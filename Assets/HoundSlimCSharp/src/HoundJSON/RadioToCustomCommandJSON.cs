/* file "RadioToCustomCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RadioToCustomCommandJSON : RadioCommandJSON
  {
    private bool flagHasSource;
    private string storeSource;
    private bool flagHasSpokenForm;
    private string storeSpokenForm;
    private bool flagHasWrittenForm;
    private string storeWrittenForm;
    private bool flagHasAlreadyOnResult;
    private DynamicResponseJSON  storeAlreadyOnResult;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraSourceToJSON()
      {
        JSONStringValue generated_string_Source = new JSONStringValue(storeSource);
        return generated_string_Source;
      }

    private JSONValue  extraSpokenFormToJSON()
      {
        JSONStringValue generated_string_SpokenForm = new JSONStringValue(storeSpokenForm);
        return generated_string_SpokenForm;
      }

    private JSONValue  extraWrittenFormToJSON()
      {
        JSONStringValue generated_string_WrittenForm = new JSONStringValue(storeWrittenForm);
        return generated_string_WrittenForm;
      }

    private JSONValue  extraAlreadyOnResultToJSON()
      {
        JSONValueHandler handler_AlreadyOnResult = new JSONValueHandler();
        storeAlreadyOnResult.write_as_json(handler_AlreadyOnResult);
        return handler_AlreadyOnResult.result;
      }


    private void  fromJSONSource(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Source of RadioToCustomCommandJSON is not a string.");
        setSource(json_string.getData());
      }


    private void  fromJSONSpokenForm(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenForm of RadioToCustomCommandJSON is not a string.");
        setSpokenForm(json_string.getData());
      }


    private void  fromJSONWrittenForm(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenForm of RadioToCustomCommandJSON is not a string.");
        setWrittenForm(json_string.getData());
      }


    private void  fromJSONAlreadyOnResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setAlreadyOnResult(convert_classy);
      }


    public RadioToCustomCommandJSON()
      {
        flagHasSource = false;
        flagHasSpokenForm = false;
        flagHasWrittenForm = false;
        flagHasAlreadyOnResult = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getRadioCommandKind()
      {
        return "RadioToCustom";
      }

    public bool  hasSource()
      {
        return flagHasSource;
      }

    public string  getSource()
      {
        Debug.Assert(flagHasSource);
        return storeSource;
      }

    public bool  hasSpokenForm()
      {
        return flagHasSpokenForm;
      }

    public string  getSpokenForm()
      {
        Debug.Assert(flagHasSpokenForm);
        return storeSpokenForm;
      }

    public bool  hasWrittenForm()
      {
        return flagHasWrittenForm;
      }

    public string  getWrittenForm()
      {
        Debug.Assert(flagHasWrittenForm);
        return storeWrittenForm;
      }

    public bool  hasAlreadyOnResult()
      {
        return flagHasAlreadyOnResult;
      }

    public DynamicResponseJSON   getAlreadyOnResult()
      {
        Debug.Assert(flagHasAlreadyOnResult);
        return storeAlreadyOnResult;
      }


    public virtual int extraRadioToCustomCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRadioToCustomCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRadioToCustomCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRadioToCustomCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraRadioCommandComponentCount()
      {
        int result = 0;
        if (flagHasSource)
            ++result;
        if (flagHasSpokenForm)
            ++result;
        if (flagHasWrittenForm)
            ++result;
        if (flagHasAlreadyOnResult)
            ++result;
        result += extraRadioToCustomCommandComponentCount();
        return result;
      }
    public override string extraRadioCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasSource)
          {
            if (remainder == 0)
                return "Source";
            --remainder;
          }
        if (flagHasSpokenForm)
          {
            if (remainder == 0)
                return "SpokenForm";
            --remainder;
          }
        if (flagHasWrittenForm)
          {
            if (remainder == 0)
                return "WrittenForm";
            --remainder;
          }
        if (flagHasAlreadyOnResult)
          {
            if (remainder == 0)
                return "AlreadyOnResult";
            --remainder;
          }
        return extraRadioToCustomCommandComponentKey(remainder);
      }
    public override JSONValue extraRadioCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasSource)
          {
            if (remainder == 0)
                return extraSourceToJSON();
            --remainder;
          }
        if (flagHasSpokenForm)
          {
            if (remainder == 0)
                return extraSpokenFormToJSON();
            --remainder;
          }
        if (flagHasWrittenForm)
          {
            if (remainder == 0)
                return extraWrittenFormToJSON();
            --remainder;
          }
        if (flagHasAlreadyOnResult)
          {
            if (remainder == 0)
                return extraAlreadyOnResultToJSON();
            --remainder;
          }
        return extraRadioToCustomCommandComponentValue(remainder);
      }
    public override JSONValue extraRadioCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "lreadyOnResult", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasAlreadyOnResult ? extraAlreadyOnResultToJSON() : null);
                break;
            case 'S':
                switch (field_name[1])
                  {
                    case 'o':
                        if ((String.Compare(field_name, 2, "urce", 0, 4, false) == 0) && (field_name.Length == 6))
                            return (flagHasSource ? extraSourceToJSON() : null);
                        break;
                    case 'p':
                        if ((String.Compare(field_name, 2, "okenForm", 0, 8, false) == 0) && (field_name.Length == 10))
                            return (flagHasSpokenForm ? extraSpokenFormToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'W':
                if ((String.Compare(field_name, 1, "rittenForm", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasWrittenForm ? extraWrittenFormToJSON() : null);
                break;
            default:
                break;
          }
        return extraRadioToCustomCommandLookup(field_name);
      }

    public void setSource(string new_value)
      {
        flagHasSource = true;
        storeSource = new_value;
      }
    public void unsetSource()
      {
        flagHasSource = false;
      }
    public void setSpokenForm(string new_value)
      {
        flagHasSpokenForm = true;
        storeSpokenForm = new_value;
      }
    public void unsetSpokenForm()
      {
        flagHasSpokenForm = false;
      }
    public void setWrittenForm(string new_value)
      {
        flagHasWrittenForm = true;
        storeWrittenForm = new_value;
      }
    public void unsetWrittenForm()
      {
        flagHasWrittenForm = false;
      }
    public void setAlreadyOnResult(DynamicResponseJSON  new_value)
      {
        if (flagHasAlreadyOnResult)
          {
          }
        flagHasAlreadyOnResult = true;
        storeAlreadyOnResult = new_value;
      }
    public void unsetAlreadyOnResult()
      {
        if (flagHasAlreadyOnResult)
          {
          }
        flagHasAlreadyOnResult = false;
      }

    public virtual void extraRadioToCustomCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRadioToCustomCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRadioToCustomCommandLookup(key);
        if (old_field == null)
          {
            extraRadioToCustomCommandAppendPair(key, new_component);
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
    public override void extraRadioCommandAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "lreadyOnResult", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONAlreadyOnResult(new_component, false);
                    return;
                    }
                break;
            case 'S':
                switch (key[1])
                  {
                    case 'o':
                        if ((String.Compare(key, 2, "urce", 0, 4, false) == 0) && (key.Length == 6))
                            {
                            fromJSONSource(new_component, false);
                            return;
                            }
                        break;
                    case 'p':
                        if ((String.Compare(key, 2, "okenForm", 0, 8, false) == 0) && (key.Length == 10))
                            {
                            fromJSONSpokenForm(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'W':
                if ((String.Compare(key, 1, "rittenForm", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONWrittenForm(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraRadioToCustomCommandAppendPair(key, new_component);
      }
    public override void extraRadioCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "lreadyOnResult", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONAlreadyOnResult(new_component, false);
                    return;
                    }
                break;
            case 'S':
                switch (key[1])
                  {
                    case 'o':
                        if ((String.Compare(key, 2, "urce", 0, 4, false) == 0) && (key.Length == 6))
                            {
                            fromJSONSource(new_component, false);
                            return;
                            }
                        break;
                    case 'p':
                        if ((String.Compare(key, 2, "okenForm", 0, 8, false) == 0) && (key.Length == 10))
                            {
                            fromJSONSpokenForm(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'W':
                if ((String.Compare(key, 1, "rittenForm", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONWrittenForm(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraRadioToCustomCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasSource);
        if (flagHasSource)
          {
            handler.start_pair("Source");
            handler.string_value(storeSource);
          }
        Debug.Assert(partial_allowed || flagHasSpokenForm);
        if (flagHasSpokenForm)
          {
            handler.start_pair("SpokenForm");
            handler.string_value(storeSpokenForm);
          }
        Debug.Assert(partial_allowed || flagHasWrittenForm);
        if (flagHasWrittenForm)
          {
            handler.start_pair("WrittenForm");
            handler.string_value(storeWrittenForm);
          }
        Debug.Assert(partial_allowed || flagHasAlreadyOnResult);
        if (flagHasAlreadyOnResult)
          {
            handler.start_pair("AlreadyOnResult");
            if (partial_allowed)
                storeAlreadyOnResult.write_partial_as_json(handler);
            else
                storeAlreadyOnResult.write_as_json(handler);
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
        if (!(hasSource()))
          {
            return "When parsing the object for %what%, the \"Source\" field was missing.";
          }
        if (!(hasSpokenForm()))
          {
            return "When parsing the object for %what%, the \"SpokenForm\" field was missing.";
          }
        if (!(hasWrittenForm()))
          {
            return "When parsing the object for %what%, the \"WrittenForm\" field was missing.";
          }
        if (!(hasAlreadyOnResult()))
          {
            return "When parsing the object for %what%, the \"AlreadyOnResult\" field was missing.";
          }
        return null;
      }

    public static new RadioToCustomCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RadioToCustomCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioToCustomCommand", ignore_extras);
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
    public static new RadioToCustomCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RadioToCustomCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RadioToCustomCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioToCustomCommand", ignore_extras);
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
    public static new RadioToCustomCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RadioToCustomCommandJSON from_text(string text, bool ignore_extras)
      {
        RadioToCustomCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioToCustomCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RadioToCustomCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new RadioToCustomCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RadioToCustomCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioToCustomCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : RadioCommandJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorSource;
        private JSONHoldingStringGenerator fieldGeneratorSpokenForm;
        private JSONHoldingStringGenerator fieldGeneratorWrittenForm;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorAlreadyOnResult;
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
            if (!(getRadioCommandJSONKey().Equals("RadioToCustom")))
                throw new Exception("The key field has a value other than `RadioToCustom'.");
            RadioToCustomCommandJSON result = new RadioToCustomCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRadioToCustomCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(RadioCommandJSON new_result)
          {
            handle_result((RadioToCustomCommandJSON )new_result);
          }
        protected void finish(RadioToCustomCommandJSON result)
          {
            if (fieldGeneratorSource.have_value)
              {
                result.setSource(fieldGeneratorSource.value);
                fieldGeneratorSource.have_value = false;
              }
            else if ((!(result.hasSource())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Source\" field was missing.");
              }
            if (fieldGeneratorSpokenForm.have_value)
              {
                result.setSpokenForm(fieldGeneratorSpokenForm.value);
                fieldGeneratorSpokenForm.have_value = false;
              }
            else if ((!(result.hasSpokenForm())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SpokenForm\" field was missing.");
              }
            if (fieldGeneratorWrittenForm.have_value)
              {
                result.setWrittenForm(fieldGeneratorWrittenForm.value);
                fieldGeneratorWrittenForm.have_value = false;
              }
            else if ((!(result.hasWrittenForm())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"WrittenForm\" field was missing.");
              }
            if (fieldGeneratorAlreadyOnResult.have_value)
              {
                result.setAlreadyOnResult(fieldGeneratorAlreadyOnResult.value);
                fieldGeneratorAlreadyOnResult.have_value = false;
              }
            else if ((!(result.hasAlreadyOnResult())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AlreadyOnResult\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(RadioToCustomCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "lreadyOnResult", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorAlreadyOnResult;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'o':
                            if ((String.Compare(field_name, 2, "urce", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorSource;
                            break;
                        case 'p':
                            if ((String.Compare(field_name, 2, "okenForm", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorSpokenForm;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "rittenForm", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorWrittenForm;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorSource = new JSONHoldingStringGenerator("field \"Source\" of the RadioToCustomCommand class");
            fieldGeneratorSpokenForm = new JSONHoldingStringGenerator("field \"SpokenForm\" of the RadioToCustomCommand class");
            fieldGeneratorWrittenForm = new JSONHoldingStringGenerator("field \"WrittenForm\" of the RadioToCustomCommand class");
            fieldGeneratorAlreadyOnResult = new DynamicResponseJSON.HoldingGenerator("field \"AlreadyOnResult\" of the RadioToCustomCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RadioToCustomCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorSource = new JSONHoldingStringGenerator("field \"Source\" of the RadioToCustomCommand class");
            fieldGeneratorSpokenForm = new JSONHoldingStringGenerator("field \"SpokenForm\" of the RadioToCustomCommand class");
            fieldGeneratorWrittenForm = new JSONHoldingStringGenerator("field \"WrittenForm\" of the RadioToCustomCommand class");
            fieldGeneratorAlreadyOnResult = new DynamicResponseJSON.HoldingGenerator("field \"AlreadyOnResult\" of the RadioToCustomCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RadioToCustomCommand class");
          }

        public override void reset()
          {
            fieldGeneratorSource.reset();
            fieldGeneratorSpokenForm.reset();
            fieldGeneratorWrittenForm.reset();
            fieldGeneratorAlreadyOnResult.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(RadioToCustomCommandJSON  result)
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
        public RadioToCustomCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RadioToCustomCommandJSON  result)
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
    protected virtual void handle_result(List<RadioToCustomCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RadioToCustomCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RadioToCustomCommandJSON>();
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
    public List<RadioToCustomCommandJSON> value;
  };
  };
