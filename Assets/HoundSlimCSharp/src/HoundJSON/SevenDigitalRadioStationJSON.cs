/* file "SevenDigitalRadioStationJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SevenDigitalRadioStationJSON : JSONBase
  {
    private bool flagHasProviderName;
    private string storeProviderName;
    private bool flagHasProviderDescription;
    private string storeProviderDescription;
    private bool flagHasProviderWebURL;
    private string storeProviderWebURL;
    private bool flagHasProviderImageURL;
    private string storeProviderImageURL;
    private bool flagHasNetRadioID;
    private BigInteger storeNetRadioID;
    private bool flagHasStationDescription;
    private string storeStationDescription;
    private bool flagHasStationWebURL;
    private string storeStationWebURL;
    private bool flagHasBroadcastMethod;
    private string storeBroadcastMethod;
    private bool flagHasImageURL;
    private string storeImageURL;
    private bool flagHasCity;
    private string storeCity;
    private bool flagHasStationName;
    private string storeStationName;
    private bool flagHasFrequency;
    private double storeFrequency;
    private string textStoreFrequency;
    private bool flagHasBand;
    private string storeBand;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONProviderName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ProviderName of SevenDigitalRadioStationJSON is not a string.");
        setProviderName(json_string.getData());
      }


    private void  fromJSONProviderDescription(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ProviderDescription of SevenDigitalRadioStationJSON is not a string.");
        setProviderDescription(json_string.getData());
      }


    private void  fromJSONProviderWebURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ProviderWebURL of SevenDigitalRadioStationJSON is not a string.");
        setProviderWebURL(json_string.getData());
      }


    private void  fromJSONProviderImageURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ProviderImageURL of SevenDigitalRadioStationJSON is not a string.");
        setProviderImageURL(json_string.getData());
      }


    private void  fromJSONNetRadioID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field NetRadioID of SevenDigitalRadioStationJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field NetRadioID of SevenDigitalRadioStationJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setNetRadioID(extracted_integer);
      }


    private void  fromJSONStationDescription(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field StationDescription of SevenDigitalRadioStationJSON is not a string.");
        setStationDescription(json_string.getData());
      }


    private void  fromJSONStationWebURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field StationWebURL of SevenDigitalRadioStationJSON is not a string.");
        setStationWebURL(json_string.getData());
      }


    private void  fromJSONBroadcastMethod(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field BroadcastMethod of SevenDigitalRadioStationJSON is not a string.");
        setBroadcastMethod(json_string.getData());
      }


    private void  fromJSONImageURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ImageURL of SevenDigitalRadioStationJSON is not a string.");
        setImageURL(json_string.getData());
      }


    private void  fromJSONCity(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field City of SevenDigitalRadioStationJSON is not a string.");
        setCity(json_string.getData());
      }


    private void  fromJSONStationName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field StationName of SevenDigitalRadioStationJSON is not a string.");
        setStationName(json_string.getData());
      }


    private void  fromJSONFrequency(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Frequency of SevenDigitalRadioStationJSON is not a number.");
              }
          }
        setFrequencyText(the_rational_text);
      }


    private void  fromJSONBand(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Band of SevenDigitalRadioStationJSON is not a string.");
        setBand(json_string.getData());
      }


    public SevenDigitalRadioStationJSON()
      {
        flagHasProviderName = false;
        flagHasProviderDescription = false;
        flagHasProviderWebURL = false;
        flagHasProviderImageURL = false;
        flagHasNetRadioID = false;
        flagHasStationDescription = false;
        flagHasStationWebURL = false;
        flagHasBroadcastMethod = false;
        flagHasImageURL = false;
        flagHasCity = false;
        flagHasStationName = false;
        flagHasFrequency = false;
        flagHasBand = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasProviderName()
      {
        return flagHasProviderName;
      }

    public string  getProviderName()
      {
        Debug.Assert(flagHasProviderName);
        return storeProviderName;
      }

    public bool  hasProviderDescription()
      {
        return flagHasProviderDescription;
      }

    public string  getProviderDescription()
      {
        Debug.Assert(flagHasProviderDescription);
        return storeProviderDescription;
      }

    public bool  hasProviderWebURL()
      {
        return flagHasProviderWebURL;
      }

    public string  getProviderWebURL()
      {
        Debug.Assert(flagHasProviderWebURL);
        return storeProviderWebURL;
      }

    public bool  hasProviderImageURL()
      {
        return flagHasProviderImageURL;
      }

    public string  getProviderImageURL()
      {
        Debug.Assert(flagHasProviderImageURL);
        return storeProviderImageURL;
      }

    public bool  hasNetRadioID()
      {
        return flagHasNetRadioID;
      }

    public BigInteger  getNetRadioID()
      {
        Debug.Assert(flagHasNetRadioID);
        return storeNetRadioID;
      }

    public bool  hasStationDescription()
      {
        return flagHasStationDescription;
      }

    public string  getStationDescription()
      {
        Debug.Assert(flagHasStationDescription);
        return storeStationDescription;
      }

    public bool  hasStationWebURL()
      {
        return flagHasStationWebURL;
      }

    public string  getStationWebURL()
      {
        Debug.Assert(flagHasStationWebURL);
        return storeStationWebURL;
      }

    public bool  hasBroadcastMethod()
      {
        return flagHasBroadcastMethod;
      }

    public string  getBroadcastMethod()
      {
        Debug.Assert(flagHasBroadcastMethod);
        return storeBroadcastMethod;
      }

    public bool  hasImageURL()
      {
        return flagHasImageURL;
      }

    public string  getImageURL()
      {
        Debug.Assert(flagHasImageURL);
        return storeImageURL;
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

    public bool  hasStationName()
      {
        return flagHasStationName;
      }

    public string  getStationName()
      {
        Debug.Assert(flagHasStationName);
        return storeStationName;
      }

    public bool  hasFrequency()
      {
        return flagHasFrequency;
      }

    public double  getFrequency()
      {
        Debug.Assert(flagHasFrequency);
        if (textStoreFrequency != "")
          {
            return Double.Parse(textStoreFrequency);
          }
        return storeFrequency;
      }

    public string  getFrequencyAsText()
      {
        Debug.Assert(flagHasFrequency);
        if (textStoreFrequency == "")
          {
            return Convert.ToString(storeFrequency);
          }
        else
          {
            return (textStoreFrequency);
          }
      }

    public bool  hasBand()
      {
        return flagHasBand;
      }

    public string  getBand()
      {
        Debug.Assert(flagHasBand);
        return storeBand;
      }


    public virtual int extraSevenDigitalRadioStationComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSevenDigitalRadioStationComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSevenDigitalRadioStationComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSevenDigitalRadioStationLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setProviderName(string new_value)
      {
        flagHasProviderName = true;
        storeProviderName = new_value;
      }
    public void unsetProviderName()
      {
        flagHasProviderName = false;
      }
    public void setProviderDescription(string new_value)
      {
        flagHasProviderDescription = true;
        storeProviderDescription = new_value;
      }
    public void unsetProviderDescription()
      {
        flagHasProviderDescription = false;
      }
    public void setProviderWebURL(string new_value)
      {
        flagHasProviderWebURL = true;
        storeProviderWebURL = new_value;
      }
    public void unsetProviderWebURL()
      {
        flagHasProviderWebURL = false;
      }
    public void setProviderImageURL(string new_value)
      {
        flagHasProviderImageURL = true;
        storeProviderImageURL = new_value;
      }
    public void unsetProviderImageURL()
      {
        flagHasProviderImageURL = false;
      }
    public void setNetRadioID(BigInteger new_value)
      {
        flagHasNetRadioID = true;
        storeNetRadioID = new_value;
      }
    public void unsetNetRadioID()
      {
        flagHasNetRadioID = false;
      }
    public void setStationDescription(string new_value)
      {
        flagHasStationDescription = true;
        storeStationDescription = new_value;
      }
    public void unsetStationDescription()
      {
        flagHasStationDescription = false;
      }
    public void setStationWebURL(string new_value)
      {
        flagHasStationWebURL = true;
        storeStationWebURL = new_value;
      }
    public void unsetStationWebURL()
      {
        flagHasStationWebURL = false;
      }
    public void setBroadcastMethod(string new_value)
      {
        flagHasBroadcastMethod = true;
        storeBroadcastMethod = new_value;
      }
    public void unsetBroadcastMethod()
      {
        flagHasBroadcastMethod = false;
      }
    public void setImageURL(string new_value)
      {
        flagHasImageURL = true;
        storeImageURL = new_value;
      }
    public void unsetImageURL()
      {
        flagHasImageURL = false;
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
    public void setStationName(string new_value)
      {
        flagHasStationName = true;
        storeStationName = new_value;
      }
    public void unsetStationName()
      {
        flagHasStationName = false;
      }
    public void setFrequency(double new_value)
      {
        flagHasFrequency = true;
        storeFrequency = new_value;
        textStoreFrequency = "";
      }
    public void setFrequencyText(string new_value)
      {
        flagHasFrequency = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Frequency of SevenDigitalRadioStationJSON is not a valid number.");
        textStoreFrequency = new_value;
      }
    public void unsetFrequency()
      {
        flagHasFrequency = false;
      }
    public void setBand(string new_value)
      {
        flagHasBand = true;
        storeBand = new_value;
      }
    public void unsetBand()
      {
        flagHasBand = false;
      }

    public virtual void extraSevenDigitalRadioStationAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSevenDigitalRadioStationSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSevenDigitalRadioStationLookup(key);
        if (old_field == null)
          {
            extraSevenDigitalRadioStationAppendPair(key, new_component);
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
        if (flagHasProviderName)
          {
            handler.start_pair("ProviderName");
            handler.string_value(storeProviderName);
          }
        if (flagHasProviderDescription)
          {
            handler.start_pair("ProviderDescription");
            handler.string_value(storeProviderDescription);
          }
        if (flagHasProviderWebURL)
          {
            handler.start_pair("ProviderWebURL");
            handler.string_value(storeProviderWebURL);
          }
        if (flagHasProviderImageURL)
          {
            handler.start_pair("ProviderImageURL");
            handler.string_value(storeProviderImageURL);
          }
        if (flagHasNetRadioID)
          {
            handler.start_pair("NetRadioID");
            handler.number_value(storeNetRadioID);
          }
        if (flagHasStationDescription)
          {
            handler.start_pair("StationDescription");
            handler.string_value(storeStationDescription);
          }
        if (flagHasStationWebURL)
          {
            handler.start_pair("StationWebURL");
            handler.string_value(storeStationWebURL);
          }
        if (flagHasBroadcastMethod)
          {
            handler.start_pair("BroadcastMethod");
            handler.string_value(storeBroadcastMethod);
          }
        if (flagHasImageURL)
          {
            handler.start_pair("ImageURL");
            handler.string_value(storeImageURL);
          }
        if (flagHasCity)
          {
            handler.start_pair("City");
            handler.string_value(storeCity);
          }
        if (flagHasStationName)
          {
            handler.start_pair("StationName");
            handler.string_value(storeStationName);
          }
        if (flagHasFrequency)
          {
            handler.start_pair("Frequency");
            if (textStoreFrequency != "")
                handler.number_value(textStoreFrequency);
            else if (((double)(long)storeFrequency) == storeFrequency)
                handler.number_value((long)storeFrequency);
            else
                handler.number_value(storeFrequency);
          }
        if (flagHasBand)
          {
            handler.start_pair("Band");
            handler.string_value(storeBand);
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

    public static SevenDigitalRadioStationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SevenDigitalRadioStationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SevenDigitalRadioStation", ignore_extras);
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
    public static SevenDigitalRadioStationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SevenDigitalRadioStationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SevenDigitalRadioStationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SevenDigitalRadioStation", ignore_extras);
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
    public static SevenDigitalRadioStationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SevenDigitalRadioStationJSON from_text(string text, bool ignore_extras)
      {
        SevenDigitalRadioStationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SevenDigitalRadioStation", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SevenDigitalRadioStationJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SevenDigitalRadioStationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SevenDigitalRadioStationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SevenDigitalRadioStation", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorProviderName;
        private JSONHoldingStringGenerator fieldGeneratorProviderDescription;
        private JSONHoldingStringGenerator fieldGeneratorProviderWebURL;
        private JSONHoldingStringGenerator fieldGeneratorProviderImageURL;
    private class FieldHoldingGeneratorNetRadioID : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorNetRadioID(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorNetRadioID : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorNetRadioID(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorNetRadioID fieldGeneratorNetRadioID;
        private JSONHoldingStringGenerator fieldGeneratorStationDescription;
        private JSONHoldingStringGenerator fieldGeneratorStationWebURL;
        private JSONHoldingStringGenerator fieldGeneratorBroadcastMethod;
        private JSONHoldingStringGenerator fieldGeneratorImageURL;
        private JSONHoldingStringGenerator fieldGeneratorCity;
        private JSONHoldingStringGenerator fieldGeneratorStationName;
        private JSONHoldingNumberTextGenerator fieldGeneratorFrequency;
        private JSONHoldingStringGenerator fieldGeneratorBand;
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
            SevenDigitalRadioStationJSON result = new SevenDigitalRadioStationJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSevenDigitalRadioStationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SevenDigitalRadioStationJSON result)
          {
            if (fieldGeneratorProviderName.have_value)
              {
                result.setProviderName(fieldGeneratorProviderName.value);
                fieldGeneratorProviderName.have_value = false;
              }
            if (fieldGeneratorProviderDescription.have_value)
              {
                result.setProviderDescription(fieldGeneratorProviderDescription.value);
                fieldGeneratorProviderDescription.have_value = false;
              }
            if (fieldGeneratorProviderWebURL.have_value)
              {
                result.setProviderWebURL(fieldGeneratorProviderWebURL.value);
                fieldGeneratorProviderWebURL.have_value = false;
              }
            if (fieldGeneratorProviderImageURL.have_value)
              {
                result.setProviderImageURL(fieldGeneratorProviderImageURL.value);
                fieldGeneratorProviderImageURL.have_value = false;
              }
            if (fieldGeneratorNetRadioID.have_value)
              {
                result.setNetRadioID(fieldGeneratorNetRadioID.value);
                fieldGeneratorNetRadioID.have_value = false;
              }
            if (fieldGeneratorStationDescription.have_value)
              {
                result.setStationDescription(fieldGeneratorStationDescription.value);
                fieldGeneratorStationDescription.have_value = false;
              }
            if (fieldGeneratorStationWebURL.have_value)
              {
                result.setStationWebURL(fieldGeneratorStationWebURL.value);
                fieldGeneratorStationWebURL.have_value = false;
              }
            if (fieldGeneratorBroadcastMethod.have_value)
              {
                result.setBroadcastMethod(fieldGeneratorBroadcastMethod.value);
                fieldGeneratorBroadcastMethod.have_value = false;
              }
            if (fieldGeneratorImageURL.have_value)
              {
                result.setImageURL(fieldGeneratorImageURL.value);
                fieldGeneratorImageURL.have_value = false;
              }
            if (fieldGeneratorCity.have_value)
              {
                result.setCity(fieldGeneratorCity.value);
                fieldGeneratorCity.have_value = false;
              }
            if (fieldGeneratorStationName.have_value)
              {
                result.setStationName(fieldGeneratorStationName.value);
                fieldGeneratorStationName.have_value = false;
              }
            if (fieldGeneratorFrequency.have_value)
              {
                result.setFrequencyText(fieldGeneratorFrequency.value);
                fieldGeneratorFrequency.have_value = false;
              }
            if (fieldGeneratorBand.have_value)
              {
                result.setBand(fieldGeneratorBand.value);
                fieldGeneratorBand.have_value = false;
              }
          }
        protected abstract void handle_result(SevenDigitalRadioStationJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "nd", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorBand;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "oadcastMethod", 0, 13, false) == 0) && (field_name.Length == 15))
                                return fieldGeneratorBroadcastMethod;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "ity", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorCity;
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "requency", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorFrequency;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "mageURL", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorImageURL;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "etRadioID", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorNetRadioID;
                    break;
                case 'P':
                    if (String.Compare(field_name, 1, "rovider", 0, 7, false) == 0)
                      {
                        switch (field_name[8])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 9, "escription", 0, 10, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorProviderDescription;
                                break;
                            case 'I':
                                if ((String.Compare(field_name, 9, "mageURL", 0, 7, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorProviderImageURL;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 9, "ame", 0, 3, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorProviderName;
                                break;
                            case 'W':
                                if ((String.Compare(field_name, 9, "ebURL", 0, 5, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorProviderWebURL;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "tation", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 8, "escription", 0, 10, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorStationDescription;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 8, "ame", 0, 3, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorStationName;
                                break;
                            case 'W':
                                if ((String.Compare(field_name, 8, "ebURL", 0, 5, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorStationWebURL;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorProviderName = new JSONHoldingStringGenerator("field \"ProviderName\" of the SevenDigitalRadioStation class");
            fieldGeneratorProviderDescription = new JSONHoldingStringGenerator("field \"ProviderDescription\" of the SevenDigitalRadioStation class");
            fieldGeneratorProviderWebURL = new JSONHoldingStringGenerator("field \"ProviderWebURL\" of the SevenDigitalRadioStation class");
            fieldGeneratorProviderImageURL = new JSONHoldingStringGenerator("field \"ProviderImageURL\" of the SevenDigitalRadioStation class");
            fieldGeneratorNetRadioID = new FieldHoldingGeneratorNetRadioID("field \"NetRadioID\" of the SevenDigitalRadioStation class");
            fieldGeneratorStationDescription = new JSONHoldingStringGenerator("field \"StationDescription\" of the SevenDigitalRadioStation class");
            fieldGeneratorStationWebURL = new JSONHoldingStringGenerator("field \"StationWebURL\" of the SevenDigitalRadioStation class");
            fieldGeneratorBroadcastMethod = new JSONHoldingStringGenerator("field \"BroadcastMethod\" of the SevenDigitalRadioStation class");
            fieldGeneratorImageURL = new JSONHoldingStringGenerator("field \"ImageURL\" of the SevenDigitalRadioStation class");
            fieldGeneratorCity = new JSONHoldingStringGenerator("field \"City\" of the SevenDigitalRadioStation class");
            fieldGeneratorStationName = new JSONHoldingStringGenerator("field \"StationName\" of the SevenDigitalRadioStation class");
            fieldGeneratorFrequency = new JSONHoldingNumberTextGenerator("field \"Frequency\" of the SevenDigitalRadioStation class");
            fieldGeneratorBand = new JSONHoldingStringGenerator("field \"Band\" of the SevenDigitalRadioStation class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SevenDigitalRadioStation class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorProviderName = new JSONHoldingStringGenerator("field \"ProviderName\" of the SevenDigitalRadioStation class");
            fieldGeneratorProviderDescription = new JSONHoldingStringGenerator("field \"ProviderDescription\" of the SevenDigitalRadioStation class");
            fieldGeneratorProviderWebURL = new JSONHoldingStringGenerator("field \"ProviderWebURL\" of the SevenDigitalRadioStation class");
            fieldGeneratorProviderImageURL = new JSONHoldingStringGenerator("field \"ProviderImageURL\" of the SevenDigitalRadioStation class");
            fieldGeneratorNetRadioID = new FieldHoldingGeneratorNetRadioID("field \"NetRadioID\" of the SevenDigitalRadioStation class");
            fieldGeneratorStationDescription = new JSONHoldingStringGenerator("field \"StationDescription\" of the SevenDigitalRadioStation class");
            fieldGeneratorStationWebURL = new JSONHoldingStringGenerator("field \"StationWebURL\" of the SevenDigitalRadioStation class");
            fieldGeneratorBroadcastMethod = new JSONHoldingStringGenerator("field \"BroadcastMethod\" of the SevenDigitalRadioStation class");
            fieldGeneratorImageURL = new JSONHoldingStringGenerator("field \"ImageURL\" of the SevenDigitalRadioStation class");
            fieldGeneratorCity = new JSONHoldingStringGenerator("field \"City\" of the SevenDigitalRadioStation class");
            fieldGeneratorStationName = new JSONHoldingStringGenerator("field \"StationName\" of the SevenDigitalRadioStation class");
            fieldGeneratorFrequency = new JSONHoldingNumberTextGenerator("field \"Frequency\" of the SevenDigitalRadioStation class");
            fieldGeneratorBand = new JSONHoldingStringGenerator("field \"Band\" of the SevenDigitalRadioStation class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SevenDigitalRadioStation class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorProviderName.reset();
            fieldGeneratorProviderDescription.reset();
            fieldGeneratorProviderWebURL.reset();
            fieldGeneratorProviderImageURL.reset();
            fieldGeneratorNetRadioID.reset();
            fieldGeneratorStationDescription.reset();
            fieldGeneratorStationWebURL.reset();
            fieldGeneratorBroadcastMethod.reset();
            fieldGeneratorImageURL.reset();
            fieldGeneratorCity.reset();
            fieldGeneratorStationName.reset();
            fieldGeneratorFrequency.reset();
            fieldGeneratorBand.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SevenDigitalRadioStationJSON  result)
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
        public SevenDigitalRadioStationJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SevenDigitalRadioStationJSON  result)
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
    protected virtual void handle_result(List<SevenDigitalRadioStationJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SevenDigitalRadioStationJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SevenDigitalRadioStationJSON>();
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
    public List<SevenDigitalRadioStationJSON> value;
  };
  };
