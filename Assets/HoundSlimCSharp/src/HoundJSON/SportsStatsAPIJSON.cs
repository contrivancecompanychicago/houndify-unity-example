/* file "SportsStatsAPIJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsStatsAPIJSON : JSONBase
  {
    public class TypeValueJSON : JSONBase
      {
        public class TypeStatsJSON : JSONBase
          {
            public enum TypeValueKnownValues
              {
                Value_Unavailable,
                Value__none
              };
            public struct TypeValue
              {
                public bool in_known_list;
                public string string_value;
                public TypeValueKnownValues list_value;
              };

            public static TypeValueKnownValues  stringToValue(string chars)
              {
                if ((String.Compare(chars, 0, "Unavailable", 0, 11, false) == 0) && (chars.Length == 11))
                    return TypeValueKnownValues.Value_Unavailable;
                return TypeValueKnownValues.Value__none;
              }

            public static string  stringFromValue(TypeValueKnownValues the_enum)
              {
                switch (the_enum)
                  {
                    case TypeValueKnownValues.Value_Unavailable:
                        return "Unavailable";
                    default:
                        Debug.Assert(false);
                        return null;
                  }
              }

            public class TypeSplitJSON : JSONBase
              {
                private bool flagHasSplitClass;
                private string storeSplitClass;
                private bool flagHasSplitValue;
                private string storeSplitValue;
                private List<string> extraKeys;
                private List<JSONValue > extraValues;
                private Dictionary<string, JSONValue > extraIndex;


                private void  fromJSONSplitClass(JSONValue json_value, bool ignore_extras)
                  {
                    Debug.Assert(json_value != null);
                    JSONStringValue json_string = json_value.string_value();
                    if (json_string == null)
                        throw new Exception("The value for field SplitClass of TypeSplitJSON is not a string.");
                    setSplitClass(json_string.getData());
                  }


                private void  fromJSONSplitValue(JSONValue json_value, bool ignore_extras)
                  {
                    Debug.Assert(json_value != null);
                    JSONStringValue json_string = json_value.string_value();
                    if (json_string == null)
                        throw new Exception("The value for field SplitValue of TypeSplitJSON is not a string.");
                    setSplitValue(json_string.getData());
                  }


                public TypeSplitJSON()
                  {
                    flagHasSplitClass = false;
                    flagHasSplitValue = false;
                    extraKeys = new List<string>();
                extraValues = new List<JSONValue >();
                extraIndex = new Dictionary<string, JSONValue >();
                  }

                public bool  hasSplitClass()
                  {
                    return flagHasSplitClass;
                  }

                public string  getSplitClass()
                  {
                    Debug.Assert(flagHasSplitClass);
                    return storeSplitClass;
                  }

                public bool  hasSplitValue()
                  {
                    return flagHasSplitValue;
                  }

                public string  getSplitValue()
                  {
                    Debug.Assert(flagHasSplitValue);
                    return storeSplitValue;
                  }


                public virtual int extraTypeSplitComponentCount()
                  {
                    Debug.Assert(extraKeys.Count == extraValues.Count);
                    return extraKeys.Count;
                  }
                public virtual string extraTypeSplitComponentKey(int component_num)
                  {
                    Debug.Assert(extraKeys.Count == extraValues.Count);
                    Debug.Assert(component_num < extraValues.Count);
                    return extraKeys[component_num];
                  }
                public virtual JSONValue extraTypeSplitComponentValue(int component_num)
                  {
                    Debug.Assert(extraKeys.Count == extraValues.Count);
                    Debug.Assert(component_num < extraValues.Count);
                    return extraValues[component_num];
                  }
                public virtual JSONValue extraTypeSplitLookup(string field_name)
                  {
                    JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                    return result;
                  }

                public void setSplitClass(string new_value)
                  {
                    flagHasSplitClass = true;
                    storeSplitClass = new_value;
                  }
                public void unsetSplitClass()
                  {
                    flagHasSplitClass = false;
                  }
                public void setSplitValue(string new_value)
                  {
                    flagHasSplitValue = true;
                    storeSplitValue = new_value;
                  }
                public void unsetSplitValue()
                  {
                    flagHasSplitValue = false;
                  }

                public virtual void extraTypeSplitAppendPair(string key, JSONValue new_component)
                  {
                    Debug.Assert(key != null);
                    Debug.Assert(new_component != null);

                    Debug.Assert(extraKeys.Count == extraValues.Count);
                    extraKeys.Add(key);
                    extraValues.Add(new_component);
                    extraIndex.Add(key, new_component);
                  }
                public virtual void extraTypeSplitSetField(string key, JSONValue new_component)
                  {
                    Debug.Assert(key != null);
                    Debug.Assert(new_component != null);

                    JSONValue old_field = extraTypeSplitLookup(key);
                    if (old_field == null)
                      {
                        extraTypeSplitAppendPair(key, new_component);
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
                    Debug.Assert(partial_allowed || flagHasSplitClass);
                    if (flagHasSplitClass)
                      {
                        handler.start_pair("SplitClass");
                        handler.string_value(storeSplitClass);
                      }
                    Debug.Assert(partial_allowed || flagHasSplitValue);
                    if (flagHasSplitValue)
                      {
                        handler.start_pair("SplitValue");
                        handler.string_value(storeSplitValue);
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
                    if (!(hasSplitClass()))
                      {
                        return "When parsing the object for %what%, the \"SplitClass\" field was missing.";
                      }
                    if (!(hasSplitValue()))
                      {
                        return "When parsing the object for %what%, the \"SplitValue\" field was missing.";
                      }
                    return null;
                  }

                public static TypeSplitJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                  {
                    TypeSplitJSON result;
                      {
                        HoldingGenerator generator = new HoldingGenerator("Type TypeSplit", ignore_extras);
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
                public static TypeSplitJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
              {
                return from_json(json_value, ignore_extras, allow_incomplete, false);
              }
                public static TypeSplitJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                  {
                    TypeSplitJSON result;
                      {
                        HoldingGenerator generator = new HoldingGenerator("Type TypeSplit", ignore_extras);
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
                public static TypeSplitJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
              {
                return from_json(json_value, ignore_extras, allow_incomplete, false);
              }
                public static TypeSplitJSON from_text(string text, bool ignore_extras)
                  {
                    TypeSplitJSON result;
                      {
                        HoldingGenerator generator = new HoldingGenerator("Type TypeSplit", ignore_extras);
                        JSONParse.parse_json_value(text, "Text for TypeSplitJSON", generator);
                        Debug.Assert(generator.have_value);
                        result = generator.value;
                      };
                    return result;
                  }
                public static TypeSplitJSON from_file(TextReader fp, string file_name, bool ignore_extras)
                  {
                    TypeSplitJSON result;
                      {
                        HoldingGenerator generator = new HoldingGenerator("Type TypeSplit", ignore_extras);
                        JSONParse.parse_json_value(fp, file_name, generator);
                        Debug.Assert(generator.have_value);
                        result = generator.value;
                      };
                    return result;
                  }
                public abstract class Generator : JSONObjectGenerator
                  {
                    private JSONHoldingStringGenerator fieldGeneratorSplitClass;
                    private JSONHoldingStringGenerator fieldGeneratorSplitValue;
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
                        TypeSplitJSON result = new TypeSplitJSON();
                        Debug.Assert(result != null);
                        finish(result);
                        int extra_count = unknownFieldGenerator.field_names.Count;
                        Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                        for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                          {
                            result.extraTypeSplitAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                          }
                        unknownFieldGenerator.field_names.Clear();
                        unknownFieldGenerator.field_values.Clear();
                        unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                        handle_result(result);
                      }
                    protected void finish(TypeSplitJSON result)
                      {
                        if (fieldGeneratorSplitClass.have_value)
                          {
                            result.setSplitClass(fieldGeneratorSplitClass.value);
                            fieldGeneratorSplitClass.have_value = false;
                          }
                        else if ((!(result.hasSplitClass())) && !allow_incomplete)
                          {
                            error("When parsing the object for %what%, the \"SplitClass\" field was missing.");
                          }
                        if (fieldGeneratorSplitValue.have_value)
                          {
                            result.setSplitValue(fieldGeneratorSplitValue.value);
                            fieldGeneratorSplitValue.have_value = false;
                          }
                        else if ((!(result.hasSplitValue())) && !allow_incomplete)
                          {
                            error("When parsing the object for %what%, the \"SplitValue\" field was missing.");
                          }
                      }
                    protected abstract void handle_result(TypeSplitJSON new_result);
                    protected virtual JSONHandler start_known_field(string field_name)
                      {
                        if (String.Compare(field_name, 0, "Split", 0, 5, false) == 0)
                          {
                            switch (field_name[5])
                              {
                                case 'C':
                                    if ((String.Compare(field_name, 6, "lass", 0, 4, false) == 0) && (field_name.Length == 10))
                                        return fieldGeneratorSplitClass;
                                    break;
                                case 'V':
                                    if ((String.Compare(field_name, 6, "alue", 0, 4, false) == 0) && (field_name.Length == 10))
                                        return fieldGeneratorSplitValue;
                                    break;
                                default:
                                    break;
                              }
                          }
                        return null;
                      }
                    public Generator(bool ignore_extras)
                      {
                        fieldGeneratorSplitClass = new JSONHoldingStringGenerator("field \"SplitClass\" of the TypeSplit class");
                        fieldGeneratorSplitValue = new JSONHoldingStringGenerator("field \"SplitValue\" of the TypeSplit class");
                        unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                        set_what("the TypeSplit class");
                        allow_incomplete = false;
                        allow_unpolished = false;
                      }
                    public Generator()
                      {
                        fieldGeneratorSplitClass = new JSONHoldingStringGenerator("field \"SplitClass\" of the TypeSplit class");
                        fieldGeneratorSplitValue = new JSONHoldingStringGenerator("field \"SplitValue\" of the TypeSplit class");
                        unknownFieldGenerator = new UnknownFieldGenerator(false);
                        set_what("the TypeSplit class");
                        allow_incomplete = false;
                        allow_unpolished = false;
                      }

                    public override void reset()
                      {
                        fieldGeneratorSplitClass.reset();
                        fieldGeneratorSplitValue.reset();
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
                    protected override void handle_result(TypeSplitJSON  result)
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
                    public TypeSplitJSON value;
                  };
                public class HoldingArrayGenerator : JSONArrayGenerator
              {
                protected class ElementHandler : Generator
                  {
                    private HoldingArrayGenerator top;

                    protected override void handle_result(TypeSplitJSON  result)
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
                protected virtual void handle_result(List<TypeSplitJSON> result)

                  {
                  }

                public HoldingArrayGenerator(string what, bool ignore_extras)
                  {
                    element_handler = new ElementHandler(this, ignore_extras);
                    have_value = false;
                    value = new List<TypeSplitJSON>();
                    base.set_what(what);
                  }
                public HoldingArrayGenerator(bool ignore_extras)
                  {
                    element_handler = new ElementHandler(this, ignore_extras);
                    value = new List<TypeSplitJSON>();
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
                public List<TypeSplitJSON> value;
              };
              };
            private bool flagHasName;
            private string storeName;
            private bool flagHasValue;
            private TypeValue storeValue;
            private bool flagHasValueNumeric;
            private double storeValueNumeric;
            private string textStoreValueNumeric;
            private bool flagHasSeason;
            private SportsSeasonJSON  storeSeason;
            private bool flagHasSplit;
            private TypeSplitJSON  storeSplit;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONName(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field Name of TypeStatsJSON is not a string.");
                setName(json_string.getData());
              }


            private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field Value of TypeStatsJSON is not a string.");
                TypeValue the_open_enum = new TypeValue();
                if ((String.Compare(json_string.getData(), 0, "Unavailable", 0, 11, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Unavailable;
                        goto open_enum_is_done;
                      }
                the_open_enum.in_known_list = false;
                the_open_enum.string_value = json_string.getData();
              open_enum_is_done:;
                setValue(the_open_enum);
              }


            private void  fromJSONValueNumeric(JSONValue json_value, bool ignore_extras)
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
                        throw new Exception("The value for field ValueNumeric of TypeStatsJSON is not a number.");
                      }
                  }
                setValueNumericText(the_rational_text);
              }


            private void  fromJSONSeason(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                SportsSeasonJSON convert_classy = SportsSeasonJSON.from_json(json_value, ignore_extras, true);
                setSeason(convert_classy);
              }


            private void  fromJSONSplit(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                TypeSplitJSON convert_classy = TypeSplitJSON.from_json(json_value, ignore_extras, true);
                setSplit(convert_classy);
              }


            public TypeStatsJSON()
              {
                flagHasName = false;
                flagHasValue = false;
                flagHasValueNumeric = false;
                flagHasSeason = false;
                flagHasSplit = false;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasName()
              {
                return flagHasName;
              }

            public string  getName()
              {
                Debug.Assert(flagHasName);
                return storeName;
              }

            public bool  hasValue()
              {
                return flagHasValue;
              }

            public TypeValue  getValue()
              {
                Debug.Assert(flagHasValue);
                return storeValue;
              }

            public string  getValueAsString()
              {
                TypeValue result = getValue();
                if (result.in_known_list)
                    return stringFromValue(result.list_value);
                else
                    return result.string_value;
              }

            public bool  hasValueNumeric()
              {
                return flagHasValueNumeric;
              }

            public double  getValueNumeric()
              {
                Debug.Assert(flagHasValueNumeric);
                if (textStoreValueNumeric != "")
                  {
                    return Double.Parse(textStoreValueNumeric);
                  }
                return storeValueNumeric;
              }

            public string  getValueNumericAsText()
              {
                Debug.Assert(flagHasValueNumeric);
                if (textStoreValueNumeric == "")
                  {
                    return Convert.ToString(storeValueNumeric);
                  }
                else
                  {
                    return (textStoreValueNumeric);
                  }
              }

            public bool  hasSeason()
              {
                return flagHasSeason;
              }

            public SportsSeasonJSON   getSeason()
              {
                Debug.Assert(flagHasSeason);
                return storeSeason;
              }

            public bool  hasSplit()
              {
                return flagHasSplit;
              }

            public TypeSplitJSON   getSplit()
              {
                Debug.Assert(flagHasSplit);
                return storeSplit;
              }


            public virtual int extraTypeStatsComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypeStatsComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypeStatsComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypeStatsLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setName(string new_value)
              {
                flagHasName = true;
                storeName = new_value;
              }
            public void unsetName()
              {
                flagHasName = false;
              }
            public void setValue(TypeValue new_value)
              {
                flagHasValue = true;
                storeValue = new_value;
              }
            public void setValue(string chars)
              {
                TypeValueKnownValues known = stringToValue(chars);
                TypeValue new_value = new TypeValue();
                if (known == TypeValueKnownValues.Value__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = chars;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                setValue(new_value);
              }
            public void setValue(TypeValueKnownValues new_value)
              {
                TypeValue new_full_value = new TypeValue();
                Debug.Assert(new_value != TypeValueKnownValues.Value__none);
                new_full_value.in_known_list = true;
                new_full_value.list_value = new_value;
                setValue(new_full_value);
              }
            public void unsetValue()
              {
                flagHasValue = false;
              }
            public void setValueNumeric(double new_value)
              {
                flagHasValueNumeric = true;
                storeValueNumeric = new_value;
                textStoreValueNumeric = "";
              }
            public void setValueNumericText(string new_value)
              {
                flagHasValueNumeric = true;
                if (!(JSONWriter.is_valid_number_format(new_value)))
                    throw new Exception("The text value for field ValueNumeric of TypeStatsJSON is not a valid number.");
                textStoreValueNumeric = new_value;
              }
            public void unsetValueNumeric()
              {
                flagHasValueNumeric = false;
              }
            public void setSeason(SportsSeasonJSON  new_value)
              {
                if (flagHasSeason)
                  {
                  }
                flagHasSeason = true;
                storeSeason = new_value;
              }
            public void unsetSeason()
              {
                if (flagHasSeason)
                  {
                  }
                flagHasSeason = false;
              }
            public void setSplit(TypeSplitJSON  new_value)
              {
                if (flagHasSplit)
                  {
                  }
                flagHasSplit = true;
                storeSplit = new_value;
              }
            public void unsetSplit()
              {
                if (flagHasSplit)
                  {
                  }
                flagHasSplit = false;
              }

            public virtual void extraTypeStatsAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypeStatsSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypeStatsLookup(key);
                if (old_field == null)
                  {
                    extraTypeStatsAppendPair(key, new_component);
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
                Debug.Assert(partial_allowed || flagHasName);
                if (flagHasName)
                  {
                    handler.start_pair("Name");
                    handler.string_value(storeName);
                  }
                Debug.Assert(partial_allowed || flagHasValue);
                if (flagHasValue)
                  {
                    handler.start_pair("Value");
                    if (storeValue.in_known_list)
                      {
                        switch (storeValue.list_value)
                          {
                            case TypeValueKnownValues.Value_Unavailable:
                                handler.string_value("Unavailable");
                                break;
                            default:
                                Debug.Assert(false);
                                break;
                          }
                      }
                    else
                      {
                                handler.string_value(storeValue.string_value);
                      }
                  }
                if (flagHasValueNumeric)
                  {
                    handler.start_pair("ValueNumeric");
                    if (textStoreValueNumeric != "")
                        handler.number_value(textStoreValueNumeric);
                    else if (((double)(long)storeValueNumeric) == storeValueNumeric)
                        handler.number_value((long)storeValueNumeric);
                    else
                        handler.number_value(storeValueNumeric);
                  }
                if (flagHasSeason)
                  {
                    handler.start_pair("Season");
                    if (partial_allowed)
                        storeSeason.write_partial_as_json(handler);
                    else
                        storeSeason.write_as_json(handler);
                  }
                if (flagHasSplit)
                  {
                    handler.start_pair("Split");
                    if (partial_allowed)
                        storeSplit.write_partial_as_json(handler);
                    else
                        storeSplit.write_as_json(handler);
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
                if (!(hasName()))
                  {
                    return "When parsing the object for %what%, the \"Name\" field was missing.";
                  }
                if (!(hasValue()))
                  {
                    return "When parsing the object for %what%, the \"Value\" field was missing.";
                  }
                return null;
              }

            public static TypeStatsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeStatsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeStats", ignore_extras);
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
            public static TypeStatsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeStatsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeStatsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeStats", ignore_extras);
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
            public static TypeStatsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeStatsJSON from_text(string text, bool ignore_extras)
              {
                TypeStatsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeStats", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeStatsJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeStatsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeStatsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeStats", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private JSONHoldingStringGenerator fieldGeneratorName;
            private abstract class FieldGeneratorValue : JSONStringGenerator
                  {
                    protected FieldGeneratorValue(string what)
                      {
                        set_what(what);
                      }
                    protected FieldGeneratorValue()
                      {
                      }
                    protected override void handle_result(string result)
                      {
                        TypeValueKnownValues known = stringToValue(result);
                        TypeValue new_value = new TypeValue();
                        if (known == TypeValueKnownValues.Value__none)
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
                    protected abstract void handle_result(TypeValue result);
                  };
            private class FieldHoldingGeneratorValue : FieldGeneratorValue
          {
            protected override void handle_result(TypeValue result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = result;
              }

            public FieldHoldingGeneratorValue(String what)
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
            public TypeValue value;
          };
            private class FieldHoldingArrayGeneratorValue : JSONArrayGenerator
          {
            protected class ElementHandler : FieldGeneratorValue
              {
                private FieldHoldingArrayGeneratorValue top;

                protected override void handle_result(TypeValue result)
                  {
                    top.value.Add(result);
                  }
                protected override string get_what()
                  {
                    return "element " + top.value.Count + " of " + top.get_what();
                  }

                public ElementHandler(FieldHoldingArrayGeneratorValue init_top)
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
            protected virtual void handle_result(List<TypeValue> result)
              {
              }

            public FieldHoldingArrayGeneratorValue(string what)
              {
                element_handler = new ElementHandler(this);
                have_value = false;
                value = new List<TypeValue>();
                base.set_what(what);
              }
            public FieldHoldingArrayGeneratorValue()
              {
                element_handler = new ElementHandler(this);
                have_value = false;
                value = new List<TypeValue>();
              }

            public override void reset()
              {
                element_handler.reset();
                have_value = false;
                value.Clear();
                base.reset();
              }

            public bool have_value;
            public List<TypeValue> value;
          };
                private FieldHoldingGeneratorValue fieldGeneratorValue;
                private JSONHoldingNumberTextGenerator fieldGeneratorValueNumeric;
                private SportsSeasonJSON.HoldingGenerator fieldGeneratorSeason;
                private TypeSplitJSON.HoldingGenerator fieldGeneratorSplit;
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
                    TypeStatsJSON result = new TypeStatsJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypeStatsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypeStatsJSON result)
                  {
                    if (fieldGeneratorName.have_value)
                      {
                        result.setName(fieldGeneratorName.value);
                        fieldGeneratorName.have_value = false;
                      }
                    else if ((!(result.hasName())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Name\" field was missing.");
                      }
                    if (fieldGeneratorValue.have_value)
                      {
                        result.setValue(fieldGeneratorValue.value);
                        fieldGeneratorValue.have_value = false;
                      }
                    else if ((!(result.hasValue())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Value\" field was missing.");
                      }
                    if (fieldGeneratorValueNumeric.have_value)
                      {
                        result.setValueNumericText(fieldGeneratorValueNumeric.value);
                        fieldGeneratorValueNumeric.have_value = false;
                      }
                    if (fieldGeneratorSeason.have_value)
                      {
                        result.setSeason(fieldGeneratorSeason.value);
                        fieldGeneratorSeason.have_value = false;
                      }
                    if (fieldGeneratorSplit.have_value)
                      {
                        result.setSplit(fieldGeneratorSplit.value);
                        fieldGeneratorSplit.have_value = false;
                      }
                  }
                protected abstract void handle_result(TypeStatsJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    switch (field_name[0])
                      {
                        case 'N':
                            if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorName;
                            break;
                        case 'S':
                            switch (field_name[1])
                              {
                                case 'e':
                                    if ((String.Compare(field_name, 2, "ason", 0, 4, false) == 0) && (field_name.Length == 6))
                                        return fieldGeneratorSeason;
                                    break;
                                case 'p':
                                    if ((String.Compare(field_name, 2, "lit", 0, 3, false) == 0) && (field_name.Length == 5))
                                        return fieldGeneratorSplit;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'V':
                            if (String.Compare(field_name, 1, "alue", 0, 4, false) == 0)
                              {
                                if (field_name.Length == 5)
                                  {
                                    return fieldGeneratorValue;
                                  }
                                switch (field_name[5])
                                  {
                                    case 'N':
                                        if ((String.Compare(field_name, 6, "umeric", 0, 6, false) == 0) && (field_name.Length == 12))
                                            return fieldGeneratorValueNumeric;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the TypeStats class");
                    fieldGeneratorValue = new FieldHoldingGeneratorValue("field \"Value\" of the TypeStats class");
                    fieldGeneratorValueNumeric = new JSONHoldingNumberTextGenerator("field \"ValueNumeric\" of the TypeStats class");
                    fieldGeneratorSeason = new SportsSeasonJSON.HoldingGenerator("field \"Season\" of the TypeStats class", ignore_extras);
                    fieldGeneratorSplit = new TypeSplitJSON.HoldingGenerator("field \"Split\" of the TypeStats class", ignore_extras);
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypeStats class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the TypeStats class");
                    fieldGeneratorValue = new FieldHoldingGeneratorValue("field \"Value\" of the TypeStats class");
                    fieldGeneratorValueNumeric = new JSONHoldingNumberTextGenerator("field \"ValueNumeric\" of the TypeStats class");
                    fieldGeneratorSeason = new SportsSeasonJSON.HoldingGenerator("field \"Season\" of the TypeStats class", false);
                    fieldGeneratorSplit = new TypeSplitJSON.HoldingGenerator("field \"Split\" of the TypeStats class", false);
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypeStats class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorName.reset();
                    fieldGeneratorValue.reset();
                    fieldGeneratorValueNumeric.reset();
                    fieldGeneratorSeason.reset();
                    fieldGeneratorSplit.reset();
                    base.reset();
                    unknownFieldGenerator.reset();
                  }
                public void set_allow_incomplete(bool new_allow_incomplete)
                  {
                    allow_incomplete = new_allow_incomplete;
                    fieldGeneratorSeason.set_allow_incomplete(new_allow_incomplete);
                    fieldGeneratorSplit.set_allow_incomplete(new_allow_incomplete);
                  }
                public void set_allow_unpolished(bool new_allow_unpolished)
                  {
                    allow_unpolished = new_allow_unpolished;
                    fieldGeneratorSeason.set_allow_unpolished(new_allow_unpolished);
                    fieldGeneratorSplit.set_allow_unpolished(new_allow_unpolished);
                  }
              };
            public class HoldingGenerator : Generator
              {
                protected override void handle_result(TypeStatsJSON  result)
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
                public TypeStatsJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeStatsJSON  result)
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
            protected virtual void handle_result(List<TypeStatsJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeStatsJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeStatsJSON>();
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
            public List<TypeStatsJSON> value;
          };
          };
        private bool flagHasTeamID;
        private string storeTeamID;
        private bool flagHasPlayerID;
        private string storePlayerID;
        private bool flagHasGameID;
        private string storeGameID;
        private bool flagHasLeague;
        private string storeLeague;
        private bool flagHasStats;
        private List< TypeStatsJSON  > storeStats;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONTeamID(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field TeamID of TypeValueJSON is not a string.");
            setTeamID(json_string.getData());
          }


        private void  fromJSONPlayerID(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field PlayerID of TypeValueJSON is not a string.");
            setPlayerID(json_string.getData());
          }


        private void  fromJSONGameID(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field GameID of TypeValueJSON is not a string.");
            setGameID(json_string.getData());
          }


        private void  fromJSONLeague(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field League of TypeValueJSON is not a string.");
            setLeague(json_string.getData());
          }


        private void  fromJSONStats(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field Stats of TypeValueJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< TypeStatsJSON  > vector_Stats1 = new List< TypeStatsJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                TypeStatsJSON convert_classy = TypeStatsJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_Stats1.Add(convert_classy);
              }
            initStats();
            for (int num1 = 0; num1 < vector_Stats1.Count; ++num1)
                appendStats(vector_Stats1[num1]);
            for (int num1 = 0; num1 < vector_Stats1.Count; ++num1)
              {
              }
          }


        public TypeValueJSON()
          {
            flagHasTeamID = false;
            flagHasPlayerID = false;
            flagHasGameID = false;
            flagHasLeague = false;
            flagHasStats = false;
            storeStats = new List< TypeStatsJSON  >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasTeamID()
          {
            return flagHasTeamID;
          }

        public string  getTeamID()
          {
            Debug.Assert(flagHasTeamID);
            return storeTeamID;
          }

        public bool  hasPlayerID()
          {
            return flagHasPlayerID;
          }

        public string  getPlayerID()
          {
            Debug.Assert(flagHasPlayerID);
            return storePlayerID;
          }

        public bool  hasGameID()
          {
            return flagHasGameID;
          }

        public string  getGameID()
          {
            Debug.Assert(flagHasGameID);
            return storeGameID;
          }

        public bool  hasLeague()
          {
            return flagHasLeague;
          }

        public string  getLeague()
          {
            Debug.Assert(flagHasLeague);
            return storeLeague;
          }

        public bool  hasStats()
          {
            return flagHasStats;
          }

        public int  countOfStats()
          {
            Debug.Assert(flagHasStats);
            return storeStats.Count;
          }

        public TypeStatsJSON   elementOfStats(int element_num)
          {
            Debug.Assert(flagHasStats);
            return storeStats[element_num];
          }

        public List< TypeStatsJSON  >  getStats()
          {
            Debug.Assert(flagHasStats);
            return storeStats;
          }


        public virtual int extraTypeValueComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeValueComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeValueComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeValueLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setTeamID(string new_value)
          {
            flagHasTeamID = true;
            storeTeamID = new_value;
          }
        public void unsetTeamID()
          {
            flagHasTeamID = false;
          }
        public void setPlayerID(string new_value)
          {
            flagHasPlayerID = true;
            storePlayerID = new_value;
          }
        public void unsetPlayerID()
          {
            flagHasPlayerID = false;
          }
        public void setGameID(string new_value)
          {
            flagHasGameID = true;
            storeGameID = new_value;
          }
        public void unsetGameID()
          {
            flagHasGameID = false;
          }
        public void setLeague(string new_value)
          {
            flagHasLeague = true;
            storeLeague = new_value;
          }
        public void unsetLeague()
          {
            flagHasLeague = false;
          }
        public void initStats()
          {
            if (flagHasStats)
              {
                for (int num1 = 0; num1 < storeStats.Count; ++num1)
                  {
                  }
              }
            flagHasStats = true;
            storeStats.Clear();
          }
        public void appendStats(TypeStatsJSON  to_append)
          {
            if (!flagHasStats)
              {
                flagHasStats = true;
                storeStats.Clear();
              }
            Debug.Assert(flagHasStats);
            storeStats.Add(to_append);
          }
        public void unsetStats()
          {
            if (flagHasStats)
              {
                for (int num2 = 0; num2 < storeStats.Count; ++num2)
                  {
                  }
              }
            flagHasStats = false;
            storeStats.Clear();
          }

        public virtual void extraTypeValueAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeValueSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeValueLookup(key);
            if (old_field == null)
              {
                extraTypeValueAppendPair(key, new_component);
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
            if (flagHasTeamID)
              {
                handler.start_pair("TeamID");
                handler.string_value(storeTeamID);
              }
            if (flagHasPlayerID)
              {
                handler.start_pair("PlayerID");
                handler.string_value(storePlayerID);
              }
            if (flagHasGameID)
              {
                handler.start_pair("GameID");
                handler.string_value(storeGameID);
              }
            Debug.Assert(partial_allowed || flagHasLeague);
            if (flagHasLeague)
              {
                handler.start_pair("League");
                handler.string_value(storeLeague);
              }
            Debug.Assert(partial_allowed || flagHasStats);
            if (flagHasStats)
              {
                handler.start_pair("Stats");
                handler.start_array();
                for (int num1 = 0; num1 < storeStats.Count; ++num1)
                  {
                    if (partial_allowed)
                        storeStats[num1].write_partial_as_json(handler);
                    else
                        storeStats[num1].write_as_json(handler);
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
        public virtual string missing_field_error(bool allow_unpolished)
          {
            if (!(hasLeague()))
              {
                return "When parsing the object for %what%, the \"League\" field was missing.";
              }
            if (!(hasStats()))
              {
                return "When parsing the object for %what%, the \"Stats\" field was missing.";
              }
            return null;
          }

        public static TypeValueJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeValueJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeValue", ignore_extras);
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
        public static TypeValueJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeValueJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeValueJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeValue", ignore_extras);
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
        public static TypeValueJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeValueJSON from_text(string text, bool ignore_extras)
          {
            TypeValueJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeValue", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeValueJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeValueJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeValueJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeValue", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorTeamID;
            private JSONHoldingStringGenerator fieldGeneratorPlayerID;
            private JSONHoldingStringGenerator fieldGeneratorGameID;
            private JSONHoldingStringGenerator fieldGeneratorLeague;
            private TypeStatsJSON.HoldingArrayGenerator fieldGeneratorStats;
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
                TypeValueJSON result = new TypeValueJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeValueAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeValueJSON result)
              {
                if (fieldGeneratorTeamID.have_value)
                  {
                    result.setTeamID(fieldGeneratorTeamID.value);
                    fieldGeneratorTeamID.have_value = false;
                  }
                if (fieldGeneratorPlayerID.have_value)
                  {
                    result.setPlayerID(fieldGeneratorPlayerID.value);
                    fieldGeneratorPlayerID.have_value = false;
                  }
                if (fieldGeneratorGameID.have_value)
                  {
                    result.setGameID(fieldGeneratorGameID.value);
                    fieldGeneratorGameID.have_value = false;
                  }
                if (fieldGeneratorLeague.have_value)
                  {
                    result.setLeague(fieldGeneratorLeague.value);
                    fieldGeneratorLeague.have_value = false;
                  }
                else if ((!(result.hasLeague())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"League\" field was missing.");
                  }
                if (fieldGeneratorStats.have_value)
                  {
                    result.initStats();
                    int count = fieldGeneratorStats.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendStats(fieldGeneratorStats.value[num]);
                      }
                    fieldGeneratorStats.value.Clear();
                    fieldGeneratorStats.have_value = false;
                  }
                else if ((!(result.hasStats())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Stats\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeValueJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'G':
                        if ((String.Compare(field_name, 1, "ameID", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorGameID;
                        break;
                    case 'L':
                        if ((String.Compare(field_name, 1, "eague", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorLeague;
                        break;
                    case 'P':
                        if ((String.Compare(field_name, 1, "layerID", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorPlayerID;
                        break;
                    case 'S':
                        if ((String.Compare(field_name, 1, "tats", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorStats;
                        break;
                    case 'T':
                        if ((String.Compare(field_name, 1, "eamID", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorTeamID;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorTeamID = new JSONHoldingStringGenerator("field \"TeamID\" of the TypeValue class");
                fieldGeneratorPlayerID = new JSONHoldingStringGenerator("field \"PlayerID\" of the TypeValue class");
                fieldGeneratorGameID = new JSONHoldingStringGenerator("field \"GameID\" of the TypeValue class");
                fieldGeneratorLeague = new JSONHoldingStringGenerator("field \"League\" of the TypeValue class");
                fieldGeneratorStats = new TypeStatsJSON.HoldingArrayGenerator("field \"Stats\" of the TypeValue class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeValue class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorTeamID = new JSONHoldingStringGenerator("field \"TeamID\" of the TypeValue class");
                fieldGeneratorPlayerID = new JSONHoldingStringGenerator("field \"PlayerID\" of the TypeValue class");
                fieldGeneratorGameID = new JSONHoldingStringGenerator("field \"GameID\" of the TypeValue class");
                fieldGeneratorLeague = new JSONHoldingStringGenerator("field \"League\" of the TypeValue class");
                fieldGeneratorStats = new TypeStatsJSON.HoldingArrayGenerator("field \"Stats\" of the TypeValue class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeValue class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorTeamID.reset();
                fieldGeneratorPlayerID.reset();
                fieldGeneratorGameID.reset();
                fieldGeneratorLeague.reset();
                fieldGeneratorStats.reset();
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
            protected override void handle_result(TypeValueJSON  result)
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
            public TypeValueJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeValueJSON  result)
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
        protected virtual void handle_result(List<TypeValueJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeValueJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeValueJSON>();
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
        public List<TypeValueJSON> value;
      };
      };
    private bool flagHasValue;
    private List< TypeValueJSON  > storeValue;


    private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Value of SportsStatsAPIJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeValueJSON  > vector_Value1 = new List< TypeValueJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeValueJSON convert_classy = TypeValueJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Value1.Add(convert_classy);
          }
        initValue();
        for (int num2 = 0; num2 < vector_Value1.Count; ++num2)
            appendValue(vector_Value1[num2]);
        for (int num1 = 0; num1 < vector_Value1.Count; ++num1)
          {
          }
      }


    public SportsStatsAPIJSON()
      {
        flagHasValue = false;
        storeValue = new List< TypeValueJSON  >();
      }

    public bool  hasValue()
      {
        return flagHasValue;
      }

    public int  countOfValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue.Count;
      }

    public TypeValueJSON   elementOfValue(int element_num)
      {
        Debug.Assert(flagHasValue);
        return storeValue[element_num];
      }

    public List< TypeValueJSON  >  getValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue;
      }



    public void initValue()
      {
        if (flagHasValue)
          {
            for (int num3 = 0; num3 < storeValue.Count; ++num3)
              {
              }
          }
        flagHasValue = true;
        storeValue.Clear();
      }
    public void appendValue(TypeValueJSON  to_append)
      {
        if (!flagHasValue)
          {
            flagHasValue = true;
            storeValue.Clear();
          }
        Debug.Assert(flagHasValue);
        storeValue.Add(to_append);
      }
    public void unsetValue()
      {
        if (flagHasValue)
          {
            for (int num4 = 0; num4 < storeValue.Count; ++num4)
              {
              }
          }
        flagHasValue = false;
        storeValue.Clear();
      }


    public override void write_as_json(JSONHandler handler)
      {
        handler.start_array();
        for (int num1 = 0; num1 < storeValue.Count; ++num1)
          {
            storeValue[num1].write_as_json(handler);
          }
        handler.finish_array();
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_array();
        for (int num2 = 0; num2 < storeValue.Count; ++num2)
          {
            storeValue[num2].write_partial_as_json(handler);
          }
        handler.finish_array();
      }

    public static SportsStatsAPIJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStatsAPIJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStatsAPI", ignore_extras);
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
    public static SportsStatsAPIJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsStatsAPIJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStatsAPIJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStatsAPI", ignore_extras);
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
    public static SportsStatsAPIJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsStatsAPIJSON from_text(string text, bool ignore_extras)
      {
        SportsStatsAPIJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStatsAPI", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsStatsAPIJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsStatsAPIJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsStatsAPIJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStatsAPI", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : TypeValueJSON.HoldingArrayGenerator
      {
        protected void finish()
          {
            Debug.Assert(have_value);
            SportsStatsAPIJSON result = new SportsStatsAPIJSON();
            result.initValue();
            int count = value.Count;
            for (int num = 0; num < count; ++num)
              {
                result.appendValue(value[num]);
              }
            handle_result(result);
          }
        protected abstract void handle_result(SportsStatsAPIJSON new_result);
        public Generator(bool ignore_extras) : base("Type SportsStatsAPI", ignore_extras)
          {
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsStatsAPIJSON  result)
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
        public SportsStatsAPIJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsStatsAPIJSON  result)
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
    protected virtual void handle_result(List<SportsStatsAPIJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsStatsAPIJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsStatsAPIJSON>();
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
    public List<SportsStatsAPIJSON> value;
  };
  };
