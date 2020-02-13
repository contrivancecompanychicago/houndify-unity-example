/* file "TerrierUploadBlockJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;


public class TerrierUploadBlockJSON : JSONBase
  {
    public static Regex expressionName = new Regex("^[a-zA-Z_]([a-zA-Z_0-9]*)$");
    private bool flagHasName;
    private string storeName;
    private bool flagHasInputParameters;
    private List< TerrierUploadParameterJSON  > storeInputParameters;
    private bool flagHasOutputParameters;
    private List< TerrierUploadParameterJSON  > storeOutputParameters;
    private bool flagHasClauses;
    private List< TerrierUploadClauseJSON  > storeClauses;
    private bool flagHasCodeLanguage;
    private UploadedCodeFunctionLanguageJSON  storeCodeLanguage;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Name of TerrierUploadBlockJSON is not a string.");
        setName(json_string.getData());
      }


    private void  fromJSONInputParameters(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field InputParameters of TerrierUploadBlockJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TerrierUploadParameterJSON  > vector_InputParameters1 = new List< TerrierUploadParameterJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TerrierUploadParameterJSON convert_classy = TerrierUploadParameterJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_InputParameters1.Add(convert_classy);
          }
        initInputParameters();
        for (int num1 = 0; num1 < vector_InputParameters1.Count; ++num1)
            appendInputParameters(vector_InputParameters1[num1]);
        for (int num1 = 0; num1 < vector_InputParameters1.Count; ++num1)
          {
          }
      }


    private void  fromJSONOutputParameters(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field OutputParameters of TerrierUploadBlockJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TerrierUploadParameterJSON  > vector_OutputParameters1 = new List< TerrierUploadParameterJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TerrierUploadParameterJSON convert_classy = TerrierUploadParameterJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_OutputParameters1.Add(convert_classy);
          }
        initOutputParameters();
        for (int num2 = 0; num2 < vector_OutputParameters1.Count; ++num2)
            appendOutputParameters(vector_OutputParameters1[num2]);
        for (int num1 = 0; num1 < vector_OutputParameters1.Count; ++num1)
          {
          }
      }


    private void  fromJSONClauses(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Clauses of TerrierUploadBlockJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TerrierUploadClauseJSON  > vector_Clauses1 = new List< TerrierUploadClauseJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TerrierUploadClauseJSON convert_classy = TerrierUploadClauseJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Clauses1.Add(convert_classy);
          }
        initClauses();
        for (int num3 = 0; num3 < vector_Clauses1.Count; ++num3)
            appendClauses(vector_Clauses1[num3]);
        for (int num1 = 0; num1 < vector_Clauses1.Count; ++num1)
          {
          }
      }


    private void  fromJSONCodeLanguage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UploadedCodeFunctionLanguageJSON convert_classy = UploadedCodeFunctionLanguageJSON.from_json(json_value, ignore_extras, true);
        setCodeLanguage(convert_classy);
      }


    public TerrierUploadBlockJSON()
      {
        flagHasName = false;
        flagHasInputParameters = false;
        flagHasOutputParameters = false;
        flagHasClauses = false;
        flagHasCodeLanguage = false;
        storeInputParameters = new List< TerrierUploadParameterJSON  >();
        storeOutputParameters = new List< TerrierUploadParameterJSON  >();
        storeClauses = new List< TerrierUploadClauseJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasName()
      {
        return flagHasName;
      }

    public string  getName()
      {
        Debug.Assert(flagHasName);
        return storeName;
      }

    public bool  hasInputParameters()
      {
        return flagHasInputParameters;
      }

    public int  countOfInputParameters()
      {
        Debug.Assert(flagHasInputParameters);
        return storeInputParameters.Count;
      }

    public TerrierUploadParameterJSON   elementOfInputParameters(int element_num)
      {
        Debug.Assert(flagHasInputParameters);
        return storeInputParameters[element_num];
      }

    public List< TerrierUploadParameterJSON  >  getInputParameters()
      {
        Debug.Assert(flagHasInputParameters);
        return storeInputParameters;
      }

    public bool  hasOutputParameters()
      {
        return flagHasOutputParameters;
      }

    public int  countOfOutputParameters()
      {
        Debug.Assert(flagHasOutputParameters);
        return storeOutputParameters.Count;
      }

    public TerrierUploadParameterJSON   elementOfOutputParameters(int element_num)
      {
        Debug.Assert(flagHasOutputParameters);
        return storeOutputParameters[element_num];
      }

    public List< TerrierUploadParameterJSON  >  getOutputParameters()
      {
        Debug.Assert(flagHasOutputParameters);
        return storeOutputParameters;
      }

    public bool  hasClauses()
      {
        return flagHasClauses;
      }

    public int  countOfClauses()
      {
        Debug.Assert(flagHasClauses);
        return storeClauses.Count;
      }

    public TerrierUploadClauseJSON   elementOfClauses(int element_num)
      {
        Debug.Assert(flagHasClauses);
        return storeClauses[element_num];
      }

    public List< TerrierUploadClauseJSON  >  getClauses()
      {
        Debug.Assert(flagHasClauses);
        return storeClauses;
      }

    public bool  hasCodeLanguage()
      {
        return flagHasCodeLanguage;
      }

    public UploadedCodeFunctionLanguageJSON   getCodeLanguage()
      {
        Debug.Assert(flagHasCodeLanguage);
        return storeCodeLanguage;
      }

    public UploadedCodeFunctionLanguageJSON.TypeValue  getCodeLanguageValue()
      {
        return getCodeLanguage().getValue();
      }

    public string  getCodeLanguageAsString()
      {
        return getCodeLanguage().getValueAsString();
      }


    public virtual int extraTerrierUploadBlockComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTerrierUploadBlockComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTerrierUploadBlockComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTerrierUploadBlockLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setName(string new_value)
      {
        flagHasName = true;
        if (!expressionName.IsMatch(new_value))
            throw new Exception("The value is not in the regular expression for field Name of TerrierUploadBlockJSON.");
        storeName = new_value;
      }
    public void unsetName()
      {
        flagHasName = false;
      }
    public void initInputParameters()
      {
        if (flagHasInputParameters)
          {
            for (int num1 = 0; num1 < storeInputParameters.Count; ++num1)
              {
              }
          }
        flagHasInputParameters = true;
        storeInputParameters.Clear();
      }
    public void appendInputParameters(TerrierUploadParameterJSON  to_append)
      {
        if (!flagHasInputParameters)
          {
            flagHasInputParameters = true;
            storeInputParameters.Clear();
          }
        Debug.Assert(flagHasInputParameters);
        storeInputParameters.Add(to_append);
      }
    public void unsetInputParameters()
      {
        if (flagHasInputParameters)
          {
            for (int num2 = 0; num2 < storeInputParameters.Count; ++num2)
              {
              }
          }
        flagHasInputParameters = false;
        storeInputParameters.Clear();
      }
    public void initOutputParameters()
      {
        if (flagHasOutputParameters)
          {
            for (int num3 = 0; num3 < storeOutputParameters.Count; ++num3)
              {
              }
          }
        flagHasOutputParameters = true;
        storeOutputParameters.Clear();
      }
    public void appendOutputParameters(TerrierUploadParameterJSON  to_append)
      {
        if (!flagHasOutputParameters)
          {
            flagHasOutputParameters = true;
            storeOutputParameters.Clear();
          }
        Debug.Assert(flagHasOutputParameters);
        storeOutputParameters.Add(to_append);
      }
    public void unsetOutputParameters()
      {
        if (flagHasOutputParameters)
          {
            for (int num4 = 0; num4 < storeOutputParameters.Count; ++num4)
              {
              }
          }
        flagHasOutputParameters = false;
        storeOutputParameters.Clear();
      }
    public void initClauses()
      {
        if (flagHasClauses)
          {
            for (int num5 = 0; num5 < storeClauses.Count; ++num5)
              {
              }
          }
        flagHasClauses = true;
        storeClauses.Clear();
      }
    public void appendClauses(TerrierUploadClauseJSON  to_append)
      {
        if (!flagHasClauses)
          {
            flagHasClauses = true;
            storeClauses.Clear();
          }
        Debug.Assert(flagHasClauses);
        storeClauses.Add(to_append);
      }
    public void unsetClauses()
      {
        if (flagHasClauses)
          {
            for (int num6 = 0; num6 < storeClauses.Count; ++num6)
              {
              }
          }
        flagHasClauses = false;
        storeClauses.Clear();
      }
    public void setCodeLanguage(UploadedCodeFunctionLanguageJSON  new_value)
      {
        if (flagHasCodeLanguage)
          {
          }
        flagHasCodeLanguage = true;
        storeCodeLanguage = new_value;
      }
    public void setCodeLanguage(UploadedCodeFunctionLanguageJSON.TypeValue new_value)
      {
        setCodeLanguage(new UploadedCodeFunctionLanguageJSON(new_value));
      }
    public void setCodeLanguage(string chars)
      {
        UploadedCodeFunctionLanguageJSON.TypeValueKnownValues known = UploadedCodeFunctionLanguageJSON.stringToValue(chars);
        UploadedCodeFunctionLanguageJSON.TypeValue new_value = new UploadedCodeFunctionLanguageJSON.TypeValue();
        if (known == UploadedCodeFunctionLanguageJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setCodeLanguage(new_value);
      }
    public void unsetCodeLanguage()
      {
        if (flagHasCodeLanguage)
          {
          }
        flagHasCodeLanguage = false;
      }

    public virtual void extraTerrierUploadBlockAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTerrierUploadBlockSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTerrierUploadBlockLookup(key);
        if (old_field == null)
          {
            extraTerrierUploadBlockAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasName);
        if (flagHasName)
          {
            handler.start_pair("Name");
            handler.string_value(storeName);
          }
        Debug.Assert(partial_allowed || flagHasInputParameters);
        if (flagHasInputParameters)
          {
            handler.start_pair("InputParameters");
            handler.start_array();
            for (int num1 = 0; num1 < storeInputParameters.Count; ++num1)
              {
                if (partial_allowed)
                    storeInputParameters[num1].write_partial_as_json(handler);
                else
                    storeInputParameters[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasOutputParameters);
        if (flagHasOutputParameters)
          {
            handler.start_pair("OutputParameters");
            handler.start_array();
            for (int num2 = 0; num2 < storeOutputParameters.Count; ++num2)
              {
                if (partial_allowed)
                    storeOutputParameters[num2].write_partial_as_json(handler);
                else
                    storeOutputParameters[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasClauses);
        if (flagHasClauses)
          {
            handler.start_pair("Clauses");
            handler.start_array();
            for (int num3 = 0; num3 < storeClauses.Count; ++num3)
              {
                if (partial_allowed)
                    storeClauses[num3].write_partial_as_json(handler);
                else
                    storeClauses[num3].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasCodeLanguage)
          {
            handler.start_pair("CodeLanguage");
            if (partial_allowed)
                storeCodeLanguage.write_partial_as_json(handler);
            else
                storeCodeLanguage.write_as_json(handler);
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
        if (!(hasName()))
          {
            return "When parsing the object for %what%, the \"Name\" field was missing.";
          }
        if (!(hasInputParameters()))
          {
            return "When parsing the object for %what%, the \"InputParameters\" field was missing.";
          }
        if (!(hasOutputParameters()))
          {
            return "When parsing the object for %what%, the \"OutputParameters\" field was missing.";
          }
        if (!(hasClauses()))
          {
            return "When parsing the object for %what%, the \"Clauses\" field was missing.";
          }
        return null;
      }

    public static TerrierUploadBlockJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrierUploadBlockJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadBlock", ignore_extras);
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
    public static TerrierUploadBlockJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TerrierUploadBlockJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrierUploadBlockJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadBlock", ignore_extras);
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
    public static TerrierUploadBlockJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TerrierUploadBlockJSON from_text(string text, bool ignore_extras)
      {
        TerrierUploadBlockJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadBlock", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TerrierUploadBlockJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static TerrierUploadBlockJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TerrierUploadBlockJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadBlock", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorName : JSONStringGenerator
          {
            private Regex checker;
            protected FieldGeneratorName()  { checker = new Regex("^[a-zA-Z_]([a-zA-Z_0-9]*)$"); }
            protected void validate(string result)
              {
                if (!(checker.IsMatch(result)))
                    error("The string for %what% doesn't match the required pattern @^[a-zA-Z_]([a-zA-Z_0-9]*)$@.");
              }
          };
    private class FieldHoldingGeneratorName : FieldGeneratorName
  {
    protected override void handle_result(string result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorName(String what)
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
    public string value;
  };
    private class FieldHoldingArrayGeneratorName : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorName
      {
        private FieldHoldingArrayGeneratorName top;

        protected override void handle_result(string result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorName init_top)
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
    protected virtual void handle_result(List<string> result)
      {
      }

    public FieldHoldingArrayGeneratorName(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<string>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorName()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<string>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<string> value;
  };
        private FieldHoldingGeneratorName fieldGeneratorName;
        private TerrierUploadParameterJSON.HoldingArrayGenerator fieldGeneratorInputParameters;
        private TerrierUploadParameterJSON.HoldingArrayGenerator fieldGeneratorOutputParameters;
        private TerrierUploadClauseJSON.HoldingArrayGenerator fieldGeneratorClauses;
        private UploadedCodeFunctionLanguageJSON.HoldingGenerator fieldGeneratorCodeLanguage;
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
            TerrierUploadBlockJSON result = new TerrierUploadBlockJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTerrierUploadBlockAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(TerrierUploadBlockJSON result)
          {
            if (fieldGeneratorName.have_value)
              {
                result.setName(fieldGeneratorName.value);
                fieldGeneratorName.have_value = false;
              }
            else if ((!(result.hasName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Name\" field was missing.");
              }
            if (fieldGeneratorInputParameters.have_value)
              {
                result.initInputParameters();
                int count = fieldGeneratorInputParameters.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendInputParameters(fieldGeneratorInputParameters.value[num]);
                  }
                fieldGeneratorInputParameters.value.Clear();
                fieldGeneratorInputParameters.have_value = false;
              }
            else if ((!(result.hasInputParameters())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"InputParameters\" field was missing.");
              }
            if (fieldGeneratorOutputParameters.have_value)
              {
                result.initOutputParameters();
                int count = fieldGeneratorOutputParameters.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendOutputParameters(fieldGeneratorOutputParameters.value[num]);
                  }
                fieldGeneratorOutputParameters.value.Clear();
                fieldGeneratorOutputParameters.have_value = false;
              }
            else if ((!(result.hasOutputParameters())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"OutputParameters\" field was missing.");
              }
            if (fieldGeneratorClauses.have_value)
              {
                result.initClauses();
                int count = fieldGeneratorClauses.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendClauses(fieldGeneratorClauses.value[num]);
                  }
                fieldGeneratorClauses.value.Clear();
                fieldGeneratorClauses.have_value = false;
              }
            else if ((!(result.hasClauses())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Clauses\" field was missing.");
              }
            if (fieldGeneratorCodeLanguage.have_value)
              {
                result.setCodeLanguage(fieldGeneratorCodeLanguage.value);
                fieldGeneratorCodeLanguage.have_value = false;
              }
          }
        protected abstract void handle_result(TerrierUploadBlockJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    switch (field_name[1])
                      {
                        case 'l':
                            if ((String.Compare(field_name, 2, "auses", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorClauses;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "deLanguage", 0, 10, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorCodeLanguage;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "nputParameters", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorInputParameters;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorName;
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "utputParameters", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorOutputParameters;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorName = new FieldHoldingGeneratorName("field \"Name\" of the TerrierUploadBlock class");
            fieldGeneratorInputParameters = new TerrierUploadParameterJSON.HoldingArrayGenerator("field \"InputParameters\" of the TerrierUploadBlock class", ignore_extras);
            fieldGeneratorOutputParameters = new TerrierUploadParameterJSON.HoldingArrayGenerator("field \"OutputParameters\" of the TerrierUploadBlock class", ignore_extras);
            fieldGeneratorClauses = new TerrierUploadClauseJSON.HoldingArrayGenerator("field \"Clauses\" of the TerrierUploadBlock class", ignore_extras);
            fieldGeneratorCodeLanguage = new UploadedCodeFunctionLanguageJSON.HoldingGenerator("field \"CodeLanguage\" of the TerrierUploadBlock class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TerrierUploadBlock class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorName = new FieldHoldingGeneratorName("field \"Name\" of the TerrierUploadBlock class");
            fieldGeneratorInputParameters = new TerrierUploadParameterJSON.HoldingArrayGenerator("field \"InputParameters\" of the TerrierUploadBlock class", false);
            fieldGeneratorOutputParameters = new TerrierUploadParameterJSON.HoldingArrayGenerator("field \"OutputParameters\" of the TerrierUploadBlock class", false);
            fieldGeneratorClauses = new TerrierUploadClauseJSON.HoldingArrayGenerator("field \"Clauses\" of the TerrierUploadBlock class", false);
            fieldGeneratorCodeLanguage = new UploadedCodeFunctionLanguageJSON.HoldingGenerator("field \"CodeLanguage\" of the TerrierUploadBlock class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TerrierUploadBlock class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorName.reset();
            fieldGeneratorInputParameters.reset();
            fieldGeneratorOutputParameters.reset();
            fieldGeneratorClauses.reset();
            fieldGeneratorCodeLanguage.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorCodeLanguage.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorCodeLanguage.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(TerrierUploadBlockJSON  result)
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
        public TerrierUploadBlockJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TerrierUploadBlockJSON  result)
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
    protected virtual void handle_result(List<TerrierUploadBlockJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TerrierUploadBlockJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TerrierUploadBlockJSON>();
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
    public List<TerrierUploadBlockJSON> value;
  };
  };
