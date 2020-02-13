/* file "TerrierUploadReadCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TerrierUploadReadCommandJSON : TerrierUploadCommandJSON
  {
    private bool flagHasBlockNameList;
    private List< string > storeBlockNameList;
    private bool flagHasBlockDetails;
    private List< TerrierUploadBlockJSON  > storeBlockDetails;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraBlockNameListToJSON()
      {
        JSONArrayValue generated_array_1_BlockNameList = new JSONArrayValue();
        for (int num1 = 0; num1 < storeBlockNameList.Count; ++num1)
          {
            JSONStringValue generated_string_BlockNameList = new JSONStringValue(storeBlockNameList[num1]);
            generated_array_1_BlockNameList.appendComponent(generated_string_BlockNameList);
          }
        return generated_array_1_BlockNameList;
      }

    private JSONValue  extraBlockDetailsToJSON()
      {
        JSONArrayValue generated_array_2_BlockDetails = new JSONArrayValue();
        for (int num2 = 0; num2 < storeBlockDetails.Count; ++num2)
          {
            JSONValueHandler handler_BlockDetails = new JSONValueHandler();
            storeBlockDetails[num2].write_as_json(handler_BlockDetails);
            generated_array_2_BlockDetails.appendComponent(handler_BlockDetails.result);
          }
        return generated_array_2_BlockDetails;
      }


    private void  fromJSONBlockNameList(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field BlockNameList of TerrierUploadReadCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_BlockNameList1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field BlockNameList of TerrierUploadReadCommandJSON is not a string.");
            vector_BlockNameList1.Add(json_string.getData());
          }
        initBlockNameList();
        for (int num1 = 0; num1 < vector_BlockNameList1.Count; ++num1)
            appendBlockNameList(vector_BlockNameList1[num1]);
        for (int num1 = 0; num1 < vector_BlockNameList1.Count; ++num1)
          {
          }
      }


    private void  fromJSONBlockDetails(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field BlockDetails of TerrierUploadReadCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TerrierUploadBlockJSON  > vector_BlockDetails1 = new List< TerrierUploadBlockJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TerrierUploadBlockJSON convert_classy = TerrierUploadBlockJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_BlockDetails1.Add(convert_classy);
          }
        initBlockDetails();
        for (int num2 = 0; num2 < vector_BlockDetails1.Count; ++num2)
            appendBlockDetails(vector_BlockDetails1[num2]);
        for (int num1 = 0; num1 < vector_BlockDetails1.Count; ++num1)
          {
          }
      }


    public TerrierUploadReadCommandJSON()
      {
        flagHasBlockNameList = false;
        flagHasBlockDetails = false;
        storeBlockNameList = new List< string >();
        storeBlockDetails = new List< TerrierUploadBlockJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getTerrierUploadCommandKind()
      {
        return "Read";
      }

    public bool  hasBlockNameList()
      {
        return flagHasBlockNameList;
      }

    public int  countOfBlockNameList()
      {
        Debug.Assert(flagHasBlockNameList);
        return storeBlockNameList.Count;
      }

    public string  elementOfBlockNameList(int element_num)
      {
        Debug.Assert(flagHasBlockNameList);
        return storeBlockNameList[element_num];
      }

    public List< string >  getBlockNameList()
      {
        Debug.Assert(flagHasBlockNameList);
        return storeBlockNameList;
      }

    public bool  hasBlockDetails()
      {
        return flagHasBlockDetails;
      }

    public int  countOfBlockDetails()
      {
        Debug.Assert(flagHasBlockDetails);
        return storeBlockDetails.Count;
      }

    public TerrierUploadBlockJSON   elementOfBlockDetails(int element_num)
      {
        Debug.Assert(flagHasBlockDetails);
        return storeBlockDetails[element_num];
      }

    public List< TerrierUploadBlockJSON  >  getBlockDetails()
      {
        Debug.Assert(flagHasBlockDetails);
        return storeBlockDetails;
      }


    public virtual int extraTerrierUploadReadCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTerrierUploadReadCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTerrierUploadReadCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTerrierUploadReadCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraTerrierUploadCommandComponentCount()
      {
        int result = 0;
        if (flagHasBlockNameList)
            ++result;
        if (flagHasBlockDetails)
            ++result;
        result += extraTerrierUploadReadCommandComponentCount();
        return result;
      }
    public override string extraTerrierUploadCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasBlockNameList)
          {
            if (remainder == 0)
                return "BlockNameList";
            --remainder;
          }
        if (flagHasBlockDetails)
          {
            if (remainder == 0)
                return "BlockDetails";
            --remainder;
          }
        return extraTerrierUploadReadCommandComponentKey(remainder);
      }
    public override JSONValue extraTerrierUploadCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasBlockNameList)
          {
            if (remainder == 0)
                return extraBlockNameListToJSON();
            --remainder;
          }
        if (flagHasBlockDetails)
          {
            if (remainder == 0)
                return extraBlockDetailsToJSON();
            --remainder;
          }
        return extraTerrierUploadReadCommandComponentValue(remainder);
      }
    public override JSONValue extraTerrierUploadCommandLookup(string field_name)
      {
        if (String.Compare(field_name, 0, "Block", 0, 5, false) == 0)
          {
            switch (field_name[5])
              {
                case 'D':
                    if ((String.Compare(field_name, 6, "etails", 0, 6, false) == 0) && (field_name.Length == 12))
                        return (flagHasBlockDetails ? extraBlockDetailsToJSON() : null);
                    break;
                case 'N':
                    if ((String.Compare(field_name, 6, "ameList", 0, 7, false) == 0) && (field_name.Length == 13))
                        return (flagHasBlockNameList ? extraBlockNameListToJSON() : null);
                    break;
                default:
                    break;
              }
          }
        return extraTerrierUploadReadCommandLookup(field_name);
      }

    public void initBlockNameList()
      {
        flagHasBlockNameList = true;
        storeBlockNameList.Clear();
      }
    public void appendBlockNameList(string to_append)
      {
        if (!flagHasBlockNameList)
          {
            flagHasBlockNameList = true;
            storeBlockNameList.Clear();
          }
        Debug.Assert(flagHasBlockNameList);
        storeBlockNameList.Add(to_append);
      }
    public void unsetBlockNameList()
      {
        flagHasBlockNameList = false;
        storeBlockNameList.Clear();
      }
    public void initBlockDetails()
      {
        if (flagHasBlockDetails)
          {
            for (int num1 = 0; num1 < storeBlockDetails.Count; ++num1)
              {
              }
          }
        flagHasBlockDetails = true;
        storeBlockDetails.Clear();
      }
    public void appendBlockDetails(TerrierUploadBlockJSON  to_append)
      {
        if (!flagHasBlockDetails)
          {
            flagHasBlockDetails = true;
            storeBlockDetails.Clear();
          }
        Debug.Assert(flagHasBlockDetails);
        storeBlockDetails.Add(to_append);
      }
    public void unsetBlockDetails()
      {
        if (flagHasBlockDetails)
          {
            for (int num2 = 0; num2 < storeBlockDetails.Count; ++num2)
              {
              }
          }
        flagHasBlockDetails = false;
        storeBlockDetails.Clear();
      }

    public virtual void extraTerrierUploadReadCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTerrierUploadReadCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTerrierUploadReadCommandLookup(key);
        if (old_field == null)
          {
            extraTerrierUploadReadCommandAppendPair(key, new_component);
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
    public override void extraTerrierUploadCommandAppendPair(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "Block", 0, 5, false) == 0)
          {
            switch (key[5])
              {
                case 'D':
                    if ((String.Compare(key, 6, "etails", 0, 6, false) == 0) && (key.Length == 12))
                        {
                        fromJSONBlockDetails(new_component, false);
                        return;
                        }
                    break;
                case 'N':
                    if ((String.Compare(key, 6, "ameList", 0, 7, false) == 0) && (key.Length == 13))
                        {
                        fromJSONBlockNameList(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraTerrierUploadReadCommandAppendPair(key, new_component);
      }
    public override void extraTerrierUploadCommandSetField(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "Block", 0, 5, false) == 0)
          {
            switch (key[5])
              {
                case 'D':
                    if ((String.Compare(key, 6, "etails", 0, 6, false) == 0) && (key.Length == 12))
                        {
                        fromJSONBlockDetails(new_component, false);
                        return;
                        }
                    break;
                case 'N':
                    if ((String.Compare(key, 6, "ameList", 0, 7, false) == 0) && (key.Length == 13))
                        {
                        fromJSONBlockNameList(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraTerrierUploadReadCommandSetField(key, new_component);
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
        if (flagHasBlockNameList)
          {
            handler.start_pair("BlockNameList");
            handler.start_array();
            for (int num1 = 0; num1 < storeBlockNameList.Count; ++num1)
              {
                handler.string_value(storeBlockNameList[num1]);
              }
            handler.finish_array();
          }
        if (flagHasBlockDetails)
          {
            handler.start_pair("BlockDetails");
            handler.start_array();
            for (int num2 = 0; num2 < storeBlockDetails.Count; ++num2)
              {
                if (partial_allowed)
                    storeBlockDetails[num2].write_partial_as_json(handler);
                else
                    storeBlockDetails[num2].write_as_json(handler);
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
        return null;
      }

    public static new TerrierUploadReadCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrierUploadReadCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadReadCommand", ignore_extras);
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
    public static new TerrierUploadReadCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TerrierUploadReadCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrierUploadReadCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadReadCommand", ignore_extras);
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
    public static new TerrierUploadReadCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TerrierUploadReadCommandJSON from_text(string text, bool ignore_extras)
      {
        TerrierUploadReadCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadReadCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TerrierUploadReadCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new TerrierUploadReadCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TerrierUploadReadCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadReadCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : TerrierUploadCommandJSON.Generator
      {
        private JSONHoldingStringArrayGenerator fieldGeneratorBlockNameList;
        private TerrierUploadBlockJSON.HoldingArrayGenerator fieldGeneratorBlockDetails;
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
            if (!(getTerrierUploadCommandJSONKey().Equals("Read")))
                throw new Exception("The key field has a value other than `Read'.");
            TerrierUploadReadCommandJSON result = new TerrierUploadReadCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTerrierUploadReadCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(TerrierUploadCommandJSON new_result)
          {
            handle_result((TerrierUploadReadCommandJSON )new_result);
          }
        protected void finish(TerrierUploadReadCommandJSON result)
          {
            if (fieldGeneratorBlockNameList.have_value)
              {
                result.initBlockNameList();
                int count = fieldGeneratorBlockNameList.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendBlockNameList(fieldGeneratorBlockNameList.value[num]);
                  }
                fieldGeneratorBlockNameList.value.Clear();
                fieldGeneratorBlockNameList.have_value = false;
              }
            if (fieldGeneratorBlockDetails.have_value)
              {
                result.initBlockDetails();
                int count = fieldGeneratorBlockDetails.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendBlockDetails(fieldGeneratorBlockDetails.value[num]);
                  }
                fieldGeneratorBlockDetails.value.Clear();
                fieldGeneratorBlockDetails.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(TerrierUploadReadCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "Block", 0, 5, false) == 0)
              {
                switch (field_name[5])
                  {
                    case 'D':
                        if ((String.Compare(field_name, 6, "etails", 0, 6, false) == 0) && (field_name.Length == 12))
                            return fieldGeneratorBlockDetails;
                        break;
                    case 'N':
                        if ((String.Compare(field_name, 6, "ameList", 0, 7, false) == 0) && (field_name.Length == 13))
                            return fieldGeneratorBlockNameList;
                        break;
                    default:
                        break;
                  }
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorBlockNameList = new JSONHoldingStringArrayGenerator("field \"BlockNameList\" of the TerrierUploadReadCommand class");
            fieldGeneratorBlockDetails = new TerrierUploadBlockJSON.HoldingArrayGenerator("field \"BlockDetails\" of the TerrierUploadReadCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TerrierUploadReadCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorBlockNameList = new JSONHoldingStringArrayGenerator("field \"BlockNameList\" of the TerrierUploadReadCommand class");
            fieldGeneratorBlockDetails = new TerrierUploadBlockJSON.HoldingArrayGenerator("field \"BlockDetails\" of the TerrierUploadReadCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TerrierUploadReadCommand class");
          }

        public override void reset()
          {
            fieldGeneratorBlockNameList.reset();
            fieldGeneratorBlockDetails.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(TerrierUploadReadCommandJSON  result)
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
        public TerrierUploadReadCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TerrierUploadReadCommandJSON  result)
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
    protected virtual void handle_result(List<TerrierUploadReadCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TerrierUploadReadCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TerrierUploadReadCommandJSON>();
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
    public List<TerrierUploadReadCommandJSON> value;
  };
  };
