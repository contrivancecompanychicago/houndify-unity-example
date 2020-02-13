/* file "UberDeepLinksJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UberDeepLinksJSON : JSONBase
  {
    private bool flagHasStandardLink;
    private string storeStandardLink;
    private bool flagHasUniversalLink;
    private string storeUniversalLink;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONStandardLink(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field StandardLink of UberDeepLinksJSON is not a string.");
        setStandardLink(json_string.getData());
      }


    private void  fromJSONUniversalLink(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field UniversalLink of UberDeepLinksJSON is not a string.");
        setUniversalLink(json_string.getData());
      }


    public UberDeepLinksJSON()
      {
        flagHasStandardLink = false;
        flagHasUniversalLink = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasStandardLink()
      {
        return flagHasStandardLink;
      }

    public string  getStandardLink()
      {
        Debug.Assert(flagHasStandardLink);
        return storeStandardLink;
      }

    public bool  hasUniversalLink()
      {
        return flagHasUniversalLink;
      }

    public string  getUniversalLink()
      {
        Debug.Assert(flagHasUniversalLink);
        return storeUniversalLink;
      }


    public virtual int extraUberDeepLinksComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUberDeepLinksComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUberDeepLinksComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUberDeepLinksLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setStandardLink(string new_value)
      {
        flagHasStandardLink = true;
        storeStandardLink = new_value;
      }
    public void unsetStandardLink()
      {
        flagHasStandardLink = false;
      }
    public void setUniversalLink(string new_value)
      {
        flagHasUniversalLink = true;
        storeUniversalLink = new_value;
      }
    public void unsetUniversalLink()
      {
        flagHasUniversalLink = false;
      }

    public virtual void extraUberDeepLinksAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUberDeepLinksSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUberDeepLinksLookup(key);
        if (old_field == null)
          {
            extraUberDeepLinksAppendPair(key, new_component);
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
        if (flagHasStandardLink)
          {
            handler.start_pair("StandardLink");
            handler.string_value(storeStandardLink);
          }
        if (flagHasUniversalLink)
          {
            handler.start_pair("UniversalLink");
            handler.string_value(storeUniversalLink);
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

    public static UberDeepLinksJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberDeepLinksJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberDeepLinks", ignore_extras);
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
    public static UberDeepLinksJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberDeepLinksJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberDeepLinksJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberDeepLinks", ignore_extras);
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
    public static UberDeepLinksJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberDeepLinksJSON from_text(string text, bool ignore_extras)
      {
        UberDeepLinksJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberDeepLinks", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UberDeepLinksJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UberDeepLinksJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UberDeepLinksJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberDeepLinks", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorStandardLink;
        private JSONHoldingStringGenerator fieldGeneratorUniversalLink;
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
            UberDeepLinksJSON result = new UberDeepLinksJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUberDeepLinksAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UberDeepLinksJSON result)
          {
            if (fieldGeneratorStandardLink.have_value)
              {
                result.setStandardLink(fieldGeneratorStandardLink.value);
                fieldGeneratorStandardLink.have_value = false;
              }
            if (fieldGeneratorUniversalLink.have_value)
              {
                result.setUniversalLink(fieldGeneratorUniversalLink.value);
                fieldGeneratorUniversalLink.have_value = false;
              }
          }
        protected abstract void handle_result(UberDeepLinksJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'S':
                    if ((String.Compare(field_name, 1, "tandardLink", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorStandardLink;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "niversalLink", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorUniversalLink;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorStandardLink = new JSONHoldingStringGenerator("field \"StandardLink\" of the UberDeepLinks class");
            fieldGeneratorUniversalLink = new JSONHoldingStringGenerator("field \"UniversalLink\" of the UberDeepLinks class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UberDeepLinks class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorStandardLink = new JSONHoldingStringGenerator("field \"StandardLink\" of the UberDeepLinks class");
            fieldGeneratorUniversalLink = new JSONHoldingStringGenerator("field \"UniversalLink\" of the UberDeepLinks class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UberDeepLinks class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorStandardLink.reset();
            fieldGeneratorUniversalLink.reset();
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
        protected override void handle_result(UberDeepLinksJSON  result)
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
        public UberDeepLinksJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UberDeepLinksJSON  result)
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
    protected virtual void handle_result(List<UberDeepLinksJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UberDeepLinksJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UberDeepLinksJSON>();
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
    public List<UberDeepLinksJSON> value;
  };
  };
