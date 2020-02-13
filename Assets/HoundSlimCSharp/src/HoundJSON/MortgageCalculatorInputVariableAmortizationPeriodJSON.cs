/* file "MortgageCalculatorInputVariableAmortizationPeriodJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MortgageCalculatorInputVariableAmortizationPeriodJSON : MortgageCalculatorInputVariableJSON
  {
    public class TypeAmortizationPeriodJSON : JSONBase
      {
        public enum TypeUnitKnownValues
          {
            Unit_Months,
            Unit__none
          };
        public struct TypeUnit
          {
            public bool in_known_list;
            public string string_value;
            public TypeUnitKnownValues list_value;
          };

        public static TypeUnitKnownValues  stringToUnit(string chars)
          {
            if ((String.Compare(chars, 0, "Months", 0, 6, false) == 0) && (chars.Length == 6))
                return TypeUnitKnownValues.Unit_Months;
            return TypeUnitKnownValues.Unit__none;
          }

        public static string  stringFromUnit(TypeUnitKnownValues the_enum)
          {
            switch (the_enum)
              {
                case TypeUnitKnownValues.Unit_Months:
                    return "Months";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        private bool flagHasValue;
        private double storeValue;
        private string textStoreValue;
        private bool flagHasUnit;
        private TypeUnit storeUnit;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field Value of TypeAmortizationPeriodJSON is not a number.");
                  }
              }
            setValueText(the_rational_text);
          }


        private void  fromJSONUnit(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Unit of TypeAmortizationPeriodJSON is not a string.");
            TypeUnit the_open_enum = new TypeUnit();
            if ((String.Compare(json_string.getData(), 0, "Months", 0, 6, false) == 0) && (json_string.getData().Length == 6))
                  {
                    the_open_enum.in_known_list = true;
                    the_open_enum.list_value = TypeUnitKnownValues.Unit_Months;
                    goto open_enum_is_done;
                  }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            setUnit(the_open_enum);
          }


        public TypeAmortizationPeriodJSON()
          {
            flagHasValue = false;
            flagHasUnit = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasValue()
          {
            return flagHasValue;
          }

        public double  getValue()
          {
            Debug.Assert(flagHasValue);
            if (textStoreValue != "")
              {
                return Double.Parse(textStoreValue);
              }
            return storeValue;
          }

        public string  getValueAsText()
          {
            Debug.Assert(flagHasValue);
            if (textStoreValue == "")
              {
                return Convert.ToString(storeValue);
              }
            else
              {
                return (textStoreValue);
              }
          }

        public bool  hasUnit()
          {
            return flagHasUnit;
          }

        public TypeUnit  getUnit()
          {
            Debug.Assert(flagHasUnit);
            return storeUnit;
          }

        public string  getUnitAsString()
          {
            TypeUnit result = getUnit();
            if (result.in_known_list)
                return stringFromUnit(result.list_value);
            else
                return result.string_value;
          }


        public virtual int extraTypeAmortizationPeriodComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeAmortizationPeriodComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeAmortizationPeriodComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeAmortizationPeriodLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setValue(double new_value)
          {
            flagHasValue = true;
            if (new_value < 0)
                throw new Exception("The value for field Value of TypeAmortizationPeriodJSON is less than the lower bound (0) for that field.");
            storeValue = new_value;
            textStoreValue = "";
          }
        public void setValueText(string new_value)
          {
            flagHasValue = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field Value of TypeAmortizationPeriodJSON is not a valid number.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
                throw new Exception("The value for field Value of TypeAmortizationPeriodJSON is less than the lower bound (0) for that field.");
            textStoreValue = new_value;
          }
        public void unsetValue()
          {
            flagHasValue = false;
          }
        public void setUnit(TypeUnit new_value)
          {
            flagHasUnit = true;
            storeUnit = new_value;
          }
        public void setUnit(string chars)
          {
            TypeUnitKnownValues known = stringToUnit(chars);
            TypeUnit new_value = new TypeUnit();
            if (known == TypeUnitKnownValues.Unit__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setUnit(new_value);
          }
        public void setUnit(TypeUnitKnownValues new_value)
          {
            TypeUnit new_full_value = new TypeUnit();
            Debug.Assert(new_value != TypeUnitKnownValues.Unit__none);
            new_full_value.in_known_list = true;
            new_full_value.list_value = new_value;
            setUnit(new_full_value);
          }
        public void unsetUnit()
          {
            flagHasUnit = false;
          }

        public virtual void extraTypeAmortizationPeriodAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeAmortizationPeriodSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeAmortizationPeriodLookup(key);
            if (old_field == null)
              {
                extraTypeAmortizationPeriodAppendPair(key, new_component);
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

        public virtual void write_fields_as_json(JSONHandler handler)
          {
            write_fields_as_json(handler, false);
          }

        public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
          {
            Debug.Assert(partial_allowed || flagHasValue);
            if (flagHasValue)
              {
                handler.start_pair("Value");
                if (textStoreValue != "")
                    handler.number_value(textStoreValue);
                else if (((double)(long)storeValue) == storeValue)
                    handler.number_value((long)storeValue);
                else
                    handler.number_value(storeValue);
              }
            Debug.Assert(partial_allowed || flagHasUnit);
            if (flagHasUnit)
              {
                handler.start_pair("Unit");
                if (storeUnit.in_known_list)
                  {
                    switch (storeUnit.list_value)
                      {
                        case TypeUnitKnownValues.Unit_Months:
                            handler.string_value("Months");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeUnit.string_value);
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
        public virtual string missing_field_error(bool allow_unpolished)
          {
            if (!(hasValue()))
              {
                return "When parsing the object for %what%, the \"Value\" field was missing.";
              }
            if (!(hasUnit()))
              {
                return "When parsing the object for %what%, the \"Unit\" field was missing.";
              }
            return null;
          }

        public static TypeAmortizationPeriodJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeAmortizationPeriodJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAmortizationPeriod", ignore_extras);
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
        public static TypeAmortizationPeriodJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeAmortizationPeriodJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeAmortizationPeriodJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAmortizationPeriod", ignore_extras);
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
        public static TypeAmortizationPeriodJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeAmortizationPeriodJSON from_text(string text, bool ignore_extras)
          {
            TypeAmortizationPeriodJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAmortizationPeriod", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeAmortizationPeriodJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeAmortizationPeriodJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeAmortizationPeriodJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAmortizationPeriod", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingNumberTextGenerator fieldGeneratorValue;
        private abstract class FieldGeneratorUnit : JSONStringGenerator
              {
                protected FieldGeneratorUnit(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorUnit()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    TypeUnitKnownValues known = stringToUnit(result);
                    TypeUnit new_value = new TypeUnit();
                    if (known == TypeUnitKnownValues.Unit__none)
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
                protected abstract void handle_result(TypeUnit result);
              };
        private class FieldHoldingGeneratorUnit : FieldGeneratorUnit
      {
        protected override void handle_result(TypeUnit result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorUnit(String what)
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
        public TypeUnit value;
      };
        private class FieldHoldingArrayGeneratorUnit : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorUnit
          {
            private FieldHoldingArrayGeneratorUnit top;

            protected override void handle_result(TypeUnit result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorUnit init_top)
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
        protected virtual void handle_result(List<TypeUnit> result)
          {
          }

        public FieldHoldingArrayGeneratorUnit(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeUnit>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorUnit()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeUnit>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeUnit> value;
      };
            private FieldHoldingGeneratorUnit fieldGeneratorUnit;
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

            protected bool allow_incomplete;

            protected bool allow_unpolished;

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
                TypeAmortizationPeriodJSON result = new TypeAmortizationPeriodJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeAmortizationPeriodAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeAmortizationPeriodJSON result)
              {
                if (fieldGeneratorValue.have_value)
                  {
                    result.setValueText(fieldGeneratorValue.value);
                    fieldGeneratorValue.have_value = false;
                  }
                else if ((!(result.hasValue())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Value\" field was missing.");
                  }
                if (fieldGeneratorUnit.have_value)
                  {
                    result.setUnit(fieldGeneratorUnit.value);
                    fieldGeneratorUnit.have_value = false;
                  }
                else if ((!(result.hasUnit())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Unit\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeAmortizationPeriodJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'U':
                        if ((String.Compare(field_name, 1, "nit", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorUnit;
                        break;
                    case 'V':
                        if ((String.Compare(field_name, 1, "alue", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorValue;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new JSONHoldingNumberTextGenerator("field \"Value\" of the TypeAmortizationPeriod class");
                fieldGeneratorUnit = new FieldHoldingGeneratorUnit("field \"Unit\" of the TypeAmortizationPeriod class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeAmortizationPeriod class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new JSONHoldingNumberTextGenerator("field \"Value\" of the TypeAmortizationPeriod class");
                fieldGeneratorUnit = new FieldHoldingGeneratorUnit("field \"Unit\" of the TypeAmortizationPeriod class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeAmortizationPeriod class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorValue.reset();
                fieldGeneratorUnit.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeAmortizationPeriodJSON  result)
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
            public TypeAmortizationPeriodJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeAmortizationPeriodJSON  result)
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
        protected virtual void handle_result(List<TypeAmortizationPeriodJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeAmortizationPeriodJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeAmortizationPeriodJSON>();
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
        public List<TypeAmortizationPeriodJSON> value;
      };
      };
    private bool flagHasAmortizationPeriod;
    private TypeAmortizationPeriodJSON  storeAmortizationPeriod;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraAmortizationPeriodToJSON()
      {
        JSONValueHandler handler_AmortizationPeriod = new JSONValueHandler();
        storeAmortizationPeriod.write_as_json(handler_AmortizationPeriod);
        return handler_AmortizationPeriod.result;
      }


    private void  fromJSONAmortizationPeriod(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeAmortizationPeriodJSON convert_classy = TypeAmortizationPeriodJSON.from_json(json_value, ignore_extras, true);
        setAmortizationPeriod(convert_classy);
      }


    public MortgageCalculatorInputVariableAmortizationPeriodJSON()
      {
        flagHasAmortizationPeriod = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getInputVariableKind()
      {
        return "AmortizationPeriod";
      }

    public bool  hasAmortizationPeriod()
      {
        return flagHasAmortizationPeriod;
      }

    public TypeAmortizationPeriodJSON   getAmortizationPeriod()
      {
        Debug.Assert(flagHasAmortizationPeriod);
        return storeAmortizationPeriod;
      }


    public virtual int extraMortgageCalculatorInputVariableAmortizationPeriodComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMortgageCalculatorInputVariableAmortizationPeriodComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMortgageCalculatorInputVariableAmortizationPeriodComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMortgageCalculatorInputVariableAmortizationPeriodLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraMortgageCalculatorInputVariableComponentCount()
      {
        int result = 0;
        if (flagHasAmortizationPeriod)
            ++result;
        result += extraMortgageCalculatorInputVariableAmortizationPeriodComponentCount();
        return result;
      }
    public override string extraMortgageCalculatorInputVariableComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasAmortizationPeriod)
          {
            if (remainder == 0)
                return "AmortizationPeriod";
            --remainder;
          }
        return extraMortgageCalculatorInputVariableAmortizationPeriodComponentKey(remainder);
      }
    public override JSONValue extraMortgageCalculatorInputVariableComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasAmortizationPeriod)
          {
            if (remainder == 0)
                return extraAmortizationPeriodToJSON();
            --remainder;
          }
        return extraMortgageCalculatorInputVariableAmortizationPeriodComponentValue(remainder);
      }
    public override JSONValue extraMortgageCalculatorInputVariableLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "AmortizationPeriod", 0, 18, false) == 0) && (field_name.Length == 18))
            return (flagHasAmortizationPeriod ? extraAmortizationPeriodToJSON() : null);
        return extraMortgageCalculatorInputVariableAmortizationPeriodLookup(field_name);
      }

    public void setAmortizationPeriod(TypeAmortizationPeriodJSON  new_value)
      {
        if (flagHasAmortizationPeriod)
          {
          }
        flagHasAmortizationPeriod = true;
        storeAmortizationPeriod = new_value;
      }
    public void unsetAmortizationPeriod()
      {
        if (flagHasAmortizationPeriod)
          {
          }
        flagHasAmortizationPeriod = false;
      }

    public virtual void extraMortgageCalculatorInputVariableAmortizationPeriodAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMortgageCalculatorInputVariableAmortizationPeriodSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMortgageCalculatorInputVariableAmortizationPeriodLookup(key);
        if (old_field == null)
          {
            extraMortgageCalculatorInputVariableAmortizationPeriodAppendPair(key, new_component);
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
        if ((String.Compare(key, 0, "AmortizationPeriod", 0, 18, false) == 0) && (key.Length == 18))
            {
            fromJSONAmortizationPeriod(new_component, false);
            return;
            }
        extraMortgageCalculatorInputVariableAmortizationPeriodAppendPair(key, new_component);
      }
    public override void extraMortgageCalculatorInputVariableSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "AmortizationPeriod", 0, 18, false) == 0) && (key.Length == 18))
            {
            fromJSONAmortizationPeriod(new_component, false);
            return;
            }
        extraMortgageCalculatorInputVariableAmortizationPeriodSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasAmortizationPeriod);
        if (flagHasAmortizationPeriod)
          {
            handler.start_pair("AmortizationPeriod");
            if (partial_allowed)
                storeAmortizationPeriod.write_partial_as_json(handler);
            else
                storeAmortizationPeriod.write_as_json(handler);
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
        if (!(hasAmortizationPeriod()))
          {
            return "When parsing the object for %what%, the \"AmortizationPeriod\" field was missing.";
          }
        return null;
      }

    public static new MortgageCalculatorInputVariableAmortizationPeriodJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MortgageCalculatorInputVariableAmortizationPeriodJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariableAmortizationPeriod", ignore_extras);
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
    public static new MortgageCalculatorInputVariableAmortizationPeriodJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MortgageCalculatorInputVariableAmortizationPeriodJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MortgageCalculatorInputVariableAmortizationPeriodJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariableAmortizationPeriod", ignore_extras);
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
    public static new MortgageCalculatorInputVariableAmortizationPeriodJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MortgageCalculatorInputVariableAmortizationPeriodJSON from_text(string text, bool ignore_extras)
      {
        MortgageCalculatorInputVariableAmortizationPeriodJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariableAmortizationPeriod", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MortgageCalculatorInputVariableAmortizationPeriodJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MortgageCalculatorInputVariableAmortizationPeriodJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MortgageCalculatorInputVariableAmortizationPeriodJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariableAmortizationPeriod", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : MortgageCalculatorInputVariableJSON.Generator
      {
        private TypeAmortizationPeriodJSON.HoldingGenerator fieldGeneratorAmortizationPeriod;
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
            if (!(getMortgageCalculatorInputVariableJSONKey().Equals("AmortizationPeriod")))
                throw new Exception("The key field has a value other than `AmortizationPeriod'.");
            MortgageCalculatorInputVariableAmortizationPeriodJSON result = new MortgageCalculatorInputVariableAmortizationPeriodJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMortgageCalculatorInputVariableAmortizationPeriodAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(MortgageCalculatorInputVariableJSON new_result)
          {
            handle_result((MortgageCalculatorInputVariableAmortizationPeriodJSON )new_result);
          }
        protected void finish(MortgageCalculatorInputVariableAmortizationPeriodJSON result)
          {
            if (fieldGeneratorAmortizationPeriod.have_value)
              {
                result.setAmortizationPeriod(fieldGeneratorAmortizationPeriod.value);
                fieldGeneratorAmortizationPeriod.have_value = false;
              }
            else if ((!(result.hasAmortizationPeriod())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AmortizationPeriod\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(MortgageCalculatorInputVariableAmortizationPeriodJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "AmortizationPeriod", 0, 18, false) == 0) && (field_name.Length == 18))
                return fieldGeneratorAmortizationPeriod;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorAmortizationPeriod = new TypeAmortizationPeriodJSON.HoldingGenerator("field \"AmortizationPeriod\" of the MortgageCalculatorInputVariableAmortizationPeriod class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MortgageCalculatorInputVariableAmortizationPeriod class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorAmortizationPeriod = new TypeAmortizationPeriodJSON.HoldingGenerator("field \"AmortizationPeriod\" of the MortgageCalculatorInputVariableAmortizationPeriod class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MortgageCalculatorInputVariableAmortizationPeriod class");
          }

        public override void reset()
          {
            fieldGeneratorAmortizationPeriod.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MortgageCalculatorInputVariableAmortizationPeriodJSON  result)
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
        public MortgageCalculatorInputVariableAmortizationPeriodJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MortgageCalculatorInputVariableAmortizationPeriodJSON  result)
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
    protected virtual void handle_result(List<MortgageCalculatorInputVariableAmortizationPeriodJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MortgageCalculatorInputVariableAmortizationPeriodJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MortgageCalculatorInputVariableAmortizationPeriodJSON>();
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
    public List<MortgageCalculatorInputVariableAmortizationPeriodJSON> value;
  };
  };
