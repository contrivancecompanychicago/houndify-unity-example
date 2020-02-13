/* file "SiriusChannelCommandIntentJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SiriusChannelCommandIntentJSON : RadioCommandIntentJSON
  {
    private bool flagHasChannel;
    private byte storeChannel;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraChannelToJSON()
      {
        JSONIntegerValue generated_integer_Channel = new JSONIntegerValue(storeChannel);
        return generated_integer_Channel;
      }


    private void  fromJSONChannel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        byte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Channel of SiriusChannelCommandIntentJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Channel of SiriusChannelCommandIntentJSON is not an integer.");
              }
            extracted_integer = (byte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (byte)(json_integer.getLongInt())        ;
          }
        setChannel(extracted_integer);
      }


    public SiriusChannelCommandIntentJSON()
      {
        flagHasChannel = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getRadioIntentKind()
      {
        return "SiriusChannel";
      }

    public bool  hasChannel()
      {
        return flagHasChannel;
      }

    public byte  getChannel()
      {
        Debug.Assert(flagHasChannel);
        return storeChannel;
      }


    public virtual int extraSiriusChannelCommandIntentComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSiriusChannelCommandIntentComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSiriusChannelCommandIntentComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSiriusChannelCommandIntentLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraRadioCommandIntentComponentCount()
      {
        int result = 0;
        if (flagHasChannel)
            ++result;
        result += extraSiriusChannelCommandIntentComponentCount();
        return result;
      }
    public override string extraRadioCommandIntentComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasChannel)
          {
            if (remainder == 0)
                return "Channel";
            --remainder;
          }
        return extraSiriusChannelCommandIntentComponentKey(remainder);
      }
    public override JSONValue extraRadioCommandIntentComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasChannel)
          {
            if (remainder == 0)
                return extraChannelToJSON();
            --remainder;
          }
        return extraSiriusChannelCommandIntentComponentValue(remainder);
      }
    public override JSONValue extraRadioCommandIntentLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Channel", 0, 7, false) == 0) && (field_name.Length == 7))
            return (flagHasChannel ? extraChannelToJSON() : null);
        return extraSiriusChannelCommandIntentLookup(field_name);
      }

    public void setChannel(byte new_value)
      {
        flagHasChannel = true;
        if (new_value < 1)
            throw new Exception("The value for field Channel of SiriusChannelCommandIntentJSON is less than the lower bound (1) for that field.");
        if (new_value > 233)
            throw new Exception("The value for field Channel of SiriusChannelCommandIntentJSON is greater than the upper bound (233) for that field.");
        storeChannel = new_value;
      }
    public void unsetChannel()
      {
        flagHasChannel = false;
      }

    public virtual void extraSiriusChannelCommandIntentAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSiriusChannelCommandIntentSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSiriusChannelCommandIntentLookup(key);
        if (old_field == null)
          {
            extraSiriusChannelCommandIntentAppendPair(key, new_component);
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
    public override void extraRadioCommandIntentAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Channel", 0, 7, false) == 0) && (key.Length == 7))
            {
            fromJSONChannel(new_component, false);
            return;
            }
        extraSiriusChannelCommandIntentAppendPair(key, new_component);
      }
    public override void extraRadioCommandIntentSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Channel", 0, 7, false) == 0) && (key.Length == 7))
            {
            fromJSONChannel(new_component, false);
            return;
            }
        extraSiriusChannelCommandIntentSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasChannel);
        if (flagHasChannel)
          {
            handler.start_pair("Channel");
            handler.number_value(storeChannel);
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
        if (!(hasChannel()))
          {
            return "When parsing the object for %what%, the \"Channel\" field was missing.";
          }
        return null;
      }

    public static new SiriusChannelCommandIntentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SiriusChannelCommandIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SiriusChannelCommandIntent", ignore_extras);
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
    public static new SiriusChannelCommandIntentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SiriusChannelCommandIntentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SiriusChannelCommandIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SiriusChannelCommandIntent", ignore_extras);
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
    public static new SiriusChannelCommandIntentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SiriusChannelCommandIntentJSON from_text(string text, bool ignore_extras)
      {
        SiriusChannelCommandIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SiriusChannelCommandIntent", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SiriusChannelCommandIntentJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SiriusChannelCommandIntentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SiriusChannelCommandIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SiriusChannelCommandIntent", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : RadioCommandIntentJSON.Generator
      {
    private class FieldHoldingGeneratorChannel : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorChannel(String what) : base(what, 1, 233)
              {
              }
          };
    private class FieldHoldingArrayGeneratorChannel : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorChannel(String what) : base(what, 1, 233)
              {
              }
          };
        private FieldHoldingGeneratorChannel fieldGeneratorChannel;
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
            if (!(getRadioCommandIntentJSONKey().Equals("SiriusChannel")))
                throw new Exception("The key field has a value other than `SiriusChannel'.");
            SiriusChannelCommandIntentJSON result = new SiriusChannelCommandIntentJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSiriusChannelCommandIntentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(RadioCommandIntentJSON new_result)
          {
            handle_result((SiriusChannelCommandIntentJSON )new_result);
          }
        protected void finish(SiriusChannelCommandIntentJSON result)
          {
            if (fieldGeneratorChannel.have_value)
              {
                result.setChannel((byte)(fieldGeneratorChannel.value));
                fieldGeneratorChannel.have_value = false;
              }
            else if ((!(result.hasChannel())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Channel\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(SiriusChannelCommandIntentJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Channel", 0, 7, false) == 0) && (field_name.Length == 7))
                return fieldGeneratorChannel;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorChannel = new FieldHoldingGeneratorChannel("field \"Channel\" of the SiriusChannelCommandIntent class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SiriusChannelCommandIntent class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorChannel = new FieldHoldingGeneratorChannel("field \"Channel\" of the SiriusChannelCommandIntent class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SiriusChannelCommandIntent class");
          }

        public override void reset()
          {
            fieldGeneratorChannel.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SiriusChannelCommandIntentJSON  result)
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
        public SiriusChannelCommandIntentJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SiriusChannelCommandIntentJSON  result)
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
    protected virtual void handle_result(List<SiriusChannelCommandIntentJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SiriusChannelCommandIntentJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SiriusChannelCommandIntentJSON>();
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
    public List<SiriusChannelCommandIntentJSON> value;
  };
  };
