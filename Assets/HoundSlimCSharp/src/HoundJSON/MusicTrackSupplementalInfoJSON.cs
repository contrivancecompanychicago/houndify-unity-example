/* file "MusicTrackSupplementalInfoJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MusicTrackSupplementalInfoJSON : JSONBase
  {
    private bool flagHasPrimaryIDType;
    private MusicThirdPartyJSON  storePrimaryIDType;
    private bool flagHasSpotifyTrackID;
    private string storeSpotifyTrackID;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONPrimaryIDType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MusicThirdPartyJSON convert_classy = MusicThirdPartyJSON.from_json(json_value, ignore_extras, true);
        setPrimaryIDType(convert_classy);
      }


    private void  fromJSONSpotifyTrackID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpotifyTrackID of MusicTrackSupplementalInfoJSON is not a string.");
        setSpotifyTrackID(json_string.getData());
      }


    public MusicTrackSupplementalInfoJSON()
      {
        flagHasPrimaryIDType = false;
        flagHasSpotifyTrackID = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasPrimaryIDType()
      {
        return flagHasPrimaryIDType;
      }

    public MusicThirdPartyJSON   getPrimaryIDType()
      {
        Debug.Assert(flagHasPrimaryIDType);
        return storePrimaryIDType;
      }

    public bool  hasSpotifyTrackID()
      {
        return flagHasSpotifyTrackID;
      }

    public string  getSpotifyTrackID()
      {
        Debug.Assert(flagHasSpotifyTrackID);
        return storeSpotifyTrackID;
      }


    public virtual int extraMusicTrackSupplementalInfoComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMusicTrackSupplementalInfoComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMusicTrackSupplementalInfoComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMusicTrackSupplementalInfoLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setPrimaryIDType(MusicThirdPartyJSON  new_value)
      {
        if (flagHasPrimaryIDType)
          {
          }
        flagHasPrimaryIDType = true;
        storePrimaryIDType = new_value;
      }
    public void unsetPrimaryIDType()
      {
        if (flagHasPrimaryIDType)
          {
          }
        flagHasPrimaryIDType = false;
      }
    public void setSpotifyTrackID(string new_value)
      {
        flagHasSpotifyTrackID = true;
        storeSpotifyTrackID = new_value;
      }
    public void unsetSpotifyTrackID()
      {
        flagHasSpotifyTrackID = false;
      }

    public virtual void extraMusicTrackSupplementalInfoAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMusicTrackSupplementalInfoSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMusicTrackSupplementalInfoLookup(key);
        if (old_field == null)
          {
            extraMusicTrackSupplementalInfoAppendPair(key, new_component);
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
        if (flagHasPrimaryIDType)
          {
            handler.start_pair("PrimaryIDType");
            if (partial_allowed)
                storePrimaryIDType.write_partial_as_json(handler);
            else
                storePrimaryIDType.write_as_json(handler);
          }
        if (flagHasSpotifyTrackID)
          {
            handler.start_pair("SpotifyTrackID");
            handler.string_value(storeSpotifyTrackID);
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

    public static MusicTrackSupplementalInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicTrackSupplementalInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicTrackSupplementalInfo", ignore_extras);
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
    public static MusicTrackSupplementalInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicTrackSupplementalInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicTrackSupplementalInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicTrackSupplementalInfo", ignore_extras);
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
    public static MusicTrackSupplementalInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicTrackSupplementalInfoJSON from_text(string text, bool ignore_extras)
      {
        MusicTrackSupplementalInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicTrackSupplementalInfo", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicTrackSupplementalInfoJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MusicTrackSupplementalInfoJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicTrackSupplementalInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicTrackSupplementalInfo", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private MusicThirdPartyJSON.HoldingGenerator fieldGeneratorPrimaryIDType;
        private JSONHoldingStringGenerator fieldGeneratorSpotifyTrackID;
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
            MusicTrackSupplementalInfoJSON result = new MusicTrackSupplementalInfoJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMusicTrackSupplementalInfoAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(MusicTrackSupplementalInfoJSON result)
          {
            if (fieldGeneratorPrimaryIDType.have_value)
              {
                result.setPrimaryIDType(fieldGeneratorPrimaryIDType.value);
                fieldGeneratorPrimaryIDType.have_value = false;
              }
            if (fieldGeneratorSpotifyTrackID.have_value)
              {
                result.setSpotifyTrackID(fieldGeneratorSpotifyTrackID.value);
                fieldGeneratorSpotifyTrackID.have_value = false;
              }
          }
        protected abstract void handle_result(MusicTrackSupplementalInfoJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'P':
                    if ((String.Compare(field_name, 1, "rimaryIDType", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorPrimaryIDType;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "potifyTrackID", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorSpotifyTrackID;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorPrimaryIDType = new MusicThirdPartyJSON.HoldingGenerator("field \"PrimaryIDType\" of the MusicTrackSupplementalInfo class", ignore_extras);
            fieldGeneratorSpotifyTrackID = new JSONHoldingStringGenerator("field \"SpotifyTrackID\" of the MusicTrackSupplementalInfo class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MusicTrackSupplementalInfo class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorPrimaryIDType = new MusicThirdPartyJSON.HoldingGenerator("field \"PrimaryIDType\" of the MusicTrackSupplementalInfo class", false);
            fieldGeneratorSpotifyTrackID = new JSONHoldingStringGenerator("field \"SpotifyTrackID\" of the MusicTrackSupplementalInfo class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MusicTrackSupplementalInfo class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorPrimaryIDType.reset();
            fieldGeneratorSpotifyTrackID.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorPrimaryIDType.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorPrimaryIDType.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MusicTrackSupplementalInfoJSON  result)
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
        public MusicTrackSupplementalInfoJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicTrackSupplementalInfoJSON  result)
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
    protected virtual void handle_result(List<MusicTrackSupplementalInfoJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicTrackSupplementalInfoJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicTrackSupplementalInfoJSON>();
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
    public List<MusicTrackSupplementalInfoJSON> value;
  };
  };
