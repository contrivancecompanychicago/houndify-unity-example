/* file "StoredPageMatchPageListCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class StoredPageMatchPageListCommandJSON : StoredPageMatchCommandJSON
  {
    private bool flagHasPages;
    private List< string > storePages;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraPagesToJSON()
      {
        JSONArrayValue generated_array_1_Pages = new JSONArrayValue();
        for (int num1 = 0; num1 < storePages.Count; ++num1)
          {
            JSONStringValue generated_string_Pages = new JSONStringValue(storePages[num1]);
            generated_array_1_Pages.appendComponent(generated_string_Pages);
          }
        return generated_array_1_Pages;
      }


    private void  fromJSONPages(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Pages of StoredPageMatchPageListCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_Pages1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field Pages of StoredPageMatchPageListCommandJSON is not a string.");
            vector_Pages1.Add(json_string.getData());
          }
        initPages();
        for (int num1 = 0; num1 < vector_Pages1.Count; ++num1)
            appendPages(vector_Pages1[num1]);
        for (int num1 = 0; num1 < vector_Pages1.Count; ++num1)
          {
          }
      }


    public StoredPageMatchPageListCommandJSON()
      {
        flagHasPages = false;
        storePages = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getStoredPageMatchCommandKind()
      {
        return "PageList";
      }

    public bool  hasPages()
      {
        return flagHasPages;
      }

    public int  countOfPages()
      {
        Debug.Assert(flagHasPages);
        return storePages.Count;
      }

    public string  elementOfPages(int element_num)
      {
        Debug.Assert(flagHasPages);
        return storePages[element_num];
      }

    public List< string >  getPages()
      {
        Debug.Assert(flagHasPages);
        return storePages;
      }


    public virtual int extraStoredPageMatchPageListCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraStoredPageMatchPageListCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraStoredPageMatchPageListCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraStoredPageMatchPageListCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraStoredPageMatchCommandComponentCount()
      {
        int result = 0;
        if (flagHasPages)
            ++result;
        result += extraStoredPageMatchPageListCommandComponentCount();
        return result;
      }
    public override string extraStoredPageMatchCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasPages)
          {
            if (remainder == 0)
                return "Pages";
            --remainder;
          }
        return extraStoredPageMatchPageListCommandComponentKey(remainder);
      }
    public override JSONValue extraStoredPageMatchCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasPages)
          {
            if (remainder == 0)
                return extraPagesToJSON();
            --remainder;
          }
        return extraStoredPageMatchPageListCommandComponentValue(remainder);
      }
    public override JSONValue extraStoredPageMatchCommandLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Pages", 0, 5, false) == 0) && (field_name.Length == 5))
            return (flagHasPages ? extraPagesToJSON() : null);
        return extraStoredPageMatchPageListCommandLookup(field_name);
      }

    public void initPages()
      {
        flagHasPages = true;
        storePages.Clear();
      }
    public void appendPages(string to_append)
      {
        if (!flagHasPages)
          {
            flagHasPages = true;
            storePages.Clear();
          }
        Debug.Assert(flagHasPages);
        storePages.Add(to_append);
      }
    public void unsetPages()
      {
        flagHasPages = false;
        storePages.Clear();
      }

    public virtual void extraStoredPageMatchPageListCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraStoredPageMatchPageListCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraStoredPageMatchPageListCommandLookup(key);
        if (old_field == null)
          {
            extraStoredPageMatchPageListCommandAppendPair(key, new_component);
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
    public override void extraStoredPageMatchCommandAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Pages", 0, 5, false) == 0) && (key.Length == 5))
            {
            fromJSONPages(new_component, false);
            return;
            }
        extraStoredPageMatchPageListCommandAppendPair(key, new_component);
      }
    public override void extraStoredPageMatchCommandSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Pages", 0, 5, false) == 0) && (key.Length == 5))
            {
            fromJSONPages(new_component, false);
            return;
            }
        extraStoredPageMatchPageListCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasPages);
        if (flagHasPages)
          {
            handler.start_pair("Pages");
            handler.start_array();
            for (int num1 = 0; num1 < storePages.Count; ++num1)
              {
                handler.string_value(storePages[num1]);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasPages()))
          {
            return "When parsing the object for %what%, the \"Pages\" field was missing.";
          }
        return null;
      }

    public static new StoredPageMatchPageListCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StoredPageMatchPageListCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StoredPageMatchPageListCommand", ignore_extras);
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
    public static new StoredPageMatchPageListCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new StoredPageMatchPageListCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StoredPageMatchPageListCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StoredPageMatchPageListCommand", ignore_extras);
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
    public static new StoredPageMatchPageListCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new StoredPageMatchPageListCommandJSON from_text(string text, bool ignore_extras)
      {
        StoredPageMatchPageListCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StoredPageMatchPageListCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for StoredPageMatchPageListCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new StoredPageMatchPageListCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        StoredPageMatchPageListCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StoredPageMatchPageListCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : StoredPageMatchCommandJSON.Generator
      {
        private JSONHoldingStringArrayGenerator fieldGeneratorPages;
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
            if (!(getStoredPageMatchCommandJSONKey().Equals("PageList")))
                throw new Exception("The key field has a value other than `PageList'.");
            StoredPageMatchPageListCommandJSON result = new StoredPageMatchPageListCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraStoredPageMatchPageListCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(StoredPageMatchCommandJSON new_result)
          {
            handle_result((StoredPageMatchPageListCommandJSON )new_result);
          }
        protected void finish(StoredPageMatchPageListCommandJSON result)
          {
            if (fieldGeneratorPages.have_value)
              {
                result.initPages();
                int count = fieldGeneratorPages.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendPages(fieldGeneratorPages.value[num]);
                  }
                fieldGeneratorPages.value.Clear();
                fieldGeneratorPages.have_value = false;
              }
            else if ((!(result.hasPages())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Pages\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(StoredPageMatchPageListCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Pages", 0, 5, false) == 0) && (field_name.Length == 5))
                return fieldGeneratorPages;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorPages = new JSONHoldingStringArrayGenerator("field \"Pages\" of the StoredPageMatchPageListCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the StoredPageMatchPageListCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorPages = new JSONHoldingStringArrayGenerator("field \"Pages\" of the StoredPageMatchPageListCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the StoredPageMatchPageListCommand class");
          }

        public override void reset()
          {
            fieldGeneratorPages.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(StoredPageMatchPageListCommandJSON  result)
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
        public StoredPageMatchPageListCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(StoredPageMatchPageListCommandJSON  result)
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
    protected virtual void handle_result(List<StoredPageMatchPageListCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<StoredPageMatchPageListCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<StoredPageMatchPageListCommandJSON>();
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
    public List<StoredPageMatchPageListCommandJSON> value;
  };
  };
