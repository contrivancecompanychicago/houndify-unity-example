/* file "SportsOlympicsBasicAttributeArgumentSeasonJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsOlympicsBasicAttributeArgumentSeasonJSON : SportsOlympicsBasicAttributeArgumentJSON
  {
    private bool flagHasSeason;
    private SportsOlympicsSeasonJSON  storeSeason;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraSeasonToJSON()
      {
        JSONValueHandler handler_Season = new JSONValueHandler();
        storeSeason.write_as_json(handler_Season);
        return handler_Season.result;
      }


    private void  fromJSONSeason(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsOlympicsSeasonJSON convert_classy = SportsOlympicsSeasonJSON.from_json(json_value, ignore_extras, true);
        setSeason(convert_classy);
      }


    public SportsOlympicsBasicAttributeArgumentSeasonJSON()
      {
        flagHasSeason = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getSportsOlympicsBasicAttributeArgumentKind()
      {
        return "Season";
      }

    public bool  hasSeason()
      {
        return flagHasSeason;
      }

    public SportsOlympicsSeasonJSON   getSeason()
      {
        Debug.Assert(flagHasSeason);
        return storeSeason;
      }

    public SportsOlympicsSeasonJSON.TypeValue  getSeasonValue()
      {
        return getSeason().getValue();
      }

    public string  getSeasonAsString()
      {
        return getSeason().getValueAsString();
      }


    public virtual int extraSportsOlympicsBasicAttributeArgumentSeasonComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsOlympicsBasicAttributeArgumentSeasonComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsOlympicsBasicAttributeArgumentSeasonComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsOlympicsBasicAttributeArgumentSeasonLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSportsOlympicsBasicAttributeArgumentComponentCount()
      {
        int result = 0;
        if (flagHasSeason)
            ++result;
        result += extraSportsOlympicsBasicAttributeArgumentSeasonComponentCount();
        return result;
      }
    public override string extraSportsOlympicsBasicAttributeArgumentComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasSeason)
          {
            if (remainder == 0)
                return "Season";
            --remainder;
          }
        return extraSportsOlympicsBasicAttributeArgumentSeasonComponentKey(remainder);
      }
    public override JSONValue extraSportsOlympicsBasicAttributeArgumentComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasSeason)
          {
            if (remainder == 0)
                return extraSeasonToJSON();
            --remainder;
          }
        return extraSportsOlympicsBasicAttributeArgumentSeasonComponentValue(remainder);
      }
    public override JSONValue extraSportsOlympicsBasicAttributeArgumentLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Season", 0, 6, false) == 0) && (field_name.Length == 6))
            return (flagHasSeason ? extraSeasonToJSON() : null);
        return extraSportsOlympicsBasicAttributeArgumentSeasonLookup(field_name);
      }

    public void setSeason(SportsOlympicsSeasonJSON  new_value)
      {
        if (flagHasSeason)
          {
          }
        flagHasSeason = true;
        storeSeason = new_value;
      }
    public void setSeason(SportsOlympicsSeasonJSON.TypeValue new_value)
      {
        setSeason(new SportsOlympicsSeasonJSON(new_value));
      }
    public void setSeason(string chars)
      {
        SportsOlympicsSeasonJSON.TypeValueKnownValues known = SportsOlympicsSeasonJSON.stringToValue(chars);
        SportsOlympicsSeasonJSON.TypeValue new_value = new SportsOlympicsSeasonJSON.TypeValue();
        if (known == SportsOlympicsSeasonJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setSeason(new_value);
      }
    public void unsetSeason()
      {
        if (flagHasSeason)
          {
          }
        flagHasSeason = false;
      }

    public virtual void extraSportsOlympicsBasicAttributeArgumentSeasonAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsOlympicsBasicAttributeArgumentSeasonSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsOlympicsBasicAttributeArgumentSeasonLookup(key);
        if (old_field == null)
          {
            extraSportsOlympicsBasicAttributeArgumentSeasonAppendPair(key, new_component);
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
    public override void extraSportsOlympicsBasicAttributeArgumentAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Season", 0, 6, false) == 0) && (key.Length == 6))
            {
            fromJSONSeason(new_component, false);
            return;
            }
        extraSportsOlympicsBasicAttributeArgumentSeasonAppendPair(key, new_component);
      }
    public override void extraSportsOlympicsBasicAttributeArgumentSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Season", 0, 6, false) == 0) && (key.Length == 6))
            {
            fromJSONSeason(new_component, false);
            return;
            }
        extraSportsOlympicsBasicAttributeArgumentSeasonSetField(key, new_component);
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
        if (flagHasSeason)
          {
            handler.start_pair("Season");
            if (partial_allowed)
                storeSeason.write_partial_as_json(handler);
            else
                storeSeason.write_as_json(handler);
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

    public static new SportsOlympicsBasicAttributeArgumentSeasonJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsBasicAttributeArgumentSeasonJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsBasicAttributeArgumentSeason", ignore_extras);
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
    public static new SportsOlympicsBasicAttributeArgumentSeasonJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsOlympicsBasicAttributeArgumentSeasonJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsBasicAttributeArgumentSeasonJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsBasicAttributeArgumentSeason", ignore_extras);
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
    public static new SportsOlympicsBasicAttributeArgumentSeasonJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsOlympicsBasicAttributeArgumentSeasonJSON from_text(string text, bool ignore_extras)
      {
        SportsOlympicsBasicAttributeArgumentSeasonJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsBasicAttributeArgumentSeason", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsOlympicsBasicAttributeArgumentSeasonJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SportsOlympicsBasicAttributeArgumentSeasonJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsOlympicsBasicAttributeArgumentSeasonJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsBasicAttributeArgumentSeason", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SportsOlympicsBasicAttributeArgumentJSON.Generator
      {
        private SportsOlympicsSeasonJSON.HoldingGenerator fieldGeneratorSeason;
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
            if (!(getSportsOlympicsBasicAttributeArgumentJSONKey().Equals("Season")))
                throw new Exception("The key field has a value other than `Season'.");
            SportsOlympicsBasicAttributeArgumentSeasonJSON result = new SportsOlympicsBasicAttributeArgumentSeasonJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsOlympicsBasicAttributeArgumentSeasonAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SportsOlympicsBasicAttributeArgumentJSON new_result)
          {
            handle_result((SportsOlympicsBasicAttributeArgumentSeasonJSON )new_result);
          }
        protected void finish(SportsOlympicsBasicAttributeArgumentSeasonJSON result)
          {
            if (fieldGeneratorSeason.have_value)
              {
                result.setSeason(fieldGeneratorSeason.value);
                fieldGeneratorSeason.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(SportsOlympicsBasicAttributeArgumentSeasonJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Season", 0, 6, false) == 0) && (field_name.Length == 6))
                return fieldGeneratorSeason;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorSeason = new SportsOlympicsSeasonJSON.HoldingGenerator("field \"Season\" of the SportsOlympicsBasicAttributeArgumentSeason class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsOlympicsBasicAttributeArgumentSeason class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorSeason = new SportsOlympicsSeasonJSON.HoldingGenerator("field \"Season\" of the SportsOlympicsBasicAttributeArgumentSeason class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsOlympicsBasicAttributeArgumentSeason class");
          }

        public override void reset()
          {
            fieldGeneratorSeason.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsOlympicsBasicAttributeArgumentSeasonJSON  result)
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
        public SportsOlympicsBasicAttributeArgumentSeasonJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsOlympicsBasicAttributeArgumentSeasonJSON  result)
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
    protected virtual void handle_result(List<SportsOlympicsBasicAttributeArgumentSeasonJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsOlympicsBasicAttributeArgumentSeasonJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsOlympicsBasicAttributeArgumentSeasonJSON>();
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
    public List<SportsOlympicsBasicAttributeArgumentSeasonJSON> value;
  };
  };
