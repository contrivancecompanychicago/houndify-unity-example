/* file "SportsOlympicsMedalStandingsArgumentSortMethodJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsOlympicsMedalStandingsArgumentSortMethodJSON : SportsOlympicsMedalStandingsArgumentJSON
  {
    private bool flagHasSortMethod;
    private SportsOlympicsMedalStandingsSortMethodJSON  storeSortMethod;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraSortMethodToJSON()
      {
        JSONValueHandler handler_SortMethod = new JSONValueHandler();
        storeSortMethod.write_as_json(handler_SortMethod);
        return handler_SortMethod.result;
      }


    private void  fromJSONSortMethod(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsOlympicsMedalStandingsSortMethodJSON convert_classy = SportsOlympicsMedalStandingsSortMethodJSON.from_json(json_value, ignore_extras, true);
        setSortMethod(convert_classy);
      }


    public SportsOlympicsMedalStandingsArgumentSortMethodJSON()
      {
        flagHasSortMethod = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getSportsOlympicsMedalStandingsArgumentKind()
      {
        return "SortMethod";
      }

    public bool  hasSortMethod()
      {
        return flagHasSortMethod;
      }

    public SportsOlympicsMedalStandingsSortMethodJSON   getSortMethod()
      {
        Debug.Assert(flagHasSortMethod);
        return storeSortMethod;
      }

    public SportsOlympicsMedalStandingsSortMethodJSON.TypeValue  getSortMethodValue()
      {
        return getSortMethod().getValue();
      }

    public string  getSortMethodAsString()
      {
        return getSortMethod().getValueAsString();
      }


    public virtual int extraSportsOlympicsMedalStandingsArgumentSortMethodComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsOlympicsMedalStandingsArgumentSortMethodComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsOlympicsMedalStandingsArgumentSortMethodComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsOlympicsMedalStandingsArgumentSortMethodLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSportsOlympicsMedalStandingsArgumentComponentCount()
      {
        int result = 0;
        if (flagHasSortMethod)
            ++result;
        result += extraSportsOlympicsMedalStandingsArgumentSortMethodComponentCount();
        return result;
      }
    public override string extraSportsOlympicsMedalStandingsArgumentComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasSortMethod)
          {
            if (remainder == 0)
                return "SortMethod";
            --remainder;
          }
        return extraSportsOlympicsMedalStandingsArgumentSortMethodComponentKey(remainder);
      }
    public override JSONValue extraSportsOlympicsMedalStandingsArgumentComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasSortMethod)
          {
            if (remainder == 0)
                return extraSortMethodToJSON();
            --remainder;
          }
        return extraSportsOlympicsMedalStandingsArgumentSortMethodComponentValue(remainder);
      }
    public override JSONValue extraSportsOlympicsMedalStandingsArgumentLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "SortMethod", 0, 10, false) == 0) && (field_name.Length == 10))
            return (flagHasSortMethod ? extraSortMethodToJSON() : null);
        return extraSportsOlympicsMedalStandingsArgumentSortMethodLookup(field_name);
      }

    public void setSortMethod(SportsOlympicsMedalStandingsSortMethodJSON  new_value)
      {
        if (flagHasSortMethod)
          {
          }
        flagHasSortMethod = true;
        storeSortMethod = new_value;
      }
    public void setSortMethod(SportsOlympicsMedalStandingsSortMethodJSON.TypeValue new_value)
      {
        setSortMethod(new SportsOlympicsMedalStandingsSortMethodJSON(new_value));
      }
    public void setSortMethod(string chars)
      {
        SportsOlympicsMedalStandingsSortMethodJSON.TypeValueKnownValues known = SportsOlympicsMedalStandingsSortMethodJSON.stringToValue(chars);
        SportsOlympicsMedalStandingsSortMethodJSON.TypeValue new_value = new SportsOlympicsMedalStandingsSortMethodJSON.TypeValue();
        if (known == SportsOlympicsMedalStandingsSortMethodJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setSortMethod(new_value);
      }
    public void unsetSortMethod()
      {
        if (flagHasSortMethod)
          {
          }
        flagHasSortMethod = false;
      }

    public virtual void extraSportsOlympicsMedalStandingsArgumentSortMethodAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsOlympicsMedalStandingsArgumentSortMethodSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsOlympicsMedalStandingsArgumentSortMethodLookup(key);
        if (old_field == null)
          {
            extraSportsOlympicsMedalStandingsArgumentSortMethodAppendPair(key, new_component);
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
        if ((String.Compare(key, 0, "SortMethod", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONSortMethod(new_component, false);
            return;
            }
        extraSportsOlympicsMedalStandingsArgumentSortMethodAppendPair(key, new_component);
      }
    public override void extraSportsOlympicsMedalStandingsArgumentSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "SortMethod", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONSortMethod(new_component, false);
            return;
            }
        extraSportsOlympicsMedalStandingsArgumentSortMethodSetField(key, new_component);
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
        if (flagHasSortMethod)
          {
            handler.start_pair("SortMethod");
            if (partial_allowed)
                storeSortMethod.write_partial_as_json(handler);
            else
                storeSortMethod.write_as_json(handler);
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

    public static new SportsOlympicsMedalStandingsArgumentSortMethodJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsMedalStandingsArgumentSortMethodJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsMedalStandingsArgumentSortMethod", ignore_extras);
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
    public static new SportsOlympicsMedalStandingsArgumentSortMethodJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsOlympicsMedalStandingsArgumentSortMethodJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsMedalStandingsArgumentSortMethodJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsMedalStandingsArgumentSortMethod", ignore_extras);
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
    public static new SportsOlympicsMedalStandingsArgumentSortMethodJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsOlympicsMedalStandingsArgumentSortMethodJSON from_text(string text, bool ignore_extras)
      {
        SportsOlympicsMedalStandingsArgumentSortMethodJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsMedalStandingsArgumentSortMethod", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsOlympicsMedalStandingsArgumentSortMethodJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SportsOlympicsMedalStandingsArgumentSortMethodJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsOlympicsMedalStandingsArgumentSortMethodJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsMedalStandingsArgumentSortMethod", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SportsOlympicsMedalStandingsArgumentJSON.Generator
      {
        private SportsOlympicsMedalStandingsSortMethodJSON.HoldingGenerator fieldGeneratorSortMethod;
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
            if (!(getSportsOlympicsMedalStandingsArgumentJSONKey().Equals("SortMethod")))
                throw new Exception("The key field has a value other than `SortMethod'.");
            SportsOlympicsMedalStandingsArgumentSortMethodJSON result = new SportsOlympicsMedalStandingsArgumentSortMethodJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsOlympicsMedalStandingsArgumentSortMethodAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SportsOlympicsMedalStandingsArgumentJSON new_result)
          {
            handle_result((SportsOlympicsMedalStandingsArgumentSortMethodJSON )new_result);
          }
        protected void finish(SportsOlympicsMedalStandingsArgumentSortMethodJSON result)
          {
            if (fieldGeneratorSortMethod.have_value)
              {
                result.setSortMethod(fieldGeneratorSortMethod.value);
                fieldGeneratorSortMethod.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(SportsOlympicsMedalStandingsArgumentSortMethodJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "SortMethod", 0, 10, false) == 0) && (field_name.Length == 10))
                return fieldGeneratorSortMethod;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorSortMethod = new SportsOlympicsMedalStandingsSortMethodJSON.HoldingGenerator("field \"SortMethod\" of the SportsOlympicsMedalStandingsArgumentSortMethod class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsOlympicsMedalStandingsArgumentSortMethod class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorSortMethod = new SportsOlympicsMedalStandingsSortMethodJSON.HoldingGenerator("field \"SortMethod\" of the SportsOlympicsMedalStandingsArgumentSortMethod class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsOlympicsMedalStandingsArgumentSortMethod class");
          }

        public override void reset()
          {
            fieldGeneratorSortMethod.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsOlympicsMedalStandingsArgumentSortMethodJSON  result)
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
        public SportsOlympicsMedalStandingsArgumentSortMethodJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsOlympicsMedalStandingsArgumentSortMethodJSON  result)
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
    protected virtual void handle_result(List<SportsOlympicsMedalStandingsArgumentSortMethodJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsOlympicsMedalStandingsArgumentSortMethodJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsOlympicsMedalStandingsArgumentSortMethodJSON>();
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
    public List<SportsOlympicsMedalStandingsArgumentSortMethodJSON> value;
  };
  };
