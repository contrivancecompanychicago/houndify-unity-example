/* file "DisplayMapInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class DisplayMapInformationNuggetJSON : InformationNuggetJSON
  {
    private bool flagHasToDisplay;
    private MapDisplaySpecificationJSON  storeToDisplay;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraToDisplayToJSON()
      {
        JSONValueHandler handler_ToDisplay = new JSONValueHandler();
        storeToDisplay.write_as_json(handler_ToDisplay);
        return handler_ToDisplay.result;
      }


    private void  fromJSONToDisplay(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapDisplaySpecificationJSON convert_classy = MapDisplaySpecificationJSON.from_json(json_value, ignore_extras, true);
        setToDisplay(convert_classy);
      }


    public DisplayMapInformationNuggetJSON()
      {
        flagHasToDisplay = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "DisplayMap";
      }

    public bool  hasToDisplay()
      {
        return flagHasToDisplay;
      }

    public MapDisplaySpecificationJSON   getToDisplay()
      {
        Debug.Assert(flagHasToDisplay);
        return storeToDisplay;
      }


    public virtual int extraDisplayMapInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraDisplayMapInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraDisplayMapInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraDisplayMapInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasToDisplay)
            ++result;
        result += extraDisplayMapInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasToDisplay)
          {
            if (remainder == 0)
                return "ToDisplay";
            --remainder;
          }
        return extraDisplayMapInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasToDisplay)
          {
            if (remainder == 0)
                return extraToDisplayToJSON();
            --remainder;
          }
        return extraDisplayMapInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "ToDisplay", 0, 9, false) == 0) && (field_name.Length == 9))
            return (flagHasToDisplay ? extraToDisplayToJSON() : null);
        return extraDisplayMapInformationNuggetLookup(field_name);
      }

    public void setToDisplay(MapDisplaySpecificationJSON  new_value)
      {
        if (flagHasToDisplay)
          {
          }
        flagHasToDisplay = true;
        storeToDisplay = new_value;
      }
    public void unsetToDisplay()
      {
        if (flagHasToDisplay)
          {
          }
        flagHasToDisplay = false;
      }

    public virtual void extraDisplayMapInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraDisplayMapInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraDisplayMapInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraDisplayMapInformationNuggetAppendPair(key, new_component);
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
    public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "ToDisplay", 0, 9, false) == 0) && (key.Length == 9))
            {
            fromJSONToDisplay(new_component, false);
            return;
            }
        extraDisplayMapInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "ToDisplay", 0, 9, false) == 0) && (key.Length == 9))
            {
            fromJSONToDisplay(new_component, false);
            return;
            }
        extraDisplayMapInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasToDisplay);
        if (flagHasToDisplay)
          {
            handler.start_pair("ToDisplay");
            if (partial_allowed)
                storeToDisplay.write_partial_as_json(handler);
            else
                storeToDisplay.write_as_json(handler);
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
        if (!(hasToDisplay()))
          {
            return "When parsing the object for %what%, the \"ToDisplay\" field was missing.";
          }
        return null;
      }

    public static new DisplayMapInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DisplayMapInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisplayMapInformationNugget", ignore_extras);
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
    public static new DisplayMapInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DisplayMapInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DisplayMapInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisplayMapInformationNugget", ignore_extras);
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
    public static new DisplayMapInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DisplayMapInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        DisplayMapInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisplayMapInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DisplayMapInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new DisplayMapInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DisplayMapInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisplayMapInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private MapDisplaySpecificationJSON.HoldingGenerator fieldGeneratorToDisplay;
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
            if (!(getInformationNuggetJSONKey().Equals("DisplayMap")))
                throw new Exception("The key field has a value other than `DisplayMap'.");
            DisplayMapInformationNuggetJSON result = new DisplayMapInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDisplayMapInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((DisplayMapInformationNuggetJSON )new_result);
          }
        protected void finish(DisplayMapInformationNuggetJSON result)
          {
            if (fieldGeneratorToDisplay.have_value)
              {
                result.setToDisplay(fieldGeneratorToDisplay.value);
                fieldGeneratorToDisplay.have_value = false;
              }
            else if ((!(result.hasToDisplay())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ToDisplay\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(DisplayMapInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "ToDisplay", 0, 9, false) == 0) && (field_name.Length == 9))
                return fieldGeneratorToDisplay;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorToDisplay = new MapDisplaySpecificationJSON.HoldingGenerator("field \"ToDisplay\" of the DisplayMapInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the DisplayMapInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorToDisplay = new MapDisplaySpecificationJSON.HoldingGenerator("field \"ToDisplay\" of the DisplayMapInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the DisplayMapInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorToDisplay.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(DisplayMapInformationNuggetJSON  result)
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
        public DisplayMapInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DisplayMapInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<DisplayMapInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DisplayMapInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DisplayMapInformationNuggetJSON>();
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
    public List<DisplayMapInformationNuggetJSON> value;
  };
  };
