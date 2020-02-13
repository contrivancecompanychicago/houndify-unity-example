/* file "UberRequestDriverJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UberRequestDriverJSON : JSONBase
  {
    public struct Typepicture_url
      {
        public int key;
        public string choice0;
        public bool choice1;
      };
    private bool flagHasname;
    private string storename;
    private bool flagHasphone_number;
    private string storephone_number;
    private bool flagHasrating;
    private double storerating;
    private string textStorerating;
    private bool flagHaspicture_url;
    private Typepicture_url storepicture_url;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONname(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field name of UberRequestDriverJSON is not a string.");
        setname(json_string.getData());
      }


    private void  fromJSONphone_number(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field phone_number of UberRequestDriverJSON is not a string.");
        setphone_number(json_string.getData());
      }


    private void  fromJSONrating(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field rating of UberRequestDriverJSON is not a number.");
              }
          }
        setratingText(the_rational_text);
      }


    private void  fromJSONpicture_url(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        Typepicture_url or_result = new Typepicture_url();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for ??? is not a string.");
                or_result.choice0 = json_string.getData();
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field picture_url of UberRequestDriverJSON is not one of the allowed values.");
        setpicture_url(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    public UberRequestDriverJSON()
      {
        flagHasname = false;
        flagHasphone_number = false;
        flagHasrating = false;
        flagHaspicture_url = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
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

    public bool  hasphone_number()
      {
        return flagHasphone_number;
      }

    public string  getphone_number()
      {
        Debug.Assert(flagHasphone_number);
        return storephone_number;
      }

    public bool  hasrating()
      {
        return flagHasrating;
      }

    public double  getrating()
      {
        Debug.Assert(flagHasrating);
        if (textStorerating != "")
          {
            return Double.Parse(textStorerating);
          }
        return storerating;
      }

    public string  getratingAsText()
      {
        Debug.Assert(flagHasrating);
        if (textStorerating == "")
          {
            return Convert.ToString(storerating);
          }
        else
          {
            return (textStorerating);
          }
      }

    public bool  haspicture_url()
      {
        return flagHaspicture_url;
      }

    public Typepicture_url  getpicture_url()
      {
        Debug.Assert(flagHaspicture_url);
        return storepicture_url;
      }


    public virtual int extraUberRequestDriverComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUberRequestDriverComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUberRequestDriverComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUberRequestDriverLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
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
    public void setphone_number(string new_value)
      {
        flagHasphone_number = true;
        storephone_number = new_value;
      }
    public void unsetphone_number()
      {
        flagHasphone_number = false;
      }
    public void setrating(double new_value)
      {
        flagHasrating = true;
        storerating = new_value;
        textStorerating = "";
      }
    public void setratingText(string new_value)
      {
        flagHasrating = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field rating of UberRequestDriverJSON is not a valid number.");
        textStorerating = new_value;
      }
    public void unsetrating()
      {
        flagHasrating = false;
      }
    public void setpicture_url(Typepicture_url new_value)
      {
        flagHaspicture_url = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storepicture_url = new_value;
      }
    public void unsetpicture_url()
      {
        flagHaspicture_url = false;
      }

    public virtual void extraUberRequestDriverAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUberRequestDriverSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUberRequestDriverLookup(key);
        if (old_field == null)
          {
            extraUberRequestDriverAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasname);
        if (flagHasname)
          {
            handler.start_pair("name");
            handler.string_value(storename);
          }
        Debug.Assert(partial_allowed || flagHasphone_number);
        if (flagHasphone_number)
          {
            handler.start_pair("phone_number");
            handler.string_value(storephone_number);
          }
        Debug.Assert(partial_allowed || flagHasrating);
        if (flagHasrating)
          {
            handler.start_pair("rating");
            if (textStorerating != "")
                handler.number_value(textStorerating);
            else if (((double)(long)storerating) == storerating)
                handler.number_value((long)storerating);
            else
                handler.number_value(storerating);
          }
        Debug.Assert(partial_allowed || flagHaspicture_url);
        if (flagHaspicture_url)
          {
            handler.start_pair("picture_url");
            switch (storepicture_url.key)
              {
                case 0:
                    handler.string_value(storepicture_url.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
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
        if (!(hasname()))
          {
            return "When parsing the object for %what%, the \"name\" field was missing.";
          }
        if (!(hasphone_number()))
          {
            return "When parsing the object for %what%, the \"phone_number\" field was missing.";
          }
        if (!(hasrating()))
          {
            return "When parsing the object for %what%, the \"rating\" field was missing.";
          }
        if (!(haspicture_url()))
          {
            return "When parsing the object for %what%, the \"picture_url\" field was missing.";
          }
        return null;
      }

    public static UberRequestDriverJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberRequestDriverJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestDriver", ignore_extras);
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
    public static UberRequestDriverJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberRequestDriverJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberRequestDriverJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestDriver", ignore_extras);
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
    public static UberRequestDriverJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberRequestDriverJSON from_text(string text, bool ignore_extras)
      {
        UberRequestDriverJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestDriver", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UberRequestDriverJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UberRequestDriverJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UberRequestDriverJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestDriver", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorname;
        private JSONHoldingStringGenerator fieldGeneratorphone_number;
        private JSONHoldingNumberTextGenerator fieldGeneratorrating;
    private abstract class FieldGeneratorpicture_url : JSONParallelGenerator
          {
            private JSONHoldingStringGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                Typepicture_url result = new Typepicture_url();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(Typepicture_url result);
            public FieldGeneratorpicture_url(bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"picture_url\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"picture_url\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorpicture_url(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"picture_url\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"picture_url\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class Holderpicture_url
          {
            private bool have_data;
            private Typepicture_url data;
            public Holderpicture_url()  { have_data = false; }
            public Holderpicture_url(Typepicture_url init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public Holderpicture_url(Holderpicture_url other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public Typepicture_url referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorpicture_url : FieldGeneratorpicture_url
          {
            protected override void handle_result(Typepicture_url result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new Holderpicture_url(result);
              }

            public FieldHoldingGeneratorpicture_url(String what, bool ignore_extras) : base(ignore_extras)
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
            public Holderpicture_url value;
          };
    private class FieldHoldingArrayGeneratorpicture_url : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorpicture_url
      {
        private FieldHoldingArrayGeneratorpicture_url top;

        protected override void handle_result(Typepicture_url result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorpicture_url init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<Typepicture_url> result)
      {
      }

    public FieldHoldingArrayGeneratorpicture_url(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typepicture_url>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorpicture_url(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typepicture_url>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<Typepicture_url> value;
  };
        private FieldHoldingGeneratorpicture_url fieldGeneratorpicture_url;
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
            UberRequestDriverJSON result = new UberRequestDriverJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUberRequestDriverAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UberRequestDriverJSON result)
          {
            if (fieldGeneratorname.have_value)
              {
                result.setname(fieldGeneratorname.value);
                fieldGeneratorname.have_value = false;
              }
            else if ((!(result.hasname())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"name\" field was missing.");
              }
            if (fieldGeneratorphone_number.have_value)
              {
                result.setphone_number(fieldGeneratorphone_number.value);
                fieldGeneratorphone_number.have_value = false;
              }
            else if ((!(result.hasphone_number())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"phone_number\" field was missing.");
              }
            if (fieldGeneratorrating.have_value)
              {
                result.setratingText(fieldGeneratorrating.value);
                fieldGeneratorrating.have_value = false;
              }
            else if ((!(result.hasrating())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"rating\" field was missing.");
              }
            if (fieldGeneratorpicture_url.have_value)
              {
                result.setpicture_url(fieldGeneratorpicture_url.value.referenced());
                fieldGeneratorpicture_url.have_value = false;
              }
            else if ((!(result.haspicture_url())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"picture_url\" field was missing.");
              }
          }
        protected abstract void handle_result(UberRequestDriverJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'n':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorname;
                    break;
                case 'p':
                    switch (field_name[1])
                      {
                        case 'h':
                            if ((String.Compare(field_name, 2, "one_number", 0, 10, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorphone_number;
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "cture_url", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorpicture_url;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'r':
                    if ((String.Compare(field_name, 1, "ating", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorrating;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the UberRequestDriver class");
            fieldGeneratorphone_number = new JSONHoldingStringGenerator("field \"phone_number\" of the UberRequestDriver class");
            fieldGeneratorrating = new JSONHoldingNumberTextGenerator("field \"rating\" of the UberRequestDriver class");
            fieldGeneratorpicture_url = new FieldHoldingGeneratorpicture_url("field \"picture_url\" of the UberRequestDriver class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UberRequestDriver class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the UberRequestDriver class");
            fieldGeneratorphone_number = new JSONHoldingStringGenerator("field \"phone_number\" of the UberRequestDriver class");
            fieldGeneratorrating = new JSONHoldingNumberTextGenerator("field \"rating\" of the UberRequestDriver class");
            fieldGeneratorpicture_url = new FieldHoldingGeneratorpicture_url("field \"picture_url\" of the UberRequestDriver class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UberRequestDriver class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorname.reset();
            fieldGeneratorphone_number.reset();
            fieldGeneratorrating.reset();
            fieldGeneratorpicture_url.reset();
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
        protected override void handle_result(UberRequestDriverJSON  result)
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
        public UberRequestDriverJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UberRequestDriverJSON  result)
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
    protected virtual void handle_result(List<UberRequestDriverJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UberRequestDriverJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UberRequestDriverJSON>();
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
    public List<UberRequestDriverJSON> value;
  };
  };
