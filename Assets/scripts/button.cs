using System;
using System.Collections;
using UnityEngine;
using WWUtils.Audio;
using Dweiss;

public class button : MonoBehaviour
{
    // Start is called before the first frame update
    protected AudioSource audioSource = null;
    protected Coroutine m_RecordingCoroutine = null;
    private String killerName = "Bob";
    private String innocentName = "Anna";

    private HoundCloudRequester requester;
    private RequestInfoJSON request_info = new RequestInfoJSON();
    private const int chunk_byte_size = 2500;
    private LocalPartialHandler lph = new LocalPartialHandler(true);
    private String audio_teste = "request_audio.wav";
    private int i = 0;
    private byte[] audio_bytes_to_send = new byte[chunk_byte_size];
    private RequestInfoJSON.TypeClientVersion client_version = new RequestInfoJSON.TypeClientVersion();
    private HoundServerJSON hound_result;
    private int number_of_chunks;
    private int rest;
    private byte[] remaining_audio_bytes;
    private byte[] bytes;
    private CommandResultJSON my_answer;
    private byte[] audio_stream;
    private string bytes_audio;
    private HoundRequester.VoiceRequest request;
    private String male_voice = "Richard";
    private String female_voice = "Sarah";
    int lastPos, pos;
    AudioClip m_clip;
    bool sending = false;
    // We need to create this object so we can get different answers to the same question
    // Each page will work like a character, so if we are asking Bob, it will hit only
    // the Bob corresponding page, that will respond "Yes I killed that guy" to the "Did you kill that guy question"
    StoredPageMatchPageListJSON character_pages = new StoredPageMatchPageListJSON();
    AudioClip wav_clip;
    int diff;
    AudioClip audioClip;
    WAV wav;

    bool stopRecording = false;
    
    void Start()
    {
        requester = new HoundCloudRequester(Settings.Instance.clientId, Settings.Instance.clientKey, Settings.Instance.userId);

        audioSource = GetComponent<AudioSource>();
        request_info.setUnitPreference(RequestInfoJSON.TypeUnitPreference.UnitPreference_US);

        //We need to set this flag so the answers of the characters are vocalized
        request_info.setResponseAudioShortOrLong(RequestInfoJSON.stringToResponseAudioShortOrLong("Long"));

        client_version.key = 0;
        client_version.choice0 = "1.0";
        request_info.setClientVersion(client_version);

        // RequestInfoJSON class contains metadata about the current request, like session_id, request id, client_version, etc   
        request_info.setRequestID(Guid.NewGuid().ToString());
        request_info.setStoredGlobalPagesToMatch(character_pages);
    }

    public void OnPointerDown()
    {
        Debug.Log("pointerHold");
        GameObject.Find("Button Speak").GetComponentInChildren<UnityEngine.UI.Text>().text = "Listening";
        StartCoroutine("Record");
    }

    public void OnPointerUp()
    {
        Debug.Log("pointerRelease");
    }

    IEnumerator Record()
    {

        character_pages.initValue();

        if (blame.guilt == killerName)
        {
            character_pages.appendValue(killerName);

            //We are setting a male voice to this response
            request_info.setResponseAudioVoice("Richard");

        }

        //In this conditional we will hit only the page corresponding to the character "Anna",
        //that will respond "No, I didn't kill that guy" to the "Did you kill that guy" question
        else
        {
            character_pages.appendValue(innocentName);

            //We are setting a female voice to this response
            request_info.setResponseAudioVoice("Sarah");
        }

        m_clip = Microphone.Start(Microphone.devices[0], true, 1000, 16000);
        lastPos = 0;

        // Create a HoundRequester.VoiceRequest object
        lph.bt = this;
        request = requester.start_voice_request(null, request_info, lph);

        sending = true;
        stopRecording = false;
        while (Microphone.IsRecording(Microphone.devices[0]))
        {
            yield return null;
        }
        sending = false;

        hound_result = request.finish();

        Debug.Log("stopped!");

        //StringWriter txt = new StringWriter();
        //JSONStreamWriter h = new JSONStreamWriter(txt);
        //hound_result.write_as_json(h);
        //Debug.Log(txt.GetStringBuilder().ToString());

        ////play the clip back
        if (hound_result.getAllResults().Count > 0)
        {
            wav = new WAV(System.Convert.FromBase64String(hound_result.getAllResults()[0].getResponseAudioBytes()));
            audioClip = AudioClip.Create("testSound", wav.SampleCount, 1, wav.Frequency, false, false);
            audioClip.SetData(wav.LeftChannel, 0);
            audioSource.clip = audioClip;
            audioSource.Play();
        } else
        {
            Debug.Log("NO RESULT - ERROR FROM HOUNDIFY");
        }
    }

    void Update()
    {   
        if (sending)
        {
            if (stopRecording)
            {
                Microphone.End(Microphone.devices[0]);
                GameObject.Find("Button Speak").GetComponentInChildren<UnityEngine.UI.Text>().text = "Ask";
            }
            else
            {
                pos = Microphone.GetPosition(null);
                diff = pos - lastPos;
                if (diff > 0)
                {
                    float[] samples = new float[diff * m_clip.channels];
                    m_clip.GetData(samples, lastPos);
                    wav_clip = AudioClip.Create("", samples.Length, m_clip.channels, 16000, true, false);
                    wav_clip.SetData(samples, 0);
                    if (lastPos == 0)
                    {
                        audio_stream = WavUtility.FromAudioClip(wav_clip, out audio_teste, true);
                    }
                    else
                    {
                        audio_stream = WavUtility.ConvertToByteArray(wav_clip);
                    }
                    request.add_audio(audio_stream.Length, audio_stream);
                    lastPos = pos;
                }
            }
        }
    }

    class LocalPartialHandler : HoundRequester.PartialHandler
    {
        private bool show_transcript;
        public button bt;
        public LocalPartialHandler(bool init_show_transcript)
        {
            show_transcript = init_show_transcript;
        }

        // The handle method is called whenever a partial transcript is received by the client
        public override void handle(HoundPartialTranscriptJSON partial)
        {
            if (show_transcript)
            {
                Debug.Log(partial.getPartialTranscript());

                if (partial.getSafeToStopAudio())
                {
                    bt.stopRecording = true;
                }
            }
        }
    }

}