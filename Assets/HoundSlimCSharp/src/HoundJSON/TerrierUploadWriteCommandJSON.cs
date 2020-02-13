/* file "TerrierUploadWriteCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class TerrierUploadWriteCommandJSON : TerrierUploadCommandJSON
  {
    private bool flagHasDeletedBlockCount;
    private BigInteger storeDeletedBlockCount;
    private bool flagHasCreatedBlockCount;
    private BigInteger storeCreatedBlockCount;
    private bool flagHasUpdatedBlockCount;
    private BigInteger storeUpdatedBlockCount;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraDeletedBlockCountToJSON()
      {
        JSONIntegerValue generated_integer_DeletedBlockCount = new JSONIntegerValue(storeDeletedBlockCount);
        return generated_integer_DeletedBlockCount;
      }

    private JSONValue  extraCreatedBlockCountToJSON()
      {
        JSONIntegerValue generated_integer_CreatedBlockCount = new JSONIntegerValue(storeCreatedBlockCount);
        return generated_integer_CreatedBlockCount;
      }

    private JSONValue  extraUpdatedBlockCountToJSON()
      {
        JSONIntegerValue generated_integer_UpdatedBlockCount = new JSONIntegerValue(storeUpdatedBlockCount);
        return generated_integer_UpdatedBlockCount;
      }


    private void  fromJSONDeletedBlockCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field DeletedBlockCount of TerrierUploadWriteCommandJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field DeletedBlockCount of TerrierUploadWriteCommandJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setDeletedBlockCount(extracted_integer);
      }


    private void  fromJSONCreatedBlockCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field CreatedBlockCount of TerrierUploadWriteCommandJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field CreatedBlockCount of TerrierUploadWriteCommandJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setCreatedBlockCount(extracted_integer);
      }


    private void  fromJSONUpdatedBlockCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field UpdatedBlockCount of TerrierUploadWriteCommandJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field UpdatedBlockCount of TerrierUploadWriteCommandJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setUpdatedBlockCount(extracted_integer);
      }


    public TerrierUploadWriteCommandJSON()
      {
        flagHasDeletedBlockCount = false;
        flagHasCreatedBlockCount = false;
        flagHasUpdatedBlockCount = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getTerrierUploadCommandKind()
      {
        return "Write";
      }

    public bool  hasDeletedBlockCount()
      {
        return flagHasDeletedBlockCount;
      }

    public BigInteger  getDeletedBlockCount()
      {
        Debug.Assert(flagHasDeletedBlockCount);
        return storeDeletedBlockCount;
      }

    public bool  hasCreatedBlockCount()
      {
        return flagHasCreatedBlockCount;
      }

    public BigInteger  getCreatedBlockCount()
      {
        Debug.Assert(flagHasCreatedBlockCount);
        return storeCreatedBlockCount;
      }

    public bool  hasUpdatedBlockCount()
      {
        return flagHasUpdatedBlockCount;
      }

    public BigInteger  getUpdatedBlockCount()
      {
        Debug.Assert(flagHasUpdatedBlockCount);
        return storeUpdatedBlockCount;
      }


    public virtual int extraTerrierUploadWriteCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTerrierUploadWriteCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTerrierUploadWriteCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTerrierUploadWriteCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraTerrierUploadCommandComponentCount()
      {
        int result = 0;
        if (flagHasDeletedBlockCount)
            ++result;
        if (flagHasCreatedBlockCount)
            ++result;
        if (flagHasUpdatedBlockCount)
            ++result;
        result += extraTerrierUploadWriteCommandComponentCount();
        return result;
      }
    public override string extraTerrierUploadCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasDeletedBlockCount)
          {
            if (remainder == 0)
                return "DeletedBlockCount";
            --remainder;
          }
        if (flagHasCreatedBlockCount)
          {
            if (remainder == 0)
                return "CreatedBlockCount";
            --remainder;
          }
        if (flagHasUpdatedBlockCount)
          {
            if (remainder == 0)
                return "UpdatedBlockCount";
            --remainder;
          }
        return extraTerrierUploadWriteCommandComponentKey(remainder);
      }
    public override JSONValue extraTerrierUploadCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasDeletedBlockCount)
          {
            if (remainder == 0)
                return extraDeletedBlockCountToJSON();
            --remainder;
          }
        if (flagHasCreatedBlockCount)
          {
            if (remainder == 0)
                return extraCreatedBlockCountToJSON();
            --remainder;
          }
        if (flagHasUpdatedBlockCount)
          {
            if (remainder == 0)
                return extraUpdatedBlockCountToJSON();
            --remainder;
          }
        return extraTerrierUploadWriteCommandComponentValue(remainder);
      }
    public override JSONValue extraTerrierUploadCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "reatedBlockCount", 0, 16, false) == 0) && (field_name.Length == 17))
                    return (flagHasCreatedBlockCount ? extraCreatedBlockCountToJSON() : null);
                break;
            case 'D':
                if ((String.Compare(field_name, 1, "eletedBlockCount", 0, 16, false) == 0) && (field_name.Length == 17))
                    return (flagHasDeletedBlockCount ? extraDeletedBlockCountToJSON() : null);
                break;
            case 'U':
                if ((String.Compare(field_name, 1, "pdatedBlockCount", 0, 16, false) == 0) && (field_name.Length == 17))
                    return (flagHasUpdatedBlockCount ? extraUpdatedBlockCountToJSON() : null);
                break;
            default:
                break;
          }
        return extraTerrierUploadWriteCommandLookup(field_name);
      }

    public void setDeletedBlockCount(BigInteger new_value)
      {
        flagHasDeletedBlockCount = true;
        if (new_value < 0)
            throw new Exception("The value for field DeletedBlockCount of TerrierUploadWriteCommandJSON is less than the lower bound (0) for that field.");
        storeDeletedBlockCount = new_value;
      }
    public void unsetDeletedBlockCount()
      {
        flagHasDeletedBlockCount = false;
      }
    public void setCreatedBlockCount(BigInteger new_value)
      {
        flagHasCreatedBlockCount = true;
        if (new_value < 0)
            throw new Exception("The value for field CreatedBlockCount of TerrierUploadWriteCommandJSON is less than the lower bound (0) for that field.");
        storeCreatedBlockCount = new_value;
      }
    public void unsetCreatedBlockCount()
      {
        flagHasCreatedBlockCount = false;
      }
    public void setUpdatedBlockCount(BigInteger new_value)
      {
        flagHasUpdatedBlockCount = true;
        if (new_value < 0)
            throw new Exception("The value for field UpdatedBlockCount of TerrierUploadWriteCommandJSON is less than the lower bound (0) for that field.");
        storeUpdatedBlockCount = new_value;
      }
    public void unsetUpdatedBlockCount()
      {
        flagHasUpdatedBlockCount = false;
      }

    public virtual void extraTerrierUploadWriteCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTerrierUploadWriteCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTerrierUploadWriteCommandLookup(key);
        if (old_field == null)
          {
            extraTerrierUploadWriteCommandAppendPair(key, new_component);
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
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "reatedBlockCount", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONCreatedBlockCount(new_component, false);
                    return;
                    }
                break;
            case 'D':
                if ((String.Compare(key, 1, "eletedBlockCount", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONDeletedBlockCount(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if ((String.Compare(key, 1, "pdatedBlockCount", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONUpdatedBlockCount(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraTerrierUploadWriteCommandAppendPair(key, new_component);
      }
    public override void extraTerrierUploadCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "reatedBlockCount", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONCreatedBlockCount(new_component, false);
                    return;
                    }
                break;
            case 'D':
                if ((String.Compare(key, 1, "eletedBlockCount", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONDeletedBlockCount(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if ((String.Compare(key, 1, "pdatedBlockCount", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONUpdatedBlockCount(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraTerrierUploadWriteCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasDeletedBlockCount);
        if (flagHasDeletedBlockCount)
          {
            handler.start_pair("DeletedBlockCount");
            handler.number_value(storeDeletedBlockCount);
          }
        Debug.Assert(partial_allowed || flagHasCreatedBlockCount);
        if (flagHasCreatedBlockCount)
          {
            handler.start_pair("CreatedBlockCount");
            handler.number_value(storeCreatedBlockCount);
          }
        Debug.Assert(partial_allowed || flagHasUpdatedBlockCount);
        if (flagHasUpdatedBlockCount)
          {
            handler.start_pair("UpdatedBlockCount");
            handler.number_value(storeUpdatedBlockCount);
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
        if (!(hasDeletedBlockCount()))
          {
            return "When parsing the object for %what%, the \"DeletedBlockCount\" field was missing.";
          }
        if (!(hasCreatedBlockCount()))
          {
            return "When parsing the object for %what%, the \"CreatedBlockCount\" field was missing.";
          }
        if (!(hasUpdatedBlockCount()))
          {
            return "When parsing the object for %what%, the \"UpdatedBlockCount\" field was missing.";
          }
        return null;
      }

    public static new TerrierUploadWriteCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrierUploadWriteCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadWriteCommand", ignore_extras);
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
    public static new TerrierUploadWriteCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TerrierUploadWriteCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrierUploadWriteCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadWriteCommand", ignore_extras);
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
    public static new TerrierUploadWriteCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TerrierUploadWriteCommandJSON from_text(string text, bool ignore_extras)
      {
        TerrierUploadWriteCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadWriteCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TerrierUploadWriteCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new TerrierUploadWriteCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TerrierUploadWriteCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadWriteCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : TerrierUploadCommandJSON.Generator
      {
    private class FieldHoldingGeneratorDeletedBlockCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorDeletedBlockCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorDeletedBlockCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorDeletedBlockCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorDeletedBlockCount fieldGeneratorDeletedBlockCount;
    private class FieldHoldingGeneratorCreatedBlockCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorCreatedBlockCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorCreatedBlockCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorCreatedBlockCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorCreatedBlockCount fieldGeneratorCreatedBlockCount;
    private class FieldHoldingGeneratorUpdatedBlockCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorUpdatedBlockCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorUpdatedBlockCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorUpdatedBlockCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorUpdatedBlockCount fieldGeneratorUpdatedBlockCount;
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
            if (!(getTerrierUploadCommandJSONKey().Equals("Write")))
                throw new Exception("The key field has a value other than `Write'.");
            TerrierUploadWriteCommandJSON result = new TerrierUploadWriteCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTerrierUploadWriteCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(TerrierUploadCommandJSON new_result)
          {
            handle_result((TerrierUploadWriteCommandJSON )new_result);
          }
        protected void finish(TerrierUploadWriteCommandJSON result)
          {
            if (fieldGeneratorDeletedBlockCount.have_value)
              {
                result.setDeletedBlockCount(fieldGeneratorDeletedBlockCount.value);
                fieldGeneratorDeletedBlockCount.have_value = false;
              }
            else if ((!(result.hasDeletedBlockCount())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DeletedBlockCount\" field was missing.");
              }
            if (fieldGeneratorCreatedBlockCount.have_value)
              {
                result.setCreatedBlockCount(fieldGeneratorCreatedBlockCount.value);
                fieldGeneratorCreatedBlockCount.have_value = false;
              }
            else if ((!(result.hasCreatedBlockCount())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CreatedBlockCount\" field was missing.");
              }
            if (fieldGeneratorUpdatedBlockCount.have_value)
              {
                result.setUpdatedBlockCount(fieldGeneratorUpdatedBlockCount.value);
                fieldGeneratorUpdatedBlockCount.have_value = false;
              }
            else if ((!(result.hasUpdatedBlockCount())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"UpdatedBlockCount\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(TerrierUploadWriteCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "reatedBlockCount", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorCreatedBlockCount;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "eletedBlockCount", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorDeletedBlockCount;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "pdatedBlockCount", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorUpdatedBlockCount;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorDeletedBlockCount = new FieldHoldingGeneratorDeletedBlockCount("field \"DeletedBlockCount\" of the TerrierUploadWriteCommand class");
            fieldGeneratorCreatedBlockCount = new FieldHoldingGeneratorCreatedBlockCount("field \"CreatedBlockCount\" of the TerrierUploadWriteCommand class");
            fieldGeneratorUpdatedBlockCount = new FieldHoldingGeneratorUpdatedBlockCount("field \"UpdatedBlockCount\" of the TerrierUploadWriteCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TerrierUploadWriteCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorDeletedBlockCount = new FieldHoldingGeneratorDeletedBlockCount("field \"DeletedBlockCount\" of the TerrierUploadWriteCommand class");
            fieldGeneratorCreatedBlockCount = new FieldHoldingGeneratorCreatedBlockCount("field \"CreatedBlockCount\" of the TerrierUploadWriteCommand class");
            fieldGeneratorUpdatedBlockCount = new FieldHoldingGeneratorUpdatedBlockCount("field \"UpdatedBlockCount\" of the TerrierUploadWriteCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TerrierUploadWriteCommand class");
          }

        public override void reset()
          {
            fieldGeneratorDeletedBlockCount.reset();
            fieldGeneratorCreatedBlockCount.reset();
            fieldGeneratorUpdatedBlockCount.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(TerrierUploadWriteCommandJSON  result)
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
        public TerrierUploadWriteCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TerrierUploadWriteCommandJSON  result)
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
    protected virtual void handle_result(List<TerrierUploadWriteCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TerrierUploadWriteCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TerrierUploadWriteCommandJSON>();
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
    public List<TerrierUploadWriteCommandJSON> value;
  };
  };
