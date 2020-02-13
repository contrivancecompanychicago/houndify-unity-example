/* file "TerrierUploadClauseJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TerrierUploadClauseJSON : JSONBase
  {
    private bool flagHasExpression;
    private string storeExpression;
    private bool flagHasExpressionSource;
    private UploadedCodeSourceJSON  storeExpressionSource;
    private bool flagHasMatchCode;
    private string storeMatchCode;
    private bool flagHasMatchCodeSource;
    private UploadedCodeSourceJSON  storeMatchCodeSource;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONExpression(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Expression of TerrierUploadClauseJSON is not a string.");
        setExpression(json_string.getData());
      }


    private void  fromJSONExpressionSource(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UploadedCodeSourceJSON convert_classy = UploadedCodeSourceJSON.from_json(json_value, ignore_extras, true);
        setExpressionSource(convert_classy);
      }


    private void  fromJSONMatchCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field MatchCode of TerrierUploadClauseJSON is not a string.");
        setMatchCode(json_string.getData());
      }


    private void  fromJSONMatchCodeSource(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UploadedCodeSourceJSON convert_classy = UploadedCodeSourceJSON.from_json(json_value, ignore_extras, true);
        setMatchCodeSource(convert_classy);
      }


    public TerrierUploadClauseJSON()
      {
        flagHasExpression = false;
        flagHasExpressionSource = false;
        flagHasMatchCode = false;
        flagHasMatchCodeSource = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasExpression()
      {
        return flagHasExpression;
      }

    public string  getExpression()
      {
        Debug.Assert(flagHasExpression);
        return storeExpression;
      }

    public bool  hasExpressionSource()
      {
        return flagHasExpressionSource;
      }

    public UploadedCodeSourceJSON   getExpressionSource()
      {
        Debug.Assert(flagHasExpressionSource);
        return storeExpressionSource;
      }

    public bool  hasMatchCode()
      {
        return flagHasMatchCode;
      }

    public string  getMatchCode()
      {
        Debug.Assert(flagHasMatchCode);
        return storeMatchCode;
      }

    public bool  hasMatchCodeSource()
      {
        return flagHasMatchCodeSource;
      }

    public UploadedCodeSourceJSON   getMatchCodeSource()
      {
        Debug.Assert(flagHasMatchCodeSource);
        return storeMatchCodeSource;
      }


    public virtual int extraTerrierUploadClauseComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTerrierUploadClauseComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTerrierUploadClauseComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTerrierUploadClauseLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setExpression(string new_value)
      {
        flagHasExpression = true;
        storeExpression = new_value;
      }
    public void unsetExpression()
      {
        flagHasExpression = false;
      }
    public void setExpressionSource(UploadedCodeSourceJSON  new_value)
      {
        if (flagHasExpressionSource)
          {
          }
        flagHasExpressionSource = true;
        storeExpressionSource = new_value;
      }
    public void unsetExpressionSource()
      {
        if (flagHasExpressionSource)
          {
          }
        flagHasExpressionSource = false;
      }
    public void setMatchCode(string new_value)
      {
        flagHasMatchCode = true;
        storeMatchCode = new_value;
      }
    public void unsetMatchCode()
      {
        flagHasMatchCode = false;
      }
    public void setMatchCodeSource(UploadedCodeSourceJSON  new_value)
      {
        if (flagHasMatchCodeSource)
          {
          }
        flagHasMatchCodeSource = true;
        storeMatchCodeSource = new_value;
      }
    public void unsetMatchCodeSource()
      {
        if (flagHasMatchCodeSource)
          {
          }
        flagHasMatchCodeSource = false;
      }

    public virtual void extraTerrierUploadClauseAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTerrierUploadClauseSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTerrierUploadClauseLookup(key);
        if (old_field == null)
          {
            extraTerrierUploadClauseAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasExpression);
        if (flagHasExpression)
          {
            handler.start_pair("Expression");
            handler.string_value(storeExpression);
          }
        if (flagHasExpressionSource)
          {
            handler.start_pair("ExpressionSource");
            if (partial_allowed)
                storeExpressionSource.write_partial_as_json(handler);
            else
                storeExpressionSource.write_as_json(handler);
          }
        if (flagHasMatchCode)
          {
            handler.start_pair("MatchCode");
            handler.string_value(storeMatchCode);
          }
        if (flagHasMatchCodeSource)
          {
            handler.start_pair("MatchCodeSource");
            if (partial_allowed)
                storeMatchCodeSource.write_partial_as_json(handler);
            else
                storeMatchCodeSource.write_as_json(handler);
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
        if (!(hasExpression()))
          {
            return "When parsing the object for %what%, the \"Expression\" field was missing.";
          }
        return null;
      }

    public static TerrierUploadClauseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrierUploadClauseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadClause", ignore_extras);
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
    public static TerrierUploadClauseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TerrierUploadClauseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrierUploadClauseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadClause", ignore_extras);
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
    public static TerrierUploadClauseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TerrierUploadClauseJSON from_text(string text, bool ignore_extras)
      {
        TerrierUploadClauseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadClause", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TerrierUploadClauseJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static TerrierUploadClauseJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TerrierUploadClauseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadClause", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorExpression;
        private UploadedCodeSourceJSON.HoldingGenerator fieldGeneratorExpressionSource;
        private JSONHoldingStringGenerator fieldGeneratorMatchCode;
        private UploadedCodeSourceJSON.HoldingGenerator fieldGeneratorMatchCodeSource;
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
            TerrierUploadClauseJSON result = new TerrierUploadClauseJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTerrierUploadClauseAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(TerrierUploadClauseJSON result)
          {
            if (fieldGeneratorExpression.have_value)
              {
                result.setExpression(fieldGeneratorExpression.value);
                fieldGeneratorExpression.have_value = false;
              }
            else if ((!(result.hasExpression())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Expression\" field was missing.");
              }
            if (fieldGeneratorExpressionSource.have_value)
              {
                result.setExpressionSource(fieldGeneratorExpressionSource.value);
                fieldGeneratorExpressionSource.have_value = false;
              }
            if (fieldGeneratorMatchCode.have_value)
              {
                result.setMatchCode(fieldGeneratorMatchCode.value);
                fieldGeneratorMatchCode.have_value = false;
              }
            if (fieldGeneratorMatchCodeSource.have_value)
              {
                result.setMatchCodeSource(fieldGeneratorMatchCodeSource.value);
                fieldGeneratorMatchCodeSource.have_value = false;
              }
          }
        protected abstract void handle_result(TerrierUploadClauseJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if (String.Compare(field_name, 1, "xpression", 0, 9, false) == 0)
                      {
                        if (field_name.Length == 10)
                          {
                            return fieldGeneratorExpression;
                          }
                        switch (field_name[10])
                          {
                            case 'S':
                                if ((String.Compare(field_name, 11, "ource", 0, 5, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorExpressionSource;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'M':
                    if (String.Compare(field_name, 1, "atchCode", 0, 8, false) == 0)
                      {
                        if (field_name.Length == 9)
                          {
                            return fieldGeneratorMatchCode;
                          }
                        switch (field_name[9])
                          {
                            case 'S':
                                if ((String.Compare(field_name, 10, "ource", 0, 5, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorMatchCodeSource;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorExpression = new JSONHoldingStringGenerator("field \"Expression\" of the TerrierUploadClause class");
            fieldGeneratorExpressionSource = new UploadedCodeSourceJSON.HoldingGenerator("field \"ExpressionSource\" of the TerrierUploadClause class", ignore_extras);
            fieldGeneratorMatchCode = new JSONHoldingStringGenerator("field \"MatchCode\" of the TerrierUploadClause class");
            fieldGeneratorMatchCodeSource = new UploadedCodeSourceJSON.HoldingGenerator("field \"MatchCodeSource\" of the TerrierUploadClause class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TerrierUploadClause class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorExpression = new JSONHoldingStringGenerator("field \"Expression\" of the TerrierUploadClause class");
            fieldGeneratorExpressionSource = new UploadedCodeSourceJSON.HoldingGenerator("field \"ExpressionSource\" of the TerrierUploadClause class", false);
            fieldGeneratorMatchCode = new JSONHoldingStringGenerator("field \"MatchCode\" of the TerrierUploadClause class");
            fieldGeneratorMatchCodeSource = new UploadedCodeSourceJSON.HoldingGenerator("field \"MatchCodeSource\" of the TerrierUploadClause class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TerrierUploadClause class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorExpression.reset();
            fieldGeneratorExpressionSource.reset();
            fieldGeneratorMatchCode.reset();
            fieldGeneratorMatchCodeSource.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorExpressionSource.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMatchCodeSource.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorExpressionSource.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMatchCodeSource.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(TerrierUploadClauseJSON  result)
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
        public TerrierUploadClauseJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TerrierUploadClauseJSON  result)
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
    protected virtual void handle_result(List<TerrierUploadClauseJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TerrierUploadClauseJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TerrierUploadClauseJSON>();
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
    public List<TerrierUploadClauseJSON> value;
  };
  };
