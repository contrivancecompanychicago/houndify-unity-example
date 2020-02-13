/* file "ReadInputOverrideCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ReadInputOverrideCommandJSON : CommandResultJSON
  {
    private bool flagHasFunctionText;
    private string storeFunctionText;
    private bool flagHasFunctionLanguage;
    private string storeFunctionLanguage;
    private bool flagHasFunctionSource;
    private UploadedCodeSourceJSON  storeFunctionSource;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraFunctionTextToJSON()
      {
        JSONStringValue generated_string_FunctionText = new JSONStringValue(storeFunctionText);
        return generated_string_FunctionText;
      }

    private JSONValue  extraFunctionLanguageToJSON()
      {
        JSONStringValue generated_string_FunctionLanguage = new JSONStringValue(storeFunctionLanguage);
        return generated_string_FunctionLanguage;
      }

    private JSONValue  extraFunctionSourceToJSON()
      {
        JSONValueHandler handler_FunctionSource = new JSONValueHandler();
        storeFunctionSource.write_as_json(handler_FunctionSource);
        return handler_FunctionSource.result;
      }


    private void  fromJSONFunctionText(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FunctionText of ReadInputOverrideCommandJSON is not a string.");
        setFunctionText(json_string.getData());
      }


    private void  fromJSONFunctionLanguage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FunctionLanguage of ReadInputOverrideCommandJSON is not a string.");
        setFunctionLanguage(json_string.getData());
      }


    private void  fromJSONFunctionSource(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UploadedCodeSourceJSON convert_classy = UploadedCodeSourceJSON.from_json(json_value, ignore_extras, true);
        setFunctionSource(convert_classy);
      }


    public ReadInputOverrideCommandJSON()
      {
        flagHasFunctionText = false;
        flagHasFunctionLanguage = false;
        flagHasFunctionSource = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getCommandKind()
      {
        return "ReadInputOverride";
      }

    public bool  hasFunctionText()
      {
        return flagHasFunctionText;
      }

    public string  getFunctionText()
      {
        Debug.Assert(flagHasFunctionText);
        return storeFunctionText;
      }

    public bool  hasFunctionLanguage()
      {
        return flagHasFunctionLanguage;
      }

    public string  getFunctionLanguage()
      {
        Debug.Assert(flagHasFunctionLanguage);
        return storeFunctionLanguage;
      }

    public bool  hasFunctionSource()
      {
        return flagHasFunctionSource;
      }

    public UploadedCodeSourceJSON   getFunctionSource()
      {
        Debug.Assert(flagHasFunctionSource);
        return storeFunctionSource;
      }


    public virtual int extraReadInputOverrideCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraReadInputOverrideCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraReadInputOverrideCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraReadInputOverrideCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCommandResultComponentCount()
      {
        int result = 0;
        if (flagHasFunctionText)
            ++result;
        if (flagHasFunctionLanguage)
            ++result;
        if (flagHasFunctionSource)
            ++result;
        result += extraReadInputOverrideCommandComponentCount();
        return result;
      }
    public override string extraCommandResultComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasFunctionText)
          {
            if (remainder == 0)
                return "FunctionText";
            --remainder;
          }
        if (flagHasFunctionLanguage)
          {
            if (remainder == 0)
                return "FunctionLanguage";
            --remainder;
          }
        if (flagHasFunctionSource)
          {
            if (remainder == 0)
                return "FunctionSource";
            --remainder;
          }
        return extraReadInputOverrideCommandComponentKey(remainder);
      }
    public override JSONValue extraCommandResultComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasFunctionText)
          {
            if (remainder == 0)
                return extraFunctionTextToJSON();
            --remainder;
          }
        if (flagHasFunctionLanguage)
          {
            if (remainder == 0)
                return extraFunctionLanguageToJSON();
            --remainder;
          }
        if (flagHasFunctionSource)
          {
            if (remainder == 0)
                return extraFunctionSourceToJSON();
            --remainder;
          }
        return extraReadInputOverrideCommandComponentValue(remainder);
      }
    public override JSONValue extraCommandResultLookup(string field_name)
      {
        if (String.Compare(field_name, 0, "Function", 0, 8, false) == 0)
          {
            switch (field_name[8])
              {
                case 'L':
                    if ((String.Compare(field_name, 9, "anguage", 0, 7, false) == 0) && (field_name.Length == 16))
                        return (flagHasFunctionLanguage ? extraFunctionLanguageToJSON() : null);
                    break;
                case 'S':
                    if ((String.Compare(field_name, 9, "ource", 0, 5, false) == 0) && (field_name.Length == 14))
                        return (flagHasFunctionSource ? extraFunctionSourceToJSON() : null);
                    break;
                case 'T':
                    if ((String.Compare(field_name, 9, "ext", 0, 3, false) == 0) && (field_name.Length == 12))
                        return (flagHasFunctionText ? extraFunctionTextToJSON() : null);
                    break;
                default:
                    break;
              }
          }
        return extraReadInputOverrideCommandLookup(field_name);
      }

    public void setFunctionText(string new_value)
      {
        flagHasFunctionText = true;
        storeFunctionText = new_value;
      }
    public void unsetFunctionText()
      {
        flagHasFunctionText = false;
      }
    public void setFunctionLanguage(string new_value)
      {
        flagHasFunctionLanguage = true;
        storeFunctionLanguage = new_value;
      }
    public void unsetFunctionLanguage()
      {
        flagHasFunctionLanguage = false;
      }
    public void setFunctionSource(UploadedCodeSourceJSON  new_value)
      {
        if (flagHasFunctionSource)
          {
          }
        flagHasFunctionSource = true;
        storeFunctionSource = new_value;
      }
    public void unsetFunctionSource()
      {
        if (flagHasFunctionSource)
          {
          }
        flagHasFunctionSource = false;
      }

    public virtual void extraReadInputOverrideCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraReadInputOverrideCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraReadInputOverrideCommandLookup(key);
        if (old_field == null)
          {
            extraReadInputOverrideCommandAppendPair(key, new_component);
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
    public override void extraCommandResultAppendPair(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "Function", 0, 8, false) == 0)
          {
            switch (key[8])
              {
                case 'L':
                    if ((String.Compare(key, 9, "anguage", 0, 7, false) == 0) && (key.Length == 16))
                        {
                        fromJSONFunctionLanguage(new_component, false);
                        return;
                        }
                    break;
                case 'S':
                    if ((String.Compare(key, 9, "ource", 0, 5, false) == 0) && (key.Length == 14))
                        {
                        fromJSONFunctionSource(new_component, false);
                        return;
                        }
                    break;
                case 'T':
                    if ((String.Compare(key, 9, "ext", 0, 3, false) == 0) && (key.Length == 12))
                        {
                        fromJSONFunctionText(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraReadInputOverrideCommandAppendPair(key, new_component);
      }
    public override void extraCommandResultSetField(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "Function", 0, 8, false) == 0)
          {
            switch (key[8])
              {
                case 'L':
                    if ((String.Compare(key, 9, "anguage", 0, 7, false) == 0) && (key.Length == 16))
                        {
                        fromJSONFunctionLanguage(new_component, false);
                        return;
                        }
                    break;
                case 'S':
                    if ((String.Compare(key, 9, "ource", 0, 5, false) == 0) && (key.Length == 14))
                        {
                        fromJSONFunctionSource(new_component, false);
                        return;
                        }
                    break;
                case 'T':
                    if ((String.Compare(key, 9, "ext", 0, 3, false) == 0) && (key.Length == 12))
                        {
                        fromJSONFunctionText(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraReadInputOverrideCommandSetField(key, new_component);
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
        if (flagHasFunctionText)
          {
            handler.start_pair("FunctionText");
            handler.string_value(storeFunctionText);
          }
        if (flagHasFunctionLanguage)
          {
            handler.start_pair("FunctionLanguage");
            handler.string_value(storeFunctionLanguage);
          }
        if (flagHasFunctionSource)
          {
            handler.start_pair("FunctionSource");
            if (partial_allowed)
                storeFunctionSource.write_partial_as_json(handler);
            else
                storeFunctionSource.write_as_json(handler);
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
        return null;
      }

    public static new ReadInputOverrideCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ReadInputOverrideCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ReadInputOverrideCommand", ignore_extras);
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
    public static new ReadInputOverrideCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ReadInputOverrideCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ReadInputOverrideCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ReadInputOverrideCommand", ignore_extras);
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
    public static new ReadInputOverrideCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ReadInputOverrideCommandJSON from_text(string text, bool ignore_extras)
      {
        ReadInputOverrideCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ReadInputOverrideCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ReadInputOverrideCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ReadInputOverrideCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ReadInputOverrideCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ReadInputOverrideCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandResultJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorFunctionText;
        private JSONHoldingStringGenerator fieldGeneratorFunctionLanguage;
        private UploadedCodeSourceJSON.HoldingGenerator fieldGeneratorFunctionSource;
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
            if (!(getCommandResultJSONKey().Equals("ReadInputOverride")))
                throw new Exception("The key field has a value other than `ReadInputOverride'.");
            ReadInputOverrideCommandJSON result = new ReadInputOverrideCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraReadInputOverrideCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CommandResultJSON new_result)
          {
            handle_result((ReadInputOverrideCommandJSON )new_result);
          }
        protected void finish(ReadInputOverrideCommandJSON result)
          {
            if (fieldGeneratorFunctionText.have_value)
              {
                result.setFunctionText(fieldGeneratorFunctionText.value);
                fieldGeneratorFunctionText.have_value = false;
              }
            if (fieldGeneratorFunctionLanguage.have_value)
              {
                result.setFunctionLanguage(fieldGeneratorFunctionLanguage.value);
                fieldGeneratorFunctionLanguage.have_value = false;
              }
            if (fieldGeneratorFunctionSource.have_value)
              {
                result.setFunctionSource(fieldGeneratorFunctionSource.value);
                fieldGeneratorFunctionSource.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(ReadInputOverrideCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "Function", 0, 8, false) == 0)
              {
                switch (field_name[8])
                  {
                    case 'L':
                        if ((String.Compare(field_name, 9, "anguage", 0, 7, false) == 0) && (field_name.Length == 16))
                            return fieldGeneratorFunctionLanguage;
                        break;
                    case 'S':
                        if ((String.Compare(field_name, 9, "ource", 0, 5, false) == 0) && (field_name.Length == 14))
                            return fieldGeneratorFunctionSource;
                        break;
                    case 'T':
                        if ((String.Compare(field_name, 9, "ext", 0, 3, false) == 0) && (field_name.Length == 12))
                            return fieldGeneratorFunctionText;
                        break;
                    default:
                        break;
                  }
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorFunctionText = new JSONHoldingStringGenerator("field \"FunctionText\" of the ReadInputOverrideCommand class");
            fieldGeneratorFunctionLanguage = new JSONHoldingStringGenerator("field \"FunctionLanguage\" of the ReadInputOverrideCommand class");
            fieldGeneratorFunctionSource = new UploadedCodeSourceJSON.HoldingGenerator("field \"FunctionSource\" of the ReadInputOverrideCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ReadInputOverrideCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorFunctionText = new JSONHoldingStringGenerator("field \"FunctionText\" of the ReadInputOverrideCommand class");
            fieldGeneratorFunctionLanguage = new JSONHoldingStringGenerator("field \"FunctionLanguage\" of the ReadInputOverrideCommand class");
            fieldGeneratorFunctionSource = new UploadedCodeSourceJSON.HoldingGenerator("field \"FunctionSource\" of the ReadInputOverrideCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ReadInputOverrideCommand class");
          }

        public override void reset()
          {
            fieldGeneratorFunctionText.reset();
            fieldGeneratorFunctionLanguage.reset();
            fieldGeneratorFunctionSource.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ReadInputOverrideCommandJSON  result)
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
        public ReadInputOverrideCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ReadInputOverrideCommandJSON  result)
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
    protected virtual void handle_result(List<ReadInputOverrideCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ReadInputOverrideCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ReadInputOverrideCommandJSON>();
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
    public List<ReadInputOverrideCommandJSON> value;
  };
  };
