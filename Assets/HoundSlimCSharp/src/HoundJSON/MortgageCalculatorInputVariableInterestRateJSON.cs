/* file "MortgageCalculatorInputVariableInterestRateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MortgageCalculatorInputVariableInterestRateJSON : MortgageCalculatorInputVariableJSON
  {
    private bool flagHasInterestRatePercentage;
    private double storeInterestRatePercentage;
    private string textStoreInterestRatePercentage;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraInterestRatePercentageToJSON()
      {
        JSONValue generated_rational_InterestRatePercentage;
        if (((double)(long)storeInterestRatePercentage) == storeInterestRatePercentage)
            generated_rational_InterestRatePercentage = new JSONIntegerValue((long)(storeInterestRatePercentage));
        else
            generated_rational_InterestRatePercentage = new JSONRationalValue(storeInterestRatePercentage, 15);
        return generated_rational_InterestRatePercentage;
      }


    private void  fromJSONInterestRatePercentage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field InterestRatePercentage of MortgageCalculatorInputVariableInterestRateJSON is not a number.");
              }
          }
        setInterestRatePercentageText(the_rational_text);
      }


    public MortgageCalculatorInputVariableInterestRateJSON()
      {
        flagHasInterestRatePercentage = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getInputVariableKind()
      {
        return "InterestRate";
      }

    public bool  hasInterestRatePercentage()
      {
        return flagHasInterestRatePercentage;
      }

    public double  getInterestRatePercentage()
      {
        Debug.Assert(flagHasInterestRatePercentage);
        if (textStoreInterestRatePercentage != "")
          {
            return Double.Parse(textStoreInterestRatePercentage);
          }
        return storeInterestRatePercentage;
      }

    public string  getInterestRatePercentageAsText()
      {
        Debug.Assert(flagHasInterestRatePercentage);
        if (textStoreInterestRatePercentage == "")
          {
            return Convert.ToString(storeInterestRatePercentage);
          }
        else
          {
            return (textStoreInterestRatePercentage);
          }
      }


    public virtual int extraMortgageCalculatorInputVariableInterestRateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMortgageCalculatorInputVariableInterestRateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMortgageCalculatorInputVariableInterestRateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMortgageCalculatorInputVariableInterestRateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraMortgageCalculatorInputVariableComponentCount()
      {
        int result = 0;
        if (flagHasInterestRatePercentage)
            ++result;
        result += extraMortgageCalculatorInputVariableInterestRateComponentCount();
        return result;
      }
    public override string extraMortgageCalculatorInputVariableComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasInterestRatePercentage)
          {
            if (remainder == 0)
                return "InterestRatePercentage";
            --remainder;
          }
        return extraMortgageCalculatorInputVariableInterestRateComponentKey(remainder);
      }
    public override JSONValue extraMortgageCalculatorInputVariableComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasInterestRatePercentage)
          {
            if (remainder == 0)
                return extraInterestRatePercentageToJSON();
            --remainder;
          }
        return extraMortgageCalculatorInputVariableInterestRateComponentValue(remainder);
      }
    public override JSONValue extraMortgageCalculatorInputVariableLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "InterestRatePercentage", 0, 22, false) == 0) && (field_name.Length == 22))
            return (flagHasInterestRatePercentage ? extraInterestRatePercentageToJSON() : null);
        return extraMortgageCalculatorInputVariableInterestRateLookup(field_name);
      }

    public void setInterestRatePercentage(double new_value)
      {
        flagHasInterestRatePercentage = true;
        if (new_value < 0)
            throw new Exception("The value for field InterestRatePercentage of MortgageCalculatorInputVariableInterestRateJSON is less than the lower bound (0) for that field.");
        storeInterestRatePercentage = new_value;
        textStoreInterestRatePercentage = "";
      }
    public void setInterestRatePercentageText(string new_value)
      {
        flagHasInterestRatePercentage = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field InterestRatePercentage of MortgageCalculatorInputVariableInterestRateJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field InterestRatePercentage of MortgageCalculatorInputVariableInterestRateJSON is less than the lower bound (0) for that field.");
        textStoreInterestRatePercentage = new_value;
      }
    public void unsetInterestRatePercentage()
      {
        flagHasInterestRatePercentage = false;
      }

    public virtual void extraMortgageCalculatorInputVariableInterestRateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMortgageCalculatorInputVariableInterestRateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMortgageCalculatorInputVariableInterestRateLookup(key);
        if (old_field == null)
          {
            extraMortgageCalculatorInputVariableInterestRateAppendPair(key, new_component);
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
        if ((String.Compare(key, 0, "InterestRatePercentage", 0, 22, false) == 0) && (key.Length == 22))
            {
            fromJSONInterestRatePercentage(new_component, false);
            return;
            }
        extraMortgageCalculatorInputVariableInterestRateAppendPair(key, new_component);
      }
    public override void extraMortgageCalculatorInputVariableSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "InterestRatePercentage", 0, 22, false) == 0) && (key.Length == 22))
            {
            fromJSONInterestRatePercentage(new_component, false);
            return;
            }
        extraMortgageCalculatorInputVariableInterestRateSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasInterestRatePercentage);
        if (flagHasInterestRatePercentage)
          {
            handler.start_pair("InterestRatePercentage");
            if (textStoreInterestRatePercentage != "")
                handler.number_value(textStoreInterestRatePercentage);
            else if (((double)(long)storeInterestRatePercentage) == storeInterestRatePercentage)
                handler.number_value((long)storeInterestRatePercentage);
            else
                handler.number_value(storeInterestRatePercentage);
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
        if (!(hasInterestRatePercentage()))
          {
            return "When parsing the object for %what%, the \"InterestRatePercentage\" field was missing.";
          }
        return null;
      }

    public static new MortgageCalculatorInputVariableInterestRateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MortgageCalculatorInputVariableInterestRateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariableInterestRate", ignore_extras);
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
    public static new MortgageCalculatorInputVariableInterestRateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MortgageCalculatorInputVariableInterestRateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MortgageCalculatorInputVariableInterestRateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariableInterestRate", ignore_extras);
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
    public static new MortgageCalculatorInputVariableInterestRateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MortgageCalculatorInputVariableInterestRateJSON from_text(string text, bool ignore_extras)
      {
        MortgageCalculatorInputVariableInterestRateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariableInterestRate", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MortgageCalculatorInputVariableInterestRateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MortgageCalculatorInputVariableInterestRateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MortgageCalculatorInputVariableInterestRateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariableInterestRate", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : MortgageCalculatorInputVariableJSON.Generator
      {
        private JSONHoldingNumberTextGenerator fieldGeneratorInterestRatePercentage;
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
            if (!(getMortgageCalculatorInputVariableJSONKey().Equals("InterestRate")))
                throw new Exception("The key field has a value other than `InterestRate'.");
            MortgageCalculatorInputVariableInterestRateJSON result = new MortgageCalculatorInputVariableInterestRateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMortgageCalculatorInputVariableInterestRateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(MortgageCalculatorInputVariableJSON new_result)
          {
            handle_result((MortgageCalculatorInputVariableInterestRateJSON )new_result);
          }
        protected void finish(MortgageCalculatorInputVariableInterestRateJSON result)
          {
            if (fieldGeneratorInterestRatePercentage.have_value)
              {
                result.setInterestRatePercentageText(fieldGeneratorInterestRatePercentage.value);
                fieldGeneratorInterestRatePercentage.have_value = false;
              }
            else if ((!(result.hasInterestRatePercentage())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"InterestRatePercentage\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(MortgageCalculatorInputVariableInterestRateJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "InterestRatePercentage", 0, 22, false) == 0) && (field_name.Length == 22))
                return fieldGeneratorInterestRatePercentage;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorInterestRatePercentage = new JSONHoldingNumberTextGenerator("field \"InterestRatePercentage\" of the MortgageCalculatorInputVariableInterestRate class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MortgageCalculatorInputVariableInterestRate class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorInterestRatePercentage = new JSONHoldingNumberTextGenerator("field \"InterestRatePercentage\" of the MortgageCalculatorInputVariableInterestRate class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MortgageCalculatorInputVariableInterestRate class");
          }

        public override void reset()
          {
            fieldGeneratorInterestRatePercentage.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MortgageCalculatorInputVariableInterestRateJSON  result)
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
        public MortgageCalculatorInputVariableInterestRateJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MortgageCalculatorInputVariableInterestRateJSON  result)
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
    protected virtual void handle_result(List<MortgageCalculatorInputVariableInterestRateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MortgageCalculatorInputVariableInterestRateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MortgageCalculatorInputVariableInterestRateJSON>();
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
    public List<MortgageCalculatorInputVariableInterestRateJSON> value;
  };
  };
