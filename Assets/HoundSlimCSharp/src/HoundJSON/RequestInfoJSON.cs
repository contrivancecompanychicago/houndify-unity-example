/* file "RequestInfoJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class RequestInfoJSON : JSONBase
  {
    public enum TypeUnitPreference
      {
        UnitPreference_US,
        UnitPreference_METRIC
      };

    public static TypeUnitPreference  stringToUnitPreference(string chars)
      {
        switch (chars[0])
          {
            case 'M':
                if ((String.Compare(chars, 1, "ETRIC", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeUnitPreference.UnitPreference_METRIC;
                break;
            case 'U':
                if ((String.Compare(chars, 1, "S", 0, 1, false) == 0) && (chars.Length == 2))
                    return TypeUnitPreference.UnitPreference_US;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `UnitPreference' is not one of the legal values.");
      }

    public static string  stringFromUnitPreference(TypeUnitPreference the_enum)
      {
        switch (the_enum)
          {
            case TypeUnitPreference.UnitPreference_US:
                return "US";
            case TypeUnitPreference.UnitPreference_METRIC:
                return "METRIC";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public struct TypeClientVersion
      {
        public int key;
        public string choice0;
        public BigInteger choice1;
      };
    public enum TypeProfanityFilter
      {
        ProfanityFilter_AllowAll,
        ProfanityFilter_StarOne,
        ProfanityFilter_StarAllButFirst,
        ProfanityFilter_StarAll,
        ProfanityFilter_DontRecognize
      };

    public static TypeProfanityFilter  stringToProfanityFilter(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "llowAll", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeProfanityFilter.ProfanityFilter_AllowAll;
                break;
            case 'D':
                if ((String.Compare(chars, 1, "ontRecognize", 0, 12, false) == 0) && (chars.Length == 13))
                    return TypeProfanityFilter.ProfanityFilter_DontRecognize;
                break;
            case 'S':
                if (String.Compare(chars, 1, "tar", 0, 3, false) == 0)
                  {
                    switch (chars[4])
                      {
                        case 'A':
                            if (String.Compare(chars, 5, "ll", 0, 2, false) == 0)
                              {
                                if (chars.Length == 7)
                                  {
                                    return TypeProfanityFilter.ProfanityFilter_StarAll;
                                  }
                                switch (chars[7])
                                  {
                                    case 'B':
                                        if ((String.Compare(chars, 8, "utFirst", 0, 7, false) == 0) && (chars.Length == 15))
                                            return TypeProfanityFilter.ProfanityFilter_StarAllButFirst;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'O':
                            if ((String.Compare(chars, 5, "ne", 0, 2, false) == 0) && (chars.Length == 7))
                                return TypeProfanityFilter.ProfanityFilter_StarOne;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        throw new Exception("The value for field `ProfanityFilter' is not one of the legal values.");
      }

    public static string  stringFromProfanityFilter(TypeProfanityFilter the_enum)
      {
        switch (the_enum)
          {
            case TypeProfanityFilter.ProfanityFilter_AllowAll:
                return "AllowAll";
            case TypeProfanityFilter.ProfanityFilter_StarOne:
                return "StarOne";
            case TypeProfanityFilter.ProfanityFilter_StarAllButFirst:
                return "StarAllButFirst";
            case TypeProfanityFilter.ProfanityFilter_StarAll:
                return "StarAll";
            case TypeProfanityFilter.ProfanityFilter_DontRecognize:
                return "DontRecognize";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeResponseAudioShortOrLong
      {
        ResponseAudioShortOrLong_Short,
        ResponseAudioShortOrLong_Long
      };

    public static TypeResponseAudioShortOrLong  stringToResponseAudioShortOrLong(string chars)
      {
        switch (chars[0])
          {
            case 'L':
                if ((String.Compare(chars, 1, "ong", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeResponseAudioShortOrLong.ResponseAudioShortOrLong_Long;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "hort", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeResponseAudioShortOrLong.ResponseAudioShortOrLong_Short;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `ResponseAudioShortOrLong' is not one of the legal values.");
      }

    public static string  stringFromResponseAudioShortOrLong(TypeResponseAudioShortOrLong the_enum)
      {
        switch (the_enum)
          {
            case TypeResponseAudioShortOrLong.ResponseAudioShortOrLong_Short:
                return "Short";
            case TypeResponseAudioShortOrLong.ResponseAudioShortOrLong_Long:
                return "Long";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeResponseAudioAcceptedEncodingsKnownValues
      {
        ResponseAudioAcceptedEncodings_WAV,
        ResponseAudioAcceptedEncodings_Speex,
        ResponseAudioAcceptedEncodings__none
      };
    public struct TypeResponseAudioAcceptedEncodings
      {
        public bool in_known_list;
        public string string_value;
        public TypeResponseAudioAcceptedEncodingsKnownValues list_value;
      };

    public static TypeResponseAudioAcceptedEncodingsKnownValues  stringToResponseAudioAcceptedEncodings(string chars)
      {
        switch (chars[0])
          {
            case 'S':
                if ((String.Compare(chars, 1, "peex", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeResponseAudioAcceptedEncodingsKnownValues.ResponseAudioAcceptedEncodings_Speex;
                break;
            case 'W':
                if ((String.Compare(chars, 1, "AV", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeResponseAudioAcceptedEncodingsKnownValues.ResponseAudioAcceptedEncodings_WAV;
                break;
            default:
                break;
          }
        return TypeResponseAudioAcceptedEncodingsKnownValues.ResponseAudioAcceptedEncodings__none;
      }

    public static string  stringFromResponseAudioAcceptedEncodings(TypeResponseAudioAcceptedEncodingsKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeResponseAudioAcceptedEncodingsKnownValues.ResponseAudioAcceptedEncodings_WAV:
                return "WAV";
            case TypeResponseAudioAcceptedEncodingsKnownValues.ResponseAudioAcceptedEncodings_Speex:
                return "Speex";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasLatitude;
    private double storeLatitude;
    private string textStoreLatitude;
    private bool flagHasLongitude;
    private double storeLongitude;
    private string textStoreLongitude;
    private bool flagHasPositionTime;
    private BigInteger storePositionTime;
    private bool flagHasPositionHorizontalAccuracy;
    private double storePositionHorizontalAccuracy;
    private string textStorePositionHorizontalAccuracy;
    private bool flagHasStreet;
    private string storeStreet;
    private bool flagHasCity;
    private string storeCity;
    private bool flagHasState;
    private string storeState;
    private bool flagHasCountry;
    private string storeCountry;
    private bool flagHasRoutePoints;
    private RoutePointsJSON  storeRoutePoints;
    private bool flagHasControllableTrackPlaying;
    private bool storeControllableTrackPlaying;
    private bool flagHasTimeStamp;
    private BigInteger storeTimeStamp;
    private bool flagHasTimeZone;
    private string storeTimeZone;
    private bool flagHasConversationState;
    private ConversationStateJSON  storeConversationState;
    private bool flagHasClientState;
    private ClientStateJSON  storeClientState;
    private bool flagHasSendBack;
    private JSONValue  storeSendBack;
    private bool flagHasPreferredImageSize;
    private List< BigInteger > storePreferredImageSize;
    private bool flagHasInputLanguageEnglishName;
    private string storeInputLanguageEnglishName;
    private bool flagHasInputLanguageNativeName;
    private string storeInputLanguageNativeName;
    private bool flagHasInputLanguageIETFTag;
    private string storeInputLanguageIETFTag;
    private bool flagHasOutputLanguageEnglishName;
    private string storeOutputLanguageEnglishName;
    private bool flagHasOutputLanguageNativeName;
    private string storeOutputLanguageNativeName;
    private bool flagHasOutputLanguageIETFTag;
    private string storeOutputLanguageIETFTag;
    private bool flagHasResultVersionAccepted;
    private double storeResultVersionAccepted;
    private string textStoreResultVersionAccepted;
    private bool flagHasUnitPreference;
    private TypeUnitPreference storeUnitPreference;
    private bool flagHasDefaultTimeFormat24Hours;
    private bool storeDefaultTimeFormat24Hours;
    private bool flagHasClientID;
    private string storeClientID;
    private bool flagHasClientVersion;
    private TypeClientVersion storeClientVersion;
    private bool flagHasDeviceID;
    private string storeDeviceID;
    private bool flagHasSDK;
    private string storeSDK;
    private bool flagHasSDKInfo;
    private JSONObjectValue  storeSDKInfo;
    private bool flagHasFirstPersonSelf;
    private string storeFirstPersonSelf;
    private bool flagHasFirstPersonSelfSpoken;
    private string storeFirstPersonSelfSpoken;
    private bool flagHasSecondPersonSelf;
    private List< string > storeSecondPersonSelf;
    private bool flagHasSecondPersonSelfSpoken;
    private List< string > storeSecondPersonSelfSpoken;
    private bool flagHasWakeUpPattern;
    private string storeWakeUpPattern;
    private bool flagHasUserID;
    private string storeUserID;
    private bool flagHasRequestID;
    private string storeRequestID;
    private bool flagHasSessionID;
    private string storeSessionID;
    private bool flagHasDomains;
    private DomainsJSON  storeDomains;
    private bool flagHasResultUpdateAllowed;
    private bool storeResultUpdateAllowed;
    private bool flagHasPartialTranscriptsDesired;
    private bool storePartialTranscriptsDesired;
    private bool flagHasMinResults;
    private BigInteger storeMinResults;
    private bool flagHasMaxResults;
    private BigInteger storeMaxResults;
    private bool flagHasObjectByteCountPrefix;
    private bool storeObjectByteCountPrefix;
    private bool flagHasProfanityFilter;
    private TypeProfanityFilter storeProfanityFilter;
    private bool flagHasClientMatches;
    private List< ClientMatchJSON  > storeClientMatches;
    private bool flagHasClientMatchesOnly;
    private bool storeClientMatchesOnly;
    private bool flagHasPagination;
    private PaginationJSON  storePagination;
    private bool flagHasResponseAudioVoice;
    private string storeResponseAudioVoice;
    private bool flagHasResponseAudioShortOrLong;
    private TypeResponseAudioShortOrLong storeResponseAudioShortOrLong;
    private bool flagHasResponseAudioAcceptedEncodings;
    private List< TypeResponseAudioAcceptedEncodings > storeResponseAudioAcceptedEncodings;
    private bool flagHasVoiceActivityDetection;
    private VoiceActivityDetectionJSON  storeVoiceActivityDetection;
    private bool flagHasServerDeterminesEndOfAudio;
    private bool storeServerDeterminesEndOfAudio;
    private bool flagHasIntentOnly;
    private bool storeIntentOnly;
    private bool flagHasDisableSpellCorrection;
    private bool storeDisableSpellCorrection;
    private bool flagHasUseContactData;
    private bool storeUseContactData;
    private bool flagHasUseClientTime;
    private bool storeUseClientTime;
    private bool flagHasForceConversationStateTime;
    private BigInteger storeForceConversationStateTime;
    private bool flagHasPhoneDisambiguationOmitList;
    private PhoneDisambiguationOmitListJSON  storePhoneDisambiguationOmitList;
    private bool flagHasIncomingCallPending;
    private IncomingCallPendingJSON  storeIncomingCallPending;
    private bool flagHasAllowPopularNameContactMatches;
    private AllowPopularNameContactMatchesJSON  storeAllowPopularNameContactMatches;
    private bool flagHasMusicClientState;
    private MusicClientStateJSON  storeMusicClientState;
    private bool flagHasDisableMusicSearchListPositionSpecification;
    private DisableListPositionSpecificationJSON  storeDisableMusicSearchListPositionSpecification;
    private bool flagHasCollateMusicEntities;
    private CollateMusicEntitiesJSON  storeCollateMusicEntities;
    private bool flagHasAllowContextFreeMusicSearchForPopularEntities;
    private AllowContextFreeMusicSearchForPopularEntitiesJSON  storeAllowContextFreeMusicSearchForPopularEntities;
    private bool flagHasReturnInformationNuggetsForMusicSearch;
    private ReturnInformationNuggetsForMusicSearchJSON  storeReturnInformationNuggetsForMusicSearch;
    private bool flagHasUseXAPAPI;
    private RequestInfoBooleanFlagJSON  storeUseXAPAPI;
    private bool flagHasLocalSearchClientState;
    private LocalSearchClientStateJSON  storeLocalSearchClientState;
    private bool flagHasUberServerToken;
    private UberServerTokenJSON  storeUberServerToken;
    private bool flagHasGetUberServerToken;
    private GetUberServerTokenJSON  storeGetUberServerToken;
    private bool flagHasUberClientId;
    private UberClientIdJSON  storeUberClientId;
    private bool flagHasGetUberClientId;
    private GetUberClientIdJSON  storeGetUberClientId;
    private bool flagHasSetUserMemoryLocation;
    private SetUserMemoryLocationJSON  storeSetUserMemoryLocation;
    private bool flagHasDisableMusicPlayerListPositionSpecification;
    private DisableListPositionSpecificationJSON  storeDisableMusicPlayerListPositionSpecification;
    private bool flagHasCarControlClimateClientConfiguration;
    private CarControlClimateClientConfigurationJSON  storeCarControlClimateClientConfiguration;
    private bool flagHasHomeAutomationDomainSettings;
    private HomeAutomationDomainSettingsJSON  storeHomeAutomationDomainSettings;
    private bool flagHasUserContactsRequests;
    private UserContactsRequestsJSON  storeUserContactsRequests;
    private bool flagHasStoredGlobalPagesToMatch;
    private StoredPageMatchPageListJSON  storeStoredGlobalPagesToMatch;
    private bool flagHasStoredGlobalPagesToNotMatch;
    private StoredPageMatchPageListJSON  storeStoredGlobalPagesToNotMatch;
    private bool flagHasStoredPerUserPagesToMatch;
    private StoredPageMatchPageListJSON  storeStoredPerUserPagesToMatch;
    private bool flagHasStoredPerUserPagesToNotMatch;
    private StoredPageMatchPageListJSON  storeStoredPerUserPagesToNotMatch;
    private bool flagHasStoredGlobalPagesToSetOnByDefault;
    private StoredPageMatchPageListJSON  storeStoredGlobalPagesToSetOnByDefault;
    private bool flagHasStoredPerUserPagesToSetOnByDefault;
    private StoredPageMatchPageListJSON  storeStoredPerUserPagesToSetOnByDefault;
    private bool flagHasStoredGlobalPagesToSetOffByDefault;
    private StoredPageMatchPageListJSON  storeStoredGlobalPagesToSetOffByDefault;
    private bool flagHasStoredPerUserPagesToSetOffByDefault;
    private StoredPageMatchPageListJSON  storeStoredPerUserPagesToSetOffByDefault;
    private bool flagHasStoredPageMatchWriteData;
    private StoredPageMatchWriteDataJSON  storeStoredPageMatchWriteData;
    private bool flagHasStoredPageMatchReadData;
    private StoredPageMatchReadDataJSON  storeStoredPageMatchReadData;
    private bool flagHasStoredPageMatchPageListData;
    private StoredPageMatchPageListDataJSON  storeStoredPageMatchPageListData;
    private bool flagHasVoiceParameters;
    private VoiceParametersJSON  storeVoiceParameters;
    private bool flagHasStoredAlwaysMatchWriteData;
    private ClientMatchesJSON  storeStoredAlwaysMatchWriteData;
    private bool flagHasStoredAlwaysMatchReadData;
    private StoredAlwaysMatchReadDataJSON  storeStoredAlwaysMatchReadData;
    private bool flagHasUserFeedback;
    private UserFeedbackJSON  storeUserFeedback;
    private bool flagHasRadioControlRecognizeNorthAmericanFMBand;
    private RadioControlRecognizeNorthAmericanFMBandJSON  storeRadioControlRecognizeNorthAmericanFMBand;
    private bool flagHasRadioControlRecognizeNorthAmericanAMBand;
    private RadioControlRecognizeNorthAmericanAMBandJSON  storeRadioControlRecognizeNorthAmericanAMBand;
    private bool flagHasRadioControlOtherFMBands;
    private RadioControlOtherFMBandsJSON  storeRadioControlOtherFMBands;
    private bool flagHasRadioControlOtherAMBands;
    private RadioControlOtherAMBandsJSON  storeRadioControlOtherAMBands;
    private bool flagHasRadioControlAvailableAudioSources;
    private RadioControlAvailableAudioSourcesJSON  storeRadioControlAvailableAudioSources;
    private bool flagHasClientListMatches;
    private ClientListMatchesJSON  storeClientListMatches;
    private bool flagHasIntentToExecute;
    private CommandIntentJSON  storeIntentToExecute;
    private bool flagHasRobotInfo;
    private RobotInfoJSON  storeRobotInfo;
    private bool flagHasConvertToNewInformationNuggets;
    private ConvertToNewInformationNuggetsJSON  storeConvertToNewInformationNuggets;
    private bool flagHasAcapelaVoiceParameters;
    private AcapelaVoiceParametersJSON  storeAcapelaVoiceParameters;
    private bool flagHasOutputOverrideCommandIsPreAudioOut;
    private RequestInfoBooleanFlagJSON  storeOutputOverrideCommandIsPreAudioOut;
    private bool flagHasOutputOverrideCommandFunction;
    private OutputOverrideFunctionJSON  storeOutputOverrideCommandFunction;
    private bool flagHasOutputOverrideCommandFunctionLanguage;
    private UploadedCodeFunctionLanguageJSON  storeOutputOverrideCommandFunctionLanguage;
    private bool flagHasOutputOverrideCommandFunctionSource;
    private UploadedCodeSourceJSON  storeOutputOverrideCommandFunctionSource;
    private bool flagHasOutputOverrideDeleteCommandFunction;
    private RequestInfoBooleanFlagJSON  storeOutputOverrideDeleteCommandFunction;
    private bool flagHasOutputOverrideReadCommandFunction;
    private RequestInfoBooleanFlagJSON  storeOutputOverrideReadCommandFunction;
    private bool flagHasOutputOverrideInformationNuggetFunction;
    private OutputOverrideFunctionJSON  storeOutputOverrideInformationNuggetFunction;
    private bool flagHasOutputOverrideInformationNuggetFunctionLanguage;
    private UploadedCodeFunctionLanguageJSON  storeOutputOverrideInformationNuggetFunctionLanguage;
    private bool flagHasOutputOverrideInformationNuggetFunctionSource;
    private UploadedCodeSourceJSON  storeOutputOverrideInformationNuggetFunctionSource;
    private bool flagHasOutputOverrideDeleteInformationNuggetFunction;
    private RequestInfoBooleanFlagJSON  storeOutputOverrideDeleteInformationNuggetFunction;
    private bool flagHasOutputOverrideReadInformationNuggetFunction;
    private RequestInfoBooleanFlagJSON  storeOutputOverrideReadInformationNuggetFunction;
    private bool flagHasTerrierUploadWriteData;
    private TerrierUploadWriteDataJSON  storeTerrierUploadWriteData;
    private bool flagHasTerrierUploadReadData;
    private TerrierUploadReadDataJSON  storeTerrierUploadReadData;
    private bool flagHasDisambiguateResultsBeforeAction;
    private DisambiguateResultsBeforeActionJSON  storeDisambiguateResultsBeforeAction;
    private bool flagHasInputOverrideFunction;
    private InputOverrideFunctionJSON  storeInputOverrideFunction;
    private bool flagHasInputOverrideFunctionLanguage;
    private UploadedCodeFunctionLanguageJSON  storeInputOverrideFunctionLanguage;
    private bool flagHasInputOverrideFunctionSource;
    private UploadedCodeSourceJSON  storeInputOverrideFunctionSource;
    private bool flagHasInputOverrideDeleteFunction;
    private RequestInfoBooleanFlagJSON  storeInputOverrideDeleteFunction;
    private bool flagHasInputOverrideReadFunction;
    private RequestInfoBooleanFlagJSON  storeInputOverrideReadFunction;
    private bool flagHasSportsLeagueControl;
    private SportsLeagueControlJSON  storeSportsLeagueControl;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONLatitude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field Latitude of RequestInfoJSON is not a number.");
              }
          }
        setLatitudeText(the_rational_text);
      }


    private void  fromJSONLongitude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field Longitude of RequestInfoJSON is not a number.");
              }
          }
        setLongitudeText(the_rational_text);
      }


    private void  fromJSONPositionTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field PositionTime of RequestInfoJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field PositionTime of RequestInfoJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setPositionTime(extracted_integer);
      }


    private void  fromJSONPositionHorizontalAccuracy(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field PositionHorizontalAccuracy of RequestInfoJSON is not a number.");
              }
          }
        setPositionHorizontalAccuracyText(the_rational_text);
      }


    private void  fromJSONStreet(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Street of RequestInfoJSON is not a string.");
        setStreet(json_string.getData());
      }


    private void  fromJSONCity(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field City of RequestInfoJSON is not a string.");
        setCity(json_string.getData());
      }


    private void  fromJSONState(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field State of RequestInfoJSON is not a string.");
        setState(json_string.getData());
      }


    private void  fromJSONCountry(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Country of RequestInfoJSON is not a string.");
        setCountry(json_string.getData());
      }


    private void  fromJSONRoutePoints(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RoutePointsJSON convert_classy = RoutePointsJSON.from_json(json_value, ignore_extras, true);
        setRoutePoints(convert_classy);
      }


    private void  fromJSONControllableTrackPlaying(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field ControllableTrackPlaying of RequestInfoJSON is not true for false.");
              }
          }
        setControllableTrackPlaying(the_bool);
      }


    private void  fromJSONTimeStamp(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field TimeStamp of RequestInfoJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field TimeStamp of RequestInfoJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setTimeStamp(extracted_integer);
      }


    private void  fromJSONTimeZone(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TimeZone of RequestInfoJSON is not a string.");
        setTimeZone(json_string.getData());
      }


    private void  fromJSONConversationState(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ConversationStateJSON convert_classy = ConversationStateJSON.from_json(json_value, ignore_extras, true);
        setConversationState(convert_classy);
      }


    private void  fromJSONClientState(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ClientStateJSON convert_classy = ClientStateJSON.from_json(json_value, ignore_extras, true);
        setClientState(convert_classy);
      }


    private void  fromJSONSendBack(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        setSendBack(json_value);
      }


    private void  fromJSONPreferredImageSize(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field PreferredImageSize of RequestInfoJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 2)
            throw new Exception("The value for field PreferredImageSize of RequestInfoJSON has too few elements.");
        List< BigInteger > vector_PreferredImageSize1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field PreferredImageSize of RequestInfoJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field PreferredImageSize of RequestInfoJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_PreferredImageSize1.Add(extracted_integer);
          }
        Debug.Assert(vector_PreferredImageSize1.Count >= 2);
        initPreferredImageSize();
        for (int num1 = 0; num1 < vector_PreferredImageSize1.Count; ++num1)
            appendPreferredImageSize(vector_PreferredImageSize1[num1]);
        for (int num1 = 0; num1 < vector_PreferredImageSize1.Count; ++num1)
          {
          }
      }


    private void  fromJSONInputLanguageEnglishName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field InputLanguageEnglishName of RequestInfoJSON is not a string.");
        setInputLanguageEnglishName(json_string.getData());
      }


    private void  fromJSONInputLanguageNativeName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field InputLanguageNativeName of RequestInfoJSON is not a string.");
        setInputLanguageNativeName(json_string.getData());
      }


    private void  fromJSONInputLanguageIETFTag(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field InputLanguageIETFTag of RequestInfoJSON is not a string.");
        setInputLanguageIETFTag(json_string.getData());
      }


    private void  fromJSONOutputLanguageEnglishName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field OutputLanguageEnglishName of RequestInfoJSON is not a string.");
        setOutputLanguageEnglishName(json_string.getData());
      }


    private void  fromJSONOutputLanguageNativeName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field OutputLanguageNativeName of RequestInfoJSON is not a string.");
        setOutputLanguageNativeName(json_string.getData());
      }


    private void  fromJSONOutputLanguageIETFTag(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field OutputLanguageIETFTag of RequestInfoJSON is not a string.");
        setOutputLanguageIETFTag(json_string.getData());
      }


    private void  fromJSONResultVersionAccepted(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field ResultVersionAccepted of RequestInfoJSON is not a number.");
              }
          }
        setResultVersionAcceptedText(the_rational_text);
      }


    private void  fromJSONUnitPreference(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field UnitPreference of RequestInfoJSON is not a string.");
        TypeUnitPreference the_enum;
        switch (json_string.getData()[0])
          {
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "ETRIC", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_enum = TypeUnitPreference.UnitPreference_METRIC;
                        goto enum_is_done;
                      }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "S", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                      {
                        the_enum = TypeUnitPreference.UnitPreference_US;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field UnitPreference of RequestInfoJSON is not one of the legal strings.");
      enum_is_done:;
        setUnitPreference(the_enum);
      }


    private void  fromJSONDefaultTimeFormat24Hours(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field DefaultTimeFormat24Hours of RequestInfoJSON is not true for false.");
              }
          }
        setDefaultTimeFormat24Hours(the_bool);
      }


    private void  fromJSONClientID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ClientID of RequestInfoJSON is not a string.");
        setClientID(json_string.getData());
      }


    private void  fromJSONClientVersion(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeClientVersion or_result = new TypeClientVersion();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for ??? is not a string.");
                or_result.choice0 = json_string.getData();
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                BigInteger extracted_integer;
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer == null)
                  {
                    JSONRationalValue json_rational = json_value.rational_value();
                    if (json_rational == null)
                      {
                        throw new Exception("The value for ??? is not a number.");
                      }
                    if (!(json_rational.isInteger()))
                      {
                        throw new Exception("The value for ??? is not an integer.");
                      }
                    extracted_integer = json_rational.getInteger()                ;
                  }
                else
                  {
                    extracted_integer = json_integer.getData()                ;
                  }
                if (extracted_integer < 0)
                    throw new Exception("The value for ??? is less than the lower bound (0) for that field.");
                or_result.choice1 = extracted_integer;
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field ClientVersion of RequestInfoJSON is not one of the allowed values.");
        setClientVersion(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONDeviceID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DeviceID of RequestInfoJSON is not a string.");
        setDeviceID(json_string.getData());
      }


    private void  fromJSONSDK(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SDK of RequestInfoJSON is not a string.");
        setSDK(json_string.getData());
      }


    private void  fromJSONSDKInfo(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        if (json_value.object_value() == null)
            throw new Exception("The value for field SDKInfo of RequestInfoJSON is not an object.");
        setSDKInfo(json_value.object_value());
      }


    private void  fromJSONFirstPersonSelf(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FirstPersonSelf of RequestInfoJSON is not a string.");
        setFirstPersonSelf(json_string.getData());
      }


    private void  fromJSONFirstPersonSelfSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FirstPersonSelfSpoken of RequestInfoJSON is not a string.");
        setFirstPersonSelfSpoken(json_string.getData());
      }


    private void  fromJSONSecondPersonSelf(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SecondPersonSelf of RequestInfoJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_SecondPersonSelf1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field SecondPersonSelf of RequestInfoJSON is not a string.");
            vector_SecondPersonSelf1.Add(json_string.getData());
          }
        initSecondPersonSelf();
        for (int num2 = 0; num2 < vector_SecondPersonSelf1.Count; ++num2)
            appendSecondPersonSelf(vector_SecondPersonSelf1[num2]);
        for (int num1 = 0; num1 < vector_SecondPersonSelf1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSecondPersonSelfSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SecondPersonSelfSpoken of RequestInfoJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_SecondPersonSelfSpoken1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field SecondPersonSelfSpoken of RequestInfoJSON is not a string.");
            vector_SecondPersonSelfSpoken1.Add(json_string.getData());
          }
        initSecondPersonSelfSpoken();
        for (int num3 = 0; num3 < vector_SecondPersonSelfSpoken1.Count; ++num3)
            appendSecondPersonSelfSpoken(vector_SecondPersonSelfSpoken1[num3]);
        for (int num1 = 0; num1 < vector_SecondPersonSelfSpoken1.Count; ++num1)
          {
          }
      }


    private void  fromJSONWakeUpPattern(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WakeUpPattern of RequestInfoJSON is not a string.");
        setWakeUpPattern(json_string.getData());
      }


    private void  fromJSONUserID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field UserID of RequestInfoJSON is not a string.");
        setUserID(json_string.getData());
      }


    private void  fromJSONRequestID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field RequestID of RequestInfoJSON is not a string.");
        setRequestID(json_string.getData());
      }


    private void  fromJSONSessionID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SessionID of RequestInfoJSON is not a string.");
        setSessionID(json_string.getData());
      }


    private void  fromJSONDomains(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DomainsJSON convert_classy = DomainsJSON.from_json(json_value, ignore_extras, true);
        setDomains(convert_classy);
      }


    private void  fromJSONResultUpdateAllowed(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field ResultUpdateAllowed of RequestInfoJSON is not true for false.");
              }
          }
        setResultUpdateAllowed(the_bool);
      }


    private void  fromJSONPartialTranscriptsDesired(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field PartialTranscriptsDesired of RequestInfoJSON is not true for false.");
              }
          }
        setPartialTranscriptsDesired(the_bool);
      }


    private void  fromJSONMinResults(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field MinResults of RequestInfoJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field MinResults of RequestInfoJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setMinResults(extracted_integer);
      }


    private void  fromJSONMaxResults(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field MaxResults of RequestInfoJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field MaxResults of RequestInfoJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setMaxResults(extracted_integer);
      }


    private void  fromJSONObjectByteCountPrefix(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field ObjectByteCountPrefix of RequestInfoJSON is not true for false.");
              }
          }
        setObjectByteCountPrefix(the_bool);
      }


    private void  fromJSONProfanityFilter(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ProfanityFilter of RequestInfoJSON is not a string.");
        TypeProfanityFilter the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "llowAll", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeProfanityFilter.ProfanityFilter_AllowAll;
                        goto enum_is_done;
                      }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "ontRecognize", 0, 12, false) == 0) && (json_string.getData().Length == 13))
                      {
                        the_enum = TypeProfanityFilter.ProfanityFilter_DontRecognize;
                        goto enum_is_done;
                      }
                break;
            case 'S':
                if (String.Compare(json_string.getData(), 1, "tar", 0, 3, false) == 0)
                  {
                    switch (json_string.getData()[4])
                      {
                        case 'A':
                            if (String.Compare(json_string.getData(), 5, "ll", 0, 2, false) == 0)
                              {
                                if (json_string.getData().Length == 7)
                                  {
                                      {
                                        the_enum = TypeProfanityFilter.ProfanityFilter_StarAll;
                                        goto enum_is_done;
                                      }
                                  }
                                switch (json_string.getData()[7])
                                  {
                                    case 'B':
                                        if ((String.Compare(json_string.getData(), 8, "utFirst", 0, 7, false) == 0) && (json_string.getData().Length == 15))
                                              {
                                                the_enum = TypeProfanityFilter.ProfanityFilter_StarAllButFirst;
                                                goto enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'O':
                            if ((String.Compare(json_string.getData(), 5, "ne", 0, 2, false) == 0) && (json_string.getData().Length == 7))
                                  {
                                    the_enum = TypeProfanityFilter.ProfanityFilter_StarOne;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        throw new Exception("The value for field ProfanityFilter of RequestInfoJSON is not one of the legal strings.");
      enum_is_done:;
        setProfanityFilter(the_enum);
      }


    private void  fromJSONClientMatches(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ClientMatches of RequestInfoJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field ClientMatches of RequestInfoJSON has too few elements.");
        List< ClientMatchJSON  > vector_ClientMatches1 = new List< ClientMatchJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            ClientMatchJSON convert_classy = ClientMatchJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_ClientMatches1.Add(convert_classy);
          }
        Debug.Assert(vector_ClientMatches1.Count >= 1);
        initClientMatches();
        for (int num4 = 0; num4 < vector_ClientMatches1.Count; ++num4)
            appendClientMatches(vector_ClientMatches1[num4]);
        for (int num1 = 0; num1 < vector_ClientMatches1.Count; ++num1)
          {
          }
      }


    private void  fromJSONClientMatchesOnly(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field ClientMatchesOnly of RequestInfoJSON is not true for false.");
              }
          }
        setClientMatchesOnly(the_bool);
      }


    private void  fromJSONPagination(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        PaginationJSON convert_classy = PaginationJSON.from_json(json_value, ignore_extras, true);
        setPagination(convert_classy);
      }


    private void  fromJSONResponseAudioVoice(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ResponseAudioVoice of RequestInfoJSON is not a string.");
        setResponseAudioVoice(json_string.getData());
      }


    private void  fromJSONResponseAudioShortOrLong(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ResponseAudioShortOrLong of RequestInfoJSON is not a string.");
        TypeResponseAudioShortOrLong the_enum;
        switch (json_string.getData()[0])
          {
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "ong", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeResponseAudioShortOrLong.ResponseAudioShortOrLong_Long;
                        goto enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "hort", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_enum = TypeResponseAudioShortOrLong.ResponseAudioShortOrLong_Short;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field ResponseAudioShortOrLong of RequestInfoJSON is not one of the legal strings.");
      enum_is_done:;
        setResponseAudioShortOrLong(the_enum);
      }


    private void  fromJSONResponseAudioAcceptedEncodings(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ResponseAudioAcceptedEncodings of RequestInfoJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field ResponseAudioAcceptedEncodings of RequestInfoJSON has too few elements.");
        List< TypeResponseAudioAcceptedEncodings > vector_ResponseAudioAcceptedEncodings1 = new List< TypeResponseAudioAcceptedEncodings >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field ResponseAudioAcceptedEncodings of RequestInfoJSON is not a string.");
            TypeResponseAudioAcceptedEncodings the_open_enum = new TypeResponseAudioAcceptedEncodings();
            switch (json_string.getData()[0])
              {
                case 'S':
                    if ((String.Compare(json_string.getData(), 1, "peex", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeResponseAudioAcceptedEncodingsKnownValues.ResponseAudioAcceptedEncodings_Speex;
                            goto open_enum_is_done;
                          }
                    break;
                case 'W':
                    if ((String.Compare(json_string.getData(), 1, "AV", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeResponseAudioAcceptedEncodingsKnownValues.ResponseAudioAcceptedEncodings_WAV;
                            goto open_enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            vector_ResponseAudioAcceptedEncodings1.Add(the_open_enum);
          }
        Debug.Assert(vector_ResponseAudioAcceptedEncodings1.Count >= 1);
        initResponseAudioAcceptedEncodings();
        for (int num5 = 0; num5 < vector_ResponseAudioAcceptedEncodings1.Count; ++num5)
            appendResponseAudioAcceptedEncodings(vector_ResponseAudioAcceptedEncodings1[num5]);
        for (int num1 = 0; num1 < vector_ResponseAudioAcceptedEncodings1.Count; ++num1)
          {
          }
      }


    private void  fromJSONVoiceActivityDetection(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        VoiceActivityDetectionJSON convert_classy = VoiceActivityDetectionJSON.from_json(json_value, ignore_extras, true);
        setVoiceActivityDetection(convert_classy);
      }


    private void  fromJSONServerDeterminesEndOfAudio(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field ServerDeterminesEndOfAudio of RequestInfoJSON is not true for false.");
              }
          }
        setServerDeterminesEndOfAudio(the_bool);
      }


    private void  fromJSONIntentOnly(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field IntentOnly of RequestInfoJSON is not true for false.");
              }
          }
        setIntentOnly(the_bool);
      }


    private void  fromJSONDisableSpellCorrection(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field DisableSpellCorrection of RequestInfoJSON is not true for false.");
              }
          }
        setDisableSpellCorrection(the_bool);
      }


    private void  fromJSONUseContactData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field UseContactData of RequestInfoJSON is not true for false.");
              }
          }
        setUseContactData(the_bool);
      }


    private void  fromJSONUseClientTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field UseClientTime of RequestInfoJSON is not true for false.");
              }
          }
        setUseClientTime(the_bool);
      }


    private void  fromJSONForceConversationStateTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ForceConversationStateTime of RequestInfoJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ForceConversationStateTime of RequestInfoJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setForceConversationStateTime(extracted_integer);
      }


    private void  fromJSONPhoneDisambiguationOmitList(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        PhoneDisambiguationOmitListJSON convert_classy = PhoneDisambiguationOmitListJSON.from_json(json_value, ignore_extras, true);
        setPhoneDisambiguationOmitList(convert_classy);
      }


    private void  fromJSONIncomingCallPending(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        IncomingCallPendingJSON convert_classy = IncomingCallPendingJSON.from_json(json_value, ignore_extras, true);
        setIncomingCallPending(convert_classy);
      }


    private void  fromJSONAllowPopularNameContactMatches(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AllowPopularNameContactMatchesJSON convert_classy = AllowPopularNameContactMatchesJSON.from_json(json_value, ignore_extras, true);
        setAllowPopularNameContactMatches(convert_classy);
      }


    private void  fromJSONMusicClientState(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MusicClientStateJSON convert_classy = MusicClientStateJSON.from_json(json_value, ignore_extras, true);
        setMusicClientState(convert_classy);
      }


    private void  fromJSONDisableMusicSearchListPositionSpecification(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DisableListPositionSpecificationJSON convert_classy = DisableListPositionSpecificationJSON.from_json(json_value, ignore_extras, true);
        setDisableMusicSearchListPositionSpecification(convert_classy);
      }


    private void  fromJSONCollateMusicEntities(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CollateMusicEntitiesJSON convert_classy = CollateMusicEntitiesJSON.from_json(json_value, ignore_extras, true);
        setCollateMusicEntities(convert_classy);
      }


    private void  fromJSONAllowContextFreeMusicSearchForPopularEntities(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AllowContextFreeMusicSearchForPopularEntitiesJSON convert_classy = AllowContextFreeMusicSearchForPopularEntitiesJSON.from_json(json_value, ignore_extras, true);
        setAllowContextFreeMusicSearchForPopularEntities(convert_classy);
      }


    private void  fromJSONReturnInformationNuggetsForMusicSearch(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ReturnInformationNuggetsForMusicSearchJSON convert_classy = ReturnInformationNuggetsForMusicSearchJSON.from_json(json_value, ignore_extras, true);
        setReturnInformationNuggetsForMusicSearch(convert_classy);
      }


    private void  fromJSONUseXAPAPI(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RequestInfoBooleanFlagJSON convert_classy = RequestInfoBooleanFlagJSON.from_json(json_value, ignore_extras, true);
        setUseXAPAPI(convert_classy);
      }


    private void  fromJSONLocalSearchClientState(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        LocalSearchClientStateJSON convert_classy = LocalSearchClientStateJSON.from_json(json_value, ignore_extras, true);
        setLocalSearchClientState(convert_classy);
      }


    private void  fromJSONUberServerToken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UberServerTokenJSON convert_classy = UberServerTokenJSON.from_json(json_value, ignore_extras, true);
        setUberServerToken(convert_classy);
      }


    private void  fromJSONGetUberServerToken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        GetUberServerTokenJSON convert_classy = GetUberServerTokenJSON.from_json(json_value, ignore_extras, true);
        setGetUberServerToken(convert_classy);
      }


    private void  fromJSONUberClientId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UberClientIdJSON convert_classy = UberClientIdJSON.from_json(json_value, ignore_extras, true);
        setUberClientId(convert_classy);
      }


    private void  fromJSONGetUberClientId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        GetUberClientIdJSON convert_classy = GetUberClientIdJSON.from_json(json_value, ignore_extras, true);
        setGetUberClientId(convert_classy);
      }


    private void  fromJSONSetUserMemoryLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SetUserMemoryLocationJSON convert_classy = SetUserMemoryLocationJSON.from_json(json_value, ignore_extras, true);
        setSetUserMemoryLocation(convert_classy);
      }


    private void  fromJSONDisableMusicPlayerListPositionSpecification(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DisableListPositionSpecificationJSON convert_classy = DisableListPositionSpecificationJSON.from_json(json_value, ignore_extras, true);
        setDisableMusicPlayerListPositionSpecification(convert_classy);
      }


    private void  fromJSONCarControlClimateClientConfiguration(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CarControlClimateClientConfigurationJSON convert_classy = CarControlClimateClientConfigurationJSON.from_json(json_value, ignore_extras, true);
        setCarControlClimateClientConfiguration(convert_classy);
      }


    private void  fromJSONHomeAutomationDomainSettings(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationDomainSettingsJSON convert_classy = HomeAutomationDomainSettingsJSON.from_json(json_value, ignore_extras, true);
        setHomeAutomationDomainSettings(convert_classy);
      }


    private void  fromJSONUserContactsRequests(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UserContactsRequestsJSON convert_classy = UserContactsRequestsJSON.from_json(json_value, ignore_extras, true);
        setUserContactsRequests(convert_classy);
      }


    private void  fromJSONStoredGlobalPagesToMatch(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StoredPageMatchPageListJSON convert_classy = StoredPageMatchPageListJSON.from_json(json_value, ignore_extras, true);
        setStoredGlobalPagesToMatch(convert_classy);
      }


    private void  fromJSONStoredGlobalPagesToNotMatch(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StoredPageMatchPageListJSON convert_classy = StoredPageMatchPageListJSON.from_json(json_value, ignore_extras, true);
        setStoredGlobalPagesToNotMatch(convert_classy);
      }


    private void  fromJSONStoredPerUserPagesToMatch(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StoredPageMatchPageListJSON convert_classy = StoredPageMatchPageListJSON.from_json(json_value, ignore_extras, true);
        setStoredPerUserPagesToMatch(convert_classy);
      }


    private void  fromJSONStoredPerUserPagesToNotMatch(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StoredPageMatchPageListJSON convert_classy = StoredPageMatchPageListJSON.from_json(json_value, ignore_extras, true);
        setStoredPerUserPagesToNotMatch(convert_classy);
      }


    private void  fromJSONStoredGlobalPagesToSetOnByDefault(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StoredPageMatchPageListJSON convert_classy = StoredPageMatchPageListJSON.from_json(json_value, ignore_extras, true);
        setStoredGlobalPagesToSetOnByDefault(convert_classy);
      }


    private void  fromJSONStoredPerUserPagesToSetOnByDefault(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StoredPageMatchPageListJSON convert_classy = StoredPageMatchPageListJSON.from_json(json_value, ignore_extras, true);
        setStoredPerUserPagesToSetOnByDefault(convert_classy);
      }


    private void  fromJSONStoredGlobalPagesToSetOffByDefault(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StoredPageMatchPageListJSON convert_classy = StoredPageMatchPageListJSON.from_json(json_value, ignore_extras, true);
        setStoredGlobalPagesToSetOffByDefault(convert_classy);
      }


    private void  fromJSONStoredPerUserPagesToSetOffByDefault(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StoredPageMatchPageListJSON convert_classy = StoredPageMatchPageListJSON.from_json(json_value, ignore_extras, true);
        setStoredPerUserPagesToSetOffByDefault(convert_classy);
      }


    private void  fromJSONStoredPageMatchWriteData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StoredPageMatchWriteDataJSON convert_classy = StoredPageMatchWriteDataJSON.from_json(json_value, ignore_extras, true);
        setStoredPageMatchWriteData(convert_classy);
      }


    private void  fromJSONStoredPageMatchReadData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StoredPageMatchReadDataJSON convert_classy = StoredPageMatchReadDataJSON.from_json(json_value, ignore_extras, true);
        setStoredPageMatchReadData(convert_classy);
      }


    private void  fromJSONStoredPageMatchPageListData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StoredPageMatchPageListDataJSON convert_classy = StoredPageMatchPageListDataJSON.from_json(json_value, ignore_extras, true);
        setStoredPageMatchPageListData(convert_classy);
      }


    private void  fromJSONVoiceParameters(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        VoiceParametersJSON convert_classy = VoiceParametersJSON.from_json(json_value, ignore_extras, true);
        setVoiceParameters(convert_classy);
      }


    private void  fromJSONStoredAlwaysMatchWriteData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ClientMatchesJSON convert_classy = ClientMatchesJSON.from_json(json_value, ignore_extras, true);
        setStoredAlwaysMatchWriteData(convert_classy);
      }


    private void  fromJSONStoredAlwaysMatchReadData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StoredAlwaysMatchReadDataJSON convert_classy = StoredAlwaysMatchReadDataJSON.from_json(json_value, ignore_extras, true);
        setStoredAlwaysMatchReadData(convert_classy);
      }


    private void  fromJSONUserFeedback(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UserFeedbackJSON convert_classy = UserFeedbackJSON.from_json(json_value, ignore_extras, true);
        setUserFeedback(convert_classy);
      }


    private void  fromJSONRadioControlRecognizeNorthAmericanFMBand(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RadioControlRecognizeNorthAmericanFMBandJSON convert_classy = RadioControlRecognizeNorthAmericanFMBandJSON.from_json(json_value, ignore_extras, true);
        setRadioControlRecognizeNorthAmericanFMBand(convert_classy);
      }


    private void  fromJSONRadioControlRecognizeNorthAmericanAMBand(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RadioControlRecognizeNorthAmericanAMBandJSON convert_classy = RadioControlRecognizeNorthAmericanAMBandJSON.from_json(json_value, ignore_extras, true);
        setRadioControlRecognizeNorthAmericanAMBand(convert_classy);
      }


    private void  fromJSONRadioControlOtherFMBands(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RadioControlOtherFMBandsJSON convert_classy = RadioControlOtherFMBandsJSON.from_json(json_value, ignore_extras, true);
        setRadioControlOtherFMBands(convert_classy);
      }


    private void  fromJSONRadioControlOtherAMBands(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RadioControlOtherAMBandsJSON convert_classy = RadioControlOtherAMBandsJSON.from_json(json_value, ignore_extras, true);
        setRadioControlOtherAMBands(convert_classy);
      }


    private void  fromJSONRadioControlAvailableAudioSources(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RadioControlAvailableAudioSourcesJSON convert_classy = RadioControlAvailableAudioSourcesJSON.from_json(json_value, ignore_extras, true);
        setRadioControlAvailableAudioSources(convert_classy);
      }


    private void  fromJSONClientListMatches(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ClientListMatchesJSON convert_classy = ClientListMatchesJSON.from_json(json_value, ignore_extras, true);
        setClientListMatches(convert_classy);
      }


    private void  fromJSONIntentToExecute(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CommandIntentJSON convert_classy = CommandIntentJSON.from_json(json_value, ignore_extras, true);
        setIntentToExecute(convert_classy);
      }


    private void  fromJSONRobotInfo(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RobotInfoJSON convert_classy = RobotInfoJSON.from_json(json_value, ignore_extras, true);
        setRobotInfo(convert_classy);
      }


    private void  fromJSONConvertToNewInformationNuggets(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ConvertToNewInformationNuggetsJSON convert_classy = ConvertToNewInformationNuggetsJSON.from_json(json_value, ignore_extras, true);
        setConvertToNewInformationNuggets(convert_classy);
      }


    private void  fromJSONAcapelaVoiceParameters(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AcapelaVoiceParametersJSON convert_classy = AcapelaVoiceParametersJSON.from_json(json_value, ignore_extras, true);
        setAcapelaVoiceParameters(convert_classy);
      }


    private void  fromJSONOutputOverrideCommandIsPreAudioOut(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RequestInfoBooleanFlagJSON convert_classy = RequestInfoBooleanFlagJSON.from_json(json_value, ignore_extras, true);
        setOutputOverrideCommandIsPreAudioOut(convert_classy);
      }


    private void  fromJSONOutputOverrideCommandFunction(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        OutputOverrideFunctionJSON convert_classy = OutputOverrideFunctionJSON.from_json(json_value, ignore_extras, true);
        setOutputOverrideCommandFunction(convert_classy);
      }


    private void  fromJSONOutputOverrideCommandFunctionLanguage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UploadedCodeFunctionLanguageJSON convert_classy = UploadedCodeFunctionLanguageJSON.from_json(json_value, ignore_extras, true);
        setOutputOverrideCommandFunctionLanguage(convert_classy);
      }


    private void  fromJSONOutputOverrideCommandFunctionSource(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UploadedCodeSourceJSON convert_classy = UploadedCodeSourceJSON.from_json(json_value, ignore_extras, true);
        setOutputOverrideCommandFunctionSource(convert_classy);
      }


    private void  fromJSONOutputOverrideDeleteCommandFunction(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RequestInfoBooleanFlagJSON convert_classy = RequestInfoBooleanFlagJSON.from_json(json_value, ignore_extras, true);
        setOutputOverrideDeleteCommandFunction(convert_classy);
      }


    private void  fromJSONOutputOverrideReadCommandFunction(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RequestInfoBooleanFlagJSON convert_classy = RequestInfoBooleanFlagJSON.from_json(json_value, ignore_extras, true);
        setOutputOverrideReadCommandFunction(convert_classy);
      }


    private void  fromJSONOutputOverrideInformationNuggetFunction(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        OutputOverrideFunctionJSON convert_classy = OutputOverrideFunctionJSON.from_json(json_value, ignore_extras, true);
        setOutputOverrideInformationNuggetFunction(convert_classy);
      }


    private void  fromJSONOutputOverrideInformationNuggetFunctionLanguage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UploadedCodeFunctionLanguageJSON convert_classy = UploadedCodeFunctionLanguageJSON.from_json(json_value, ignore_extras, true);
        setOutputOverrideInformationNuggetFunctionLanguage(convert_classy);
      }


    private void  fromJSONOutputOverrideInformationNuggetFunctionSource(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UploadedCodeSourceJSON convert_classy = UploadedCodeSourceJSON.from_json(json_value, ignore_extras, true);
        setOutputOverrideInformationNuggetFunctionSource(convert_classy);
      }


    private void  fromJSONOutputOverrideDeleteInformationNuggetFunction(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RequestInfoBooleanFlagJSON convert_classy = RequestInfoBooleanFlagJSON.from_json(json_value, ignore_extras, true);
        setOutputOverrideDeleteInformationNuggetFunction(convert_classy);
      }


    private void  fromJSONOutputOverrideReadInformationNuggetFunction(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RequestInfoBooleanFlagJSON convert_classy = RequestInfoBooleanFlagJSON.from_json(json_value, ignore_extras, true);
        setOutputOverrideReadInformationNuggetFunction(convert_classy);
      }


    private void  fromJSONTerrierUploadWriteData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TerrierUploadWriteDataJSON convert_classy = TerrierUploadWriteDataJSON.from_json(json_value, ignore_extras, true);
        setTerrierUploadWriteData(convert_classy);
      }


    private void  fromJSONTerrierUploadReadData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TerrierUploadReadDataJSON convert_classy = TerrierUploadReadDataJSON.from_json(json_value, ignore_extras, true);
        setTerrierUploadReadData(convert_classy);
      }


    private void  fromJSONDisambiguateResultsBeforeAction(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DisambiguateResultsBeforeActionJSON convert_classy = DisambiguateResultsBeforeActionJSON.from_json(json_value, ignore_extras, true);
        setDisambiguateResultsBeforeAction(convert_classy);
      }


    private void  fromJSONInputOverrideFunction(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        InputOverrideFunctionJSON convert_classy = InputOverrideFunctionJSON.from_json(json_value, ignore_extras, true);
        setInputOverrideFunction(convert_classy);
      }


    private void  fromJSONInputOverrideFunctionLanguage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UploadedCodeFunctionLanguageJSON convert_classy = UploadedCodeFunctionLanguageJSON.from_json(json_value, ignore_extras, true);
        setInputOverrideFunctionLanguage(convert_classy);
      }


    private void  fromJSONInputOverrideFunctionSource(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UploadedCodeSourceJSON convert_classy = UploadedCodeSourceJSON.from_json(json_value, ignore_extras, true);
        setInputOverrideFunctionSource(convert_classy);
      }


    private void  fromJSONInputOverrideDeleteFunction(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RequestInfoBooleanFlagJSON convert_classy = RequestInfoBooleanFlagJSON.from_json(json_value, ignore_extras, true);
        setInputOverrideDeleteFunction(convert_classy);
      }


    private void  fromJSONInputOverrideReadFunction(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RequestInfoBooleanFlagJSON convert_classy = RequestInfoBooleanFlagJSON.from_json(json_value, ignore_extras, true);
        setInputOverrideReadFunction(convert_classy);
      }


    private void  fromJSONSportsLeagueControl(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsLeagueControlJSON convert_classy = SportsLeagueControlJSON.from_json(json_value, ignore_extras, true);
        setSportsLeagueControl(convert_classy);
      }


    public RequestInfoJSON()
      {
        flagHasLatitude = false;
        flagHasLongitude = false;
        flagHasPositionTime = false;
        flagHasPositionHorizontalAccuracy = false;
        flagHasStreet = false;
        flagHasCity = false;
        flagHasState = false;
        flagHasCountry = false;
        flagHasRoutePoints = false;
        flagHasControllableTrackPlaying = false;
        flagHasTimeStamp = false;
        flagHasTimeZone = false;
        flagHasConversationState = false;
        flagHasClientState = false;
        flagHasSendBack = false;
        flagHasPreferredImageSize = false;
        flagHasInputLanguageEnglishName = false;
        flagHasInputLanguageNativeName = false;
        flagHasInputLanguageIETFTag = false;
        flagHasOutputLanguageEnglishName = false;
        flagHasOutputLanguageNativeName = false;
        flagHasOutputLanguageIETFTag = false;
        flagHasResultVersionAccepted = false;
        flagHasUnitPreference = false;
        flagHasDefaultTimeFormat24Hours = false;
        flagHasClientID = false;
        flagHasClientVersion = false;
        flagHasDeviceID = false;
        flagHasSDK = false;
        flagHasSDKInfo = false;
        flagHasFirstPersonSelf = false;
        flagHasFirstPersonSelfSpoken = false;
        flagHasSecondPersonSelf = false;
        flagHasSecondPersonSelfSpoken = false;
        flagHasWakeUpPattern = false;
        flagHasUserID = false;
        flagHasRequestID = false;
        flagHasSessionID = false;
        flagHasDomains = false;
        flagHasResultUpdateAllowed = false;
        flagHasPartialTranscriptsDesired = false;
        flagHasMinResults = false;
        flagHasMaxResults = false;
        flagHasObjectByteCountPrefix = false;
        flagHasProfanityFilter = false;
        flagHasClientMatches = false;
        flagHasClientMatchesOnly = false;
        flagHasPagination = false;
        flagHasResponseAudioVoice = false;
        flagHasResponseAudioShortOrLong = false;
        flagHasResponseAudioAcceptedEncodings = false;
        flagHasVoiceActivityDetection = false;
        flagHasServerDeterminesEndOfAudio = false;
        flagHasIntentOnly = false;
        flagHasDisableSpellCorrection = false;
        flagHasUseContactData = false;
        flagHasUseClientTime = false;
        flagHasForceConversationStateTime = false;
        flagHasPhoneDisambiguationOmitList = false;
        flagHasIncomingCallPending = false;
        flagHasAllowPopularNameContactMatches = false;
        flagHasMusicClientState = false;
        flagHasDisableMusicSearchListPositionSpecification = false;
        flagHasCollateMusicEntities = false;
        flagHasAllowContextFreeMusicSearchForPopularEntities = false;
        flagHasReturnInformationNuggetsForMusicSearch = false;
        flagHasUseXAPAPI = false;
        flagHasLocalSearchClientState = false;
        flagHasUberServerToken = false;
        flagHasGetUberServerToken = false;
        flagHasUberClientId = false;
        flagHasGetUberClientId = false;
        flagHasSetUserMemoryLocation = false;
        flagHasDisableMusicPlayerListPositionSpecification = false;
        flagHasCarControlClimateClientConfiguration = false;
        flagHasHomeAutomationDomainSettings = false;
        flagHasUserContactsRequests = false;
        flagHasStoredGlobalPagesToMatch = false;
        flagHasStoredGlobalPagesToNotMatch = false;
        flagHasStoredPerUserPagesToMatch = false;
        flagHasStoredPerUserPagesToNotMatch = false;
        flagHasStoredGlobalPagesToSetOnByDefault = false;
        flagHasStoredPerUserPagesToSetOnByDefault = false;
        flagHasStoredGlobalPagesToSetOffByDefault = false;
        flagHasStoredPerUserPagesToSetOffByDefault = false;
        flagHasStoredPageMatchWriteData = false;
        flagHasStoredPageMatchReadData = false;
        flagHasStoredPageMatchPageListData = false;
        flagHasVoiceParameters = false;
        flagHasStoredAlwaysMatchWriteData = false;
        flagHasStoredAlwaysMatchReadData = false;
        flagHasUserFeedback = false;
        flagHasRadioControlRecognizeNorthAmericanFMBand = false;
        flagHasRadioControlRecognizeNorthAmericanAMBand = false;
        flagHasRadioControlOtherFMBands = false;
        flagHasRadioControlOtherAMBands = false;
        flagHasRadioControlAvailableAudioSources = false;
        flagHasClientListMatches = false;
        flagHasIntentToExecute = false;
        flagHasRobotInfo = false;
        flagHasConvertToNewInformationNuggets = false;
        flagHasAcapelaVoiceParameters = false;
        flagHasOutputOverrideCommandIsPreAudioOut = false;
        flagHasOutputOverrideCommandFunction = false;
        flagHasOutputOverrideCommandFunctionLanguage = false;
        flagHasOutputOverrideCommandFunctionSource = false;
        flagHasOutputOverrideDeleteCommandFunction = false;
        flagHasOutputOverrideReadCommandFunction = false;
        flagHasOutputOverrideInformationNuggetFunction = false;
        flagHasOutputOverrideInformationNuggetFunctionLanguage = false;
        flagHasOutputOverrideInformationNuggetFunctionSource = false;
        flagHasOutputOverrideDeleteInformationNuggetFunction = false;
        flagHasOutputOverrideReadInformationNuggetFunction = false;
        flagHasTerrierUploadWriteData = false;
        flagHasTerrierUploadReadData = false;
        flagHasDisambiguateResultsBeforeAction = false;
        flagHasInputOverrideFunction = false;
        flagHasInputOverrideFunctionLanguage = false;
        flagHasInputOverrideFunctionSource = false;
        flagHasInputOverrideDeleteFunction = false;
        flagHasInputOverrideReadFunction = false;
        flagHasSportsLeagueControl = false;
        storeControllableTrackPlaying = false;
        storePreferredImageSize = new List< BigInteger >();
        storeFirstPersonSelf = "Hound";
        storeSecondPersonSelf = new List< string >();
        string element1;
        element1 = "Hound";
        storeSecondPersonSelf.Add(element1);
        storeSecondPersonSelfSpoken = new List< string >();
        storeWakeUpPattern = "[[\"OK\"] . \"Hound\"]";
        storeResultUpdateAllowed = false;
        storePartialTranscriptsDesired = false;
        storeMinResults = 1;
        storeMaxResults = 1;
        storeObjectByteCountPrefix = false;
        storeClientMatches = new List< ClientMatchJSON  >();
        storeClientMatchesOnly = false;
        storeResponseAudioAcceptedEncodings = new List< TypeResponseAudioAcceptedEncodings >();
        storeUseContactData = true;
        storeUseClientTime = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasLatitude()
      {
        return flagHasLatitude;
      }

    public double  getLatitude()
      {
        Debug.Assert(flagHasLatitude);
        if (textStoreLatitude != "")
          {
            return Double.Parse(textStoreLatitude);
          }
        return storeLatitude;
      }

    public string  getLatitudeAsText()
      {
        Debug.Assert(flagHasLatitude);
        if (textStoreLatitude == "")
          {
            return Convert.ToString(storeLatitude);
          }
        else
          {
            return (textStoreLatitude);
          }
      }

    public bool  hasLongitude()
      {
        return flagHasLongitude;
      }

    public double  getLongitude()
      {
        Debug.Assert(flagHasLongitude);
        if (textStoreLongitude != "")
          {
            return Double.Parse(textStoreLongitude);
          }
        return storeLongitude;
      }

    public string  getLongitudeAsText()
      {
        Debug.Assert(flagHasLongitude);
        if (textStoreLongitude == "")
          {
            return Convert.ToString(storeLongitude);
          }
        else
          {
            return (textStoreLongitude);
          }
      }

    public bool  hasPositionTime()
      {
        return flagHasPositionTime;
      }

    public BigInteger  getPositionTime()
      {
        Debug.Assert(flagHasPositionTime);
        return storePositionTime;
      }

    public bool  hasPositionHorizontalAccuracy()
      {
        return flagHasPositionHorizontalAccuracy;
      }

    public double  getPositionHorizontalAccuracy()
      {
        Debug.Assert(flagHasPositionHorizontalAccuracy);
        if (textStorePositionHorizontalAccuracy != "")
          {
            return Double.Parse(textStorePositionHorizontalAccuracy);
          }
        return storePositionHorizontalAccuracy;
      }

    public string  getPositionHorizontalAccuracyAsText()
      {
        Debug.Assert(flagHasPositionHorizontalAccuracy);
        if (textStorePositionHorizontalAccuracy == "")
          {
            return Convert.ToString(storePositionHorizontalAccuracy);
          }
        else
          {
            return (textStorePositionHorizontalAccuracy);
          }
      }

    public bool  hasStreet()
      {
        return flagHasStreet;
      }

    public string  getStreet()
      {
        Debug.Assert(flagHasStreet);
        return storeStreet;
      }

    public bool  hasCity()
      {
        return flagHasCity;
      }

    public string  getCity()
      {
        Debug.Assert(flagHasCity);
        return storeCity;
      }

    public bool  hasState()
      {
        return flagHasState;
      }

    public string  getState()
      {
        Debug.Assert(flagHasState);
        return storeState;
      }

    public bool  hasCountry()
      {
        return flagHasCountry;
      }

    public string  getCountry()
      {
        Debug.Assert(flagHasCountry);
        return storeCountry;
      }

    public bool  hasRoutePoints()
      {
        return flagHasRoutePoints;
      }

    public RoutePointsJSON   getRoutePoints()
      {
        Debug.Assert(flagHasRoutePoints);
        return storeRoutePoints;
      }

    public bool  hasControllableTrackPlaying()
      {
        return flagHasControllableTrackPlaying;
      }

    public bool  getControllableTrackPlaying()
      {
        return storeControllableTrackPlaying;
      }

    public bool  hasTimeStamp()
      {
        return flagHasTimeStamp;
      }

    public BigInteger  getTimeStamp()
      {
        Debug.Assert(flagHasTimeStamp);
        return storeTimeStamp;
      }

    public bool  hasTimeZone()
      {
        return flagHasTimeZone;
      }

    public string  getTimeZone()
      {
        Debug.Assert(flagHasTimeZone);
        return storeTimeZone;
      }

    public bool  hasConversationState()
      {
        return flagHasConversationState;
      }

    public ConversationStateJSON   getConversationState()
      {
        Debug.Assert(flagHasConversationState);
        return storeConversationState;
      }

    public bool  hasClientState()
      {
        return flagHasClientState;
      }

    public ClientStateJSON   getClientState()
      {
        Debug.Assert(flagHasClientState);
        return storeClientState;
      }

    public bool  hasSendBack()
      {
        return flagHasSendBack;
      }

    public JSONValue   getSendBack()
      {
        Debug.Assert(flagHasSendBack);
        return storeSendBack;
      }

    public bool  hasPreferredImageSize()
      {
        return flagHasPreferredImageSize;
      }

    public int  countOfPreferredImageSize()
      {
        Debug.Assert(flagHasPreferredImageSize);
        return storePreferredImageSize.Count;
      }

    public BigInteger  elementOfPreferredImageSize(int element_num)
      {
        Debug.Assert(flagHasPreferredImageSize);
        return storePreferredImageSize[element_num];
      }

    public List< BigInteger >  getPreferredImageSize()
      {
        Debug.Assert(flagHasPreferredImageSize);
        return storePreferredImageSize;
      }

    public bool  hasInputLanguageEnglishName()
      {
        return flagHasInputLanguageEnglishName;
      }

    public string  getInputLanguageEnglishName()
      {
        Debug.Assert(flagHasInputLanguageEnglishName);
        return storeInputLanguageEnglishName;
      }

    public bool  hasInputLanguageNativeName()
      {
        return flagHasInputLanguageNativeName;
      }

    public string  getInputLanguageNativeName()
      {
        Debug.Assert(flagHasInputLanguageNativeName);
        return storeInputLanguageNativeName;
      }

    public bool  hasInputLanguageIETFTag()
      {
        return flagHasInputLanguageIETFTag;
      }

    public string  getInputLanguageIETFTag()
      {
        Debug.Assert(flagHasInputLanguageIETFTag);
        return storeInputLanguageIETFTag;
      }

    public bool  hasOutputLanguageEnglishName()
      {
        return flagHasOutputLanguageEnglishName;
      }

    public string  getOutputLanguageEnglishName()
      {
        Debug.Assert(flagHasOutputLanguageEnglishName);
        return storeOutputLanguageEnglishName;
      }

    public bool  hasOutputLanguageNativeName()
      {
        return flagHasOutputLanguageNativeName;
      }

    public string  getOutputLanguageNativeName()
      {
        Debug.Assert(flagHasOutputLanguageNativeName);
        return storeOutputLanguageNativeName;
      }

    public bool  hasOutputLanguageIETFTag()
      {
        return flagHasOutputLanguageIETFTag;
      }

    public string  getOutputLanguageIETFTag()
      {
        Debug.Assert(flagHasOutputLanguageIETFTag);
        return storeOutputLanguageIETFTag;
      }

    public bool  hasResultVersionAccepted()
      {
        return flagHasResultVersionAccepted;
      }

    public double  getResultVersionAccepted()
      {
        Debug.Assert(flagHasResultVersionAccepted);
        if (textStoreResultVersionAccepted != "")
          {
            return Double.Parse(textStoreResultVersionAccepted);
          }
        return storeResultVersionAccepted;
      }

    public string  getResultVersionAcceptedAsText()
      {
        Debug.Assert(flagHasResultVersionAccepted);
        if (textStoreResultVersionAccepted == "")
          {
            return Convert.ToString(storeResultVersionAccepted);
          }
        else
          {
            return (textStoreResultVersionAccepted);
          }
      }

    public bool  hasUnitPreference()
      {
        return flagHasUnitPreference;
      }

    public TypeUnitPreference  getUnitPreference()
      {
        Debug.Assert(flagHasUnitPreference);
        return storeUnitPreference;
      }

    public string  getUnitPreferenceAsString()
      {
        return stringFromUnitPreference(getUnitPreference());
      }

    public bool  hasDefaultTimeFormat24Hours()
      {
        return flagHasDefaultTimeFormat24Hours;
      }

    public bool  getDefaultTimeFormat24Hours()
      {
        Debug.Assert(flagHasDefaultTimeFormat24Hours);
        return storeDefaultTimeFormat24Hours;
      }

    public bool  hasClientID()
      {
        return flagHasClientID;
      }

    public string  getClientID()
      {
        Debug.Assert(flagHasClientID);
        return storeClientID;
      }

    public bool  hasClientVersion()
      {
        return flagHasClientVersion;
      }

    public TypeClientVersion  getClientVersion()
      {
        Debug.Assert(flagHasClientVersion);
        return storeClientVersion;
      }

    public bool  hasDeviceID()
      {
        return flagHasDeviceID;
      }

    public string  getDeviceID()
      {
        Debug.Assert(flagHasDeviceID);
        return storeDeviceID;
      }

    public bool  hasSDK()
      {
        return flagHasSDK;
      }

    public string  getSDK()
      {
        Debug.Assert(flagHasSDK);
        return storeSDK;
      }

    public bool  hasSDKInfo()
      {
        return flagHasSDKInfo;
      }

    public JSONObjectValue   getSDKInfo()
      {
        Debug.Assert(flagHasSDKInfo);
        return storeSDKInfo;
      }

    public bool  hasFirstPersonSelf()
      {
        return flagHasFirstPersonSelf;
      }

    public string  getFirstPersonSelf()
      {
        return storeFirstPersonSelf;
      }

    public bool  hasFirstPersonSelfSpoken()
      {
        return flagHasFirstPersonSelfSpoken;
      }

    public string  getFirstPersonSelfSpoken()
      {
        Debug.Assert(flagHasFirstPersonSelfSpoken);
        return storeFirstPersonSelfSpoken;
      }

    public bool  hasSecondPersonSelf()
      {
        return flagHasSecondPersonSelf;
      }

    public int  countOfSecondPersonSelf()
      {
        return storeSecondPersonSelf.Count;
      }

    public string  elementOfSecondPersonSelf(int element_num)
      {
        return storeSecondPersonSelf[element_num];
      }

    public List< string >  getSecondPersonSelf()
      {
        return storeSecondPersonSelf;
      }

    public bool  hasSecondPersonSelfSpoken()
      {
        return flagHasSecondPersonSelfSpoken;
      }

    public int  countOfSecondPersonSelfSpoken()
      {
        Debug.Assert(flagHasSecondPersonSelfSpoken);
        return storeSecondPersonSelfSpoken.Count;
      }

    public string  elementOfSecondPersonSelfSpoken(int element_num)
      {
        Debug.Assert(flagHasSecondPersonSelfSpoken);
        return storeSecondPersonSelfSpoken[element_num];
      }

    public List< string >  getSecondPersonSelfSpoken()
      {
        Debug.Assert(flagHasSecondPersonSelfSpoken);
        return storeSecondPersonSelfSpoken;
      }

    public bool  hasWakeUpPattern()
      {
        return flagHasWakeUpPattern;
      }

    public string  getWakeUpPattern()
      {
        return storeWakeUpPattern;
      }

    public bool  hasUserID()
      {
        return flagHasUserID;
      }

    public string  getUserID()
      {
        Debug.Assert(flagHasUserID);
        return storeUserID;
      }

    public bool  hasRequestID()
      {
        return flagHasRequestID;
      }

    public string  getRequestID()
      {
        Debug.Assert(flagHasRequestID);
        return storeRequestID;
      }

    public bool  hasSessionID()
      {
        return flagHasSessionID;
      }

    public string  getSessionID()
      {
        Debug.Assert(flagHasSessionID);
        return storeSessionID;
      }

    public bool  hasDomains()
      {
        return flagHasDomains;
      }

    public DomainsJSON   getDomains()
      {
        Debug.Assert(flagHasDomains);
        return storeDomains;
      }

    public bool  hasResultUpdateAllowed()
      {
        return flagHasResultUpdateAllowed;
      }

    public bool  getResultUpdateAllowed()
      {
        return storeResultUpdateAllowed;
      }

    public bool  hasPartialTranscriptsDesired()
      {
        return flagHasPartialTranscriptsDesired;
      }

    public bool  getPartialTranscriptsDesired()
      {
        return storePartialTranscriptsDesired;
      }

    public bool  hasMinResults()
      {
        return flagHasMinResults;
      }

    public BigInteger  getMinResults()
      {
        return storeMinResults;
      }

    public bool  hasMaxResults()
      {
        return flagHasMaxResults;
      }

    public BigInteger  getMaxResults()
      {
        return storeMaxResults;
      }

    public bool  hasObjectByteCountPrefix()
      {
        return flagHasObjectByteCountPrefix;
      }

    public bool  getObjectByteCountPrefix()
      {
        return storeObjectByteCountPrefix;
      }

    public bool  hasProfanityFilter()
      {
        return flagHasProfanityFilter;
      }

    public TypeProfanityFilter  getProfanityFilter()
      {
        Debug.Assert(flagHasProfanityFilter);
        return storeProfanityFilter;
      }

    public string  getProfanityFilterAsString()
      {
        return stringFromProfanityFilter(getProfanityFilter());
      }

    public bool  hasClientMatches()
      {
        return flagHasClientMatches;
      }

    public int  countOfClientMatches()
      {
        Debug.Assert(flagHasClientMatches);
        return storeClientMatches.Count;
      }

    public ClientMatchJSON   elementOfClientMatches(int element_num)
      {
        Debug.Assert(flagHasClientMatches);
        return storeClientMatches[element_num];
      }

    public List< ClientMatchJSON  >  getClientMatches()
      {
        Debug.Assert(flagHasClientMatches);
        return storeClientMatches;
      }

    public bool  hasClientMatchesOnly()
      {
        return flagHasClientMatchesOnly;
      }

    public bool  getClientMatchesOnly()
      {
        return storeClientMatchesOnly;
      }

    public bool  hasPagination()
      {
        return flagHasPagination;
      }

    public PaginationJSON   getPagination()
      {
        Debug.Assert(flagHasPagination);
        return storePagination;
      }

    public bool  hasResponseAudioVoice()
      {
        return flagHasResponseAudioVoice;
      }

    public string  getResponseAudioVoice()
      {
        Debug.Assert(flagHasResponseAudioVoice);
        return storeResponseAudioVoice;
      }

    public bool  hasResponseAudioShortOrLong()
      {
        return flagHasResponseAudioShortOrLong;
      }

    public TypeResponseAudioShortOrLong  getResponseAudioShortOrLong()
      {
        Debug.Assert(flagHasResponseAudioShortOrLong);
        return storeResponseAudioShortOrLong;
      }

    public string  getResponseAudioShortOrLongAsString()
      {
        return stringFromResponseAudioShortOrLong(getResponseAudioShortOrLong());
      }

    public bool  hasResponseAudioAcceptedEncodings()
      {
        return flagHasResponseAudioAcceptedEncodings;
      }

    public int  countOfResponseAudioAcceptedEncodings()
      {
        Debug.Assert(flagHasResponseAudioAcceptedEncodings);
        return storeResponseAudioAcceptedEncodings.Count;
      }

    public TypeResponseAudioAcceptedEncodings  elementOfResponseAudioAcceptedEncodings(int element_num)
      {
        Debug.Assert(flagHasResponseAudioAcceptedEncodings);
        return storeResponseAudioAcceptedEncodings[element_num];
      }

    public List< TypeResponseAudioAcceptedEncodings >  getResponseAudioAcceptedEncodings()
      {
        Debug.Assert(flagHasResponseAudioAcceptedEncodings);
        return storeResponseAudioAcceptedEncodings;
      }

    public bool  hasVoiceActivityDetection()
      {
        return flagHasVoiceActivityDetection;
      }

    public VoiceActivityDetectionJSON   getVoiceActivityDetection()
      {
        Debug.Assert(flagHasVoiceActivityDetection);
        return storeVoiceActivityDetection;
      }

    public bool  hasServerDeterminesEndOfAudio()
      {
        return flagHasServerDeterminesEndOfAudio;
      }

    public bool  getServerDeterminesEndOfAudio()
      {
        Debug.Assert(flagHasServerDeterminesEndOfAudio);
        return storeServerDeterminesEndOfAudio;
      }

    public bool  hasIntentOnly()
      {
        return flagHasIntentOnly;
      }

    public bool  getIntentOnly()
      {
        Debug.Assert(flagHasIntentOnly);
        return storeIntentOnly;
      }

    public bool  hasDisableSpellCorrection()
      {
        return flagHasDisableSpellCorrection;
      }

    public bool  getDisableSpellCorrection()
      {
        Debug.Assert(flagHasDisableSpellCorrection);
        return storeDisableSpellCorrection;
      }

    public bool  hasUseContactData()
      {
        return flagHasUseContactData;
      }

    public bool  getUseContactData()
      {
        return storeUseContactData;
      }

    public bool  hasUseClientTime()
      {
        return flagHasUseClientTime;
      }

    public bool  getUseClientTime()
      {
        return storeUseClientTime;
      }

    public bool  hasForceConversationStateTime()
      {
        return flagHasForceConversationStateTime;
      }

    public BigInteger  getForceConversationStateTime()
      {
        Debug.Assert(flagHasForceConversationStateTime);
        return storeForceConversationStateTime;
      }

    public bool  hasPhoneDisambiguationOmitList()
      {
        return flagHasPhoneDisambiguationOmitList;
      }

    public PhoneDisambiguationOmitListJSON   getPhoneDisambiguationOmitList()
      {
        Debug.Assert(flagHasPhoneDisambiguationOmitList);
        return storePhoneDisambiguationOmitList;
      }

    public bool  hasIncomingCallPending()
      {
        return flagHasIncomingCallPending;
      }

    public IncomingCallPendingJSON   getIncomingCallPending()
      {
        Debug.Assert(flagHasIncomingCallPending);
        return storeIncomingCallPending;
      }

    public bool  getIncomingCallPendingValue()
      {
        return getIncomingCallPending().getValue();
      }

    public bool  hasAllowPopularNameContactMatches()
      {
        return flagHasAllowPopularNameContactMatches;
      }

    public AllowPopularNameContactMatchesJSON   getAllowPopularNameContactMatches()
      {
        Debug.Assert(flagHasAllowPopularNameContactMatches);
        return storeAllowPopularNameContactMatches;
      }

    public bool  getAllowPopularNameContactMatchesValue()
      {
        return getAllowPopularNameContactMatches().getValue();
      }

    public bool  hasMusicClientState()
      {
        return flagHasMusicClientState;
      }

    public MusicClientStateJSON   getMusicClientState()
      {
        Debug.Assert(flagHasMusicClientState);
        return storeMusicClientState;
      }

    public bool  hasDisableMusicSearchListPositionSpecification()
      {
        return flagHasDisableMusicSearchListPositionSpecification;
      }

    public DisableListPositionSpecificationJSON   getDisableMusicSearchListPositionSpecification()
      {
        Debug.Assert(flagHasDisableMusicSearchListPositionSpecification);
        return storeDisableMusicSearchListPositionSpecification;
      }

    public bool  getDisableMusicSearchListPositionSpecificationValue()
      {
        return getDisableMusicSearchListPositionSpecification().getValue();
      }

    public bool  hasCollateMusicEntities()
      {
        return flagHasCollateMusicEntities;
      }

    public CollateMusicEntitiesJSON   getCollateMusicEntities()
      {
        Debug.Assert(flagHasCollateMusicEntities);
        return storeCollateMusicEntities;
      }

    public bool  getCollateMusicEntitiesValue()
      {
        return getCollateMusicEntities().getValue();
      }

    public bool  hasAllowContextFreeMusicSearchForPopularEntities()
      {
        return flagHasAllowContextFreeMusicSearchForPopularEntities;
      }

    public AllowContextFreeMusicSearchForPopularEntitiesJSON   getAllowContextFreeMusicSearchForPopularEntities()
      {
        Debug.Assert(flagHasAllowContextFreeMusicSearchForPopularEntities);
        return storeAllowContextFreeMusicSearchForPopularEntities;
      }

    public bool  getAllowContextFreeMusicSearchForPopularEntitiesValue()
      {
        return getAllowContextFreeMusicSearchForPopularEntities().getValue();
      }

    public bool  hasReturnInformationNuggetsForMusicSearch()
      {
        return flagHasReturnInformationNuggetsForMusicSearch;
      }

    public ReturnInformationNuggetsForMusicSearchJSON   getReturnInformationNuggetsForMusicSearch()
      {
        Debug.Assert(flagHasReturnInformationNuggetsForMusicSearch);
        return storeReturnInformationNuggetsForMusicSearch;
      }

    public bool  getReturnInformationNuggetsForMusicSearchValue()
      {
        return getReturnInformationNuggetsForMusicSearch().getValue();
      }

    public bool  hasUseXAPAPI()
      {
        return flagHasUseXAPAPI;
      }

    public RequestInfoBooleanFlagJSON   getUseXAPAPI()
      {
        Debug.Assert(flagHasUseXAPAPI);
        return storeUseXAPAPI;
      }

    public bool  getUseXAPAPIValue()
      {
        return getUseXAPAPI().getValue();
      }

    public bool  hasLocalSearchClientState()
      {
        return flagHasLocalSearchClientState;
      }

    public LocalSearchClientStateJSON   getLocalSearchClientState()
      {
        Debug.Assert(flagHasLocalSearchClientState);
        return storeLocalSearchClientState;
      }

    public bool  hasUberServerToken()
      {
        return flagHasUberServerToken;
      }

    public UberServerTokenJSON   getUberServerToken()
      {
        Debug.Assert(flagHasUberServerToken);
        return storeUberServerToken;
      }

    public string  getUberServerTokenValue()
      {
        return getUberServerToken().getValue();
      }

    public bool  hasGetUberServerToken()
      {
        return flagHasGetUberServerToken;
      }

    public GetUberServerTokenJSON   getGetUberServerToken()
      {
        Debug.Assert(flagHasGetUberServerToken);
        return storeGetUberServerToken;
      }

    public bool  getGetUberServerTokenValue()
      {
        return getGetUberServerToken().getValue();
      }

    public bool  hasUberClientId()
      {
        return flagHasUberClientId;
      }

    public UberClientIdJSON   getUberClientId()
      {
        Debug.Assert(flagHasUberClientId);
        return storeUberClientId;
      }

    public string  getUberClientIdValue()
      {
        return getUberClientId().getValue();
      }

    public bool  hasGetUberClientId()
      {
        return flagHasGetUberClientId;
      }

    public GetUberClientIdJSON   getGetUberClientId()
      {
        Debug.Assert(flagHasGetUberClientId);
        return storeGetUberClientId;
      }

    public bool  getGetUberClientIdValue()
      {
        return getGetUberClientId().getValue();
      }

    public bool  hasSetUserMemoryLocation()
      {
        return flagHasSetUserMemoryLocation;
      }

    public SetUserMemoryLocationJSON   getSetUserMemoryLocation()
      {
        Debug.Assert(flagHasSetUserMemoryLocation);
        return storeSetUserMemoryLocation;
      }

    public bool  hasDisableMusicPlayerListPositionSpecification()
      {
        return flagHasDisableMusicPlayerListPositionSpecification;
      }

    public DisableListPositionSpecificationJSON   getDisableMusicPlayerListPositionSpecification()
      {
        Debug.Assert(flagHasDisableMusicPlayerListPositionSpecification);
        return storeDisableMusicPlayerListPositionSpecification;
      }

    public bool  getDisableMusicPlayerListPositionSpecificationValue()
      {
        return getDisableMusicPlayerListPositionSpecification().getValue();
      }

    public bool  hasCarControlClimateClientConfiguration()
      {
        return flagHasCarControlClimateClientConfiguration;
      }

    public CarControlClimateClientConfigurationJSON   getCarControlClimateClientConfiguration()
      {
        Debug.Assert(flagHasCarControlClimateClientConfiguration);
        return storeCarControlClimateClientConfiguration;
      }

    public bool  hasHomeAutomationDomainSettings()
      {
        return flagHasHomeAutomationDomainSettings;
      }

    public HomeAutomationDomainSettingsJSON   getHomeAutomationDomainSettings()
      {
        Debug.Assert(flagHasHomeAutomationDomainSettings);
        return storeHomeAutomationDomainSettings;
      }

    public bool  hasUserContactsRequests()
      {
        return flagHasUserContactsRequests;
      }

    public UserContactsRequestsJSON   getUserContactsRequests()
      {
        Debug.Assert(flagHasUserContactsRequests);
        return storeUserContactsRequests;
      }

    public bool  hasStoredGlobalPagesToMatch()
      {
        return flagHasStoredGlobalPagesToMatch;
      }

    public StoredPageMatchPageListJSON   getStoredGlobalPagesToMatch()
      {
        Debug.Assert(flagHasStoredGlobalPagesToMatch);
        return storeStoredGlobalPagesToMatch;
      }

    public bool  hasStoredGlobalPagesToNotMatch()
      {
        return flagHasStoredGlobalPagesToNotMatch;
      }

    public StoredPageMatchPageListJSON   getStoredGlobalPagesToNotMatch()
      {
        Debug.Assert(flagHasStoredGlobalPagesToNotMatch);
        return storeStoredGlobalPagesToNotMatch;
      }

    public bool  hasStoredPerUserPagesToMatch()
      {
        return flagHasStoredPerUserPagesToMatch;
      }

    public StoredPageMatchPageListJSON   getStoredPerUserPagesToMatch()
      {
        Debug.Assert(flagHasStoredPerUserPagesToMatch);
        return storeStoredPerUserPagesToMatch;
      }

    public bool  hasStoredPerUserPagesToNotMatch()
      {
        return flagHasStoredPerUserPagesToNotMatch;
      }

    public StoredPageMatchPageListJSON   getStoredPerUserPagesToNotMatch()
      {
        Debug.Assert(flagHasStoredPerUserPagesToNotMatch);
        return storeStoredPerUserPagesToNotMatch;
      }

    public bool  hasStoredGlobalPagesToSetOnByDefault()
      {
        return flagHasStoredGlobalPagesToSetOnByDefault;
      }

    public StoredPageMatchPageListJSON   getStoredGlobalPagesToSetOnByDefault()
      {
        Debug.Assert(flagHasStoredGlobalPagesToSetOnByDefault);
        return storeStoredGlobalPagesToSetOnByDefault;
      }

    public bool  hasStoredPerUserPagesToSetOnByDefault()
      {
        return flagHasStoredPerUserPagesToSetOnByDefault;
      }

    public StoredPageMatchPageListJSON   getStoredPerUserPagesToSetOnByDefault()
      {
        Debug.Assert(flagHasStoredPerUserPagesToSetOnByDefault);
        return storeStoredPerUserPagesToSetOnByDefault;
      }

    public bool  hasStoredGlobalPagesToSetOffByDefault()
      {
        return flagHasStoredGlobalPagesToSetOffByDefault;
      }

    public StoredPageMatchPageListJSON   getStoredGlobalPagesToSetOffByDefault()
      {
        Debug.Assert(flagHasStoredGlobalPagesToSetOffByDefault);
        return storeStoredGlobalPagesToSetOffByDefault;
      }

    public bool  hasStoredPerUserPagesToSetOffByDefault()
      {
        return flagHasStoredPerUserPagesToSetOffByDefault;
      }

    public StoredPageMatchPageListJSON   getStoredPerUserPagesToSetOffByDefault()
      {
        Debug.Assert(flagHasStoredPerUserPagesToSetOffByDefault);
        return storeStoredPerUserPagesToSetOffByDefault;
      }

    public bool  hasStoredPageMatchWriteData()
      {
        return flagHasStoredPageMatchWriteData;
      }

    public StoredPageMatchWriteDataJSON   getStoredPageMatchWriteData()
      {
        Debug.Assert(flagHasStoredPageMatchWriteData);
        return storeStoredPageMatchWriteData;
      }

    public bool  hasStoredPageMatchReadData()
      {
        return flagHasStoredPageMatchReadData;
      }

    public StoredPageMatchReadDataJSON   getStoredPageMatchReadData()
      {
        Debug.Assert(flagHasStoredPageMatchReadData);
        return storeStoredPageMatchReadData;
      }

    public bool  hasStoredPageMatchPageListData()
      {
        return flagHasStoredPageMatchPageListData;
      }

    public StoredPageMatchPageListDataJSON   getStoredPageMatchPageListData()
      {
        Debug.Assert(flagHasStoredPageMatchPageListData);
        return storeStoredPageMatchPageListData;
      }

    public bool  hasVoiceParameters()
      {
        return flagHasVoiceParameters;
      }

    public VoiceParametersJSON   getVoiceParameters()
      {
        Debug.Assert(flagHasVoiceParameters);
        return storeVoiceParameters;
      }

    public bool  hasStoredAlwaysMatchWriteData()
      {
        return flagHasStoredAlwaysMatchWriteData;
      }

    public ClientMatchesJSON   getStoredAlwaysMatchWriteData()
      {
        Debug.Assert(flagHasStoredAlwaysMatchWriteData);
        return storeStoredAlwaysMatchWriteData;
      }

    public bool  hasStoredAlwaysMatchReadData()
      {
        return flagHasStoredAlwaysMatchReadData;
      }

    public StoredAlwaysMatchReadDataJSON   getStoredAlwaysMatchReadData()
      {
        Debug.Assert(flagHasStoredAlwaysMatchReadData);
        return storeStoredAlwaysMatchReadData;
      }

    public bool  getStoredAlwaysMatchReadDataValue()
      {
        return getStoredAlwaysMatchReadData().getValue();
      }

    public bool  hasUserFeedback()
      {
        return flagHasUserFeedback;
      }

    public UserFeedbackJSON   getUserFeedback()
      {
        Debug.Assert(flagHasUserFeedback);
        return storeUserFeedback;
      }

    public bool  hasRadioControlRecognizeNorthAmericanFMBand()
      {
        return flagHasRadioControlRecognizeNorthAmericanFMBand;
      }

    public RadioControlRecognizeNorthAmericanFMBandJSON   getRadioControlRecognizeNorthAmericanFMBand()
      {
        Debug.Assert(flagHasRadioControlRecognizeNorthAmericanFMBand);
        return storeRadioControlRecognizeNorthAmericanFMBand;
      }

    public bool  getRadioControlRecognizeNorthAmericanFMBandValue()
      {
        return getRadioControlRecognizeNorthAmericanFMBand().getValue();
      }

    public bool  hasRadioControlRecognizeNorthAmericanAMBand()
      {
        return flagHasRadioControlRecognizeNorthAmericanAMBand;
      }

    public RadioControlRecognizeNorthAmericanAMBandJSON   getRadioControlRecognizeNorthAmericanAMBand()
      {
        Debug.Assert(flagHasRadioControlRecognizeNorthAmericanAMBand);
        return storeRadioControlRecognizeNorthAmericanAMBand;
      }

    public bool  getRadioControlRecognizeNorthAmericanAMBandValue()
      {
        return getRadioControlRecognizeNorthAmericanAMBand().getValue();
      }

    public bool  hasRadioControlOtherFMBands()
      {
        return flagHasRadioControlOtherFMBands;
      }

    public RadioControlOtherFMBandsJSON   getRadioControlOtherFMBands()
      {
        Debug.Assert(flagHasRadioControlOtherFMBands);
        return storeRadioControlOtherFMBands;
      }

    public bool  hasRadioControlOtherAMBands()
      {
        return flagHasRadioControlOtherAMBands;
      }

    public RadioControlOtherAMBandsJSON   getRadioControlOtherAMBands()
      {
        Debug.Assert(flagHasRadioControlOtherAMBands);
        return storeRadioControlOtherAMBands;
      }

    public bool  hasRadioControlAvailableAudioSources()
      {
        return flagHasRadioControlAvailableAudioSources;
      }

    public RadioControlAvailableAudioSourcesJSON   getRadioControlAvailableAudioSources()
      {
        Debug.Assert(flagHasRadioControlAvailableAudioSources);
        return storeRadioControlAvailableAudioSources;
      }

    public bool  hasClientListMatches()
      {
        return flagHasClientListMatches;
      }

    public ClientListMatchesJSON   getClientListMatches()
      {
        Debug.Assert(flagHasClientListMatches);
        return storeClientListMatches;
      }

    public bool  hasIntentToExecute()
      {
        return flagHasIntentToExecute;
      }

    public CommandIntentJSON   getIntentToExecute()
      {
        Debug.Assert(flagHasIntentToExecute);
        return storeIntentToExecute;
      }

    public bool  hasRobotInfo()
      {
        return flagHasRobotInfo;
      }

    public RobotInfoJSON   getRobotInfo()
      {
        Debug.Assert(flagHasRobotInfo);
        return storeRobotInfo;
      }

    public bool  hasConvertToNewInformationNuggets()
      {
        return flagHasConvertToNewInformationNuggets;
      }

    public ConvertToNewInformationNuggetsJSON   getConvertToNewInformationNuggets()
      {
        Debug.Assert(flagHasConvertToNewInformationNuggets);
        return storeConvertToNewInformationNuggets;
      }

    public bool  getConvertToNewInformationNuggetsValue()
      {
        return getConvertToNewInformationNuggets().getValue();
      }

    public bool  hasAcapelaVoiceParameters()
      {
        return flagHasAcapelaVoiceParameters;
      }

    public AcapelaVoiceParametersJSON   getAcapelaVoiceParameters()
      {
        Debug.Assert(flagHasAcapelaVoiceParameters);
        return storeAcapelaVoiceParameters;
      }

    public bool  hasOutputOverrideCommandIsPreAudioOut()
      {
        return flagHasOutputOverrideCommandIsPreAudioOut;
      }

    public RequestInfoBooleanFlagJSON   getOutputOverrideCommandIsPreAudioOut()
      {
        Debug.Assert(flagHasOutputOverrideCommandIsPreAudioOut);
        return storeOutputOverrideCommandIsPreAudioOut;
      }

    public bool  getOutputOverrideCommandIsPreAudioOutValue()
      {
        return getOutputOverrideCommandIsPreAudioOut().getValue();
      }

    public bool  hasOutputOverrideCommandFunction()
      {
        return flagHasOutputOverrideCommandFunction;
      }

    public OutputOverrideFunctionJSON   getOutputOverrideCommandFunction()
      {
        Debug.Assert(flagHasOutputOverrideCommandFunction);
        return storeOutputOverrideCommandFunction;
      }

    public string  getOutputOverrideCommandFunctionValue()
      {
        return getOutputOverrideCommandFunction().getValue();
      }

    public bool  hasOutputOverrideCommandFunctionLanguage()
      {
        return flagHasOutputOverrideCommandFunctionLanguage;
      }

    public UploadedCodeFunctionLanguageJSON   getOutputOverrideCommandFunctionLanguage()
      {
        Debug.Assert(flagHasOutputOverrideCommandFunctionLanguage);
        return storeOutputOverrideCommandFunctionLanguage;
      }

    public UploadedCodeFunctionLanguageJSON.TypeValue  getOutputOverrideCommandFunctionLanguageValue()
      {
        return getOutputOverrideCommandFunctionLanguage().getValue();
      }

    public string  getOutputOverrideCommandFunctionLanguageAsString()
      {
        return getOutputOverrideCommandFunctionLanguage().getValueAsString();
      }

    public bool  hasOutputOverrideCommandFunctionSource()
      {
        return flagHasOutputOverrideCommandFunctionSource;
      }

    public UploadedCodeSourceJSON   getOutputOverrideCommandFunctionSource()
      {
        Debug.Assert(flagHasOutputOverrideCommandFunctionSource);
        return storeOutputOverrideCommandFunctionSource;
      }

    public bool  hasOutputOverrideDeleteCommandFunction()
      {
        return flagHasOutputOverrideDeleteCommandFunction;
      }

    public RequestInfoBooleanFlagJSON   getOutputOverrideDeleteCommandFunction()
      {
        Debug.Assert(flagHasOutputOverrideDeleteCommandFunction);
        return storeOutputOverrideDeleteCommandFunction;
      }

    public bool  getOutputOverrideDeleteCommandFunctionValue()
      {
        return getOutputOverrideDeleteCommandFunction().getValue();
      }

    public bool  hasOutputOverrideReadCommandFunction()
      {
        return flagHasOutputOverrideReadCommandFunction;
      }

    public RequestInfoBooleanFlagJSON   getOutputOverrideReadCommandFunction()
      {
        Debug.Assert(flagHasOutputOverrideReadCommandFunction);
        return storeOutputOverrideReadCommandFunction;
      }

    public bool  getOutputOverrideReadCommandFunctionValue()
      {
        return getOutputOverrideReadCommandFunction().getValue();
      }

    public bool  hasOutputOverrideInformationNuggetFunction()
      {
        return flagHasOutputOverrideInformationNuggetFunction;
      }

    public OutputOverrideFunctionJSON   getOutputOverrideInformationNuggetFunction()
      {
        Debug.Assert(flagHasOutputOverrideInformationNuggetFunction);
        return storeOutputOverrideInformationNuggetFunction;
      }

    public string  getOutputOverrideInformationNuggetFunctionValue()
      {
        return getOutputOverrideInformationNuggetFunction().getValue();
      }

    public bool  hasOutputOverrideInformationNuggetFunctionLanguage()
      {
        return flagHasOutputOverrideInformationNuggetFunctionLanguage;
      }

    public UploadedCodeFunctionLanguageJSON   getOutputOverrideInformationNuggetFunctionLanguage()
      {
        Debug.Assert(flagHasOutputOverrideInformationNuggetFunctionLanguage);
        return storeOutputOverrideInformationNuggetFunctionLanguage;
      }

    public UploadedCodeFunctionLanguageJSON.TypeValue  getOutputOverrideInformationNuggetFunctionLanguageValue()
      {
        return getOutputOverrideInformationNuggetFunctionLanguage().getValue();
      }

    public string  getOutputOverrideInformationNuggetFunctionLanguageAsString()
      {
        return getOutputOverrideInformationNuggetFunctionLanguage().getValueAsString();
      }

    public bool  hasOutputOverrideInformationNuggetFunctionSource()
      {
        return flagHasOutputOverrideInformationNuggetFunctionSource;
      }

    public UploadedCodeSourceJSON   getOutputOverrideInformationNuggetFunctionSource()
      {
        Debug.Assert(flagHasOutputOverrideInformationNuggetFunctionSource);
        return storeOutputOverrideInformationNuggetFunctionSource;
      }

    public bool  hasOutputOverrideDeleteInformationNuggetFunction()
      {
        return flagHasOutputOverrideDeleteInformationNuggetFunction;
      }

    public RequestInfoBooleanFlagJSON   getOutputOverrideDeleteInformationNuggetFunction()
      {
        Debug.Assert(flagHasOutputOverrideDeleteInformationNuggetFunction);
        return storeOutputOverrideDeleteInformationNuggetFunction;
      }

    public bool  getOutputOverrideDeleteInformationNuggetFunctionValue()
      {
        return getOutputOverrideDeleteInformationNuggetFunction().getValue();
      }

    public bool  hasOutputOverrideReadInformationNuggetFunction()
      {
        return flagHasOutputOverrideReadInformationNuggetFunction;
      }

    public RequestInfoBooleanFlagJSON   getOutputOverrideReadInformationNuggetFunction()
      {
        Debug.Assert(flagHasOutputOverrideReadInformationNuggetFunction);
        return storeOutputOverrideReadInformationNuggetFunction;
      }

    public bool  getOutputOverrideReadInformationNuggetFunctionValue()
      {
        return getOutputOverrideReadInformationNuggetFunction().getValue();
      }

    public bool  hasTerrierUploadWriteData()
      {
        return flagHasTerrierUploadWriteData;
      }

    public TerrierUploadWriteDataJSON   getTerrierUploadWriteData()
      {
        Debug.Assert(flagHasTerrierUploadWriteData);
        return storeTerrierUploadWriteData;
      }

    public bool  hasTerrierUploadReadData()
      {
        return flagHasTerrierUploadReadData;
      }

    public TerrierUploadReadDataJSON   getTerrierUploadReadData()
      {
        Debug.Assert(flagHasTerrierUploadReadData);
        return storeTerrierUploadReadData;
      }

    public bool  hasDisambiguateResultsBeforeAction()
      {
        return flagHasDisambiguateResultsBeforeAction;
      }

    public DisambiguateResultsBeforeActionJSON   getDisambiguateResultsBeforeAction()
      {
        Debug.Assert(flagHasDisambiguateResultsBeforeAction);
        return storeDisambiguateResultsBeforeAction;
      }

    public bool  getDisambiguateResultsBeforeActionValue()
      {
        return getDisambiguateResultsBeforeAction().getValue();
      }

    public bool  hasInputOverrideFunction()
      {
        return flagHasInputOverrideFunction;
      }

    public InputOverrideFunctionJSON   getInputOverrideFunction()
      {
        Debug.Assert(flagHasInputOverrideFunction);
        return storeInputOverrideFunction;
      }

    public string  getInputOverrideFunctionValue()
      {
        return getInputOverrideFunction().getValue();
      }

    public bool  hasInputOverrideFunctionLanguage()
      {
        return flagHasInputOverrideFunctionLanguage;
      }

    public UploadedCodeFunctionLanguageJSON   getInputOverrideFunctionLanguage()
      {
        Debug.Assert(flagHasInputOverrideFunctionLanguage);
        return storeInputOverrideFunctionLanguage;
      }

    public UploadedCodeFunctionLanguageJSON.TypeValue  getInputOverrideFunctionLanguageValue()
      {
        return getInputOverrideFunctionLanguage().getValue();
      }

    public string  getInputOverrideFunctionLanguageAsString()
      {
        return getInputOverrideFunctionLanguage().getValueAsString();
      }

    public bool  hasInputOverrideFunctionSource()
      {
        return flagHasInputOverrideFunctionSource;
      }

    public UploadedCodeSourceJSON   getInputOverrideFunctionSource()
      {
        Debug.Assert(flagHasInputOverrideFunctionSource);
        return storeInputOverrideFunctionSource;
      }

    public bool  hasInputOverrideDeleteFunction()
      {
        return flagHasInputOverrideDeleteFunction;
      }

    public RequestInfoBooleanFlagJSON   getInputOverrideDeleteFunction()
      {
        Debug.Assert(flagHasInputOverrideDeleteFunction);
        return storeInputOverrideDeleteFunction;
      }

    public bool  getInputOverrideDeleteFunctionValue()
      {
        return getInputOverrideDeleteFunction().getValue();
      }

    public bool  hasInputOverrideReadFunction()
      {
        return flagHasInputOverrideReadFunction;
      }

    public RequestInfoBooleanFlagJSON   getInputOverrideReadFunction()
      {
        Debug.Assert(flagHasInputOverrideReadFunction);
        return storeInputOverrideReadFunction;
      }

    public bool  getInputOverrideReadFunctionValue()
      {
        return getInputOverrideReadFunction().getValue();
      }

    public bool  hasSportsLeagueControl()
      {
        return flagHasSportsLeagueControl;
      }

    public SportsLeagueControlJSON   getSportsLeagueControl()
      {
        Debug.Assert(flagHasSportsLeagueControl);
        return storeSportsLeagueControl;
      }


    public virtual int extraRequestInfoComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRequestInfoComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRequestInfoComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRequestInfoLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setLatitude(double new_value)
      {
        flagHasLatitude = true;
        if (new_value < -90)
            throw new Exception("The value for field Latitude of RequestInfoJSON is less than the lower bound (-90) for that field.");
        if (new_value > 90)
            throw new Exception("The value for field Latitude of RequestInfoJSON is greater than the upper bound (90) for that field.");
        storeLatitude = new_value;
        textStoreLatitude = "";
      }
    public void setLatitudeText(string new_value)
      {
        flagHasLatitude = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Latitude of RequestInfoJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, true, "90", "", false, "2") < 0)
            throw new Exception("The value for field Latitude of RequestInfoJSON is less than the lower bound (-90) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "90", "", false, "2") > 0)
            throw new Exception("The value for field Latitude of RequestInfoJSON is greater than the upper bound (90) for that field.");
        textStoreLatitude = new_value;
      }
    public void unsetLatitude()
      {
        flagHasLatitude = false;
      }
    public void setLongitude(double new_value)
      {
        flagHasLongitude = true;
        if (new_value < -180)
            throw new Exception("The value for field Longitude of RequestInfoJSON is less than the lower bound (-180) for that field.");
        if (new_value > 180)
            throw new Exception("The value for field Longitude of RequestInfoJSON is greater than the upper bound (180) for that field.");
        storeLongitude = new_value;
        textStoreLongitude = "";
      }
    public void setLongitudeText(string new_value)
      {
        flagHasLongitude = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Longitude of RequestInfoJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, true, "180", "", false, "3") < 0)
            throw new Exception("The value for field Longitude of RequestInfoJSON is less than the lower bound (-180) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "180", "", false, "3") > 0)
            throw new Exception("The value for field Longitude of RequestInfoJSON is greater than the upper bound (180) for that field.");
        textStoreLongitude = new_value;
      }
    public void unsetLongitude()
      {
        flagHasLongitude = false;
      }
    public void setPositionTime(BigInteger new_value)
      {
        flagHasPositionTime = true;
        storePositionTime = new_value;
      }
    public void unsetPositionTime()
      {
        flagHasPositionTime = false;
      }
    public void setPositionHorizontalAccuracy(double new_value)
      {
        flagHasPositionHorizontalAccuracy = true;
        if (new_value < 0)
            throw new Exception("The value for field PositionHorizontalAccuracy of RequestInfoJSON is less than the lower bound (0) for that field.");
        storePositionHorizontalAccuracy = new_value;
        textStorePositionHorizontalAccuracy = "";
      }
    public void setPositionHorizontalAccuracyText(string new_value)
      {
        flagHasPositionHorizontalAccuracy = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field PositionHorizontalAccuracy of RequestInfoJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field PositionHorizontalAccuracy of RequestInfoJSON is less than the lower bound (0) for that field.");
        textStorePositionHorizontalAccuracy = new_value;
      }
    public void unsetPositionHorizontalAccuracy()
      {
        flagHasPositionHorizontalAccuracy = false;
      }
    public void setStreet(string new_value)
      {
        flagHasStreet = true;
        storeStreet = new_value;
      }
    public void unsetStreet()
      {
        flagHasStreet = false;
      }
    public void setCity(string new_value)
      {
        flagHasCity = true;
        storeCity = new_value;
      }
    public void unsetCity()
      {
        flagHasCity = false;
      }
    public void setState(string new_value)
      {
        flagHasState = true;
        storeState = new_value;
      }
    public void unsetState()
      {
        flagHasState = false;
      }
    public void setCountry(string new_value)
      {
        flagHasCountry = true;
        storeCountry = new_value;
      }
    public void unsetCountry()
      {
        flagHasCountry = false;
      }
    public void setRoutePoints(RoutePointsJSON  new_value)
      {
        if (flagHasRoutePoints)
          {
          }
        flagHasRoutePoints = true;
        storeRoutePoints = new_value;
      }
    public void unsetRoutePoints()
      {
        if (flagHasRoutePoints)
          {
          }
        flagHasRoutePoints = false;
      }
    public void setControllableTrackPlaying(bool new_value)
      {
        flagHasControllableTrackPlaying = true;
        storeControllableTrackPlaying = new_value;
      }
    public void unsetControllableTrackPlaying()
      {
        flagHasControllableTrackPlaying = false;
      }
    public void setTimeStamp(BigInteger new_value)
      {
        flagHasTimeStamp = true;
        storeTimeStamp = new_value;
      }
    public void unsetTimeStamp()
      {
        flagHasTimeStamp = false;
      }
    public void setTimeZone(string new_value)
      {
        flagHasTimeZone = true;
        storeTimeZone = new_value;
      }
    public void unsetTimeZone()
      {
        flagHasTimeZone = false;
      }
    public void setConversationState(ConversationStateJSON  new_value)
      {
        if (flagHasConversationState)
          {
          }
        flagHasConversationState = true;
        storeConversationState = new_value;
      }
    public void unsetConversationState()
      {
        if (flagHasConversationState)
          {
          }
        flagHasConversationState = false;
      }
    public void setClientState(ClientStateJSON  new_value)
      {
        if (flagHasClientState)
          {
          }
        flagHasClientState = true;
        storeClientState = new_value;
      }
    public void unsetClientState()
      {
        if (flagHasClientState)
          {
          }
        flagHasClientState = false;
      }
    public void setSendBack(JSONValue  new_value)
      {
        if (flagHasSendBack)
          {
          }
        flagHasSendBack = true;
        storeSendBack = new_value;
      }
    public void unsetSendBack()
      {
        if (flagHasSendBack)
          {
          }
        flagHasSendBack = false;
      }
    public void initPreferredImageSize()
      {
        flagHasPreferredImageSize = true;
        storePreferredImageSize.Clear();
      }
    public void appendPreferredImageSize(BigInteger to_append)
      {
        if (!flagHasPreferredImageSize)
          {
            flagHasPreferredImageSize = true;
            storePreferredImageSize.Clear();
          }
        Debug.Assert(flagHasPreferredImageSize);
        storePreferredImageSize.Add(to_append);
      }
    public void unsetPreferredImageSize()
      {
        flagHasPreferredImageSize = false;
        storePreferredImageSize.Clear();
      }
    public void setInputLanguageEnglishName(string new_value)
      {
        flagHasInputLanguageEnglishName = true;
        storeInputLanguageEnglishName = new_value;
      }
    public void unsetInputLanguageEnglishName()
      {
        flagHasInputLanguageEnglishName = false;
      }
    public void setInputLanguageNativeName(string new_value)
      {
        flagHasInputLanguageNativeName = true;
        storeInputLanguageNativeName = new_value;
      }
    public void unsetInputLanguageNativeName()
      {
        flagHasInputLanguageNativeName = false;
      }
    public void setInputLanguageIETFTag(string new_value)
      {
        flagHasInputLanguageIETFTag = true;
        storeInputLanguageIETFTag = new_value;
      }
    public void unsetInputLanguageIETFTag()
      {
        flagHasInputLanguageIETFTag = false;
      }
    public void setOutputLanguageEnglishName(string new_value)
      {
        flagHasOutputLanguageEnglishName = true;
        storeOutputLanguageEnglishName = new_value;
      }
    public void unsetOutputLanguageEnglishName()
      {
        flagHasOutputLanguageEnglishName = false;
      }
    public void setOutputLanguageNativeName(string new_value)
      {
        flagHasOutputLanguageNativeName = true;
        storeOutputLanguageNativeName = new_value;
      }
    public void unsetOutputLanguageNativeName()
      {
        flagHasOutputLanguageNativeName = false;
      }
    public void setOutputLanguageIETFTag(string new_value)
      {
        flagHasOutputLanguageIETFTag = true;
        storeOutputLanguageIETFTag = new_value;
      }
    public void unsetOutputLanguageIETFTag()
      {
        flagHasOutputLanguageIETFTag = false;
      }
    public void setResultVersionAccepted(double new_value)
      {
        flagHasResultVersionAccepted = true;
        if (new_value < 1)
            throw new Exception("The value for field ResultVersionAccepted of RequestInfoJSON is less than the lower bound (1) for that field.");
        storeResultVersionAccepted = new_value;
        textStoreResultVersionAccepted = "";
      }
    public void setResultVersionAcceptedText(string new_value)
      {
        flagHasResultVersionAccepted = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field ResultVersionAccepted of RequestInfoJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "1", "", false, "1") < 0)
            throw new Exception("The value for field ResultVersionAccepted of RequestInfoJSON is less than the lower bound (1) for that field.");
        textStoreResultVersionAccepted = new_value;
      }
    public void unsetResultVersionAccepted()
      {
        flagHasResultVersionAccepted = false;
      }
    public void setUnitPreference(TypeUnitPreference new_value)
      {
        flagHasUnitPreference = true;
        storeUnitPreference = new_value;
      }
    public void setUnitPreference(string chars)
      {
        setUnitPreference(stringToUnitPreference(chars));
      }
    public void unsetUnitPreference()
      {
        flagHasUnitPreference = false;
      }
    public void setDefaultTimeFormat24Hours(bool new_value)
      {
        flagHasDefaultTimeFormat24Hours = true;
        storeDefaultTimeFormat24Hours = new_value;
      }
    public void unsetDefaultTimeFormat24Hours()
      {
        flagHasDefaultTimeFormat24Hours = false;
      }
    public void setClientID(string new_value)
      {
        flagHasClientID = true;
        storeClientID = new_value;
      }
    public void unsetClientID()
      {
        flagHasClientID = false;
      }
    public void setClientVersion(TypeClientVersion new_value)
      {
        flagHasClientVersion = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                if (new_value.choice1 < 0)
                    throw new Exception("The value for case 1 of field ClientVersion of RequestInfoJSON is less than the lower bound (0) for that field.");
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeClientVersion = new_value;
      }
    public void unsetClientVersion()
      {
        flagHasClientVersion = false;
      }
    public void setDeviceID(string new_value)
      {
        flagHasDeviceID = true;
        storeDeviceID = new_value;
      }
    public void unsetDeviceID()
      {
        flagHasDeviceID = false;
      }
    public void setSDK(string new_value)
      {
        flagHasSDK = true;
        storeSDK = new_value;
      }
    public void unsetSDK()
      {
        flagHasSDK = false;
      }
    public void setSDKInfo(JSONObjectValue  new_value)
      {
        if (flagHasSDKInfo)
          {
          }
        flagHasSDKInfo = true;
        storeSDKInfo = new_value;
      }
    public void unsetSDKInfo()
      {
        if (flagHasSDKInfo)
          {
          }
        flagHasSDKInfo = false;
      }
    public void setFirstPersonSelf(string new_value)
      {
        flagHasFirstPersonSelf = true;
        storeFirstPersonSelf = new_value;
      }
    public void unsetFirstPersonSelf()
      {
        flagHasFirstPersonSelf = false;
      }
    public void setFirstPersonSelfSpoken(string new_value)
      {
        flagHasFirstPersonSelfSpoken = true;
        storeFirstPersonSelfSpoken = new_value;
      }
    public void unsetFirstPersonSelfSpoken()
      {
        flagHasFirstPersonSelfSpoken = false;
      }
    public void initSecondPersonSelf()
      {
        flagHasSecondPersonSelf = true;
        storeSecondPersonSelf.Clear();
      }
    public void appendSecondPersonSelf(string to_append)
      {
        if (!flagHasSecondPersonSelf)
          {
            flagHasSecondPersonSelf = true;
            storeSecondPersonSelf.Clear();
          }
        Debug.Assert(flagHasSecondPersonSelf);
        storeSecondPersonSelf.Add(to_append);
      }
    public void unsetSecondPersonSelf()
      {
        flagHasSecondPersonSelf = false;
        storeSecondPersonSelf.Clear();
      }
    public void initSecondPersonSelfSpoken()
      {
        flagHasSecondPersonSelfSpoken = true;
        storeSecondPersonSelfSpoken.Clear();
      }
    public void appendSecondPersonSelfSpoken(string to_append)
      {
        if (!flagHasSecondPersonSelfSpoken)
          {
            flagHasSecondPersonSelfSpoken = true;
            storeSecondPersonSelfSpoken.Clear();
          }
        Debug.Assert(flagHasSecondPersonSelfSpoken);
        storeSecondPersonSelfSpoken.Add(to_append);
      }
    public void unsetSecondPersonSelfSpoken()
      {
        flagHasSecondPersonSelfSpoken = false;
        storeSecondPersonSelfSpoken.Clear();
      }
    public void setWakeUpPattern(string new_value)
      {
        flagHasWakeUpPattern = true;
        storeWakeUpPattern = new_value;
      }
    public void unsetWakeUpPattern()
      {
        flagHasWakeUpPattern = false;
      }
    public void setUserID(string new_value)
      {
        flagHasUserID = true;
        storeUserID = new_value;
      }
    public void unsetUserID()
      {
        flagHasUserID = false;
      }
    public void setRequestID(string new_value)
      {
        flagHasRequestID = true;
        storeRequestID = new_value;
      }
    public void unsetRequestID()
      {
        flagHasRequestID = false;
      }
    public void setSessionID(string new_value)
      {
        flagHasSessionID = true;
        storeSessionID = new_value;
      }
    public void unsetSessionID()
      {
        flagHasSessionID = false;
      }
    public void setDomains(DomainsJSON  new_value)
      {
        if (flagHasDomains)
          {
          }
        flagHasDomains = true;
        storeDomains = new_value;
      }
    public void unsetDomains()
      {
        if (flagHasDomains)
          {
          }
        flagHasDomains = false;
      }
    public void setResultUpdateAllowed(bool new_value)
      {
        flagHasResultUpdateAllowed = true;
        storeResultUpdateAllowed = new_value;
      }
    public void unsetResultUpdateAllowed()
      {
        flagHasResultUpdateAllowed = false;
      }
    public void setPartialTranscriptsDesired(bool new_value)
      {
        flagHasPartialTranscriptsDesired = true;
        storePartialTranscriptsDesired = new_value;
      }
    public void unsetPartialTranscriptsDesired()
      {
        flagHasPartialTranscriptsDesired = false;
      }
    public void setMinResults(BigInteger new_value)
      {
        flagHasMinResults = true;
        if (new_value < 1)
            throw new Exception("The value for field MinResults of RequestInfoJSON is less than the lower bound (1) for that field.");
        storeMinResults = new_value;
      }
    public void unsetMinResults()
      {
        flagHasMinResults = false;
      }
    public void setMaxResults(BigInteger new_value)
      {
        flagHasMaxResults = true;
        if (new_value < 1)
            throw new Exception("The value for field MaxResults of RequestInfoJSON is less than the lower bound (1) for that field.");
        storeMaxResults = new_value;
      }
    public void unsetMaxResults()
      {
        flagHasMaxResults = false;
      }
    public void setObjectByteCountPrefix(bool new_value)
      {
        flagHasObjectByteCountPrefix = true;
        storeObjectByteCountPrefix = new_value;
      }
    public void unsetObjectByteCountPrefix()
      {
        flagHasObjectByteCountPrefix = false;
      }
    public void setProfanityFilter(TypeProfanityFilter new_value)
      {
        flagHasProfanityFilter = true;
        storeProfanityFilter = new_value;
      }
    public void setProfanityFilter(string chars)
      {
        setProfanityFilter(stringToProfanityFilter(chars));
      }
    public void unsetProfanityFilter()
      {
        flagHasProfanityFilter = false;
      }
    public void initClientMatches()
      {
        if (flagHasClientMatches)
          {
            for (int num1 = 0; num1 < storeClientMatches.Count; ++num1)
              {
              }
          }
        flagHasClientMatches = true;
        storeClientMatches.Clear();
      }
    public void appendClientMatches(ClientMatchJSON  to_append)
      {
        if (!flagHasClientMatches)
          {
            flagHasClientMatches = true;
            storeClientMatches.Clear();
          }
        Debug.Assert(flagHasClientMatches);
        storeClientMatches.Add(to_append);
      }
    public void unsetClientMatches()
      {
        if (flagHasClientMatches)
          {
            for (int num2 = 0; num2 < storeClientMatches.Count; ++num2)
              {
              }
          }
        flagHasClientMatches = false;
        storeClientMatches.Clear();
      }
    public void setClientMatchesOnly(bool new_value)
      {
        flagHasClientMatchesOnly = true;
        storeClientMatchesOnly = new_value;
      }
    public void unsetClientMatchesOnly()
      {
        flagHasClientMatchesOnly = false;
      }
    public void setPagination(PaginationJSON  new_value)
      {
        if (flagHasPagination)
          {
          }
        flagHasPagination = true;
        storePagination = new_value;
      }
    public void unsetPagination()
      {
        if (flagHasPagination)
          {
          }
        flagHasPagination = false;
      }
    public void setResponseAudioVoice(string new_value)
      {
        flagHasResponseAudioVoice = true;
        storeResponseAudioVoice = new_value;
      }
    public void unsetResponseAudioVoice()
      {
        flagHasResponseAudioVoice = false;
      }
    public void setResponseAudioShortOrLong(TypeResponseAudioShortOrLong new_value)
      {
        flagHasResponseAudioShortOrLong = true;
        storeResponseAudioShortOrLong = new_value;
      }
    public void setResponseAudioShortOrLong(string chars)
      {
        setResponseAudioShortOrLong(stringToResponseAudioShortOrLong(chars));
      }
    public void unsetResponseAudioShortOrLong()
      {
        flagHasResponseAudioShortOrLong = false;
      }
    public void initResponseAudioAcceptedEncodings()
      {
        flagHasResponseAudioAcceptedEncodings = true;
        storeResponseAudioAcceptedEncodings.Clear();
      }
    public void appendResponseAudioAcceptedEncodings(TypeResponseAudioAcceptedEncodings to_append)
      {
        if (!flagHasResponseAudioAcceptedEncodings)
          {
            flagHasResponseAudioAcceptedEncodings = true;
            storeResponseAudioAcceptedEncodings.Clear();
          }
        Debug.Assert(flagHasResponseAudioAcceptedEncodings);
        storeResponseAudioAcceptedEncodings.Add(to_append);
      }
    public void appendResponseAudioAcceptedEncodings(string chars)
      {
        TypeResponseAudioAcceptedEncodingsKnownValues known = stringToResponseAudioAcceptedEncodings(chars);
        TypeResponseAudioAcceptedEncodings new_value = new TypeResponseAudioAcceptedEncodings();
        if (known == TypeResponseAudioAcceptedEncodingsKnownValues.ResponseAudioAcceptedEncodings__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendResponseAudioAcceptedEncodings(new_value);
      }
    public void appendResponseAudioAcceptedEncodings(TypeResponseAudioAcceptedEncodingsKnownValues new_value)
      {
        TypeResponseAudioAcceptedEncodings new_full_value = new TypeResponseAudioAcceptedEncodings();
        Debug.Assert(new_value != TypeResponseAudioAcceptedEncodingsKnownValues.ResponseAudioAcceptedEncodings__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        appendResponseAudioAcceptedEncodings(new_full_value);
      }
    public void unsetResponseAudioAcceptedEncodings()
      {
        flagHasResponseAudioAcceptedEncodings = false;
        storeResponseAudioAcceptedEncodings.Clear();
      }
    public void setVoiceActivityDetection(VoiceActivityDetectionJSON  new_value)
      {
        if (flagHasVoiceActivityDetection)
          {
          }
        flagHasVoiceActivityDetection = true;
        storeVoiceActivityDetection = new_value;
      }
    public void unsetVoiceActivityDetection()
      {
        if (flagHasVoiceActivityDetection)
          {
          }
        flagHasVoiceActivityDetection = false;
      }
    public void setServerDeterminesEndOfAudio(bool new_value)
      {
        flagHasServerDeterminesEndOfAudio = true;
        storeServerDeterminesEndOfAudio = new_value;
      }
    public void unsetServerDeterminesEndOfAudio()
      {
        flagHasServerDeterminesEndOfAudio = false;
      }
    public void setIntentOnly(bool new_value)
      {
        flagHasIntentOnly = true;
        storeIntentOnly = new_value;
      }
    public void unsetIntentOnly()
      {
        flagHasIntentOnly = false;
      }
    public void setDisableSpellCorrection(bool new_value)
      {
        flagHasDisableSpellCorrection = true;
        storeDisableSpellCorrection = new_value;
      }
    public void unsetDisableSpellCorrection()
      {
        flagHasDisableSpellCorrection = false;
      }
    public void setUseContactData(bool new_value)
      {
        flagHasUseContactData = true;
        storeUseContactData = new_value;
      }
    public void unsetUseContactData()
      {
        flagHasUseContactData = false;
      }
    public void setUseClientTime(bool new_value)
      {
        flagHasUseClientTime = true;
        storeUseClientTime = new_value;
      }
    public void unsetUseClientTime()
      {
        flagHasUseClientTime = false;
      }
    public void setForceConversationStateTime(BigInteger new_value)
      {
        flagHasForceConversationStateTime = true;
        storeForceConversationStateTime = new_value;
      }
    public void unsetForceConversationStateTime()
      {
        flagHasForceConversationStateTime = false;
      }
    public void setPhoneDisambiguationOmitList(PhoneDisambiguationOmitListJSON  new_value)
      {
        if (flagHasPhoneDisambiguationOmitList)
          {
          }
        flagHasPhoneDisambiguationOmitList = true;
        storePhoneDisambiguationOmitList = new_value;
      }
    public void unsetPhoneDisambiguationOmitList()
      {
        if (flagHasPhoneDisambiguationOmitList)
          {
          }
        flagHasPhoneDisambiguationOmitList = false;
      }
    public void setIncomingCallPending(IncomingCallPendingJSON  new_value)
      {
        if (flagHasIncomingCallPending)
          {
          }
        flagHasIncomingCallPending = true;
        storeIncomingCallPending = new_value;
      }
    public void setIncomingCallPending(bool new_value)
      {
        setIncomingCallPending(new IncomingCallPendingJSON(new_value));
      }
    public void unsetIncomingCallPending()
      {
        if (flagHasIncomingCallPending)
          {
          }
        flagHasIncomingCallPending = false;
      }
    public void setAllowPopularNameContactMatches(AllowPopularNameContactMatchesJSON  new_value)
      {
        if (flagHasAllowPopularNameContactMatches)
          {
          }
        flagHasAllowPopularNameContactMatches = true;
        storeAllowPopularNameContactMatches = new_value;
      }
    public void setAllowPopularNameContactMatches(bool new_value)
      {
        setAllowPopularNameContactMatches(new AllowPopularNameContactMatchesJSON(new_value));
      }
    public void unsetAllowPopularNameContactMatches()
      {
        if (flagHasAllowPopularNameContactMatches)
          {
          }
        flagHasAllowPopularNameContactMatches = false;
      }
    public void setMusicClientState(MusicClientStateJSON  new_value)
      {
        if (flagHasMusicClientState)
          {
          }
        flagHasMusicClientState = true;
        storeMusicClientState = new_value;
      }
    public void unsetMusicClientState()
      {
        if (flagHasMusicClientState)
          {
          }
        flagHasMusicClientState = false;
      }
    public void setDisableMusicSearchListPositionSpecification(DisableListPositionSpecificationJSON  new_value)
      {
        if (flagHasDisableMusicSearchListPositionSpecification)
          {
          }
        flagHasDisableMusicSearchListPositionSpecification = true;
        storeDisableMusicSearchListPositionSpecification = new_value;
      }
    public void setDisableMusicSearchListPositionSpecification(bool new_value)
      {
        setDisableMusicSearchListPositionSpecification(new DisableListPositionSpecificationJSON(new_value));
      }
    public void unsetDisableMusicSearchListPositionSpecification()
      {
        if (flagHasDisableMusicSearchListPositionSpecification)
          {
          }
        flagHasDisableMusicSearchListPositionSpecification = false;
      }
    public void setCollateMusicEntities(CollateMusicEntitiesJSON  new_value)
      {
        if (flagHasCollateMusicEntities)
          {
          }
        flagHasCollateMusicEntities = true;
        storeCollateMusicEntities = new_value;
      }
    public void setCollateMusicEntities(bool new_value)
      {
        setCollateMusicEntities(new CollateMusicEntitiesJSON(new_value));
      }
    public void unsetCollateMusicEntities()
      {
        if (flagHasCollateMusicEntities)
          {
          }
        flagHasCollateMusicEntities = false;
      }
    public void setAllowContextFreeMusicSearchForPopularEntities(AllowContextFreeMusicSearchForPopularEntitiesJSON  new_value)
      {
        if (flagHasAllowContextFreeMusicSearchForPopularEntities)
          {
          }
        flagHasAllowContextFreeMusicSearchForPopularEntities = true;
        storeAllowContextFreeMusicSearchForPopularEntities = new_value;
      }
    public void setAllowContextFreeMusicSearchForPopularEntities(bool new_value)
      {
        setAllowContextFreeMusicSearchForPopularEntities(new AllowContextFreeMusicSearchForPopularEntitiesJSON(new_value));
      }
    public void unsetAllowContextFreeMusicSearchForPopularEntities()
      {
        if (flagHasAllowContextFreeMusicSearchForPopularEntities)
          {
          }
        flagHasAllowContextFreeMusicSearchForPopularEntities = false;
      }
    public void setReturnInformationNuggetsForMusicSearch(ReturnInformationNuggetsForMusicSearchJSON  new_value)
      {
        if (flagHasReturnInformationNuggetsForMusicSearch)
          {
          }
        flagHasReturnInformationNuggetsForMusicSearch = true;
        storeReturnInformationNuggetsForMusicSearch = new_value;
      }
    public void setReturnInformationNuggetsForMusicSearch(bool new_value)
      {
        setReturnInformationNuggetsForMusicSearch(new ReturnInformationNuggetsForMusicSearchJSON(new_value));
      }
    public void unsetReturnInformationNuggetsForMusicSearch()
      {
        if (flagHasReturnInformationNuggetsForMusicSearch)
          {
          }
        flagHasReturnInformationNuggetsForMusicSearch = false;
      }
    public void setUseXAPAPI(RequestInfoBooleanFlagJSON  new_value)
      {
        if (flagHasUseXAPAPI)
          {
          }
        flagHasUseXAPAPI = true;
        storeUseXAPAPI = new_value;
      }
    public void setUseXAPAPI(bool new_value)
      {
        setUseXAPAPI(new RequestInfoBooleanFlagJSON(new_value));
      }
    public void unsetUseXAPAPI()
      {
        if (flagHasUseXAPAPI)
          {
          }
        flagHasUseXAPAPI = false;
      }
    public void setLocalSearchClientState(LocalSearchClientStateJSON  new_value)
      {
        if (flagHasLocalSearchClientState)
          {
          }
        flagHasLocalSearchClientState = true;
        storeLocalSearchClientState = new_value;
      }
    public void unsetLocalSearchClientState()
      {
        if (flagHasLocalSearchClientState)
          {
          }
        flagHasLocalSearchClientState = false;
      }
    public void setUberServerToken(UberServerTokenJSON  new_value)
      {
        if (flagHasUberServerToken)
          {
          }
        flagHasUberServerToken = true;
        storeUberServerToken = new_value;
      }
    public void setUberServerToken(string new_value)
      {
        setUberServerToken(new UberServerTokenJSON(new_value));
      }
    public void unsetUberServerToken()
      {
        if (flagHasUberServerToken)
          {
          }
        flagHasUberServerToken = false;
      }
    public void setGetUberServerToken(GetUberServerTokenJSON  new_value)
      {
        if (flagHasGetUberServerToken)
          {
          }
        flagHasGetUberServerToken = true;
        storeGetUberServerToken = new_value;
      }
    public void setGetUberServerToken(bool new_value)
      {
        setGetUberServerToken(new GetUberServerTokenJSON(new_value));
      }
    public void unsetGetUberServerToken()
      {
        if (flagHasGetUberServerToken)
          {
          }
        flagHasGetUberServerToken = false;
      }
    public void setUberClientId(UberClientIdJSON  new_value)
      {
        if (flagHasUberClientId)
          {
          }
        flagHasUberClientId = true;
        storeUberClientId = new_value;
      }
    public void setUberClientId(string new_value)
      {
        setUberClientId(new UberClientIdJSON(new_value));
      }
    public void unsetUberClientId()
      {
        if (flagHasUberClientId)
          {
          }
        flagHasUberClientId = false;
      }
    public void setGetUberClientId(GetUberClientIdJSON  new_value)
      {
        if (flagHasGetUberClientId)
          {
          }
        flagHasGetUberClientId = true;
        storeGetUberClientId = new_value;
      }
    public void setGetUberClientId(bool new_value)
      {
        setGetUberClientId(new GetUberClientIdJSON(new_value));
      }
    public void unsetGetUberClientId()
      {
        if (flagHasGetUberClientId)
          {
          }
        flagHasGetUberClientId = false;
      }
    public void setSetUserMemoryLocation(SetUserMemoryLocationJSON  new_value)
      {
        if (flagHasSetUserMemoryLocation)
          {
          }
        flagHasSetUserMemoryLocation = true;
        storeSetUserMemoryLocation = new_value;
      }
    public void unsetSetUserMemoryLocation()
      {
        if (flagHasSetUserMemoryLocation)
          {
          }
        flagHasSetUserMemoryLocation = false;
      }
    public void setDisableMusicPlayerListPositionSpecification(DisableListPositionSpecificationJSON  new_value)
      {
        if (flagHasDisableMusicPlayerListPositionSpecification)
          {
          }
        flagHasDisableMusicPlayerListPositionSpecification = true;
        storeDisableMusicPlayerListPositionSpecification = new_value;
      }
    public void setDisableMusicPlayerListPositionSpecification(bool new_value)
      {
        setDisableMusicPlayerListPositionSpecification(new DisableListPositionSpecificationJSON(new_value));
      }
    public void unsetDisableMusicPlayerListPositionSpecification()
      {
        if (flagHasDisableMusicPlayerListPositionSpecification)
          {
          }
        flagHasDisableMusicPlayerListPositionSpecification = false;
      }
    public void setCarControlClimateClientConfiguration(CarControlClimateClientConfigurationJSON  new_value)
      {
        if (flagHasCarControlClimateClientConfiguration)
          {
          }
        flagHasCarControlClimateClientConfiguration = true;
        storeCarControlClimateClientConfiguration = new_value;
      }
    public void unsetCarControlClimateClientConfiguration()
      {
        if (flagHasCarControlClimateClientConfiguration)
          {
          }
        flagHasCarControlClimateClientConfiguration = false;
      }
    public void setHomeAutomationDomainSettings(HomeAutomationDomainSettingsJSON  new_value)
      {
        if (flagHasHomeAutomationDomainSettings)
          {
          }
        flagHasHomeAutomationDomainSettings = true;
        storeHomeAutomationDomainSettings = new_value;
      }
    public void unsetHomeAutomationDomainSettings()
      {
        if (flagHasHomeAutomationDomainSettings)
          {
          }
        flagHasHomeAutomationDomainSettings = false;
      }
    public void setUserContactsRequests(UserContactsRequestsJSON  new_value)
      {
        if (flagHasUserContactsRequests)
          {
          }
        flagHasUserContactsRequests = true;
        storeUserContactsRequests = new_value;
      }
    public void unsetUserContactsRequests()
      {
        if (flagHasUserContactsRequests)
          {
          }
        flagHasUserContactsRequests = false;
      }
    public void setStoredGlobalPagesToMatch(StoredPageMatchPageListJSON  new_value)
      {
        if (flagHasStoredGlobalPagesToMatch)
          {
          }
        flagHasStoredGlobalPagesToMatch = true;
        storeStoredGlobalPagesToMatch = new_value;
      }
    public void unsetStoredGlobalPagesToMatch()
      {
        if (flagHasStoredGlobalPagesToMatch)
          {
          }
        flagHasStoredGlobalPagesToMatch = false;
      }
    public void setStoredGlobalPagesToNotMatch(StoredPageMatchPageListJSON  new_value)
      {
        if (flagHasStoredGlobalPagesToNotMatch)
          {
          }
        flagHasStoredGlobalPagesToNotMatch = true;
        storeStoredGlobalPagesToNotMatch = new_value;
      }
    public void unsetStoredGlobalPagesToNotMatch()
      {
        if (flagHasStoredGlobalPagesToNotMatch)
          {
          }
        flagHasStoredGlobalPagesToNotMatch = false;
      }
    public void setStoredPerUserPagesToMatch(StoredPageMatchPageListJSON  new_value)
      {
        if (flagHasStoredPerUserPagesToMatch)
          {
          }
        flagHasStoredPerUserPagesToMatch = true;
        storeStoredPerUserPagesToMatch = new_value;
      }
    public void unsetStoredPerUserPagesToMatch()
      {
        if (flagHasStoredPerUserPagesToMatch)
          {
          }
        flagHasStoredPerUserPagesToMatch = false;
      }
    public void setStoredPerUserPagesToNotMatch(StoredPageMatchPageListJSON  new_value)
      {
        if (flagHasStoredPerUserPagesToNotMatch)
          {
          }
        flagHasStoredPerUserPagesToNotMatch = true;
        storeStoredPerUserPagesToNotMatch = new_value;
      }
    public void unsetStoredPerUserPagesToNotMatch()
      {
        if (flagHasStoredPerUserPagesToNotMatch)
          {
          }
        flagHasStoredPerUserPagesToNotMatch = false;
      }
    public void setStoredGlobalPagesToSetOnByDefault(StoredPageMatchPageListJSON  new_value)
      {
        if (flagHasStoredGlobalPagesToSetOnByDefault)
          {
          }
        flagHasStoredGlobalPagesToSetOnByDefault = true;
        storeStoredGlobalPagesToSetOnByDefault = new_value;
      }
    public void unsetStoredGlobalPagesToSetOnByDefault()
      {
        if (flagHasStoredGlobalPagesToSetOnByDefault)
          {
          }
        flagHasStoredGlobalPagesToSetOnByDefault = false;
      }
    public void setStoredPerUserPagesToSetOnByDefault(StoredPageMatchPageListJSON  new_value)
      {
        if (flagHasStoredPerUserPagesToSetOnByDefault)
          {
          }
        flagHasStoredPerUserPagesToSetOnByDefault = true;
        storeStoredPerUserPagesToSetOnByDefault = new_value;
      }
    public void unsetStoredPerUserPagesToSetOnByDefault()
      {
        if (flagHasStoredPerUserPagesToSetOnByDefault)
          {
          }
        flagHasStoredPerUserPagesToSetOnByDefault = false;
      }
    public void setStoredGlobalPagesToSetOffByDefault(StoredPageMatchPageListJSON  new_value)
      {
        if (flagHasStoredGlobalPagesToSetOffByDefault)
          {
          }
        flagHasStoredGlobalPagesToSetOffByDefault = true;
        storeStoredGlobalPagesToSetOffByDefault = new_value;
      }
    public void unsetStoredGlobalPagesToSetOffByDefault()
      {
        if (flagHasStoredGlobalPagesToSetOffByDefault)
          {
          }
        flagHasStoredGlobalPagesToSetOffByDefault = false;
      }
    public void setStoredPerUserPagesToSetOffByDefault(StoredPageMatchPageListJSON  new_value)
      {
        if (flagHasStoredPerUserPagesToSetOffByDefault)
          {
          }
        flagHasStoredPerUserPagesToSetOffByDefault = true;
        storeStoredPerUserPagesToSetOffByDefault = new_value;
      }
    public void unsetStoredPerUserPagesToSetOffByDefault()
      {
        if (flagHasStoredPerUserPagesToSetOffByDefault)
          {
          }
        flagHasStoredPerUserPagesToSetOffByDefault = false;
      }
    public void setStoredPageMatchWriteData(StoredPageMatchWriteDataJSON  new_value)
      {
        if (flagHasStoredPageMatchWriteData)
          {
          }
        flagHasStoredPageMatchWriteData = true;
        storeStoredPageMatchWriteData = new_value;
      }
    public void unsetStoredPageMatchWriteData()
      {
        if (flagHasStoredPageMatchWriteData)
          {
          }
        flagHasStoredPageMatchWriteData = false;
      }
    public void setStoredPageMatchReadData(StoredPageMatchReadDataJSON  new_value)
      {
        if (flagHasStoredPageMatchReadData)
          {
          }
        flagHasStoredPageMatchReadData = true;
        storeStoredPageMatchReadData = new_value;
      }
    public void unsetStoredPageMatchReadData()
      {
        if (flagHasStoredPageMatchReadData)
          {
          }
        flagHasStoredPageMatchReadData = false;
      }
    public void setStoredPageMatchPageListData(StoredPageMatchPageListDataJSON  new_value)
      {
        if (flagHasStoredPageMatchPageListData)
          {
          }
        flagHasStoredPageMatchPageListData = true;
        storeStoredPageMatchPageListData = new_value;
      }
    public void unsetStoredPageMatchPageListData()
      {
        if (flagHasStoredPageMatchPageListData)
          {
          }
        flagHasStoredPageMatchPageListData = false;
      }
    public void setVoiceParameters(VoiceParametersJSON  new_value)
      {
        if (flagHasVoiceParameters)
          {
          }
        flagHasVoiceParameters = true;
        storeVoiceParameters = new_value;
      }
    public void unsetVoiceParameters()
      {
        if (flagHasVoiceParameters)
          {
          }
        flagHasVoiceParameters = false;
      }
    public void setStoredAlwaysMatchWriteData(ClientMatchesJSON  new_value)
      {
        if (flagHasStoredAlwaysMatchWriteData)
          {
          }
        flagHasStoredAlwaysMatchWriteData = true;
        storeStoredAlwaysMatchWriteData = new_value;
      }
    public void unsetStoredAlwaysMatchWriteData()
      {
        if (flagHasStoredAlwaysMatchWriteData)
          {
          }
        flagHasStoredAlwaysMatchWriteData = false;
      }
    public void setStoredAlwaysMatchReadData(StoredAlwaysMatchReadDataJSON  new_value)
      {
        if (flagHasStoredAlwaysMatchReadData)
          {
          }
        flagHasStoredAlwaysMatchReadData = true;
        storeStoredAlwaysMatchReadData = new_value;
      }
    public void setStoredAlwaysMatchReadData(bool new_value)
      {
        setStoredAlwaysMatchReadData(new StoredAlwaysMatchReadDataJSON(new_value));
      }
    public void unsetStoredAlwaysMatchReadData()
      {
        if (flagHasStoredAlwaysMatchReadData)
          {
          }
        flagHasStoredAlwaysMatchReadData = false;
      }
    public void setUserFeedback(UserFeedbackJSON  new_value)
      {
        if (flagHasUserFeedback)
          {
          }
        flagHasUserFeedback = true;
        storeUserFeedback = new_value;
      }
    public void unsetUserFeedback()
      {
        if (flagHasUserFeedback)
          {
          }
        flagHasUserFeedback = false;
      }
    public void setRadioControlRecognizeNorthAmericanFMBand(RadioControlRecognizeNorthAmericanFMBandJSON  new_value)
      {
        if (flagHasRadioControlRecognizeNorthAmericanFMBand)
          {
          }
        flagHasRadioControlRecognizeNorthAmericanFMBand = true;
        storeRadioControlRecognizeNorthAmericanFMBand = new_value;
      }
    public void setRadioControlRecognizeNorthAmericanFMBand(bool new_value)
      {
        setRadioControlRecognizeNorthAmericanFMBand(new RadioControlRecognizeNorthAmericanFMBandJSON(new_value));
      }
    public void unsetRadioControlRecognizeNorthAmericanFMBand()
      {
        if (flagHasRadioControlRecognizeNorthAmericanFMBand)
          {
          }
        flagHasRadioControlRecognizeNorthAmericanFMBand = false;
      }
    public void setRadioControlRecognizeNorthAmericanAMBand(RadioControlRecognizeNorthAmericanAMBandJSON  new_value)
      {
        if (flagHasRadioControlRecognizeNorthAmericanAMBand)
          {
          }
        flagHasRadioControlRecognizeNorthAmericanAMBand = true;
        storeRadioControlRecognizeNorthAmericanAMBand = new_value;
      }
    public void setRadioControlRecognizeNorthAmericanAMBand(bool new_value)
      {
        setRadioControlRecognizeNorthAmericanAMBand(new RadioControlRecognizeNorthAmericanAMBandJSON(new_value));
      }
    public void unsetRadioControlRecognizeNorthAmericanAMBand()
      {
        if (flagHasRadioControlRecognizeNorthAmericanAMBand)
          {
          }
        flagHasRadioControlRecognizeNorthAmericanAMBand = false;
      }
    public void setRadioControlOtherFMBands(RadioControlOtherFMBandsJSON  new_value)
      {
        if (flagHasRadioControlOtherFMBands)
          {
          }
        flagHasRadioControlOtherFMBands = true;
        storeRadioControlOtherFMBands = new_value;
      }
    public void unsetRadioControlOtherFMBands()
      {
        if (flagHasRadioControlOtherFMBands)
          {
          }
        flagHasRadioControlOtherFMBands = false;
      }
    public void setRadioControlOtherAMBands(RadioControlOtherAMBandsJSON  new_value)
      {
        if (flagHasRadioControlOtherAMBands)
          {
          }
        flagHasRadioControlOtherAMBands = true;
        storeRadioControlOtherAMBands = new_value;
      }
    public void unsetRadioControlOtherAMBands()
      {
        if (flagHasRadioControlOtherAMBands)
          {
          }
        flagHasRadioControlOtherAMBands = false;
      }
    public void setRadioControlAvailableAudioSources(RadioControlAvailableAudioSourcesJSON  new_value)
      {
        if (flagHasRadioControlAvailableAudioSources)
          {
          }
        flagHasRadioControlAvailableAudioSources = true;
        storeRadioControlAvailableAudioSources = new_value;
      }
    public void unsetRadioControlAvailableAudioSources()
      {
        if (flagHasRadioControlAvailableAudioSources)
          {
          }
        flagHasRadioControlAvailableAudioSources = false;
      }
    public void setClientListMatches(ClientListMatchesJSON  new_value)
      {
        if (flagHasClientListMatches)
          {
          }
        flagHasClientListMatches = true;
        storeClientListMatches = new_value;
      }
    public void unsetClientListMatches()
      {
        if (flagHasClientListMatches)
          {
          }
        flagHasClientListMatches = false;
      }
    public void setIntentToExecute(CommandIntentJSON  new_value)
      {
        if (flagHasIntentToExecute)
          {
          }
        flagHasIntentToExecute = true;
        storeIntentToExecute = new_value;
      }
    public void unsetIntentToExecute()
      {
        if (flagHasIntentToExecute)
          {
          }
        flagHasIntentToExecute = false;
      }
    public void setRobotInfo(RobotInfoJSON  new_value)
      {
        if (flagHasRobotInfo)
          {
          }
        flagHasRobotInfo = true;
        storeRobotInfo = new_value;
      }
    public void unsetRobotInfo()
      {
        if (flagHasRobotInfo)
          {
          }
        flagHasRobotInfo = false;
      }
    public void setConvertToNewInformationNuggets(ConvertToNewInformationNuggetsJSON  new_value)
      {
        if (flagHasConvertToNewInformationNuggets)
          {
          }
        flagHasConvertToNewInformationNuggets = true;
        storeConvertToNewInformationNuggets = new_value;
      }
    public void setConvertToNewInformationNuggets(bool new_value)
      {
        setConvertToNewInformationNuggets(new ConvertToNewInformationNuggetsJSON(new_value));
      }
    public void unsetConvertToNewInformationNuggets()
      {
        if (flagHasConvertToNewInformationNuggets)
          {
          }
        flagHasConvertToNewInformationNuggets = false;
      }
    public void setAcapelaVoiceParameters(AcapelaVoiceParametersJSON  new_value)
      {
        if (flagHasAcapelaVoiceParameters)
          {
          }
        flagHasAcapelaVoiceParameters = true;
        storeAcapelaVoiceParameters = new_value;
      }
    public void unsetAcapelaVoiceParameters()
      {
        if (flagHasAcapelaVoiceParameters)
          {
          }
        flagHasAcapelaVoiceParameters = false;
      }
    public void setOutputOverrideCommandIsPreAudioOut(RequestInfoBooleanFlagJSON  new_value)
      {
        if (flagHasOutputOverrideCommandIsPreAudioOut)
          {
          }
        flagHasOutputOverrideCommandIsPreAudioOut = true;
        storeOutputOverrideCommandIsPreAudioOut = new_value;
      }
    public void setOutputOverrideCommandIsPreAudioOut(bool new_value)
      {
        setOutputOverrideCommandIsPreAudioOut(new RequestInfoBooleanFlagJSON(new_value));
      }
    public void unsetOutputOverrideCommandIsPreAudioOut()
      {
        if (flagHasOutputOverrideCommandIsPreAudioOut)
          {
          }
        flagHasOutputOverrideCommandIsPreAudioOut = false;
      }
    public void setOutputOverrideCommandFunction(OutputOverrideFunctionJSON  new_value)
      {
        if (flagHasOutputOverrideCommandFunction)
          {
          }
        flagHasOutputOverrideCommandFunction = true;
        storeOutputOverrideCommandFunction = new_value;
      }
    public void setOutputOverrideCommandFunction(string new_value)
      {
        setOutputOverrideCommandFunction(new OutputOverrideFunctionJSON(new_value));
      }
    public void unsetOutputOverrideCommandFunction()
      {
        if (flagHasOutputOverrideCommandFunction)
          {
          }
        flagHasOutputOverrideCommandFunction = false;
      }
    public void setOutputOverrideCommandFunctionLanguage(UploadedCodeFunctionLanguageJSON  new_value)
      {
        if (flagHasOutputOverrideCommandFunctionLanguage)
          {
          }
        flagHasOutputOverrideCommandFunctionLanguage = true;
        storeOutputOverrideCommandFunctionLanguage = new_value;
      }
    public void setOutputOverrideCommandFunctionLanguage(UploadedCodeFunctionLanguageJSON.TypeValue new_value)
      {
        setOutputOverrideCommandFunctionLanguage(new UploadedCodeFunctionLanguageJSON(new_value));
      }
    public void setOutputOverrideCommandFunctionLanguage(string chars)
      {
        UploadedCodeFunctionLanguageJSON.TypeValueKnownValues known = UploadedCodeFunctionLanguageJSON.stringToValue(chars);
        UploadedCodeFunctionLanguageJSON.TypeValue new_value = new UploadedCodeFunctionLanguageJSON.TypeValue();
        if (known == UploadedCodeFunctionLanguageJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setOutputOverrideCommandFunctionLanguage(new_value);
      }
    public void unsetOutputOverrideCommandFunctionLanguage()
      {
        if (flagHasOutputOverrideCommandFunctionLanguage)
          {
          }
        flagHasOutputOverrideCommandFunctionLanguage = false;
      }
    public void setOutputOverrideCommandFunctionSource(UploadedCodeSourceJSON  new_value)
      {
        if (flagHasOutputOverrideCommandFunctionSource)
          {
          }
        flagHasOutputOverrideCommandFunctionSource = true;
        storeOutputOverrideCommandFunctionSource = new_value;
      }
    public void unsetOutputOverrideCommandFunctionSource()
      {
        if (flagHasOutputOverrideCommandFunctionSource)
          {
          }
        flagHasOutputOverrideCommandFunctionSource = false;
      }
    public void setOutputOverrideDeleteCommandFunction(RequestInfoBooleanFlagJSON  new_value)
      {
        if (flagHasOutputOverrideDeleteCommandFunction)
          {
          }
        flagHasOutputOverrideDeleteCommandFunction = true;
        storeOutputOverrideDeleteCommandFunction = new_value;
      }
    public void setOutputOverrideDeleteCommandFunction(bool new_value)
      {
        setOutputOverrideDeleteCommandFunction(new RequestInfoBooleanFlagJSON(new_value));
      }
    public void unsetOutputOverrideDeleteCommandFunction()
      {
        if (flagHasOutputOverrideDeleteCommandFunction)
          {
          }
        flagHasOutputOverrideDeleteCommandFunction = false;
      }
    public void setOutputOverrideReadCommandFunction(RequestInfoBooleanFlagJSON  new_value)
      {
        if (flagHasOutputOverrideReadCommandFunction)
          {
          }
        flagHasOutputOverrideReadCommandFunction = true;
        storeOutputOverrideReadCommandFunction = new_value;
      }
    public void setOutputOverrideReadCommandFunction(bool new_value)
      {
        setOutputOverrideReadCommandFunction(new RequestInfoBooleanFlagJSON(new_value));
      }
    public void unsetOutputOverrideReadCommandFunction()
      {
        if (flagHasOutputOverrideReadCommandFunction)
          {
          }
        flagHasOutputOverrideReadCommandFunction = false;
      }
    public void setOutputOverrideInformationNuggetFunction(OutputOverrideFunctionJSON  new_value)
      {
        if (flagHasOutputOverrideInformationNuggetFunction)
          {
          }
        flagHasOutputOverrideInformationNuggetFunction = true;
        storeOutputOverrideInformationNuggetFunction = new_value;
      }
    public void setOutputOverrideInformationNuggetFunction(string new_value)
      {
        setOutputOverrideInformationNuggetFunction(new OutputOverrideFunctionJSON(new_value));
      }
    public void unsetOutputOverrideInformationNuggetFunction()
      {
        if (flagHasOutputOverrideInformationNuggetFunction)
          {
          }
        flagHasOutputOverrideInformationNuggetFunction = false;
      }
    public void setOutputOverrideInformationNuggetFunctionLanguage(UploadedCodeFunctionLanguageJSON  new_value)
      {
        if (flagHasOutputOverrideInformationNuggetFunctionLanguage)
          {
          }
        flagHasOutputOverrideInformationNuggetFunctionLanguage = true;
        storeOutputOverrideInformationNuggetFunctionLanguage = new_value;
      }
    public void setOutputOverrideInformationNuggetFunctionLanguage(UploadedCodeFunctionLanguageJSON.TypeValue new_value)
      {
        setOutputOverrideInformationNuggetFunctionLanguage(new UploadedCodeFunctionLanguageJSON(new_value));
      }
    public void setOutputOverrideInformationNuggetFunctionLanguage(string chars)
      {
        UploadedCodeFunctionLanguageJSON.TypeValueKnownValues known = UploadedCodeFunctionLanguageJSON.stringToValue(chars);
        UploadedCodeFunctionLanguageJSON.TypeValue new_value = new UploadedCodeFunctionLanguageJSON.TypeValue();
        if (known == UploadedCodeFunctionLanguageJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setOutputOverrideInformationNuggetFunctionLanguage(new_value);
      }
    public void unsetOutputOverrideInformationNuggetFunctionLanguage()
      {
        if (flagHasOutputOverrideInformationNuggetFunctionLanguage)
          {
          }
        flagHasOutputOverrideInformationNuggetFunctionLanguage = false;
      }
    public void setOutputOverrideInformationNuggetFunctionSource(UploadedCodeSourceJSON  new_value)
      {
        if (flagHasOutputOverrideInformationNuggetFunctionSource)
          {
          }
        flagHasOutputOverrideInformationNuggetFunctionSource = true;
        storeOutputOverrideInformationNuggetFunctionSource = new_value;
      }
    public void unsetOutputOverrideInformationNuggetFunctionSource()
      {
        if (flagHasOutputOverrideInformationNuggetFunctionSource)
          {
          }
        flagHasOutputOverrideInformationNuggetFunctionSource = false;
      }
    public void setOutputOverrideDeleteInformationNuggetFunction(RequestInfoBooleanFlagJSON  new_value)
      {
        if (flagHasOutputOverrideDeleteInformationNuggetFunction)
          {
          }
        flagHasOutputOverrideDeleteInformationNuggetFunction = true;
        storeOutputOverrideDeleteInformationNuggetFunction = new_value;
      }
    public void setOutputOverrideDeleteInformationNuggetFunction(bool new_value)
      {
        setOutputOverrideDeleteInformationNuggetFunction(new RequestInfoBooleanFlagJSON(new_value));
      }
    public void unsetOutputOverrideDeleteInformationNuggetFunction()
      {
        if (flagHasOutputOverrideDeleteInformationNuggetFunction)
          {
          }
        flagHasOutputOverrideDeleteInformationNuggetFunction = false;
      }
    public void setOutputOverrideReadInformationNuggetFunction(RequestInfoBooleanFlagJSON  new_value)
      {
        if (flagHasOutputOverrideReadInformationNuggetFunction)
          {
          }
        flagHasOutputOverrideReadInformationNuggetFunction = true;
        storeOutputOverrideReadInformationNuggetFunction = new_value;
      }
    public void setOutputOverrideReadInformationNuggetFunction(bool new_value)
      {
        setOutputOverrideReadInformationNuggetFunction(new RequestInfoBooleanFlagJSON(new_value));
      }
    public void unsetOutputOverrideReadInformationNuggetFunction()
      {
        if (flagHasOutputOverrideReadInformationNuggetFunction)
          {
          }
        flagHasOutputOverrideReadInformationNuggetFunction = false;
      }
    public void setTerrierUploadWriteData(TerrierUploadWriteDataJSON  new_value)
      {
        if (flagHasTerrierUploadWriteData)
          {
          }
        flagHasTerrierUploadWriteData = true;
        storeTerrierUploadWriteData = new_value;
      }
    public void unsetTerrierUploadWriteData()
      {
        if (flagHasTerrierUploadWriteData)
          {
          }
        flagHasTerrierUploadWriteData = false;
      }
    public void setTerrierUploadReadData(TerrierUploadReadDataJSON  new_value)
      {
        if (flagHasTerrierUploadReadData)
          {
          }
        flagHasTerrierUploadReadData = true;
        storeTerrierUploadReadData = new_value;
      }
    public void unsetTerrierUploadReadData()
      {
        if (flagHasTerrierUploadReadData)
          {
          }
        flagHasTerrierUploadReadData = false;
      }
    public void setDisambiguateResultsBeforeAction(DisambiguateResultsBeforeActionJSON  new_value)
      {
        if (flagHasDisambiguateResultsBeforeAction)
          {
          }
        flagHasDisambiguateResultsBeforeAction = true;
        storeDisambiguateResultsBeforeAction = new_value;
      }
    public void setDisambiguateResultsBeforeAction(bool new_value)
      {
        setDisambiguateResultsBeforeAction(new DisambiguateResultsBeforeActionJSON(new_value));
      }
    public void unsetDisambiguateResultsBeforeAction()
      {
        if (flagHasDisambiguateResultsBeforeAction)
          {
          }
        flagHasDisambiguateResultsBeforeAction = false;
      }
    public void setInputOverrideFunction(InputOverrideFunctionJSON  new_value)
      {
        if (flagHasInputOverrideFunction)
          {
          }
        flagHasInputOverrideFunction = true;
        storeInputOverrideFunction = new_value;
      }
    public void setInputOverrideFunction(string new_value)
      {
        setInputOverrideFunction(new InputOverrideFunctionJSON(new_value));
      }
    public void unsetInputOverrideFunction()
      {
        if (flagHasInputOverrideFunction)
          {
          }
        flagHasInputOverrideFunction = false;
      }
    public void setInputOverrideFunctionLanguage(UploadedCodeFunctionLanguageJSON  new_value)
      {
        if (flagHasInputOverrideFunctionLanguage)
          {
          }
        flagHasInputOverrideFunctionLanguage = true;
        storeInputOverrideFunctionLanguage = new_value;
      }
    public void setInputOverrideFunctionLanguage(UploadedCodeFunctionLanguageJSON.TypeValue new_value)
      {
        setInputOverrideFunctionLanguage(new UploadedCodeFunctionLanguageJSON(new_value));
      }
    public void setInputOverrideFunctionLanguage(string chars)
      {
        UploadedCodeFunctionLanguageJSON.TypeValueKnownValues known = UploadedCodeFunctionLanguageJSON.stringToValue(chars);
        UploadedCodeFunctionLanguageJSON.TypeValue new_value = new UploadedCodeFunctionLanguageJSON.TypeValue();
        if (known == UploadedCodeFunctionLanguageJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setInputOverrideFunctionLanguage(new_value);
      }
    public void unsetInputOverrideFunctionLanguage()
      {
        if (flagHasInputOverrideFunctionLanguage)
          {
          }
        flagHasInputOverrideFunctionLanguage = false;
      }
    public void setInputOverrideFunctionSource(UploadedCodeSourceJSON  new_value)
      {
        if (flagHasInputOverrideFunctionSource)
          {
          }
        flagHasInputOverrideFunctionSource = true;
        storeInputOverrideFunctionSource = new_value;
      }
    public void unsetInputOverrideFunctionSource()
      {
        if (flagHasInputOverrideFunctionSource)
          {
          }
        flagHasInputOverrideFunctionSource = false;
      }
    public void setInputOverrideDeleteFunction(RequestInfoBooleanFlagJSON  new_value)
      {
        if (flagHasInputOverrideDeleteFunction)
          {
          }
        flagHasInputOverrideDeleteFunction = true;
        storeInputOverrideDeleteFunction = new_value;
      }
    public void setInputOverrideDeleteFunction(bool new_value)
      {
        setInputOverrideDeleteFunction(new RequestInfoBooleanFlagJSON(new_value));
      }
    public void unsetInputOverrideDeleteFunction()
      {
        if (flagHasInputOverrideDeleteFunction)
          {
          }
        flagHasInputOverrideDeleteFunction = false;
      }
    public void setInputOverrideReadFunction(RequestInfoBooleanFlagJSON  new_value)
      {
        if (flagHasInputOverrideReadFunction)
          {
          }
        flagHasInputOverrideReadFunction = true;
        storeInputOverrideReadFunction = new_value;
      }
    public void setInputOverrideReadFunction(bool new_value)
      {
        setInputOverrideReadFunction(new RequestInfoBooleanFlagJSON(new_value));
      }
    public void unsetInputOverrideReadFunction()
      {
        if (flagHasInputOverrideReadFunction)
          {
          }
        flagHasInputOverrideReadFunction = false;
      }
    public void setSportsLeagueControl(SportsLeagueControlJSON  new_value)
      {
        if (flagHasSportsLeagueControl)
          {
          }
        flagHasSportsLeagueControl = true;
        storeSportsLeagueControl = new_value;
      }
    public void unsetSportsLeagueControl()
      {
        if (flagHasSportsLeagueControl)
          {
          }
        flagHasSportsLeagueControl = false;
      }

    public virtual void extraRequestInfoAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRequestInfoSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRequestInfoLookup(key);
        if (old_field == null)
          {
            extraRequestInfoAppendPair(key, new_component);
          }
        else
          {
            int count = extraKeys.Count;
            Debug.Assert(count == extraValues.Count);
            for (int num = 0; num < count; ++num)
              {
                if (extraKeys[num].Equals( key))
                  {
                    extraValues[num] = new_component;
                    break;
                  }
              }
            extraIndex.Add(key, new_component);
          }
      }

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        int extra_count = extraKeys.Count;
        Debug.Assert(extra_count == extraValues.Count);
        for (int extra_num = 0; extra_num < extra_count; ++extra_num)
          {
            handler.start_pair(extraKeys[extra_num]);
            extraValues[extra_num].write(handler);
          }
        handler.finish_object();
      }

    public virtual void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        if (flagHasLatitude)
          {
            handler.start_pair("Latitude");
            if (textStoreLatitude != "")
                handler.number_value(textStoreLatitude);
            else if (((double)(long)storeLatitude) == storeLatitude)
                handler.number_value((long)storeLatitude);
            else
                handler.number_value(storeLatitude);
          }
        if (flagHasLongitude)
          {
            handler.start_pair("Longitude");
            if (textStoreLongitude != "")
                handler.number_value(textStoreLongitude);
            else if (((double)(long)storeLongitude) == storeLongitude)
                handler.number_value((long)storeLongitude);
            else
                handler.number_value(storeLongitude);
          }
        if (flagHasPositionTime)
          {
            handler.start_pair("PositionTime");
            handler.number_value(storePositionTime);
          }
        if (flagHasPositionHorizontalAccuracy)
          {
            handler.start_pair("PositionHorizontalAccuracy");
            if (textStorePositionHorizontalAccuracy != "")
                handler.number_value(textStorePositionHorizontalAccuracy);
            else if (((double)(long)storePositionHorizontalAccuracy) == storePositionHorizontalAccuracy)
                handler.number_value((long)storePositionHorizontalAccuracy);
            else
                handler.number_value(storePositionHorizontalAccuracy);
          }
        if (flagHasStreet)
          {
            handler.start_pair("Street");
            handler.string_value(storeStreet);
          }
        if (flagHasCity)
          {
            handler.start_pair("City");
            handler.string_value(storeCity);
          }
        if (flagHasState)
          {
            handler.start_pair("State");
            handler.string_value(storeState);
          }
        if (flagHasCountry)
          {
            handler.start_pair("Country");
            handler.string_value(storeCountry);
          }
        if (flagHasRoutePoints)
          {
            handler.start_pair("RoutePoints");
            if (partial_allowed)
                storeRoutePoints.write_partial_as_json(handler);
            else
                storeRoutePoints.write_as_json(handler);
          }
        if (flagHasControllableTrackPlaying)
          {
            handler.start_pair("ControllableTrackPlaying");
            handler.boolean_value(storeControllableTrackPlaying);
          }
        if (flagHasTimeStamp)
          {
            handler.start_pair("TimeStamp");
            handler.number_value(storeTimeStamp);
          }
        if (flagHasTimeZone)
          {
            handler.start_pair("TimeZone");
            handler.string_value(storeTimeZone);
          }
        if (flagHasConversationState)
          {
            handler.start_pair("ConversationState");
            if (partial_allowed)
                storeConversationState.write_partial_as_json(handler);
            else
                storeConversationState.write_as_json(handler);
          }
        if (flagHasClientState)
          {
            handler.start_pair("ClientState");
            if (partial_allowed)
                storeClientState.write_partial_as_json(handler);
            else
                storeClientState.write_as_json(handler);
          }
        if (flagHasSendBack)
          {
            handler.start_pair("SendBack");
            storeSendBack.write(handler);
          }
        if (flagHasPreferredImageSize)
          {
            handler.start_pair("PreferredImageSize");
            Debug.Assert(storePreferredImageSize.Count >= 2);
            handler.start_array();
            for (int num1 = 0; num1 < storePreferredImageSize.Count; ++num1)
              {
                handler.number_value(storePreferredImageSize[num1]);
              }
            handler.finish_array();
          }
        if (flagHasInputLanguageEnglishName)
          {
            handler.start_pair("InputLanguageEnglishName");
            handler.string_value(storeInputLanguageEnglishName);
          }
        if (flagHasInputLanguageNativeName)
          {
            handler.start_pair("InputLanguageNativeName");
            handler.string_value(storeInputLanguageNativeName);
          }
        if (flagHasInputLanguageIETFTag)
          {
            handler.start_pair("InputLanguageIETFTag");
            handler.string_value(storeInputLanguageIETFTag);
          }
        if (flagHasOutputLanguageEnglishName)
          {
            handler.start_pair("OutputLanguageEnglishName");
            handler.string_value(storeOutputLanguageEnglishName);
          }
        if (flagHasOutputLanguageNativeName)
          {
            handler.start_pair("OutputLanguageNativeName");
            handler.string_value(storeOutputLanguageNativeName);
          }
        if (flagHasOutputLanguageIETFTag)
          {
            handler.start_pair("OutputLanguageIETFTag");
            handler.string_value(storeOutputLanguageIETFTag);
          }
        if (flagHasResultVersionAccepted)
          {
            handler.start_pair("ResultVersionAccepted");
            if (textStoreResultVersionAccepted != "")
                handler.number_value(textStoreResultVersionAccepted);
            else if (((double)(long)storeResultVersionAccepted) == storeResultVersionAccepted)
                handler.number_value((long)storeResultVersionAccepted);
            else
                handler.number_value(storeResultVersionAccepted);
          }
        if (flagHasUnitPreference)
          {
            handler.start_pair("UnitPreference");
            switch (storeUnitPreference)
              {
                case TypeUnitPreference.UnitPreference_US:
                    handler.string_value("US");
                    break;
                case TypeUnitPreference.UnitPreference_METRIC:
                    handler.string_value("METRIC");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasDefaultTimeFormat24Hours)
          {
            handler.start_pair("DefaultTimeFormat24Hours");
            handler.boolean_value(storeDefaultTimeFormat24Hours);
          }
        if (flagHasClientID)
          {
            handler.start_pair("ClientID");
            handler.string_value(storeClientID);
          }
        if (flagHasClientVersion)
          {
            handler.start_pair("ClientVersion");
            switch (storeClientVersion.key)
              {
                case 0:
                    handler.string_value(storeClientVersion.choice0);
                    break;
                case 1:
                    handler.number_value(storeClientVersion.choice1);
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasDeviceID)
          {
            handler.start_pair("DeviceID");
            handler.string_value(storeDeviceID);
          }
        if (flagHasSDK)
          {
            handler.start_pair("SDK");
            handler.string_value(storeSDK);
          }
        if (flagHasSDKInfo)
          {
            handler.start_pair("SDKInfo");
            storeSDKInfo.write(handler);
          }
        if (flagHasFirstPersonSelf)
          {
            handler.start_pair("FirstPersonSelf");
            handler.string_value(storeFirstPersonSelf);
          }
        if (flagHasFirstPersonSelfSpoken)
          {
            handler.start_pair("FirstPersonSelfSpoken");
            handler.string_value(storeFirstPersonSelfSpoken);
          }
        if (flagHasSecondPersonSelf)
          {
            handler.start_pair("SecondPersonSelf");
            handler.start_array();
            for (int num2 = 0; num2 < storeSecondPersonSelf.Count; ++num2)
              {
                handler.string_value(storeSecondPersonSelf[num2]);
              }
            handler.finish_array();
          }
        if (flagHasSecondPersonSelfSpoken)
          {
            handler.start_pair("SecondPersonSelfSpoken");
            handler.start_array();
            for (int num3 = 0; num3 < storeSecondPersonSelfSpoken.Count; ++num3)
              {
                handler.string_value(storeSecondPersonSelfSpoken[num3]);
              }
            handler.finish_array();
          }
        if (flagHasWakeUpPattern)
          {
            handler.start_pair("WakeUpPattern");
            handler.string_value(storeWakeUpPattern);
          }
        if (flagHasUserID)
          {
            handler.start_pair("UserID");
            handler.string_value(storeUserID);
          }
        if (flagHasRequestID)
          {
            handler.start_pair("RequestID");
            handler.string_value(storeRequestID);
          }
        if (flagHasSessionID)
          {
            handler.start_pair("SessionID");
            handler.string_value(storeSessionID);
          }
        if (flagHasDomains)
          {
            handler.start_pair("Domains");
            if (partial_allowed)
                storeDomains.write_partial_as_json(handler);
            else
                storeDomains.write_as_json(handler);
          }
        if (flagHasResultUpdateAllowed)
          {
            handler.start_pair("ResultUpdateAllowed");
            handler.boolean_value(storeResultUpdateAllowed);
          }
        if (flagHasPartialTranscriptsDesired)
          {
            handler.start_pair("PartialTranscriptsDesired");
            handler.boolean_value(storePartialTranscriptsDesired);
          }
        if (flagHasMinResults)
          {
            handler.start_pair("MinResults");
            handler.number_value(storeMinResults);
          }
        if (flagHasMaxResults)
          {
            handler.start_pair("MaxResults");
            handler.number_value(storeMaxResults);
          }
        if (flagHasObjectByteCountPrefix)
          {
            handler.start_pair("ObjectByteCountPrefix");
            handler.boolean_value(storeObjectByteCountPrefix);
          }
        if (flagHasProfanityFilter)
          {
            handler.start_pair("ProfanityFilter");
            switch (storeProfanityFilter)
              {
                case TypeProfanityFilter.ProfanityFilter_AllowAll:
                    handler.string_value("AllowAll");
                    break;
                case TypeProfanityFilter.ProfanityFilter_StarOne:
                    handler.string_value("StarOne");
                    break;
                case TypeProfanityFilter.ProfanityFilter_StarAllButFirst:
                    handler.string_value("StarAllButFirst");
                    break;
                case TypeProfanityFilter.ProfanityFilter_StarAll:
                    handler.string_value("StarAll");
                    break;
                case TypeProfanityFilter.ProfanityFilter_DontRecognize:
                    handler.string_value("DontRecognize");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasClientMatches)
          {
            handler.start_pair("ClientMatches");
            Debug.Assert(storeClientMatches.Count >= 1);
            handler.start_array();
            for (int num4 = 0; num4 < storeClientMatches.Count; ++num4)
              {
                if (partial_allowed)
                    storeClientMatches[num4].write_partial_as_json(handler);
                else
                    storeClientMatches[num4].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasClientMatchesOnly)
          {
            handler.start_pair("ClientMatchesOnly");
            handler.boolean_value(storeClientMatchesOnly);
          }
        if (flagHasPagination)
          {
            handler.start_pair("Pagination");
            if (partial_allowed)
                storePagination.write_partial_as_json(handler);
            else
                storePagination.write_as_json(handler);
          }
        if (flagHasResponseAudioVoice)
          {
            handler.start_pair("ResponseAudioVoice");
            handler.string_value(storeResponseAudioVoice);
          }
        if (flagHasResponseAudioShortOrLong)
          {
            handler.start_pair("ResponseAudioShortOrLong");
            switch (storeResponseAudioShortOrLong)
              {
                case TypeResponseAudioShortOrLong.ResponseAudioShortOrLong_Short:
                    handler.string_value("Short");
                    break;
                case TypeResponseAudioShortOrLong.ResponseAudioShortOrLong_Long:
                    handler.string_value("Long");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasResponseAudioAcceptedEncodings)
          {
            handler.start_pair("ResponseAudioAcceptedEncodings");
            Debug.Assert(storeResponseAudioAcceptedEncodings.Count >= 1);
            handler.start_array();
            for (int num5 = 0; num5 < storeResponseAudioAcceptedEncodings.Count; ++num5)
              {
                if (storeResponseAudioAcceptedEncodings[num5].in_known_list)
                  {
                    switch (storeResponseAudioAcceptedEncodings[num5].list_value)
                      {
                        case TypeResponseAudioAcceptedEncodingsKnownValues.ResponseAudioAcceptedEncodings_WAV:
                            handler.string_value("WAV");
                            break;
                        case TypeResponseAudioAcceptedEncodingsKnownValues.ResponseAudioAcceptedEncodings_Speex:
                            handler.string_value("Speex");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeResponseAudioAcceptedEncodings[num5].string_value);
                  }
              }
            handler.finish_array();
          }
        if (flagHasVoiceActivityDetection)
          {
            handler.start_pair("VoiceActivityDetection");
            if (partial_allowed)
                storeVoiceActivityDetection.write_partial_as_json(handler);
            else
                storeVoiceActivityDetection.write_as_json(handler);
          }
        if (flagHasServerDeterminesEndOfAudio)
          {
            handler.start_pair("ServerDeterminesEndOfAudio");
            handler.boolean_value(storeServerDeterminesEndOfAudio);
          }
        if (flagHasIntentOnly)
          {
            handler.start_pair("IntentOnly");
            handler.boolean_value(storeIntentOnly);
          }
        if (flagHasDisableSpellCorrection)
          {
            handler.start_pair("DisableSpellCorrection");
            handler.boolean_value(storeDisableSpellCorrection);
          }
        if (flagHasUseContactData)
          {
            handler.start_pair("UseContactData");
            handler.boolean_value(storeUseContactData);
          }
        if (flagHasUseClientTime)
          {
            handler.start_pair("UseClientTime");
            handler.boolean_value(storeUseClientTime);
          }
        if (flagHasForceConversationStateTime)
          {
            handler.start_pair("ForceConversationStateTime");
            handler.number_value(storeForceConversationStateTime);
          }
        if (flagHasPhoneDisambiguationOmitList)
          {
            handler.start_pair("PhoneDisambiguationOmitList");
            if (partial_allowed)
                storePhoneDisambiguationOmitList.write_partial_as_json(handler);
            else
                storePhoneDisambiguationOmitList.write_as_json(handler);
          }
        if (flagHasIncomingCallPending)
          {
            handler.start_pair("IncomingCallPending");
            if (partial_allowed)
                storeIncomingCallPending.write_partial_as_json(handler);
            else
                storeIncomingCallPending.write_as_json(handler);
          }
        if (flagHasAllowPopularNameContactMatches)
          {
            handler.start_pair("AllowPopularNameContactMatches");
            if (partial_allowed)
                storeAllowPopularNameContactMatches.write_partial_as_json(handler);
            else
                storeAllowPopularNameContactMatches.write_as_json(handler);
          }
        if (flagHasMusicClientState)
          {
            handler.start_pair("MusicClientState");
            if (partial_allowed)
                storeMusicClientState.write_partial_as_json(handler);
            else
                storeMusicClientState.write_as_json(handler);
          }
        if (flagHasDisableMusicSearchListPositionSpecification)
          {
            handler.start_pair("DisableMusicSearchListPositionSpecification");
            if (partial_allowed)
                storeDisableMusicSearchListPositionSpecification.write_partial_as_json(handler);
            else
                storeDisableMusicSearchListPositionSpecification.write_as_json(handler);
          }
        if (flagHasCollateMusicEntities)
          {
            handler.start_pair("CollateMusicEntities");
            if (partial_allowed)
                storeCollateMusicEntities.write_partial_as_json(handler);
            else
                storeCollateMusicEntities.write_as_json(handler);
          }
        if (flagHasAllowContextFreeMusicSearchForPopularEntities)
          {
            handler.start_pair("AllowContextFreeMusicSearchForPopularEntities");
            if (partial_allowed)
                storeAllowContextFreeMusicSearchForPopularEntities.write_partial_as_json(handler);
            else
                storeAllowContextFreeMusicSearchForPopularEntities.write_as_json(handler);
          }
        if (flagHasReturnInformationNuggetsForMusicSearch)
          {
            handler.start_pair("ReturnInformationNuggetsForMusicSearch");
            if (partial_allowed)
                storeReturnInformationNuggetsForMusicSearch.write_partial_as_json(handler);
            else
                storeReturnInformationNuggetsForMusicSearch.write_as_json(handler);
          }
        if (flagHasUseXAPAPI)
          {
            handler.start_pair("UseXAPAPI");
            if (partial_allowed)
                storeUseXAPAPI.write_partial_as_json(handler);
            else
                storeUseXAPAPI.write_as_json(handler);
          }
        if (flagHasLocalSearchClientState)
          {
            handler.start_pair("LocalSearchClientState");
            if (partial_allowed)
                storeLocalSearchClientState.write_partial_as_json(handler);
            else
                storeLocalSearchClientState.write_as_json(handler);
          }
        if (flagHasUberServerToken)
          {
            handler.start_pair("UberServerToken");
            if (partial_allowed)
                storeUberServerToken.write_partial_as_json(handler);
            else
                storeUberServerToken.write_as_json(handler);
          }
        if (flagHasGetUberServerToken)
          {
            handler.start_pair("GetUberServerToken");
            if (partial_allowed)
                storeGetUberServerToken.write_partial_as_json(handler);
            else
                storeGetUberServerToken.write_as_json(handler);
          }
        if (flagHasUberClientId)
          {
            handler.start_pair("UberClientId");
            if (partial_allowed)
                storeUberClientId.write_partial_as_json(handler);
            else
                storeUberClientId.write_as_json(handler);
          }
        if (flagHasGetUberClientId)
          {
            handler.start_pair("GetUberClientId");
            if (partial_allowed)
                storeGetUberClientId.write_partial_as_json(handler);
            else
                storeGetUberClientId.write_as_json(handler);
          }
        if (flagHasSetUserMemoryLocation)
          {
            handler.start_pair("SetUserMemoryLocation");
            if (partial_allowed)
                storeSetUserMemoryLocation.write_partial_as_json(handler);
            else
                storeSetUserMemoryLocation.write_as_json(handler);
          }
        if (flagHasDisableMusicPlayerListPositionSpecification)
          {
            handler.start_pair("DisableMusicPlayerListPositionSpecification");
            if (partial_allowed)
                storeDisableMusicPlayerListPositionSpecification.write_partial_as_json(handler);
            else
                storeDisableMusicPlayerListPositionSpecification.write_as_json(handler);
          }
        if (flagHasCarControlClimateClientConfiguration)
          {
            handler.start_pair("CarControlClimateClientConfiguration");
            if (partial_allowed)
                storeCarControlClimateClientConfiguration.write_partial_as_json(handler);
            else
                storeCarControlClimateClientConfiguration.write_as_json(handler);
          }
        if (flagHasHomeAutomationDomainSettings)
          {
            handler.start_pair("HomeAutomationDomainSettings");
            if (partial_allowed)
                storeHomeAutomationDomainSettings.write_partial_as_json(handler);
            else
                storeHomeAutomationDomainSettings.write_as_json(handler);
          }
        if (flagHasUserContactsRequests)
          {
            handler.start_pair("UserContactsRequests");
            if (partial_allowed)
                storeUserContactsRequests.write_partial_as_json(handler);
            else
                storeUserContactsRequests.write_as_json(handler);
          }
        if (flagHasStoredGlobalPagesToMatch)
          {
            handler.start_pair("StoredGlobalPagesToMatch");
            if (partial_allowed)
                storeStoredGlobalPagesToMatch.write_partial_as_json(handler);
            else
                storeStoredGlobalPagesToMatch.write_as_json(handler);
          }
        if (flagHasStoredGlobalPagesToNotMatch)
          {
            handler.start_pair("StoredGlobalPagesToNotMatch");
            if (partial_allowed)
                storeStoredGlobalPagesToNotMatch.write_partial_as_json(handler);
            else
                storeStoredGlobalPagesToNotMatch.write_as_json(handler);
          }
        if (flagHasStoredPerUserPagesToMatch)
          {
            handler.start_pair("StoredPerUserPagesToMatch");
            if (partial_allowed)
                storeStoredPerUserPagesToMatch.write_partial_as_json(handler);
            else
                storeStoredPerUserPagesToMatch.write_as_json(handler);
          }
        if (flagHasStoredPerUserPagesToNotMatch)
          {
            handler.start_pair("StoredPerUserPagesToNotMatch");
            if (partial_allowed)
                storeStoredPerUserPagesToNotMatch.write_partial_as_json(handler);
            else
                storeStoredPerUserPagesToNotMatch.write_as_json(handler);
          }
        if (flagHasStoredGlobalPagesToSetOnByDefault)
          {
            handler.start_pair("StoredGlobalPagesToSetOnByDefault");
            if (partial_allowed)
                storeStoredGlobalPagesToSetOnByDefault.write_partial_as_json(handler);
            else
                storeStoredGlobalPagesToSetOnByDefault.write_as_json(handler);
          }
        if (flagHasStoredPerUserPagesToSetOnByDefault)
          {
            handler.start_pair("StoredPerUserPagesToSetOnByDefault");
            if (partial_allowed)
                storeStoredPerUserPagesToSetOnByDefault.write_partial_as_json(handler);
            else
                storeStoredPerUserPagesToSetOnByDefault.write_as_json(handler);
          }
        if (flagHasStoredGlobalPagesToSetOffByDefault)
          {
            handler.start_pair("StoredGlobalPagesToSetOffByDefault");
            if (partial_allowed)
                storeStoredGlobalPagesToSetOffByDefault.write_partial_as_json(handler);
            else
                storeStoredGlobalPagesToSetOffByDefault.write_as_json(handler);
          }
        if (flagHasStoredPerUserPagesToSetOffByDefault)
          {
            handler.start_pair("StoredPerUserPagesToSetOffByDefault");
            if (partial_allowed)
                storeStoredPerUserPagesToSetOffByDefault.write_partial_as_json(handler);
            else
                storeStoredPerUserPagesToSetOffByDefault.write_as_json(handler);
          }
        if (flagHasStoredPageMatchWriteData)
          {
            handler.start_pair("StoredPageMatchWriteData");
            if (partial_allowed)
                storeStoredPageMatchWriteData.write_partial_as_json(handler);
            else
                storeStoredPageMatchWriteData.write_as_json(handler);
          }
        if (flagHasStoredPageMatchReadData)
          {
            handler.start_pair("StoredPageMatchReadData");
            if (partial_allowed)
                storeStoredPageMatchReadData.write_partial_as_json(handler);
            else
                storeStoredPageMatchReadData.write_as_json(handler);
          }
        if (flagHasStoredPageMatchPageListData)
          {
            handler.start_pair("StoredPageMatchPageListData");
            if (partial_allowed)
                storeStoredPageMatchPageListData.write_partial_as_json(handler);
            else
                storeStoredPageMatchPageListData.write_as_json(handler);
          }
        if (flagHasVoiceParameters)
          {
            handler.start_pair("VoiceParameters");
            if (partial_allowed)
                storeVoiceParameters.write_partial_as_json(handler);
            else
                storeVoiceParameters.write_as_json(handler);
          }
        if (flagHasStoredAlwaysMatchWriteData)
          {
            handler.start_pair("StoredAlwaysMatchWriteData");
            if (partial_allowed)
                storeStoredAlwaysMatchWriteData.write_partial_as_json(handler);
            else
                storeStoredAlwaysMatchWriteData.write_as_json(handler);
          }
        if (flagHasStoredAlwaysMatchReadData)
          {
            handler.start_pair("StoredAlwaysMatchReadData");
            if (partial_allowed)
                storeStoredAlwaysMatchReadData.write_partial_as_json(handler);
            else
                storeStoredAlwaysMatchReadData.write_as_json(handler);
          }
        if (flagHasUserFeedback)
          {
            handler.start_pair("UserFeedback");
            if (partial_allowed)
                storeUserFeedback.write_partial_as_json(handler);
            else
                storeUserFeedback.write_as_json(handler);
          }
        if (flagHasRadioControlRecognizeNorthAmericanFMBand)
          {
            handler.start_pair("RadioControlRecognizeNorthAmericanFMBand");
            if (partial_allowed)
                storeRadioControlRecognizeNorthAmericanFMBand.write_partial_as_json(handler);
            else
                storeRadioControlRecognizeNorthAmericanFMBand.write_as_json(handler);
          }
        if (flagHasRadioControlRecognizeNorthAmericanAMBand)
          {
            handler.start_pair("RadioControlRecognizeNorthAmericanAMBand");
            if (partial_allowed)
                storeRadioControlRecognizeNorthAmericanAMBand.write_partial_as_json(handler);
            else
                storeRadioControlRecognizeNorthAmericanAMBand.write_as_json(handler);
          }
        if (flagHasRadioControlOtherFMBands)
          {
            handler.start_pair("RadioControlOtherFMBands");
            if (partial_allowed)
                storeRadioControlOtherFMBands.write_partial_as_json(handler);
            else
                storeRadioControlOtherFMBands.write_as_json(handler);
          }
        if (flagHasRadioControlOtherAMBands)
          {
            handler.start_pair("RadioControlOtherAMBands");
            if (partial_allowed)
                storeRadioControlOtherAMBands.write_partial_as_json(handler);
            else
                storeRadioControlOtherAMBands.write_as_json(handler);
          }
        if (flagHasRadioControlAvailableAudioSources)
          {
            handler.start_pair("RadioControlAvailableAudioSources");
            if (partial_allowed)
                storeRadioControlAvailableAudioSources.write_partial_as_json(handler);
            else
                storeRadioControlAvailableAudioSources.write_as_json(handler);
          }
        if (flagHasClientListMatches)
          {
            handler.start_pair("ClientListMatches");
            if (partial_allowed)
                storeClientListMatches.write_partial_as_json(handler);
            else
                storeClientListMatches.write_as_json(handler);
          }
        if (flagHasIntentToExecute)
          {
            handler.start_pair("IntentToExecute");
            if (partial_allowed)
                storeIntentToExecute.write_partial_as_json(handler);
            else
                storeIntentToExecute.write_as_json(handler);
          }
        if (flagHasRobotInfo)
          {
            handler.start_pair("RobotInfo");
            if (partial_allowed)
                storeRobotInfo.write_partial_as_json(handler);
            else
                storeRobotInfo.write_as_json(handler);
          }
        if (flagHasConvertToNewInformationNuggets)
          {
            handler.start_pair("ConvertToNewInformationNuggets");
            if (partial_allowed)
                storeConvertToNewInformationNuggets.write_partial_as_json(handler);
            else
                storeConvertToNewInformationNuggets.write_as_json(handler);
          }
        if (flagHasAcapelaVoiceParameters)
          {
            handler.start_pair("AcapelaVoiceParameters");
            if (partial_allowed)
                storeAcapelaVoiceParameters.write_partial_as_json(handler);
            else
                storeAcapelaVoiceParameters.write_as_json(handler);
          }
        if (flagHasOutputOverrideCommandIsPreAudioOut)
          {
            handler.start_pair("OutputOverrideCommandIsPreAudioOut");
            if (partial_allowed)
                storeOutputOverrideCommandIsPreAudioOut.write_partial_as_json(handler);
            else
                storeOutputOverrideCommandIsPreAudioOut.write_as_json(handler);
          }
        if (flagHasOutputOverrideCommandFunction)
          {
            handler.start_pair("OutputOverrideCommandFunction");
            if (partial_allowed)
                storeOutputOverrideCommandFunction.write_partial_as_json(handler);
            else
                storeOutputOverrideCommandFunction.write_as_json(handler);
          }
        if (flagHasOutputOverrideCommandFunctionLanguage)
          {
            handler.start_pair("OutputOverrideCommandFunctionLanguage");
            if (partial_allowed)
                storeOutputOverrideCommandFunctionLanguage.write_partial_as_json(handler);
            else
                storeOutputOverrideCommandFunctionLanguage.write_as_json(handler);
          }
        if (flagHasOutputOverrideCommandFunctionSource)
          {
            handler.start_pair("OutputOverrideCommandFunctionSource");
            if (partial_allowed)
                storeOutputOverrideCommandFunctionSource.write_partial_as_json(handler);
            else
                storeOutputOverrideCommandFunctionSource.write_as_json(handler);
          }
        if (flagHasOutputOverrideDeleteCommandFunction)
          {
            handler.start_pair("OutputOverrideDeleteCommandFunction");
            if (partial_allowed)
                storeOutputOverrideDeleteCommandFunction.write_partial_as_json(handler);
            else
                storeOutputOverrideDeleteCommandFunction.write_as_json(handler);
          }
        if (flagHasOutputOverrideReadCommandFunction)
          {
            handler.start_pair("OutputOverrideReadCommandFunction");
            if (partial_allowed)
                storeOutputOverrideReadCommandFunction.write_partial_as_json(handler);
            else
                storeOutputOverrideReadCommandFunction.write_as_json(handler);
          }
        if (flagHasOutputOverrideInformationNuggetFunction)
          {
            handler.start_pair("OutputOverrideInformationNuggetFunction");
            if (partial_allowed)
                storeOutputOverrideInformationNuggetFunction.write_partial_as_json(handler);
            else
                storeOutputOverrideInformationNuggetFunction.write_as_json(handler);
          }
        if (flagHasOutputOverrideInformationNuggetFunctionLanguage)
          {
            handler.start_pair("OutputOverrideInformationNuggetFunctionLanguage");
            if (partial_allowed)
                storeOutputOverrideInformationNuggetFunctionLanguage.write_partial_as_json(handler);
            else
                storeOutputOverrideInformationNuggetFunctionLanguage.write_as_json(handler);
          }
        if (flagHasOutputOverrideInformationNuggetFunctionSource)
          {
            handler.start_pair("OutputOverrideInformationNuggetFunctionSource");
            if (partial_allowed)
                storeOutputOverrideInformationNuggetFunctionSource.write_partial_as_json(handler);
            else
                storeOutputOverrideInformationNuggetFunctionSource.write_as_json(handler);
          }
        if (flagHasOutputOverrideDeleteInformationNuggetFunction)
          {
            handler.start_pair("OutputOverrideDeleteInformationNuggetFunction");
            if (partial_allowed)
                storeOutputOverrideDeleteInformationNuggetFunction.write_partial_as_json(handler);
            else
                storeOutputOverrideDeleteInformationNuggetFunction.write_as_json(handler);
          }
        if (flagHasOutputOverrideReadInformationNuggetFunction)
          {
            handler.start_pair("OutputOverrideReadInformationNuggetFunction");
            if (partial_allowed)
                storeOutputOverrideReadInformationNuggetFunction.write_partial_as_json(handler);
            else
                storeOutputOverrideReadInformationNuggetFunction.write_as_json(handler);
          }
        if (flagHasTerrierUploadWriteData)
          {
            handler.start_pair("TerrierUploadWriteData");
            if (partial_allowed)
                storeTerrierUploadWriteData.write_partial_as_json(handler);
            else
                storeTerrierUploadWriteData.write_as_json(handler);
          }
        if (flagHasTerrierUploadReadData)
          {
            handler.start_pair("TerrierUploadReadData");
            if (partial_allowed)
                storeTerrierUploadReadData.write_partial_as_json(handler);
            else
                storeTerrierUploadReadData.write_as_json(handler);
          }
        if (flagHasDisambiguateResultsBeforeAction)
          {
            handler.start_pair("DisambiguateResultsBeforeAction");
            if (partial_allowed)
                storeDisambiguateResultsBeforeAction.write_partial_as_json(handler);
            else
                storeDisambiguateResultsBeforeAction.write_as_json(handler);
          }
        if (flagHasInputOverrideFunction)
          {
            handler.start_pair("InputOverrideFunction");
            if (partial_allowed)
                storeInputOverrideFunction.write_partial_as_json(handler);
            else
                storeInputOverrideFunction.write_as_json(handler);
          }
        if (flagHasInputOverrideFunctionLanguage)
          {
            handler.start_pair("InputOverrideFunctionLanguage");
            if (partial_allowed)
                storeInputOverrideFunctionLanguage.write_partial_as_json(handler);
            else
                storeInputOverrideFunctionLanguage.write_as_json(handler);
          }
        if (flagHasInputOverrideFunctionSource)
          {
            handler.start_pair("InputOverrideFunctionSource");
            if (partial_allowed)
                storeInputOverrideFunctionSource.write_partial_as_json(handler);
            else
                storeInputOverrideFunctionSource.write_as_json(handler);
          }
        if (flagHasInputOverrideDeleteFunction)
          {
            handler.start_pair("InputOverrideDeleteFunction");
            if (partial_allowed)
                storeInputOverrideDeleteFunction.write_partial_as_json(handler);
            else
                storeInputOverrideDeleteFunction.write_as_json(handler);
          }
        if (flagHasInputOverrideReadFunction)
          {
            handler.start_pair("InputOverrideReadFunction");
            if (partial_allowed)
                storeInputOverrideReadFunction.write_partial_as_json(handler);
            else
                storeInputOverrideReadFunction.write_as_json(handler);
          }
        if (flagHasSportsLeagueControl)
          {
            handler.start_pair("SportsLeagueControl");
            if (partial_allowed)
                storeSportsLeagueControl.write_partial_as_json(handler);
            else
                storeSportsLeagueControl.write_as_json(handler);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        int extra_count = extraKeys.Count;
        Debug.Assert(extra_count == extraValues.Count);
        for (int extra_num = 0; extra_num < extra_count; ++extra_num)
          {
            handler.start_pair(extraKeys[extra_num]);
            extraValues[extra_num].write(handler);
          }
        handler.finish_object();
      }
    public virtual string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static RequestInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RequestInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RequestInfo", ignore_extras);
            generator.set_allow_incomplete(allow_incomplete);
            generator.set_allow_unpolished(allow_unpolished);
            if (allow_incomplete || allow_unpolished)
                json_value.write(generator);
            else
                json_value.write(generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RequestInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RequestInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RequestInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RequestInfo", ignore_extras);
            generator.set_allow_incomplete(allow_incomplete);
            generator.set_allow_unpolished(allow_unpolished);
            if (allow_incomplete || allow_unpolished)
                json_value.write_partial_as_json(generator);
            else
                json_value.write_as_json(generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RequestInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RequestInfoJSON from_text(string text, bool ignore_extras)
      {
        RequestInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RequestInfo", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RequestInfoJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RequestInfoJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RequestInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RequestInfo", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingNumberTextGenerator fieldGeneratorLatitude;
        private JSONHoldingNumberTextGenerator fieldGeneratorLongitude;
    private class FieldHoldingGeneratorPositionTime : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorPositionTime(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorPositionTime : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorPositionTime(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorPositionTime fieldGeneratorPositionTime;
        private JSONHoldingNumberTextGenerator fieldGeneratorPositionHorizontalAccuracy;
        private JSONHoldingStringGenerator fieldGeneratorStreet;
        private JSONHoldingStringGenerator fieldGeneratorCity;
        private JSONHoldingStringGenerator fieldGeneratorState;
        private JSONHoldingStringGenerator fieldGeneratorCountry;
        private RoutePointsJSON.HoldingGenerator fieldGeneratorRoutePoints;
        private JSONHoldingBooleanGenerator fieldGeneratorControllableTrackPlaying;
    private class FieldHoldingGeneratorTimeStamp : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorTimeStamp(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorTimeStamp : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorTimeStamp(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorTimeStamp fieldGeneratorTimeStamp;
        private JSONHoldingStringGenerator fieldGeneratorTimeZone;
        private ConversationStateJSON.HoldingGenerator fieldGeneratorConversationState;
        private ClientStateJSON.HoldingGenerator fieldGeneratorClientState;
        private JSONHoldingValueGenerator fieldGeneratorSendBack;
    private class FieldHoldingGeneratorPreferredImageSize : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorPreferredImageSize(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorPreferredImageSize : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorPreferredImageSize(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingArrayGeneratorPreferredImageSize fieldGeneratorPreferredImageSize;
        private JSONHoldingStringGenerator fieldGeneratorInputLanguageEnglishName;
        private JSONHoldingStringGenerator fieldGeneratorInputLanguageNativeName;
        private JSONHoldingStringGenerator fieldGeneratorInputLanguageIETFTag;
        private JSONHoldingStringGenerator fieldGeneratorOutputLanguageEnglishName;
        private JSONHoldingStringGenerator fieldGeneratorOutputLanguageNativeName;
        private JSONHoldingStringGenerator fieldGeneratorOutputLanguageIETFTag;
        private JSONHoldingNumberTextGenerator fieldGeneratorResultVersionAccepted;
    private abstract class FieldGeneratorUnitPreference : JSONStringGenerator
          {
            protected FieldGeneratorUnitPreference(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorUnitPreference()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToUnitPreference(result));
              }
            protected abstract void handle_result(TypeUnitPreference result);
          };
    private class FieldHoldingGeneratorUnitPreference : FieldGeneratorUnitPreference
  {
    protected override void handle_result(TypeUnitPreference result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorUnitPreference(String what)
      {
        have_value = false;
        base.set_what(what);
      }

    public override void reset()
      {
        have_value = false;
        base.reset();
      }

    public bool have_value;
    public TypeUnitPreference value;
  };
    private class FieldHoldingArrayGeneratorUnitPreference : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorUnitPreference
      {
        private FieldHoldingArrayGeneratorUnitPreference top;

        protected override void handle_result(TypeUnitPreference result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorUnitPreference init_top)
          {
            top = init_top;
          }
      };

    private ElementHandler element_handler;

    protected override JSONHandler start()
      {
        have_value = true;
        value.Clear();
        return element_handler;
      }
    protected override void finish()
      {
        Debug.Assert(have_value);
        handle_result(value);
        element_handler.reset();
      }
    protected virtual void handle_result(List<TypeUnitPreference> result)
      {
      }

    public FieldHoldingArrayGeneratorUnitPreference(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeUnitPreference>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorUnitPreference()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeUnitPreference>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeUnitPreference> value;
  };
        private FieldHoldingGeneratorUnitPreference fieldGeneratorUnitPreference;
        private JSONHoldingBooleanGenerator fieldGeneratorDefaultTimeFormat24Hours;
        private JSONHoldingStringGenerator fieldGeneratorClientID;
    private class FieldHoldingGeneratorClientVersion_1 : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorClientVersion_1(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorClientVersion_1 : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorClientVersion_1(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private abstract class FieldGeneratorClientVersion : JSONParallelGenerator
          {
            private JSONHoldingStringGenerator field0;
            private FieldHoldingGeneratorClientVersion_1 field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeClientVersion result = new TypeClientVersion();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeClientVersion result);
            public FieldGeneratorClientVersion(bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"ClientVersion\"");
                    field1 = new FieldHoldingGeneratorClientVersion_1("option 1 of field \"ClientVersion\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorClientVersion(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"ClientVersion\"");
                    field1 = new FieldHoldingGeneratorClientVersion_1("option 1 of field \"ClientVersion\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderClientVersion
          {
            private bool have_data;
            private TypeClientVersion data;
            public HolderClientVersion()  { have_data = false; }
            public HolderClientVersion(TypeClientVersion init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderClientVersion(HolderClientVersion other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeClientVersion referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorClientVersion : FieldGeneratorClientVersion
          {
            protected override void handle_result(TypeClientVersion result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderClientVersion(result);
              }

            public FieldHoldingGeneratorClientVersion(String what, bool ignore_extras) : base(ignore_extras)
              {
                have_value = false;
                base.set_what(what);
              }

            public override void reset()
              {
                have_value = false;
                base.reset();
              }

            public bool have_value;
            public HolderClientVersion value;
          };
    private class FieldHoldingArrayGeneratorClientVersion : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorClientVersion
      {
        private FieldHoldingArrayGeneratorClientVersion top;

        protected override void handle_result(TypeClientVersion result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorClientVersion init_top, bool ignore_extras) : base(ignore_extras)
          {
            top = init_top;
          }
      };

    private ElementHandler element_handler;

    protected override JSONHandler start()
      {
        have_value = true;
        value.Clear();
        return element_handler;
      }
    protected override void finish()
      {
        Debug.Assert(have_value);
        handle_result(value);
        element_handler.reset();
      }
    protected virtual void handle_result(List<TypeClientVersion> result)
      {
      }

    public FieldHoldingArrayGeneratorClientVersion(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeClientVersion>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorClientVersion(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeClientVersion>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeClientVersion> value;
  };
        private FieldHoldingGeneratorClientVersion fieldGeneratorClientVersion;
        private JSONHoldingStringGenerator fieldGeneratorDeviceID;
        private JSONHoldingStringGenerator fieldGeneratorSDK;
        private JSONHoldingObjectValueGenerator fieldGeneratorSDKInfo;
        private JSONHoldingStringGenerator fieldGeneratorFirstPersonSelf;
        private JSONHoldingStringGenerator fieldGeneratorFirstPersonSelfSpoken;
        private JSONHoldingStringArrayGenerator fieldGeneratorSecondPersonSelf;
        private JSONHoldingStringArrayGenerator fieldGeneratorSecondPersonSelfSpoken;
        private JSONHoldingStringGenerator fieldGeneratorWakeUpPattern;
        private JSONHoldingStringGenerator fieldGeneratorUserID;
        private JSONHoldingStringGenerator fieldGeneratorRequestID;
        private JSONHoldingStringGenerator fieldGeneratorSessionID;
        private DomainsJSON.HoldingGenerator fieldGeneratorDomains;
        private JSONHoldingBooleanGenerator fieldGeneratorResultUpdateAllowed;
        private JSONHoldingBooleanGenerator fieldGeneratorPartialTranscriptsDesired;
    private class FieldHoldingGeneratorMinResults : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorMinResults(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorMinResults : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorMinResults(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorMinResults fieldGeneratorMinResults;
    private class FieldHoldingGeneratorMaxResults : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorMaxResults(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorMaxResults : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorMaxResults(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorMaxResults fieldGeneratorMaxResults;
        private JSONHoldingBooleanGenerator fieldGeneratorObjectByteCountPrefix;
    private abstract class FieldGeneratorProfanityFilter : JSONStringGenerator
          {
            protected FieldGeneratorProfanityFilter(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorProfanityFilter()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToProfanityFilter(result));
              }
            protected abstract void handle_result(TypeProfanityFilter result);
          };
    private class FieldHoldingGeneratorProfanityFilter : FieldGeneratorProfanityFilter
  {
    protected override void handle_result(TypeProfanityFilter result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorProfanityFilter(String what)
      {
        have_value = false;
        base.set_what(what);
      }

    public override void reset()
      {
        have_value = false;
        base.reset();
      }

    public bool have_value;
    public TypeProfanityFilter value;
  };
    private class FieldHoldingArrayGeneratorProfanityFilter : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorProfanityFilter
      {
        private FieldHoldingArrayGeneratorProfanityFilter top;

        protected override void handle_result(TypeProfanityFilter result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorProfanityFilter init_top)
          {
            top = init_top;
          }
      };

    private ElementHandler element_handler;

    protected override JSONHandler start()
      {
        have_value = true;
        value.Clear();
        return element_handler;
      }
    protected override void finish()
      {
        Debug.Assert(have_value);
        handle_result(value);
        element_handler.reset();
      }
    protected virtual void handle_result(List<TypeProfanityFilter> result)
      {
      }

    public FieldHoldingArrayGeneratorProfanityFilter(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeProfanityFilter>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorProfanityFilter()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeProfanityFilter>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeProfanityFilter> value;
  };
        private FieldHoldingGeneratorProfanityFilter fieldGeneratorProfanityFilter;
        private ClientMatchJSON.HoldingArrayGenerator fieldGeneratorClientMatches;
        private JSONHoldingBooleanGenerator fieldGeneratorClientMatchesOnly;
        private PaginationJSON.HoldingGenerator fieldGeneratorPagination;
        private JSONHoldingStringGenerator fieldGeneratorResponseAudioVoice;
    private abstract class FieldGeneratorResponseAudioShortOrLong : JSONStringGenerator
          {
            protected FieldGeneratorResponseAudioShortOrLong(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorResponseAudioShortOrLong()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToResponseAudioShortOrLong(result));
              }
            protected abstract void handle_result(TypeResponseAudioShortOrLong result);
          };
    private class FieldHoldingGeneratorResponseAudioShortOrLong : FieldGeneratorResponseAudioShortOrLong
  {
    protected override void handle_result(TypeResponseAudioShortOrLong result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorResponseAudioShortOrLong(String what)
      {
        have_value = false;
        base.set_what(what);
      }

    public override void reset()
      {
        have_value = false;
        base.reset();
      }

    public bool have_value;
    public TypeResponseAudioShortOrLong value;
  };
    private class FieldHoldingArrayGeneratorResponseAudioShortOrLong : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorResponseAudioShortOrLong
      {
        private FieldHoldingArrayGeneratorResponseAudioShortOrLong top;

        protected override void handle_result(TypeResponseAudioShortOrLong result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorResponseAudioShortOrLong init_top)
          {
            top = init_top;
          }
      };

    private ElementHandler element_handler;

    protected override JSONHandler start()
      {
        have_value = true;
        value.Clear();
        return element_handler;
      }
    protected override void finish()
      {
        Debug.Assert(have_value);
        handle_result(value);
        element_handler.reset();
      }
    protected virtual void handle_result(List<TypeResponseAudioShortOrLong> result)
      {
      }

    public FieldHoldingArrayGeneratorResponseAudioShortOrLong(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeResponseAudioShortOrLong>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorResponseAudioShortOrLong()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeResponseAudioShortOrLong>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeResponseAudioShortOrLong> value;
  };
        private FieldHoldingGeneratorResponseAudioShortOrLong fieldGeneratorResponseAudioShortOrLong;
    private abstract class FieldGeneratorResponseAudioAcceptedEncodings : JSONStringGenerator
          {
            protected FieldGeneratorResponseAudioAcceptedEncodings(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorResponseAudioAcceptedEncodings()
              {
              }
            protected override void handle_result(string result)
              {
                TypeResponseAudioAcceptedEncodingsKnownValues known = stringToResponseAudioAcceptedEncodings(result);
                TypeResponseAudioAcceptedEncodings new_value = new TypeResponseAudioAcceptedEncodings();
                if (known == TypeResponseAudioAcceptedEncodingsKnownValues.ResponseAudioAcceptedEncodings__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = result;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                handle_result(new_value);
              }
            protected abstract void handle_result(TypeResponseAudioAcceptedEncodings result);
          };
    private class FieldHoldingGeneratorResponseAudioAcceptedEncodings : FieldGeneratorResponseAudioAcceptedEncodings
  {
    protected override void handle_result(TypeResponseAudioAcceptedEncodings result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorResponseAudioAcceptedEncodings(String what)
      {
        have_value = false;
        base.set_what(what);
      }

    public override void reset()
      {
        have_value = false;
        base.reset();
      }

    public bool have_value;
    public TypeResponseAudioAcceptedEncodings value;
  };
    private class FieldHoldingArrayGeneratorResponseAudioAcceptedEncodings : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorResponseAudioAcceptedEncodings
      {
        private FieldHoldingArrayGeneratorResponseAudioAcceptedEncodings top;

        protected override void handle_result(TypeResponseAudioAcceptedEncodings result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorResponseAudioAcceptedEncodings init_top)
          {
            top = init_top;
          }
      };

    private ElementHandler element_handler;

    protected override JSONHandler start()
      {
        have_value = true;
        value.Clear();
        return element_handler;
      }
    protected override void finish()
      {
        Debug.Assert(have_value);
        handle_result(value);
        element_handler.reset();
      }
    protected virtual void handle_result(List<TypeResponseAudioAcceptedEncodings> result)
      {
      }

    public FieldHoldingArrayGeneratorResponseAudioAcceptedEncodings(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeResponseAudioAcceptedEncodings>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorResponseAudioAcceptedEncodings()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeResponseAudioAcceptedEncodings>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeResponseAudioAcceptedEncodings> value;
  };
        private FieldHoldingArrayGeneratorResponseAudioAcceptedEncodings fieldGeneratorResponseAudioAcceptedEncodings;
        private VoiceActivityDetectionJSON.HoldingGenerator fieldGeneratorVoiceActivityDetection;
        private JSONHoldingBooleanGenerator fieldGeneratorServerDeterminesEndOfAudio;
        private JSONHoldingBooleanGenerator fieldGeneratorIntentOnly;
        private JSONHoldingBooleanGenerator fieldGeneratorDisableSpellCorrection;
        private JSONHoldingBooleanGenerator fieldGeneratorUseContactData;
        private JSONHoldingBooleanGenerator fieldGeneratorUseClientTime;
    private class FieldHoldingGeneratorForceConversationStateTime : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorForceConversationStateTime(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorForceConversationStateTime : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorForceConversationStateTime(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorForceConversationStateTime fieldGeneratorForceConversationStateTime;
        private PhoneDisambiguationOmitListJSON.HoldingGenerator fieldGeneratorPhoneDisambiguationOmitList;
        private IncomingCallPendingJSON.HoldingGenerator fieldGeneratorIncomingCallPending;
        private AllowPopularNameContactMatchesJSON.HoldingGenerator fieldGeneratorAllowPopularNameContactMatches;
        private MusicClientStateJSON.HoldingGenerator fieldGeneratorMusicClientState;
        private DisableListPositionSpecificationJSON.HoldingGenerator fieldGeneratorDisableMusicSearchListPositionSpecification;
        private CollateMusicEntitiesJSON.HoldingGenerator fieldGeneratorCollateMusicEntities;
        private AllowContextFreeMusicSearchForPopularEntitiesJSON.HoldingGenerator fieldGeneratorAllowContextFreeMusicSearchForPopularEntities;
        private ReturnInformationNuggetsForMusicSearchJSON.HoldingGenerator fieldGeneratorReturnInformationNuggetsForMusicSearch;
        private RequestInfoBooleanFlagJSON.HoldingGenerator fieldGeneratorUseXAPAPI;
        private LocalSearchClientStateJSON.HoldingGenerator fieldGeneratorLocalSearchClientState;
        private UberServerTokenJSON.HoldingGenerator fieldGeneratorUberServerToken;
        private GetUberServerTokenJSON.HoldingGenerator fieldGeneratorGetUberServerToken;
        private UberClientIdJSON.HoldingGenerator fieldGeneratorUberClientId;
        private GetUberClientIdJSON.HoldingGenerator fieldGeneratorGetUberClientId;
        private SetUserMemoryLocationJSON.HoldingGenerator fieldGeneratorSetUserMemoryLocation;
        private DisableListPositionSpecificationJSON.HoldingGenerator fieldGeneratorDisableMusicPlayerListPositionSpecification;
        private CarControlClimateClientConfigurationJSON.HoldingGenerator fieldGeneratorCarControlClimateClientConfiguration;
        private HomeAutomationDomainSettingsJSON.HoldingGenerator fieldGeneratorHomeAutomationDomainSettings;
        private UserContactsRequestsJSON.HoldingGenerator fieldGeneratorUserContactsRequests;
        private StoredPageMatchPageListJSON.HoldingGenerator fieldGeneratorStoredGlobalPagesToMatch;
        private StoredPageMatchPageListJSON.HoldingGenerator fieldGeneratorStoredGlobalPagesToNotMatch;
        private StoredPageMatchPageListJSON.HoldingGenerator fieldGeneratorStoredPerUserPagesToMatch;
        private StoredPageMatchPageListJSON.HoldingGenerator fieldGeneratorStoredPerUserPagesToNotMatch;
        private StoredPageMatchPageListJSON.HoldingGenerator fieldGeneratorStoredGlobalPagesToSetOnByDefault;
        private StoredPageMatchPageListJSON.HoldingGenerator fieldGeneratorStoredPerUserPagesToSetOnByDefault;
        private StoredPageMatchPageListJSON.HoldingGenerator fieldGeneratorStoredGlobalPagesToSetOffByDefault;
        private StoredPageMatchPageListJSON.HoldingGenerator fieldGeneratorStoredPerUserPagesToSetOffByDefault;
        private StoredPageMatchWriteDataJSON.HoldingGenerator fieldGeneratorStoredPageMatchWriteData;
        private StoredPageMatchReadDataJSON.HoldingGenerator fieldGeneratorStoredPageMatchReadData;
        private StoredPageMatchPageListDataJSON.HoldingGenerator fieldGeneratorStoredPageMatchPageListData;
        private VoiceParametersJSON.HoldingGenerator fieldGeneratorVoiceParameters;
        private ClientMatchesJSON.HoldingGenerator fieldGeneratorStoredAlwaysMatchWriteData;
        private StoredAlwaysMatchReadDataJSON.HoldingGenerator fieldGeneratorStoredAlwaysMatchReadData;
        private UserFeedbackJSON.HoldingGenerator fieldGeneratorUserFeedback;
        private RadioControlRecognizeNorthAmericanFMBandJSON.HoldingGenerator fieldGeneratorRadioControlRecognizeNorthAmericanFMBand;
        private RadioControlRecognizeNorthAmericanAMBandJSON.HoldingGenerator fieldGeneratorRadioControlRecognizeNorthAmericanAMBand;
        private RadioControlOtherFMBandsJSON.HoldingGenerator fieldGeneratorRadioControlOtherFMBands;
        private RadioControlOtherAMBandsJSON.HoldingGenerator fieldGeneratorRadioControlOtherAMBands;
        private RadioControlAvailableAudioSourcesJSON.HoldingGenerator fieldGeneratorRadioControlAvailableAudioSources;
        private ClientListMatchesJSON.HoldingGenerator fieldGeneratorClientListMatches;
        private CommandIntentJSON.HoldingGenerator fieldGeneratorIntentToExecute;
        private RobotInfoJSON.HoldingGenerator fieldGeneratorRobotInfo;
        private ConvertToNewInformationNuggetsJSON.HoldingGenerator fieldGeneratorConvertToNewInformationNuggets;
        private AcapelaVoiceParametersJSON.HoldingGenerator fieldGeneratorAcapelaVoiceParameters;
        private RequestInfoBooleanFlagJSON.HoldingGenerator fieldGeneratorOutputOverrideCommandIsPreAudioOut;
        private OutputOverrideFunctionJSON.HoldingGenerator fieldGeneratorOutputOverrideCommandFunction;
        private UploadedCodeFunctionLanguageJSON.HoldingGenerator fieldGeneratorOutputOverrideCommandFunctionLanguage;
        private UploadedCodeSourceJSON.HoldingGenerator fieldGeneratorOutputOverrideCommandFunctionSource;
        private RequestInfoBooleanFlagJSON.HoldingGenerator fieldGeneratorOutputOverrideDeleteCommandFunction;
        private RequestInfoBooleanFlagJSON.HoldingGenerator fieldGeneratorOutputOverrideReadCommandFunction;
        private OutputOverrideFunctionJSON.HoldingGenerator fieldGeneratorOutputOverrideInformationNuggetFunction;
        private UploadedCodeFunctionLanguageJSON.HoldingGenerator fieldGeneratorOutputOverrideInformationNuggetFunctionLanguage;
        private UploadedCodeSourceJSON.HoldingGenerator fieldGeneratorOutputOverrideInformationNuggetFunctionSource;
        private RequestInfoBooleanFlagJSON.HoldingGenerator fieldGeneratorOutputOverrideDeleteInformationNuggetFunction;
        private RequestInfoBooleanFlagJSON.HoldingGenerator fieldGeneratorOutputOverrideReadInformationNuggetFunction;
        private TerrierUploadWriteDataJSON.HoldingGenerator fieldGeneratorTerrierUploadWriteData;
        private TerrierUploadReadDataJSON.HoldingGenerator fieldGeneratorTerrierUploadReadData;
        private DisambiguateResultsBeforeActionJSON.HoldingGenerator fieldGeneratorDisambiguateResultsBeforeAction;
        private InputOverrideFunctionJSON.HoldingGenerator fieldGeneratorInputOverrideFunction;
        private UploadedCodeFunctionLanguageJSON.HoldingGenerator fieldGeneratorInputOverrideFunctionLanguage;
        private UploadedCodeSourceJSON.HoldingGenerator fieldGeneratorInputOverrideFunctionSource;
        private RequestInfoBooleanFlagJSON.HoldingGenerator fieldGeneratorInputOverrideDeleteFunction;
        private RequestInfoBooleanFlagJSON.HoldingGenerator fieldGeneratorInputOverrideReadFunction;
        private SportsLeagueControlJSON.HoldingGenerator fieldGeneratorSportsLeagueControl;
        private class UnknownFieldGenerator : JSONValueHandler
          {
            public bool ignore;
            public List<string> field_names;
            public List<JSONValue > field_values;
            public Dictionary<string, JSONValue > index;
            public UnknownFieldGenerator(bool init_ignore)
              {
                ignore = init_ignore;
                field_names = new List<string>();
                field_values = new List<JSONValue >();
            index = new Dictionary<string, JSONValue >();
              }

            protected override void new_value(JSONValue item)
              {
                if (ignore)
                    return;
                Debug.Assert(field_names.Count == (field_values.Count + 1));
                index.Add(field_names[field_values.Count], item);
                field_values.Add(item);
              }
            public override void reset()
              {
                field_names.Clear();
                field_values.Clear();
            index = new Dictionary<string, JSONValue >();
              }
          };
        private UnknownFieldGenerator unknownFieldGenerator;

        protected bool allow_incomplete;

        protected bool allow_unpolished;

        protected override void start()
          {
          }
        protected override JSONHandler start_field(string field_name)
          {
            JSONHandler result = start_known_field(field_name);
            if (result != null)
                return result;
            Debug.Assert(unknownFieldGenerator.field_names.Count ==
                   unknownFieldGenerator.field_values.Count);
            if (unknownFieldGenerator.ignore)
              {
                Debug.Assert(unknownFieldGenerator.field_names.Count == 0);
              }
            else
              {
                unknownFieldGenerator.field_names.Add(field_name);
              }
            return unknownFieldGenerator;
          }
        protected override void finish_field(string field_name, JSONHandler field_handler)
          {
          }
        protected override void finish()
          {
            RequestInfoJSON result = new RequestInfoJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRequestInfoAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RequestInfoJSON result)
          {
            if (fieldGeneratorLatitude.have_value)
              {
                result.setLatitudeText(fieldGeneratorLatitude.value);
                fieldGeneratorLatitude.have_value = false;
              }
            if (fieldGeneratorLongitude.have_value)
              {
                result.setLongitudeText(fieldGeneratorLongitude.value);
                fieldGeneratorLongitude.have_value = false;
              }
            if (fieldGeneratorPositionTime.have_value)
              {
                result.setPositionTime(fieldGeneratorPositionTime.value);
                fieldGeneratorPositionTime.have_value = false;
              }
            if (fieldGeneratorPositionHorizontalAccuracy.have_value)
              {
                result.setPositionHorizontalAccuracyText(fieldGeneratorPositionHorizontalAccuracy.value);
                fieldGeneratorPositionHorizontalAccuracy.have_value = false;
              }
            if (fieldGeneratorStreet.have_value)
              {
                result.setStreet(fieldGeneratorStreet.value);
                fieldGeneratorStreet.have_value = false;
              }
            if (fieldGeneratorCity.have_value)
              {
                result.setCity(fieldGeneratorCity.value);
                fieldGeneratorCity.have_value = false;
              }
            if (fieldGeneratorState.have_value)
              {
                result.setState(fieldGeneratorState.value);
                fieldGeneratorState.have_value = false;
              }
            if (fieldGeneratorCountry.have_value)
              {
                result.setCountry(fieldGeneratorCountry.value);
                fieldGeneratorCountry.have_value = false;
              }
            if (fieldGeneratorRoutePoints.have_value)
              {
                result.setRoutePoints(fieldGeneratorRoutePoints.value);
                fieldGeneratorRoutePoints.have_value = false;
              }
            if (fieldGeneratorControllableTrackPlaying.have_value)
              {
                result.setControllableTrackPlaying(fieldGeneratorControllableTrackPlaying.value);
                fieldGeneratorControllableTrackPlaying.have_value = false;
              }
            if (fieldGeneratorTimeStamp.have_value)
              {
                result.setTimeStamp(fieldGeneratorTimeStamp.value);
                fieldGeneratorTimeStamp.have_value = false;
              }
            if (fieldGeneratorTimeZone.have_value)
              {
                result.setTimeZone(fieldGeneratorTimeZone.value);
                fieldGeneratorTimeZone.have_value = false;
              }
            if (fieldGeneratorConversationState.have_value)
              {
                result.setConversationState(fieldGeneratorConversationState.value);
                fieldGeneratorConversationState.have_value = false;
              }
            if (fieldGeneratorClientState.have_value)
              {
                result.setClientState(fieldGeneratorClientState.value);
                fieldGeneratorClientState.have_value = false;
              }
            if (fieldGeneratorSendBack.have_value)
              {
                result.setSendBack(fieldGeneratorSendBack.value);
                fieldGeneratorSendBack.have_value = false;
              }
            if (fieldGeneratorPreferredImageSize.have_value)
              {
                result.initPreferredImageSize();
                int count = fieldGeneratorPreferredImageSize.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendPreferredImageSize(fieldGeneratorPreferredImageSize.value[num]);
                  }
                fieldGeneratorPreferredImageSize.value.Clear();
                fieldGeneratorPreferredImageSize.have_value = false;
              }
            if (fieldGeneratorInputLanguageEnglishName.have_value)
              {
                result.setInputLanguageEnglishName(fieldGeneratorInputLanguageEnglishName.value);
                fieldGeneratorInputLanguageEnglishName.have_value = false;
              }
            if (fieldGeneratorInputLanguageNativeName.have_value)
              {
                result.setInputLanguageNativeName(fieldGeneratorInputLanguageNativeName.value);
                fieldGeneratorInputLanguageNativeName.have_value = false;
              }
            if (fieldGeneratorInputLanguageIETFTag.have_value)
              {
                result.setInputLanguageIETFTag(fieldGeneratorInputLanguageIETFTag.value);
                fieldGeneratorInputLanguageIETFTag.have_value = false;
              }
            if (fieldGeneratorOutputLanguageEnglishName.have_value)
              {
                result.setOutputLanguageEnglishName(fieldGeneratorOutputLanguageEnglishName.value);
                fieldGeneratorOutputLanguageEnglishName.have_value = false;
              }
            if (fieldGeneratorOutputLanguageNativeName.have_value)
              {
                result.setOutputLanguageNativeName(fieldGeneratorOutputLanguageNativeName.value);
                fieldGeneratorOutputLanguageNativeName.have_value = false;
              }
            if (fieldGeneratorOutputLanguageIETFTag.have_value)
              {
                result.setOutputLanguageIETFTag(fieldGeneratorOutputLanguageIETFTag.value);
                fieldGeneratorOutputLanguageIETFTag.have_value = false;
              }
            if (fieldGeneratorResultVersionAccepted.have_value)
              {
                result.setResultVersionAcceptedText(fieldGeneratorResultVersionAccepted.value);
                fieldGeneratorResultVersionAccepted.have_value = false;
              }
            if (fieldGeneratorUnitPreference.have_value)
              {
                result.setUnitPreference(fieldGeneratorUnitPreference.value);
                fieldGeneratorUnitPreference.have_value = false;
              }
            if (fieldGeneratorDefaultTimeFormat24Hours.have_value)
              {
                result.setDefaultTimeFormat24Hours(fieldGeneratorDefaultTimeFormat24Hours.value);
                fieldGeneratorDefaultTimeFormat24Hours.have_value = false;
              }
            if (fieldGeneratorClientID.have_value)
              {
                result.setClientID(fieldGeneratorClientID.value);
                fieldGeneratorClientID.have_value = false;
              }
            if (fieldGeneratorClientVersion.have_value)
              {
                result.setClientVersion(fieldGeneratorClientVersion.value.referenced());
                fieldGeneratorClientVersion.have_value = false;
              }
            if (fieldGeneratorDeviceID.have_value)
              {
                result.setDeviceID(fieldGeneratorDeviceID.value);
                fieldGeneratorDeviceID.have_value = false;
              }
            if (fieldGeneratorSDK.have_value)
              {
                result.setSDK(fieldGeneratorSDK.value);
                fieldGeneratorSDK.have_value = false;
              }
            if (fieldGeneratorSDKInfo.have_value)
              {
                result.setSDKInfo(fieldGeneratorSDKInfo.value);
                fieldGeneratorSDKInfo.have_value = false;
              }
            if (fieldGeneratorFirstPersonSelf.have_value)
              {
                result.setFirstPersonSelf(fieldGeneratorFirstPersonSelf.value);
                fieldGeneratorFirstPersonSelf.have_value = false;
              }
            if (fieldGeneratorFirstPersonSelfSpoken.have_value)
              {
                result.setFirstPersonSelfSpoken(fieldGeneratorFirstPersonSelfSpoken.value);
                fieldGeneratorFirstPersonSelfSpoken.have_value = false;
              }
            if (fieldGeneratorSecondPersonSelf.have_value)
              {
                result.initSecondPersonSelf();
                int count = fieldGeneratorSecondPersonSelf.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSecondPersonSelf(fieldGeneratorSecondPersonSelf.value[num]);
                  }
                fieldGeneratorSecondPersonSelf.value.Clear();
                fieldGeneratorSecondPersonSelf.have_value = false;
              }
            if (fieldGeneratorSecondPersonSelfSpoken.have_value)
              {
                result.initSecondPersonSelfSpoken();
                int count = fieldGeneratorSecondPersonSelfSpoken.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSecondPersonSelfSpoken(fieldGeneratorSecondPersonSelfSpoken.value[num]);
                  }
                fieldGeneratorSecondPersonSelfSpoken.value.Clear();
                fieldGeneratorSecondPersonSelfSpoken.have_value = false;
              }
            if (fieldGeneratorWakeUpPattern.have_value)
              {
                result.setWakeUpPattern(fieldGeneratorWakeUpPattern.value);
                fieldGeneratorWakeUpPattern.have_value = false;
              }
            if (fieldGeneratorUserID.have_value)
              {
                result.setUserID(fieldGeneratorUserID.value);
                fieldGeneratorUserID.have_value = false;
              }
            if (fieldGeneratorRequestID.have_value)
              {
                result.setRequestID(fieldGeneratorRequestID.value);
                fieldGeneratorRequestID.have_value = false;
              }
            if (fieldGeneratorSessionID.have_value)
              {
                result.setSessionID(fieldGeneratorSessionID.value);
                fieldGeneratorSessionID.have_value = false;
              }
            if (fieldGeneratorDomains.have_value)
              {
                result.setDomains(fieldGeneratorDomains.value);
                fieldGeneratorDomains.have_value = false;
              }
            if (fieldGeneratorResultUpdateAllowed.have_value)
              {
                result.setResultUpdateAllowed(fieldGeneratorResultUpdateAllowed.value);
                fieldGeneratorResultUpdateAllowed.have_value = false;
              }
            if (fieldGeneratorPartialTranscriptsDesired.have_value)
              {
                result.setPartialTranscriptsDesired(fieldGeneratorPartialTranscriptsDesired.value);
                fieldGeneratorPartialTranscriptsDesired.have_value = false;
              }
            if (fieldGeneratorMinResults.have_value)
              {
                result.setMinResults(fieldGeneratorMinResults.value);
                fieldGeneratorMinResults.have_value = false;
              }
            if (fieldGeneratorMaxResults.have_value)
              {
                result.setMaxResults(fieldGeneratorMaxResults.value);
                fieldGeneratorMaxResults.have_value = false;
              }
            if (fieldGeneratorObjectByteCountPrefix.have_value)
              {
                result.setObjectByteCountPrefix(fieldGeneratorObjectByteCountPrefix.value);
                fieldGeneratorObjectByteCountPrefix.have_value = false;
              }
            if (fieldGeneratorProfanityFilter.have_value)
              {
                result.setProfanityFilter(fieldGeneratorProfanityFilter.value);
                fieldGeneratorProfanityFilter.have_value = false;
              }
            if (fieldGeneratorClientMatches.have_value)
              {
                result.initClientMatches();
                int count = fieldGeneratorClientMatches.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendClientMatches(fieldGeneratorClientMatches.value[num]);
                  }
                fieldGeneratorClientMatches.value.Clear();
                fieldGeneratorClientMatches.have_value = false;
              }
            if (fieldGeneratorClientMatchesOnly.have_value)
              {
                result.setClientMatchesOnly(fieldGeneratorClientMatchesOnly.value);
                fieldGeneratorClientMatchesOnly.have_value = false;
              }
            if (fieldGeneratorPagination.have_value)
              {
                result.setPagination(fieldGeneratorPagination.value);
                fieldGeneratorPagination.have_value = false;
              }
            if (fieldGeneratorResponseAudioVoice.have_value)
              {
                result.setResponseAudioVoice(fieldGeneratorResponseAudioVoice.value);
                fieldGeneratorResponseAudioVoice.have_value = false;
              }
            if (fieldGeneratorResponseAudioShortOrLong.have_value)
              {
                result.setResponseAudioShortOrLong(fieldGeneratorResponseAudioShortOrLong.value);
                fieldGeneratorResponseAudioShortOrLong.have_value = false;
              }
            if (fieldGeneratorResponseAudioAcceptedEncodings.have_value)
              {
                result.initResponseAudioAcceptedEncodings();
                int count = fieldGeneratorResponseAudioAcceptedEncodings.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendResponseAudioAcceptedEncodings(fieldGeneratorResponseAudioAcceptedEncodings.value[num]);
                  }
                fieldGeneratorResponseAudioAcceptedEncodings.value.Clear();
                fieldGeneratorResponseAudioAcceptedEncodings.have_value = false;
              }
            if (fieldGeneratorVoiceActivityDetection.have_value)
              {
                result.setVoiceActivityDetection(fieldGeneratorVoiceActivityDetection.value);
                fieldGeneratorVoiceActivityDetection.have_value = false;
              }
            if (fieldGeneratorServerDeterminesEndOfAudio.have_value)
              {
                result.setServerDeterminesEndOfAudio(fieldGeneratorServerDeterminesEndOfAudio.value);
                fieldGeneratorServerDeterminesEndOfAudio.have_value = false;
              }
            if (fieldGeneratorIntentOnly.have_value)
              {
                result.setIntentOnly(fieldGeneratorIntentOnly.value);
                fieldGeneratorIntentOnly.have_value = false;
              }
            if (fieldGeneratorDisableSpellCorrection.have_value)
              {
                result.setDisableSpellCorrection(fieldGeneratorDisableSpellCorrection.value);
                fieldGeneratorDisableSpellCorrection.have_value = false;
              }
            if (fieldGeneratorUseContactData.have_value)
              {
                result.setUseContactData(fieldGeneratorUseContactData.value);
                fieldGeneratorUseContactData.have_value = false;
              }
            if (fieldGeneratorUseClientTime.have_value)
              {
                result.setUseClientTime(fieldGeneratorUseClientTime.value);
                fieldGeneratorUseClientTime.have_value = false;
              }
            if (fieldGeneratorForceConversationStateTime.have_value)
              {
                result.setForceConversationStateTime(fieldGeneratorForceConversationStateTime.value);
                fieldGeneratorForceConversationStateTime.have_value = false;
              }
            if (fieldGeneratorPhoneDisambiguationOmitList.have_value)
              {
                result.setPhoneDisambiguationOmitList(fieldGeneratorPhoneDisambiguationOmitList.value);
                fieldGeneratorPhoneDisambiguationOmitList.have_value = false;
              }
            if (fieldGeneratorIncomingCallPending.have_value)
              {
                result.setIncomingCallPending(fieldGeneratorIncomingCallPending.value);
                fieldGeneratorIncomingCallPending.have_value = false;
              }
            if (fieldGeneratorAllowPopularNameContactMatches.have_value)
              {
                result.setAllowPopularNameContactMatches(fieldGeneratorAllowPopularNameContactMatches.value);
                fieldGeneratorAllowPopularNameContactMatches.have_value = false;
              }
            if (fieldGeneratorMusicClientState.have_value)
              {
                result.setMusicClientState(fieldGeneratorMusicClientState.value);
                fieldGeneratorMusicClientState.have_value = false;
              }
            if (fieldGeneratorDisableMusicSearchListPositionSpecification.have_value)
              {
                result.setDisableMusicSearchListPositionSpecification(fieldGeneratorDisableMusicSearchListPositionSpecification.value);
                fieldGeneratorDisableMusicSearchListPositionSpecification.have_value = false;
              }
            if (fieldGeneratorCollateMusicEntities.have_value)
              {
                result.setCollateMusicEntities(fieldGeneratorCollateMusicEntities.value);
                fieldGeneratorCollateMusicEntities.have_value = false;
              }
            if (fieldGeneratorAllowContextFreeMusicSearchForPopularEntities.have_value)
              {
                result.setAllowContextFreeMusicSearchForPopularEntities(fieldGeneratorAllowContextFreeMusicSearchForPopularEntities.value);
                fieldGeneratorAllowContextFreeMusicSearchForPopularEntities.have_value = false;
              }
            if (fieldGeneratorReturnInformationNuggetsForMusicSearch.have_value)
              {
                result.setReturnInformationNuggetsForMusicSearch(fieldGeneratorReturnInformationNuggetsForMusicSearch.value);
                fieldGeneratorReturnInformationNuggetsForMusicSearch.have_value = false;
              }
            if (fieldGeneratorUseXAPAPI.have_value)
              {
                result.setUseXAPAPI(fieldGeneratorUseXAPAPI.value);
                fieldGeneratorUseXAPAPI.have_value = false;
              }
            if (fieldGeneratorLocalSearchClientState.have_value)
              {
                result.setLocalSearchClientState(fieldGeneratorLocalSearchClientState.value);
                fieldGeneratorLocalSearchClientState.have_value = false;
              }
            if (fieldGeneratorUberServerToken.have_value)
              {
                result.setUberServerToken(fieldGeneratorUberServerToken.value);
                fieldGeneratorUberServerToken.have_value = false;
              }
            if (fieldGeneratorGetUberServerToken.have_value)
              {
                result.setGetUberServerToken(fieldGeneratorGetUberServerToken.value);
                fieldGeneratorGetUberServerToken.have_value = false;
              }
            if (fieldGeneratorUberClientId.have_value)
              {
                result.setUberClientId(fieldGeneratorUberClientId.value);
                fieldGeneratorUberClientId.have_value = false;
              }
            if (fieldGeneratorGetUberClientId.have_value)
              {
                result.setGetUberClientId(fieldGeneratorGetUberClientId.value);
                fieldGeneratorGetUberClientId.have_value = false;
              }
            if (fieldGeneratorSetUserMemoryLocation.have_value)
              {
                result.setSetUserMemoryLocation(fieldGeneratorSetUserMemoryLocation.value);
                fieldGeneratorSetUserMemoryLocation.have_value = false;
              }
            if (fieldGeneratorDisableMusicPlayerListPositionSpecification.have_value)
              {
                result.setDisableMusicPlayerListPositionSpecification(fieldGeneratorDisableMusicPlayerListPositionSpecification.value);
                fieldGeneratorDisableMusicPlayerListPositionSpecification.have_value = false;
              }
            if (fieldGeneratorCarControlClimateClientConfiguration.have_value)
              {
                result.setCarControlClimateClientConfiguration(fieldGeneratorCarControlClimateClientConfiguration.value);
                fieldGeneratorCarControlClimateClientConfiguration.have_value = false;
              }
            if (fieldGeneratorHomeAutomationDomainSettings.have_value)
              {
                result.setHomeAutomationDomainSettings(fieldGeneratorHomeAutomationDomainSettings.value);
                fieldGeneratorHomeAutomationDomainSettings.have_value = false;
              }
            if (fieldGeneratorUserContactsRequests.have_value)
              {
                result.setUserContactsRequests(fieldGeneratorUserContactsRequests.value);
                fieldGeneratorUserContactsRequests.have_value = false;
              }
            if (fieldGeneratorStoredGlobalPagesToMatch.have_value)
              {
                result.setStoredGlobalPagesToMatch(fieldGeneratorStoredGlobalPagesToMatch.value);
                fieldGeneratorStoredGlobalPagesToMatch.have_value = false;
              }
            if (fieldGeneratorStoredGlobalPagesToNotMatch.have_value)
              {
                result.setStoredGlobalPagesToNotMatch(fieldGeneratorStoredGlobalPagesToNotMatch.value);
                fieldGeneratorStoredGlobalPagesToNotMatch.have_value = false;
              }
            if (fieldGeneratorStoredPerUserPagesToMatch.have_value)
              {
                result.setStoredPerUserPagesToMatch(fieldGeneratorStoredPerUserPagesToMatch.value);
                fieldGeneratorStoredPerUserPagesToMatch.have_value = false;
              }
            if (fieldGeneratorStoredPerUserPagesToNotMatch.have_value)
              {
                result.setStoredPerUserPagesToNotMatch(fieldGeneratorStoredPerUserPagesToNotMatch.value);
                fieldGeneratorStoredPerUserPagesToNotMatch.have_value = false;
              }
            if (fieldGeneratorStoredGlobalPagesToSetOnByDefault.have_value)
              {
                result.setStoredGlobalPagesToSetOnByDefault(fieldGeneratorStoredGlobalPagesToSetOnByDefault.value);
                fieldGeneratorStoredGlobalPagesToSetOnByDefault.have_value = false;
              }
            if (fieldGeneratorStoredPerUserPagesToSetOnByDefault.have_value)
              {
                result.setStoredPerUserPagesToSetOnByDefault(fieldGeneratorStoredPerUserPagesToSetOnByDefault.value);
                fieldGeneratorStoredPerUserPagesToSetOnByDefault.have_value = false;
              }
            if (fieldGeneratorStoredGlobalPagesToSetOffByDefault.have_value)
              {
                result.setStoredGlobalPagesToSetOffByDefault(fieldGeneratorStoredGlobalPagesToSetOffByDefault.value);
                fieldGeneratorStoredGlobalPagesToSetOffByDefault.have_value = false;
              }
            if (fieldGeneratorStoredPerUserPagesToSetOffByDefault.have_value)
              {
                result.setStoredPerUserPagesToSetOffByDefault(fieldGeneratorStoredPerUserPagesToSetOffByDefault.value);
                fieldGeneratorStoredPerUserPagesToSetOffByDefault.have_value = false;
              }
            if (fieldGeneratorStoredPageMatchWriteData.have_value)
              {
                result.setStoredPageMatchWriteData(fieldGeneratorStoredPageMatchWriteData.value);
                fieldGeneratorStoredPageMatchWriteData.have_value = false;
              }
            if (fieldGeneratorStoredPageMatchReadData.have_value)
              {
                result.setStoredPageMatchReadData(fieldGeneratorStoredPageMatchReadData.value);
                fieldGeneratorStoredPageMatchReadData.have_value = false;
              }
            if (fieldGeneratorStoredPageMatchPageListData.have_value)
              {
                result.setStoredPageMatchPageListData(fieldGeneratorStoredPageMatchPageListData.value);
                fieldGeneratorStoredPageMatchPageListData.have_value = false;
              }
            if (fieldGeneratorVoiceParameters.have_value)
              {
                result.setVoiceParameters(fieldGeneratorVoiceParameters.value);
                fieldGeneratorVoiceParameters.have_value = false;
              }
            if (fieldGeneratorStoredAlwaysMatchWriteData.have_value)
              {
                result.setStoredAlwaysMatchWriteData(fieldGeneratorStoredAlwaysMatchWriteData.value);
                fieldGeneratorStoredAlwaysMatchWriteData.have_value = false;
              }
            if (fieldGeneratorStoredAlwaysMatchReadData.have_value)
              {
                result.setStoredAlwaysMatchReadData(fieldGeneratorStoredAlwaysMatchReadData.value);
                fieldGeneratorStoredAlwaysMatchReadData.have_value = false;
              }
            if (fieldGeneratorUserFeedback.have_value)
              {
                result.setUserFeedback(fieldGeneratorUserFeedback.value);
                fieldGeneratorUserFeedback.have_value = false;
              }
            if (fieldGeneratorRadioControlRecognizeNorthAmericanFMBand.have_value)
              {
                result.setRadioControlRecognizeNorthAmericanFMBand(fieldGeneratorRadioControlRecognizeNorthAmericanFMBand.value);
                fieldGeneratorRadioControlRecognizeNorthAmericanFMBand.have_value = false;
              }
            if (fieldGeneratorRadioControlRecognizeNorthAmericanAMBand.have_value)
              {
                result.setRadioControlRecognizeNorthAmericanAMBand(fieldGeneratorRadioControlRecognizeNorthAmericanAMBand.value);
                fieldGeneratorRadioControlRecognizeNorthAmericanAMBand.have_value = false;
              }
            if (fieldGeneratorRadioControlOtherFMBands.have_value)
              {
                result.setRadioControlOtherFMBands(fieldGeneratorRadioControlOtherFMBands.value);
                fieldGeneratorRadioControlOtherFMBands.have_value = false;
              }
            if (fieldGeneratorRadioControlOtherAMBands.have_value)
              {
                result.setRadioControlOtherAMBands(fieldGeneratorRadioControlOtherAMBands.value);
                fieldGeneratorRadioControlOtherAMBands.have_value = false;
              }
            if (fieldGeneratorRadioControlAvailableAudioSources.have_value)
              {
                result.setRadioControlAvailableAudioSources(fieldGeneratorRadioControlAvailableAudioSources.value);
                fieldGeneratorRadioControlAvailableAudioSources.have_value = false;
              }
            if (fieldGeneratorClientListMatches.have_value)
              {
                result.setClientListMatches(fieldGeneratorClientListMatches.value);
                fieldGeneratorClientListMatches.have_value = false;
              }
            if (fieldGeneratorIntentToExecute.have_value)
              {
                result.setIntentToExecute(fieldGeneratorIntentToExecute.value);
                fieldGeneratorIntentToExecute.have_value = false;
              }
            if (fieldGeneratorRobotInfo.have_value)
              {
                result.setRobotInfo(fieldGeneratorRobotInfo.value);
                fieldGeneratorRobotInfo.have_value = false;
              }
            if (fieldGeneratorConvertToNewInformationNuggets.have_value)
              {
                result.setConvertToNewInformationNuggets(fieldGeneratorConvertToNewInformationNuggets.value);
                fieldGeneratorConvertToNewInformationNuggets.have_value = false;
              }
            if (fieldGeneratorAcapelaVoiceParameters.have_value)
              {
                result.setAcapelaVoiceParameters(fieldGeneratorAcapelaVoiceParameters.value);
                fieldGeneratorAcapelaVoiceParameters.have_value = false;
              }
            if (fieldGeneratorOutputOverrideCommandIsPreAudioOut.have_value)
              {
                result.setOutputOverrideCommandIsPreAudioOut(fieldGeneratorOutputOverrideCommandIsPreAudioOut.value);
                fieldGeneratorOutputOverrideCommandIsPreAudioOut.have_value = false;
              }
            if (fieldGeneratorOutputOverrideCommandFunction.have_value)
              {
                result.setOutputOverrideCommandFunction(fieldGeneratorOutputOverrideCommandFunction.value);
                fieldGeneratorOutputOverrideCommandFunction.have_value = false;
              }
            if (fieldGeneratorOutputOverrideCommandFunctionLanguage.have_value)
              {
                result.setOutputOverrideCommandFunctionLanguage(fieldGeneratorOutputOverrideCommandFunctionLanguage.value);
                fieldGeneratorOutputOverrideCommandFunctionLanguage.have_value = false;
              }
            if (fieldGeneratorOutputOverrideCommandFunctionSource.have_value)
              {
                result.setOutputOverrideCommandFunctionSource(fieldGeneratorOutputOverrideCommandFunctionSource.value);
                fieldGeneratorOutputOverrideCommandFunctionSource.have_value = false;
              }
            if (fieldGeneratorOutputOverrideDeleteCommandFunction.have_value)
              {
                result.setOutputOverrideDeleteCommandFunction(fieldGeneratorOutputOverrideDeleteCommandFunction.value);
                fieldGeneratorOutputOverrideDeleteCommandFunction.have_value = false;
              }
            if (fieldGeneratorOutputOverrideReadCommandFunction.have_value)
              {
                result.setOutputOverrideReadCommandFunction(fieldGeneratorOutputOverrideReadCommandFunction.value);
                fieldGeneratorOutputOverrideReadCommandFunction.have_value = false;
              }
            if (fieldGeneratorOutputOverrideInformationNuggetFunction.have_value)
              {
                result.setOutputOverrideInformationNuggetFunction(fieldGeneratorOutputOverrideInformationNuggetFunction.value);
                fieldGeneratorOutputOverrideInformationNuggetFunction.have_value = false;
              }
            if (fieldGeneratorOutputOverrideInformationNuggetFunctionLanguage.have_value)
              {
                result.setOutputOverrideInformationNuggetFunctionLanguage(fieldGeneratorOutputOverrideInformationNuggetFunctionLanguage.value);
                fieldGeneratorOutputOverrideInformationNuggetFunctionLanguage.have_value = false;
              }
            if (fieldGeneratorOutputOverrideInformationNuggetFunctionSource.have_value)
              {
                result.setOutputOverrideInformationNuggetFunctionSource(fieldGeneratorOutputOverrideInformationNuggetFunctionSource.value);
                fieldGeneratorOutputOverrideInformationNuggetFunctionSource.have_value = false;
              }
            if (fieldGeneratorOutputOverrideDeleteInformationNuggetFunction.have_value)
              {
                result.setOutputOverrideDeleteInformationNuggetFunction(fieldGeneratorOutputOverrideDeleteInformationNuggetFunction.value);
                fieldGeneratorOutputOverrideDeleteInformationNuggetFunction.have_value = false;
              }
            if (fieldGeneratorOutputOverrideReadInformationNuggetFunction.have_value)
              {
                result.setOutputOverrideReadInformationNuggetFunction(fieldGeneratorOutputOverrideReadInformationNuggetFunction.value);
                fieldGeneratorOutputOverrideReadInformationNuggetFunction.have_value = false;
              }
            if (fieldGeneratorTerrierUploadWriteData.have_value)
              {
                result.setTerrierUploadWriteData(fieldGeneratorTerrierUploadWriteData.value);
                fieldGeneratorTerrierUploadWriteData.have_value = false;
              }
            if (fieldGeneratorTerrierUploadReadData.have_value)
              {
                result.setTerrierUploadReadData(fieldGeneratorTerrierUploadReadData.value);
                fieldGeneratorTerrierUploadReadData.have_value = false;
              }
            if (fieldGeneratorDisambiguateResultsBeforeAction.have_value)
              {
                result.setDisambiguateResultsBeforeAction(fieldGeneratorDisambiguateResultsBeforeAction.value);
                fieldGeneratorDisambiguateResultsBeforeAction.have_value = false;
              }
            if (fieldGeneratorInputOverrideFunction.have_value)
              {
                result.setInputOverrideFunction(fieldGeneratorInputOverrideFunction.value);
                fieldGeneratorInputOverrideFunction.have_value = false;
              }
            if (fieldGeneratorInputOverrideFunctionLanguage.have_value)
              {
                result.setInputOverrideFunctionLanguage(fieldGeneratorInputOverrideFunctionLanguage.value);
                fieldGeneratorInputOverrideFunctionLanguage.have_value = false;
              }
            if (fieldGeneratorInputOverrideFunctionSource.have_value)
              {
                result.setInputOverrideFunctionSource(fieldGeneratorInputOverrideFunctionSource.value);
                fieldGeneratorInputOverrideFunctionSource.have_value = false;
              }
            if (fieldGeneratorInputOverrideDeleteFunction.have_value)
              {
                result.setInputOverrideDeleteFunction(fieldGeneratorInputOverrideDeleteFunction.value);
                fieldGeneratorInputOverrideDeleteFunction.have_value = false;
              }
            if (fieldGeneratorInputOverrideReadFunction.have_value)
              {
                result.setInputOverrideReadFunction(fieldGeneratorInputOverrideReadFunction.value);
                fieldGeneratorInputOverrideReadFunction.have_value = false;
              }
            if (fieldGeneratorSportsLeagueControl.have_value)
              {
                result.setSportsLeagueControl(fieldGeneratorSportsLeagueControl.value);
                fieldGeneratorSportsLeagueControl.have_value = false;
              }
          }
        protected abstract void handle_result(RequestInfoJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'c':
                            if ((String.Compare(field_name, 2, "apelaVoiceParameters", 0, 20, false) == 0) && (field_name.Length == 22))
                                return fieldGeneratorAcapelaVoiceParameters;
                            break;
                        case 'l':
                            if (String.Compare(field_name, 2, "low", 0, 3, false) == 0)
                              {
                                switch (field_name[5])
                                  {
                                    case 'C':
                                        if ((String.Compare(field_name, 6, "ontextFreeMusicSearchForPopularEntities", 0, 39, false) == 0) && (field_name.Length == 45))
                                            return fieldGeneratorAllowContextFreeMusicSearchForPopularEntities;
                                        break;
                                    case 'P':
                                        if ((String.Compare(field_name, 6, "opularNameContactMatches", 0, 24, false) == 0) && (field_name.Length == 30))
                                            return fieldGeneratorAllowPopularNameContactMatches;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'C':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "rControlClimateClientConfiguration", 0, 34, false) == 0) && (field_name.Length == 36))
                                return fieldGeneratorCarControlClimateClientConfiguration;
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "ty", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorCity;
                            break;
                        case 'l':
                            if (String.Compare(field_name, 2, "ient", 0, 4, false) == 0)
                              {
                                switch (field_name[6])
                                  {
                                    case 'I':
                                        if ((String.Compare(field_name, 7, "D", 0, 1, false) == 0) && (field_name.Length == 8))
                                            return fieldGeneratorClientID;
                                        break;
                                    case 'L':
                                        if ((String.Compare(field_name, 7, "istMatches", 0, 10, false) == 0) && (field_name.Length == 17))
                                            return fieldGeneratorClientListMatches;
                                        break;
                                    case 'M':
                                        if (String.Compare(field_name, 7, "atches", 0, 6, false) == 0)
                                          {
                                            if (field_name.Length == 13)
                                              {
                                                return fieldGeneratorClientMatches;
                                              }
                                            switch (field_name[13])
                                              {
                                                case 'O':
                                                    if ((String.Compare(field_name, 14, "nly", 0, 3, false) == 0) && (field_name.Length == 17))
                                                        return fieldGeneratorClientMatchesOnly;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'S':
                                        if ((String.Compare(field_name, 7, "tate", 0, 4, false) == 0) && (field_name.Length == 11))
                                            return fieldGeneratorClientState;
                                        break;
                                    case 'V':
                                        if ((String.Compare(field_name, 7, "ersion", 0, 6, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratorClientVersion;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'o':
                            switch (field_name[2])
                              {
                                case 'l':
                                    if ((String.Compare(field_name, 3, "lateMusicEntities", 0, 17, false) == 0) && (field_name.Length == 20))
                                        return fieldGeneratorCollateMusicEntities;
                                    break;
                                case 'n':
                                    switch (field_name[3])
                                      {
                                        case 't':
                                            if ((String.Compare(field_name, 4, "rollableTrackPlaying", 0, 20, false) == 0) && (field_name.Length == 24))
                                                return fieldGeneratorControllableTrackPlaying;
                                            break;
                                        case 'v':
                                            if (String.Compare(field_name, 4, "er", 0, 2, false) == 0)
                                              {
                                                switch (field_name[6])
                                                  {
                                                    case 's':
                                                        if ((String.Compare(field_name, 7, "ationState", 0, 10, false) == 0) && (field_name.Length == 17))
                                                            return fieldGeneratorConversationState;
                                                        break;
                                                    case 't':
                                                        if ((String.Compare(field_name, 7, "ToNewInformationNuggets", 0, 23, false) == 0) && (field_name.Length == 30))
                                                            return fieldGeneratorConvertToNewInformationNuggets;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'u':
                                    if ((String.Compare(field_name, 3, "ntry", 0, 4, false) == 0) && (field_name.Length == 7))
                                        return fieldGeneratorCountry;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'D':
                    switch (field_name[1])
                      {
                        case 'e':
                            switch (field_name[2])
                              {
                                case 'f':
                                    if ((String.Compare(field_name, 3, "aultTimeFormat24Hours", 0, 21, false) == 0) && (field_name.Length == 24))
                                        return fieldGeneratorDefaultTimeFormat24Hours;
                                    break;
                                case 'v':
                                    if ((String.Compare(field_name, 3, "iceID", 0, 5, false) == 0) && (field_name.Length == 8))
                                        return fieldGeneratorDeviceID;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'i':
                            if (String.Compare(field_name, 2, "sa", 0, 2, false) == 0)
                              {
                                switch (field_name[4])
                                  {
                                    case 'b':
                                        if (String.Compare(field_name, 5, "le", 0, 2, false) == 0)
                                          {
                                            switch (field_name[7])
                                              {
                                                case 'M':
                                                    if (String.Compare(field_name, 8, "usic", 0, 4, false) == 0)
                                                      {
                                                        switch (field_name[12])
                                                          {
                                                            case 'P':
                                                                if ((String.Compare(field_name, 13, "layerListPositionSpecification", 0, 30, false) == 0) && (field_name.Length == 43))
                                                                    return fieldGeneratorDisableMusicPlayerListPositionSpecification;
                                                                break;
                                                            case 'S':
                                                                if ((String.Compare(field_name, 13, "earchListPositionSpecification", 0, 30, false) == 0) && (field_name.Length == 43))
                                                                    return fieldGeneratorDisableMusicSearchListPositionSpecification;
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                      }
                                                    break;
                                                case 'S':
                                                    if ((String.Compare(field_name, 8, "pellCorrection", 0, 14, false) == 0) && (field_name.Length == 22))
                                                        return fieldGeneratorDisableSpellCorrection;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'm':
                                        if ((String.Compare(field_name, 5, "biguateResultsBeforeAction", 0, 26, false) == 0) && (field_name.Length == 31))
                                            return fieldGeneratorDisambiguateResultsBeforeAction;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "mains", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorDomains;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'F':
                    switch (field_name[1])
                      {
                        case 'i':
                            if (String.Compare(field_name, 2, "rstPersonSelf", 0, 13, false) == 0)
                              {
                                if (field_name.Length == 15)
                                  {
                                    return fieldGeneratorFirstPersonSelf;
                                  }
                                switch (field_name[15])
                                  {
                                    case 'S':
                                        if ((String.Compare(field_name, 16, "poken", 0, 5, false) == 0) && (field_name.Length == 21))
                                            return fieldGeneratorFirstPersonSelfSpoken;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "rceConversationStateTime", 0, 24, false) == 0) && (field_name.Length == 26))
                                return fieldGeneratorForceConversationStateTime;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'G':
                    if (String.Compare(field_name, 1, "etUber", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'C':
                                if ((String.Compare(field_name, 8, "lientId", 0, 7, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorGetUberClientId;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 8, "erverToken", 0, 10, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorGetUberServerToken;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "omeAutomationDomainSettings", 0, 27, false) == 0) && (field_name.Length == 28))
                        return fieldGeneratorHomeAutomationDomainSettings;
                    break;
                case 'I':
                    if (String.Compare(field_name, 1, "n", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'c':
                                if ((String.Compare(field_name, 3, "omingCallPending", 0, 16, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorIncomingCallPending;
                                break;
                            case 'p':
                                if (String.Compare(field_name, 3, "ut", 0, 2, false) == 0)
                                  {
                                    switch (field_name[5])
                                      {
                                        case 'L':
                                            if (String.Compare(field_name, 6, "anguage", 0, 7, false) == 0)
                                              {
                                                switch (field_name[13])
                                                  {
                                                    case 'E':
                                                        if ((String.Compare(field_name, 14, "nglishName", 0, 10, false) == 0) && (field_name.Length == 24))
                                                            return fieldGeneratorInputLanguageEnglishName;
                                                        break;
                                                    case 'I':
                                                        if ((String.Compare(field_name, 14, "ETFTag", 0, 6, false) == 0) && (field_name.Length == 20))
                                                            return fieldGeneratorInputLanguageIETFTag;
                                                        break;
                                                    case 'N':
                                                        if ((String.Compare(field_name, 14, "ativeName", 0, 9, false) == 0) && (field_name.Length == 23))
                                                            return fieldGeneratorInputLanguageNativeName;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'O':
                                            if (String.Compare(field_name, 6, "verride", 0, 7, false) == 0)
                                              {
                                                switch (field_name[13])
                                                  {
                                                    case 'D':
                                                        if ((String.Compare(field_name, 14, "eleteFunction", 0, 13, false) == 0) && (field_name.Length == 27))
                                                            return fieldGeneratorInputOverrideDeleteFunction;
                                                        break;
                                                    case 'F':
                                                        if (String.Compare(field_name, 14, "unction", 0, 7, false) == 0)
                                                          {
                                                            if (field_name.Length == 21)
                                                              {
                                                                return fieldGeneratorInputOverrideFunction;
                                                              }
                                                            switch (field_name[21])
                                                              {
                                                                case 'L':
                                                                    if ((String.Compare(field_name, 22, "anguage", 0, 7, false) == 0) && (field_name.Length == 29))
                                                                        return fieldGeneratorInputOverrideFunctionLanguage;
                                                                    break;
                                                                case 'S':
                                                                    if ((String.Compare(field_name, 22, "ource", 0, 5, false) == 0) && (field_name.Length == 27))
                                                                        return fieldGeneratorInputOverrideFunctionSource;
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                          }
                                                        break;
                                                    case 'R':
                                                        if ((String.Compare(field_name, 14, "eadFunction", 0, 11, false) == 0) && (field_name.Length == 25))
                                                            return fieldGeneratorInputOverrideReadFunction;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 't':
                                if (String.Compare(field_name, 3, "ent", 0, 3, false) == 0)
                                  {
                                    switch (field_name[6])
                                      {
                                        case 'O':
                                            if ((String.Compare(field_name, 7, "nly", 0, 3, false) == 0) && (field_name.Length == 10))
                                                return fieldGeneratorIntentOnly;
                                            break;
                                        case 'T':
                                            if ((String.Compare(field_name, 7, "oExecute", 0, 8, false) == 0) && (field_name.Length == 15))
                                                return fieldGeneratorIntentToExecute;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'L':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "titude", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorLatitude;
                            break;
                        case 'o':
                            switch (field_name[2])
                              {
                                case 'c':
                                    if ((String.Compare(field_name, 3, "alSearchClientState", 0, 19, false) == 0) && (field_name.Length == 22))
                                        return fieldGeneratorLocalSearchClientState;
                                    break;
                                case 'n':
                                    if ((String.Compare(field_name, 3, "gitude", 0, 6, false) == 0) && (field_name.Length == 9))
                                        return fieldGeneratorLongitude;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'M':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "xResults", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorMaxResults;
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "nResults", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorMinResults;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "sicClientState", 0, 14, false) == 0) && (field_name.Length == 16))
                                return fieldGeneratorMusicClientState;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'O':
                    switch (field_name[1])
                      {
                        case 'b':
                            if ((String.Compare(field_name, 2, "jectByteCountPrefix", 0, 19, false) == 0) && (field_name.Length == 21))
                                return fieldGeneratorObjectByteCountPrefix;
                            break;
                        case 'u':
                            if (String.Compare(field_name, 2, "tput", 0, 4, false) == 0)
                              {
                                switch (field_name[6])
                                  {
                                    case 'L':
                                        if (String.Compare(field_name, 7, "anguage", 0, 7, false) == 0)
                                          {
                                            switch (field_name[14])
                                              {
                                                case 'E':
                                                    if ((String.Compare(field_name, 15, "nglishName", 0, 10, false) == 0) && (field_name.Length == 25))
                                                        return fieldGeneratorOutputLanguageEnglishName;
                                                    break;
                                                case 'I':
                                                    if ((String.Compare(field_name, 15, "ETFTag", 0, 6, false) == 0) && (field_name.Length == 21))
                                                        return fieldGeneratorOutputLanguageIETFTag;
                                                    break;
                                                case 'N':
                                                    if ((String.Compare(field_name, 15, "ativeName", 0, 9, false) == 0) && (field_name.Length == 24))
                                                        return fieldGeneratorOutputLanguageNativeName;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'O':
                                        if (String.Compare(field_name, 7, "verride", 0, 7, false) == 0)
                                          {
                                            switch (field_name[14])
                                              {
                                                case 'C':
                                                    if (String.Compare(field_name, 15, "ommand", 0, 6, false) == 0)
                                                      {
                                                        switch (field_name[21])
                                                          {
                                                            case 'F':
                                                                if (String.Compare(field_name, 22, "unction", 0, 7, false) == 0)
                                                                  {
                                                                    if (field_name.Length == 29)
                                                                      {
                                                                        return fieldGeneratorOutputOverrideCommandFunction;
                                                                      }
                                                                    switch (field_name[29])
                                                                      {
                                                                        case 'L':
                                                                            if ((String.Compare(field_name, 30, "anguage", 0, 7, false) == 0) && (field_name.Length == 37))
                                                                                return fieldGeneratorOutputOverrideCommandFunctionLanguage;
                                                                            break;
                                                                        case 'S':
                                                                            if ((String.Compare(field_name, 30, "ource", 0, 5, false) == 0) && (field_name.Length == 35))
                                                                                return fieldGeneratorOutputOverrideCommandFunctionSource;
                                                                            break;
                                                                        default:
                                                                            break;
                                                                      }
                                                                  }
                                                                break;
                                                            case 'I':
                                                                if ((String.Compare(field_name, 22, "sPreAudioOut", 0, 12, false) == 0) && (field_name.Length == 34))
                                                                    return fieldGeneratorOutputOverrideCommandIsPreAudioOut;
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                      }
                                                    break;
                                                case 'D':
                                                    if (String.Compare(field_name, 15, "elete", 0, 5, false) == 0)
                                                      {
                                                        switch (field_name[20])
                                                          {
                                                            case 'C':
                                                                if ((String.Compare(field_name, 21, "ommandFunction", 0, 14, false) == 0) && (field_name.Length == 35))
                                                                    return fieldGeneratorOutputOverrideDeleteCommandFunction;
                                                                break;
                                                            case 'I':
                                                                if ((String.Compare(field_name, 21, "nformationNuggetFunction", 0, 24, false) == 0) && (field_name.Length == 45))
                                                                    return fieldGeneratorOutputOverrideDeleteInformationNuggetFunction;
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                      }
                                                    break;
                                                case 'I':
                                                    if (String.Compare(field_name, 15, "nformationNuggetFunction", 0, 24, false) == 0)
                                                      {
                                                        if (field_name.Length == 39)
                                                          {
                                                            return fieldGeneratorOutputOverrideInformationNuggetFunction;
                                                          }
                                                        switch (field_name[39])
                                                          {
                                                            case 'L':
                                                                if ((String.Compare(field_name, 40, "anguage", 0, 7, false) == 0) && (field_name.Length == 47))
                                                                    return fieldGeneratorOutputOverrideInformationNuggetFunctionLanguage;
                                                                break;
                                                            case 'S':
                                                                if ((String.Compare(field_name, 40, "ource", 0, 5, false) == 0) && (field_name.Length == 45))
                                                                    return fieldGeneratorOutputOverrideInformationNuggetFunctionSource;
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                      }
                                                    break;
                                                case 'R':
                                                    if (String.Compare(field_name, 15, "ead", 0, 3, false) == 0)
                                                      {
                                                        switch (field_name[18])
                                                          {
                                                            case 'C':
                                                                if ((String.Compare(field_name, 19, "ommandFunction", 0, 14, false) == 0) && (field_name.Length == 33))
                                                                    return fieldGeneratorOutputOverrideReadCommandFunction;
                                                                break;
                                                            case 'I':
                                                                if ((String.Compare(field_name, 19, "nformationNuggetFunction", 0, 24, false) == 0) && (field_name.Length == 43))
                                                                    return fieldGeneratorOutputOverrideReadInformationNuggetFunction;
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                      }
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'P':
                    switch (field_name[1])
                      {
                        case 'a':
                            switch (field_name[2])
                              {
                                case 'g':
                                    if ((String.Compare(field_name, 3, "ination", 0, 7, false) == 0) && (field_name.Length == 10))
                                        return fieldGeneratorPagination;
                                    break;
                                case 'r':
                                    if ((String.Compare(field_name, 3, "tialTranscriptsDesired", 0, 22, false) == 0) && (field_name.Length == 25))
                                        return fieldGeneratorPartialTranscriptsDesired;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'h':
                            if ((String.Compare(field_name, 2, "oneDisambiguationOmitList", 0, 25, false) == 0) && (field_name.Length == 27))
                                return fieldGeneratorPhoneDisambiguationOmitList;
                            break;
                        case 'o':
                            if (String.Compare(field_name, 2, "sition", 0, 6, false) == 0)
                              {
                                switch (field_name[8])
                                  {
                                    case 'H':
                                        if ((String.Compare(field_name, 9, "orizontalAccuracy", 0, 17, false) == 0) && (field_name.Length == 26))
                                            return fieldGeneratorPositionHorizontalAccuracy;
                                        break;
                                    case 'T':
                                        if ((String.Compare(field_name, 9, "ime", 0, 3, false) == 0) && (field_name.Length == 12))
                                            return fieldGeneratorPositionTime;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'r':
                            switch (field_name[2])
                              {
                                case 'e':
                                    if ((String.Compare(field_name, 3, "ferredImageSize", 0, 15, false) == 0) && (field_name.Length == 18))
                                        return fieldGeneratorPreferredImageSize;
                                    break;
                                case 'o':
                                    if ((String.Compare(field_name, 3, "fanityFilter", 0, 12, false) == 0) && (field_name.Length == 15))
                                        return fieldGeneratorProfanityFilter;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'R':
                    switch (field_name[1])
                      {
                        case 'a':
                            if (String.Compare(field_name, 2, "dioControl", 0, 10, false) == 0)
                              {
                                switch (field_name[12])
                                  {
                                    case 'A':
                                        if ((String.Compare(field_name, 13, "vailableAudioSources", 0, 20, false) == 0) && (field_name.Length == 33))
                                            return fieldGeneratorRadioControlAvailableAudioSources;
                                        break;
                                    case 'O':
                                        if (String.Compare(field_name, 13, "ther", 0, 4, false) == 0)
                                          {
                                            switch (field_name[17])
                                              {
                                                case 'A':
                                                    if ((String.Compare(field_name, 18, "MBands", 0, 6, false) == 0) && (field_name.Length == 24))
                                                        return fieldGeneratorRadioControlOtherAMBands;
                                                    break;
                                                case 'F':
                                                    if ((String.Compare(field_name, 18, "MBands", 0, 6, false) == 0) && (field_name.Length == 24))
                                                        return fieldGeneratorRadioControlOtherFMBands;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'R':
                                        if (String.Compare(field_name, 13, "ecognizeNorthAmerican", 0, 21, false) == 0)
                                          {
                                            switch (field_name[34])
                                              {
                                                case 'A':
                                                    if ((String.Compare(field_name, 35, "MBand", 0, 5, false) == 0) && (field_name.Length == 40))
                                                        return fieldGeneratorRadioControlRecognizeNorthAmericanAMBand;
                                                    break;
                                                case 'F':
                                                    if ((String.Compare(field_name, 35, "MBand", 0, 5, false) == 0) && (field_name.Length == 40))
                                                        return fieldGeneratorRadioControlRecognizeNorthAmericanFMBand;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'e':
                            switch (field_name[2])
                              {
                                case 'q':
                                    if ((String.Compare(field_name, 3, "uestID", 0, 6, false) == 0) && (field_name.Length == 9))
                                        return fieldGeneratorRequestID;
                                    break;
                                case 's':
                                    switch (field_name[3])
                                      {
                                        case 'p':
                                            if (String.Compare(field_name, 4, "onseAudio", 0, 9, false) == 0)
                                              {
                                                switch (field_name[13])
                                                  {
                                                    case 'A':
                                                        if ((String.Compare(field_name, 14, "cceptedEncodings", 0, 16, false) == 0) && (field_name.Length == 30))
                                                            return fieldGeneratorResponseAudioAcceptedEncodings;
                                                        break;
                                                    case 'S':
                                                        if ((String.Compare(field_name, 14, "hortOrLong", 0, 10, false) == 0) && (field_name.Length == 24))
                                                            return fieldGeneratorResponseAudioShortOrLong;
                                                        break;
                                                    case 'V':
                                                        if ((String.Compare(field_name, 14, "oice", 0, 4, false) == 0) && (field_name.Length == 18))
                                                            return fieldGeneratorResponseAudioVoice;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'u':
                                            if (String.Compare(field_name, 4, "lt", 0, 2, false) == 0)
                                              {
                                                switch (field_name[6])
                                                  {
                                                    case 'U':
                                                        if ((String.Compare(field_name, 7, "pdateAllowed", 0, 12, false) == 0) && (field_name.Length == 19))
                                                            return fieldGeneratorResultUpdateAllowed;
                                                        break;
                                                    case 'V':
                                                        if ((String.Compare(field_name, 7, "ersionAccepted", 0, 14, false) == 0) && (field_name.Length == 21))
                                                            return fieldGeneratorResultVersionAccepted;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 't':
                                    if ((String.Compare(field_name, 3, "urnInformationNuggetsForMusicSearch", 0, 35, false) == 0) && (field_name.Length == 38))
                                        return fieldGeneratorReturnInformationNuggetsForMusicSearch;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'o':
                            switch (field_name[2])
                              {
                                case 'b':
                                    if ((String.Compare(field_name, 3, "otInfo", 0, 6, false) == 0) && (field_name.Length == 9))
                                        return fieldGeneratorRobotInfo;
                                    break;
                                case 'u':
                                    if ((String.Compare(field_name, 3, "tePoints", 0, 8, false) == 0) && (field_name.Length == 11))
                                        return fieldGeneratorRoutePoints;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'D':
                            if (String.Compare(field_name, 2, "K", 0, 1, false) == 0)
                              {
                                if (field_name.Length == 3)
                                  {
                                    return fieldGeneratorSDK;
                                  }
                                switch (field_name[3])
                                  {
                                    case 'I':
                                        if ((String.Compare(field_name, 4, "nfo", 0, 3, false) == 0) && (field_name.Length == 7))
                                            return fieldGeneratorSDKInfo;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'e':
                            switch (field_name[2])
                              {
                                case 'c':
                                    if (String.Compare(field_name, 3, "ondPersonSelf", 0, 13, false) == 0)
                                      {
                                        if (field_name.Length == 16)
                                          {
                                            return fieldGeneratorSecondPersonSelf;
                                          }
                                        switch (field_name[16])
                                          {
                                            case 'S':
                                                if ((String.Compare(field_name, 17, "poken", 0, 5, false) == 0) && (field_name.Length == 22))
                                                    return fieldGeneratorSecondPersonSelfSpoken;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'n':
                                    if ((String.Compare(field_name, 3, "dBack", 0, 5, false) == 0) && (field_name.Length == 8))
                                        return fieldGeneratorSendBack;
                                    break;
                                case 'r':
                                    if ((String.Compare(field_name, 3, "verDeterminesEndOfAudio", 0, 23, false) == 0) && (field_name.Length == 26))
                                        return fieldGeneratorServerDeterminesEndOfAudio;
                                    break;
                                case 's':
                                    if ((String.Compare(field_name, 3, "sionID", 0, 6, false) == 0) && (field_name.Length == 9))
                                        return fieldGeneratorSessionID;
                                    break;
                                case 't':
                                    if ((String.Compare(field_name, 3, "UserMemoryLocation", 0, 18, false) == 0) && (field_name.Length == 21))
                                        return fieldGeneratorSetUserMemoryLocation;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'p':
                            if ((String.Compare(field_name, 2, "ortsLeagueControl", 0, 17, false) == 0) && (field_name.Length == 19))
                                return fieldGeneratorSportsLeagueControl;
                            break;
                        case 't':
                            switch (field_name[2])
                              {
                                case 'a':
                                    if ((String.Compare(field_name, 3, "te", 0, 2, false) == 0) && (field_name.Length == 5))
                                        return fieldGeneratorState;
                                    break;
                                case 'o':
                                    if (String.Compare(field_name, 3, "red", 0, 3, false) == 0)
                                      {
                                        switch (field_name[6])
                                          {
                                            case 'A':
                                                if (String.Compare(field_name, 7, "lwaysMatch", 0, 10, false) == 0)
                                                  {
                                                    switch (field_name[17])
                                                      {
                                                        case 'R':
                                                            if ((String.Compare(field_name, 18, "eadData", 0, 7, false) == 0) && (field_name.Length == 25))
                                                                return fieldGeneratorStoredAlwaysMatchReadData;
                                                            break;
                                                        case 'W':
                                                            if ((String.Compare(field_name, 18, "riteData", 0, 8, false) == 0) && (field_name.Length == 26))
                                                                return fieldGeneratorStoredAlwaysMatchWriteData;
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'G':
                                                if (String.Compare(field_name, 7, "lobalPagesTo", 0, 12, false) == 0)
                                                  {
                                                    switch (field_name[19])
                                                      {
                                                        case 'M':
                                                            if ((String.Compare(field_name, 20, "atch", 0, 4, false) == 0) && (field_name.Length == 24))
                                                                return fieldGeneratorStoredGlobalPagesToMatch;
                                                            break;
                                                        case 'N':
                                                            if ((String.Compare(field_name, 20, "otMatch", 0, 7, false) == 0) && (field_name.Length == 27))
                                                                return fieldGeneratorStoredGlobalPagesToNotMatch;
                                                            break;
                                                        case 'S':
                                                            if (String.Compare(field_name, 20, "etO", 0, 3, false) == 0)
                                                              {
                                                                switch (field_name[23])
                                                                  {
                                                                    case 'f':
                                                                        if ((String.Compare(field_name, 24, "fByDefault", 0, 10, false) == 0) && (field_name.Length == 34))
                                                                            return fieldGeneratorStoredGlobalPagesToSetOffByDefault;
                                                                        break;
                                                                    case 'n':
                                                                        if ((String.Compare(field_name, 24, "ByDefault", 0, 9, false) == 0) && (field_name.Length == 33))
                                                                            return fieldGeneratorStoredGlobalPagesToSetOnByDefault;
                                                                        break;
                                                                    default:
                                                                        break;
                                                                  }
                                                              }
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'P':
                                                switch (field_name[7])
                                                  {
                                                    case 'a':
                                                        if (String.Compare(field_name, 8, "geMatch", 0, 7, false) == 0)
                                                          {
                                                            switch (field_name[15])
                                                              {
                                                                case 'P':
                                                                    if ((String.Compare(field_name, 16, "ageListData", 0, 11, false) == 0) && (field_name.Length == 27))
                                                                        return fieldGeneratorStoredPageMatchPageListData;
                                                                    break;
                                                                case 'R':
                                                                    if ((String.Compare(field_name, 16, "eadData", 0, 7, false) == 0) && (field_name.Length == 23))
                                                                        return fieldGeneratorStoredPageMatchReadData;
                                                                    break;
                                                                case 'W':
                                                                    if ((String.Compare(field_name, 16, "riteData", 0, 8, false) == 0) && (field_name.Length == 24))
                                                                        return fieldGeneratorStoredPageMatchWriteData;
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                          }
                                                        break;
                                                    case 'e':
                                                        if (String.Compare(field_name, 8, "rUserPagesTo", 0, 12, false) == 0)
                                                          {
                                                            switch (field_name[20])
                                                              {
                                                                case 'M':
                                                                    if ((String.Compare(field_name, 21, "atch", 0, 4, false) == 0) && (field_name.Length == 25))
                                                                        return fieldGeneratorStoredPerUserPagesToMatch;
                                                                    break;
                                                                case 'N':
                                                                    if ((String.Compare(field_name, 21, "otMatch", 0, 7, false) == 0) && (field_name.Length == 28))
                                                                        return fieldGeneratorStoredPerUserPagesToNotMatch;
                                                                    break;
                                                                case 'S':
                                                                    if (String.Compare(field_name, 21, "etO", 0, 3, false) == 0)
                                                                      {
                                                                        switch (field_name[24])
                                                                          {
                                                                            case 'f':
                                                                                if ((String.Compare(field_name, 25, "fByDefault", 0, 10, false) == 0) && (field_name.Length == 35))
                                                                                    return fieldGeneratorStoredPerUserPagesToSetOffByDefault;
                                                                                break;
                                                                            case 'n':
                                                                                if ((String.Compare(field_name, 25, "ByDefault", 0, 9, false) == 0) && (field_name.Length == 34))
                                                                                    return fieldGeneratorStoredPerUserPagesToSetOnByDefault;
                                                                                break;
                                                                            default:
                                                                                break;
                                                                          }
                                                                      }
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                          }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'r':
                                    if ((String.Compare(field_name, 3, "eet", 0, 3, false) == 0) && (field_name.Length == 6))
                                        return fieldGeneratorStreet;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    switch (field_name[1])
                      {
                        case 'e':
                            if (String.Compare(field_name, 2, "rrierUpload", 0, 11, false) == 0)
                              {
                                switch (field_name[13])
                                  {
                                    case 'R':
                                        if ((String.Compare(field_name, 14, "eadData", 0, 7, false) == 0) && (field_name.Length == 21))
                                            return fieldGeneratorTerrierUploadReadData;
                                        break;
                                    case 'W':
                                        if ((String.Compare(field_name, 14, "riteData", 0, 8, false) == 0) && (field_name.Length == 22))
                                            return fieldGeneratorTerrierUploadWriteData;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'i':
                            if (String.Compare(field_name, 2, "me", 0, 2, false) == 0)
                              {
                                switch (field_name[4])
                                  {
                                    case 'S':
                                        if ((String.Compare(field_name, 5, "tamp", 0, 4, false) == 0) && (field_name.Length == 9))
                                            return fieldGeneratorTimeStamp;
                                        break;
                                    case 'Z':
                                        if ((String.Compare(field_name, 5, "one", 0, 3, false) == 0) && (field_name.Length == 8))
                                            return fieldGeneratorTimeZone;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'U':
                    switch (field_name[1])
                      {
                        case 'b':
                            if (String.Compare(field_name, 2, "er", 0, 2, false) == 0)
                              {
                                switch (field_name[4])
                                  {
                                    case 'C':
                                        if ((String.Compare(field_name, 5, "lientId", 0, 7, false) == 0) && (field_name.Length == 12))
                                            return fieldGeneratorUberClientId;
                                        break;
                                    case 'S':
                                        if ((String.Compare(field_name, 5, "erverToken", 0, 10, false) == 0) && (field_name.Length == 15))
                                            return fieldGeneratorUberServerToken;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'n':
                            if ((String.Compare(field_name, 2, "itPreference", 0, 12, false) == 0) && (field_name.Length == 14))
                                return fieldGeneratorUnitPreference;
                            break;
                        case 's':
                            if (String.Compare(field_name, 2, "e", 0, 1, false) == 0)
                              {
                                switch (field_name[3])
                                  {
                                    case 'C':
                                        switch (field_name[4])
                                          {
                                            case 'l':
                                                if ((String.Compare(field_name, 5, "ientTime", 0, 8, false) == 0) && (field_name.Length == 13))
                                                    return fieldGeneratorUseClientTime;
                                                break;
                                            case 'o':
                                                if ((String.Compare(field_name, 5, "ntactData", 0, 9, false) == 0) && (field_name.Length == 14))
                                                    return fieldGeneratorUseContactData;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case 'X':
                                        if ((String.Compare(field_name, 4, "APAPI", 0, 5, false) == 0) && (field_name.Length == 9))
                                            return fieldGeneratorUseXAPAPI;
                                        break;
                                    case 'r':
                                        switch (field_name[4])
                                          {
                                            case 'C':
                                                if ((String.Compare(field_name, 5, "ontactsRequests", 0, 15, false) == 0) && (field_name.Length == 20))
                                                    return fieldGeneratorUserContactsRequests;
                                                break;
                                            case 'F':
                                                if ((String.Compare(field_name, 5, "eedback", 0, 7, false) == 0) && (field_name.Length == 12))
                                                    return fieldGeneratorUserFeedback;
                                                break;
                                            case 'I':
                                                if ((String.Compare(field_name, 5, "D", 0, 1, false) == 0) && (field_name.Length == 6))
                                                    return fieldGeneratorUserID;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'V':
                    if (String.Compare(field_name, 1, "oice", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 6, "ctivityDetection", 0, 16, false) == 0) && (field_name.Length == 22))
                                    return fieldGeneratorVoiceActivityDetection;
                                break;
                            case 'P':
                                if ((String.Compare(field_name, 6, "arameters", 0, 9, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorVoiceParameters;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "akeUpPattern", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorWakeUpPattern;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorLatitude = new JSONHoldingNumberTextGenerator("field \"Latitude\" of the RequestInfo class");
            fieldGeneratorLongitude = new JSONHoldingNumberTextGenerator("field \"Longitude\" of the RequestInfo class");
            fieldGeneratorPositionTime = new FieldHoldingGeneratorPositionTime("field \"PositionTime\" of the RequestInfo class");
            fieldGeneratorPositionHorizontalAccuracy = new JSONHoldingNumberTextGenerator("field \"PositionHorizontalAccuracy\" of the RequestInfo class");
            fieldGeneratorStreet = new JSONHoldingStringGenerator("field \"Street\" of the RequestInfo class");
            fieldGeneratorCity = new JSONHoldingStringGenerator("field \"City\" of the RequestInfo class");
            fieldGeneratorState = new JSONHoldingStringGenerator("field \"State\" of the RequestInfo class");
            fieldGeneratorCountry = new JSONHoldingStringGenerator("field \"Country\" of the RequestInfo class");
            fieldGeneratorRoutePoints = new RoutePointsJSON.HoldingGenerator("field \"RoutePoints\" of the RequestInfo class", ignore_extras);
            fieldGeneratorControllableTrackPlaying = new JSONHoldingBooleanGenerator("field \"ControllableTrackPlaying\" of the RequestInfo class");
            fieldGeneratorTimeStamp = new FieldHoldingGeneratorTimeStamp("field \"TimeStamp\" of the RequestInfo class");
            fieldGeneratorTimeZone = new JSONHoldingStringGenerator("field \"TimeZone\" of the RequestInfo class");
            fieldGeneratorConversationState = new ConversationStateJSON.HoldingGenerator("field \"ConversationState\" of the RequestInfo class", ignore_extras);
            fieldGeneratorClientState = new ClientStateJSON.HoldingGenerator("field \"ClientState\" of the RequestInfo class", ignore_extras);
            fieldGeneratorSendBack = new JSONHoldingValueGenerator("field \"SendBack\" of the RequestInfo class");
            fieldGeneratorPreferredImageSize = new FieldHoldingArrayGeneratorPreferredImageSize("field \"PreferredImageSize\" of the RequestInfo class");
            fieldGeneratorInputLanguageEnglishName = new JSONHoldingStringGenerator("field \"InputLanguageEnglishName\" of the RequestInfo class");
            fieldGeneratorInputLanguageNativeName = new JSONHoldingStringGenerator("field \"InputLanguageNativeName\" of the RequestInfo class");
            fieldGeneratorInputLanguageIETFTag = new JSONHoldingStringGenerator("field \"InputLanguageIETFTag\" of the RequestInfo class");
            fieldGeneratorOutputLanguageEnglishName = new JSONHoldingStringGenerator("field \"OutputLanguageEnglishName\" of the RequestInfo class");
            fieldGeneratorOutputLanguageNativeName = new JSONHoldingStringGenerator("field \"OutputLanguageNativeName\" of the RequestInfo class");
            fieldGeneratorOutputLanguageIETFTag = new JSONHoldingStringGenerator("field \"OutputLanguageIETFTag\" of the RequestInfo class");
            fieldGeneratorResultVersionAccepted = new JSONHoldingNumberTextGenerator("field \"ResultVersionAccepted\" of the RequestInfo class");
            fieldGeneratorUnitPreference = new FieldHoldingGeneratorUnitPreference("field \"UnitPreference\" of the RequestInfo class");
            fieldGeneratorDefaultTimeFormat24Hours = new JSONHoldingBooleanGenerator("field \"DefaultTimeFormat24Hours\" of the RequestInfo class");
            fieldGeneratorClientID = new JSONHoldingStringGenerator("field \"ClientID\" of the RequestInfo class");
            fieldGeneratorClientVersion = new FieldHoldingGeneratorClientVersion("field \"ClientVersion\" of the RequestInfo class", ignore_extras);
            fieldGeneratorDeviceID = new JSONHoldingStringGenerator("field \"DeviceID\" of the RequestInfo class");
            fieldGeneratorSDK = new JSONHoldingStringGenerator("field \"SDK\" of the RequestInfo class");
            fieldGeneratorSDKInfo = new JSONHoldingObjectValueGenerator("field \"SDKInfo\" of the RequestInfo class");
            fieldGeneratorFirstPersonSelf = new JSONHoldingStringGenerator("field \"FirstPersonSelf\" of the RequestInfo class");
            fieldGeneratorFirstPersonSelfSpoken = new JSONHoldingStringGenerator("field \"FirstPersonSelfSpoken\" of the RequestInfo class");
            fieldGeneratorSecondPersonSelf = new JSONHoldingStringArrayGenerator("field \"SecondPersonSelf\" of the RequestInfo class");
            fieldGeneratorSecondPersonSelfSpoken = new JSONHoldingStringArrayGenerator("field \"SecondPersonSelfSpoken\" of the RequestInfo class");
            fieldGeneratorWakeUpPattern = new JSONHoldingStringGenerator("field \"WakeUpPattern\" of the RequestInfo class");
            fieldGeneratorUserID = new JSONHoldingStringGenerator("field \"UserID\" of the RequestInfo class");
            fieldGeneratorRequestID = new JSONHoldingStringGenerator("field \"RequestID\" of the RequestInfo class");
            fieldGeneratorSessionID = new JSONHoldingStringGenerator("field \"SessionID\" of the RequestInfo class");
            fieldGeneratorDomains = new DomainsJSON.HoldingGenerator("field \"Domains\" of the RequestInfo class", ignore_extras);
            fieldGeneratorResultUpdateAllowed = new JSONHoldingBooleanGenerator("field \"ResultUpdateAllowed\" of the RequestInfo class");
            fieldGeneratorPartialTranscriptsDesired = new JSONHoldingBooleanGenerator("field \"PartialTranscriptsDesired\" of the RequestInfo class");
            fieldGeneratorMinResults = new FieldHoldingGeneratorMinResults("field \"MinResults\" of the RequestInfo class");
            fieldGeneratorMaxResults = new FieldHoldingGeneratorMaxResults("field \"MaxResults\" of the RequestInfo class");
            fieldGeneratorObjectByteCountPrefix = new JSONHoldingBooleanGenerator("field \"ObjectByteCountPrefix\" of the RequestInfo class");
            fieldGeneratorProfanityFilter = new FieldHoldingGeneratorProfanityFilter("field \"ProfanityFilter\" of the RequestInfo class");
            fieldGeneratorClientMatches = new ClientMatchJSON.HoldingArrayGenerator("field \"ClientMatches\" of the RequestInfo class", ignore_extras);
            fieldGeneratorClientMatchesOnly = new JSONHoldingBooleanGenerator("field \"ClientMatchesOnly\" of the RequestInfo class");
            fieldGeneratorPagination = new PaginationJSON.HoldingGenerator("field \"Pagination\" of the RequestInfo class", ignore_extras);
            fieldGeneratorResponseAudioVoice = new JSONHoldingStringGenerator("field \"ResponseAudioVoice\" of the RequestInfo class");
            fieldGeneratorResponseAudioShortOrLong = new FieldHoldingGeneratorResponseAudioShortOrLong("field \"ResponseAudioShortOrLong\" of the RequestInfo class");
            fieldGeneratorResponseAudioAcceptedEncodings = new FieldHoldingArrayGeneratorResponseAudioAcceptedEncodings("field \"ResponseAudioAcceptedEncodings\" of the RequestInfo class");
            fieldGeneratorVoiceActivityDetection = new VoiceActivityDetectionJSON.HoldingGenerator("field \"VoiceActivityDetection\" of the RequestInfo class", ignore_extras);
            fieldGeneratorServerDeterminesEndOfAudio = new JSONHoldingBooleanGenerator("field \"ServerDeterminesEndOfAudio\" of the RequestInfo class");
            fieldGeneratorIntentOnly = new JSONHoldingBooleanGenerator("field \"IntentOnly\" of the RequestInfo class");
            fieldGeneratorDisableSpellCorrection = new JSONHoldingBooleanGenerator("field \"DisableSpellCorrection\" of the RequestInfo class");
            fieldGeneratorUseContactData = new JSONHoldingBooleanGenerator("field \"UseContactData\" of the RequestInfo class");
            fieldGeneratorUseClientTime = new JSONHoldingBooleanGenerator("field \"UseClientTime\" of the RequestInfo class");
            fieldGeneratorForceConversationStateTime = new FieldHoldingGeneratorForceConversationStateTime("field \"ForceConversationStateTime\" of the RequestInfo class");
            fieldGeneratorPhoneDisambiguationOmitList = new PhoneDisambiguationOmitListJSON.HoldingGenerator("field \"PhoneDisambiguationOmitList\" of the RequestInfo class", ignore_extras);
            fieldGeneratorIncomingCallPending = new IncomingCallPendingJSON.HoldingGenerator("field \"IncomingCallPending\" of the RequestInfo class", ignore_extras);
            fieldGeneratorAllowPopularNameContactMatches = new AllowPopularNameContactMatchesJSON.HoldingGenerator("field \"AllowPopularNameContactMatches\" of the RequestInfo class", ignore_extras);
            fieldGeneratorMusicClientState = new MusicClientStateJSON.HoldingGenerator("field \"MusicClientState\" of the RequestInfo class", ignore_extras);
            fieldGeneratorDisableMusicSearchListPositionSpecification = new DisableListPositionSpecificationJSON.HoldingGenerator("field \"DisableMusicSearchListPositionSpecification\" of the RequestInfo class", ignore_extras);
            fieldGeneratorCollateMusicEntities = new CollateMusicEntitiesJSON.HoldingGenerator("field \"CollateMusicEntities\" of the RequestInfo class", ignore_extras);
            fieldGeneratorAllowContextFreeMusicSearchForPopularEntities = new AllowContextFreeMusicSearchForPopularEntitiesJSON.HoldingGenerator("field \"AllowContextFreeMusicSearchForPopularEntities\" of the RequestInfo class", ignore_extras);
            fieldGeneratorReturnInformationNuggetsForMusicSearch = new ReturnInformationNuggetsForMusicSearchJSON.HoldingGenerator("field \"ReturnInformationNuggetsForMusicSearch\" of the RequestInfo class", ignore_extras);
            fieldGeneratorUseXAPAPI = new RequestInfoBooleanFlagJSON.HoldingGenerator("field \"UseXAPAPI\" of the RequestInfo class", ignore_extras);
            fieldGeneratorLocalSearchClientState = new LocalSearchClientStateJSON.HoldingGenerator("field \"LocalSearchClientState\" of the RequestInfo class", ignore_extras);
            fieldGeneratorUberServerToken = new UberServerTokenJSON.HoldingGenerator("field \"UberServerToken\" of the RequestInfo class", ignore_extras);
            fieldGeneratorGetUberServerToken = new GetUberServerTokenJSON.HoldingGenerator("field \"GetUberServerToken\" of the RequestInfo class", ignore_extras);
            fieldGeneratorUberClientId = new UberClientIdJSON.HoldingGenerator("field \"UberClientId\" of the RequestInfo class", ignore_extras);
            fieldGeneratorGetUberClientId = new GetUberClientIdJSON.HoldingGenerator("field \"GetUberClientId\" of the RequestInfo class", ignore_extras);
            fieldGeneratorSetUserMemoryLocation = new SetUserMemoryLocationJSON.HoldingGenerator("field \"SetUserMemoryLocation\" of the RequestInfo class", ignore_extras);
            fieldGeneratorDisableMusicPlayerListPositionSpecification = new DisableListPositionSpecificationJSON.HoldingGenerator("field \"DisableMusicPlayerListPositionSpecification\" of the RequestInfo class", ignore_extras);
            fieldGeneratorCarControlClimateClientConfiguration = new CarControlClimateClientConfigurationJSON.HoldingGenerator("field \"CarControlClimateClientConfiguration\" of the RequestInfo class", ignore_extras);
            fieldGeneratorHomeAutomationDomainSettings = new HomeAutomationDomainSettingsJSON.HoldingGenerator("field \"HomeAutomationDomainSettings\" of the RequestInfo class", ignore_extras);
            fieldGeneratorUserContactsRequests = new UserContactsRequestsJSON.HoldingGenerator("field \"UserContactsRequests\" of the RequestInfo class", ignore_extras);
            fieldGeneratorStoredGlobalPagesToMatch = new StoredPageMatchPageListJSON.HoldingGenerator("field \"StoredGlobalPagesToMatch\" of the RequestInfo class", ignore_extras);
            fieldGeneratorStoredGlobalPagesToNotMatch = new StoredPageMatchPageListJSON.HoldingGenerator("field \"StoredGlobalPagesToNotMatch\" of the RequestInfo class", ignore_extras);
            fieldGeneratorStoredPerUserPagesToMatch = new StoredPageMatchPageListJSON.HoldingGenerator("field \"StoredPerUserPagesToMatch\" of the RequestInfo class", ignore_extras);
            fieldGeneratorStoredPerUserPagesToNotMatch = new StoredPageMatchPageListJSON.HoldingGenerator("field \"StoredPerUserPagesToNotMatch\" of the RequestInfo class", ignore_extras);
            fieldGeneratorStoredGlobalPagesToSetOnByDefault = new StoredPageMatchPageListJSON.HoldingGenerator("field \"StoredGlobalPagesToSetOnByDefault\" of the RequestInfo class", ignore_extras);
            fieldGeneratorStoredPerUserPagesToSetOnByDefault = new StoredPageMatchPageListJSON.HoldingGenerator("field \"StoredPerUserPagesToSetOnByDefault\" of the RequestInfo class", ignore_extras);
            fieldGeneratorStoredGlobalPagesToSetOffByDefault = new StoredPageMatchPageListJSON.HoldingGenerator("field \"StoredGlobalPagesToSetOffByDefault\" of the RequestInfo class", ignore_extras);
            fieldGeneratorStoredPerUserPagesToSetOffByDefault = new StoredPageMatchPageListJSON.HoldingGenerator("field \"StoredPerUserPagesToSetOffByDefault\" of the RequestInfo class", ignore_extras);
            fieldGeneratorStoredPageMatchWriteData = new StoredPageMatchWriteDataJSON.HoldingGenerator("field \"StoredPageMatchWriteData\" of the RequestInfo class", ignore_extras);
            fieldGeneratorStoredPageMatchReadData = new StoredPageMatchReadDataJSON.HoldingGenerator("field \"StoredPageMatchReadData\" of the RequestInfo class", ignore_extras);
            fieldGeneratorStoredPageMatchPageListData = new StoredPageMatchPageListDataJSON.HoldingGenerator("field \"StoredPageMatchPageListData\" of the RequestInfo class", ignore_extras);
            fieldGeneratorVoiceParameters = new VoiceParametersJSON.HoldingGenerator("field \"VoiceParameters\" of the RequestInfo class", ignore_extras);
            fieldGeneratorStoredAlwaysMatchWriteData = new ClientMatchesJSON.HoldingGenerator("field \"StoredAlwaysMatchWriteData\" of the RequestInfo class", ignore_extras);
            fieldGeneratorStoredAlwaysMatchReadData = new StoredAlwaysMatchReadDataJSON.HoldingGenerator("field \"StoredAlwaysMatchReadData\" of the RequestInfo class", ignore_extras);
            fieldGeneratorUserFeedback = new UserFeedbackJSON.HoldingGenerator("field \"UserFeedback\" of the RequestInfo class", ignore_extras);
            fieldGeneratorRadioControlRecognizeNorthAmericanFMBand = new RadioControlRecognizeNorthAmericanFMBandJSON.HoldingGenerator("field \"RadioControlRecognizeNorthAmericanFMBand\" of the RequestInfo class", ignore_extras);
            fieldGeneratorRadioControlRecognizeNorthAmericanAMBand = new RadioControlRecognizeNorthAmericanAMBandJSON.HoldingGenerator("field \"RadioControlRecognizeNorthAmericanAMBand\" of the RequestInfo class", ignore_extras);
            fieldGeneratorRadioControlOtherFMBands = new RadioControlOtherFMBandsJSON.HoldingGenerator("field \"RadioControlOtherFMBands\" of the RequestInfo class", ignore_extras);
            fieldGeneratorRadioControlOtherAMBands = new RadioControlOtherAMBandsJSON.HoldingGenerator("field \"RadioControlOtherAMBands\" of the RequestInfo class", ignore_extras);
            fieldGeneratorRadioControlAvailableAudioSources = new RadioControlAvailableAudioSourcesJSON.HoldingGenerator("field \"RadioControlAvailableAudioSources\" of the RequestInfo class", ignore_extras);
            fieldGeneratorClientListMatches = new ClientListMatchesJSON.HoldingGenerator("field \"ClientListMatches\" of the RequestInfo class", ignore_extras);
            fieldGeneratorIntentToExecute = new CommandIntentJSON.HoldingGenerator("field \"IntentToExecute\" of the RequestInfo class", ignore_extras);
            fieldGeneratorRobotInfo = new RobotInfoJSON.HoldingGenerator("field \"RobotInfo\" of the RequestInfo class", ignore_extras);
            fieldGeneratorConvertToNewInformationNuggets = new ConvertToNewInformationNuggetsJSON.HoldingGenerator("field \"ConvertToNewInformationNuggets\" of the RequestInfo class", ignore_extras);
            fieldGeneratorAcapelaVoiceParameters = new AcapelaVoiceParametersJSON.HoldingGenerator("field \"AcapelaVoiceParameters\" of the RequestInfo class", ignore_extras);
            fieldGeneratorOutputOverrideCommandIsPreAudioOut = new RequestInfoBooleanFlagJSON.HoldingGenerator("field \"OutputOverrideCommandIsPreAudioOut\" of the RequestInfo class", ignore_extras);
            fieldGeneratorOutputOverrideCommandFunction = new OutputOverrideFunctionJSON.HoldingGenerator("field \"OutputOverrideCommandFunction\" of the RequestInfo class", ignore_extras);
            fieldGeneratorOutputOverrideCommandFunctionLanguage = new UploadedCodeFunctionLanguageJSON.HoldingGenerator("field \"OutputOverrideCommandFunctionLanguage\" of the RequestInfo class", ignore_extras);
            fieldGeneratorOutputOverrideCommandFunctionSource = new UploadedCodeSourceJSON.HoldingGenerator("field \"OutputOverrideCommandFunctionSource\" of the RequestInfo class", ignore_extras);
            fieldGeneratorOutputOverrideDeleteCommandFunction = new RequestInfoBooleanFlagJSON.HoldingGenerator("field \"OutputOverrideDeleteCommandFunction\" of the RequestInfo class", ignore_extras);
            fieldGeneratorOutputOverrideReadCommandFunction = new RequestInfoBooleanFlagJSON.HoldingGenerator("field \"OutputOverrideReadCommandFunction\" of the RequestInfo class", ignore_extras);
            fieldGeneratorOutputOverrideInformationNuggetFunction = new OutputOverrideFunctionJSON.HoldingGenerator("field \"OutputOverrideInformationNuggetFunction\" of the RequestInfo class", ignore_extras);
            fieldGeneratorOutputOverrideInformationNuggetFunctionLanguage = new UploadedCodeFunctionLanguageJSON.HoldingGenerator("field \"OutputOverrideInformationNuggetFunctionLanguage\" of the RequestInfo class", ignore_extras);
            fieldGeneratorOutputOverrideInformationNuggetFunctionSource = new UploadedCodeSourceJSON.HoldingGenerator("field \"OutputOverrideInformationNuggetFunctionSource\" of the RequestInfo class", ignore_extras);
            fieldGeneratorOutputOverrideDeleteInformationNuggetFunction = new RequestInfoBooleanFlagJSON.HoldingGenerator("field \"OutputOverrideDeleteInformationNuggetFunction\" of the RequestInfo class", ignore_extras);
            fieldGeneratorOutputOverrideReadInformationNuggetFunction = new RequestInfoBooleanFlagJSON.HoldingGenerator("field \"OutputOverrideReadInformationNuggetFunction\" of the RequestInfo class", ignore_extras);
            fieldGeneratorTerrierUploadWriteData = new TerrierUploadWriteDataJSON.HoldingGenerator("field \"TerrierUploadWriteData\" of the RequestInfo class", ignore_extras);
            fieldGeneratorTerrierUploadReadData = new TerrierUploadReadDataJSON.HoldingGenerator("field \"TerrierUploadReadData\" of the RequestInfo class", ignore_extras);
            fieldGeneratorDisambiguateResultsBeforeAction = new DisambiguateResultsBeforeActionJSON.HoldingGenerator("field \"DisambiguateResultsBeforeAction\" of the RequestInfo class", ignore_extras);
            fieldGeneratorInputOverrideFunction = new InputOverrideFunctionJSON.HoldingGenerator("field \"InputOverrideFunction\" of the RequestInfo class", ignore_extras);
            fieldGeneratorInputOverrideFunctionLanguage = new UploadedCodeFunctionLanguageJSON.HoldingGenerator("field \"InputOverrideFunctionLanguage\" of the RequestInfo class", ignore_extras);
            fieldGeneratorInputOverrideFunctionSource = new UploadedCodeSourceJSON.HoldingGenerator("field \"InputOverrideFunctionSource\" of the RequestInfo class", ignore_extras);
            fieldGeneratorInputOverrideDeleteFunction = new RequestInfoBooleanFlagJSON.HoldingGenerator("field \"InputOverrideDeleteFunction\" of the RequestInfo class", ignore_extras);
            fieldGeneratorInputOverrideReadFunction = new RequestInfoBooleanFlagJSON.HoldingGenerator("field \"InputOverrideReadFunction\" of the RequestInfo class", ignore_extras);
            fieldGeneratorSportsLeagueControl = new SportsLeagueControlJSON.HoldingGenerator("field \"SportsLeagueControl\" of the RequestInfo class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RequestInfo class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorLatitude = new JSONHoldingNumberTextGenerator("field \"Latitude\" of the RequestInfo class");
            fieldGeneratorLongitude = new JSONHoldingNumberTextGenerator("field \"Longitude\" of the RequestInfo class");
            fieldGeneratorPositionTime = new FieldHoldingGeneratorPositionTime("field \"PositionTime\" of the RequestInfo class");
            fieldGeneratorPositionHorizontalAccuracy = new JSONHoldingNumberTextGenerator("field \"PositionHorizontalAccuracy\" of the RequestInfo class");
            fieldGeneratorStreet = new JSONHoldingStringGenerator("field \"Street\" of the RequestInfo class");
            fieldGeneratorCity = new JSONHoldingStringGenerator("field \"City\" of the RequestInfo class");
            fieldGeneratorState = new JSONHoldingStringGenerator("field \"State\" of the RequestInfo class");
            fieldGeneratorCountry = new JSONHoldingStringGenerator("field \"Country\" of the RequestInfo class");
            fieldGeneratorRoutePoints = new RoutePointsJSON.HoldingGenerator("field \"RoutePoints\" of the RequestInfo class", false);
            fieldGeneratorControllableTrackPlaying = new JSONHoldingBooleanGenerator("field \"ControllableTrackPlaying\" of the RequestInfo class");
            fieldGeneratorTimeStamp = new FieldHoldingGeneratorTimeStamp("field \"TimeStamp\" of the RequestInfo class");
            fieldGeneratorTimeZone = new JSONHoldingStringGenerator("field \"TimeZone\" of the RequestInfo class");
            fieldGeneratorConversationState = new ConversationStateJSON.HoldingGenerator("field \"ConversationState\" of the RequestInfo class", false);
            fieldGeneratorClientState = new ClientStateJSON.HoldingGenerator("field \"ClientState\" of the RequestInfo class", false);
            fieldGeneratorSendBack = new JSONHoldingValueGenerator("field \"SendBack\" of the RequestInfo class");
            fieldGeneratorPreferredImageSize = new FieldHoldingArrayGeneratorPreferredImageSize("field \"PreferredImageSize\" of the RequestInfo class");
            fieldGeneratorInputLanguageEnglishName = new JSONHoldingStringGenerator("field \"InputLanguageEnglishName\" of the RequestInfo class");
            fieldGeneratorInputLanguageNativeName = new JSONHoldingStringGenerator("field \"InputLanguageNativeName\" of the RequestInfo class");
            fieldGeneratorInputLanguageIETFTag = new JSONHoldingStringGenerator("field \"InputLanguageIETFTag\" of the RequestInfo class");
            fieldGeneratorOutputLanguageEnglishName = new JSONHoldingStringGenerator("field \"OutputLanguageEnglishName\" of the RequestInfo class");
            fieldGeneratorOutputLanguageNativeName = new JSONHoldingStringGenerator("field \"OutputLanguageNativeName\" of the RequestInfo class");
            fieldGeneratorOutputLanguageIETFTag = new JSONHoldingStringGenerator("field \"OutputLanguageIETFTag\" of the RequestInfo class");
            fieldGeneratorResultVersionAccepted = new JSONHoldingNumberTextGenerator("field \"ResultVersionAccepted\" of the RequestInfo class");
            fieldGeneratorUnitPreference = new FieldHoldingGeneratorUnitPreference("field \"UnitPreference\" of the RequestInfo class");
            fieldGeneratorDefaultTimeFormat24Hours = new JSONHoldingBooleanGenerator("field \"DefaultTimeFormat24Hours\" of the RequestInfo class");
            fieldGeneratorClientID = new JSONHoldingStringGenerator("field \"ClientID\" of the RequestInfo class");
            fieldGeneratorClientVersion = new FieldHoldingGeneratorClientVersion("field \"ClientVersion\" of the RequestInfo class", false);
            fieldGeneratorDeviceID = new JSONHoldingStringGenerator("field \"DeviceID\" of the RequestInfo class");
            fieldGeneratorSDK = new JSONHoldingStringGenerator("field \"SDK\" of the RequestInfo class");
            fieldGeneratorSDKInfo = new JSONHoldingObjectValueGenerator("field \"SDKInfo\" of the RequestInfo class");
            fieldGeneratorFirstPersonSelf = new JSONHoldingStringGenerator("field \"FirstPersonSelf\" of the RequestInfo class");
            fieldGeneratorFirstPersonSelfSpoken = new JSONHoldingStringGenerator("field \"FirstPersonSelfSpoken\" of the RequestInfo class");
            fieldGeneratorSecondPersonSelf = new JSONHoldingStringArrayGenerator("field \"SecondPersonSelf\" of the RequestInfo class");
            fieldGeneratorSecondPersonSelfSpoken = new JSONHoldingStringArrayGenerator("field \"SecondPersonSelfSpoken\" of the RequestInfo class");
            fieldGeneratorWakeUpPattern = new JSONHoldingStringGenerator("field \"WakeUpPattern\" of the RequestInfo class");
            fieldGeneratorUserID = new JSONHoldingStringGenerator("field \"UserID\" of the RequestInfo class");
            fieldGeneratorRequestID = new JSONHoldingStringGenerator("field \"RequestID\" of the RequestInfo class");
            fieldGeneratorSessionID = new JSONHoldingStringGenerator("field \"SessionID\" of the RequestInfo class");
            fieldGeneratorDomains = new DomainsJSON.HoldingGenerator("field \"Domains\" of the RequestInfo class", false);
            fieldGeneratorResultUpdateAllowed = new JSONHoldingBooleanGenerator("field \"ResultUpdateAllowed\" of the RequestInfo class");
            fieldGeneratorPartialTranscriptsDesired = new JSONHoldingBooleanGenerator("field \"PartialTranscriptsDesired\" of the RequestInfo class");
            fieldGeneratorMinResults = new FieldHoldingGeneratorMinResults("field \"MinResults\" of the RequestInfo class");
            fieldGeneratorMaxResults = new FieldHoldingGeneratorMaxResults("field \"MaxResults\" of the RequestInfo class");
            fieldGeneratorObjectByteCountPrefix = new JSONHoldingBooleanGenerator("field \"ObjectByteCountPrefix\" of the RequestInfo class");
            fieldGeneratorProfanityFilter = new FieldHoldingGeneratorProfanityFilter("field \"ProfanityFilter\" of the RequestInfo class");
            fieldGeneratorClientMatches = new ClientMatchJSON.HoldingArrayGenerator("field \"ClientMatches\" of the RequestInfo class", false);
            fieldGeneratorClientMatchesOnly = new JSONHoldingBooleanGenerator("field \"ClientMatchesOnly\" of the RequestInfo class");
            fieldGeneratorPagination = new PaginationJSON.HoldingGenerator("field \"Pagination\" of the RequestInfo class", false);
            fieldGeneratorResponseAudioVoice = new JSONHoldingStringGenerator("field \"ResponseAudioVoice\" of the RequestInfo class");
            fieldGeneratorResponseAudioShortOrLong = new FieldHoldingGeneratorResponseAudioShortOrLong("field \"ResponseAudioShortOrLong\" of the RequestInfo class");
            fieldGeneratorResponseAudioAcceptedEncodings = new FieldHoldingArrayGeneratorResponseAudioAcceptedEncodings("field \"ResponseAudioAcceptedEncodings\" of the RequestInfo class");
            fieldGeneratorVoiceActivityDetection = new VoiceActivityDetectionJSON.HoldingGenerator("field \"VoiceActivityDetection\" of the RequestInfo class", false);
            fieldGeneratorServerDeterminesEndOfAudio = new JSONHoldingBooleanGenerator("field \"ServerDeterminesEndOfAudio\" of the RequestInfo class");
            fieldGeneratorIntentOnly = new JSONHoldingBooleanGenerator("field \"IntentOnly\" of the RequestInfo class");
            fieldGeneratorDisableSpellCorrection = new JSONHoldingBooleanGenerator("field \"DisableSpellCorrection\" of the RequestInfo class");
            fieldGeneratorUseContactData = new JSONHoldingBooleanGenerator("field \"UseContactData\" of the RequestInfo class");
            fieldGeneratorUseClientTime = new JSONHoldingBooleanGenerator("field \"UseClientTime\" of the RequestInfo class");
            fieldGeneratorForceConversationStateTime = new FieldHoldingGeneratorForceConversationStateTime("field \"ForceConversationStateTime\" of the RequestInfo class");
            fieldGeneratorPhoneDisambiguationOmitList = new PhoneDisambiguationOmitListJSON.HoldingGenerator("field \"PhoneDisambiguationOmitList\" of the RequestInfo class", false);
            fieldGeneratorIncomingCallPending = new IncomingCallPendingJSON.HoldingGenerator("field \"IncomingCallPending\" of the RequestInfo class", false);
            fieldGeneratorAllowPopularNameContactMatches = new AllowPopularNameContactMatchesJSON.HoldingGenerator("field \"AllowPopularNameContactMatches\" of the RequestInfo class", false);
            fieldGeneratorMusicClientState = new MusicClientStateJSON.HoldingGenerator("field \"MusicClientState\" of the RequestInfo class", false);
            fieldGeneratorDisableMusicSearchListPositionSpecification = new DisableListPositionSpecificationJSON.HoldingGenerator("field \"DisableMusicSearchListPositionSpecification\" of the RequestInfo class", false);
            fieldGeneratorCollateMusicEntities = new CollateMusicEntitiesJSON.HoldingGenerator("field \"CollateMusicEntities\" of the RequestInfo class", false);
            fieldGeneratorAllowContextFreeMusicSearchForPopularEntities = new AllowContextFreeMusicSearchForPopularEntitiesJSON.HoldingGenerator("field \"AllowContextFreeMusicSearchForPopularEntities\" of the RequestInfo class", false);
            fieldGeneratorReturnInformationNuggetsForMusicSearch = new ReturnInformationNuggetsForMusicSearchJSON.HoldingGenerator("field \"ReturnInformationNuggetsForMusicSearch\" of the RequestInfo class", false);
            fieldGeneratorUseXAPAPI = new RequestInfoBooleanFlagJSON.HoldingGenerator("field \"UseXAPAPI\" of the RequestInfo class", false);
            fieldGeneratorLocalSearchClientState = new LocalSearchClientStateJSON.HoldingGenerator("field \"LocalSearchClientState\" of the RequestInfo class", false);
            fieldGeneratorUberServerToken = new UberServerTokenJSON.HoldingGenerator("field \"UberServerToken\" of the RequestInfo class", false);
            fieldGeneratorGetUberServerToken = new GetUberServerTokenJSON.HoldingGenerator("field \"GetUberServerToken\" of the RequestInfo class", false);
            fieldGeneratorUberClientId = new UberClientIdJSON.HoldingGenerator("field \"UberClientId\" of the RequestInfo class", false);
            fieldGeneratorGetUberClientId = new GetUberClientIdJSON.HoldingGenerator("field \"GetUberClientId\" of the RequestInfo class", false);
            fieldGeneratorSetUserMemoryLocation = new SetUserMemoryLocationJSON.HoldingGenerator("field \"SetUserMemoryLocation\" of the RequestInfo class", false);
            fieldGeneratorDisableMusicPlayerListPositionSpecification = new DisableListPositionSpecificationJSON.HoldingGenerator("field \"DisableMusicPlayerListPositionSpecification\" of the RequestInfo class", false);
            fieldGeneratorCarControlClimateClientConfiguration = new CarControlClimateClientConfigurationJSON.HoldingGenerator("field \"CarControlClimateClientConfiguration\" of the RequestInfo class", false);
            fieldGeneratorHomeAutomationDomainSettings = new HomeAutomationDomainSettingsJSON.HoldingGenerator("field \"HomeAutomationDomainSettings\" of the RequestInfo class", false);
            fieldGeneratorUserContactsRequests = new UserContactsRequestsJSON.HoldingGenerator("field \"UserContactsRequests\" of the RequestInfo class", false);
            fieldGeneratorStoredGlobalPagesToMatch = new StoredPageMatchPageListJSON.HoldingGenerator("field \"StoredGlobalPagesToMatch\" of the RequestInfo class", false);
            fieldGeneratorStoredGlobalPagesToNotMatch = new StoredPageMatchPageListJSON.HoldingGenerator("field \"StoredGlobalPagesToNotMatch\" of the RequestInfo class", false);
            fieldGeneratorStoredPerUserPagesToMatch = new StoredPageMatchPageListJSON.HoldingGenerator("field \"StoredPerUserPagesToMatch\" of the RequestInfo class", false);
            fieldGeneratorStoredPerUserPagesToNotMatch = new StoredPageMatchPageListJSON.HoldingGenerator("field \"StoredPerUserPagesToNotMatch\" of the RequestInfo class", false);
            fieldGeneratorStoredGlobalPagesToSetOnByDefault = new StoredPageMatchPageListJSON.HoldingGenerator("field \"StoredGlobalPagesToSetOnByDefault\" of the RequestInfo class", false);
            fieldGeneratorStoredPerUserPagesToSetOnByDefault = new StoredPageMatchPageListJSON.HoldingGenerator("field \"StoredPerUserPagesToSetOnByDefault\" of the RequestInfo class", false);
            fieldGeneratorStoredGlobalPagesToSetOffByDefault = new StoredPageMatchPageListJSON.HoldingGenerator("field \"StoredGlobalPagesToSetOffByDefault\" of the RequestInfo class", false);
            fieldGeneratorStoredPerUserPagesToSetOffByDefault = new StoredPageMatchPageListJSON.HoldingGenerator("field \"StoredPerUserPagesToSetOffByDefault\" of the RequestInfo class", false);
            fieldGeneratorStoredPageMatchWriteData = new StoredPageMatchWriteDataJSON.HoldingGenerator("field \"StoredPageMatchWriteData\" of the RequestInfo class", false);
            fieldGeneratorStoredPageMatchReadData = new StoredPageMatchReadDataJSON.HoldingGenerator("field \"StoredPageMatchReadData\" of the RequestInfo class", false);
            fieldGeneratorStoredPageMatchPageListData = new StoredPageMatchPageListDataJSON.HoldingGenerator("field \"StoredPageMatchPageListData\" of the RequestInfo class", false);
            fieldGeneratorVoiceParameters = new VoiceParametersJSON.HoldingGenerator("field \"VoiceParameters\" of the RequestInfo class", false);
            fieldGeneratorStoredAlwaysMatchWriteData = new ClientMatchesJSON.HoldingGenerator("field \"StoredAlwaysMatchWriteData\" of the RequestInfo class", false);
            fieldGeneratorStoredAlwaysMatchReadData = new StoredAlwaysMatchReadDataJSON.HoldingGenerator("field \"StoredAlwaysMatchReadData\" of the RequestInfo class", false);
            fieldGeneratorUserFeedback = new UserFeedbackJSON.HoldingGenerator("field \"UserFeedback\" of the RequestInfo class", false);
            fieldGeneratorRadioControlRecognizeNorthAmericanFMBand = new RadioControlRecognizeNorthAmericanFMBandJSON.HoldingGenerator("field \"RadioControlRecognizeNorthAmericanFMBand\" of the RequestInfo class", false);
            fieldGeneratorRadioControlRecognizeNorthAmericanAMBand = new RadioControlRecognizeNorthAmericanAMBandJSON.HoldingGenerator("field \"RadioControlRecognizeNorthAmericanAMBand\" of the RequestInfo class", false);
            fieldGeneratorRadioControlOtherFMBands = new RadioControlOtherFMBandsJSON.HoldingGenerator("field \"RadioControlOtherFMBands\" of the RequestInfo class", false);
            fieldGeneratorRadioControlOtherAMBands = new RadioControlOtherAMBandsJSON.HoldingGenerator("field \"RadioControlOtherAMBands\" of the RequestInfo class", false);
            fieldGeneratorRadioControlAvailableAudioSources = new RadioControlAvailableAudioSourcesJSON.HoldingGenerator("field \"RadioControlAvailableAudioSources\" of the RequestInfo class", false);
            fieldGeneratorClientListMatches = new ClientListMatchesJSON.HoldingGenerator("field \"ClientListMatches\" of the RequestInfo class", false);
            fieldGeneratorIntentToExecute = new CommandIntentJSON.HoldingGenerator("field \"IntentToExecute\" of the RequestInfo class", false);
            fieldGeneratorRobotInfo = new RobotInfoJSON.HoldingGenerator("field \"RobotInfo\" of the RequestInfo class", false);
            fieldGeneratorConvertToNewInformationNuggets = new ConvertToNewInformationNuggetsJSON.HoldingGenerator("field \"ConvertToNewInformationNuggets\" of the RequestInfo class", false);
            fieldGeneratorAcapelaVoiceParameters = new AcapelaVoiceParametersJSON.HoldingGenerator("field \"AcapelaVoiceParameters\" of the RequestInfo class", false);
            fieldGeneratorOutputOverrideCommandIsPreAudioOut = new RequestInfoBooleanFlagJSON.HoldingGenerator("field \"OutputOverrideCommandIsPreAudioOut\" of the RequestInfo class", false);
            fieldGeneratorOutputOverrideCommandFunction = new OutputOverrideFunctionJSON.HoldingGenerator("field \"OutputOverrideCommandFunction\" of the RequestInfo class", false);
            fieldGeneratorOutputOverrideCommandFunctionLanguage = new UploadedCodeFunctionLanguageJSON.HoldingGenerator("field \"OutputOverrideCommandFunctionLanguage\" of the RequestInfo class", false);
            fieldGeneratorOutputOverrideCommandFunctionSource = new UploadedCodeSourceJSON.HoldingGenerator("field \"OutputOverrideCommandFunctionSource\" of the RequestInfo class", false);
            fieldGeneratorOutputOverrideDeleteCommandFunction = new RequestInfoBooleanFlagJSON.HoldingGenerator("field \"OutputOverrideDeleteCommandFunction\" of the RequestInfo class", false);
            fieldGeneratorOutputOverrideReadCommandFunction = new RequestInfoBooleanFlagJSON.HoldingGenerator("field \"OutputOverrideReadCommandFunction\" of the RequestInfo class", false);
            fieldGeneratorOutputOverrideInformationNuggetFunction = new OutputOverrideFunctionJSON.HoldingGenerator("field \"OutputOverrideInformationNuggetFunction\" of the RequestInfo class", false);
            fieldGeneratorOutputOverrideInformationNuggetFunctionLanguage = new UploadedCodeFunctionLanguageJSON.HoldingGenerator("field \"OutputOverrideInformationNuggetFunctionLanguage\" of the RequestInfo class", false);
            fieldGeneratorOutputOverrideInformationNuggetFunctionSource = new UploadedCodeSourceJSON.HoldingGenerator("field \"OutputOverrideInformationNuggetFunctionSource\" of the RequestInfo class", false);
            fieldGeneratorOutputOverrideDeleteInformationNuggetFunction = new RequestInfoBooleanFlagJSON.HoldingGenerator("field \"OutputOverrideDeleteInformationNuggetFunction\" of the RequestInfo class", false);
            fieldGeneratorOutputOverrideReadInformationNuggetFunction = new RequestInfoBooleanFlagJSON.HoldingGenerator("field \"OutputOverrideReadInformationNuggetFunction\" of the RequestInfo class", false);
            fieldGeneratorTerrierUploadWriteData = new TerrierUploadWriteDataJSON.HoldingGenerator("field \"TerrierUploadWriteData\" of the RequestInfo class", false);
            fieldGeneratorTerrierUploadReadData = new TerrierUploadReadDataJSON.HoldingGenerator("field \"TerrierUploadReadData\" of the RequestInfo class", false);
            fieldGeneratorDisambiguateResultsBeforeAction = new DisambiguateResultsBeforeActionJSON.HoldingGenerator("field \"DisambiguateResultsBeforeAction\" of the RequestInfo class", false);
            fieldGeneratorInputOverrideFunction = new InputOverrideFunctionJSON.HoldingGenerator("field \"InputOverrideFunction\" of the RequestInfo class", false);
            fieldGeneratorInputOverrideFunctionLanguage = new UploadedCodeFunctionLanguageJSON.HoldingGenerator("field \"InputOverrideFunctionLanguage\" of the RequestInfo class", false);
            fieldGeneratorInputOverrideFunctionSource = new UploadedCodeSourceJSON.HoldingGenerator("field \"InputOverrideFunctionSource\" of the RequestInfo class", false);
            fieldGeneratorInputOverrideDeleteFunction = new RequestInfoBooleanFlagJSON.HoldingGenerator("field \"InputOverrideDeleteFunction\" of the RequestInfo class", false);
            fieldGeneratorInputOverrideReadFunction = new RequestInfoBooleanFlagJSON.HoldingGenerator("field \"InputOverrideReadFunction\" of the RequestInfo class", false);
            fieldGeneratorSportsLeagueControl = new SportsLeagueControlJSON.HoldingGenerator("field \"SportsLeagueControl\" of the RequestInfo class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RequestInfo class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorLatitude.reset();
            fieldGeneratorLongitude.reset();
            fieldGeneratorPositionTime.reset();
            fieldGeneratorPositionHorizontalAccuracy.reset();
            fieldGeneratorStreet.reset();
            fieldGeneratorCity.reset();
            fieldGeneratorState.reset();
            fieldGeneratorCountry.reset();
            fieldGeneratorRoutePoints.reset();
            fieldGeneratorControllableTrackPlaying.reset();
            fieldGeneratorTimeStamp.reset();
            fieldGeneratorTimeZone.reset();
            fieldGeneratorConversationState.reset();
            fieldGeneratorClientState.reset();
            fieldGeneratorSendBack.reset();
            fieldGeneratorPreferredImageSize.reset();
            fieldGeneratorInputLanguageEnglishName.reset();
            fieldGeneratorInputLanguageNativeName.reset();
            fieldGeneratorInputLanguageIETFTag.reset();
            fieldGeneratorOutputLanguageEnglishName.reset();
            fieldGeneratorOutputLanguageNativeName.reset();
            fieldGeneratorOutputLanguageIETFTag.reset();
            fieldGeneratorResultVersionAccepted.reset();
            fieldGeneratorUnitPreference.reset();
            fieldGeneratorDefaultTimeFormat24Hours.reset();
            fieldGeneratorClientID.reset();
            fieldGeneratorClientVersion.reset();
            fieldGeneratorDeviceID.reset();
            fieldGeneratorSDK.reset();
            fieldGeneratorSDKInfo.reset();
            fieldGeneratorFirstPersonSelf.reset();
            fieldGeneratorFirstPersonSelfSpoken.reset();
            fieldGeneratorSecondPersonSelf.reset();
            fieldGeneratorSecondPersonSelfSpoken.reset();
            fieldGeneratorWakeUpPattern.reset();
            fieldGeneratorUserID.reset();
            fieldGeneratorRequestID.reset();
            fieldGeneratorSessionID.reset();
            fieldGeneratorDomains.reset();
            fieldGeneratorResultUpdateAllowed.reset();
            fieldGeneratorPartialTranscriptsDesired.reset();
            fieldGeneratorMinResults.reset();
            fieldGeneratorMaxResults.reset();
            fieldGeneratorObjectByteCountPrefix.reset();
            fieldGeneratorProfanityFilter.reset();
            fieldGeneratorClientMatches.reset();
            fieldGeneratorClientMatchesOnly.reset();
            fieldGeneratorPagination.reset();
            fieldGeneratorResponseAudioVoice.reset();
            fieldGeneratorResponseAudioShortOrLong.reset();
            fieldGeneratorResponseAudioAcceptedEncodings.reset();
            fieldGeneratorVoiceActivityDetection.reset();
            fieldGeneratorServerDeterminesEndOfAudio.reset();
            fieldGeneratorIntentOnly.reset();
            fieldGeneratorDisableSpellCorrection.reset();
            fieldGeneratorUseContactData.reset();
            fieldGeneratorUseClientTime.reset();
            fieldGeneratorForceConversationStateTime.reset();
            fieldGeneratorPhoneDisambiguationOmitList.reset();
            fieldGeneratorIncomingCallPending.reset();
            fieldGeneratorAllowPopularNameContactMatches.reset();
            fieldGeneratorMusicClientState.reset();
            fieldGeneratorDisableMusicSearchListPositionSpecification.reset();
            fieldGeneratorCollateMusicEntities.reset();
            fieldGeneratorAllowContextFreeMusicSearchForPopularEntities.reset();
            fieldGeneratorReturnInformationNuggetsForMusicSearch.reset();
            fieldGeneratorUseXAPAPI.reset();
            fieldGeneratorLocalSearchClientState.reset();
            fieldGeneratorUberServerToken.reset();
            fieldGeneratorGetUberServerToken.reset();
            fieldGeneratorUberClientId.reset();
            fieldGeneratorGetUberClientId.reset();
            fieldGeneratorSetUserMemoryLocation.reset();
            fieldGeneratorDisableMusicPlayerListPositionSpecification.reset();
            fieldGeneratorCarControlClimateClientConfiguration.reset();
            fieldGeneratorHomeAutomationDomainSettings.reset();
            fieldGeneratorUserContactsRequests.reset();
            fieldGeneratorStoredGlobalPagesToMatch.reset();
            fieldGeneratorStoredGlobalPagesToNotMatch.reset();
            fieldGeneratorStoredPerUserPagesToMatch.reset();
            fieldGeneratorStoredPerUserPagesToNotMatch.reset();
            fieldGeneratorStoredGlobalPagesToSetOnByDefault.reset();
            fieldGeneratorStoredPerUserPagesToSetOnByDefault.reset();
            fieldGeneratorStoredGlobalPagesToSetOffByDefault.reset();
            fieldGeneratorStoredPerUserPagesToSetOffByDefault.reset();
            fieldGeneratorStoredPageMatchWriteData.reset();
            fieldGeneratorStoredPageMatchReadData.reset();
            fieldGeneratorStoredPageMatchPageListData.reset();
            fieldGeneratorVoiceParameters.reset();
            fieldGeneratorStoredAlwaysMatchWriteData.reset();
            fieldGeneratorStoredAlwaysMatchReadData.reset();
            fieldGeneratorUserFeedback.reset();
            fieldGeneratorRadioControlRecognizeNorthAmericanFMBand.reset();
            fieldGeneratorRadioControlRecognizeNorthAmericanAMBand.reset();
            fieldGeneratorRadioControlOtherFMBands.reset();
            fieldGeneratorRadioControlOtherAMBands.reset();
            fieldGeneratorRadioControlAvailableAudioSources.reset();
            fieldGeneratorClientListMatches.reset();
            fieldGeneratorIntentToExecute.reset();
            fieldGeneratorRobotInfo.reset();
            fieldGeneratorConvertToNewInformationNuggets.reset();
            fieldGeneratorAcapelaVoiceParameters.reset();
            fieldGeneratorOutputOverrideCommandIsPreAudioOut.reset();
            fieldGeneratorOutputOverrideCommandFunction.reset();
            fieldGeneratorOutputOverrideCommandFunctionLanguage.reset();
            fieldGeneratorOutputOverrideCommandFunctionSource.reset();
            fieldGeneratorOutputOverrideDeleteCommandFunction.reset();
            fieldGeneratorOutputOverrideReadCommandFunction.reset();
            fieldGeneratorOutputOverrideInformationNuggetFunction.reset();
            fieldGeneratorOutputOverrideInformationNuggetFunctionLanguage.reset();
            fieldGeneratorOutputOverrideInformationNuggetFunctionSource.reset();
            fieldGeneratorOutputOverrideDeleteInformationNuggetFunction.reset();
            fieldGeneratorOutputOverrideReadInformationNuggetFunction.reset();
            fieldGeneratorTerrierUploadWriteData.reset();
            fieldGeneratorTerrierUploadReadData.reset();
            fieldGeneratorDisambiguateResultsBeforeAction.reset();
            fieldGeneratorInputOverrideFunction.reset();
            fieldGeneratorInputOverrideFunctionLanguage.reset();
            fieldGeneratorInputOverrideFunctionSource.reset();
            fieldGeneratorInputOverrideDeleteFunction.reset();
            fieldGeneratorInputOverrideReadFunction.reset();
            fieldGeneratorSportsLeagueControl.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorRoutePoints.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorConversationState.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorClientState.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDomains.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPagination.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorVoiceActivityDetection.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPhoneDisambiguationOmitList.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorIncomingCallPending.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAllowPopularNameContactMatches.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMusicClientState.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDisableMusicSearchListPositionSpecification.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorCollateMusicEntities.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAllowContextFreeMusicSearchForPopularEntities.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorReturnInformationNuggetsForMusicSearch.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorUseXAPAPI.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorLocalSearchClientState.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorUberServerToken.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorGetUberServerToken.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorUberClientId.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorGetUberClientId.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSetUserMemoryLocation.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDisableMusicPlayerListPositionSpecification.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorCarControlClimateClientConfiguration.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorHomeAutomationDomainSettings.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorUserContactsRequests.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStoredGlobalPagesToMatch.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStoredGlobalPagesToNotMatch.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStoredPerUserPagesToMatch.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStoredPerUserPagesToNotMatch.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStoredGlobalPagesToSetOnByDefault.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStoredPerUserPagesToSetOnByDefault.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStoredGlobalPagesToSetOffByDefault.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStoredPerUserPagesToSetOffByDefault.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStoredPageMatchWriteData.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStoredPageMatchReadData.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStoredPageMatchPageListData.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorVoiceParameters.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStoredAlwaysMatchWriteData.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStoredAlwaysMatchReadData.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorUserFeedback.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRadioControlRecognizeNorthAmericanFMBand.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRadioControlRecognizeNorthAmericanAMBand.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRadioControlOtherFMBands.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRadioControlOtherAMBands.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRadioControlAvailableAudioSources.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorClientListMatches.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorIntentToExecute.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRobotInfo.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorConvertToNewInformationNuggets.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAcapelaVoiceParameters.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorOutputOverrideCommandIsPreAudioOut.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorOutputOverrideCommandFunction.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorOutputOverrideCommandFunctionLanguage.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorOutputOverrideCommandFunctionSource.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorOutputOverrideDeleteCommandFunction.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorOutputOverrideReadCommandFunction.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorOutputOverrideInformationNuggetFunction.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorOutputOverrideInformationNuggetFunctionLanguage.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorOutputOverrideInformationNuggetFunctionSource.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorOutputOverrideDeleteInformationNuggetFunction.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorOutputOverrideReadInformationNuggetFunction.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTerrierUploadWriteData.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTerrierUploadReadData.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDisambiguateResultsBeforeAction.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorInputOverrideFunction.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorInputOverrideFunctionLanguage.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorInputOverrideFunctionSource.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorInputOverrideDeleteFunction.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorInputOverrideReadFunction.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSportsLeagueControl.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorRoutePoints.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorConversationState.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorClientState.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDomains.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPagination.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorVoiceActivityDetection.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPhoneDisambiguationOmitList.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorIncomingCallPending.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAllowPopularNameContactMatches.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMusicClientState.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDisableMusicSearchListPositionSpecification.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorCollateMusicEntities.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAllowContextFreeMusicSearchForPopularEntities.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorReturnInformationNuggetsForMusicSearch.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorUseXAPAPI.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorLocalSearchClientState.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorUberServerToken.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorGetUberServerToken.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorUberClientId.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorGetUberClientId.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSetUserMemoryLocation.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDisableMusicPlayerListPositionSpecification.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorCarControlClimateClientConfiguration.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorHomeAutomationDomainSettings.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorUserContactsRequests.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStoredGlobalPagesToMatch.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStoredGlobalPagesToNotMatch.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStoredPerUserPagesToMatch.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStoredPerUserPagesToNotMatch.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStoredGlobalPagesToSetOnByDefault.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStoredPerUserPagesToSetOnByDefault.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStoredGlobalPagesToSetOffByDefault.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStoredPerUserPagesToSetOffByDefault.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStoredPageMatchWriteData.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStoredPageMatchReadData.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStoredPageMatchPageListData.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorVoiceParameters.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStoredAlwaysMatchWriteData.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStoredAlwaysMatchReadData.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorUserFeedback.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRadioControlRecognizeNorthAmericanFMBand.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRadioControlRecognizeNorthAmericanAMBand.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRadioControlOtherFMBands.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRadioControlOtherAMBands.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRadioControlAvailableAudioSources.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorClientListMatches.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorIntentToExecute.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRobotInfo.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorConvertToNewInformationNuggets.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAcapelaVoiceParameters.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorOutputOverrideCommandIsPreAudioOut.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorOutputOverrideCommandFunction.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorOutputOverrideCommandFunctionLanguage.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorOutputOverrideCommandFunctionSource.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorOutputOverrideDeleteCommandFunction.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorOutputOverrideReadCommandFunction.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorOutputOverrideInformationNuggetFunction.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorOutputOverrideInformationNuggetFunctionLanguage.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorOutputOverrideInformationNuggetFunctionSource.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorOutputOverrideDeleteInformationNuggetFunction.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorOutputOverrideReadInformationNuggetFunction.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTerrierUploadWriteData.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTerrierUploadReadData.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDisambiguateResultsBeforeAction.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorInputOverrideFunction.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorInputOverrideFunctionLanguage.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorInputOverrideFunctionSource.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorInputOverrideDeleteFunction.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorInputOverrideReadFunction.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSportsLeagueControl.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(RequestInfoJSON  result)
          {
//@@@            Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public HoldingGenerator(String what, bool ignore_extras) : base(ignore_extras)
          {
            have_value = false;
            base.set_what(what);
          }

        public HoldingGenerator(String what) : base(false)
          {
            have_value = false;
            base.set_what(what);
          }

        public override void reset()
          {
            have_value = false;
            base.reset();
          }

        public bool have_value;
        public RequestInfoJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RequestInfoJSON  result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(HoldingArrayGenerator init_top, bool ignore_extras) : base(ignore_extras)
          {
            top = init_top;
          }
      };

    private ElementHandler element_handler;

    protected override JSONHandler start()
      {
        have_value = true;
        value.Clear();
        return element_handler;
      }
    protected override void finish()
      {
        Debug.Assert(have_value);
        handle_result(value);
        element_handler.reset();
      }
    protected virtual void handle_result(List<RequestInfoJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RequestInfoJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RequestInfoJSON>();
        have_value = false;
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<RequestInfoJSON> value;
  };
  };
