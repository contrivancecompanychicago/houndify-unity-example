/* file "SportsPlayersArgumentPositionJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsPlayersArgumentPositionJSON : SportsPlayersArgumentJSON
  {
    private bool flagHasPosition;
    private List< SportsPlayerPositionJSON  > storePosition;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraPositionToJSON()
      {
        JSONArrayValue generated_array_1_Position = new JSONArrayValue();
        for (int num1 = 0; num1 < storePosition.Count; ++num1)
          {
            JSONValueHandler handler_Position = new JSONValueHandler();
            storePosition[num1].write_as_json(handler_Position);
            generated_array_1_Position.appendComponent(handler_Position.result);
          }
        return generated_array_1_Position;
      }


    private void  fromJSONPosition(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Position of SportsPlayersArgumentPositionJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Position of SportsPlayersArgumentPositionJSON has too few elements.");
        List< SportsPlayerPositionJSON  > vector_Position1 = new List< SportsPlayerPositionJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsPlayerPositionJSON convert_classy = SportsPlayerPositionJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Position1.Add(convert_classy);
          }
        Debug.Assert(vector_Position1.Count >= 1);
        initPosition();
        for (int num1 = 0; num1 < vector_Position1.Count; ++num1)
            appendPosition(vector_Position1[num1]);
        for (int num1 = 0; num1 < vector_Position1.Count; ++num1)
          {
          }
      }


    public SportsPlayersArgumentPositionJSON()
      {
        flagHasPosition = false;
        storePosition = new List< SportsPlayerPositionJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getSportsPlayersArgumentKind()
      {
        return "Position";
      }

    public bool  hasPosition()
      {
        return flagHasPosition;
      }

    public int  countOfPosition()
      {
        Debug.Assert(flagHasPosition);
        return storePosition.Count;
      }

    public SportsPlayerPositionJSON   elementOfPosition(int element_num)
      {
        Debug.Assert(flagHasPosition);
        return storePosition[element_num];
      }

    public List< SportsPlayerPositionJSON  >  getPosition()
      {
        Debug.Assert(flagHasPosition);
        return storePosition;
      }


    public virtual int extraSportsPlayersArgumentPositionComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsPlayersArgumentPositionComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsPlayersArgumentPositionComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsPlayersArgumentPositionLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSportsPlayersArgumentComponentCount()
      {
        int result = 0;
        if (flagHasPosition)
            ++result;
        result += extraSportsPlayersArgumentPositionComponentCount();
        return result;
      }
    public override string extraSportsPlayersArgumentComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasPosition)
          {
            if (remainder == 0)
                return "Position";
            --remainder;
          }
        return extraSportsPlayersArgumentPositionComponentKey(remainder);
      }
    public override JSONValue extraSportsPlayersArgumentComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasPosition)
          {
            if (remainder == 0)
                return extraPositionToJSON();
            --remainder;
          }
        return extraSportsPlayersArgumentPositionComponentValue(remainder);
      }
    public override JSONValue extraSportsPlayersArgumentLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Position", 0, 8, false) == 0) && (field_name.Length == 8))
            return (flagHasPosition ? extraPositionToJSON() : null);
        return extraSportsPlayersArgumentPositionLookup(field_name);
      }

    public void initPosition()
      {
        if (flagHasPosition)
          {
            for (int num1 = 0; num1 < storePosition.Count; ++num1)
              {
              }
          }
        flagHasPosition = true;
        storePosition.Clear();
      }
    public void appendPosition(SportsPlayerPositionJSON  to_append)
      {
        if (!flagHasPosition)
          {
            flagHasPosition = true;
            storePosition.Clear();
          }
        Debug.Assert(flagHasPosition);
        storePosition.Add(to_append);
      }
    public void appendPosition(SportsPlayerPositionJSON.TypeValue new_value)
      {
        appendPosition(new SportsPlayerPositionJSON(new_value));
      }
    public void appendPosition(string chars)
      {
        SportsPlayerPositionJSON.TypeValueKnownValues known = SportsPlayerPositionJSON.stringToValue(chars);
        SportsPlayerPositionJSON.TypeValue new_value = new SportsPlayerPositionJSON.TypeValue();
        if (known == SportsPlayerPositionJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendPosition(new_value);
      }
    public void unsetPosition()
      {
        if (flagHasPosition)
          {
            for (int num2 = 0; num2 < storePosition.Count; ++num2)
              {
              }
          }
        flagHasPosition = false;
        storePosition.Clear();
      }

    public virtual void extraSportsPlayersArgumentPositionAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsPlayersArgumentPositionSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsPlayersArgumentPositionLookup(key);
        if (old_field == null)
          {
            extraSportsPlayersArgumentPositionAppendPair(key, new_component);
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
        if ((String.Compare(key, 0, "Position", 0, 8, false) == 0) && (key.Length == 8))
            {
            fromJSONPosition(new_component, false);
            return;
            }
        extraSportsPlayersArgumentPositionAppendPair(key, new_component);
      }
    public override void extraSportsPlayersArgumentSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Position", 0, 8, false) == 0) && (key.Length == 8))
            {
            fromJSONPosition(new_component, false);
            return;
            }
        extraSportsPlayersArgumentPositionSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasPosition);
        if (flagHasPosition)
          {
            handler.start_pair("Position");
            Debug.Assert(storePosition.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storePosition.Count; ++num1)
              {
                if (partial_allowed)
                    storePosition[num1].write_partial_as_json(handler);
                else
                    storePosition[num1].write_as_json(handler);
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
        if (!(hasPosition()))
          {
            return "When parsing the object for %what%, the \"Position\" field was missing.";
          }
        return null;
      }

    public static new SportsPlayersArgumentPositionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsPlayersArgumentPositionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayersArgumentPosition", ignore_extras);
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
    public static new SportsPlayersArgumentPositionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsPlayersArgumentPositionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsPlayersArgumentPositionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayersArgumentPosition", ignore_extras);
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
    public static new SportsPlayersArgumentPositionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsPlayersArgumentPositionJSON from_text(string text, bool ignore_extras)
      {
        SportsPlayersArgumentPositionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayersArgumentPosition", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsPlayersArgumentPositionJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SportsPlayersArgumentPositionJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsPlayersArgumentPositionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayersArgumentPosition", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SportsPlayersArgumentJSON.Generator
      {
        private SportsPlayerPositionJSON.HoldingArrayGenerator fieldGeneratorPosition;
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
            if (!(getSportsPlayersArgumentJSONKey().Equals("Position")))
                throw new Exception("The key field has a value other than `Position'.");
            SportsPlayersArgumentPositionJSON result = new SportsPlayersArgumentPositionJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsPlayersArgumentPositionAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SportsPlayersArgumentJSON new_result)
          {
            handle_result((SportsPlayersArgumentPositionJSON )new_result);
          }
        protected void finish(SportsPlayersArgumentPositionJSON result)
          {
            if (fieldGeneratorPosition.have_value)
              {
                result.initPosition();
                int count = fieldGeneratorPosition.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendPosition(fieldGeneratorPosition.value[num]);
                  }
                fieldGeneratorPosition.value.Clear();
                fieldGeneratorPosition.have_value = false;
              }
            else if ((!(result.hasPosition())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Position\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(SportsPlayersArgumentPositionJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Position", 0, 8, false) == 0) && (field_name.Length == 8))
                return fieldGeneratorPosition;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorPosition = new SportsPlayerPositionJSON.HoldingArrayGenerator("field \"Position\" of the SportsPlayersArgumentPosition class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsPlayersArgumentPosition class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorPosition = new SportsPlayerPositionJSON.HoldingArrayGenerator("field \"Position\" of the SportsPlayersArgumentPosition class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsPlayersArgumentPosition class");
          }

        public override void reset()
          {
            fieldGeneratorPosition.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsPlayersArgumentPositionJSON  result)
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
        public SportsPlayersArgumentPositionJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsPlayersArgumentPositionJSON  result)
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
    protected virtual void handle_result(List<SportsPlayersArgumentPositionJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsPlayersArgumentPositionJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsPlayersArgumentPositionJSON>();
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
    public List<SportsPlayersArgumentPositionJSON> value;
  };
  };
