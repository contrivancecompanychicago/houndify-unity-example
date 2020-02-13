/* file "TerrierUploadReadDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TerrierUploadReadDataJSON : JSONBase
  {
    private bool flagHasReadBlockList;
    private bool storeReadBlockList;
    private bool flagHasBlocksToRead;
    private List< string > storeBlocksToRead;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONReadBlockList(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field ReadBlockList of TerrierUploadReadDataJSON is not true for false.");
              }
          }
        setReadBlockList(the_bool);
      }


    private void  fromJSONBlocksToRead(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field BlocksToRead of TerrierUploadReadDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_BlocksToRead1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field BlocksToRead of TerrierUploadReadDataJSON is not a string.");
            vector_BlocksToRead1.Add(json_string.getData());
          }
        initBlocksToRead();
        for (int num1 = 0; num1 < vector_BlocksToRead1.Count; ++num1)
            appendBlocksToRead(vector_BlocksToRead1[num1]);
        for (int num1 = 0; num1 < vector_BlocksToRead1.Count; ++num1)
          {
          }
      }


    public TerrierUploadReadDataJSON()
      {
        flagHasReadBlockList = false;
        flagHasBlocksToRead = false;
        storeBlocksToRead = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasReadBlockList()
      {
        return flagHasReadBlockList;
      }

    public bool  getReadBlockList()
      {
        Debug.Assert(flagHasReadBlockList);
        return storeReadBlockList;
      }

    public bool  hasBlocksToRead()
      {
        return flagHasBlocksToRead;
      }

    public int  countOfBlocksToRead()
      {
        Debug.Assert(flagHasBlocksToRead);
        return storeBlocksToRead.Count;
      }

    public string  elementOfBlocksToRead(int element_num)
      {
        Debug.Assert(flagHasBlocksToRead);
        return storeBlocksToRead[element_num];
      }

    public List< string >  getBlocksToRead()
      {
        Debug.Assert(flagHasBlocksToRead);
        return storeBlocksToRead;
      }


    public virtual int extraTerrierUploadReadDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTerrierUploadReadDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTerrierUploadReadDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTerrierUploadReadDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setReadBlockList(bool new_value)
      {
        flagHasReadBlockList = true;
        storeReadBlockList = new_value;
      }
    public void unsetReadBlockList()
      {
        flagHasReadBlockList = false;
      }
    public void initBlocksToRead()
      {
        flagHasBlocksToRead = true;
        storeBlocksToRead.Clear();
      }
    public void appendBlocksToRead(string to_append)
      {
        if (!flagHasBlocksToRead)
          {
            flagHasBlocksToRead = true;
            storeBlocksToRead.Clear();
          }
        Debug.Assert(flagHasBlocksToRead);
        storeBlocksToRead.Add(to_append);
      }
    public void unsetBlocksToRead()
      {
        flagHasBlocksToRead = false;
        storeBlocksToRead.Clear();
      }

    public virtual void extraTerrierUploadReadDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTerrierUploadReadDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTerrierUploadReadDataLookup(key);
        if (old_field == null)
          {
            extraTerrierUploadReadDataAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasReadBlockList);
        if (flagHasReadBlockList)
          {
            handler.start_pair("ReadBlockList");
            handler.boolean_value(storeReadBlockList);
          }
        Debug.Assert(partial_allowed || flagHasBlocksToRead);
        if (flagHasBlocksToRead)
          {
            handler.start_pair("BlocksToRead");
            handler.start_array();
            for (int num1 = 0; num1 < storeBlocksToRead.Count; ++num1)
              {
                handler.string_value(storeBlocksToRead[num1]);
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
    public virtual string missing_field_error(bool allow_unpolished)
      {
        if (!(hasReadBlockList()))
          {
            return "When parsing the object for %what%, the \"ReadBlockList\" field was missing.";
          }
        if (!(hasBlocksToRead()))
          {
            return "When parsing the object for %what%, the \"BlocksToRead\" field was missing.";
          }
        return null;
      }

    public static TerrierUploadReadDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrierUploadReadDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadReadData", ignore_extras);
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
    public static TerrierUploadReadDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TerrierUploadReadDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrierUploadReadDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadReadData", ignore_extras);
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
    public static TerrierUploadReadDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TerrierUploadReadDataJSON from_text(string text, bool ignore_extras)
      {
        TerrierUploadReadDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadReadData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TerrierUploadReadDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static TerrierUploadReadDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TerrierUploadReadDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadReadData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorReadBlockList;
        private JSONHoldingStringArrayGenerator fieldGeneratorBlocksToRead;
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
            TerrierUploadReadDataJSON result = new TerrierUploadReadDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTerrierUploadReadDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(TerrierUploadReadDataJSON result)
          {
            if (fieldGeneratorReadBlockList.have_value)
              {
                result.setReadBlockList(fieldGeneratorReadBlockList.value);
                fieldGeneratorReadBlockList.have_value = false;
              }
            else if ((!(result.hasReadBlockList())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ReadBlockList\" field was missing.");
              }
            if (fieldGeneratorBlocksToRead.have_value)
              {
                result.initBlocksToRead();
                int count = fieldGeneratorBlocksToRead.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendBlocksToRead(fieldGeneratorBlocksToRead.value[num]);
                  }
                fieldGeneratorBlocksToRead.value.Clear();
                fieldGeneratorBlocksToRead.have_value = false;
              }
            else if ((!(result.hasBlocksToRead())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"BlocksToRead\" field was missing.");
              }
          }
        protected abstract void handle_result(TerrierUploadReadDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    if ((String.Compare(field_name, 1, "locksToRead", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorBlocksToRead;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "eadBlockList", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorReadBlockList;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorReadBlockList = new JSONHoldingBooleanGenerator("field \"ReadBlockList\" of the TerrierUploadReadData class");
            fieldGeneratorBlocksToRead = new JSONHoldingStringArrayGenerator("field \"BlocksToRead\" of the TerrierUploadReadData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TerrierUploadReadData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorReadBlockList = new JSONHoldingBooleanGenerator("field \"ReadBlockList\" of the TerrierUploadReadData class");
            fieldGeneratorBlocksToRead = new JSONHoldingStringArrayGenerator("field \"BlocksToRead\" of the TerrierUploadReadData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TerrierUploadReadData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorReadBlockList.reset();
            fieldGeneratorBlocksToRead.reset();
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
        protected override void handle_result(TerrierUploadReadDataJSON  result)
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
        public TerrierUploadReadDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TerrierUploadReadDataJSON  result)
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
    protected virtual void handle_result(List<TerrierUploadReadDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TerrierUploadReadDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TerrierUploadReadDataJSON>();
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
    public List<TerrierUploadReadDataJSON> value;
  };
  };