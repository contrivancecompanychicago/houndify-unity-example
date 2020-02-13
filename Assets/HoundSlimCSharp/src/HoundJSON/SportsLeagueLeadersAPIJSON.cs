/* file "SportsLeagueLeadersAPIJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SportsLeagueLeadersAPIJSON : JSONBase
  {
    public class TypeValueJSON : JSONBase
      {
        public enum TypeQualifierKnownValues
          {
            Qualifier_Goaltending,
            Qualifier_Offense,
            Qualifier__none
          };
        public struct TypeQualifier
          {
            public bool in_known_list;
            public string string_value;
            public TypeQualifierKnownValues list_value;
          };

        public static TypeQualifierKnownValues  stringToQualifier(string chars)
          {
            switch (chars[0])
              {
                case 'G':
                    if ((String.Compare(chars, 1, "oaltending", 0, 10, false) == 0) && (chars.Length == 11))
                        return TypeQualifierKnownValues.Qualifier_Goaltending;
                    break;
                case 'O':
                    if ((String.Compare(chars, 1, "ffense", 0, 6, false) == 0) && (chars.Length == 7))
                        return TypeQualifierKnownValues.Qualifier_Offense;
                    break;
                default:
                    break;
              }
            return TypeQualifierKnownValues.Qualifier__none;
          }

        public static string  stringFromQualifier(TypeQualifierKnownValues the_enum)
          {
            switch (the_enum)
              {
                case TypeQualifierKnownValues.Qualifier_Goaltending:
                    return "Goaltending";
                case TypeQualifierKnownValues.Qualifier_Offense:
                    return "Offense";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        public class TypeStatsJSON : JSONBase
          {
            public class TypeTeamsJSON : JSONBase
              {
                private bool flagHasTeamName;
                private string storeTeamName;
                private bool flagHasAlias;
                private string storeAlias;
                private bool flagHasID;
                private string storeID;
                private bool flagHasRank;
                private BigInteger storeRank;
                private bool flagHasValue;
                private double storeValue;
                private string textStoreValue;
                private List<string> extraKeys;
                private List<JSONValue > extraValues;
                private Dictionary<string, JSONValue > extraIndex;


                private void  fromJSONTeamName(JSONValue json_value, bool ignore_extras)
                  {
                    Debug.Assert(json_value != null);
                    JSONStringValue json_string = json_value.string_value();
                    if (json_string == null)
                        throw new Exception("The value for field TeamName of TypeTeamsJSON is not a string.");
                    setTeamName(json_string.getData());
                  }


                private void  fromJSONAlias(JSONValue json_value, bool ignore_extras)
                  {
                    Debug.Assert(json_value != null);
                    JSONStringValue json_string = json_value.string_value();
                    if (json_string == null)
                        throw new Exception("The value for field Alias of TypeTeamsJSON is not a string.");
                    setAlias(json_string.getData());
                  }


                private void  fromJSONID(JSONValue json_value, bool ignore_extras)
                  {
                    Debug.Assert(json_value != null);
                    JSONStringValue json_string = json_value.string_value();
                    if (json_string == null)
                        throw new Exception("The value for field ID of TypeTeamsJSON is not a string.");
                    setID(json_string.getData());
                  }


                private void  fromJSONRank(JSONValue json_value, bool ignore_extras)
                  {
                    Debug.Assert(json_value != null);
                    BigInteger extracted_integer;
                    JSONIntegerValue json_integer = json_value.integer_value();
                    if (json_integer == null)
                      {
                        JSONRationalValue json_rational = json_value.rational_value();
                        if (json_rational == null)
                          {
                            throw new Exception("The value for field Rank of TypeTeamsJSON is not a number.");
                          }
                        if (!(json_rational.isInteger()))
                          {
                            throw new Exception("The value for field Rank of TypeTeamsJSON is not an integer.");
                          }
                        extracted_integer = json_rational.getInteger()                    ;
                      }
                    else
                      {
                        extracted_integer = json_integer.getData()                    ;
                      }
                    setRank(extracted_integer);
                  }


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
                            throw new Exception("The value for field Value of TypeTeamsJSON is not a number.");
                          }
                      }
                    setValueText(the_rational_text);
                  }


                public TypeTeamsJSON()
                  {
                    flagHasTeamName = false;
                    flagHasAlias = false;
                    flagHasID = false;
                    flagHasRank = false;
                    flagHasValue = false;
                    extraKeys = new List<string>();
                extraValues = new List<JSONValue >();
                extraIndex = new Dictionary<string, JSONValue >();
                  }

                public bool  hasTeamName()
                  {
                    return flagHasTeamName;
                  }

                public string  getTeamName()
                  {
                    Debug.Assert(flagHasTeamName);
                    return storeTeamName;
                  }

                public bool  hasAlias()
                  {
                    return flagHasAlias;
                  }

                public string  getAlias()
                  {
                    Debug.Assert(flagHasAlias);
                    return storeAlias;
                  }

                public bool  hasID()
                  {
                    return flagHasID;
                  }

                public string  getID()
                  {
                    Debug.Assert(flagHasID);
                    return storeID;
                  }

                public bool  hasRank()
                  {
                    return flagHasRank;
                  }

                public BigInteger  getRank()
                  {
                    Debug.Assert(flagHasRank);
                    return storeRank;
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


                public virtual int extraTypeTeamsComponentCount()
                  {
                    Debug.Assert(extraKeys.Count == extraValues.Count);
                    return extraKeys.Count;
                  }
                public virtual string extraTypeTeamsComponentKey(int component_num)
                  {
                    Debug.Assert(extraKeys.Count == extraValues.Count);
                    Debug.Assert(component_num < extraValues.Count);
                    return extraKeys[component_num];
                  }
                public virtual JSONValue extraTypeTeamsComponentValue(int component_num)
                  {
                    Debug.Assert(extraKeys.Count == extraValues.Count);
                    Debug.Assert(component_num < extraValues.Count);
                    return extraValues[component_num];
                  }
                public virtual JSONValue extraTypeTeamsLookup(string field_name)
                  {
                    JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                    return result;
                  }

                public void setTeamName(string new_value)
                  {
                    flagHasTeamName = true;
                    storeTeamName = new_value;
                  }
                public void unsetTeamName()
                  {
                    flagHasTeamName = false;
                  }
                public void setAlias(string new_value)
                  {
                    flagHasAlias = true;
                    storeAlias = new_value;
                  }
                public void unsetAlias()
                  {
                    flagHasAlias = false;
                  }
                public void setID(string new_value)
                  {
                    flagHasID = true;
                    storeID = new_value;
                  }
                public void unsetID()
                  {
                    flagHasID = false;
                  }
                public void setRank(BigInteger new_value)
                  {
                    flagHasRank = true;
                    if (new_value < 1)
                        throw new Exception("The value for field Rank of TypeTeamsJSON is less than the lower bound (1) for that field.");
                    storeRank = new_value;
                  }
                public void unsetRank()
                  {
                    flagHasRank = false;
                  }
                public void setValue(double new_value)
                  {
                    flagHasValue = true;
                    storeValue = new_value;
                    textStoreValue = "";
                  }
                public void setValueText(string new_value)
                  {
                    flagHasValue = true;
                    if (!(JSONWriter.is_valid_number_format(new_value)))
                        throw new Exception("The text value for field Value of TypeTeamsJSON is not a valid number.");
                    textStoreValue = new_value;
                  }
                public void unsetValue()
                  {
                    flagHasValue = false;
                  }

                public virtual void extraTypeTeamsAppendPair(string key, JSONValue new_component)
                  {
                    Debug.Assert(key != null);
                    Debug.Assert(new_component != null);

                    Debug.Assert(extraKeys.Count == extraValues.Count);
                    extraKeys.Add(key);
                    extraValues.Add(new_component);
                    extraIndex.Add(key, new_component);
                  }
                public virtual void extraTypeTeamsSetField(string key, JSONValue new_component)
                  {
                    Debug.Assert(key != null);
                    Debug.Assert(new_component != null);

                    JSONValue old_field = extraTypeTeamsLookup(key);
                    if (old_field == null)
                      {
                        extraTypeTeamsAppendPair(key, new_component);
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
                    Debug.Assert(partial_allowed || flagHasTeamName);
                    if (flagHasTeamName)
                      {
                        handler.start_pair("TeamName");
                        handler.string_value(storeTeamName);
                      }
                    Debug.Assert(partial_allowed || flagHasAlias);
                    if (flagHasAlias)
                      {
                        handler.start_pair("Alias");
                        handler.string_value(storeAlias);
                      }
                    Debug.Assert(partial_allowed || flagHasID);
                    if (flagHasID)
                      {
                        handler.start_pair("ID");
                        handler.string_value(storeID);
                      }
                    Debug.Assert(partial_allowed || flagHasRank);
                    if (flagHasRank)
                      {
                        handler.start_pair("Rank");
                        handler.number_value(storeRank);
                      }
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
                    if (!(hasTeamName()))
                      {
                        return "When parsing the object for %what%, the \"TeamName\" field was missing.";
                      }
                    if (!(hasAlias()))
                      {
                        return "When parsing the object for %what%, the \"Alias\" field was missing.";
                      }
                    if (!(hasID()))
                      {
                        return "When parsing the object for %what%, the \"ID\" field was missing.";
                      }
                    if (!(hasRank()))
                      {
                        return "When parsing the object for %what%, the \"Rank\" field was missing.";
                      }
                    return null;
                  }

                public static TypeTeamsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                  {
                    TypeTeamsJSON result;
                      {
                        HoldingGenerator generator = new HoldingGenerator("Type TypeTeams", ignore_extras);
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
                public static TypeTeamsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
              {
                return from_json(json_value, ignore_extras, allow_incomplete, false);
              }
                public static TypeTeamsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                  {
                    TypeTeamsJSON result;
                      {
                        HoldingGenerator generator = new HoldingGenerator("Type TypeTeams", ignore_extras);
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
                public static TypeTeamsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
              {
                return from_json(json_value, ignore_extras, allow_incomplete, false);
              }
                public static TypeTeamsJSON from_text(string text, bool ignore_extras)
                  {
                    TypeTeamsJSON result;
                      {
                        HoldingGenerator generator = new HoldingGenerator("Type TypeTeams", ignore_extras);
                        JSONParse.parse_json_value(text, "Text for TypeTeamsJSON", generator);
                        Debug.Assert(generator.have_value);
                        result = generator.value;
                      };
                    return result;
                  }
                public static TypeTeamsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
                  {
                    TypeTeamsJSON result;
                      {
                        HoldingGenerator generator = new HoldingGenerator("Type TypeTeams", ignore_extras);
                        JSONParse.parse_json_value(fp, file_name, generator);
                        Debug.Assert(generator.have_value);
                        result = generator.value;
                      };
                    return result;
                  }
                public abstract class Generator : JSONObjectGenerator
                  {
                    private JSONHoldingStringGenerator fieldGeneratorTeamName;
                    private JSONHoldingStringGenerator fieldGeneratorAlias;
                    private JSONHoldingStringGenerator fieldGeneratorID;
                private class FieldHoldingGeneratorRank : JSONHoldingIntegerLowerBoundOnlyGenerator
                      {
                        public FieldHoldingGeneratorRank(String what) : base(what, (BigInteger)(1))
                          {
                          }
                      };
                private class FieldHoldingArrayGeneratorRank : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
                      {
                        public FieldHoldingArrayGeneratorRank(String what) : base(what, (BigInteger)(1))
                          {
                          }
                      };
                    private FieldHoldingGeneratorRank fieldGeneratorRank;
                    private JSONHoldingNumberTextGenerator fieldGeneratorValue;
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
                        TypeTeamsJSON result = new TypeTeamsJSON();
                        Debug.Assert(result != null);
                        finish(result);
                        int extra_count = unknownFieldGenerator.field_names.Count;
                        Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                        for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                          {
                            result.extraTypeTeamsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                          }
                        unknownFieldGenerator.field_names.Clear();
                        unknownFieldGenerator.field_values.Clear();
                        unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                        handle_result(result);
                      }
                    protected void finish(TypeTeamsJSON result)
                      {
                        if (fieldGeneratorTeamName.have_value)
                          {
                            result.setTeamName(fieldGeneratorTeamName.value);
                            fieldGeneratorTeamName.have_value = false;
                          }
                        else if ((!(result.hasTeamName())) && !allow_incomplete)
                          {
                            error("When parsing the object for %what%, the \"TeamName\" field was missing.");
                          }
                        if (fieldGeneratorAlias.have_value)
                          {
                            result.setAlias(fieldGeneratorAlias.value);
                            fieldGeneratorAlias.have_value = false;
                          }
                        else if ((!(result.hasAlias())) && !allow_incomplete)
                          {
                            error("When parsing the object for %what%, the \"Alias\" field was missing.");
                          }
                        if (fieldGeneratorID.have_value)
                          {
                            result.setID(fieldGeneratorID.value);
                            fieldGeneratorID.have_value = false;
                          }
                        else if ((!(result.hasID())) && !allow_incomplete)
                          {
                            error("When parsing the object for %what%, the \"ID\" field was missing.");
                          }
                        if (fieldGeneratorRank.have_value)
                          {
                            result.setRank(fieldGeneratorRank.value);
                            fieldGeneratorRank.have_value = false;
                          }
                        else if ((!(result.hasRank())) && !allow_incomplete)
                          {
                            error("When parsing the object for %what%, the \"Rank\" field was missing.");
                          }
                        if (fieldGeneratorValue.have_value)
                          {
                            result.setValueText(fieldGeneratorValue.value);
                            fieldGeneratorValue.have_value = false;
                          }
                      }
                    protected abstract void handle_result(TypeTeamsJSON new_result);
                    protected virtual JSONHandler start_known_field(string field_name)
                      {
                        switch (field_name[0])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 1, "lias", 0, 4, false) == 0) && (field_name.Length == 5))
                                    return fieldGeneratorAlias;
                                break;
                            case 'I':
                                if ((String.Compare(field_name, 1, "D", 0, 1, false) == 0) && (field_name.Length == 2))
                                    return fieldGeneratorID;
                                break;
                            case 'R':
                                if ((String.Compare(field_name, 1, "ank", 0, 3, false) == 0) && (field_name.Length == 4))
                                    return fieldGeneratorRank;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 1, "eamName", 0, 7, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorTeamName;
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
                        fieldGeneratorTeamName = new JSONHoldingStringGenerator("field \"TeamName\" of the TypeTeams class");
                        fieldGeneratorAlias = new JSONHoldingStringGenerator("field \"Alias\" of the TypeTeams class");
                        fieldGeneratorID = new JSONHoldingStringGenerator("field \"ID\" of the TypeTeams class");
                        fieldGeneratorRank = new FieldHoldingGeneratorRank("field \"Rank\" of the TypeTeams class");
                        fieldGeneratorValue = new JSONHoldingNumberTextGenerator("field \"Value\" of the TypeTeams class");
                        unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                        set_what("the TypeTeams class");
                        allow_incomplete = false;
                        allow_unpolished = false;
                      }
                    public Generator()
                      {
                        fieldGeneratorTeamName = new JSONHoldingStringGenerator("field \"TeamName\" of the TypeTeams class");
                        fieldGeneratorAlias = new JSONHoldingStringGenerator("field \"Alias\" of the TypeTeams class");
                        fieldGeneratorID = new JSONHoldingStringGenerator("field \"ID\" of the TypeTeams class");
                        fieldGeneratorRank = new FieldHoldingGeneratorRank("field \"Rank\" of the TypeTeams class");
                        fieldGeneratorValue = new JSONHoldingNumberTextGenerator("field \"Value\" of the TypeTeams class");
                        unknownFieldGenerator = new UnknownFieldGenerator(false);
                        set_what("the TypeTeams class");
                        allow_incomplete = false;
                        allow_unpolished = false;
                      }

                    public override void reset()
                      {
                        fieldGeneratorTeamName.reset();
                        fieldGeneratorAlias.reset();
                        fieldGeneratorID.reset();
                        fieldGeneratorRank.reset();
                        fieldGeneratorValue.reset();
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
                    protected override void handle_result(TypeTeamsJSON  result)
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
                    public TypeTeamsJSON value;
                  };
                public class HoldingArrayGenerator : JSONArrayGenerator
              {
                protected class ElementHandler : Generator
                  {
                    private HoldingArrayGenerator top;

                    protected override void handle_result(TypeTeamsJSON  result)
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
                protected virtual void handle_result(List<TypeTeamsJSON> result)

                  {
                  }

                public HoldingArrayGenerator(string what, bool ignore_extras)
                  {
                    element_handler = new ElementHandler(this, ignore_extras);
                    have_value = false;
                    value = new List<TypeTeamsJSON>();
                    base.set_what(what);
                  }
                public HoldingArrayGenerator(bool ignore_extras)
                  {
                    element_handler = new ElementHandler(this, ignore_extras);
                    value = new List<TypeTeamsJSON>();
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
                public List<TypeTeamsJSON> value;
              };
              };
            public class TypePlayersJSON : JSONBase
              {
                private bool flagHasID;
                private string storeID;
                private bool flagHasLastName;
                private string storeLastName;
                private bool flagHasFullName;
                private string storeFullName;
                private bool flagHasRank;
                private BigInteger storeRank;
                private bool flagHasValue;
                private double storeValue;
                private string textStoreValue;
                private List<string> extraKeys;
                private List<JSONValue > extraValues;
                private Dictionary<string, JSONValue > extraIndex;


                private void  fromJSONID(JSONValue json_value, bool ignore_extras)
                  {
                    Debug.Assert(json_value != null);
                    JSONStringValue json_string = json_value.string_value();
                    if (json_string == null)
                        throw new Exception("The value for field ID of TypePlayersJSON is not a string.");
                    setID(json_string.getData());
                  }


                private void  fromJSONLastName(JSONValue json_value, bool ignore_extras)
                  {
                    Debug.Assert(json_value != null);
                    JSONStringValue json_string = json_value.string_value();
                    if (json_string == null)
                        throw new Exception("The value for field LastName of TypePlayersJSON is not a string.");
                    setLastName(json_string.getData());
                  }


                private void  fromJSONFullName(JSONValue json_value, bool ignore_extras)
                  {
                    Debug.Assert(json_value != null);
                    JSONStringValue json_string = json_value.string_value();
                    if (json_string == null)
                        throw new Exception("The value for field FullName of TypePlayersJSON is not a string.");
                    setFullName(json_string.getData());
                  }


                private void  fromJSONRank(JSONValue json_value, bool ignore_extras)
                  {
                    Debug.Assert(json_value != null);
                    BigInteger extracted_integer;
                    JSONIntegerValue json_integer = json_value.integer_value();
                    if (json_integer == null)
                      {
                        JSONRationalValue json_rational = json_value.rational_value();
                        if (json_rational == null)
                          {
                            throw new Exception("The value for field Rank of TypePlayersJSON is not a number.");
                          }
                        if (!(json_rational.isInteger()))
                          {
                            throw new Exception("The value for field Rank of TypePlayersJSON is not an integer.");
                          }
                        extracted_integer = json_rational.getInteger()                    ;
                      }
                    else
                      {
                        extracted_integer = json_integer.getData()                    ;
                      }
                    setRank(extracted_integer);
                  }


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
                            throw new Exception("The value for field Value of TypePlayersJSON is not a number.");
                          }
                      }
                    setValueText(the_rational_text);
                  }


                public TypePlayersJSON()
                  {
                    flagHasID = false;
                    flagHasLastName = false;
                    flagHasFullName = false;
                    flagHasRank = false;
                    flagHasValue = false;
                    extraKeys = new List<string>();
                extraValues = new List<JSONValue >();
                extraIndex = new Dictionary<string, JSONValue >();
                  }

                public bool  hasID()
                  {
                    return flagHasID;
                  }

                public string  getID()
                  {
                    Debug.Assert(flagHasID);
                    return storeID;
                  }

                public bool  hasLastName()
                  {
                    return flagHasLastName;
                  }

                public string  getLastName()
                  {
                    Debug.Assert(flagHasLastName);
                    return storeLastName;
                  }

                public bool  hasFullName()
                  {
                    return flagHasFullName;
                  }

                public string  getFullName()
                  {
                    Debug.Assert(flagHasFullName);
                    return storeFullName;
                  }

                public bool  hasRank()
                  {
                    return flagHasRank;
                  }

                public BigInteger  getRank()
                  {
                    Debug.Assert(flagHasRank);
                    return storeRank;
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


                public virtual int extraTypePlayersComponentCount()
                  {
                    Debug.Assert(extraKeys.Count == extraValues.Count);
                    return extraKeys.Count;
                  }
                public virtual string extraTypePlayersComponentKey(int component_num)
                  {
                    Debug.Assert(extraKeys.Count == extraValues.Count);
                    Debug.Assert(component_num < extraValues.Count);
                    return extraKeys[component_num];
                  }
                public virtual JSONValue extraTypePlayersComponentValue(int component_num)
                  {
                    Debug.Assert(extraKeys.Count == extraValues.Count);
                    Debug.Assert(component_num < extraValues.Count);
                    return extraValues[component_num];
                  }
                public virtual JSONValue extraTypePlayersLookup(string field_name)
                  {
                    JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                    return result;
                  }

                public void setID(string new_value)
                  {
                    flagHasID = true;
                    storeID = new_value;
                  }
                public void unsetID()
                  {
                    flagHasID = false;
                  }
                public void setLastName(string new_value)
                  {
                    flagHasLastName = true;
                    storeLastName = new_value;
                  }
                public void unsetLastName()
                  {
                    flagHasLastName = false;
                  }
                public void setFullName(string new_value)
                  {
                    flagHasFullName = true;
                    storeFullName = new_value;
                  }
                public void unsetFullName()
                  {
                    flagHasFullName = false;
                  }
                public void setRank(BigInteger new_value)
                  {
                    flagHasRank = true;
                    if (new_value < 1)
                        throw new Exception("The value for field Rank of TypePlayersJSON is less than the lower bound (1) for that field.");
                    storeRank = new_value;
                  }
                public void unsetRank()
                  {
                    flagHasRank = false;
                  }
                public void setValue(double new_value)
                  {
                    flagHasValue = true;
                    storeValue = new_value;
                    textStoreValue = "";
                  }
                public void setValueText(string new_value)
                  {
                    flagHasValue = true;
                    if (!(JSONWriter.is_valid_number_format(new_value)))
                        throw new Exception("The text value for field Value of TypePlayersJSON is not a valid number.");
                    textStoreValue = new_value;
                  }
                public void unsetValue()
                  {
                    flagHasValue = false;
                  }

                public virtual void extraTypePlayersAppendPair(string key, JSONValue new_component)
                  {
                    Debug.Assert(key != null);
                    Debug.Assert(new_component != null);

                    Debug.Assert(extraKeys.Count == extraValues.Count);
                    extraKeys.Add(key);
                    extraValues.Add(new_component);
                    extraIndex.Add(key, new_component);
                  }
                public virtual void extraTypePlayersSetField(string key, JSONValue new_component)
                  {
                    Debug.Assert(key != null);
                    Debug.Assert(new_component != null);

                    JSONValue old_field = extraTypePlayersLookup(key);
                    if (old_field == null)
                      {
                        extraTypePlayersAppendPair(key, new_component);
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
                    Debug.Assert(partial_allowed || flagHasID);
                    if (flagHasID)
                      {
                        handler.start_pair("ID");
                        handler.string_value(storeID);
                      }
                    Debug.Assert(partial_allowed || flagHasLastName);
                    if (flagHasLastName)
                      {
                        handler.start_pair("LastName");
                        handler.string_value(storeLastName);
                      }
                    Debug.Assert(partial_allowed || flagHasFullName);
                    if (flagHasFullName)
                      {
                        handler.start_pair("FullName");
                        handler.string_value(storeFullName);
                      }
                    Debug.Assert(partial_allowed || flagHasRank);
                    if (flagHasRank)
                      {
                        handler.start_pair("Rank");
                        handler.number_value(storeRank);
                      }
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
                    if (!(hasID()))
                      {
                        return "When parsing the object for %what%, the \"ID\" field was missing.";
                      }
                    if (!(hasLastName()))
                      {
                        return "When parsing the object for %what%, the \"LastName\" field was missing.";
                      }
                    if (!(hasFullName()))
                      {
                        return "When parsing the object for %what%, the \"FullName\" field was missing.";
                      }
                    if (!(hasRank()))
                      {
                        return "When parsing the object for %what%, the \"Rank\" field was missing.";
                      }
                    return null;
                  }

                public static TypePlayersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                  {
                    TypePlayersJSON result;
                      {
                        HoldingGenerator generator = new HoldingGenerator("Type TypePlayers", ignore_extras);
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
                public static TypePlayersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
              {
                return from_json(json_value, ignore_extras, allow_incomplete, false);
              }
                public static TypePlayersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                  {
                    TypePlayersJSON result;
                      {
                        HoldingGenerator generator = new HoldingGenerator("Type TypePlayers", ignore_extras);
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
                public static TypePlayersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
              {
                return from_json(json_value, ignore_extras, allow_incomplete, false);
              }
                public static TypePlayersJSON from_text(string text, bool ignore_extras)
                  {
                    TypePlayersJSON result;
                      {
                        HoldingGenerator generator = new HoldingGenerator("Type TypePlayers", ignore_extras);
                        JSONParse.parse_json_value(text, "Text for TypePlayersJSON", generator);
                        Debug.Assert(generator.have_value);
                        result = generator.value;
                      };
                    return result;
                  }
                public static TypePlayersJSON from_file(TextReader fp, string file_name, bool ignore_extras)
                  {
                    TypePlayersJSON result;
                      {
                        HoldingGenerator generator = new HoldingGenerator("Type TypePlayers", ignore_extras);
                        JSONParse.parse_json_value(fp, file_name, generator);
                        Debug.Assert(generator.have_value);
                        result = generator.value;
                      };
                    return result;
                  }
                public abstract class Generator : JSONObjectGenerator
                  {
                    private JSONHoldingStringGenerator fieldGeneratorID;
                    private JSONHoldingStringGenerator fieldGeneratorLastName;
                    private JSONHoldingStringGenerator fieldGeneratorFullName;
                private class FieldHoldingGeneratorRank : JSONHoldingIntegerLowerBoundOnlyGenerator
                      {
                        public FieldHoldingGeneratorRank(String what) : base(what, (BigInteger)(1))
                          {
                          }
                      };
                private class FieldHoldingArrayGeneratorRank : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
                      {
                        public FieldHoldingArrayGeneratorRank(String what) : base(what, (BigInteger)(1))
                          {
                          }
                      };
                    private FieldHoldingGeneratorRank fieldGeneratorRank;
                    private JSONHoldingNumberTextGenerator fieldGeneratorValue;
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
                        TypePlayersJSON result = new TypePlayersJSON();
                        Debug.Assert(result != null);
                        finish(result);
                        int extra_count = unknownFieldGenerator.field_names.Count;
                        Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                        for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                          {
                            result.extraTypePlayersAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                          }
                        unknownFieldGenerator.field_names.Clear();
                        unknownFieldGenerator.field_values.Clear();
                        unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                        handle_result(result);
                      }
                    protected void finish(TypePlayersJSON result)
                      {
                        if (fieldGeneratorID.have_value)
                          {
                            result.setID(fieldGeneratorID.value);
                            fieldGeneratorID.have_value = false;
                          }
                        else if ((!(result.hasID())) && !allow_incomplete)
                          {
                            error("When parsing the object for %what%, the \"ID\" field was missing.");
                          }
                        if (fieldGeneratorLastName.have_value)
                          {
                            result.setLastName(fieldGeneratorLastName.value);
                            fieldGeneratorLastName.have_value = false;
                          }
                        else if ((!(result.hasLastName())) && !allow_incomplete)
                          {
                            error("When parsing the object for %what%, the \"LastName\" field was missing.");
                          }
                        if (fieldGeneratorFullName.have_value)
                          {
                            result.setFullName(fieldGeneratorFullName.value);
                            fieldGeneratorFullName.have_value = false;
                          }
                        else if ((!(result.hasFullName())) && !allow_incomplete)
                          {
                            error("When parsing the object for %what%, the \"FullName\" field was missing.");
                          }
                        if (fieldGeneratorRank.have_value)
                          {
                            result.setRank(fieldGeneratorRank.value);
                            fieldGeneratorRank.have_value = false;
                          }
                        else if ((!(result.hasRank())) && !allow_incomplete)
                          {
                            error("When parsing the object for %what%, the \"Rank\" field was missing.");
                          }
                        if (fieldGeneratorValue.have_value)
                          {
                            result.setValueText(fieldGeneratorValue.value);
                            fieldGeneratorValue.have_value = false;
                          }
                      }
                    protected abstract void handle_result(TypePlayersJSON new_result);
                    protected virtual JSONHandler start_known_field(string field_name)
                      {
                        switch (field_name[0])
                          {
                            case 'F':
                                if ((String.Compare(field_name, 1, "ullName", 0, 7, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorFullName;
                                break;
                            case 'I':
                                if ((String.Compare(field_name, 1, "D", 0, 1, false) == 0) && (field_name.Length == 2))
                                    return fieldGeneratorID;
                                break;
                            case 'L':
                                if ((String.Compare(field_name, 1, "astName", 0, 7, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorLastName;
                                break;
                            case 'R':
                                if ((String.Compare(field_name, 1, "ank", 0, 3, false) == 0) && (field_name.Length == 4))
                                    return fieldGeneratorRank;
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
                        fieldGeneratorID = new JSONHoldingStringGenerator("field \"ID\" of the TypePlayers class");
                        fieldGeneratorLastName = new JSONHoldingStringGenerator("field \"LastName\" of the TypePlayers class");
                        fieldGeneratorFullName = new JSONHoldingStringGenerator("field \"FullName\" of the TypePlayers class");
                        fieldGeneratorRank = new FieldHoldingGeneratorRank("field \"Rank\" of the TypePlayers class");
                        fieldGeneratorValue = new JSONHoldingNumberTextGenerator("field \"Value\" of the TypePlayers class");
                        unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                        set_what("the TypePlayers class");
                        allow_incomplete = false;
                        allow_unpolished = false;
                      }
                    public Generator()
                      {
                        fieldGeneratorID = new JSONHoldingStringGenerator("field \"ID\" of the TypePlayers class");
                        fieldGeneratorLastName = new JSONHoldingStringGenerator("field \"LastName\" of the TypePlayers class");
                        fieldGeneratorFullName = new JSONHoldingStringGenerator("field \"FullName\" of the TypePlayers class");
                        fieldGeneratorRank = new FieldHoldingGeneratorRank("field \"Rank\" of the TypePlayers class");
                        fieldGeneratorValue = new JSONHoldingNumberTextGenerator("field \"Value\" of the TypePlayers class");
                        unknownFieldGenerator = new UnknownFieldGenerator(false);
                        set_what("the TypePlayers class");
                        allow_incomplete = false;
                        allow_unpolished = false;
                      }

                    public override void reset()
                      {
                        fieldGeneratorID.reset();
                        fieldGeneratorLastName.reset();
                        fieldGeneratorFullName.reset();
                        fieldGeneratorRank.reset();
                        fieldGeneratorValue.reset();
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
                    protected override void handle_result(TypePlayersJSON  result)
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
                    public TypePlayersJSON value;
                  };
                public class HoldingArrayGenerator : JSONArrayGenerator
              {
                protected class ElementHandler : Generator
                  {
                    private HoldingArrayGenerator top;

                    protected override void handle_result(TypePlayersJSON  result)
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
                protected virtual void handle_result(List<TypePlayersJSON> result)

                  {
                  }

                public HoldingArrayGenerator(string what, bool ignore_extras)
                  {
                    element_handler = new ElementHandler(this, ignore_extras);
                    have_value = false;
                    value = new List<TypePlayersJSON>();
                    base.set_what(what);
                  }
                public HoldingArrayGenerator(bool ignore_extras)
                  {
                    element_handler = new ElementHandler(this, ignore_extras);
                    value = new List<TypePlayersJSON>();
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
                public List<TypePlayersJSON> value;
              };
              };
            private bool flagHasStatType;
            private SportsStatsTypeJSON  storeStatType;
            private bool flagHasTeams;
            private List< TypeTeamsJSON  > storeTeams;
            private bool flagHasPlayers;
            private List< TypePlayersJSON  > storePlayers;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONStatType(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                SportsStatsTypeJSON convert_classy = SportsStatsTypeJSON.from_json(json_value, ignore_extras, true);
                setStatType(convert_classy);
              }


            private void  fromJSONTeams(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONArrayValue json_array1 = json_value.array_value();
                if (json_array1 == null)
                    throw new Exception("The value for field Teams of TypeStatsJSON is not an array.");
                int count1 = json_array1.componentCount();
                List< TypeTeamsJSON  > vector_Teams1 = new List< TypeTeamsJSON  >(count1);
                for (int num1 = 0; num1 < count1; ++num1)
                  {
                    TypeTeamsJSON convert_classy = TypeTeamsJSON.from_json(json_array1.component(num1), ignore_extras, true);
                    vector_Teams1.Add(convert_classy);
                  }
                initTeams();
                for (int num1 = 0; num1 < vector_Teams1.Count; ++num1)
                    appendTeams(vector_Teams1[num1]);
                for (int num1 = 0; num1 < vector_Teams1.Count; ++num1)
                  {
                  }
              }


            private void  fromJSONPlayers(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONArrayValue json_array1 = json_value.array_value();
                if (json_array1 == null)
                    throw new Exception("The value for field Players of TypeStatsJSON is not an array.");
                int count1 = json_array1.componentCount();
                List< TypePlayersJSON  > vector_Players1 = new List< TypePlayersJSON  >(count1);
                for (int num1 = 0; num1 < count1; ++num1)
                  {
                    TypePlayersJSON convert_classy = TypePlayersJSON.from_json(json_array1.component(num1), ignore_extras, true);
                    vector_Players1.Add(convert_classy);
                  }
                initPlayers();
                for (int num2 = 0; num2 < vector_Players1.Count; ++num2)
                    appendPlayers(vector_Players1[num2]);
                for (int num1 = 0; num1 < vector_Players1.Count; ++num1)
                  {
                  }
              }


            public TypeStatsJSON()
              {
                flagHasStatType = false;
                flagHasTeams = false;
                flagHasPlayers = false;
                storeTeams = new List< TypeTeamsJSON  >();
                storePlayers = new List< TypePlayersJSON  >();
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasStatType()
              {
                return flagHasStatType;
              }

            public SportsStatsTypeJSON   getStatType()
              {
                Debug.Assert(flagHasStatType);
                return storeStatType;
              }

            public SportsStatsTypeJSON.TypeValue  getStatTypeValue()
              {
                return getStatType().getValue();
              }

            public string  getStatTypeAsString()
              {
                return getStatType().getValueAsString();
              }

            public bool  hasTeams()
              {
                return flagHasTeams;
              }

            public int  countOfTeams()
              {
                Debug.Assert(flagHasTeams);
                return storeTeams.Count;
              }

            public TypeTeamsJSON   elementOfTeams(int element_num)
              {
                Debug.Assert(flagHasTeams);
                return storeTeams[element_num];
              }

            public List< TypeTeamsJSON  >  getTeams()
              {
                Debug.Assert(flagHasTeams);
                return storeTeams;
              }

            public bool  hasPlayers()
              {
                return flagHasPlayers;
              }

            public int  countOfPlayers()
              {
                Debug.Assert(flagHasPlayers);
                return storePlayers.Count;
              }

            public TypePlayersJSON   elementOfPlayers(int element_num)
              {
                Debug.Assert(flagHasPlayers);
                return storePlayers[element_num];
              }

            public List< TypePlayersJSON  >  getPlayers()
              {
                Debug.Assert(flagHasPlayers);
                return storePlayers;
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

            public void setStatType(SportsStatsTypeJSON  new_value)
              {
                if (flagHasStatType)
                  {
                  }
                flagHasStatType = true;
                storeStatType = new_value;
              }
            public void setStatType(SportsStatsTypeJSON.TypeValue new_value)
              {
                setStatType(new SportsStatsTypeJSON(new_value));
              }
            public void setStatType(string chars)
              {
                SportsStatsTypeJSON.TypeValueKnownValues known = SportsStatsTypeJSON.stringToValue(chars);
                SportsStatsTypeJSON.TypeValue new_value = new SportsStatsTypeJSON.TypeValue();
                if (known == SportsStatsTypeJSON.TypeValueKnownValues.Value__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = chars;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                setStatType(new_value);
              }
            public void unsetStatType()
              {
                if (flagHasStatType)
                  {
                  }
                flagHasStatType = false;
              }
            public void initTeams()
              {
                if (flagHasTeams)
                  {
                    for (int num1 = 0; num1 < storeTeams.Count; ++num1)
                      {
                      }
                  }
                flagHasTeams = true;
                storeTeams.Clear();
              }
            public void appendTeams(TypeTeamsJSON  to_append)
              {
                if (!flagHasTeams)
                  {
                    flagHasTeams = true;
                    storeTeams.Clear();
                  }
                Debug.Assert(flagHasTeams);
                storeTeams.Add(to_append);
              }
            public void unsetTeams()
              {
                if (flagHasTeams)
                  {
                    for (int num2 = 0; num2 < storeTeams.Count; ++num2)
                      {
                      }
                  }
                flagHasTeams = false;
                storeTeams.Clear();
              }
            public void initPlayers()
              {
                if (flagHasPlayers)
                  {
                    for (int num3 = 0; num3 < storePlayers.Count; ++num3)
                      {
                      }
                  }
                flagHasPlayers = true;
                storePlayers.Clear();
              }
            public void appendPlayers(TypePlayersJSON  to_append)
              {
                if (!flagHasPlayers)
                  {
                    flagHasPlayers = true;
                    storePlayers.Clear();
                  }
                Debug.Assert(flagHasPlayers);
                storePlayers.Add(to_append);
              }
            public void unsetPlayers()
              {
                if (flagHasPlayers)
                  {
                    for (int num4 = 0; num4 < storePlayers.Count; ++num4)
                      {
                      }
                  }
                flagHasPlayers = false;
                storePlayers.Clear();
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
                Debug.Assert(partial_allowed || flagHasStatType);
                if (flagHasStatType)
                  {
                    handler.start_pair("StatType");
                    if (partial_allowed)
                        storeStatType.write_partial_as_json(handler);
                    else
                        storeStatType.write_as_json(handler);
                  }
                if (flagHasTeams)
                  {
                    handler.start_pair("Teams");
                    handler.start_array();
                    for (int num1 = 0; num1 < storeTeams.Count; ++num1)
                      {
                        if (partial_allowed)
                            storeTeams[num1].write_partial_as_json(handler);
                        else
                            storeTeams[num1].write_as_json(handler);
                      }
                    handler.finish_array();
                  }
                if (flagHasPlayers)
                  {
                    handler.start_pair("Players");
                    handler.start_array();
                    for (int num2 = 0; num2 < storePlayers.Count; ++num2)
                      {
                        if (partial_allowed)
                            storePlayers[num2].write_partial_as_json(handler);
                        else
                            storePlayers[num2].write_as_json(handler);
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
                if (!(hasStatType()))
                  {
                    return "When parsing the object for %what%, the \"StatType\" field was missing.";
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
                private SportsStatsTypeJSON.HoldingGenerator fieldGeneratorStatType;
                private TypeTeamsJSON.HoldingArrayGenerator fieldGeneratorTeams;
                private TypePlayersJSON.HoldingArrayGenerator fieldGeneratorPlayers;
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
                    if (fieldGeneratorStatType.have_value)
                      {
                        result.setStatType(fieldGeneratorStatType.value);
                        fieldGeneratorStatType.have_value = false;
                      }
                    else if ((!(result.hasStatType())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"StatType\" field was missing.");
                      }
                    if (fieldGeneratorTeams.have_value)
                      {
                        result.initTeams();
                        int count = fieldGeneratorTeams.value.Count;
                        for (int num = 0; num < count; ++num)
                          {
                            result.appendTeams(fieldGeneratorTeams.value[num]);
                          }
                        fieldGeneratorTeams.value.Clear();
                        fieldGeneratorTeams.have_value = false;
                      }
                    if (fieldGeneratorPlayers.have_value)
                      {
                        result.initPlayers();
                        int count = fieldGeneratorPlayers.value.Count;
                        for (int num = 0; num < count; ++num)
                          {
                            result.appendPlayers(fieldGeneratorPlayers.value[num]);
                          }
                        fieldGeneratorPlayers.value.Clear();
                        fieldGeneratorPlayers.have_value = false;
                      }
                  }
                protected abstract void handle_result(TypeStatsJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    switch (field_name[0])
                      {
                        case 'P':
                            if ((String.Compare(field_name, 1, "layers", 0, 6, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorPlayers;
                            break;
                        case 'S':
                            if ((String.Compare(field_name, 1, "tatType", 0, 7, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorStatType;
                            break;
                        case 'T':
                            if ((String.Compare(field_name, 1, "eams", 0, 4, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorTeams;
                            break;
                        default:
                            break;
                      }
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorStatType = new SportsStatsTypeJSON.HoldingGenerator("field \"StatType\" of the TypeStats class", ignore_extras);
                    fieldGeneratorTeams = new TypeTeamsJSON.HoldingArrayGenerator("field \"Teams\" of the TypeStats class", ignore_extras);
                    fieldGeneratorPlayers = new TypePlayersJSON.HoldingArrayGenerator("field \"Players\" of the TypeStats class", ignore_extras);
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypeStats class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorStatType = new SportsStatsTypeJSON.HoldingGenerator("field \"StatType\" of the TypeStats class", false);
                    fieldGeneratorTeams = new TypeTeamsJSON.HoldingArrayGenerator("field \"Teams\" of the TypeStats class", false);
                    fieldGeneratorPlayers = new TypePlayersJSON.HoldingArrayGenerator("field \"Players\" of the TypeStats class", false);
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypeStats class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorStatType.reset();
                    fieldGeneratorTeams.reset();
                    fieldGeneratorPlayers.reset();
                    base.reset();
                    unknownFieldGenerator.reset();
                  }
                public void set_allow_incomplete(bool new_allow_incomplete)
                  {
                    allow_incomplete = new_allow_incomplete;
                    fieldGeneratorStatType.set_allow_incomplete(new_allow_incomplete);
                  }
                public void set_allow_unpolished(bool new_allow_unpolished)
                  {
                    allow_unpolished = new_allow_unpolished;
                    fieldGeneratorStatType.set_allow_unpolished(new_allow_unpolished);
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
        private bool flagHasYear;
        private BigInteger storeYear;
        private bool flagHasLeague;
        private string storeLeague;
        private bool flagHasLeagueDivision;
        private SportsLeagueDivisionJSON  storeLeagueDivision;
        private bool flagHasQualifier;
        private TypeQualifier storeQualifier;
        private bool flagHasStats;
        private List< TypeStatsJSON  > storeStats;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONYear(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field Year of TypeValueJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Year of TypeValueJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setYear(extracted_integer);
          }


        private void  fromJSONLeague(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field League of TypeValueJSON is not a string.");
            setLeague(json_string.getData());
          }


        private void  fromJSONLeagueDivision(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            SportsLeagueDivisionJSON convert_classy = SportsLeagueDivisionJSON.from_json(json_value, ignore_extras, true);
            setLeagueDivision(convert_classy);
          }


        private void  fromJSONQualifier(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Qualifier of TypeValueJSON is not a string.");
            TypeQualifier the_open_enum = new TypeQualifier();
            switch (json_string.getData()[0])
              {
                case 'G':
                    if ((String.Compare(json_string.getData(), 1, "oaltending", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeQualifierKnownValues.Qualifier_Goaltending;
                            goto open_enum_is_done;
                          }
                    break;
                case 'O':
                    if ((String.Compare(json_string.getData(), 1, "ffense", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeQualifierKnownValues.Qualifier_Offense;
                            goto open_enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            setQualifier(the_open_enum);
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
            for (int num3 = 0; num3 < vector_Stats1.Count; ++num3)
                appendStats(vector_Stats1[num3]);
            for (int num1 = 0; num1 < vector_Stats1.Count; ++num1)
              {
              }
          }


        public TypeValueJSON()
          {
            flagHasYear = false;
            flagHasLeague = false;
            flagHasLeagueDivision = false;
            flagHasQualifier = false;
            flagHasStats = false;
            storeStats = new List< TypeStatsJSON  >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasYear()
          {
            return flagHasYear;
          }

        public BigInteger  getYear()
          {
            Debug.Assert(flagHasYear);
            return storeYear;
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

        public bool  hasLeagueDivision()
          {
            return flagHasLeagueDivision;
          }

        public SportsLeagueDivisionJSON   getLeagueDivision()
          {
            Debug.Assert(flagHasLeagueDivision);
            return storeLeagueDivision;
          }

        public SportsLeagueDivisionJSON.TypeValue  getLeagueDivisionValue()
          {
            return getLeagueDivision().getValue();
          }

        public string  getLeagueDivisionAsString()
          {
            return getLeagueDivision().getValueAsString();
          }

        public bool  hasQualifier()
          {
            return flagHasQualifier;
          }

        public TypeQualifier  getQualifier()
          {
            Debug.Assert(flagHasQualifier);
            return storeQualifier;
          }

        public string  getQualifierAsString()
          {
            TypeQualifier result = getQualifier();
            if (result.in_known_list)
                return stringFromQualifier(result.list_value);
            else
                return result.string_value;
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

        public void setYear(BigInteger new_value)
          {
            flagHasYear = true;
            if (new_value < 0)
                throw new Exception("The value for field Year of TypeValueJSON is less than the lower bound (0) for that field.");
            storeYear = new_value;
          }
        public void unsetYear()
          {
            flagHasYear = false;
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
        public void setLeagueDivision(SportsLeagueDivisionJSON  new_value)
          {
            if (flagHasLeagueDivision)
              {
              }
            flagHasLeagueDivision = true;
            storeLeagueDivision = new_value;
          }
        public void setLeagueDivision(SportsLeagueDivisionJSON.TypeValue new_value)
          {
            setLeagueDivision(new SportsLeagueDivisionJSON(new_value));
          }
        public void setLeagueDivision(string chars)
          {
            SportsLeagueDivisionJSON.TypeValueKnownValues known = SportsLeagueDivisionJSON.stringToValue(chars);
            SportsLeagueDivisionJSON.TypeValue new_value = new SportsLeagueDivisionJSON.TypeValue();
            if (known == SportsLeagueDivisionJSON.TypeValueKnownValues.Value__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setLeagueDivision(new_value);
          }
        public void unsetLeagueDivision()
          {
            if (flagHasLeagueDivision)
              {
              }
            flagHasLeagueDivision = false;
          }
        public void setQualifier(TypeQualifier new_value)
          {
            flagHasQualifier = true;
            storeQualifier = new_value;
          }
        public void setQualifier(string chars)
          {
            TypeQualifierKnownValues known = stringToQualifier(chars);
            TypeQualifier new_value = new TypeQualifier();
            if (known == TypeQualifierKnownValues.Qualifier__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setQualifier(new_value);
          }
        public void setQualifier(TypeQualifierKnownValues new_value)
          {
            TypeQualifier new_full_value = new TypeQualifier();
            Debug.Assert(new_value != TypeQualifierKnownValues.Qualifier__none);
            new_full_value.in_known_list = true;
            new_full_value.list_value = new_value;
            setQualifier(new_full_value);
          }
        public void unsetQualifier()
          {
            flagHasQualifier = false;
          }
        public void initStats()
          {
            if (flagHasStats)
              {
                for (int num5 = 0; num5 < storeStats.Count; ++num5)
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
                for (int num6 = 0; num6 < storeStats.Count; ++num6)
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
            Debug.Assert(partial_allowed || flagHasYear);
            if (flagHasYear)
              {
                handler.start_pair("Year");
                handler.number_value(storeYear);
              }
            Debug.Assert(partial_allowed || flagHasLeague);
            if (flagHasLeague)
              {
                handler.start_pair("League");
                handler.string_value(storeLeague);
              }
            if (flagHasLeagueDivision)
              {
                handler.start_pair("LeagueDivision");
                if (partial_allowed)
                    storeLeagueDivision.write_partial_as_json(handler);
                else
                    storeLeagueDivision.write_as_json(handler);
              }
            if (flagHasQualifier)
              {
                handler.start_pair("Qualifier");
                if (storeQualifier.in_known_list)
                  {
                    switch (storeQualifier.list_value)
                      {
                        case TypeQualifierKnownValues.Qualifier_Goaltending:
                            handler.string_value("Goaltending");
                            break;
                        case TypeQualifierKnownValues.Qualifier_Offense:
                            handler.string_value("Offense");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeQualifier.string_value);
                  }
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
            if (!(hasYear()))
              {
                return "When parsing the object for %what%, the \"Year\" field was missing.";
              }
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
        private class FieldHoldingGeneratorYear : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorYear(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorYear : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorYear(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorYear fieldGeneratorYear;
            private JSONHoldingStringGenerator fieldGeneratorLeague;
            private SportsLeagueDivisionJSON.HoldingGenerator fieldGeneratorLeagueDivision;
        private abstract class FieldGeneratorQualifier : JSONStringGenerator
              {
                protected FieldGeneratorQualifier(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorQualifier()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    TypeQualifierKnownValues known = stringToQualifier(result);
                    TypeQualifier new_value = new TypeQualifier();
                    if (known == TypeQualifierKnownValues.Qualifier__none)
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
                protected abstract void handle_result(TypeQualifier result);
              };
        private class FieldHoldingGeneratorQualifier : FieldGeneratorQualifier
      {
        protected override void handle_result(TypeQualifier result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorQualifier(String what)
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
        public TypeQualifier value;
      };
        private class FieldHoldingArrayGeneratorQualifier : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorQualifier
          {
            private FieldHoldingArrayGeneratorQualifier top;

            protected override void handle_result(TypeQualifier result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorQualifier init_top)
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
        protected virtual void handle_result(List<TypeQualifier> result)
          {
          }

        public FieldHoldingArrayGeneratorQualifier(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeQualifier>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorQualifier()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeQualifier>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeQualifier> value;
      };
            private FieldHoldingGeneratorQualifier fieldGeneratorQualifier;
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
                if (fieldGeneratorYear.have_value)
                  {
                    result.setYear(fieldGeneratorYear.value);
                    fieldGeneratorYear.have_value = false;
                  }
                else if ((!(result.hasYear())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Year\" field was missing.");
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
                if (fieldGeneratorLeagueDivision.have_value)
                  {
                    result.setLeagueDivision(fieldGeneratorLeagueDivision.value);
                    fieldGeneratorLeagueDivision.have_value = false;
                  }
                if (fieldGeneratorQualifier.have_value)
                  {
                    result.setQualifier(fieldGeneratorQualifier.value);
                    fieldGeneratorQualifier.have_value = false;
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
                    case 'L':
                        if (String.Compare(field_name, 1, "eague", 0, 5, false) == 0)
                          {
                            if (field_name.Length == 6)
                              {
                                return fieldGeneratorLeague;
                              }
                            switch (field_name[6])
                              {
                                case 'D':
                                    if ((String.Compare(field_name, 7, "ivision", 0, 7, false) == 0) && (field_name.Length == 14))
                                        return fieldGeneratorLeagueDivision;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'Q':
                        if ((String.Compare(field_name, 1, "ualifier", 0, 8, false) == 0) && (field_name.Length == 9))
                            return fieldGeneratorQualifier;
                        break;
                    case 'S':
                        if ((String.Compare(field_name, 1, "tats", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorStats;
                        break;
                    case 'Y':
                        if ((String.Compare(field_name, 1, "ear", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorYear;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorYear = new FieldHoldingGeneratorYear("field \"Year\" of the TypeValue class");
                fieldGeneratorLeague = new JSONHoldingStringGenerator("field \"League\" of the TypeValue class");
                fieldGeneratorLeagueDivision = new SportsLeagueDivisionJSON.HoldingGenerator("field \"LeagueDivision\" of the TypeValue class", ignore_extras);
                fieldGeneratorQualifier = new FieldHoldingGeneratorQualifier("field \"Qualifier\" of the TypeValue class");
                fieldGeneratorStats = new TypeStatsJSON.HoldingArrayGenerator("field \"Stats\" of the TypeValue class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeValue class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorYear = new FieldHoldingGeneratorYear("field \"Year\" of the TypeValue class");
                fieldGeneratorLeague = new JSONHoldingStringGenerator("field \"League\" of the TypeValue class");
                fieldGeneratorLeagueDivision = new SportsLeagueDivisionJSON.HoldingGenerator("field \"LeagueDivision\" of the TypeValue class", false);
                fieldGeneratorQualifier = new FieldHoldingGeneratorQualifier("field \"Qualifier\" of the TypeValue class");
                fieldGeneratorStats = new TypeStatsJSON.HoldingArrayGenerator("field \"Stats\" of the TypeValue class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeValue class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorYear.reset();
                fieldGeneratorLeague.reset();
                fieldGeneratorLeagueDivision.reset();
                fieldGeneratorQualifier.reset();
                fieldGeneratorStats.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorLeagueDivision.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorLeagueDivision.set_allow_unpolished(new_allow_unpolished);
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
            throw new Exception("The value for field Value of SportsLeagueLeadersAPIJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeValueJSON  > vector_Value1 = new List< TypeValueJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeValueJSON convert_classy = TypeValueJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Value1.Add(convert_classy);
          }
        initValue();
        for (int num4 = 0; num4 < vector_Value1.Count; ++num4)
            appendValue(vector_Value1[num4]);
        for (int num1 = 0; num1 < vector_Value1.Count; ++num1)
          {
          }
      }


    public SportsLeagueLeadersAPIJSON()
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
            for (int num7 = 0; num7 < storeValue.Count; ++num7)
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
            for (int num8 = 0; num8 < storeValue.Count; ++num8)
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

    public static SportsLeagueLeadersAPIJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsLeagueLeadersAPIJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsLeagueLeadersAPI", ignore_extras);
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
    public static SportsLeagueLeadersAPIJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsLeagueLeadersAPIJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsLeagueLeadersAPIJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsLeagueLeadersAPI", ignore_extras);
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
    public static SportsLeagueLeadersAPIJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsLeagueLeadersAPIJSON from_text(string text, bool ignore_extras)
      {
        SportsLeagueLeadersAPIJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsLeagueLeadersAPI", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsLeagueLeadersAPIJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsLeagueLeadersAPIJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsLeagueLeadersAPIJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsLeagueLeadersAPI", ignore_extras);
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
            SportsLeagueLeadersAPIJSON result = new SportsLeagueLeadersAPIJSON();
            result.initValue();
            int count = value.Count;
            for (int num = 0; num < count; ++num)
              {
                result.appendValue(value[num]);
              }
            handle_result(result);
          }
        protected abstract void handle_result(SportsLeagueLeadersAPIJSON new_result);
        public Generator(bool ignore_extras) : base("Type SportsLeagueLeadersAPI", ignore_extras)
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
        protected override void handle_result(SportsLeagueLeadersAPIJSON  result)
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
        public SportsLeagueLeadersAPIJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsLeagueLeadersAPIJSON  result)
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
    protected virtual void handle_result(List<SportsLeagueLeadersAPIJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsLeagueLeadersAPIJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsLeagueLeadersAPIJSON>();
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
    public List<SportsLeagueLeadersAPIJSON> value;
  };
  };
