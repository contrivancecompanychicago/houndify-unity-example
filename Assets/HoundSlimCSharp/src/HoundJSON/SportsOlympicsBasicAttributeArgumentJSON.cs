/* file "SportsOlympicsBasicAttributeArgumentJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public abstract class SportsOlympicsBasicAttributeArgumentJSON : JSONBase
  {
    private bool flagHasArgumentID;
    private BigInteger storeArgumentID;


    private void  fromJSONArgumentID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ArgumentID of SportsOlympicsBasicAttributeArgumentJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ArgumentID of SportsOlympicsBasicAttributeArgumentJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setArgumentID(extracted_integer);
      }


    public SportsOlympicsBasicAttributeArgumentJSON()
      {
        flagHasArgumentID = false;
      }

    public abstract string getSportsOlympicsBasicAttributeArgumentKind();
    public bool  hasArgumentID()
      {
        return flagHasArgumentID;
      }

    public BigInteger  getArgumentID()
      {
        Debug.Assert(flagHasArgumentID);
        return storeArgumentID;
      }


    public abstract int extraSportsOlympicsBasicAttributeArgumentComponentCount();
    public abstract string extraSportsOlympicsBasicAttributeArgumentComponentKey(int component_num);
    public abstract JSONValue extraSportsOlympicsBasicAttributeArgumentComponentValue(int component_num);
    public abstract JSONValue extraSportsOlympicsBasicAttributeArgumentLookup(string field_name);

    public void setArgumentID(BigInteger new_value)
      {
        flagHasArgumentID = true;
        if (new_value < 0)
            throw new Exception("The value for field ArgumentID of SportsOlympicsBasicAttributeArgumentJSON is less than the lower bound (0) for that field.");
        storeArgumentID = new_value;
      }
    public void unsetArgumentID()
      {
        flagHasArgumentID = false;
      }

    public abstract void extraSportsOlympicsBasicAttributeArgumentAppendPair(string key, JSONValue new_component);
    public abstract void extraSportsOlympicsBasicAttributeArgumentSetField(string key, JSONValue new_component);

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public virtual void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        handler.pair("SportsOlympicsBasicAttributeArgumentKind", getSportsOlympicsBasicAttributeArgumentKind());
        Debug.Assert(partial_allowed || flagHasArgumentID);
        if (flagHasArgumentID)
          {
            handler.start_pair("ArgumentID");
            handler.number_value(storeArgumentID);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public virtual string missing_field_error(bool allow_unpolished)
      {
        if (!(hasArgumentID()))
          {
            return "When parsing the object for %what%, the \"ArgumentID\" field was missing.";
          }
        return null;
      }

    public static SportsOlympicsBasicAttributeArgumentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsBasicAttributeArgumentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsBasicAttributeArgument", ignore_extras);
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
    public static SportsOlympicsBasicAttributeArgumentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsBasicAttributeArgumentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsBasicAttributeArgumentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsBasicAttributeArgument", ignore_extras);
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
    public static SportsOlympicsBasicAttributeArgumentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsBasicAttributeArgumentJSON from_text(string text, bool ignore_extras)
      {
        SportsOlympicsBasicAttributeArgumentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsBasicAttributeArgument", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsOlympicsBasicAttributeArgumentJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsOlympicsBasicAttributeArgumentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsOlympicsBasicAttributeArgumentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsBasicAttributeArgument", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorArgumentID : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorArgumentID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorArgumentID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorArgumentID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorArgumentID fieldGeneratorArgumentID;
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
        private JSONHoldingStringGenerator keyGenerator;

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
            if (!(keyGenerator.have_value))
                throw new Exception("The `SportsOlympicsBasicAttributeArgumentKind' field is missing.");
            SportsOlympicsBasicAttributeArgumentJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsOlympicsBasicAttributeArgumentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            if (!allow_incomplete)
              {
                string missing_field_error = result.missing_field_error(allow_unpolished);
                if (missing_field_error != null)
                    error(missing_field_error);
              }
            handle_result(result);
          }
        protected string getSportsOlympicsBasicAttributeArgumentJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `SportsOlympicsBasicAttributeArgumentKind' field is missing.");
            return keyGenerator.value;
          }
        protected void finish(SportsOlympicsBasicAttributeArgumentJSON result)
          {
            if (fieldGeneratorArgumentID.have_value)
              {
                result.setArgumentID(fieldGeneratorArgumentID.value);
                fieldGeneratorArgumentID.have_value = false;
              }
            else if ((!(result.hasArgumentID())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ArgumentID\" field was missing.");
              }
          }
        protected abstract void handle_result(SportsOlympicsBasicAttributeArgumentJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "rgumentID", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorArgumentID;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "portsOlympicsBasicAttributeArgumentKind", 0, 39, false) == 0) && (field_name.Length == 40))
                        {
                        keyGenerator.reset();
                        return keyGenerator;
                        }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorArgumentID = new FieldHoldingGeneratorArgumentID("field \"ArgumentID\" of the SportsOlympicsBasicAttributeArgument class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"SportsOlympicsBasicAttributeArgumentKind\" of the SportsOlympicsBasicAttributeArgument class");
            set_what("the SportsOlympicsBasicAttributeArgument class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorArgumentID = new FieldHoldingGeneratorArgumentID("field \"ArgumentID\" of the SportsOlympicsBasicAttributeArgument class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"SportsOlympicsBasicAttributeArgumentKind\" of the SportsOlympicsBasicAttributeArgument class");
            set_what("the SportsOlympicsBasicAttributeArgument class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorArgumentID.reset();
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
        protected override void handle_result(SportsOlympicsBasicAttributeArgumentJSON  result)
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
        public SportsOlympicsBasicAttributeArgumentJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsOlympicsBasicAttributeArgumentJSON  result)
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
    protected virtual void handle_result(List<SportsOlympicsBasicAttributeArgumentJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsOlympicsBasicAttributeArgumentJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsOlympicsBasicAttributeArgumentJSON>();
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
    public List<SportsOlympicsBasicAttributeArgumentJSON> value;
  };
    class GenericSportsOlympicsBasicAttributeArgumentJSON : SportsOlympicsBasicAttributeArgumentJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericSportsOlympicsBasicAttributeArgumentJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getSportsOlympicsBasicAttributeArgumentKind()  { return key; }
        public override int extraSportsOlympicsBasicAttributeArgumentComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraSportsOlympicsBasicAttributeArgumentComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraSportsOlympicsBasicAttributeArgumentComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraSportsOlympicsBasicAttributeArgumentLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraSportsOlympicsBasicAttributeArgumentAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraSportsOlympicsBasicAttributeArgumentSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraSportsOlympicsBasicAttributeArgumentLookup(key);
            if (old_field == null)
              {
                extraSportsOlympicsBasicAttributeArgumentAppendPair(key, new_component);
              }
            else
              {
                int count = extraKeys.Count;
                Debug.Assert(count == extraValues.Count);
                for (int num = 0; num < count; ++num)
                  {
                    if (extraKeys[num].Equals(key))
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
      };
    public static SportsOlympicsBasicAttributeArgumentJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    switch (key[0])
      {
        case 'H':
            if ((String.Compare(key, 1, "ost", 0, 3, false) == 0) && (key.Length == 4))
                return new SportsOlympicsBasicAttributeArgumentHostJSON();
            break;
        case 'L':
            if ((String.Compare(key, 1, "ast", 0, 3, false) == 0) && (key.Length == 4))
                return new SportsOlympicsBasicAttributeArgumentLastJSON();
            break;
        case 'N':
            if ((String.Compare(key, 1, "ext", 0, 3, false) == 0) && (key.Length == 4))
                return new SportsOlympicsBasicAttributeArgumentNextJSON();
            break;
        case 'Q':
            if ((String.Compare(key, 1, "ueryType", 0, 8, false) == 0) && (key.Length == 9))
                return new SportsOlympicsBasicAttributeArgumentQueryTypeJSON();
            break;
        case 'S':
            if ((String.Compare(key, 1, "eason", 0, 5, false) == 0) && (key.Length == 6))
                return new SportsOlympicsBasicAttributeArgumentSeasonJSON();
            break;
        case 'Y':
            if ((String.Compare(key, 1, "ear", 0, 3, false) == 0) && (key.Length == 4))
                return new SportsOlympicsBasicAttributeArgumentYearJSON();
            break;
        default:
            break;
      }

        return new GenericSportsOlympicsBasicAttributeArgumentJSON(key);
      }
  };
