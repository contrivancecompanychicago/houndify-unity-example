/* file "SportsStandingsAPIJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SportsStandingsAPIJSON : JSONBase
  {
    public class TypeValueJSON : JSONBase
      {
        public class TypeDivisionsJSON : JSONBase
          {
            public class TypeTeamsJSON : JSONBase
              {
                public class TypeTeamJSON : JSONBase
                  {
                    private bool flagHasID;
                    private string storeID;
                    private bool flagHasAlias;
                    private string storeAlias;
                    private bool flagHasName;
                    private string storeName;
                    private List<string> extraKeys;
                    private List<JSONValue > extraValues;
                    private Dictionary<string, JSONValue > extraIndex;


                    private void  fromJSONID(JSONValue json_value, bool ignore_extras)
                      {
                        Debug.Assert(json_value != null);
                        JSONStringValue json_string = json_value.string_value();
                        if (json_string == null)
                            throw new Exception("The value for field ID of TypeTeamJSON is not a string.");
                        setID(json_string.getData());
                      }


                    private void  fromJSONAlias(JSONValue json_value, bool ignore_extras)
                      {
                        Debug.Assert(json_value != null);
                        JSONStringValue json_string = json_value.string_value();
                        if (json_string == null)
                            throw new Exception("The value for field Alias of TypeTeamJSON is not a string.");
                        setAlias(json_string.getData());
                      }


                    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
                      {
                        Debug.Assert(json_value != null);
                        JSONStringValue json_string = json_value.string_value();
                        if (json_string == null)
                            throw new Exception("The value for field Name of TypeTeamJSON is not a string.");
                        setName(json_string.getData());
                      }


                    public TypeTeamJSON()
                      {
                        flagHasID = false;
                        flagHasAlias = false;
                        flagHasName = false;
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

                    public bool  hasAlias()
                      {
                        return flagHasAlias;
                      }

                    public string  getAlias()
                      {
                        Debug.Assert(flagHasAlias);
                        return storeAlias;
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


                    public virtual int extraTypeTeamComponentCount()
                      {
                        Debug.Assert(extraKeys.Count == extraValues.Count);
                        return extraKeys.Count;
                      }
                    public virtual string extraTypeTeamComponentKey(int component_num)
                      {
                        Debug.Assert(extraKeys.Count == extraValues.Count);
                        Debug.Assert(component_num < extraValues.Count);
                        return extraKeys[component_num];
                      }
                    public virtual JSONValue extraTypeTeamComponentValue(int component_num)
                      {
                        Debug.Assert(extraKeys.Count == extraValues.Count);
                        Debug.Assert(component_num < extraValues.Count);
                        return extraValues[component_num];
                      }
                    public virtual JSONValue extraTypeTeamLookup(string field_name)
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
                    public void setAlias(string new_value)
                      {
                        flagHasAlias = true;
                        storeAlias = new_value;
                      }
                    public void unsetAlias()
                      {
                        flagHasAlias = false;
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

                    public virtual void extraTypeTeamAppendPair(string key, JSONValue new_component)
                      {
                        Debug.Assert(key != null);
                        Debug.Assert(new_component != null);

                        Debug.Assert(extraKeys.Count == extraValues.Count);
                        extraKeys.Add(key);
                        extraValues.Add(new_component);
                        extraIndex.Add(key, new_component);
                      }
                    public virtual void extraTypeTeamSetField(string key, JSONValue new_component)
                      {
                        Debug.Assert(key != null);
                        Debug.Assert(new_component != null);

                        JSONValue old_field = extraTypeTeamLookup(key);
                        if (old_field == null)
                          {
                            extraTypeTeamAppendPair(key, new_component);
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
                        if (flagHasAlias)
                          {
                            handler.start_pair("Alias");
                            handler.string_value(storeAlias);
                          }
                        if (flagHasName)
                          {
                            handler.start_pair("Name");
                            handler.string_value(storeName);
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
                        return null;
                      }

                    public static TypeTeamJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                      {
                        TypeTeamJSON result;
                          {
                            HoldingGenerator generator = new HoldingGenerator("Type TypeTeam", ignore_extras);
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
                    public static TypeTeamJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
                  {
                    return from_json(json_value, ignore_extras, allow_incomplete, false);
                  }
                    public static TypeTeamJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                      {
                        TypeTeamJSON result;
                          {
                            HoldingGenerator generator = new HoldingGenerator("Type TypeTeam", ignore_extras);
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
                    public static TypeTeamJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
                  {
                    return from_json(json_value, ignore_extras, allow_incomplete, false);
                  }
                    public static TypeTeamJSON from_text(string text, bool ignore_extras)
                      {
                        TypeTeamJSON result;
                          {
                            HoldingGenerator generator = new HoldingGenerator("Type TypeTeam", ignore_extras);
                            JSONParse.parse_json_value(text, "Text for TypeTeamJSON", generator);
                            Debug.Assert(generator.have_value);
                            result = generator.value;
                          };
                        return result;
                      }
                    public static TypeTeamJSON from_file(TextReader fp, string file_name, bool ignore_extras)
                      {
                        TypeTeamJSON result;
                          {
                            HoldingGenerator generator = new HoldingGenerator("Type TypeTeam", ignore_extras);
                            JSONParse.parse_json_value(fp, file_name, generator);
                            Debug.Assert(generator.have_value);
                            result = generator.value;
                          };
                        return result;
                      }
                    public abstract class Generator : JSONObjectGenerator
                      {
                        private JSONHoldingStringGenerator fieldGeneratorID;
                        private JSONHoldingStringGenerator fieldGeneratorAlias;
                        private JSONHoldingStringGenerator fieldGeneratorName;
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
                            TypeTeamJSON result = new TypeTeamJSON();
                            Debug.Assert(result != null);
                            finish(result);
                            int extra_count = unknownFieldGenerator.field_names.Count;
                            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                              {
                                result.extraTypeTeamAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                              }
                            unknownFieldGenerator.field_names.Clear();
                            unknownFieldGenerator.field_values.Clear();
                            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                            handle_result(result);
                          }
                        protected void finish(TypeTeamJSON result)
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
                            if (fieldGeneratorAlias.have_value)
                              {
                                result.setAlias(fieldGeneratorAlias.value);
                                fieldGeneratorAlias.have_value = false;
                              }
                            if (fieldGeneratorName.have_value)
                              {
                                result.setName(fieldGeneratorName.value);
                                fieldGeneratorName.have_value = false;
                              }
                          }
                        protected abstract void handle_result(TypeTeamJSON new_result);
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
                                case 'N':
                                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                                        return fieldGeneratorName;
                                    break;
                                default:
                                    break;
                              }
                            return null;
                          }
                        public Generator(bool ignore_extras)
                          {
                            fieldGeneratorID = new JSONHoldingStringGenerator("field \"ID\" of the TypeTeam class");
                            fieldGeneratorAlias = new JSONHoldingStringGenerator("field \"Alias\" of the TypeTeam class");
                            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the TypeTeam class");
                            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                            set_what("the TypeTeam class");
                            allow_incomplete = false;
                            allow_unpolished = false;
                          }
                        public Generator()
                          {
                            fieldGeneratorID = new JSONHoldingStringGenerator("field \"ID\" of the TypeTeam class");
                            fieldGeneratorAlias = new JSONHoldingStringGenerator("field \"Alias\" of the TypeTeam class");
                            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the TypeTeam class");
                            unknownFieldGenerator = new UnknownFieldGenerator(false);
                            set_what("the TypeTeam class");
                            allow_incomplete = false;
                            allow_unpolished = false;
                          }

                        public override void reset()
                          {
                            fieldGeneratorID.reset();
                            fieldGeneratorAlias.reset();
                            fieldGeneratorName.reset();
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
                        protected override void handle_result(TypeTeamJSON  result)
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
                        public TypeTeamJSON value;
                      };
                    public class HoldingArrayGenerator : JSONArrayGenerator
                  {
                    protected class ElementHandler : Generator
                      {
                        private HoldingArrayGenerator top;

                        protected override void handle_result(TypeTeamJSON  result)
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
                    protected virtual void handle_result(List<TypeTeamJSON> result)

                      {
                      }

                    public HoldingArrayGenerator(string what, bool ignore_extras)
                      {
                        element_handler = new ElementHandler(this, ignore_extras);
                        have_value = false;
                        value = new List<TypeTeamJSON>();
                        base.set_what(what);
                      }
                    public HoldingArrayGenerator(bool ignore_extras)
                      {
                        element_handler = new ElementHandler(this, ignore_extras);
                        value = new List<TypeTeamJSON>();
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
                    public List<TypeTeamJSON> value;
                  };
                  };
                private bool flagHasTeam;
                private TypeTeamJSON  storeTeam;
                private bool flagHasStandingsData;
                private SportsStandingsDataJSON  storeStandingsData;
                private List<string> extraKeys;
                private List<JSONValue > extraValues;
                private Dictionary<string, JSONValue > extraIndex;


                private void  fromJSONTeam(JSONValue json_value, bool ignore_extras)
                  {
                    Debug.Assert(json_value != null);
                    TypeTeamJSON convert_classy = TypeTeamJSON.from_json(json_value, ignore_extras, true);
                    setTeam(convert_classy);
                  }


                private void  fromJSONStandingsData(JSONValue json_value, bool ignore_extras)
                  {
                    Debug.Assert(json_value != null);
                    SportsStandingsDataJSON convert_classy = SportsStandingsDataJSON.from_json(json_value, ignore_extras, true);
                    setStandingsData(convert_classy);
                  }


                public TypeTeamsJSON()
                  {
                    flagHasTeam = false;
                    flagHasStandingsData = false;
                    extraKeys = new List<string>();
                extraValues = new List<JSONValue >();
                extraIndex = new Dictionary<string, JSONValue >();
                  }

                public bool  hasTeam()
                  {
                    return flagHasTeam;
                  }

                public TypeTeamJSON   getTeam()
                  {
                    Debug.Assert(flagHasTeam);
                    return storeTeam;
                  }

                public bool  hasStandingsData()
                  {
                    return flagHasStandingsData;
                  }

                public SportsStandingsDataJSON   getStandingsData()
                  {
                    Debug.Assert(flagHasStandingsData);
                    return storeStandingsData;
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

                public void setTeam(TypeTeamJSON  new_value)
                  {
                    if (flagHasTeam)
                      {
                      }
                    flagHasTeam = true;
                    storeTeam = new_value;
                  }
                public void unsetTeam()
                  {
                    if (flagHasTeam)
                      {
                      }
                    flagHasTeam = false;
                  }
                public void setStandingsData(SportsStandingsDataJSON  new_value)
                  {
                    if (flagHasStandingsData)
                      {
                      }
                    flagHasStandingsData = true;
                    storeStandingsData = new_value;
                  }
                public void unsetStandingsData()
                  {
                    if (flagHasStandingsData)
                      {
                      }
                    flagHasStandingsData = false;
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
                    Debug.Assert(partial_allowed || flagHasTeam);
                    if (flagHasTeam)
                      {
                        handler.start_pair("Team");
                        if (partial_allowed)
                            storeTeam.write_partial_as_json(handler);
                        else
                            storeTeam.write_as_json(handler);
                      }
                    Debug.Assert(partial_allowed || flagHasStandingsData);
                    if (flagHasStandingsData)
                      {
                        handler.start_pair("StandingsData");
                        if (partial_allowed)
                            storeStandingsData.write_partial_as_json(handler);
                        else
                            storeStandingsData.write_as_json(handler);
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
                    if (!(hasTeam()))
                      {
                        return "When parsing the object for %what%, the \"Team\" field was missing.";
                      }
                    if (!(hasStandingsData()))
                      {
                        return "When parsing the object for %what%, the \"StandingsData\" field was missing.";
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
                    private TypeTeamJSON.HoldingGenerator fieldGeneratorTeam;
                    private SportsStandingsDataJSON.HoldingGenerator fieldGeneratorStandingsData;
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
                        if (fieldGeneratorTeam.have_value)
                          {
                            result.setTeam(fieldGeneratorTeam.value);
                            fieldGeneratorTeam.have_value = false;
                          }
                        else if ((!(result.hasTeam())) && !allow_incomplete)
                          {
                            error("When parsing the object for %what%, the \"Team\" field was missing.");
                          }
                        if (fieldGeneratorStandingsData.have_value)
                          {
                            result.setStandingsData(fieldGeneratorStandingsData.value);
                            fieldGeneratorStandingsData.have_value = false;
                          }
                        else if ((!(result.hasStandingsData())) && !allow_incomplete)
                          {
                            error("When parsing the object for %what%, the \"StandingsData\" field was missing.");
                          }
                      }
                    protected abstract void handle_result(TypeTeamsJSON new_result);
                    protected virtual JSONHandler start_known_field(string field_name)
                      {
                        switch (field_name[0])
                          {
                            case 'S':
                                if ((String.Compare(field_name, 1, "tandingsData", 0, 12, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorStandingsData;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 1, "eam", 0, 3, false) == 0) && (field_name.Length == 4))
                                    return fieldGeneratorTeam;
                                break;
                            default:
                                break;
                          }
                        return null;
                      }
                    public Generator(bool ignore_extras)
                      {
                        fieldGeneratorTeam = new TypeTeamJSON.HoldingGenerator("field \"Team\" of the TypeTeams class", ignore_extras);
                        fieldGeneratorStandingsData = new SportsStandingsDataJSON.HoldingGenerator("field \"StandingsData\" of the TypeTeams class", ignore_extras);
                        unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                        set_what("the TypeTeams class");
                        allow_incomplete = false;
                        allow_unpolished = false;
                      }
                    public Generator()
                      {
                        fieldGeneratorTeam = new TypeTeamJSON.HoldingGenerator("field \"Team\" of the TypeTeams class", false);
                        fieldGeneratorStandingsData = new SportsStandingsDataJSON.HoldingGenerator("field \"StandingsData\" of the TypeTeams class", false);
                        unknownFieldGenerator = new UnknownFieldGenerator(false);
                        set_what("the TypeTeams class");
                        allow_incomplete = false;
                        allow_unpolished = false;
                      }

                    public override void reset()
                      {
                        fieldGeneratorTeam.reset();
                        fieldGeneratorStandingsData.reset();
                        base.reset();
                        unknownFieldGenerator.reset();
                      }
                    public void set_allow_incomplete(bool new_allow_incomplete)
                      {
                        allow_incomplete = new_allow_incomplete;
                        fieldGeneratorTeam.set_allow_incomplete(new_allow_incomplete);
                        fieldGeneratorStandingsData.set_allow_incomplete(new_allow_incomplete);
                      }
                    public void set_allow_unpolished(bool new_allow_unpolished)
                      {
                        allow_unpolished = new_allow_unpolished;
                        fieldGeneratorTeam.set_allow_unpolished(new_allow_unpolished);
                        fieldGeneratorStandingsData.set_allow_unpolished(new_allow_unpolished);
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
            private bool flagHasDivision;
            private string storeDivision;
            private bool flagHasTeams;
            private List< TypeTeamsJSON  > storeTeams;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONDivision(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field Division of TypeDivisionsJSON is not a string.");
                setDivision(json_string.getData());
              }


            private void  fromJSONTeams(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONArrayValue json_array1 = json_value.array_value();
                if (json_array1 == null)
                    throw new Exception("The value for field Teams of TypeDivisionsJSON is not an array.");
                int count1 = json_array1.componentCount();
                if (count1 < 1)
                    throw new Exception("The value for field Teams of TypeDivisionsJSON has too few elements.");
                List< TypeTeamsJSON  > vector_Teams1 = new List< TypeTeamsJSON  >(count1);
                for (int num1 = 0; num1 < count1; ++num1)
                  {
                    TypeTeamsJSON convert_classy = TypeTeamsJSON.from_json(json_array1.component(num1), ignore_extras, true);
                    vector_Teams1.Add(convert_classy);
                  }
                Debug.Assert(vector_Teams1.Count >= 1);
                initTeams();
                for (int num1 = 0; num1 < vector_Teams1.Count; ++num1)
                    appendTeams(vector_Teams1[num1]);
                for (int num1 = 0; num1 < vector_Teams1.Count; ++num1)
                  {
                  }
              }


            public TypeDivisionsJSON()
              {
                flagHasDivision = false;
                flagHasTeams = false;
                storeTeams = new List< TypeTeamsJSON  >();
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasDivision()
              {
                return flagHasDivision;
              }

            public string  getDivision()
              {
                Debug.Assert(flagHasDivision);
                return storeDivision;
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


            public virtual int extraTypeDivisionsComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypeDivisionsComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypeDivisionsComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypeDivisionsLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setDivision(string new_value)
              {
                flagHasDivision = true;
                storeDivision = new_value;
              }
            public void unsetDivision()
              {
                flagHasDivision = false;
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

            public virtual void extraTypeDivisionsAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypeDivisionsSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypeDivisionsLookup(key);
                if (old_field == null)
                  {
                    extraTypeDivisionsAppendPair(key, new_component);
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
                Debug.Assert(partial_allowed || flagHasDivision);
                if (flagHasDivision)
                  {
                    handler.start_pair("Division");
                    handler.string_value(storeDivision);
                  }
                Debug.Assert(partial_allowed || flagHasTeams);
                if (flagHasTeams)
                  {
                    handler.start_pair("Teams");
                    Debug.Assert(storeTeams.Count >= 1);
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
                if (!(hasDivision()))
                  {
                    return "When parsing the object for %what%, the \"Division\" field was missing.";
                  }
                if (!(hasTeams()))
                  {
                    return "When parsing the object for %what%, the \"Teams\" field was missing.";
                  }
                return null;
              }

            public static TypeDivisionsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeDivisionsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeDivisions", ignore_extras);
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
            public static TypeDivisionsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeDivisionsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeDivisionsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeDivisions", ignore_extras);
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
            public static TypeDivisionsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeDivisionsJSON from_text(string text, bool ignore_extras)
              {
                TypeDivisionsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeDivisions", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeDivisionsJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeDivisionsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeDivisionsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeDivisions", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private JSONHoldingStringGenerator fieldGeneratorDivision;
                private TypeTeamsJSON.HoldingArrayGenerator fieldGeneratorTeams;
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
                    TypeDivisionsJSON result = new TypeDivisionsJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypeDivisionsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypeDivisionsJSON result)
                  {
                    if (fieldGeneratorDivision.have_value)
                      {
                        result.setDivision(fieldGeneratorDivision.value);
                        fieldGeneratorDivision.have_value = false;
                      }
                    else if ((!(result.hasDivision())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Division\" field was missing.");
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
                    else if ((!(result.hasTeams())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Teams\" field was missing.");
                      }
                  }
                protected abstract void handle_result(TypeDivisionsJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    switch (field_name[0])
                      {
                        case 'D':
                            if ((String.Compare(field_name, 1, "ivision", 0, 7, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorDivision;
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
                    fieldGeneratorDivision = new JSONHoldingStringGenerator("field \"Division\" of the TypeDivisions class");
                    fieldGeneratorTeams = new TypeTeamsJSON.HoldingArrayGenerator("field \"Teams\" of the TypeDivisions class", ignore_extras);
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypeDivisions class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorDivision = new JSONHoldingStringGenerator("field \"Division\" of the TypeDivisions class");
                    fieldGeneratorTeams = new TypeTeamsJSON.HoldingArrayGenerator("field \"Teams\" of the TypeDivisions class", false);
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypeDivisions class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorDivision.reset();
                    fieldGeneratorTeams.reset();
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
                protected override void handle_result(TypeDivisionsJSON  result)
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
                public TypeDivisionsJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeDivisionsJSON  result)
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
            protected virtual void handle_result(List<TypeDivisionsJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeDivisionsJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeDivisionsJSON>();
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
            public List<TypeDivisionsJSON> value;
          };
          };
        private bool flagHasYear;
        private BigInteger storeYear;
        private bool flagHasLeague;
        private string storeLeague;
        private bool flagHasTournament;
        private string storeTournament;
        private bool flagHasDivisionParent;
        private SportsLeagueDivisionJSON  storeDivisionParent;
        private bool flagHasWildCard;
        private bool storeWildCard;
        private bool flagHasConference;
        private bool storeConference;
        private bool flagHasDivisional;
        private bool storeDivisional;
        private bool flagHasDivisions;
        private List< TypeDivisionsJSON  > storeDivisions;
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


        private void  fromJSONTournament(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Tournament of TypeValueJSON is not a string.");
            setTournament(json_string.getData());
          }


        private void  fromJSONDivisionParent(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            SportsLeagueDivisionJSON convert_classy = SportsLeagueDivisionJSON.from_json(json_value, ignore_extras, true);
            setDivisionParent(convert_classy);
          }


        private void  fromJSONWildCard(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field WildCard of TypeValueJSON is not true for false.");
                  }
              }
            setWildCard(the_bool);
          }


        private void  fromJSONConference(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field Conference of TypeValueJSON is not true for false.");
                  }
              }
            setConference(the_bool);
          }


        private void  fromJSONDivisional(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field Divisional of TypeValueJSON is not true for false.");
                  }
              }
            setDivisional(the_bool);
          }


        private void  fromJSONDivisions(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field Divisions of TypeValueJSON is not an array.");
            int count1 = json_array1.componentCount();
            if (count1 < 1)
                throw new Exception("The value for field Divisions of TypeValueJSON has too few elements.");
            List< TypeDivisionsJSON  > vector_Divisions1 = new List< TypeDivisionsJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                TypeDivisionsJSON convert_classy = TypeDivisionsJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_Divisions1.Add(convert_classy);
              }
            Debug.Assert(vector_Divisions1.Count >= 1);
            initDivisions();
            for (int num2 = 0; num2 < vector_Divisions1.Count; ++num2)
                appendDivisions(vector_Divisions1[num2]);
            for (int num1 = 0; num1 < vector_Divisions1.Count; ++num1)
              {
              }
          }


        public TypeValueJSON()
          {
            flagHasYear = false;
            flagHasLeague = false;
            flagHasTournament = false;
            flagHasDivisionParent = false;
            flagHasWildCard = false;
            flagHasConference = false;
            flagHasDivisional = false;
            flagHasDivisions = false;
            storeDivisions = new List< TypeDivisionsJSON  >();
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

        public bool  hasTournament()
          {
            return flagHasTournament;
          }

        public string  getTournament()
          {
            Debug.Assert(flagHasTournament);
            return storeTournament;
          }

        public bool  hasDivisionParent()
          {
            return flagHasDivisionParent;
          }

        public SportsLeagueDivisionJSON   getDivisionParent()
          {
            Debug.Assert(flagHasDivisionParent);
            return storeDivisionParent;
          }

        public SportsLeagueDivisionJSON.TypeValue  getDivisionParentValue()
          {
            return getDivisionParent().getValue();
          }

        public string  getDivisionParentAsString()
          {
            return getDivisionParent().getValueAsString();
          }

        public bool  hasWildCard()
          {
            return flagHasWildCard;
          }

        public bool  getWildCard()
          {
            Debug.Assert(flagHasWildCard);
            return storeWildCard;
          }

        public bool  hasConference()
          {
            return flagHasConference;
          }

        public bool  getConference()
          {
            Debug.Assert(flagHasConference);
            return storeConference;
          }

        public bool  hasDivisional()
          {
            return flagHasDivisional;
          }

        public bool  getDivisional()
          {
            Debug.Assert(flagHasDivisional);
            return storeDivisional;
          }

        public bool  hasDivisions()
          {
            return flagHasDivisions;
          }

        public int  countOfDivisions()
          {
            Debug.Assert(flagHasDivisions);
            return storeDivisions.Count;
          }

        public TypeDivisionsJSON   elementOfDivisions(int element_num)
          {
            Debug.Assert(flagHasDivisions);
            return storeDivisions[element_num];
          }

        public List< TypeDivisionsJSON  >  getDivisions()
          {
            Debug.Assert(flagHasDivisions);
            return storeDivisions;
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
        public void setTournament(string new_value)
          {
            flagHasTournament = true;
            storeTournament = new_value;
          }
        public void unsetTournament()
          {
            flagHasTournament = false;
          }
        public void setDivisionParent(SportsLeagueDivisionJSON  new_value)
          {
            if (flagHasDivisionParent)
              {
              }
            flagHasDivisionParent = true;
            storeDivisionParent = new_value;
          }
        public void setDivisionParent(SportsLeagueDivisionJSON.TypeValue new_value)
          {
            setDivisionParent(new SportsLeagueDivisionJSON(new_value));
          }
        public void setDivisionParent(string chars)
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
            setDivisionParent(new_value);
          }
        public void unsetDivisionParent()
          {
            if (flagHasDivisionParent)
              {
              }
            flagHasDivisionParent = false;
          }
        public void setWildCard(bool new_value)
          {
            flagHasWildCard = true;
            storeWildCard = new_value;
          }
        public void unsetWildCard()
          {
            flagHasWildCard = false;
          }
        public void setConference(bool new_value)
          {
            flagHasConference = true;
            storeConference = new_value;
          }
        public void unsetConference()
          {
            flagHasConference = false;
          }
        public void setDivisional(bool new_value)
          {
            flagHasDivisional = true;
            storeDivisional = new_value;
          }
        public void unsetDivisional()
          {
            flagHasDivisional = false;
          }
        public void initDivisions()
          {
            if (flagHasDivisions)
              {
                for (int num3 = 0; num3 < storeDivisions.Count; ++num3)
                  {
                  }
              }
            flagHasDivisions = true;
            storeDivisions.Clear();
          }
        public void appendDivisions(TypeDivisionsJSON  to_append)
          {
            if (!flagHasDivisions)
              {
                flagHasDivisions = true;
                storeDivisions.Clear();
              }
            Debug.Assert(flagHasDivisions);
            storeDivisions.Add(to_append);
          }
        public void unsetDivisions()
          {
            if (flagHasDivisions)
              {
                for (int num4 = 0; num4 < storeDivisions.Count; ++num4)
                  {
                  }
              }
            flagHasDivisions = false;
            storeDivisions.Clear();
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
            if (flagHasTournament)
              {
                handler.start_pair("Tournament");
                handler.string_value(storeTournament);
              }
            if (flagHasDivisionParent)
              {
                handler.start_pair("DivisionParent");
                if (partial_allowed)
                    storeDivisionParent.write_partial_as_json(handler);
                else
                    storeDivisionParent.write_as_json(handler);
              }
            if (flagHasWildCard)
              {
                handler.start_pair("WildCard");
                handler.boolean_value(storeWildCard);
              }
            if (flagHasConference)
              {
                handler.start_pair("Conference");
                handler.boolean_value(storeConference);
              }
            if (flagHasDivisional)
              {
                handler.start_pair("Divisional");
                handler.boolean_value(storeDivisional);
              }
            Debug.Assert(partial_allowed || flagHasDivisions);
            if (flagHasDivisions)
              {
                handler.start_pair("Divisions");
                Debug.Assert(storeDivisions.Count >= 1);
                handler.start_array();
                for (int num1 = 0; num1 < storeDivisions.Count; ++num1)
                  {
                    if (partial_allowed)
                        storeDivisions[num1].write_partial_as_json(handler);
                    else
                        storeDivisions[num1].write_as_json(handler);
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
            if (!(hasDivisions()))
              {
                return "When parsing the object for %what%, the \"Divisions\" field was missing.";
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
            private JSONHoldingStringGenerator fieldGeneratorTournament;
            private SportsLeagueDivisionJSON.HoldingGenerator fieldGeneratorDivisionParent;
            private JSONHoldingBooleanGenerator fieldGeneratorWildCard;
            private JSONHoldingBooleanGenerator fieldGeneratorConference;
            private JSONHoldingBooleanGenerator fieldGeneratorDivisional;
            private TypeDivisionsJSON.HoldingArrayGenerator fieldGeneratorDivisions;
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
                if (fieldGeneratorTournament.have_value)
                  {
                    result.setTournament(fieldGeneratorTournament.value);
                    fieldGeneratorTournament.have_value = false;
                  }
                if (fieldGeneratorDivisionParent.have_value)
                  {
                    result.setDivisionParent(fieldGeneratorDivisionParent.value);
                    fieldGeneratorDivisionParent.have_value = false;
                  }
                if (fieldGeneratorWildCard.have_value)
                  {
                    result.setWildCard(fieldGeneratorWildCard.value);
                    fieldGeneratorWildCard.have_value = false;
                  }
                if (fieldGeneratorConference.have_value)
                  {
                    result.setConference(fieldGeneratorConference.value);
                    fieldGeneratorConference.have_value = false;
                  }
                if (fieldGeneratorDivisional.have_value)
                  {
                    result.setDivisional(fieldGeneratorDivisional.value);
                    fieldGeneratorDivisional.have_value = false;
                  }
                if (fieldGeneratorDivisions.have_value)
                  {
                    result.initDivisions();
                    int count = fieldGeneratorDivisions.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendDivisions(fieldGeneratorDivisions.value[num]);
                      }
                    fieldGeneratorDivisions.value.Clear();
                    fieldGeneratorDivisions.have_value = false;
                  }
                else if ((!(result.hasDivisions())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Divisions\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeValueJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'C':
                        if ((String.Compare(field_name, 1, "onference", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorConference;
                        break;
                    case 'D':
                        if (String.Compare(field_name, 1, "ivision", 0, 7, false) == 0)
                          {
                            switch (field_name[8])
                              {
                                case 'P':
                                    if ((String.Compare(field_name, 9, "arent", 0, 5, false) == 0) && (field_name.Length == 14))
                                        return fieldGeneratorDivisionParent;
                                    break;
                                case 'a':
                                    if ((String.Compare(field_name, 9, "l", 0, 1, false) == 0) && (field_name.Length == 10))
                                        return fieldGeneratorDivisional;
                                    break;
                                case 's':
                                    if (field_name.Length == 9)
                                        return fieldGeneratorDivisions;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'L':
                        if ((String.Compare(field_name, 1, "eague", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorLeague;
                        break;
                    case 'T':
                        if ((String.Compare(field_name, 1, "ournament", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorTournament;
                        break;
                    case 'W':
                        if ((String.Compare(field_name, 1, "ildCard", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorWildCard;
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
                fieldGeneratorTournament = new JSONHoldingStringGenerator("field \"Tournament\" of the TypeValue class");
                fieldGeneratorDivisionParent = new SportsLeagueDivisionJSON.HoldingGenerator("field \"DivisionParent\" of the TypeValue class", ignore_extras);
                fieldGeneratorWildCard = new JSONHoldingBooleanGenerator("field \"WildCard\" of the TypeValue class");
                fieldGeneratorConference = new JSONHoldingBooleanGenerator("field \"Conference\" of the TypeValue class");
                fieldGeneratorDivisional = new JSONHoldingBooleanGenerator("field \"Divisional\" of the TypeValue class");
                fieldGeneratorDivisions = new TypeDivisionsJSON.HoldingArrayGenerator("field \"Divisions\" of the TypeValue class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeValue class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorYear = new FieldHoldingGeneratorYear("field \"Year\" of the TypeValue class");
                fieldGeneratorLeague = new JSONHoldingStringGenerator("field \"League\" of the TypeValue class");
                fieldGeneratorTournament = new JSONHoldingStringGenerator("field \"Tournament\" of the TypeValue class");
                fieldGeneratorDivisionParent = new SportsLeagueDivisionJSON.HoldingGenerator("field \"DivisionParent\" of the TypeValue class", false);
                fieldGeneratorWildCard = new JSONHoldingBooleanGenerator("field \"WildCard\" of the TypeValue class");
                fieldGeneratorConference = new JSONHoldingBooleanGenerator("field \"Conference\" of the TypeValue class");
                fieldGeneratorDivisional = new JSONHoldingBooleanGenerator("field \"Divisional\" of the TypeValue class");
                fieldGeneratorDivisions = new TypeDivisionsJSON.HoldingArrayGenerator("field \"Divisions\" of the TypeValue class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeValue class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorYear.reset();
                fieldGeneratorLeague.reset();
                fieldGeneratorTournament.reset();
                fieldGeneratorDivisionParent.reset();
                fieldGeneratorWildCard.reset();
                fieldGeneratorConference.reset();
                fieldGeneratorDivisional.reset();
                fieldGeneratorDivisions.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorDivisionParent.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorDivisionParent.set_allow_unpolished(new_allow_unpolished);
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
            throw new Exception("The value for field Value of SportsStandingsAPIJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeValueJSON  > vector_Value1 = new List< TypeValueJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeValueJSON convert_classy = TypeValueJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Value1.Add(convert_classy);
          }
        initValue();
        for (int num3 = 0; num3 < vector_Value1.Count; ++num3)
            appendValue(vector_Value1[num3]);
        for (int num1 = 0; num1 < vector_Value1.Count; ++num1)
          {
          }
      }


    public SportsStandingsAPIJSON()
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
            for (int num5 = 0; num5 < storeValue.Count; ++num5)
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
            for (int num6 = 0; num6 < storeValue.Count; ++num6)
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

    public static SportsStandingsAPIJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStandingsAPIJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsAPI", ignore_extras);
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
    public static SportsStandingsAPIJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsStandingsAPIJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStandingsAPIJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsAPI", ignore_extras);
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
    public static SportsStandingsAPIJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsStandingsAPIJSON from_text(string text, bool ignore_extras)
      {
        SportsStandingsAPIJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsAPI", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsStandingsAPIJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsStandingsAPIJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsStandingsAPIJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsAPI", ignore_extras);
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
            SportsStandingsAPIJSON result = new SportsStandingsAPIJSON();
            result.initValue();
            int count = value.Count;
            for (int num = 0; num < count; ++num)
              {
                result.appendValue(value[num]);
              }
            handle_result(result);
          }
        protected abstract void handle_result(SportsStandingsAPIJSON new_result);
        public Generator(bool ignore_extras) : base("Type SportsStandingsAPI", ignore_extras)
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
        protected override void handle_result(SportsStandingsAPIJSON  result)
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
        public SportsStandingsAPIJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsStandingsAPIJSON  result)
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
    protected virtual void handle_result(List<SportsStandingsAPIJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsStandingsAPIJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsStandingsAPIJSON>();
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
    public List<SportsStandingsAPIJSON> value;
  };
  };
