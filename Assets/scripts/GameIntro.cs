using UnityEngine;
using System;
using WWUtils.Audio;
using System.Globalization;
using Dweiss;

public class GameIntro : MonoBehaviour
{
    // Start is called before the first frame update

    protected AudioSource audioSource = null;
    protected Coroutine m_RecordingCoroutine = null;

    void Start()
    {

        // This is a workaround for the game to work on a system that's not on English
        System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        HoundCloudRequester requester = new HoundCloudRequester(Settings.Instance.clientId, Settings.Instance.clientKey, Settings.Instance.userId);

        RequestInfoJSON.TypeClientVersion client_version = new RequestInfoJSON.TypeClientVersion();
        client_version.key = 0;
        client_version.choice0 = "1.0";

        // RequestInfoJSON class contains metadata about the current request, like session_id, request id, client_version, etc
        RequestInfoJSON request_info = new RequestInfoJSON();
        request_info.setUnitPreference(RequestInfoJSON.TypeUnitPreference.UnitPreference_US);
        request_info.setRequestID(Guid.NewGuid().ToString());
        request_info.setClientVersion(client_version);


        // We need these to lines to get the vocalized intro of the game. The parameter Claire sets the voice type
        // and we need to set the ResponseAudioShortOrLong field to tell the API we want it to vocalize the answer
        request_info.setResponseAudioVoice("Claire");
        request_info.setResponseAudioShortOrLong(RequestInfoJSON.stringToResponseAudioShortOrLong("Long"));

        // The HoundServerJSON class is used to handle all server responses
        HoundServerJSON hound_result;
        hound_result = requester.do_text_request("speak_this", null, request_info);
        CommandResultJSON my_answer = hound_result.getAllResults()[0];
        string bytes_audio = my_answer.getResponseAudioBytes();
        byte[] bytes = System.Convert.FromBase64String(bytes_audio);

        // Play the clip back
        audioSource = GetComponent<AudioSource>();

        Debug.Log("Intro started...");

        WAV wav = new WAV(bytes);
        AudioClip audioClip = AudioClip.Create("testSound", wav.SampleCount, 1, wav.Frequency, false, false);
        audioClip.SetData(wav.LeftChannel, 0);
        audioSource.clip = audioClip;
        audioSource.Play();

        Debug.Log("Intro finished!");

    }

    // Update is called once per frame
    void Update()
    {

    }
}
