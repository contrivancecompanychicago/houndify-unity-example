/* file "SportsOlympicsMedalStandingsArgumentOrganizationJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsOlympicsMedalStandingsArgumentOrganizationJSON : SportsOlympicsMedalStandingsArgumentJSON
  {
    private bool flagHasOrganizations;
    private List< string > storeOrganizations;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraOrganizationsToJSON()
      {
        JSONArrayValue generated_array_1_Organizations = new JSONArrayValue();
        for (int num1 = 0; num1 < storeOrganizations.Count; ++num1)
          {
            JSONStringValue generated_string_Organizations = new JSONStringValue(storeOrganizations[num1]);
            generated_array_1_Organizations.appendComponent(generated_string_Organizations);
          }
        return generated_array_1_Organizations;
      }


    private void  fromJSONOrganizations(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Organizations of SportsOlympicsMedalStandingsArgumentOrganizationJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Organizations of SportsOlympicsMedalStandingsArgumentOrganizationJSON has too few elements.");
        List< string > vector_Organizations1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field Organizations of SportsOlympicsMedalStandingsArgumentOrganizationJSON is not a string.");
            vector_Organizations1.Add(json_string.getData());
          }
        Debug.Assert(vector_Organizations1.Count >= 1);
        initOrganizations();
        for (int num1 = 0; num1 < vector_Organizations1.Count; ++num1)
            appendOrganizations(vector_Organizations1[num1]);
        for (int num1 = 0; num1 < vector_Organizations1.Count; ++num1)
          {
          }
      }


    public SportsOlympicsMedalStandingsArgumentOrganizationJSON()
      {
        flagHasOrganizations = false;
        storeOrganizations = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getSportsOlympicsMedalStandingsArgumentKind()
      {
        return "Organization";
      }

    public bool  hasOrganizations()
      {
        return flagHasOrganizations;
      }

    public int  countOfOrganizations()
      {
        Debug.Assert(flagHasOrganizations);
        return storeOrganizations.Count;
      }

    public string  elementOfOrganizations(int element_num)
      {
        Debug.Assert(flagHasOrganizations);
        return storeOrganizations[element_num];
      }

    public List< string >  getOrganizations()
      {
        Debug.Assert(flagHasOrganizations);
        return storeOrganizations;
      }


    public virtual int extraSportsOlympicsMedalStandingsArgumentOrganizationComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsOlympicsMedalStandingsArgumentOrganizationComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsOlympicsMedalStandingsArgumentOrganizationComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsOlympicsMedalStandingsArgumentOrganizationLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSportsOlympicsMedalStandingsArgumentComponentCount()
      {
        int result = 0;
        if (flagHasOrganizations)
            ++result;
        result += extraSportsOlympicsMedalStandingsArgumentOrganizationComponentCount();
        return result;
      }
    public override string extraSportsOlympicsMedalStandingsArgumentComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasOrganizations)
          {
            if (remainder == 0)
                return "Organizations";
            --remainder;
          }
        return extraSportsOlympicsMedalStandingsArgumentOrganizationComponentKey(remainder);
      }
    public override JSONValue extraSportsOlympicsMedalStandingsArgumentComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasOrganizations)
          {
            if (remainder == 0)
                return extraOrganizationsToJSON();
            --remainder;
          }
        return extraSportsOlympicsMedalStandingsArgumentOrganizationComponentValue(remainder);
      }
    public override JSONValue extraSportsOlympicsMedalStandingsArgumentLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Organizations", 0, 13, false) == 0) && (field_name.Length == 13))
            return (flagHasOrganizations ? extraOrganizationsToJSON() : null);
        return extraSportsOlympicsMedalStandingsArgumentOrganizationLookup(field_name);
      }

    public void initOrganizations()
      {
        flagHasOrganizations = true;
        storeOrganizations.Clear();
      }
    public void appendOrganizations(string to_append)
      {
        if (!flagHasOrganizations)
          {
            flagHasOrganizations = true;
            storeOrganizations.Clear();
          }
        Debug.Assert(flagHasOrganizations);
        storeOrganizations.Add(to_append);
      }
    public void unsetOrganizations()
      {
        flagHasOrganizations = false;
        storeOrganizations.Clear();
      }

    public virtual void extraSportsOlympicsMedalStandingsArgumentOrganizationAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsOlympicsMedalStandingsArgumentOrganizationSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsOlympicsMedalStandingsArgumentOrganizationLookup(key);
        if (old_field == null)
          {
            extraSportsOlympicsMedalStandingsArgumentOrganizationAppendPair(key, new_component);
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
        if ((String.Compare(key, 0, "Organizations", 0, 13, false) == 0) && (key.Length == 13))
            {
            fromJSONOrganizations(new_component, false);
            return;
            }
        extraSportsOlympicsMedalStandingsArgumentOrganizationAppendPair(key, new_component);
      }
    public override void extraSportsOlympicsMedalStandingsArgumentSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Organizations", 0, 13, false) == 0) && (key.Length == 13))
            {
            fromJSONOrganizations(new_component, false);
            return;
            }
        extraSportsOlympicsMedalStandingsArgumentOrganizationSetField(key, new_component);
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
        if (flagHasOrganizations)
          {
            handler.start_pair("Organizations");
            Debug.Assert(storeOrganizations.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeOrganizations.Count; ++num1)
              {
                handler.string_value(storeOrganizations[num1]);
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

    public static new SportsOlympicsMedalStandingsArgumentOrganizationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsMedalStandingsArgumentOrganizationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsMedalStandingsArgumentOrganization", ignore_extras);
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
    public static new SportsOlympicsMedalStandingsArgumentOrganizationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsOlympicsMedalStandingsArgumentOrganizationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsMedalStandingsArgumentOrganizationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsMedalStandingsArgumentOrganization", ignore_extras);
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
    public static new SportsOlympicsMedalStandingsArgumentOrganizationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsOlympicsMedalStandingsArgumentOrganizationJSON from_text(string text, bool ignore_extras)
      {
        SportsOlympicsMedalStandingsArgumentOrganizationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsMedalStandingsArgumentOrganization", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsOlympicsMedalStandingsArgumentOrganizationJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SportsOlympicsMedalStandingsArgumentOrganizationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsOlympicsMedalStandingsArgumentOrganizationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsMedalStandingsArgumentOrganization", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SportsOlympicsMedalStandingsArgumentJSON.Generator
      {
        private JSONHoldingStringArrayGenerator fieldGeneratorOrganizations;
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
            if (!(getSportsOlympicsMedalStandingsArgumentJSONKey().Equals("Organization")))
                throw new Exception("The key field has a value other than `Organization'.");
            SportsOlympicsMedalStandingsArgumentOrganizationJSON result = new SportsOlympicsMedalStandingsArgumentOrganizationJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsOlympicsMedalStandingsArgumentOrganizationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SportsOlympicsMedalStandingsArgumentJSON new_result)
          {
            handle_result((SportsOlympicsMedalStandingsArgumentOrganizationJSON )new_result);
          }
        protected void finish(SportsOlympicsMedalStandingsArgumentOrganizationJSON result)
          {
            if (fieldGeneratorOrganizations.have_value)
              {
                result.initOrganizations();
                int count = fieldGeneratorOrganizations.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendOrganizations(fieldGeneratorOrganizations.value[num]);
                  }
                fieldGeneratorOrganizations.value.Clear();
                fieldGeneratorOrganizations.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(SportsOlympicsMedalStandingsArgumentOrganizationJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Organizations", 0, 13, false) == 0) && (field_name.Length == 13))
                return fieldGeneratorOrganizations;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorOrganizations = new JSONHoldingStringArrayGenerator("field \"Organizations\" of the SportsOlympicsMedalStandingsArgumentOrganization class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsOlympicsMedalStandingsArgumentOrganization class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorOrganizations = new JSONHoldingStringArrayGenerator("field \"Organizations\" of the SportsOlympicsMedalStandingsArgumentOrganization class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsOlympicsMedalStandingsArgumentOrganization class");
          }

        public override void reset()
          {
            fieldGeneratorOrganizations.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsOlympicsMedalStandingsArgumentOrganizationJSON  result)
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
        public SportsOlympicsMedalStandingsArgumentOrganizationJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsOlympicsMedalStandingsArgumentOrganizationJSON  result)
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
    protected virtual void handle_result(List<SportsOlympicsMedalStandingsArgumentOrganizationJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsOlympicsMedalStandingsArgumentOrganizationJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsOlympicsMedalStandingsArgumentOrganizationJSON>();
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
    public List<SportsOlympicsMedalStandingsArgumentOrganizationJSON> value;
  };
  };
