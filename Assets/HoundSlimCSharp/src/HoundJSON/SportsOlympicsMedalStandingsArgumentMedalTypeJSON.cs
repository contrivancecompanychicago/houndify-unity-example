/* file "SportsOlympicsMedalStandingsArgumentMedalTypeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsOlympicsMedalStandingsArgumentMedalTypeJSON : SportsOlympicsMedalStandingsArgumentJSON
  {
    private bool flagHasMedalType;
    private SportsOlympicsMedalJSON  storeMedalType;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraMedalTypeToJSON()
      {
        JSONValueHandler handler_MedalType = new JSONValueHandler();
        storeMedalType.write_as_json(handler_MedalType);
        return handler_MedalType.result;
      }


    private void  fromJSONMedalType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsOlympicsMedalJSON convert_classy = SportsOlympicsMedalJSON.from_json(json_value, ignore_extras, true);
        setMedalType(convert_classy);
      }


    public SportsOlympicsMedalStandingsArgumentMedalTypeJSON()
      {
        flagHasMedalType = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getSportsOlympicsMedalStandingsArgumentKind()
      {
        return "MedalType";
      }

    public bool  hasMedalType()
      {
        return flagHasMedalType;
      }

    public SportsOlympicsMedalJSON   getMedalType()
      {
        Debug.Assert(flagHasMedalType);
        return storeMedalType;
      }

    public SportsOlympicsMedalJSON.TypeValue  getMedalTypeValue()
      {
        return getMedalType().getValue();
      }

    public string  getMedalTypeAsString()
      {
        return getMedalType().getValueAsString();
      }


    public virtual int extraSportsOlympicsMedalStandingsArgumentMedalTypeComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsOlympicsMedalStandingsArgumentMedalTypeComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsOlympicsMedalStandingsArgumentMedalTypeComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsOlympicsMedalStandingsArgumentMedalTypeLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSportsOlympicsMedalStandingsArgumentComponentCount()
      {
        int result = 0;
        if (flagHasMedalType)
            ++result;
        result += extraSportsOlympicsMedalStandingsArgumentMedalTypeComponentCount();
        return result;
      }
    public override string extraSportsOlympicsMedalStandingsArgumentComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasMedalType)
          {
            if (remainder == 0)
                return "MedalType";
            --remainder;
          }
        return extraSportsOlympicsMedalStandingsArgumentMedalTypeComponentKey(remainder);
      }
    public override JSONValue extraSportsOlympicsMedalStandingsArgumentComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasMedalType)
          {
            if (remainder == 0)
                return extraMedalTypeToJSON();
            --remainder;
          }
        return extraSportsOlympicsMedalStandingsArgumentMedalTypeComponentValue(remainder);
      }
    public override JSONValue extraSportsOlympicsMedalStandingsArgumentLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "MedalType", 0, 9, false) == 0) && (field_name.Length == 9))
            return (flagHasMedalType ? extraMedalTypeToJSON() : null);
        return extraSportsOlympicsMedalStandingsArgumentMedalTypeLookup(field_name);
      }

    public void setMedalType(SportsOlympicsMedalJSON  new_value)
      {
        if (flagHasMedalType)
          {
          }
        flagHasMedalType = true;
        storeMedalType = new_value;
      }
    public void setMedalType(SportsOlympicsMedalJSON.TypeValue new_value)
      {
        setMedalType(new SportsOlympicsMedalJSON(new_value));
      }
    public void setMedalType(string chars)
      {
        SportsOlympicsMedalJSON.TypeValueKnownValues known = SportsOlympicsMedalJSON.stringToValue(chars);
        SportsOlympicsMedalJSON.TypeValue new_value = new SportsOlympicsMedalJSON.TypeValue();
        if (known == SportsOlympicsMedalJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setMedalType(new_value);
      }
    public void unsetMedalType()
      {
        if (flagHasMedalType)
          {
          }
        flagHasMedalType = false;
      }

    public virtual void extraSportsOlympicsMedalStandingsArgumentMedalTypeAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsOlympicsMedalStandingsArgumentMedalTypeSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsOlympicsMedalStandingsArgumentMedalTypeLookup(key);
        if (old_field == null)
          {
            extraSportsOlympicsMedalStandingsArgumentMedalTypeAppendPair(key, new_component);
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
    public override void extraSportsOlympicsMedalStandingsArgumentAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "MedalType", 0, 9, false) == 0) && (key.Length == 9))
            {
            fromJSONMedalType(new_component, false);
            return;
            }
        extraSportsOlympicsMedalStandingsArgumentMedalTypeAppendPair(key, new_component);
      }
    public override void extraSportsOlympicsMedalStandingsArgumentSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "MedalType", 0, 9, false) == 0) && (key.Length == 9))
            {
            fromJSONMedalType(new_component, false);
            return;
            }
        extraSportsOlympicsMedalStandingsArgumentMedalTypeSetField(key, new_component);
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

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        if (flagHasMedalType)
          {
            handler.start_pair("MedalType");
            if (partial_allowed)
                storeMedalType.write_partial_as_json(handler);
            else
                storeMedalType.write_as_json(handler);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static new SportsOlympicsMedalStandingsArgumentMedalTypeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsMedalStandingsArgumentMedalTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsMedalStandingsArgumentMedalType", ignore_extras);
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
    public static new SportsOlympicsMedalStandingsArgumentMedalTypeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsOlympicsMedalStandingsArgumentMedalTypeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsMedalStandingsArgumentMedalTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsMedalStandingsArgumentMedalType", ignore_extras);
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
    public static new SportsOlympicsMedalStandingsArgumentMedalTypeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsOlympicsMedalStandingsArgumentMedalTypeJSON from_text(string text, bool ignore_extras)
      {
        SportsOlympicsMedalStandingsArgumentMedalTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsMedalStandingsArgumentMedalType", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsOlympicsMedalStandingsArgumentMedalTypeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SportsOlympicsMedalStandingsArgumentMedalTypeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsOlympicsMedalStandingsArgumentMedalTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsMedalStandingsArgumentMedalType", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SportsOlympicsMedalStandingsArgumentJSON.Generator
      {
        private SportsOlympicsMedalJSON.HoldingGenerator fieldGeneratorMedalType;
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
            if (!(getSportsOlympicsMedalStandingsArgumentJSONKey().Equals("MedalType")))
                throw new Exception("The key field has a value other than `MedalType'.");
            SportsOlympicsMedalStandingsArgumentMedalTypeJSON result = new SportsOlympicsMedalStandingsArgumentMedalTypeJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsOlympicsMedalStandingsArgumentMedalTypeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SportsOlympicsMedalStandingsArgumentJSON new_result)
          {
            handle_result((SportsOlympicsMedalStandingsArgumentMedalTypeJSON )new_result);
          }
        protected void finish(SportsOlympicsMedalStandingsArgumentMedalTypeJSON result)
          {
            if (fieldGeneratorMedalType.have_value)
              {
                result.setMedalType(fieldGeneratorMedalType.value);
                fieldGeneratorMedalType.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(SportsOlympicsMedalStandingsArgumentMedalTypeJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "MedalType", 0, 9, false) == 0) && (field_name.Length == 9))
                return fieldGeneratorMedalType;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorMedalType = new SportsOlympicsMedalJSON.HoldingGenerator("field \"MedalType\" of the SportsOlympicsMedalStandingsArgumentMedalType class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsOlympicsMedalStandingsArgumentMedalType class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorMedalType = new SportsOlympicsMedalJSON.HoldingGenerator("field \"MedalType\" of the SportsOlympicsMedalStandingsArgumentMedalType class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsOlympicsMedalStandingsArgumentMedalType class");
          }

        public override void reset()
          {
            fieldGeneratorMedalType.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsOlympicsMedalStandingsArgumentMedalTypeJSON  result)
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
        public SportsOlympicsMedalStandingsArgumentMedalTypeJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsOlympicsMedalStandingsArgumentMedalTypeJSON  result)
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
    protected virtual void handle_result(List<SportsOlympicsMedalStandingsArgumentMedalTypeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsOlympicsMedalStandingsArgumentMedalTypeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsOlympicsMedalStandingsArgumentMedalTypeJSON>();
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
    public List<SportsOlympicsMedalStandingsArgumentMedalTypeJSON> value;
  };
  };
