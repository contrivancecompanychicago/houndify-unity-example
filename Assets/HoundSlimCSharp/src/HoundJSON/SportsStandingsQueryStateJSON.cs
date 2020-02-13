/* file "SportsStandingsQueryStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SportsStandingsQueryStateJSON : JSONBase
  {
    public class TypeQueryDataAndResultsJSON : JSONBase
      {
        private bool flagHasQueryType;
        private SportsStandingsQueryTypeJSON  storeQueryType;
        private bool flagHasDivision;
        private SportsLeagueDivisionJSON  storeDivision;
        private bool flagHasLeague;
        private SportsLeagueCodeJSON  storeLeague;
        private bool flagHasTeam;
        private SportsTeamNewJSON  storeTeam;
        private bool flagHasTeamComparison;
        private SportsTeamNewJSON  storeTeamComparison;
        private bool flagHasRank;
        private BigInteger storeRank;
        private bool flagHasArguments;
        private List< SportsStandingsArgumentArrayJSON  > storeArguments;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONQueryType(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            SportsStandingsQueryTypeJSON convert_classy = SportsStandingsQueryTypeJSON.from_json(json_value, ignore_extras, true);
            setQueryType(convert_classy);
          }


        private void  fromJSONDivision(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            SportsLeagueDivisionJSON convert_classy = SportsLeagueDivisionJSON.from_json(json_value, ignore_extras, true);
            setDivision(convert_classy);
          }


        private void  fromJSONLeague(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            SportsLeagueCodeJSON convert_classy = SportsLeagueCodeJSON.from_json(json_value, ignore_extras, true);
            setLeague(convert_classy);
          }


        private void  fromJSONTeam(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            SportsTeamNewJSON convert_classy = SportsTeamNewJSON.from_json(json_value, ignore_extras, true);
            setTeam(convert_classy);
          }


        private void  fromJSONTeamComparison(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            SportsTeamNewJSON convert_classy = SportsTeamNewJSON.from_json(json_value, ignore_extras, true);
            setTeamComparison(convert_classy);
          }


        private void  fromJSONRank(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field Rank of TypeQueryDataAndResultsJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Rank of TypeQueryDataAndResultsJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setRank(extracted_integer);
          }


        private void  fromJSONArguments(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field Arguments of TypeQueryDataAndResultsJSON is not an array.");
            int count1 = json_array1.componentCount();
            if (count1 < 1)
                throw new Exception("The value for field Arguments of TypeQueryDataAndResultsJSON has too few elements.");
            List< SportsStandingsArgumentArrayJSON  > vector_Arguments1 = new List< SportsStandingsArgumentArrayJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                SportsStandingsArgumentArrayJSON convert_classy = SportsStandingsArgumentArrayJSON.from_json(json_array1.component(num1), ignore_extras, true);
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


        public TypeQueryDataAndResultsJSON()
          {
            flagHasQueryType = false;
            flagHasDivision = false;
            flagHasLeague = false;
            flagHasTeam = false;
            flagHasTeamComparison = false;
            flagHasRank = false;
            flagHasArguments = false;
            storeArguments = new List< SportsStandingsArgumentArrayJSON  >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasQueryType()
          {
            return flagHasQueryType;
          }

        public SportsStandingsQueryTypeJSON   getQueryType()
          {
            Debug.Assert(flagHasQueryType);
            return storeQueryType;
          }

        public SportsStandingsQueryTypeJSON.TypeValue  getQueryTypeValue()
          {
            return getQueryType().getValue();
          }

        public string  getQueryTypeAsString()
          {
            return getQueryType().getValueAsString();
          }

        public bool  hasDivision()
          {
            return flagHasDivision;
          }

        public SportsLeagueDivisionJSON   getDivision()
          {
            Debug.Assert(flagHasDivision);
            return storeDivision;
          }

        public SportsLeagueDivisionJSON.TypeValue  getDivisionValue()
          {
            return getDivision().getValue();
          }

        public string  getDivisionAsString()
          {
            return getDivision().getValueAsString();
          }

        public bool  hasLeague()
          {
            return flagHasLeague;
          }

        public SportsLeagueCodeJSON   getLeague()
          {
            Debug.Assert(flagHasLeague);
            return storeLeague;
          }

        public SportsLeagueCodeJSON.TypeValue  getLeagueValue()
          {
            return getLeague().getValue();
          }

        public string  getLeagueAsString()
          {
            return getLeague().getValueAsString();
          }

        public bool  hasTeam()
          {
            return flagHasTeam;
          }

        public SportsTeamNewJSON   getTeam()
          {
            Debug.Assert(flagHasTeam);
            return storeTeam;
          }

        public bool  hasTeamComparison()
          {
            return flagHasTeamComparison;
          }

        public SportsTeamNewJSON   getTeamComparison()
          {
            Debug.Assert(flagHasTeamComparison);
            return storeTeamComparison;
          }

        public bool  hasRank()
          {
            return flagHasRank;
          }

        public BigInteger  getRank()
          {
            Debug.Assert(flagHasRank);
            return storeRank;
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

        public SportsStandingsArgumentArrayJSON   elementOfArguments(int element_num)
          {
            Debug.Assert(flagHasArguments);
            return storeArguments[element_num];
          }

        public List< SportsStandingsArgumentArrayJSON  >  getArguments()
          {
            Debug.Assert(flagHasArguments);
            return storeArguments;
          }


        public virtual int extraTypeQueryDataAndResultsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeQueryDataAndResultsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeQueryDataAndResultsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeQueryDataAndResultsLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setQueryType(SportsStandingsQueryTypeJSON  new_value)
          {
            if (flagHasQueryType)
              {
              }
            flagHasQueryType = true;
            storeQueryType = new_value;
          }
        public void setQueryType(SportsStandingsQueryTypeJSON.TypeValue new_value)
          {
            setQueryType(new SportsStandingsQueryTypeJSON(new_value));
          }
        public void setQueryType(string chars)
          {
            SportsStandingsQueryTypeJSON.TypeValueKnownValues known = SportsStandingsQueryTypeJSON.stringToValue(chars);
            SportsStandingsQueryTypeJSON.TypeValue new_value = new SportsStandingsQueryTypeJSON.TypeValue();
            if (known == SportsStandingsQueryTypeJSON.TypeValueKnownValues.Value__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setQueryType(new_value);
          }
        public void unsetQueryType()
          {
            if (flagHasQueryType)
              {
              }
            flagHasQueryType = false;
          }
        public void setDivision(SportsLeagueDivisionJSON  new_value)
          {
            if (flagHasDivision)
              {
              }
            flagHasDivision = true;
            storeDivision = new_value;
          }
        public void setDivision(SportsLeagueDivisionJSON.TypeValue new_value)
          {
            setDivision(new SportsLeagueDivisionJSON(new_value));
          }
        public void setDivision(string chars)
          {
            SportsLeagueDivisionJSON.TypeValueKnownValues known = SportsLeagueDivisionJSON.stringToValue(chars);
            SportsLeagueDivisionJSON.TypeValue new_value = new SportsLeagueDivisionJSON.TypeValue();
            if (known == SportsLeagueDivisionJSON.TypeValueKnownValues.Value__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setDivision(new_value);
          }
        public void unsetDivision()
          {
            if (flagHasDivision)
              {
              }
            flagHasDivision = false;
          }
        public void setLeague(SportsLeagueCodeJSON  new_value)
          {
            if (flagHasLeague)
              {
              }
            flagHasLeague = true;
            storeLeague = new_value;
          }
        public void setLeague(SportsLeagueCodeJSON.TypeValue new_value)
          {
            setLeague(new SportsLeagueCodeJSON(new_value));
          }
        public void setLeague(string chars)
          {
            SportsLeagueCodeJSON.TypeValueKnownValues known = SportsLeagueCodeJSON.stringToValue(chars);
            SportsLeagueCodeJSON.TypeValue new_value = new SportsLeagueCodeJSON.TypeValue();
            if (known == SportsLeagueCodeJSON.TypeValueKnownValues.Value__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setLeague(new_value);
          }
        public void unsetLeague()
          {
            if (flagHasLeague)
              {
              }
            flagHasLeague = false;
          }
        public void setTeam(SportsTeamNewJSON  new_value)
          {
            if (flagHasTeam)
              {
              }
            flagHasTeam = true;
            storeTeam = new_value;
          }
        public void unsetTeam()
          {
            if (flagHasTeam)
              {
              }
            flagHasTeam = false;
          }
        public void setTeamComparison(SportsTeamNewJSON  new_value)
          {
            if (flagHasTeamComparison)
              {
              }
            flagHasTeamComparison = true;
            storeTeamComparison = new_value;
          }
        public void unsetTeamComparison()
          {
            if (flagHasTeamComparison)
              {
              }
            flagHasTeamComparison = false;
          }
        public void setRank(BigInteger new_value)
          {
            flagHasRank = true;
            if (new_value < 1)
                throw new Exception("The value for field Rank of TypeQueryDataAndResultsJSON is less than the lower bound (1) for that field.");
            storeRank = new_value;
          }
        public void unsetRank()
          {
            flagHasRank = false;
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
        public void appendArguments(SportsStandingsArgumentArrayJSON  to_append)
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

        public virtual void extraTypeQueryDataAndResultsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeQueryDataAndResultsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeQueryDataAndResultsLookup(key);
            if (old_field == null)
              {
                extraTypeQueryDataAndResultsAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasQueryType);
            if (flagHasQueryType)
              {
                handler.start_pair("QueryType");
                if (partial_allowed)
                    storeQueryType.write_partial_as_json(handler);
                else
                    storeQueryType.write_as_json(handler);
              }
            if (flagHasDivision)
              {
                handler.start_pair("Division");
                if (partial_allowed)
                    storeDivision.write_partial_as_json(handler);
                else
                    storeDivision.write_as_json(handler);
              }
            if (flagHasLeague)
              {
                handler.start_pair("League");
                if (partial_allowed)
                    storeLeague.write_partial_as_json(handler);
                else
                    storeLeague.write_as_json(handler);
              }
            if (flagHasTeam)
              {
                handler.start_pair("Team");
                if (partial_allowed)
                    storeTeam.write_partial_as_json(handler);
                else
                    storeTeam.write_as_json(handler);
              }
            if (flagHasTeamComparison)
              {
                handler.start_pair("TeamComparison");
                if (partial_allowed)
                    storeTeamComparison.write_partial_as_json(handler);
                else
                    storeTeamComparison.write_as_json(handler);
              }
            if (flagHasRank)
              {
                handler.start_pair("Rank");
                handler.number_value(storeRank);
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
            if (!(hasQueryType()))
              {
                return "When parsing the object for %what%, the \"QueryType\" field was missing.";
              }
            return null;
          }

        public static TypeQueryDataAndResultsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeQueryDataAndResultsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeQueryDataAndResults", ignore_extras);
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
        public static TypeQueryDataAndResultsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeQueryDataAndResultsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeQueryDataAndResultsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeQueryDataAndResults", ignore_extras);
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
        public static TypeQueryDataAndResultsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeQueryDataAndResultsJSON from_text(string text, bool ignore_extras)
          {
            TypeQueryDataAndResultsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeQueryDataAndResults", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeQueryDataAndResultsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeQueryDataAndResultsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeQueryDataAndResultsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeQueryDataAndResults", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private SportsStandingsQueryTypeJSON.HoldingGenerator fieldGeneratorQueryType;
            private SportsLeagueDivisionJSON.HoldingGenerator fieldGeneratorDivision;
            private SportsLeagueCodeJSON.HoldingGenerator fieldGeneratorLeague;
            private SportsTeamNewJSON.HoldingGenerator fieldGeneratorTeam;
            private SportsTeamNewJSON.HoldingGenerator fieldGeneratorTeamComparison;
        private class FieldHoldingGeneratorRank : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorRank(String what) : base(what, (BigInteger)(1))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorRank : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorRank(String what) : base(what, (BigInteger)(1))
                  {
                  }
              };
            private FieldHoldingGeneratorRank fieldGeneratorRank;
            private SportsStandingsArgumentArrayJSON.HoldingArrayGenerator fieldGeneratorArguments;
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
                TypeQueryDataAndResultsJSON result = new TypeQueryDataAndResultsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeQueryDataAndResultsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeQueryDataAndResultsJSON result)
              {
                if (fieldGeneratorQueryType.have_value)
                  {
                    result.setQueryType(fieldGeneratorQueryType.value);
                    fieldGeneratorQueryType.have_value = false;
                  }
                else if ((!(result.hasQueryType())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"QueryType\" field was missing.");
                  }
                if (fieldGeneratorDivision.have_value)
                  {
                    result.setDivision(fieldGeneratorDivision.value);
                    fieldGeneratorDivision.have_value = false;
                  }
                if (fieldGeneratorLeague.have_value)
                  {
                    result.setLeague(fieldGeneratorLeague.value);
                    fieldGeneratorLeague.have_value = false;
                  }
                if (fieldGeneratorTeam.have_value)
                  {
                    result.setTeam(fieldGeneratorTeam.value);
                    fieldGeneratorTeam.have_value = false;
                  }
                if (fieldGeneratorTeamComparison.have_value)
                  {
                    result.setTeamComparison(fieldGeneratorTeamComparison.value);
                    fieldGeneratorTeamComparison.have_value = false;
                  }
                if (fieldGeneratorRank.have_value)
                  {
                    result.setRank(fieldGeneratorRank.value);
                    fieldGeneratorRank.have_value = false;
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
            protected abstract void handle_result(TypeQueryDataAndResultsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'A':
                        if ((String.Compare(field_name, 1, "rguments", 0, 8, false) == 0) && (field_name.Length == 9))
                            return fieldGeneratorArguments;
                        break;
                    case 'D':
                        if ((String.Compare(field_name, 1, "ivision", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorDivision;
                        break;
                    case 'L':
                        if ((String.Compare(field_name, 1, "eague", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorLeague;
                        break;
                    case 'Q':
                        if ((String.Compare(field_name, 1, "ueryType", 0, 8, false) == 0) && (field_name.Length == 9))
                            return fieldGeneratorQueryType;
                        break;
                    case 'R':
                        if ((String.Compare(field_name, 1, "ank", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorRank;
                        break;
                    case 'T':
                        if (String.Compare(field_name, 1, "eam", 0, 3, false) == 0)
                          {
                            if (field_name.Length == 4)
                              {
                                return fieldGeneratorTeam;
                              }
                            switch (field_name[4])
                              {
                                case 'C':
                                    if ((String.Compare(field_name, 5, "omparison", 0, 9, false) == 0) && (field_name.Length == 14))
                                        return fieldGeneratorTeamComparison;
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
                fieldGeneratorQueryType = new SportsStandingsQueryTypeJSON.HoldingGenerator("field \"QueryType\" of the TypeQueryDataAndResults class", ignore_extras);
                fieldGeneratorDivision = new SportsLeagueDivisionJSON.HoldingGenerator("field \"Division\" of the TypeQueryDataAndResults class", ignore_extras);
                fieldGeneratorLeague = new SportsLeagueCodeJSON.HoldingGenerator("field \"League\" of the TypeQueryDataAndResults class", ignore_extras);
                fieldGeneratorTeam = new SportsTeamNewJSON.HoldingGenerator("field \"Team\" of the TypeQueryDataAndResults class", ignore_extras);
                fieldGeneratorTeamComparison = new SportsTeamNewJSON.HoldingGenerator("field \"TeamComparison\" of the TypeQueryDataAndResults class", ignore_extras);
                fieldGeneratorRank = new FieldHoldingGeneratorRank("field \"Rank\" of the TypeQueryDataAndResults class");
                fieldGeneratorArguments = new SportsStandingsArgumentArrayJSON.HoldingArrayGenerator("field \"Arguments\" of the TypeQueryDataAndResults class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeQueryDataAndResults class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorQueryType = new SportsStandingsQueryTypeJSON.HoldingGenerator("field \"QueryType\" of the TypeQueryDataAndResults class", false);
                fieldGeneratorDivision = new SportsLeagueDivisionJSON.HoldingGenerator("field \"Division\" of the TypeQueryDataAndResults class", false);
                fieldGeneratorLeague = new SportsLeagueCodeJSON.HoldingGenerator("field \"League\" of the TypeQueryDataAndResults class", false);
                fieldGeneratorTeam = new SportsTeamNewJSON.HoldingGenerator("field \"Team\" of the TypeQueryDataAndResults class", false);
                fieldGeneratorTeamComparison = new SportsTeamNewJSON.HoldingGenerator("field \"TeamComparison\" of the TypeQueryDataAndResults class", false);
                fieldGeneratorRank = new FieldHoldingGeneratorRank("field \"Rank\" of the TypeQueryDataAndResults class");
                fieldGeneratorArguments = new SportsStandingsArgumentArrayJSON.HoldingArrayGenerator("field \"Arguments\" of the TypeQueryDataAndResults class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeQueryDataAndResults class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorQueryType.reset();
                fieldGeneratorDivision.reset();
                fieldGeneratorLeague.reset();
                fieldGeneratorTeam.reset();
                fieldGeneratorTeamComparison.reset();
                fieldGeneratorRank.reset();
                fieldGeneratorArguments.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorQueryType.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorDivision.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorLeague.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorTeam.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorTeamComparison.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorQueryType.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorDivision.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorLeague.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorTeam.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorTeamComparison.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeQueryDataAndResultsJSON  result)
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
            public TypeQueryDataAndResultsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeQueryDataAndResultsJSON  result)
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
        protected virtual void handle_result(List<TypeQueryDataAndResultsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeQueryDataAndResultsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeQueryDataAndResultsJSON>();
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
        public List<TypeQueryDataAndResultsJSON> value;
      };
      };
    private bool flagHasQueryDataAndResults;
    private List< TypeQueryDataAndResultsJSON  > storeQueryDataAndResults;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONQueryDataAndResults(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field QueryDataAndResults of SportsStandingsQueryStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeQueryDataAndResultsJSON  > vector_QueryDataAndResults1 = new List< TypeQueryDataAndResultsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeQueryDataAndResultsJSON convert_classy = TypeQueryDataAndResultsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_QueryDataAndResults1.Add(convert_classy);
          }
        initQueryDataAndResults();
        for (int num2 = 0; num2 < vector_QueryDataAndResults1.Count; ++num2)
            appendQueryDataAndResults(vector_QueryDataAndResults1[num2]);
        for (int num1 = 0; num1 < vector_QueryDataAndResults1.Count; ++num1)
          {
          }
      }


    public SportsStandingsQueryStateJSON()
      {
        flagHasQueryDataAndResults = false;
        storeQueryDataAndResults = new List< TypeQueryDataAndResultsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasQueryDataAndResults()
      {
        return flagHasQueryDataAndResults;
      }

    public int  countOfQueryDataAndResults()
      {
        Debug.Assert(flagHasQueryDataAndResults);
        return storeQueryDataAndResults.Count;
      }

    public TypeQueryDataAndResultsJSON   elementOfQueryDataAndResults(int element_num)
      {
        Debug.Assert(flagHasQueryDataAndResults);
        return storeQueryDataAndResults[element_num];
      }

    public List< TypeQueryDataAndResultsJSON  >  getQueryDataAndResults()
      {
        Debug.Assert(flagHasQueryDataAndResults);
        return storeQueryDataAndResults;
      }


    public virtual int extraSportsStandingsQueryStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsStandingsQueryStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsStandingsQueryStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsStandingsQueryStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initQueryDataAndResults()
      {
        if (flagHasQueryDataAndResults)
          {
            for (int num3 = 0; num3 < storeQueryDataAndResults.Count; ++num3)
              {
              }
          }
        flagHasQueryDataAndResults = true;
        storeQueryDataAndResults.Clear();
      }
    public void appendQueryDataAndResults(TypeQueryDataAndResultsJSON  to_append)
      {
        if (!flagHasQueryDataAndResults)
          {
            flagHasQueryDataAndResults = true;
            storeQueryDataAndResults.Clear();
          }
        Debug.Assert(flagHasQueryDataAndResults);
        storeQueryDataAndResults.Add(to_append);
      }
    public void unsetQueryDataAndResults()
      {
        if (flagHasQueryDataAndResults)
          {
            for (int num4 = 0; num4 < storeQueryDataAndResults.Count; ++num4)
              {
              }
          }
        flagHasQueryDataAndResults = false;
        storeQueryDataAndResults.Clear();
      }

    public virtual void extraSportsStandingsQueryStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsStandingsQueryStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsStandingsQueryStateLookup(key);
        if (old_field == null)
          {
            extraSportsStandingsQueryStateAppendPair(key, new_component);
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
        if (flagHasQueryDataAndResults)
          {
            handler.start_pair("QueryDataAndResults");
            handler.start_array();
            for (int num1 = 0; num1 < storeQueryDataAndResults.Count; ++num1)
              {
                if (partial_allowed)
                    storeQueryDataAndResults[num1].write_partial_as_json(handler);
                else
                    storeQueryDataAndResults[num1].write_as_json(handler);
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

    public static SportsStandingsQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStandingsQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsQueryState", ignore_extras);
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
    public static SportsStandingsQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsStandingsQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStandingsQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsQueryState", ignore_extras);
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
    public static SportsStandingsQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsStandingsQueryStateJSON from_text(string text, bool ignore_extras)
      {
        SportsStandingsQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsQueryState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsStandingsQueryStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsStandingsQueryStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsStandingsQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsQueryState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private TypeQueryDataAndResultsJSON.HoldingArrayGenerator fieldGeneratorQueryDataAndResults;
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
            SportsStandingsQueryStateJSON result = new SportsStandingsQueryStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsStandingsQueryStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsStandingsQueryStateJSON result)
          {
            if (fieldGeneratorQueryDataAndResults.have_value)
              {
                result.initQueryDataAndResults();
                int count = fieldGeneratorQueryDataAndResults.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendQueryDataAndResults(fieldGeneratorQueryDataAndResults.value[num]);
                  }
                fieldGeneratorQueryDataAndResults.value.Clear();
                fieldGeneratorQueryDataAndResults.have_value = false;
              }
          }
        protected abstract void handle_result(SportsStandingsQueryStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "QueryDataAndResults", 0, 19, false) == 0) && (field_name.Length == 19))
                return fieldGeneratorQueryDataAndResults;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorQueryDataAndResults = new TypeQueryDataAndResultsJSON.HoldingArrayGenerator("field \"QueryDataAndResults\" of the SportsStandingsQueryState class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsStandingsQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorQueryDataAndResults = new TypeQueryDataAndResultsJSON.HoldingArrayGenerator("field \"QueryDataAndResults\" of the SportsStandingsQueryState class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsStandingsQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorQueryDataAndResults.reset();
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
        protected override void handle_result(SportsStandingsQueryStateJSON  result)
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
        public SportsStandingsQueryStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsStandingsQueryStateJSON  result)
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
    protected virtual void handle_result(List<SportsStandingsQueryStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsStandingsQueryStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsStandingsQueryStateJSON>();
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
    public List<SportsStandingsQueryStateJSON> value;
  };
  };
