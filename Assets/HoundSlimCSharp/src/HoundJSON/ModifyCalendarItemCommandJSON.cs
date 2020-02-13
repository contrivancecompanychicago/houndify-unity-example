/* file "ModifyCalendarItemCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class ModifyCalendarItemCommandJSON : CalendarCommandJSON
  {
    public enum TypeNewFrequencyType
      {
        NewFrequencyType_unknown,
        NewFrequencyType_one_time,
        NewFrequencyType_daily,
        NewFrequencyType_weekly,
        NewFrequencyType_monthly,
        NewFrequencyType_yearly
      };

    public static TypeNewFrequencyType  stringToNewFrequencyType(string chars)
      {
        switch (chars[0])
          {
            case 'd':
                if ((String.Compare(chars, 1, "aily", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeNewFrequencyType.NewFrequencyType_daily;
                break;
            case 'm':
                if ((String.Compare(chars, 1, "onthly", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeNewFrequencyType.NewFrequencyType_monthly;
                break;
            case 'o':
                if ((String.Compare(chars, 1, "ne-time", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeNewFrequencyType.NewFrequencyType_one_time;
                break;
            case 'u':
                if ((String.Compare(chars, 1, "nknown", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeNewFrequencyType.NewFrequencyType_unknown;
                break;
            case 'w':
                if ((String.Compare(chars, 1, "eekly", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeNewFrequencyType.NewFrequencyType_weekly;
                break;
            case 'y':
                if ((String.Compare(chars, 1, "early", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeNewFrequencyType.NewFrequencyType_yearly;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `NewFrequencyType' is not one of the legal values.");
      }

    public static string  stringFromNewFrequencyType(TypeNewFrequencyType the_enum)
      {
        switch (the_enum)
          {
            case TypeNewFrequencyType.NewFrequencyType_unknown:
                return "unknown";
            case TypeNewFrequencyType.NewFrequencyType_one_time:
                return "one-time";
            case TypeNewFrequencyType.NewFrequencyType_daily:
                return "daily";
            case TypeNewFrequencyType.NewFrequencyType_weekly:
                return "weekly";
            case TypeNewFrequencyType.NewFrequencyType_monthly:
                return "monthly";
            case TypeNewFrequencyType.NewFrequencyType_yearly:
                return "yearly";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public class TypeSetEventFieldsJSON : JSONBase
      {
        private bool flagHasFieldName;
        private string storeFieldName;
        private bool flagHasNewValue;
        private JSONValue  storeNewValue;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONFieldName(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field FieldName of TypeSetEventFieldsJSON is not a string.");
            setFieldName(json_string.getData());
          }


        private void  fromJSONNewValue(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            setNewValue(json_value);
          }


        public TypeSetEventFieldsJSON()
          {
            flagHasFieldName = false;
            flagHasNewValue = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasFieldName()
          {
            return flagHasFieldName;
          }

        public string  getFieldName()
          {
            Debug.Assert(flagHasFieldName);
            return storeFieldName;
          }

        public bool  hasNewValue()
          {
            return flagHasNewValue;
          }

        public JSONValue   getNewValue()
          {
            Debug.Assert(flagHasNewValue);
            return storeNewValue;
          }


        public virtual int extraTypeSetEventFieldsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeSetEventFieldsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeSetEventFieldsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeSetEventFieldsLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setFieldName(string new_value)
          {
            flagHasFieldName = true;
            storeFieldName = new_value;
          }
        public void unsetFieldName()
          {
            flagHasFieldName = false;
          }
        public void setNewValue(JSONValue  new_value)
          {
            if (flagHasNewValue)
              {
              }
            flagHasNewValue = true;
            storeNewValue = new_value;
          }
        public void unsetNewValue()
          {
            if (flagHasNewValue)
              {
              }
            flagHasNewValue = false;
          }

        public virtual void extraTypeSetEventFieldsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeSetEventFieldsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeSetEventFieldsLookup(key);
            if (old_field == null)
              {
                extraTypeSetEventFieldsAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasFieldName);
            if (flagHasFieldName)
              {
                handler.start_pair("FieldName");
                handler.string_value(storeFieldName);
              }
            Debug.Assert(partial_allowed || flagHasNewValue);
            if (flagHasNewValue)
              {
                handler.start_pair("NewValue");
                storeNewValue.write(handler);
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
            if (!(hasFieldName()))
              {
                return "When parsing the object for %what%, the \"FieldName\" field was missing.";
              }
            if (!(hasNewValue()))
              {
                return "When parsing the object for %what%, the \"NewValue\" field was missing.";
              }
            return null;
          }

        public static TypeSetEventFieldsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeSetEventFieldsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSetEventFields", ignore_extras);
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
        public static TypeSetEventFieldsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeSetEventFieldsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeSetEventFieldsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSetEventFields", ignore_extras);
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
        public static TypeSetEventFieldsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeSetEventFieldsJSON from_text(string text, bool ignore_extras)
          {
            TypeSetEventFieldsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSetEventFields", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeSetEventFieldsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeSetEventFieldsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeSetEventFieldsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSetEventFields", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorFieldName;
            private JSONHoldingValueGenerator fieldGeneratorNewValue;
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
                TypeSetEventFieldsJSON result = new TypeSetEventFieldsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeSetEventFieldsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeSetEventFieldsJSON result)
              {
                if (fieldGeneratorFieldName.have_value)
                  {
                    result.setFieldName(fieldGeneratorFieldName.value);
                    fieldGeneratorFieldName.have_value = false;
                  }
                else if ((!(result.hasFieldName())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"FieldName\" field was missing.");
                  }
                if (fieldGeneratorNewValue.have_value)
                  {
                    result.setNewValue(fieldGeneratorNewValue.value);
                    fieldGeneratorNewValue.have_value = false;
                  }
                else if ((!(result.hasNewValue())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"NewValue\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeSetEventFieldsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'F':
                        if ((String.Compare(field_name, 1, "ieldName", 0, 8, false) == 0) && (field_name.Length == 9))
                            return fieldGeneratorFieldName;
                        break;
                    case 'N':
                        if ((String.Compare(field_name, 1, "ewValue", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorNewValue;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorFieldName = new JSONHoldingStringGenerator("field \"FieldName\" of the TypeSetEventFields class");
                fieldGeneratorNewValue = new JSONHoldingValueGenerator("field \"NewValue\" of the TypeSetEventFields class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeSetEventFields class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorFieldName = new JSONHoldingStringGenerator("field \"FieldName\" of the TypeSetEventFields class");
                fieldGeneratorNewValue = new JSONHoldingValueGenerator("field \"NewValue\" of the TypeSetEventFields class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeSetEventFields class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorFieldName.reset();
                fieldGeneratorNewValue.reset();
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
            protected override void handle_result(TypeSetEventFieldsJSON  result)
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
            public TypeSetEventFieldsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeSetEventFieldsJSON  result)
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
        protected virtual void handle_result(List<TypeSetEventFieldsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeSetEventFieldsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeSetEventFieldsJSON>();
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
        public List<TypeSetEventFieldsJSON> value;
      };
      };
    public class TypeAppendEventFieldsJSON : JSONBase
      {
        private bool flagHasFieldName;
        private string storeFieldName;
        private bool flagHasNewValues;
        private List< JSONValue  > storeNewValues;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONFieldName(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field FieldName of TypeAppendEventFieldsJSON is not a string.");
            setFieldName(json_string.getData());
          }


        private void  fromJSONNewValues(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field NewValues of TypeAppendEventFieldsJSON is not an array.");
            int count1 = json_array1.componentCount();
            if (count1 < 1)
                throw new Exception("The value for field NewValues of TypeAppendEventFieldsJSON has too few elements.");
            List< JSONValue  > vector_NewValues1 = new List< JSONValue  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                vector_NewValues1.Add(json_array1.component(num1));
              }
            Debug.Assert(vector_NewValues1.Count >= 1);
            initNewValues();
            for (int num1 = 0; num1 < vector_NewValues1.Count; ++num1)
                appendNewValues(vector_NewValues1[num1]);
            for (int num1 = 0; num1 < vector_NewValues1.Count; ++num1)
              {
              }
          }


        public TypeAppendEventFieldsJSON()
          {
            flagHasFieldName = false;
            flagHasNewValues = false;
            storeNewValues = new List< JSONValue  >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasFieldName()
          {
            return flagHasFieldName;
          }

        public string  getFieldName()
          {
            Debug.Assert(flagHasFieldName);
            return storeFieldName;
          }

        public bool  hasNewValues()
          {
            return flagHasNewValues;
          }

        public int  countOfNewValues()
          {
            Debug.Assert(flagHasNewValues);
            return storeNewValues.Count;
          }

        public JSONValue   elementOfNewValues(int element_num)
          {
            Debug.Assert(flagHasNewValues);
            return storeNewValues[element_num];
          }

        public List< JSONValue  >  getNewValues()
          {
            Debug.Assert(flagHasNewValues);
            return storeNewValues;
          }


        public virtual int extraTypeAppendEventFieldsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeAppendEventFieldsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeAppendEventFieldsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeAppendEventFieldsLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setFieldName(string new_value)
          {
            flagHasFieldName = true;
            storeFieldName = new_value;
          }
        public void unsetFieldName()
          {
            flagHasFieldName = false;
          }
        public void initNewValues()
          {
            if (flagHasNewValues)
              {
                for (int num1 = 0; num1 < storeNewValues.Count; ++num1)
                  {
                  }
              }
            flagHasNewValues = true;
            storeNewValues.Clear();
          }
        public void appendNewValues(JSONValue  to_append)
          {
            if (!flagHasNewValues)
              {
                flagHasNewValues = true;
                storeNewValues.Clear();
              }
            Debug.Assert(flagHasNewValues);
            storeNewValues.Add(to_append);
          }
        public void unsetNewValues()
          {
            if (flagHasNewValues)
              {
                for (int num2 = 0; num2 < storeNewValues.Count; ++num2)
                  {
                  }
              }
            flagHasNewValues = false;
            storeNewValues.Clear();
          }

        public virtual void extraTypeAppendEventFieldsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeAppendEventFieldsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeAppendEventFieldsLookup(key);
            if (old_field == null)
              {
                extraTypeAppendEventFieldsAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasFieldName);
            if (flagHasFieldName)
              {
                handler.start_pair("FieldName");
                handler.string_value(storeFieldName);
              }
            Debug.Assert(partial_allowed || flagHasNewValues);
            if (flagHasNewValues)
              {
                handler.start_pair("NewValues");
                Debug.Assert(storeNewValues.Count >= 1);
                handler.start_array();
                for (int num1 = 0; num1 < storeNewValues.Count; ++num1)
                  {
                    storeNewValues[num1].write(handler);
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
            if (!(hasFieldName()))
              {
                return "When parsing the object for %what%, the \"FieldName\" field was missing.";
              }
            if (!(hasNewValues()))
              {
                return "When parsing the object for %what%, the \"NewValues\" field was missing.";
              }
            return null;
          }

        public static TypeAppendEventFieldsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeAppendEventFieldsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAppendEventFields", ignore_extras);
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
        public static TypeAppendEventFieldsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeAppendEventFieldsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeAppendEventFieldsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAppendEventFields", ignore_extras);
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
        public static TypeAppendEventFieldsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeAppendEventFieldsJSON from_text(string text, bool ignore_extras)
          {
            TypeAppendEventFieldsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAppendEventFields", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeAppendEventFieldsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeAppendEventFieldsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeAppendEventFieldsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAppendEventFields", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorFieldName;
            private JSONHoldingValueArrayGenerator fieldGeneratorNewValues;
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
                TypeAppendEventFieldsJSON result = new TypeAppendEventFieldsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeAppendEventFieldsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeAppendEventFieldsJSON result)
              {
                if (fieldGeneratorFieldName.have_value)
                  {
                    result.setFieldName(fieldGeneratorFieldName.value);
                    fieldGeneratorFieldName.have_value = false;
                  }
                else if ((!(result.hasFieldName())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"FieldName\" field was missing.");
                  }
                if (fieldGeneratorNewValues.have_value)
                  {
                    result.initNewValues();
                    int count = fieldGeneratorNewValues.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendNewValues(fieldGeneratorNewValues.value[num]);
                      }
                    fieldGeneratorNewValues.value.Clear();
                    fieldGeneratorNewValues.have_value = false;
                  }
                else if ((!(result.hasNewValues())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"NewValues\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeAppendEventFieldsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'F':
                        if ((String.Compare(field_name, 1, "ieldName", 0, 8, false) == 0) && (field_name.Length == 9))
                            return fieldGeneratorFieldName;
                        break;
                    case 'N':
                        if ((String.Compare(field_name, 1, "ewValues", 0, 8, false) == 0) && (field_name.Length == 9))
                            return fieldGeneratorNewValues;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorFieldName = new JSONHoldingStringGenerator("field \"FieldName\" of the TypeAppendEventFields class");
                fieldGeneratorNewValues = new JSONHoldingValueArrayGenerator("field \"NewValues\" of the TypeAppendEventFields class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeAppendEventFields class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorFieldName = new JSONHoldingStringGenerator("field \"FieldName\" of the TypeAppendEventFields class");
                fieldGeneratorNewValues = new JSONHoldingValueArrayGenerator("field \"NewValues\" of the TypeAppendEventFields class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeAppendEventFields class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorFieldName.reset();
                fieldGeneratorNewValues.reset();
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
            protected override void handle_result(TypeAppendEventFieldsJSON  result)
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
            public TypeAppendEventFieldsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeAppendEventFieldsJSON  result)
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
        protected virtual void handle_result(List<TypeAppendEventFieldsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeAppendEventFieldsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeAppendEventFieldsJSON>();
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
        public List<TypeAppendEventFieldsJSON> value;
      };
      };
    public class TypeAddEventFieldsJSON : JSONBase
      {
        private bool flagHasFieldName;
        private string storeFieldName;
        private bool flagHasNewValue;
        private JSONValue  storeNewValue;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONFieldName(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field FieldName of TypeAddEventFieldsJSON is not a string.");
            setFieldName(json_string.getData());
          }


        private void  fromJSONNewValue(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            setNewValue(json_value);
          }


        public TypeAddEventFieldsJSON()
          {
            flagHasFieldName = false;
            flagHasNewValue = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasFieldName()
          {
            return flagHasFieldName;
          }

        public string  getFieldName()
          {
            Debug.Assert(flagHasFieldName);
            return storeFieldName;
          }

        public bool  hasNewValue()
          {
            return flagHasNewValue;
          }

        public JSONValue   getNewValue()
          {
            Debug.Assert(flagHasNewValue);
            return storeNewValue;
          }


        public virtual int extraTypeAddEventFieldsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeAddEventFieldsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeAddEventFieldsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeAddEventFieldsLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setFieldName(string new_value)
          {
            flagHasFieldName = true;
            storeFieldName = new_value;
          }
        public void unsetFieldName()
          {
            flagHasFieldName = false;
          }
        public void setNewValue(JSONValue  new_value)
          {
            if (flagHasNewValue)
              {
              }
            flagHasNewValue = true;
            storeNewValue = new_value;
          }
        public void unsetNewValue()
          {
            if (flagHasNewValue)
              {
              }
            flagHasNewValue = false;
          }

        public virtual void extraTypeAddEventFieldsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeAddEventFieldsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeAddEventFieldsLookup(key);
            if (old_field == null)
              {
                extraTypeAddEventFieldsAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasFieldName);
            if (flagHasFieldName)
              {
                handler.start_pair("FieldName");
                handler.string_value(storeFieldName);
              }
            Debug.Assert(partial_allowed || flagHasNewValue);
            if (flagHasNewValue)
              {
                handler.start_pair("NewValue");
                storeNewValue.write(handler);
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
            if (!(hasFieldName()))
              {
                return "When parsing the object for %what%, the \"FieldName\" field was missing.";
              }
            if (!(hasNewValue()))
              {
                return "When parsing the object for %what%, the \"NewValue\" field was missing.";
              }
            return null;
          }

        public static TypeAddEventFieldsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeAddEventFieldsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAddEventFields", ignore_extras);
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
        public static TypeAddEventFieldsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeAddEventFieldsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeAddEventFieldsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAddEventFields", ignore_extras);
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
        public static TypeAddEventFieldsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeAddEventFieldsJSON from_text(string text, bool ignore_extras)
          {
            TypeAddEventFieldsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAddEventFields", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeAddEventFieldsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeAddEventFieldsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeAddEventFieldsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAddEventFields", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorFieldName;
            private JSONHoldingValueGenerator fieldGeneratorNewValue;
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
                TypeAddEventFieldsJSON result = new TypeAddEventFieldsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeAddEventFieldsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeAddEventFieldsJSON result)
              {
                if (fieldGeneratorFieldName.have_value)
                  {
                    result.setFieldName(fieldGeneratorFieldName.value);
                    fieldGeneratorFieldName.have_value = false;
                  }
                else if ((!(result.hasFieldName())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"FieldName\" field was missing.");
                  }
                if (fieldGeneratorNewValue.have_value)
                  {
                    result.setNewValue(fieldGeneratorNewValue.value);
                    fieldGeneratorNewValue.have_value = false;
                  }
                else if ((!(result.hasNewValue())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"NewValue\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeAddEventFieldsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'F':
                        if ((String.Compare(field_name, 1, "ieldName", 0, 8, false) == 0) && (field_name.Length == 9))
                            return fieldGeneratorFieldName;
                        break;
                    case 'N':
                        if ((String.Compare(field_name, 1, "ewValue", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorNewValue;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorFieldName = new JSONHoldingStringGenerator("field \"FieldName\" of the TypeAddEventFields class");
                fieldGeneratorNewValue = new JSONHoldingValueGenerator("field \"NewValue\" of the TypeAddEventFields class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeAddEventFields class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorFieldName = new JSONHoldingStringGenerator("field \"FieldName\" of the TypeAddEventFields class");
                fieldGeneratorNewValue = new JSONHoldingValueGenerator("field \"NewValue\" of the TypeAddEventFields class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeAddEventFields class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorFieldName.reset();
                fieldGeneratorNewValue.reset();
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
            protected override void handle_result(TypeAddEventFieldsJSON  result)
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
            public TypeAddEventFieldsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeAddEventFieldsJSON  result)
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
        protected virtual void handle_result(List<TypeAddEventFieldsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeAddEventFieldsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeAddEventFieldsJSON>();
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
        public List<TypeAddEventFieldsJSON> value;
      };
      };
    public class TypeNativeDataJSON : JSONBase
      {
        public enum TypeNewFrequencyType
          {
            NewFrequencyType_unknown,
            NewFrequencyType_one_time,
            NewFrequencyType_daily,
            NewFrequencyType_weekly,
            NewFrequencyType_monthly,
            NewFrequencyType_yearly
          };

        public static TypeNewFrequencyType  stringToNewFrequencyType(string chars)
          {
            switch (chars[0])
              {
                case 'd':
                    if ((String.Compare(chars, 1, "aily", 0, 4, false) == 0) && (chars.Length == 5))
                        return TypeNewFrequencyType.NewFrequencyType_daily;
                    break;
                case 'm':
                    if ((String.Compare(chars, 1, "onthly", 0, 6, false) == 0) && (chars.Length == 7))
                        return TypeNewFrequencyType.NewFrequencyType_monthly;
                    break;
                case 'o':
                    if ((String.Compare(chars, 1, "ne-time", 0, 7, false) == 0) && (chars.Length == 8))
                        return TypeNewFrequencyType.NewFrequencyType_one_time;
                    break;
                case 'u':
                    if ((String.Compare(chars, 1, "nknown", 0, 6, false) == 0) && (chars.Length == 7))
                        return TypeNewFrequencyType.NewFrequencyType_unknown;
                    break;
                case 'w':
                    if ((String.Compare(chars, 1, "eekly", 0, 5, false) == 0) && (chars.Length == 6))
                        return TypeNewFrequencyType.NewFrequencyType_weekly;
                    break;
                case 'y':
                    if ((String.Compare(chars, 1, "early", 0, 5, false) == 0) && (chars.Length == 6))
                        return TypeNewFrequencyType.NewFrequencyType_yearly;
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field `NewFrequencyType' is not one of the legal values.");
          }

        public static string  stringFromNewFrequencyType(TypeNewFrequencyType the_enum)
          {
            switch (the_enum)
              {
                case TypeNewFrequencyType.NewFrequencyType_unknown:
                    return "unknown";
                case TypeNewFrequencyType.NewFrequencyType_one_time:
                    return "one-time";
                case TypeNewFrequencyType.NewFrequencyType_daily:
                    return "daily";
                case TypeNewFrequencyType.NewFrequencyType_weekly:
                    return "weekly";
                case TypeNewFrequencyType.NewFrequencyType_monthly:
                    return "monthly";
                case TypeNewFrequencyType.NewFrequencyType_yearly:
                    return "yearly";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        public class TypeSetEventFieldsJSON : JSONBase
          {
            private bool flagHasFieldName;
            private string storeFieldName;
            private bool flagHasNewValue;
            private JSONValue  storeNewValue;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONFieldName(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field FieldName of TypeSetEventFieldsJSON is not a string.");
                setFieldName(json_string.getData());
              }


            private void  fromJSONNewValue(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                setNewValue(json_value);
              }


            public TypeSetEventFieldsJSON()
              {
                flagHasFieldName = false;
                flagHasNewValue = false;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasFieldName()
              {
                return flagHasFieldName;
              }

            public string  getFieldName()
              {
                Debug.Assert(flagHasFieldName);
                return storeFieldName;
              }

            public bool  hasNewValue()
              {
                return flagHasNewValue;
              }

            public JSONValue   getNewValue()
              {
                Debug.Assert(flagHasNewValue);
                return storeNewValue;
              }


            public virtual int extraTypeSetEventFieldsComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypeSetEventFieldsComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypeSetEventFieldsComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypeSetEventFieldsLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setFieldName(string new_value)
              {
                flagHasFieldName = true;
                storeFieldName = new_value;
              }
            public void unsetFieldName()
              {
                flagHasFieldName = false;
              }
            public void setNewValue(JSONValue  new_value)
              {
                if (flagHasNewValue)
                  {
                  }
                flagHasNewValue = true;
                storeNewValue = new_value;
              }
            public void unsetNewValue()
              {
                if (flagHasNewValue)
                  {
                  }
                flagHasNewValue = false;
              }

            public virtual void extraTypeSetEventFieldsAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypeSetEventFieldsSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypeSetEventFieldsLookup(key);
                if (old_field == null)
                  {
                    extraTypeSetEventFieldsAppendPair(key, new_component);
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
                Debug.Assert(partial_allowed || flagHasFieldName);
                if (flagHasFieldName)
                  {
                    handler.start_pair("FieldName");
                    handler.string_value(storeFieldName);
                  }
                Debug.Assert(partial_allowed || flagHasNewValue);
                if (flagHasNewValue)
                  {
                    handler.start_pair("NewValue");
                    storeNewValue.write(handler);
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
                if (!(hasFieldName()))
                  {
                    return "When parsing the object for %what%, the \"FieldName\" field was missing.";
                  }
                if (!(hasNewValue()))
                  {
                    return "When parsing the object for %what%, the \"NewValue\" field was missing.";
                  }
                return null;
              }

            public static TypeSetEventFieldsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeSetEventFieldsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeSetEventFields", ignore_extras);
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
            public static TypeSetEventFieldsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeSetEventFieldsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeSetEventFieldsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeSetEventFields", ignore_extras);
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
            public static TypeSetEventFieldsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeSetEventFieldsJSON from_text(string text, bool ignore_extras)
              {
                TypeSetEventFieldsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeSetEventFields", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeSetEventFieldsJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeSetEventFieldsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeSetEventFieldsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeSetEventFields", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private JSONHoldingStringGenerator fieldGeneratorFieldName;
                private JSONHoldingValueGenerator fieldGeneratorNewValue;
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
                    TypeSetEventFieldsJSON result = new TypeSetEventFieldsJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypeSetEventFieldsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypeSetEventFieldsJSON result)
                  {
                    if (fieldGeneratorFieldName.have_value)
                      {
                        result.setFieldName(fieldGeneratorFieldName.value);
                        fieldGeneratorFieldName.have_value = false;
                      }
                    else if ((!(result.hasFieldName())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"FieldName\" field was missing.");
                      }
                    if (fieldGeneratorNewValue.have_value)
                      {
                        result.setNewValue(fieldGeneratorNewValue.value);
                        fieldGeneratorNewValue.have_value = false;
                      }
                    else if ((!(result.hasNewValue())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"NewValue\" field was missing.");
                      }
                  }
                protected abstract void handle_result(TypeSetEventFieldsJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    switch (field_name[0])
                      {
                        case 'F':
                            if ((String.Compare(field_name, 1, "ieldName", 0, 8, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorFieldName;
                            break;
                        case 'N':
                            if ((String.Compare(field_name, 1, "ewValue", 0, 7, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorNewValue;
                            break;
                        default:
                            break;
                      }
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorFieldName = new JSONHoldingStringGenerator("field \"FieldName\" of the TypeSetEventFields class");
                    fieldGeneratorNewValue = new JSONHoldingValueGenerator("field \"NewValue\" of the TypeSetEventFields class");
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypeSetEventFields class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorFieldName = new JSONHoldingStringGenerator("field \"FieldName\" of the TypeSetEventFields class");
                    fieldGeneratorNewValue = new JSONHoldingValueGenerator("field \"NewValue\" of the TypeSetEventFields class");
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypeSetEventFields class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorFieldName.reset();
                    fieldGeneratorNewValue.reset();
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
                protected override void handle_result(TypeSetEventFieldsJSON  result)
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
                public TypeSetEventFieldsJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeSetEventFieldsJSON  result)
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
            protected virtual void handle_result(List<TypeSetEventFieldsJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeSetEventFieldsJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeSetEventFieldsJSON>();
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
            public List<TypeSetEventFieldsJSON> value;
          };
          };
        public class TypeAppendEventFieldsJSON : JSONBase
          {
            private bool flagHasFieldName;
            private string storeFieldName;
            private bool flagHasNewValues;
            private List< JSONValue  > storeNewValues;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONFieldName(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field FieldName of TypeAppendEventFieldsJSON is not a string.");
                setFieldName(json_string.getData());
              }


            private void  fromJSONNewValues(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONArrayValue json_array1 = json_value.array_value();
                if (json_array1 == null)
                    throw new Exception("The value for field NewValues of TypeAppendEventFieldsJSON is not an array.");
                int count1 = json_array1.componentCount();
                if (count1 < 1)
                    throw new Exception("The value for field NewValues of TypeAppendEventFieldsJSON has too few elements.");
                List< JSONValue  > vector_NewValues1 = new List< JSONValue  >(count1);
                for (int num1 = 0; num1 < count1; ++num1)
                  {
                    vector_NewValues1.Add(json_array1.component(num1));
                  }
                Debug.Assert(vector_NewValues1.Count >= 1);
                initNewValues();
                for (int num2 = 0; num2 < vector_NewValues1.Count; ++num2)
                    appendNewValues(vector_NewValues1[num2]);
                for (int num1 = 0; num1 < vector_NewValues1.Count; ++num1)
                  {
                  }
              }


            public TypeAppendEventFieldsJSON()
              {
                flagHasFieldName = false;
                flagHasNewValues = false;
                storeNewValues = new List< JSONValue  >();
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasFieldName()
              {
                return flagHasFieldName;
              }

            public string  getFieldName()
              {
                Debug.Assert(flagHasFieldName);
                return storeFieldName;
              }

            public bool  hasNewValues()
              {
                return flagHasNewValues;
              }

            public int  countOfNewValues()
              {
                Debug.Assert(flagHasNewValues);
                return storeNewValues.Count;
              }

            public JSONValue   elementOfNewValues(int element_num)
              {
                Debug.Assert(flagHasNewValues);
                return storeNewValues[element_num];
              }

            public List< JSONValue  >  getNewValues()
              {
                Debug.Assert(flagHasNewValues);
                return storeNewValues;
              }


            public virtual int extraTypeAppendEventFieldsComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypeAppendEventFieldsComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypeAppendEventFieldsComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypeAppendEventFieldsLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setFieldName(string new_value)
              {
                flagHasFieldName = true;
                storeFieldName = new_value;
              }
            public void unsetFieldName()
              {
                flagHasFieldName = false;
              }
            public void initNewValues()
              {
                if (flagHasNewValues)
                  {
                    for (int num3 = 0; num3 < storeNewValues.Count; ++num3)
                      {
                      }
                  }
                flagHasNewValues = true;
                storeNewValues.Clear();
              }
            public void appendNewValues(JSONValue  to_append)
              {
                if (!flagHasNewValues)
                  {
                    flagHasNewValues = true;
                    storeNewValues.Clear();
                  }
                Debug.Assert(flagHasNewValues);
                storeNewValues.Add(to_append);
              }
            public void unsetNewValues()
              {
                if (flagHasNewValues)
                  {
                    for (int num4 = 0; num4 < storeNewValues.Count; ++num4)
                      {
                      }
                  }
                flagHasNewValues = false;
                storeNewValues.Clear();
              }

            public virtual void extraTypeAppendEventFieldsAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypeAppendEventFieldsSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypeAppendEventFieldsLookup(key);
                if (old_field == null)
                  {
                    extraTypeAppendEventFieldsAppendPair(key, new_component);
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
                Debug.Assert(partial_allowed || flagHasFieldName);
                if (flagHasFieldName)
                  {
                    handler.start_pair("FieldName");
                    handler.string_value(storeFieldName);
                  }
                Debug.Assert(partial_allowed || flagHasNewValues);
                if (flagHasNewValues)
                  {
                    handler.start_pair("NewValues");
                    Debug.Assert(storeNewValues.Count >= 1);
                    handler.start_array();
                    for (int num1 = 0; num1 < storeNewValues.Count; ++num1)
                      {
                        storeNewValues[num1].write(handler);
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
                if (!(hasFieldName()))
                  {
                    return "When parsing the object for %what%, the \"FieldName\" field was missing.";
                  }
                if (!(hasNewValues()))
                  {
                    return "When parsing the object for %what%, the \"NewValues\" field was missing.";
                  }
                return null;
              }

            public static TypeAppendEventFieldsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeAppendEventFieldsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAppendEventFields", ignore_extras);
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
            public static TypeAppendEventFieldsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeAppendEventFieldsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeAppendEventFieldsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAppendEventFields", ignore_extras);
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
            public static TypeAppendEventFieldsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeAppendEventFieldsJSON from_text(string text, bool ignore_extras)
              {
                TypeAppendEventFieldsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAppendEventFields", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeAppendEventFieldsJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeAppendEventFieldsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeAppendEventFieldsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAppendEventFields", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private JSONHoldingStringGenerator fieldGeneratorFieldName;
                private JSONHoldingValueArrayGenerator fieldGeneratorNewValues;
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
                    TypeAppendEventFieldsJSON result = new TypeAppendEventFieldsJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypeAppendEventFieldsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypeAppendEventFieldsJSON result)
                  {
                    if (fieldGeneratorFieldName.have_value)
                      {
                        result.setFieldName(fieldGeneratorFieldName.value);
                        fieldGeneratorFieldName.have_value = false;
                      }
                    else if ((!(result.hasFieldName())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"FieldName\" field was missing.");
                      }
                    if (fieldGeneratorNewValues.have_value)
                      {
                        result.initNewValues();
                        int count = fieldGeneratorNewValues.value.Count;
                        for (int num = 0; num < count; ++num)
                          {
                            result.appendNewValues(fieldGeneratorNewValues.value[num]);
                          }
                        fieldGeneratorNewValues.value.Clear();
                        fieldGeneratorNewValues.have_value = false;
                      }
                    else if ((!(result.hasNewValues())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"NewValues\" field was missing.");
                      }
                  }
                protected abstract void handle_result(TypeAppendEventFieldsJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    switch (field_name[0])
                      {
                        case 'F':
                            if ((String.Compare(field_name, 1, "ieldName", 0, 8, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorFieldName;
                            break;
                        case 'N':
                            if ((String.Compare(field_name, 1, "ewValues", 0, 8, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorNewValues;
                            break;
                        default:
                            break;
                      }
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorFieldName = new JSONHoldingStringGenerator("field \"FieldName\" of the TypeAppendEventFields class");
                    fieldGeneratorNewValues = new JSONHoldingValueArrayGenerator("field \"NewValues\" of the TypeAppendEventFields class");
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypeAppendEventFields class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorFieldName = new JSONHoldingStringGenerator("field \"FieldName\" of the TypeAppendEventFields class");
                    fieldGeneratorNewValues = new JSONHoldingValueArrayGenerator("field \"NewValues\" of the TypeAppendEventFields class");
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypeAppendEventFields class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorFieldName.reset();
                    fieldGeneratorNewValues.reset();
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
                protected override void handle_result(TypeAppendEventFieldsJSON  result)
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
                public TypeAppendEventFieldsJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeAppendEventFieldsJSON  result)
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
            protected virtual void handle_result(List<TypeAppendEventFieldsJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeAppendEventFieldsJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeAppendEventFieldsJSON>();
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
            public List<TypeAppendEventFieldsJSON> value;
          };
          };
        public class TypeAddEventFieldsJSON : JSONBase
          {
            private bool flagHasFieldName;
            private string storeFieldName;
            private bool flagHasNewValue;
            private JSONValue  storeNewValue;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONFieldName(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field FieldName of TypeAddEventFieldsJSON is not a string.");
                setFieldName(json_string.getData());
              }


            private void  fromJSONNewValue(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                setNewValue(json_value);
              }


            public TypeAddEventFieldsJSON()
              {
                flagHasFieldName = false;
                flagHasNewValue = false;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasFieldName()
              {
                return flagHasFieldName;
              }

            public string  getFieldName()
              {
                Debug.Assert(flagHasFieldName);
                return storeFieldName;
              }

            public bool  hasNewValue()
              {
                return flagHasNewValue;
              }

            public JSONValue   getNewValue()
              {
                Debug.Assert(flagHasNewValue);
                return storeNewValue;
              }


            public virtual int extraTypeAddEventFieldsComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypeAddEventFieldsComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypeAddEventFieldsComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypeAddEventFieldsLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setFieldName(string new_value)
              {
                flagHasFieldName = true;
                storeFieldName = new_value;
              }
            public void unsetFieldName()
              {
                flagHasFieldName = false;
              }
            public void setNewValue(JSONValue  new_value)
              {
                if (flagHasNewValue)
                  {
                  }
                flagHasNewValue = true;
                storeNewValue = new_value;
              }
            public void unsetNewValue()
              {
                if (flagHasNewValue)
                  {
                  }
                flagHasNewValue = false;
              }

            public virtual void extraTypeAddEventFieldsAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypeAddEventFieldsSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypeAddEventFieldsLookup(key);
                if (old_field == null)
                  {
                    extraTypeAddEventFieldsAppendPair(key, new_component);
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
                Debug.Assert(partial_allowed || flagHasFieldName);
                if (flagHasFieldName)
                  {
                    handler.start_pair("FieldName");
                    handler.string_value(storeFieldName);
                  }
                Debug.Assert(partial_allowed || flagHasNewValue);
                if (flagHasNewValue)
                  {
                    handler.start_pair("NewValue");
                    storeNewValue.write(handler);
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
                if (!(hasFieldName()))
                  {
                    return "When parsing the object for %what%, the \"FieldName\" field was missing.";
                  }
                if (!(hasNewValue()))
                  {
                    return "When parsing the object for %what%, the \"NewValue\" field was missing.";
                  }
                return null;
              }

            public static TypeAddEventFieldsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeAddEventFieldsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAddEventFields", ignore_extras);
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
            public static TypeAddEventFieldsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeAddEventFieldsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeAddEventFieldsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAddEventFields", ignore_extras);
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
            public static TypeAddEventFieldsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeAddEventFieldsJSON from_text(string text, bool ignore_extras)
              {
                TypeAddEventFieldsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAddEventFields", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeAddEventFieldsJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeAddEventFieldsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeAddEventFieldsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeAddEventFields", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private JSONHoldingStringGenerator fieldGeneratorFieldName;
                private JSONHoldingValueGenerator fieldGeneratorNewValue;
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
                    TypeAddEventFieldsJSON result = new TypeAddEventFieldsJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypeAddEventFieldsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypeAddEventFieldsJSON result)
                  {
                    if (fieldGeneratorFieldName.have_value)
                      {
                        result.setFieldName(fieldGeneratorFieldName.value);
                        fieldGeneratorFieldName.have_value = false;
                      }
                    else if ((!(result.hasFieldName())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"FieldName\" field was missing.");
                      }
                    if (fieldGeneratorNewValue.have_value)
                      {
                        result.setNewValue(fieldGeneratorNewValue.value);
                        fieldGeneratorNewValue.have_value = false;
                      }
                    else if ((!(result.hasNewValue())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"NewValue\" field was missing.");
                      }
                  }
                protected abstract void handle_result(TypeAddEventFieldsJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    switch (field_name[0])
                      {
                        case 'F':
                            if ((String.Compare(field_name, 1, "ieldName", 0, 8, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorFieldName;
                            break;
                        case 'N':
                            if ((String.Compare(field_name, 1, "ewValue", 0, 7, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorNewValue;
                            break;
                        default:
                            break;
                      }
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorFieldName = new JSONHoldingStringGenerator("field \"FieldName\" of the TypeAddEventFields class");
                    fieldGeneratorNewValue = new JSONHoldingValueGenerator("field \"NewValue\" of the TypeAddEventFields class");
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypeAddEventFields class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorFieldName = new JSONHoldingStringGenerator("field \"FieldName\" of the TypeAddEventFields class");
                    fieldGeneratorNewValue = new JSONHoldingValueGenerator("field \"NewValue\" of the TypeAddEventFields class");
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypeAddEventFields class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorFieldName.reset();
                    fieldGeneratorNewValue.reset();
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
                protected override void handle_result(TypeAddEventFieldsJSON  result)
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
                public TypeAddEventFieldsJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeAddEventFieldsJSON  result)
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
            protected virtual void handle_result(List<TypeAddEventFieldsJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeAddEventFieldsJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeAddEventFieldsJSON>();
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
            public List<TypeAddEventFieldsJSON> value;
          };
          };
        private bool flagHasEventIDs;
        private List< string > storeEventIDs;
        private bool flagHasQuery;
        private CalendarQueryJSON  storeQuery;
        private bool flagHasNewItemType;
        private string storeNewItemType;
        private bool flagHasNewTitle;
        private string storeNewTitle;
        private bool flagHasNewLocation;
        private string storeNewLocation;
        private bool flagHasNewStart;
        private DateAndOrTimeJSON  storeNewStart;
        private bool flagHasStartDeltaSeconds;
        private double storeStartDeltaSeconds;
        private string textStoreStartDeltaSeconds;
        private bool flagHasStartDeltaDays;
        private BigInteger storeStartDeltaDays;
        private bool flagHasStartDeltaMonths;
        private BigInteger storeStartDeltaMonths;
        private bool flagHasNewEnd;
        private DateAndOrTimeJSON  storeNewEnd;
        private bool flagHasEndDeltaSeconds;
        private double storeEndDeltaSeconds;
        private string textStoreEndDeltaSeconds;
        private bool flagHasEndDeltaDays;
        private BigInteger storeEndDeltaDays;
        private bool flagHasEndDeltaMonths;
        private BigInteger storeEndDeltaMonths;
        private bool flagHasNewFrequencyType;
        private TypeNewFrequencyType storeNewFrequencyType;
        private bool flagHasNewFrequencyMultiplier;
        private BigInteger storeNewFrequencyMultiplier;
        private bool flagHasSetEventFields;
        private List< TypeSetEventFieldsJSON  > storeSetEventFields;
        private bool flagHasAppendEventFields;
        private List< TypeAppendEventFieldsJSON  > storeAppendEventFields;
        private bool flagHasRemoveEventFields;
        private List< string > storeRemoveEventFields;
        private bool flagHasAddEventFields;
        private List< TypeAddEventFieldsJSON  > storeAddEventFields;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONEventIDs(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field EventIDs of TypeNativeDataJSON is not an array.");
            int count1 = json_array1.componentCount();
            if (count1 < 1)
                throw new Exception("The value for field EventIDs of TypeNativeDataJSON has too few elements.");
            List< string > vector_EventIDs1 = new List< string >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                JSONStringValue json_string = json_array1.component(num1).string_value();
                if (json_string == null)
                    throw new Exception("The value for an element of field EventIDs of TypeNativeDataJSON is not a string.");
                vector_EventIDs1.Add(json_string.getData());
              }
            Debug.Assert(vector_EventIDs1.Count >= 1);
            initEventIDs();
            for (int num3 = 0; num3 < vector_EventIDs1.Count; ++num3)
                appendEventIDs(vector_EventIDs1[num3]);
            for (int num1 = 0; num1 < vector_EventIDs1.Count; ++num1)
              {
              }
          }


        private void  fromJSONQuery(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            CalendarQueryJSON convert_classy = CalendarQueryJSON.from_json(json_value, ignore_extras, true);
            setQuery(convert_classy);
          }


        private void  fromJSONNewItemType(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field NewItemType of TypeNativeDataJSON is not a string.");
            setNewItemType(json_string.getData());
          }


        private void  fromJSONNewTitle(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field NewTitle of TypeNativeDataJSON is not a string.");
            setNewTitle(json_string.getData());
          }


        private void  fromJSONNewLocation(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field NewLocation of TypeNativeDataJSON is not a string.");
            setNewLocation(json_string.getData());
          }


        private void  fromJSONNewStart(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
            setNewStart(convert_classy);
          }


        private void  fromJSONStartDeltaSeconds(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONRationalValue json_rational = json_value.rational_value();
            string the_rational_text;
            if (json_rational != null)
              {
                the_rational_text = json_rational.getText();
              }
            else
              {
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer != null)
                  {
                    the_rational_text = json_integer.getText();
                  }
                else
                  {
                    throw new Exception("The value for field StartDeltaSeconds of TypeNativeDataJSON is not a number.");
                  }
              }
            setStartDeltaSecondsText(the_rational_text);
          }


        private void  fromJSONStartDeltaDays(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field StartDeltaDays of TypeNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field StartDeltaDays of TypeNativeDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setStartDeltaDays(extracted_integer);
          }


        private void  fromJSONStartDeltaMonths(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field StartDeltaMonths of TypeNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field StartDeltaMonths of TypeNativeDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setStartDeltaMonths(extracted_integer);
          }


        private void  fromJSONNewEnd(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
            setNewEnd(convert_classy);
          }


        private void  fromJSONEndDeltaSeconds(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONRationalValue json_rational = json_value.rational_value();
            string the_rational_text;
            if (json_rational != null)
              {
                the_rational_text = json_rational.getText();
              }
            else
              {
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer != null)
                  {
                    the_rational_text = json_integer.getText();
                  }
                else
                  {
                    throw new Exception("The value for field EndDeltaSeconds of TypeNativeDataJSON is not a number.");
                  }
              }
            setEndDeltaSecondsText(the_rational_text);
          }


        private void  fromJSONEndDeltaDays(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field EndDeltaDays of TypeNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field EndDeltaDays of TypeNativeDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setEndDeltaDays(extracted_integer);
          }


        private void  fromJSONEndDeltaMonths(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field EndDeltaMonths of TypeNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field EndDeltaMonths of TypeNativeDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setEndDeltaMonths(extracted_integer);
          }


        private void  fromJSONNewFrequencyType(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field NewFrequencyType of TypeNativeDataJSON is not a string.");
            TypeNewFrequencyType the_enum;
            switch (json_string.getData()[0])
              {
                case 'd':
                    if ((String.Compare(json_string.getData(), 1, "aily", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                          {
                            the_enum = TypeNewFrequencyType.NewFrequencyType_daily;
                            goto enum_is_done;
                          }
                    break;
                case 'm':
                    if ((String.Compare(json_string.getData(), 1, "onthly", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                          {
                            the_enum = TypeNewFrequencyType.NewFrequencyType_monthly;
                            goto enum_is_done;
                          }
                    break;
                case 'o':
                    if ((String.Compare(json_string.getData(), 1, "ne-time", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                          {
                            the_enum = TypeNewFrequencyType.NewFrequencyType_one_time;
                            goto enum_is_done;
                          }
                    break;
                case 'u':
                    if ((String.Compare(json_string.getData(), 1, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                          {
                            the_enum = TypeNewFrequencyType.NewFrequencyType_unknown;
                            goto enum_is_done;
                          }
                    break;
                case 'w':
                    if ((String.Compare(json_string.getData(), 1, "eekly", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                          {
                            the_enum = TypeNewFrequencyType.NewFrequencyType_weekly;
                            goto enum_is_done;
                          }
                    break;
                case 'y':
                    if ((String.Compare(json_string.getData(), 1, "early", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                          {
                            the_enum = TypeNewFrequencyType.NewFrequencyType_yearly;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field NewFrequencyType of TypeNativeDataJSON is not one of the legal strings.");
          enum_is_done:;
            setNewFrequencyType(the_enum);
          }


        private void  fromJSONNewFrequencyMultiplier(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field NewFrequencyMultiplier of TypeNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field NewFrequencyMultiplier of TypeNativeDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setNewFrequencyMultiplier(extracted_integer);
          }


        private void  fromJSONSetEventFields(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field SetEventFields of TypeNativeDataJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< TypeSetEventFieldsJSON  > vector_SetEventFields1 = new List< TypeSetEventFieldsJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                TypeSetEventFieldsJSON convert_classy = TypeSetEventFieldsJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_SetEventFields1.Add(convert_classy);
              }
            initSetEventFields();
            for (int num4 = 0; num4 < vector_SetEventFields1.Count; ++num4)
                appendSetEventFields(vector_SetEventFields1[num4]);
            for (int num1 = 0; num1 < vector_SetEventFields1.Count; ++num1)
              {
              }
          }


        private void  fromJSONAppendEventFields(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field AppendEventFields of TypeNativeDataJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< TypeAppendEventFieldsJSON  > vector_AppendEventFields1 = new List< TypeAppendEventFieldsJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                TypeAppendEventFieldsJSON convert_classy = TypeAppendEventFieldsJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_AppendEventFields1.Add(convert_classy);
              }
            initAppendEventFields();
            for (int num5 = 0; num5 < vector_AppendEventFields1.Count; ++num5)
                appendAppendEventFields(vector_AppendEventFields1[num5]);
            for (int num1 = 0; num1 < vector_AppendEventFields1.Count; ++num1)
              {
              }
          }


        private void  fromJSONRemoveEventFields(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field RemoveEventFields of TypeNativeDataJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< string > vector_RemoveEventFields1 = new List< string >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                JSONStringValue json_string = json_array1.component(num1).string_value();
                if (json_string == null)
                    throw new Exception("The value for an element of field RemoveEventFields of TypeNativeDataJSON is not a string.");
                vector_RemoveEventFields1.Add(json_string.getData());
              }
            initRemoveEventFields();
            for (int num6 = 0; num6 < vector_RemoveEventFields1.Count; ++num6)
                appendRemoveEventFields(vector_RemoveEventFields1[num6]);
            for (int num1 = 0; num1 < vector_RemoveEventFields1.Count; ++num1)
              {
              }
          }


        private void  fromJSONAddEventFields(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field AddEventFields of TypeNativeDataJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< TypeAddEventFieldsJSON  > vector_AddEventFields1 = new List< TypeAddEventFieldsJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                TypeAddEventFieldsJSON convert_classy = TypeAddEventFieldsJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_AddEventFields1.Add(convert_classy);
              }
            initAddEventFields();
            for (int num7 = 0; num7 < vector_AddEventFields1.Count; ++num7)
                appendAddEventFields(vector_AddEventFields1[num7]);
            for (int num1 = 0; num1 < vector_AddEventFields1.Count; ++num1)
              {
              }
          }


        public TypeNativeDataJSON()
          {
            flagHasEventIDs = false;
            flagHasQuery = false;
            flagHasNewItemType = false;
            flagHasNewTitle = false;
            flagHasNewLocation = false;
            flagHasNewStart = false;
            flagHasStartDeltaSeconds = false;
            flagHasStartDeltaDays = false;
            flagHasStartDeltaMonths = false;
            flagHasNewEnd = false;
            flagHasEndDeltaSeconds = false;
            flagHasEndDeltaDays = false;
            flagHasEndDeltaMonths = false;
            flagHasNewFrequencyType = false;
            flagHasNewFrequencyMultiplier = false;
            flagHasSetEventFields = false;
            flagHasAppendEventFields = false;
            flagHasRemoveEventFields = false;
            flagHasAddEventFields = false;
            storeEventIDs = new List< string >();
            storeSetEventFields = new List< TypeSetEventFieldsJSON  >();
            storeAppendEventFields = new List< TypeAppendEventFieldsJSON  >();
            storeRemoveEventFields = new List< string >();
            storeAddEventFields = new List< TypeAddEventFieldsJSON  >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasEventIDs()
          {
            return flagHasEventIDs;
          }

        public int  countOfEventIDs()
          {
            Debug.Assert(flagHasEventIDs);
            return storeEventIDs.Count;
          }

        public string  elementOfEventIDs(int element_num)
          {
            Debug.Assert(flagHasEventIDs);
            return storeEventIDs[element_num];
          }

        public List< string >  getEventIDs()
          {
            Debug.Assert(flagHasEventIDs);
            return storeEventIDs;
          }

        public bool  hasQuery()
          {
            return flagHasQuery;
          }

        public CalendarQueryJSON   getQuery()
          {
            Debug.Assert(flagHasQuery);
            return storeQuery;
          }

        public bool  hasNewItemType()
          {
            return flagHasNewItemType;
          }

        public string  getNewItemType()
          {
            Debug.Assert(flagHasNewItemType);
            return storeNewItemType;
          }

        public bool  hasNewTitle()
          {
            return flagHasNewTitle;
          }

        public string  getNewTitle()
          {
            Debug.Assert(flagHasNewTitle);
            return storeNewTitle;
          }

        public bool  hasNewLocation()
          {
            return flagHasNewLocation;
          }

        public string  getNewLocation()
          {
            Debug.Assert(flagHasNewLocation);
            return storeNewLocation;
          }

        public bool  hasNewStart()
          {
            return flagHasNewStart;
          }

        public DateAndOrTimeJSON   getNewStart()
          {
            Debug.Assert(flagHasNewStart);
            return storeNewStart;
          }

        public bool  hasStartDeltaSeconds()
          {
            return flagHasStartDeltaSeconds;
          }

        public double  getStartDeltaSeconds()
          {
            Debug.Assert(flagHasStartDeltaSeconds);
            if (textStoreStartDeltaSeconds != "")
              {
                return Double.Parse(textStoreStartDeltaSeconds);
              }
            return storeStartDeltaSeconds;
          }

        public string  getStartDeltaSecondsAsText()
          {
            Debug.Assert(flagHasStartDeltaSeconds);
            if (textStoreStartDeltaSeconds == "")
              {
                return Convert.ToString(storeStartDeltaSeconds);
              }
            else
              {
                return (textStoreStartDeltaSeconds);
              }
          }

        public bool  hasStartDeltaDays()
          {
            return flagHasStartDeltaDays;
          }

        public BigInteger  getStartDeltaDays()
          {
            Debug.Assert(flagHasStartDeltaDays);
            return storeStartDeltaDays;
          }

        public bool  hasStartDeltaMonths()
          {
            return flagHasStartDeltaMonths;
          }

        public BigInteger  getStartDeltaMonths()
          {
            Debug.Assert(flagHasStartDeltaMonths);
            return storeStartDeltaMonths;
          }

        public bool  hasNewEnd()
          {
            return flagHasNewEnd;
          }

        public DateAndOrTimeJSON   getNewEnd()
          {
            Debug.Assert(flagHasNewEnd);
            return storeNewEnd;
          }

        public bool  hasEndDeltaSeconds()
          {
            return flagHasEndDeltaSeconds;
          }

        public double  getEndDeltaSeconds()
          {
            Debug.Assert(flagHasEndDeltaSeconds);
            if (textStoreEndDeltaSeconds != "")
              {
                return Double.Parse(textStoreEndDeltaSeconds);
              }
            return storeEndDeltaSeconds;
          }

        public string  getEndDeltaSecondsAsText()
          {
            Debug.Assert(flagHasEndDeltaSeconds);
            if (textStoreEndDeltaSeconds == "")
              {
                return Convert.ToString(storeEndDeltaSeconds);
              }
            else
              {
                return (textStoreEndDeltaSeconds);
              }
          }

        public bool  hasEndDeltaDays()
          {
            return flagHasEndDeltaDays;
          }

        public BigInteger  getEndDeltaDays()
          {
            Debug.Assert(flagHasEndDeltaDays);
            return storeEndDeltaDays;
          }

        public bool  hasEndDeltaMonths()
          {
            return flagHasEndDeltaMonths;
          }

        public BigInteger  getEndDeltaMonths()
          {
            Debug.Assert(flagHasEndDeltaMonths);
            return storeEndDeltaMonths;
          }

        public bool  hasNewFrequencyType()
          {
            return flagHasNewFrequencyType;
          }

        public TypeNewFrequencyType  getNewFrequencyType()
          {
            Debug.Assert(flagHasNewFrequencyType);
            return storeNewFrequencyType;
          }

        public string  getNewFrequencyTypeAsString()
          {
            return stringFromNewFrequencyType(getNewFrequencyType());
          }

        public bool  hasNewFrequencyMultiplier()
          {
            return flagHasNewFrequencyMultiplier;
          }

        public BigInteger  getNewFrequencyMultiplier()
          {
            Debug.Assert(flagHasNewFrequencyMultiplier);
            return storeNewFrequencyMultiplier;
          }

        public bool  hasSetEventFields()
          {
            return flagHasSetEventFields;
          }

        public int  countOfSetEventFields()
          {
            Debug.Assert(flagHasSetEventFields);
            return storeSetEventFields.Count;
          }

        public TypeSetEventFieldsJSON   elementOfSetEventFields(int element_num)
          {
            Debug.Assert(flagHasSetEventFields);
            return storeSetEventFields[element_num];
          }

        public List< TypeSetEventFieldsJSON  >  getSetEventFields()
          {
            Debug.Assert(flagHasSetEventFields);
            return storeSetEventFields;
          }

        public bool  hasAppendEventFields()
          {
            return flagHasAppendEventFields;
          }

        public int  countOfAppendEventFields()
          {
            Debug.Assert(flagHasAppendEventFields);
            return storeAppendEventFields.Count;
          }

        public TypeAppendEventFieldsJSON   elementOfAppendEventFields(int element_num)
          {
            Debug.Assert(flagHasAppendEventFields);
            return storeAppendEventFields[element_num];
          }

        public List< TypeAppendEventFieldsJSON  >  getAppendEventFields()
          {
            Debug.Assert(flagHasAppendEventFields);
            return storeAppendEventFields;
          }

        public bool  hasRemoveEventFields()
          {
            return flagHasRemoveEventFields;
          }

        public int  countOfRemoveEventFields()
          {
            Debug.Assert(flagHasRemoveEventFields);
            return storeRemoveEventFields.Count;
          }

        public string  elementOfRemoveEventFields(int element_num)
          {
            Debug.Assert(flagHasRemoveEventFields);
            return storeRemoveEventFields[element_num];
          }

        public List< string >  getRemoveEventFields()
          {
            Debug.Assert(flagHasRemoveEventFields);
            return storeRemoveEventFields;
          }

        public bool  hasAddEventFields()
          {
            return flagHasAddEventFields;
          }

        public int  countOfAddEventFields()
          {
            Debug.Assert(flagHasAddEventFields);
            return storeAddEventFields.Count;
          }

        public TypeAddEventFieldsJSON   elementOfAddEventFields(int element_num)
          {
            Debug.Assert(flagHasAddEventFields);
            return storeAddEventFields[element_num];
          }

        public List< TypeAddEventFieldsJSON  >  getAddEventFields()
          {
            Debug.Assert(flagHasAddEventFields);
            return storeAddEventFields;
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

        public void initEventIDs()
          {
            flagHasEventIDs = true;
            storeEventIDs.Clear();
          }
        public void appendEventIDs(string to_append)
          {
            if (!flagHasEventIDs)
              {
                flagHasEventIDs = true;
                storeEventIDs.Clear();
              }
            Debug.Assert(flagHasEventIDs);
            storeEventIDs.Add(to_append);
          }
        public void unsetEventIDs()
          {
            flagHasEventIDs = false;
            storeEventIDs.Clear();
          }
        public void setQuery(CalendarQueryJSON  new_value)
          {
            if (flagHasQuery)
              {
              }
            flagHasQuery = true;
            storeQuery = new_value;
          }
        public void unsetQuery()
          {
            if (flagHasQuery)
              {
              }
            flagHasQuery = false;
          }
        public void setNewItemType(string new_value)
          {
            flagHasNewItemType = true;
            storeNewItemType = new_value;
          }
        public void unsetNewItemType()
          {
            flagHasNewItemType = false;
          }
        public void setNewTitle(string new_value)
          {
            flagHasNewTitle = true;
            storeNewTitle = new_value;
          }
        public void unsetNewTitle()
          {
            flagHasNewTitle = false;
          }
        public void setNewLocation(string new_value)
          {
            flagHasNewLocation = true;
            storeNewLocation = new_value;
          }
        public void unsetNewLocation()
          {
            flagHasNewLocation = false;
          }
        public void setNewStart(DateAndOrTimeJSON  new_value)
          {
            if (flagHasNewStart)
              {
              }
            flagHasNewStart = true;
            storeNewStart = new_value;
          }
        public void unsetNewStart()
          {
            if (flagHasNewStart)
              {
              }
            flagHasNewStart = false;
          }
        public void setStartDeltaSeconds(double new_value)
          {
            flagHasStartDeltaSeconds = true;
            storeStartDeltaSeconds = new_value;
            textStoreStartDeltaSeconds = "";
          }
        public void setStartDeltaSecondsText(string new_value)
          {
            flagHasStartDeltaSeconds = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field StartDeltaSeconds of TypeNativeDataJSON is not a valid number.");
            textStoreStartDeltaSeconds = new_value;
          }
        public void unsetStartDeltaSeconds()
          {
            flagHasStartDeltaSeconds = false;
          }
        public void setStartDeltaDays(BigInteger new_value)
          {
            flagHasStartDeltaDays = true;
            if (new_value < 0)
                throw new Exception("The value for field StartDeltaDays of TypeNativeDataJSON is less than the lower bound (0) for that field.");
            storeStartDeltaDays = new_value;
          }
        public void unsetStartDeltaDays()
          {
            flagHasStartDeltaDays = false;
          }
        public void setStartDeltaMonths(BigInteger new_value)
          {
            flagHasStartDeltaMonths = true;
            if (new_value < 0)
                throw new Exception("The value for field StartDeltaMonths of TypeNativeDataJSON is less than the lower bound (0) for that field.");
            storeStartDeltaMonths = new_value;
          }
        public void unsetStartDeltaMonths()
          {
            flagHasStartDeltaMonths = false;
          }
        public void setNewEnd(DateAndOrTimeJSON  new_value)
          {
            if (flagHasNewEnd)
              {
              }
            flagHasNewEnd = true;
            storeNewEnd = new_value;
          }
        public void unsetNewEnd()
          {
            if (flagHasNewEnd)
              {
              }
            flagHasNewEnd = false;
          }
        public void setEndDeltaSeconds(double new_value)
          {
            flagHasEndDeltaSeconds = true;
            storeEndDeltaSeconds = new_value;
            textStoreEndDeltaSeconds = "";
          }
        public void setEndDeltaSecondsText(string new_value)
          {
            flagHasEndDeltaSeconds = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field EndDeltaSeconds of TypeNativeDataJSON is not a valid number.");
            textStoreEndDeltaSeconds = new_value;
          }
        public void unsetEndDeltaSeconds()
          {
            flagHasEndDeltaSeconds = false;
          }
        public void setEndDeltaDays(BigInteger new_value)
          {
            flagHasEndDeltaDays = true;
            if (new_value < 0)
                throw new Exception("The value for field EndDeltaDays of TypeNativeDataJSON is less than the lower bound (0) for that field.");
            storeEndDeltaDays = new_value;
          }
        public void unsetEndDeltaDays()
          {
            flagHasEndDeltaDays = false;
          }
        public void setEndDeltaMonths(BigInteger new_value)
          {
            flagHasEndDeltaMonths = true;
            if (new_value < 0)
                throw new Exception("The value for field EndDeltaMonths of TypeNativeDataJSON is less than the lower bound (0) for that field.");
            storeEndDeltaMonths = new_value;
          }
        public void unsetEndDeltaMonths()
          {
            flagHasEndDeltaMonths = false;
          }
        public void setNewFrequencyType(TypeNewFrequencyType new_value)
          {
            flagHasNewFrequencyType = true;
            storeNewFrequencyType = new_value;
          }
        public void setNewFrequencyType(string chars)
          {
            setNewFrequencyType(stringToNewFrequencyType(chars));
          }
        public void unsetNewFrequencyType()
          {
            flagHasNewFrequencyType = false;
          }
        public void setNewFrequencyMultiplier(BigInteger new_value)
          {
            flagHasNewFrequencyMultiplier = true;
            if (new_value < 0)
                throw new Exception("The value for field NewFrequencyMultiplier of TypeNativeDataJSON is less than the lower bound (0) for that field.");
            storeNewFrequencyMultiplier = new_value;
          }
        public void unsetNewFrequencyMultiplier()
          {
            flagHasNewFrequencyMultiplier = false;
          }
        public void initSetEventFields()
          {
            if (flagHasSetEventFields)
              {
                for (int num5 = 0; num5 < storeSetEventFields.Count; ++num5)
                  {
                  }
              }
            flagHasSetEventFields = true;
            storeSetEventFields.Clear();
          }
        public void appendSetEventFields(TypeSetEventFieldsJSON  to_append)
          {
            if (!flagHasSetEventFields)
              {
                flagHasSetEventFields = true;
                storeSetEventFields.Clear();
              }
            Debug.Assert(flagHasSetEventFields);
            storeSetEventFields.Add(to_append);
          }
        public void unsetSetEventFields()
          {
            if (flagHasSetEventFields)
              {
                for (int num6 = 0; num6 < storeSetEventFields.Count; ++num6)
                  {
                  }
              }
            flagHasSetEventFields = false;
            storeSetEventFields.Clear();
          }
        public void initAppendEventFields()
          {
            if (flagHasAppendEventFields)
              {
                for (int num7 = 0; num7 < storeAppendEventFields.Count; ++num7)
                  {
                  }
              }
            flagHasAppendEventFields = true;
            storeAppendEventFields.Clear();
          }
        public void appendAppendEventFields(TypeAppendEventFieldsJSON  to_append)
          {
            if (!flagHasAppendEventFields)
              {
                flagHasAppendEventFields = true;
                storeAppendEventFields.Clear();
              }
            Debug.Assert(flagHasAppendEventFields);
            storeAppendEventFields.Add(to_append);
          }
        public void unsetAppendEventFields()
          {
            if (flagHasAppendEventFields)
              {
                for (int num8 = 0; num8 < storeAppendEventFields.Count; ++num8)
                  {
                  }
              }
            flagHasAppendEventFields = false;
            storeAppendEventFields.Clear();
          }
        public void initRemoveEventFields()
          {
            flagHasRemoveEventFields = true;
            storeRemoveEventFields.Clear();
          }
        public void appendRemoveEventFields(string to_append)
          {
            if (!flagHasRemoveEventFields)
              {
                flagHasRemoveEventFields = true;
                storeRemoveEventFields.Clear();
              }
            Debug.Assert(flagHasRemoveEventFields);
            storeRemoveEventFields.Add(to_append);
          }
        public void unsetRemoveEventFields()
          {
            flagHasRemoveEventFields = false;
            storeRemoveEventFields.Clear();
          }
        public void initAddEventFields()
          {
            if (flagHasAddEventFields)
              {
                for (int num9 = 0; num9 < storeAddEventFields.Count; ++num9)
                  {
                  }
              }
            flagHasAddEventFields = true;
            storeAddEventFields.Clear();
          }
        public void appendAddEventFields(TypeAddEventFieldsJSON  to_append)
          {
            if (!flagHasAddEventFields)
              {
                flagHasAddEventFields = true;
                storeAddEventFields.Clear();
              }
            Debug.Assert(flagHasAddEventFields);
            storeAddEventFields.Add(to_append);
          }
        public void unsetAddEventFields()
          {
            if (flagHasAddEventFields)
              {
                for (int num10 = 0; num10 < storeAddEventFields.Count; ++num10)
                  {
                  }
              }
            flagHasAddEventFields = false;
            storeAddEventFields.Clear();
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
            if (flagHasEventIDs)
              {
                handler.start_pair("EventIDs");
                Debug.Assert(storeEventIDs.Count >= 1);
                handler.start_array();
                for (int num1 = 0; num1 < storeEventIDs.Count; ++num1)
                  {
                    handler.string_value(storeEventIDs[num1]);
                  }
                handler.finish_array();
              }
            if (flagHasQuery)
              {
                handler.start_pair("Query");
                if (partial_allowed)
                    storeQuery.write_partial_as_json(handler);
                else
                    storeQuery.write_as_json(handler);
              }
            Debug.Assert(partial_allowed || flagHasNewItemType);
            if (flagHasNewItemType)
              {
                handler.start_pair("NewItemType");
                handler.string_value(storeNewItemType);
              }
            Debug.Assert(partial_allowed || flagHasNewTitle);
            if (flagHasNewTitle)
              {
                handler.start_pair("NewTitle");
                handler.string_value(storeNewTitle);
              }
            Debug.Assert(partial_allowed || flagHasNewLocation);
            if (flagHasNewLocation)
              {
                handler.start_pair("NewLocation");
                handler.string_value(storeNewLocation);
              }
            Debug.Assert(partial_allowed || flagHasNewStart);
            if (flagHasNewStart)
              {
                handler.start_pair("NewStart");
                if (partial_allowed)
                    storeNewStart.write_partial_as_json(handler);
                else
                    storeNewStart.write_as_json(handler);
              }
            Debug.Assert(partial_allowed || flagHasStartDeltaSeconds);
            if (flagHasStartDeltaSeconds)
              {
                handler.start_pair("StartDeltaSeconds");
                if (textStoreStartDeltaSeconds != "")
                    handler.number_value(textStoreStartDeltaSeconds);
                else if (((double)(long)storeStartDeltaSeconds) == storeStartDeltaSeconds)
                    handler.number_value((long)storeStartDeltaSeconds);
                else
                    handler.number_value(storeStartDeltaSeconds);
              }
            Debug.Assert(partial_allowed || flagHasStartDeltaDays);
            if (flagHasStartDeltaDays)
              {
                handler.start_pair("StartDeltaDays");
                handler.number_value(storeStartDeltaDays);
              }
            Debug.Assert(partial_allowed || flagHasStartDeltaMonths);
            if (flagHasStartDeltaMonths)
              {
                handler.start_pair("StartDeltaMonths");
                handler.number_value(storeStartDeltaMonths);
              }
            Debug.Assert(partial_allowed || flagHasNewEnd);
            if (flagHasNewEnd)
              {
                handler.start_pair("NewEnd");
                if (partial_allowed)
                    storeNewEnd.write_partial_as_json(handler);
                else
                    storeNewEnd.write_as_json(handler);
              }
            Debug.Assert(partial_allowed || flagHasEndDeltaSeconds);
            if (flagHasEndDeltaSeconds)
              {
                handler.start_pair("EndDeltaSeconds");
                if (textStoreEndDeltaSeconds != "")
                    handler.number_value(textStoreEndDeltaSeconds);
                else if (((double)(long)storeEndDeltaSeconds) == storeEndDeltaSeconds)
                    handler.number_value((long)storeEndDeltaSeconds);
                else
                    handler.number_value(storeEndDeltaSeconds);
              }
            Debug.Assert(partial_allowed || flagHasEndDeltaDays);
            if (flagHasEndDeltaDays)
              {
                handler.start_pair("EndDeltaDays");
                handler.number_value(storeEndDeltaDays);
              }
            Debug.Assert(partial_allowed || flagHasEndDeltaMonths);
            if (flagHasEndDeltaMonths)
              {
                handler.start_pair("EndDeltaMonths");
                handler.number_value(storeEndDeltaMonths);
              }
            Debug.Assert(partial_allowed || flagHasNewFrequencyType);
            if (flagHasNewFrequencyType)
              {
                handler.start_pair("NewFrequencyType");
                switch (storeNewFrequencyType)
                  {
                    case TypeNewFrequencyType.NewFrequencyType_unknown:
                        handler.string_value("unknown");
                        break;
                    case TypeNewFrequencyType.NewFrequencyType_one_time:
                        handler.string_value("one-time");
                        break;
                    case TypeNewFrequencyType.NewFrequencyType_daily:
                        handler.string_value("daily");
                        break;
                    case TypeNewFrequencyType.NewFrequencyType_weekly:
                        handler.string_value("weekly");
                        break;
                    case TypeNewFrequencyType.NewFrequencyType_monthly:
                        handler.string_value("monthly");
                        break;
                    case TypeNewFrequencyType.NewFrequencyType_yearly:
                        handler.string_value("yearly");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            Debug.Assert(partial_allowed || flagHasNewFrequencyMultiplier);
            if (flagHasNewFrequencyMultiplier)
              {
                handler.start_pair("NewFrequencyMultiplier");
                handler.number_value(storeNewFrequencyMultiplier);
              }
            if (flagHasSetEventFields)
              {
                handler.start_pair("SetEventFields");
                handler.start_array();
                for (int num2 = 0; num2 < storeSetEventFields.Count; ++num2)
                  {
                    if (partial_allowed)
                        storeSetEventFields[num2].write_partial_as_json(handler);
                    else
                        storeSetEventFields[num2].write_as_json(handler);
                  }
                handler.finish_array();
              }
            if (flagHasAppendEventFields)
              {
                handler.start_pair("AppendEventFields");
                handler.start_array();
                for (int num3 = 0; num3 < storeAppendEventFields.Count; ++num3)
                  {
                    if (partial_allowed)
                        storeAppendEventFields[num3].write_partial_as_json(handler);
                    else
                        storeAppendEventFields[num3].write_as_json(handler);
                  }
                handler.finish_array();
              }
            if (flagHasRemoveEventFields)
              {
                handler.start_pair("RemoveEventFields");
                handler.start_array();
                for (int num4 = 0; num4 < storeRemoveEventFields.Count; ++num4)
                  {
                    handler.string_value(storeRemoveEventFields[num4]);
                  }
                handler.finish_array();
              }
            if (flagHasAddEventFields)
              {
                handler.start_pair("AddEventFields");
                handler.start_array();
                for (int num5 = 0; num5 < storeAddEventFields.Count; ++num5)
                  {
                    if (partial_allowed)
                        storeAddEventFields[num5].write_partial_as_json(handler);
                    else
                        storeAddEventFields[num5].write_as_json(handler);
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
            if (!(hasNewItemType()))
              {
                return "When parsing the object for %what%, the \"NewItemType\" field was missing.";
              }
            if (!(hasNewTitle()))
              {
                return "When parsing the object for %what%, the \"NewTitle\" field was missing.";
              }
            if (!(hasNewLocation()))
              {
                return "When parsing the object for %what%, the \"NewLocation\" field was missing.";
              }
            if (!(hasNewStart()))
              {
                return "When parsing the object for %what%, the \"NewStart\" field was missing.";
              }
            if (!(hasStartDeltaSeconds()))
              {
                return "When parsing the object for %what%, the \"StartDeltaSeconds\" field was missing.";
              }
            if (!(hasStartDeltaDays()))
              {
                return "When parsing the object for %what%, the \"StartDeltaDays\" field was missing.";
              }
            if (!(hasStartDeltaMonths()))
              {
                return "When parsing the object for %what%, the \"StartDeltaMonths\" field was missing.";
              }
            if (!(hasNewEnd()))
              {
                return "When parsing the object for %what%, the \"NewEnd\" field was missing.";
              }
            if (!(hasEndDeltaSeconds()))
              {
                return "When parsing the object for %what%, the \"EndDeltaSeconds\" field was missing.";
              }
            if (!(hasEndDeltaDays()))
              {
                return "When parsing the object for %what%, the \"EndDeltaDays\" field was missing.";
              }
            if (!(hasEndDeltaMonths()))
              {
                return "When parsing the object for %what%, the \"EndDeltaMonths\" field was missing.";
              }
            if (!(hasNewFrequencyType()))
              {
                return "When parsing the object for %what%, the \"NewFrequencyType\" field was missing.";
              }
            if (!(hasNewFrequencyMultiplier()))
              {
                return "When parsing the object for %what%, the \"NewFrequencyMultiplier\" field was missing.";
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
            private JSONHoldingStringArrayGenerator fieldGeneratorEventIDs;
            private CalendarQueryJSON.HoldingGenerator fieldGeneratorQuery;
            private JSONHoldingStringGenerator fieldGeneratorNewItemType;
            private JSONHoldingStringGenerator fieldGeneratorNewTitle;
            private JSONHoldingStringGenerator fieldGeneratorNewLocation;
            private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorNewStart;
            private JSONHoldingNumberTextGenerator fieldGeneratorStartDeltaSeconds;
        private class FieldHoldingGeneratorStartDeltaDays : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorStartDeltaDays(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorStartDeltaDays : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorStartDeltaDays(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorStartDeltaDays fieldGeneratorStartDeltaDays;
        private class FieldHoldingGeneratorStartDeltaMonths : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorStartDeltaMonths(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorStartDeltaMonths : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorStartDeltaMonths(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorStartDeltaMonths fieldGeneratorStartDeltaMonths;
            private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorNewEnd;
            private JSONHoldingNumberTextGenerator fieldGeneratorEndDeltaSeconds;
        private class FieldHoldingGeneratorEndDeltaDays : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorEndDeltaDays(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorEndDeltaDays : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorEndDeltaDays(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorEndDeltaDays fieldGeneratorEndDeltaDays;
        private class FieldHoldingGeneratorEndDeltaMonths : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorEndDeltaMonths(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorEndDeltaMonths : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorEndDeltaMonths(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorEndDeltaMonths fieldGeneratorEndDeltaMonths;
        private abstract class FieldGeneratorNewFrequencyType : JSONStringGenerator
              {
                protected FieldGeneratorNewFrequencyType(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorNewFrequencyType()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    handle_result(stringToNewFrequencyType(result));
                  }
                protected abstract void handle_result(TypeNewFrequencyType result);
              };
        private class FieldHoldingGeneratorNewFrequencyType : FieldGeneratorNewFrequencyType
      {
        protected override void handle_result(TypeNewFrequencyType result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorNewFrequencyType(String what)
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
        public TypeNewFrequencyType value;
      };
        private class FieldHoldingArrayGeneratorNewFrequencyType : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorNewFrequencyType
          {
            private FieldHoldingArrayGeneratorNewFrequencyType top;

            protected override void handle_result(TypeNewFrequencyType result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorNewFrequencyType init_top)
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
        protected virtual void handle_result(List<TypeNewFrequencyType> result)
          {
          }

        public FieldHoldingArrayGeneratorNewFrequencyType(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeNewFrequencyType>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorNewFrequencyType()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeNewFrequencyType>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeNewFrequencyType> value;
      };
            private FieldHoldingGeneratorNewFrequencyType fieldGeneratorNewFrequencyType;
        private class FieldHoldingGeneratorNewFrequencyMultiplier : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorNewFrequencyMultiplier(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorNewFrequencyMultiplier : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorNewFrequencyMultiplier(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorNewFrequencyMultiplier fieldGeneratorNewFrequencyMultiplier;
            private TypeSetEventFieldsJSON.HoldingArrayGenerator fieldGeneratorSetEventFields;
            private TypeAppendEventFieldsJSON.HoldingArrayGenerator fieldGeneratorAppendEventFields;
            private JSONHoldingStringArrayGenerator fieldGeneratorRemoveEventFields;
            private TypeAddEventFieldsJSON.HoldingArrayGenerator fieldGeneratorAddEventFields;
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
                if (fieldGeneratorEventIDs.have_value)
                  {
                    result.initEventIDs();
                    int count = fieldGeneratorEventIDs.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendEventIDs(fieldGeneratorEventIDs.value[num]);
                      }
                    fieldGeneratorEventIDs.value.Clear();
                    fieldGeneratorEventIDs.have_value = false;
                  }
                if (fieldGeneratorQuery.have_value)
                  {
                    result.setQuery(fieldGeneratorQuery.value);
                    fieldGeneratorQuery.have_value = false;
                  }
                if (fieldGeneratorNewItemType.have_value)
                  {
                    result.setNewItemType(fieldGeneratorNewItemType.value);
                    fieldGeneratorNewItemType.have_value = false;
                  }
                else if ((!(result.hasNewItemType())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"NewItemType\" field was missing.");
                  }
                if (fieldGeneratorNewTitle.have_value)
                  {
                    result.setNewTitle(fieldGeneratorNewTitle.value);
                    fieldGeneratorNewTitle.have_value = false;
                  }
                else if ((!(result.hasNewTitle())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"NewTitle\" field was missing.");
                  }
                if (fieldGeneratorNewLocation.have_value)
                  {
                    result.setNewLocation(fieldGeneratorNewLocation.value);
                    fieldGeneratorNewLocation.have_value = false;
                  }
                else if ((!(result.hasNewLocation())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"NewLocation\" field was missing.");
                  }
                if (fieldGeneratorNewStart.have_value)
                  {
                    result.setNewStart(fieldGeneratorNewStart.value);
                    fieldGeneratorNewStart.have_value = false;
                  }
                else if ((!(result.hasNewStart())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"NewStart\" field was missing.");
                  }
                if (fieldGeneratorStartDeltaSeconds.have_value)
                  {
                    result.setStartDeltaSecondsText(fieldGeneratorStartDeltaSeconds.value);
                    fieldGeneratorStartDeltaSeconds.have_value = false;
                  }
                else if ((!(result.hasStartDeltaSeconds())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"StartDeltaSeconds\" field was missing.");
                  }
                if (fieldGeneratorStartDeltaDays.have_value)
                  {
                    result.setStartDeltaDays(fieldGeneratorStartDeltaDays.value);
                    fieldGeneratorStartDeltaDays.have_value = false;
                  }
                else if ((!(result.hasStartDeltaDays())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"StartDeltaDays\" field was missing.");
                  }
                if (fieldGeneratorStartDeltaMonths.have_value)
                  {
                    result.setStartDeltaMonths(fieldGeneratorStartDeltaMonths.value);
                    fieldGeneratorStartDeltaMonths.have_value = false;
                  }
                else if ((!(result.hasStartDeltaMonths())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"StartDeltaMonths\" field was missing.");
                  }
                if (fieldGeneratorNewEnd.have_value)
                  {
                    result.setNewEnd(fieldGeneratorNewEnd.value);
                    fieldGeneratorNewEnd.have_value = false;
                  }
                else if ((!(result.hasNewEnd())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"NewEnd\" field was missing.");
                  }
                if (fieldGeneratorEndDeltaSeconds.have_value)
                  {
                    result.setEndDeltaSecondsText(fieldGeneratorEndDeltaSeconds.value);
                    fieldGeneratorEndDeltaSeconds.have_value = false;
                  }
                else if ((!(result.hasEndDeltaSeconds())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"EndDeltaSeconds\" field was missing.");
                  }
                if (fieldGeneratorEndDeltaDays.have_value)
                  {
                    result.setEndDeltaDays(fieldGeneratorEndDeltaDays.value);
                    fieldGeneratorEndDeltaDays.have_value = false;
                  }
                else if ((!(result.hasEndDeltaDays())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"EndDeltaDays\" field was missing.");
                  }
                if (fieldGeneratorEndDeltaMonths.have_value)
                  {
                    result.setEndDeltaMonths(fieldGeneratorEndDeltaMonths.value);
                    fieldGeneratorEndDeltaMonths.have_value = false;
                  }
                else if ((!(result.hasEndDeltaMonths())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"EndDeltaMonths\" field was missing.");
                  }
                if (fieldGeneratorNewFrequencyType.have_value)
                  {
                    result.setNewFrequencyType(fieldGeneratorNewFrequencyType.value);
                    fieldGeneratorNewFrequencyType.have_value = false;
                  }
                else if ((!(result.hasNewFrequencyType())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"NewFrequencyType\" field was missing.");
                  }
                if (fieldGeneratorNewFrequencyMultiplier.have_value)
                  {
                    result.setNewFrequencyMultiplier(fieldGeneratorNewFrequencyMultiplier.value);
                    fieldGeneratorNewFrequencyMultiplier.have_value = false;
                  }
                else if ((!(result.hasNewFrequencyMultiplier())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"NewFrequencyMultiplier\" field was missing.");
                  }
                if (fieldGeneratorSetEventFields.have_value)
                  {
                    result.initSetEventFields();
                    int count = fieldGeneratorSetEventFields.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendSetEventFields(fieldGeneratorSetEventFields.value[num]);
                      }
                    fieldGeneratorSetEventFields.value.Clear();
                    fieldGeneratorSetEventFields.have_value = false;
                  }
                if (fieldGeneratorAppendEventFields.have_value)
                  {
                    result.initAppendEventFields();
                    int count = fieldGeneratorAppendEventFields.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendAppendEventFields(fieldGeneratorAppendEventFields.value[num]);
                      }
                    fieldGeneratorAppendEventFields.value.Clear();
                    fieldGeneratorAppendEventFields.have_value = false;
                  }
                if (fieldGeneratorRemoveEventFields.have_value)
                  {
                    result.initRemoveEventFields();
                    int count = fieldGeneratorRemoveEventFields.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendRemoveEventFields(fieldGeneratorRemoveEventFields.value[num]);
                      }
                    fieldGeneratorRemoveEventFields.value.Clear();
                    fieldGeneratorRemoveEventFields.have_value = false;
                  }
                if (fieldGeneratorAddEventFields.have_value)
                  {
                    result.initAddEventFields();
                    int count = fieldGeneratorAddEventFields.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendAddEventFields(fieldGeneratorAddEventFields.value[num]);
                      }
                    fieldGeneratorAddEventFields.value.Clear();
                    fieldGeneratorAddEventFields.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeNativeDataJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'A':
                        switch (field_name[1])
                          {
                            case 'd':
                                if ((String.Compare(field_name, 2, "dEventFields", 0, 12, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorAddEventFields;
                                break;
                            case 'p':
                                if ((String.Compare(field_name, 2, "pendEventFields", 0, 15, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorAppendEventFields;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'E':
                        switch (field_name[1])
                          {
                            case 'n':
                                if (String.Compare(field_name, 2, "dDelta", 0, 6, false) == 0)
                                  {
                                    switch (field_name[8])
                                      {
                                        case 'D':
                                            if ((String.Compare(field_name, 9, "ays", 0, 3, false) == 0) && (field_name.Length == 12))
                                                return fieldGeneratorEndDeltaDays;
                                            break;
                                        case 'M':
                                            if ((String.Compare(field_name, 9, "onths", 0, 5, false) == 0) && (field_name.Length == 14))
                                                return fieldGeneratorEndDeltaMonths;
                                            break;
                                        case 'S':
                                            if ((String.Compare(field_name, 9, "econds", 0, 6, false) == 0) && (field_name.Length == 15))
                                                return fieldGeneratorEndDeltaSeconds;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'v':
                                if ((String.Compare(field_name, 2, "entIDs", 0, 6, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorEventIDs;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'N':
                        if (String.Compare(field_name, 1, "ew", 0, 2, false) == 0)
                          {
                            switch (field_name[3])
                              {
                                case 'E':
                                    if ((String.Compare(field_name, 4, "nd", 0, 2, false) == 0) && (field_name.Length == 6))
                                        return fieldGeneratorNewEnd;
                                    break;
                                case 'F':
                                    if (String.Compare(field_name, 4, "requency", 0, 8, false) == 0)
                                      {
                                        switch (field_name[12])
                                          {
                                            case 'M':
                                                if ((String.Compare(field_name, 13, "ultiplier", 0, 9, false) == 0) && (field_name.Length == 22))
                                                    return fieldGeneratorNewFrequencyMultiplier;
                                                break;
                                            case 'T':
                                                if ((String.Compare(field_name, 13, "ype", 0, 3, false) == 0) && (field_name.Length == 16))
                                                    return fieldGeneratorNewFrequencyType;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'I':
                                    if ((String.Compare(field_name, 4, "temType", 0, 7, false) == 0) && (field_name.Length == 11))
                                        return fieldGeneratorNewItemType;
                                    break;
                                case 'L':
                                    if ((String.Compare(field_name, 4, "ocation", 0, 7, false) == 0) && (field_name.Length == 11))
                                        return fieldGeneratorNewLocation;
                                    break;
                                case 'S':
                                    if ((String.Compare(field_name, 4, "tart", 0, 4, false) == 0) && (field_name.Length == 8))
                                        return fieldGeneratorNewStart;
                                    break;
                                case 'T':
                                    if ((String.Compare(field_name, 4, "itle", 0, 4, false) == 0) && (field_name.Length == 8))
                                        return fieldGeneratorNewTitle;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'Q':
                        if ((String.Compare(field_name, 1, "uery", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorQuery;
                        break;
                    case 'R':
                        if ((String.Compare(field_name, 1, "emoveEventFields", 0, 16, false) == 0) && (field_name.Length == 17))
                            return fieldGeneratorRemoveEventFields;
                        break;
                    case 'S':
                        switch (field_name[1])
                          {
                            case 'e':
                                if ((String.Compare(field_name, 2, "tEventFields", 0, 12, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorSetEventFields;
                                break;
                            case 't':
                                if (String.Compare(field_name, 2, "artDelta", 0, 8, false) == 0)
                                  {
                                    switch (field_name[10])
                                      {
                                        case 'D':
                                            if ((String.Compare(field_name, 11, "ays", 0, 3, false) == 0) && (field_name.Length == 14))
                                                return fieldGeneratorStartDeltaDays;
                                            break;
                                        case 'M':
                                            if ((String.Compare(field_name, 11, "onths", 0, 5, false) == 0) && (field_name.Length == 16))
                                                return fieldGeneratorStartDeltaMonths;
                                            break;
                                        case 'S':
                                            if ((String.Compare(field_name, 11, "econds", 0, 6, false) == 0) && (field_name.Length == 17))
                                                return fieldGeneratorStartDeltaSeconds;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
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
                fieldGeneratorEventIDs = new JSONHoldingStringArrayGenerator("field \"EventIDs\" of the TypeNativeData class");
                fieldGeneratorQuery = new CalendarQueryJSON.HoldingGenerator("field \"Query\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorNewItemType = new JSONHoldingStringGenerator("field \"NewItemType\" of the TypeNativeData class");
                fieldGeneratorNewTitle = new JSONHoldingStringGenerator("field \"NewTitle\" of the TypeNativeData class");
                fieldGeneratorNewLocation = new JSONHoldingStringGenerator("field \"NewLocation\" of the TypeNativeData class");
                fieldGeneratorNewStart = new DateAndOrTimeJSON.HoldingGenerator("field \"NewStart\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorStartDeltaSeconds = new JSONHoldingNumberTextGenerator("field \"StartDeltaSeconds\" of the TypeNativeData class");
                fieldGeneratorStartDeltaDays = new FieldHoldingGeneratorStartDeltaDays("field \"StartDeltaDays\" of the TypeNativeData class");
                fieldGeneratorStartDeltaMonths = new FieldHoldingGeneratorStartDeltaMonths("field \"StartDeltaMonths\" of the TypeNativeData class");
                fieldGeneratorNewEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"NewEnd\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorEndDeltaSeconds = new JSONHoldingNumberTextGenerator("field \"EndDeltaSeconds\" of the TypeNativeData class");
                fieldGeneratorEndDeltaDays = new FieldHoldingGeneratorEndDeltaDays("field \"EndDeltaDays\" of the TypeNativeData class");
                fieldGeneratorEndDeltaMonths = new FieldHoldingGeneratorEndDeltaMonths("field \"EndDeltaMonths\" of the TypeNativeData class");
                fieldGeneratorNewFrequencyType = new FieldHoldingGeneratorNewFrequencyType("field \"NewFrequencyType\" of the TypeNativeData class");
                fieldGeneratorNewFrequencyMultiplier = new FieldHoldingGeneratorNewFrequencyMultiplier("field \"NewFrequencyMultiplier\" of the TypeNativeData class");
                fieldGeneratorSetEventFields = new TypeSetEventFieldsJSON.HoldingArrayGenerator("field \"SetEventFields\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorAppendEventFields = new TypeAppendEventFieldsJSON.HoldingArrayGenerator("field \"AppendEventFields\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorRemoveEventFields = new JSONHoldingStringArrayGenerator("field \"RemoveEventFields\" of the TypeNativeData class");
                fieldGeneratorAddEventFields = new TypeAddEventFieldsJSON.HoldingArrayGenerator("field \"AddEventFields\" of the TypeNativeData class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorEventIDs = new JSONHoldingStringArrayGenerator("field \"EventIDs\" of the TypeNativeData class");
                fieldGeneratorQuery = new CalendarQueryJSON.HoldingGenerator("field \"Query\" of the TypeNativeData class", false);
                fieldGeneratorNewItemType = new JSONHoldingStringGenerator("field \"NewItemType\" of the TypeNativeData class");
                fieldGeneratorNewTitle = new JSONHoldingStringGenerator("field \"NewTitle\" of the TypeNativeData class");
                fieldGeneratorNewLocation = new JSONHoldingStringGenerator("field \"NewLocation\" of the TypeNativeData class");
                fieldGeneratorNewStart = new DateAndOrTimeJSON.HoldingGenerator("field \"NewStart\" of the TypeNativeData class", false);
                fieldGeneratorStartDeltaSeconds = new JSONHoldingNumberTextGenerator("field \"StartDeltaSeconds\" of the TypeNativeData class");
                fieldGeneratorStartDeltaDays = new FieldHoldingGeneratorStartDeltaDays("field \"StartDeltaDays\" of the TypeNativeData class");
                fieldGeneratorStartDeltaMonths = new FieldHoldingGeneratorStartDeltaMonths("field \"StartDeltaMonths\" of the TypeNativeData class");
                fieldGeneratorNewEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"NewEnd\" of the TypeNativeData class", false);
                fieldGeneratorEndDeltaSeconds = new JSONHoldingNumberTextGenerator("field \"EndDeltaSeconds\" of the TypeNativeData class");
                fieldGeneratorEndDeltaDays = new FieldHoldingGeneratorEndDeltaDays("field \"EndDeltaDays\" of the TypeNativeData class");
                fieldGeneratorEndDeltaMonths = new FieldHoldingGeneratorEndDeltaMonths("field \"EndDeltaMonths\" of the TypeNativeData class");
                fieldGeneratorNewFrequencyType = new FieldHoldingGeneratorNewFrequencyType("field \"NewFrequencyType\" of the TypeNativeData class");
                fieldGeneratorNewFrequencyMultiplier = new FieldHoldingGeneratorNewFrequencyMultiplier("field \"NewFrequencyMultiplier\" of the TypeNativeData class");
                fieldGeneratorSetEventFields = new TypeSetEventFieldsJSON.HoldingArrayGenerator("field \"SetEventFields\" of the TypeNativeData class", false);
                fieldGeneratorAppendEventFields = new TypeAppendEventFieldsJSON.HoldingArrayGenerator("field \"AppendEventFields\" of the TypeNativeData class", false);
                fieldGeneratorRemoveEventFields = new JSONHoldingStringArrayGenerator("field \"RemoveEventFields\" of the TypeNativeData class");
                fieldGeneratorAddEventFields = new TypeAddEventFieldsJSON.HoldingArrayGenerator("field \"AddEventFields\" of the TypeNativeData class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorEventIDs.reset();
                fieldGeneratorQuery.reset();
                fieldGeneratorNewItemType.reset();
                fieldGeneratorNewTitle.reset();
                fieldGeneratorNewLocation.reset();
                fieldGeneratorNewStart.reset();
                fieldGeneratorStartDeltaSeconds.reset();
                fieldGeneratorStartDeltaDays.reset();
                fieldGeneratorStartDeltaMonths.reset();
                fieldGeneratorNewEnd.reset();
                fieldGeneratorEndDeltaSeconds.reset();
                fieldGeneratorEndDeltaDays.reset();
                fieldGeneratorEndDeltaMonths.reset();
                fieldGeneratorNewFrequencyType.reset();
                fieldGeneratorNewFrequencyMultiplier.reset();
                fieldGeneratorSetEventFields.reset();
                fieldGeneratorAppendEventFields.reset();
                fieldGeneratorRemoveEventFields.reset();
                fieldGeneratorAddEventFields.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorQuery.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorNewStart.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorNewEnd.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorQuery.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorNewStart.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorNewEnd.set_allow_unpolished(new_allow_unpolished);
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
    private bool flagHasEventIDs;
    private List< string > storeEventIDs;
    private bool flagHasQuery;
    private CalendarQueryJSON  storeQuery;
    private bool flagHasNewItemType;
    private string storeNewItemType;
    private bool flagHasNewTitle;
    private string storeNewTitle;
    private bool flagHasNewLocation;
    private string storeNewLocation;
    private bool flagHasNewStart;
    private DateAndOrTimeJSON  storeNewStart;
    private bool flagHasStartDeltaSeconds;
    private double storeStartDeltaSeconds;
    private string textStoreStartDeltaSeconds;
    private bool flagHasStartDeltaDays;
    private BigInteger storeStartDeltaDays;
    private bool flagHasStartDeltaMonths;
    private BigInteger storeStartDeltaMonths;
    private bool flagHasNewEnd;
    private DateAndOrTimeJSON  storeNewEnd;
    private bool flagHasEndDeltaSeconds;
    private double storeEndDeltaSeconds;
    private string textStoreEndDeltaSeconds;
    private bool flagHasEndDeltaDays;
    private BigInteger storeEndDeltaDays;
    private bool flagHasEndDeltaMonths;
    private BigInteger storeEndDeltaMonths;
    private bool flagHasNewFrequencyType;
    private TypeNewFrequencyType storeNewFrequencyType;
    private bool flagHasNewFrequencyMultiplier;
    private BigInteger storeNewFrequencyMultiplier;
    private bool flagHasSetEventFields;
    private List< TypeSetEventFieldsJSON  > storeSetEventFields;
    private bool flagHasAppendEventFields;
    private List< TypeAppendEventFieldsJSON  > storeAppendEventFields;
    private bool flagHasRemoveEventFields;
    private List< string > storeRemoveEventFields;
    private bool flagHasAddEventFields;
    private List< TypeAddEventFieldsJSON  > storeAddEventFields;
    private bool flagHasNativeData;
    private TypeNativeDataJSON  storeNativeData;
    private bool flagHasEventsConflictResult;
    private DynamicResponseJSON  storeEventsConflictResult;
    private bool flagHasCalendarPreferenceIsNotSetResult;
    private DynamicResponseJSON  storeCalendarPreferenceIsNotSetResult;
    private bool flagHasNoMatchResult;
    private DynamicResponseJSON  storeNoMatchResult;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraEventIDsToJSON()
      {
        JSONArrayValue generated_array_1_EventIDs = new JSONArrayValue();
        for (int num1 = 0; num1 < storeEventIDs.Count; ++num1)
          {
            JSONStringValue generated_string_EventIDs = new JSONStringValue(storeEventIDs[num1]);
            generated_array_1_EventIDs.appendComponent(generated_string_EventIDs);
          }
        return generated_array_1_EventIDs;
      }

    private JSONValue  extraQueryToJSON()
      {
        JSONValueHandler handler_Query = new JSONValueHandler();
        storeQuery.write_as_json(handler_Query);
        return handler_Query.result;
      }

    private JSONValue  extraNewItemTypeToJSON()
      {
        JSONStringValue generated_string_NewItemType = new JSONStringValue(storeNewItemType);
        return generated_string_NewItemType;
      }

    private JSONValue  extraNewTitleToJSON()
      {
        JSONStringValue generated_string_NewTitle = new JSONStringValue(storeNewTitle);
        return generated_string_NewTitle;
      }

    private JSONValue  extraNewLocationToJSON()
      {
        JSONStringValue generated_string_NewLocation = new JSONStringValue(storeNewLocation);
        return generated_string_NewLocation;
      }

    private JSONValue  extraNewStartToJSON()
      {
        JSONValueHandler handler_NewStart = new JSONValueHandler();
        storeNewStart.write_as_json(handler_NewStart);
        return handler_NewStart.result;
      }

    private JSONValue  extraStartDeltaSecondsToJSON()
      {
        JSONValue generated_rational_StartDeltaSeconds;
        if (((double)(long)storeStartDeltaSeconds) == storeStartDeltaSeconds)
            generated_rational_StartDeltaSeconds = new JSONIntegerValue((long)(storeStartDeltaSeconds));
        else
            generated_rational_StartDeltaSeconds = new JSONRationalValue(storeStartDeltaSeconds, 15);
        return generated_rational_StartDeltaSeconds;
      }

    private JSONValue  extraStartDeltaDaysToJSON()
      {
        JSONIntegerValue generated_integer_StartDeltaDays = new JSONIntegerValue(storeStartDeltaDays);
        return generated_integer_StartDeltaDays;
      }

    private JSONValue  extraStartDeltaMonthsToJSON()
      {
        JSONIntegerValue generated_integer_StartDeltaMonths = new JSONIntegerValue(storeStartDeltaMonths);
        return generated_integer_StartDeltaMonths;
      }

    private JSONValue  extraNewEndToJSON()
      {
        JSONValueHandler handler_NewEnd = new JSONValueHandler();
        storeNewEnd.write_as_json(handler_NewEnd);
        return handler_NewEnd.result;
      }

    private JSONValue  extraEndDeltaSecondsToJSON()
      {
        JSONValue generated_rational_EndDeltaSeconds;
        if (((double)(long)storeEndDeltaSeconds) == storeEndDeltaSeconds)
            generated_rational_EndDeltaSeconds = new JSONIntegerValue((long)(storeEndDeltaSeconds));
        else
            generated_rational_EndDeltaSeconds = new JSONRationalValue(storeEndDeltaSeconds, 15);
        return generated_rational_EndDeltaSeconds;
      }

    private JSONValue  extraEndDeltaDaysToJSON()
      {
        JSONIntegerValue generated_integer_EndDeltaDays = new JSONIntegerValue(storeEndDeltaDays);
        return generated_integer_EndDeltaDays;
      }

    private JSONValue  extraEndDeltaMonthsToJSON()
      {
        JSONIntegerValue generated_integer_EndDeltaMonths = new JSONIntegerValue(storeEndDeltaMonths);
        return generated_integer_EndDeltaMonths;
      }

    private JSONValue  extraNewFrequencyTypeToJSON()
      {
        JSONStringValue generated_string_NewFrequencyType;
        switch (storeNewFrequencyType)
          {
            case TypeNewFrequencyType.NewFrequencyType_unknown:
                generated_string_NewFrequencyType = new JSONStringValue("unknown");
                break;
            case TypeNewFrequencyType.NewFrequencyType_one_time:
                generated_string_NewFrequencyType = new JSONStringValue("one-time");
                break;
            case TypeNewFrequencyType.NewFrequencyType_daily:
                generated_string_NewFrequencyType = new JSONStringValue("daily");
                break;
            case TypeNewFrequencyType.NewFrequencyType_weekly:
                generated_string_NewFrequencyType = new JSONStringValue("weekly");
                break;
            case TypeNewFrequencyType.NewFrequencyType_monthly:
                generated_string_NewFrequencyType = new JSONStringValue("monthly");
                break;
            case TypeNewFrequencyType.NewFrequencyType_yearly:
                generated_string_NewFrequencyType = new JSONStringValue("yearly");
                break;
            default:
                Debug.Assert(false);
                generated_string_NewFrequencyType = null;
                break;
          }
        return generated_string_NewFrequencyType;
      }

    private JSONValue  extraNewFrequencyMultiplierToJSON()
      {
        JSONIntegerValue generated_integer_NewFrequencyMultiplier = new JSONIntegerValue(storeNewFrequencyMultiplier);
        return generated_integer_NewFrequencyMultiplier;
      }

    private JSONValue  extraSetEventFieldsToJSON()
      {
        JSONArrayValue generated_array_2_SetEventFields = new JSONArrayValue();
        for (int num2 = 0; num2 < storeSetEventFields.Count; ++num2)
          {
            JSONValueHandler handler_SetEventFields = new JSONValueHandler();
            storeSetEventFields[num2].write_as_json(handler_SetEventFields);
            generated_array_2_SetEventFields.appendComponent(handler_SetEventFields.result);
          }
        return generated_array_2_SetEventFields;
      }

    private JSONValue  extraAppendEventFieldsToJSON()
      {
        JSONArrayValue generated_array_3_AppendEventFields = new JSONArrayValue();
        for (int num3 = 0; num3 < storeAppendEventFields.Count; ++num3)
          {
            JSONValueHandler handler_AppendEventFields = new JSONValueHandler();
            storeAppendEventFields[num3].write_as_json(handler_AppendEventFields);
            generated_array_3_AppendEventFields.appendComponent(handler_AppendEventFields.result);
          }
        return generated_array_3_AppendEventFields;
      }

    private JSONValue  extraRemoveEventFieldsToJSON()
      {
        JSONArrayValue generated_array_4_RemoveEventFields = new JSONArrayValue();
        for (int num4 = 0; num4 < storeRemoveEventFields.Count; ++num4)
          {
            JSONStringValue generated_string_RemoveEventFields = new JSONStringValue(storeRemoveEventFields[num4]);
            generated_array_4_RemoveEventFields.appendComponent(generated_string_RemoveEventFields);
          }
        return generated_array_4_RemoveEventFields;
      }

    private JSONValue  extraAddEventFieldsToJSON()
      {
        JSONArrayValue generated_array_5_AddEventFields = new JSONArrayValue();
        for (int num5 = 0; num5 < storeAddEventFields.Count; ++num5)
          {
            JSONValueHandler handler_AddEventFields = new JSONValueHandler();
            storeAddEventFields[num5].write_as_json(handler_AddEventFields);
            generated_array_5_AddEventFields.appendComponent(handler_AddEventFields.result);
          }
        return generated_array_5_AddEventFields;
      }

    private JSONValue  extraNativeDataToJSON()
      {
        JSONValueHandler handler_NativeData = new JSONValueHandler();
        storeNativeData.write_as_json(handler_NativeData);
        return handler_NativeData.result;
      }

    private JSONValue  extraEventsConflictResultToJSON()
      {
        JSONValueHandler handler_EventsConflictResult = new JSONValueHandler();
        storeEventsConflictResult.write_as_json(handler_EventsConflictResult);
        return handler_EventsConflictResult.result;
      }

    private JSONValue  extraCalendarPreferenceIsNotSetResultToJSON()
      {
        JSONValueHandler handler_CalendarPreferenceIsNotSetResult = new JSONValueHandler();
        storeCalendarPreferenceIsNotSetResult.write_as_json(handler_CalendarPreferenceIsNotSetResult);
        return handler_CalendarPreferenceIsNotSetResult.result;
      }

    private JSONValue  extraNoMatchResultToJSON()
      {
        JSONValueHandler handler_NoMatchResult = new JSONValueHandler();
        storeNoMatchResult.write_as_json(handler_NoMatchResult);
        return handler_NoMatchResult.result;
      }


    private void  fromJSONEventIDs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field EventIDs of ModifyCalendarItemCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field EventIDs of ModifyCalendarItemCommandJSON has too few elements.");
        List< string > vector_EventIDs1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field EventIDs of ModifyCalendarItemCommandJSON is not a string.");
            vector_EventIDs1.Add(json_string.getData());
          }
        Debug.Assert(vector_EventIDs1.Count >= 1);
        initEventIDs();
        for (int num8 = 0; num8 < vector_EventIDs1.Count; ++num8)
            appendEventIDs(vector_EventIDs1[num8]);
        for (int num1 = 0; num1 < vector_EventIDs1.Count; ++num1)
          {
          }
      }


    private void  fromJSONQuery(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CalendarQueryJSON convert_classy = CalendarQueryJSON.from_json(json_value, ignore_extras, true);
        setQuery(convert_classy);
      }


    private void  fromJSONNewItemType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NewItemType of ModifyCalendarItemCommandJSON is not a string.");
        setNewItemType(json_string.getData());
      }


    private void  fromJSONNewTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NewTitle of ModifyCalendarItemCommandJSON is not a string.");
        setNewTitle(json_string.getData());
      }


    private void  fromJSONNewLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NewLocation of ModifyCalendarItemCommandJSON is not a string.");
        setNewLocation(json_string.getData());
      }


    private void  fromJSONNewStart(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setNewStart(convert_classy);
      }


    private void  fromJSONStartDeltaSeconds(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field StartDeltaSeconds of ModifyCalendarItemCommandJSON is not a number.");
              }
          }
        setStartDeltaSecondsText(the_rational_text);
      }


    private void  fromJSONStartDeltaDays(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field StartDeltaDays of ModifyCalendarItemCommandJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field StartDeltaDays of ModifyCalendarItemCommandJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setStartDeltaDays(extracted_integer);
      }


    private void  fromJSONStartDeltaMonths(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field StartDeltaMonths of ModifyCalendarItemCommandJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field StartDeltaMonths of ModifyCalendarItemCommandJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setStartDeltaMonths(extracted_integer);
      }


    private void  fromJSONNewEnd(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setNewEnd(convert_classy);
      }


    private void  fromJSONEndDeltaSeconds(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field EndDeltaSeconds of ModifyCalendarItemCommandJSON is not a number.");
              }
          }
        setEndDeltaSecondsText(the_rational_text);
      }


    private void  fromJSONEndDeltaDays(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field EndDeltaDays of ModifyCalendarItemCommandJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field EndDeltaDays of ModifyCalendarItemCommandJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setEndDeltaDays(extracted_integer);
      }


    private void  fromJSONEndDeltaMonths(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field EndDeltaMonths of ModifyCalendarItemCommandJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field EndDeltaMonths of ModifyCalendarItemCommandJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setEndDeltaMonths(extracted_integer);
      }


    private void  fromJSONNewFrequencyType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NewFrequencyType of ModifyCalendarItemCommandJSON is not a string.");
        TypeNewFrequencyType the_enum;
        switch (json_string.getData()[0])
          {
            case 'd':
                if ((String.Compare(json_string.getData(), 1, "aily", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_enum = TypeNewFrequencyType.NewFrequencyType_daily;
                        goto enum_is_done;
                      }
                break;
            case 'm':
                if ((String.Compare(json_string.getData(), 1, "onthly", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeNewFrequencyType.NewFrequencyType_monthly;
                        goto enum_is_done;
                      }
                break;
            case 'o':
                if ((String.Compare(json_string.getData(), 1, "ne-time", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeNewFrequencyType.NewFrequencyType_one_time;
                        goto enum_is_done;
                      }
                break;
            case 'u':
                if ((String.Compare(json_string.getData(), 1, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeNewFrequencyType.NewFrequencyType_unknown;
                        goto enum_is_done;
                      }
                break;
            case 'w':
                if ((String.Compare(json_string.getData(), 1, "eekly", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_enum = TypeNewFrequencyType.NewFrequencyType_weekly;
                        goto enum_is_done;
                      }
                break;
            case 'y':
                if ((String.Compare(json_string.getData(), 1, "early", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_enum = TypeNewFrequencyType.NewFrequencyType_yearly;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field NewFrequencyType of ModifyCalendarItemCommandJSON is not one of the legal strings.");
      enum_is_done:;
        setNewFrequencyType(the_enum);
      }


    private void  fromJSONNewFrequencyMultiplier(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field NewFrequencyMultiplier of ModifyCalendarItemCommandJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field NewFrequencyMultiplier of ModifyCalendarItemCommandJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setNewFrequencyMultiplier(extracted_integer);
      }


    private void  fromJSONSetEventFields(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SetEventFields of ModifyCalendarItemCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeSetEventFieldsJSON  > vector_SetEventFields1 = new List< TypeSetEventFieldsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeSetEventFieldsJSON convert_classy = TypeSetEventFieldsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_SetEventFields1.Add(convert_classy);
          }
        initSetEventFields();
        for (int num9 = 0; num9 < vector_SetEventFields1.Count; ++num9)
            appendSetEventFields(vector_SetEventFields1[num9]);
        for (int num1 = 0; num1 < vector_SetEventFields1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAppendEventFields(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AppendEventFields of ModifyCalendarItemCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeAppendEventFieldsJSON  > vector_AppendEventFields1 = new List< TypeAppendEventFieldsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeAppendEventFieldsJSON convert_classy = TypeAppendEventFieldsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_AppendEventFields1.Add(convert_classy);
          }
        initAppendEventFields();
        for (int num10 = 0; num10 < vector_AppendEventFields1.Count; ++num10)
            appendAppendEventFields(vector_AppendEventFields1[num10]);
        for (int num1 = 0; num1 < vector_AppendEventFields1.Count; ++num1)
          {
          }
      }


    private void  fromJSONRemoveEventFields(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RemoveEventFields of ModifyCalendarItemCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_RemoveEventFields1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field RemoveEventFields of ModifyCalendarItemCommandJSON is not a string.");
            vector_RemoveEventFields1.Add(json_string.getData());
          }
        initRemoveEventFields();
        for (int num11 = 0; num11 < vector_RemoveEventFields1.Count; ++num11)
            appendRemoveEventFields(vector_RemoveEventFields1[num11]);
        for (int num1 = 0; num1 < vector_RemoveEventFields1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAddEventFields(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AddEventFields of ModifyCalendarItemCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeAddEventFieldsJSON  > vector_AddEventFields1 = new List< TypeAddEventFieldsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeAddEventFieldsJSON convert_classy = TypeAddEventFieldsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_AddEventFields1.Add(convert_classy);
          }
        initAddEventFields();
        for (int num12 = 0; num12 < vector_AddEventFields1.Count; ++num12)
            appendAddEventFields(vector_AddEventFields1[num12]);
        for (int num1 = 0; num1 < vector_AddEventFields1.Count; ++num1)
          {
          }
      }


    private void  fromJSONNativeData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeNativeDataJSON convert_classy = TypeNativeDataJSON.from_json(json_value, ignore_extras, true);
        setNativeData(convert_classy);
      }


    private void  fromJSONEventsConflictResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setEventsConflictResult(convert_classy);
      }


    private void  fromJSONCalendarPreferenceIsNotSetResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setCalendarPreferenceIsNotSetResult(convert_classy);
      }


    private void  fromJSONNoMatchResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setNoMatchResult(convert_classy);
      }


    public ModifyCalendarItemCommandJSON()
      {
        flagHasEventIDs = false;
        flagHasQuery = false;
        flagHasNewItemType = false;
        flagHasNewTitle = false;
        flagHasNewLocation = false;
        flagHasNewStart = false;
        flagHasStartDeltaSeconds = false;
        flagHasStartDeltaDays = false;
        flagHasStartDeltaMonths = false;
        flagHasNewEnd = false;
        flagHasEndDeltaSeconds = false;
        flagHasEndDeltaDays = false;
        flagHasEndDeltaMonths = false;
        flagHasNewFrequencyType = false;
        flagHasNewFrequencyMultiplier = false;
        flagHasSetEventFields = false;
        flagHasAppendEventFields = false;
        flagHasRemoveEventFields = false;
        flagHasAddEventFields = false;
        flagHasNativeData = false;
        flagHasEventsConflictResult = false;
        flagHasCalendarPreferenceIsNotSetResult = false;
        flagHasNoMatchResult = false;
        storeEventIDs = new List< string >();
        storeSetEventFields = new List< TypeSetEventFieldsJSON  >();
        storeAppendEventFields = new List< TypeAppendEventFieldsJSON  >();
        storeRemoveEventFields = new List< string >();
        storeAddEventFields = new List< TypeAddEventFieldsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getCalendarCommandKind()
      {
        return "ModifyItem";
      }

    public bool  hasEventIDs()
      {
        return flagHasEventIDs;
      }

    public int  countOfEventIDs()
      {
        Debug.Assert(flagHasEventIDs);
        return storeEventIDs.Count;
      }

    public string  elementOfEventIDs(int element_num)
      {
        Debug.Assert(flagHasEventIDs);
        return storeEventIDs[element_num];
      }

    public List< string >  getEventIDs()
      {
        Debug.Assert(flagHasEventIDs);
        return storeEventIDs;
      }

    public bool  hasQuery()
      {
        return flagHasQuery;
      }

    public CalendarQueryJSON   getQuery()
      {
        Debug.Assert(flagHasQuery);
        return storeQuery;
      }

    public bool  hasNewItemType()
      {
        return flagHasNewItemType;
      }

    public string  getNewItemType()
      {
        Debug.Assert(flagHasNewItemType);
        return storeNewItemType;
      }

    public bool  hasNewTitle()
      {
        return flagHasNewTitle;
      }

    public string  getNewTitle()
      {
        Debug.Assert(flagHasNewTitle);
        return storeNewTitle;
      }

    public bool  hasNewLocation()
      {
        return flagHasNewLocation;
      }

    public string  getNewLocation()
      {
        Debug.Assert(flagHasNewLocation);
        return storeNewLocation;
      }

    public bool  hasNewStart()
      {
        return flagHasNewStart;
      }

    public DateAndOrTimeJSON   getNewStart()
      {
        Debug.Assert(flagHasNewStart);
        return storeNewStart;
      }

    public bool  hasStartDeltaSeconds()
      {
        return flagHasStartDeltaSeconds;
      }

    public double  getStartDeltaSeconds()
      {
        Debug.Assert(flagHasStartDeltaSeconds);
        if (textStoreStartDeltaSeconds != "")
          {
            return Double.Parse(textStoreStartDeltaSeconds);
          }
        return storeStartDeltaSeconds;
      }

    public string  getStartDeltaSecondsAsText()
      {
        Debug.Assert(flagHasStartDeltaSeconds);
        if (textStoreStartDeltaSeconds == "")
          {
            return Convert.ToString(storeStartDeltaSeconds);
          }
        else
          {
            return (textStoreStartDeltaSeconds);
          }
      }

    public bool  hasStartDeltaDays()
      {
        return flagHasStartDeltaDays;
      }

    public BigInteger  getStartDeltaDays()
      {
        Debug.Assert(flagHasStartDeltaDays);
        return storeStartDeltaDays;
      }

    public bool  hasStartDeltaMonths()
      {
        return flagHasStartDeltaMonths;
      }

    public BigInteger  getStartDeltaMonths()
      {
        Debug.Assert(flagHasStartDeltaMonths);
        return storeStartDeltaMonths;
      }

    public bool  hasNewEnd()
      {
        return flagHasNewEnd;
      }

    public DateAndOrTimeJSON   getNewEnd()
      {
        Debug.Assert(flagHasNewEnd);
        return storeNewEnd;
      }

    public bool  hasEndDeltaSeconds()
      {
        return flagHasEndDeltaSeconds;
      }

    public double  getEndDeltaSeconds()
      {
        Debug.Assert(flagHasEndDeltaSeconds);
        if (textStoreEndDeltaSeconds != "")
          {
            return Double.Parse(textStoreEndDeltaSeconds);
          }
        return storeEndDeltaSeconds;
      }

    public string  getEndDeltaSecondsAsText()
      {
        Debug.Assert(flagHasEndDeltaSeconds);
        if (textStoreEndDeltaSeconds == "")
          {
            return Convert.ToString(storeEndDeltaSeconds);
          }
        else
          {
            return (textStoreEndDeltaSeconds);
          }
      }

    public bool  hasEndDeltaDays()
      {
        return flagHasEndDeltaDays;
      }

    public BigInteger  getEndDeltaDays()
      {
        Debug.Assert(flagHasEndDeltaDays);
        return storeEndDeltaDays;
      }

    public bool  hasEndDeltaMonths()
      {
        return flagHasEndDeltaMonths;
      }

    public BigInteger  getEndDeltaMonths()
      {
        Debug.Assert(flagHasEndDeltaMonths);
        return storeEndDeltaMonths;
      }

    public bool  hasNewFrequencyType()
      {
        return flagHasNewFrequencyType;
      }

    public TypeNewFrequencyType  getNewFrequencyType()
      {
        Debug.Assert(flagHasNewFrequencyType);
        return storeNewFrequencyType;
      }

    public string  getNewFrequencyTypeAsString()
      {
        return stringFromNewFrequencyType(getNewFrequencyType());
      }

    public bool  hasNewFrequencyMultiplier()
      {
        return flagHasNewFrequencyMultiplier;
      }

    public BigInteger  getNewFrequencyMultiplier()
      {
        Debug.Assert(flagHasNewFrequencyMultiplier);
        return storeNewFrequencyMultiplier;
      }

    public bool  hasSetEventFields()
      {
        return flagHasSetEventFields;
      }

    public int  countOfSetEventFields()
      {
        Debug.Assert(flagHasSetEventFields);
        return storeSetEventFields.Count;
      }

    public TypeSetEventFieldsJSON   elementOfSetEventFields(int element_num)
      {
        Debug.Assert(flagHasSetEventFields);
        return storeSetEventFields[element_num];
      }

    public List< TypeSetEventFieldsJSON  >  getSetEventFields()
      {
        Debug.Assert(flagHasSetEventFields);
        return storeSetEventFields;
      }

    public bool  hasAppendEventFields()
      {
        return flagHasAppendEventFields;
      }

    public int  countOfAppendEventFields()
      {
        Debug.Assert(flagHasAppendEventFields);
        return storeAppendEventFields.Count;
      }

    public TypeAppendEventFieldsJSON   elementOfAppendEventFields(int element_num)
      {
        Debug.Assert(flagHasAppendEventFields);
        return storeAppendEventFields[element_num];
      }

    public List< TypeAppendEventFieldsJSON  >  getAppendEventFields()
      {
        Debug.Assert(flagHasAppendEventFields);
        return storeAppendEventFields;
      }

    public bool  hasRemoveEventFields()
      {
        return flagHasRemoveEventFields;
      }

    public int  countOfRemoveEventFields()
      {
        Debug.Assert(flagHasRemoveEventFields);
        return storeRemoveEventFields.Count;
      }

    public string  elementOfRemoveEventFields(int element_num)
      {
        Debug.Assert(flagHasRemoveEventFields);
        return storeRemoveEventFields[element_num];
      }

    public List< string >  getRemoveEventFields()
      {
        Debug.Assert(flagHasRemoveEventFields);
        return storeRemoveEventFields;
      }

    public bool  hasAddEventFields()
      {
        return flagHasAddEventFields;
      }

    public int  countOfAddEventFields()
      {
        Debug.Assert(flagHasAddEventFields);
        return storeAddEventFields.Count;
      }

    public TypeAddEventFieldsJSON   elementOfAddEventFields(int element_num)
      {
        Debug.Assert(flagHasAddEventFields);
        return storeAddEventFields[element_num];
      }

    public List< TypeAddEventFieldsJSON  >  getAddEventFields()
      {
        Debug.Assert(flagHasAddEventFields);
        return storeAddEventFields;
      }

    public bool  hasNativeData()
      {
        return flagHasNativeData;
      }

    public TypeNativeDataJSON   getNativeData()
      {
        Debug.Assert(flagHasNativeData);
        return storeNativeData;
      }

    public bool  hasEventsConflictResult()
      {
        return flagHasEventsConflictResult;
      }

    public DynamicResponseJSON   getEventsConflictResult()
      {
        Debug.Assert(flagHasEventsConflictResult);
        return storeEventsConflictResult;
      }

    public bool  hasCalendarPreferenceIsNotSetResult()
      {
        return flagHasCalendarPreferenceIsNotSetResult;
      }

    public DynamicResponseJSON   getCalendarPreferenceIsNotSetResult()
      {
        Debug.Assert(flagHasCalendarPreferenceIsNotSetResult);
        return storeCalendarPreferenceIsNotSetResult;
      }

    public bool  hasNoMatchResult()
      {
        return flagHasNoMatchResult;
      }

    public DynamicResponseJSON   getNoMatchResult()
      {
        Debug.Assert(flagHasNoMatchResult);
        return storeNoMatchResult;
      }


    public virtual int extraModifyCalendarItemCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraModifyCalendarItemCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraModifyCalendarItemCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraModifyCalendarItemCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCalendarCommandComponentCount()
      {
        int result = 0;
        if (flagHasEventIDs)
            ++result;
        if (flagHasQuery)
            ++result;
        if (flagHasNewItemType)
            ++result;
        if (flagHasNewTitle)
            ++result;
        if (flagHasNewLocation)
            ++result;
        if (flagHasNewStart)
            ++result;
        if (flagHasStartDeltaSeconds)
            ++result;
        if (flagHasStartDeltaDays)
            ++result;
        if (flagHasStartDeltaMonths)
            ++result;
        if (flagHasNewEnd)
            ++result;
        if (flagHasEndDeltaSeconds)
            ++result;
        if (flagHasEndDeltaDays)
            ++result;
        if (flagHasEndDeltaMonths)
            ++result;
        if (flagHasNewFrequencyType)
            ++result;
        if (flagHasNewFrequencyMultiplier)
            ++result;
        if (flagHasSetEventFields)
            ++result;
        if (flagHasAppendEventFields)
            ++result;
        if (flagHasRemoveEventFields)
            ++result;
        if (flagHasAddEventFields)
            ++result;
        if (flagHasNativeData)
            ++result;
        if (flagHasEventsConflictResult)
            ++result;
        if (flagHasCalendarPreferenceIsNotSetResult)
            ++result;
        if (flagHasNoMatchResult)
            ++result;
        result += extraModifyCalendarItemCommandComponentCount();
        return result;
      }
    public override string extraCalendarCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasEventIDs)
          {
            if (remainder == 0)
                return "EventIDs";
            --remainder;
          }
        if (flagHasQuery)
          {
            if (remainder == 0)
                return "Query";
            --remainder;
          }
        if (flagHasNewItemType)
          {
            if (remainder == 0)
                return "NewItemType";
            --remainder;
          }
        if (flagHasNewTitle)
          {
            if (remainder == 0)
                return "NewTitle";
            --remainder;
          }
        if (flagHasNewLocation)
          {
            if (remainder == 0)
                return "NewLocation";
            --remainder;
          }
        if (flagHasNewStart)
          {
            if (remainder == 0)
                return "NewStart";
            --remainder;
          }
        if (flagHasStartDeltaSeconds)
          {
            if (remainder == 0)
                return "StartDeltaSeconds";
            --remainder;
          }
        if (flagHasStartDeltaDays)
          {
            if (remainder == 0)
                return "StartDeltaDays";
            --remainder;
          }
        if (flagHasStartDeltaMonths)
          {
            if (remainder == 0)
                return "StartDeltaMonths";
            --remainder;
          }
        if (flagHasNewEnd)
          {
            if (remainder == 0)
                return "NewEnd";
            --remainder;
          }
        if (flagHasEndDeltaSeconds)
          {
            if (remainder == 0)
                return "EndDeltaSeconds";
            --remainder;
          }
        if (flagHasEndDeltaDays)
          {
            if (remainder == 0)
                return "EndDeltaDays";
            --remainder;
          }
        if (flagHasEndDeltaMonths)
          {
            if (remainder == 0)
                return "EndDeltaMonths";
            --remainder;
          }
        if (flagHasNewFrequencyType)
          {
            if (remainder == 0)
                return "NewFrequencyType";
            --remainder;
          }
        if (flagHasNewFrequencyMultiplier)
          {
            if (remainder == 0)
                return "NewFrequencyMultiplier";
            --remainder;
          }
        if (flagHasSetEventFields)
          {
            if (remainder == 0)
                return "SetEventFields";
            --remainder;
          }
        if (flagHasAppendEventFields)
          {
            if (remainder == 0)
                return "AppendEventFields";
            --remainder;
          }
        if (flagHasRemoveEventFields)
          {
            if (remainder == 0)
                return "RemoveEventFields";
            --remainder;
          }
        if (flagHasAddEventFields)
          {
            if (remainder == 0)
                return "AddEventFields";
            --remainder;
          }
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return "NativeData";
            --remainder;
          }
        if (flagHasEventsConflictResult)
          {
            if (remainder == 0)
                return "EventsConflictResult";
            --remainder;
          }
        if (flagHasCalendarPreferenceIsNotSetResult)
          {
            if (remainder == 0)
                return "CalendarPreferenceIsNotSetResult";
            --remainder;
          }
        if (flagHasNoMatchResult)
          {
            if (remainder == 0)
                return "NoMatchResult";
            --remainder;
          }
        return extraModifyCalendarItemCommandComponentKey(remainder);
      }
    public override JSONValue extraCalendarCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasEventIDs)
          {
            if (remainder == 0)
                return extraEventIDsToJSON();
            --remainder;
          }
        if (flagHasQuery)
          {
            if (remainder == 0)
                return extraQueryToJSON();
            --remainder;
          }
        if (flagHasNewItemType)
          {
            if (remainder == 0)
                return extraNewItemTypeToJSON();
            --remainder;
          }
        if (flagHasNewTitle)
          {
            if (remainder == 0)
                return extraNewTitleToJSON();
            --remainder;
          }
        if (flagHasNewLocation)
          {
            if (remainder == 0)
                return extraNewLocationToJSON();
            --remainder;
          }
        if (flagHasNewStart)
          {
            if (remainder == 0)
                return extraNewStartToJSON();
            --remainder;
          }
        if (flagHasStartDeltaSeconds)
          {
            if (remainder == 0)
                return extraStartDeltaSecondsToJSON();
            --remainder;
          }
        if (flagHasStartDeltaDays)
          {
            if (remainder == 0)
                return extraStartDeltaDaysToJSON();
            --remainder;
          }
        if (flagHasStartDeltaMonths)
          {
            if (remainder == 0)
                return extraStartDeltaMonthsToJSON();
            --remainder;
          }
        if (flagHasNewEnd)
          {
            if (remainder == 0)
                return extraNewEndToJSON();
            --remainder;
          }
        if (flagHasEndDeltaSeconds)
          {
            if (remainder == 0)
                return extraEndDeltaSecondsToJSON();
            --remainder;
          }
        if (flagHasEndDeltaDays)
          {
            if (remainder == 0)
                return extraEndDeltaDaysToJSON();
            --remainder;
          }
        if (flagHasEndDeltaMonths)
          {
            if (remainder == 0)
                return extraEndDeltaMonthsToJSON();
            --remainder;
          }
        if (flagHasNewFrequencyType)
          {
            if (remainder == 0)
                return extraNewFrequencyTypeToJSON();
            --remainder;
          }
        if (flagHasNewFrequencyMultiplier)
          {
            if (remainder == 0)
                return extraNewFrequencyMultiplierToJSON();
            --remainder;
          }
        if (flagHasSetEventFields)
          {
            if (remainder == 0)
                return extraSetEventFieldsToJSON();
            --remainder;
          }
        if (flagHasAppendEventFields)
          {
            if (remainder == 0)
                return extraAppendEventFieldsToJSON();
            --remainder;
          }
        if (flagHasRemoveEventFields)
          {
            if (remainder == 0)
                return extraRemoveEventFieldsToJSON();
            --remainder;
          }
        if (flagHasAddEventFields)
          {
            if (remainder == 0)
                return extraAddEventFieldsToJSON();
            --remainder;
          }
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return extraNativeDataToJSON();
            --remainder;
          }
        if (flagHasEventsConflictResult)
          {
            if (remainder == 0)
                return extraEventsConflictResultToJSON();
            --remainder;
          }
        if (flagHasCalendarPreferenceIsNotSetResult)
          {
            if (remainder == 0)
                return extraCalendarPreferenceIsNotSetResultToJSON();
            --remainder;
          }
        if (flagHasNoMatchResult)
          {
            if (remainder == 0)
                return extraNoMatchResultToJSON();
            --remainder;
          }
        return extraModifyCalendarItemCommandComponentValue(remainder);
      }
    public override JSONValue extraCalendarCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                switch (field_name[1])
                  {
                    case 'd':
                        if ((String.Compare(field_name, 2, "dEventFields", 0, 12, false) == 0) && (field_name.Length == 14))
                            return (flagHasAddEventFields ? extraAddEventFieldsToJSON() : null);
                        break;
                    case 'p':
                        if ((String.Compare(field_name, 2, "pendEventFields", 0, 15, false) == 0) && (field_name.Length == 17))
                            return (flagHasAppendEventFields ? extraAppendEventFieldsToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                if ((String.Compare(field_name, 1, "alendarPreferenceIsNotSetResult", 0, 31, false) == 0) && (field_name.Length == 32))
                    return (flagHasCalendarPreferenceIsNotSetResult ? extraCalendarPreferenceIsNotSetResultToJSON() : null);
                break;
            case 'E':
                switch (field_name[1])
                  {
                    case 'n':
                        if (String.Compare(field_name, 2, "dDelta", 0, 6, false) == 0)
                          {
                            switch (field_name[8])
                              {
                                case 'D':
                                    if ((String.Compare(field_name, 9, "ays", 0, 3, false) == 0) && (field_name.Length == 12))
                                        return (flagHasEndDeltaDays ? extraEndDeltaDaysToJSON() : null);
                                    break;
                                case 'M':
                                    if ((String.Compare(field_name, 9, "onths", 0, 5, false) == 0) && (field_name.Length == 14))
                                        return (flagHasEndDeltaMonths ? extraEndDeltaMonthsToJSON() : null);
                                    break;
                                case 'S':
                                    if ((String.Compare(field_name, 9, "econds", 0, 6, false) == 0) && (field_name.Length == 15))
                                        return (flagHasEndDeltaSeconds ? extraEndDeltaSecondsToJSON() : null);
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'v':
                        if (String.Compare(field_name, 2, "ent", 0, 3, false) == 0)
                          {
                            switch (field_name[5])
                              {
                                case 'I':
                                    if ((String.Compare(field_name, 6, "Ds", 0, 2, false) == 0) && (field_name.Length == 8))
                                        return (flagHasEventIDs ? extraEventIDsToJSON() : null);
                                    break;
                                case 's':
                                    if ((String.Compare(field_name, 6, "ConflictResult", 0, 14, false) == 0) && (field_name.Length == 20))
                                        return (flagHasEventsConflictResult ? extraEventsConflictResultToJSON() : null);
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'N':
                switch (field_name[1])
                  {
                    case 'a':
                        if ((String.Compare(field_name, 2, "tiveData", 0, 8, false) == 0) && (field_name.Length == 10))
                            return (flagHasNativeData ? extraNativeDataToJSON() : null);
                        break;
                    case 'e':
                        if (String.Compare(field_name, 2, "w", 0, 1, false) == 0)
                          {
                            switch (field_name[3])
                              {
                                case 'E':
                                    if ((String.Compare(field_name, 4, "nd", 0, 2, false) == 0) && (field_name.Length == 6))
                                        return (flagHasNewEnd ? extraNewEndToJSON() : null);
                                    break;
                                case 'F':
                                    if (String.Compare(field_name, 4, "requency", 0, 8, false) == 0)
                                      {
                                        switch (field_name[12])
                                          {
                                            case 'M':
                                                if ((String.Compare(field_name, 13, "ultiplier", 0, 9, false) == 0) && (field_name.Length == 22))
                                                    return (flagHasNewFrequencyMultiplier ? extraNewFrequencyMultiplierToJSON() : null);
                                                break;
                                            case 'T':
                                                if ((String.Compare(field_name, 13, "ype", 0, 3, false) == 0) && (field_name.Length == 16))
                                                    return (flagHasNewFrequencyType ? extraNewFrequencyTypeToJSON() : null);
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'I':
                                    if ((String.Compare(field_name, 4, "temType", 0, 7, false) == 0) && (field_name.Length == 11))
                                        return (flagHasNewItemType ? extraNewItemTypeToJSON() : null);
                                    break;
                                case 'L':
                                    if ((String.Compare(field_name, 4, "ocation", 0, 7, false) == 0) && (field_name.Length == 11))
                                        return (flagHasNewLocation ? extraNewLocationToJSON() : null);
                                    break;
                                case 'S':
                                    if ((String.Compare(field_name, 4, "tart", 0, 4, false) == 0) && (field_name.Length == 8))
                                        return (flagHasNewStart ? extraNewStartToJSON() : null);
                                    break;
                                case 'T':
                                    if ((String.Compare(field_name, 4, "itle", 0, 4, false) == 0) && (field_name.Length == 8))
                                        return (flagHasNewTitle ? extraNewTitleToJSON() : null);
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'o':
                        if ((String.Compare(field_name, 2, "MatchResult", 0, 11, false) == 0) && (field_name.Length == 13))
                            return (flagHasNoMatchResult ? extraNoMatchResultToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'Q':
                if ((String.Compare(field_name, 1, "uery", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasQuery ? extraQueryToJSON() : null);
                break;
            case 'R':
                if ((String.Compare(field_name, 1, "emoveEventFields", 0, 16, false) == 0) && (field_name.Length == 17))
                    return (flagHasRemoveEventFields ? extraRemoveEventFieldsToJSON() : null);
                break;
            case 'S':
                switch (field_name[1])
                  {
                    case 'e':
                        if ((String.Compare(field_name, 2, "tEventFields", 0, 12, false) == 0) && (field_name.Length == 14))
                            return (flagHasSetEventFields ? extraSetEventFieldsToJSON() : null);
                        break;
                    case 't':
                        if (String.Compare(field_name, 2, "artDelta", 0, 8, false) == 0)
                          {
                            switch (field_name[10])
                              {
                                case 'D':
                                    if ((String.Compare(field_name, 11, "ays", 0, 3, false) == 0) && (field_name.Length == 14))
                                        return (flagHasStartDeltaDays ? extraStartDeltaDaysToJSON() : null);
                                    break;
                                case 'M':
                                    if ((String.Compare(field_name, 11, "onths", 0, 5, false) == 0) && (field_name.Length == 16))
                                        return (flagHasStartDeltaMonths ? extraStartDeltaMonthsToJSON() : null);
                                    break;
                                case 'S':
                                    if ((String.Compare(field_name, 11, "econds", 0, 6, false) == 0) && (field_name.Length == 17))
                                        return (flagHasStartDeltaSeconds ? extraStartDeltaSecondsToJSON() : null);
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        return extraModifyCalendarItemCommandLookup(field_name);
      }

    public void initEventIDs()
      {
        flagHasEventIDs = true;
        storeEventIDs.Clear();
      }
    public void appendEventIDs(string to_append)
      {
        if (!flagHasEventIDs)
          {
            flagHasEventIDs = true;
            storeEventIDs.Clear();
          }
        Debug.Assert(flagHasEventIDs);
        storeEventIDs.Add(to_append);
      }
    public void unsetEventIDs()
      {
        flagHasEventIDs = false;
        storeEventIDs.Clear();
      }
    public void setQuery(CalendarQueryJSON  new_value)
      {
        if (flagHasQuery)
          {
          }
        flagHasQuery = true;
        storeQuery = new_value;
      }
    public void unsetQuery()
      {
        if (flagHasQuery)
          {
          }
        flagHasQuery = false;
      }
    public void setNewItemType(string new_value)
      {
        flagHasNewItemType = true;
        storeNewItemType = new_value;
      }
    public void unsetNewItemType()
      {
        flagHasNewItemType = false;
      }
    public void setNewTitle(string new_value)
      {
        flagHasNewTitle = true;
        storeNewTitle = new_value;
      }
    public void unsetNewTitle()
      {
        flagHasNewTitle = false;
      }
    public void setNewLocation(string new_value)
      {
        flagHasNewLocation = true;
        storeNewLocation = new_value;
      }
    public void unsetNewLocation()
      {
        flagHasNewLocation = false;
      }
    public void setNewStart(DateAndOrTimeJSON  new_value)
      {
        if (flagHasNewStart)
          {
          }
        flagHasNewStart = true;
        storeNewStart = new_value;
      }
    public void unsetNewStart()
      {
        if (flagHasNewStart)
          {
          }
        flagHasNewStart = false;
      }
    public void setStartDeltaSeconds(double new_value)
      {
        flagHasStartDeltaSeconds = true;
        storeStartDeltaSeconds = new_value;
        textStoreStartDeltaSeconds = "";
      }
    public void setStartDeltaSecondsText(string new_value)
      {
        flagHasStartDeltaSeconds = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field StartDeltaSeconds of ModifyCalendarItemCommandJSON is not a valid number.");
        textStoreStartDeltaSeconds = new_value;
      }
    public void unsetStartDeltaSeconds()
      {
        flagHasStartDeltaSeconds = false;
      }
    public void setStartDeltaDays(BigInteger new_value)
      {
        flagHasStartDeltaDays = true;
        if (new_value < 0)
            throw new Exception("The value for field StartDeltaDays of ModifyCalendarItemCommandJSON is less than the lower bound (0) for that field.");
        storeStartDeltaDays = new_value;
      }
    public void unsetStartDeltaDays()
      {
        flagHasStartDeltaDays = false;
      }
    public void setStartDeltaMonths(BigInteger new_value)
      {
        flagHasStartDeltaMonths = true;
        if (new_value < 0)
            throw new Exception("The value for field StartDeltaMonths of ModifyCalendarItemCommandJSON is less than the lower bound (0) for that field.");
        storeStartDeltaMonths = new_value;
      }
    public void unsetStartDeltaMonths()
      {
        flagHasStartDeltaMonths = false;
      }
    public void setNewEnd(DateAndOrTimeJSON  new_value)
      {
        if (flagHasNewEnd)
          {
          }
        flagHasNewEnd = true;
        storeNewEnd = new_value;
      }
    public void unsetNewEnd()
      {
        if (flagHasNewEnd)
          {
          }
        flagHasNewEnd = false;
      }
    public void setEndDeltaSeconds(double new_value)
      {
        flagHasEndDeltaSeconds = true;
        storeEndDeltaSeconds = new_value;
        textStoreEndDeltaSeconds = "";
      }
    public void setEndDeltaSecondsText(string new_value)
      {
        flagHasEndDeltaSeconds = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field EndDeltaSeconds of ModifyCalendarItemCommandJSON is not a valid number.");
        textStoreEndDeltaSeconds = new_value;
      }
    public void unsetEndDeltaSeconds()
      {
        flagHasEndDeltaSeconds = false;
      }
    public void setEndDeltaDays(BigInteger new_value)
      {
        flagHasEndDeltaDays = true;
        if (new_value < 0)
            throw new Exception("The value for field EndDeltaDays of ModifyCalendarItemCommandJSON is less than the lower bound (0) for that field.");
        storeEndDeltaDays = new_value;
      }
    public void unsetEndDeltaDays()
      {
        flagHasEndDeltaDays = false;
      }
    public void setEndDeltaMonths(BigInteger new_value)
      {
        flagHasEndDeltaMonths = true;
        if (new_value < 0)
            throw new Exception("The value for field EndDeltaMonths of ModifyCalendarItemCommandJSON is less than the lower bound (0) for that field.");
        storeEndDeltaMonths = new_value;
      }
    public void unsetEndDeltaMonths()
      {
        flagHasEndDeltaMonths = false;
      }
    public void setNewFrequencyType(TypeNewFrequencyType new_value)
      {
        flagHasNewFrequencyType = true;
        storeNewFrequencyType = new_value;
      }
    public void setNewFrequencyType(string chars)
      {
        setNewFrequencyType(stringToNewFrequencyType(chars));
      }
    public void unsetNewFrequencyType()
      {
        flagHasNewFrequencyType = false;
      }
    public void setNewFrequencyMultiplier(BigInteger new_value)
      {
        flagHasNewFrequencyMultiplier = true;
        if (new_value < 0)
            throw new Exception("The value for field NewFrequencyMultiplier of ModifyCalendarItemCommandJSON is less than the lower bound (0) for that field.");
        storeNewFrequencyMultiplier = new_value;
      }
    public void unsetNewFrequencyMultiplier()
      {
        flagHasNewFrequencyMultiplier = false;
      }
    public void initSetEventFields()
      {
        if (flagHasSetEventFields)
          {
            for (int num11 = 0; num11 < storeSetEventFields.Count; ++num11)
              {
              }
          }
        flagHasSetEventFields = true;
        storeSetEventFields.Clear();
      }
    public void appendSetEventFields(TypeSetEventFieldsJSON  to_append)
      {
        if (!flagHasSetEventFields)
          {
            flagHasSetEventFields = true;
            storeSetEventFields.Clear();
          }
        Debug.Assert(flagHasSetEventFields);
        storeSetEventFields.Add(to_append);
      }
    public void unsetSetEventFields()
      {
        if (flagHasSetEventFields)
          {
            for (int num12 = 0; num12 < storeSetEventFields.Count; ++num12)
              {
              }
          }
        flagHasSetEventFields = false;
        storeSetEventFields.Clear();
      }
    public void initAppendEventFields()
      {
        if (flagHasAppendEventFields)
          {
            for (int num13 = 0; num13 < storeAppendEventFields.Count; ++num13)
              {
              }
          }
        flagHasAppendEventFields = true;
        storeAppendEventFields.Clear();
      }
    public void appendAppendEventFields(TypeAppendEventFieldsJSON  to_append)
      {
        if (!flagHasAppendEventFields)
          {
            flagHasAppendEventFields = true;
            storeAppendEventFields.Clear();
          }
        Debug.Assert(flagHasAppendEventFields);
        storeAppendEventFields.Add(to_append);
      }
    public void unsetAppendEventFields()
      {
        if (flagHasAppendEventFields)
          {
            for (int num14 = 0; num14 < storeAppendEventFields.Count; ++num14)
              {
              }
          }
        flagHasAppendEventFields = false;
        storeAppendEventFields.Clear();
      }
    public void initRemoveEventFields()
      {
        flagHasRemoveEventFields = true;
        storeRemoveEventFields.Clear();
      }
    public void appendRemoveEventFields(string to_append)
      {
        if (!flagHasRemoveEventFields)
          {
            flagHasRemoveEventFields = true;
            storeRemoveEventFields.Clear();
          }
        Debug.Assert(flagHasRemoveEventFields);
        storeRemoveEventFields.Add(to_append);
      }
    public void unsetRemoveEventFields()
      {
        flagHasRemoveEventFields = false;
        storeRemoveEventFields.Clear();
      }
    public void initAddEventFields()
      {
        if (flagHasAddEventFields)
          {
            for (int num15 = 0; num15 < storeAddEventFields.Count; ++num15)
              {
              }
          }
        flagHasAddEventFields = true;
        storeAddEventFields.Clear();
      }
    public void appendAddEventFields(TypeAddEventFieldsJSON  to_append)
      {
        if (!flagHasAddEventFields)
          {
            flagHasAddEventFields = true;
            storeAddEventFields.Clear();
          }
        Debug.Assert(flagHasAddEventFields);
        storeAddEventFields.Add(to_append);
      }
    public void unsetAddEventFields()
      {
        if (flagHasAddEventFields)
          {
            for (int num16 = 0; num16 < storeAddEventFields.Count; ++num16)
              {
              }
          }
        flagHasAddEventFields = false;
        storeAddEventFields.Clear();
      }
    public void setNativeData(TypeNativeDataJSON  new_value)
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = true;
        storeNativeData = new_value;
      }
    public void unsetNativeData()
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = false;
      }
    public void setEventsConflictResult(DynamicResponseJSON  new_value)
      {
        if (flagHasEventsConflictResult)
          {
          }
        flagHasEventsConflictResult = true;
        storeEventsConflictResult = new_value;
      }
    public void unsetEventsConflictResult()
      {
        if (flagHasEventsConflictResult)
          {
          }
        flagHasEventsConflictResult = false;
      }
    public void setCalendarPreferenceIsNotSetResult(DynamicResponseJSON  new_value)
      {
        if (flagHasCalendarPreferenceIsNotSetResult)
          {
          }
        flagHasCalendarPreferenceIsNotSetResult = true;
        storeCalendarPreferenceIsNotSetResult = new_value;
      }
    public void unsetCalendarPreferenceIsNotSetResult()
      {
        if (flagHasCalendarPreferenceIsNotSetResult)
          {
          }
        flagHasCalendarPreferenceIsNotSetResult = false;
      }
    public void setNoMatchResult(DynamicResponseJSON  new_value)
      {
        if (flagHasNoMatchResult)
          {
          }
        flagHasNoMatchResult = true;
        storeNoMatchResult = new_value;
      }
    public void unsetNoMatchResult()
      {
        if (flagHasNoMatchResult)
          {
          }
        flagHasNoMatchResult = false;
      }

    public virtual void extraModifyCalendarItemCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraModifyCalendarItemCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraModifyCalendarItemCommandLookup(key);
        if (old_field == null)
          {
            extraModifyCalendarItemCommandAppendPair(key, new_component);
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
    public override void extraCalendarCommandAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                switch (key[1])
                  {
                    case 'd':
                        if ((String.Compare(key, 2, "dEventFields", 0, 12, false) == 0) && (key.Length == 14))
                            {
                            fromJSONAddEventFields(new_component, false);
                            return;
                            }
                        break;
                    case 'p':
                        if ((String.Compare(key, 2, "pendEventFields", 0, 15, false) == 0) && (key.Length == 17))
                            {
                            fromJSONAppendEventFields(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                if ((String.Compare(key, 1, "alendarPreferenceIsNotSetResult", 0, 31, false) == 0) && (key.Length == 32))
                    {
                    fromJSONCalendarPreferenceIsNotSetResult(new_component, false);
                    return;
                    }
                break;
            case 'E':
                switch (key[1])
                  {
                    case 'n':
                        if (String.Compare(key, 2, "dDelta", 0, 6, false) == 0)
                          {
                            switch (key[8])
                              {
                                case 'D':
                                    if ((String.Compare(key, 9, "ays", 0, 3, false) == 0) && (key.Length == 12))
                                        {
                                        fromJSONEndDeltaDays(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'M':
                                    if ((String.Compare(key, 9, "onths", 0, 5, false) == 0) && (key.Length == 14))
                                        {
                                        fromJSONEndDeltaMonths(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'S':
                                    if ((String.Compare(key, 9, "econds", 0, 6, false) == 0) && (key.Length == 15))
                                        {
                                        fromJSONEndDeltaSeconds(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'v':
                        if (String.Compare(key, 2, "ent", 0, 3, false) == 0)
                          {
                            switch (key[5])
                              {
                                case 'I':
                                    if ((String.Compare(key, 6, "Ds", 0, 2, false) == 0) && (key.Length == 8))
                                        {
                                        fromJSONEventIDs(new_component, false);
                                        return;
                                        }
                                    break;
                                case 's':
                                    if ((String.Compare(key, 6, "ConflictResult", 0, 14, false) == 0) && (key.Length == 20))
                                        {
                                        fromJSONEventsConflictResult(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'N':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "tiveData", 0, 8, false) == 0) && (key.Length == 10))
                            {
                            fromJSONNativeData(new_component, false);
                            return;
                            }
                        break;
                    case 'e':
                        if (String.Compare(key, 2, "w", 0, 1, false) == 0)
                          {
                            switch (key[3])
                              {
                                case 'E':
                                    if ((String.Compare(key, 4, "nd", 0, 2, false) == 0) && (key.Length == 6))
                                        {
                                        fromJSONNewEnd(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'F':
                                    if (String.Compare(key, 4, "requency", 0, 8, false) == 0)
                                      {
                                        switch (key[12])
                                          {
                                            case 'M':
                                                if ((String.Compare(key, 13, "ultiplier", 0, 9, false) == 0) && (key.Length == 22))
                                                    {
                                                    fromJSONNewFrequencyMultiplier(new_component, false);
                                                    return;
                                                    }
                                                break;
                                            case 'T':
                                                if ((String.Compare(key, 13, "ype", 0, 3, false) == 0) && (key.Length == 16))
                                                    {
                                                    fromJSONNewFrequencyType(new_component, false);
                                                    return;
                                                    }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'I':
                                    if ((String.Compare(key, 4, "temType", 0, 7, false) == 0) && (key.Length == 11))
                                        {
                                        fromJSONNewItemType(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'L':
                                    if ((String.Compare(key, 4, "ocation", 0, 7, false) == 0) && (key.Length == 11))
                                        {
                                        fromJSONNewLocation(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'S':
                                    if ((String.Compare(key, 4, "tart", 0, 4, false) == 0) && (key.Length == 8))
                                        {
                                        fromJSONNewStart(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'T':
                                    if ((String.Compare(key, 4, "itle", 0, 4, false) == 0) && (key.Length == 8))
                                        {
                                        fromJSONNewTitle(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'o':
                        if ((String.Compare(key, 2, "MatchResult", 0, 11, false) == 0) && (key.Length == 13))
                            {
                            fromJSONNoMatchResult(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'Q':
                if ((String.Compare(key, 1, "uery", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONQuery(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "emoveEventFields", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONRemoveEventFields(new_component, false);
                    return;
                    }
                break;
            case 'S':
                switch (key[1])
                  {
                    case 'e':
                        if ((String.Compare(key, 2, "tEventFields", 0, 12, false) == 0) && (key.Length == 14))
                            {
                            fromJSONSetEventFields(new_component, false);
                            return;
                            }
                        break;
                    case 't':
                        if (String.Compare(key, 2, "artDelta", 0, 8, false) == 0)
                          {
                            switch (key[10])
                              {
                                case 'D':
                                    if ((String.Compare(key, 11, "ays", 0, 3, false) == 0) && (key.Length == 14))
                                        {
                                        fromJSONStartDeltaDays(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'M':
                                    if ((String.Compare(key, 11, "onths", 0, 5, false) == 0) && (key.Length == 16))
                                        {
                                        fromJSONStartDeltaMonths(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'S':
                                    if ((String.Compare(key, 11, "econds", 0, 6, false) == 0) && (key.Length == 17))
                                        {
                                        fromJSONStartDeltaSeconds(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        extraModifyCalendarItemCommandAppendPair(key, new_component);
      }
    public override void extraCalendarCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                switch (key[1])
                  {
                    case 'd':
                        if ((String.Compare(key, 2, "dEventFields", 0, 12, false) == 0) && (key.Length == 14))
                            {
                            fromJSONAddEventFields(new_component, false);
                            return;
                            }
                        break;
                    case 'p':
                        if ((String.Compare(key, 2, "pendEventFields", 0, 15, false) == 0) && (key.Length == 17))
                            {
                            fromJSONAppendEventFields(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                if ((String.Compare(key, 1, "alendarPreferenceIsNotSetResult", 0, 31, false) == 0) && (key.Length == 32))
                    {
                    fromJSONCalendarPreferenceIsNotSetResult(new_component, false);
                    return;
                    }
                break;
            case 'E':
                switch (key[1])
                  {
                    case 'n':
                        if (String.Compare(key, 2, "dDelta", 0, 6, false) == 0)
                          {
                            switch (key[8])
                              {
                                case 'D':
                                    if ((String.Compare(key, 9, "ays", 0, 3, false) == 0) && (key.Length == 12))
                                        {
                                        fromJSONEndDeltaDays(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'M':
                                    if ((String.Compare(key, 9, "onths", 0, 5, false) == 0) && (key.Length == 14))
                                        {
                                        fromJSONEndDeltaMonths(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'S':
                                    if ((String.Compare(key, 9, "econds", 0, 6, false) == 0) && (key.Length == 15))
                                        {
                                        fromJSONEndDeltaSeconds(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'v':
                        if (String.Compare(key, 2, "ent", 0, 3, false) == 0)
                          {
                            switch (key[5])
                              {
                                case 'I':
                                    if ((String.Compare(key, 6, "Ds", 0, 2, false) == 0) && (key.Length == 8))
                                        {
                                        fromJSONEventIDs(new_component, false);
                                        return;
                                        }
                                    break;
                                case 's':
                                    if ((String.Compare(key, 6, "ConflictResult", 0, 14, false) == 0) && (key.Length == 20))
                                        {
                                        fromJSONEventsConflictResult(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'N':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "tiveData", 0, 8, false) == 0) && (key.Length == 10))
                            {
                            fromJSONNativeData(new_component, false);
                            return;
                            }
                        break;
                    case 'e':
                        if (String.Compare(key, 2, "w", 0, 1, false) == 0)
                          {
                            switch (key[3])
                              {
                                case 'E':
                                    if ((String.Compare(key, 4, "nd", 0, 2, false) == 0) && (key.Length == 6))
                                        {
                                        fromJSONNewEnd(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'F':
                                    if (String.Compare(key, 4, "requency", 0, 8, false) == 0)
                                      {
                                        switch (key[12])
                                          {
                                            case 'M':
                                                if ((String.Compare(key, 13, "ultiplier", 0, 9, false) == 0) && (key.Length == 22))
                                                    {
                                                    fromJSONNewFrequencyMultiplier(new_component, false);
                                                    return;
                                                    }
                                                break;
                                            case 'T':
                                                if ((String.Compare(key, 13, "ype", 0, 3, false) == 0) && (key.Length == 16))
                                                    {
                                                    fromJSONNewFrequencyType(new_component, false);
                                                    return;
                                                    }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'I':
                                    if ((String.Compare(key, 4, "temType", 0, 7, false) == 0) && (key.Length == 11))
                                        {
                                        fromJSONNewItemType(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'L':
                                    if ((String.Compare(key, 4, "ocation", 0, 7, false) == 0) && (key.Length == 11))
                                        {
                                        fromJSONNewLocation(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'S':
                                    if ((String.Compare(key, 4, "tart", 0, 4, false) == 0) && (key.Length == 8))
                                        {
                                        fromJSONNewStart(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'T':
                                    if ((String.Compare(key, 4, "itle", 0, 4, false) == 0) && (key.Length == 8))
                                        {
                                        fromJSONNewTitle(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'o':
                        if ((String.Compare(key, 2, "MatchResult", 0, 11, false) == 0) && (key.Length == 13))
                            {
                            fromJSONNoMatchResult(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'Q':
                if ((String.Compare(key, 1, "uery", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONQuery(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "emoveEventFields", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONRemoveEventFields(new_component, false);
                    return;
                    }
                break;
            case 'S':
                switch (key[1])
                  {
                    case 'e':
                        if ((String.Compare(key, 2, "tEventFields", 0, 12, false) == 0) && (key.Length == 14))
                            {
                            fromJSONSetEventFields(new_component, false);
                            return;
                            }
                        break;
                    case 't':
                        if (String.Compare(key, 2, "artDelta", 0, 8, false) == 0)
                          {
                            switch (key[10])
                              {
                                case 'D':
                                    if ((String.Compare(key, 11, "ays", 0, 3, false) == 0) && (key.Length == 14))
                                        {
                                        fromJSONStartDeltaDays(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'M':
                                    if ((String.Compare(key, 11, "onths", 0, 5, false) == 0) && (key.Length == 16))
                                        {
                                        fromJSONStartDeltaMonths(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'S':
                                    if ((String.Compare(key, 11, "econds", 0, 6, false) == 0) && (key.Length == 17))
                                        {
                                        fromJSONStartDeltaSeconds(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        extraModifyCalendarItemCommandSetField(key, new_component);
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
        if (flagHasEventIDs)
          {
            handler.start_pair("EventIDs");
            Debug.Assert(storeEventIDs.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeEventIDs.Count; ++num1)
              {
                handler.string_value(storeEventIDs[num1]);
              }
            handler.finish_array();
          }
        if (flagHasQuery)
          {
            handler.start_pair("Query");
            if (partial_allowed)
                storeQuery.write_partial_as_json(handler);
            else
                storeQuery.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasNewItemType);
        if (flagHasNewItemType)
          {
            handler.start_pair("NewItemType");
            handler.string_value(storeNewItemType);
          }
        Debug.Assert(partial_allowed || flagHasNewTitle);
        if (flagHasNewTitle)
          {
            handler.start_pair("NewTitle");
            handler.string_value(storeNewTitle);
          }
        Debug.Assert(partial_allowed || flagHasNewLocation);
        if (flagHasNewLocation)
          {
            handler.start_pair("NewLocation");
            handler.string_value(storeNewLocation);
          }
        Debug.Assert(partial_allowed || flagHasNewStart);
        if (flagHasNewStart)
          {
            handler.start_pair("NewStart");
            if (partial_allowed)
                storeNewStart.write_partial_as_json(handler);
            else
                storeNewStart.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasStartDeltaSeconds);
        if (flagHasStartDeltaSeconds)
          {
            handler.start_pair("StartDeltaSeconds");
            if (textStoreStartDeltaSeconds != "")
                handler.number_value(textStoreStartDeltaSeconds);
            else if (((double)(long)storeStartDeltaSeconds) == storeStartDeltaSeconds)
                handler.number_value((long)storeStartDeltaSeconds);
            else
                handler.number_value(storeStartDeltaSeconds);
          }
        Debug.Assert(partial_allowed || flagHasStartDeltaDays);
        if (flagHasStartDeltaDays)
          {
            handler.start_pair("StartDeltaDays");
            handler.number_value(storeStartDeltaDays);
          }
        Debug.Assert(partial_allowed || flagHasStartDeltaMonths);
        if (flagHasStartDeltaMonths)
          {
            handler.start_pair("StartDeltaMonths");
            handler.number_value(storeStartDeltaMonths);
          }
        Debug.Assert(partial_allowed || flagHasNewEnd);
        if (flagHasNewEnd)
          {
            handler.start_pair("NewEnd");
            if (partial_allowed)
                storeNewEnd.write_partial_as_json(handler);
            else
                storeNewEnd.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasEndDeltaSeconds);
        if (flagHasEndDeltaSeconds)
          {
            handler.start_pair("EndDeltaSeconds");
            if (textStoreEndDeltaSeconds != "")
                handler.number_value(textStoreEndDeltaSeconds);
            else if (((double)(long)storeEndDeltaSeconds) == storeEndDeltaSeconds)
                handler.number_value((long)storeEndDeltaSeconds);
            else
                handler.number_value(storeEndDeltaSeconds);
          }
        Debug.Assert(partial_allowed || flagHasEndDeltaDays);
        if (flagHasEndDeltaDays)
          {
            handler.start_pair("EndDeltaDays");
            handler.number_value(storeEndDeltaDays);
          }
        Debug.Assert(partial_allowed || flagHasEndDeltaMonths);
        if (flagHasEndDeltaMonths)
          {
            handler.start_pair("EndDeltaMonths");
            handler.number_value(storeEndDeltaMonths);
          }
        Debug.Assert(partial_allowed || flagHasNewFrequencyType);
        if (flagHasNewFrequencyType)
          {
            handler.start_pair("NewFrequencyType");
            switch (storeNewFrequencyType)
              {
                case TypeNewFrequencyType.NewFrequencyType_unknown:
                    handler.string_value("unknown");
                    break;
                case TypeNewFrequencyType.NewFrequencyType_one_time:
                    handler.string_value("one-time");
                    break;
                case TypeNewFrequencyType.NewFrequencyType_daily:
                    handler.string_value("daily");
                    break;
                case TypeNewFrequencyType.NewFrequencyType_weekly:
                    handler.string_value("weekly");
                    break;
                case TypeNewFrequencyType.NewFrequencyType_monthly:
                    handler.string_value("monthly");
                    break;
                case TypeNewFrequencyType.NewFrequencyType_yearly:
                    handler.string_value("yearly");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasNewFrequencyMultiplier);
        if (flagHasNewFrequencyMultiplier)
          {
            handler.start_pair("NewFrequencyMultiplier");
            handler.number_value(storeNewFrequencyMultiplier);
          }
        if (flagHasSetEventFields)
          {
            handler.start_pair("SetEventFields");
            handler.start_array();
            for (int num2 = 0; num2 < storeSetEventFields.Count; ++num2)
              {
                if (partial_allowed)
                    storeSetEventFields[num2].write_partial_as_json(handler);
                else
                    storeSetEventFields[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasAppendEventFields)
          {
            handler.start_pair("AppendEventFields");
            handler.start_array();
            for (int num3 = 0; num3 < storeAppendEventFields.Count; ++num3)
              {
                if (partial_allowed)
                    storeAppendEventFields[num3].write_partial_as_json(handler);
                else
                    storeAppendEventFields[num3].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasRemoveEventFields)
          {
            handler.start_pair("RemoveEventFields");
            handler.start_array();
            for (int num4 = 0; num4 < storeRemoveEventFields.Count; ++num4)
              {
                handler.string_value(storeRemoveEventFields[num4]);
              }
            handler.finish_array();
          }
        if (flagHasAddEventFields)
          {
            handler.start_pair("AddEventFields");
            handler.start_array();
            for (int num5 = 0; num5 < storeAddEventFields.Count; ++num5)
              {
                if (partial_allowed)
                    storeAddEventFields[num5].write_partial_as_json(handler);
                else
                    storeAddEventFields[num5].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasNativeData)
          {
            handler.start_pair("NativeData");
            if (partial_allowed)
                storeNativeData.write_partial_as_json(handler);
            else
                storeNativeData.write_as_json(handler);
          }
        if (flagHasEventsConflictResult)
          {
            handler.start_pair("EventsConflictResult");
            if (partial_allowed)
                storeEventsConflictResult.write_partial_as_json(handler);
            else
                storeEventsConflictResult.write_as_json(handler);
          }
        if (flagHasCalendarPreferenceIsNotSetResult)
          {
            handler.start_pair("CalendarPreferenceIsNotSetResult");
            if (partial_allowed)
                storeCalendarPreferenceIsNotSetResult.write_partial_as_json(handler);
            else
                storeCalendarPreferenceIsNotSetResult.write_as_json(handler);
          }
        if (flagHasNoMatchResult)
          {
            handler.start_pair("NoMatchResult");
            if (partial_allowed)
                storeNoMatchResult.write_partial_as_json(handler);
            else
                storeNoMatchResult.write_as_json(handler);
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
        if (!(hasNewItemType()))
          {
            return "When parsing the object for %what%, the \"NewItemType\" field was missing.";
          }
        if (!(hasNewTitle()))
          {
            return "When parsing the object for %what%, the \"NewTitle\" field was missing.";
          }
        if (!(hasNewLocation()))
          {
            return "When parsing the object for %what%, the \"NewLocation\" field was missing.";
          }
        if (!(hasNewStart()))
          {
            return "When parsing the object for %what%, the \"NewStart\" field was missing.";
          }
        if (!(hasStartDeltaSeconds()))
          {
            return "When parsing the object for %what%, the \"StartDeltaSeconds\" field was missing.";
          }
        if (!(hasStartDeltaDays()))
          {
            return "When parsing the object for %what%, the \"StartDeltaDays\" field was missing.";
          }
        if (!(hasStartDeltaMonths()))
          {
            return "When parsing the object for %what%, the \"StartDeltaMonths\" field was missing.";
          }
        if (!(hasNewEnd()))
          {
            return "When parsing the object for %what%, the \"NewEnd\" field was missing.";
          }
        if (!(hasEndDeltaSeconds()))
          {
            return "When parsing the object for %what%, the \"EndDeltaSeconds\" field was missing.";
          }
        if (!(hasEndDeltaDays()))
          {
            return "When parsing the object for %what%, the \"EndDeltaDays\" field was missing.";
          }
        if (!(hasEndDeltaMonths()))
          {
            return "When parsing the object for %what%, the \"EndDeltaMonths\" field was missing.";
          }
        if (!(hasNewFrequencyType()))
          {
            return "When parsing the object for %what%, the \"NewFrequencyType\" field was missing.";
          }
        if (!(hasNewFrequencyMultiplier()))
          {
            return "When parsing the object for %what%, the \"NewFrequencyMultiplier\" field was missing.";
          }
        return null;
      }

    public static new ModifyCalendarItemCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ModifyCalendarItemCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ModifyCalendarItemCommand", ignore_extras);
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
    public static new ModifyCalendarItemCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ModifyCalendarItemCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ModifyCalendarItemCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ModifyCalendarItemCommand", ignore_extras);
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
    public static new ModifyCalendarItemCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ModifyCalendarItemCommandJSON from_text(string text, bool ignore_extras)
      {
        ModifyCalendarItemCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ModifyCalendarItemCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ModifyCalendarItemCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ModifyCalendarItemCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ModifyCalendarItemCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ModifyCalendarItemCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CalendarCommandJSON.Generator
      {
        private JSONHoldingStringArrayGenerator fieldGeneratorEventIDs;
        private CalendarQueryJSON.HoldingGenerator fieldGeneratorQuery;
        private JSONHoldingStringGenerator fieldGeneratorNewItemType;
        private JSONHoldingStringGenerator fieldGeneratorNewTitle;
        private JSONHoldingStringGenerator fieldGeneratorNewLocation;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorNewStart;
        private JSONHoldingNumberTextGenerator fieldGeneratorStartDeltaSeconds;
    private class FieldHoldingGeneratorStartDeltaDays : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorStartDeltaDays(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorStartDeltaDays : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorStartDeltaDays(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorStartDeltaDays fieldGeneratorStartDeltaDays;
    private class FieldHoldingGeneratorStartDeltaMonths : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorStartDeltaMonths(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorStartDeltaMonths : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorStartDeltaMonths(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorStartDeltaMonths fieldGeneratorStartDeltaMonths;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorNewEnd;
        private JSONHoldingNumberTextGenerator fieldGeneratorEndDeltaSeconds;
    private class FieldHoldingGeneratorEndDeltaDays : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorEndDeltaDays(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorEndDeltaDays : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorEndDeltaDays(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorEndDeltaDays fieldGeneratorEndDeltaDays;
    private class FieldHoldingGeneratorEndDeltaMonths : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorEndDeltaMonths(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorEndDeltaMonths : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorEndDeltaMonths(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorEndDeltaMonths fieldGeneratorEndDeltaMonths;
    private abstract class FieldGeneratorNewFrequencyType : JSONStringGenerator
          {
            protected FieldGeneratorNewFrequencyType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorNewFrequencyType()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToNewFrequencyType(result));
              }
            protected abstract void handle_result(TypeNewFrequencyType result);
          };
    private class FieldHoldingGeneratorNewFrequencyType : FieldGeneratorNewFrequencyType
  {
    protected override void handle_result(TypeNewFrequencyType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorNewFrequencyType(String what)
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
    public TypeNewFrequencyType value;
  };
    private class FieldHoldingArrayGeneratorNewFrequencyType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorNewFrequencyType
      {
        private FieldHoldingArrayGeneratorNewFrequencyType top;

        protected override void handle_result(TypeNewFrequencyType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorNewFrequencyType init_top)
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
    protected virtual void handle_result(List<TypeNewFrequencyType> result)
      {
      }

    public FieldHoldingArrayGeneratorNewFrequencyType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeNewFrequencyType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorNewFrequencyType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeNewFrequencyType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeNewFrequencyType> value;
  };
        private FieldHoldingGeneratorNewFrequencyType fieldGeneratorNewFrequencyType;
    private class FieldHoldingGeneratorNewFrequencyMultiplier : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorNewFrequencyMultiplier(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorNewFrequencyMultiplier : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorNewFrequencyMultiplier(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorNewFrequencyMultiplier fieldGeneratorNewFrequencyMultiplier;
        private TypeSetEventFieldsJSON.HoldingArrayGenerator fieldGeneratorSetEventFields;
        private TypeAppendEventFieldsJSON.HoldingArrayGenerator fieldGeneratorAppendEventFields;
        private JSONHoldingStringArrayGenerator fieldGeneratorRemoveEventFields;
        private TypeAddEventFieldsJSON.HoldingArrayGenerator fieldGeneratorAddEventFields;
        private TypeNativeDataJSON.HoldingGenerator fieldGeneratorNativeData;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorEventsConflictResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorCalendarPreferenceIsNotSetResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorNoMatchResult;
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
            if (!(getCalendarCommandJSONKey().Equals("ModifyItem")))
                throw new Exception("The key field has a value other than `ModifyItem'.");
            ModifyCalendarItemCommandJSON result = new ModifyCalendarItemCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraModifyCalendarItemCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CalendarCommandJSON new_result)
          {
            handle_result((ModifyCalendarItemCommandJSON )new_result);
          }
        protected void finish(ModifyCalendarItemCommandJSON result)
          {
            if (fieldGeneratorEventIDs.have_value)
              {
                result.initEventIDs();
                int count = fieldGeneratorEventIDs.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendEventIDs(fieldGeneratorEventIDs.value[num]);
                  }
                fieldGeneratorEventIDs.value.Clear();
                fieldGeneratorEventIDs.have_value = false;
              }
            if (fieldGeneratorQuery.have_value)
              {
                result.setQuery(fieldGeneratorQuery.value);
                fieldGeneratorQuery.have_value = false;
              }
            if (fieldGeneratorNewItemType.have_value)
              {
                result.setNewItemType(fieldGeneratorNewItemType.value);
                fieldGeneratorNewItemType.have_value = false;
              }
            else if ((!(result.hasNewItemType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NewItemType\" field was missing.");
              }
            if (fieldGeneratorNewTitle.have_value)
              {
                result.setNewTitle(fieldGeneratorNewTitle.value);
                fieldGeneratorNewTitle.have_value = false;
              }
            else if ((!(result.hasNewTitle())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NewTitle\" field was missing.");
              }
            if (fieldGeneratorNewLocation.have_value)
              {
                result.setNewLocation(fieldGeneratorNewLocation.value);
                fieldGeneratorNewLocation.have_value = false;
              }
            else if ((!(result.hasNewLocation())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NewLocation\" field was missing.");
              }
            if (fieldGeneratorNewStart.have_value)
              {
                result.setNewStart(fieldGeneratorNewStart.value);
                fieldGeneratorNewStart.have_value = false;
              }
            else if ((!(result.hasNewStart())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NewStart\" field was missing.");
              }
            if (fieldGeneratorStartDeltaSeconds.have_value)
              {
                result.setStartDeltaSecondsText(fieldGeneratorStartDeltaSeconds.value);
                fieldGeneratorStartDeltaSeconds.have_value = false;
              }
            else if ((!(result.hasStartDeltaSeconds())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StartDeltaSeconds\" field was missing.");
              }
            if (fieldGeneratorStartDeltaDays.have_value)
              {
                result.setStartDeltaDays(fieldGeneratorStartDeltaDays.value);
                fieldGeneratorStartDeltaDays.have_value = false;
              }
            else if ((!(result.hasStartDeltaDays())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StartDeltaDays\" field was missing.");
              }
            if (fieldGeneratorStartDeltaMonths.have_value)
              {
                result.setStartDeltaMonths(fieldGeneratorStartDeltaMonths.value);
                fieldGeneratorStartDeltaMonths.have_value = false;
              }
            else if ((!(result.hasStartDeltaMonths())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StartDeltaMonths\" field was missing.");
              }
            if (fieldGeneratorNewEnd.have_value)
              {
                result.setNewEnd(fieldGeneratorNewEnd.value);
                fieldGeneratorNewEnd.have_value = false;
              }
            else if ((!(result.hasNewEnd())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NewEnd\" field was missing.");
              }
            if (fieldGeneratorEndDeltaSeconds.have_value)
              {
                result.setEndDeltaSecondsText(fieldGeneratorEndDeltaSeconds.value);
                fieldGeneratorEndDeltaSeconds.have_value = false;
              }
            else if ((!(result.hasEndDeltaSeconds())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"EndDeltaSeconds\" field was missing.");
              }
            if (fieldGeneratorEndDeltaDays.have_value)
              {
                result.setEndDeltaDays(fieldGeneratorEndDeltaDays.value);
                fieldGeneratorEndDeltaDays.have_value = false;
              }
            else if ((!(result.hasEndDeltaDays())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"EndDeltaDays\" field was missing.");
              }
            if (fieldGeneratorEndDeltaMonths.have_value)
              {
                result.setEndDeltaMonths(fieldGeneratorEndDeltaMonths.value);
                fieldGeneratorEndDeltaMonths.have_value = false;
              }
            else if ((!(result.hasEndDeltaMonths())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"EndDeltaMonths\" field was missing.");
              }
            if (fieldGeneratorNewFrequencyType.have_value)
              {
                result.setNewFrequencyType(fieldGeneratorNewFrequencyType.value);
                fieldGeneratorNewFrequencyType.have_value = false;
              }
            else if ((!(result.hasNewFrequencyType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NewFrequencyType\" field was missing.");
              }
            if (fieldGeneratorNewFrequencyMultiplier.have_value)
              {
                result.setNewFrequencyMultiplier(fieldGeneratorNewFrequencyMultiplier.value);
                fieldGeneratorNewFrequencyMultiplier.have_value = false;
              }
            else if ((!(result.hasNewFrequencyMultiplier())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NewFrequencyMultiplier\" field was missing.");
              }
            if (fieldGeneratorSetEventFields.have_value)
              {
                result.initSetEventFields();
                int count = fieldGeneratorSetEventFields.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSetEventFields(fieldGeneratorSetEventFields.value[num]);
                  }
                fieldGeneratorSetEventFields.value.Clear();
                fieldGeneratorSetEventFields.have_value = false;
              }
            if (fieldGeneratorAppendEventFields.have_value)
              {
                result.initAppendEventFields();
                int count = fieldGeneratorAppendEventFields.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAppendEventFields(fieldGeneratorAppendEventFields.value[num]);
                  }
                fieldGeneratorAppendEventFields.value.Clear();
                fieldGeneratorAppendEventFields.have_value = false;
              }
            if (fieldGeneratorRemoveEventFields.have_value)
              {
                result.initRemoveEventFields();
                int count = fieldGeneratorRemoveEventFields.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRemoveEventFields(fieldGeneratorRemoveEventFields.value[num]);
                  }
                fieldGeneratorRemoveEventFields.value.Clear();
                fieldGeneratorRemoveEventFields.have_value = false;
              }
            if (fieldGeneratorAddEventFields.have_value)
              {
                result.initAddEventFields();
                int count = fieldGeneratorAddEventFields.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAddEventFields(fieldGeneratorAddEventFields.value[num]);
                  }
                fieldGeneratorAddEventFields.value.Clear();
                fieldGeneratorAddEventFields.have_value = false;
              }
            if (fieldGeneratorNativeData.have_value)
              {
                result.setNativeData(fieldGeneratorNativeData.value);
                fieldGeneratorNativeData.have_value = false;
              }
            if (fieldGeneratorEventsConflictResult.have_value)
              {
                result.setEventsConflictResult(fieldGeneratorEventsConflictResult.value);
                fieldGeneratorEventsConflictResult.have_value = false;
              }
            if (fieldGeneratorCalendarPreferenceIsNotSetResult.have_value)
              {
                result.setCalendarPreferenceIsNotSetResult(fieldGeneratorCalendarPreferenceIsNotSetResult.value);
                fieldGeneratorCalendarPreferenceIsNotSetResult.have_value = false;
              }
            if (fieldGeneratorNoMatchResult.have_value)
              {
                result.setNoMatchResult(fieldGeneratorNoMatchResult.value);
                fieldGeneratorNoMatchResult.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(ModifyCalendarItemCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'd':
                            if ((String.Compare(field_name, 2, "dEventFields", 0, 12, false) == 0) && (field_name.Length == 14))
                                return fieldGeneratorAddEventFields;
                            break;
                        case 'p':
                            if ((String.Compare(field_name, 2, "pendEventFields", 0, 15, false) == 0) && (field_name.Length == 17))
                                return fieldGeneratorAppendEventFields;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "alendarPreferenceIsNotSetResult", 0, 31, false) == 0) && (field_name.Length == 32))
                        return fieldGeneratorCalendarPreferenceIsNotSetResult;
                    break;
                case 'E':
                    switch (field_name[1])
                      {
                        case 'n':
                            if (String.Compare(field_name, 2, "dDelta", 0, 6, false) == 0)
                              {
                                switch (field_name[8])
                                  {
                                    case 'D':
                                        if ((String.Compare(field_name, 9, "ays", 0, 3, false) == 0) && (field_name.Length == 12))
                                            return fieldGeneratorEndDeltaDays;
                                        break;
                                    case 'M':
                                        if ((String.Compare(field_name, 9, "onths", 0, 5, false) == 0) && (field_name.Length == 14))
                                            return fieldGeneratorEndDeltaMonths;
                                        break;
                                    case 'S':
                                        if ((String.Compare(field_name, 9, "econds", 0, 6, false) == 0) && (field_name.Length == 15))
                                            return fieldGeneratorEndDeltaSeconds;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'v':
                            if (String.Compare(field_name, 2, "ent", 0, 3, false) == 0)
                              {
                                switch (field_name[5])
                                  {
                                    case 'I':
                                        if ((String.Compare(field_name, 6, "Ds", 0, 2, false) == 0) && (field_name.Length == 8))
                                            return fieldGeneratorEventIDs;
                                        break;
                                    case 's':
                                        if ((String.Compare(field_name, 6, "ConflictResult", 0, 14, false) == 0) && (field_name.Length == 20))
                                            return fieldGeneratorEventsConflictResult;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'N':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "tiveData", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorNativeData;
                            break;
                        case 'e':
                            if (String.Compare(field_name, 2, "w", 0, 1, false) == 0)
                              {
                                switch (field_name[3])
                                  {
                                    case 'E':
                                        if ((String.Compare(field_name, 4, "nd", 0, 2, false) == 0) && (field_name.Length == 6))
                                            return fieldGeneratorNewEnd;
                                        break;
                                    case 'F':
                                        if (String.Compare(field_name, 4, "requency", 0, 8, false) == 0)
                                          {
                                            switch (field_name[12])
                                              {
                                                case 'M':
                                                    if ((String.Compare(field_name, 13, "ultiplier", 0, 9, false) == 0) && (field_name.Length == 22))
                                                        return fieldGeneratorNewFrequencyMultiplier;
                                                    break;
                                                case 'T':
                                                    if ((String.Compare(field_name, 13, "ype", 0, 3, false) == 0) && (field_name.Length == 16))
                                                        return fieldGeneratorNewFrequencyType;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'I':
                                        if ((String.Compare(field_name, 4, "temType", 0, 7, false) == 0) && (field_name.Length == 11))
                                            return fieldGeneratorNewItemType;
                                        break;
                                    case 'L':
                                        if ((String.Compare(field_name, 4, "ocation", 0, 7, false) == 0) && (field_name.Length == 11))
                                            return fieldGeneratorNewLocation;
                                        break;
                                    case 'S':
                                        if ((String.Compare(field_name, 4, "tart", 0, 4, false) == 0) && (field_name.Length == 8))
                                            return fieldGeneratorNewStart;
                                        break;
                                    case 'T':
                                        if ((String.Compare(field_name, 4, "itle", 0, 4, false) == 0) && (field_name.Length == 8))
                                            return fieldGeneratorNewTitle;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "MatchResult", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorNoMatchResult;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "uery", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorQuery;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "emoveEventFields", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorRemoveEventFields;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "tEventFields", 0, 12, false) == 0) && (field_name.Length == 14))
                                return fieldGeneratorSetEventFields;
                            break;
                        case 't':
                            if (String.Compare(field_name, 2, "artDelta", 0, 8, false) == 0)
                              {
                                switch (field_name[10])
                                  {
                                    case 'D':
                                        if ((String.Compare(field_name, 11, "ays", 0, 3, false) == 0) && (field_name.Length == 14))
                                            return fieldGeneratorStartDeltaDays;
                                        break;
                                    case 'M':
                                        if ((String.Compare(field_name, 11, "onths", 0, 5, false) == 0) && (field_name.Length == 16))
                                            return fieldGeneratorStartDeltaMonths;
                                        break;
                                    case 'S':
                                        if ((String.Compare(field_name, 11, "econds", 0, 6, false) == 0) && (field_name.Length == 17))
                                            return fieldGeneratorStartDeltaSeconds;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorEventIDs = new JSONHoldingStringArrayGenerator("field \"EventIDs\" of the ModifyCalendarItemCommand class");
            fieldGeneratorQuery = new CalendarQueryJSON.HoldingGenerator("field \"Query\" of the ModifyCalendarItemCommand class", ignore_extras);
            fieldGeneratorNewItemType = new JSONHoldingStringGenerator("field \"NewItemType\" of the ModifyCalendarItemCommand class");
            fieldGeneratorNewTitle = new JSONHoldingStringGenerator("field \"NewTitle\" of the ModifyCalendarItemCommand class");
            fieldGeneratorNewLocation = new JSONHoldingStringGenerator("field \"NewLocation\" of the ModifyCalendarItemCommand class");
            fieldGeneratorNewStart = new DateAndOrTimeJSON.HoldingGenerator("field \"NewStart\" of the ModifyCalendarItemCommand class", ignore_extras);
            fieldGeneratorStartDeltaSeconds = new JSONHoldingNumberTextGenerator("field \"StartDeltaSeconds\" of the ModifyCalendarItemCommand class");
            fieldGeneratorStartDeltaDays = new FieldHoldingGeneratorStartDeltaDays("field \"StartDeltaDays\" of the ModifyCalendarItemCommand class");
            fieldGeneratorStartDeltaMonths = new FieldHoldingGeneratorStartDeltaMonths("field \"StartDeltaMonths\" of the ModifyCalendarItemCommand class");
            fieldGeneratorNewEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"NewEnd\" of the ModifyCalendarItemCommand class", ignore_extras);
            fieldGeneratorEndDeltaSeconds = new JSONHoldingNumberTextGenerator("field \"EndDeltaSeconds\" of the ModifyCalendarItemCommand class");
            fieldGeneratorEndDeltaDays = new FieldHoldingGeneratorEndDeltaDays("field \"EndDeltaDays\" of the ModifyCalendarItemCommand class");
            fieldGeneratorEndDeltaMonths = new FieldHoldingGeneratorEndDeltaMonths("field \"EndDeltaMonths\" of the ModifyCalendarItemCommand class");
            fieldGeneratorNewFrequencyType = new FieldHoldingGeneratorNewFrequencyType("field \"NewFrequencyType\" of the ModifyCalendarItemCommand class");
            fieldGeneratorNewFrequencyMultiplier = new FieldHoldingGeneratorNewFrequencyMultiplier("field \"NewFrequencyMultiplier\" of the ModifyCalendarItemCommand class");
            fieldGeneratorSetEventFields = new TypeSetEventFieldsJSON.HoldingArrayGenerator("field \"SetEventFields\" of the ModifyCalendarItemCommand class", ignore_extras);
            fieldGeneratorAppendEventFields = new TypeAppendEventFieldsJSON.HoldingArrayGenerator("field \"AppendEventFields\" of the ModifyCalendarItemCommand class", ignore_extras);
            fieldGeneratorRemoveEventFields = new JSONHoldingStringArrayGenerator("field \"RemoveEventFields\" of the ModifyCalendarItemCommand class");
            fieldGeneratorAddEventFields = new TypeAddEventFieldsJSON.HoldingArrayGenerator("field \"AddEventFields\" of the ModifyCalendarItemCommand class", ignore_extras);
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the ModifyCalendarItemCommand class", ignore_extras);
            fieldGeneratorEventsConflictResult = new DynamicResponseJSON.HoldingGenerator("field \"EventsConflictResult\" of the ModifyCalendarItemCommand class", ignore_extras);
            fieldGeneratorCalendarPreferenceIsNotSetResult = new DynamicResponseJSON.HoldingGenerator("field \"CalendarPreferenceIsNotSetResult\" of the ModifyCalendarItemCommand class", ignore_extras);
            fieldGeneratorNoMatchResult = new DynamicResponseJSON.HoldingGenerator("field \"NoMatchResult\" of the ModifyCalendarItemCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ModifyCalendarItemCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorEventIDs = new JSONHoldingStringArrayGenerator("field \"EventIDs\" of the ModifyCalendarItemCommand class");
            fieldGeneratorQuery = new CalendarQueryJSON.HoldingGenerator("field \"Query\" of the ModifyCalendarItemCommand class", false);
            fieldGeneratorNewItemType = new JSONHoldingStringGenerator("field \"NewItemType\" of the ModifyCalendarItemCommand class");
            fieldGeneratorNewTitle = new JSONHoldingStringGenerator("field \"NewTitle\" of the ModifyCalendarItemCommand class");
            fieldGeneratorNewLocation = new JSONHoldingStringGenerator("field \"NewLocation\" of the ModifyCalendarItemCommand class");
            fieldGeneratorNewStart = new DateAndOrTimeJSON.HoldingGenerator("field \"NewStart\" of the ModifyCalendarItemCommand class", false);
            fieldGeneratorStartDeltaSeconds = new JSONHoldingNumberTextGenerator("field \"StartDeltaSeconds\" of the ModifyCalendarItemCommand class");
            fieldGeneratorStartDeltaDays = new FieldHoldingGeneratorStartDeltaDays("field \"StartDeltaDays\" of the ModifyCalendarItemCommand class");
            fieldGeneratorStartDeltaMonths = new FieldHoldingGeneratorStartDeltaMonths("field \"StartDeltaMonths\" of the ModifyCalendarItemCommand class");
            fieldGeneratorNewEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"NewEnd\" of the ModifyCalendarItemCommand class", false);
            fieldGeneratorEndDeltaSeconds = new JSONHoldingNumberTextGenerator("field \"EndDeltaSeconds\" of the ModifyCalendarItemCommand class");
            fieldGeneratorEndDeltaDays = new FieldHoldingGeneratorEndDeltaDays("field \"EndDeltaDays\" of the ModifyCalendarItemCommand class");
            fieldGeneratorEndDeltaMonths = new FieldHoldingGeneratorEndDeltaMonths("field \"EndDeltaMonths\" of the ModifyCalendarItemCommand class");
            fieldGeneratorNewFrequencyType = new FieldHoldingGeneratorNewFrequencyType("field \"NewFrequencyType\" of the ModifyCalendarItemCommand class");
            fieldGeneratorNewFrequencyMultiplier = new FieldHoldingGeneratorNewFrequencyMultiplier("field \"NewFrequencyMultiplier\" of the ModifyCalendarItemCommand class");
            fieldGeneratorSetEventFields = new TypeSetEventFieldsJSON.HoldingArrayGenerator("field \"SetEventFields\" of the ModifyCalendarItemCommand class", false);
            fieldGeneratorAppendEventFields = new TypeAppendEventFieldsJSON.HoldingArrayGenerator("field \"AppendEventFields\" of the ModifyCalendarItemCommand class", false);
            fieldGeneratorRemoveEventFields = new JSONHoldingStringArrayGenerator("field \"RemoveEventFields\" of the ModifyCalendarItemCommand class");
            fieldGeneratorAddEventFields = new TypeAddEventFieldsJSON.HoldingArrayGenerator("field \"AddEventFields\" of the ModifyCalendarItemCommand class", false);
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the ModifyCalendarItemCommand class", false);
            fieldGeneratorEventsConflictResult = new DynamicResponseJSON.HoldingGenerator("field \"EventsConflictResult\" of the ModifyCalendarItemCommand class", false);
            fieldGeneratorCalendarPreferenceIsNotSetResult = new DynamicResponseJSON.HoldingGenerator("field \"CalendarPreferenceIsNotSetResult\" of the ModifyCalendarItemCommand class", false);
            fieldGeneratorNoMatchResult = new DynamicResponseJSON.HoldingGenerator("field \"NoMatchResult\" of the ModifyCalendarItemCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ModifyCalendarItemCommand class");
          }

        public override void reset()
          {
            fieldGeneratorEventIDs.reset();
            fieldGeneratorQuery.reset();
            fieldGeneratorNewItemType.reset();
            fieldGeneratorNewTitle.reset();
            fieldGeneratorNewLocation.reset();
            fieldGeneratorNewStart.reset();
            fieldGeneratorStartDeltaSeconds.reset();
            fieldGeneratorStartDeltaDays.reset();
            fieldGeneratorStartDeltaMonths.reset();
            fieldGeneratorNewEnd.reset();
            fieldGeneratorEndDeltaSeconds.reset();
            fieldGeneratorEndDeltaDays.reset();
            fieldGeneratorEndDeltaMonths.reset();
            fieldGeneratorNewFrequencyType.reset();
            fieldGeneratorNewFrequencyMultiplier.reset();
            fieldGeneratorSetEventFields.reset();
            fieldGeneratorAppendEventFields.reset();
            fieldGeneratorRemoveEventFields.reset();
            fieldGeneratorAddEventFields.reset();
            fieldGeneratorNativeData.reset();
            fieldGeneratorEventsConflictResult.reset();
            fieldGeneratorCalendarPreferenceIsNotSetResult.reset();
            fieldGeneratorNoMatchResult.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ModifyCalendarItemCommandJSON  result)
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
        public ModifyCalendarItemCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ModifyCalendarItemCommandJSON  result)
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
    protected virtual void handle_result(List<ModifyCalendarItemCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ModifyCalendarItemCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ModifyCalendarItemCommandJSON>();
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
    public List<ModifyCalendarItemCommandJSON> value;
  };
  };
