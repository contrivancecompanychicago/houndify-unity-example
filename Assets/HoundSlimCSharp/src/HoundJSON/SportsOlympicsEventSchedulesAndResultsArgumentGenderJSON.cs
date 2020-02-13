/* file "SportsOlympicsEventSchedulesAndResultsArgumentGenderJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsOlympicsEventSchedulesAndResultsArgumentGenderJSON : SportsOlympicsEventSchedulesAndResultsArgumentJSON
  {
    private bool flagHasGender;
    private SportsOlympicsGenderJSON  storeGender;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraGenderToJSON()
      {
        JSONValueHandler handler_Gender = new JSONValueHandler();
        storeGender.write_as_json(handler_Gender);
        return handler_Gender.result;
      }


    private void  fromJSONGender(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsOlympicsGenderJSON convert_classy = SportsOlympicsGenderJSON.from_json(json_value, ignore_extras, true);
        setGender(convert_classy);
      }


    public SportsOlympicsEventSchedulesAndResultsArgumentGenderJSON()
      {
        flagHasGender = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getSportsOlympicsEventSchedulesAndResultsArgumentKind()
      {
        return "Gender";
      }

    public bool  hasGender()
      {
        return flagHasGender;
      }

    public SportsOlympicsGenderJSON   getGender()
      {
        Debug.Assert(flagHasGender);
        return storeGender;
      }

    public SportsOlympicsGenderJSON.TypeValue  getGenderValue()
      {
        return getGender().getValue();
      }

    public string  getGenderAsString()
      {
        return getGender().getValueAsString();
      }


    public virtual int extraSportsOlympicsEventSchedulesAndResultsArgumentGenderComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsOlympicsEventSchedulesAndResultsArgumentGenderComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsOlympicsEventSchedulesAndResultsArgumentGenderComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsOlympicsEventSchedulesAndResultsArgumentGenderLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSportsOlympicsEventSchedulesAndResultsArgumentComponentCount()
      {
        int result = 0;
        if (flagHasGender)
            ++result;
        result += extraSportsOlympicsEventSchedulesAndResultsArgumentGenderComponentCount();
        return result;
      }
    public override string extraSportsOlympicsEventSchedulesAndResultsArgumentComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasGender)
          {
            if (remainder == 0)
                return "Gender";
            --remainder;
          }
        return extraSportsOlympicsEventSchedulesAndResultsArgumentGenderComponentKey(remainder);
      }
    public override JSONValue extraSportsOlympicsEventSchedulesAndResultsArgumentComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasGender)
          {
            if (remainder == 0)
                return extraGenderToJSON();
            --remainder;
          }
        return extraSportsOlympicsEventSchedulesAndResultsArgumentGenderComponentValue(remainder);
      }
    public override JSONValue extraSportsOlympicsEventSchedulesAndResultsArgumentLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Gender", 0, 6, false) == 0) && (field_name.Length == 6))
            return (flagHasGender ? extraGenderToJSON() : null);
        return extraSportsOlympicsEventSchedulesAndResultsArgumentGenderLookup(field_name);
      }

    public void setGender(SportsOlympicsGenderJSON  new_value)
      {
        if (flagHasGender)
          {
          }
        flagHasGender = true;
        storeGender = new_value;
      }
    public void setGender(SportsOlympicsGenderJSON.TypeValue new_value)
      {
        setGender(new SportsOlympicsGenderJSON(new_value));
      }
    public void setGender(string chars)
      {
        SportsOlympicsGenderJSON.TypeValueKnownValues known = SportsOlympicsGenderJSON.stringToValue(chars);
        SportsOlympicsGenderJSON.TypeValue new_value = new SportsOlympicsGenderJSON.TypeValue();
        if (known == SportsOlympicsGenderJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setGender(new_value);
      }
    public void unsetGender()
      {
        if (flagHasGender)
          {
          }
        flagHasGender = false;
      }

    public virtual void extraSportsOlympicsEventSchedulesAndResultsArgumentGenderAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsOlympicsEventSchedulesAndResultsArgumentGenderSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsOlympicsEventSchedulesAndResultsArgumentGenderLookup(key);
        if (old_field == null)
          {
            extraSportsOlympicsEventSchedulesAndResultsArgumentGenderAppendPair(key, new_component);
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
    public override void extraSportsOlympicsEventSchedulesAndResultsArgumentAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Gender", 0, 6, false) == 0) && (key.Length == 6))
            {
            fromJSONGender(new_component, false);
            return;
            }
        extraSportsOlympicsEventSchedulesAndResultsArgumentGenderAppendPair(key, new_component);
      }
    public override void extraSportsOlympicsEventSchedulesAndResultsArgumentSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Gender", 0, 6, false) == 0) && (key.Length == 6))
            {
            fromJSONGender(new_component, false);
            return;
            }
        extraSportsOlympicsEventSchedulesAndResultsArgumentGenderSetField(key, new_component);
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
        if (flagHasGender)
          {
            handler.start_pair("Gender");
            if (partial_allowed)
                storeGender.write_partial_as_json(handler);
            else
                storeGender.write_as_json(handler);
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

    public static new SportsOlympicsEventSchedulesAndResultsArgumentGenderJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsEventSchedulesAndResultsArgumentGenderJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsArgumentGender", ignore_extras);
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
    public static new SportsOlympicsEventSchedulesAndResultsArgumentGenderJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsOlympicsEventSchedulesAndResultsArgumentGenderJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsEventSchedulesAndResultsArgumentGenderJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsArgumentGender", ignore_extras);
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
    public static new SportsOlympicsEventSchedulesAndResultsArgumentGenderJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsOlympicsEventSchedulesAndResultsArgumentGenderJSON from_text(string text, bool ignore_extras)
      {
        SportsOlympicsEventSchedulesAndResultsArgumentGenderJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsArgumentGender", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsOlympicsEventSchedulesAndResultsArgumentGenderJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SportsOlympicsEventSchedulesAndResultsArgumentGenderJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsOlympicsEventSchedulesAndResultsArgumentGenderJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsArgumentGender", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SportsOlympicsEventSchedulesAndResultsArgumentJSON.Generator
      {
        private SportsOlympicsGenderJSON.HoldingGenerator fieldGeneratorGender;
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
            if (!(getSportsOlympicsEventSchedulesAndResultsArgumentJSONKey().Equals("Gender")))
                throw new Exception("The key field has a value other than `Gender'.");
            SportsOlympicsEventSchedulesAndResultsArgumentGenderJSON result = new SportsOlympicsEventSchedulesAndResultsArgumentGenderJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsOlympicsEventSchedulesAndResultsArgumentGenderAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SportsOlympicsEventSchedulesAndResultsArgumentJSON new_result)
          {
            handle_result((SportsOlympicsEventSchedulesAndResultsArgumentGenderJSON )new_result);
          }
        protected void finish(SportsOlympicsEventSchedulesAndResultsArgumentGenderJSON result)
          {
            if (fieldGeneratorGender.have_value)
              {
                result.setGender(fieldGeneratorGender.value);
                fieldGeneratorGender.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(SportsOlympicsEventSchedulesAndResultsArgumentGenderJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Gender", 0, 6, false) == 0) && (field_name.Length == 6))
                return fieldGeneratorGender;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorGender = new SportsOlympicsGenderJSON.HoldingGenerator("field \"Gender\" of the SportsOlympicsEventSchedulesAndResultsArgumentGender class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsOlympicsEventSchedulesAndResultsArgumentGender class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorGender = new SportsOlympicsGenderJSON.HoldingGenerator("field \"Gender\" of the SportsOlympicsEventSchedulesAndResultsArgumentGender class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsOlympicsEventSchedulesAndResultsArgumentGender class");
          }

        public override void reset()
          {
            fieldGeneratorGender.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsOlympicsEventSchedulesAndResultsArgumentGenderJSON  result)
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
        public SportsOlympicsEventSchedulesAndResultsArgumentGenderJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsOlympicsEventSchedulesAndResultsArgumentGenderJSON  result)
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
    protected virtual void handle_result(List<SportsOlympicsEventSchedulesAndResultsArgumentGenderJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsOlympicsEventSchedulesAndResultsArgumentGenderJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsOlympicsEventSchedulesAndResultsArgumentGenderJSON>();
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
    public List<SportsOlympicsEventSchedulesAndResultsArgumentGenderJSON> value;
  };
  };
