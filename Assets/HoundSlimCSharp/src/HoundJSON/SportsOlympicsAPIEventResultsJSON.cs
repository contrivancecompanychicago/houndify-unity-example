/* file "SportsOlympicsAPIEventResultsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsOlympicsAPIEventResultsJSON : JSONBase
  {
    public class Typesport_event_resultsJSON : JSONBase
      {
        public class Typesport_eventJSON : JSONBase
          {
            public class TypetournamentJSON : JSONBase
              {
                public class TypesportJSON : JSONBase
                  {
                    private bool flagHasid;
                    private string storeid;
                    private bool flagHasname;
                    private string storename;
                    private List<string> extraKeys;
                    private List<JSONValue > extraValues;
                    private Dictionary<string, JSONValue > extraIndex;


                    private void  fromJSONid(JSONValue json_value, bool ignore_extras)
                      {
                        Debug.Assert(json_value != null);
                        JSONStringValue json_string = json_value.string_value();
                        if (json_string == null)
                            throw new Exception("The value for field id of TypesportJSON is not a string.");
                        setid(json_string.getData());
                      }


                    private void  fromJSONname(JSONValue json_value, bool ignore_extras)
                      {
                        Debug.Assert(json_value != null);
                        JSONStringValue json_string = json_value.string_value();
                        if (json_string == null)
                            throw new Exception("The value for field name of TypesportJSON is not a string.");
                        setname(json_string.getData());
                      }


                    public TypesportJSON()
                      {
                        flagHasid = false;
                        flagHasname = false;
                        extraKeys = new List<string>();
                    extraValues = new List<JSONValue >();
                    extraIndex = new Dictionary<string, JSONValue >();
                      }

                    public bool  hasid()
                      {
                        return flagHasid;
                      }

                    public string  getid()
                      {
                        Debug.Assert(flagHasid);
                        return storeid;
                      }

                    public bool  hasname()
                      {
                        return flagHasname;
                      }

                    public string  getname()
                      {
                        Debug.Assert(flagHasname);
                        return storename;
                      }


                    public virtual int extraTypesportComponentCount()
                      {
                        Debug.Assert(extraKeys.Count == extraValues.Count);
                        return extraKeys.Count;
                      }
                    public virtual string extraTypesportComponentKey(int component_num)
                      {
                        Debug.Assert(extraKeys.Count == extraValues.Count);
                        Debug.Assert(component_num < extraValues.Count);
                        return extraKeys[component_num];
                      }
                    public virtual JSONValue extraTypesportComponentValue(int component_num)
                      {
                        Debug.Assert(extraKeys.Count == extraValues.Count);
                        Debug.Assert(component_num < extraValues.Count);
                        return extraValues[component_num];
                      }
                    public virtual JSONValue extraTypesportLookup(string field_name)
                      {
                        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                        return result;
                      }

                    public void setid(string new_value)
                      {
                        flagHasid = true;
                        storeid = new_value;
                      }
                    public void unsetid()
                      {
                        flagHasid = false;
                      }
                    public void setname(string new_value)
                      {
                        flagHasname = true;
                        storename = new_value;
                      }
                    public void unsetname()
                      {
                        flagHasname = false;
                      }

                    public virtual void extraTypesportAppendPair(string key, JSONValue new_component)
                      {
                        Debug.Assert(key != null);
                        Debug.Assert(new_component != null);

                        Debug.Assert(extraKeys.Count == extraValues.Count);
                        extraKeys.Add(key);
                        extraValues.Add(new_component);
                        extraIndex.Add(key, new_component);
                      }
                    public virtual void extraTypesportSetField(string key, JSONValue new_component)
                      {
                        Debug.Assert(key != null);
                        Debug.Assert(new_component != null);

                        JSONValue old_field = extraTypesportLookup(key);
                        if (old_field == null)
                          {
                            extraTypesportAppendPair(key, new_component);
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
                        if (flagHasid)
                          {
                            handler.start_pair("id");
                            handler.string_value(storeid);
                          }
                        if (flagHasname)
                          {
                            handler.start_pair("name");
                            handler.string_value(storename);
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

                    public static TypesportJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                      {
                        TypesportJSON result;
                          {
                            HoldingGenerator generator = new HoldingGenerator("Type Typesport", ignore_extras);
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
                    public static TypesportJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
                  {
                    return from_json(json_value, ignore_extras, allow_incomplete, false);
                  }
                    public static TypesportJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                      {
                        TypesportJSON result;
                          {
                            HoldingGenerator generator = new HoldingGenerator("Type Typesport", ignore_extras);
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
                    public static TypesportJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
                  {
                    return from_json(json_value, ignore_extras, allow_incomplete, false);
                  }
                    public static TypesportJSON from_text(string text, bool ignore_extras)
                      {
                        TypesportJSON result;
                          {
                            HoldingGenerator generator = new HoldingGenerator("Type Typesport", ignore_extras);
                            JSONParse.parse_json_value(text, "Text for TypesportJSON", generator);
                            Debug.Assert(generator.have_value);
                            result = generator.value;
                          };
                        return result;
                      }
                    public static TypesportJSON from_file(TextReader fp, string file_name, bool ignore_extras)
                      {
                        TypesportJSON result;
                          {
                            HoldingGenerator generator = new HoldingGenerator("Type Typesport", ignore_extras);
                            JSONParse.parse_json_value(fp, file_name, generator);
                            Debug.Assert(generator.have_value);
                            result = generator.value;
                          };
                        return result;
                      }
                    public abstract class Generator : JSONObjectGenerator
                      {
                        private JSONHoldingStringGenerator fieldGeneratorid;
                        private JSONHoldingStringGenerator fieldGeneratorname;
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
                            TypesportJSON result = new TypesportJSON();
                            Debug.Assert(result != null);
                            finish(result);
                            int extra_count = unknownFieldGenerator.field_names.Count;
                            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                              {
                                result.extraTypesportAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                              }
                            unknownFieldGenerator.field_names.Clear();
                            unknownFieldGenerator.field_values.Clear();
                            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                            handle_result(result);
                          }
                        protected void finish(TypesportJSON result)
                          {
                            if (fieldGeneratorid.have_value)
                              {
                                result.setid(fieldGeneratorid.value);
                                fieldGeneratorid.have_value = false;
                              }
                            if (fieldGeneratorname.have_value)
                              {
                                result.setname(fieldGeneratorname.value);
                                fieldGeneratorname.have_value = false;
                              }
                          }
                        protected abstract void handle_result(TypesportJSON new_result);
                        protected virtual JSONHandler start_known_field(string field_name)
                          {
                            switch (field_name[0])
                              {
                                case 'i':
                                    if ((String.Compare(field_name, 1, "d", 0, 1, false) == 0) && (field_name.Length == 2))
                                        return fieldGeneratorid;
                                    break;
                                case 'n':
                                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                                        return fieldGeneratorname;
                                    break;
                                default:
                                    break;
                              }
                            return null;
                          }
                        public Generator(bool ignore_extras)
                          {
                            fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the Typesport class");
                            fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the Typesport class");
                            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                            set_what("the Typesport class");
                            allow_incomplete = false;
                            allow_unpolished = false;
                          }
                        public Generator()
                          {
                            fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the Typesport class");
                            fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the Typesport class");
                            unknownFieldGenerator = new UnknownFieldGenerator(false);
                            set_what("the Typesport class");
                            allow_incomplete = false;
                            allow_unpolished = false;
                          }

                        public override void reset()
                          {
                            fieldGeneratorid.reset();
                            fieldGeneratorname.reset();
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
                        protected override void handle_result(TypesportJSON  result)
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
                        public TypesportJSON value;
                      };
                    public class HoldingArrayGenerator : JSONArrayGenerator
                  {
                    protected class ElementHandler : Generator
                      {
                        private HoldingArrayGenerator top;

                        protected override void handle_result(TypesportJSON  result)
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
                    protected virtual void handle_result(List<TypesportJSON> result)

                      {
                      }

                    public HoldingArrayGenerator(string what, bool ignore_extras)
                      {
                        element_handler = new ElementHandler(this, ignore_extras);
                        have_value = false;
                        value = new List<TypesportJSON>();
                        base.set_what(what);
                      }
                    public HoldingArrayGenerator(bool ignore_extras)
                      {
                        element_handler = new ElementHandler(this, ignore_extras);
                        value = new List<TypesportJSON>();
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
                    public List<TypesportJSON> value;
                  };
                  };
                public class TypecategoryJSON : JSONBase
                  {
                    private bool flagHasid;
                    private string storeid;
                    private bool flagHasname;
                    private string storename;
                    private List<string> extraKeys;
                    private List<JSONValue > extraValues;
                    private Dictionary<string, JSONValue > extraIndex;


                    private void  fromJSONid(JSONValue json_value, bool ignore_extras)
                      {
                        Debug.Assert(json_value != null);
                        JSONStringValue json_string = json_value.string_value();
                        if (json_string == null)
                            throw new Exception("The value for field id of TypecategoryJSON is not a string.");
                        setid(json_string.getData());
                      }


                    private void  fromJSONname(JSONValue json_value, bool ignore_extras)
                      {
                        Debug.Assert(json_value != null);
                        JSONStringValue json_string = json_value.string_value();
                        if (json_string == null)
                            throw new Exception("The value for field name of TypecategoryJSON is not a string.");
                        setname(json_string.getData());
                      }


                    public TypecategoryJSON()
                      {
                        flagHasid = false;
                        flagHasname = false;
                        extraKeys = new List<string>();
                    extraValues = new List<JSONValue >();
                    extraIndex = new Dictionary<string, JSONValue >();
                      }

                    public bool  hasid()
                      {
                        return flagHasid;
                      }

                    public string  getid()
                      {
                        Debug.Assert(flagHasid);
                        return storeid;
                      }

                    public bool  hasname()
                      {
                        return flagHasname;
                      }

                    public string  getname()
                      {
                        Debug.Assert(flagHasname);
                        return storename;
                      }


                    public virtual int extraTypecategoryComponentCount()
                      {
                        Debug.Assert(extraKeys.Count == extraValues.Count);
                        return extraKeys.Count;
                      }
                    public virtual string extraTypecategoryComponentKey(int component_num)
                      {
                        Debug.Assert(extraKeys.Count == extraValues.Count);
                        Debug.Assert(component_num < extraValues.Count);
                        return extraKeys[component_num];
                      }
                    public virtual JSONValue extraTypecategoryComponentValue(int component_num)
                      {
                        Debug.Assert(extraKeys.Count == extraValues.Count);
                        Debug.Assert(component_num < extraValues.Count);
                        return extraValues[component_num];
                      }
                    public virtual JSONValue extraTypecategoryLookup(string field_name)
                      {
                        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                        return result;
                      }

                    public void setid(string new_value)
                      {
                        flagHasid = true;
                        storeid = new_value;
                      }
                    public void unsetid()
                      {
                        flagHasid = false;
                      }
                    public void setname(string new_value)
                      {
                        flagHasname = true;
                        storename = new_value;
                      }
                    public void unsetname()
                      {
                        flagHasname = false;
                      }

                    public virtual void extraTypecategoryAppendPair(string key, JSONValue new_component)
                      {
                        Debug.Assert(key != null);
                        Debug.Assert(new_component != null);

                        Debug.Assert(extraKeys.Count == extraValues.Count);
                        extraKeys.Add(key);
                        extraValues.Add(new_component);
                        extraIndex.Add(key, new_component);
                      }
                    public virtual void extraTypecategorySetField(string key, JSONValue new_component)
                      {
                        Debug.Assert(key != null);
                        Debug.Assert(new_component != null);

                        JSONValue old_field = extraTypecategoryLookup(key);
                        if (old_field == null)
                          {
                            extraTypecategoryAppendPair(key, new_component);
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
                        if (flagHasid)
                          {
                            handler.start_pair("id");
                            handler.string_value(storeid);
                          }
                        if (flagHasname)
                          {
                            handler.start_pair("name");
                            handler.string_value(storename);
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

                    public static TypecategoryJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                      {
                        TypecategoryJSON result;
                          {
                            HoldingGenerator generator = new HoldingGenerator("Type Typecategory", ignore_extras);
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
                    public static TypecategoryJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
                  {
                    return from_json(json_value, ignore_extras, allow_incomplete, false);
                  }
                    public static TypecategoryJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                      {
                        TypecategoryJSON result;
                          {
                            HoldingGenerator generator = new HoldingGenerator("Type Typecategory", ignore_extras);
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
                    public static TypecategoryJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
                  {
                    return from_json(json_value, ignore_extras, allow_incomplete, false);
                  }
                    public static TypecategoryJSON from_text(string text, bool ignore_extras)
                      {
                        TypecategoryJSON result;
                          {
                            HoldingGenerator generator = new HoldingGenerator("Type Typecategory", ignore_extras);
                            JSONParse.parse_json_value(text, "Text for TypecategoryJSON", generator);
                            Debug.Assert(generator.have_value);
                            result = generator.value;
                          };
                        return result;
                      }
                    public static TypecategoryJSON from_file(TextReader fp, string file_name, bool ignore_extras)
                      {
                        TypecategoryJSON result;
                          {
                            HoldingGenerator generator = new HoldingGenerator("Type Typecategory", ignore_extras);
                            JSONParse.parse_json_value(fp, file_name, generator);
                            Debug.Assert(generator.have_value);
                            result = generator.value;
                          };
                        return result;
                      }
                    public abstract class Generator : JSONObjectGenerator
                      {
                        private JSONHoldingStringGenerator fieldGeneratorid;
                        private JSONHoldingStringGenerator fieldGeneratorname;
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
                            TypecategoryJSON result = new TypecategoryJSON();
                            Debug.Assert(result != null);
                            finish(result);
                            int extra_count = unknownFieldGenerator.field_names.Count;
                            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                              {
                                result.extraTypecategoryAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                              }
                            unknownFieldGenerator.field_names.Clear();
                            unknownFieldGenerator.field_values.Clear();
                            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                            handle_result(result);
                          }
                        protected void finish(TypecategoryJSON result)
                          {
                            if (fieldGeneratorid.have_value)
                              {
                                result.setid(fieldGeneratorid.value);
                                fieldGeneratorid.have_value = false;
                              }
                            if (fieldGeneratorname.have_value)
                              {
                                result.setname(fieldGeneratorname.value);
                                fieldGeneratorname.have_value = false;
                              }
                          }
                        protected abstract void handle_result(TypecategoryJSON new_result);
                        protected virtual JSONHandler start_known_field(string field_name)
                          {
                            switch (field_name[0])
                              {
                                case 'i':
                                    if ((String.Compare(field_name, 1, "d", 0, 1, false) == 0) && (field_name.Length == 2))
                                        return fieldGeneratorid;
                                    break;
                                case 'n':
                                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                                        return fieldGeneratorname;
                                    break;
                                default:
                                    break;
                              }
                            return null;
                          }
                        public Generator(bool ignore_extras)
                          {
                            fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the Typecategory class");
                            fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the Typecategory class");
                            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                            set_what("the Typecategory class");
                            allow_incomplete = false;
                            allow_unpolished = false;
                          }
                        public Generator()
                          {
                            fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the Typecategory class");
                            fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the Typecategory class");
                            unknownFieldGenerator = new UnknownFieldGenerator(false);
                            set_what("the Typecategory class");
                            allow_incomplete = false;
                            allow_unpolished = false;
                          }

                        public override void reset()
                          {
                            fieldGeneratorid.reset();
                            fieldGeneratorname.reset();
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
                        protected override void handle_result(TypecategoryJSON  result)
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
                        public TypecategoryJSON value;
                      };
                    public class HoldingArrayGenerator : JSONArrayGenerator
                  {
                    protected class ElementHandler : Generator
                      {
                        private HoldingArrayGenerator top;

                        protected override void handle_result(TypecategoryJSON  result)
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
                    protected virtual void handle_result(List<TypecategoryJSON> result)

                      {
                      }

                    public HoldingArrayGenerator(string what, bool ignore_extras)
                      {
                        element_handler = new ElementHandler(this, ignore_extras);
                        have_value = false;
                        value = new List<TypecategoryJSON>();
                        base.set_what(what);
                      }
                    public HoldingArrayGenerator(bool ignore_extras)
                      {
                        element_handler = new ElementHandler(this, ignore_extras);
                        value = new List<TypecategoryJSON>();
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
                    public List<TypecategoryJSON> value;
                  };
                  };
                private bool flagHassport;
                private TypesportJSON  storesport;
                private bool flagHascategory;
                private TypecategoryJSON  storecategory;
                private bool flagHasid;
                private string storeid;
                private List<string> extraKeys;
                private List<JSONValue > extraValues;
                private Dictionary<string, JSONValue > extraIndex;


                private void  fromJSONsport(JSONValue json_value, bool ignore_extras)
                  {
                    Debug.Assert(json_value != null);
                    TypesportJSON convert_classy = TypesportJSON.from_json(json_value, ignore_extras, true);
                    setsport(convert_classy);
                  }


                private void  fromJSONcategory(JSONValue json_value, bool ignore_extras)
                  {
                    Debug.Assert(json_value != null);
                    TypecategoryJSON convert_classy = TypecategoryJSON.from_json(json_value, ignore_extras, true);
                    setcategory(convert_classy);
                  }


                private void  fromJSONid(JSONValue json_value, bool ignore_extras)
                  {
                    Debug.Assert(json_value != null);
                    JSONStringValue json_string = json_value.string_value();
                    if (json_string == null)
                        throw new Exception("The value for field id of TypetournamentJSON is not a string.");
                    setid(json_string.getData());
                  }


                public TypetournamentJSON()
                  {
                    flagHassport = false;
                    flagHascategory = false;
                    flagHasid = false;
                    extraKeys = new List<string>();
                extraValues = new List<JSONValue >();
                extraIndex = new Dictionary<string, JSONValue >();
                  }

                public bool  hassport()
                  {
                    return flagHassport;
                  }

                public TypesportJSON   getsport()
                  {
                    Debug.Assert(flagHassport);
                    return storesport;
                  }

                public bool  hascategory()
                  {
                    return flagHascategory;
                  }

                public TypecategoryJSON   getcategory()
                  {
                    Debug.Assert(flagHascategory);
                    return storecategory;
                  }

                public bool  hasid()
                  {
                    return flagHasid;
                  }

                public string  getid()
                  {
                    Debug.Assert(flagHasid);
                    return storeid;
                  }


                public virtual int extraTypetournamentComponentCount()
                  {
                    Debug.Assert(extraKeys.Count == extraValues.Count);
                    return extraKeys.Count;
                  }
                public virtual string extraTypetournamentComponentKey(int component_num)
                  {
                    Debug.Assert(extraKeys.Count == extraValues.Count);
                    Debug.Assert(component_num < extraValues.Count);
                    return extraKeys[component_num];
                  }
                public virtual JSONValue extraTypetournamentComponentValue(int component_num)
                  {
                    Debug.Assert(extraKeys.Count == extraValues.Count);
                    Debug.Assert(component_num < extraValues.Count);
                    return extraValues[component_num];
                  }
                public virtual JSONValue extraTypetournamentLookup(string field_name)
                  {
                    JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                    return result;
                  }

                public void setsport(TypesportJSON  new_value)
                  {
                    if (flagHassport)
                      {
                      }
                    flagHassport = true;
                    storesport = new_value;
                  }
                public void unsetsport()
                  {
                    if (flagHassport)
                      {
                      }
                    flagHassport = false;
                  }
                public void setcategory(TypecategoryJSON  new_value)
                  {
                    if (flagHascategory)
                      {
                      }
                    flagHascategory = true;
                    storecategory = new_value;
                  }
                public void unsetcategory()
                  {
                    if (flagHascategory)
                      {
                      }
                    flagHascategory = false;
                  }
                public void setid(string new_value)
                  {
                    flagHasid = true;
                    storeid = new_value;
                  }
                public void unsetid()
                  {
                    flagHasid = false;
                  }

                public virtual void extraTypetournamentAppendPair(string key, JSONValue new_component)
                  {
                    Debug.Assert(key != null);
                    Debug.Assert(new_component != null);

                    Debug.Assert(extraKeys.Count == extraValues.Count);
                    extraKeys.Add(key);
                    extraValues.Add(new_component);
                    extraIndex.Add(key, new_component);
                  }
                public virtual void extraTypetournamentSetField(string key, JSONValue new_component)
                  {
                    Debug.Assert(key != null);
                    Debug.Assert(new_component != null);

                    JSONValue old_field = extraTypetournamentLookup(key);
                    if (old_field == null)
                      {
                        extraTypetournamentAppendPair(key, new_component);
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
                    if (flagHassport)
                      {
                        handler.start_pair("sport");
                        if (partial_allowed)
                            storesport.write_partial_as_json(handler);
                        else
                            storesport.write_as_json(handler);
                      }
                    if (flagHascategory)
                      {
                        handler.start_pair("category");
                        if (partial_allowed)
                            storecategory.write_partial_as_json(handler);
                        else
                            storecategory.write_as_json(handler);
                      }
                    if (flagHasid)
                      {
                        handler.start_pair("id");
                        handler.string_value(storeid);
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

                public static TypetournamentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                  {
                    TypetournamentJSON result;
                      {
                        HoldingGenerator generator = new HoldingGenerator("Type Typetournament", ignore_extras);
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
                public static TypetournamentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
              {
                return from_json(json_value, ignore_extras, allow_incomplete, false);
              }
                public static TypetournamentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                  {
                    TypetournamentJSON result;
                      {
                        HoldingGenerator generator = new HoldingGenerator("Type Typetournament", ignore_extras);
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
                public static TypetournamentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
              {
                return from_json(json_value, ignore_extras, allow_incomplete, false);
              }
                public static TypetournamentJSON from_text(string text, bool ignore_extras)
                  {
                    TypetournamentJSON result;
                      {
                        HoldingGenerator generator = new HoldingGenerator("Type Typetournament", ignore_extras);
                        JSONParse.parse_json_value(text, "Text for TypetournamentJSON", generator);
                        Debug.Assert(generator.have_value);
                        result = generator.value;
                      };
                    return result;
                  }
                public static TypetournamentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
                  {
                    TypetournamentJSON result;
                      {
                        HoldingGenerator generator = new HoldingGenerator("Type Typetournament", ignore_extras);
                        JSONParse.parse_json_value(fp, file_name, generator);
                        Debug.Assert(generator.have_value);
                        result = generator.value;
                      };
                    return result;
                  }
                public abstract class Generator : JSONObjectGenerator
                  {
                    private TypesportJSON.HoldingGenerator fieldGeneratorsport;
                    private TypecategoryJSON.HoldingGenerator fieldGeneratorcategory;
                    private JSONHoldingStringGenerator fieldGeneratorid;
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
                        TypetournamentJSON result = new TypetournamentJSON();
                        Debug.Assert(result != null);
                        finish(result);
                        int extra_count = unknownFieldGenerator.field_names.Count;
                        Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                        for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                          {
                            result.extraTypetournamentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                          }
                        unknownFieldGenerator.field_names.Clear();
                        unknownFieldGenerator.field_values.Clear();
                        unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                        handle_result(result);
                      }
                    protected void finish(TypetournamentJSON result)
                      {
                        if (fieldGeneratorsport.have_value)
                          {
                            result.setsport(fieldGeneratorsport.value);
                            fieldGeneratorsport.have_value = false;
                          }
                        if (fieldGeneratorcategory.have_value)
                          {
                            result.setcategory(fieldGeneratorcategory.value);
                            fieldGeneratorcategory.have_value = false;
                          }
                        if (fieldGeneratorid.have_value)
                          {
                            result.setid(fieldGeneratorid.value);
                            fieldGeneratorid.have_value = false;
                          }
                      }
                    protected abstract void handle_result(TypetournamentJSON new_result);
                    protected virtual JSONHandler start_known_field(string field_name)
                      {
                        switch (field_name[0])
                          {
                            case 'c':
                                if ((String.Compare(field_name, 1, "ategory", 0, 7, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorcategory;
                                break;
                            case 'i':
                                if ((String.Compare(field_name, 1, "d", 0, 1, false) == 0) && (field_name.Length == 2))
                                    return fieldGeneratorid;
                                break;
                            case 's':
                                if ((String.Compare(field_name, 1, "port", 0, 4, false) == 0) && (field_name.Length == 5))
                                    return fieldGeneratorsport;
                                break;
                            default:
                                break;
                          }
                        return null;
                      }
                    public Generator(bool ignore_extras)
                      {
                        fieldGeneratorsport = new TypesportJSON.HoldingGenerator("field \"sport\" of the Typetournament class", ignore_extras);
                        fieldGeneratorcategory = new TypecategoryJSON.HoldingGenerator("field \"category\" of the Typetournament class", ignore_extras);
                        fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the Typetournament class");
                        unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                        set_what("the Typetournament class");
                        allow_incomplete = false;
                        allow_unpolished = false;
                      }
                    public Generator()
                      {
                        fieldGeneratorsport = new TypesportJSON.HoldingGenerator("field \"sport\" of the Typetournament class", false);
                        fieldGeneratorcategory = new TypecategoryJSON.HoldingGenerator("field \"category\" of the Typetournament class", false);
                        fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the Typetournament class");
                        unknownFieldGenerator = new UnknownFieldGenerator(false);
                        set_what("the Typetournament class");
                        allow_incomplete = false;
                        allow_unpolished = false;
                      }

                    public override void reset()
                      {
                        fieldGeneratorsport.reset();
                        fieldGeneratorcategory.reset();
                        fieldGeneratorid.reset();
                        base.reset();
                        unknownFieldGenerator.reset();
                      }
                    public void set_allow_incomplete(bool new_allow_incomplete)
                      {
                        allow_incomplete = new_allow_incomplete;
                        fieldGeneratorsport.set_allow_incomplete(new_allow_incomplete);
                        fieldGeneratorcategory.set_allow_incomplete(new_allow_incomplete);
                      }
                    public void set_allow_unpolished(bool new_allow_unpolished)
                      {
                        allow_unpolished = new_allow_unpolished;
                        fieldGeneratorsport.set_allow_unpolished(new_allow_unpolished);
                        fieldGeneratorcategory.set_allow_unpolished(new_allow_unpolished);
                      }
                  };
                public class HoldingGenerator : Generator
                  {
                    protected override void handle_result(TypetournamentJSON  result)
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
                    public TypetournamentJSON value;
                  };
                public class HoldingArrayGenerator : JSONArrayGenerator
              {
                protected class ElementHandler : Generator
                  {
                    private HoldingArrayGenerator top;

                    protected override void handle_result(TypetournamentJSON  result)
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
                protected virtual void handle_result(List<TypetournamentJSON> result)

                  {
                  }

                public HoldingArrayGenerator(string what, bool ignore_extras)
                  {
                    element_handler = new ElementHandler(this, ignore_extras);
                    have_value = false;
                    value = new List<TypetournamentJSON>();
                    base.set_what(what);
                  }
                public HoldingArrayGenerator(bool ignore_extras)
                  {
                    element_handler = new ElementHandler(this, ignore_extras);
                    value = new List<TypetournamentJSON>();
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
                public List<TypetournamentJSON> value;
              };
              };
            private bool flagHasid;
            private string storeid;
            private bool flagHasname;
            private string storename;
            private bool flagHasscheduled;
            private string storescheduled;
            private bool flagHastournament;
            private TypetournamentJSON  storetournament;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONid(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field id of Typesport_eventJSON is not a string.");
                setid(json_string.getData());
              }


            private void  fromJSONname(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field name of Typesport_eventJSON is not a string.");
                setname(json_string.getData());
              }


            private void  fromJSONscheduled(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field scheduled of Typesport_eventJSON is not a string.");
                setscheduled(json_string.getData());
              }


            private void  fromJSONtournament(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                TypetournamentJSON convert_classy = TypetournamentJSON.from_json(json_value, ignore_extras, true);
                settournament(convert_classy);
              }


            public Typesport_eventJSON()
              {
                flagHasid = false;
                flagHasname = false;
                flagHasscheduled = false;
                flagHastournament = false;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasid()
              {
                return flagHasid;
              }

            public string  getid()
              {
                Debug.Assert(flagHasid);
                return storeid;
              }

            public bool  hasname()
              {
                return flagHasname;
              }

            public string  getname()
              {
                Debug.Assert(flagHasname);
                return storename;
              }

            public bool  hasscheduled()
              {
                return flagHasscheduled;
              }

            public string  getscheduled()
              {
                Debug.Assert(flagHasscheduled);
                return storescheduled;
              }

            public bool  hastournament()
              {
                return flagHastournament;
              }

            public TypetournamentJSON   gettournament()
              {
                Debug.Assert(flagHastournament);
                return storetournament;
              }


            public virtual int extraTypesport_eventComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypesport_eventComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypesport_eventComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypesport_eventLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setid(string new_value)
              {
                flagHasid = true;
                storeid = new_value;
              }
            public void unsetid()
              {
                flagHasid = false;
              }
            public void setname(string new_value)
              {
                flagHasname = true;
                storename = new_value;
              }
            public void unsetname()
              {
                flagHasname = false;
              }
            public void setscheduled(string new_value)
              {
                flagHasscheduled = true;
                storescheduled = new_value;
              }
            public void unsetscheduled()
              {
                flagHasscheduled = false;
              }
            public void settournament(TypetournamentJSON  new_value)
              {
                if (flagHastournament)
                  {
                  }
                flagHastournament = true;
                storetournament = new_value;
              }
            public void unsettournament()
              {
                if (flagHastournament)
                  {
                  }
                flagHastournament = false;
              }

            public virtual void extraTypesport_eventAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypesport_eventSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypesport_eventLookup(key);
                if (old_field == null)
                  {
                    extraTypesport_eventAppendPair(key, new_component);
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
                if (flagHasid)
                  {
                    handler.start_pair("id");
                    handler.string_value(storeid);
                  }
                if (flagHasname)
                  {
                    handler.start_pair("name");
                    handler.string_value(storename);
                  }
                if (flagHasscheduled)
                  {
                    handler.start_pair("scheduled");
                    handler.string_value(storescheduled);
                  }
                if (flagHastournament)
                  {
                    handler.start_pair("tournament");
                    if (partial_allowed)
                        storetournament.write_partial_as_json(handler);
                    else
                        storetournament.write_as_json(handler);
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

            public static Typesport_eventJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                Typesport_eventJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typesport_event", ignore_extras);
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
            public static Typesport_eventJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static Typesport_eventJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                Typesport_eventJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typesport_event", ignore_extras);
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
            public static Typesport_eventJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static Typesport_eventJSON from_text(string text, bool ignore_extras)
              {
                Typesport_eventJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typesport_event", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for Typesport_eventJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static Typesport_eventJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                Typesport_eventJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typesport_event", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private JSONHoldingStringGenerator fieldGeneratorid;
                private JSONHoldingStringGenerator fieldGeneratorname;
                private JSONHoldingStringGenerator fieldGeneratorscheduled;
                private TypetournamentJSON.HoldingGenerator fieldGeneratortournament;
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
                    Typesport_eventJSON result = new Typesport_eventJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypesport_eventAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(Typesport_eventJSON result)
                  {
                    if (fieldGeneratorid.have_value)
                      {
                        result.setid(fieldGeneratorid.value);
                        fieldGeneratorid.have_value = false;
                      }
                    if (fieldGeneratorname.have_value)
                      {
                        result.setname(fieldGeneratorname.value);
                        fieldGeneratorname.have_value = false;
                      }
                    if (fieldGeneratorscheduled.have_value)
                      {
                        result.setscheduled(fieldGeneratorscheduled.value);
                        fieldGeneratorscheduled.have_value = false;
                      }
                    if (fieldGeneratortournament.have_value)
                      {
                        result.settournament(fieldGeneratortournament.value);
                        fieldGeneratortournament.have_value = false;
                      }
                  }
                protected abstract void handle_result(Typesport_eventJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    switch (field_name[0])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 1, "d", 0, 1, false) == 0) && (field_name.Length == 2))
                                return fieldGeneratorid;
                            break;
                        case 'n':
                            if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorname;
                            break;
                        case 's':
                            if ((String.Compare(field_name, 1, "cheduled", 0, 8, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorscheduled;
                            break;
                        case 't':
                            if ((String.Compare(field_name, 1, "ournament", 0, 9, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratortournament;
                            break;
                        default:
                            break;
                      }
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the Typesport_event class");
                    fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the Typesport_event class");
                    fieldGeneratorscheduled = new JSONHoldingStringGenerator("field \"scheduled\" of the Typesport_event class");
                    fieldGeneratortournament = new TypetournamentJSON.HoldingGenerator("field \"tournament\" of the Typesport_event class", ignore_extras);
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the Typesport_event class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the Typesport_event class");
                    fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the Typesport_event class");
                    fieldGeneratorscheduled = new JSONHoldingStringGenerator("field \"scheduled\" of the Typesport_event class");
                    fieldGeneratortournament = new TypetournamentJSON.HoldingGenerator("field \"tournament\" of the Typesport_event class", false);
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the Typesport_event class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorid.reset();
                    fieldGeneratorname.reset();
                    fieldGeneratorscheduled.reset();
                    fieldGeneratortournament.reset();
                    base.reset();
                    unknownFieldGenerator.reset();
                  }
                public void set_allow_incomplete(bool new_allow_incomplete)
                  {
                    allow_incomplete = new_allow_incomplete;
                    fieldGeneratortournament.set_allow_incomplete(new_allow_incomplete);
                  }
                public void set_allow_unpolished(bool new_allow_unpolished)
                  {
                    allow_unpolished = new_allow_unpolished;
                    fieldGeneratortournament.set_allow_unpolished(new_allow_unpolished);
                  }
              };
            public class HoldingGenerator : Generator
              {
                protected override void handle_result(Typesport_eventJSON  result)
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
                public Typesport_eventJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(Typesport_eventJSON  result)
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
            protected virtual void handle_result(List<Typesport_eventJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<Typesport_eventJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<Typesport_eventJSON>();
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
            public List<Typesport_eventJSON> value;
          };
          };
        public class TyperesultsJSON : JSONBase
          {
            public class TypecompetitorJSON : JSONBase
              {
                public class TypeathleteJSON : JSONBase
                  {
                    private bool flagHasid;
                    private string storeid;
                    private bool flagHasname;
                    private string storename;
                    private bool flagHasnationality;
                    private string storenationality;
                    private bool flagHasioc_code;
                    private string storeioc_code;
                    private bool flagHasgender;
                    private string storegender;
                    private List<string> extraKeys;
                    private List<JSONValue > extraValues;
                    private Dictionary<string, JSONValue > extraIndex;


                    private void  fromJSONid(JSONValue json_value, bool ignore_extras)
                      {
                        Debug.Assert(json_value != null);
                        JSONStringValue json_string = json_value.string_value();
                        if (json_string == null)
                            throw new Exception("The value for field id of TypeathleteJSON is not a string.");
                        setid(json_string.getData());
                      }


                    private void  fromJSONname(JSONValue json_value, bool ignore_extras)
                      {
                        Debug.Assert(json_value != null);
                        JSONStringValue json_string = json_value.string_value();
                        if (json_string == null)
                            throw new Exception("The value for field name of TypeathleteJSON is not a string.");
                        setname(json_string.getData());
                      }


                    private void  fromJSONnationality(JSONValue json_value, bool ignore_extras)
                      {
                        Debug.Assert(json_value != null);
                        JSONStringValue json_string = json_value.string_value();
                        if (json_string == null)
                            throw new Exception("The value for field nationality of TypeathleteJSON is not a string.");
                        setnationality(json_string.getData());
                      }


                    private void  fromJSONioc_code(JSONValue json_value, bool ignore_extras)
                      {
                        Debug.Assert(json_value != null);
                        JSONStringValue json_string = json_value.string_value();
                        if (json_string == null)
                            throw new Exception("The value for field ioc_code of TypeathleteJSON is not a string.");
                        setioc_code(json_string.getData());
                      }


                    private void  fromJSONgender(JSONValue json_value, bool ignore_extras)
                      {
                        Debug.Assert(json_value != null);
                        JSONStringValue json_string = json_value.string_value();
                        if (json_string == null)
                            throw new Exception("The value for field gender of TypeathleteJSON is not a string.");
                        setgender(json_string.getData());
                      }


                    public TypeathleteJSON()
                      {
                        flagHasid = false;
                        flagHasname = false;
                        flagHasnationality = false;
                        flagHasioc_code = false;
                        flagHasgender = false;
                        extraKeys = new List<string>();
                    extraValues = new List<JSONValue >();
                    extraIndex = new Dictionary<string, JSONValue >();
                      }

                    public bool  hasid()
                      {
                        return flagHasid;
                      }

                    public string  getid()
                      {
                        Debug.Assert(flagHasid);
                        return storeid;
                      }

                    public bool  hasname()
                      {
                        return flagHasname;
                      }

                    public string  getname()
                      {
                        Debug.Assert(flagHasname);
                        return storename;
                      }

                    public bool  hasnationality()
                      {
                        return flagHasnationality;
                      }

                    public string  getnationality()
                      {
                        Debug.Assert(flagHasnationality);
                        return storenationality;
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

                    public bool  hasgender()
                      {
                        return flagHasgender;
                      }

                    public string  getgender()
                      {
                        Debug.Assert(flagHasgender);
                        return storegender;
                      }


                    public virtual int extraTypeathleteComponentCount()
                      {
                        Debug.Assert(extraKeys.Count == extraValues.Count);
                        return extraKeys.Count;
                      }
                    public virtual string extraTypeathleteComponentKey(int component_num)
                      {
                        Debug.Assert(extraKeys.Count == extraValues.Count);
                        Debug.Assert(component_num < extraValues.Count);
                        return extraKeys[component_num];
                      }
                    public virtual JSONValue extraTypeathleteComponentValue(int component_num)
                      {
                        Debug.Assert(extraKeys.Count == extraValues.Count);
                        Debug.Assert(component_num < extraValues.Count);
                        return extraValues[component_num];
                      }
                    public virtual JSONValue extraTypeathleteLookup(string field_name)
                      {
                        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                        return result;
                      }

                    public void setid(string new_value)
                      {
                        flagHasid = true;
                        storeid = new_value;
                      }
                    public void unsetid()
                      {
                        flagHasid = false;
                      }
                    public void setname(string new_value)
                      {
                        flagHasname = true;
                        storename = new_value;
                      }
                    public void unsetname()
                      {
                        flagHasname = false;
                      }
                    public void setnationality(string new_value)
                      {
                        flagHasnationality = true;
                        storenationality = new_value;
                      }
                    public void unsetnationality()
                      {
                        flagHasnationality = false;
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
                    public void setgender(string new_value)
                      {
                        flagHasgender = true;
                        storegender = new_value;
                      }
                    public void unsetgender()
                      {
                        flagHasgender = false;
                      }

                    public virtual void extraTypeathleteAppendPair(string key, JSONValue new_component)
                      {
                        Debug.Assert(key != null);
                        Debug.Assert(new_component != null);

                        Debug.Assert(extraKeys.Count == extraValues.Count);
                        extraKeys.Add(key);
                        extraValues.Add(new_component);
                        extraIndex.Add(key, new_component);
                      }
                    public virtual void extraTypeathleteSetField(string key, JSONValue new_component)
                      {
                        Debug.Assert(key != null);
                        Debug.Assert(new_component != null);

                        JSONValue old_field = extraTypeathleteLookup(key);
                        if (old_field == null)
                          {
                            extraTypeathleteAppendPair(key, new_component);
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
                        if (flagHasid)
                          {
                            handler.start_pair("id");
                            handler.string_value(storeid);
                          }
                        if (flagHasname)
                          {
                            handler.start_pair("name");
                            handler.string_value(storename);
                          }
                        if (flagHasnationality)
                          {
                            handler.start_pair("nationality");
                            handler.string_value(storenationality);
                          }
                        if (flagHasioc_code)
                          {
                            handler.start_pair("ioc_code");
                            handler.string_value(storeioc_code);
                          }
                        if (flagHasgender)
                          {
                            handler.start_pair("gender");
                            handler.string_value(storegender);
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

                    public static TypeathleteJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                      {
                        TypeathleteJSON result;
                          {
                            HoldingGenerator generator = new HoldingGenerator("Type Typeathlete", ignore_extras);
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
                    public static TypeathleteJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
                  {
                    return from_json(json_value, ignore_extras, allow_incomplete, false);
                  }
                    public static TypeathleteJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                      {
                        TypeathleteJSON result;
                          {
                            HoldingGenerator generator = new HoldingGenerator("Type Typeathlete", ignore_extras);
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
                    public static TypeathleteJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
                  {
                    return from_json(json_value, ignore_extras, allow_incomplete, false);
                  }
                    public static TypeathleteJSON from_text(string text, bool ignore_extras)
                      {
                        TypeathleteJSON result;
                          {
                            HoldingGenerator generator = new HoldingGenerator("Type Typeathlete", ignore_extras);
                            JSONParse.parse_json_value(text, "Text for TypeathleteJSON", generator);
                            Debug.Assert(generator.have_value);
                            result = generator.value;
                          };
                        return result;
                      }
                    public static TypeathleteJSON from_file(TextReader fp, string file_name, bool ignore_extras)
                      {
                        TypeathleteJSON result;
                          {
                            HoldingGenerator generator = new HoldingGenerator("Type Typeathlete", ignore_extras);
                            JSONParse.parse_json_value(fp, file_name, generator);
                            Debug.Assert(generator.have_value);
                            result = generator.value;
                          };
                        return result;
                      }
                    public abstract class Generator : JSONObjectGenerator
                      {
                        private JSONHoldingStringGenerator fieldGeneratorid;
                        private JSONHoldingStringGenerator fieldGeneratorname;
                        private JSONHoldingStringGenerator fieldGeneratornationality;
                        private JSONHoldingStringGenerator fieldGeneratorioc_code;
                        private JSONHoldingStringGenerator fieldGeneratorgender;
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
                            TypeathleteJSON result = new TypeathleteJSON();
                            Debug.Assert(result != null);
                            finish(result);
                            int extra_count = unknownFieldGenerator.field_names.Count;
                            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                              {
                                result.extraTypeathleteAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                              }
                            unknownFieldGenerator.field_names.Clear();
                            unknownFieldGenerator.field_values.Clear();
                            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                            handle_result(result);
                          }
                        protected void finish(TypeathleteJSON result)
                          {
                            if (fieldGeneratorid.have_value)
                              {
                                result.setid(fieldGeneratorid.value);
                                fieldGeneratorid.have_value = false;
                              }
                            if (fieldGeneratorname.have_value)
                              {
                                result.setname(fieldGeneratorname.value);
                                fieldGeneratorname.have_value = false;
                              }
                            if (fieldGeneratornationality.have_value)
                              {
                                result.setnationality(fieldGeneratornationality.value);
                                fieldGeneratornationality.have_value = false;
                              }
                            if (fieldGeneratorioc_code.have_value)
                              {
                                result.setioc_code(fieldGeneratorioc_code.value);
                                fieldGeneratorioc_code.have_value = false;
                              }
                            if (fieldGeneratorgender.have_value)
                              {
                                result.setgender(fieldGeneratorgender.value);
                                fieldGeneratorgender.have_value = false;
                              }
                          }
                        protected abstract void handle_result(TypeathleteJSON new_result);
                        protected virtual JSONHandler start_known_field(string field_name)
                          {
                            switch (field_name[0])
                              {
                                case 'g':
                                    if ((String.Compare(field_name, 1, "ender", 0, 5, false) == 0) && (field_name.Length == 6))
                                        return fieldGeneratorgender;
                                    break;
                                case 'i':
                                    switch (field_name[1])
                                      {
                                        case 'd':
                                            if (field_name.Length == 2)
                                                return fieldGeneratorid;
                                            break;
                                        case 'o':
                                            if ((String.Compare(field_name, 2, "c_code", 0, 6, false) == 0) && (field_name.Length == 8))
                                                return fieldGeneratorioc_code;
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'n':
                                    if (String.Compare(field_name, 1, "a", 0, 1, false) == 0)
                                      {
                                        switch (field_name[2])
                                          {
                                            case 'm':
                                                if ((String.Compare(field_name, 3, "e", 0, 1, false) == 0) && (field_name.Length == 4))
                                                    return fieldGeneratorname;
                                                break;
                                            case 't':
                                                if ((String.Compare(field_name, 3, "ionality", 0, 8, false) == 0) && (field_name.Length == 11))
                                                    return fieldGeneratornationality;
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
                            fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the Typeathlete class");
                            fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the Typeathlete class");
                            fieldGeneratornationality = new JSONHoldingStringGenerator("field \"nationality\" of the Typeathlete class");
                            fieldGeneratorioc_code = new JSONHoldingStringGenerator("field \"ioc_code\" of the Typeathlete class");
                            fieldGeneratorgender = new JSONHoldingStringGenerator("field \"gender\" of the Typeathlete class");
                            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                            set_what("the Typeathlete class");
                            allow_incomplete = false;
                            allow_unpolished = false;
                          }
                        public Generator()
                          {
                            fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the Typeathlete class");
                            fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the Typeathlete class");
                            fieldGeneratornationality = new JSONHoldingStringGenerator("field \"nationality\" of the Typeathlete class");
                            fieldGeneratorioc_code = new JSONHoldingStringGenerator("field \"ioc_code\" of the Typeathlete class");
                            fieldGeneratorgender = new JSONHoldingStringGenerator("field \"gender\" of the Typeathlete class");
                            unknownFieldGenerator = new UnknownFieldGenerator(false);
                            set_what("the Typeathlete class");
                            allow_incomplete = false;
                            allow_unpolished = false;
                          }

                        public override void reset()
                          {
                            fieldGeneratorid.reset();
                            fieldGeneratorname.reset();
                            fieldGeneratornationality.reset();
                            fieldGeneratorioc_code.reset();
                            fieldGeneratorgender.reset();
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
                        protected override void handle_result(TypeathleteJSON  result)
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
                        public TypeathleteJSON value;
                      };
                    public class HoldingArrayGenerator : JSONArrayGenerator
                  {
                    protected class ElementHandler : Generator
                      {
                        private HoldingArrayGenerator top;

                        protected override void handle_result(TypeathleteJSON  result)
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
                    protected virtual void handle_result(List<TypeathleteJSON> result)

                      {
                      }

                    public HoldingArrayGenerator(string what, bool ignore_extras)
                      {
                        element_handler = new ElementHandler(this, ignore_extras);
                        have_value = false;
                        value = new List<TypeathleteJSON>();
                        base.set_what(what);
                      }
                    public HoldingArrayGenerator(bool ignore_extras)
                      {
                        element_handler = new ElementHandler(this, ignore_extras);
                        value = new List<TypeathleteJSON>();
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
                    public List<TypeathleteJSON> value;
                  };
                  };
                public class TypeathletesJSON : JSONBase
                  {
                    private bool flagHasid;
                    private string storeid;
                    private bool flagHasname;
                    private string storename;
                    private bool flagHasnationality;
                    private string storenationality;
                    private bool flagHasioc_code;
                    private string storeioc_code;
                    private bool flagHasgender;
                    private string storegender;
                    private List<string> extraKeys;
                    private List<JSONValue > extraValues;
                    private Dictionary<string, JSONValue > extraIndex;


                    private void  fromJSONid(JSONValue json_value, bool ignore_extras)
                      {
                        Debug.Assert(json_value != null);
                        JSONStringValue json_string = json_value.string_value();
                        if (json_string == null)
                            throw new Exception("The value for field id of TypeathletesJSON is not a string.");
                        setid(json_string.getData());
                      }


                    private void  fromJSONname(JSONValue json_value, bool ignore_extras)
                      {
                        Debug.Assert(json_value != null);
                        JSONStringValue json_string = json_value.string_value();
                        if (json_string == null)
                            throw new Exception("The value for field name of TypeathletesJSON is not a string.");
                        setname(json_string.getData());
                      }


                    private void  fromJSONnationality(JSONValue json_value, bool ignore_extras)
                      {
                        Debug.Assert(json_value != null);
                        JSONStringValue json_string = json_value.string_value();
                        if (json_string == null)
                            throw new Exception("The value for field nationality of TypeathletesJSON is not a string.");
                        setnationality(json_string.getData());
                      }


                    private void  fromJSONioc_code(JSONValue json_value, bool ignore_extras)
                      {
                        Debug.Assert(json_value != null);
                        JSONStringValue json_string = json_value.string_value();
                        if (json_string == null)
                            throw new Exception("The value for field ioc_code of TypeathletesJSON is not a string.");
                        setioc_code(json_string.getData());
                      }


                    private void  fromJSONgender(JSONValue json_value, bool ignore_extras)
                      {
                        Debug.Assert(json_value != null);
                        JSONStringValue json_string = json_value.string_value();
                        if (json_string == null)
                            throw new Exception("The value for field gender of TypeathletesJSON is not a string.");
                        setgender(json_string.getData());
                      }


                    public TypeathletesJSON()
                      {
                        flagHasid = false;
                        flagHasname = false;
                        flagHasnationality = false;
                        flagHasioc_code = false;
                        flagHasgender = false;
                        extraKeys = new List<string>();
                    extraValues = new List<JSONValue >();
                    extraIndex = new Dictionary<string, JSONValue >();
                      }

                    public bool  hasid()
                      {
                        return flagHasid;
                      }

                    public string  getid()
                      {
                        Debug.Assert(flagHasid);
                        return storeid;
                      }

                    public bool  hasname()
                      {
                        return flagHasname;
                      }

                    public string  getname()
                      {
                        Debug.Assert(flagHasname);
                        return storename;
                      }

                    public bool  hasnationality()
                      {
                        return flagHasnationality;
                      }

                    public string  getnationality()
                      {
                        Debug.Assert(flagHasnationality);
                        return storenationality;
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

                    public bool  hasgender()
                      {
                        return flagHasgender;
                      }

                    public string  getgender()
                      {
                        Debug.Assert(flagHasgender);
                        return storegender;
                      }


                    public virtual int extraTypeathletesComponentCount()
                      {
                        Debug.Assert(extraKeys.Count == extraValues.Count);
                        return extraKeys.Count;
                      }
                    public virtual string extraTypeathletesComponentKey(int component_num)
                      {
                        Debug.Assert(extraKeys.Count == extraValues.Count);
                        Debug.Assert(component_num < extraValues.Count);
                        return extraKeys[component_num];
                      }
                    public virtual JSONValue extraTypeathletesComponentValue(int component_num)
                      {
                        Debug.Assert(extraKeys.Count == extraValues.Count);
                        Debug.Assert(component_num < extraValues.Count);
                        return extraValues[component_num];
                      }
                    public virtual JSONValue extraTypeathletesLookup(string field_name)
                      {
                        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                        return result;
                      }

                    public void setid(string new_value)
                      {
                        flagHasid = true;
                        storeid = new_value;
                      }
                    public void unsetid()
                      {
                        flagHasid = false;
                      }
                    public void setname(string new_value)
                      {
                        flagHasname = true;
                        storename = new_value;
                      }
                    public void unsetname()
                      {
                        flagHasname = false;
                      }
                    public void setnationality(string new_value)
                      {
                        flagHasnationality = true;
                        storenationality = new_value;
                      }
                    public void unsetnationality()
                      {
                        flagHasnationality = false;
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
                    public void setgender(string new_value)
                      {
                        flagHasgender = true;
                        storegender = new_value;
                      }
                    public void unsetgender()
                      {
                        flagHasgender = false;
                      }

                    public virtual void extraTypeathletesAppendPair(string key, JSONValue new_component)
                      {
                        Debug.Assert(key != null);
                        Debug.Assert(new_component != null);

                        Debug.Assert(extraKeys.Count == extraValues.Count);
                        extraKeys.Add(key);
                        extraValues.Add(new_component);
                        extraIndex.Add(key, new_component);
                      }
                    public virtual void extraTypeathletesSetField(string key, JSONValue new_component)
                      {
                        Debug.Assert(key != null);
                        Debug.Assert(new_component != null);

                        JSONValue old_field = extraTypeathletesLookup(key);
                        if (old_field == null)
                          {
                            extraTypeathletesAppendPair(key, new_component);
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
                        if (flagHasid)
                          {
                            handler.start_pair("id");
                            handler.string_value(storeid);
                          }
                        if (flagHasname)
                          {
                            handler.start_pair("name");
                            handler.string_value(storename);
                          }
                        if (flagHasnationality)
                          {
                            handler.start_pair("nationality");
                            handler.string_value(storenationality);
                          }
                        if (flagHasioc_code)
                          {
                            handler.start_pair("ioc_code");
                            handler.string_value(storeioc_code);
                          }
                        if (flagHasgender)
                          {
                            handler.start_pair("gender");
                            handler.string_value(storegender);
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

                    public static TypeathletesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                      {
                        TypeathletesJSON result;
                          {
                            HoldingGenerator generator = new HoldingGenerator("Type Typeathletes", ignore_extras);
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
                    public static TypeathletesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
                  {
                    return from_json(json_value, ignore_extras, allow_incomplete, false);
                  }
                    public static TypeathletesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                      {
                        TypeathletesJSON result;
                          {
                            HoldingGenerator generator = new HoldingGenerator("Type Typeathletes", ignore_extras);
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
                    public static TypeathletesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
                  {
                    return from_json(json_value, ignore_extras, allow_incomplete, false);
                  }
                    public static TypeathletesJSON from_text(string text, bool ignore_extras)
                      {
                        TypeathletesJSON result;
                          {
                            HoldingGenerator generator = new HoldingGenerator("Type Typeathletes", ignore_extras);
                            JSONParse.parse_json_value(text, "Text for TypeathletesJSON", generator);
                            Debug.Assert(generator.have_value);
                            result = generator.value;
                          };
                        return result;
                      }
                    public static TypeathletesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
                      {
                        TypeathletesJSON result;
                          {
                            HoldingGenerator generator = new HoldingGenerator("Type Typeathletes", ignore_extras);
                            JSONParse.parse_json_value(fp, file_name, generator);
                            Debug.Assert(generator.have_value);
                            result = generator.value;
                          };
                        return result;
                      }
                    public abstract class Generator : JSONObjectGenerator
                      {
                        private JSONHoldingStringGenerator fieldGeneratorid;
                        private JSONHoldingStringGenerator fieldGeneratorname;
                        private JSONHoldingStringGenerator fieldGeneratornationality;
                        private JSONHoldingStringGenerator fieldGeneratorioc_code;
                        private JSONHoldingStringGenerator fieldGeneratorgender;
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
                            TypeathletesJSON result = new TypeathletesJSON();
                            Debug.Assert(result != null);
                            finish(result);
                            int extra_count = unknownFieldGenerator.field_names.Count;
                            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                              {
                                result.extraTypeathletesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                              }
                            unknownFieldGenerator.field_names.Clear();
                            unknownFieldGenerator.field_values.Clear();
                            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                            handle_result(result);
                          }
                        protected void finish(TypeathletesJSON result)
                          {
                            if (fieldGeneratorid.have_value)
                              {
                                result.setid(fieldGeneratorid.value);
                                fieldGeneratorid.have_value = false;
                              }
                            if (fieldGeneratorname.have_value)
                              {
                                result.setname(fieldGeneratorname.value);
                                fieldGeneratorname.have_value = false;
                              }
                            if (fieldGeneratornationality.have_value)
                              {
                                result.setnationality(fieldGeneratornationality.value);
                                fieldGeneratornationality.have_value = false;
                              }
                            if (fieldGeneratorioc_code.have_value)
                              {
                                result.setioc_code(fieldGeneratorioc_code.value);
                                fieldGeneratorioc_code.have_value = false;
                              }
                            if (fieldGeneratorgender.have_value)
                              {
                                result.setgender(fieldGeneratorgender.value);
                                fieldGeneratorgender.have_value = false;
                              }
                          }
                        protected abstract void handle_result(TypeathletesJSON new_result);
                        protected virtual JSONHandler start_known_field(string field_name)
                          {
                            switch (field_name[0])
                              {
                                case 'g':
                                    if ((String.Compare(field_name, 1, "ender", 0, 5, false) == 0) && (field_name.Length == 6))
                                        return fieldGeneratorgender;
                                    break;
                                case 'i':
                                    switch (field_name[1])
                                      {
                                        case 'd':
                                            if (field_name.Length == 2)
                                                return fieldGeneratorid;
                                            break;
                                        case 'o':
                                            if ((String.Compare(field_name, 2, "c_code", 0, 6, false) == 0) && (field_name.Length == 8))
                                                return fieldGeneratorioc_code;
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'n':
                                    if (String.Compare(field_name, 1, "a", 0, 1, false) == 0)
                                      {
                                        switch (field_name[2])
                                          {
                                            case 'm':
                                                if ((String.Compare(field_name, 3, "e", 0, 1, false) == 0) && (field_name.Length == 4))
                                                    return fieldGeneratorname;
                                                break;
                                            case 't':
                                                if ((String.Compare(field_name, 3, "ionality", 0, 8, false) == 0) && (field_name.Length == 11))
                                                    return fieldGeneratornationality;
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
                            fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the Typeathletes class");
                            fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the Typeathletes class");
                            fieldGeneratornationality = new JSONHoldingStringGenerator("field \"nationality\" of the Typeathletes class");
                            fieldGeneratorioc_code = new JSONHoldingStringGenerator("field \"ioc_code\" of the Typeathletes class");
                            fieldGeneratorgender = new JSONHoldingStringGenerator("field \"gender\" of the Typeathletes class");
                            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                            set_what("the Typeathletes class");
                            allow_incomplete = false;
                            allow_unpolished = false;
                          }
                        public Generator()
                          {
                            fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the Typeathletes class");
                            fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the Typeathletes class");
                            fieldGeneratornationality = new JSONHoldingStringGenerator("field \"nationality\" of the Typeathletes class");
                            fieldGeneratorioc_code = new JSONHoldingStringGenerator("field \"ioc_code\" of the Typeathletes class");
                            fieldGeneratorgender = new JSONHoldingStringGenerator("field \"gender\" of the Typeathletes class");
                            unknownFieldGenerator = new UnknownFieldGenerator(false);
                            set_what("the Typeathletes class");
                            allow_incomplete = false;
                            allow_unpolished = false;
                          }

                        public override void reset()
                          {
                            fieldGeneratorid.reset();
                            fieldGeneratorname.reset();
                            fieldGeneratornationality.reset();
                            fieldGeneratorioc_code.reset();
                            fieldGeneratorgender.reset();
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
                        protected override void handle_result(TypeathletesJSON  result)
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
                        public TypeathletesJSON value;
                      };
                    public class HoldingArrayGenerator : JSONArrayGenerator
                  {
                    protected class ElementHandler : Generator
                      {
                        private HoldingArrayGenerator top;

                        protected override void handle_result(TypeathletesJSON  result)
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
                    protected virtual void handle_result(List<TypeathletesJSON> result)

                      {
                      }

                    public HoldingArrayGenerator(string what, bool ignore_extras)
                      {
                        element_handler = new ElementHandler(this, ignore_extras);
                        have_value = false;
                        value = new List<TypeathletesJSON>();
                        base.set_what(what);
                      }
                    public HoldingArrayGenerator(bool ignore_extras)
                      {
                        element_handler = new ElementHandler(this, ignore_extras);
                        value = new List<TypeathletesJSON>();
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
                    public List<TypeathletesJSON> value;
                  };
                  };
                private bool flagHasid;
                private string storeid;
                private bool flagHasname;
                private string storename;
                private bool flagHascountry_code;
                private string storecountry_code;
                private bool flagHasioc_code;
                private string storeioc_code;
                private bool flagHasathlete;
                private TypeathleteJSON  storeathlete;
                private bool flagHasathletes;
                private List< TypeathletesJSON  > storeathletes;
                private List<string> extraKeys;
                private List<JSONValue > extraValues;
                private Dictionary<string, JSONValue > extraIndex;


                private void  fromJSONid(JSONValue json_value, bool ignore_extras)
                  {
                    Debug.Assert(json_value != null);
                    JSONStringValue json_string = json_value.string_value();
                    if (json_string == null)
                        throw new Exception("The value for field id of TypecompetitorJSON is not a string.");
                    setid(json_string.getData());
                  }


                private void  fromJSONname(JSONValue json_value, bool ignore_extras)
                  {
                    Debug.Assert(json_value != null);
                    JSONStringValue json_string = json_value.string_value();
                    if (json_string == null)
                        throw new Exception("The value for field name of TypecompetitorJSON is not a string.");
                    setname(json_string.getData());
                  }


                private void  fromJSONcountry_code(JSONValue json_value, bool ignore_extras)
                  {
                    Debug.Assert(json_value != null);
                    JSONStringValue json_string = json_value.string_value();
                    if (json_string == null)
                        throw new Exception("The value for field country_code of TypecompetitorJSON is not a string.");
                    setcountry_code(json_string.getData());
                  }


                private void  fromJSONioc_code(JSONValue json_value, bool ignore_extras)
                  {
                    Debug.Assert(json_value != null);
                    JSONStringValue json_string = json_value.string_value();
                    if (json_string == null)
                        throw new Exception("The value for field ioc_code of TypecompetitorJSON is not a string.");
                    setioc_code(json_string.getData());
                  }


                private void  fromJSONathlete(JSONValue json_value, bool ignore_extras)
                  {
                    Debug.Assert(json_value != null);
                    TypeathleteJSON convert_classy = TypeathleteJSON.from_json(json_value, ignore_extras, true);
                    setathlete(convert_classy);
                  }


                private void  fromJSONathletes(JSONValue json_value, bool ignore_extras)
                  {
                    Debug.Assert(json_value != null);
                    JSONArrayValue json_array1 = json_value.array_value();
                    if (json_array1 == null)
                        throw new Exception("The value for field athletes of TypecompetitorJSON is not an array.");
                    int count1 = json_array1.componentCount();
                    List< TypeathletesJSON  > vector_athletes1 = new List< TypeathletesJSON  >(count1);
                    for (int num1 = 0; num1 < count1; ++num1)
                      {
                        TypeathletesJSON convert_classy = TypeathletesJSON.from_json(json_array1.component(num1), ignore_extras, true);
                        vector_athletes1.Add(convert_classy);
                      }
                    initathletes();
                    for (int num1 = 0; num1 < vector_athletes1.Count; ++num1)
                        appendathletes(vector_athletes1[num1]);
                    for (int num1 = 0; num1 < vector_athletes1.Count; ++num1)
                      {
                      }
                  }


                public TypecompetitorJSON()
                  {
                    flagHasid = false;
                    flagHasname = false;
                    flagHascountry_code = false;
                    flagHasioc_code = false;
                    flagHasathlete = false;
                    flagHasathletes = false;
                    storeathletes = new List< TypeathletesJSON  >();
                    extraKeys = new List<string>();
                extraValues = new List<JSONValue >();
                extraIndex = new Dictionary<string, JSONValue >();
                  }

                public bool  hasid()
                  {
                    return flagHasid;
                  }

                public string  getid()
                  {
                    Debug.Assert(flagHasid);
                    return storeid;
                  }

                public bool  hasname()
                  {
                    return flagHasname;
                  }

                public string  getname()
                  {
                    Debug.Assert(flagHasname);
                    return storename;
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

                public bool  hasathlete()
                  {
                    return flagHasathlete;
                  }

                public TypeathleteJSON   getathlete()
                  {
                    Debug.Assert(flagHasathlete);
                    return storeathlete;
                  }

                public bool  hasathletes()
                  {
                    return flagHasathletes;
                  }

                public int  countOfathletes()
                  {
                    Debug.Assert(flagHasathletes);
                    return storeathletes.Count;
                  }

                public TypeathletesJSON   elementOfathletes(int element_num)
                  {
                    Debug.Assert(flagHasathletes);
                    return storeathletes[element_num];
                  }

                public List< TypeathletesJSON  >  getathletes()
                  {
                    Debug.Assert(flagHasathletes);
                    return storeathletes;
                  }


                public virtual int extraTypecompetitorComponentCount()
                  {
                    Debug.Assert(extraKeys.Count == extraValues.Count);
                    return extraKeys.Count;
                  }
                public virtual string extraTypecompetitorComponentKey(int component_num)
                  {
                    Debug.Assert(extraKeys.Count == extraValues.Count);
                    Debug.Assert(component_num < extraValues.Count);
                    return extraKeys[component_num];
                  }
                public virtual JSONValue extraTypecompetitorComponentValue(int component_num)
                  {
                    Debug.Assert(extraKeys.Count == extraValues.Count);
                    Debug.Assert(component_num < extraValues.Count);
                    return extraValues[component_num];
                  }
                public virtual JSONValue extraTypecompetitorLookup(string field_name)
                  {
                    JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                    return result;
                  }

                public void setid(string new_value)
                  {
                    flagHasid = true;
                    storeid = new_value;
                  }
                public void unsetid()
                  {
                    flagHasid = false;
                  }
                public void setname(string new_value)
                  {
                    flagHasname = true;
                    storename = new_value;
                  }
                public void unsetname()
                  {
                    flagHasname = false;
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
                public void setathlete(TypeathleteJSON  new_value)
                  {
                    if (flagHasathlete)
                      {
                      }
                    flagHasathlete = true;
                    storeathlete = new_value;
                  }
                public void unsetathlete()
                  {
                    if (flagHasathlete)
                      {
                      }
                    flagHasathlete = false;
                  }
                public void initathletes()
                  {
                    if (flagHasathletes)
                      {
                        for (int num1 = 0; num1 < storeathletes.Count; ++num1)
                          {
                          }
                      }
                    flagHasathletes = true;
                    storeathletes.Clear();
                  }
                public void appendathletes(TypeathletesJSON  to_append)
                  {
                    if (!flagHasathletes)
                      {
                        flagHasathletes = true;
                        storeathletes.Clear();
                      }
                    Debug.Assert(flagHasathletes);
                    storeathletes.Add(to_append);
                  }
                public void unsetathletes()
                  {
                    if (flagHasathletes)
                      {
                        for (int num2 = 0; num2 < storeathletes.Count; ++num2)
                          {
                          }
                      }
                    flagHasathletes = false;
                    storeathletes.Clear();
                  }

                public virtual void extraTypecompetitorAppendPair(string key, JSONValue new_component)
                  {
                    Debug.Assert(key != null);
                    Debug.Assert(new_component != null);

                    Debug.Assert(extraKeys.Count == extraValues.Count);
                    extraKeys.Add(key);
                    extraValues.Add(new_component);
                    extraIndex.Add(key, new_component);
                  }
                public virtual void extraTypecompetitorSetField(string key, JSONValue new_component)
                  {
                    Debug.Assert(key != null);
                    Debug.Assert(new_component != null);

                    JSONValue old_field = extraTypecompetitorLookup(key);
                    if (old_field == null)
                      {
                        extraTypecompetitorAppendPair(key, new_component);
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
                    if (flagHasid)
                      {
                        handler.start_pair("id");
                        handler.string_value(storeid);
                      }
                    if (flagHasname)
                      {
                        handler.start_pair("name");
                        handler.string_value(storename);
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
                    if (flagHasathlete)
                      {
                        handler.start_pair("athlete");
                        if (partial_allowed)
                            storeathlete.write_partial_as_json(handler);
                        else
                            storeathlete.write_as_json(handler);
                      }
                    if (flagHasathletes)
                      {
                        handler.start_pair("athletes");
                        handler.start_array();
                        for (int num1 = 0; num1 < storeathletes.Count; ++num1)
                          {
                            if (partial_allowed)
                                storeathletes[num1].write_partial_as_json(handler);
                            else
                                storeathletes[num1].write_as_json(handler);
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

                public static TypecompetitorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                  {
                    TypecompetitorJSON result;
                      {
                        HoldingGenerator generator = new HoldingGenerator("Type Typecompetitor", ignore_extras);
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
                public static TypecompetitorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
              {
                return from_json(json_value, ignore_extras, allow_incomplete, false);
              }
                public static TypecompetitorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
                  {
                    TypecompetitorJSON result;
                      {
                        HoldingGenerator generator = new HoldingGenerator("Type Typecompetitor", ignore_extras);
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
                public static TypecompetitorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
              {
                return from_json(json_value, ignore_extras, allow_incomplete, false);
              }
                public static TypecompetitorJSON from_text(string text, bool ignore_extras)
                  {
                    TypecompetitorJSON result;
                      {
                        HoldingGenerator generator = new HoldingGenerator("Type Typecompetitor", ignore_extras);
                        JSONParse.parse_json_value(text, "Text for TypecompetitorJSON", generator);
                        Debug.Assert(generator.have_value);
                        result = generator.value;
                      };
                    return result;
                  }
                public static TypecompetitorJSON from_file(TextReader fp, string file_name, bool ignore_extras)
                  {
                    TypecompetitorJSON result;
                      {
                        HoldingGenerator generator = new HoldingGenerator("Type Typecompetitor", ignore_extras);
                        JSONParse.parse_json_value(fp, file_name, generator);
                        Debug.Assert(generator.have_value);
                        result = generator.value;
                      };
                    return result;
                  }
                public abstract class Generator : JSONObjectGenerator
                  {
                    private JSONHoldingStringGenerator fieldGeneratorid;
                    private JSONHoldingStringGenerator fieldGeneratorname;
                    private JSONHoldingStringGenerator fieldGeneratorcountry_code;
                    private JSONHoldingStringGenerator fieldGeneratorioc_code;
                    private TypeathleteJSON.HoldingGenerator fieldGeneratorathlete;
                    private TypeathletesJSON.HoldingArrayGenerator fieldGeneratorathletes;
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
                        TypecompetitorJSON result = new TypecompetitorJSON();
                        Debug.Assert(result != null);
                        finish(result);
                        int extra_count = unknownFieldGenerator.field_names.Count;
                        Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                        for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                          {
                            result.extraTypecompetitorAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                          }
                        unknownFieldGenerator.field_names.Clear();
                        unknownFieldGenerator.field_values.Clear();
                        unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                        handle_result(result);
                      }
                    protected void finish(TypecompetitorJSON result)
                      {
                        if (fieldGeneratorid.have_value)
                          {
                            result.setid(fieldGeneratorid.value);
                            fieldGeneratorid.have_value = false;
                          }
                        if (fieldGeneratorname.have_value)
                          {
                            result.setname(fieldGeneratorname.value);
                            fieldGeneratorname.have_value = false;
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
                        if (fieldGeneratorathlete.have_value)
                          {
                            result.setathlete(fieldGeneratorathlete.value);
                            fieldGeneratorathlete.have_value = false;
                          }
                        if (fieldGeneratorathletes.have_value)
                          {
                            result.initathletes();
                            int count = fieldGeneratorathletes.value.Count;
                            for (int num = 0; num < count; ++num)
                              {
                                result.appendathletes(fieldGeneratorathletes.value[num]);
                              }
                            fieldGeneratorathletes.value.Clear();
                            fieldGeneratorathletes.have_value = false;
                          }
                      }
                    protected abstract void handle_result(TypecompetitorJSON new_result);
                    protected virtual JSONHandler start_known_field(string field_name)
                      {
                        switch (field_name[0])
                          {
                            case 'a':
                                if (String.Compare(field_name, 1, "thlete", 0, 6, false) == 0)
                                  {
                                    if (field_name.Length == 7)
                                      {
                                        return fieldGeneratorathlete;
                                      }
                                    switch (field_name[7])
                                      {
                                        case 's':
                                            if (field_name.Length == 8)
                                                return fieldGeneratorathletes;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'c':
                                if ((String.Compare(field_name, 1, "ountry_code", 0, 11, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorcountry_code;
                                break;
                            case 'i':
                                switch (field_name[1])
                                  {
                                    case 'd':
                                        if (field_name.Length == 2)
                                            return fieldGeneratorid;
                                        break;
                                    case 'o':
                                        if ((String.Compare(field_name, 2, "c_code", 0, 6, false) == 0) && (field_name.Length == 8))
                                            return fieldGeneratorioc_code;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'n':
                                if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                                    return fieldGeneratorname;
                                break;
                            default:
                                break;
                          }
                        return null;
                      }
                    public Generator(bool ignore_extras)
                      {
                        fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the Typecompetitor class");
                        fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the Typecompetitor class");
                        fieldGeneratorcountry_code = new JSONHoldingStringGenerator("field \"country_code\" of the Typecompetitor class");
                        fieldGeneratorioc_code = new JSONHoldingStringGenerator("field \"ioc_code\" of the Typecompetitor class");
                        fieldGeneratorathlete = new TypeathleteJSON.HoldingGenerator("field \"athlete\" of the Typecompetitor class", ignore_extras);
                        fieldGeneratorathletes = new TypeathletesJSON.HoldingArrayGenerator("field \"athletes\" of the Typecompetitor class", ignore_extras);
                        unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                        set_what("the Typecompetitor class");
                        allow_incomplete = false;
                        allow_unpolished = false;
                      }
                    public Generator()
                      {
                        fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the Typecompetitor class");
                        fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the Typecompetitor class");
                        fieldGeneratorcountry_code = new JSONHoldingStringGenerator("field \"country_code\" of the Typecompetitor class");
                        fieldGeneratorioc_code = new JSONHoldingStringGenerator("field \"ioc_code\" of the Typecompetitor class");
                        fieldGeneratorathlete = new TypeathleteJSON.HoldingGenerator("field \"athlete\" of the Typecompetitor class", false);
                        fieldGeneratorathletes = new TypeathletesJSON.HoldingArrayGenerator("field \"athletes\" of the Typecompetitor class", false);
                        unknownFieldGenerator = new UnknownFieldGenerator(false);
                        set_what("the Typecompetitor class");
                        allow_incomplete = false;
                        allow_unpolished = false;
                      }

                    public override void reset()
                      {
                        fieldGeneratorid.reset();
                        fieldGeneratorname.reset();
                        fieldGeneratorcountry_code.reset();
                        fieldGeneratorioc_code.reset();
                        fieldGeneratorathlete.reset();
                        fieldGeneratorathletes.reset();
                        base.reset();
                        unknownFieldGenerator.reset();
                      }
                    public void set_allow_incomplete(bool new_allow_incomplete)
                      {
                        allow_incomplete = new_allow_incomplete;
                        fieldGeneratorathlete.set_allow_incomplete(new_allow_incomplete);
                      }
                    public void set_allow_unpolished(bool new_allow_unpolished)
                      {
                        allow_unpolished = new_allow_unpolished;
                        fieldGeneratorathlete.set_allow_unpolished(new_allow_unpolished);
                      }
                  };
                public class HoldingGenerator : Generator
                  {
                    protected override void handle_result(TypecompetitorJSON  result)
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
                    public TypecompetitorJSON value;
                  };
                public class HoldingArrayGenerator : JSONArrayGenerator
              {
                protected class ElementHandler : Generator
                  {
                    private HoldingArrayGenerator top;

                    protected override void handle_result(TypecompetitorJSON  result)
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
                protected virtual void handle_result(List<TypecompetitorJSON> result)

                  {
                  }

                public HoldingArrayGenerator(string what, bool ignore_extras)
                  {
                    element_handler = new ElementHandler(this, ignore_extras);
                    have_value = false;
                    value = new List<TypecompetitorJSON>();
                    base.set_what(what);
                  }
                public HoldingArrayGenerator(bool ignore_extras)
                  {
                    element_handler = new ElementHandler(this, ignore_extras);
                    value = new List<TypecompetitorJSON>();
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
                public List<TypecompetitorJSON> value;
              };
              };
            private bool flagHascompetitor;
            private TypecompetitorJSON  storecompetitor;
            private bool flagHasposition;
            private string storeposition;
            private bool flagHastime;
            private string storetime;
            private bool flagHasgold;
            private bool storegold;
            private bool flagHassilver;
            private bool storesilver;
            private bool flagHasbronze;
            private bool storebronze;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONcompetitor(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                TypecompetitorJSON convert_classy = TypecompetitorJSON.from_json(json_value, ignore_extras, true);
                setcompetitor(convert_classy);
              }


            private void  fromJSONposition(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field position of TyperesultsJSON is not a string.");
                setposition(json_string.getData());
              }


            private void  fromJSONtime(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field time of TyperesultsJSON is not a string.");
                settime(json_string.getData());
              }


            private void  fromJSONgold(JSONValue json_value, bool ignore_extras)
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
                        throw new Exception("The value for field gold of TyperesultsJSON is not true for false.");
                      }
                  }
                setgold(the_bool);
              }


            private void  fromJSONsilver(JSONValue json_value, bool ignore_extras)
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
                        throw new Exception("The value for field silver of TyperesultsJSON is not true for false.");
                      }
                  }
                setsilver(the_bool);
              }


            private void  fromJSONbronze(JSONValue json_value, bool ignore_extras)
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
                        throw new Exception("The value for field bronze of TyperesultsJSON is not true for false.");
                      }
                  }
                setbronze(the_bool);
              }


            public TyperesultsJSON()
              {
                flagHascompetitor = false;
                flagHasposition = false;
                flagHastime = false;
                flagHasgold = false;
                flagHassilver = false;
                flagHasbronze = false;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hascompetitor()
              {
                return flagHascompetitor;
              }

            public TypecompetitorJSON   getcompetitor()
              {
                Debug.Assert(flagHascompetitor);
                return storecompetitor;
              }

            public bool  hasposition()
              {
                return flagHasposition;
              }

            public string  getposition()
              {
                Debug.Assert(flagHasposition);
                return storeposition;
              }

            public bool  hastime()
              {
                return flagHastime;
              }

            public string  gettime()
              {
                Debug.Assert(flagHastime);
                return storetime;
              }

            public bool  hasgold()
              {
                return flagHasgold;
              }

            public bool  getgold()
              {
                Debug.Assert(flagHasgold);
                return storegold;
              }

            public bool  hassilver()
              {
                return flagHassilver;
              }

            public bool  getsilver()
              {
                Debug.Assert(flagHassilver);
                return storesilver;
              }

            public bool  hasbronze()
              {
                return flagHasbronze;
              }

            public bool  getbronze()
              {
                Debug.Assert(flagHasbronze);
                return storebronze;
              }


            public virtual int extraTyperesultsComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTyperesultsComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTyperesultsComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTyperesultsLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setcompetitor(TypecompetitorJSON  new_value)
              {
                if (flagHascompetitor)
                  {
                  }
                flagHascompetitor = true;
                storecompetitor = new_value;
              }
            public void unsetcompetitor()
              {
                if (flagHascompetitor)
                  {
                  }
                flagHascompetitor = false;
              }
            public void setposition(string new_value)
              {
                flagHasposition = true;
                storeposition = new_value;
              }
            public void unsetposition()
              {
                flagHasposition = false;
              }
            public void settime(string new_value)
              {
                flagHastime = true;
                storetime = new_value;
              }
            public void unsettime()
              {
                flagHastime = false;
              }
            public void setgold(bool new_value)
              {
                flagHasgold = true;
                storegold = new_value;
              }
            public void unsetgold()
              {
                flagHasgold = false;
              }
            public void setsilver(bool new_value)
              {
                flagHassilver = true;
                storesilver = new_value;
              }
            public void unsetsilver()
              {
                flagHassilver = false;
              }
            public void setbronze(bool new_value)
              {
                flagHasbronze = true;
                storebronze = new_value;
              }
            public void unsetbronze()
              {
                flagHasbronze = false;
              }

            public virtual void extraTyperesultsAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTyperesultsSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTyperesultsLookup(key);
                if (old_field == null)
                  {
                    extraTyperesultsAppendPair(key, new_component);
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
                if (flagHascompetitor)
                  {
                    handler.start_pair("competitor");
                    if (partial_allowed)
                        storecompetitor.write_partial_as_json(handler);
                    else
                        storecompetitor.write_as_json(handler);
                  }
                if (flagHasposition)
                  {
                    handler.start_pair("position");
                    handler.string_value(storeposition);
                  }
                if (flagHastime)
                  {
                    handler.start_pair("time");
                    handler.string_value(storetime);
                  }
                if (flagHasgold)
                  {
                    handler.start_pair("gold");
                    handler.boolean_value(storegold);
                  }
                if (flagHassilver)
                  {
                    handler.start_pair("silver");
                    handler.boolean_value(storesilver);
                  }
                if (flagHasbronze)
                  {
                    handler.start_pair("bronze");
                    handler.boolean_value(storebronze);
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

            public static TyperesultsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TyperesultsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typeresults", ignore_extras);
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
            public static TyperesultsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TyperesultsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TyperesultsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typeresults", ignore_extras);
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
            public static TyperesultsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TyperesultsJSON from_text(string text, bool ignore_extras)
              {
                TyperesultsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typeresults", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TyperesultsJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TyperesultsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TyperesultsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typeresults", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private TypecompetitorJSON.HoldingGenerator fieldGeneratorcompetitor;
                private JSONHoldingStringGenerator fieldGeneratorposition;
                private JSONHoldingStringGenerator fieldGeneratortime;
                private JSONHoldingBooleanGenerator fieldGeneratorgold;
                private JSONHoldingBooleanGenerator fieldGeneratorsilver;
                private JSONHoldingBooleanGenerator fieldGeneratorbronze;
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
                    TyperesultsJSON result = new TyperesultsJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTyperesultsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TyperesultsJSON result)
                  {
                    if (fieldGeneratorcompetitor.have_value)
                      {
                        result.setcompetitor(fieldGeneratorcompetitor.value);
                        fieldGeneratorcompetitor.have_value = false;
                      }
                    if (fieldGeneratorposition.have_value)
                      {
                        result.setposition(fieldGeneratorposition.value);
                        fieldGeneratorposition.have_value = false;
                      }
                    if (fieldGeneratortime.have_value)
                      {
                        result.settime(fieldGeneratortime.value);
                        fieldGeneratortime.have_value = false;
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
                protected abstract void handle_result(TyperesultsJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    switch (field_name[0])
                      {
                        case 'b':
                            if ((String.Compare(field_name, 1, "ronze", 0, 5, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorbronze;
                            break;
                        case 'c':
                            if ((String.Compare(field_name, 1, "ompetitor", 0, 9, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorcompetitor;
                            break;
                        case 'g':
                            if ((String.Compare(field_name, 1, "old", 0, 3, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorgold;
                            break;
                        case 'p':
                            if ((String.Compare(field_name, 1, "osition", 0, 7, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorposition;
                            break;
                        case 's':
                            if ((String.Compare(field_name, 1, "ilver", 0, 5, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorsilver;
                            break;
                        case 't':
                            if ((String.Compare(field_name, 1, "ime", 0, 3, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratortime;
                            break;
                        default:
                            break;
                      }
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorcompetitor = new TypecompetitorJSON.HoldingGenerator("field \"competitor\" of the Typeresults class", ignore_extras);
                    fieldGeneratorposition = new JSONHoldingStringGenerator("field \"position\" of the Typeresults class");
                    fieldGeneratortime = new JSONHoldingStringGenerator("field \"time\" of the Typeresults class");
                    fieldGeneratorgold = new JSONHoldingBooleanGenerator("field \"gold\" of the Typeresults class");
                    fieldGeneratorsilver = new JSONHoldingBooleanGenerator("field \"silver\" of the Typeresults class");
                    fieldGeneratorbronze = new JSONHoldingBooleanGenerator("field \"bronze\" of the Typeresults class");
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the Typeresults class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorcompetitor = new TypecompetitorJSON.HoldingGenerator("field \"competitor\" of the Typeresults class", false);
                    fieldGeneratorposition = new JSONHoldingStringGenerator("field \"position\" of the Typeresults class");
                    fieldGeneratortime = new JSONHoldingStringGenerator("field \"time\" of the Typeresults class");
                    fieldGeneratorgold = new JSONHoldingBooleanGenerator("field \"gold\" of the Typeresults class");
                    fieldGeneratorsilver = new JSONHoldingBooleanGenerator("field \"silver\" of the Typeresults class");
                    fieldGeneratorbronze = new JSONHoldingBooleanGenerator("field \"bronze\" of the Typeresults class");
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the Typeresults class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorcompetitor.reset();
                    fieldGeneratorposition.reset();
                    fieldGeneratortime.reset();
                    fieldGeneratorgold.reset();
                    fieldGeneratorsilver.reset();
                    fieldGeneratorbronze.reset();
                    base.reset();
                    unknownFieldGenerator.reset();
                  }
                public void set_allow_incomplete(bool new_allow_incomplete)
                  {
                    allow_incomplete = new_allow_incomplete;
                    fieldGeneratorcompetitor.set_allow_incomplete(new_allow_incomplete);
                  }
                public void set_allow_unpolished(bool new_allow_unpolished)
                  {
                    allow_unpolished = new_allow_unpolished;
                    fieldGeneratorcompetitor.set_allow_unpolished(new_allow_unpolished);
                  }
              };
            public class HoldingGenerator : Generator
              {
                protected override void handle_result(TyperesultsJSON  result)
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
                public TyperesultsJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TyperesultsJSON  result)
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
            protected virtual void handle_result(List<TyperesultsJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TyperesultsJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TyperesultsJSON>();
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
            public List<TyperesultsJSON> value;
          };
          };
        private bool flagHassport_event;
        private Typesport_eventJSON  storesport_event;
        private bool flagHasresults;
        private List< TyperesultsJSON  > storeresults;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONsport_event(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            Typesport_eventJSON convert_classy = Typesport_eventJSON.from_json(json_value, ignore_extras, true);
            setsport_event(convert_classy);
          }


        private void  fromJSONresults(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field results of Typesport_event_resultsJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< TyperesultsJSON  > vector_results1 = new List< TyperesultsJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                TyperesultsJSON convert_classy = TyperesultsJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_results1.Add(convert_classy);
              }
            initresults();
            for (int num2 = 0; num2 < vector_results1.Count; ++num2)
                appendresults(vector_results1[num2]);
            for (int num1 = 0; num1 < vector_results1.Count; ++num1)
              {
              }
          }


        public Typesport_event_resultsJSON()
          {
            flagHassport_event = false;
            flagHasresults = false;
            storeresults = new List< TyperesultsJSON  >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hassport_event()
          {
            return flagHassport_event;
          }

        public Typesport_eventJSON   getsport_event()
          {
            Debug.Assert(flagHassport_event);
            return storesport_event;
          }

        public bool  hasresults()
          {
            return flagHasresults;
          }

        public int  countOfresults()
          {
            Debug.Assert(flagHasresults);
            return storeresults.Count;
          }

        public TyperesultsJSON   elementOfresults(int element_num)
          {
            Debug.Assert(flagHasresults);
            return storeresults[element_num];
          }

        public List< TyperesultsJSON  >  getresults()
          {
            Debug.Assert(flagHasresults);
            return storeresults;
          }


        public virtual int extraTypesport_event_resultsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypesport_event_resultsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypesport_event_resultsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypesport_event_resultsLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setsport_event(Typesport_eventJSON  new_value)
          {
            if (flagHassport_event)
              {
              }
            flagHassport_event = true;
            storesport_event = new_value;
          }
        public void unsetsport_event()
          {
            if (flagHassport_event)
              {
              }
            flagHassport_event = false;
          }
        public void initresults()
          {
            if (flagHasresults)
              {
                for (int num3 = 0; num3 < storeresults.Count; ++num3)
                  {
                  }
              }
            flagHasresults = true;
            storeresults.Clear();
          }
        public void appendresults(TyperesultsJSON  to_append)
          {
            if (!flagHasresults)
              {
                flagHasresults = true;
                storeresults.Clear();
              }
            Debug.Assert(flagHasresults);
            storeresults.Add(to_append);
          }
        public void unsetresults()
          {
            if (flagHasresults)
              {
                for (int num4 = 0; num4 < storeresults.Count; ++num4)
                  {
                  }
              }
            flagHasresults = false;
            storeresults.Clear();
          }

        public virtual void extraTypesport_event_resultsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypesport_event_resultsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypesport_event_resultsLookup(key);
            if (old_field == null)
              {
                extraTypesport_event_resultsAppendPair(key, new_component);
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
            if (flagHassport_event)
              {
                handler.start_pair("sport_event");
                if (partial_allowed)
                    storesport_event.write_partial_as_json(handler);
                else
                    storesport_event.write_as_json(handler);
              }
            if (flagHasresults)
              {
                handler.start_pair("results");
                handler.start_array();
                for (int num1 = 0; num1 < storeresults.Count; ++num1)
                  {
                    if (partial_allowed)
                        storeresults[num1].write_partial_as_json(handler);
                    else
                        storeresults[num1].write_as_json(handler);
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

        public static Typesport_event_resultsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            Typesport_event_resultsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typesport_event_results", ignore_extras);
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
        public static Typesport_event_resultsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static Typesport_event_resultsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            Typesport_event_resultsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typesport_event_results", ignore_extras);
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
        public static Typesport_event_resultsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static Typesport_event_resultsJSON from_text(string text, bool ignore_extras)
          {
            Typesport_event_resultsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typesport_event_results", ignore_extras);
                JSONParse.parse_json_value(text, "Text for Typesport_event_resultsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static Typesport_event_resultsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            Typesport_event_resultsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typesport_event_results", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private Typesport_eventJSON.HoldingGenerator fieldGeneratorsport_event;
            private TyperesultsJSON.HoldingArrayGenerator fieldGeneratorresults;
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
                Typesport_event_resultsJSON result = new Typesport_event_resultsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypesport_event_resultsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(Typesport_event_resultsJSON result)
              {
                if (fieldGeneratorsport_event.have_value)
                  {
                    result.setsport_event(fieldGeneratorsport_event.value);
                    fieldGeneratorsport_event.have_value = false;
                  }
                if (fieldGeneratorresults.have_value)
                  {
                    result.initresults();
                    int count = fieldGeneratorresults.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendresults(fieldGeneratorresults.value[num]);
                      }
                    fieldGeneratorresults.value.Clear();
                    fieldGeneratorresults.have_value = false;
                  }
              }
            protected abstract void handle_result(Typesport_event_resultsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'r':
                        if ((String.Compare(field_name, 1, "esults", 0, 6, false) == 0) && (field_name.Length == 7))
                            return fieldGeneratorresults;
                        break;
                    case 's':
                        if ((String.Compare(field_name, 1, "port_event", 0, 10, false) == 0) && (field_name.Length == 11))
                            return fieldGeneratorsport_event;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorsport_event = new Typesport_eventJSON.HoldingGenerator("field \"sport_event\" of the Typesport_event_results class", ignore_extras);
                fieldGeneratorresults = new TyperesultsJSON.HoldingArrayGenerator("field \"results\" of the Typesport_event_results class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the Typesport_event_results class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorsport_event = new Typesport_eventJSON.HoldingGenerator("field \"sport_event\" of the Typesport_event_results class", false);
                fieldGeneratorresults = new TyperesultsJSON.HoldingArrayGenerator("field \"results\" of the Typesport_event_results class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the Typesport_event_results class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorsport_event.reset();
                fieldGeneratorresults.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorsport_event.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorsport_event.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(Typesport_event_resultsJSON  result)
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
            public Typesport_event_resultsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(Typesport_event_resultsJSON  result)
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
        protected virtual void handle_result(List<Typesport_event_resultsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<Typesport_event_resultsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<Typesport_event_resultsJSON>();
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
        public List<Typesport_event_resultsJSON> value;
      };
      };
    private bool flagHassport_event_results;
    private List< List< Typesport_event_resultsJSON  > > storesport_event_results;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONsport_event_results(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field sport_event_results of SportsOlympicsAPIEventResultsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< List< Typesport_event_resultsJSON  > > vector_sport_event_results1 = new List< List< Typesport_event_resultsJSON  > >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONArrayValue json_array2 = json_array1.component(num1).array_value();
            if (json_array2 == null)
                throw new Exception("The value for an element of field sport_event_results of SportsOlympicsAPIEventResultsJSON is not an array.");
            int count2 = json_array2.componentCount();
            List< Typesport_event_resultsJSON  > vector_sport_event_results2 = new List< Typesport_event_resultsJSON  >(count2);
            for (int num2 = 0; num2 < count2; ++num2)
              {
                Typesport_event_resultsJSON convert_classy = Typesport_event_resultsJSON.from_json(json_array2.component(num2), ignore_extras, true);
                vector_sport_event_results2.Add(convert_classy);
              }
            vector_sport_event_results1.Add(vector_sport_event_results2);
          }
        initsport_event_results();
        for (int num3 = 0; num3 < vector_sport_event_results1.Count; ++num3)
            appendsport_event_results(vector_sport_event_results1[num3]);
        for (int num1 = 0; num1 < vector_sport_event_results1.Count; ++num1)
          {
            for (int num2 = 0; num2 < vector_sport_event_results1[num1].Count; ++num2)
              {
              }
          }
      }


    public SportsOlympicsAPIEventResultsJSON()
      {
        flagHassport_event_results = false;
        storesport_event_results = new List< List< Typesport_event_resultsJSON  > >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hassport_event_results()
      {
        return flagHassport_event_results;
      }

    public int  countOfsport_event_results()
      {
        Debug.Assert(flagHassport_event_results);
        return storesport_event_results.Count;
      }

    public List< Typesport_event_resultsJSON  >  elementOfsport_event_results(int element_num)
      {
        Debug.Assert(flagHassport_event_results);
        return storesport_event_results[element_num];
      }

    public List< List< Typesport_event_resultsJSON  > >  getsport_event_results()
      {
        Debug.Assert(flagHassport_event_results);
        return storesport_event_results;
      }


    public virtual int extraSportsOlympicsAPIEventResultsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsOlympicsAPIEventResultsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsOlympicsAPIEventResultsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsOlympicsAPIEventResultsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initsport_event_results()
      {
        if (flagHassport_event_results)
          {
            for (int num5 = 0; num5 < storesport_event_results.Count; ++num5)
              {
                for (int num6 = 0; num6 < storesport_event_results[num5].Count; ++num6)
                  {
                  }
              }
          }
        flagHassport_event_results = true;
        storesport_event_results.Clear();
      }
    public void appendsport_event_results(List< Typesport_event_resultsJSON  > to_append)
      {
        if (!flagHassport_event_results)
          {
            flagHassport_event_results = true;
            storesport_event_results.Clear();
          }
        Debug.Assert(flagHassport_event_results);
        for (int num1 = 0; num1 < to_append.Count; ++num1)
          {
          }
        storesport_event_results.Add(to_append);
      }
    public void unsetsport_event_results()
      {
        if (flagHassport_event_results)
          {
            for (int num7 = 0; num7 < storesport_event_results.Count; ++num7)
              {
                for (int num8 = 0; num8 < storesport_event_results[num7].Count; ++num8)
                  {
                  }
              }
          }
        flagHassport_event_results = false;
        storesport_event_results.Clear();
      }

    public virtual void extraSportsOlympicsAPIEventResultsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsOlympicsAPIEventResultsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsOlympicsAPIEventResultsLookup(key);
        if (old_field == null)
          {
            extraSportsOlympicsAPIEventResultsAppendPair(key, new_component);
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
        if (flagHassport_event_results)
          {
            handler.start_pair("sport_event_results");
            handler.start_array();
            for (int num1 = 0; num1 < storesport_event_results.Count; ++num1)
              {
                handler.start_array();
                for (int num2 = 0; num2 < storesport_event_results[num1].Count; ++num2)
                  {
                    if (partial_allowed)
                        storesport_event_results[num1][num2].write_partial_as_json(handler);
                    else
                        storesport_event_results[num1][num2].write_as_json(handler);
                  }
                handler.finish_array();
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

    public static SportsOlympicsAPIEventResultsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsAPIEventResultsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsAPIEventResults", ignore_extras);
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
    public static SportsOlympicsAPIEventResultsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsAPIEventResultsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsAPIEventResultsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsAPIEventResults", ignore_extras);
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
    public static SportsOlympicsAPIEventResultsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsAPIEventResultsJSON from_text(string text, bool ignore_extras)
      {
        SportsOlympicsAPIEventResultsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsAPIEventResults", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsOlympicsAPIEventResultsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsOlympicsAPIEventResultsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsOlympicsAPIEventResultsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsAPIEventResults", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingArrayGeneratorsport_event_results : JSONArrayGenerator
  {
    protected class ElementHandler : Typesport_event_resultsJSON.HoldingArrayGenerator
      {
        private FieldHoldingArrayGeneratorsport_event_results top;

        protected override void handle_result(List< Typesport_event_resultsJSON  > result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorsport_event_results init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<List< Typesport_event_resultsJSON  >> result)
      {
      }

    public FieldHoldingArrayGeneratorsport_event_results(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<List< Typesport_event_resultsJSON  >>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorsport_event_results(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<List< Typesport_event_resultsJSON  >>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<List< Typesport_event_resultsJSON  >> value;
  };
        private FieldHoldingArrayGeneratorsport_event_results fieldGeneratorsport_event_results;
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
            SportsOlympicsAPIEventResultsJSON result = new SportsOlympicsAPIEventResultsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsOlympicsAPIEventResultsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsOlympicsAPIEventResultsJSON result)
          {
            if (fieldGeneratorsport_event_results.have_value)
              {
                result.initsport_event_results();
                int count = fieldGeneratorsport_event_results.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    List< Typesport_event_resultsJSON  > unwrapped0 = new List< Typesport_event_resultsJSON  >();
                    for (int num0 = 0; num0 < fieldGeneratorsport_event_results.value[num].Count; ++num0)
                      {
                        unwrapped0.Add(fieldGeneratorsport_event_results.value[num][num0]);
                      }
                    result.appendsport_event_results(unwrapped0);
                  }
                fieldGeneratorsport_event_results.value.Clear();
                fieldGeneratorsport_event_results.have_value = false;
              }
          }
        protected abstract void handle_result(SportsOlympicsAPIEventResultsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "sport_event_results", 0, 19, false) == 0) && (field_name.Length == 19))
                return fieldGeneratorsport_event_results;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorsport_event_results = new FieldHoldingArrayGeneratorsport_event_results("field \"sport_event_results\" of the SportsOlympicsAPIEventResults class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsOlympicsAPIEventResults class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorsport_event_results = new FieldHoldingArrayGeneratorsport_event_results("field \"sport_event_results\" of the SportsOlympicsAPIEventResults class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsOlympicsAPIEventResults class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorsport_event_results.reset();
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
        protected override void handle_result(SportsOlympicsAPIEventResultsJSON  result)
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
        public SportsOlympicsAPIEventResultsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsOlympicsAPIEventResultsJSON  result)
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
    protected virtual void handle_result(List<SportsOlympicsAPIEventResultsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsOlympicsAPIEventResultsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsOlympicsAPIEventResultsJSON>();
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
    public List<SportsOlympicsAPIEventResultsJSON> value;
  };
  };
