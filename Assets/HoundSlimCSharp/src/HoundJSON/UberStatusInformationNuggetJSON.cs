/* file "UberStatusInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UberStatusInformationNuggetJSON : UberInformationNuggetJSON
  {
    private bool flagHasUberRequest;
    private UberCompositeRequestJSON  storeUberRequest;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraUberRequestToJSON()
      {
        JSONValueHandler handler_UberRequest = new JSONValueHandler();
        storeUberRequest.write_as_json(handler_UberRequest);
        return handler_UberRequest.result;
      }


    private void  fromJSONUberRequest(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UberCompositeRequestJSON convert_classy = UberCompositeRequestJSON.from_json(json_value, ignore_extras, true);
        setUberRequest(convert_classy);
      }


    public UberStatusInformationNuggetJSON()
      {
        flagHasUberRequest = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getUberNuggetKind()
      {
        return "UberStatus";
      }

    public bool  hasUberRequest()
      {
        return flagHasUberRequest;
      }

    public UberCompositeRequestJSON   getUberRequest()
      {
        Debug.Assert(flagHasUberRequest);
        return storeUberRequest;
      }


    public virtual int extraUberStatusInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUberStatusInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUberStatusInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUberStatusInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraUberInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasUberRequest)
            ++result;
        result += extraUberStatusInformationNuggetComponentCount();
        return result;
      }
    public override string extraUberInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasUberRequest)
          {
            if (remainder == 0)
                return "UberRequest";
            --remainder;
          }
        return extraUberStatusInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraUberInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasUberRequest)
          {
            if (remainder == 0)
                return extraUberRequestToJSON();
            --remainder;
          }
        return extraUberStatusInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraUberInformationNuggetLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "UberRequest", 0, 11, false) == 0) && (field_name.Length == 11))
            return (flagHasUberRequest ? extraUberRequestToJSON() : null);
        return extraUberStatusInformationNuggetLookup(field_name);
      }

    public void setUberRequest(UberCompositeRequestJSON  new_value)
      {
        if (flagHasUberRequest)
          {
          }
        flagHasUberRequest = true;
        storeUberRequest = new_value;
      }
    public void unsetUberRequest()
      {
        if (flagHasUberRequest)
          {
          }
        flagHasUberRequest = false;
      }

    public virtual void extraUberStatusInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUberStatusInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUberStatusInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraUberStatusInformationNuggetAppendPair(key, new_component);
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
    public override void extraUberInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "UberRequest", 0, 11, false) == 0) && (key.Length == 11))
            {
            fromJSONUberRequest(new_component, false);
            return;
            }
        extraUberStatusInformationNuggetAppendPair(key, new_component);
      }
    public override void extraUberInformationNuggetSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "UberRequest", 0, 11, false) == 0) && (key.Length == 11))
            {
            fromJSONUberRequest(new_component, false);
            return;
            }
        extraUberStatusInformationNuggetSetField(key, new_component);
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
        if (flagHasUberRequest)
          {
            handler.start_pair("UberRequest");
            if (partial_allowed)
                storeUberRequest.write_partial_as_json(handler);
            else
                storeUberRequest.write_as_json(handler);
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

    public static new UberStatusInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberStatusInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberStatusInformationNugget", ignore_extras);
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
    public static new UberStatusInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UberStatusInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberStatusInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberStatusInformationNugget", ignore_extras);
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
    public static new UberStatusInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UberStatusInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        UberStatusInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberStatusInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UberStatusInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new UberStatusInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UberStatusInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberStatusInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : UberInformationNuggetJSON.Generator
      {
        private UberCompositeRequestJSON.HoldingGenerator fieldGeneratorUberRequest;
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
            if (!(getUberInformationNuggetJSONKey().Equals("UberStatus")))
                throw new Exception("The key field has a value other than `UberStatus'.");
            UberStatusInformationNuggetJSON result = new UberStatusInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUberStatusInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(UberInformationNuggetJSON new_result)
          {
            handle_result((UberStatusInformationNuggetJSON )new_result);
          }
        protected void finish(UberStatusInformationNuggetJSON result)
          {
            if (fieldGeneratorUberRequest.have_value)
              {
                result.setUberRequest(fieldGeneratorUberRequest.value);
                fieldGeneratorUberRequest.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(UberStatusInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "UberRequest", 0, 11, false) == 0) && (field_name.Length == 11))
                return fieldGeneratorUberRequest;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorUberRequest = new UberCompositeRequestJSON.HoldingGenerator("field \"UberRequest\" of the UberStatusInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UberStatusInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorUberRequest = new UberCompositeRequestJSON.HoldingGenerator("field \"UberRequest\" of the UberStatusInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UberStatusInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorUberRequest.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(UberStatusInformationNuggetJSON  result)
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
        public UberStatusInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UberStatusInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<UberStatusInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UberStatusInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UberStatusInformationNuggetJSON>();
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
    public List<UberStatusInformationNuggetJSON> value;
  };
  };