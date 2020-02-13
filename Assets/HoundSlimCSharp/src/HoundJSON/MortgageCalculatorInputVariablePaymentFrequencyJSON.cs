/* file "MortgageCalculatorInputVariablePaymentFrequencyJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MortgageCalculatorInputVariablePaymentFrequencyJSON : MortgageCalculatorInputVariableJSON
  {
    public enum TypePaymentFrequencyKnownValues
      {
        PaymentFrequency_Monthly,
        PaymentFrequency_BiWeekly,
        PaymentFrequency_Weekly,
        PaymentFrequency__none
      };
    public struct TypePaymentFrequency
      {
        public bool in_known_list;
        public string string_value;
        public TypePaymentFrequencyKnownValues list_value;
      };

    public static TypePaymentFrequencyKnownValues  stringToPaymentFrequency(string chars)
      {
        switch (chars[0])
          {
            case 'B':
                if ((String.Compare(chars, 1, "iWeekly", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypePaymentFrequencyKnownValues.PaymentFrequency_BiWeekly;
                break;
            case 'M':
                if ((String.Compare(chars, 1, "onthly", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypePaymentFrequencyKnownValues.PaymentFrequency_Monthly;
                break;
            case 'W':
                if ((String.Compare(chars, 1, "eekly", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypePaymentFrequencyKnownValues.PaymentFrequency_Weekly;
                break;
            default:
                break;
          }
        return TypePaymentFrequencyKnownValues.PaymentFrequency__none;
      }

    public static string  stringFromPaymentFrequency(TypePaymentFrequencyKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypePaymentFrequencyKnownValues.PaymentFrequency_Monthly:
                return "Monthly";
            case TypePaymentFrequencyKnownValues.PaymentFrequency_BiWeekly:
                return "BiWeekly";
            case TypePaymentFrequencyKnownValues.PaymentFrequency_Weekly:
                return "Weekly";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasPaymentFrequency;
    private TypePaymentFrequency storePaymentFrequency;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraPaymentFrequencyToJSON()
      {
        JSONStringValue generated_string_PaymentFrequency;
        if (!(storePaymentFrequency.in_known_list))
          {
        generated_string_PaymentFrequency = new JSONStringValue(storePaymentFrequency.string_value);
          }
        else
          {
        switch (storePaymentFrequency.list_value)
          {
            case TypePaymentFrequencyKnownValues.PaymentFrequency_Monthly:
                generated_string_PaymentFrequency = new JSONStringValue("Monthly");
                break;
            case TypePaymentFrequencyKnownValues.PaymentFrequency_BiWeekly:
                generated_string_PaymentFrequency = new JSONStringValue("BiWeekly");
                break;
            case TypePaymentFrequencyKnownValues.PaymentFrequency_Weekly:
                generated_string_PaymentFrequency = new JSONStringValue("Weekly");
                break;
            default:
                Debug.Assert(false);
                generated_string_PaymentFrequency = null;
                break;
          }
          }
        return generated_string_PaymentFrequency;
      }


    private void  fromJSONPaymentFrequency(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PaymentFrequency of MortgageCalculatorInputVariablePaymentFrequencyJSON is not a string.");
        TypePaymentFrequency the_open_enum = new TypePaymentFrequency();
        switch (json_string.getData()[0])
          {
            case 'B':
                if ((String.Compare(json_string.getData(), 1, "iWeekly", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypePaymentFrequencyKnownValues.PaymentFrequency_BiWeekly;
                        goto open_enum_is_done;
                      }
                break;
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "onthly", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypePaymentFrequencyKnownValues.PaymentFrequency_Monthly;
                        goto open_enum_is_done;
                      }
                break;
            case 'W':
                if ((String.Compare(json_string.getData(), 1, "eekly", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypePaymentFrequencyKnownValues.PaymentFrequency_Weekly;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setPaymentFrequency(the_open_enum);
      }


    public MortgageCalculatorInputVariablePaymentFrequencyJSON()
      {
        flagHasPaymentFrequency = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getInputVariableKind()
      {
        return "PaymentFrequency";
      }

    public bool  hasPaymentFrequency()
      {
        return flagHasPaymentFrequency;
      }

    public TypePaymentFrequency  getPaymentFrequency()
      {
        Debug.Assert(flagHasPaymentFrequency);
        return storePaymentFrequency;
      }

    public string  getPaymentFrequencyAsString()
      {
        TypePaymentFrequency result = getPaymentFrequency();
        if (result.in_known_list)
            return stringFromPaymentFrequency(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraMortgageCalculatorInputVariablePaymentFrequencyComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMortgageCalculatorInputVariablePaymentFrequencyComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMortgageCalculatorInputVariablePaymentFrequencyComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMortgageCalculatorInputVariablePaymentFrequencyLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraMortgageCalculatorInputVariableComponentCount()
      {
        int result = 0;
        if (flagHasPaymentFrequency)
            ++result;
        result += extraMortgageCalculatorInputVariablePaymentFrequencyComponentCount();
        return result;
      }
    public override string extraMortgageCalculatorInputVariableComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasPaymentFrequency)
          {
            if (remainder == 0)
                return "PaymentFrequency";
            --remainder;
          }
        return extraMortgageCalculatorInputVariablePaymentFrequencyComponentKey(remainder);
      }
    public override JSONValue extraMortgageCalculatorInputVariableComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasPaymentFrequency)
          {
            if (remainder == 0)
                return extraPaymentFrequencyToJSON();
            --remainder;
          }
        return extraMortgageCalculatorInputVariablePaymentFrequencyComponentValue(remainder);
      }
    public override JSONValue extraMortgageCalculatorInputVariableLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "PaymentFrequency", 0, 16, false) == 0) && (field_name.Length == 16))
            return (flagHasPaymentFrequency ? extraPaymentFrequencyToJSON() : null);
        return extraMortgageCalculatorInputVariablePaymentFrequencyLookup(field_name);
      }

    public void setPaymentFrequency(TypePaymentFrequency new_value)
      {
        flagHasPaymentFrequency = true;
        storePaymentFrequency = new_value;
      }
    public void setPaymentFrequency(string chars)
      {
        TypePaymentFrequencyKnownValues known = stringToPaymentFrequency(chars);
        TypePaymentFrequency new_value = new TypePaymentFrequency();
        if (known == TypePaymentFrequencyKnownValues.PaymentFrequency__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setPaymentFrequency(new_value);
      }
    public void setPaymentFrequency(TypePaymentFrequencyKnownValues new_value)
      {
        TypePaymentFrequency new_full_value = new TypePaymentFrequency();
        Debug.Assert(new_value != TypePaymentFrequencyKnownValues.PaymentFrequency__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setPaymentFrequency(new_full_value);
      }
    public void unsetPaymentFrequency()
      {
        flagHasPaymentFrequency = false;
      }

    public virtual void extraMortgageCalculatorInputVariablePaymentFrequencyAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMortgageCalculatorInputVariablePaymentFrequencySetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMortgageCalculatorInputVariablePaymentFrequencyLookup(key);
        if (old_field == null)
          {
            extraMortgageCalculatorInputVariablePaymentFrequencyAppendPair(key, new_component);
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
        if ((String.Compare(key, 0, "PaymentFrequency", 0, 16, false) == 0) && (key.Length == 16))
            {
            fromJSONPaymentFrequency(new_component, false);
            return;
            }
        extraMortgageCalculatorInputVariablePaymentFrequencyAppendPair(key, new_component);
      }
    public override void extraMortgageCalculatorInputVariableSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "PaymentFrequency", 0, 16, false) == 0) && (key.Length == 16))
            {
            fromJSONPaymentFrequency(new_component, false);
            return;
            }
        extraMortgageCalculatorInputVariablePaymentFrequencySetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasPaymentFrequency);
        if (flagHasPaymentFrequency)
          {
            handler.start_pair("PaymentFrequency");
            if (storePaymentFrequency.in_known_list)
              {
                switch (storePaymentFrequency.list_value)
                  {
                    case TypePaymentFrequencyKnownValues.PaymentFrequency_Monthly:
                        handler.string_value("Monthly");
                        break;
                    case TypePaymentFrequencyKnownValues.PaymentFrequency_BiWeekly:
                        handler.string_value("BiWeekly");
                        break;
                    case TypePaymentFrequencyKnownValues.PaymentFrequency_Weekly:
                        handler.string_value("Weekly");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storePaymentFrequency.string_value);
              }
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
        if (!(hasPaymentFrequency()))
          {
            return "When parsing the object for %what%, the \"PaymentFrequency\" field was missing.";
          }
        return null;
      }

    public static new MortgageCalculatorInputVariablePaymentFrequencyJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MortgageCalculatorInputVariablePaymentFrequencyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariablePaymentFrequency", ignore_extras);
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
    public static new MortgageCalculatorInputVariablePaymentFrequencyJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MortgageCalculatorInputVariablePaymentFrequencyJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MortgageCalculatorInputVariablePaymentFrequencyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariablePaymentFrequency", ignore_extras);
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
    public static new MortgageCalculatorInputVariablePaymentFrequencyJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MortgageCalculatorInputVariablePaymentFrequencyJSON from_text(string text, bool ignore_extras)
      {
        MortgageCalculatorInputVariablePaymentFrequencyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariablePaymentFrequency", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MortgageCalculatorInputVariablePaymentFrequencyJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MortgageCalculatorInputVariablePaymentFrequencyJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MortgageCalculatorInputVariablePaymentFrequencyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariablePaymentFrequency", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : MortgageCalculatorInputVariableJSON.Generator
      {
    private abstract class FieldGeneratorPaymentFrequency : JSONStringGenerator
          {
            protected FieldGeneratorPaymentFrequency(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorPaymentFrequency()
              {
              }
            protected override void handle_result(string result)
              {
                TypePaymentFrequencyKnownValues known = stringToPaymentFrequency(result);
                TypePaymentFrequency new_value = new TypePaymentFrequency();
                if (known == TypePaymentFrequencyKnownValues.PaymentFrequency__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = result;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                handle_result(new_value);
              }
            protected abstract void handle_result(TypePaymentFrequency result);
          };
    private class FieldHoldingGeneratorPaymentFrequency : FieldGeneratorPaymentFrequency
  {
    protected override void handle_result(TypePaymentFrequency result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorPaymentFrequency(String what)
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
    public TypePaymentFrequency value;
  };
    private class FieldHoldingArrayGeneratorPaymentFrequency : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorPaymentFrequency
      {
        private FieldHoldingArrayGeneratorPaymentFrequency top;

        protected override void handle_result(TypePaymentFrequency result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorPaymentFrequency init_top)
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
    protected virtual void handle_result(List<TypePaymentFrequency> result)
      {
      }

    public FieldHoldingArrayGeneratorPaymentFrequency(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypePaymentFrequency>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorPaymentFrequency()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypePaymentFrequency>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypePaymentFrequency> value;
  };
        private FieldHoldingGeneratorPaymentFrequency fieldGeneratorPaymentFrequency;
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
            if (!(getMortgageCalculatorInputVariableJSONKey().Equals("PaymentFrequency")))
                throw new Exception("The key field has a value other than `PaymentFrequency'.");
            MortgageCalculatorInputVariablePaymentFrequencyJSON result = new MortgageCalculatorInputVariablePaymentFrequencyJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMortgageCalculatorInputVariablePaymentFrequencyAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(MortgageCalculatorInputVariableJSON new_result)
          {
            handle_result((MortgageCalculatorInputVariablePaymentFrequencyJSON )new_result);
          }
        protected void finish(MortgageCalculatorInputVariablePaymentFrequencyJSON result)
          {
            if (fieldGeneratorPaymentFrequency.have_value)
              {
                result.setPaymentFrequency(fieldGeneratorPaymentFrequency.value);
                fieldGeneratorPaymentFrequency.have_value = false;
              }
            else if ((!(result.hasPaymentFrequency())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PaymentFrequency\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(MortgageCalculatorInputVariablePaymentFrequencyJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "PaymentFrequency", 0, 16, false) == 0) && (field_name.Length == 16))
                return fieldGeneratorPaymentFrequency;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorPaymentFrequency = new FieldHoldingGeneratorPaymentFrequency("field \"PaymentFrequency\" of the MortgageCalculatorInputVariablePaymentFrequency class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MortgageCalculatorInputVariablePaymentFrequency class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorPaymentFrequency = new FieldHoldingGeneratorPaymentFrequency("field \"PaymentFrequency\" of the MortgageCalculatorInputVariablePaymentFrequency class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MortgageCalculatorInputVariablePaymentFrequency class");
          }

        public override void reset()
          {
            fieldGeneratorPaymentFrequency.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MortgageCalculatorInputVariablePaymentFrequencyJSON  result)
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
        public MortgageCalculatorInputVariablePaymentFrequencyJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MortgageCalculatorInputVariablePaymentFrequencyJSON  result)
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
    protected virtual void handle_result(List<MortgageCalculatorInputVariablePaymentFrequencyJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MortgageCalculatorInputVariablePaymentFrequencyJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MortgageCalculatorInputVariablePaymentFrequencyJSON>();
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
    public List<MortgageCalculatorInputVariablePaymentFrequencyJSON> value;
  };
  };
