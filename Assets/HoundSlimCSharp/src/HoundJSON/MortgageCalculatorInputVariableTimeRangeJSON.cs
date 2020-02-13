/* file "MortgageCalculatorInputVariableTimeRangeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MortgageCalculatorInputVariableTimeRangeJSON : MortgageCalculatorInputVariableJSON
  {
    public class TypeStartJSON : JSONBase
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
        private bool flagHasRelativeToEnd;
        private bool storeRelativeToEnd;
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
                    throw new Exception("The value for field Value of TypeStartJSON is not a number.");
                  }
              }
            setValueText(the_rational_text);
          }


        private void  fromJSONUnit(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Unit of TypeStartJSON is not a string.");
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


        private void  fromJSONRelativeToEnd(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field RelativeToEnd of TypeStartJSON is not true for false.");
                  }
              }
            setRelativeToEnd(the_bool);
          }


        public TypeStartJSON()
          {
            flagHasValue = false;
            flagHasUnit = false;
            flagHasRelativeToEnd = false;
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

        public bool  hasRelativeToEnd()
          {
            return flagHasRelativeToEnd;
          }

        public bool  getRelativeToEnd()
          {
            Debug.Assert(flagHasRelativeToEnd);
            return storeRelativeToEnd;
          }


        public virtual int extraTypeStartComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeStartComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeStartComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeStartLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setValue(double new_value)
          {
            flagHasValue = true;
            if (new_value < 0)
                throw new Exception("The value for field Value of TypeStartJSON is less than the lower bound (0) for that field.");
            storeValue = new_value;
            textStoreValue = "";
          }
        public void setValueText(string new_value)
          {
            flagHasValue = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field Value of TypeStartJSON is not a valid number.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
                throw new Exception("The value for field Value of TypeStartJSON is less than the lower bound (0) for that field.");
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
        public void setRelativeToEnd(bool new_value)
          {
            flagHasRelativeToEnd = true;
            storeRelativeToEnd = new_value;
          }
        public void unsetRelativeToEnd()
          {
            flagHasRelativeToEnd = false;
          }

        public virtual void extraTypeStartAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeStartSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeStartLookup(key);
            if (old_field == null)
              {
                extraTypeStartAppendPair(key, new_component);
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
            if (flagHasRelativeToEnd)
              {
                handler.start_pair("RelativeToEnd");
                handler.boolean_value(storeRelativeToEnd);
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

        public static TypeStartJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeStartJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeStart", ignore_extras);
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
        public static TypeStartJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeStartJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeStartJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeStart", ignore_extras);
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
        public static TypeStartJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeStartJSON from_text(string text, bool ignore_extras)
          {
            TypeStartJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeStart", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeStartJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeStartJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeStartJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeStart", ignore_extras);
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
            private JSONHoldingBooleanGenerator fieldGeneratorRelativeToEnd;
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
                TypeStartJSON result = new TypeStartJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeStartAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeStartJSON result)
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
                if (fieldGeneratorRelativeToEnd.have_value)
                  {
                    result.setRelativeToEnd(fieldGeneratorRelativeToEnd.value);
                    fieldGeneratorRelativeToEnd.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeStartJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'R':
                        if ((String.Compare(field_name, 1, "elativeToEnd", 0, 12, false) == 0) && (field_name.Length == 13))
                            return fieldGeneratorRelativeToEnd;
                        break;
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
                fieldGeneratorValue = new JSONHoldingNumberTextGenerator("field \"Value\" of the TypeStart class");
                fieldGeneratorUnit = new FieldHoldingGeneratorUnit("field \"Unit\" of the TypeStart class");
                fieldGeneratorRelativeToEnd = new JSONHoldingBooleanGenerator("field \"RelativeToEnd\" of the TypeStart class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeStart class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new JSONHoldingNumberTextGenerator("field \"Value\" of the TypeStart class");
                fieldGeneratorUnit = new FieldHoldingGeneratorUnit("field \"Unit\" of the TypeStart class");
                fieldGeneratorRelativeToEnd = new JSONHoldingBooleanGenerator("field \"RelativeToEnd\" of the TypeStart class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeStart class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorValue.reset();
                fieldGeneratorUnit.reset();
                fieldGeneratorRelativeToEnd.reset();
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
            protected override void handle_result(TypeStartJSON  result)
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
            public TypeStartJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeStartJSON  result)
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
        protected virtual void handle_result(List<TypeStartJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeStartJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeStartJSON>();
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
        public List<TypeStartJSON> value;
      };
      };
    public class TypeEndJSON : JSONBase
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
        private bool flagHasMortgageEnd;
        private bool storeMortgageEnd;
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
                    throw new Exception("The value for field Value of TypeEndJSON is not a number.");
                  }
              }
            setValueText(the_rational_text);
          }


        private void  fromJSONUnit(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Unit of TypeEndJSON is not a string.");
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


        private void  fromJSONMortgageEnd(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field MortgageEnd of TypeEndJSON is not true for false.");
                  }
              }
            setMortgageEnd(the_bool);
          }


        public TypeEndJSON()
          {
            flagHasValue = false;
            flagHasUnit = false;
            flagHasMortgageEnd = false;
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

        public bool  hasMortgageEnd()
          {
            return flagHasMortgageEnd;
          }

        public bool  getMortgageEnd()
          {
            Debug.Assert(flagHasMortgageEnd);
            return storeMortgageEnd;
          }


        public virtual int extraTypeEndComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeEndComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeEndComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeEndLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setValue(double new_value)
          {
            flagHasValue = true;
            if (new_value < 0)
                throw new Exception("The value for field Value of TypeEndJSON is less than the lower bound (0) for that field.");
            storeValue = new_value;
            textStoreValue = "";
          }
        public void setValueText(string new_value)
          {
            flagHasValue = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field Value of TypeEndJSON is not a valid number.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
                throw new Exception("The value for field Value of TypeEndJSON is less than the lower bound (0) for that field.");
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
        public void setMortgageEnd(bool new_value)
          {
            flagHasMortgageEnd = true;
            storeMortgageEnd = new_value;
          }
        public void unsetMortgageEnd()
          {
            flagHasMortgageEnd = false;
          }

        public virtual void extraTypeEndAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeEndSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeEndLookup(key);
            if (old_field == null)
              {
                extraTypeEndAppendPair(key, new_component);
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
            if (flagHasMortgageEnd)
              {
                handler.start_pair("MortgageEnd");
                handler.boolean_value(storeMortgageEnd);
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
            return null;
          }

        public static TypeEndJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeEndJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeEnd", ignore_extras);
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
        public static TypeEndJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeEndJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeEndJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeEnd", ignore_extras);
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
        public static TypeEndJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeEndJSON from_text(string text, bool ignore_extras)
          {
            TypeEndJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeEnd", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeEndJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeEndJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeEndJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeEnd", ignore_extras);
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
            private JSONHoldingBooleanGenerator fieldGeneratorMortgageEnd;
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
                TypeEndJSON result = new TypeEndJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeEndAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeEndJSON result)
              {
                if (fieldGeneratorValue.have_value)
                  {
                    result.setValueText(fieldGeneratorValue.value);
                    fieldGeneratorValue.have_value = false;
                  }
                if (fieldGeneratorUnit.have_value)
                  {
                    result.setUnit(fieldGeneratorUnit.value);
                    fieldGeneratorUnit.have_value = false;
                  }
                if (fieldGeneratorMortgageEnd.have_value)
                  {
                    result.setMortgageEnd(fieldGeneratorMortgageEnd.value);
                    fieldGeneratorMortgageEnd.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeEndJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'M':
                        if ((String.Compare(field_name, 1, "ortgageEnd", 0, 10, false) == 0) && (field_name.Length == 11))
                            return fieldGeneratorMortgageEnd;
                        break;
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
                fieldGeneratorValue = new JSONHoldingNumberTextGenerator("field \"Value\" of the TypeEnd class");
                fieldGeneratorUnit = new FieldHoldingGeneratorUnit("field \"Unit\" of the TypeEnd class");
                fieldGeneratorMortgageEnd = new JSONHoldingBooleanGenerator("field \"MortgageEnd\" of the TypeEnd class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeEnd class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new JSONHoldingNumberTextGenerator("field \"Value\" of the TypeEnd class");
                fieldGeneratorUnit = new FieldHoldingGeneratorUnit("field \"Unit\" of the TypeEnd class");
                fieldGeneratorMortgageEnd = new JSONHoldingBooleanGenerator("field \"MortgageEnd\" of the TypeEnd class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeEnd class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorValue.reset();
                fieldGeneratorUnit.reset();
                fieldGeneratorMortgageEnd.reset();
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
            protected override void handle_result(TypeEndJSON  result)
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
            public TypeEndJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeEndJSON  result)
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
        protected virtual void handle_result(List<TypeEndJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeEndJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeEndJSON>();
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
        public List<TypeEndJSON> value;
      };
      };
    private bool flagHasStart;
    private TypeStartJSON  storeStart;
    private bool flagHasEnd;
    private TypeEndJSON  storeEnd;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraStartToJSON()
      {
        JSONValueHandler handler_Start = new JSONValueHandler();
        storeStart.write_as_json(handler_Start);
        return handler_Start.result;
      }

    private JSONValue  extraEndToJSON()
      {
        JSONValueHandler handler_End = new JSONValueHandler();
        storeEnd.write_as_json(handler_End);
        return handler_End.result;
      }


    private void  fromJSONStart(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeStartJSON convert_classy = TypeStartJSON.from_json(json_value, ignore_extras, true);
        setStart(convert_classy);
      }


    private void  fromJSONEnd(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeEndJSON convert_classy = TypeEndJSON.from_json(json_value, ignore_extras, true);
        setEnd(convert_classy);
      }


    public MortgageCalculatorInputVariableTimeRangeJSON()
      {
        flagHasStart = false;
        flagHasEnd = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getInputVariableKind()
      {
        return "TimeRange";
      }

    public bool  hasStart()
      {
        return flagHasStart;
      }

    public TypeStartJSON   getStart()
      {
        Debug.Assert(flagHasStart);
        return storeStart;
      }

    public bool  hasEnd()
      {
        return flagHasEnd;
      }

    public TypeEndJSON   getEnd()
      {
        Debug.Assert(flagHasEnd);
        return storeEnd;
      }


    public virtual int extraMortgageCalculatorInputVariableTimeRangeComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMortgageCalculatorInputVariableTimeRangeComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMortgageCalculatorInputVariableTimeRangeComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMortgageCalculatorInputVariableTimeRangeLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraMortgageCalculatorInputVariableComponentCount()
      {
        int result = 0;
        if (flagHasStart)
            ++result;
        if (flagHasEnd)
            ++result;
        result += extraMortgageCalculatorInputVariableTimeRangeComponentCount();
        return result;
      }
    public override string extraMortgageCalculatorInputVariableComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasStart)
          {
            if (remainder == 0)
                return "Start";
            --remainder;
          }
        if (flagHasEnd)
          {
            if (remainder == 0)
                return "End";
            --remainder;
          }
        return extraMortgageCalculatorInputVariableTimeRangeComponentKey(remainder);
      }
    public override JSONValue extraMortgageCalculatorInputVariableComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasStart)
          {
            if (remainder == 0)
                return extraStartToJSON();
            --remainder;
          }
        if (flagHasEnd)
          {
            if (remainder == 0)
                return extraEndToJSON();
            --remainder;
          }
        return extraMortgageCalculatorInputVariableTimeRangeComponentValue(remainder);
      }
    public override JSONValue extraMortgageCalculatorInputVariableLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'E':
                if ((String.Compare(field_name, 1, "nd", 0, 2, false) == 0) && (field_name.Length == 3))
                    return (flagHasEnd ? extraEndToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "tart", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasStart ? extraStartToJSON() : null);
                break;
            default:
                break;
          }
        return extraMortgageCalculatorInputVariableTimeRangeLookup(field_name);
      }

    public void setStart(TypeStartJSON  new_value)
      {
        if (flagHasStart)
          {
          }
        flagHasStart = true;
        storeStart = new_value;
      }
    public void unsetStart()
      {
        if (flagHasStart)
          {
          }
        flagHasStart = false;
      }
    public void setEnd(TypeEndJSON  new_value)
      {
        if (flagHasEnd)
          {
          }
        flagHasEnd = true;
        storeEnd = new_value;
      }
    public void unsetEnd()
      {
        if (flagHasEnd)
          {
          }
        flagHasEnd = false;
      }

    public virtual void extraMortgageCalculatorInputVariableTimeRangeAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMortgageCalculatorInputVariableTimeRangeSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMortgageCalculatorInputVariableTimeRangeLookup(key);
        if (old_field == null)
          {
            extraMortgageCalculatorInputVariableTimeRangeAppendPair(key, new_component);
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
            case 'E':
                if ((String.Compare(key, 1, "nd", 0, 2, false) == 0) && (key.Length == 3))
                    {
                    fromJSONEnd(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "tart", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONStart(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraMortgageCalculatorInputVariableTimeRangeAppendPair(key, new_component);
      }
    public override void extraMortgageCalculatorInputVariableSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'E':
                if ((String.Compare(key, 1, "nd", 0, 2, false) == 0) && (key.Length == 3))
                    {
                    fromJSONEnd(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "tart", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONStart(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraMortgageCalculatorInputVariableTimeRangeSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasStart);
        if (flagHasStart)
          {
            handler.start_pair("Start");
            if (partial_allowed)
                storeStart.write_partial_as_json(handler);
            else
                storeStart.write_as_json(handler);
          }
        if (flagHasEnd)
          {
            handler.start_pair("End");
            if (partial_allowed)
                storeEnd.write_partial_as_json(handler);
            else
                storeEnd.write_as_json(handler);
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
        if (!(hasStart()))
          {
            return "When parsing the object for %what%, the \"Start\" field was missing.";
          }
        return null;
      }

    public static new MortgageCalculatorInputVariableTimeRangeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MortgageCalculatorInputVariableTimeRangeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariableTimeRange", ignore_extras);
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
    public static new MortgageCalculatorInputVariableTimeRangeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MortgageCalculatorInputVariableTimeRangeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MortgageCalculatorInputVariableTimeRangeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariableTimeRange", ignore_extras);
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
    public static new MortgageCalculatorInputVariableTimeRangeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MortgageCalculatorInputVariableTimeRangeJSON from_text(string text, bool ignore_extras)
      {
        MortgageCalculatorInputVariableTimeRangeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariableTimeRange", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MortgageCalculatorInputVariableTimeRangeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MortgageCalculatorInputVariableTimeRangeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MortgageCalculatorInputVariableTimeRangeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariableTimeRange", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : MortgageCalculatorInputVariableJSON.Generator
      {
        private TypeStartJSON.HoldingGenerator fieldGeneratorStart;
        private TypeEndJSON.HoldingGenerator fieldGeneratorEnd;
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
            if (!(getMortgageCalculatorInputVariableJSONKey().Equals("TimeRange")))
                throw new Exception("The key field has a value other than `TimeRange'.");
            MortgageCalculatorInputVariableTimeRangeJSON result = new MortgageCalculatorInputVariableTimeRangeJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMortgageCalculatorInputVariableTimeRangeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(MortgageCalculatorInputVariableJSON new_result)
          {
            handle_result((MortgageCalculatorInputVariableTimeRangeJSON )new_result);
          }
        protected void finish(MortgageCalculatorInputVariableTimeRangeJSON result)
          {
            if (fieldGeneratorStart.have_value)
              {
                result.setStart(fieldGeneratorStart.value);
                fieldGeneratorStart.have_value = false;
              }
            else if ((!(result.hasStart())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Start\" field was missing.");
              }
            if (fieldGeneratorEnd.have_value)
              {
                result.setEnd(fieldGeneratorEnd.value);
                fieldGeneratorEnd.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(MortgageCalculatorInputVariableTimeRangeJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "nd", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorEnd;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "tart", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorStart;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorStart = new TypeStartJSON.HoldingGenerator("field \"Start\" of the MortgageCalculatorInputVariableTimeRange class", ignore_extras);
            fieldGeneratorEnd = new TypeEndJSON.HoldingGenerator("field \"End\" of the MortgageCalculatorInputVariableTimeRange class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MortgageCalculatorInputVariableTimeRange class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorStart = new TypeStartJSON.HoldingGenerator("field \"Start\" of the MortgageCalculatorInputVariableTimeRange class", false);
            fieldGeneratorEnd = new TypeEndJSON.HoldingGenerator("field \"End\" of the MortgageCalculatorInputVariableTimeRange class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MortgageCalculatorInputVariableTimeRange class");
          }

        public override void reset()
          {
            fieldGeneratorStart.reset();
            fieldGeneratorEnd.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MortgageCalculatorInputVariableTimeRangeJSON  result)
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
        public MortgageCalculatorInputVariableTimeRangeJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MortgageCalculatorInputVariableTimeRangeJSON  result)
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
    protected virtual void handle_result(List<MortgageCalculatorInputVariableTimeRangeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MortgageCalculatorInputVariableTimeRangeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MortgageCalculatorInputVariableTimeRangeJSON>();
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
    public List<MortgageCalculatorInputVariableTimeRangeJSON> value;
  };
  };
