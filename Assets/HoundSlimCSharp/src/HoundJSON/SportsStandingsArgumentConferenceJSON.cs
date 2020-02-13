/* file "SportsStandingsArgumentConferenceJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsStandingsArgumentConferenceJSON : JSONBase
  {
    public enum TypeArgumentType
      {
        ArgumentType_SportsStandingsArgumentConference
      };

    public static TypeArgumentType  stringToArgumentType(string chars)
      {
        if ((String.Compare(chars, 0, "SportsStandingsArgumentConference", 0, 33, false) == 0) && (chars.Length == 33))
            return TypeArgumentType.ArgumentType_SportsStandingsArgumentConference;
        throw new Exception("The value for field `ArgumentType' is not one of the legal values.");
      }

    public static string  stringFromArgumentType(TypeArgumentType the_enum)
      {
        switch (the_enum)
          {
            case TypeArgumentType.ArgumentType_SportsStandingsArgumentConference:
                return "SportsStandingsArgumentConference";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasArgumentType;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONArgumentType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ArgumentType of SportsStandingsArgumentConferenceJSON is not a string.");
        if (!(json_string.getData().Equals("SportsStandingsArgumentConference")))
            throw new Exception("The value for field ArgumentType of SportsStandingsArgumentConferenceJSON is not `SportsStandingsArgumentConference'.");
        setArgumentType();
      }


    public SportsStandingsArgumentConferenceJSON()
      {
        flagHasArgumentType = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasArgumentType()
      {
        return flagHasArgumentType;
      }

    public TypeArgumentType  getArgumentType()
      {
        Debug.Assert(flagHasArgumentType);
        return TypeArgumentType.ArgumentType_SportsStandingsArgumentConference;
      }

    public string  getArgumentTypeAsString()
      {
        return stringFromArgumentType(getArgumentType());
      }


    public virtual int extraSportsStandingsArgumentConferenceComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsStandingsArgumentConferenceComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsStandingsArgumentConferenceComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsStandingsArgumentConferenceLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setArgumentType()
      {
        flagHasArgumentType = true;
      }
    public void setArgumentType(TypeArgumentType new_value)
      {
        setArgumentType();
      }
    public void setArgumentType(string chars)
      {
        setArgumentType(stringToArgumentType(chars));
      }
    public void unsetArgumentType()
      {
        flagHasArgumentType = false;
      }

    public virtual void extraSportsStandingsArgumentConferenceAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsStandingsArgumentConferenceSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsStandingsArgumentConferenceLookup(key);
        if (old_field == null)
          {
            extraSportsStandingsArgumentConferenceAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasArgumentType);
        if (flagHasArgumentType)
          {
            handler.start_pair("ArgumentType");
            handler.string_value("SportsStandingsArgumentConference");
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
        if (!(hasArgumentType()))
          {
            return "When parsing the object for %what%, the \"ArgumentType\" field was missing.";
          }
        return null;
      }

    public static SportsStandingsArgumentConferenceJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStandingsArgumentConferenceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsArgumentConference", ignore_extras);
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
    public static SportsStandingsArgumentConferenceJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsStandingsArgumentConferenceJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStandingsArgumentConferenceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsArgumentConference", ignore_extras);
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
    public static SportsStandingsArgumentConferenceJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsStandingsArgumentConferenceJSON from_text(string text, bool ignore_extras)
      {
        SportsStandingsArgumentConferenceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsArgumentConference", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsStandingsArgumentConferenceJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsStandingsArgumentConferenceJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsStandingsArgumentConferenceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsArgumentConference", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorArgumentType : JSONStringGenerator
          {
            protected FieldGeneratorArgumentType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorArgumentType()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToArgumentType(result));
              }
            protected abstract void handle_result(TypeArgumentType result);
          };
    private class FieldHoldingGeneratorArgumentType : FieldGeneratorArgumentType
  {
    protected override void handle_result(TypeArgumentType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorArgumentType(String what)
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
    public TypeArgumentType value;
  };
    private class FieldHoldingArrayGeneratorArgumentType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorArgumentType
      {
        private FieldHoldingArrayGeneratorArgumentType top;

        protected override void handle_result(TypeArgumentType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorArgumentType init_top)
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
    protected virtual void handle_result(List<TypeArgumentType> result)
      {
      }

    public FieldHoldingArrayGeneratorArgumentType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeArgumentType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorArgumentType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeArgumentType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeArgumentType> value;
  };
        private FieldHoldingGeneratorArgumentType fieldGeneratorArgumentType;
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
            SportsStandingsArgumentConferenceJSON result = new SportsStandingsArgumentConferenceJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsStandingsArgumentConferenceAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsStandingsArgumentConferenceJSON result)
          {
            if (fieldGeneratorArgumentType.have_value)
              {
                result.setArgumentType();
                fieldGeneratorArgumentType.have_value = false;
              }
            else if ((!(result.hasArgumentType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ArgumentType\" field was missing.");
              }
          }
        protected abstract void handle_result(SportsStandingsArgumentConferenceJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "ArgumentType", 0, 12, false) == 0) && (field_name.Length == 12))
                return fieldGeneratorArgumentType;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorArgumentType = new FieldHoldingGeneratorArgumentType("field \"ArgumentType\" of the SportsStandingsArgumentConference class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsStandingsArgumentConference class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorArgumentType = new FieldHoldingGeneratorArgumentType("field \"ArgumentType\" of the SportsStandingsArgumentConference class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsStandingsArgumentConference class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorArgumentType.reset();
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
        protected override void handle_result(SportsStandingsArgumentConferenceJSON  result)
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
        public SportsStandingsArgumentConferenceJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsStandingsArgumentConferenceJSON  result)
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
    protected virtual void handle_result(List<SportsStandingsArgumentConferenceJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsStandingsArgumentConferenceJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsStandingsArgumentConferenceJSON>();
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
    public List<SportsStandingsArgumentConferenceJSON> value;
  };
  };
