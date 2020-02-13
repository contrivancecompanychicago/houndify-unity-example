/* file "SportsPlayersArgumentJerseyNumberJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SportsPlayersArgumentJerseyNumberJSON : SportsPlayersArgumentJSON
  {
    private bool flagHasJerseyNumber;
    private BigInteger storeJerseyNumber;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraJerseyNumberToJSON()
      {
        JSONIntegerValue generated_integer_JerseyNumber = new JSONIntegerValue(storeJerseyNumber);
        return generated_integer_JerseyNumber;
      }


    private void  fromJSONJerseyNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field JerseyNumber of SportsPlayersArgumentJerseyNumberJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field JerseyNumber of SportsPlayersArgumentJerseyNumberJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setJerseyNumber(extracted_integer);
      }


    public SportsPlayersArgumentJerseyNumberJSON()
      {
        flagHasJerseyNumber = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getSportsPlayersArgumentKind()
      {
        return "JerseyNumber";
      }

    public bool  hasJerseyNumber()
      {
        return flagHasJerseyNumber;
      }

    public BigInteger  getJerseyNumber()
      {
        Debug.Assert(flagHasJerseyNumber);
        return storeJerseyNumber;
      }


    public virtual int extraSportsPlayersArgumentJerseyNumberComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsPlayersArgumentJerseyNumberComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsPlayersArgumentJerseyNumberComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsPlayersArgumentJerseyNumberLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSportsPlayersArgumentComponentCount()
      {
        int result = 0;
        if (flagHasJerseyNumber)
            ++result;
        result += extraSportsPlayersArgumentJerseyNumberComponentCount();
        return result;
      }
    public override string extraSportsPlayersArgumentComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasJerseyNumber)
          {
            if (remainder == 0)
                return "JerseyNumber";
            --remainder;
          }
        return extraSportsPlayersArgumentJerseyNumberComponentKey(remainder);
      }
    public override JSONValue extraSportsPlayersArgumentComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasJerseyNumber)
          {
            if (remainder == 0)
                return extraJerseyNumberToJSON();
            --remainder;
          }
        return extraSportsPlayersArgumentJerseyNumberComponentValue(remainder);
      }
    public override JSONValue extraSportsPlayersArgumentLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "JerseyNumber", 0, 12, false) == 0) && (field_name.Length == 12))
            return (flagHasJerseyNumber ? extraJerseyNumberToJSON() : null);
        return extraSportsPlayersArgumentJerseyNumberLookup(field_name);
      }

    public void setJerseyNumber(BigInteger new_value)
      {
        flagHasJerseyNumber = true;
        if (new_value < 0)
            throw new Exception("The value for field JerseyNumber of SportsPlayersArgumentJerseyNumberJSON is less than the lower bound (0) for that field.");
        storeJerseyNumber = new_value;
      }
    public void unsetJerseyNumber()
      {
        flagHasJerseyNumber = false;
      }

    public virtual void extraSportsPlayersArgumentJerseyNumberAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsPlayersArgumentJerseyNumberSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsPlayersArgumentJerseyNumberLookup(key);
        if (old_field == null)
          {
            extraSportsPlayersArgumentJerseyNumberAppendPair(key, new_component);
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
    public override void extraSportsPlayersArgumentAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "JerseyNumber", 0, 12, false) == 0) && (key.Length == 12))
            {
            fromJSONJerseyNumber(new_component, false);
            return;
            }
        extraSportsPlayersArgumentJerseyNumberAppendPair(key, new_component);
      }
    public override void extraSportsPlayersArgumentSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "JerseyNumber", 0, 12, false) == 0) && (key.Length == 12))
            {
            fromJSONJerseyNumber(new_component, false);
            return;
            }
        extraSportsPlayersArgumentJerseyNumberSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasJerseyNumber);
        if (flagHasJerseyNumber)
          {
            handler.start_pair("JerseyNumber");
            handler.number_value(storeJerseyNumber);
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
        if (!(hasJerseyNumber()))
          {
            return "When parsing the object for %what%, the \"JerseyNumber\" field was missing.";
          }
        return null;
      }

    public static new SportsPlayersArgumentJerseyNumberJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsPlayersArgumentJerseyNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayersArgumentJerseyNumber", ignore_extras);
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
    public static new SportsPlayersArgumentJerseyNumberJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsPlayersArgumentJerseyNumberJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsPlayersArgumentJerseyNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayersArgumentJerseyNumber", ignore_extras);
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
    public static new SportsPlayersArgumentJerseyNumberJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsPlayersArgumentJerseyNumberJSON from_text(string text, bool ignore_extras)
      {
        SportsPlayersArgumentJerseyNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayersArgumentJerseyNumber", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsPlayersArgumentJerseyNumberJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SportsPlayersArgumentJerseyNumberJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsPlayersArgumentJerseyNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayersArgumentJerseyNumber", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SportsPlayersArgumentJSON.Generator
      {
    private class FieldHoldingGeneratorJerseyNumber : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorJerseyNumber(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorJerseyNumber : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorJerseyNumber(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorJerseyNumber fieldGeneratorJerseyNumber;
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
            if (!(getSportsPlayersArgumentJSONKey().Equals("JerseyNumber")))
                throw new Exception("The key field has a value other than `JerseyNumber'.");
            SportsPlayersArgumentJerseyNumberJSON result = new SportsPlayersArgumentJerseyNumberJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsPlayersArgumentJerseyNumberAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SportsPlayersArgumentJSON new_result)
          {
            handle_result((SportsPlayersArgumentJerseyNumberJSON )new_result);
          }
        protected void finish(SportsPlayersArgumentJerseyNumberJSON result)
          {
            if (fieldGeneratorJerseyNumber.have_value)
              {
                result.setJerseyNumber(fieldGeneratorJerseyNumber.value);
                fieldGeneratorJerseyNumber.have_value = false;
              }
            else if ((!(result.hasJerseyNumber())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"JerseyNumber\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(SportsPlayersArgumentJerseyNumberJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "JerseyNumber", 0, 12, false) == 0) && (field_name.Length == 12))
                return fieldGeneratorJerseyNumber;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorJerseyNumber = new FieldHoldingGeneratorJerseyNumber("field \"JerseyNumber\" of the SportsPlayersArgumentJerseyNumber class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsPlayersArgumentJerseyNumber class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorJerseyNumber = new FieldHoldingGeneratorJerseyNumber("field \"JerseyNumber\" of the SportsPlayersArgumentJerseyNumber class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsPlayersArgumentJerseyNumber class");
          }

        public override void reset()
          {
            fieldGeneratorJerseyNumber.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsPlayersArgumentJerseyNumberJSON  result)
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
        public SportsPlayersArgumentJerseyNumberJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsPlayersArgumentJerseyNumberJSON  result)
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
    protected virtual void handle_result(List<SportsPlayersArgumentJerseyNumberJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsPlayersArgumentJerseyNumberJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsPlayersArgumentJerseyNumberJSON>();
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
    public List<SportsPlayersArgumentJerseyNumberJSON> value;
  };
  };
