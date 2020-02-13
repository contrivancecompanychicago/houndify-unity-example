/* file "SportsOlympicsBasicAttributeArgumentHostJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsOlympicsBasicAttributeArgumentHostJSON : SportsOlympicsBasicAttributeArgumentJSON
  {
    private bool flagHasHosts;
    private List< SportsOlympicsGamesCodeJSON  > storeHosts;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraHostsToJSON()
      {
        JSONArrayValue generated_array_1_Hosts = new JSONArrayValue();
        for (int num1 = 0; num1 < storeHosts.Count; ++num1)
          {
            JSONValueHandler handler_Hosts = new JSONValueHandler();
            storeHosts[num1].write_as_json(handler_Hosts);
            generated_array_1_Hosts.appendComponent(handler_Hosts.result);
          }
        return generated_array_1_Hosts;
      }


    private void  fromJSONHosts(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Hosts of SportsOlympicsBasicAttributeArgumentHostJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Hosts of SportsOlympicsBasicAttributeArgumentHostJSON has too few elements.");
        List< SportsOlympicsGamesCodeJSON  > vector_Hosts1 = new List< SportsOlympicsGamesCodeJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsOlympicsGamesCodeJSON convert_classy = SportsOlympicsGamesCodeJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Hosts1.Add(convert_classy);
          }
        Debug.Assert(vector_Hosts1.Count >= 1);
        initHosts();
        for (int num1 = 0; num1 < vector_Hosts1.Count; ++num1)
            appendHosts(vector_Hosts1[num1]);
        for (int num1 = 0; num1 < vector_Hosts1.Count; ++num1)
          {
          }
      }


    public SportsOlympicsBasicAttributeArgumentHostJSON()
      {
        flagHasHosts = false;
        storeHosts = new List< SportsOlympicsGamesCodeJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getSportsOlympicsBasicAttributeArgumentKind()
      {
        return "Host";
      }

    public bool  hasHosts()
      {
        return flagHasHosts;
      }

    public int  countOfHosts()
      {
        Debug.Assert(flagHasHosts);
        return storeHosts.Count;
      }

    public SportsOlympicsGamesCodeJSON   elementOfHosts(int element_num)
      {
        Debug.Assert(flagHasHosts);
        return storeHosts[element_num];
      }

    public List< SportsOlympicsGamesCodeJSON  >  getHosts()
      {
        Debug.Assert(flagHasHosts);
        return storeHosts;
      }


    public virtual int extraSportsOlympicsBasicAttributeArgumentHostComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsOlympicsBasicAttributeArgumentHostComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsOlympicsBasicAttributeArgumentHostComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsOlympicsBasicAttributeArgumentHostLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSportsOlympicsBasicAttributeArgumentComponentCount()
      {
        int result = 0;
        if (flagHasHosts)
            ++result;
        result += extraSportsOlympicsBasicAttributeArgumentHostComponentCount();
        return result;
      }
    public override string extraSportsOlympicsBasicAttributeArgumentComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasHosts)
          {
            if (remainder == 0)
                return "Hosts";
            --remainder;
          }
        return extraSportsOlympicsBasicAttributeArgumentHostComponentKey(remainder);
      }
    public override JSONValue extraSportsOlympicsBasicAttributeArgumentComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasHosts)
          {
            if (remainder == 0)
                return extraHostsToJSON();
            --remainder;
          }
        return extraSportsOlympicsBasicAttributeArgumentHostComponentValue(remainder);
      }
    public override JSONValue extraSportsOlympicsBasicAttributeArgumentLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Hosts", 0, 5, false) == 0) && (field_name.Length == 5))
            return (flagHasHosts ? extraHostsToJSON() : null);
        return extraSportsOlympicsBasicAttributeArgumentHostLookup(field_name);
      }

    public void initHosts()
      {
        if (flagHasHosts)
          {
            for (int num1 = 0; num1 < storeHosts.Count; ++num1)
              {
              }
          }
        flagHasHosts = true;
        storeHosts.Clear();
      }
    public void appendHosts(SportsOlympicsGamesCodeJSON  to_append)
      {
        if (!flagHasHosts)
          {
            flagHasHosts = true;
            storeHosts.Clear();
          }
        Debug.Assert(flagHasHosts);
        storeHosts.Add(to_append);
      }
    public void appendHosts(SportsOlympicsGamesCodeJSON.TypeValue new_value)
      {
        appendHosts(new SportsOlympicsGamesCodeJSON(new_value));
      }
    public void appendHosts(string chars)
      {
        SportsOlympicsGamesCodeJSON.TypeValueKnownValues known = SportsOlympicsGamesCodeJSON.stringToValue(chars);
        SportsOlympicsGamesCodeJSON.TypeValue new_value = new SportsOlympicsGamesCodeJSON.TypeValue();
        if (known == SportsOlympicsGamesCodeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendHosts(new_value);
      }
    public void unsetHosts()
      {
        if (flagHasHosts)
          {
            for (int num2 = 0; num2 < storeHosts.Count; ++num2)
              {
              }
          }
        flagHasHosts = false;
        storeHosts.Clear();
      }

    public virtual void extraSportsOlympicsBasicAttributeArgumentHostAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsOlympicsBasicAttributeArgumentHostSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsOlympicsBasicAttributeArgumentHostLookup(key);
        if (old_field == null)
          {
            extraSportsOlympicsBasicAttributeArgumentHostAppendPair(key, new_component);
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
        if ((String.Compare(key, 0, "Hosts", 0, 5, false) == 0) && (key.Length == 5))
            {
            fromJSONHosts(new_component, false);
            return;
            }
        extraSportsOlympicsBasicAttributeArgumentHostAppendPair(key, new_component);
      }
    public override void extraSportsOlympicsBasicAttributeArgumentSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Hosts", 0, 5, false) == 0) && (key.Length == 5))
            {
            fromJSONHosts(new_component, false);
            return;
            }
        extraSportsOlympicsBasicAttributeArgumentHostSetField(key, new_component);
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
        if (flagHasHosts)
          {
            handler.start_pair("Hosts");
            Debug.Assert(storeHosts.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeHosts.Count; ++num1)
              {
                if (partial_allowed)
                    storeHosts[num1].write_partial_as_json(handler);
                else
                    storeHosts[num1].write_as_json(handler);
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

    public static new SportsOlympicsBasicAttributeArgumentHostJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsBasicAttributeArgumentHostJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsBasicAttributeArgumentHost", ignore_extras);
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
    public static new SportsOlympicsBasicAttributeArgumentHostJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsOlympicsBasicAttributeArgumentHostJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsBasicAttributeArgumentHostJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsBasicAttributeArgumentHost", ignore_extras);
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
    public static new SportsOlympicsBasicAttributeArgumentHostJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsOlympicsBasicAttributeArgumentHostJSON from_text(string text, bool ignore_extras)
      {
        SportsOlympicsBasicAttributeArgumentHostJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsBasicAttributeArgumentHost", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsOlympicsBasicAttributeArgumentHostJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SportsOlympicsBasicAttributeArgumentHostJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsOlympicsBasicAttributeArgumentHostJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsBasicAttributeArgumentHost", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SportsOlympicsBasicAttributeArgumentJSON.Generator
      {
        private SportsOlympicsGamesCodeJSON.HoldingArrayGenerator fieldGeneratorHosts;
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
            if (!(getSportsOlympicsBasicAttributeArgumentJSONKey().Equals("Host")))
                throw new Exception("The key field has a value other than `Host'.");
            SportsOlympicsBasicAttributeArgumentHostJSON result = new SportsOlympicsBasicAttributeArgumentHostJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsOlympicsBasicAttributeArgumentHostAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SportsOlympicsBasicAttributeArgumentJSON new_result)
          {
            handle_result((SportsOlympicsBasicAttributeArgumentHostJSON )new_result);
          }
        protected void finish(SportsOlympicsBasicAttributeArgumentHostJSON result)
          {
            if (fieldGeneratorHosts.have_value)
              {
                result.initHosts();
                int count = fieldGeneratorHosts.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendHosts(fieldGeneratorHosts.value[num]);
                  }
                fieldGeneratorHosts.value.Clear();
                fieldGeneratorHosts.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(SportsOlympicsBasicAttributeArgumentHostJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Hosts", 0, 5, false) == 0) && (field_name.Length == 5))
                return fieldGeneratorHosts;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorHosts = new SportsOlympicsGamesCodeJSON.HoldingArrayGenerator("field \"Hosts\" of the SportsOlympicsBasicAttributeArgumentHost class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsOlympicsBasicAttributeArgumentHost class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorHosts = new SportsOlympicsGamesCodeJSON.HoldingArrayGenerator("field \"Hosts\" of the SportsOlympicsBasicAttributeArgumentHost class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsOlympicsBasicAttributeArgumentHost class");
          }

        public override void reset()
          {
            fieldGeneratorHosts.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsOlympicsBasicAttributeArgumentHostJSON  result)
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
        public SportsOlympicsBasicAttributeArgumentHostJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsOlympicsBasicAttributeArgumentHostJSON  result)
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
    protected virtual void handle_result(List<SportsOlympicsBasicAttributeArgumentHostJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsOlympicsBasicAttributeArgumentHostJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsOlympicsBasicAttributeArgumentHostJSON>();
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
    public List<SportsOlympicsBasicAttributeArgumentHostJSON> value;
  };
  };
