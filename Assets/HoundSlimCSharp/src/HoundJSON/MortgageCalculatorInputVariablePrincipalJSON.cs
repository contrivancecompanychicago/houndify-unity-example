/* file "MortgageCalculatorInputVariablePrincipalJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MortgageCalculatorInputVariablePrincipalJSON : MortgageCalculatorInputVariableJSON
  {
    private bool flagHasPrincipal;
    private MoneyJSON  storePrincipal;
    private bool flagHasAmbiguityWithHomeValue;
    private bool storeAmbiguityWithHomeValue;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraPrincipalToJSON()
      {
        JSONValueHandler handler_Principal = new JSONValueHandler();
        storePrincipal.write_as_json(handler_Principal);
        return handler_Principal.result;
      }

    private JSONValue  extraAmbiguityWithHomeValueToJSON()
      {
        JSONValue generated_boolean_AmbiguityWithHomeValue = (storeAmbiguityWithHomeValue ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_AmbiguityWithHomeValue;
      }


    private void  fromJSONPrincipal(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
        setPrincipal(convert_classy);
      }


    private void  fromJSONAmbiguityWithHomeValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field AmbiguityWithHomeValue of MortgageCalculatorInputVariablePrincipalJSON is not true for false.");
              }
          }
        setAmbiguityWithHomeValue(the_bool);
      }


    public MortgageCalculatorInputVariablePrincipalJSON()
      {
        flagHasPrincipal = false;
        flagHasAmbiguityWithHomeValue = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getInputVariableKind()
      {
        return "Principal";
      }

    public bool  hasPrincipal()
      {
        return flagHasPrincipal;
      }

    public MoneyJSON   getPrincipal()
      {
        Debug.Assert(flagHasPrincipal);
        return storePrincipal;
      }

    public bool  hasAmbiguityWithHomeValue()
      {
        return flagHasAmbiguityWithHomeValue;
      }

    public bool  getAmbiguityWithHomeValue()
      {
        Debug.Assert(flagHasAmbiguityWithHomeValue);
        return storeAmbiguityWithHomeValue;
      }


    public virtual int extraMortgageCalculatorInputVariablePrincipalComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMortgageCalculatorInputVariablePrincipalComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMortgageCalculatorInputVariablePrincipalComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMortgageCalculatorInputVariablePrincipalLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraMortgageCalculatorInputVariableComponentCount()
      {
        int result = 0;
        if (flagHasPrincipal)
            ++result;
        if (flagHasAmbiguityWithHomeValue)
            ++result;
        result += extraMortgageCalculatorInputVariablePrincipalComponentCount();
        return result;
      }
    public override string extraMortgageCalculatorInputVariableComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasPrincipal)
          {
            if (remainder == 0)
                return "Principal";
            --remainder;
          }
        if (flagHasAmbiguityWithHomeValue)
          {
            if (remainder == 0)
                return "AmbiguityWithHomeValue";
            --remainder;
          }
        return extraMortgageCalculatorInputVariablePrincipalComponentKey(remainder);
      }
    public override JSONValue extraMortgageCalculatorInputVariableComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasPrincipal)
          {
            if (remainder == 0)
                return extraPrincipalToJSON();
            --remainder;
          }
        if (flagHasAmbiguityWithHomeValue)
          {
            if (remainder == 0)
                return extraAmbiguityWithHomeValueToJSON();
            --remainder;
          }
        return extraMortgageCalculatorInputVariablePrincipalComponentValue(remainder);
      }
    public override JSONValue extraMortgageCalculatorInputVariableLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "mbiguityWithHomeValue", 0, 21, false) == 0) && (field_name.Length == 22))
                    return (flagHasAmbiguityWithHomeValue ? extraAmbiguityWithHomeValueToJSON() : null);
                break;
            case 'P':
                if ((String.Compare(field_name, 1, "rincipal", 0, 8, false) == 0) && (field_name.Length == 9))
                    return (flagHasPrincipal ? extraPrincipalToJSON() : null);
                break;
            default:
                break;
          }
        return extraMortgageCalculatorInputVariablePrincipalLookup(field_name);
      }

    public void setPrincipal(MoneyJSON  new_value)
      {
        if (flagHasPrincipal)
          {
          }
        flagHasPrincipal = true;
        storePrincipal = new_value;
      }
    public void unsetPrincipal()
      {
        if (flagHasPrincipal)
          {
          }
        flagHasPrincipal = false;
      }
    public void setAmbiguityWithHomeValue(bool new_value)
      {
        flagHasAmbiguityWithHomeValue = true;
        storeAmbiguityWithHomeValue = new_value;
      }
    public void unsetAmbiguityWithHomeValue()
      {
        flagHasAmbiguityWithHomeValue = false;
      }

    public virtual void extraMortgageCalculatorInputVariablePrincipalAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMortgageCalculatorInputVariablePrincipalSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMortgageCalculatorInputVariablePrincipalLookup(key);
        if (old_field == null)
          {
            extraMortgageCalculatorInputVariablePrincipalAppendPair(key, new_component);
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
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "mbiguityWithHomeValue", 0, 21, false) == 0) && (key.Length == 22))
                    {
                    fromJSONAmbiguityWithHomeValue(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "rincipal", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONPrincipal(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraMortgageCalculatorInputVariablePrincipalAppendPair(key, new_component);
      }
    public override void extraMortgageCalculatorInputVariableSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "mbiguityWithHomeValue", 0, 21, false) == 0) && (key.Length == 22))
                    {
                    fromJSONAmbiguityWithHomeValue(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "rincipal", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONPrincipal(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraMortgageCalculatorInputVariablePrincipalSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasPrincipal);
        if (flagHasPrincipal)
          {
            handler.start_pair("Principal");
            if (partial_allowed)
                storePrincipal.write_partial_as_json(handler);
            else
                storePrincipal.write_as_json(handler);
          }
        if (flagHasAmbiguityWithHomeValue)
          {
            handler.start_pair("AmbiguityWithHomeValue");
            handler.boolean_value(storeAmbiguityWithHomeValue);
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
        if (!(hasPrincipal()))
          {
            return "When parsing the object for %what%, the \"Principal\" field was missing.";
          }
        return null;
      }

    public static new MortgageCalculatorInputVariablePrincipalJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MortgageCalculatorInputVariablePrincipalJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariablePrincipal", ignore_extras);
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
    public static new MortgageCalculatorInputVariablePrincipalJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MortgageCalculatorInputVariablePrincipalJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MortgageCalculatorInputVariablePrincipalJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariablePrincipal", ignore_extras);
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
    public static new MortgageCalculatorInputVariablePrincipalJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MortgageCalculatorInputVariablePrincipalJSON from_text(string text, bool ignore_extras)
      {
        MortgageCalculatorInputVariablePrincipalJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariablePrincipal", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MortgageCalculatorInputVariablePrincipalJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MortgageCalculatorInputVariablePrincipalJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MortgageCalculatorInputVariablePrincipalJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariablePrincipal", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : MortgageCalculatorInputVariableJSON.Generator
      {
        private MoneyJSON.HoldingGenerator fieldGeneratorPrincipal;
        private JSONHoldingBooleanGenerator fieldGeneratorAmbiguityWithHomeValue;
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
            if (!(getMortgageCalculatorInputVariableJSONKey().Equals("Principal")))
                throw new Exception("The key field has a value other than `Principal'.");
            MortgageCalculatorInputVariablePrincipalJSON result = new MortgageCalculatorInputVariablePrincipalJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMortgageCalculatorInputVariablePrincipalAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(MortgageCalculatorInputVariableJSON new_result)
          {
            handle_result((MortgageCalculatorInputVariablePrincipalJSON )new_result);
          }
        protected void finish(MortgageCalculatorInputVariablePrincipalJSON result)
          {
            if (fieldGeneratorPrincipal.have_value)
              {
                result.setPrincipal(fieldGeneratorPrincipal.value);
                fieldGeneratorPrincipal.have_value = false;
              }
            else if ((!(result.hasPrincipal())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Principal\" field was missing.");
              }
            if (fieldGeneratorAmbiguityWithHomeValue.have_value)
              {
                result.setAmbiguityWithHomeValue(fieldGeneratorAmbiguityWithHomeValue.value);
                fieldGeneratorAmbiguityWithHomeValue.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(MortgageCalculatorInputVariablePrincipalJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "mbiguityWithHomeValue", 0, 21, false) == 0) && (field_name.Length == 22))
                        return fieldGeneratorAmbiguityWithHomeValue;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "rincipal", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorPrincipal;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorPrincipal = new MoneyJSON.HoldingGenerator("field \"Principal\" of the MortgageCalculatorInputVariablePrincipal class", ignore_extras);
            fieldGeneratorAmbiguityWithHomeValue = new JSONHoldingBooleanGenerator("field \"AmbiguityWithHomeValue\" of the MortgageCalculatorInputVariablePrincipal class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MortgageCalculatorInputVariablePrincipal class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorPrincipal = new MoneyJSON.HoldingGenerator("field \"Principal\" of the MortgageCalculatorInputVariablePrincipal class", false);
            fieldGeneratorAmbiguityWithHomeValue = new JSONHoldingBooleanGenerator("field \"AmbiguityWithHomeValue\" of the MortgageCalculatorInputVariablePrincipal class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MortgageCalculatorInputVariablePrincipal class");
          }

        public override void reset()
          {
            fieldGeneratorPrincipal.reset();
            fieldGeneratorAmbiguityWithHomeValue.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MortgageCalculatorInputVariablePrincipalJSON  result)
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
        public MortgageCalculatorInputVariablePrincipalJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MortgageCalculatorInputVariablePrincipalJSON  result)
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
    protected virtual void handle_result(List<MortgageCalculatorInputVariablePrincipalJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MortgageCalculatorInputVariablePrincipalJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MortgageCalculatorInputVariablePrincipalJSON>();
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
    public List<MortgageCalculatorInputVariablePrincipalJSON> value;
  };
  };
