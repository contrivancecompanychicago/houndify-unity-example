/* file "SportsOlympicsEventSchedulesAndResultsArgumentEventCategoryJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsOlympicsEventSchedulesAndResultsArgumentEventCategoryJSON : SportsOlympicsEventSchedulesAndResultsArgumentJSON
  {
    private bool flagHasEventCategories;
    private List< SportsOlympicsEventCategoryJSON  > storeEventCategories;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraEventCategoriesToJSON()
      {
        JSONArrayValue generated_array_1_EventCategories = new JSONArrayValue();
        for (int num1 = 0; num1 < storeEventCategories.Count; ++num1)
          {
            JSONValueHandler handler_EventCategories = new JSONValueHandler();
            storeEventCategories[num1].write_as_json(handler_EventCategories);
            generated_array_1_EventCategories.appendComponent(handler_EventCategories.result);
          }
        return generated_array_1_EventCategories;
      }


    private void  fromJSONEventCategories(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field EventCategories of SportsOlympicsEventSchedulesAndResultsArgumentEventCategoryJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field EventCategories of SportsOlympicsEventSchedulesAndResultsArgumentEventCategoryJSON has too few elements.");
        List< SportsOlympicsEventCategoryJSON  > vector_EventCategories1 = new List< SportsOlympicsEventCategoryJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsOlympicsEventCategoryJSON convert_classy = SportsOlympicsEventCategoryJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_EventCategories1.Add(convert_classy);
          }
        Debug.Assert(vector_EventCategories1.Count >= 1);
        initEventCategories();
        for (int num1 = 0; num1 < vector_EventCategories1.Count; ++num1)
            appendEventCategories(vector_EventCategories1[num1]);
        for (int num1 = 0; num1 < vector_EventCategories1.Count; ++num1)
          {
          }
      }


    public SportsOlympicsEventSchedulesAndResultsArgumentEventCategoryJSON()
      {
        flagHasEventCategories = false;
        storeEventCategories = new List< SportsOlympicsEventCategoryJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getSportsOlympicsEventSchedulesAndResultsArgumentKind()
      {
        return "EventCategory";
      }

    public bool  hasEventCategories()
      {
        return flagHasEventCategories;
      }

    public int  countOfEventCategories()
      {
        Debug.Assert(flagHasEventCategories);
        return storeEventCategories.Count;
      }

    public SportsOlympicsEventCategoryJSON   elementOfEventCategories(int element_num)
      {
        Debug.Assert(flagHasEventCategories);
        return storeEventCategories[element_num];
      }

    public List< SportsOlympicsEventCategoryJSON  >  getEventCategories()
      {
        Debug.Assert(flagHasEventCategories);
        return storeEventCategories;
      }


    public virtual int extraSportsOlympicsEventSchedulesAndResultsArgumentEventCategoryComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsOlympicsEventSchedulesAndResultsArgumentEventCategoryComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsOlympicsEventSchedulesAndResultsArgumentEventCategoryComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsOlympicsEventSchedulesAndResultsArgumentEventCategoryLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSportsOlympicsEventSchedulesAndResultsArgumentComponentCount()
      {
        int result = 0;
        if (flagHasEventCategories)
            ++result;
        result += extraSportsOlympicsEventSchedulesAndResultsArgumentEventCategoryComponentCount();
        return result;
      }
    public override string extraSportsOlympicsEventSchedulesAndResultsArgumentComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasEventCategories)
          {
            if (remainder == 0)
                return "EventCategories";
            --remainder;
          }
        return extraSportsOlympicsEventSchedulesAndResultsArgumentEventCategoryComponentKey(remainder);
      }
    public override JSONValue extraSportsOlympicsEventSchedulesAndResultsArgumentComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasEventCategories)
          {
            if (remainder == 0)
                return extraEventCategoriesToJSON();
            --remainder;
          }
        return extraSportsOlympicsEventSchedulesAndResultsArgumentEventCategoryComponentValue(remainder);
      }
    public override JSONValue extraSportsOlympicsEventSchedulesAndResultsArgumentLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "EventCategories", 0, 15, false) == 0) && (field_name.Length == 15))
            return (flagHasEventCategories ? extraEventCategoriesToJSON() : null);
        return extraSportsOlympicsEventSchedulesAndResultsArgumentEventCategoryLookup(field_name);
      }

    public void initEventCategories()
      {
        if (flagHasEventCategories)
          {
            for (int num1 = 0; num1 < storeEventCategories.Count; ++num1)
              {
              }
          }
        flagHasEventCategories = true;
        storeEventCategories.Clear();
      }
    public void appendEventCategories(SportsOlympicsEventCategoryJSON  to_append)
      {
        if (!flagHasEventCategories)
          {
            flagHasEventCategories = true;
            storeEventCategories.Clear();
          }
        Debug.Assert(flagHasEventCategories);
        storeEventCategories.Add(to_append);
      }
    public void appendEventCategories(SportsOlympicsEventCategoryJSON.TypeValue new_value)
      {
        appendEventCategories(new SportsOlympicsEventCategoryJSON(new_value));
      }
    public void appendEventCategories(string chars)
      {
        SportsOlympicsEventCategoryJSON.TypeValueKnownValues known = SportsOlympicsEventCategoryJSON.stringToValue(chars);
        SportsOlympicsEventCategoryJSON.TypeValue new_value = new SportsOlympicsEventCategoryJSON.TypeValue();
        if (known == SportsOlympicsEventCategoryJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendEventCategories(new_value);
      }
    public void unsetEventCategories()
      {
        if (flagHasEventCategories)
          {
            for (int num2 = 0; num2 < storeEventCategories.Count; ++num2)
              {
              }
          }
        flagHasEventCategories = false;
        storeEventCategories.Clear();
      }

    public virtual void extraSportsOlympicsEventSchedulesAndResultsArgumentEventCategoryAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsOlympicsEventSchedulesAndResultsArgumentEventCategorySetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsOlympicsEventSchedulesAndResultsArgumentEventCategoryLookup(key);
        if (old_field == null)
          {
            extraSportsOlympicsEventSchedulesAndResultsArgumentEventCategoryAppendPair(key, new_component);
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
        if ((String.Compare(key, 0, "EventCategories", 0, 15, false) == 0) && (key.Length == 15))
            {
            fromJSONEventCategories(new_component, false);
            return;
            }
        extraSportsOlympicsEventSchedulesAndResultsArgumentEventCategoryAppendPair(key, new_component);
      }
    public override void extraSportsOlympicsEventSchedulesAndResultsArgumentSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "EventCategories", 0, 15, false) == 0) && (key.Length == 15))
            {
            fromJSONEventCategories(new_component, false);
            return;
            }
        extraSportsOlympicsEventSchedulesAndResultsArgumentEventCategorySetField(key, new_component);
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
        if (flagHasEventCategories)
          {
            handler.start_pair("EventCategories");
            Debug.Assert(storeEventCategories.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeEventCategories.Count; ++num1)
              {
                if (partial_allowed)
                    storeEventCategories[num1].write_partial_as_json(handler);
                else
                    storeEventCategories[num1].write_as_json(handler);
              }
            handler.finish_array();
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

    public static new SportsOlympicsEventSchedulesAndResultsArgumentEventCategoryJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsEventSchedulesAndResultsArgumentEventCategoryJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsArgumentEventCategory", ignore_extras);
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
    public static new SportsOlympicsEventSchedulesAndResultsArgumentEventCategoryJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsOlympicsEventSchedulesAndResultsArgumentEventCategoryJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsEventSchedulesAndResultsArgumentEventCategoryJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsArgumentEventCategory", ignore_extras);
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
    public static new SportsOlympicsEventSchedulesAndResultsArgumentEventCategoryJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsOlympicsEventSchedulesAndResultsArgumentEventCategoryJSON from_text(string text, bool ignore_extras)
      {
        SportsOlympicsEventSchedulesAndResultsArgumentEventCategoryJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsArgumentEventCategory", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsOlympicsEventSchedulesAndResultsArgumentEventCategoryJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SportsOlympicsEventSchedulesAndResultsArgumentEventCategoryJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsOlympicsEventSchedulesAndResultsArgumentEventCategoryJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsArgumentEventCategory", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SportsOlympicsEventSchedulesAndResultsArgumentJSON.Generator
      {
        private SportsOlympicsEventCategoryJSON.HoldingArrayGenerator fieldGeneratorEventCategories;
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
            if (!(getSportsOlympicsEventSchedulesAndResultsArgumentJSONKey().Equals("EventCategory")))
                throw new Exception("The key field has a value other than `EventCategory'.");
            SportsOlympicsEventSchedulesAndResultsArgumentEventCategoryJSON result = new SportsOlympicsEventSchedulesAndResultsArgumentEventCategoryJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsOlympicsEventSchedulesAndResultsArgumentEventCategoryAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SportsOlympicsEventSchedulesAndResultsArgumentJSON new_result)
          {
            handle_result((SportsOlympicsEventSchedulesAndResultsArgumentEventCategoryJSON )new_result);
          }
        protected void finish(SportsOlympicsEventSchedulesAndResultsArgumentEventCategoryJSON result)
          {
            if (fieldGeneratorEventCategories.have_value)
              {
                result.initEventCategories();
                int count = fieldGeneratorEventCategories.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendEventCategories(fieldGeneratorEventCategories.value[num]);
                  }
                fieldGeneratorEventCategories.value.Clear();
                fieldGeneratorEventCategories.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(SportsOlympicsEventSchedulesAndResultsArgumentEventCategoryJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "EventCategories", 0, 15, false) == 0) && (field_name.Length == 15))
                return fieldGeneratorEventCategories;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorEventCategories = new SportsOlympicsEventCategoryJSON.HoldingArrayGenerator("field \"EventCategories\" of the SportsOlympicsEventSchedulesAndResultsArgumentEventCategory class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsOlympicsEventSchedulesAndResultsArgumentEventCategory class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorEventCategories = new SportsOlympicsEventCategoryJSON.HoldingArrayGenerator("field \"EventCategories\" of the SportsOlympicsEventSchedulesAndResultsArgumentEventCategory class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsOlympicsEventSchedulesAndResultsArgumentEventCategory class");
          }

        public override void reset()
          {
            fieldGeneratorEventCategories.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsOlympicsEventSchedulesAndResultsArgumentEventCategoryJSON  result)
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
        public SportsOlympicsEventSchedulesAndResultsArgumentEventCategoryJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsOlympicsEventSchedulesAndResultsArgumentEventCategoryJSON  result)
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
    protected virtual void handle_result(List<SportsOlympicsEventSchedulesAndResultsArgumentEventCategoryJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsOlympicsEventSchedulesAndResultsArgumentEventCategoryJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsOlympicsEventSchedulesAndResultsArgumentEventCategoryJSON>();
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
    public List<SportsOlympicsEventSchedulesAndResultsArgumentEventCategoryJSON> value;
  };
  };
