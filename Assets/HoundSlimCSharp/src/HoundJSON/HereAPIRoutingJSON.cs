/* file "HereAPIRoutingJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HereAPIRoutingJSON : JSONBase
  {
    public class TyperesponseJSON : JSONBase
      {
        public class TyperouteJSON : JSONBase
          {
            public class TypesummaryJSON : JSONBase
              {
                private bool flagHasdistance;
                private double storedistance;
                private string textStoredistance;
                private bool flagHastravelTime;
                private double storetravelTime;
                private string textStoretravelTime;
                private List<string> extraKeys;
                private List<JSONValue > extraValues;
                private Dictionary<string, JSONValue > extraIndex;


                private void  fromJSONdistance(JSONValue json_value, bool ignore_extras)
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
                            throw new Exception("The value for field distance of TypesummaryJSON is not a number.");
                          }
                      }
                    setdistanceText(the_rational_text);
                  }


                private void  fromJSONtravelTime(JSONValue json_value, bool ignore_extras)
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
                            throw new Exception("The value for field travelTime of TypesummaryJSON is not a number.");
                          }
                      }
                    settravelTimeText(the_rational_text);
                  }


                public TypesummaryJSON()
                  {
                    flagHasdistance = false;
                    flagHastravelTime = false;
                    extraKeys = new List<string>();
                extraValues = new List<JSONValue >();
                extraIndex = new Dictionary<string, JSONValue >();
                  }

                public bool  hasdistance()
                  {
                    return flagHasdistance;
                  }

                public double  getdistance()
                  {
                    Debug.Assert(flagHasdistance);
                    if (textStoredistance != "")
                      {
                        return Double.Parse(textStoredistance);
                      }
                    return storedistance;
                  }

                public string  getdistanceAsText()
                  {
                    Debug.Assert(flagHasdistance);
                    if (textStoredistance == "")
                      {
                        return Convert.ToString(storedistance);
                      }
                    else
                      {
                        return (textStoredistance);
                      }
                  }

                public bool  hastravelTime()
                  {
                    return flagHastravelTime;
                  }

                public double  gettravelTime()
                  {
                    Debug.Assert(flagHastravelTime);
                    if (textStoretravelTime != "")
                      {
                        return Double.Parse(textStoretravelTime);
                      }
                    return storetravelTime;
                  }

                public string  gettravelTimeAsText()
                  {
                    Debug.Assert(flagHastravelTime);
                    if (textStoretravelTime == "")
                      {
                        return Convert.ToString(storetravelTime);
                      }
                    else
                      {
                        return (textStoretravelTime);
                      }
                  }


                public virtual int extraTypesummaryComponentCount()
                  {
                    Debug.Assert(extraKeys.Count == extraValues.Count);
                    return extraKeys.Count;
                  }
                public virtual string extraTypesummaryComponentKey(int component_num)
                  {
                    Debug.Assert(extraKeys.Count == extraValues.Count);
                    Debug.Assert(component_num < extraValues.Count);
                    return extraKeys[component_num];
                  }
                public virtual JSONValue extraTypesummaryComponentValue(int component_num)
                  {
                    Debug.Assert(extraKeys.Count == extraValues.Count);
                    Debug.Assert(component_num < extraValues.Count);
                    return extraValues[component_num];
                  }
                public virtual JSONValue extraTypesummaryLookup(string field_name)
                  {
                    JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                    return result;
                  }

                public void setdistance(double new_value)
                  {
                    flagHasdistance = true;
                    storedistance = new_value;
                    textStoredistance = "";
                  }
                public void setdistanceText(string new_value)
                  {
                    flagHasdistance = true;
                    if (!(JSONWriter.is_valid_number_format(new_value)))
                        throw new Exception("The text value for field distance of TypesummaryJSON is not a valid number.");
                    textStoredistance = new_value;
                  }
                public void unsetdistance()
                  {
                    flagHasdistance = false;
                  }
                public void settravelTime(double new_value)
                  {
                    flagHastravelTime = true;
                    storetravelTime = new_value;
                    textStoretravelTime = "";
                  }
                public void settravelTimeText(string new_value)
                  {
                    flagHastravelTime = true;
                    if (!(JSONWriter.is_valid_number_format(new_value)))
                        throw new Exception("The text value for field travelTime of TypesummaryJSON is not a valid number.");
                    textStoretravelTime = new_value;
                  }
                public void unsettravelTime()
                  {
                    flagHastravelTime = false;
                  }

                public virtual void extraTypesummaryAppendPair(string key, JSONValue new_component)
                  {
                    Debug.Assert(key != null);
                    Debug.Assert(new_component != null);

                    Debug.Assert(extraKeys.Count == extraValues.Count);
                    extraKeys.Add(key);
                    extraValues.Add(new_component);
                    extraIndex.Add(key, new_component);
                  }
                public virtual void extraTypesummarySetField(string key, JSONValue new_component)
                  {
                    Debug.Assert(key != null);
                    Debug.Assert(new_component != null);

                    JSONValue old_field = extraTypesummaryLookup(key);
                    if (old_field == null)
                      {
                        extraTypesummaryAppendPair(key, new_component);
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
                    Debug.Assert(partial_allowed || flagHasdistance);
                    if (flagHasdistance)
                      {
                        handler.start_pair("distance");
                        if (textStoredistance != "")
                            handler.number_value(textStoredistance);
                        else if (((double)(long)storedistance) == storedistance)
                            handler.number_value((long)storedistance);
                        else
                            handler.number_value(storedistance);
                      }
                    Debug.Assert(partial_allowed || flagHastravelTime);
                    if (flagHastravelTime)
                      {
                        handler.start_pair("travelTime");
                        if (textStoretravelTime != "")
                            handler.number_value(textStoretravelTime);
                        else if (((double)(long)storetravelTime) == storetravelTime)
                            handler.number_value((long)storetravelTime);
                        else
                            handler.number_value(storetravelTime);
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
                    if (!(hasdistance()))
                      {
                        return "When parsing the object for %what%, the \"distance\" field was missing.";
                      }
                    if (!(hastravelTime()))
                      {
                        return "When parsing the object for %what%, the \"travelTime\" field was missing.";
                      }
                    return null;
                  }

                public static TypesummaryJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                  {
                    TypesummaryJSON result;
                      {
                        HoldingGenerator generator = new HoldingGenerator("Type Typesummary", ignore_extras);
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
                public static TypesummaryJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
              {
                return from_json(json_value, ignore_extras, allow_incomplete, false);
              }
                public static TypesummaryJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                  {
                    TypesummaryJSON result;
                      {
                        HoldingGenerator generator = new HoldingGenerator("Type Typesummary", ignore_extras);
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
                public static TypesummaryJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
              {
                return from_json(json_value, ignore_extras, allow_incomplete, false);
              }
                public static TypesummaryJSON from_text(string text, bool ignore_extras)
                  {
                    TypesummaryJSON result;
                      {
                        HoldingGenerator generator = new HoldingGenerator("Type Typesummary", ignore_extras);
                        JSONParse.parse_json_value(text, "Text for TypesummaryJSON", generator);
                        Debug.Assert(generator.have_value);
                        result = generator.value;
                      };
                    return result;
                  }
                public static TypesummaryJSON from_file(TextReader fp, string file_name, bool ignore_extras)
                  {
                    TypesummaryJSON result;
                      {
                        HoldingGenerator generator = new HoldingGenerator("Type Typesummary", ignore_extras);
                        JSONParse.parse_json_value(fp, file_name, generator);
                        Debug.Assert(generator.have_value);
                        result = generator.value;
                      };
                    return result;
                  }
                public abstract class Generator : JSONObjectGenerator
                  {
                    private JSONHoldingNumberTextGenerator fieldGeneratordistance;
                    private JSONHoldingNumberTextGenerator fieldGeneratortravelTime;
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
                        TypesummaryJSON result = new TypesummaryJSON();
                        Debug.Assert(result != null);
                        finish(result);
                        int extra_count = unknownFieldGenerator.field_names.Count;
                        Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                        for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                          {
                            result.extraTypesummaryAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                          }
                        unknownFieldGenerator.field_names.Clear();
                        unknownFieldGenerator.field_values.Clear();
                        unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                        handle_result(result);
                      }
                    protected void finish(TypesummaryJSON result)
                      {
                        if (fieldGeneratordistance.have_value)
                          {
                            result.setdistanceText(fieldGeneratordistance.value);
                            fieldGeneratordistance.have_value = false;
                          }
                        else if ((!(result.hasdistance())) && !allow_incomplete)
                          {
                            error("When parsing the object for %what%, the \"distance\" field was missing.");
                          }
                        if (fieldGeneratortravelTime.have_value)
                          {
                            result.settravelTimeText(fieldGeneratortravelTime.value);
                            fieldGeneratortravelTime.have_value = false;
                          }
                        else if ((!(result.hastravelTime())) && !allow_incomplete)
                          {
                            error("When parsing the object for %what%, the \"travelTime\" field was missing.");
                          }
                      }
                    protected abstract void handle_result(TypesummaryJSON new_result);
                    protected virtual JSONHandler start_known_field(string field_name)
                      {
                        switch (field_name[0])
                          {
                            case 'd':
                                if ((String.Compare(field_name, 1, "istance", 0, 7, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratordistance;
                                break;
                            case 't':
                                if ((String.Compare(field_name, 1, "ravelTime", 0, 9, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratortravelTime;
                                break;
                            default:
                                break;
                          }
                        return null;
                      }
                    public Generator(bool ignore_extras)
                      {
                        fieldGeneratordistance = new JSONHoldingNumberTextGenerator("field \"distance\" of the Typesummary class");
                        fieldGeneratortravelTime = new JSONHoldingNumberTextGenerator("field \"travelTime\" of the Typesummary class");
                        unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                        set_what("the Typesummary class");
                        allow_incomplete = false;
                        allow_unpolished = false;
                      }
                    public Generator()
                      {
                        fieldGeneratordistance = new JSONHoldingNumberTextGenerator("field \"distance\" of the Typesummary class");
                        fieldGeneratortravelTime = new JSONHoldingNumberTextGenerator("field \"travelTime\" of the Typesummary class");
                        unknownFieldGenerator = new UnknownFieldGenerator(false);
                        set_what("the Typesummary class");
                        allow_incomplete = false;
                        allow_unpolished = false;
                      }

                    public override void reset()
                      {
                        fieldGeneratordistance.reset();
                        fieldGeneratortravelTime.reset();
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
                    protected override void handle_result(TypesummaryJSON  result)
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
                    public TypesummaryJSON value;
                  };
                public class HoldingArrayGenerator : JSONArrayGenerator
              {
                protected class ElementHandler : Generator
                  {
                    private HoldingArrayGenerator top;

                    protected override void handle_result(TypesummaryJSON  result)
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
                protected virtual void handle_result(List<TypesummaryJSON> result)

                  {
                  }

                public HoldingArrayGenerator(string what, bool ignore_extras)
                  {
                    element_handler = new ElementHandler(this, ignore_extras);
                    have_value = false;
                    value = new List<TypesummaryJSON>();
                    base.set_what(what);
                  }
                public HoldingArrayGenerator(bool ignore_extras)
                  {
                    element_handler = new ElementHandler(this, ignore_extras);
                    value = new List<TypesummaryJSON>();
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
                public List<TypesummaryJSON> value;
              };
              };
            public class TypelegJSON : JSONBase
              {
                public class TypestartJSON : JSONBase
                  {
                    public class TypemappedPositionJSON : JSONBase
                      {
                        private bool flagHaslatitude;
                        private double storelatitude;
                        private string textStorelatitude;
                        private bool flagHaslongitude;
                        private double storelongitude;
                        private string textStorelongitude;
                        private List<string> extraKeys;
                        private List<JSONValue > extraValues;
                        private Dictionary<string, JSONValue > extraIndex;


                        private void  fromJSONlatitude(JSONValue json_value, bool ignore_extras)
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
                                    throw new Exception("The value for field latitude of TypemappedPositionJSON is not a number.");
                                  }
                              }
                            setlatitudeText(the_rational_text);
                          }


                        private void  fromJSONlongitude(JSONValue json_value, bool ignore_extras)
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
                                    throw new Exception("The value for field longitude of TypemappedPositionJSON is not a number.");
                                  }
                              }
                            setlongitudeText(the_rational_text);
                          }


                        public TypemappedPositionJSON()
                          {
                            flagHaslatitude = false;
                            flagHaslongitude = false;
                            extraKeys = new List<string>();
                        extraValues = new List<JSONValue >();
                        extraIndex = new Dictionary<string, JSONValue >();
                          }

                        public bool  haslatitude()
                          {
                            return flagHaslatitude;
                          }

                        public double  getlatitude()
                          {
                            Debug.Assert(flagHaslatitude);
                            if (textStorelatitude != "")
                              {
                                return Double.Parse(textStorelatitude);
                              }
                            return storelatitude;
                          }

                        public string  getlatitudeAsText()
                          {
                            Debug.Assert(flagHaslatitude);
                            if (textStorelatitude == "")
                              {
                                return Convert.ToString(storelatitude);
                              }
                            else
                              {
                                return (textStorelatitude);
                              }
                          }

                        public bool  haslongitude()
                          {
                            return flagHaslongitude;
                          }

                        public double  getlongitude()
                          {
                            Debug.Assert(flagHaslongitude);
                            if (textStorelongitude != "")
                              {
                                return Double.Parse(textStorelongitude);
                              }
                            return storelongitude;
                          }

                        public string  getlongitudeAsText()
                          {
                            Debug.Assert(flagHaslongitude);
                            if (textStorelongitude == "")
                              {
                                return Convert.ToString(storelongitude);
                              }
                            else
                              {
                                return (textStorelongitude);
                              }
                          }


                        public virtual int extraTypemappedPositionComponentCount()
                          {
                            Debug.Assert(extraKeys.Count == extraValues.Count);
                            return extraKeys.Count;
                          }
                        public virtual string extraTypemappedPositionComponentKey(int component_num)
                          {
                            Debug.Assert(extraKeys.Count == extraValues.Count);
                            Debug.Assert(component_num < extraValues.Count);
                            return extraKeys[component_num];
                          }
                        public virtual JSONValue extraTypemappedPositionComponentValue(int component_num)
                          {
                            Debug.Assert(extraKeys.Count == extraValues.Count);
                            Debug.Assert(component_num < extraValues.Count);
                            return extraValues[component_num];
                          }
                        public virtual JSONValue extraTypemappedPositionLookup(string field_name)
                          {
                            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                            return result;
                          }

                        public void setlatitude(double new_value)
                          {
                            flagHaslatitude = true;
                            storelatitude = new_value;
                            textStorelatitude = "";
                          }
                        public void setlatitudeText(string new_value)
                          {
                            flagHaslatitude = true;
                            if (!(JSONWriter.is_valid_number_format(new_value)))
                                throw new Exception("The text value for field latitude of TypemappedPositionJSON is not a valid number.");
                            textStorelatitude = new_value;
                          }
                        public void unsetlatitude()
                          {
                            flagHaslatitude = false;
                          }
                        public void setlongitude(double new_value)
                          {
                            flagHaslongitude = true;
                            storelongitude = new_value;
                            textStorelongitude = "";
                          }
                        public void setlongitudeText(string new_value)
                          {
                            flagHaslongitude = true;
                            if (!(JSONWriter.is_valid_number_format(new_value)))
                                throw new Exception("The text value for field longitude of TypemappedPositionJSON is not a valid number.");
                            textStorelongitude = new_value;
                          }
                        public void unsetlongitude()
                          {
                            flagHaslongitude = false;
                          }

                        public virtual void extraTypemappedPositionAppendPair(string key, JSONValue new_component)
                          {
                            Debug.Assert(key != null);
                            Debug.Assert(new_component != null);

                            Debug.Assert(extraKeys.Count == extraValues.Count);
                            extraKeys.Add(key);
                            extraValues.Add(new_component);
                            extraIndex.Add(key, new_component);
                          }
                        public virtual void extraTypemappedPositionSetField(string key, JSONValue new_component)
                          {
                            Debug.Assert(key != null);
                            Debug.Assert(new_component != null);

                            JSONValue old_field = extraTypemappedPositionLookup(key);
                            if (old_field == null)
                              {
                                extraTypemappedPositionAppendPair(key, new_component);
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
                            Debug.Assert(partial_allowed || flagHaslatitude);
                            if (flagHaslatitude)
                              {
                                handler.start_pair("latitude");
                                if (textStorelatitude != "")
                                    handler.number_value(textStorelatitude);
                                else if (((double)(long)storelatitude) == storelatitude)
                                    handler.number_value((long)storelatitude);
                                else
                                    handler.number_value(storelatitude);
                              }
                            Debug.Assert(partial_allowed || flagHaslongitude);
                            if (flagHaslongitude)
                              {
                                handler.start_pair("longitude");
                                if (textStorelongitude != "")
                                    handler.number_value(textStorelongitude);
                                else if (((double)(long)storelongitude) == storelongitude)
                                    handler.number_value((long)storelongitude);
                                else
                                    handler.number_value(storelongitude);
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
                            if (!(haslatitude()))
                              {
                                return "When parsing the object for %what%, the \"latitude\" field was missing.";
                              }
                            if (!(haslongitude()))
                              {
                                return "When parsing the object for %what%, the \"longitude\" field was missing.";
                              }
                            return null;
                          }

                        public static TypemappedPositionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                          {
                            TypemappedPositionJSON result;
                              {
                                HoldingGenerator generator = new HoldingGenerator("Type TypemappedPosition", ignore_extras);
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
                        public static TypemappedPositionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
                      {
                        return from_json(json_value, ignore_extras, allow_incomplete, false);
                      }
                        public static TypemappedPositionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                          {
                            TypemappedPositionJSON result;
                              {
                                HoldingGenerator generator = new HoldingGenerator("Type TypemappedPosition", ignore_extras);
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
                        public static TypemappedPositionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
                      {
                        return from_json(json_value, ignore_extras, allow_incomplete, false);
                      }
                        public static TypemappedPositionJSON from_text(string text, bool ignore_extras)
                          {
                            TypemappedPositionJSON result;
                              {
                                HoldingGenerator generator = new HoldingGenerator("Type TypemappedPosition", ignore_extras);
                                JSONParse.parse_json_value(text, "Text for TypemappedPositionJSON", generator);
                                Debug.Assert(generator.have_value);
                                result = generator.value;
                              };
                            return result;
                          }
                        public static TypemappedPositionJSON from_file(TextReader fp, string file_name, bool ignore_extras)
                          {
                            TypemappedPositionJSON result;
                              {
                                HoldingGenerator generator = new HoldingGenerator("Type TypemappedPosition", ignore_extras);
                                JSONParse.parse_json_value(fp, file_name, generator);
                                Debug.Assert(generator.have_value);
                                result = generator.value;
                              };
                            return result;
                          }
                        public abstract class Generator : JSONObjectGenerator
                          {
                            private JSONHoldingNumberTextGenerator fieldGeneratorlatitude;
                            private JSONHoldingNumberTextGenerator fieldGeneratorlongitude;
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
                                TypemappedPositionJSON result = new TypemappedPositionJSON();
                                Debug.Assert(result != null);
                                finish(result);
                                int extra_count = unknownFieldGenerator.field_names.Count;
                                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                                  {
                                    result.extraTypemappedPositionAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                                  }
                                unknownFieldGenerator.field_names.Clear();
                                unknownFieldGenerator.field_values.Clear();
                                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                                handle_result(result);
                              }
                            protected void finish(TypemappedPositionJSON result)
                              {
                                if (fieldGeneratorlatitude.have_value)
                                  {
                                    result.setlatitudeText(fieldGeneratorlatitude.value);
                                    fieldGeneratorlatitude.have_value = false;
                                  }
                                else if ((!(result.haslatitude())) && !allow_incomplete)
                                  {
                                    error("When parsing the object for %what%, the \"latitude\" field was missing.");
                                  }
                                if (fieldGeneratorlongitude.have_value)
                                  {
                                    result.setlongitudeText(fieldGeneratorlongitude.value);
                                    fieldGeneratorlongitude.have_value = false;
                                  }
                                else if ((!(result.haslongitude())) && !allow_incomplete)
                                  {
                                    error("When parsing the object for %what%, the \"longitude\" field was missing.");
                                  }
                              }
                            protected abstract void handle_result(TypemappedPositionJSON new_result);
                            protected virtual JSONHandler start_known_field(string field_name)
                              {
                                if (String.Compare(field_name, 0, "l", 0, 1, false) == 0)
                                  {
                                    switch (field_name[1])
                                      {
                                        case 'a':
                                            if ((String.Compare(field_name, 2, "titude", 0, 6, false) == 0) && (field_name.Length == 8))
                                                return fieldGeneratorlatitude;
                                            break;
                                        case 'o':
                                            if ((String.Compare(field_name, 2, "ngitude", 0, 7, false) == 0) && (field_name.Length == 9))
                                                return fieldGeneratorlongitude;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                return null;
                              }
                            public Generator(bool ignore_extras)
                              {
                                fieldGeneratorlatitude = new JSONHoldingNumberTextGenerator("field \"latitude\" of the TypemappedPosition class");
                                fieldGeneratorlongitude = new JSONHoldingNumberTextGenerator("field \"longitude\" of the TypemappedPosition class");
                                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                                set_what("the TypemappedPosition class");
                                allow_incomplete = false;
                                allow_unpolished = false;
                              }
                            public Generator()
                              {
                                fieldGeneratorlatitude = new JSONHoldingNumberTextGenerator("field \"latitude\" of the TypemappedPosition class");
                                fieldGeneratorlongitude = new JSONHoldingNumberTextGenerator("field \"longitude\" of the TypemappedPosition class");
                                unknownFieldGenerator = new UnknownFieldGenerator(false);
                                set_what("the TypemappedPosition class");
                                allow_incomplete = false;
                                allow_unpolished = false;
                              }

                            public override void reset()
                              {
                                fieldGeneratorlatitude.reset();
                                fieldGeneratorlongitude.reset();
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
                            protected override void handle_result(TypemappedPositionJSON  result)
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
                            public TypemappedPositionJSON value;
                          };
                        public class HoldingArrayGenerator : JSONArrayGenerator
                      {
                        protected class ElementHandler : Generator
                          {
                            private HoldingArrayGenerator top;

                            protected override void handle_result(TypemappedPositionJSON  result)
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
                        protected virtual void handle_result(List<TypemappedPositionJSON> result)

                          {
                          }

                        public HoldingArrayGenerator(string what, bool ignore_extras)
                          {
                            element_handler = new ElementHandler(this, ignore_extras);
                            have_value = false;
                            value = new List<TypemappedPositionJSON>();
                            base.set_what(what);
                          }
                        public HoldingArrayGenerator(bool ignore_extras)
                          {
                            element_handler = new ElementHandler(this, ignore_extras);
                            value = new List<TypemappedPositionJSON>();
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
                        public List<TypemappedPositionJSON> value;
                      };
                      };
                    private bool flagHasmappedPosition;
                    private TypemappedPositionJSON  storemappedPosition;
                    private List<string> extraKeys;
                    private List<JSONValue > extraValues;
                    private Dictionary<string, JSONValue > extraIndex;


                    private void  fromJSONmappedPosition(JSONValue json_value, bool ignore_extras)
                      {
                        Debug.Assert(json_value != null);
                        TypemappedPositionJSON convert_classy = TypemappedPositionJSON.from_json(json_value, ignore_extras, true);
                        setmappedPosition(convert_classy);
                      }


                    public TypestartJSON()
                      {
                        flagHasmappedPosition = false;
                        extraKeys = new List<string>();
                    extraValues = new List<JSONValue >();
                    extraIndex = new Dictionary<string, JSONValue >();
                      }

                    public bool  hasmappedPosition()
                      {
                        return flagHasmappedPosition;
                      }

                    public TypemappedPositionJSON   getmappedPosition()
                      {
                        Debug.Assert(flagHasmappedPosition);
                        return storemappedPosition;
                      }


                    public virtual int extraTypestartComponentCount()
                      {
                        Debug.Assert(extraKeys.Count == extraValues.Count);
                        return extraKeys.Count;
                      }
                    public virtual string extraTypestartComponentKey(int component_num)
                      {
                        Debug.Assert(extraKeys.Count == extraValues.Count);
                        Debug.Assert(component_num < extraValues.Count);
                        return extraKeys[component_num];
                      }
                    public virtual JSONValue extraTypestartComponentValue(int component_num)
                      {
                        Debug.Assert(extraKeys.Count == extraValues.Count);
                        Debug.Assert(component_num < extraValues.Count);
                        return extraValues[component_num];
                      }
                    public virtual JSONValue extraTypestartLookup(string field_name)
                      {
                        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                        return result;
                      }

                    public void setmappedPosition(TypemappedPositionJSON  new_value)
                      {
                        if (flagHasmappedPosition)
                          {
                          }
                        flagHasmappedPosition = true;
                        storemappedPosition = new_value;
                      }
                    public void unsetmappedPosition()
                      {
                        if (flagHasmappedPosition)
                          {
                          }
                        flagHasmappedPosition = false;
                      }

                    public virtual void extraTypestartAppendPair(string key, JSONValue new_component)
                      {
                        Debug.Assert(key != null);
                        Debug.Assert(new_component != null);

                        Debug.Assert(extraKeys.Count == extraValues.Count);
                        extraKeys.Add(key);
                        extraValues.Add(new_component);
                        extraIndex.Add(key, new_component);
                      }
                    public virtual void extraTypestartSetField(string key, JSONValue new_component)
                      {
                        Debug.Assert(key != null);
                        Debug.Assert(new_component != null);

                        JSONValue old_field = extraTypestartLookup(key);
                        if (old_field == null)
                          {
                            extraTypestartAppendPair(key, new_component);
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
                        Debug.Assert(partial_allowed || flagHasmappedPosition);
                        if (flagHasmappedPosition)
                          {
                            handler.start_pair("mappedPosition");
                            if (partial_allowed)
                                storemappedPosition.write_partial_as_json(handler);
                            else
                                storemappedPosition.write_as_json(handler);
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
                        if (!(hasmappedPosition()))
                          {
                            return "When parsing the object for %what%, the \"mappedPosition\" field was missing.";
                          }
                        return null;
                      }

                    public static TypestartJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                      {
                        TypestartJSON result;
                          {
                            HoldingGenerator generator = new HoldingGenerator("Type Typestart", ignore_extras);
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
                    public static TypestartJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
                  {
                    return from_json(json_value, ignore_extras, allow_incomplete, false);
                  }
                    public static TypestartJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                      {
                        TypestartJSON result;
                          {
                            HoldingGenerator generator = new HoldingGenerator("Type Typestart", ignore_extras);
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
                    public static TypestartJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
                  {
                    return from_json(json_value, ignore_extras, allow_incomplete, false);
                  }
                    public static TypestartJSON from_text(string text, bool ignore_extras)
                      {
                        TypestartJSON result;
                          {
                            HoldingGenerator generator = new HoldingGenerator("Type Typestart", ignore_extras);
                            JSONParse.parse_json_value(text, "Text for TypestartJSON", generator);
                            Debug.Assert(generator.have_value);
                            result = generator.value;
                          };
                        return result;
                      }
                    public static TypestartJSON from_file(TextReader fp, string file_name, bool ignore_extras)
                      {
                        TypestartJSON result;
                          {
                            HoldingGenerator generator = new HoldingGenerator("Type Typestart", ignore_extras);
                            JSONParse.parse_json_value(fp, file_name, generator);
                            Debug.Assert(generator.have_value);
                            result = generator.value;
                          };
                        return result;
                      }
                    public abstract class Generator : JSONObjectGenerator
                      {
                        private TypemappedPositionJSON.HoldingGenerator fieldGeneratormappedPosition;
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
                            TypestartJSON result = new TypestartJSON();
                            Debug.Assert(result != null);
                            finish(result);
                            int extra_count = unknownFieldGenerator.field_names.Count;
                            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                              {
                                result.extraTypestartAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                              }
                            unknownFieldGenerator.field_names.Clear();
                            unknownFieldGenerator.field_values.Clear();
                            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                            handle_result(result);
                          }
                        protected void finish(TypestartJSON result)
                          {
                            if (fieldGeneratormappedPosition.have_value)
                              {
                                result.setmappedPosition(fieldGeneratormappedPosition.value);
                                fieldGeneratormappedPosition.have_value = false;
                              }
                            else if ((!(result.hasmappedPosition())) && !allow_incomplete)
                              {
                                error("When parsing the object for %what%, the \"mappedPosition\" field was missing.");
                              }
                          }
                        protected abstract void handle_result(TypestartJSON new_result);
                        protected virtual JSONHandler start_known_field(string field_name)
                          {
                            if ((String.Compare(field_name, 0, "mappedPosition", 0, 14, false) == 0) && (field_name.Length == 14))
                                return fieldGeneratormappedPosition;
                            return null;
                          }
                        public Generator(bool ignore_extras)
                          {
                            fieldGeneratormappedPosition = new TypemappedPositionJSON.HoldingGenerator("field \"mappedPosition\" of the Typestart class", ignore_extras);
                            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                            set_what("the Typestart class");
                            allow_incomplete = false;
                            allow_unpolished = false;
                          }
                        public Generator()
                          {
                            fieldGeneratormappedPosition = new TypemappedPositionJSON.HoldingGenerator("field \"mappedPosition\" of the Typestart class", false);
                            unknownFieldGenerator = new UnknownFieldGenerator(false);
                            set_what("the Typestart class");
                            allow_incomplete = false;
                            allow_unpolished = false;
                          }

                        public override void reset()
                          {
                            fieldGeneratormappedPosition.reset();
                            base.reset();
                            unknownFieldGenerator.reset();
                          }
                        public void set_allow_incomplete(bool new_allow_incomplete)
                          {
                            allow_incomplete = new_allow_incomplete;
                            fieldGeneratormappedPosition.set_allow_incomplete(new_allow_incomplete);
                          }
                        public void set_allow_unpolished(bool new_allow_unpolished)
                          {
                            allow_unpolished = new_allow_unpolished;
                            fieldGeneratormappedPosition.set_allow_unpolished(new_allow_unpolished);
                          }
                      };
                    public class HoldingGenerator : Generator
                      {
                        protected override void handle_result(TypestartJSON  result)
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
                        public TypestartJSON value;
                      };
                    public class HoldingArrayGenerator : JSONArrayGenerator
                  {
                    protected class ElementHandler : Generator
                      {
                        private HoldingArrayGenerator top;

                        protected override void handle_result(TypestartJSON  result)
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
                    protected virtual void handle_result(List<TypestartJSON> result)

                      {
                      }

                    public HoldingArrayGenerator(string what, bool ignore_extras)
                      {
                        element_handler = new ElementHandler(this, ignore_extras);
                        have_value = false;
                        value = new List<TypestartJSON>();
                        base.set_what(what);
                      }
                    public HoldingArrayGenerator(bool ignore_extras)
                      {
                        element_handler = new ElementHandler(this, ignore_extras);
                        value = new List<TypestartJSON>();
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
                    public List<TypestartJSON> value;
                  };
                  };
                public class TypeendJSON : JSONBase
                  {
                    public class TypemappedPositionJSON : JSONBase
                      {
                        private bool flagHaslatitude;
                        private double storelatitude;
                        private string textStorelatitude;
                        private bool flagHaslongitude;
                        private double storelongitude;
                        private string textStorelongitude;
                        private List<string> extraKeys;
                        private List<JSONValue > extraValues;
                        private Dictionary<string, JSONValue > extraIndex;


                        private void  fromJSONlatitude(JSONValue json_value, bool ignore_extras)
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
                                    throw new Exception("The value for field latitude of TypemappedPositionJSON is not a number.");
                                  }
                              }
                            setlatitudeText(the_rational_text);
                          }


                        private void  fromJSONlongitude(JSONValue json_value, bool ignore_extras)
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
                                    throw new Exception("The value for field longitude of TypemappedPositionJSON is not a number.");
                                  }
                              }
                            setlongitudeText(the_rational_text);
                          }


                        public TypemappedPositionJSON()
                          {
                            flagHaslatitude = false;
                            flagHaslongitude = false;
                            extraKeys = new List<string>();
                        extraValues = new List<JSONValue >();
                        extraIndex = new Dictionary<string, JSONValue >();
                          }

                        public bool  haslatitude()
                          {
                            return flagHaslatitude;
                          }

                        public double  getlatitude()
                          {
                            Debug.Assert(flagHaslatitude);
                            if (textStorelatitude != "")
                              {
                                return Double.Parse(textStorelatitude);
                              }
                            return storelatitude;
                          }

                        public string  getlatitudeAsText()
                          {
                            Debug.Assert(flagHaslatitude);
                            if (textStorelatitude == "")
                              {
                                return Convert.ToString(storelatitude);
                              }
                            else
                              {
                                return (textStorelatitude);
                              }
                          }

                        public bool  haslongitude()
                          {
                            return flagHaslongitude;
                          }

                        public double  getlongitude()
                          {
                            Debug.Assert(flagHaslongitude);
                            if (textStorelongitude != "")
                              {
                                return Double.Parse(textStorelongitude);
                              }
                            return storelongitude;
                          }

                        public string  getlongitudeAsText()
                          {
                            Debug.Assert(flagHaslongitude);
                            if (textStorelongitude == "")
                              {
                                return Convert.ToString(storelongitude);
                              }
                            else
                              {
                                return (textStorelongitude);
                              }
                          }


                        public virtual int extraTypemappedPositionComponentCount()
                          {
                            Debug.Assert(extraKeys.Count == extraValues.Count);
                            return extraKeys.Count;
                          }
                        public virtual string extraTypemappedPositionComponentKey(int component_num)
                          {
                            Debug.Assert(extraKeys.Count == extraValues.Count);
                            Debug.Assert(component_num < extraValues.Count);
                            return extraKeys[component_num];
                          }
                        public virtual JSONValue extraTypemappedPositionComponentValue(int component_num)
                          {
                            Debug.Assert(extraKeys.Count == extraValues.Count);
                            Debug.Assert(component_num < extraValues.Count);
                            return extraValues[component_num];
                          }
                        public virtual JSONValue extraTypemappedPositionLookup(string field_name)
                          {
                            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                            return result;
                          }

                        public void setlatitude(double new_value)
                          {
                            flagHaslatitude = true;
                            storelatitude = new_value;
                            textStorelatitude = "";
                          }
                        public void setlatitudeText(string new_value)
                          {
                            flagHaslatitude = true;
                            if (!(JSONWriter.is_valid_number_format(new_value)))
                                throw new Exception("The text value for field latitude of TypemappedPositionJSON is not a valid number.");
                            textStorelatitude = new_value;
                          }
                        public void unsetlatitude()
                          {
                            flagHaslatitude = false;
                          }
                        public void setlongitude(double new_value)
                          {
                            flagHaslongitude = true;
                            storelongitude = new_value;
                            textStorelongitude = "";
                          }
                        public void setlongitudeText(string new_value)
                          {
                            flagHaslongitude = true;
                            if (!(JSONWriter.is_valid_number_format(new_value)))
                                throw new Exception("The text value for field longitude of TypemappedPositionJSON is not a valid number.");
                            textStorelongitude = new_value;
                          }
                        public void unsetlongitude()
                          {
                            flagHaslongitude = false;
                          }

                        public virtual void extraTypemappedPositionAppendPair(string key, JSONValue new_component)
                          {
                            Debug.Assert(key != null);
                            Debug.Assert(new_component != null);

                            Debug.Assert(extraKeys.Count == extraValues.Count);
                            extraKeys.Add(key);
                            extraValues.Add(new_component);
                            extraIndex.Add(key, new_component);
                          }
                        public virtual void extraTypemappedPositionSetField(string key, JSONValue new_component)
                          {
                            Debug.Assert(key != null);
                            Debug.Assert(new_component != null);

                            JSONValue old_field = extraTypemappedPositionLookup(key);
                            if (old_field == null)
                              {
                                extraTypemappedPositionAppendPair(key, new_component);
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
                            Debug.Assert(partial_allowed || flagHaslatitude);
                            if (flagHaslatitude)
                              {
                                handler.start_pair("latitude");
                                if (textStorelatitude != "")
                                    handler.number_value(textStorelatitude);
                                else if (((double)(long)storelatitude) == storelatitude)
                                    handler.number_value((long)storelatitude);
                                else
                                    handler.number_value(storelatitude);
                              }
                            Debug.Assert(partial_allowed || flagHaslongitude);
                            if (flagHaslongitude)
                              {
                                handler.start_pair("longitude");
                                if (textStorelongitude != "")
                                    handler.number_value(textStorelongitude);
                                else if (((double)(long)storelongitude) == storelongitude)
                                    handler.number_value((long)storelongitude);
                                else
                                    handler.number_value(storelongitude);
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
                            if (!(haslatitude()))
                              {
                                return "When parsing the object for %what%, the \"latitude\" field was missing.";
                              }
                            if (!(haslongitude()))
                              {
                                return "When parsing the object for %what%, the \"longitude\" field was missing.";
                              }
                            return null;
                          }

                        public static TypemappedPositionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                          {
                            TypemappedPositionJSON result;
                              {
                                HoldingGenerator generator = new HoldingGenerator("Type TypemappedPosition", ignore_extras);
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
                        public static TypemappedPositionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
                      {
                        return from_json(json_value, ignore_extras, allow_incomplete, false);
                      }
                        public static TypemappedPositionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                          {
                            TypemappedPositionJSON result;
                              {
                                HoldingGenerator generator = new HoldingGenerator("Type TypemappedPosition", ignore_extras);
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
                        public static TypemappedPositionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
                      {
                        return from_json(json_value, ignore_extras, allow_incomplete, false);
                      }
                        public static TypemappedPositionJSON from_text(string text, bool ignore_extras)
                          {
                            TypemappedPositionJSON result;
                              {
                                HoldingGenerator generator = new HoldingGenerator("Type TypemappedPosition", ignore_extras);
                                JSONParse.parse_json_value(text, "Text for TypemappedPositionJSON", generator);
                                Debug.Assert(generator.have_value);
                                result = generator.value;
                              };
                            return result;
                          }
                        public static TypemappedPositionJSON from_file(TextReader fp, string file_name, bool ignore_extras)
                          {
                            TypemappedPositionJSON result;
                              {
                                HoldingGenerator generator = new HoldingGenerator("Type TypemappedPosition", ignore_extras);
                                JSONParse.parse_json_value(fp, file_name, generator);
                                Debug.Assert(generator.have_value);
                                result = generator.value;
                              };
                            return result;
                          }
                        public abstract class Generator : JSONObjectGenerator
                          {
                            private JSONHoldingNumberTextGenerator fieldGeneratorlatitude;
                            private JSONHoldingNumberTextGenerator fieldGeneratorlongitude;
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
                                TypemappedPositionJSON result = new TypemappedPositionJSON();
                                Debug.Assert(result != null);
                                finish(result);
                                int extra_count = unknownFieldGenerator.field_names.Count;
                                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                                  {
                                    result.extraTypemappedPositionAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                                  }
                                unknownFieldGenerator.field_names.Clear();
                                unknownFieldGenerator.field_values.Clear();
                                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                                handle_result(result);
                              }
                            protected void finish(TypemappedPositionJSON result)
                              {
                                if (fieldGeneratorlatitude.have_value)
                                  {
                                    result.setlatitudeText(fieldGeneratorlatitude.value);
                                    fieldGeneratorlatitude.have_value = false;
                                  }
                                else if ((!(result.haslatitude())) && !allow_incomplete)
                                  {
                                    error("When parsing the object for %what%, the \"latitude\" field was missing.");
                                  }
                                if (fieldGeneratorlongitude.have_value)
                                  {
                                    result.setlongitudeText(fieldGeneratorlongitude.value);
                                    fieldGeneratorlongitude.have_value = false;
                                  }
                                else if ((!(result.haslongitude())) && !allow_incomplete)
                                  {
                                    error("When parsing the object for %what%, the \"longitude\" field was missing.");
                                  }
                              }
                            protected abstract void handle_result(TypemappedPositionJSON new_result);
                            protected virtual JSONHandler start_known_field(string field_name)
                              {
                                if (String.Compare(field_name, 0, "l", 0, 1, false) == 0)
                                  {
                                    switch (field_name[1])
                                      {
                                        case 'a':
                                            if ((String.Compare(field_name, 2, "titude", 0, 6, false) == 0) && (field_name.Length == 8))
                                                return fieldGeneratorlatitude;
                                            break;
                                        case 'o':
                                            if ((String.Compare(field_name, 2, "ngitude", 0, 7, false) == 0) && (field_name.Length == 9))
                                                return fieldGeneratorlongitude;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                return null;
                              }
                            public Generator(bool ignore_extras)
                              {
                                fieldGeneratorlatitude = new JSONHoldingNumberTextGenerator("field \"latitude\" of the TypemappedPosition class");
                                fieldGeneratorlongitude = new JSONHoldingNumberTextGenerator("field \"longitude\" of the TypemappedPosition class");
                                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                                set_what("the TypemappedPosition class");
                                allow_incomplete = false;
                                allow_unpolished = false;
                              }
                            public Generator()
                              {
                                fieldGeneratorlatitude = new JSONHoldingNumberTextGenerator("field \"latitude\" of the TypemappedPosition class");
                                fieldGeneratorlongitude = new JSONHoldingNumberTextGenerator("field \"longitude\" of the TypemappedPosition class");
                                unknownFieldGenerator = new UnknownFieldGenerator(false);
                                set_what("the TypemappedPosition class");
                                allow_incomplete = false;
                                allow_unpolished = false;
                              }

                            public override void reset()
                              {
                                fieldGeneratorlatitude.reset();
                                fieldGeneratorlongitude.reset();
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
                            protected override void handle_result(TypemappedPositionJSON  result)
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
                            public TypemappedPositionJSON value;
                          };
                        public class HoldingArrayGenerator : JSONArrayGenerator
                      {
                        protected class ElementHandler : Generator
                          {
                            private HoldingArrayGenerator top;

                            protected override void handle_result(TypemappedPositionJSON  result)
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
                        protected virtual void handle_result(List<TypemappedPositionJSON> result)

                          {
                          }

                        public HoldingArrayGenerator(string what, bool ignore_extras)
                          {
                            element_handler = new ElementHandler(this, ignore_extras);
                            have_value = false;
                            value = new List<TypemappedPositionJSON>();
                            base.set_what(what);
                          }
                        public HoldingArrayGenerator(bool ignore_extras)
                          {
                            element_handler = new ElementHandler(this, ignore_extras);
                            value = new List<TypemappedPositionJSON>();
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
                        public List<TypemappedPositionJSON> value;
                      };
                      };
                    private bool flagHasmappedPosition;
                    private TypemappedPositionJSON  storemappedPosition;
                    private List<string> extraKeys;
                    private List<JSONValue > extraValues;
                    private Dictionary<string, JSONValue > extraIndex;


                    private void  fromJSONmappedPosition(JSONValue json_value, bool ignore_extras)
                      {
                        Debug.Assert(json_value != null);
                        TypemappedPositionJSON convert_classy = TypemappedPositionJSON.from_json(json_value, ignore_extras, true);
                        setmappedPosition(convert_classy);
                      }


                    public TypeendJSON()
                      {
                        flagHasmappedPosition = false;
                        extraKeys = new List<string>();
                    extraValues = new List<JSONValue >();
                    extraIndex = new Dictionary<string, JSONValue >();
                      }

                    public bool  hasmappedPosition()
                      {
                        return flagHasmappedPosition;
                      }

                    public TypemappedPositionJSON   getmappedPosition()
                      {
                        Debug.Assert(flagHasmappedPosition);
                        return storemappedPosition;
                      }


                    public virtual int extraTypeendComponentCount()
                      {
                        Debug.Assert(extraKeys.Count == extraValues.Count);
                        return extraKeys.Count;
                      }
                    public virtual string extraTypeendComponentKey(int component_num)
                      {
                        Debug.Assert(extraKeys.Count == extraValues.Count);
                        Debug.Assert(component_num < extraValues.Count);
                        return extraKeys[component_num];
                      }
                    public virtual JSONValue extraTypeendComponentValue(int component_num)
                      {
                        Debug.Assert(extraKeys.Count == extraValues.Count);
                        Debug.Assert(component_num < extraValues.Count);
                        return extraValues[component_num];
                      }
                    public virtual JSONValue extraTypeendLookup(string field_name)
                      {
                        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                        return result;
                      }

                    public void setmappedPosition(TypemappedPositionJSON  new_value)
                      {
                        if (flagHasmappedPosition)
                          {
                          }
                        flagHasmappedPosition = true;
                        storemappedPosition = new_value;
                      }
                    public void unsetmappedPosition()
                      {
                        if (flagHasmappedPosition)
                          {
                          }
                        flagHasmappedPosition = false;
                      }

                    public virtual void extraTypeendAppendPair(string key, JSONValue new_component)
                      {
                        Debug.Assert(key != null);
                        Debug.Assert(new_component != null);

                        Debug.Assert(extraKeys.Count == extraValues.Count);
                        extraKeys.Add(key);
                        extraValues.Add(new_component);
                        extraIndex.Add(key, new_component);
                      }
                    public virtual void extraTypeendSetField(string key, JSONValue new_component)
                      {
                        Debug.Assert(key != null);
                        Debug.Assert(new_component != null);

                        JSONValue old_field = extraTypeendLookup(key);
                        if (old_field == null)
                          {
                            extraTypeendAppendPair(key, new_component);
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
                        Debug.Assert(partial_allowed || flagHasmappedPosition);
                        if (flagHasmappedPosition)
                          {
                            handler.start_pair("mappedPosition");
                            if (partial_allowed)
                                storemappedPosition.write_partial_as_json(handler);
                            else
                                storemappedPosition.write_as_json(handler);
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
                        if (!(hasmappedPosition()))
                          {
                            return "When parsing the object for %what%, the \"mappedPosition\" field was missing.";
                          }
                        return null;
                      }

                    public static TypeendJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                      {
                        TypeendJSON result;
                          {
                            HoldingGenerator generator = new HoldingGenerator("Type Typeend", ignore_extras);
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
                    public static TypeendJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
                  {
                    return from_json(json_value, ignore_extras, allow_incomplete, false);
                  }
                    public static TypeendJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                      {
                        TypeendJSON result;
                          {
                            HoldingGenerator generator = new HoldingGenerator("Type Typeend", ignore_extras);
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
                    public static TypeendJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
                  {
                    return from_json(json_value, ignore_extras, allow_incomplete, false);
                  }
                    public static TypeendJSON from_text(string text, bool ignore_extras)
                      {
                        TypeendJSON result;
                          {
                            HoldingGenerator generator = new HoldingGenerator("Type Typeend", ignore_extras);
                            JSONParse.parse_json_value(text, "Text for TypeendJSON", generator);
                            Debug.Assert(generator.have_value);
                            result = generator.value;
                          };
                        return result;
                      }
                    public static TypeendJSON from_file(TextReader fp, string file_name, bool ignore_extras)
                      {
                        TypeendJSON result;
                          {
                            HoldingGenerator generator = new HoldingGenerator("Type Typeend", ignore_extras);
                            JSONParse.parse_json_value(fp, file_name, generator);
                            Debug.Assert(generator.have_value);
                            result = generator.value;
                          };
                        return result;
                      }
                    public abstract class Generator : JSONObjectGenerator
                      {
                        private TypemappedPositionJSON.HoldingGenerator fieldGeneratormappedPosition;
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
                            TypeendJSON result = new TypeendJSON();
                            Debug.Assert(result != null);
                            finish(result);
                            int extra_count = unknownFieldGenerator.field_names.Count;
                            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                              {
                                result.extraTypeendAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                              }
                            unknownFieldGenerator.field_names.Clear();
                            unknownFieldGenerator.field_values.Clear();
                            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                            handle_result(result);
                          }
                        protected void finish(TypeendJSON result)
                          {
                            if (fieldGeneratormappedPosition.have_value)
                              {
                                result.setmappedPosition(fieldGeneratormappedPosition.value);
                                fieldGeneratormappedPosition.have_value = false;
                              }
                            else if ((!(result.hasmappedPosition())) && !allow_incomplete)
                              {
                                error("When parsing the object for %what%, the \"mappedPosition\" field was missing.");
                              }
                          }
                        protected abstract void handle_result(TypeendJSON new_result);
                        protected virtual JSONHandler start_known_field(string field_name)
                          {
                            if ((String.Compare(field_name, 0, "mappedPosition", 0, 14, false) == 0) && (field_name.Length == 14))
                                return fieldGeneratormappedPosition;
                            return null;
                          }
                        public Generator(bool ignore_extras)
                          {
                            fieldGeneratormappedPosition = new TypemappedPositionJSON.HoldingGenerator("field \"mappedPosition\" of the Typeend class", ignore_extras);
                            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                            set_what("the Typeend class");
                            allow_incomplete = false;
                            allow_unpolished = false;
                          }
                        public Generator()
                          {
                            fieldGeneratormappedPosition = new TypemappedPositionJSON.HoldingGenerator("field \"mappedPosition\" of the Typeend class", false);
                            unknownFieldGenerator = new UnknownFieldGenerator(false);
                            set_what("the Typeend class");
                            allow_incomplete = false;
                            allow_unpolished = false;
                          }

                        public override void reset()
                          {
                            fieldGeneratormappedPosition.reset();
                            base.reset();
                            unknownFieldGenerator.reset();
                          }
                        public void set_allow_incomplete(bool new_allow_incomplete)
                          {
                            allow_incomplete = new_allow_incomplete;
                            fieldGeneratormappedPosition.set_allow_incomplete(new_allow_incomplete);
                          }
                        public void set_allow_unpolished(bool new_allow_unpolished)
                          {
                            allow_unpolished = new_allow_unpolished;
                            fieldGeneratormappedPosition.set_allow_unpolished(new_allow_unpolished);
                          }
                      };
                    public class HoldingGenerator : Generator
                      {
                        protected override void handle_result(TypeendJSON  result)
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
                        public TypeendJSON value;
                      };
                    public class HoldingArrayGenerator : JSONArrayGenerator
                  {
                    protected class ElementHandler : Generator
                      {
                        private HoldingArrayGenerator top;

                        protected override void handle_result(TypeendJSON  result)
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
                    protected virtual void handle_result(List<TypeendJSON> result)

                      {
                      }

                    public HoldingArrayGenerator(string what, bool ignore_extras)
                      {
                        element_handler = new ElementHandler(this, ignore_extras);
                        have_value = false;
                        value = new List<TypeendJSON>();
                        base.set_what(what);
                      }
                    public HoldingArrayGenerator(bool ignore_extras)
                      {
                        element_handler = new ElementHandler(this, ignore_extras);
                        value = new List<TypeendJSON>();
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
                    public List<TypeendJSON> value;
                  };
                  };
                public class TypemaneuverJSON : JSONBase
                  {
                    public class TypepositionJSON : JSONBase
                      {
                        private bool flagHaslatitude;
                        private double storelatitude;
                        private string textStorelatitude;
                        private bool flagHaslongitude;
                        private double storelongitude;
                        private string textStorelongitude;
                        private List<string> extraKeys;
                        private List<JSONValue > extraValues;
                        private Dictionary<string, JSONValue > extraIndex;


                        private void  fromJSONlatitude(JSONValue json_value, bool ignore_extras)
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
                                    throw new Exception("The value for field latitude of TypepositionJSON is not a number.");
                                  }
                              }
                            setlatitudeText(the_rational_text);
                          }


                        private void  fromJSONlongitude(JSONValue json_value, bool ignore_extras)
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
                                    throw new Exception("The value for field longitude of TypepositionJSON is not a number.");
                                  }
                              }
                            setlongitudeText(the_rational_text);
                          }


                        public TypepositionJSON()
                          {
                            flagHaslatitude = false;
                            flagHaslongitude = false;
                            extraKeys = new List<string>();
                        extraValues = new List<JSONValue >();
                        extraIndex = new Dictionary<string, JSONValue >();
                          }

                        public bool  haslatitude()
                          {
                            return flagHaslatitude;
                          }

                        public double  getlatitude()
                          {
                            Debug.Assert(flagHaslatitude);
                            if (textStorelatitude != "")
                              {
                                return Double.Parse(textStorelatitude);
                              }
                            return storelatitude;
                          }

                        public string  getlatitudeAsText()
                          {
                            Debug.Assert(flagHaslatitude);
                            if (textStorelatitude == "")
                              {
                                return Convert.ToString(storelatitude);
                              }
                            else
                              {
                                return (textStorelatitude);
                              }
                          }

                        public bool  haslongitude()
                          {
                            return flagHaslongitude;
                          }

                        public double  getlongitude()
                          {
                            Debug.Assert(flagHaslongitude);
                            if (textStorelongitude != "")
                              {
                                return Double.Parse(textStorelongitude);
                              }
                            return storelongitude;
                          }

                        public string  getlongitudeAsText()
                          {
                            Debug.Assert(flagHaslongitude);
                            if (textStorelongitude == "")
                              {
                                return Convert.ToString(storelongitude);
                              }
                            else
                              {
                                return (textStorelongitude);
                              }
                          }


                        public virtual int extraTypepositionComponentCount()
                          {
                            Debug.Assert(extraKeys.Count == extraValues.Count);
                            return extraKeys.Count;
                          }
                        public virtual string extraTypepositionComponentKey(int component_num)
                          {
                            Debug.Assert(extraKeys.Count == extraValues.Count);
                            Debug.Assert(component_num < extraValues.Count);
                            return extraKeys[component_num];
                          }
                        public virtual JSONValue extraTypepositionComponentValue(int component_num)
                          {
                            Debug.Assert(extraKeys.Count == extraValues.Count);
                            Debug.Assert(component_num < extraValues.Count);
                            return extraValues[component_num];
                          }
                        public virtual JSONValue extraTypepositionLookup(string field_name)
                          {
                            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                            return result;
                          }

                        public void setlatitude(double new_value)
                          {
                            flagHaslatitude = true;
                            storelatitude = new_value;
                            textStorelatitude = "";
                          }
                        public void setlatitudeText(string new_value)
                          {
                            flagHaslatitude = true;
                            if (!(JSONWriter.is_valid_number_format(new_value)))
                                throw new Exception("The text value for field latitude of TypepositionJSON is not a valid number.");
                            textStorelatitude = new_value;
                          }
                        public void unsetlatitude()
                          {
                            flagHaslatitude = false;
                          }
                        public void setlongitude(double new_value)
                          {
                            flagHaslongitude = true;
                            storelongitude = new_value;
                            textStorelongitude = "";
                          }
                        public void setlongitudeText(string new_value)
                          {
                            flagHaslongitude = true;
                            if (!(JSONWriter.is_valid_number_format(new_value)))
                                throw new Exception("The text value for field longitude of TypepositionJSON is not a valid number.");
                            textStorelongitude = new_value;
                          }
                        public void unsetlongitude()
                          {
                            flagHaslongitude = false;
                          }

                        public virtual void extraTypepositionAppendPair(string key, JSONValue new_component)
                          {
                            Debug.Assert(key != null);
                            Debug.Assert(new_component != null);

                            Debug.Assert(extraKeys.Count == extraValues.Count);
                            extraKeys.Add(key);
                            extraValues.Add(new_component);
                            extraIndex.Add(key, new_component);
                          }
                        public virtual void extraTypepositionSetField(string key, JSONValue new_component)
                          {
                            Debug.Assert(key != null);
                            Debug.Assert(new_component != null);

                            JSONValue old_field = extraTypepositionLookup(key);
                            if (old_field == null)
                              {
                                extraTypepositionAppendPair(key, new_component);
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
                            Debug.Assert(partial_allowed || flagHaslatitude);
                            if (flagHaslatitude)
                              {
                                handler.start_pair("latitude");
                                if (textStorelatitude != "")
                                    handler.number_value(textStorelatitude);
                                else if (((double)(long)storelatitude) == storelatitude)
                                    handler.number_value((long)storelatitude);
                                else
                                    handler.number_value(storelatitude);
                              }
                            Debug.Assert(partial_allowed || flagHaslongitude);
                            if (flagHaslongitude)
                              {
                                handler.start_pair("longitude");
                                if (textStorelongitude != "")
                                    handler.number_value(textStorelongitude);
                                else if (((double)(long)storelongitude) == storelongitude)
                                    handler.number_value((long)storelongitude);
                                else
                                    handler.number_value(storelongitude);
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
                            if (!(haslatitude()))
                              {
                                return "When parsing the object for %what%, the \"latitude\" field was missing.";
                              }
                            if (!(haslongitude()))
                              {
                                return "When parsing the object for %what%, the \"longitude\" field was missing.";
                              }
                            return null;
                          }

                        public static TypepositionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                          {
                            TypepositionJSON result;
                              {
                                HoldingGenerator generator = new HoldingGenerator("Type Typeposition", ignore_extras);
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
                        public static TypepositionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
                      {
                        return from_json(json_value, ignore_extras, allow_incomplete, false);
                      }
                        public static TypepositionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                          {
                            TypepositionJSON result;
                              {
                                HoldingGenerator generator = new HoldingGenerator("Type Typeposition", ignore_extras);
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
                        public static TypepositionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
                      {
                        return from_json(json_value, ignore_extras, allow_incomplete, false);
                      }
                        public static TypepositionJSON from_text(string text, bool ignore_extras)
                          {
                            TypepositionJSON result;
                              {
                                HoldingGenerator generator = new HoldingGenerator("Type Typeposition", ignore_extras);
                                JSONParse.parse_json_value(text, "Text for TypepositionJSON", generator);
                                Debug.Assert(generator.have_value);
                                result = generator.value;
                              };
                            return result;
                          }
                        public static TypepositionJSON from_file(TextReader fp, string file_name, bool ignore_extras)
                          {
                            TypepositionJSON result;
                              {
                                HoldingGenerator generator = new HoldingGenerator("Type Typeposition", ignore_extras);
                                JSONParse.parse_json_value(fp, file_name, generator);
                                Debug.Assert(generator.have_value);
                                result = generator.value;
                              };
                            return result;
                          }
                        public abstract class Generator : JSONObjectGenerator
                          {
                            private JSONHoldingNumberTextGenerator fieldGeneratorlatitude;
                            private JSONHoldingNumberTextGenerator fieldGeneratorlongitude;
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
                                TypepositionJSON result = new TypepositionJSON();
                                Debug.Assert(result != null);
                                finish(result);
                                int extra_count = unknownFieldGenerator.field_names.Count;
                                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                                  {
                                    result.extraTypepositionAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                                  }
                                unknownFieldGenerator.field_names.Clear();
                                unknownFieldGenerator.field_values.Clear();
                                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                                handle_result(result);
                              }
                            protected void finish(TypepositionJSON result)
                              {
                                if (fieldGeneratorlatitude.have_value)
                                  {
                                    result.setlatitudeText(fieldGeneratorlatitude.value);
                                    fieldGeneratorlatitude.have_value = false;
                                  }
                                else if ((!(result.haslatitude())) && !allow_incomplete)
                                  {
                                    error("When parsing the object for %what%, the \"latitude\" field was missing.");
                                  }
                                if (fieldGeneratorlongitude.have_value)
                                  {
                                    result.setlongitudeText(fieldGeneratorlongitude.value);
                                    fieldGeneratorlongitude.have_value = false;
                                  }
                                else if ((!(result.haslongitude())) && !allow_incomplete)
                                  {
                                    error("When parsing the object for %what%, the \"longitude\" field was missing.");
                                  }
                              }
                            protected abstract void handle_result(TypepositionJSON new_result);
                            protected virtual JSONHandler start_known_field(string field_name)
                              {
                                if (String.Compare(field_name, 0, "l", 0, 1, false) == 0)
                                  {
                                    switch (field_name[1])
                                      {
                                        case 'a':
                                            if ((String.Compare(field_name, 2, "titude", 0, 6, false) == 0) && (field_name.Length == 8))
                                                return fieldGeneratorlatitude;
                                            break;
                                        case 'o':
                                            if ((String.Compare(field_name, 2, "ngitude", 0, 7, false) == 0) && (field_name.Length == 9))
                                                return fieldGeneratorlongitude;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                return null;
                              }
                            public Generator(bool ignore_extras)
                              {
                                fieldGeneratorlatitude = new JSONHoldingNumberTextGenerator("field \"latitude\" of the Typeposition class");
                                fieldGeneratorlongitude = new JSONHoldingNumberTextGenerator("field \"longitude\" of the Typeposition class");
                                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                                set_what("the Typeposition class");
                                allow_incomplete = false;
                                allow_unpolished = false;
                              }
                            public Generator()
                              {
                                fieldGeneratorlatitude = new JSONHoldingNumberTextGenerator("field \"latitude\" of the Typeposition class");
                                fieldGeneratorlongitude = new JSONHoldingNumberTextGenerator("field \"longitude\" of the Typeposition class");
                                unknownFieldGenerator = new UnknownFieldGenerator(false);
                                set_what("the Typeposition class");
                                allow_incomplete = false;
                                allow_unpolished = false;
                              }

                            public override void reset()
                              {
                                fieldGeneratorlatitude.reset();
                                fieldGeneratorlongitude.reset();
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
                            protected override void handle_result(TypepositionJSON  result)
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
                            public TypepositionJSON value;
                          };
                        public class HoldingArrayGenerator : JSONArrayGenerator
                      {
                        protected class ElementHandler : Generator
                          {
                            private HoldingArrayGenerator top;

                            protected override void handle_result(TypepositionJSON  result)
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
                        protected virtual void handle_result(List<TypepositionJSON> result)

                          {
                          }

                        public HoldingArrayGenerator(string what, bool ignore_extras)
                          {
                            element_handler = new ElementHandler(this, ignore_extras);
                            have_value = false;
                            value = new List<TypepositionJSON>();
                            base.set_what(what);
                          }
                        public HoldingArrayGenerator(bool ignore_extras)
                          {
                            element_handler = new ElementHandler(this, ignore_extras);
                            value = new List<TypepositionJSON>();
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
                        public List<TypepositionJSON> value;
                      };
                      };
                    private bool flagHasinstruction;
                    private string storeinstruction;
                    private bool flagHasposition;
                    private TypepositionJSON  storeposition;
                    private List<string> extraKeys;
                    private List<JSONValue > extraValues;
                    private Dictionary<string, JSONValue > extraIndex;


                    private void  fromJSONinstruction(JSONValue json_value, bool ignore_extras)
                      {
                        Debug.Assert(json_value != null);
                        JSONStringValue json_string = json_value.string_value();
                        if (json_string == null)
                            throw new Exception("The value for field instruction of TypemaneuverJSON is not a string.");
                        setinstruction(json_string.getData());
                      }


                    private void  fromJSONposition(JSONValue json_value, bool ignore_extras)
                      {
                        Debug.Assert(json_value != null);
                        TypepositionJSON convert_classy = TypepositionJSON.from_json(json_value, ignore_extras, true);
                        setposition(convert_classy);
                      }


                    public TypemaneuverJSON()
                      {
                        flagHasinstruction = false;
                        flagHasposition = false;
                        extraKeys = new List<string>();
                    extraValues = new List<JSONValue >();
                    extraIndex = new Dictionary<string, JSONValue >();
                      }

                    public bool  hasinstruction()
                      {
                        return flagHasinstruction;
                      }

                    public string  getinstruction()
                      {
                        Debug.Assert(flagHasinstruction);
                        return storeinstruction;
                      }

                    public bool  hasposition()
                      {
                        return flagHasposition;
                      }

                    public TypepositionJSON   getposition()
                      {
                        Debug.Assert(flagHasposition);
                        return storeposition;
                      }


                    public virtual int extraTypemaneuverComponentCount()
                      {
                        Debug.Assert(extraKeys.Count == extraValues.Count);
                        return extraKeys.Count;
                      }
                    public virtual string extraTypemaneuverComponentKey(int component_num)
                      {
                        Debug.Assert(extraKeys.Count == extraValues.Count);
                        Debug.Assert(component_num < extraValues.Count);
                        return extraKeys[component_num];
                      }
                    public virtual JSONValue extraTypemaneuverComponentValue(int component_num)
                      {
                        Debug.Assert(extraKeys.Count == extraValues.Count);
                        Debug.Assert(component_num < extraValues.Count);
                        return extraValues[component_num];
                      }
                    public virtual JSONValue extraTypemaneuverLookup(string field_name)
                      {
                        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                        return result;
                      }

                    public void setinstruction(string new_value)
                      {
                        flagHasinstruction = true;
                        storeinstruction = new_value;
                      }
                    public void unsetinstruction()
                      {
                        flagHasinstruction = false;
                      }
                    public void setposition(TypepositionJSON  new_value)
                      {
                        if (flagHasposition)
                          {
                          }
                        flagHasposition = true;
                        storeposition = new_value;
                      }
                    public void unsetposition()
                      {
                        if (flagHasposition)
                          {
                          }
                        flagHasposition = false;
                      }

                    public virtual void extraTypemaneuverAppendPair(string key, JSONValue new_component)
                      {
                        Debug.Assert(key != null);
                        Debug.Assert(new_component != null);

                        Debug.Assert(extraKeys.Count == extraValues.Count);
                        extraKeys.Add(key);
                        extraValues.Add(new_component);
                        extraIndex.Add(key, new_component);
                      }
                    public virtual void extraTypemaneuverSetField(string key, JSONValue new_component)
                      {
                        Debug.Assert(key != null);
                        Debug.Assert(new_component != null);

                        JSONValue old_field = extraTypemaneuverLookup(key);
                        if (old_field == null)
                          {
                            extraTypemaneuverAppendPair(key, new_component);
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
                        Debug.Assert(partial_allowed || flagHasinstruction);
                        if (flagHasinstruction)
                          {
                            handler.start_pair("instruction");
                            handler.string_value(storeinstruction);
                          }
                        Debug.Assert(partial_allowed || flagHasposition);
                        if (flagHasposition)
                          {
                            handler.start_pair("position");
                            if (partial_allowed)
                                storeposition.write_partial_as_json(handler);
                            else
                                storeposition.write_as_json(handler);
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
                        if (!(hasinstruction()))
                          {
                            return "When parsing the object for %what%, the \"instruction\" field was missing.";
                          }
                        if (!(hasposition()))
                          {
                            return "When parsing the object for %what%, the \"position\" field was missing.";
                          }
                        return null;
                      }

                    public static TypemaneuverJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                      {
                        TypemaneuverJSON result;
                          {
                            HoldingGenerator generator = new HoldingGenerator("Type Typemaneuver", ignore_extras);
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
                    public static TypemaneuverJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
                  {
                    return from_json(json_value, ignore_extras, allow_incomplete, false);
                  }
                    public static TypemaneuverJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                      {
                        TypemaneuverJSON result;
                          {
                            HoldingGenerator generator = new HoldingGenerator("Type Typemaneuver", ignore_extras);
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
                    public static TypemaneuverJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
                  {
                    return from_json(json_value, ignore_extras, allow_incomplete, false);
                  }
                    public static TypemaneuverJSON from_text(string text, bool ignore_extras)
                      {
                        TypemaneuverJSON result;
                          {
                            HoldingGenerator generator = new HoldingGenerator("Type Typemaneuver", ignore_extras);
                            JSONParse.parse_json_value(text, "Text for TypemaneuverJSON", generator);
                            Debug.Assert(generator.have_value);
                            result = generator.value;
                          };
                        return result;
                      }
                    public static TypemaneuverJSON from_file(TextReader fp, string file_name, bool ignore_extras)
                      {
                        TypemaneuverJSON result;
                          {
                            HoldingGenerator generator = new HoldingGenerator("Type Typemaneuver", ignore_extras);
                            JSONParse.parse_json_value(fp, file_name, generator);
                            Debug.Assert(generator.have_value);
                            result = generator.value;
                          };
                        return result;
                      }
                    public abstract class Generator : JSONObjectGenerator
                      {
                        private JSONHoldingStringGenerator fieldGeneratorinstruction;
                        private TypepositionJSON.HoldingGenerator fieldGeneratorposition;
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
                            TypemaneuverJSON result = new TypemaneuverJSON();
                            Debug.Assert(result != null);
                            finish(result);
                            int extra_count = unknownFieldGenerator.field_names.Count;
                            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                              {
                                result.extraTypemaneuverAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                              }
                            unknownFieldGenerator.field_names.Clear();
                            unknownFieldGenerator.field_values.Clear();
                            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                            handle_result(result);
                          }
                        protected void finish(TypemaneuverJSON result)
                          {
                            if (fieldGeneratorinstruction.have_value)
                              {
                                result.setinstruction(fieldGeneratorinstruction.value);
                                fieldGeneratorinstruction.have_value = false;
                              }
                            else if ((!(result.hasinstruction())) && !allow_incomplete)
                              {
                                error("When parsing the object for %what%, the \"instruction\" field was missing.");
                              }
                            if (fieldGeneratorposition.have_value)
                              {
                                result.setposition(fieldGeneratorposition.value);
                                fieldGeneratorposition.have_value = false;
                              }
                            else if ((!(result.hasposition())) && !allow_incomplete)
                              {
                                error("When parsing the object for %what%, the \"position\" field was missing.");
                              }
                          }
                        protected abstract void handle_result(TypemaneuverJSON new_result);
                        protected virtual JSONHandler start_known_field(string field_name)
                          {
                            switch (field_name[0])
                              {
                                case 'i':
                                    if ((String.Compare(field_name, 1, "nstruction", 0, 10, false) == 0) && (field_name.Length == 11))
                                        return fieldGeneratorinstruction;
                                    break;
                                case 'p':
                                    if ((String.Compare(field_name, 1, "osition", 0, 7, false) == 0) && (field_name.Length == 8))
                                        return fieldGeneratorposition;
                                    break;
                                default:
                                    break;
                              }
                            return null;
                          }
                        public Generator(bool ignore_extras)
                          {
                            fieldGeneratorinstruction = new JSONHoldingStringGenerator("field \"instruction\" of the Typemaneuver class");
                            fieldGeneratorposition = new TypepositionJSON.HoldingGenerator("field \"position\" of the Typemaneuver class", ignore_extras);
                            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                            set_what("the Typemaneuver class");
                            allow_incomplete = false;
                            allow_unpolished = false;
                          }
                        public Generator()
                          {
                            fieldGeneratorinstruction = new JSONHoldingStringGenerator("field \"instruction\" of the Typemaneuver class");
                            fieldGeneratorposition = new TypepositionJSON.HoldingGenerator("field \"position\" of the Typemaneuver class", false);
                            unknownFieldGenerator = new UnknownFieldGenerator(false);
                            set_what("the Typemaneuver class");
                            allow_incomplete = false;
                            allow_unpolished = false;
                          }

                        public override void reset()
                          {
                            fieldGeneratorinstruction.reset();
                            fieldGeneratorposition.reset();
                            base.reset();
                            unknownFieldGenerator.reset();
                          }
                        public void set_allow_incomplete(bool new_allow_incomplete)
                          {
                            allow_incomplete = new_allow_incomplete;
                            fieldGeneratorposition.set_allow_incomplete(new_allow_incomplete);
                          }
                        public void set_allow_unpolished(bool new_allow_unpolished)
                          {
                            allow_unpolished = new_allow_unpolished;
                            fieldGeneratorposition.set_allow_unpolished(new_allow_unpolished);
                          }
                      };
                    public class HoldingGenerator : Generator
                      {
                        protected override void handle_result(TypemaneuverJSON  result)
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
                        public TypemaneuverJSON value;
                      };
                    public class HoldingArrayGenerator : JSONArrayGenerator
                  {
                    protected class ElementHandler : Generator
                      {
                        private HoldingArrayGenerator top;

                        protected override void handle_result(TypemaneuverJSON  result)
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
                    protected virtual void handle_result(List<TypemaneuverJSON> result)

                      {
                      }

                    public HoldingArrayGenerator(string what, bool ignore_extras)
                      {
                        element_handler = new ElementHandler(this, ignore_extras);
                        have_value = false;
                        value = new List<TypemaneuverJSON>();
                        base.set_what(what);
                      }
                    public HoldingArrayGenerator(bool ignore_extras)
                      {
                        element_handler = new ElementHandler(this, ignore_extras);
                        value = new List<TypemaneuverJSON>();
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
                    public List<TypemaneuverJSON> value;
                  };
                  };
                private bool flagHasstart;
                private TypestartJSON  storestart;
                private bool flagHasend;
                private TypeendJSON  storeend;
                private bool flagHasmaneuver;
                private List< TypemaneuverJSON  > storemaneuver;
                private List<string> extraKeys;
                private List<JSONValue > extraValues;
                private Dictionary<string, JSONValue > extraIndex;


                private void  fromJSONstart(JSONValue json_value, bool ignore_extras)
                  {
                    Debug.Assert(json_value != null);
                    TypestartJSON convert_classy = TypestartJSON.from_json(json_value, ignore_extras, true);
                    setstart(convert_classy);
                  }


                private void  fromJSONend(JSONValue json_value, bool ignore_extras)
                  {
                    Debug.Assert(json_value != null);
                    TypeendJSON convert_classy = TypeendJSON.from_json(json_value, ignore_extras, true);
                    setend(convert_classy);
                  }


                private void  fromJSONmaneuver(JSONValue json_value, bool ignore_extras)
                  {
                    Debug.Assert(json_value != null);
                    JSONArrayValue json_array1 = json_value.array_value();
                    if (json_array1 == null)
                        throw new Exception("The value for field maneuver of TypelegJSON is not an array.");
                    int count1 = json_array1.componentCount();
                    if (count1 < 1)
                        throw new Exception("The value for field maneuver of TypelegJSON has too few elements.");
                    List< TypemaneuverJSON  > vector_maneuver1 = new List< TypemaneuverJSON  >(count1);
                    for (int num1 = 0; num1 < count1; ++num1)
                      {
                        TypemaneuverJSON convert_classy = TypemaneuverJSON.from_json(json_array1.component(num1), ignore_extras, true);
                        vector_maneuver1.Add(convert_classy);
                      }
                    Debug.Assert(vector_maneuver1.Count >= 1);
                    initmaneuver();
                    for (int num1 = 0; num1 < vector_maneuver1.Count; ++num1)
                        appendmaneuver(vector_maneuver1[num1]);
                    for (int num1 = 0; num1 < vector_maneuver1.Count; ++num1)
                      {
                      }
                  }


                public TypelegJSON()
                  {
                    flagHasstart = false;
                    flagHasend = false;
                    flagHasmaneuver = false;
                    storemaneuver = new List< TypemaneuverJSON  >();
                    extraKeys = new List<string>();
                extraValues = new List<JSONValue >();
                extraIndex = new Dictionary<string, JSONValue >();
                  }

                public bool  hasstart()
                  {
                    return flagHasstart;
                  }

                public TypestartJSON   getstart()
                  {
                    Debug.Assert(flagHasstart);
                    return storestart;
                  }

                public bool  hasend()
                  {
                    return flagHasend;
                  }

                public TypeendJSON   getend()
                  {
                    Debug.Assert(flagHasend);
                    return storeend;
                  }

                public bool  hasmaneuver()
                  {
                    return flagHasmaneuver;
                  }

                public int  countOfmaneuver()
                  {
                    Debug.Assert(flagHasmaneuver);
                    return storemaneuver.Count;
                  }

                public TypemaneuverJSON   elementOfmaneuver(int element_num)
                  {
                    Debug.Assert(flagHasmaneuver);
                    return storemaneuver[element_num];
                  }

                public List< TypemaneuverJSON  >  getmaneuver()
                  {
                    Debug.Assert(flagHasmaneuver);
                    return storemaneuver;
                  }


                public virtual int extraTypelegComponentCount()
                  {
                    Debug.Assert(extraKeys.Count == extraValues.Count);
                    return extraKeys.Count;
                  }
                public virtual string extraTypelegComponentKey(int component_num)
                  {
                    Debug.Assert(extraKeys.Count == extraValues.Count);
                    Debug.Assert(component_num < extraValues.Count);
                    return extraKeys[component_num];
                  }
                public virtual JSONValue extraTypelegComponentValue(int component_num)
                  {
                    Debug.Assert(extraKeys.Count == extraValues.Count);
                    Debug.Assert(component_num < extraValues.Count);
                    return extraValues[component_num];
                  }
                public virtual JSONValue extraTypelegLookup(string field_name)
                  {
                    JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                    return result;
                  }

                public void setstart(TypestartJSON  new_value)
                  {
                    if (flagHasstart)
                      {
                      }
                    flagHasstart = true;
                    storestart = new_value;
                  }
                public void unsetstart()
                  {
                    if (flagHasstart)
                      {
                      }
                    flagHasstart = false;
                  }
                public void setend(TypeendJSON  new_value)
                  {
                    if (flagHasend)
                      {
                      }
                    flagHasend = true;
                    storeend = new_value;
                  }
                public void unsetend()
                  {
                    if (flagHasend)
                      {
                      }
                    flagHasend = false;
                  }
                public void initmaneuver()
                  {
                    if (flagHasmaneuver)
                      {
                        for (int num1 = 0; num1 < storemaneuver.Count; ++num1)
                          {
                          }
                      }
                    flagHasmaneuver = true;
                    storemaneuver.Clear();
                  }
                public void appendmaneuver(TypemaneuverJSON  to_append)
                  {
                    if (!flagHasmaneuver)
                      {
                        flagHasmaneuver = true;
                        storemaneuver.Clear();
                      }
                    Debug.Assert(flagHasmaneuver);
                    storemaneuver.Add(to_append);
                  }
                public void unsetmaneuver()
                  {
                    if (flagHasmaneuver)
                      {
                        for (int num2 = 0; num2 < storemaneuver.Count; ++num2)
                          {
                          }
                      }
                    flagHasmaneuver = false;
                    storemaneuver.Clear();
                  }

                public virtual void extraTypelegAppendPair(string key, JSONValue new_component)
                  {
                    Debug.Assert(key != null);
                    Debug.Assert(new_component != null);

                    Debug.Assert(extraKeys.Count == extraValues.Count);
                    extraKeys.Add(key);
                    extraValues.Add(new_component);
                    extraIndex.Add(key, new_component);
                  }
                public virtual void extraTypelegSetField(string key, JSONValue new_component)
                  {
                    Debug.Assert(key != null);
                    Debug.Assert(new_component != null);

                    JSONValue old_field = extraTypelegLookup(key);
                    if (old_field == null)
                      {
                        extraTypelegAppendPair(key, new_component);
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
                    Debug.Assert(partial_allowed || flagHasstart);
                    if (flagHasstart)
                      {
                        handler.start_pair("start");
                        if (partial_allowed)
                            storestart.write_partial_as_json(handler);
                        else
                            storestart.write_as_json(handler);
                      }
                    Debug.Assert(partial_allowed || flagHasend);
                    if (flagHasend)
                      {
                        handler.start_pair("end");
                        if (partial_allowed)
                            storeend.write_partial_as_json(handler);
                        else
                            storeend.write_as_json(handler);
                      }
                    Debug.Assert(partial_allowed || flagHasmaneuver);
                    if (flagHasmaneuver)
                      {
                        handler.start_pair("maneuver");
                        Debug.Assert(storemaneuver.Count >= 1);
                        handler.start_array();
                        for (int num1 = 0; num1 < storemaneuver.Count; ++num1)
                          {
                            if (partial_allowed)
                                storemaneuver[num1].write_partial_as_json(handler);
                            else
                                storemaneuver[num1].write_as_json(handler);
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
                    if (!(hasstart()))
                      {
                        return "When parsing the object for %what%, the \"start\" field was missing.";
                      }
                    if (!(hasend()))
                      {
                        return "When parsing the object for %what%, the \"end\" field was missing.";
                      }
                    if (!(hasmaneuver()))
                      {
                        return "When parsing the object for %what%, the \"maneuver\" field was missing.";
                      }
                    return null;
                  }

                public static TypelegJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                  {
                    TypelegJSON result;
                      {
                        HoldingGenerator generator = new HoldingGenerator("Type Typeleg", ignore_extras);
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
                public static TypelegJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
              {
                return from_json(json_value, ignore_extras, allow_incomplete, false);
              }
                public static TypelegJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                  {
                    TypelegJSON result;
                      {
                        HoldingGenerator generator = new HoldingGenerator("Type Typeleg", ignore_extras);
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
                public static TypelegJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
              {
                return from_json(json_value, ignore_extras, allow_incomplete, false);
              }
                public static TypelegJSON from_text(string text, bool ignore_extras)
                  {
                    TypelegJSON result;
                      {
                        HoldingGenerator generator = new HoldingGenerator("Type Typeleg", ignore_extras);
                        JSONParse.parse_json_value(text, "Text for TypelegJSON", generator);
                        Debug.Assert(generator.have_value);
                        result = generator.value;
                      };
                    return result;
                  }
                public static TypelegJSON from_file(TextReader fp, string file_name, bool ignore_extras)
                  {
                    TypelegJSON result;
                      {
                        HoldingGenerator generator = new HoldingGenerator("Type Typeleg", ignore_extras);
                        JSONParse.parse_json_value(fp, file_name, generator);
                        Debug.Assert(generator.have_value);
                        result = generator.value;
                      };
                    return result;
                  }
                public abstract class Generator : JSONObjectGenerator
                  {
                    private TypestartJSON.HoldingGenerator fieldGeneratorstart;
                    private TypeendJSON.HoldingGenerator fieldGeneratorend;
                    private TypemaneuverJSON.HoldingArrayGenerator fieldGeneratormaneuver;
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
                        TypelegJSON result = new TypelegJSON();
                        Debug.Assert(result != null);
                        finish(result);
                        int extra_count = unknownFieldGenerator.field_names.Count;
                        Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                        for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                          {
                            result.extraTypelegAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                          }
                        unknownFieldGenerator.field_names.Clear();
                        unknownFieldGenerator.field_values.Clear();
                        unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                        handle_result(result);
                      }
                    protected void finish(TypelegJSON result)
                      {
                        if (fieldGeneratorstart.have_value)
                          {
                            result.setstart(fieldGeneratorstart.value);
                            fieldGeneratorstart.have_value = false;
                          }
                        else if ((!(result.hasstart())) && !allow_incomplete)
                          {
                            error("When parsing the object for %what%, the \"start\" field was missing.");
                          }
                        if (fieldGeneratorend.have_value)
                          {
                            result.setend(fieldGeneratorend.value);
                            fieldGeneratorend.have_value = false;
                          }
                        else if ((!(result.hasend())) && !allow_incomplete)
                          {
                            error("When parsing the object for %what%, the \"end\" field was missing.");
                          }
                        if (fieldGeneratormaneuver.have_value)
                          {
                            result.initmaneuver();
                            int count = fieldGeneratormaneuver.value.Count;
                            for (int num = 0; num < count; ++num)
                              {
                                result.appendmaneuver(fieldGeneratormaneuver.value[num]);
                              }
                            fieldGeneratormaneuver.value.Clear();
                            fieldGeneratormaneuver.have_value = false;
                          }
                        else if ((!(result.hasmaneuver())) && !allow_incomplete)
                          {
                            error("When parsing the object for %what%, the \"maneuver\" field was missing.");
                          }
                      }
                    protected abstract void handle_result(TypelegJSON new_result);
                    protected virtual JSONHandler start_known_field(string field_name)
                      {
                        switch (field_name[0])
                          {
                            case 'e':
                                if ((String.Compare(field_name, 1, "nd", 0, 2, false) == 0) && (field_name.Length == 3))
                                    return fieldGeneratorend;
                                break;
                            case 'm':
                                if ((String.Compare(field_name, 1, "aneuver", 0, 7, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratormaneuver;
                                break;
                            case 's':
                                if ((String.Compare(field_name, 1, "tart", 0, 4, false) == 0) && (field_name.Length == 5))
                                    return fieldGeneratorstart;
                                break;
                            default:
                                break;
                          }
                        return null;
                      }
                    public Generator(bool ignore_extras)
                      {
                        fieldGeneratorstart = new TypestartJSON.HoldingGenerator("field \"start\" of the Typeleg class", ignore_extras);
                        fieldGeneratorend = new TypeendJSON.HoldingGenerator("field \"end\" of the Typeleg class", ignore_extras);
                        fieldGeneratormaneuver = new TypemaneuverJSON.HoldingArrayGenerator("field \"maneuver\" of the Typeleg class", ignore_extras);
                        unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                        set_what("the Typeleg class");
                        allow_incomplete = false;
                        allow_unpolished = false;
                      }
                    public Generator()
                      {
                        fieldGeneratorstart = new TypestartJSON.HoldingGenerator("field \"start\" of the Typeleg class", false);
                        fieldGeneratorend = new TypeendJSON.HoldingGenerator("field \"end\" of the Typeleg class", false);
                        fieldGeneratormaneuver = new TypemaneuverJSON.HoldingArrayGenerator("field \"maneuver\" of the Typeleg class", false);
                        unknownFieldGenerator = new UnknownFieldGenerator(false);
                        set_what("the Typeleg class");
                        allow_incomplete = false;
                        allow_unpolished = false;
                      }

                    public override void reset()
                      {
                        fieldGeneratorstart.reset();
                        fieldGeneratorend.reset();
                        fieldGeneratormaneuver.reset();
                        base.reset();
                        unknownFieldGenerator.reset();
                      }
                    public void set_allow_incomplete(bool new_allow_incomplete)
                      {
                        allow_incomplete = new_allow_incomplete;
                        fieldGeneratorstart.set_allow_incomplete(new_allow_incomplete);
                        fieldGeneratorend.set_allow_incomplete(new_allow_incomplete);
                      }
                    public void set_allow_unpolished(bool new_allow_unpolished)
                      {
                        allow_unpolished = new_allow_unpolished;
                        fieldGeneratorstart.set_allow_unpolished(new_allow_unpolished);
                        fieldGeneratorend.set_allow_unpolished(new_allow_unpolished);
                      }
                  };
                public class HoldingGenerator : Generator
                  {
                    protected override void handle_result(TypelegJSON  result)
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
                    public TypelegJSON value;
                  };
                public class HoldingArrayGenerator : JSONArrayGenerator
              {
                protected class ElementHandler : Generator
                  {
                    private HoldingArrayGenerator top;

                    protected override void handle_result(TypelegJSON  result)
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
                protected virtual void handle_result(List<TypelegJSON> result)

                  {
                  }

                public HoldingArrayGenerator(string what, bool ignore_extras)
                  {
                    element_handler = new ElementHandler(this, ignore_extras);
                    have_value = false;
                    value = new List<TypelegJSON>();
                    base.set_what(what);
                  }
                public HoldingArrayGenerator(bool ignore_extras)
                  {
                    element_handler = new ElementHandler(this, ignore_extras);
                    value = new List<TypelegJSON>();
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
                public List<TypelegJSON> value;
              };
              };
            private bool flagHassummary;
            private TypesummaryJSON  storesummary;
            private bool flagHasshape;
            private List< string > storeshape;
            private bool flagHasleg;
            private List< TypelegJSON  > storeleg;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONsummary(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                TypesummaryJSON convert_classy = TypesummaryJSON.from_json(json_value, ignore_extras, true);
                setsummary(convert_classy);
              }


            private void  fromJSONshape(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONArrayValue json_array1 = json_value.array_value();
                if (json_array1 == null)
                    throw new Exception("The value for field shape of TyperouteJSON is not an array.");
                int count1 = json_array1.componentCount();
                if (count1 < 2)
                    throw new Exception("The value for field shape of TyperouteJSON has too few elements.");
                List< string > vector_shape1 = new List< string >(count1);
                for (int num1 = 0; num1 < count1; ++num1)
                  {
                    JSONStringValue json_string = json_array1.component(num1).string_value();
                    if (json_string == null)
                        throw new Exception("The value for an element of field shape of TyperouteJSON is not a string.");
                    vector_shape1.Add(json_string.getData());
                  }
                Debug.Assert(vector_shape1.Count >= 2);
                initshape();
                for (int num2 = 0; num2 < vector_shape1.Count; ++num2)
                    appendshape(vector_shape1[num2]);
                for (int num1 = 0; num1 < vector_shape1.Count; ++num1)
                  {
                  }
              }


            private void  fromJSONleg(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONArrayValue json_array1 = json_value.array_value();
                if (json_array1 == null)
                    throw new Exception("The value for field leg of TyperouteJSON is not an array.");
                int count1 = json_array1.componentCount();
                if (count1 < 2)
                    throw new Exception("The value for field leg of TyperouteJSON has too few elements.");
                List< TypelegJSON  > vector_leg1 = new List< TypelegJSON  >(count1);
                for (int num1 = 0; num1 < count1; ++num1)
                  {
                    TypelegJSON convert_classy = TypelegJSON.from_json(json_array1.component(num1), ignore_extras, true);
                    vector_leg1.Add(convert_classy);
                  }
                Debug.Assert(vector_leg1.Count >= 2);
                initleg();
                for (int num3 = 0; num3 < vector_leg1.Count; ++num3)
                    appendleg(vector_leg1[num3]);
                for (int num1 = 0; num1 < vector_leg1.Count; ++num1)
                  {
                  }
              }


            public TyperouteJSON()
              {
                flagHassummary = false;
                flagHasshape = false;
                flagHasleg = false;
                storeshape = new List< string >();
                storeleg = new List< TypelegJSON  >();
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hassummary()
              {
                return flagHassummary;
              }

            public TypesummaryJSON   getsummary()
              {
                Debug.Assert(flagHassummary);
                return storesummary;
              }

            public bool  hasshape()
              {
                return flagHasshape;
              }

            public int  countOfshape()
              {
                Debug.Assert(flagHasshape);
                return storeshape.Count;
              }

            public string  elementOfshape(int element_num)
              {
                Debug.Assert(flagHasshape);
                return storeshape[element_num];
              }

            public List< string >  getshape()
              {
                Debug.Assert(flagHasshape);
                return storeshape;
              }

            public bool  hasleg()
              {
                return flagHasleg;
              }

            public int  countOfleg()
              {
                Debug.Assert(flagHasleg);
                return storeleg.Count;
              }

            public TypelegJSON   elementOfleg(int element_num)
              {
                Debug.Assert(flagHasleg);
                return storeleg[element_num];
              }

            public List< TypelegJSON  >  getleg()
              {
                Debug.Assert(flagHasleg);
                return storeleg;
              }


            public virtual int extraTyperouteComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTyperouteComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTyperouteComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTyperouteLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setsummary(TypesummaryJSON  new_value)
              {
                if (flagHassummary)
                  {
                  }
                flagHassummary = true;
                storesummary = new_value;
              }
            public void unsetsummary()
              {
                if (flagHassummary)
                  {
                  }
                flagHassummary = false;
              }
            public void initshape()
              {
                flagHasshape = true;
                storeshape.Clear();
              }
            public void appendshape(string to_append)
              {
                if (!flagHasshape)
                  {
                    flagHasshape = true;
                    storeshape.Clear();
                  }
                Debug.Assert(flagHasshape);
                storeshape.Add(to_append);
              }
            public void unsetshape()
              {
                flagHasshape = false;
                storeshape.Clear();
              }
            public void initleg()
              {
                if (flagHasleg)
                  {
                    for (int num3 = 0; num3 < storeleg.Count; ++num3)
                      {
                      }
                  }
                flagHasleg = true;
                storeleg.Clear();
              }
            public void appendleg(TypelegJSON  to_append)
              {
                if (!flagHasleg)
                  {
                    flagHasleg = true;
                    storeleg.Clear();
                  }
                Debug.Assert(flagHasleg);
                storeleg.Add(to_append);
              }
            public void unsetleg()
              {
                if (flagHasleg)
                  {
                    for (int num4 = 0; num4 < storeleg.Count; ++num4)
                      {
                      }
                  }
                flagHasleg = false;
                storeleg.Clear();
              }

            public virtual void extraTyperouteAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTyperouteSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTyperouteLookup(key);
                if (old_field == null)
                  {
                    extraTyperouteAppendPair(key, new_component);
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
                Debug.Assert(partial_allowed || flagHassummary);
                if (flagHassummary)
                  {
                    handler.start_pair("summary");
                    if (partial_allowed)
                        storesummary.write_partial_as_json(handler);
                    else
                        storesummary.write_as_json(handler);
                  }
                if (flagHasshape)
                  {
                    handler.start_pair("shape");
                    Debug.Assert(storeshape.Count >= 2);
                    handler.start_array();
                    for (int num1 = 0; num1 < storeshape.Count; ++num1)
                      {
                        handler.string_value(storeshape[num1]);
                      }
                    handler.finish_array();
                  }
                if (flagHasleg)
                  {
                    handler.start_pair("leg");
                    Debug.Assert(storeleg.Count >= 2);
                    handler.start_array();
                    for (int num2 = 0; num2 < storeleg.Count; ++num2)
                      {
                        if (partial_allowed)
                            storeleg[num2].write_partial_as_json(handler);
                        else
                            storeleg[num2].write_as_json(handler);
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
                if (!(hassummary()))
                  {
                    return "When parsing the object for %what%, the \"summary\" field was missing.";
                  }
                return null;
              }

            public static TyperouteJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TyperouteJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typeroute", ignore_extras);
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
            public static TyperouteJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TyperouteJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TyperouteJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typeroute", ignore_extras);
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
            public static TyperouteJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TyperouteJSON from_text(string text, bool ignore_extras)
              {
                TyperouteJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typeroute", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TyperouteJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TyperouteJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TyperouteJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typeroute", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private TypesummaryJSON.HoldingGenerator fieldGeneratorsummary;
                private JSONHoldingStringArrayGenerator fieldGeneratorshape;
                private TypelegJSON.HoldingArrayGenerator fieldGeneratorleg;
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
                    TyperouteJSON result = new TyperouteJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTyperouteAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TyperouteJSON result)
                  {
                    if (fieldGeneratorsummary.have_value)
                      {
                        result.setsummary(fieldGeneratorsummary.value);
                        fieldGeneratorsummary.have_value = false;
                      }
                    else if ((!(result.hassummary())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"summary\" field was missing.");
                      }
                    if (fieldGeneratorshape.have_value)
                      {
                        result.initshape();
                        int count = fieldGeneratorshape.value.Count;
                        for (int num = 0; num < count; ++num)
                          {
                            result.appendshape(fieldGeneratorshape.value[num]);
                          }
                        fieldGeneratorshape.value.Clear();
                        fieldGeneratorshape.have_value = false;
                      }
                    if (fieldGeneratorleg.have_value)
                      {
                        result.initleg();
                        int count = fieldGeneratorleg.value.Count;
                        for (int num = 0; num < count; ++num)
                          {
                            result.appendleg(fieldGeneratorleg.value[num]);
                          }
                        fieldGeneratorleg.value.Clear();
                        fieldGeneratorleg.have_value = false;
                      }
                  }
                protected abstract void handle_result(TyperouteJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    switch (field_name[0])
                      {
                        case 'l':
                            if ((String.Compare(field_name, 1, "eg", 0, 2, false) == 0) && (field_name.Length == 3))
                                return fieldGeneratorleg;
                            break;
                        case 's':
                            switch (field_name[1])
                              {
                                case 'h':
                                    if ((String.Compare(field_name, 2, "ape", 0, 3, false) == 0) && (field_name.Length == 5))
                                        return fieldGeneratorshape;
                                    break;
                                case 'u':
                                    if ((String.Compare(field_name, 2, "mmary", 0, 5, false) == 0) && (field_name.Length == 7))
                                        return fieldGeneratorsummary;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorsummary = new TypesummaryJSON.HoldingGenerator("field \"summary\" of the Typeroute class", ignore_extras);
                    fieldGeneratorshape = new JSONHoldingStringArrayGenerator("field \"shape\" of the Typeroute class");
                    fieldGeneratorleg = new TypelegJSON.HoldingArrayGenerator("field \"leg\" of the Typeroute class", ignore_extras);
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the Typeroute class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorsummary = new TypesummaryJSON.HoldingGenerator("field \"summary\" of the Typeroute class", false);
                    fieldGeneratorshape = new JSONHoldingStringArrayGenerator("field \"shape\" of the Typeroute class");
                    fieldGeneratorleg = new TypelegJSON.HoldingArrayGenerator("field \"leg\" of the Typeroute class", false);
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the Typeroute class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorsummary.reset();
                    fieldGeneratorshape.reset();
                    fieldGeneratorleg.reset();
                    base.reset();
                    unknownFieldGenerator.reset();
                  }
                public void set_allow_incomplete(bool new_allow_incomplete)
                  {
                    allow_incomplete = new_allow_incomplete;
                    fieldGeneratorsummary.set_allow_incomplete(new_allow_incomplete);
                  }
                public void set_allow_unpolished(bool new_allow_unpolished)
                  {
                    allow_unpolished = new_allow_unpolished;
                    fieldGeneratorsummary.set_allow_unpolished(new_allow_unpolished);
                  }
              };
            public class HoldingGenerator : Generator
              {
                protected override void handle_result(TyperouteJSON  result)
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
                public TyperouteJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TyperouteJSON  result)
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
            protected virtual void handle_result(List<TyperouteJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TyperouteJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TyperouteJSON>();
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
            public List<TyperouteJSON> value;
          };
          };
        private bool flagHasroute;
        private List< TyperouteJSON  > storeroute;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONroute(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field route of TyperesponseJSON is not an array.");
            int count1 = json_array1.componentCount();
            if (count1 < 1)
                throw new Exception("The value for field route of TyperesponseJSON has too few elements.");
            List< TyperouteJSON  > vector_route1 = new List< TyperouteJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                TyperouteJSON convert_classy = TyperouteJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_route1.Add(convert_classy);
              }
            Debug.Assert(vector_route1.Count >= 1);
            initroute();
            for (int num4 = 0; num4 < vector_route1.Count; ++num4)
                appendroute(vector_route1[num4]);
            for (int num1 = 0; num1 < vector_route1.Count; ++num1)
              {
              }
          }


        public TyperesponseJSON()
          {
            flagHasroute = false;
            storeroute = new List< TyperouteJSON  >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasroute()
          {
            return flagHasroute;
          }

        public int  countOfroute()
          {
            Debug.Assert(flagHasroute);
            return storeroute.Count;
          }

        public TyperouteJSON   elementOfroute(int element_num)
          {
            Debug.Assert(flagHasroute);
            return storeroute[element_num];
          }

        public List< TyperouteJSON  >  getroute()
          {
            Debug.Assert(flagHasroute);
            return storeroute;
          }


        public virtual int extraTyperesponseComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTyperesponseComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTyperesponseComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTyperesponseLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void initroute()
          {
            if (flagHasroute)
              {
                for (int num5 = 0; num5 < storeroute.Count; ++num5)
                  {
                  }
              }
            flagHasroute = true;
            storeroute.Clear();
          }
        public void appendroute(TyperouteJSON  to_append)
          {
            if (!flagHasroute)
              {
                flagHasroute = true;
                storeroute.Clear();
              }
            Debug.Assert(flagHasroute);
            storeroute.Add(to_append);
          }
        public void unsetroute()
          {
            if (flagHasroute)
              {
                for (int num6 = 0; num6 < storeroute.Count; ++num6)
                  {
                  }
              }
            flagHasroute = false;
            storeroute.Clear();
          }

        public virtual void extraTyperesponseAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTyperesponseSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTyperesponseLookup(key);
            if (old_field == null)
              {
                extraTyperesponseAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasroute);
            if (flagHasroute)
              {
                handler.start_pair("route");
                Debug.Assert(storeroute.Count >= 1);
                handler.start_array();
                for (int num1 = 0; num1 < storeroute.Count; ++num1)
                  {
                    if (partial_allowed)
                        storeroute[num1].write_partial_as_json(handler);
                    else
                        storeroute[num1].write_as_json(handler);
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
            if (!(hasroute()))
              {
                return "When parsing the object for %what%, the \"route\" field was missing.";
              }
            return null;
          }

        public static TyperesponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TyperesponseJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typeresponse", ignore_extras);
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
        public static TyperesponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TyperesponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TyperesponseJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typeresponse", ignore_extras);
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
        public static TyperesponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TyperesponseJSON from_text(string text, bool ignore_extras)
          {
            TyperesponseJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typeresponse", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TyperesponseJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TyperesponseJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TyperesponseJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typeresponse", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private TyperouteJSON.HoldingArrayGenerator fieldGeneratorroute;
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
                TyperesponseJSON result = new TyperesponseJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTyperesponseAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TyperesponseJSON result)
              {
                if (fieldGeneratorroute.have_value)
                  {
                    result.initroute();
                    int count = fieldGeneratorroute.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendroute(fieldGeneratorroute.value[num]);
                      }
                    fieldGeneratorroute.value.Clear();
                    fieldGeneratorroute.have_value = false;
                  }
                else if ((!(result.hasroute())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"route\" field was missing.");
                  }
              }
            protected abstract void handle_result(TyperesponseJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "route", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorroute;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorroute = new TyperouteJSON.HoldingArrayGenerator("field \"route\" of the Typeresponse class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the Typeresponse class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorroute = new TyperouteJSON.HoldingArrayGenerator("field \"route\" of the Typeresponse class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the Typeresponse class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorroute.reset();
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
            protected override void handle_result(TyperesponseJSON  result)
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
            public TyperesponseJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TyperesponseJSON  result)
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
        protected virtual void handle_result(List<TyperesponseJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TyperesponseJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TyperesponseJSON>();
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
        public List<TyperesponseJSON> value;
      };
      };
    private bool flagHasresponse;
    private TyperesponseJSON  storeresponse;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONresponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TyperesponseJSON convert_classy = TyperesponseJSON.from_json(json_value, ignore_extras, true);
        setresponse(convert_classy);
      }


    public HereAPIRoutingJSON()
      {
        flagHasresponse = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasresponse()
      {
        return flagHasresponse;
      }

    public TyperesponseJSON   getresponse()
      {
        Debug.Assert(flagHasresponse);
        return storeresponse;
      }


    public virtual int extraHereAPIRoutingComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHereAPIRoutingComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHereAPIRoutingComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHereAPIRoutingLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setresponse(TyperesponseJSON  new_value)
      {
        if (flagHasresponse)
          {
          }
        flagHasresponse = true;
        storeresponse = new_value;
      }
    public void unsetresponse()
      {
        if (flagHasresponse)
          {
          }
        flagHasresponse = false;
      }

    public virtual void extraHereAPIRoutingAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHereAPIRoutingSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHereAPIRoutingLookup(key);
        if (old_field == null)
          {
            extraHereAPIRoutingAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasresponse);
        if (flagHasresponse)
          {
            handler.start_pair("response");
            if (partial_allowed)
                storeresponse.write_partial_as_json(handler);
            else
                storeresponse.write_as_json(handler);
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
        if (!(hasresponse()))
          {
            return "When parsing the object for %what%, the \"response\" field was missing.";
          }
        return null;
      }

    public static HereAPIRoutingJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HereAPIRoutingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HereAPIRouting", ignore_extras);
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
    public static HereAPIRoutingJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HereAPIRoutingJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HereAPIRoutingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HereAPIRouting", ignore_extras);
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
    public static HereAPIRoutingJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HereAPIRoutingJSON from_text(string text, bool ignore_extras)
      {
        HereAPIRoutingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HereAPIRouting", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HereAPIRoutingJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HereAPIRoutingJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HereAPIRoutingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HereAPIRouting", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private TyperesponseJSON.HoldingGenerator fieldGeneratorresponse;
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
            HereAPIRoutingJSON result = new HereAPIRoutingJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHereAPIRoutingAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HereAPIRoutingJSON result)
          {
            if (fieldGeneratorresponse.have_value)
              {
                result.setresponse(fieldGeneratorresponse.value);
                fieldGeneratorresponse.have_value = false;
              }
            else if ((!(result.hasresponse())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"response\" field was missing.");
              }
          }
        protected abstract void handle_result(HereAPIRoutingJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "response", 0, 8, false) == 0) && (field_name.Length == 8))
                return fieldGeneratorresponse;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorresponse = new TyperesponseJSON.HoldingGenerator("field \"response\" of the HereAPIRouting class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HereAPIRouting class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorresponse = new TyperesponseJSON.HoldingGenerator("field \"response\" of the HereAPIRouting class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HereAPIRouting class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorresponse.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorresponse.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorresponse.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HereAPIRoutingJSON  result)
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
        public HereAPIRoutingJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HereAPIRoutingJSON  result)
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
    protected virtual void handle_result(List<HereAPIRoutingJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HereAPIRoutingJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HereAPIRoutingJSON>();
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
    public List<HereAPIRoutingJSON> value;
  };
  };
