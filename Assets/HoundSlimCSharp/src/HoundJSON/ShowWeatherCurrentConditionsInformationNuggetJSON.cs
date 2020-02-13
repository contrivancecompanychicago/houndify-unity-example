/* file "ShowWeatherCurrentConditionsInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ShowWeatherCurrentConditionsInformationNuggetJSON : WeatherInformationNuggetJSON
  {
    public class TypeCurrentTemperatureJSON : JSONBase
      {
        private bool flagHasValue;
        private UnitsValue_TemperatureJSON  storeValue;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            UnitsValue_TemperatureJSON convert_classy = UnitsValue_TemperatureJSON.from_json(json_value, ignore_extras, true);
            setValue(convert_classy);
          }


        public TypeCurrentTemperatureJSON()
          {
            flagHasValue = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasValue()
          {
            return flagHasValue;
          }

        public UnitsValue_TemperatureJSON   getValue()
          {
            Debug.Assert(flagHasValue);
            return storeValue;
          }


        public virtual int extraTypeCurrentTemperatureComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeCurrentTemperatureComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeCurrentTemperatureComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeCurrentTemperatureLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setValue(UnitsValue_TemperatureJSON  new_value)
          {
            if (flagHasValue)
              {
              }
            flagHasValue = true;
            storeValue = new_value;
          }
        public void unsetValue()
          {
            if (flagHasValue)
              {
              }
            flagHasValue = false;
          }

        public virtual void extraTypeCurrentTemperatureAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeCurrentTemperatureSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeCurrentTemperatureLookup(key);
            if (old_field == null)
              {
                extraTypeCurrentTemperatureAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasValue);
            if (flagHasValue)
              {
                handler.start_pair("Value");
                if (partial_allowed)
                    storeValue.write_partial_as_json(handler);
                else
                    storeValue.write_as_json(handler);
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
            if (!(hasValue()))
              {
                return "When parsing the object for %what%, the \"Value\" field was missing.";
              }
            return null;
          }

        public static TypeCurrentTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeCurrentTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeCurrentTemperature", ignore_extras);
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
        public static TypeCurrentTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeCurrentTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeCurrentTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeCurrentTemperature", ignore_extras);
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
        public static TypeCurrentTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeCurrentTemperatureJSON from_text(string text, bool ignore_extras)
          {
            TypeCurrentTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeCurrentTemperature", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeCurrentTemperatureJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeCurrentTemperatureJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeCurrentTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeCurrentTemperature", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private UnitsValue_TemperatureJSON.HoldingGenerator fieldGeneratorValue;
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
                TypeCurrentTemperatureJSON result = new TypeCurrentTemperatureJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeCurrentTemperatureAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeCurrentTemperatureJSON result)
              {
                if (fieldGeneratorValue.have_value)
                  {
                    result.setValue(fieldGeneratorValue.value);
                    fieldGeneratorValue.have_value = false;
                  }
                else if ((!(result.hasValue())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Value\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeCurrentTemperatureJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeCurrentTemperature class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeCurrentTemperature class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeCurrentTemperature class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeCurrentTemperature class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorValue.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorValue.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorValue.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeCurrentTemperatureJSON  result)
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
            public TypeCurrentTemperatureJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeCurrentTemperatureJSON  result)
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
        protected virtual void handle_result(List<TypeCurrentTemperatureJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeCurrentTemperatureJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeCurrentTemperatureJSON>();
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
        public List<TypeCurrentTemperatureJSON> value;
      };
      };
    public class TypeFeelsLikeTemperatureJSON : JSONBase
      {
        private bool flagHasValue;
        private UnitsValue_TemperatureJSON  storeValue;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            UnitsValue_TemperatureJSON convert_classy = UnitsValue_TemperatureJSON.from_json(json_value, ignore_extras, true);
            setValue(convert_classy);
          }


        public TypeFeelsLikeTemperatureJSON()
          {
            flagHasValue = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasValue()
          {
            return flagHasValue;
          }

        public UnitsValue_TemperatureJSON   getValue()
          {
            Debug.Assert(flagHasValue);
            return storeValue;
          }


        public virtual int extraTypeFeelsLikeTemperatureComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeFeelsLikeTemperatureComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeFeelsLikeTemperatureComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeFeelsLikeTemperatureLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setValue(UnitsValue_TemperatureJSON  new_value)
          {
            if (flagHasValue)
              {
              }
            flagHasValue = true;
            storeValue = new_value;
          }
        public void unsetValue()
          {
            if (flagHasValue)
              {
              }
            flagHasValue = false;
          }

        public virtual void extraTypeFeelsLikeTemperatureAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeFeelsLikeTemperatureSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeFeelsLikeTemperatureLookup(key);
            if (old_field == null)
              {
                extraTypeFeelsLikeTemperatureAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasValue);
            if (flagHasValue)
              {
                handler.start_pair("Value");
                if (partial_allowed)
                    storeValue.write_partial_as_json(handler);
                else
                    storeValue.write_as_json(handler);
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
            if (!(hasValue()))
              {
                return "When parsing the object for %what%, the \"Value\" field was missing.";
              }
            return null;
          }

        public static TypeFeelsLikeTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeFeelsLikeTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeFeelsLikeTemperature", ignore_extras);
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
        public static TypeFeelsLikeTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeFeelsLikeTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeFeelsLikeTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeFeelsLikeTemperature", ignore_extras);
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
        public static TypeFeelsLikeTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeFeelsLikeTemperatureJSON from_text(string text, bool ignore_extras)
          {
            TypeFeelsLikeTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeFeelsLikeTemperature", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeFeelsLikeTemperatureJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeFeelsLikeTemperatureJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeFeelsLikeTemperatureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeFeelsLikeTemperature", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private UnitsValue_TemperatureJSON.HoldingGenerator fieldGeneratorValue;
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
                TypeFeelsLikeTemperatureJSON result = new TypeFeelsLikeTemperatureJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeFeelsLikeTemperatureAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeFeelsLikeTemperatureJSON result)
              {
                if (fieldGeneratorValue.have_value)
                  {
                    result.setValue(fieldGeneratorValue.value);
                    fieldGeneratorValue.have_value = false;
                  }
                else if ((!(result.hasValue())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Value\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeFeelsLikeTemperatureJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeFeelsLikeTemperature class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeFeelsLikeTemperature class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeFeelsLikeTemperature class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeFeelsLikeTemperature class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorValue.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorValue.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorValue.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeFeelsLikeTemperatureJSON  result)
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
            public TypeFeelsLikeTemperatureJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeFeelsLikeTemperatureJSON  result)
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
        protected virtual void handle_result(List<TypeFeelsLikeTemperatureJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeFeelsLikeTemperatureJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeFeelsLikeTemperatureJSON>();
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
        public List<TypeFeelsLikeTemperatureJSON> value;
      };
      };
    public class TypeHeatIndexJSON : JSONBase
      {
        private bool flagHasValue;
        private UnitsValue_TemperatureJSON  storeValue;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            UnitsValue_TemperatureJSON convert_classy = UnitsValue_TemperatureJSON.from_json(json_value, ignore_extras, true);
            setValue(convert_classy);
          }


        public TypeHeatIndexJSON()
          {
            flagHasValue = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasValue()
          {
            return flagHasValue;
          }

        public UnitsValue_TemperatureJSON   getValue()
          {
            Debug.Assert(flagHasValue);
            return storeValue;
          }


        public virtual int extraTypeHeatIndexComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeHeatIndexComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeHeatIndexComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeHeatIndexLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setValue(UnitsValue_TemperatureJSON  new_value)
          {
            if (flagHasValue)
              {
              }
            flagHasValue = true;
            storeValue = new_value;
          }
        public void unsetValue()
          {
            if (flagHasValue)
              {
              }
            flagHasValue = false;
          }

        public virtual void extraTypeHeatIndexAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeHeatIndexSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeHeatIndexLookup(key);
            if (old_field == null)
              {
                extraTypeHeatIndexAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasValue);
            if (flagHasValue)
              {
                handler.start_pair("Value");
                if (partial_allowed)
                    storeValue.write_partial_as_json(handler);
                else
                    storeValue.write_as_json(handler);
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
            if (!(hasValue()))
              {
                return "When parsing the object for %what%, the \"Value\" field was missing.";
              }
            return null;
          }

        public static TypeHeatIndexJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeHeatIndexJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHeatIndex", ignore_extras);
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
        public static TypeHeatIndexJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeHeatIndexJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeHeatIndexJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHeatIndex", ignore_extras);
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
        public static TypeHeatIndexJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeHeatIndexJSON from_text(string text, bool ignore_extras)
          {
            TypeHeatIndexJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHeatIndex", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeHeatIndexJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeHeatIndexJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeHeatIndexJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHeatIndex", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private UnitsValue_TemperatureJSON.HoldingGenerator fieldGeneratorValue;
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
                TypeHeatIndexJSON result = new TypeHeatIndexJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeHeatIndexAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeHeatIndexJSON result)
              {
                if (fieldGeneratorValue.have_value)
                  {
                    result.setValue(fieldGeneratorValue.value);
                    fieldGeneratorValue.have_value = false;
                  }
                else if ((!(result.hasValue())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Value\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeHeatIndexJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeHeatIndex class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeHeatIndex class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeHeatIndex class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeHeatIndex class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorValue.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorValue.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorValue.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeHeatIndexJSON  result)
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
            public TypeHeatIndexJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeHeatIndexJSON  result)
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
        protected virtual void handle_result(List<TypeHeatIndexJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeHeatIndexJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeHeatIndexJSON>();
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
        public List<TypeHeatIndexJSON> value;
      };
      };
    public class TypeWindchillJSON : JSONBase
      {
        private bool flagHasValue;
        private UnitsValue_TemperatureJSON  storeValue;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            UnitsValue_TemperatureJSON convert_classy = UnitsValue_TemperatureJSON.from_json(json_value, ignore_extras, true);
            setValue(convert_classy);
          }


        public TypeWindchillJSON()
          {
            flagHasValue = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasValue()
          {
            return flagHasValue;
          }

        public UnitsValue_TemperatureJSON   getValue()
          {
            Debug.Assert(flagHasValue);
            return storeValue;
          }


        public virtual int extraTypeWindchillComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeWindchillComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeWindchillComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeWindchillLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setValue(UnitsValue_TemperatureJSON  new_value)
          {
            if (flagHasValue)
              {
              }
            flagHasValue = true;
            storeValue = new_value;
          }
        public void unsetValue()
          {
            if (flagHasValue)
              {
              }
            flagHasValue = false;
          }

        public virtual void extraTypeWindchillAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeWindchillSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeWindchillLookup(key);
            if (old_field == null)
              {
                extraTypeWindchillAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasValue);
            if (flagHasValue)
              {
                handler.start_pair("Value");
                if (partial_allowed)
                    storeValue.write_partial_as_json(handler);
                else
                    storeValue.write_as_json(handler);
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
            if (!(hasValue()))
              {
                return "When parsing the object for %what%, the \"Value\" field was missing.";
              }
            return null;
          }

        public static TypeWindchillJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeWindchillJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeWindchill", ignore_extras);
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
        public static TypeWindchillJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeWindchillJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeWindchillJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeWindchill", ignore_extras);
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
        public static TypeWindchillJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeWindchillJSON from_text(string text, bool ignore_extras)
          {
            TypeWindchillJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeWindchill", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeWindchillJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeWindchillJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeWindchillJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeWindchill", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private UnitsValue_TemperatureJSON.HoldingGenerator fieldGeneratorValue;
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
                TypeWindchillJSON result = new TypeWindchillJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeWindchillAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeWindchillJSON result)
              {
                if (fieldGeneratorValue.have_value)
                  {
                    result.setValue(fieldGeneratorValue.value);
                    fieldGeneratorValue.have_value = false;
                  }
                else if ((!(result.hasValue())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Value\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeWindchillJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeWindchill class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeWindchill class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeWindchill class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeWindchill class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorValue.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorValue.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorValue.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeWindchillJSON  result)
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
            public TypeWindchillJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeWindchillJSON  result)
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
        protected virtual void handle_result(List<TypeWindchillJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeWindchillJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeWindchillJSON>();
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
        public List<TypeWindchillJSON> value;
      };
      };
    public class TypeDewPointJSON : JSONBase
      {
        private bool flagHasValue;
        private UnitsValue_TemperatureJSON  storeValue;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            UnitsValue_TemperatureJSON convert_classy = UnitsValue_TemperatureJSON.from_json(json_value, ignore_extras, true);
            setValue(convert_classy);
          }


        public TypeDewPointJSON()
          {
            flagHasValue = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasValue()
          {
            return flagHasValue;
          }

        public UnitsValue_TemperatureJSON   getValue()
          {
            Debug.Assert(flagHasValue);
            return storeValue;
          }


        public virtual int extraTypeDewPointComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeDewPointComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeDewPointComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeDewPointLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setValue(UnitsValue_TemperatureJSON  new_value)
          {
            if (flagHasValue)
              {
              }
            flagHasValue = true;
            storeValue = new_value;
          }
        public void unsetValue()
          {
            if (flagHasValue)
              {
              }
            flagHasValue = false;
          }

        public virtual void extraTypeDewPointAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeDewPointSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeDewPointLookup(key);
            if (old_field == null)
              {
                extraTypeDewPointAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasValue);
            if (flagHasValue)
              {
                handler.start_pair("Value");
                if (partial_allowed)
                    storeValue.write_partial_as_json(handler);
                else
                    storeValue.write_as_json(handler);
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
            if (!(hasValue()))
              {
                return "When parsing the object for %what%, the \"Value\" field was missing.";
              }
            return null;
          }

        public static TypeDewPointJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeDewPointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDewPoint", ignore_extras);
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
        public static TypeDewPointJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeDewPointJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeDewPointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDewPoint", ignore_extras);
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
        public static TypeDewPointJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeDewPointJSON from_text(string text, bool ignore_extras)
          {
            TypeDewPointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDewPoint", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeDewPointJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeDewPointJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeDewPointJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDewPoint", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private UnitsValue_TemperatureJSON.HoldingGenerator fieldGeneratorValue;
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
                TypeDewPointJSON result = new TypeDewPointJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeDewPointAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeDewPointJSON result)
              {
                if (fieldGeneratorValue.have_value)
                  {
                    result.setValue(fieldGeneratorValue.value);
                    fieldGeneratorValue.have_value = false;
                  }
                else if ((!(result.hasValue())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Value\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeDewPointJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeDewPoint class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeDewPoint class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_TemperatureJSON.HoldingGenerator("field \"Value\" of the TypeDewPoint class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeDewPoint class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorValue.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorValue.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorValue.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeDewPointJSON  result)
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
            public TypeDewPointJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeDewPointJSON  result)
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
        protected virtual void handle_result(List<TypeDewPointJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeDewPointJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeDewPointJSON>();
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
        public List<TypeDewPointJSON> value;
      };
      };
    public class TypeVisibilityJSON : JSONBase
      {
        private bool flagHasValue;
        private UnitsValue_VisibilityJSON  storeValue;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            UnitsValue_VisibilityJSON convert_classy = UnitsValue_VisibilityJSON.from_json(json_value, ignore_extras, true);
            setValue(convert_classy);
          }


        public TypeVisibilityJSON()
          {
            flagHasValue = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasValue()
          {
            return flagHasValue;
          }

        public UnitsValue_VisibilityJSON   getValue()
          {
            Debug.Assert(flagHasValue);
            return storeValue;
          }


        public virtual int extraTypeVisibilityComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeVisibilityComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeVisibilityComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeVisibilityLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setValue(UnitsValue_VisibilityJSON  new_value)
          {
            if (flagHasValue)
              {
              }
            flagHasValue = true;
            storeValue = new_value;
          }
        public void unsetValue()
          {
            if (flagHasValue)
              {
              }
            flagHasValue = false;
          }

        public virtual void extraTypeVisibilityAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeVisibilitySetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeVisibilityLookup(key);
            if (old_field == null)
              {
                extraTypeVisibilityAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasValue);
            if (flagHasValue)
              {
                handler.start_pair("Value");
                if (partial_allowed)
                    storeValue.write_partial_as_json(handler);
                else
                    storeValue.write_as_json(handler);
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
            if (!(hasValue()))
              {
                return "When parsing the object for %what%, the \"Value\" field was missing.";
              }
            return null;
          }

        public static TypeVisibilityJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeVisibilityJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeVisibility", ignore_extras);
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
        public static TypeVisibilityJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeVisibilityJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeVisibilityJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeVisibility", ignore_extras);
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
        public static TypeVisibilityJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeVisibilityJSON from_text(string text, bool ignore_extras)
          {
            TypeVisibilityJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeVisibility", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeVisibilityJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeVisibilityJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeVisibilityJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeVisibility", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private UnitsValue_VisibilityJSON.HoldingGenerator fieldGeneratorValue;
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
                TypeVisibilityJSON result = new TypeVisibilityJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeVisibilityAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeVisibilityJSON result)
              {
                if (fieldGeneratorValue.have_value)
                  {
                    result.setValue(fieldGeneratorValue.value);
                    fieldGeneratorValue.have_value = false;
                  }
                else if ((!(result.hasValue())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Value\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeVisibilityJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_VisibilityJSON.HoldingGenerator("field \"Value\" of the TypeVisibility class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeVisibility class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_VisibilityJSON.HoldingGenerator("field \"Value\" of the TypeVisibility class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeVisibility class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorValue.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorValue.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorValue.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeVisibilityJSON  result)
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
            public TypeVisibilityJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeVisibilityJSON  result)
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
        protected virtual void handle_result(List<TypeVisibilityJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeVisibilityJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeVisibilityJSON>();
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
        public List<TypeVisibilityJSON> value;
      };
      };
    public class TypePrecipitation1HourJSON : JSONBase
      {
        private bool flagHasValue;
        private UnitsValue_PrecipitationJSON  storeValue;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            UnitsValue_PrecipitationJSON convert_classy = UnitsValue_PrecipitationJSON.from_json(json_value, ignore_extras, true);
            setValue(convert_classy);
          }


        public TypePrecipitation1HourJSON()
          {
            flagHasValue = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasValue()
          {
            return flagHasValue;
          }

        public UnitsValue_PrecipitationJSON   getValue()
          {
            Debug.Assert(flagHasValue);
            return storeValue;
          }


        public virtual int extraTypePrecipitation1HourComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypePrecipitation1HourComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypePrecipitation1HourComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypePrecipitation1HourLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setValue(UnitsValue_PrecipitationJSON  new_value)
          {
            if (flagHasValue)
              {
              }
            flagHasValue = true;
            storeValue = new_value;
          }
        public void unsetValue()
          {
            if (flagHasValue)
              {
              }
            flagHasValue = false;
          }

        public virtual void extraTypePrecipitation1HourAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypePrecipitation1HourSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypePrecipitation1HourLookup(key);
            if (old_field == null)
              {
                extraTypePrecipitation1HourAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasValue);
            if (flagHasValue)
              {
                handler.start_pair("Value");
                if (partial_allowed)
                    storeValue.write_partial_as_json(handler);
                else
                    storeValue.write_as_json(handler);
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
            if (!(hasValue()))
              {
                return "When parsing the object for %what%, the \"Value\" field was missing.";
              }
            return null;
          }

        public static TypePrecipitation1HourJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePrecipitation1HourJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePrecipitation1Hour", ignore_extras);
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
        public static TypePrecipitation1HourJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePrecipitation1HourJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePrecipitation1HourJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePrecipitation1Hour", ignore_extras);
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
        public static TypePrecipitation1HourJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePrecipitation1HourJSON from_text(string text, bool ignore_extras)
          {
            TypePrecipitation1HourJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePrecipitation1Hour", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypePrecipitation1HourJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypePrecipitation1HourJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypePrecipitation1HourJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePrecipitation1Hour", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private UnitsValue_PrecipitationJSON.HoldingGenerator fieldGeneratorValue;
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
                TypePrecipitation1HourJSON result = new TypePrecipitation1HourJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypePrecipitation1HourAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypePrecipitation1HourJSON result)
              {
                if (fieldGeneratorValue.have_value)
                  {
                    result.setValue(fieldGeneratorValue.value);
                    fieldGeneratorValue.have_value = false;
                  }
                else if ((!(result.hasValue())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Value\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypePrecipitation1HourJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_PrecipitationJSON.HoldingGenerator("field \"Value\" of the TypePrecipitation1Hour class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypePrecipitation1Hour class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_PrecipitationJSON.HoldingGenerator("field \"Value\" of the TypePrecipitation1Hour class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypePrecipitation1Hour class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorValue.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorValue.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorValue.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypePrecipitation1HourJSON  result)
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
            public TypePrecipitation1HourJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypePrecipitation1HourJSON  result)
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
        protected virtual void handle_result(List<TypePrecipitation1HourJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypePrecipitation1HourJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypePrecipitation1HourJSON>();
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
        public List<TypePrecipitation1HourJSON> value;
      };
      };
    public class TypePrecipitationTodayJSON : JSONBase
      {
        private bool flagHasValue;
        private UnitsValue_PrecipitationJSON  storeValue;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            UnitsValue_PrecipitationJSON convert_classy = UnitsValue_PrecipitationJSON.from_json(json_value, ignore_extras, true);
            setValue(convert_classy);
          }


        public TypePrecipitationTodayJSON()
          {
            flagHasValue = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasValue()
          {
            return flagHasValue;
          }

        public UnitsValue_PrecipitationJSON   getValue()
          {
            Debug.Assert(flagHasValue);
            return storeValue;
          }


        public virtual int extraTypePrecipitationTodayComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypePrecipitationTodayComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypePrecipitationTodayComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypePrecipitationTodayLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setValue(UnitsValue_PrecipitationJSON  new_value)
          {
            if (flagHasValue)
              {
              }
            flagHasValue = true;
            storeValue = new_value;
          }
        public void unsetValue()
          {
            if (flagHasValue)
              {
              }
            flagHasValue = false;
          }

        public virtual void extraTypePrecipitationTodayAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypePrecipitationTodaySetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypePrecipitationTodayLookup(key);
            if (old_field == null)
              {
                extraTypePrecipitationTodayAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasValue);
            if (flagHasValue)
              {
                handler.start_pair("Value");
                if (partial_allowed)
                    storeValue.write_partial_as_json(handler);
                else
                    storeValue.write_as_json(handler);
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
            if (!(hasValue()))
              {
                return "When parsing the object for %what%, the \"Value\" field was missing.";
              }
            return null;
          }

        public static TypePrecipitationTodayJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePrecipitationTodayJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePrecipitationToday", ignore_extras);
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
        public static TypePrecipitationTodayJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePrecipitationTodayJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePrecipitationTodayJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePrecipitationToday", ignore_extras);
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
        public static TypePrecipitationTodayJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePrecipitationTodayJSON from_text(string text, bool ignore_extras)
          {
            TypePrecipitationTodayJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePrecipitationToday", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypePrecipitationTodayJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypePrecipitationTodayJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypePrecipitationTodayJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePrecipitationToday", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private UnitsValue_PrecipitationJSON.HoldingGenerator fieldGeneratorValue;
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
                TypePrecipitationTodayJSON result = new TypePrecipitationTodayJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypePrecipitationTodayAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypePrecipitationTodayJSON result)
              {
                if (fieldGeneratorValue.have_value)
                  {
                    result.setValue(fieldGeneratorValue.value);
                    fieldGeneratorValue.have_value = false;
                  }
                else if ((!(result.hasValue())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Value\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypePrecipitationTodayJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_PrecipitationJSON.HoldingGenerator("field \"Value\" of the TypePrecipitationToday class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypePrecipitationToday class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_PrecipitationJSON.HoldingGenerator("field \"Value\" of the TypePrecipitationToday class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypePrecipitationToday class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorValue.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorValue.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorValue.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypePrecipitationTodayJSON  result)
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
            public TypePrecipitationTodayJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypePrecipitationTodayJSON  result)
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
        protected virtual void handle_result(List<TypePrecipitationTodayJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypePrecipitationTodayJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypePrecipitationTodayJSON>();
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
        public List<TypePrecipitationTodayJSON> value;
      };
      };
    public class TypeWindJSON : JSONBase
      {
        private bool flagHasValue;
        private UnitsValue_WindJSON  storeValue;
        private bool flagHasDirectionAbbreviation;
        private string storeDirectionAbbreviation;
        private bool flagHasDirectionText;
        private string storeDirectionText;
        private bool flagHasDirectionDegrees;
        private short storeDirectionDegrees;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            UnitsValue_WindJSON convert_classy = UnitsValue_WindJSON.from_json(json_value, ignore_extras, true);
            setValue(convert_classy);
          }


        private void  fromJSONDirectionAbbreviation(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field DirectionAbbreviation of TypeWindJSON is not a string.");
            setDirectionAbbreviation(json_string.getData());
          }


        private void  fromJSONDirectionText(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field DirectionText of TypeWindJSON is not a string.");
            setDirectionText(json_string.getData());
          }


        private void  fromJSONDirectionDegrees(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            short extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field DirectionDegrees of TypeWindJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field DirectionDegrees of TypeWindJSON is not an integer.");
                  }
                extracted_integer = (short)(json_rational.getLongInt())            ;
              }
            else
              {
                extracted_integer = (short)(json_integer.getLongInt())            ;
              }
            setDirectionDegrees(extracted_integer);
          }


        public TypeWindJSON()
          {
            flagHasValue = false;
            flagHasDirectionAbbreviation = false;
            flagHasDirectionText = false;
            flagHasDirectionDegrees = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasValue()
          {
            return flagHasValue;
          }

        public UnitsValue_WindJSON   getValue()
          {
            Debug.Assert(flagHasValue);
            return storeValue;
          }

        public bool  hasDirectionAbbreviation()
          {
            return flagHasDirectionAbbreviation;
          }

        public string  getDirectionAbbreviation()
          {
            Debug.Assert(flagHasDirectionAbbreviation);
            return storeDirectionAbbreviation;
          }

        public bool  hasDirectionText()
          {
            return flagHasDirectionText;
          }

        public string  getDirectionText()
          {
            Debug.Assert(flagHasDirectionText);
            return storeDirectionText;
          }

        public bool  hasDirectionDegrees()
          {
            return flagHasDirectionDegrees;
          }

        public short  getDirectionDegrees()
          {
            Debug.Assert(flagHasDirectionDegrees);
            return storeDirectionDegrees;
          }


        public virtual int extraTypeWindComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeWindComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeWindComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeWindLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setValue(UnitsValue_WindJSON  new_value)
          {
            if (flagHasValue)
              {
              }
            flagHasValue = true;
            storeValue = new_value;
          }
        public void unsetValue()
          {
            if (flagHasValue)
              {
              }
            flagHasValue = false;
          }
        public void setDirectionAbbreviation(string new_value)
          {
            flagHasDirectionAbbreviation = true;
            storeDirectionAbbreviation = new_value;
          }
        public void unsetDirectionAbbreviation()
          {
            flagHasDirectionAbbreviation = false;
          }
        public void setDirectionText(string new_value)
          {
            flagHasDirectionText = true;
            storeDirectionText = new_value;
          }
        public void unsetDirectionText()
          {
            flagHasDirectionText = false;
          }
        public void setDirectionDegrees(short new_value)
          {
            flagHasDirectionDegrees = true;
            if (new_value < 0)
                throw new Exception("The value for field DirectionDegrees of TypeWindJSON is less than the lower bound (0) for that field.");
            if (new_value > 360)
                throw new Exception("The value for field DirectionDegrees of TypeWindJSON is greater than the upper bound (360) for that field.");
            storeDirectionDegrees = new_value;
          }
        public void unsetDirectionDegrees()
          {
            flagHasDirectionDegrees = false;
          }

        public virtual void extraTypeWindAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeWindSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeWindLookup(key);
            if (old_field == null)
              {
                extraTypeWindAppendPair(key, new_component);
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
            if (flagHasValue)
              {
                handler.start_pair("Value");
                if (partial_allowed)
                    storeValue.write_partial_as_json(handler);
                else
                    storeValue.write_as_json(handler);
              }
            if (flagHasDirectionAbbreviation)
              {
                handler.start_pair("DirectionAbbreviation");
                handler.string_value(storeDirectionAbbreviation);
              }
            if (flagHasDirectionText)
              {
                handler.start_pair("DirectionText");
                handler.string_value(storeDirectionText);
              }
            if (flagHasDirectionDegrees)
              {
                handler.start_pair("DirectionDegrees");
                handler.number_value(storeDirectionDegrees);
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
            return null;
          }

        public static TypeWindJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeWindJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeWind", ignore_extras);
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
        public static TypeWindJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeWindJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeWindJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeWind", ignore_extras);
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
        public static TypeWindJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeWindJSON from_text(string text, bool ignore_extras)
          {
            TypeWindJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeWind", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeWindJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeWindJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeWindJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeWind", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private UnitsValue_WindJSON.HoldingGenerator fieldGeneratorValue;
            private JSONHoldingStringGenerator fieldGeneratorDirectionAbbreviation;
            private JSONHoldingStringGenerator fieldGeneratorDirectionText;
        private class FieldHoldingGeneratorDirectionDegrees : JSONHoldingIntegerRangeGenerator
              {
                public FieldHoldingGeneratorDirectionDegrees(String what) : base(what, 0, 360)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorDirectionDegrees : JSONHoldingIntegerRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorDirectionDegrees(String what) : base(what, 0, 360)
                  {
                  }
              };
            private FieldHoldingGeneratorDirectionDegrees fieldGeneratorDirectionDegrees;
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
                TypeWindJSON result = new TypeWindJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeWindAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeWindJSON result)
              {
                if (fieldGeneratorValue.have_value)
                  {
                    result.setValue(fieldGeneratorValue.value);
                    fieldGeneratorValue.have_value = false;
                  }
                if (fieldGeneratorDirectionAbbreviation.have_value)
                  {
                    result.setDirectionAbbreviation(fieldGeneratorDirectionAbbreviation.value);
                    fieldGeneratorDirectionAbbreviation.have_value = false;
                  }
                if (fieldGeneratorDirectionText.have_value)
                  {
                    result.setDirectionText(fieldGeneratorDirectionText.value);
                    fieldGeneratorDirectionText.have_value = false;
                  }
                if (fieldGeneratorDirectionDegrees.have_value)
                  {
                    result.setDirectionDegrees((short)(fieldGeneratorDirectionDegrees.value));
                    fieldGeneratorDirectionDegrees.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeWindJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'D':
                        if (String.Compare(field_name, 1, "irection", 0, 8, false) == 0)
                          {
                            switch (field_name[9])
                              {
                                case 'A':
                                    if ((String.Compare(field_name, 10, "bbreviation", 0, 11, false) == 0) && (field_name.Length == 21))
                                        return fieldGeneratorDirectionAbbreviation;
                                    break;
                                case 'D':
                                    if ((String.Compare(field_name, 10, "egrees", 0, 6, false) == 0) && (field_name.Length == 16))
                                        return fieldGeneratorDirectionDegrees;
                                    break;
                                case 'T':
                                    if ((String.Compare(field_name, 10, "ext", 0, 3, false) == 0) && (field_name.Length == 13))
                                        return fieldGeneratorDirectionText;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'V':
                        if ((String.Compare(field_name, 1, "alue", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorValue;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_WindJSON.HoldingGenerator("field \"Value\" of the TypeWind class", ignore_extras);
                fieldGeneratorDirectionAbbreviation = new JSONHoldingStringGenerator("field \"DirectionAbbreviation\" of the TypeWind class");
                fieldGeneratorDirectionText = new JSONHoldingStringGenerator("field \"DirectionText\" of the TypeWind class");
                fieldGeneratorDirectionDegrees = new FieldHoldingGeneratorDirectionDegrees("field \"DirectionDegrees\" of the TypeWind class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeWind class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_WindJSON.HoldingGenerator("field \"Value\" of the TypeWind class", false);
                fieldGeneratorDirectionAbbreviation = new JSONHoldingStringGenerator("field \"DirectionAbbreviation\" of the TypeWind class");
                fieldGeneratorDirectionText = new JSONHoldingStringGenerator("field \"DirectionText\" of the TypeWind class");
                fieldGeneratorDirectionDegrees = new FieldHoldingGeneratorDirectionDegrees("field \"DirectionDegrees\" of the TypeWind class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeWind class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorValue.reset();
                fieldGeneratorDirectionAbbreviation.reset();
                fieldGeneratorDirectionText.reset();
                fieldGeneratorDirectionDegrees.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorValue.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorValue.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeWindJSON  result)
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
            public TypeWindJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeWindJSON  result)
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
        protected virtual void handle_result(List<TypeWindJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeWindJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeWindJSON>();
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
        public List<TypeWindJSON> value;
      };
      };
    public class TypeWindGustJSON : JSONBase
      {
        private bool flagHasValue;
        private UnitsValue_WindJSON  storeValue;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            UnitsValue_WindJSON convert_classy = UnitsValue_WindJSON.from_json(json_value, ignore_extras, true);
            setValue(convert_classy);
          }


        public TypeWindGustJSON()
          {
            flagHasValue = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasValue()
          {
            return flagHasValue;
          }

        public UnitsValue_WindJSON   getValue()
          {
            Debug.Assert(flagHasValue);
            return storeValue;
          }


        public virtual int extraTypeWindGustComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeWindGustComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeWindGustComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeWindGustLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setValue(UnitsValue_WindJSON  new_value)
          {
            if (flagHasValue)
              {
              }
            flagHasValue = true;
            storeValue = new_value;
          }
        public void unsetValue()
          {
            if (flagHasValue)
              {
              }
            flagHasValue = false;
          }

        public virtual void extraTypeWindGustAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeWindGustSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeWindGustLookup(key);
            if (old_field == null)
              {
                extraTypeWindGustAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasValue);
            if (flagHasValue)
              {
                handler.start_pair("Value");
                if (partial_allowed)
                    storeValue.write_partial_as_json(handler);
                else
                    storeValue.write_as_json(handler);
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
            if (!(hasValue()))
              {
                return "When parsing the object for %what%, the \"Value\" field was missing.";
              }
            return null;
          }

        public static TypeWindGustJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeWindGustJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeWindGust", ignore_extras);
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
        public static TypeWindGustJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeWindGustJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeWindGustJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeWindGust", ignore_extras);
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
        public static TypeWindGustJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeWindGustJSON from_text(string text, bool ignore_extras)
          {
            TypeWindGustJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeWindGust", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeWindGustJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeWindGustJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeWindGustJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeWindGust", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private UnitsValue_WindJSON.HoldingGenerator fieldGeneratorValue;
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
                TypeWindGustJSON result = new TypeWindGustJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeWindGustAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeWindGustJSON result)
              {
                if (fieldGeneratorValue.have_value)
                  {
                    result.setValue(fieldGeneratorValue.value);
                    fieldGeneratorValue.have_value = false;
                  }
                else if ((!(result.hasValue())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Value\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeWindGustJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Value", 0, 5, false) == 0) && (field_name.Length == 5))
                    return fieldGeneratorValue;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_WindJSON.HoldingGenerator("field \"Value\" of the TypeWindGust class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeWindGust class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_WindJSON.HoldingGenerator("field \"Value\" of the TypeWindGust class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeWindGust class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorValue.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorValue.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorValue.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeWindGustJSON  result)
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
            public TypeWindGustJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeWindGustJSON  result)
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
        protected virtual void handle_result(List<TypeWindGustJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeWindGustJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeWindGustJSON>();
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
        public List<TypeWindGustJSON> value;
      };
      };
    public class TypeBarometricPressureJSON : JSONBase
      {
        private bool flagHasValue;
        private UnitsValue_PressureJSON  storeValue;
        private bool flagHasTrend;
        private string storeTrend;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            UnitsValue_PressureJSON convert_classy = UnitsValue_PressureJSON.from_json(json_value, ignore_extras, true);
            setValue(convert_classy);
          }


        private void  fromJSONTrend(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Trend of TypeBarometricPressureJSON is not a string.");
            setTrend(json_string.getData());
          }


        public TypeBarometricPressureJSON()
          {
            flagHasValue = false;
            flagHasTrend = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasValue()
          {
            return flagHasValue;
          }

        public UnitsValue_PressureJSON   getValue()
          {
            Debug.Assert(flagHasValue);
            return storeValue;
          }

        public bool  hasTrend()
          {
            return flagHasTrend;
          }

        public string  getTrend()
          {
            Debug.Assert(flagHasTrend);
            return storeTrend;
          }


        public virtual int extraTypeBarometricPressureComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeBarometricPressureComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeBarometricPressureComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeBarometricPressureLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setValue(UnitsValue_PressureJSON  new_value)
          {
            if (flagHasValue)
              {
              }
            flagHasValue = true;
            storeValue = new_value;
          }
        public void unsetValue()
          {
            if (flagHasValue)
              {
              }
            flagHasValue = false;
          }
        public void setTrend(string new_value)
          {
            flagHasTrend = true;
            storeTrend = new_value;
          }
        public void unsetTrend()
          {
            flagHasTrend = false;
          }

        public virtual void extraTypeBarometricPressureAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeBarometricPressureSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeBarometricPressureLookup(key);
            if (old_field == null)
              {
                extraTypeBarometricPressureAppendPair(key, new_component);
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
            if (flagHasValue)
              {
                handler.start_pair("Value");
                if (partial_allowed)
                    storeValue.write_partial_as_json(handler);
                else
                    storeValue.write_as_json(handler);
              }
            if (flagHasTrend)
              {
                handler.start_pair("Trend");
                handler.string_value(storeTrend);
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
            return null;
          }

        public static TypeBarometricPressureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeBarometricPressureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeBarometricPressure", ignore_extras);
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
        public static TypeBarometricPressureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeBarometricPressureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeBarometricPressureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeBarometricPressure", ignore_extras);
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
        public static TypeBarometricPressureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeBarometricPressureJSON from_text(string text, bool ignore_extras)
          {
            TypeBarometricPressureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeBarometricPressure", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeBarometricPressureJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeBarometricPressureJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeBarometricPressureJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeBarometricPressure", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private UnitsValue_PressureJSON.HoldingGenerator fieldGeneratorValue;
            private JSONHoldingStringGenerator fieldGeneratorTrend;
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
                TypeBarometricPressureJSON result = new TypeBarometricPressureJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeBarometricPressureAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeBarometricPressureJSON result)
              {
                if (fieldGeneratorValue.have_value)
                  {
                    result.setValue(fieldGeneratorValue.value);
                    fieldGeneratorValue.have_value = false;
                  }
                if (fieldGeneratorTrend.have_value)
                  {
                    result.setTrend(fieldGeneratorTrend.value);
                    fieldGeneratorTrend.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeBarometricPressureJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'T':
                        if ((String.Compare(field_name, 1, "rend", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorTrend;
                        break;
                    case 'V':
                        if ((String.Compare(field_name, 1, "alue", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorValue;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new UnitsValue_PressureJSON.HoldingGenerator("field \"Value\" of the TypeBarometricPressure class", ignore_extras);
                fieldGeneratorTrend = new JSONHoldingStringGenerator("field \"Trend\" of the TypeBarometricPressure class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeBarometricPressure class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new UnitsValue_PressureJSON.HoldingGenerator("field \"Value\" of the TypeBarometricPressure class", false);
                fieldGeneratorTrend = new JSONHoldingStringGenerator("field \"Trend\" of the TypeBarometricPressure class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeBarometricPressure class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorValue.reset();
                fieldGeneratorTrend.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorValue.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorValue.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeBarometricPressureJSON  result)
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
            public TypeBarometricPressureJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeBarometricPressureJSON  result)
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
        protected virtual void handle_result(List<TypeBarometricPressureJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeBarometricPressureJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeBarometricPressureJSON>();
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
        public List<TypeBarometricPressureJSON> value;
      };
      };
    public class TypeUVIndexJSON : JSONBase
      {
        private bool flagHasValue;
        private sbyte storeValue;
        private bool flagHasText;
        private string storeText;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            sbyte extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field Value of TypeUVIndexJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Value of TypeUVIndexJSON is not an integer.");
                  }
                extracted_integer = (sbyte)(json_rational.getLongInt())            ;
              }
            else
              {
                extracted_integer = (sbyte)(json_integer.getLongInt())            ;
              }
            setValue(extracted_integer);
          }


        private void  fromJSONText(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Text of TypeUVIndexJSON is not a string.");
            setText(json_string.getData());
          }


        public TypeUVIndexJSON()
          {
            flagHasValue = false;
            flagHasText = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasValue()
          {
            return flagHasValue;
          }

        public sbyte  getValue()
          {
            Debug.Assert(flagHasValue);
            return storeValue;
          }

        public bool  hasText()
          {
            return flagHasText;
          }

        public string  getText()
          {
            Debug.Assert(flagHasText);
            return storeText;
          }


        public virtual int extraTypeUVIndexComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeUVIndexComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeUVIndexComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeUVIndexLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setValue(sbyte new_value)
          {
            flagHasValue = true;
            if (new_value < 0)
                throw new Exception("The value for field Value of TypeUVIndexJSON is less than the lower bound (0) for that field.");
            if (new_value > 30)
                throw new Exception("The value for field Value of TypeUVIndexJSON is greater than the upper bound (30) for that field.");
            storeValue = new_value;
          }
        public void unsetValue()
          {
            flagHasValue = false;
          }
        public void setText(string new_value)
          {
            flagHasText = true;
            storeText = new_value;
          }
        public void unsetText()
          {
            flagHasText = false;
          }

        public virtual void extraTypeUVIndexAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeUVIndexSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeUVIndexLookup(key);
            if (old_field == null)
              {
                extraTypeUVIndexAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasValue);
            if (flagHasValue)
              {
                handler.start_pair("Value");
                handler.number_value(storeValue);
              }
            Debug.Assert(partial_allowed || flagHasText);
            if (flagHasText)
              {
                handler.start_pair("Text");
                handler.string_value(storeText);
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
            if (!(hasValue()))
              {
                return "When parsing the object for %what%, the \"Value\" field was missing.";
              }
            if (!(hasText()))
              {
                return "When parsing the object for %what%, the \"Text\" field was missing.";
              }
            return null;
          }

        public static TypeUVIndexJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeUVIndexJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeUVIndex", ignore_extras);
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
        public static TypeUVIndexJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeUVIndexJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeUVIndexJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeUVIndex", ignore_extras);
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
        public static TypeUVIndexJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeUVIndexJSON from_text(string text, bool ignore_extras)
          {
            TypeUVIndexJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeUVIndex", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeUVIndexJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeUVIndexJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeUVIndexJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeUVIndex", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private class FieldHoldingGeneratorValue : JSONHoldingIntegerRangeGenerator
              {
                public FieldHoldingGeneratorValue(String what) : base(what, 0, 30)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorValue : JSONHoldingIntegerRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorValue(String what) : base(what, 0, 30)
                  {
                  }
              };
            private FieldHoldingGeneratorValue fieldGeneratorValue;
            private JSONHoldingStringGenerator fieldGeneratorText;
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
                TypeUVIndexJSON result = new TypeUVIndexJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeUVIndexAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeUVIndexJSON result)
              {
                if (fieldGeneratorValue.have_value)
                  {
                    result.setValue((sbyte)(fieldGeneratorValue.value));
                    fieldGeneratorValue.have_value = false;
                  }
                else if ((!(result.hasValue())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Value\" field was missing.");
                  }
                if (fieldGeneratorText.have_value)
                  {
                    result.setText(fieldGeneratorText.value);
                    fieldGeneratorText.have_value = false;
                  }
                else if ((!(result.hasText())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Text\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeUVIndexJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'T':
                        if ((String.Compare(field_name, 1, "ext", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorText;
                        break;
                    case 'V':
                        if ((String.Compare(field_name, 1, "alue", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorValue;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new FieldHoldingGeneratorValue("field \"Value\" of the TypeUVIndex class");
                fieldGeneratorText = new JSONHoldingStringGenerator("field \"Text\" of the TypeUVIndex class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeUVIndex class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new FieldHoldingGeneratorValue("field \"Value\" of the TypeUVIndex class");
                fieldGeneratorText = new JSONHoldingStringGenerator("field \"Text\" of the TypeUVIndex class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeUVIndex class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorValue.reset();
                fieldGeneratorText.reset();
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
            protected override void handle_result(TypeUVIndexJSON  result)
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
            public TypeUVIndexJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeUVIndexJSON  result)
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
        protected virtual void handle_result(List<TypeUVIndexJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeUVIndexJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeUVIndexJSON>();
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
        public List<TypeUVIndexJSON> value;
      };
      };
    private bool flagHasAttribution;
    private AttributionJSON  storeAttribution;
    private bool flagHasLocation;
    private MapLocationJSON  storeLocation;
    private bool flagHasAlerts;
    private List< AlertJSON  > storeAlerts;
    private bool flagHasRequestedAttribute;
    private string storeRequestedAttribute;
    private bool flagHasIsYesNoQuery;
    private bool storeIsYesNoQuery;
    private bool flagHasWeatherMapRequested;
    private bool storeWeatherMapRequested;
    private bool flagHasAlongTheRoute;
    private bool storeAlongTheRoute;
    private bool flagHasObservationDateAndTime;
    private DateAndOrTimeJSON  storeObservationDateAndTime;
    private bool flagHasConditionsShortPhrase;
    private string storeConditionsShortPhrase;
    private bool flagHasCurrentTemperature;
    private TypeCurrentTemperatureJSON  storeCurrentTemperature;
    private bool flagHasFeelsLikeTemperature;
    private TypeFeelsLikeTemperatureJSON  storeFeelsLikeTemperature;
    private bool flagHasHeatIndex;
    private TypeHeatIndexJSON  storeHeatIndex;
    private bool flagHasWindchill;
    private TypeWindchillJSON  storeWindchill;
    private bool flagHasDewPoint;
    private TypeDewPointJSON  storeDewPoint;
    private bool flagHasWeatherIconURL;
    private string storeWeatherIconURL;
    private bool flagHasConditionsImage;
    private WeatherImageJSON  storeConditionsImage;
    private bool flagHasHumidityPct;
    private sbyte storeHumidityPct;
    private bool flagHasVisibility;
    private TypeVisibilityJSON  storeVisibility;
    private bool flagHasPrecipitation1Hour;
    private TypePrecipitation1HourJSON  storePrecipitation1Hour;
    private bool flagHasPrecipitationToday;
    private TypePrecipitationTodayJSON  storePrecipitationToday;
    private bool flagHasWind;
    private TypeWindJSON  storeWind;
    private bool flagHasWindGust;
    private TypeWindGustJSON  storeWindGust;
    private bool flagHasBarometricPressure;
    private TypeBarometricPressureJSON  storeBarometricPressure;
    private bool flagHasUVIndex;
    private TypeUVIndexJSON  storeUVIndex;
    private bool flagHasCloudinessPct;
    private sbyte storeCloudinessPct;
    private bool flagHasDailyForecasts;
    private List< DailyForecastJSON  > storeDailyForecasts;
    private bool flagHasHourlyForecasts;
    private List< HourlyForecastJSON  > storeHourlyForecasts;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraAttributionToJSON()
      {
        JSONValueHandler handler_Attribution = new JSONValueHandler();
        storeAttribution.write_as_json(handler_Attribution);
        return handler_Attribution.result;
      }

    private JSONValue  extraLocationToJSON()
      {
        JSONValueHandler handler_Location = new JSONValueHandler();
        storeLocation.write_as_json(handler_Location);
        return handler_Location.result;
      }

    private JSONValue  extraAlertsToJSON()
      {
        JSONArrayValue generated_array_1_Alerts = new JSONArrayValue();
        for (int num1 = 0; num1 < storeAlerts.Count; ++num1)
          {
            JSONValueHandler handler_Alerts = new JSONValueHandler();
            storeAlerts[num1].write_as_json(handler_Alerts);
            generated_array_1_Alerts.appendComponent(handler_Alerts.result);
          }
        return generated_array_1_Alerts;
      }

    private JSONValue  extraRequestedAttributeToJSON()
      {
        JSONStringValue generated_string_RequestedAttribute = new JSONStringValue(storeRequestedAttribute);
        return generated_string_RequestedAttribute;
      }

    private JSONValue  extraIsYesNoQueryToJSON()
      {
        JSONValue generated_boolean_IsYesNoQuery = (storeIsYesNoQuery ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IsYesNoQuery;
      }

    private JSONValue  extraWeatherMapRequestedToJSON()
      {
        JSONValue generated_boolean_WeatherMapRequested = (storeWeatherMapRequested ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_WeatherMapRequested;
      }

    private JSONValue  extraAlongTheRouteToJSON()
      {
        JSONValue generated_boolean_AlongTheRoute = (storeAlongTheRoute ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_AlongTheRoute;
      }

    private JSONValue  extraObservationDateAndTimeToJSON()
      {
        JSONValueHandler handler_ObservationDateAndTime = new JSONValueHandler();
        storeObservationDateAndTime.write_as_json(handler_ObservationDateAndTime);
        return handler_ObservationDateAndTime.result;
      }

    private JSONValue  extraConditionsShortPhraseToJSON()
      {
        JSONStringValue generated_string_ConditionsShortPhrase = new JSONStringValue(storeConditionsShortPhrase);
        return generated_string_ConditionsShortPhrase;
      }

    private JSONValue  extraCurrentTemperatureToJSON()
      {
        JSONValueHandler handler_CurrentTemperature = new JSONValueHandler();
        storeCurrentTemperature.write_as_json(handler_CurrentTemperature);
        return handler_CurrentTemperature.result;
      }

    private JSONValue  extraFeelsLikeTemperatureToJSON()
      {
        JSONValueHandler handler_FeelsLikeTemperature = new JSONValueHandler();
        storeFeelsLikeTemperature.write_as_json(handler_FeelsLikeTemperature);
        return handler_FeelsLikeTemperature.result;
      }

    private JSONValue  extraHeatIndexToJSON()
      {
        JSONValueHandler handler_HeatIndex = new JSONValueHandler();
        storeHeatIndex.write_as_json(handler_HeatIndex);
        return handler_HeatIndex.result;
      }

    private JSONValue  extraWindchillToJSON()
      {
        JSONValueHandler handler_Windchill = new JSONValueHandler();
        storeWindchill.write_as_json(handler_Windchill);
        return handler_Windchill.result;
      }

    private JSONValue  extraDewPointToJSON()
      {
        JSONValueHandler handler_DewPoint = new JSONValueHandler();
        storeDewPoint.write_as_json(handler_DewPoint);
        return handler_DewPoint.result;
      }

    private JSONValue  extraWeatherIconURLToJSON()
      {
        JSONStringValue generated_string_WeatherIconURL = new JSONStringValue(storeWeatherIconURL);
        return generated_string_WeatherIconURL;
      }

    private JSONValue  extraConditionsImageToJSON()
      {
        JSONValueHandler handler_ConditionsImage = new JSONValueHandler();
        storeConditionsImage.write_as_json(handler_ConditionsImage);
        return handler_ConditionsImage.result;
      }

    private JSONValue  extraHumidityPctToJSON()
      {
        JSONIntegerValue generated_integer_HumidityPct = new JSONIntegerValue(storeHumidityPct);
        return generated_integer_HumidityPct;
      }

    private JSONValue  extraVisibilityToJSON()
      {
        JSONValueHandler handler_Visibility = new JSONValueHandler();
        storeVisibility.write_as_json(handler_Visibility);
        return handler_Visibility.result;
      }

    private JSONValue  extraPrecipitation1HourToJSON()
      {
        JSONValueHandler handler_Precipitation1Hour = new JSONValueHandler();
        storePrecipitation1Hour.write_as_json(handler_Precipitation1Hour);
        return handler_Precipitation1Hour.result;
      }

    private JSONValue  extraPrecipitationTodayToJSON()
      {
        JSONValueHandler handler_PrecipitationToday = new JSONValueHandler();
        storePrecipitationToday.write_as_json(handler_PrecipitationToday);
        return handler_PrecipitationToday.result;
      }

    private JSONValue  extraWindToJSON()
      {
        JSONValueHandler handler_Wind = new JSONValueHandler();
        storeWind.write_as_json(handler_Wind);
        return handler_Wind.result;
      }

    private JSONValue  extraWindGustToJSON()
      {
        JSONValueHandler handler_WindGust = new JSONValueHandler();
        storeWindGust.write_as_json(handler_WindGust);
        return handler_WindGust.result;
      }

    private JSONValue  extraBarometricPressureToJSON()
      {
        JSONValueHandler handler_BarometricPressure = new JSONValueHandler();
        storeBarometricPressure.write_as_json(handler_BarometricPressure);
        return handler_BarometricPressure.result;
      }

    private JSONValue  extraUVIndexToJSON()
      {
        JSONValueHandler handler_UVIndex = new JSONValueHandler();
        storeUVIndex.write_as_json(handler_UVIndex);
        return handler_UVIndex.result;
      }

    private JSONValue  extraCloudinessPctToJSON()
      {
        JSONIntegerValue generated_integer_CloudinessPct = new JSONIntegerValue(storeCloudinessPct);
        return generated_integer_CloudinessPct;
      }

    private JSONValue  extraDailyForecastsToJSON()
      {
        JSONArrayValue generated_array_2_DailyForecasts = new JSONArrayValue();
        for (int num2 = 0; num2 < storeDailyForecasts.Count; ++num2)
          {
            JSONValueHandler handler_DailyForecasts = new JSONValueHandler();
            storeDailyForecasts[num2].write_as_json(handler_DailyForecasts);
            generated_array_2_DailyForecasts.appendComponent(handler_DailyForecasts.result);
          }
        return generated_array_2_DailyForecasts;
      }

    private JSONValue  extraHourlyForecastsToJSON()
      {
        JSONArrayValue generated_array_3_HourlyForecasts = new JSONArrayValue();
        for (int num3 = 0; num3 < storeHourlyForecasts.Count; ++num3)
          {
            JSONValueHandler handler_HourlyForecasts = new JSONValueHandler();
            storeHourlyForecasts[num3].write_as_json(handler_HourlyForecasts);
            generated_array_3_HourlyForecasts.appendComponent(handler_HourlyForecasts.result);
          }
        return generated_array_3_HourlyForecasts;
      }


    private void  fromJSONAttribution(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AttributionJSON convert_classy = AttributionJSON.from_json(json_value, ignore_extras, true);
        setAttribution(convert_classy);
      }


    private void  fromJSONLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setLocation(convert_classy);
      }


    private void  fromJSONAlerts(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Alerts of ShowWeatherCurrentConditionsInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< AlertJSON  > vector_Alerts1 = new List< AlertJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            AlertJSON convert_classy = AlertJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Alerts1.Add(convert_classy);
          }
        initAlerts();
        for (int num1 = 0; num1 < vector_Alerts1.Count; ++num1)
            appendAlerts(vector_Alerts1[num1]);
        for (int num1 = 0; num1 < vector_Alerts1.Count; ++num1)
          {
          }
      }


    private void  fromJSONRequestedAttribute(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field RequestedAttribute of ShowWeatherCurrentConditionsInformationNuggetJSON is not a string.");
        setRequestedAttribute(json_string.getData());
      }


    private void  fromJSONIsYesNoQuery(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsYesNoQuery of ShowWeatherCurrentConditionsInformationNuggetJSON is not true for false.");
              }
          }
        setIsYesNoQuery(the_bool);
      }


    private void  fromJSONWeatherMapRequested(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field WeatherMapRequested of ShowWeatherCurrentConditionsInformationNuggetJSON is not true for false.");
              }
          }
        setWeatherMapRequested(the_bool);
      }


    private void  fromJSONAlongTheRoute(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field AlongTheRoute of ShowWeatherCurrentConditionsInformationNuggetJSON is not true for false.");
              }
          }
        setAlongTheRoute(the_bool);
      }


    private void  fromJSONObservationDateAndTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setObservationDateAndTime(convert_classy);
      }


    private void  fromJSONConditionsShortPhrase(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ConditionsShortPhrase of ShowWeatherCurrentConditionsInformationNuggetJSON is not a string.");
        setConditionsShortPhrase(json_string.getData());
      }


    private void  fromJSONCurrentTemperature(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeCurrentTemperatureJSON convert_classy = TypeCurrentTemperatureJSON.from_json(json_value, ignore_extras, true);
        setCurrentTemperature(convert_classy);
      }


    private void  fromJSONFeelsLikeTemperature(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeFeelsLikeTemperatureJSON convert_classy = TypeFeelsLikeTemperatureJSON.from_json(json_value, ignore_extras, true);
        setFeelsLikeTemperature(convert_classy);
      }


    private void  fromJSONHeatIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeHeatIndexJSON convert_classy = TypeHeatIndexJSON.from_json(json_value, ignore_extras, true);
        setHeatIndex(convert_classy);
      }


    private void  fromJSONWindchill(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeWindchillJSON convert_classy = TypeWindchillJSON.from_json(json_value, ignore_extras, true);
        setWindchill(convert_classy);
      }


    private void  fromJSONDewPoint(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeDewPointJSON convert_classy = TypeDewPointJSON.from_json(json_value, ignore_extras, true);
        setDewPoint(convert_classy);
      }


    private void  fromJSONWeatherIconURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WeatherIconURL of ShowWeatherCurrentConditionsInformationNuggetJSON is not a string.");
        setWeatherIconURL(json_string.getData());
      }


    private void  fromJSONConditionsImage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WeatherImageJSON convert_classy = WeatherImageJSON.from_json(json_value, ignore_extras, true);
        setConditionsImage(convert_classy);
      }


    private void  fromJSONHumidityPct(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field HumidityPct of ShowWeatherCurrentConditionsInformationNuggetJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field HumidityPct of ShowWeatherCurrentConditionsInformationNuggetJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setHumidityPct(extracted_integer);
      }


    private void  fromJSONVisibility(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeVisibilityJSON convert_classy = TypeVisibilityJSON.from_json(json_value, ignore_extras, true);
        setVisibility(convert_classy);
      }


    private void  fromJSONPrecipitation1Hour(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypePrecipitation1HourJSON convert_classy = TypePrecipitation1HourJSON.from_json(json_value, ignore_extras, true);
        setPrecipitation1Hour(convert_classy);
      }


    private void  fromJSONPrecipitationToday(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypePrecipitationTodayJSON convert_classy = TypePrecipitationTodayJSON.from_json(json_value, ignore_extras, true);
        setPrecipitationToday(convert_classy);
      }


    private void  fromJSONWind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeWindJSON convert_classy = TypeWindJSON.from_json(json_value, ignore_extras, true);
        setWind(convert_classy);
      }


    private void  fromJSONWindGust(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeWindGustJSON convert_classy = TypeWindGustJSON.from_json(json_value, ignore_extras, true);
        setWindGust(convert_classy);
      }


    private void  fromJSONBarometricPressure(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeBarometricPressureJSON convert_classy = TypeBarometricPressureJSON.from_json(json_value, ignore_extras, true);
        setBarometricPressure(convert_classy);
      }


    private void  fromJSONUVIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeUVIndexJSON convert_classy = TypeUVIndexJSON.from_json(json_value, ignore_extras, true);
        setUVIndex(convert_classy);
      }


    private void  fromJSONCloudinessPct(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field CloudinessPct of ShowWeatherCurrentConditionsInformationNuggetJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field CloudinessPct of ShowWeatherCurrentConditionsInformationNuggetJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setCloudinessPct(extracted_integer);
      }


    private void  fromJSONDailyForecasts(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field DailyForecasts of ShowWeatherCurrentConditionsInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< DailyForecastJSON  > vector_DailyForecasts1 = new List< DailyForecastJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            DailyForecastJSON convert_classy = DailyForecastJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_DailyForecasts1.Add(convert_classy);
          }
        initDailyForecasts();
        for (int num2 = 0; num2 < vector_DailyForecasts1.Count; ++num2)
            appendDailyForecasts(vector_DailyForecasts1[num2]);
        for (int num1 = 0; num1 < vector_DailyForecasts1.Count; ++num1)
          {
          }
      }


    private void  fromJSONHourlyForecasts(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field HourlyForecasts of ShowWeatherCurrentConditionsInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< HourlyForecastJSON  > vector_HourlyForecasts1 = new List< HourlyForecastJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            HourlyForecastJSON convert_classy = HourlyForecastJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_HourlyForecasts1.Add(convert_classy);
          }
        initHourlyForecasts();
        for (int num3 = 0; num3 < vector_HourlyForecasts1.Count; ++num3)
            appendHourlyForecasts(vector_HourlyForecasts1[num3]);
        for (int num1 = 0; num1 < vector_HourlyForecasts1.Count; ++num1)
          {
          }
      }


    public ShowWeatherCurrentConditionsInformationNuggetJSON()
      {
        flagHasAttribution = false;
        flagHasLocation = false;
        flagHasAlerts = false;
        flagHasRequestedAttribute = false;
        flagHasIsYesNoQuery = false;
        flagHasWeatherMapRequested = false;
        flagHasAlongTheRoute = false;
        flagHasObservationDateAndTime = false;
        flagHasConditionsShortPhrase = false;
        flagHasCurrentTemperature = false;
        flagHasFeelsLikeTemperature = false;
        flagHasHeatIndex = false;
        flagHasWindchill = false;
        flagHasDewPoint = false;
        flagHasWeatherIconURL = false;
        flagHasConditionsImage = false;
        flagHasHumidityPct = false;
        flagHasVisibility = false;
        flagHasPrecipitation1Hour = false;
        flagHasPrecipitationToday = false;
        flagHasWind = false;
        flagHasWindGust = false;
        flagHasBarometricPressure = false;
        flagHasUVIndex = false;
        flagHasCloudinessPct = false;
        flagHasDailyForecasts = false;
        flagHasHourlyForecasts = false;
        storeAlerts = new List< AlertJSON  >();
        storeDailyForecasts = new List< DailyForecastJSON  >();
        storeHourlyForecasts = new List< HourlyForecastJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getWeatherNuggetKind()
      {
        return "ShowWeatherCurrentConditions";
      }

    public bool  hasAttribution()
      {
        return flagHasAttribution;
      }

    public AttributionJSON   getAttribution()
      {
        Debug.Assert(flagHasAttribution);
        return storeAttribution;
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

    public bool  hasAlerts()
      {
        return flagHasAlerts;
      }

    public int  countOfAlerts()
      {
        Debug.Assert(flagHasAlerts);
        return storeAlerts.Count;
      }

    public AlertJSON   elementOfAlerts(int element_num)
      {
        Debug.Assert(flagHasAlerts);
        return storeAlerts[element_num];
      }

    public List< AlertJSON  >  getAlerts()
      {
        Debug.Assert(flagHasAlerts);
        return storeAlerts;
      }

    public bool  hasRequestedAttribute()
      {
        return flagHasRequestedAttribute;
      }

    public string  getRequestedAttribute()
      {
        Debug.Assert(flagHasRequestedAttribute);
        return storeRequestedAttribute;
      }

    public bool  hasIsYesNoQuery()
      {
        return flagHasIsYesNoQuery;
      }

    public bool  getIsYesNoQuery()
      {
        Debug.Assert(flagHasIsYesNoQuery);
        return storeIsYesNoQuery;
      }

    public bool  hasWeatherMapRequested()
      {
        return flagHasWeatherMapRequested;
      }

    public bool  getWeatherMapRequested()
      {
        Debug.Assert(flagHasWeatherMapRequested);
        return storeWeatherMapRequested;
      }

    public bool  hasAlongTheRoute()
      {
        return flagHasAlongTheRoute;
      }

    public bool  getAlongTheRoute()
      {
        Debug.Assert(flagHasAlongTheRoute);
        return storeAlongTheRoute;
      }

    public bool  hasObservationDateAndTime()
      {
        return flagHasObservationDateAndTime;
      }

    public DateAndOrTimeJSON   getObservationDateAndTime()
      {
        Debug.Assert(flagHasObservationDateAndTime);
        return storeObservationDateAndTime;
      }

    public bool  hasConditionsShortPhrase()
      {
        return flagHasConditionsShortPhrase;
      }

    public string  getConditionsShortPhrase()
      {
        Debug.Assert(flagHasConditionsShortPhrase);
        return storeConditionsShortPhrase;
      }

    public bool  hasCurrentTemperature()
      {
        return flagHasCurrentTemperature;
      }

    public TypeCurrentTemperatureJSON   getCurrentTemperature()
      {
        Debug.Assert(flagHasCurrentTemperature);
        return storeCurrentTemperature;
      }

    public bool  hasFeelsLikeTemperature()
      {
        return flagHasFeelsLikeTemperature;
      }

    public TypeFeelsLikeTemperatureJSON   getFeelsLikeTemperature()
      {
        Debug.Assert(flagHasFeelsLikeTemperature);
        return storeFeelsLikeTemperature;
      }

    public bool  hasHeatIndex()
      {
        return flagHasHeatIndex;
      }

    public TypeHeatIndexJSON   getHeatIndex()
      {
        Debug.Assert(flagHasHeatIndex);
        return storeHeatIndex;
      }

    public bool  hasWindchill()
      {
        return flagHasWindchill;
      }

    public TypeWindchillJSON   getWindchill()
      {
        Debug.Assert(flagHasWindchill);
        return storeWindchill;
      }

    public bool  hasDewPoint()
      {
        return flagHasDewPoint;
      }

    public TypeDewPointJSON   getDewPoint()
      {
        Debug.Assert(flagHasDewPoint);
        return storeDewPoint;
      }

    public bool  hasWeatherIconURL()
      {
        return flagHasWeatherIconURL;
      }

    public string  getWeatherIconURL()
      {
        Debug.Assert(flagHasWeatherIconURL);
        return storeWeatherIconURL;
      }

    public bool  hasConditionsImage()
      {
        return flagHasConditionsImage;
      }

    public WeatherImageJSON   getConditionsImage()
      {
        Debug.Assert(flagHasConditionsImage);
        return storeConditionsImage;
      }

    public bool  hasHumidityPct()
      {
        return flagHasHumidityPct;
      }

    public sbyte  getHumidityPct()
      {
        Debug.Assert(flagHasHumidityPct);
        return storeHumidityPct;
      }

    public bool  hasVisibility()
      {
        return flagHasVisibility;
      }

    public TypeVisibilityJSON   getVisibility()
      {
        Debug.Assert(flagHasVisibility);
        return storeVisibility;
      }

    public bool  hasPrecipitation1Hour()
      {
        return flagHasPrecipitation1Hour;
      }

    public TypePrecipitation1HourJSON   getPrecipitation1Hour()
      {
        Debug.Assert(flagHasPrecipitation1Hour);
        return storePrecipitation1Hour;
      }

    public bool  hasPrecipitationToday()
      {
        return flagHasPrecipitationToday;
      }

    public TypePrecipitationTodayJSON   getPrecipitationToday()
      {
        Debug.Assert(flagHasPrecipitationToday);
        return storePrecipitationToday;
      }

    public bool  hasWind()
      {
        return flagHasWind;
      }

    public TypeWindJSON   getWind()
      {
        Debug.Assert(flagHasWind);
        return storeWind;
      }

    public bool  hasWindGust()
      {
        return flagHasWindGust;
      }

    public TypeWindGustJSON   getWindGust()
      {
        Debug.Assert(flagHasWindGust);
        return storeWindGust;
      }

    public bool  hasBarometricPressure()
      {
        return flagHasBarometricPressure;
      }

    public TypeBarometricPressureJSON   getBarometricPressure()
      {
        Debug.Assert(flagHasBarometricPressure);
        return storeBarometricPressure;
      }

    public bool  hasUVIndex()
      {
        return flagHasUVIndex;
      }

    public TypeUVIndexJSON   getUVIndex()
      {
        Debug.Assert(flagHasUVIndex);
        return storeUVIndex;
      }

    public bool  hasCloudinessPct()
      {
        return flagHasCloudinessPct;
      }

    public sbyte  getCloudinessPct()
      {
        Debug.Assert(flagHasCloudinessPct);
        return storeCloudinessPct;
      }

    public bool  hasDailyForecasts()
      {
        return flagHasDailyForecasts;
      }

    public int  countOfDailyForecasts()
      {
        Debug.Assert(flagHasDailyForecasts);
        return storeDailyForecasts.Count;
      }

    public DailyForecastJSON   elementOfDailyForecasts(int element_num)
      {
        Debug.Assert(flagHasDailyForecasts);
        return storeDailyForecasts[element_num];
      }

    public List< DailyForecastJSON  >  getDailyForecasts()
      {
        Debug.Assert(flagHasDailyForecasts);
        return storeDailyForecasts;
      }

    public bool  hasHourlyForecasts()
      {
        return flagHasHourlyForecasts;
      }

    public int  countOfHourlyForecasts()
      {
        Debug.Assert(flagHasHourlyForecasts);
        return storeHourlyForecasts.Count;
      }

    public HourlyForecastJSON   elementOfHourlyForecasts(int element_num)
      {
        Debug.Assert(flagHasHourlyForecasts);
        return storeHourlyForecasts[element_num];
      }

    public List< HourlyForecastJSON  >  getHourlyForecasts()
      {
        Debug.Assert(flagHasHourlyForecasts);
        return storeHourlyForecasts;
      }


    public virtual int extraShowWeatherCurrentConditionsInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraShowWeatherCurrentConditionsInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraShowWeatherCurrentConditionsInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraShowWeatherCurrentConditionsInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraWeatherInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasAttribution)
            ++result;
        if (flagHasLocation)
            ++result;
        if (flagHasAlerts)
            ++result;
        if (flagHasRequestedAttribute)
            ++result;
        if (flagHasIsYesNoQuery)
            ++result;
        if (flagHasWeatherMapRequested)
            ++result;
        if (flagHasAlongTheRoute)
            ++result;
        if (flagHasObservationDateAndTime)
            ++result;
        if (flagHasConditionsShortPhrase)
            ++result;
        if (flagHasCurrentTemperature)
            ++result;
        if (flagHasFeelsLikeTemperature)
            ++result;
        if (flagHasHeatIndex)
            ++result;
        if (flagHasWindchill)
            ++result;
        if (flagHasDewPoint)
            ++result;
        if (flagHasWeatherIconURL)
            ++result;
        if (flagHasConditionsImage)
            ++result;
        if (flagHasHumidityPct)
            ++result;
        if (flagHasVisibility)
            ++result;
        if (flagHasPrecipitation1Hour)
            ++result;
        if (flagHasPrecipitationToday)
            ++result;
        if (flagHasWind)
            ++result;
        if (flagHasWindGust)
            ++result;
        if (flagHasBarometricPressure)
            ++result;
        if (flagHasUVIndex)
            ++result;
        if (flagHasCloudinessPct)
            ++result;
        if (flagHasDailyForecasts)
            ++result;
        if (flagHasHourlyForecasts)
            ++result;
        result += extraShowWeatherCurrentConditionsInformationNuggetComponentCount();
        return result;
      }
    public override string extraWeatherInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasAttribution)
          {
            if (remainder == 0)
                return "Attribution";
            --remainder;
          }
        if (flagHasLocation)
          {
            if (remainder == 0)
                return "Location";
            --remainder;
          }
        if (flagHasAlerts)
          {
            if (remainder == 0)
                return "Alerts";
            --remainder;
          }
        if (flagHasRequestedAttribute)
          {
            if (remainder == 0)
                return "RequestedAttribute";
            --remainder;
          }
        if (flagHasIsYesNoQuery)
          {
            if (remainder == 0)
                return "IsYesNoQuery";
            --remainder;
          }
        if (flagHasWeatherMapRequested)
          {
            if (remainder == 0)
                return "WeatherMapRequested";
            --remainder;
          }
        if (flagHasAlongTheRoute)
          {
            if (remainder == 0)
                return "AlongTheRoute";
            --remainder;
          }
        if (flagHasObservationDateAndTime)
          {
            if (remainder == 0)
                return "ObservationDateAndTime";
            --remainder;
          }
        if (flagHasConditionsShortPhrase)
          {
            if (remainder == 0)
                return "ConditionsShortPhrase";
            --remainder;
          }
        if (flagHasCurrentTemperature)
          {
            if (remainder == 0)
                return "CurrentTemperature";
            --remainder;
          }
        if (flagHasFeelsLikeTemperature)
          {
            if (remainder == 0)
                return "FeelsLikeTemperature";
            --remainder;
          }
        if (flagHasHeatIndex)
          {
            if (remainder == 0)
                return "HeatIndex";
            --remainder;
          }
        if (flagHasWindchill)
          {
            if (remainder == 0)
                return "Windchill";
            --remainder;
          }
        if (flagHasDewPoint)
          {
            if (remainder == 0)
                return "DewPoint";
            --remainder;
          }
        if (flagHasWeatherIconURL)
          {
            if (remainder == 0)
                return "WeatherIconURL";
            --remainder;
          }
        if (flagHasConditionsImage)
          {
            if (remainder == 0)
                return "ConditionsImage";
            --remainder;
          }
        if (flagHasHumidityPct)
          {
            if (remainder == 0)
                return "HumidityPct";
            --remainder;
          }
        if (flagHasVisibility)
          {
            if (remainder == 0)
                return "Visibility";
            --remainder;
          }
        if (flagHasPrecipitation1Hour)
          {
            if (remainder == 0)
                return "Precipitation1Hour";
            --remainder;
          }
        if (flagHasPrecipitationToday)
          {
            if (remainder == 0)
                return "PrecipitationToday";
            --remainder;
          }
        if (flagHasWind)
          {
            if (remainder == 0)
                return "Wind";
            --remainder;
          }
        if (flagHasWindGust)
          {
            if (remainder == 0)
                return "WindGust";
            --remainder;
          }
        if (flagHasBarometricPressure)
          {
            if (remainder == 0)
                return "BarometricPressure";
            --remainder;
          }
        if (flagHasUVIndex)
          {
            if (remainder == 0)
                return "UVIndex";
            --remainder;
          }
        if (flagHasCloudinessPct)
          {
            if (remainder == 0)
                return "CloudinessPct";
            --remainder;
          }
        if (flagHasDailyForecasts)
          {
            if (remainder == 0)
                return "DailyForecasts";
            --remainder;
          }
        if (flagHasHourlyForecasts)
          {
            if (remainder == 0)
                return "HourlyForecasts";
            --remainder;
          }
        return extraShowWeatherCurrentConditionsInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraWeatherInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasAttribution)
          {
            if (remainder == 0)
                return extraAttributionToJSON();
            --remainder;
          }
        if (flagHasLocation)
          {
            if (remainder == 0)
                return extraLocationToJSON();
            --remainder;
          }
        if (flagHasAlerts)
          {
            if (remainder == 0)
                return extraAlertsToJSON();
            --remainder;
          }
        if (flagHasRequestedAttribute)
          {
            if (remainder == 0)
                return extraRequestedAttributeToJSON();
            --remainder;
          }
        if (flagHasIsYesNoQuery)
          {
            if (remainder == 0)
                return extraIsYesNoQueryToJSON();
            --remainder;
          }
        if (flagHasWeatherMapRequested)
          {
            if (remainder == 0)
                return extraWeatherMapRequestedToJSON();
            --remainder;
          }
        if (flagHasAlongTheRoute)
          {
            if (remainder == 0)
                return extraAlongTheRouteToJSON();
            --remainder;
          }
        if (flagHasObservationDateAndTime)
          {
            if (remainder == 0)
                return extraObservationDateAndTimeToJSON();
            --remainder;
          }
        if (flagHasConditionsShortPhrase)
          {
            if (remainder == 0)
                return extraConditionsShortPhraseToJSON();
            --remainder;
          }
        if (flagHasCurrentTemperature)
          {
            if (remainder == 0)
                return extraCurrentTemperatureToJSON();
            --remainder;
          }
        if (flagHasFeelsLikeTemperature)
          {
            if (remainder == 0)
                return extraFeelsLikeTemperatureToJSON();
            --remainder;
          }
        if (flagHasHeatIndex)
          {
            if (remainder == 0)
                return extraHeatIndexToJSON();
            --remainder;
          }
        if (flagHasWindchill)
          {
            if (remainder == 0)
                return extraWindchillToJSON();
            --remainder;
          }
        if (flagHasDewPoint)
          {
            if (remainder == 0)
                return extraDewPointToJSON();
            --remainder;
          }
        if (flagHasWeatherIconURL)
          {
            if (remainder == 0)
                return extraWeatherIconURLToJSON();
            --remainder;
          }
        if (flagHasConditionsImage)
          {
            if (remainder == 0)
                return extraConditionsImageToJSON();
            --remainder;
          }
        if (flagHasHumidityPct)
          {
            if (remainder == 0)
                return extraHumidityPctToJSON();
            --remainder;
          }
        if (flagHasVisibility)
          {
            if (remainder == 0)
                return extraVisibilityToJSON();
            --remainder;
          }
        if (flagHasPrecipitation1Hour)
          {
            if (remainder == 0)
                return extraPrecipitation1HourToJSON();
            --remainder;
          }
        if (flagHasPrecipitationToday)
          {
            if (remainder == 0)
                return extraPrecipitationTodayToJSON();
            --remainder;
          }
        if (flagHasWind)
          {
            if (remainder == 0)
                return extraWindToJSON();
            --remainder;
          }
        if (flagHasWindGust)
          {
            if (remainder == 0)
                return extraWindGustToJSON();
            --remainder;
          }
        if (flagHasBarometricPressure)
          {
            if (remainder == 0)
                return extraBarometricPressureToJSON();
            --remainder;
          }
        if (flagHasUVIndex)
          {
            if (remainder == 0)
                return extraUVIndexToJSON();
            --remainder;
          }
        if (flagHasCloudinessPct)
          {
            if (remainder == 0)
                return extraCloudinessPctToJSON();
            --remainder;
          }
        if (flagHasDailyForecasts)
          {
            if (remainder == 0)
                return extraDailyForecastsToJSON();
            --remainder;
          }
        if (flagHasHourlyForecasts)
          {
            if (remainder == 0)
                return extraHourlyForecastsToJSON();
            --remainder;
          }
        return extraShowWeatherCurrentConditionsInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraWeatherInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                switch (field_name[1])
                  {
                    case 'l':
                        switch (field_name[2])
                          {
                            case 'e':
                                if ((String.Compare(field_name, 3, "rts", 0, 3, false) == 0) && (field_name.Length == 6))
                                    return (flagHasAlerts ? extraAlertsToJSON() : null);
                                break;
                            case 'o':
                                if ((String.Compare(field_name, 3, "ngTheRoute", 0, 10, false) == 0) && (field_name.Length == 13))
                                    return (flagHasAlongTheRoute ? extraAlongTheRouteToJSON() : null);
                                break;
                            default:
                                break;
                          }
                        break;
                    case 't':
                        if ((String.Compare(field_name, 2, "tribution", 0, 9, false) == 0) && (field_name.Length == 11))
                            return (flagHasAttribution ? extraAttributionToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'B':
                if ((String.Compare(field_name, 1, "arometricPressure", 0, 17, false) == 0) && (field_name.Length == 18))
                    return (flagHasBarometricPressure ? extraBarometricPressureToJSON() : null);
                break;
            case 'C':
                switch (field_name[1])
                  {
                    case 'l':
                        if ((String.Compare(field_name, 2, "oudinessPct", 0, 11, false) == 0) && (field_name.Length == 13))
                            return (flagHasCloudinessPct ? extraCloudinessPctToJSON() : null);
                        break;
                    case 'o':
                        if (String.Compare(field_name, 2, "nditions", 0, 8, false) == 0)
                          {
                            switch (field_name[10])
                              {
                                case 'I':
                                    if ((String.Compare(field_name, 11, "mage", 0, 4, false) == 0) && (field_name.Length == 15))
                                        return (flagHasConditionsImage ? extraConditionsImageToJSON() : null);
                                    break;
                                case 'S':
                                    if ((String.Compare(field_name, 11, "hortPhrase", 0, 10, false) == 0) && (field_name.Length == 21))
                                        return (flagHasConditionsShortPhrase ? extraConditionsShortPhraseToJSON() : null);
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'u':
                        if ((String.Compare(field_name, 2, "rrentTemperature", 0, 16, false) == 0) && (field_name.Length == 18))
                            return (flagHasCurrentTemperature ? extraCurrentTemperatureToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                switch (field_name[1])
                  {
                    case 'a':
                        if ((String.Compare(field_name, 2, "ilyForecasts", 0, 12, false) == 0) && (field_name.Length == 14))
                            return (flagHasDailyForecasts ? extraDailyForecastsToJSON() : null);
                        break;
                    case 'e':
                        if ((String.Compare(field_name, 2, "wPoint", 0, 6, false) == 0) && (field_name.Length == 8))
                            return (flagHasDewPoint ? extraDewPointToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'F':
                if ((String.Compare(field_name, 1, "eelsLikeTemperature", 0, 19, false) == 0) && (field_name.Length == 20))
                    return (flagHasFeelsLikeTemperature ? extraFeelsLikeTemperatureToJSON() : null);
                break;
            case 'H':
                switch (field_name[1])
                  {
                    case 'e':
                        if ((String.Compare(field_name, 2, "atIndex", 0, 7, false) == 0) && (field_name.Length == 9))
                            return (flagHasHeatIndex ? extraHeatIndexToJSON() : null);
                        break;
                    case 'o':
                        if ((String.Compare(field_name, 2, "urlyForecasts", 0, 13, false) == 0) && (field_name.Length == 15))
                            return (flagHasHourlyForecasts ? extraHourlyForecastsToJSON() : null);
                        break;
                    case 'u':
                        if ((String.Compare(field_name, 2, "midityPct", 0, 9, false) == 0) && (field_name.Length == 11))
                            return (flagHasHumidityPct ? extraHumidityPctToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'I':
                if ((String.Compare(field_name, 1, "sYesNoQuery", 0, 11, false) == 0) && (field_name.Length == 12))
                    return (flagHasIsYesNoQuery ? extraIsYesNoQueryToJSON() : null);
                break;
            case 'L':
                if ((String.Compare(field_name, 1, "ocation", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasLocation ? extraLocationToJSON() : null);
                break;
            case 'O':
                if ((String.Compare(field_name, 1, "bservationDateAndTime", 0, 21, false) == 0) && (field_name.Length == 22))
                    return (flagHasObservationDateAndTime ? extraObservationDateAndTimeToJSON() : null);
                break;
            case 'P':
                if (String.Compare(field_name, 1, "recipitation", 0, 12, false) == 0)
                  {
                    switch (field_name[13])
                      {
                        case '1':
                            if ((String.Compare(field_name, 14, "Hour", 0, 4, false) == 0) && (field_name.Length == 18))
                                return (flagHasPrecipitation1Hour ? extraPrecipitation1HourToJSON() : null);
                            break;
                        case 'T':
                            if ((String.Compare(field_name, 14, "oday", 0, 4, false) == 0) && (field_name.Length == 18))
                                return (flagHasPrecipitationToday ? extraPrecipitationTodayToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if ((String.Compare(field_name, 1, "equestedAttribute", 0, 17, false) == 0) && (field_name.Length == 18))
                    return (flagHasRequestedAttribute ? extraRequestedAttributeToJSON() : null);
                break;
            case 'U':
                if ((String.Compare(field_name, 1, "VIndex", 0, 6, false) == 0) && (field_name.Length == 7))
                    return (flagHasUVIndex ? extraUVIndexToJSON() : null);
                break;
            case 'V':
                if ((String.Compare(field_name, 1, "isibility", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasVisibility ? extraVisibilityToJSON() : null);
                break;
            case 'W':
                switch (field_name[1])
                  {
                    case 'e':
                        if (String.Compare(field_name, 2, "ather", 0, 5, false) == 0)
                          {
                            switch (field_name[7])
                              {
                                case 'I':
                                    if ((String.Compare(field_name, 8, "conURL", 0, 6, false) == 0) && (field_name.Length == 14))
                                        return (flagHasWeatherIconURL ? extraWeatherIconURLToJSON() : null);
                                    break;
                                case 'M':
                                    if ((String.Compare(field_name, 8, "apRequested", 0, 11, false) == 0) && (field_name.Length == 19))
                                        return (flagHasWeatherMapRequested ? extraWeatherMapRequestedToJSON() : null);
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'i':
                        if (String.Compare(field_name, 2, "nd", 0, 2, false) == 0)
                          {
                            if (field_name.Length == 4)
                              {
                                return (flagHasWind ? extraWindToJSON() : null);
                              }
                            switch (field_name[4])
                              {
                                case 'G':
                                    if ((String.Compare(field_name, 5, "ust", 0, 3, false) == 0) && (field_name.Length == 8))
                                        return (flagHasWindGust ? extraWindGustToJSON() : null);
                                    break;
                                case 'c':
                                    if ((String.Compare(field_name, 5, "hill", 0, 4, false) == 0) && (field_name.Length == 9))
                                        return (flagHasWindchill ? extraWindchillToJSON() : null);
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
        return extraShowWeatherCurrentConditionsInformationNuggetLookup(field_name);
      }

    public void setAttribution(AttributionJSON  new_value)
      {
        if (flagHasAttribution)
          {
          }
        flagHasAttribution = true;
        storeAttribution = new_value;
      }
    public void unsetAttribution()
      {
        if (flagHasAttribution)
          {
          }
        flagHasAttribution = false;
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
    public void initAlerts()
      {
        if (flagHasAlerts)
          {
            for (int num1 = 0; num1 < storeAlerts.Count; ++num1)
              {
              }
          }
        flagHasAlerts = true;
        storeAlerts.Clear();
      }
    public void appendAlerts(AlertJSON  to_append)
      {
        if (!flagHasAlerts)
          {
            flagHasAlerts = true;
            storeAlerts.Clear();
          }
        Debug.Assert(flagHasAlerts);
        storeAlerts.Add(to_append);
      }
    public void unsetAlerts()
      {
        if (flagHasAlerts)
          {
            for (int num2 = 0; num2 < storeAlerts.Count; ++num2)
              {
              }
          }
        flagHasAlerts = false;
        storeAlerts.Clear();
      }
    public void setRequestedAttribute(string new_value)
      {
        flagHasRequestedAttribute = true;
        storeRequestedAttribute = new_value;
      }
    public void unsetRequestedAttribute()
      {
        flagHasRequestedAttribute = false;
      }
    public void setIsYesNoQuery(bool new_value)
      {
        flagHasIsYesNoQuery = true;
        storeIsYesNoQuery = new_value;
      }
    public void unsetIsYesNoQuery()
      {
        flagHasIsYesNoQuery = false;
      }
    public void setWeatherMapRequested(bool new_value)
      {
        flagHasWeatherMapRequested = true;
        storeWeatherMapRequested = new_value;
      }
    public void unsetWeatherMapRequested()
      {
        flagHasWeatherMapRequested = false;
      }
    public void setAlongTheRoute(bool new_value)
      {
        flagHasAlongTheRoute = true;
        storeAlongTheRoute = new_value;
      }
    public void unsetAlongTheRoute()
      {
        flagHasAlongTheRoute = false;
      }
    public void setObservationDateAndTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasObservationDateAndTime)
          {
          }
        flagHasObservationDateAndTime = true;
        storeObservationDateAndTime = new_value;
      }
    public void unsetObservationDateAndTime()
      {
        if (flagHasObservationDateAndTime)
          {
          }
        flagHasObservationDateAndTime = false;
      }
    public void setConditionsShortPhrase(string new_value)
      {
        flagHasConditionsShortPhrase = true;
        storeConditionsShortPhrase = new_value;
      }
    public void unsetConditionsShortPhrase()
      {
        flagHasConditionsShortPhrase = false;
      }
    public void setCurrentTemperature(TypeCurrentTemperatureJSON  new_value)
      {
        if (flagHasCurrentTemperature)
          {
          }
        flagHasCurrentTemperature = true;
        storeCurrentTemperature = new_value;
      }
    public void unsetCurrentTemperature()
      {
        if (flagHasCurrentTemperature)
          {
          }
        flagHasCurrentTemperature = false;
      }
    public void setFeelsLikeTemperature(TypeFeelsLikeTemperatureJSON  new_value)
      {
        if (flagHasFeelsLikeTemperature)
          {
          }
        flagHasFeelsLikeTemperature = true;
        storeFeelsLikeTemperature = new_value;
      }
    public void unsetFeelsLikeTemperature()
      {
        if (flagHasFeelsLikeTemperature)
          {
          }
        flagHasFeelsLikeTemperature = false;
      }
    public void setHeatIndex(TypeHeatIndexJSON  new_value)
      {
        if (flagHasHeatIndex)
          {
          }
        flagHasHeatIndex = true;
        storeHeatIndex = new_value;
      }
    public void unsetHeatIndex()
      {
        if (flagHasHeatIndex)
          {
          }
        flagHasHeatIndex = false;
      }
    public void setWindchill(TypeWindchillJSON  new_value)
      {
        if (flagHasWindchill)
          {
          }
        flagHasWindchill = true;
        storeWindchill = new_value;
      }
    public void unsetWindchill()
      {
        if (flagHasWindchill)
          {
          }
        flagHasWindchill = false;
      }
    public void setDewPoint(TypeDewPointJSON  new_value)
      {
        if (flagHasDewPoint)
          {
          }
        flagHasDewPoint = true;
        storeDewPoint = new_value;
      }
    public void unsetDewPoint()
      {
        if (flagHasDewPoint)
          {
          }
        flagHasDewPoint = false;
      }
    public void setWeatherIconURL(string new_value)
      {
        flagHasWeatherIconURL = true;
        storeWeatherIconURL = new_value;
      }
    public void unsetWeatherIconURL()
      {
        flagHasWeatherIconURL = false;
      }
    public void setConditionsImage(WeatherImageJSON  new_value)
      {
        if (flagHasConditionsImage)
          {
          }
        flagHasConditionsImage = true;
        storeConditionsImage = new_value;
      }
    public void unsetConditionsImage()
      {
        if (flagHasConditionsImage)
          {
          }
        flagHasConditionsImage = false;
      }
    public void setHumidityPct(sbyte new_value)
      {
        flagHasHumidityPct = true;
        if (new_value < 0)
            throw new Exception("The value for field HumidityPct of ShowWeatherCurrentConditionsInformationNuggetJSON is less than the lower bound (0) for that field.");
        if (new_value > 100)
            throw new Exception("The value for field HumidityPct of ShowWeatherCurrentConditionsInformationNuggetJSON is greater than the upper bound (100) for that field.");
        storeHumidityPct = new_value;
      }
    public void unsetHumidityPct()
      {
        flagHasHumidityPct = false;
      }
    public void setVisibility(TypeVisibilityJSON  new_value)
      {
        if (flagHasVisibility)
          {
          }
        flagHasVisibility = true;
        storeVisibility = new_value;
      }
    public void unsetVisibility()
      {
        if (flagHasVisibility)
          {
          }
        flagHasVisibility = false;
      }
    public void setPrecipitation1Hour(TypePrecipitation1HourJSON  new_value)
      {
        if (flagHasPrecipitation1Hour)
          {
          }
        flagHasPrecipitation1Hour = true;
        storePrecipitation1Hour = new_value;
      }
    public void unsetPrecipitation1Hour()
      {
        if (flagHasPrecipitation1Hour)
          {
          }
        flagHasPrecipitation1Hour = false;
      }
    public void setPrecipitationToday(TypePrecipitationTodayJSON  new_value)
      {
        if (flagHasPrecipitationToday)
          {
          }
        flagHasPrecipitationToday = true;
        storePrecipitationToday = new_value;
      }
    public void unsetPrecipitationToday()
      {
        if (flagHasPrecipitationToday)
          {
          }
        flagHasPrecipitationToday = false;
      }
    public void setWind(TypeWindJSON  new_value)
      {
        if (flagHasWind)
          {
          }
        flagHasWind = true;
        storeWind = new_value;
      }
    public void unsetWind()
      {
        if (flagHasWind)
          {
          }
        flagHasWind = false;
      }
    public void setWindGust(TypeWindGustJSON  new_value)
      {
        if (flagHasWindGust)
          {
          }
        flagHasWindGust = true;
        storeWindGust = new_value;
      }
    public void unsetWindGust()
      {
        if (flagHasWindGust)
          {
          }
        flagHasWindGust = false;
      }
    public void setBarometricPressure(TypeBarometricPressureJSON  new_value)
      {
        if (flagHasBarometricPressure)
          {
          }
        flagHasBarometricPressure = true;
        storeBarometricPressure = new_value;
      }
    public void unsetBarometricPressure()
      {
        if (flagHasBarometricPressure)
          {
          }
        flagHasBarometricPressure = false;
      }
    public void setUVIndex(TypeUVIndexJSON  new_value)
      {
        if (flagHasUVIndex)
          {
          }
        flagHasUVIndex = true;
        storeUVIndex = new_value;
      }
    public void unsetUVIndex()
      {
        if (flagHasUVIndex)
          {
          }
        flagHasUVIndex = false;
      }
    public void setCloudinessPct(sbyte new_value)
      {
        flagHasCloudinessPct = true;
        if (new_value < 0)
            throw new Exception("The value for field CloudinessPct of ShowWeatherCurrentConditionsInformationNuggetJSON is less than the lower bound (0) for that field.");
        if (new_value > 100)
            throw new Exception("The value for field CloudinessPct of ShowWeatherCurrentConditionsInformationNuggetJSON is greater than the upper bound (100) for that field.");
        storeCloudinessPct = new_value;
      }
    public void unsetCloudinessPct()
      {
        flagHasCloudinessPct = false;
      }
    public void initDailyForecasts()
      {
        if (flagHasDailyForecasts)
          {
            for (int num3 = 0; num3 < storeDailyForecasts.Count; ++num3)
              {
              }
          }
        flagHasDailyForecasts = true;
        storeDailyForecasts.Clear();
      }
    public void appendDailyForecasts(DailyForecastJSON  to_append)
      {
        if (!flagHasDailyForecasts)
          {
            flagHasDailyForecasts = true;
            storeDailyForecasts.Clear();
          }
        Debug.Assert(flagHasDailyForecasts);
        storeDailyForecasts.Add(to_append);
      }
    public void unsetDailyForecasts()
      {
        if (flagHasDailyForecasts)
          {
            for (int num4 = 0; num4 < storeDailyForecasts.Count; ++num4)
              {
              }
          }
        flagHasDailyForecasts = false;
        storeDailyForecasts.Clear();
      }
    public void initHourlyForecasts()
      {
        if (flagHasHourlyForecasts)
          {
            for (int num5 = 0; num5 < storeHourlyForecasts.Count; ++num5)
              {
              }
          }
        flagHasHourlyForecasts = true;
        storeHourlyForecasts.Clear();
      }
    public void appendHourlyForecasts(HourlyForecastJSON  to_append)
      {
        if (!flagHasHourlyForecasts)
          {
            flagHasHourlyForecasts = true;
            storeHourlyForecasts.Clear();
          }
        Debug.Assert(flagHasHourlyForecasts);
        storeHourlyForecasts.Add(to_append);
      }
    public void unsetHourlyForecasts()
      {
        if (flagHasHourlyForecasts)
          {
            for (int num6 = 0; num6 < storeHourlyForecasts.Count; ++num6)
              {
              }
          }
        flagHasHourlyForecasts = false;
        storeHourlyForecasts.Clear();
      }

    public virtual void extraShowWeatherCurrentConditionsInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraShowWeatherCurrentConditionsInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraShowWeatherCurrentConditionsInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraShowWeatherCurrentConditionsInformationNuggetAppendPair(key, new_component);
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
    public override void extraWeatherInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                switch (key[1])
                  {
                    case 'l':
                        switch (key[2])
                          {
                            case 'e':
                                if ((String.Compare(key, 3, "rts", 0, 3, false) == 0) && (key.Length == 6))
                                    {
                                    fromJSONAlerts(new_component, false);
                                    return;
                                    }
                                break;
                            case 'o':
                                if ((String.Compare(key, 3, "ngTheRoute", 0, 10, false) == 0) && (key.Length == 13))
                                    {
                                    fromJSONAlongTheRoute(new_component, false);
                                    return;
                                    }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 't':
                        if ((String.Compare(key, 2, "tribution", 0, 9, false) == 0) && (key.Length == 11))
                            {
                            fromJSONAttribution(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'B':
                if ((String.Compare(key, 1, "arometricPressure", 0, 17, false) == 0) && (key.Length == 18))
                    {
                    fromJSONBarometricPressure(new_component, false);
                    return;
                    }
                break;
            case 'C':
                switch (key[1])
                  {
                    case 'l':
                        if ((String.Compare(key, 2, "oudinessPct", 0, 11, false) == 0) && (key.Length == 13))
                            {
                            fromJSONCloudinessPct(new_component, false);
                            return;
                            }
                        break;
                    case 'o':
                        if (String.Compare(key, 2, "nditions", 0, 8, false) == 0)
                          {
                            switch (key[10])
                              {
                                case 'I':
                                    if ((String.Compare(key, 11, "mage", 0, 4, false) == 0) && (key.Length == 15))
                                        {
                                        fromJSONConditionsImage(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'S':
                                    if ((String.Compare(key, 11, "hortPhrase", 0, 10, false) == 0) && (key.Length == 21))
                                        {
                                        fromJSONConditionsShortPhrase(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'u':
                        if ((String.Compare(key, 2, "rrentTemperature", 0, 16, false) == 0) && (key.Length == 18))
                            {
                            fromJSONCurrentTemperature(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "ilyForecasts", 0, 12, false) == 0) && (key.Length == 14))
                            {
                            fromJSONDailyForecasts(new_component, false);
                            return;
                            }
                        break;
                    case 'e':
                        if ((String.Compare(key, 2, "wPoint", 0, 6, false) == 0) && (key.Length == 8))
                            {
                            fromJSONDewPoint(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'F':
                if ((String.Compare(key, 1, "eelsLikeTemperature", 0, 19, false) == 0) && (key.Length == 20))
                    {
                    fromJSONFeelsLikeTemperature(new_component, false);
                    return;
                    }
                break;
            case 'H':
                switch (key[1])
                  {
                    case 'e':
                        if ((String.Compare(key, 2, "atIndex", 0, 7, false) == 0) && (key.Length == 9))
                            {
                            fromJSONHeatIndex(new_component, false);
                            return;
                            }
                        break;
                    case 'o':
                        if ((String.Compare(key, 2, "urlyForecasts", 0, 13, false) == 0) && (key.Length == 15))
                            {
                            fromJSONHourlyForecasts(new_component, false);
                            return;
                            }
                        break;
                    case 'u':
                        if ((String.Compare(key, 2, "midityPct", 0, 9, false) == 0) && (key.Length == 11))
                            {
                            fromJSONHumidityPct(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'I':
                if ((String.Compare(key, 1, "sYesNoQuery", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONIsYesNoQuery(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "ocation", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONLocation(new_component, false);
                    return;
                    }
                break;
            case 'O':
                if ((String.Compare(key, 1, "bservationDateAndTime", 0, 21, false) == 0) && (key.Length == 22))
                    {
                    fromJSONObservationDateAndTime(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if (String.Compare(key, 1, "recipitation", 0, 12, false) == 0)
                  {
                    switch (key[13])
                      {
                        case '1':
                            if ((String.Compare(key, 14, "Hour", 0, 4, false) == 0) && (key.Length == 18))
                                {
                                fromJSONPrecipitation1Hour(new_component, false);
                                return;
                                }
                            break;
                        case 'T':
                            if ((String.Compare(key, 14, "oday", 0, 4, false) == 0) && (key.Length == 18))
                                {
                                fromJSONPrecipitationToday(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if ((String.Compare(key, 1, "equestedAttribute", 0, 17, false) == 0) && (key.Length == 18))
                    {
                    fromJSONRequestedAttribute(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if ((String.Compare(key, 1, "VIndex", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONUVIndex(new_component, false);
                    return;
                    }
                break;
            case 'V':
                if ((String.Compare(key, 1, "isibility", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONVisibility(new_component, false);
                    return;
                    }
                break;
            case 'W':
                switch (key[1])
                  {
                    case 'e':
                        if (String.Compare(key, 2, "ather", 0, 5, false) == 0)
                          {
                            switch (key[7])
                              {
                                case 'I':
                                    if ((String.Compare(key, 8, "conURL", 0, 6, false) == 0) && (key.Length == 14))
                                        {
                                        fromJSONWeatherIconURL(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'M':
                                    if ((String.Compare(key, 8, "apRequested", 0, 11, false) == 0) && (key.Length == 19))
                                        {
                                        fromJSONWeatherMapRequested(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'i':
                        if (String.Compare(key, 2, "nd", 0, 2, false) == 0)
                          {
                            if (key.Length == 4)
                              {
                                {
                                fromJSONWind(new_component, false);
                                return;
                                }
                              }
                            switch (key[4])
                              {
                                case 'G':
                                    if ((String.Compare(key, 5, "ust", 0, 3, false) == 0) && (key.Length == 8))
                                        {
                                        fromJSONWindGust(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'c':
                                    if ((String.Compare(key, 5, "hill", 0, 4, false) == 0) && (key.Length == 9))
                                        {
                                        fromJSONWindchill(new_component, false);
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
        extraShowWeatherCurrentConditionsInformationNuggetAppendPair(key, new_component);
      }
    public override void extraWeatherInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                switch (key[1])
                  {
                    case 'l':
                        switch (key[2])
                          {
                            case 'e':
                                if ((String.Compare(key, 3, "rts", 0, 3, false) == 0) && (key.Length == 6))
                                    {
                                    fromJSONAlerts(new_component, false);
                                    return;
                                    }
                                break;
                            case 'o':
                                if ((String.Compare(key, 3, "ngTheRoute", 0, 10, false) == 0) && (key.Length == 13))
                                    {
                                    fromJSONAlongTheRoute(new_component, false);
                                    return;
                                    }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 't':
                        if ((String.Compare(key, 2, "tribution", 0, 9, false) == 0) && (key.Length == 11))
                            {
                            fromJSONAttribution(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'B':
                if ((String.Compare(key, 1, "arometricPressure", 0, 17, false) == 0) && (key.Length == 18))
                    {
                    fromJSONBarometricPressure(new_component, false);
                    return;
                    }
                break;
            case 'C':
                switch (key[1])
                  {
                    case 'l':
                        if ((String.Compare(key, 2, "oudinessPct", 0, 11, false) == 0) && (key.Length == 13))
                            {
                            fromJSONCloudinessPct(new_component, false);
                            return;
                            }
                        break;
                    case 'o':
                        if (String.Compare(key, 2, "nditions", 0, 8, false) == 0)
                          {
                            switch (key[10])
                              {
                                case 'I':
                                    if ((String.Compare(key, 11, "mage", 0, 4, false) == 0) && (key.Length == 15))
                                        {
                                        fromJSONConditionsImage(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'S':
                                    if ((String.Compare(key, 11, "hortPhrase", 0, 10, false) == 0) && (key.Length == 21))
                                        {
                                        fromJSONConditionsShortPhrase(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'u':
                        if ((String.Compare(key, 2, "rrentTemperature", 0, 16, false) == 0) && (key.Length == 18))
                            {
                            fromJSONCurrentTemperature(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "ilyForecasts", 0, 12, false) == 0) && (key.Length == 14))
                            {
                            fromJSONDailyForecasts(new_component, false);
                            return;
                            }
                        break;
                    case 'e':
                        if ((String.Compare(key, 2, "wPoint", 0, 6, false) == 0) && (key.Length == 8))
                            {
                            fromJSONDewPoint(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'F':
                if ((String.Compare(key, 1, "eelsLikeTemperature", 0, 19, false) == 0) && (key.Length == 20))
                    {
                    fromJSONFeelsLikeTemperature(new_component, false);
                    return;
                    }
                break;
            case 'H':
                switch (key[1])
                  {
                    case 'e':
                        if ((String.Compare(key, 2, "atIndex", 0, 7, false) == 0) && (key.Length == 9))
                            {
                            fromJSONHeatIndex(new_component, false);
                            return;
                            }
                        break;
                    case 'o':
                        if ((String.Compare(key, 2, "urlyForecasts", 0, 13, false) == 0) && (key.Length == 15))
                            {
                            fromJSONHourlyForecasts(new_component, false);
                            return;
                            }
                        break;
                    case 'u':
                        if ((String.Compare(key, 2, "midityPct", 0, 9, false) == 0) && (key.Length == 11))
                            {
                            fromJSONHumidityPct(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'I':
                if ((String.Compare(key, 1, "sYesNoQuery", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONIsYesNoQuery(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "ocation", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONLocation(new_component, false);
                    return;
                    }
                break;
            case 'O':
                if ((String.Compare(key, 1, "bservationDateAndTime", 0, 21, false) == 0) && (key.Length == 22))
                    {
                    fromJSONObservationDateAndTime(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if (String.Compare(key, 1, "recipitation", 0, 12, false) == 0)
                  {
                    switch (key[13])
                      {
                        case '1':
                            if ((String.Compare(key, 14, "Hour", 0, 4, false) == 0) && (key.Length == 18))
                                {
                                fromJSONPrecipitation1Hour(new_component, false);
                                return;
                                }
                            break;
                        case 'T':
                            if ((String.Compare(key, 14, "oday", 0, 4, false) == 0) && (key.Length == 18))
                                {
                                fromJSONPrecipitationToday(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if ((String.Compare(key, 1, "equestedAttribute", 0, 17, false) == 0) && (key.Length == 18))
                    {
                    fromJSONRequestedAttribute(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if ((String.Compare(key, 1, "VIndex", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONUVIndex(new_component, false);
                    return;
                    }
                break;
            case 'V':
                if ((String.Compare(key, 1, "isibility", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONVisibility(new_component, false);
                    return;
                    }
                break;
            case 'W':
                switch (key[1])
                  {
                    case 'e':
                        if (String.Compare(key, 2, "ather", 0, 5, false) == 0)
                          {
                            switch (key[7])
                              {
                                case 'I':
                                    if ((String.Compare(key, 8, "conURL", 0, 6, false) == 0) && (key.Length == 14))
                                        {
                                        fromJSONWeatherIconURL(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'M':
                                    if ((String.Compare(key, 8, "apRequested", 0, 11, false) == 0) && (key.Length == 19))
                                        {
                                        fromJSONWeatherMapRequested(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'i':
                        if (String.Compare(key, 2, "nd", 0, 2, false) == 0)
                          {
                            if (key.Length == 4)
                              {
                                {
                                fromJSONWind(new_component, false);
                                return;
                                }
                              }
                            switch (key[4])
                              {
                                case 'G':
                                    if ((String.Compare(key, 5, "ust", 0, 3, false) == 0) && (key.Length == 8))
                                        {
                                        fromJSONWindGust(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'c':
                                    if ((String.Compare(key, 5, "hill", 0, 4, false) == 0) && (key.Length == 9))
                                        {
                                        fromJSONWindchill(new_component, false);
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
        extraShowWeatherCurrentConditionsInformationNuggetSetField(key, new_component);
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
        if (flagHasAttribution)
          {
            handler.start_pair("Attribution");
            if (partial_allowed)
                storeAttribution.write_partial_as_json(handler);
            else
                storeAttribution.write_as_json(handler);
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
        Debug.Assert(partial_allowed || flagHasAlerts);
        if (flagHasAlerts)
          {
            handler.start_pair("Alerts");
            handler.start_array();
            for (int num1 = 0; num1 < storeAlerts.Count; ++num1)
              {
                if (partial_allowed)
                    storeAlerts[num1].write_partial_as_json(handler);
                else
                    storeAlerts[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasRequestedAttribute);
        if (flagHasRequestedAttribute)
          {
            handler.start_pair("RequestedAttribute");
            handler.string_value(storeRequestedAttribute);
          }
        Debug.Assert(partial_allowed || flagHasIsYesNoQuery);
        if (flagHasIsYesNoQuery)
          {
            handler.start_pair("IsYesNoQuery");
            handler.boolean_value(storeIsYesNoQuery);
          }
        if (flagHasWeatherMapRequested)
          {
            handler.start_pair("WeatherMapRequested");
            handler.boolean_value(storeWeatherMapRequested);
          }
        if (flagHasAlongTheRoute)
          {
            handler.start_pair("AlongTheRoute");
            handler.boolean_value(storeAlongTheRoute);
          }
        Debug.Assert(partial_allowed || flagHasObservationDateAndTime);
        if (flagHasObservationDateAndTime)
          {
            handler.start_pair("ObservationDateAndTime");
            if (partial_allowed)
                storeObservationDateAndTime.write_partial_as_json(handler);
            else
                storeObservationDateAndTime.write_as_json(handler);
          }
        if (flagHasConditionsShortPhrase)
          {
            handler.start_pair("ConditionsShortPhrase");
            handler.string_value(storeConditionsShortPhrase);
          }
        if (flagHasCurrentTemperature)
          {
            handler.start_pair("CurrentTemperature");
            if (partial_allowed)
                storeCurrentTemperature.write_partial_as_json(handler);
            else
                storeCurrentTemperature.write_as_json(handler);
          }
        if (flagHasFeelsLikeTemperature)
          {
            handler.start_pair("FeelsLikeTemperature");
            if (partial_allowed)
                storeFeelsLikeTemperature.write_partial_as_json(handler);
            else
                storeFeelsLikeTemperature.write_as_json(handler);
          }
        if (flagHasHeatIndex)
          {
            handler.start_pair("HeatIndex");
            if (partial_allowed)
                storeHeatIndex.write_partial_as_json(handler);
            else
                storeHeatIndex.write_as_json(handler);
          }
        if (flagHasWindchill)
          {
            handler.start_pair("Windchill");
            if (partial_allowed)
                storeWindchill.write_partial_as_json(handler);
            else
                storeWindchill.write_as_json(handler);
          }
        if (flagHasDewPoint)
          {
            handler.start_pair("DewPoint");
            if (partial_allowed)
                storeDewPoint.write_partial_as_json(handler);
            else
                storeDewPoint.write_as_json(handler);
          }
        if (flagHasWeatherIconURL)
          {
            handler.start_pair("WeatherIconURL");
            handler.string_value(storeWeatherIconURL);
          }
        if (flagHasConditionsImage)
          {
            handler.start_pair("ConditionsImage");
            if (partial_allowed)
                storeConditionsImage.write_partial_as_json(handler);
            else
                storeConditionsImage.write_as_json(handler);
          }
        if (flagHasHumidityPct)
          {
            handler.start_pair("HumidityPct");
            handler.number_value(storeHumidityPct);
          }
        if (flagHasVisibility)
          {
            handler.start_pair("Visibility");
            if (partial_allowed)
                storeVisibility.write_partial_as_json(handler);
            else
                storeVisibility.write_as_json(handler);
          }
        if (flagHasPrecipitation1Hour)
          {
            handler.start_pair("Precipitation1Hour");
            if (partial_allowed)
                storePrecipitation1Hour.write_partial_as_json(handler);
            else
                storePrecipitation1Hour.write_as_json(handler);
          }
        if (flagHasPrecipitationToday)
          {
            handler.start_pair("PrecipitationToday");
            if (partial_allowed)
                storePrecipitationToday.write_partial_as_json(handler);
            else
                storePrecipitationToday.write_as_json(handler);
          }
        if (flagHasWind)
          {
            handler.start_pair("Wind");
            if (partial_allowed)
                storeWind.write_partial_as_json(handler);
            else
                storeWind.write_as_json(handler);
          }
        if (flagHasWindGust)
          {
            handler.start_pair("WindGust");
            if (partial_allowed)
                storeWindGust.write_partial_as_json(handler);
            else
                storeWindGust.write_as_json(handler);
          }
        if (flagHasBarometricPressure)
          {
            handler.start_pair("BarometricPressure");
            if (partial_allowed)
                storeBarometricPressure.write_partial_as_json(handler);
            else
                storeBarometricPressure.write_as_json(handler);
          }
        if (flagHasUVIndex)
          {
            handler.start_pair("UVIndex");
            if (partial_allowed)
                storeUVIndex.write_partial_as_json(handler);
            else
                storeUVIndex.write_as_json(handler);
          }
        if (flagHasCloudinessPct)
          {
            handler.start_pair("CloudinessPct");
            handler.number_value(storeCloudinessPct);
          }
        Debug.Assert(partial_allowed || flagHasDailyForecasts);
        if (flagHasDailyForecasts)
          {
            handler.start_pair("DailyForecasts");
            handler.start_array();
            for (int num2 = 0; num2 < storeDailyForecasts.Count; ++num2)
              {
                if (partial_allowed)
                    storeDailyForecasts[num2].write_partial_as_json(handler);
                else
                    storeDailyForecasts[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasHourlyForecasts);
        if (flagHasHourlyForecasts)
          {
            handler.start_pair("HourlyForecasts");
            handler.start_array();
            for (int num3 = 0; num3 < storeHourlyForecasts.Count; ++num3)
              {
                if (partial_allowed)
                    storeHourlyForecasts[num3].write_partial_as_json(handler);
                else
                    storeHourlyForecasts[num3].write_as_json(handler);
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
        if (!(hasLocation()))
          {
            return "When parsing the object for %what%, the \"Location\" field was missing.";
          }
        if (!(hasAlerts()))
          {
            return "When parsing the object for %what%, the \"Alerts\" field was missing.";
          }
        if (!(hasRequestedAttribute()))
          {
            return "When parsing the object for %what%, the \"RequestedAttribute\" field was missing.";
          }
        if (!(hasIsYesNoQuery()))
          {
            return "When parsing the object for %what%, the \"IsYesNoQuery\" field was missing.";
          }
        if (!(hasObservationDateAndTime()))
          {
            return "When parsing the object for %what%, the \"ObservationDateAndTime\" field was missing.";
          }
        if (!(hasDailyForecasts()))
          {
            return "When parsing the object for %what%, the \"DailyForecasts\" field was missing.";
          }
        if (!(hasHourlyForecasts()))
          {
            return "When parsing the object for %what%, the \"HourlyForecasts\" field was missing.";
          }
        return null;
      }

    public static new ShowWeatherCurrentConditionsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ShowWeatherCurrentConditionsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowWeatherCurrentConditionsInformationNugget", ignore_extras);
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
    public static new ShowWeatherCurrentConditionsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ShowWeatherCurrentConditionsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ShowWeatherCurrentConditionsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowWeatherCurrentConditionsInformationNugget", ignore_extras);
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
    public static new ShowWeatherCurrentConditionsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ShowWeatherCurrentConditionsInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        ShowWeatherCurrentConditionsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowWeatherCurrentConditionsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ShowWeatherCurrentConditionsInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ShowWeatherCurrentConditionsInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ShowWeatherCurrentConditionsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowWeatherCurrentConditionsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : WeatherInformationNuggetJSON.Generator
      {
        private AttributionJSON.HoldingGenerator fieldGeneratorAttribution;
        private MapLocationJSON.HoldingGenerator fieldGeneratorLocation;
        private AlertJSON.HoldingArrayGenerator fieldGeneratorAlerts;
        private JSONHoldingStringGenerator fieldGeneratorRequestedAttribute;
        private JSONHoldingBooleanGenerator fieldGeneratorIsYesNoQuery;
        private JSONHoldingBooleanGenerator fieldGeneratorWeatherMapRequested;
        private JSONHoldingBooleanGenerator fieldGeneratorAlongTheRoute;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorObservationDateAndTime;
        private JSONHoldingStringGenerator fieldGeneratorConditionsShortPhrase;
        private TypeCurrentTemperatureJSON.HoldingGenerator fieldGeneratorCurrentTemperature;
        private TypeFeelsLikeTemperatureJSON.HoldingGenerator fieldGeneratorFeelsLikeTemperature;
        private TypeHeatIndexJSON.HoldingGenerator fieldGeneratorHeatIndex;
        private TypeWindchillJSON.HoldingGenerator fieldGeneratorWindchill;
        private TypeDewPointJSON.HoldingGenerator fieldGeneratorDewPoint;
        private JSONHoldingStringGenerator fieldGeneratorWeatherIconURL;
        private WeatherImageJSON.HoldingGenerator fieldGeneratorConditionsImage;
    private class FieldHoldingGeneratorHumidityPct : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorHumidityPct(String what) : base(what, 0, 100)
              {
              }
          };
    private class FieldHoldingArrayGeneratorHumidityPct : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorHumidityPct(String what) : base(what, 0, 100)
              {
              }
          };
        private FieldHoldingGeneratorHumidityPct fieldGeneratorHumidityPct;
        private TypeVisibilityJSON.HoldingGenerator fieldGeneratorVisibility;
        private TypePrecipitation1HourJSON.HoldingGenerator fieldGeneratorPrecipitation1Hour;
        private TypePrecipitationTodayJSON.HoldingGenerator fieldGeneratorPrecipitationToday;
        private TypeWindJSON.HoldingGenerator fieldGeneratorWind;
        private TypeWindGustJSON.HoldingGenerator fieldGeneratorWindGust;
        private TypeBarometricPressureJSON.HoldingGenerator fieldGeneratorBarometricPressure;
        private TypeUVIndexJSON.HoldingGenerator fieldGeneratorUVIndex;
    private class FieldHoldingGeneratorCloudinessPct : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorCloudinessPct(String what) : base(what, 0, 100)
              {
              }
          };
    private class FieldHoldingArrayGeneratorCloudinessPct : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorCloudinessPct(String what) : base(what, 0, 100)
              {
              }
          };
        private FieldHoldingGeneratorCloudinessPct fieldGeneratorCloudinessPct;
        private DailyForecastJSON.HoldingArrayGenerator fieldGeneratorDailyForecasts;
        private HourlyForecastJSON.HoldingArrayGenerator fieldGeneratorHourlyForecasts;
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
            if (!(getWeatherInformationNuggetJSONKey().Equals("ShowWeatherCurrentConditions")))
                throw new Exception("The key field has a value other than `ShowWeatherCurrentConditions'.");
            ShowWeatherCurrentConditionsInformationNuggetJSON result = new ShowWeatherCurrentConditionsInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraShowWeatherCurrentConditionsInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(WeatherInformationNuggetJSON new_result)
          {
            handle_result((ShowWeatherCurrentConditionsInformationNuggetJSON )new_result);
          }
        protected void finish(ShowWeatherCurrentConditionsInformationNuggetJSON result)
          {
            if (fieldGeneratorAttribution.have_value)
              {
                result.setAttribution(fieldGeneratorAttribution.value);
                fieldGeneratorAttribution.have_value = false;
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
            if (fieldGeneratorAlerts.have_value)
              {
                result.initAlerts();
                int count = fieldGeneratorAlerts.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAlerts(fieldGeneratorAlerts.value[num]);
                  }
                fieldGeneratorAlerts.value.Clear();
                fieldGeneratorAlerts.have_value = false;
              }
            else if ((!(result.hasAlerts())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Alerts\" field was missing.");
              }
            if (fieldGeneratorRequestedAttribute.have_value)
              {
                result.setRequestedAttribute(fieldGeneratorRequestedAttribute.value);
                fieldGeneratorRequestedAttribute.have_value = false;
              }
            else if ((!(result.hasRequestedAttribute())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RequestedAttribute\" field was missing.");
              }
            if (fieldGeneratorIsYesNoQuery.have_value)
              {
                result.setIsYesNoQuery(fieldGeneratorIsYesNoQuery.value);
                fieldGeneratorIsYesNoQuery.have_value = false;
              }
            else if ((!(result.hasIsYesNoQuery())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"IsYesNoQuery\" field was missing.");
              }
            if (fieldGeneratorWeatherMapRequested.have_value)
              {
                result.setWeatherMapRequested(fieldGeneratorWeatherMapRequested.value);
                fieldGeneratorWeatherMapRequested.have_value = false;
              }
            if (fieldGeneratorAlongTheRoute.have_value)
              {
                result.setAlongTheRoute(fieldGeneratorAlongTheRoute.value);
                fieldGeneratorAlongTheRoute.have_value = false;
              }
            if (fieldGeneratorObservationDateAndTime.have_value)
              {
                result.setObservationDateAndTime(fieldGeneratorObservationDateAndTime.value);
                fieldGeneratorObservationDateAndTime.have_value = false;
              }
            else if ((!(result.hasObservationDateAndTime())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ObservationDateAndTime\" field was missing.");
              }
            if (fieldGeneratorConditionsShortPhrase.have_value)
              {
                result.setConditionsShortPhrase(fieldGeneratorConditionsShortPhrase.value);
                fieldGeneratorConditionsShortPhrase.have_value = false;
              }
            if (fieldGeneratorCurrentTemperature.have_value)
              {
                result.setCurrentTemperature(fieldGeneratorCurrentTemperature.value);
                fieldGeneratorCurrentTemperature.have_value = false;
              }
            if (fieldGeneratorFeelsLikeTemperature.have_value)
              {
                result.setFeelsLikeTemperature(fieldGeneratorFeelsLikeTemperature.value);
                fieldGeneratorFeelsLikeTemperature.have_value = false;
              }
            if (fieldGeneratorHeatIndex.have_value)
              {
                result.setHeatIndex(fieldGeneratorHeatIndex.value);
                fieldGeneratorHeatIndex.have_value = false;
              }
            if (fieldGeneratorWindchill.have_value)
              {
                result.setWindchill(fieldGeneratorWindchill.value);
                fieldGeneratorWindchill.have_value = false;
              }
            if (fieldGeneratorDewPoint.have_value)
              {
                result.setDewPoint(fieldGeneratorDewPoint.value);
                fieldGeneratorDewPoint.have_value = false;
              }
            if (fieldGeneratorWeatherIconURL.have_value)
              {
                result.setWeatherIconURL(fieldGeneratorWeatherIconURL.value);
                fieldGeneratorWeatherIconURL.have_value = false;
              }
            if (fieldGeneratorConditionsImage.have_value)
              {
                result.setConditionsImage(fieldGeneratorConditionsImage.value);
                fieldGeneratorConditionsImage.have_value = false;
              }
            if (fieldGeneratorHumidityPct.have_value)
              {
                result.setHumidityPct((sbyte)(fieldGeneratorHumidityPct.value));
                fieldGeneratorHumidityPct.have_value = false;
              }
            if (fieldGeneratorVisibility.have_value)
              {
                result.setVisibility(fieldGeneratorVisibility.value);
                fieldGeneratorVisibility.have_value = false;
              }
            if (fieldGeneratorPrecipitation1Hour.have_value)
              {
                result.setPrecipitation1Hour(fieldGeneratorPrecipitation1Hour.value);
                fieldGeneratorPrecipitation1Hour.have_value = false;
              }
            if (fieldGeneratorPrecipitationToday.have_value)
              {
                result.setPrecipitationToday(fieldGeneratorPrecipitationToday.value);
                fieldGeneratorPrecipitationToday.have_value = false;
              }
            if (fieldGeneratorWind.have_value)
              {
                result.setWind(fieldGeneratorWind.value);
                fieldGeneratorWind.have_value = false;
              }
            if (fieldGeneratorWindGust.have_value)
              {
                result.setWindGust(fieldGeneratorWindGust.value);
                fieldGeneratorWindGust.have_value = false;
              }
            if (fieldGeneratorBarometricPressure.have_value)
              {
                result.setBarometricPressure(fieldGeneratorBarometricPressure.value);
                fieldGeneratorBarometricPressure.have_value = false;
              }
            if (fieldGeneratorUVIndex.have_value)
              {
                result.setUVIndex(fieldGeneratorUVIndex.value);
                fieldGeneratorUVIndex.have_value = false;
              }
            if (fieldGeneratorCloudinessPct.have_value)
              {
                result.setCloudinessPct((sbyte)(fieldGeneratorCloudinessPct.value));
                fieldGeneratorCloudinessPct.have_value = false;
              }
            if (fieldGeneratorDailyForecasts.have_value)
              {
                result.initDailyForecasts();
                int count = fieldGeneratorDailyForecasts.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendDailyForecasts(fieldGeneratorDailyForecasts.value[num]);
                  }
                fieldGeneratorDailyForecasts.value.Clear();
                fieldGeneratorDailyForecasts.have_value = false;
              }
            else if ((!(result.hasDailyForecasts())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DailyForecasts\" field was missing.");
              }
            if (fieldGeneratorHourlyForecasts.have_value)
              {
                result.initHourlyForecasts();
                int count = fieldGeneratorHourlyForecasts.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendHourlyForecasts(fieldGeneratorHourlyForecasts.value[num]);
                  }
                fieldGeneratorHourlyForecasts.value.Clear();
                fieldGeneratorHourlyForecasts.have_value = false;
              }
            else if ((!(result.hasHourlyForecasts())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"HourlyForecasts\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(ShowWeatherCurrentConditionsInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'l':
                            switch (field_name[2])
                              {
                                case 'e':
                                    if ((String.Compare(field_name, 3, "rts", 0, 3, false) == 0) && (field_name.Length == 6))
                                        return fieldGeneratorAlerts;
                                    break;
                                case 'o':
                                    if ((String.Compare(field_name, 3, "ngTheRoute", 0, 10, false) == 0) && (field_name.Length == 13))
                                        return fieldGeneratorAlongTheRoute;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "tribution", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorAttribution;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'B':
                    if ((String.Compare(field_name, 1, "arometricPressure", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorBarometricPressure;
                    break;
                case 'C':
                    switch (field_name[1])
                      {
                        case 'l':
                            if ((String.Compare(field_name, 2, "oudinessPct", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorCloudinessPct;
                            break;
                        case 'o':
                            if (String.Compare(field_name, 2, "nditions", 0, 8, false) == 0)
                              {
                                switch (field_name[10])
                                  {
                                    case 'I':
                                        if ((String.Compare(field_name, 11, "mage", 0, 4, false) == 0) && (field_name.Length == 15))
                                            return fieldGeneratorConditionsImage;
                                        break;
                                    case 'S':
                                        if ((String.Compare(field_name, 11, "hortPhrase", 0, 10, false) == 0) && (field_name.Length == 21))
                                            return fieldGeneratorConditionsShortPhrase;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "rrentTemperature", 0, 16, false) == 0) && (field_name.Length == 18))
                                return fieldGeneratorCurrentTemperature;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'D':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "ilyForecasts", 0, 12, false) == 0) && (field_name.Length == 14))
                                return fieldGeneratorDailyForecasts;
                            break;
                        case 'e':
                            if ((String.Compare(field_name, 2, "wPoint", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorDewPoint;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "eelsLikeTemperature", 0, 19, false) == 0) && (field_name.Length == 20))
                        return fieldGeneratorFeelsLikeTemperature;
                    break;
                case 'H':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "atIndex", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorHeatIndex;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "urlyForecasts", 0, 13, false) == 0) && (field_name.Length == 15))
                                return fieldGeneratorHourlyForecasts;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "midityPct", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorHumidityPct;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "sYesNoQuery", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorIsYesNoQuery;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "ocation", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorLocation;
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "bservationDateAndTime", 0, 21, false) == 0) && (field_name.Length == 22))
                        return fieldGeneratorObservationDateAndTime;
                    break;
                case 'P':
                    if (String.Compare(field_name, 1, "recipitation", 0, 12, false) == 0)
                      {
                        switch (field_name[13])
                          {
                            case '1':
                                if ((String.Compare(field_name, 14, "Hour", 0, 4, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorPrecipitation1Hour;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 14, "oday", 0, 4, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorPrecipitationToday;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "equestedAttribute", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorRequestedAttribute;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "VIndex", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorUVIndex;
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "isibility", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorVisibility;
                    break;
                case 'W':
                    switch (field_name[1])
                      {
                        case 'e':
                            if (String.Compare(field_name, 2, "ather", 0, 5, false) == 0)
                              {
                                switch (field_name[7])
                                  {
                                    case 'I':
                                        if ((String.Compare(field_name, 8, "conURL", 0, 6, false) == 0) && (field_name.Length == 14))
                                            return fieldGeneratorWeatherIconURL;
                                        break;
                                    case 'M':
                                        if ((String.Compare(field_name, 8, "apRequested", 0, 11, false) == 0) && (field_name.Length == 19))
                                            return fieldGeneratorWeatherMapRequested;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'i':
                            if (String.Compare(field_name, 2, "nd", 0, 2, false) == 0)
                              {
                                if (field_name.Length == 4)
                                  {
                                    return fieldGeneratorWind;
                                  }
                                switch (field_name[4])
                                  {
                                    case 'G':
                                        if ((String.Compare(field_name, 5, "ust", 0, 3, false) == 0) && (field_name.Length == 8))
                                            return fieldGeneratorWindGust;
                                        break;
                                    case 'c':
                                        if ((String.Compare(field_name, 5, "hill", 0, 4, false) == 0) && (field_name.Length == 9))
                                            return fieldGeneratorWindchill;
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
            fieldGeneratorAttribution = new AttributionJSON.HoldingGenerator("field \"Attribution\" of the ShowWeatherCurrentConditionsInformationNugget class", ignore_extras);
            fieldGeneratorLocation = new MapLocationJSON.HoldingGenerator("field \"Location\" of the ShowWeatherCurrentConditionsInformationNugget class", ignore_extras);
            fieldGeneratorAlerts = new AlertJSON.HoldingArrayGenerator("field \"Alerts\" of the ShowWeatherCurrentConditionsInformationNugget class", ignore_extras);
            fieldGeneratorRequestedAttribute = new JSONHoldingStringGenerator("field \"RequestedAttribute\" of the ShowWeatherCurrentConditionsInformationNugget class");
            fieldGeneratorIsYesNoQuery = new JSONHoldingBooleanGenerator("field \"IsYesNoQuery\" of the ShowWeatherCurrentConditionsInformationNugget class");
            fieldGeneratorWeatherMapRequested = new JSONHoldingBooleanGenerator("field \"WeatherMapRequested\" of the ShowWeatherCurrentConditionsInformationNugget class");
            fieldGeneratorAlongTheRoute = new JSONHoldingBooleanGenerator("field \"AlongTheRoute\" of the ShowWeatherCurrentConditionsInformationNugget class");
            fieldGeneratorObservationDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"ObservationDateAndTime\" of the ShowWeatherCurrentConditionsInformationNugget class", ignore_extras);
            fieldGeneratorConditionsShortPhrase = new JSONHoldingStringGenerator("field \"ConditionsShortPhrase\" of the ShowWeatherCurrentConditionsInformationNugget class");
            fieldGeneratorCurrentTemperature = new TypeCurrentTemperatureJSON.HoldingGenerator("field \"CurrentTemperature\" of the ShowWeatherCurrentConditionsInformationNugget class", ignore_extras);
            fieldGeneratorFeelsLikeTemperature = new TypeFeelsLikeTemperatureJSON.HoldingGenerator("field \"FeelsLikeTemperature\" of the ShowWeatherCurrentConditionsInformationNugget class", ignore_extras);
            fieldGeneratorHeatIndex = new TypeHeatIndexJSON.HoldingGenerator("field \"HeatIndex\" of the ShowWeatherCurrentConditionsInformationNugget class", ignore_extras);
            fieldGeneratorWindchill = new TypeWindchillJSON.HoldingGenerator("field \"Windchill\" of the ShowWeatherCurrentConditionsInformationNugget class", ignore_extras);
            fieldGeneratorDewPoint = new TypeDewPointJSON.HoldingGenerator("field \"DewPoint\" of the ShowWeatherCurrentConditionsInformationNugget class", ignore_extras);
            fieldGeneratorWeatherIconURL = new JSONHoldingStringGenerator("field \"WeatherIconURL\" of the ShowWeatherCurrentConditionsInformationNugget class");
            fieldGeneratorConditionsImage = new WeatherImageJSON.HoldingGenerator("field \"ConditionsImage\" of the ShowWeatherCurrentConditionsInformationNugget class", ignore_extras);
            fieldGeneratorHumidityPct = new FieldHoldingGeneratorHumidityPct("field \"HumidityPct\" of the ShowWeatherCurrentConditionsInformationNugget class");
            fieldGeneratorVisibility = new TypeVisibilityJSON.HoldingGenerator("field \"Visibility\" of the ShowWeatherCurrentConditionsInformationNugget class", ignore_extras);
            fieldGeneratorPrecipitation1Hour = new TypePrecipitation1HourJSON.HoldingGenerator("field \"Precipitation1Hour\" of the ShowWeatherCurrentConditionsInformationNugget class", ignore_extras);
            fieldGeneratorPrecipitationToday = new TypePrecipitationTodayJSON.HoldingGenerator("field \"PrecipitationToday\" of the ShowWeatherCurrentConditionsInformationNugget class", ignore_extras);
            fieldGeneratorWind = new TypeWindJSON.HoldingGenerator("field \"Wind\" of the ShowWeatherCurrentConditionsInformationNugget class", ignore_extras);
            fieldGeneratorWindGust = new TypeWindGustJSON.HoldingGenerator("field \"WindGust\" of the ShowWeatherCurrentConditionsInformationNugget class", ignore_extras);
            fieldGeneratorBarometricPressure = new TypeBarometricPressureJSON.HoldingGenerator("field \"BarometricPressure\" of the ShowWeatherCurrentConditionsInformationNugget class", ignore_extras);
            fieldGeneratorUVIndex = new TypeUVIndexJSON.HoldingGenerator("field \"UVIndex\" of the ShowWeatherCurrentConditionsInformationNugget class", ignore_extras);
            fieldGeneratorCloudinessPct = new FieldHoldingGeneratorCloudinessPct("field \"CloudinessPct\" of the ShowWeatherCurrentConditionsInformationNugget class");
            fieldGeneratorDailyForecasts = new DailyForecastJSON.HoldingArrayGenerator("field \"DailyForecasts\" of the ShowWeatherCurrentConditionsInformationNugget class", ignore_extras);
            fieldGeneratorHourlyForecasts = new HourlyForecastJSON.HoldingArrayGenerator("field \"HourlyForecasts\" of the ShowWeatherCurrentConditionsInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ShowWeatherCurrentConditionsInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorAttribution = new AttributionJSON.HoldingGenerator("field \"Attribution\" of the ShowWeatherCurrentConditionsInformationNugget class", false);
            fieldGeneratorLocation = new MapLocationJSON.HoldingGenerator("field \"Location\" of the ShowWeatherCurrentConditionsInformationNugget class", false);
            fieldGeneratorAlerts = new AlertJSON.HoldingArrayGenerator("field \"Alerts\" of the ShowWeatherCurrentConditionsInformationNugget class", false);
            fieldGeneratorRequestedAttribute = new JSONHoldingStringGenerator("field \"RequestedAttribute\" of the ShowWeatherCurrentConditionsInformationNugget class");
            fieldGeneratorIsYesNoQuery = new JSONHoldingBooleanGenerator("field \"IsYesNoQuery\" of the ShowWeatherCurrentConditionsInformationNugget class");
            fieldGeneratorWeatherMapRequested = new JSONHoldingBooleanGenerator("field \"WeatherMapRequested\" of the ShowWeatherCurrentConditionsInformationNugget class");
            fieldGeneratorAlongTheRoute = new JSONHoldingBooleanGenerator("field \"AlongTheRoute\" of the ShowWeatherCurrentConditionsInformationNugget class");
            fieldGeneratorObservationDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"ObservationDateAndTime\" of the ShowWeatherCurrentConditionsInformationNugget class", false);
            fieldGeneratorConditionsShortPhrase = new JSONHoldingStringGenerator("field \"ConditionsShortPhrase\" of the ShowWeatherCurrentConditionsInformationNugget class");
            fieldGeneratorCurrentTemperature = new TypeCurrentTemperatureJSON.HoldingGenerator("field \"CurrentTemperature\" of the ShowWeatherCurrentConditionsInformationNugget class", false);
            fieldGeneratorFeelsLikeTemperature = new TypeFeelsLikeTemperatureJSON.HoldingGenerator("field \"FeelsLikeTemperature\" of the ShowWeatherCurrentConditionsInformationNugget class", false);
            fieldGeneratorHeatIndex = new TypeHeatIndexJSON.HoldingGenerator("field \"HeatIndex\" of the ShowWeatherCurrentConditionsInformationNugget class", false);
            fieldGeneratorWindchill = new TypeWindchillJSON.HoldingGenerator("field \"Windchill\" of the ShowWeatherCurrentConditionsInformationNugget class", false);
            fieldGeneratorDewPoint = new TypeDewPointJSON.HoldingGenerator("field \"DewPoint\" of the ShowWeatherCurrentConditionsInformationNugget class", false);
            fieldGeneratorWeatherIconURL = new JSONHoldingStringGenerator("field \"WeatherIconURL\" of the ShowWeatherCurrentConditionsInformationNugget class");
            fieldGeneratorConditionsImage = new WeatherImageJSON.HoldingGenerator("field \"ConditionsImage\" of the ShowWeatherCurrentConditionsInformationNugget class", false);
            fieldGeneratorHumidityPct = new FieldHoldingGeneratorHumidityPct("field \"HumidityPct\" of the ShowWeatherCurrentConditionsInformationNugget class");
            fieldGeneratorVisibility = new TypeVisibilityJSON.HoldingGenerator("field \"Visibility\" of the ShowWeatherCurrentConditionsInformationNugget class", false);
            fieldGeneratorPrecipitation1Hour = new TypePrecipitation1HourJSON.HoldingGenerator("field \"Precipitation1Hour\" of the ShowWeatherCurrentConditionsInformationNugget class", false);
            fieldGeneratorPrecipitationToday = new TypePrecipitationTodayJSON.HoldingGenerator("field \"PrecipitationToday\" of the ShowWeatherCurrentConditionsInformationNugget class", false);
            fieldGeneratorWind = new TypeWindJSON.HoldingGenerator("field \"Wind\" of the ShowWeatherCurrentConditionsInformationNugget class", false);
            fieldGeneratorWindGust = new TypeWindGustJSON.HoldingGenerator("field \"WindGust\" of the ShowWeatherCurrentConditionsInformationNugget class", false);
            fieldGeneratorBarometricPressure = new TypeBarometricPressureJSON.HoldingGenerator("field \"BarometricPressure\" of the ShowWeatherCurrentConditionsInformationNugget class", false);
            fieldGeneratorUVIndex = new TypeUVIndexJSON.HoldingGenerator("field \"UVIndex\" of the ShowWeatherCurrentConditionsInformationNugget class", false);
            fieldGeneratorCloudinessPct = new FieldHoldingGeneratorCloudinessPct("field \"CloudinessPct\" of the ShowWeatherCurrentConditionsInformationNugget class");
            fieldGeneratorDailyForecasts = new DailyForecastJSON.HoldingArrayGenerator("field \"DailyForecasts\" of the ShowWeatherCurrentConditionsInformationNugget class", false);
            fieldGeneratorHourlyForecasts = new HourlyForecastJSON.HoldingArrayGenerator("field \"HourlyForecasts\" of the ShowWeatherCurrentConditionsInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ShowWeatherCurrentConditionsInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorAttribution.reset();
            fieldGeneratorLocation.reset();
            fieldGeneratorAlerts.reset();
            fieldGeneratorRequestedAttribute.reset();
            fieldGeneratorIsYesNoQuery.reset();
            fieldGeneratorWeatherMapRequested.reset();
            fieldGeneratorAlongTheRoute.reset();
            fieldGeneratorObservationDateAndTime.reset();
            fieldGeneratorConditionsShortPhrase.reset();
            fieldGeneratorCurrentTemperature.reset();
            fieldGeneratorFeelsLikeTemperature.reset();
            fieldGeneratorHeatIndex.reset();
            fieldGeneratorWindchill.reset();
            fieldGeneratorDewPoint.reset();
            fieldGeneratorWeatherIconURL.reset();
            fieldGeneratorConditionsImage.reset();
            fieldGeneratorHumidityPct.reset();
            fieldGeneratorVisibility.reset();
            fieldGeneratorPrecipitation1Hour.reset();
            fieldGeneratorPrecipitationToday.reset();
            fieldGeneratorWind.reset();
            fieldGeneratorWindGust.reset();
            fieldGeneratorBarometricPressure.reset();
            fieldGeneratorUVIndex.reset();
            fieldGeneratorCloudinessPct.reset();
            fieldGeneratorDailyForecasts.reset();
            fieldGeneratorHourlyForecasts.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ShowWeatherCurrentConditionsInformationNuggetJSON  result)
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
        public ShowWeatherCurrentConditionsInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ShowWeatherCurrentConditionsInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<ShowWeatherCurrentConditionsInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ShowWeatherCurrentConditionsInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ShowWeatherCurrentConditionsInformationNuggetJSON>();
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
    public List<ShowWeatherCurrentConditionsInformationNuggetJSON> value;
  };
  };
