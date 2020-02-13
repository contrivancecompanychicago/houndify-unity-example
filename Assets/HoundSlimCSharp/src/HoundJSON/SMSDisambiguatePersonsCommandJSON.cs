/* file "SMSDisambiguatePersonsCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SMSDisambiguatePersonsCommandJSON : DisambiguateCommandJSON
  {
    new public class TypeNativeDataJSON : JSONBase
      {
        private bool flagHasMultiSelect;
        private bool storeMultiSelect;
        private bool flagHasChoiceList;
        private List< DisambiguateChoiceJSON  > storeChoiceList;
        private bool flagHasWhichContactChoices;
        private WhichContactChoicesJSON  storeWhichContactChoices;
        private bool flagHasPreviousMessage;
        private string storePreviousMessage;
        private bool flagHasSpokenBody;
        private string storeSpokenBody;
        private bool flagHasWrittenBody;
        private string storeWrittenBody;
        private bool flagHasErrorMessage;
        private string storeErrorMessage;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONMultiSelect(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field MultiSelect of TypeNativeDataJSON is not true for false.");
                  }
              }
            setMultiSelect(the_bool);
          }


        private void  fromJSONChoiceList(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field ChoiceList of TypeNativeDataJSON is not an array.");
            int count1 = json_array1.componentCount();
            if (count1 < 2)
                throw new Exception("The value for field ChoiceList of TypeNativeDataJSON has too few elements.");
            List< DisambiguateChoiceJSON  > vector_ChoiceList1 = new List< DisambiguateChoiceJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                DisambiguateChoiceJSON convert_classy = DisambiguateChoiceJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_ChoiceList1.Add(convert_classy);
              }
            Debug.Assert(vector_ChoiceList1.Count >= 2);
            initChoiceList();
            for (int num1 = 0; num1 < vector_ChoiceList1.Count; ++num1)
                appendChoiceList(vector_ChoiceList1[num1]);
            for (int num1 = 0; num1 < vector_ChoiceList1.Count; ++num1)
              {
              }
          }


        private void  fromJSONWhichContactChoices(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            WhichContactChoicesJSON convert_classy = WhichContactChoicesJSON.from_json(json_value, ignore_extras, true);
            setWhichContactChoices(convert_classy);
          }


        private void  fromJSONPreviousMessage(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field PreviousMessage of TypeNativeDataJSON is not a string.");
            setPreviousMessage(json_string.getData());
          }


        private void  fromJSONSpokenBody(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field SpokenBody of TypeNativeDataJSON is not a string.");
            setSpokenBody(json_string.getData());
          }


        private void  fromJSONWrittenBody(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field WrittenBody of TypeNativeDataJSON is not a string.");
            setWrittenBody(json_string.getData());
          }


        private void  fromJSONErrorMessage(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field ErrorMessage of TypeNativeDataJSON is not a string.");
            setErrorMessage(json_string.getData());
          }


        public TypeNativeDataJSON()
          {
            flagHasMultiSelect = false;
            flagHasChoiceList = false;
            flagHasWhichContactChoices = false;
            flagHasPreviousMessage = false;
            flagHasSpokenBody = false;
            flagHasWrittenBody = false;
            flagHasErrorMessage = false;
            storeChoiceList = new List< DisambiguateChoiceJSON  >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasMultiSelect()
          {
            return flagHasMultiSelect;
          }

        public bool  getMultiSelect()
          {
            Debug.Assert(flagHasMultiSelect);
            return storeMultiSelect;
          }

        public bool  hasChoiceList()
          {
            return flagHasChoiceList;
          }

        public int  countOfChoiceList()
          {
            Debug.Assert(flagHasChoiceList);
            return storeChoiceList.Count;
          }

        public DisambiguateChoiceJSON   elementOfChoiceList(int element_num)
          {
            Debug.Assert(flagHasChoiceList);
            return storeChoiceList[element_num];
          }

        public List< DisambiguateChoiceJSON  >  getChoiceList()
          {
            Debug.Assert(flagHasChoiceList);
            return storeChoiceList;
          }

        public bool  hasWhichContactChoices()
          {
            return flagHasWhichContactChoices;
          }

        public WhichContactChoicesJSON   getWhichContactChoices()
          {
            Debug.Assert(flagHasWhichContactChoices);
            return storeWhichContactChoices;
          }

        public bool  hasPreviousMessage()
          {
            return flagHasPreviousMessage;
          }

        public string  getPreviousMessage()
          {
            Debug.Assert(flagHasPreviousMessage);
            return storePreviousMessage;
          }

        public bool  hasSpokenBody()
          {
            return flagHasSpokenBody;
          }

        public string  getSpokenBody()
          {
            Debug.Assert(flagHasSpokenBody);
            return storeSpokenBody;
          }

        public bool  hasWrittenBody()
          {
            return flagHasWrittenBody;
          }

        public string  getWrittenBody()
          {
            Debug.Assert(flagHasWrittenBody);
            return storeWrittenBody;
          }

        public bool  hasErrorMessage()
          {
            return flagHasErrorMessage;
          }

        public string  getErrorMessage()
          {
            Debug.Assert(flagHasErrorMessage);
            return storeErrorMessage;
          }


        public virtual int extraTypeNativeDataComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeNativeDataComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeNativeDataComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeNativeDataLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setMultiSelect(bool new_value)
          {
            flagHasMultiSelect = true;
            storeMultiSelect = new_value;
          }
        public void unsetMultiSelect()
          {
            flagHasMultiSelect = false;
          }
        public void initChoiceList()
          {
            if (flagHasChoiceList)
              {
                for (int num1 = 0; num1 < storeChoiceList.Count; ++num1)
                  {
                  }
              }
            flagHasChoiceList = true;
            storeChoiceList.Clear();
          }
        public void appendChoiceList(DisambiguateChoiceJSON  to_append)
          {
            if (!flagHasChoiceList)
              {
                flagHasChoiceList = true;
                storeChoiceList.Clear();
              }
            Debug.Assert(flagHasChoiceList);
            storeChoiceList.Add(to_append);
          }
        public void unsetChoiceList()
          {
            if (flagHasChoiceList)
              {
                for (int num2 = 0; num2 < storeChoiceList.Count; ++num2)
                  {
                  }
              }
            flagHasChoiceList = false;
            storeChoiceList.Clear();
          }
        public void setWhichContactChoices(WhichContactChoicesJSON  new_value)
          {
            if (flagHasWhichContactChoices)
              {
              }
            flagHasWhichContactChoices = true;
            storeWhichContactChoices = new_value;
          }
        public void unsetWhichContactChoices()
          {
            if (flagHasWhichContactChoices)
              {
              }
            flagHasWhichContactChoices = false;
          }
        public void setPreviousMessage(string new_value)
          {
            flagHasPreviousMessage = true;
            storePreviousMessage = new_value;
          }
        public void unsetPreviousMessage()
          {
            flagHasPreviousMessage = false;
          }
        public void setSpokenBody(string new_value)
          {
            flagHasSpokenBody = true;
            storeSpokenBody = new_value;
          }
        public void unsetSpokenBody()
          {
            flagHasSpokenBody = false;
          }
        public void setWrittenBody(string new_value)
          {
            flagHasWrittenBody = true;
            storeWrittenBody = new_value;
          }
        public void unsetWrittenBody()
          {
            flagHasWrittenBody = false;
          }
        public void setErrorMessage(string new_value)
          {
            flagHasErrorMessage = true;
            storeErrorMessage = new_value;
          }
        public void unsetErrorMessage()
          {
            flagHasErrorMessage = false;
          }

        public virtual void extraTypeNativeDataAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeNativeDataSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeNativeDataLookup(key);
            if (old_field == null)
              {
                extraTypeNativeDataAppendPair(key, new_component);
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
            if (flagHasMultiSelect)
              {
                handler.start_pair("MultiSelect");
                handler.boolean_value(storeMultiSelect);
              }
            Debug.Assert(partial_allowed || flagHasChoiceList);
            if (flagHasChoiceList)
              {
                handler.start_pair("ChoiceList");
                Debug.Assert(storeChoiceList.Count >= 2);
                handler.start_array();
                for (int num1 = 0; num1 < storeChoiceList.Count; ++num1)
                  {
                    if (partial_allowed)
                        storeChoiceList[num1].write_partial_as_json(handler);
                    else
                        storeChoiceList[num1].write_as_json(handler);
                  }
                handler.finish_array();
              }
            Debug.Assert(partial_allowed || flagHasWhichContactChoices);
            if (flagHasWhichContactChoices)
              {
                handler.start_pair("WhichContactChoices");
                if (partial_allowed)
                    storeWhichContactChoices.write_partial_as_json(handler);
                else
                    storeWhichContactChoices.write_as_json(handler);
              }
            if (flagHasPreviousMessage)
              {
                handler.start_pair("PreviousMessage");
                handler.string_value(storePreviousMessage);
              }
            if (flagHasSpokenBody)
              {
                handler.start_pair("SpokenBody");
                handler.string_value(storeSpokenBody);
              }
            if (flagHasWrittenBody)
              {
                handler.start_pair("WrittenBody");
                handler.string_value(storeWrittenBody);
              }
            if (flagHasErrorMessage)
              {
                handler.start_pair("ErrorMessage");
                handler.string_value(storeErrorMessage);
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
            if (!(hasChoiceList()))
              {
                return "When parsing the object for %what%, the \"ChoiceList\" field was missing.";
              }
            if (!(hasWhichContactChoices()))
              {
                return "When parsing the object for %what%, the \"WhichContactChoices\" field was missing.";
              }
            return null;
          }

        public static TypeNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
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
        public static TypeNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
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
        public static TypeNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNativeDataJSON from_text(string text, bool ignore_extras)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeNativeDataJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeNativeDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingBooleanGenerator fieldGeneratorMultiSelect;
            private DisambiguateChoiceJSON.HoldingArrayGenerator fieldGeneratorChoiceList;
            private WhichContactChoicesJSON.HoldingGenerator fieldGeneratorWhichContactChoices;
            private JSONHoldingStringGenerator fieldGeneratorPreviousMessage;
            private JSONHoldingStringGenerator fieldGeneratorSpokenBody;
            private JSONHoldingStringGenerator fieldGeneratorWrittenBody;
            private JSONHoldingStringGenerator fieldGeneratorErrorMessage;
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
                TypeNativeDataJSON result = new TypeNativeDataJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeNativeDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeNativeDataJSON result)
              {
                if (fieldGeneratorMultiSelect.have_value)
                  {
                    result.setMultiSelect(fieldGeneratorMultiSelect.value);
                    fieldGeneratorMultiSelect.have_value = false;
                  }
                if (fieldGeneratorChoiceList.have_value)
                  {
                    result.initChoiceList();
                    int count = fieldGeneratorChoiceList.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendChoiceList(fieldGeneratorChoiceList.value[num]);
                      }
                    fieldGeneratorChoiceList.value.Clear();
                    fieldGeneratorChoiceList.have_value = false;
                  }
                else if ((!(result.hasChoiceList())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"ChoiceList\" field was missing.");
                  }
                if (fieldGeneratorWhichContactChoices.have_value)
                  {
                    result.setWhichContactChoices(fieldGeneratorWhichContactChoices.value);
                    fieldGeneratorWhichContactChoices.have_value = false;
                  }
                else if ((!(result.hasWhichContactChoices())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"WhichContactChoices\" field was missing.");
                  }
                if (fieldGeneratorPreviousMessage.have_value)
                  {
                    result.setPreviousMessage(fieldGeneratorPreviousMessage.value);
                    fieldGeneratorPreviousMessage.have_value = false;
                  }
                if (fieldGeneratorSpokenBody.have_value)
                  {
                    result.setSpokenBody(fieldGeneratorSpokenBody.value);
                    fieldGeneratorSpokenBody.have_value = false;
                  }
                if (fieldGeneratorWrittenBody.have_value)
                  {
                    result.setWrittenBody(fieldGeneratorWrittenBody.value);
                    fieldGeneratorWrittenBody.have_value = false;
                  }
                if (fieldGeneratorErrorMessage.have_value)
                  {
                    result.setErrorMessage(fieldGeneratorErrorMessage.value);
                    fieldGeneratorErrorMessage.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeNativeDataJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'C':
                        if ((String.Compare(field_name, 1, "hoiceList", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorChoiceList;
                        break;
                    case 'E':
                        if ((String.Compare(field_name, 1, "rrorMessage", 0, 11, false) == 0) && (field_name.Length == 12))
                            return fieldGeneratorErrorMessage;
                        break;
                    case 'M':
                        if ((String.Compare(field_name, 1, "ultiSelect", 0, 10, false) == 0) && (field_name.Length == 11))
                            return fieldGeneratorMultiSelect;
                        break;
                    case 'P':
                        if ((String.Compare(field_name, 1, "reviousMessage", 0, 14, false) == 0) && (field_name.Length == 15))
                            return fieldGeneratorPreviousMessage;
                        break;
                    case 'S':
                        if ((String.Compare(field_name, 1, "pokenBody", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorSpokenBody;
                        break;
                    case 'W':
                        switch (field_name[1])
                          {
                            case 'h':
                                if ((String.Compare(field_name, 2, "ichContactChoices", 0, 17, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorWhichContactChoices;
                                break;
                            case 'r':
                                if ((String.Compare(field_name, 2, "ittenBody", 0, 9, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorWrittenBody;
                                break;
                            default:
                                break;
                          }
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorMultiSelect = new JSONHoldingBooleanGenerator("field \"MultiSelect\" of the TypeNativeData class");
                fieldGeneratorChoiceList = new DisambiguateChoiceJSON.HoldingArrayGenerator("field \"ChoiceList\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorWhichContactChoices = new WhichContactChoicesJSON.HoldingGenerator("field \"WhichContactChoices\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorPreviousMessage = new JSONHoldingStringGenerator("field \"PreviousMessage\" of the TypeNativeData class");
                fieldGeneratorSpokenBody = new JSONHoldingStringGenerator("field \"SpokenBody\" of the TypeNativeData class");
                fieldGeneratorWrittenBody = new JSONHoldingStringGenerator("field \"WrittenBody\" of the TypeNativeData class");
                fieldGeneratorErrorMessage = new JSONHoldingStringGenerator("field \"ErrorMessage\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorMultiSelect = new JSONHoldingBooleanGenerator("field \"MultiSelect\" of the TypeNativeData class");
                fieldGeneratorChoiceList = new DisambiguateChoiceJSON.HoldingArrayGenerator("field \"ChoiceList\" of the TypeNativeData class", false);
                fieldGeneratorWhichContactChoices = new WhichContactChoicesJSON.HoldingGenerator("field \"WhichContactChoices\" of the TypeNativeData class", false);
                fieldGeneratorPreviousMessage = new JSONHoldingStringGenerator("field \"PreviousMessage\" of the TypeNativeData class");
                fieldGeneratorSpokenBody = new JSONHoldingStringGenerator("field \"SpokenBody\" of the TypeNativeData class");
                fieldGeneratorWrittenBody = new JSONHoldingStringGenerator("field \"WrittenBody\" of the TypeNativeData class");
                fieldGeneratorErrorMessage = new JSONHoldingStringGenerator("field \"ErrorMessage\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorMultiSelect.reset();
                fieldGeneratorChoiceList.reset();
                fieldGeneratorWhichContactChoices.reset();
                fieldGeneratorPreviousMessage.reset();
                fieldGeneratorSpokenBody.reset();
                fieldGeneratorWrittenBody.reset();
                fieldGeneratorErrorMessage.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorWhichContactChoices.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorWhichContactChoices.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeNativeDataJSON  result)
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
            public TypeNativeDataJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeNativeDataJSON  result)
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
        protected virtual void handle_result(List<TypeNativeDataJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeNativeDataJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeNativeDataJSON>();
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
        public List<TypeNativeDataJSON> value;
      };
      };
    private bool flagHasNativeData;
    private TypeNativeDataJSON  storeNativeData;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraNativeDataToJSON()
      {
        JSONValueHandler handler_NativeData = new JSONValueHandler();
        storeNativeData.write_as_json(handler_NativeData);
        return handler_NativeData.result;
      }


    private void  fromJSONNativeData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeNativeDataJSON convert_classy = TypeNativeDataJSON.from_json(json_value, ignore_extras, true);
        setNativeData(convert_classy);
      }


    public SMSDisambiguatePersonsCommandJSON()
      {
        flagHasNativeData = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getDisambiguateCommandKind()
      {
        return "SMSDisambiguatePersonsCommand";
      }

    public new bool  hasNativeData()
      {
        return flagHasNativeData;
      }

    public new TypeNativeDataJSON   getNativeData()
      {
        Debug.Assert(flagHasNativeData);
        return storeNativeData;
      }


    public virtual int extraSMSDisambiguatePersonsCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSMSDisambiguatePersonsCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSMSDisambiguatePersonsCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSMSDisambiguatePersonsCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraDisambiguateCommandComponentCount()
      {
        int result = 0;
        if (flagHasNativeData)
            ++result;
        result += extraSMSDisambiguatePersonsCommandComponentCount();
        return result;
      }
    public override string extraDisambiguateCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return "NativeData";
            --remainder;
          }
        return extraSMSDisambiguatePersonsCommandComponentKey(remainder);
      }
    public override JSONValue extraDisambiguateCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return extraNativeDataToJSON();
            --remainder;
          }
        return extraSMSDisambiguatePersonsCommandComponentValue(remainder);
      }
    public override JSONValue extraDisambiguateCommandLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "NativeData", 0, 10, false) == 0) && (field_name.Length == 10))
            return (flagHasNativeData ? extraNativeDataToJSON() : null);
        return extraSMSDisambiguatePersonsCommandLookup(field_name);
      }

    public new void setNativeData(TypeNativeDataJSON  new_value)
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = true;
        storeNativeData = new_value;
        DisambiguateCommandJSON.TypeNativeDataJSON.HoldingGenerator convert_handler = new DisambiguateCommandJSON.TypeNativeDataJSON.HoldingGenerator("Type DisambiguateCommandJSON.TypeNativeDataJSON");
        new_value.write_as_json(convert_handler);
        base.setNativeData(convert_handler.value);
      }
    public void setNativeData(DisambiguateCommandJSON.TypeNativeDataJSON  new_value)
      {
        TypeNativeDataJSON.HoldingGenerator convert_handler = new TypeNativeDataJSON.HoldingGenerator("Type TypeNativeDataJSON");
        new_value.write_as_json(convert_handler);
        setNativeData(convert_handler.value);
      }
    public void unsetNativeData()
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = false;
        base.unsetNativeData();
      }

    public virtual void extraSMSDisambiguatePersonsCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSMSDisambiguatePersonsCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSMSDisambiguatePersonsCommandLookup(key);
        if (old_field == null)
          {
            extraSMSDisambiguatePersonsCommandAppendPair(key, new_component);
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
    public override void extraDisambiguateCommandAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "NativeData", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONNativeData(new_component, false);
            return;
            }
        extraSMSDisambiguatePersonsCommandAppendPair(key, new_component);
      }
    public override void extraDisambiguateCommandSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "NativeData", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONNativeData(new_component, false);
            return;
            }
        extraSMSDisambiguatePersonsCommandSetField(key, new_component);
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
    public override void writeFieldNativeData(JSONHandler handler)
      {
        Debug.Assert(flagHasNativeData);
        handler.start_pair("NativeData");
        storeNativeData.write_as_json(handler);
      }
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasNativeData()))
          {
            return "When parsing the object for %what%, the \"NativeData\" field was missing.";
          }
        return null;
      }

    public static new SMSDisambiguatePersonsCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SMSDisambiguatePersonsCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSDisambiguatePersonsCommand", ignore_extras);
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
    public static new SMSDisambiguatePersonsCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SMSDisambiguatePersonsCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SMSDisambiguatePersonsCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSDisambiguatePersonsCommand", ignore_extras);
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
    public static new SMSDisambiguatePersonsCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SMSDisambiguatePersonsCommandJSON from_text(string text, bool ignore_extras)
      {
        SMSDisambiguatePersonsCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSDisambiguatePersonsCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SMSDisambiguatePersonsCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SMSDisambiguatePersonsCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SMSDisambiguatePersonsCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSDisambiguatePersonsCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : DisambiguateCommandJSON.Generator
      {
        private TypeNativeDataJSON.HoldingGenerator fieldGeneratorNativeData;
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
            if (!(getDisambiguateCommandJSONKey().Equals("SMSDisambiguatePersonsCommand")))
                throw new Exception("The key field has a value other than `SMSDisambiguatePersonsCommand'.");
            SMSDisambiguatePersonsCommandJSON result = new SMSDisambiguatePersonsCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSMSDisambiguatePersonsCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(DisambiguateCommandJSON new_result)
          {
            handle_result((SMSDisambiguatePersonsCommandJSON )new_result);
          }
        protected void finish(SMSDisambiguatePersonsCommandJSON result)
          {
            if (fieldGeneratorNativeData.have_value)
              {
                result.setNativeData(fieldGeneratorNativeData.value);
                fieldGeneratorNativeData.have_value = false;
              }
            else if ((!(result.hasNativeData())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NativeData\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(SMSDisambiguatePersonsCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "NativeData", 0, 10, false) == 0) && (field_name.Length == 10))
                return fieldGeneratorNativeData;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the SMSDisambiguatePersonsCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SMSDisambiguatePersonsCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the SMSDisambiguatePersonsCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SMSDisambiguatePersonsCommand class");
          }

        public override void reset()
          {
            fieldGeneratorNativeData.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SMSDisambiguatePersonsCommandJSON  result)
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
        public SMSDisambiguatePersonsCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SMSDisambiguatePersonsCommandJSON  result)
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
    protected virtual void handle_result(List<SMSDisambiguatePersonsCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SMSDisambiguatePersonsCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SMSDisambiguatePersonsCommandJSON>();
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
    public List<SMSDisambiguatePersonsCommandJSON> value;
  };
  };
