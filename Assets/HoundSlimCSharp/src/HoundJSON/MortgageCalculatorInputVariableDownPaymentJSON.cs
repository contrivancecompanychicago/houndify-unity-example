/* file "MortgageCalculatorInputVariableDownPaymentJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MortgageCalculatorInputVariableDownPaymentJSON : MortgageCalculatorInputVariableJSON
  {
    public struct TypeDownPayment
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public MoneyJSON  choice0;
            [FieldOffset(0)]
            public double choice1;
          };
        public Utype u;
      };
    private bool flagHasDownPayment;
    private TypeDownPayment storeDownPayment;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraDownPaymentToJSON()
      {
        JSONValue generated_or_DownPayment;
        switch (storeDownPayment.key)
          {
            case 0:
              {
                JSONValueHandler handler_DownPayment = new JSONValueHandler();
                storeDownPayment.u.choice0.write_as_json(handler_DownPayment);
                generated_or_DownPayment = handler_DownPayment.result;
                break;
              }
            case 1:
              {
                JSONValue generated_rational_DownPayment;
                if (((double)(long)storeDownPayment.u.choice1) == storeDownPayment.u.choice1)
                    generated_rational_DownPayment = new JSONIntegerValue((long)(storeDownPayment.u.choice1));
                else
                    generated_rational_DownPayment = new JSONRationalValue(storeDownPayment.u.choice1, 15);
                generated_or_DownPayment = generated_rational_DownPayment;
                break;
              }
            default:
                Debug.Assert(false);
                generated_or_DownPayment = null;
                break;
          }
        return generated_or_DownPayment;
      }


    private void  fromJSONDownPayment(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeDownPayment or_result = new TypeDownPayment();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
                or_result.u.choice0 = convert_classy;
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                JSONRationalValue json_rational = json_value.rational_value();
                double the_double;
                if (json_rational != null)
                  {
                    the_double = json_rational.getDouble();
                  }
                else
                  {
                    JSONIntegerValue json_integer = json_value.integer_value();
                    if (json_integer != null)
                      {
                        the_double = json_integer.getLongInt();
                      }
                    else
                      {
                        throw new Exception("The value for ??? is not a number.");
                      }
                  }
                if (the_double < 0)
                    throw new Exception("The value for ??? is less than the lower bound (0) for that field.");
                or_result.u.choice1 = the_double;
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field DownPayment of MortgageCalculatorInputVariableDownPaymentJSON is not one of the allowed values.");
        setDownPayment(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    public MortgageCalculatorInputVariableDownPaymentJSON()
      {
        flagHasDownPayment = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getInputVariableKind()
      {
        return "DownPayment";
      }

    public bool  hasDownPayment()
      {
        return flagHasDownPayment;
      }

    public TypeDownPayment  getDownPayment()
      {
        Debug.Assert(flagHasDownPayment);
        return storeDownPayment;
      }


    public virtual int extraMortgageCalculatorInputVariableDownPaymentComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMortgageCalculatorInputVariableDownPaymentComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMortgageCalculatorInputVariableDownPaymentComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMortgageCalculatorInputVariableDownPaymentLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraMortgageCalculatorInputVariableComponentCount()
      {
        int result = 0;
        if (flagHasDownPayment)
            ++result;
        result += extraMortgageCalculatorInputVariableDownPaymentComponentCount();
        return result;
      }
    public override string extraMortgageCalculatorInputVariableComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasDownPayment)
          {
            if (remainder == 0)
                return "DownPayment";
            --remainder;
          }
        return extraMortgageCalculatorInputVariableDownPaymentComponentKey(remainder);
      }
    public override JSONValue extraMortgageCalculatorInputVariableComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasDownPayment)
          {
            if (remainder == 0)
                return extraDownPaymentToJSON();
            --remainder;
          }
        return extraMortgageCalculatorInputVariableDownPaymentComponentValue(remainder);
      }
    public override JSONValue extraMortgageCalculatorInputVariableLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "DownPayment", 0, 11, false) == 0) && (field_name.Length == 11))
            return (flagHasDownPayment ? extraDownPaymentToJSON() : null);
        return extraMortgageCalculatorInputVariableDownPaymentLookup(field_name);
      }

    public void setDownPayment(TypeDownPayment new_value)
      {
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        if (flagHasDownPayment)
          {
            switch (storeDownPayment.key)
              {
                case 0:
                    break;
                case 1:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        flagHasDownPayment = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                if (new_value.u.choice1 < 0)
                    throw new Exception("The value for case 1 of field DownPayment of MortgageCalculatorInputVariableDownPaymentJSON is less than the lower bound (0) for that field.");
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeDownPayment = new_value;
      }
    public void unsetDownPayment()
      {
        if (flagHasDownPayment)
          {
            switch (storeDownPayment.key)
              {
                case 0:
                    break;
                case 1:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        flagHasDownPayment = false;
      }

    public virtual void extraMortgageCalculatorInputVariableDownPaymentAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMortgageCalculatorInputVariableDownPaymentSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMortgageCalculatorInputVariableDownPaymentLookup(key);
        if (old_field == null)
          {
            extraMortgageCalculatorInputVariableDownPaymentAppendPair(key, new_component);
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
        if ((String.Compare(key, 0, "DownPayment", 0, 11, false) == 0) && (key.Length == 11))
            {
            fromJSONDownPayment(new_component, false);
            return;
            }
        extraMortgageCalculatorInputVariableDownPaymentAppendPair(key, new_component);
      }
    public override void extraMortgageCalculatorInputVariableSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "DownPayment", 0, 11, false) == 0) && (key.Length == 11))
            {
            fromJSONDownPayment(new_component, false);
            return;
            }
        extraMortgageCalculatorInputVariableDownPaymentSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasDownPayment);
        if (flagHasDownPayment)
          {
            handler.start_pair("DownPayment");
            switch (storeDownPayment.key)
              {
                case 0:
                    if (partial_allowed)
                        storeDownPayment.u.choice0.write_partial_as_json(handler);
                    else
                        storeDownPayment.u.choice0.write_as_json(handler);
                    break;
                case 1:
                    if (((double)(long)storeDownPayment.u.choice1) == storeDownPayment.u.choice1)
                        handler.number_value((long)storeDownPayment.u.choice1);
                    else
                        handler.number_value(storeDownPayment.u.choice1);
                    break;
                default:
                    Debug.Assert(false);
                    break;
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
        if (!(hasDownPayment()))
          {
            return "When parsing the object for %what%, the \"DownPayment\" field was missing.";
          }
        return null;
      }

    public static new MortgageCalculatorInputVariableDownPaymentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MortgageCalculatorInputVariableDownPaymentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariableDownPayment", ignore_extras);
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
    public static new MortgageCalculatorInputVariableDownPaymentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MortgageCalculatorInputVariableDownPaymentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MortgageCalculatorInputVariableDownPaymentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariableDownPayment", ignore_extras);
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
    public static new MortgageCalculatorInputVariableDownPaymentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MortgageCalculatorInputVariableDownPaymentJSON from_text(string text, bool ignore_extras)
      {
        MortgageCalculatorInputVariableDownPaymentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariableDownPayment", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MortgageCalculatorInputVariableDownPaymentJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MortgageCalculatorInputVariableDownPaymentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MortgageCalculatorInputVariableDownPaymentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariableDownPayment", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : MortgageCalculatorInputVariableJSON.Generator
      {
    private abstract class FieldGeneratorDownPayment : JSONParallelGenerator
          {
            private MoneyJSON.HoldingGenerator field0;
            private JSONHoldingNumberTextGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeDownPayment result = new TypeDownPayment();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = Double.Parse(field1.value);
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeDownPayment result);
            public FieldGeneratorDownPayment(bool ignore_extras)
              {
                    field0 = new MoneyJSON.HoldingGenerator("option 0 of field \"DownPayment\"", ignore_extras);
                    field1 = new JSONHoldingNumberTextGenerator("option 1 of field \"DownPayment\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorDownPayment(string what, bool ignore_extras)
              {
                    field0 = new MoneyJSON.HoldingGenerator("option 0 of field \"DownPayment\"", ignore_extras);
                    field1 = new JSONHoldingNumberTextGenerator("option 1 of field \"DownPayment\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderDownPayment
          {
            private bool have_data;
            private TypeDownPayment data;
            public HolderDownPayment()  { have_data = false; }
            public HolderDownPayment(TypeDownPayment init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderDownPayment(HolderDownPayment other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeDownPayment referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorDownPayment : FieldGeneratorDownPayment
          {
            protected override void handle_result(TypeDownPayment result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderDownPayment(result);
              }

            public FieldHoldingGeneratorDownPayment(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderDownPayment value;
          };
    private class FieldHoldingArrayGeneratorDownPayment : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorDownPayment
      {
        private FieldHoldingArrayGeneratorDownPayment top;

        protected override void handle_result(TypeDownPayment result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorDownPayment init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeDownPayment> result)
      {
      }

    public FieldHoldingArrayGeneratorDownPayment(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeDownPayment>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorDownPayment(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeDownPayment>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeDownPayment> value;
  };
        private FieldHoldingGeneratorDownPayment fieldGeneratorDownPayment;
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
            if (!(getMortgageCalculatorInputVariableJSONKey().Equals("DownPayment")))
                throw new Exception("The key field has a value other than `DownPayment'.");
            MortgageCalculatorInputVariableDownPaymentJSON result = new MortgageCalculatorInputVariableDownPaymentJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMortgageCalculatorInputVariableDownPaymentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(MortgageCalculatorInputVariableJSON new_result)
          {
            handle_result((MortgageCalculatorInputVariableDownPaymentJSON )new_result);
          }
        protected void finish(MortgageCalculatorInputVariableDownPaymentJSON result)
          {
            if (fieldGeneratorDownPayment.have_value)
              {
                result.setDownPayment(fieldGeneratorDownPayment.value.referenced());
                fieldGeneratorDownPayment.have_value = false;
              }
            else if ((!(result.hasDownPayment())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DownPayment\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(MortgageCalculatorInputVariableDownPaymentJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "DownPayment", 0, 11, false) == 0) && (field_name.Length == 11))
                return fieldGeneratorDownPayment;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorDownPayment = new FieldHoldingGeneratorDownPayment("field \"DownPayment\" of the MortgageCalculatorInputVariableDownPayment class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MortgageCalculatorInputVariableDownPayment class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorDownPayment = new FieldHoldingGeneratorDownPayment("field \"DownPayment\" of the MortgageCalculatorInputVariableDownPayment class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MortgageCalculatorInputVariableDownPayment class");
          }

        public override void reset()
          {
            fieldGeneratorDownPayment.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MortgageCalculatorInputVariableDownPaymentJSON  result)
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
        public MortgageCalculatorInputVariableDownPaymentJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MortgageCalculatorInputVariableDownPaymentJSON  result)
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
    protected virtual void handle_result(List<MortgageCalculatorInputVariableDownPaymentJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MortgageCalculatorInputVariableDownPaymentJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MortgageCalculatorInputVariableDownPaymentJSON>();
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
    public List<MortgageCalculatorInputVariableDownPaymentJSON> value;
  };
  };
