/* file "SportsOlympicsAPIMedalStandingsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SportsOlympicsAPIMedalStandingsJSON : JSONBase
  {
    public class Typemedals_by_countryJSON : JSONBase
      {
        public class Typemedal_infoJSON : JSONBase
          {
            private bool flagHascountry;
            private string storecountry;
            private bool flagHascountry_code;
            private string storecountry_code;
            private bool flagHasioc_code;
            private string storeioc_code;
            private bool flagHastotal_ranking;
            private BigInteger storetotal_ranking;
            private bool flagHasgold_ranking;
            private BigInteger storegold_ranking;
            private bool flagHastotal;
            private BigInteger storetotal;
            private bool flagHasgold;
            private BigInteger storegold;
            private bool flagHassilver;
            private BigInteger storesilver;
            private bool flagHasbronze;
            private BigInteger storebronze;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONcountry(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field country of Typemedal_infoJSON is not a string.");
                setcountry(json_string.getData());
              }


            private void  fromJSONcountry_code(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field country_code of Typemedal_infoJSON is not a string.");
                setcountry_code(json_string.getData());
              }


            private void  fromJSONioc_code(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field ioc_code of Typemedal_infoJSON is not a string.");
                setioc_code(json_string.getData());
              }


            private void  fromJSONtotal_ranking(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                BigInteger extracted_integer;
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer == null)
                  {
                    JSONRationalValue json_rational = json_value.rational_value();
                    if (json_rational == null)
                      {
                        throw new Exception("The value for field total_ranking of Typemedal_infoJSON is not a number.");
                      }
                    if (!(json_rational.isInteger()))
                      {
                        throw new Exception("The value for field total_ranking of Typemedal_infoJSON is not an integer.");
                      }
                    extracted_integer = json_rational.getInteger()                ;
                  }
                else
                  {
                    extracted_integer = json_integer.getData()                ;
                  }
                settotal_ranking(extracted_integer);
              }


            private void  fromJSONgold_ranking(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                BigInteger extracted_integer;
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer == null)
                  {
                    JSONRationalValue json_rational = json_value.rational_value();
                    if (json_rational == null)
                      {
                        throw new Exception("The value for field gold_ranking of Typemedal_infoJSON is not a number.");
                      }
                    if (!(json_rational.isInteger()))
                      {
                        throw new Exception("The value for field gold_ranking of Typemedal_infoJSON is not an integer.");
                      }
                    extracted_integer = json_rational.getInteger()                ;
                  }
                else
                  {
                    extracted_integer = json_integer.getData()                ;
                  }
                setgold_ranking(extracted_integer);
              }


            private void  fromJSONtotal(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                BigInteger extracted_integer;
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer == null)
                  {
                    JSONRationalValue json_rational = json_value.rational_value();
                    if (json_rational == null)
                      {
                        throw new Exception("The value for field total of Typemedal_infoJSON is not a number.");
                      }
                    if (!(json_rational.isInteger()))
                      {
                        throw new Exception("The value for field total of Typemedal_infoJSON is not an integer.");
                      }
                    extracted_integer = json_rational.getInteger()                ;
                  }
                else
                  {
                    extracted_integer = json_integer.getData()                ;
                  }
                settotal(extracted_integer);
              }


            private void  fromJSONgold(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                BigInteger extracted_integer;
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer == null)
                  {
                    JSONRationalValue json_rational = json_value.rational_value();
                    if (json_rational == null)
                      {
                        throw new Exception("The value for field gold of Typemedal_infoJSON is not a number.");
                      }
                    if (!(json_rational.isInteger()))
                      {
                        throw new Exception("The value for field gold of Typemedal_infoJSON is not an integer.");
                      }
                    extracted_integer = json_rational.getInteger()                ;
                  }
                else
                  {
                    extracted_integer = json_integer.getData()                ;
                  }
                setgold(extracted_integer);
              }


            private void  fromJSONsilver(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                BigInteger extracted_integer;
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer == null)
                  {
                    JSONRationalValue json_rational = json_value.rational_value();
                    if (json_rational == null)
                      {
                        throw new Exception("The value for field silver of Typemedal_infoJSON is not a number.");
                      }
                    if (!(json_rational.isInteger()))
                      {
                        throw new Exception("The value for field silver of Typemedal_infoJSON is not an integer.");
                      }
                    extracted_integer = json_rational.getInteger()                ;
                  }
                else
                  {
                    extracted_integer = json_integer.getData()                ;
                  }
                setsilver(extracted_integer);
              }


            private void  fromJSONbronze(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                BigInteger extracted_integer;
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer == null)
                  {
                    JSONRationalValue json_rational = json_value.rational_value();
                    if (json_rational == null)
                      {
                        throw new Exception("The value for field bronze of Typemedal_infoJSON is not a number.");
                      }
                    if (!(json_rational.isInteger()))
                      {
                        throw new Exception("The value for field bronze of Typemedal_infoJSON is not an integer.");
                      }
                    extracted_integer = json_rational.getInteger()                ;
                  }
                else
                  {
                    extracted_integer = json_integer.getData()                ;
                  }
                setbronze(extracted_integer);
              }


            public Typemedal_infoJSON()
              {
                flagHascountry = false;
                flagHascountry_code = false;
                flagHasioc_code = false;
                flagHastotal_ranking = false;
                flagHasgold_ranking = false;
                flagHastotal = false;
                flagHasgold = false;
                flagHassilver = false;
                flagHasbronze = false;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hascountry()
              {
                return flagHascountry;
              }

            public string  getcountry()
              {
                Debug.Assert(flagHascountry);
                return storecountry;
              }

            public bool  hascountry_code()
              {
                return flagHascountry_code;
              }

            public string  getcountry_code()
              {
                Debug.Assert(flagHascountry_code);
                return storecountry_code;
              }

            public bool  hasioc_code()
              {
                return flagHasioc_code;
              }

            public string  getioc_code()
              {
                Debug.Assert(flagHasioc_code);
                return storeioc_code;
              }

            public bool  hastotal_ranking()
              {
                return flagHastotal_ranking;
              }

            public BigInteger  gettotal_ranking()
              {
                Debug.Assert(flagHastotal_ranking);
                return storetotal_ranking;
              }

            public bool  hasgold_ranking()
              {
                return flagHasgold_ranking;
              }

            public BigInteger  getgold_ranking()
              {
                Debug.Assert(flagHasgold_ranking);
                return storegold_ranking;
              }

            public bool  hastotal()
              {
                return flagHastotal;
              }

            public BigInteger  gettotal()
              {
                Debug.Assert(flagHastotal);
                return storetotal;
              }

            public bool  hasgold()
              {
                return flagHasgold;
              }

            public BigInteger  getgold()
              {
                Debug.Assert(flagHasgold);
                return storegold;
              }

            public bool  hassilver()
              {
                return flagHassilver;
              }

            public BigInteger  getsilver()
              {
                Debug.Assert(flagHassilver);
                return storesilver;
              }

            public bool  hasbronze()
              {
                return flagHasbronze;
              }

            public BigInteger  getbronze()
              {
                Debug.Assert(flagHasbronze);
                return storebronze;
              }


            public virtual int extraTypemedal_infoComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypemedal_infoComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypemedal_infoComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypemedal_infoLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setcountry(string new_value)
              {
                flagHascountry = true;
                storecountry = new_value;
              }
            public void unsetcountry()
              {
                flagHascountry = false;
              }
            public void setcountry_code(string new_value)
              {
                flagHascountry_code = true;
                storecountry_code = new_value;
              }
            public void unsetcountry_code()
              {
                flagHascountry_code = false;
              }
            public void setioc_code(string new_value)
              {
                flagHasioc_code = true;
                storeioc_code = new_value;
              }
            public void unsetioc_code()
              {
                flagHasioc_code = false;
              }
            public void settotal_ranking(BigInteger new_value)
              {
                flagHastotal_ranking = true;
                if (new_value < 0)
                    throw new Exception("The value for field total_ranking of Typemedal_infoJSON is less than the lower bound (0) for that field.");
                storetotal_ranking = new_value;
              }
            public void unsettotal_ranking()
              {
                flagHastotal_ranking = false;
              }
            public void setgold_ranking(BigInteger new_value)
              {
                flagHasgold_ranking = true;
                if (new_value < 0)
                    throw new Exception("The value for field gold_ranking of Typemedal_infoJSON is less than the lower bound (0) for that field.");
                storegold_ranking = new_value;
              }
            public void unsetgold_ranking()
              {
                flagHasgold_ranking = false;
              }
            public void settotal(BigInteger new_value)
              {
                flagHastotal = true;
                if (new_value < 0)
                    throw new Exception("The value for field total of Typemedal_infoJSON is less than the lower bound (0) for that field.");
                storetotal = new_value;
              }
            public void unsettotal()
              {
                flagHastotal = false;
              }
            public void setgold(BigInteger new_value)
              {
                flagHasgold = true;
                if (new_value < 0)
                    throw new Exception("The value for field gold of Typemedal_infoJSON is less than the lower bound (0) for that field.");
                storegold = new_value;
              }
            public void unsetgold()
              {
                flagHasgold = false;
              }
            public void setsilver(BigInteger new_value)
              {
                flagHassilver = true;
                if (new_value < 0)
                    throw new Exception("The value for field silver of Typemedal_infoJSON is less than the lower bound (0) for that field.");
                storesilver = new_value;
              }
            public void unsetsilver()
              {
                flagHassilver = false;
              }
            public void setbronze(BigInteger new_value)
              {
                flagHasbronze = true;
                if (new_value < 0)
                    throw new Exception("The value for field bronze of Typemedal_infoJSON is less than the lower bound (0) for that field.");
                storebronze = new_value;
              }
            public void unsetbronze()
              {
                flagHasbronze = false;
              }

            public virtual void extraTypemedal_infoAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypemedal_infoSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypemedal_infoLookup(key);
                if (old_field == null)
                  {
                    extraTypemedal_infoAppendPair(key, new_component);
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
                if (flagHascountry)
                  {
                    handler.start_pair("country");
                    handler.string_value(storecountry);
                  }
                if (flagHascountry_code)
                  {
                    handler.start_pair("country_code");
                    handler.string_value(storecountry_code);
                  }
                if (flagHasioc_code)
                  {
                    handler.start_pair("ioc_code");
                    handler.string_value(storeioc_code);
                  }
                if (flagHastotal_ranking)
                  {
                    handler.start_pair("total_ranking");
                    handler.number_value(storetotal_ranking);
                  }
                if (flagHasgold_ranking)
                  {
                    handler.start_pair("gold_ranking");
                    handler.number_value(storegold_ranking);
                  }
                if (flagHastotal)
                  {
                    handler.start_pair("total");
                    handler.number_value(storetotal);
                  }
                if (flagHasgold)
                  {
                    handler.start_pair("gold");
                    handler.number_value(storegold);
                  }
                if (flagHassilver)
                  {
                    handler.start_pair("silver");
                    handler.number_value(storesilver);
                  }
                if (flagHasbronze)
                  {
                    handler.start_pair("bronze");
                    handler.number_value(storebronze);
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

            public static Typemedal_infoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                Typemedal_infoJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typemedal_info", ignore_extras);
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
            public static Typemedal_infoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static Typemedal_infoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                Typemedal_infoJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typemedal_info", ignore_extras);
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
            public static Typemedal_infoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static Typemedal_infoJSON from_text(string text, bool ignore_extras)
              {
                Typemedal_infoJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typemedal_info", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for Typemedal_infoJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static Typemedal_infoJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                Typemedal_infoJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typemedal_info", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private JSONHoldingStringGenerator fieldGeneratorcountry;
                private JSONHoldingStringGenerator fieldGeneratorcountry_code;
                private JSONHoldingStringGenerator fieldGeneratorioc_code;
            private class FieldHoldingGeneratortotal_ranking : JSONHoldingIntegerLowerBoundOnlyGenerator
                  {
                    public FieldHoldingGeneratortotal_ranking(String what) : base(what, (BigInteger)(0))
                      {
                      }
                  };
            private class FieldHoldingArrayGeneratortotal_ranking : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
                  {
                    public FieldHoldingArrayGeneratortotal_ranking(String what) : base(what, (BigInteger)(0))
                      {
                      }
                  };
                private FieldHoldingGeneratortotal_ranking fieldGeneratortotal_ranking;
            private class FieldHoldingGeneratorgold_ranking : JSONHoldingIntegerLowerBoundOnlyGenerator
                  {
                    public FieldHoldingGeneratorgold_ranking(String what) : base(what, (BigInteger)(0))
                      {
                      }
                  };
            private class FieldHoldingArrayGeneratorgold_ranking : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
                  {
                    public FieldHoldingArrayGeneratorgold_ranking(String what) : base(what, (BigInteger)(0))
                      {
                      }
                  };
                private FieldHoldingGeneratorgold_ranking fieldGeneratorgold_ranking;
            private class FieldHoldingGeneratortotal : JSONHoldingIntegerLowerBoundOnlyGenerator
                  {
                    public FieldHoldingGeneratortotal(String what) : base(what, (BigInteger)(0))
                      {
                      }
                  };
            private class FieldHoldingArrayGeneratortotal : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
                  {
                    public FieldHoldingArrayGeneratortotal(String what) : base(what, (BigInteger)(0))
                      {
                      }
                  };
                private FieldHoldingGeneratortotal fieldGeneratortotal;
            private class FieldHoldingGeneratorgold : JSONHoldingIntegerLowerBoundOnlyGenerator
                  {
                    public FieldHoldingGeneratorgold(String what) : base(what, (BigInteger)(0))
                      {
                      }
                  };
            private class FieldHoldingArrayGeneratorgold : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
                  {
                    public FieldHoldingArrayGeneratorgold(String what) : base(what, (BigInteger)(0))
                      {
                      }
                  };
                private FieldHoldingGeneratorgold fieldGeneratorgold;
            private class FieldHoldingGeneratorsilver : JSONHoldingIntegerLowerBoundOnlyGenerator
                  {
                    public FieldHoldingGeneratorsilver(String what) : base(what, (BigInteger)(0))
                      {
                      }
                  };
            private class FieldHoldingArrayGeneratorsilver : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
                  {
                    public FieldHoldingArrayGeneratorsilver(String what) : base(what, (BigInteger)(0))
                      {
                      }
                  };
                private FieldHoldingGeneratorsilver fieldGeneratorsilver;
            private class FieldHoldingGeneratorbronze : JSONHoldingIntegerLowerBoundOnlyGenerator
                  {
                    public FieldHoldingGeneratorbronze(String what) : base(what, (BigInteger)(0))
                      {
                      }
                  };
            private class FieldHoldingArrayGeneratorbronze : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
                  {
                    public FieldHoldingArrayGeneratorbronze(String what) : base(what, (BigInteger)(0))
                      {
                      }
                  };
                private FieldHoldingGeneratorbronze fieldGeneratorbronze;
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
                    Typemedal_infoJSON result = new Typemedal_infoJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypemedal_infoAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(Typemedal_infoJSON result)
                  {
                    if (fieldGeneratorcountry.have_value)
                      {
                        result.setcountry(fieldGeneratorcountry.value);
                        fieldGeneratorcountry.have_value = false;
                      }
                    if (fieldGeneratorcountry_code.have_value)
                      {
                        result.setcountry_code(fieldGeneratorcountry_code.value);
                        fieldGeneratorcountry_code.have_value = false;
                      }
                    if (fieldGeneratorioc_code.have_value)
                      {
                        result.setioc_code(fieldGeneratorioc_code.value);
                        fieldGeneratorioc_code.have_value = false;
                      }
                    if (fieldGeneratortotal_ranking.have_value)
                      {
                        result.settotal_ranking(fieldGeneratortotal_ranking.value);
                        fieldGeneratortotal_ranking.have_value = false;
                      }
                    if (fieldGeneratorgold_ranking.have_value)
                      {
                        result.setgold_ranking(fieldGeneratorgold_ranking.value);
                        fieldGeneratorgold_ranking.have_value = false;
                      }
                    if (fieldGeneratortotal.have_value)
                      {
                        result.settotal(fieldGeneratortotal.value);
                        fieldGeneratortotal.have_value = false;
                      }
                    if (fieldGeneratorgold.have_value)
                      {
                        result.setgold(fieldGeneratorgold.value);
                        fieldGeneratorgold.have_value = false;
                      }
                    if (fieldGeneratorsilver.have_value)
                      {
                        result.setsilver(fieldGeneratorsilver.value);
                        fieldGeneratorsilver.have_value = false;
                      }
                    if (fieldGeneratorbronze.have_value)
                      {
                        result.setbronze(fieldGeneratorbronze.value);
                        fieldGeneratorbronze.have_value = false;
                      }
                  }
                protected abstract void handle_result(Typemedal_infoJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    switch (field_name[0])
                      {
                        case 'b':
                            if ((String.Compare(field_name, 1, "ronze", 0, 5, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorbronze;
                            break;
                        case 'c':
                            if (String.Compare(field_name, 1, "ountry", 0, 6, false) == 0)
                              {
                                if (field_name.Length == 7)
                                  {
                                    return fieldGeneratorcountry;
                                  }
                                switch (field_name[7])
                                  {
                                    case '_':
                                        if ((String.Compare(field_name, 8, "code", 0, 4, false) == 0) && (field_name.Length == 12))
                                            return fieldGeneratorcountry_code;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'g':
                            if (String.Compare(field_name, 1, "old", 0, 3, false) == 0)
                              {
                                if (field_name.Length == 4)
                                  {
                                    return fieldGeneratorgold;
                                  }
                                switch (field_name[4])
                                  {
                                    case '_':
                                        if ((String.Compare(field_name, 5, "ranking", 0, 7, false) == 0) && (field_name.Length == 12))
                                            return fieldGeneratorgold_ranking;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 1, "oc_code", 0, 7, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorioc_code;
                            break;
                        case 's':
                            if ((String.Compare(field_name, 1, "ilver", 0, 5, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorsilver;
                            break;
                        case 't':
                            if (String.Compare(field_name, 1, "otal", 0, 4, false) == 0)
                              {
                                if (field_name.Length == 5)
                                  {
                                    return fieldGeneratortotal;
                                  }
                                switch (field_name[5])
                                  {
                                    case '_':
                                        if ((String.Compare(field_name, 6, "ranking", 0, 7, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratortotal_ranking;
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
                    fieldGeneratorcountry = new JSONHoldingStringGenerator("field \"country\" of the Typemedal_info class");
                    fieldGeneratorcountry_code = new JSONHoldingStringGenerator("field \"country_code\" of the Typemedal_info class");
                    fieldGeneratorioc_code = new JSONHoldingStringGenerator("field \"ioc_code\" of the Typemedal_info class");
                    fieldGeneratortotal_ranking = new FieldHoldingGeneratortotal_ranking("field \"total_ranking\" of the Typemedal_info class");
                    fieldGeneratorgold_ranking = new FieldHoldingGeneratorgold_ranking("field \"gold_ranking\" of the Typemedal_info class");
                    fieldGeneratortotal = new FieldHoldingGeneratortotal("field \"total\" of the Typemedal_info class");
                    fieldGeneratorgold = new FieldHoldingGeneratorgold("field \"gold\" of the Typemedal_info class");
                    fieldGeneratorsilver = new FieldHoldingGeneratorsilver("field \"silver\" of the Typemedal_info class");
                    fieldGeneratorbronze = new FieldHoldingGeneratorbronze("field \"bronze\" of the Typemedal_info class");
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the Typemedal_info class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorcountry = new JSONHoldingStringGenerator("field \"country\" of the Typemedal_info class");
                    fieldGeneratorcountry_code = new JSONHoldingStringGenerator("field \"country_code\" of the Typemedal_info class");
                    fieldGeneratorioc_code = new JSONHoldingStringGenerator("field \"ioc_code\" of the Typemedal_info class");
                    fieldGeneratortotal_ranking = new FieldHoldingGeneratortotal_ranking("field \"total_ranking\" of the Typemedal_info class");
                    fieldGeneratorgold_ranking = new FieldHoldingGeneratorgold_ranking("field \"gold_ranking\" of the Typemedal_info class");
                    fieldGeneratortotal = new FieldHoldingGeneratortotal("field \"total\" of the Typemedal_info class");
                    fieldGeneratorgold = new FieldHoldingGeneratorgold("field \"gold\" of the Typemedal_info class");
                    fieldGeneratorsilver = new FieldHoldingGeneratorsilver("field \"silver\" of the Typemedal_info class");
                    fieldGeneratorbronze = new FieldHoldingGeneratorbronze("field \"bronze\" of the Typemedal_info class");
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the Typemedal_info class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorcountry.reset();
                    fieldGeneratorcountry_code.reset();
                    fieldGeneratorioc_code.reset();
                    fieldGeneratortotal_ranking.reset();
                    fieldGeneratorgold_ranking.reset();
                    fieldGeneratortotal.reset();
                    fieldGeneratorgold.reset();
                    fieldGeneratorsilver.reset();
                    fieldGeneratorbronze.reset();
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
                protected override void handle_result(Typemedal_infoJSON  result)
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
                public Typemedal_infoJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(Typemedal_infoJSON  result)
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
            protected virtual void handle_result(List<Typemedal_infoJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<Typemedal_infoJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<Typemedal_infoJSON>();
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
            public List<Typemedal_infoJSON> value;
          };
          };
        private bool flagHasmedal_info;
        private Typemedal_infoJSON  storemedal_info;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONmedal_info(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            Typemedal_infoJSON convert_classy = Typemedal_infoJSON.from_json(json_value, ignore_extras, true);
            setmedal_info(convert_classy);
          }


        public Typemedals_by_countryJSON()
          {
            flagHasmedal_info = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasmedal_info()
          {
            return flagHasmedal_info;
          }

        public Typemedal_infoJSON   getmedal_info()
          {
            Debug.Assert(flagHasmedal_info);
            return storemedal_info;
          }


        public virtual int extraTypemedals_by_countryComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypemedals_by_countryComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypemedals_by_countryComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypemedals_by_countryLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setmedal_info(Typemedal_infoJSON  new_value)
          {
            if (flagHasmedal_info)
              {
              }
            flagHasmedal_info = true;
            storemedal_info = new_value;
          }
        public void unsetmedal_info()
          {
            if (flagHasmedal_info)
              {
              }
            flagHasmedal_info = false;
          }

        public virtual void extraTypemedals_by_countryAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypemedals_by_countrySetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypemedals_by_countryLookup(key);
            if (old_field == null)
              {
                extraTypemedals_by_countryAppendPair(key, new_component);
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
            if (flagHasmedal_info)
              {
                handler.start_pair("medal_info");
                if (partial_allowed)
                    storemedal_info.write_partial_as_json(handler);
                else
                    storemedal_info.write_as_json(handler);
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

        public static Typemedals_by_countryJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            Typemedals_by_countryJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typemedals_by_country", ignore_extras);
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
        public static Typemedals_by_countryJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static Typemedals_by_countryJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            Typemedals_by_countryJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typemedals_by_country", ignore_extras);
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
        public static Typemedals_by_countryJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static Typemedals_by_countryJSON from_text(string text, bool ignore_extras)
          {
            Typemedals_by_countryJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typemedals_by_country", ignore_extras);
                JSONParse.parse_json_value(text, "Text for Typemedals_by_countryJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static Typemedals_by_countryJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            Typemedals_by_countryJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typemedals_by_country", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private Typemedal_infoJSON.HoldingGenerator fieldGeneratormedal_info;
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
                Typemedals_by_countryJSON result = new Typemedals_by_countryJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypemedals_by_countryAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(Typemedals_by_countryJSON result)
              {
                if (fieldGeneratormedal_info.have_value)
                  {
                    result.setmedal_info(fieldGeneratormedal_info.value);
                    fieldGeneratormedal_info.have_value = false;
                  }
              }
            protected abstract void handle_result(Typemedals_by_countryJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "medal_info", 0, 10, false) == 0) && (field_name.Length == 10))
                    return fieldGeneratormedal_info;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratormedal_info = new Typemedal_infoJSON.HoldingGenerator("field \"medal_info\" of the Typemedals_by_country class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the Typemedals_by_country class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratormedal_info = new Typemedal_infoJSON.HoldingGenerator("field \"medal_info\" of the Typemedals_by_country class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the Typemedals_by_country class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratormedal_info.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratormedal_info.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratormedal_info.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(Typemedals_by_countryJSON  result)
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
            public Typemedals_by_countryJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(Typemedals_by_countryJSON  result)
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
        protected virtual void handle_result(List<Typemedals_by_countryJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<Typemedals_by_countryJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<Typemedals_by_countryJSON>();
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
        public List<Typemedals_by_countryJSON> value;
      };
      };
    private bool flagHasmedals_by_country;
    private List< Typemedals_by_countryJSON  > storemedals_by_country;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONmedals_by_country(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field medals_by_country of SportsOlympicsAPIMedalStandingsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< Typemedals_by_countryJSON  > vector_medals_by_country1 = new List< Typemedals_by_countryJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            Typemedals_by_countryJSON convert_classy = Typemedals_by_countryJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_medals_by_country1.Add(convert_classy);
          }
        initmedals_by_country();
        for (int num1 = 0; num1 < vector_medals_by_country1.Count; ++num1)
            appendmedals_by_country(vector_medals_by_country1[num1]);
        for (int num1 = 0; num1 < vector_medals_by_country1.Count; ++num1)
          {
          }
      }


    public SportsOlympicsAPIMedalStandingsJSON()
      {
        flagHasmedals_by_country = false;
        storemedals_by_country = new List< Typemedals_by_countryJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasmedals_by_country()
      {
        return flagHasmedals_by_country;
      }

    public int  countOfmedals_by_country()
      {
        Debug.Assert(flagHasmedals_by_country);
        return storemedals_by_country.Count;
      }

    public Typemedals_by_countryJSON   elementOfmedals_by_country(int element_num)
      {
        Debug.Assert(flagHasmedals_by_country);
        return storemedals_by_country[element_num];
      }

    public List< Typemedals_by_countryJSON  >  getmedals_by_country()
      {
        Debug.Assert(flagHasmedals_by_country);
        return storemedals_by_country;
      }


    public virtual int extraSportsOlympicsAPIMedalStandingsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsOlympicsAPIMedalStandingsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsOlympicsAPIMedalStandingsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsOlympicsAPIMedalStandingsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initmedals_by_country()
      {
        if (flagHasmedals_by_country)
          {
            for (int num1 = 0; num1 < storemedals_by_country.Count; ++num1)
              {
              }
          }
        flagHasmedals_by_country = true;
        storemedals_by_country.Clear();
      }
    public void appendmedals_by_country(Typemedals_by_countryJSON  to_append)
      {
        if (!flagHasmedals_by_country)
          {
            flagHasmedals_by_country = true;
            storemedals_by_country.Clear();
          }
        Debug.Assert(flagHasmedals_by_country);
        storemedals_by_country.Add(to_append);
      }
    public void unsetmedals_by_country()
      {
        if (flagHasmedals_by_country)
          {
            for (int num2 = 0; num2 < storemedals_by_country.Count; ++num2)
              {
              }
          }
        flagHasmedals_by_country = false;
        storemedals_by_country.Clear();
      }

    public virtual void extraSportsOlympicsAPIMedalStandingsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsOlympicsAPIMedalStandingsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsOlympicsAPIMedalStandingsLookup(key);
        if (old_field == null)
          {
            extraSportsOlympicsAPIMedalStandingsAppendPair(key, new_component);
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
        if (flagHasmedals_by_country)
          {
            handler.start_pair("medals_by_country");
            handler.start_array();
            for (int num1 = 0; num1 < storemedals_by_country.Count; ++num1)
              {
                if (partial_allowed)
                    storemedals_by_country[num1].write_partial_as_json(handler);
                else
                    storemedals_by_country[num1].write_as_json(handler);
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
        return null;
      }

    public static SportsOlympicsAPIMedalStandingsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsAPIMedalStandingsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsAPIMedalStandings", ignore_extras);
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
    public static SportsOlympicsAPIMedalStandingsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsAPIMedalStandingsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsAPIMedalStandingsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsAPIMedalStandings", ignore_extras);
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
    public static SportsOlympicsAPIMedalStandingsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsAPIMedalStandingsJSON from_text(string text, bool ignore_extras)
      {
        SportsOlympicsAPIMedalStandingsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsAPIMedalStandings", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsOlympicsAPIMedalStandingsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsOlympicsAPIMedalStandingsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsOlympicsAPIMedalStandingsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsAPIMedalStandings", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private Typemedals_by_countryJSON.HoldingArrayGenerator fieldGeneratormedals_by_country;
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
            SportsOlympicsAPIMedalStandingsJSON result = new SportsOlympicsAPIMedalStandingsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsOlympicsAPIMedalStandingsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsOlympicsAPIMedalStandingsJSON result)
          {
            if (fieldGeneratormedals_by_country.have_value)
              {
                result.initmedals_by_country();
                int count = fieldGeneratormedals_by_country.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendmedals_by_country(fieldGeneratormedals_by_country.value[num]);
                  }
                fieldGeneratormedals_by_country.value.Clear();
                fieldGeneratormedals_by_country.have_value = false;
              }
          }
        protected abstract void handle_result(SportsOlympicsAPIMedalStandingsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "medals_by_country", 0, 17, false) == 0) && (field_name.Length == 17))
                return fieldGeneratormedals_by_country;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratormedals_by_country = new Typemedals_by_countryJSON.HoldingArrayGenerator("field \"medals_by_country\" of the SportsOlympicsAPIMedalStandings class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsOlympicsAPIMedalStandings class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratormedals_by_country = new Typemedals_by_countryJSON.HoldingArrayGenerator("field \"medals_by_country\" of the SportsOlympicsAPIMedalStandings class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsOlympicsAPIMedalStandings class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratormedals_by_country.reset();
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
        protected override void handle_result(SportsOlympicsAPIMedalStandingsJSON  result)
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
        public SportsOlympicsAPIMedalStandingsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsOlympicsAPIMedalStandingsJSON  result)
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
    protected virtual void handle_result(List<SportsOlympicsAPIMedalStandingsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsOlympicsAPIMedalStandingsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsOlympicsAPIMedalStandingsJSON>();
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
    public List<SportsOlympicsAPIMedalStandingsJSON> value;
  };
  };
