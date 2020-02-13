/* file "FiniteIntegerBuildingNumberJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class FiniteIntegerBuildingNumberJSON : BuildingNumberJSON
  {
    private bool flagHasNumber;
    private BigInteger storeNumber;
    private bool flagHasDigitCount;
    private BigInteger storeDigitCount;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraNumberToJSON()
      {
        JSONIntegerValue generated_integer_Number = new JSONIntegerValue(storeNumber);
        return generated_integer_Number;
      }

    private JSONValue  extraDigitCountToJSON()
      {
        JSONIntegerValue generated_integer_DigitCount = new JSONIntegerValue(storeDigitCount);
        return generated_integer_DigitCount;
      }


    private void  fromJSONNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Number of FiniteIntegerBuildingNumberJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Number of FiniteIntegerBuildingNumberJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setNumber(extracted_integer);
      }


    private void  fromJSONDigitCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field DigitCount of FiniteIntegerBuildingNumberJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field DigitCount of FiniteIntegerBuildingNumberJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setDigitCount(extracted_integer);
      }


    public FiniteIntegerBuildingNumberJSON()
      {
        flagHasNumber = false;
        flagHasDigitCount = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getKind()
      {
        return "FiniteInteger";
      }

    public bool  hasNumber()
      {
        return flagHasNumber;
      }

    public BigInteger  getNumber()
      {
        Debug.Assert(flagHasNumber);
        return storeNumber;
      }

    public bool  hasDigitCount()
      {
        return flagHasDigitCount;
      }

    public BigInteger  getDigitCount()
      {
        Debug.Assert(flagHasDigitCount);
        return storeDigitCount;
      }


    public virtual int extraFiniteIntegerBuildingNumberComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFiniteIntegerBuildingNumberComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFiniteIntegerBuildingNumberComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFiniteIntegerBuildingNumberLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraBuildingNumberComponentCount()
      {
        int result = 0;
        if (flagHasNumber)
            ++result;
        if (flagHasDigitCount)
            ++result;
        result += extraFiniteIntegerBuildingNumberComponentCount();
        return result;
      }
    public override string extraBuildingNumberComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasNumber)
          {
            if (remainder == 0)
                return "Number";
            --remainder;
          }
        if (flagHasDigitCount)
          {
            if (remainder == 0)
                return "DigitCount";
            --remainder;
          }
        return extraFiniteIntegerBuildingNumberComponentKey(remainder);
      }
    public override JSONValue extraBuildingNumberComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasNumber)
          {
            if (remainder == 0)
                return extraNumberToJSON();
            --remainder;
          }
        if (flagHasDigitCount)
          {
            if (remainder == 0)
                return extraDigitCountToJSON();
            --remainder;
          }
        return extraFiniteIntegerBuildingNumberComponentValue(remainder);
      }
    public override JSONValue extraBuildingNumberLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'D':
                if ((String.Compare(field_name, 1, "igitCount", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasDigitCount ? extraDigitCountToJSON() : null);
                break;
            case 'N':
                if ((String.Compare(field_name, 1, "umber", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasNumber ? extraNumberToJSON() : null);
                break;
            default:
                break;
          }
        return extraFiniteIntegerBuildingNumberLookup(field_name);
      }

    public void setNumber(BigInteger new_value)
      {
        flagHasNumber = true;
        storeNumber = new_value;
      }
    public void unsetNumber()
      {
        flagHasNumber = false;
      }
    public void setDigitCount(BigInteger new_value)
      {
        flagHasDigitCount = true;
        if (new_value < 1)
            throw new Exception("The value for field DigitCount of FiniteIntegerBuildingNumberJSON is less than the lower bound (1) for that field.");
        storeDigitCount = new_value;
      }
    public void unsetDigitCount()
      {
        flagHasDigitCount = false;
      }

    public virtual void extraFiniteIntegerBuildingNumberAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFiniteIntegerBuildingNumberSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFiniteIntegerBuildingNumberLookup(key);
        if (old_field == null)
          {
            extraFiniteIntegerBuildingNumberAppendPair(key, new_component);
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
    public override void extraBuildingNumberAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if ((String.Compare(key, 1, "igitCount", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONDigitCount(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if ((String.Compare(key, 1, "umber", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONNumber(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraFiniteIntegerBuildingNumberAppendPair(key, new_component);
      }
    public override void extraBuildingNumberSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if ((String.Compare(key, 1, "igitCount", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONDigitCount(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if ((String.Compare(key, 1, "umber", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONNumber(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraFiniteIntegerBuildingNumberSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasNumber);
        if (flagHasNumber)
          {
            handler.start_pair("Number");
            handler.number_value(storeNumber);
          }
        if (flagHasDigitCount)
          {
            handler.start_pair("DigitCount");
            handler.number_value(storeDigitCount);
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
        if (!(hasNumber()))
          {
            return "When parsing the object for %what%, the \"Number\" field was missing.";
          }
        return null;
      }

    public static new FiniteIntegerBuildingNumberJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FiniteIntegerBuildingNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FiniteIntegerBuildingNumber", ignore_extras);
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
    public static new FiniteIntegerBuildingNumberJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new FiniteIntegerBuildingNumberJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FiniteIntegerBuildingNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FiniteIntegerBuildingNumber", ignore_extras);
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
    public static new FiniteIntegerBuildingNumberJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new FiniteIntegerBuildingNumberJSON from_text(string text, bool ignore_extras)
      {
        FiniteIntegerBuildingNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FiniteIntegerBuildingNumber", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FiniteIntegerBuildingNumberJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new FiniteIntegerBuildingNumberJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FiniteIntegerBuildingNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FiniteIntegerBuildingNumber", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : BuildingNumberJSON.Generator
      {
    private class FieldHoldingGeneratorNumber : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorNumber(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorNumber : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorNumber(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorNumber fieldGeneratorNumber;
    private class FieldHoldingGeneratorDigitCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorDigitCount(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorDigitCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorDigitCount(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorDigitCount fieldGeneratorDigitCount;
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
            if (!(getBuildingNumberJSONKey().Equals("FiniteInteger")))
                throw new Exception("The key field has a value other than `FiniteInteger'.");
            FiniteIntegerBuildingNumberJSON result = new FiniteIntegerBuildingNumberJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFiniteIntegerBuildingNumberAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(BuildingNumberJSON new_result)
          {
            handle_result((FiniteIntegerBuildingNumberJSON )new_result);
          }
        protected void finish(FiniteIntegerBuildingNumberJSON result)
          {
            if (fieldGeneratorNumber.have_value)
              {
                result.setNumber(fieldGeneratorNumber.value);
                fieldGeneratorNumber.have_value = false;
              }
            else if ((!(result.hasNumber())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Number\" field was missing.");
              }
            if (fieldGeneratorDigitCount.have_value)
              {
                result.setDigitCount(fieldGeneratorDigitCount.value);
                fieldGeneratorDigitCount.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(FiniteIntegerBuildingNumberJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "igitCount", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorDigitCount;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "umber", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorNumber;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorNumber = new FieldHoldingGeneratorNumber("field \"Number\" of the FiniteIntegerBuildingNumber class");
            fieldGeneratorDigitCount = new FieldHoldingGeneratorDigitCount("field \"DigitCount\" of the FiniteIntegerBuildingNumber class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FiniteIntegerBuildingNumber class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNumber = new FieldHoldingGeneratorNumber("field \"Number\" of the FiniteIntegerBuildingNumber class");
            fieldGeneratorDigitCount = new FieldHoldingGeneratorDigitCount("field \"DigitCount\" of the FiniteIntegerBuildingNumber class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FiniteIntegerBuildingNumber class");
          }

        public override void reset()
          {
            fieldGeneratorNumber.reset();
            fieldGeneratorDigitCount.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(FiniteIntegerBuildingNumberJSON  result)
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
        public FiniteIntegerBuildingNumberJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FiniteIntegerBuildingNumberJSON  result)
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
    protected virtual void handle_result(List<FiniteIntegerBuildingNumberJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FiniteIntegerBuildingNumberJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FiniteIntegerBuildingNumberJSON>();
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
    public List<FiniteIntegerBuildingNumberJSON> value;
  };
  };
