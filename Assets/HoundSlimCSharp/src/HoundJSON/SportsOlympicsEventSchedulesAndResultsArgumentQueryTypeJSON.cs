/* file "SportsOlympicsEventSchedulesAndResultsArgumentQueryTypeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsOlympicsEventSchedulesAndResultsArgumentQueryTypeJSON : SportsOlympicsEventSchedulesAndResultsArgumentJSON
  {
    private bool flagHasType;
    private SportsOlympicsEventSchedulesAndResultsQueryTypeJSON  storeType;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraTypeToJSON()
      {
        JSONValueHandler handler_Type = new JSONValueHandler();
        storeType.write_as_json(handler_Type);
        return handler_Type.result;
      }


    private void  fromJSONType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsOlympicsEventSchedulesAndResultsQueryTypeJSON convert_classy = SportsOlympicsEventSchedulesAndResultsQueryTypeJSON.from_json(json_value, ignore_extras, true);
        setType(convert_classy);
      }


    public SportsOlympicsEventSchedulesAndResultsArgumentQueryTypeJSON()
      {
        flagHasType = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getSportsOlympicsEventSchedulesAndResultsArgumentKind()
      {
        return "QueryType";
      }

    public bool  hasType()
      {
        return flagHasType;
      }

    public SportsOlympicsEventSchedulesAndResultsQueryTypeJSON   getType()
      {
        Debug.Assert(flagHasType);
        return storeType;
      }

    public SportsOlympicsEventSchedulesAndResultsQueryTypeJSON.TypeValue  getTypeValue()
      {
        return getType().getValue();
      }

    public string  getTypeAsString()
      {
        return getType().getValueAsString();
      }


    public virtual int extraSportsOlympicsEventSchedulesAndResultsArgumentQueryTypeComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsOlympicsEventSchedulesAndResultsArgumentQueryTypeComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsOlympicsEventSchedulesAndResultsArgumentQueryTypeComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsOlympicsEventSchedulesAndResultsArgumentQueryTypeLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSportsOlympicsEventSchedulesAndResultsArgumentComponentCount()
      {
        int result = 0;
        if (flagHasType)
            ++result;
        result += extraSportsOlympicsEventSchedulesAndResultsArgumentQueryTypeComponentCount();
        return result;
      }
    public override string extraSportsOlympicsEventSchedulesAndResultsArgumentComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasType)
          {
            if (remainder == 0)
                return "Type";
            --remainder;
          }
        return extraSportsOlympicsEventSchedulesAndResultsArgumentQueryTypeComponentKey(remainder);
      }
    public override JSONValue extraSportsOlympicsEventSchedulesAndResultsArgumentComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasType)
          {
            if (remainder == 0)
                return extraTypeToJSON();
            --remainder;
          }
        return extraSportsOlympicsEventSchedulesAndResultsArgumentQueryTypeComponentValue(remainder);
      }
    public override JSONValue extraSportsOlympicsEventSchedulesAndResultsArgumentLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Type", 0, 4, false) == 0) && (field_name.Length == 4))
            return (flagHasType ? extraTypeToJSON() : null);
        return extraSportsOlympicsEventSchedulesAndResultsArgumentQueryTypeLookup(field_name);
      }

    public void setType(SportsOlympicsEventSchedulesAndResultsQueryTypeJSON  new_value)
      {
        if (flagHasType)
          {
          }
        flagHasType = true;
        storeType = new_value;
      }
    public void setType(SportsOlympicsEventSchedulesAndResultsQueryTypeJSON.TypeValue new_value)
      {
        setType(new SportsOlympicsEventSchedulesAndResultsQueryTypeJSON(new_value));
      }
    public void setType(string chars)
      {
        SportsOlympicsEventSchedulesAndResultsQueryTypeJSON.TypeValueKnownValues known = SportsOlympicsEventSchedulesAndResultsQueryTypeJSON.stringToValue(chars);
        SportsOlympicsEventSchedulesAndResultsQueryTypeJSON.TypeValue new_value = new SportsOlympicsEventSchedulesAndResultsQueryTypeJSON.TypeValue();
        if (known == SportsOlympicsEventSchedulesAndResultsQueryTypeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setType(new_value);
      }
    public void unsetType()
      {
        if (flagHasType)
          {
          }
        flagHasType = false;
      }

    public virtual void extraSportsOlympicsEventSchedulesAndResultsArgumentQueryTypeAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsOlympicsEventSchedulesAndResultsArgumentQueryTypeSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsOlympicsEventSchedulesAndResultsArgumentQueryTypeLookup(key);
        if (old_field == null)
          {
            extraSportsOlympicsEventSchedulesAndResultsArgumentQueryTypeAppendPair(key, new_component);
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
        if ((String.Compare(key, 0, "Type", 0, 4, false) == 0) && (key.Length == 4))
            {
            fromJSONType(new_component, false);
            return;
            }
        extraSportsOlympicsEventSchedulesAndResultsArgumentQueryTypeAppendPair(key, new_component);
      }
    public override void extraSportsOlympicsEventSchedulesAndResultsArgumentSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Type", 0, 4, false) == 0) && (key.Length == 4))
            {
            fromJSONType(new_component, false);
            return;
            }
        extraSportsOlympicsEventSchedulesAndResultsArgumentQueryTypeSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasType);
        if (flagHasType)
          {
            handler.start_pair("Type");
            if (partial_allowed)
                storeType.write_partial_as_json(handler);
            else
                storeType.write_as_json(handler);
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
        if (!(hasType()))
          {
            return "When parsing the object for %what%, the \"Type\" field was missing.";
          }
        return null;
      }

    public static new SportsOlympicsEventSchedulesAndResultsArgumentQueryTypeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsEventSchedulesAndResultsArgumentQueryTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsArgumentQueryType", ignore_extras);
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
    public static new SportsOlympicsEventSchedulesAndResultsArgumentQueryTypeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsOlympicsEventSchedulesAndResultsArgumentQueryTypeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsEventSchedulesAndResultsArgumentQueryTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsArgumentQueryType", ignore_extras);
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
    public static new SportsOlympicsEventSchedulesAndResultsArgumentQueryTypeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsOlympicsEventSchedulesAndResultsArgumentQueryTypeJSON from_text(string text, bool ignore_extras)
      {
        SportsOlympicsEventSchedulesAndResultsArgumentQueryTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsArgumentQueryType", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsOlympicsEventSchedulesAndResultsArgumentQueryTypeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SportsOlympicsEventSchedulesAndResultsArgumentQueryTypeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsOlympicsEventSchedulesAndResultsArgumentQueryTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsArgumentQueryType", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SportsOlympicsEventSchedulesAndResultsArgumentJSON.Generator
      {
        private SportsOlympicsEventSchedulesAndResultsQueryTypeJSON.HoldingGenerator fieldGeneratorType;
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
            if (!(getSportsOlympicsEventSchedulesAndResultsArgumentJSONKey().Equals("QueryType")))
                throw new Exception("The key field has a value other than `QueryType'.");
            SportsOlympicsEventSchedulesAndResultsArgumentQueryTypeJSON result = new SportsOlympicsEventSchedulesAndResultsArgumentQueryTypeJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsOlympicsEventSchedulesAndResultsArgumentQueryTypeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SportsOlympicsEventSchedulesAndResultsArgumentJSON new_result)
          {
            handle_result((SportsOlympicsEventSchedulesAndResultsArgumentQueryTypeJSON )new_result);
          }
        protected void finish(SportsOlympicsEventSchedulesAndResultsArgumentQueryTypeJSON result)
          {
            if (fieldGeneratorType.have_value)
              {
                result.setType(fieldGeneratorType.value);
                fieldGeneratorType.have_value = false;
              }
            else if ((!(result.hasType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Type\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(SportsOlympicsEventSchedulesAndResultsArgumentQueryTypeJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Type", 0, 4, false) == 0) && (field_name.Length == 4))
                return fieldGeneratorType;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorType = new SportsOlympicsEventSchedulesAndResultsQueryTypeJSON.HoldingGenerator("field \"Type\" of the SportsOlympicsEventSchedulesAndResultsArgumentQueryType class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsOlympicsEventSchedulesAndResultsArgumentQueryType class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorType = new SportsOlympicsEventSchedulesAndResultsQueryTypeJSON.HoldingGenerator("field \"Type\" of the SportsOlympicsEventSchedulesAndResultsArgumentQueryType class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsOlympicsEventSchedulesAndResultsArgumentQueryType class");
          }

        public override void reset()
          {
            fieldGeneratorType.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsOlympicsEventSchedulesAndResultsArgumentQueryTypeJSON  result)
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
        public SportsOlympicsEventSchedulesAndResultsArgumentQueryTypeJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsOlympicsEventSchedulesAndResultsArgumentQueryTypeJSON  result)
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
    protected virtual void handle_result(List<SportsOlympicsEventSchedulesAndResultsArgumentQueryTypeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsOlympicsEventSchedulesAndResultsArgumentQueryTypeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsOlympicsEventSchedulesAndResultsArgumentQueryTypeJSON>();
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
    public List<SportsOlympicsEventSchedulesAndResultsArgumentQueryTypeJSON> value;
  };
  };
