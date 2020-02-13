/* file "SportsStatsQueryStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsStatsQueryStateJSON : JSONBase
  {
    public class TypeStatRequestsJSON : JSONBase
      {
        private bool flagHasTeamOrPlayer;
        private SportsTeamOrPlayerJSON  storeTeamOrPlayer;
        private bool flagHasStatisticType;
        private SportsStatsTypeJSON  storeStatisticType;
        private bool flagHasArguments;
        private List< SportsStatsArgumentArrayJSON  > storeArguments;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONTeamOrPlayer(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            SportsTeamOrPlayerJSON convert_classy = SportsTeamOrPlayerJSON.from_json(json_value, ignore_extras, true);
            setTeamOrPlayer(convert_classy);
          }


        private void  fromJSONStatisticType(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            SportsStatsTypeJSON convert_classy = SportsStatsTypeJSON.from_json(json_value, ignore_extras, true);
            setStatisticType(convert_classy);
          }


        private void  fromJSONArguments(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field Arguments of TypeStatRequestsJSON is not an array.");
            int count1 = json_array1.componentCount();
            if (count1 < 1)
                throw new Exception("The value for field Arguments of TypeStatRequestsJSON has too few elements.");
            List< SportsStatsArgumentArrayJSON  > vector_Arguments1 = new List< SportsStatsArgumentArrayJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                SportsStatsArgumentArrayJSON convert_classy = SportsStatsArgumentArrayJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_Arguments1.Add(convert_classy);
              }
            Debug.Assert(vector_Arguments1.Count >= 1);
            initArguments();
            for (int num1 = 0; num1 < vector_Arguments1.Count; ++num1)
                appendArguments(vector_Arguments1[num1]);
            for (int num1 = 0; num1 < vector_Arguments1.Count; ++num1)
              {
              }
          }


        public TypeStatRequestsJSON()
          {
            flagHasTeamOrPlayer = false;
            flagHasStatisticType = false;
            flagHasArguments = false;
            storeArguments = new List< SportsStatsArgumentArrayJSON  >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasTeamOrPlayer()
          {
            return flagHasTeamOrPlayer;
          }

        public SportsTeamOrPlayerJSON   getTeamOrPlayer()
          {
            Debug.Assert(flagHasTeamOrPlayer);
            return storeTeamOrPlayer;
          }

        public SportsTeamOrPlayerJSON.TypeValue  getTeamOrPlayerValue()
          {
            return getTeamOrPlayer().getValue();
          }

        public bool  hasStatisticType()
          {
            return flagHasStatisticType;
          }

        public SportsStatsTypeJSON   getStatisticType()
          {
            Debug.Assert(flagHasStatisticType);
            return storeStatisticType;
          }

        public SportsStatsTypeJSON.TypeValue  getStatisticTypeValue()
          {
            return getStatisticType().getValue();
          }

        public string  getStatisticTypeAsString()
          {
            return getStatisticType().getValueAsString();
          }

        public bool  hasArguments()
          {
            return flagHasArguments;
          }

        public int  countOfArguments()
          {
            Debug.Assert(flagHasArguments);
            return storeArguments.Count;
          }

        public SportsStatsArgumentArrayJSON   elementOfArguments(int element_num)
          {
            Debug.Assert(flagHasArguments);
            return storeArguments[element_num];
          }

        public List< SportsStatsArgumentArrayJSON  >  getArguments()
          {
            Debug.Assert(flagHasArguments);
            return storeArguments;
          }


        public virtual int extraTypeStatRequestsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeStatRequestsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeStatRequestsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeStatRequestsLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setTeamOrPlayer(SportsTeamOrPlayerJSON  new_value)
          {
            if (flagHasTeamOrPlayer)
              {
              }
            flagHasTeamOrPlayer = true;
            storeTeamOrPlayer = new_value;
          }
        public void setTeamOrPlayer(SportsTeamOrPlayerJSON.TypeValue new_value)
          {
            setTeamOrPlayer(new SportsTeamOrPlayerJSON(new_value));
          }
        public void unsetTeamOrPlayer()
          {
            if (flagHasTeamOrPlayer)
              {
              }
            flagHasTeamOrPlayer = false;
          }
        public void setStatisticType(SportsStatsTypeJSON  new_value)
          {
            if (flagHasStatisticType)
              {
              }
            flagHasStatisticType = true;
            storeStatisticType = new_value;
          }
        public void setStatisticType(SportsStatsTypeJSON.TypeValue new_value)
          {
            setStatisticType(new SportsStatsTypeJSON(new_value));
          }
        public void setStatisticType(string chars)
          {
            SportsStatsTypeJSON.TypeValueKnownValues known = SportsStatsTypeJSON.stringToValue(chars);
            SportsStatsTypeJSON.TypeValue new_value = new SportsStatsTypeJSON.TypeValue();
            if (known == SportsStatsTypeJSON.TypeValueKnownValues.Value__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setStatisticType(new_value);
          }
        public void unsetStatisticType()
          {
            if (flagHasStatisticType)
              {
              }
            flagHasStatisticType = false;
          }
        public void initArguments()
          {
            if (flagHasArguments)
              {
                for (int num1 = 0; num1 < storeArguments.Count; ++num1)
                  {
                  }
              }
            flagHasArguments = true;
            storeArguments.Clear();
          }
        public void appendArguments(SportsStatsArgumentArrayJSON  to_append)
          {
            if (!flagHasArguments)
              {
                flagHasArguments = true;
                storeArguments.Clear();
              }
            Debug.Assert(flagHasArguments);
            storeArguments.Add(to_append);
          }
        public void unsetArguments()
          {
            if (flagHasArguments)
              {
                for (int num2 = 0; num2 < storeArguments.Count; ++num2)
                  {
                  }
              }
            flagHasArguments = false;
            storeArguments.Clear();
          }

        public virtual void extraTypeStatRequestsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeStatRequestsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeStatRequestsLookup(key);
            if (old_field == null)
              {
                extraTypeStatRequestsAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasTeamOrPlayer);
            if (flagHasTeamOrPlayer)
              {
                handler.start_pair("TeamOrPlayer");
                if (partial_allowed)
                    storeTeamOrPlayer.write_partial_as_json(handler);
                else
                    storeTeamOrPlayer.write_as_json(handler);
              }
            Debug.Assert(partial_allowed || flagHasStatisticType);
            if (flagHasStatisticType)
              {
                handler.start_pair("StatisticType");
                if (partial_allowed)
                    storeStatisticType.write_partial_as_json(handler);
                else
                    storeStatisticType.write_as_json(handler);
              }
            if (flagHasArguments)
              {
                handler.start_pair("Arguments");
                Debug.Assert(storeArguments.Count >= 1);
                handler.start_array();
                for (int num1 = 0; num1 < storeArguments.Count; ++num1)
                  {
                    if (partial_allowed)
                        storeArguments[num1].write_partial_as_json(handler);
                    else
                        storeArguments[num1].write_as_json(handler);
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
            if (!(hasTeamOrPlayer()))
              {
                return "When parsing the object for %what%, the \"TeamOrPlayer\" field was missing.";
              }
            if (!(hasStatisticType()))
              {
                return "When parsing the object for %what%, the \"StatisticType\" field was missing.";
              }
            return null;
          }

        public static TypeStatRequestsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeStatRequestsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeStatRequests", ignore_extras);
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
        public static TypeStatRequestsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeStatRequestsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeStatRequestsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeStatRequests", ignore_extras);
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
        public static TypeStatRequestsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeStatRequestsJSON from_text(string text, bool ignore_extras)
          {
            TypeStatRequestsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeStatRequests", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeStatRequestsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeStatRequestsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeStatRequestsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeStatRequests", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private SportsTeamOrPlayerJSON.HoldingGenerator fieldGeneratorTeamOrPlayer;
            private SportsStatsTypeJSON.HoldingGenerator fieldGeneratorStatisticType;
            private SportsStatsArgumentArrayJSON.HoldingArrayGenerator fieldGeneratorArguments;
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
                TypeStatRequestsJSON result = new TypeStatRequestsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeStatRequestsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeStatRequestsJSON result)
              {
                if (fieldGeneratorTeamOrPlayer.have_value)
                  {
                    result.setTeamOrPlayer(fieldGeneratorTeamOrPlayer.value);
                    fieldGeneratorTeamOrPlayer.have_value = false;
                  }
                else if ((!(result.hasTeamOrPlayer())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"TeamOrPlayer\" field was missing.");
                  }
                if (fieldGeneratorStatisticType.have_value)
                  {
                    result.setStatisticType(fieldGeneratorStatisticType.value);
                    fieldGeneratorStatisticType.have_value = false;
                  }
                else if ((!(result.hasStatisticType())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"StatisticType\" field was missing.");
                  }
                if (fieldGeneratorArguments.have_value)
                  {
                    result.initArguments();
                    int count = fieldGeneratorArguments.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendArguments(fieldGeneratorArguments.value[num]);
                      }
                    fieldGeneratorArguments.value.Clear();
                    fieldGeneratorArguments.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeStatRequestsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'A':
                        if ((String.Compare(field_name, 1, "rguments", 0, 8, false) == 0) && (field_name.Length == 9))
                            return fieldGeneratorArguments;
                        break;
                    case 'S':
                        if ((String.Compare(field_name, 1, "tatisticType", 0, 12, false) == 0) && (field_name.Length == 13))
                            return fieldGeneratorStatisticType;
                        break;
                    case 'T':
                        if ((String.Compare(field_name, 1, "eamOrPlayer", 0, 11, false) == 0) && (field_name.Length == 12))
                            return fieldGeneratorTeamOrPlayer;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorTeamOrPlayer = new SportsTeamOrPlayerJSON.HoldingGenerator("field \"TeamOrPlayer\" of the TypeStatRequests class", ignore_extras);
                fieldGeneratorStatisticType = new SportsStatsTypeJSON.HoldingGenerator("field \"StatisticType\" of the TypeStatRequests class", ignore_extras);
                fieldGeneratorArguments = new SportsStatsArgumentArrayJSON.HoldingArrayGenerator("field \"Arguments\" of the TypeStatRequests class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeStatRequests class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorTeamOrPlayer = new SportsTeamOrPlayerJSON.HoldingGenerator("field \"TeamOrPlayer\" of the TypeStatRequests class", false);
                fieldGeneratorStatisticType = new SportsStatsTypeJSON.HoldingGenerator("field \"StatisticType\" of the TypeStatRequests class", false);
                fieldGeneratorArguments = new SportsStatsArgumentArrayJSON.HoldingArrayGenerator("field \"Arguments\" of the TypeStatRequests class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeStatRequests class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorTeamOrPlayer.reset();
                fieldGeneratorStatisticType.reset();
                fieldGeneratorArguments.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorTeamOrPlayer.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorStatisticType.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorTeamOrPlayer.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorStatisticType.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeStatRequestsJSON  result)
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
            public TypeStatRequestsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeStatRequestsJSON  result)
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
        protected virtual void handle_result(List<TypeStatRequestsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeStatRequestsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeStatRequestsJSON>();
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
        public List<TypeStatRequestsJSON> value;
      };
      };
    private bool flagHasStatRequests;
    private List< TypeStatRequestsJSON  > storeStatRequests;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONStatRequests(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field StatRequests of SportsStatsQueryStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field StatRequests of SportsStatsQueryStateJSON has too few elements.");
        List< TypeStatRequestsJSON  > vector_StatRequests1 = new List< TypeStatRequestsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeStatRequestsJSON convert_classy = TypeStatRequestsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_StatRequests1.Add(convert_classy);
          }
        Debug.Assert(vector_StatRequests1.Count >= 1);
        initStatRequests();
        for (int num2 = 0; num2 < vector_StatRequests1.Count; ++num2)
            appendStatRequests(vector_StatRequests1[num2]);
        for (int num1 = 0; num1 < vector_StatRequests1.Count; ++num1)
          {
          }
      }


    public SportsStatsQueryStateJSON()
      {
        flagHasStatRequests = false;
        storeStatRequests = new List< TypeStatRequestsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasStatRequests()
      {
        return flagHasStatRequests;
      }

    public int  countOfStatRequests()
      {
        Debug.Assert(flagHasStatRequests);
        return storeStatRequests.Count;
      }

    public TypeStatRequestsJSON   elementOfStatRequests(int element_num)
      {
        Debug.Assert(flagHasStatRequests);
        return storeStatRequests[element_num];
      }

    public List< TypeStatRequestsJSON  >  getStatRequests()
      {
        Debug.Assert(flagHasStatRequests);
        return storeStatRequests;
      }


    public virtual int extraSportsStatsQueryStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsStatsQueryStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsStatsQueryStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsStatsQueryStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initStatRequests()
      {
        if (flagHasStatRequests)
          {
            for (int num3 = 0; num3 < storeStatRequests.Count; ++num3)
              {
              }
          }
        flagHasStatRequests = true;
        storeStatRequests.Clear();
      }
    public void appendStatRequests(TypeStatRequestsJSON  to_append)
      {
        if (!flagHasStatRequests)
          {
            flagHasStatRequests = true;
            storeStatRequests.Clear();
          }
        Debug.Assert(flagHasStatRequests);
        storeStatRequests.Add(to_append);
      }
    public void unsetStatRequests()
      {
        if (flagHasStatRequests)
          {
            for (int num4 = 0; num4 < storeStatRequests.Count; ++num4)
              {
              }
          }
        flagHasStatRequests = false;
        storeStatRequests.Clear();
      }

    public virtual void extraSportsStatsQueryStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsStatsQueryStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsStatsQueryStateLookup(key);
        if (old_field == null)
          {
            extraSportsStatsQueryStateAppendPair(key, new_component);
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
        if (flagHasStatRequests)
          {
            handler.start_pair("StatRequests");
            Debug.Assert(storeStatRequests.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeStatRequests.Count; ++num1)
              {
                if (partial_allowed)
                    storeStatRequests[num1].write_partial_as_json(handler);
                else
                    storeStatRequests[num1].write_as_json(handler);
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
        return null;
      }

    public static SportsStatsQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStatsQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStatsQueryState", ignore_extras);
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
    public static SportsStatsQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsStatsQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStatsQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStatsQueryState", ignore_extras);
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
    public static SportsStatsQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsStatsQueryStateJSON from_text(string text, bool ignore_extras)
      {
        SportsStatsQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStatsQueryState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsStatsQueryStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsStatsQueryStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsStatsQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStatsQueryState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private TypeStatRequestsJSON.HoldingArrayGenerator fieldGeneratorStatRequests;
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
            SportsStatsQueryStateJSON result = new SportsStatsQueryStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsStatsQueryStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsStatsQueryStateJSON result)
          {
            if (fieldGeneratorStatRequests.have_value)
              {
                result.initStatRequests();
                int count = fieldGeneratorStatRequests.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendStatRequests(fieldGeneratorStatRequests.value[num]);
                  }
                fieldGeneratorStatRequests.value.Clear();
                fieldGeneratorStatRequests.have_value = false;
              }
          }
        protected abstract void handle_result(SportsStatsQueryStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "StatRequests", 0, 12, false) == 0) && (field_name.Length == 12))
                return fieldGeneratorStatRequests;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorStatRequests = new TypeStatRequestsJSON.HoldingArrayGenerator("field \"StatRequests\" of the SportsStatsQueryState class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsStatsQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorStatRequests = new TypeStatRequestsJSON.HoldingArrayGenerator("field \"StatRequests\" of the SportsStatsQueryState class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsStatsQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorStatRequests.reset();
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
        protected override void handle_result(SportsStatsQueryStateJSON  result)
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
        public SportsStatsQueryStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsStatsQueryStateJSON  result)
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
    protected virtual void handle_result(List<SportsStatsQueryStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsStatsQueryStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsStatsQueryStateJSON>();
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
    public List<SportsStatsQueryStateJSON> value;
  };
  };
