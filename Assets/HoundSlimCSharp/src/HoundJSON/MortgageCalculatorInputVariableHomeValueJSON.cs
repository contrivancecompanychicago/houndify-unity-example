/* file "MortgageCalculatorInputVariableHomeValueJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MortgageCalculatorInputVariableHomeValueJSON : MortgageCalculatorInputVariableJSON
  {
    private bool flagHasHomeValue;
    private MoneyJSON  storeHomeValue;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraHomeValueToJSON()
      {
        JSONValueHandler handler_HomeValue = new JSONValueHandler();
        storeHomeValue.write_as_json(handler_HomeValue);
        return handler_HomeValue.result;
      }


    private void  fromJSONHomeValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
        setHomeValue(convert_classy);
      }


    public MortgageCalculatorInputVariableHomeValueJSON()
      {
        flagHasHomeValue = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getInputVariableKind()
      {
        return "HomeValue";
      }

    public bool  hasHomeValue()
      {
        return flagHasHomeValue;
      }

    public MoneyJSON   getHomeValue()
      {
        Debug.Assert(flagHasHomeValue);
        return storeHomeValue;
      }


    public virtual int extraMortgageCalculatorInputVariableHomeValueComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMortgageCalculatorInputVariableHomeValueComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMortgageCalculatorInputVariableHomeValueComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMortgageCalculatorInputVariableHomeValueLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraMortgageCalculatorInputVariableComponentCount()
      {
        int result = 0;
        if (flagHasHomeValue)
            ++result;
        result += extraMortgageCalculatorInputVariableHomeValueComponentCount();
        return result;
      }
    public override string extraMortgageCalculatorInputVariableComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasHomeValue)
          {
            if (remainder == 0)
                return "HomeValue";
            --remainder;
          }
        return extraMortgageCalculatorInputVariableHomeValueComponentKey(remainder);
      }
    public override JSONValue extraMortgageCalculatorInputVariableComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasHomeValue)
          {
            if (remainder == 0)
                return extraHomeValueToJSON();
            --remainder;
          }
        return extraMortgageCalculatorInputVariableHomeValueComponentValue(remainder);
      }
    public override JSONValue extraMortgageCalculatorInputVariableLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "HomeValue", 0, 9, false) == 0) && (field_name.Length == 9))
            return (flagHasHomeValue ? extraHomeValueToJSON() : null);
        return extraMortgageCalculatorInputVariableHomeValueLookup(field_name);
      }

    public void setHomeValue(MoneyJSON  new_value)
      {
        if (flagHasHomeValue)
          {
          }
        flagHasHomeValue = true;
        storeHomeValue = new_value;
      }
    public void unsetHomeValue()
      {
        if (flagHasHomeValue)
          {
          }
        flagHasHomeValue = false;
      }

    public virtual void extraMortgageCalculatorInputVariableHomeValueAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMortgageCalculatorInputVariableHomeValueSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMortgageCalculatorInputVariableHomeValueLookup(key);
        if (old_field == null)
          {
            extraMortgageCalculatorInputVariableHomeValueAppendPair(key, new_component);
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
    public override void extraMortgageCalculatorInputVariableAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "HomeValue", 0, 9, false) == 0) && (key.Length == 9))
            {
            fromJSONHomeValue(new_component, false);
            return;
            }
        extraMortgageCalculatorInputVariableHomeValueAppendPair(key, new_component);
      }
    public override void extraMortgageCalculatorInputVariableSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "HomeValue", 0, 9, false) == 0) && (key.Length == 9))
            {
            fromJSONHomeValue(new_component, false);
            return;
            }
        extraMortgageCalculatorInputVariableHomeValueSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasHomeValue);
        if (flagHasHomeValue)
          {
            handler.start_pair("HomeValue");
            if (partial_allowed)
                storeHomeValue.write_partial_as_json(handler);
            else
                storeHomeValue.write_as_json(handler);
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
        if (!(hasHomeValue()))
          {
            return "When parsing the object for %what%, the \"HomeValue\" field was missing.";
          }
        return null;
      }

    public static new MortgageCalculatorInputVariableHomeValueJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MortgageCalculatorInputVariableHomeValueJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariableHomeValue", ignore_extras);
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
    public static new MortgageCalculatorInputVariableHomeValueJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MortgageCalculatorInputVariableHomeValueJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MortgageCalculatorInputVariableHomeValueJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariableHomeValue", ignore_extras);
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
    public static new MortgageCalculatorInputVariableHomeValueJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MortgageCalculatorInputVariableHomeValueJSON from_text(string text, bool ignore_extras)
      {
        MortgageCalculatorInputVariableHomeValueJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariableHomeValue", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MortgageCalculatorInputVariableHomeValueJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MortgageCalculatorInputVariableHomeValueJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MortgageCalculatorInputVariableHomeValueJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariableHomeValue", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : MortgageCalculatorInputVariableJSON.Generator
      {
        private MoneyJSON.HoldingGenerator fieldGeneratorHomeValue;
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
            if (!(getMortgageCalculatorInputVariableJSONKey().Equals("HomeValue")))
                throw new Exception("The key field has a value other than `HomeValue'.");
            MortgageCalculatorInputVariableHomeValueJSON result = new MortgageCalculatorInputVariableHomeValueJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMortgageCalculatorInputVariableHomeValueAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(MortgageCalculatorInputVariableJSON new_result)
          {
            handle_result((MortgageCalculatorInputVariableHomeValueJSON )new_result);
          }
        protected void finish(MortgageCalculatorInputVariableHomeValueJSON result)
          {
            if (fieldGeneratorHomeValue.have_value)
              {
                result.setHomeValue(fieldGeneratorHomeValue.value);
                fieldGeneratorHomeValue.have_value = false;
              }
            else if ((!(result.hasHomeValue())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"HomeValue\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(MortgageCalculatorInputVariableHomeValueJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "HomeValue", 0, 9, false) == 0) && (field_name.Length == 9))
                return fieldGeneratorHomeValue;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorHomeValue = new MoneyJSON.HoldingGenerator("field \"HomeValue\" of the MortgageCalculatorInputVariableHomeValue class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MortgageCalculatorInputVariableHomeValue class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorHomeValue = new MoneyJSON.HoldingGenerator("field \"HomeValue\" of the MortgageCalculatorInputVariableHomeValue class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MortgageCalculatorInputVariableHomeValue class");
          }

        public override void reset()
          {
            fieldGeneratorHomeValue.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MortgageCalculatorInputVariableHomeValueJSON  result)
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
        public MortgageCalculatorInputVariableHomeValueJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MortgageCalculatorInputVariableHomeValueJSON  result)
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
    protected virtual void handle_result(List<MortgageCalculatorInputVariableHomeValueJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MortgageCalculatorInputVariableHomeValueJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MortgageCalculatorInputVariableHomeValueJSON>();
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
    public List<MortgageCalculatorInputVariableHomeValueJSON> value;
  };
  };
