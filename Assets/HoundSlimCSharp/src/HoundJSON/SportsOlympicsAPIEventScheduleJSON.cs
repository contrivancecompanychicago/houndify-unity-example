/* file "SportsOlympicsAPIEventScheduleJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsOlympicsAPIEventScheduleJSON : JSONBase
  {
    public class Typesport_eventsJSON : JSONBase
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
        public class TypestagesJSON : JSONBase
          {
            private bool flagHasid;
            private string storeid;
            private bool flagHasname;
            private string storename;
            private bool flagHasscheduled;
            private string storescheduled;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONid(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field id of TypestagesJSON is not a string.");
                setid(json_string.getData());
              }


            private void  fromJSONname(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field name of TypestagesJSON is not a string.");
                setname(json_string.getData());
              }


            private void  fromJSONscheduled(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field scheduled of TypestagesJSON is not a string.");
                setscheduled(json_string.getData());
              }


            public TypestagesJSON()
              {
                flagHasid = false;
                flagHasname = false;
                flagHasscheduled = false;
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


            public virtual int extraTypestagesComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypestagesComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypestagesComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypestagesLookup(string field_name)
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

            public virtual void extraTypestagesAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypestagesSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypestagesLookup(key);
                if (old_field == null)
                  {
                    extraTypestagesAppendPair(key, new_component);
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

            public static TypestagesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypestagesJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typestages", ignore_extras);
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
            public static TypestagesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypestagesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypestagesJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typestages", ignore_extras);
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
            public static TypestagesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypestagesJSON from_text(string text, bool ignore_extras)
              {
                TypestagesJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typestages", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypestagesJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypestagesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypestagesJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typestages", ignore_extras);
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
                    TypestagesJSON result = new TypestagesJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypestagesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypestagesJSON result)
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
                  }
                protected abstract void handle_result(TypestagesJSON new_result);
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
                        default:
                            break;
                      }
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the Typestages class");
                    fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the Typestages class");
                    fieldGeneratorscheduled = new JSONHoldingStringGenerator("field \"scheduled\" of the Typestages class");
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the Typestages class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the Typestages class");
                    fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the Typestages class");
                    fieldGeneratorscheduled = new JSONHoldingStringGenerator("field \"scheduled\" of the Typestages class");
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the Typestages class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorid.reset();
                    fieldGeneratorname.reset();
                    fieldGeneratorscheduled.reset();
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
                protected override void handle_result(TypestagesJSON  result)
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
                public TypestagesJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypestagesJSON  result)
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
            protected virtual void handle_result(List<TypestagesJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypestagesJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypestagesJSON>();
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
            public List<TypestagesJSON> value;
          };
          };
        public class TypecompetitorsJSON : JSONBase
          {
            private bool flagHasid;
            private string storeid;
            private bool flagHasname;
            private string storename;
            private bool flagHascountry;
            private string storecountry;
            private bool flagHascountry_code;
            private string storecountry_code;
            private bool flagHasioc_code;
            private string storeioc_code;
            private bool flagHasabbreviation;
            private string storeabbreviation;
            private bool flagHasqualifier;
            private string storequalifier;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONid(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field id of TypecompetitorsJSON is not a string.");
                setid(json_string.getData());
              }


            private void  fromJSONname(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field name of TypecompetitorsJSON is not a string.");
                setname(json_string.getData());
              }


            private void  fromJSONcountry(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field country of TypecompetitorsJSON is not a string.");
                setcountry(json_string.getData());
              }


            private void  fromJSONcountry_code(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field country_code of TypecompetitorsJSON is not a string.");
                setcountry_code(json_string.getData());
              }


            private void  fromJSONioc_code(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field ioc_code of TypecompetitorsJSON is not a string.");
                setioc_code(json_string.getData());
              }


            private void  fromJSONabbreviation(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field abbreviation of TypecompetitorsJSON is not a string.");
                setabbreviation(json_string.getData());
              }


            private void  fromJSONqualifier(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field qualifier of TypecompetitorsJSON is not a string.");
                setqualifier(json_string.getData());
              }


            public TypecompetitorsJSON()
              {
                flagHasid = false;
                flagHasname = false;
                flagHascountry = false;
                flagHascountry_code = false;
                flagHasioc_code = false;
                flagHasabbreviation = false;
                flagHasqualifier = false;
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

            public bool  hasabbreviation()
              {
                return flagHasabbreviation;
              }

            public string  getabbreviation()
              {
                Debug.Assert(flagHasabbreviation);
                return storeabbreviation;
              }

            public bool  hasqualifier()
              {
                return flagHasqualifier;
              }

            public string  getqualifier()
              {
                Debug.Assert(flagHasqualifier);
                return storequalifier;
              }


            public virtual int extraTypecompetitorsComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypecompetitorsComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypecompetitorsComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypecompetitorsLookup(string field_name)
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
            public void setabbreviation(string new_value)
              {
                flagHasabbreviation = true;
                storeabbreviation = new_value;
              }
            public void unsetabbreviation()
              {
                flagHasabbreviation = false;
              }
            public void setqualifier(string new_value)
              {
                flagHasqualifier = true;
                storequalifier = new_value;
              }
            public void unsetqualifier()
              {
                flagHasqualifier = false;
              }

            public virtual void extraTypecompetitorsAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypecompetitorsSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypecompetitorsLookup(key);
                if (old_field == null)
                  {
                    extraTypecompetitorsAppendPair(key, new_component);
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
                if (flagHasabbreviation)
                  {
                    handler.start_pair("abbreviation");
                    handler.string_value(storeabbreviation);
                  }
                if (flagHasqualifier)
                  {
                    handler.start_pair("qualifier");
                    handler.string_value(storequalifier);
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

            public static TypecompetitorsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypecompetitorsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typecompetitors", ignore_extras);
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
            public static TypecompetitorsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypecompetitorsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypecompetitorsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typecompetitors", ignore_extras);
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
            public static TypecompetitorsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypecompetitorsJSON from_text(string text, bool ignore_extras)
              {
                TypecompetitorsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typecompetitors", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypecompetitorsJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypecompetitorsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypecompetitorsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typecompetitors", ignore_extras);
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
                private JSONHoldingStringGenerator fieldGeneratorcountry;
                private JSONHoldingStringGenerator fieldGeneratorcountry_code;
                private JSONHoldingStringGenerator fieldGeneratorioc_code;
                private JSONHoldingStringGenerator fieldGeneratorabbreviation;
                private JSONHoldingStringGenerator fieldGeneratorqualifier;
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
                    TypecompetitorsJSON result = new TypecompetitorsJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypecompetitorsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypecompetitorsJSON result)
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
                    if (fieldGeneratorabbreviation.have_value)
                      {
                        result.setabbreviation(fieldGeneratorabbreviation.value);
                        fieldGeneratorabbreviation.have_value = false;
                      }
                    if (fieldGeneratorqualifier.have_value)
                      {
                        result.setqualifier(fieldGeneratorqualifier.value);
                        fieldGeneratorqualifier.have_value = false;
                      }
                  }
                protected abstract void handle_result(TypecompetitorsJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    switch (field_name[0])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 1, "bbreviation", 0, 11, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorabbreviation;
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
                        case 'q':
                            if ((String.Compare(field_name, 1, "ualifier", 0, 8, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorqualifier;
                            break;
                        default:
                            break;
                      }
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the Typecompetitors class");
                    fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the Typecompetitors class");
                    fieldGeneratorcountry = new JSONHoldingStringGenerator("field \"country\" of the Typecompetitors class");
                    fieldGeneratorcountry_code = new JSONHoldingStringGenerator("field \"country_code\" of the Typecompetitors class");
                    fieldGeneratorioc_code = new JSONHoldingStringGenerator("field \"ioc_code\" of the Typecompetitors class");
                    fieldGeneratorabbreviation = new JSONHoldingStringGenerator("field \"abbreviation\" of the Typecompetitors class");
                    fieldGeneratorqualifier = new JSONHoldingStringGenerator("field \"qualifier\" of the Typecompetitors class");
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the Typecompetitors class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the Typecompetitors class");
                    fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the Typecompetitors class");
                    fieldGeneratorcountry = new JSONHoldingStringGenerator("field \"country\" of the Typecompetitors class");
                    fieldGeneratorcountry_code = new JSONHoldingStringGenerator("field \"country_code\" of the Typecompetitors class");
                    fieldGeneratorioc_code = new JSONHoldingStringGenerator("field \"ioc_code\" of the Typecompetitors class");
                    fieldGeneratorabbreviation = new JSONHoldingStringGenerator("field \"abbreviation\" of the Typecompetitors class");
                    fieldGeneratorqualifier = new JSONHoldingStringGenerator("field \"qualifier\" of the Typecompetitors class");
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the Typecompetitors class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorid.reset();
                    fieldGeneratorname.reset();
                    fieldGeneratorcountry.reset();
                    fieldGeneratorcountry_code.reset();
                    fieldGeneratorioc_code.reset();
                    fieldGeneratorabbreviation.reset();
                    fieldGeneratorqualifier.reset();
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
                protected override void handle_result(TypecompetitorsJSON  result)
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
                public TypecompetitorsJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypecompetitorsJSON  result)
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
            protected virtual void handle_result(List<TypecompetitorsJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypecompetitorsJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypecompetitorsJSON>();
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
            public List<TypecompetitorsJSON> value;
          };
          };
        private bool flagHasid;
        private string storeid;
        private bool flagHasname;
        private string storename;
        private bool flagHasscheduled;
        private string storescheduled;
        private bool flagHasstart_time_tbd;
        private bool storestart_time_tbd;
        private bool flagHasstatus;
        private string storestatus;
        private bool flagHastournament;
        private TypetournamentJSON  storetournament;
        private bool flagHasstages;
        private List< TypestagesJSON  > storestages;
        private bool flagHascompetitors;
        private List< TypecompetitorsJSON  > storecompetitors;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONid(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field id of Typesport_eventsJSON is not a string.");
            setid(json_string.getData());
          }


        private void  fromJSONname(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field name of Typesport_eventsJSON is not a string.");
            setname(json_string.getData());
          }


        private void  fromJSONscheduled(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field scheduled of Typesport_eventsJSON is not a string.");
            setscheduled(json_string.getData());
          }


        private void  fromJSONstart_time_tbd(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field start_time_tbd of Typesport_eventsJSON is not true for false.");
                  }
              }
            setstart_time_tbd(the_bool);
          }


        private void  fromJSONstatus(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field status of Typesport_eventsJSON is not a string.");
            setstatus(json_string.getData());
          }


        private void  fromJSONtournament(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            TypetournamentJSON convert_classy = TypetournamentJSON.from_json(json_value, ignore_extras, true);
            settournament(convert_classy);
          }


        private void  fromJSONstages(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field stages of Typesport_eventsJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< TypestagesJSON  > vector_stages1 = new List< TypestagesJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                TypestagesJSON convert_classy = TypestagesJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_stages1.Add(convert_classy);
              }
            initstages();
            for (int num1 = 0; num1 < vector_stages1.Count; ++num1)
                appendstages(vector_stages1[num1]);
            for (int num1 = 0; num1 < vector_stages1.Count; ++num1)
              {
              }
          }


        private void  fromJSONcompetitors(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field competitors of Typesport_eventsJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< TypecompetitorsJSON  > vector_competitors1 = new List< TypecompetitorsJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                TypecompetitorsJSON convert_classy = TypecompetitorsJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_competitors1.Add(convert_classy);
              }
            initcompetitors();
            for (int num2 = 0; num2 < vector_competitors1.Count; ++num2)
                appendcompetitors(vector_competitors1[num2]);
            for (int num1 = 0; num1 < vector_competitors1.Count; ++num1)
              {
              }
          }


        public Typesport_eventsJSON()
          {
            flagHasid = false;
            flagHasname = false;
            flagHasscheduled = false;
            flagHasstart_time_tbd = false;
            flagHasstatus = false;
            flagHastournament = false;
            flagHasstages = false;
            flagHascompetitors = false;
            storestages = new List< TypestagesJSON  >();
            storecompetitors = new List< TypecompetitorsJSON  >();
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

        public bool  hasstart_time_tbd()
          {
            return flagHasstart_time_tbd;
          }

        public bool  getstart_time_tbd()
          {
            Debug.Assert(flagHasstart_time_tbd);
            return storestart_time_tbd;
          }

        public bool  hasstatus()
          {
            return flagHasstatus;
          }

        public string  getstatus()
          {
            Debug.Assert(flagHasstatus);
            return storestatus;
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

        public bool  hasstages()
          {
            return flagHasstages;
          }

        public int  countOfstages()
          {
            Debug.Assert(flagHasstages);
            return storestages.Count;
          }

        public TypestagesJSON   elementOfstages(int element_num)
          {
            Debug.Assert(flagHasstages);
            return storestages[element_num];
          }

        public List< TypestagesJSON  >  getstages()
          {
            Debug.Assert(flagHasstages);
            return storestages;
          }

        public bool  hascompetitors()
          {
            return flagHascompetitors;
          }

        public int  countOfcompetitors()
          {
            Debug.Assert(flagHascompetitors);
            return storecompetitors.Count;
          }

        public TypecompetitorsJSON   elementOfcompetitors(int element_num)
          {
            Debug.Assert(flagHascompetitors);
            return storecompetitors[element_num];
          }

        public List< TypecompetitorsJSON  >  getcompetitors()
          {
            Debug.Assert(flagHascompetitors);
            return storecompetitors;
          }


        public virtual int extraTypesport_eventsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypesport_eventsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypesport_eventsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypesport_eventsLookup(string field_name)
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
        public void setstart_time_tbd(bool new_value)
          {
            flagHasstart_time_tbd = true;
            storestart_time_tbd = new_value;
          }
        public void unsetstart_time_tbd()
          {
            flagHasstart_time_tbd = false;
          }
        public void setstatus(string new_value)
          {
            flagHasstatus = true;
            storestatus = new_value;
          }
        public void unsetstatus()
          {
            flagHasstatus = false;
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
        public void initstages()
          {
            if (flagHasstages)
              {
                for (int num1 = 0; num1 < storestages.Count; ++num1)
                  {
                  }
              }
            flagHasstages = true;
            storestages.Clear();
          }
        public void appendstages(TypestagesJSON  to_append)
          {
            if (!flagHasstages)
              {
                flagHasstages = true;
                storestages.Clear();
              }
            Debug.Assert(flagHasstages);
            storestages.Add(to_append);
          }
        public void unsetstages()
          {
            if (flagHasstages)
              {
                for (int num2 = 0; num2 < storestages.Count; ++num2)
                  {
                  }
              }
            flagHasstages = false;
            storestages.Clear();
          }
        public void initcompetitors()
          {
            if (flagHascompetitors)
              {
                for (int num3 = 0; num3 < storecompetitors.Count; ++num3)
                  {
                  }
              }
            flagHascompetitors = true;
            storecompetitors.Clear();
          }
        public void appendcompetitors(TypecompetitorsJSON  to_append)
          {
            if (!flagHascompetitors)
              {
                flagHascompetitors = true;
                storecompetitors.Clear();
              }
            Debug.Assert(flagHascompetitors);
            storecompetitors.Add(to_append);
          }
        public void unsetcompetitors()
          {
            if (flagHascompetitors)
              {
                for (int num4 = 0; num4 < storecompetitors.Count; ++num4)
                  {
                  }
              }
            flagHascompetitors = false;
            storecompetitors.Clear();
          }

        public virtual void extraTypesport_eventsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypesport_eventsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypesport_eventsLookup(key);
            if (old_field == null)
              {
                extraTypesport_eventsAppendPair(key, new_component);
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
            if (flagHasstart_time_tbd)
              {
                handler.start_pair("start_time_tbd");
                handler.boolean_value(storestart_time_tbd);
              }
            if (flagHasstatus)
              {
                handler.start_pair("status");
                handler.string_value(storestatus);
              }
            if (flagHastournament)
              {
                handler.start_pair("tournament");
                if (partial_allowed)
                    storetournament.write_partial_as_json(handler);
                else
                    storetournament.write_as_json(handler);
              }
            if (flagHasstages)
              {
                handler.start_pair("stages");
                handler.start_array();
                for (int num1 = 0; num1 < storestages.Count; ++num1)
                  {
                    if (partial_allowed)
                        storestages[num1].write_partial_as_json(handler);
                    else
                        storestages[num1].write_as_json(handler);
                  }
                handler.finish_array();
              }
            if (flagHascompetitors)
              {
                handler.start_pair("competitors");
                handler.start_array();
                for (int num2 = 0; num2 < storecompetitors.Count; ++num2)
                  {
                    if (partial_allowed)
                        storecompetitors[num2].write_partial_as_json(handler);
                    else
                        storecompetitors[num2].write_as_json(handler);
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

        public static Typesport_eventsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            Typesport_eventsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typesport_events", ignore_extras);
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
        public static Typesport_eventsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static Typesport_eventsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            Typesport_eventsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typesport_events", ignore_extras);
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
        public static Typesport_eventsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static Typesport_eventsJSON from_text(string text, bool ignore_extras)
          {
            Typesport_eventsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typesport_events", ignore_extras);
                JSONParse.parse_json_value(text, "Text for Typesport_eventsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static Typesport_eventsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            Typesport_eventsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typesport_events", ignore_extras);
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
            private JSONHoldingBooleanGenerator fieldGeneratorstart_time_tbd;
            private JSONHoldingStringGenerator fieldGeneratorstatus;
            private TypetournamentJSON.HoldingGenerator fieldGeneratortournament;
            private TypestagesJSON.HoldingArrayGenerator fieldGeneratorstages;
            private TypecompetitorsJSON.HoldingArrayGenerator fieldGeneratorcompetitors;
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
                Typesport_eventsJSON result = new Typesport_eventsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypesport_eventsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(Typesport_eventsJSON result)
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
                if (fieldGeneratorstart_time_tbd.have_value)
                  {
                    result.setstart_time_tbd(fieldGeneratorstart_time_tbd.value);
                    fieldGeneratorstart_time_tbd.have_value = false;
                  }
                if (fieldGeneratorstatus.have_value)
                  {
                    result.setstatus(fieldGeneratorstatus.value);
                    fieldGeneratorstatus.have_value = false;
                  }
                if (fieldGeneratortournament.have_value)
                  {
                    result.settournament(fieldGeneratortournament.value);
                    fieldGeneratortournament.have_value = false;
                  }
                if (fieldGeneratorstages.have_value)
                  {
                    result.initstages();
                    int count = fieldGeneratorstages.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendstages(fieldGeneratorstages.value[num]);
                      }
                    fieldGeneratorstages.value.Clear();
                    fieldGeneratorstages.have_value = false;
                  }
                if (fieldGeneratorcompetitors.have_value)
                  {
                    result.initcompetitors();
                    int count = fieldGeneratorcompetitors.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendcompetitors(fieldGeneratorcompetitors.value[num]);
                      }
                    fieldGeneratorcompetitors.value.Clear();
                    fieldGeneratorcompetitors.have_value = false;
                  }
              }
            protected abstract void handle_result(Typesport_eventsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'c':
                        if ((String.Compare(field_name, 1, "ompetitors", 0, 10, false) == 0) && (field_name.Length == 11))
                            return fieldGeneratorcompetitors;
                        break;
                    case 'i':
                        if ((String.Compare(field_name, 1, "d", 0, 1, false) == 0) && (field_name.Length == 2))
                            return fieldGeneratorid;
                        break;
                    case 'n':
                        if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorname;
                        break;
                    case 's':
                        switch (field_name[1])
                          {
                            case 'c':
                                if ((String.Compare(field_name, 2, "heduled", 0, 7, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorscheduled;
                                break;
                            case 't':
                                if (String.Compare(field_name, 2, "a", 0, 1, false) == 0)
                                  {
                                    switch (field_name[3])
                                      {
                                        case 'g':
                                            if ((String.Compare(field_name, 4, "es", 0, 2, false) == 0) && (field_name.Length == 6))
                                                return fieldGeneratorstages;
                                            break;
                                        case 'r':
                                            if ((String.Compare(field_name, 4, "t_time_tbd", 0, 10, false) == 0) && (field_name.Length == 14))
                                                return fieldGeneratorstart_time_tbd;
                                            break;
                                        case 't':
                                            if ((String.Compare(field_name, 4, "us", 0, 2, false) == 0) && (field_name.Length == 6))
                                                return fieldGeneratorstatus;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            default:
                                break;
                          }
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
                fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the Typesport_events class");
                fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the Typesport_events class");
                fieldGeneratorscheduled = new JSONHoldingStringGenerator("field \"scheduled\" of the Typesport_events class");
                fieldGeneratorstart_time_tbd = new JSONHoldingBooleanGenerator("field \"start_time_tbd\" of the Typesport_events class");
                fieldGeneratorstatus = new JSONHoldingStringGenerator("field \"status\" of the Typesport_events class");
                fieldGeneratortournament = new TypetournamentJSON.HoldingGenerator("field \"tournament\" of the Typesport_events class", ignore_extras);
                fieldGeneratorstages = new TypestagesJSON.HoldingArrayGenerator("field \"stages\" of the Typesport_events class", ignore_extras);
                fieldGeneratorcompetitors = new TypecompetitorsJSON.HoldingArrayGenerator("field \"competitors\" of the Typesport_events class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the Typesport_events class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the Typesport_events class");
                fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the Typesport_events class");
                fieldGeneratorscheduled = new JSONHoldingStringGenerator("field \"scheduled\" of the Typesport_events class");
                fieldGeneratorstart_time_tbd = new JSONHoldingBooleanGenerator("field \"start_time_tbd\" of the Typesport_events class");
                fieldGeneratorstatus = new JSONHoldingStringGenerator("field \"status\" of the Typesport_events class");
                fieldGeneratortournament = new TypetournamentJSON.HoldingGenerator("field \"tournament\" of the Typesport_events class", false);
                fieldGeneratorstages = new TypestagesJSON.HoldingArrayGenerator("field \"stages\" of the Typesport_events class", false);
                fieldGeneratorcompetitors = new TypecompetitorsJSON.HoldingArrayGenerator("field \"competitors\" of the Typesport_events class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the Typesport_events class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorid.reset();
                fieldGeneratorname.reset();
                fieldGeneratorscheduled.reset();
                fieldGeneratorstart_time_tbd.reset();
                fieldGeneratorstatus.reset();
                fieldGeneratortournament.reset();
                fieldGeneratorstages.reset();
                fieldGeneratorcompetitors.reset();
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
            protected override void handle_result(Typesport_eventsJSON  result)
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
            public Typesport_eventsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(Typesport_eventsJSON  result)
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
        protected virtual void handle_result(List<Typesport_eventsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<Typesport_eventsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<Typesport_eventsJSON>();
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
        public List<Typesport_eventsJSON> value;
      };
      };
    private bool flagHassport_events;
    private List< Typesport_eventsJSON  > storesport_events;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONsport_events(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field sport_events of SportsOlympicsAPIEventScheduleJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< Typesport_eventsJSON  > vector_sport_events1 = new List< Typesport_eventsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            Typesport_eventsJSON convert_classy = Typesport_eventsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_sport_events1.Add(convert_classy);
          }
        initsport_events();
        for (int num3 = 0; num3 < vector_sport_events1.Count; ++num3)
            appendsport_events(vector_sport_events1[num3]);
        for (int num1 = 0; num1 < vector_sport_events1.Count; ++num1)
          {
          }
      }


    public SportsOlympicsAPIEventScheduleJSON()
      {
        flagHassport_events = false;
        storesport_events = new List< Typesport_eventsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hassport_events()
      {
        return flagHassport_events;
      }

    public int  countOfsport_events()
      {
        Debug.Assert(flagHassport_events);
        return storesport_events.Count;
      }

    public Typesport_eventsJSON   elementOfsport_events(int element_num)
      {
        Debug.Assert(flagHassport_events);
        return storesport_events[element_num];
      }

    public List< Typesport_eventsJSON  >  getsport_events()
      {
        Debug.Assert(flagHassport_events);
        return storesport_events;
      }


    public virtual int extraSportsOlympicsAPIEventScheduleComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsOlympicsAPIEventScheduleComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsOlympicsAPIEventScheduleComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsOlympicsAPIEventScheduleLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initsport_events()
      {
        if (flagHassport_events)
          {
            for (int num5 = 0; num5 < storesport_events.Count; ++num5)
              {
              }
          }
        flagHassport_events = true;
        storesport_events.Clear();
      }
    public void appendsport_events(Typesport_eventsJSON  to_append)
      {
        if (!flagHassport_events)
          {
            flagHassport_events = true;
            storesport_events.Clear();
          }
        Debug.Assert(flagHassport_events);
        storesport_events.Add(to_append);
      }
    public void unsetsport_events()
      {
        if (flagHassport_events)
          {
            for (int num6 = 0; num6 < storesport_events.Count; ++num6)
              {
              }
          }
        flagHassport_events = false;
        storesport_events.Clear();
      }

    public virtual void extraSportsOlympicsAPIEventScheduleAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsOlympicsAPIEventScheduleSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsOlympicsAPIEventScheduleLookup(key);
        if (old_field == null)
          {
            extraSportsOlympicsAPIEventScheduleAppendPair(key, new_component);
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
        if (flagHassport_events)
          {
            handler.start_pair("sport_events");
            handler.start_array();
            for (int num1 = 0; num1 < storesport_events.Count; ++num1)
              {
                if (partial_allowed)
                    storesport_events[num1].write_partial_as_json(handler);
                else
                    storesport_events[num1].write_as_json(handler);
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

    public static SportsOlympicsAPIEventScheduleJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsAPIEventScheduleJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsAPIEventSchedule", ignore_extras);
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
    public static SportsOlympicsAPIEventScheduleJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsAPIEventScheduleJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsAPIEventScheduleJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsAPIEventSchedule", ignore_extras);
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
    public static SportsOlympicsAPIEventScheduleJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsAPIEventScheduleJSON from_text(string text, bool ignore_extras)
      {
        SportsOlympicsAPIEventScheduleJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsAPIEventSchedule", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsOlympicsAPIEventScheduleJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsOlympicsAPIEventScheduleJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsOlympicsAPIEventScheduleJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsAPIEventSchedule", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private Typesport_eventsJSON.HoldingArrayGenerator fieldGeneratorsport_events;
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
            SportsOlympicsAPIEventScheduleJSON result = new SportsOlympicsAPIEventScheduleJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsOlympicsAPIEventScheduleAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsOlympicsAPIEventScheduleJSON result)
          {
            if (fieldGeneratorsport_events.have_value)
              {
                result.initsport_events();
                int count = fieldGeneratorsport_events.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendsport_events(fieldGeneratorsport_events.value[num]);
                  }
                fieldGeneratorsport_events.value.Clear();
                fieldGeneratorsport_events.have_value = false;
              }
          }
        protected abstract void handle_result(SportsOlympicsAPIEventScheduleJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "sport_events", 0, 12, false) == 0) && (field_name.Length == 12))
                return fieldGeneratorsport_events;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorsport_events = new Typesport_eventsJSON.HoldingArrayGenerator("field \"sport_events\" of the SportsOlympicsAPIEventSchedule class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsOlympicsAPIEventSchedule class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorsport_events = new Typesport_eventsJSON.HoldingArrayGenerator("field \"sport_events\" of the SportsOlympicsAPIEventSchedule class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsOlympicsAPIEventSchedule class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorsport_events.reset();
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
        protected override void handle_result(SportsOlympicsAPIEventScheduleJSON  result)
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
        public SportsOlympicsAPIEventScheduleJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsOlympicsAPIEventScheduleJSON  result)
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
    protected virtual void handle_result(List<SportsOlympicsAPIEventScheduleJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsOlympicsAPIEventScheduleJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsOlympicsAPIEventScheduleJSON>();
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
    public List<SportsOlympicsAPIEventScheduleJSON> value;
  };
  };
