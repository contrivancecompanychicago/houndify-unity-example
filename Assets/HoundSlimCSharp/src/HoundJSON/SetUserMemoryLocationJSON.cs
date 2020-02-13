/* file "SetUserMemoryLocationJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SetUserMemoryLocationJSON : JSONBase
  {
    private bool flagHasTag;
    private string storeTag;
    private bool flagHasLocation;
    private MapLocationJSON  storeLocation;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONTag(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Tag of SetUserMemoryLocationJSON is not a string.");
        setTag(json_string.getData());
      }


    private void  fromJSONLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setLocation(convert_classy);
      }


    public SetUserMemoryLocationJSON()
      {
        flagHasTag = false;
        flagHasLocation = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasTag()
      {
        return flagHasTag;
      }

    public string  getTag()
      {
        Debug.Assert(flagHasTag);
        return storeTag;
      }

    public bool  hasLocation()
      {
        return flagHasLocation;
      }

    public MapLocationJSON   getLocation()
      {
        Debug.Assert(flagHasLocation);
        return storeLocation;
      }


    public virtual int extraSetUserMemoryLocationComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSetUserMemoryLocationComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSetUserMemoryLocationComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSetUserMemoryLocationLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setTag(string new_value)
      {
        flagHasTag = true;
        storeTag = new_value;
      }
    public void unsetTag()
      {
        flagHasTag = false;
      }
    public void setLocation(MapLocationJSON  new_value)
      {
        if (flagHasLocation)
          {
          }
        flagHasLocation = true;
        storeLocation = new_value;
      }
    public void unsetLocation()
      {
        if (flagHasLocation)
          {
          }
        flagHasLocation = false;
      }

    public virtual void extraSetUserMemoryLocationAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSetUserMemoryLocationSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSetUserMemoryLocationLookup(key);
        if (old_field == null)
          {
            extraSetUserMemoryLocationAppendPair(key, new_component);
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

    public virtual void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        Debug.Assert(partial_allowed || flagHasTag);
        if (flagHasTag)
          {
            handler.start_pair("Tag");
            handler.string_value(storeTag);
          }
        Debug.Assert(partial_allowed || flagHasLocation);
        if (flagHasLocation)
          {
            handler.start_pair("Location");
            if (partial_allowed)
                storeLocation.write_partial_as_json(handler);
            else
                storeLocation.write_as_json(handler);
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
    public virtual string missing_field_error(bool allow_unpolished)
      {
        if (!(hasTag()))
          {
            return "When parsing the object for %what%, the \"Tag\" field was missing.";
          }
        if (!(hasLocation()))
          {
            return "When parsing the object for %what%, the \"Location\" field was missing.";
          }
        return null;
      }

    public static SetUserMemoryLocationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SetUserMemoryLocationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SetUserMemoryLocation", ignore_extras);
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
    public static SetUserMemoryLocationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SetUserMemoryLocationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SetUserMemoryLocationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SetUserMemoryLocation", ignore_extras);
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
    public static SetUserMemoryLocationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SetUserMemoryLocationJSON from_text(string text, bool ignore_extras)
      {
        SetUserMemoryLocationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SetUserMemoryLocation", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SetUserMemoryLocationJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SetUserMemoryLocationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SetUserMemoryLocationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SetUserMemoryLocation", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorTag;
        private MapLocationJSON.HoldingGenerator fieldGeneratorLocation;
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
            SetUserMemoryLocationJSON result = new SetUserMemoryLocationJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSetUserMemoryLocationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SetUserMemoryLocationJSON result)
          {
            if (fieldGeneratorTag.have_value)
              {
                result.setTag(fieldGeneratorTag.value);
                fieldGeneratorTag.have_value = false;
              }
            else if ((!(result.hasTag())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Tag\" field was missing.");
              }
            if (fieldGeneratorLocation.have_value)
              {
                result.setLocation(fieldGeneratorLocation.value);
                fieldGeneratorLocation.have_value = false;
              }
            else if ((!(result.hasLocation())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Location\" field was missing.");
              }
          }
        protected abstract void handle_result(SetUserMemoryLocationJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'L':
                    if ((String.Compare(field_name, 1, "ocation", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorLocation;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "ag", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorTag;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorTag = new JSONHoldingStringGenerator("field \"Tag\" of the SetUserMemoryLocation class");
            fieldGeneratorLocation = new MapLocationJSON.HoldingGenerator("field \"Location\" of the SetUserMemoryLocation class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SetUserMemoryLocation class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorTag = new JSONHoldingStringGenerator("field \"Tag\" of the SetUserMemoryLocation class");
            fieldGeneratorLocation = new MapLocationJSON.HoldingGenerator("field \"Location\" of the SetUserMemoryLocation class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SetUserMemoryLocation class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorTag.reset();
            fieldGeneratorLocation.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorLocation.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorLocation.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SetUserMemoryLocationJSON  result)
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
        public SetUserMemoryLocationJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SetUserMemoryLocationJSON  result)
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
    protected virtual void handle_result(List<SetUserMemoryLocationJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SetUserMemoryLocationJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SetUserMemoryLocationJSON>();
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
    public List<SetUserMemoryLocationJSON> value;
  };
  };
