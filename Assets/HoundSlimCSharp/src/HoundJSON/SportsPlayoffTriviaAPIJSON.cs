/* file "SportsPlayoffTriviaAPIJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SportsPlayoffTriviaAPIJSON : JSONBase
  {
    public class TypeValueJSON : JSONBase
      {
        private bool flagHasTeamOneAlias;
        private string storeTeamOneAlias;
        private bool flagHasTeamTwoAlias;
        private string storeTeamTwoAlias;
        private bool flagHasTeamOneID;
        private string storeTeamOneID;
        private bool flagHasTeamTwoID;
        private string storeTeamTwoID;
        private bool flagHasLeague;
        private string storeLeague;
        private bool flagHasPlayoff_Type;
        private string storePlayoff_Type;
        private bool flagHasYear;
        private BigInteger storeYear;
        private bool flagHasOutcomeCount;
        private BigInteger storeOutcomeCount;
        private bool flagHasSportsResultsScore;
        private SportsGameSchedulesScoresAPIGameJSON  storeSportsResultsScore;
        private bool flagHasSportsTeam;
        private SportsTeamJSON  storeSportsTeam;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONTeamOneAlias(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field TeamOneAlias of TypeValueJSON is not a string.");
            setTeamOneAlias(json_string.getData());
          }


        private void  fromJSONTeamTwoAlias(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field TeamTwoAlias of TypeValueJSON is not a string.");
            setTeamTwoAlias(json_string.getData());
          }


        private void  fromJSONTeamOneID(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field TeamOneID of TypeValueJSON is not a string.");
            setTeamOneID(json_string.getData());
          }


        private void  fromJSONTeamTwoID(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field TeamTwoID of TypeValueJSON is not a string.");
            setTeamTwoID(json_string.getData());
          }


        private void  fromJSONLeague(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field League of TypeValueJSON is not a string.");
            setLeague(json_string.getData());
          }


        private void  fromJSONPlayoff_Type(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Playoff_Type of TypeValueJSON is not a string.");
            setPlayoff_Type(json_string.getData());
          }


        private void  fromJSONYear(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field Year of TypeValueJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Year of TypeValueJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setYear(extracted_integer);
          }


        private void  fromJSONOutcomeCount(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field OutcomeCount of TypeValueJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field OutcomeCount of TypeValueJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setOutcomeCount(extracted_integer);
          }


        private void  fromJSONSportsResultsScore(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            SportsGameSchedulesScoresAPIGameJSON convert_classy = SportsGameSchedulesScoresAPIGameJSON.from_json(json_value, ignore_extras, true);
            setSportsResultsScore(convert_classy);
          }


        private void  fromJSONSportsTeam(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            SportsTeamJSON convert_classy = SportsTeamJSON.from_json(json_value, ignore_extras, true);
            setSportsTeam(convert_classy);
          }


        public TypeValueJSON()
          {
            flagHasTeamOneAlias = false;
            flagHasTeamTwoAlias = false;
            flagHasTeamOneID = false;
            flagHasTeamTwoID = false;
            flagHasLeague = false;
            flagHasPlayoff_Type = false;
            flagHasYear = false;
            flagHasOutcomeCount = false;
            flagHasSportsResultsScore = false;
            flagHasSportsTeam = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasTeamOneAlias()
          {
            return flagHasTeamOneAlias;
          }

        public string  getTeamOneAlias()
          {
            Debug.Assert(flagHasTeamOneAlias);
            return storeTeamOneAlias;
          }

        public bool  hasTeamTwoAlias()
          {
            return flagHasTeamTwoAlias;
          }

        public string  getTeamTwoAlias()
          {
            Debug.Assert(flagHasTeamTwoAlias);
            return storeTeamTwoAlias;
          }

        public bool  hasTeamOneID()
          {
            return flagHasTeamOneID;
          }

        public string  getTeamOneID()
          {
            Debug.Assert(flagHasTeamOneID);
            return storeTeamOneID;
          }

        public bool  hasTeamTwoID()
          {
            return flagHasTeamTwoID;
          }

        public string  getTeamTwoID()
          {
            Debug.Assert(flagHasTeamTwoID);
            return storeTeamTwoID;
          }

        public bool  hasLeague()
          {
            return flagHasLeague;
          }

        public string  getLeague()
          {
            Debug.Assert(flagHasLeague);
            return storeLeague;
          }

        public bool  hasPlayoff_Type()
          {
            return flagHasPlayoff_Type;
          }

        public string  getPlayoff_Type()
          {
            Debug.Assert(flagHasPlayoff_Type);
            return storePlayoff_Type;
          }

        public bool  hasYear()
          {
            return flagHasYear;
          }

        public BigInteger  getYear()
          {
            Debug.Assert(flagHasYear);
            return storeYear;
          }

        public bool  hasOutcomeCount()
          {
            return flagHasOutcomeCount;
          }

        public BigInteger  getOutcomeCount()
          {
            Debug.Assert(flagHasOutcomeCount);
            return storeOutcomeCount;
          }

        public bool  hasSportsResultsScore()
          {
            return flagHasSportsResultsScore;
          }

        public SportsGameSchedulesScoresAPIGameJSON   getSportsResultsScore()
          {
            Debug.Assert(flagHasSportsResultsScore);
            return storeSportsResultsScore;
          }

        public bool  hasSportsTeam()
          {
            return flagHasSportsTeam;
          }

        public SportsTeamJSON   getSportsTeam()
          {
            Debug.Assert(flagHasSportsTeam);
            return storeSportsTeam;
          }


        public virtual int extraTypeValueComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeValueComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeValueComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeValueLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setTeamOneAlias(string new_value)
          {
            flagHasTeamOneAlias = true;
            storeTeamOneAlias = new_value;
          }
        public void unsetTeamOneAlias()
          {
            flagHasTeamOneAlias = false;
          }
        public void setTeamTwoAlias(string new_value)
          {
            flagHasTeamTwoAlias = true;
            storeTeamTwoAlias = new_value;
          }
        public void unsetTeamTwoAlias()
          {
            flagHasTeamTwoAlias = false;
          }
        public void setTeamOneID(string new_value)
          {
            flagHasTeamOneID = true;
            storeTeamOneID = new_value;
          }
        public void unsetTeamOneID()
          {
            flagHasTeamOneID = false;
          }
        public void setTeamTwoID(string new_value)
          {
            flagHasTeamTwoID = true;
            storeTeamTwoID = new_value;
          }
        public void unsetTeamTwoID()
          {
            flagHasTeamTwoID = false;
          }
        public void setLeague(string new_value)
          {
            flagHasLeague = true;
            storeLeague = new_value;
          }
        public void unsetLeague()
          {
            flagHasLeague = false;
          }
        public void setPlayoff_Type(string new_value)
          {
            flagHasPlayoff_Type = true;
            storePlayoff_Type = new_value;
          }
        public void unsetPlayoff_Type()
          {
            flagHasPlayoff_Type = false;
          }
        public void setYear(BigInteger new_value)
          {
            flagHasYear = true;
            if (new_value < 0)
                throw new Exception("The value for field Year of TypeValueJSON is less than the lower bound (0) for that field.");
            storeYear = new_value;
          }
        public void unsetYear()
          {
            flagHasYear = false;
          }
        public void setOutcomeCount(BigInteger new_value)
          {
            flagHasOutcomeCount = true;
            if (new_value < 0)
                throw new Exception("The value for field OutcomeCount of TypeValueJSON is less than the lower bound (0) for that field.");
            storeOutcomeCount = new_value;
          }
        public void unsetOutcomeCount()
          {
            flagHasOutcomeCount = false;
          }
        public void setSportsResultsScore(SportsGameSchedulesScoresAPIGameJSON  new_value)
          {
            if (flagHasSportsResultsScore)
              {
              }
            flagHasSportsResultsScore = true;
            storeSportsResultsScore = new_value;
          }
        public void unsetSportsResultsScore()
          {
            if (flagHasSportsResultsScore)
              {
              }
            flagHasSportsResultsScore = false;
          }
        public void setSportsTeam(SportsTeamJSON  new_value)
          {
            if (flagHasSportsTeam)
              {
              }
            flagHasSportsTeam = true;
            storeSportsTeam = new_value;
          }
        public void unsetSportsTeam()
          {
            if (flagHasSportsTeam)
              {
              }
            flagHasSportsTeam = false;
          }

        public virtual void extraTypeValueAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeValueSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeValueLookup(key);
            if (old_field == null)
              {
                extraTypeValueAppendPair(key, new_component);
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
            if (flagHasTeamOneAlias)
              {
                handler.start_pair("TeamOneAlias");
                handler.string_value(storeTeamOneAlias);
              }
            if (flagHasTeamTwoAlias)
              {
                handler.start_pair("TeamTwoAlias");
                handler.string_value(storeTeamTwoAlias);
              }
            if (flagHasTeamOneID)
              {
                handler.start_pair("TeamOneID");
                handler.string_value(storeTeamOneID);
              }
            if (flagHasTeamTwoID)
              {
                handler.start_pair("TeamTwoID");
                handler.string_value(storeTeamTwoID);
              }
            if (flagHasLeague)
              {
                handler.start_pair("League");
                handler.string_value(storeLeague);
              }
            if (flagHasPlayoff_Type)
              {
                handler.start_pair("Playoff_Type");
                handler.string_value(storePlayoff_Type);
              }
            if (flagHasYear)
              {
                handler.start_pair("Year");
                handler.number_value(storeYear);
              }
            if (flagHasOutcomeCount)
              {
                handler.start_pair("OutcomeCount");
                handler.number_value(storeOutcomeCount);
              }
            if (flagHasSportsResultsScore)
              {
                handler.start_pair("SportsResultsScore");
                if (partial_allowed)
                    storeSportsResultsScore.write_partial_as_json(handler);
                else
                    storeSportsResultsScore.write_as_json(handler);
              }
            if (flagHasSportsTeam)
              {
                handler.start_pair("SportsTeam");
                if (partial_allowed)
                    storeSportsTeam.write_partial_as_json(handler);
                else
                    storeSportsTeam.write_as_json(handler);
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

        public static TypeValueJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeValueJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeValue", ignore_extras);
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
        public static TypeValueJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeValueJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeValueJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeValue", ignore_extras);
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
        public static TypeValueJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeValueJSON from_text(string text, bool ignore_extras)
          {
            TypeValueJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeValue", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeValueJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeValueJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeValueJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeValue", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorTeamOneAlias;
            private JSONHoldingStringGenerator fieldGeneratorTeamTwoAlias;
            private JSONHoldingStringGenerator fieldGeneratorTeamOneID;
            private JSONHoldingStringGenerator fieldGeneratorTeamTwoID;
            private JSONHoldingStringGenerator fieldGeneratorLeague;
            private JSONHoldingStringGenerator fieldGeneratorPlayoff_Type;
        private class FieldHoldingGeneratorYear : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorYear(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorYear : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorYear(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorYear fieldGeneratorYear;
        private class FieldHoldingGeneratorOutcomeCount : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorOutcomeCount(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorOutcomeCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorOutcomeCount(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorOutcomeCount fieldGeneratorOutcomeCount;
            private SportsGameSchedulesScoresAPIGameJSON.HoldingGenerator fieldGeneratorSportsResultsScore;
            private SportsTeamJSON.HoldingGenerator fieldGeneratorSportsTeam;
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
                TypeValueJSON result = new TypeValueJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeValueAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeValueJSON result)
              {
                if (fieldGeneratorTeamOneAlias.have_value)
                  {
                    result.setTeamOneAlias(fieldGeneratorTeamOneAlias.value);
                    fieldGeneratorTeamOneAlias.have_value = false;
                  }
                if (fieldGeneratorTeamTwoAlias.have_value)
                  {
                    result.setTeamTwoAlias(fieldGeneratorTeamTwoAlias.value);
                    fieldGeneratorTeamTwoAlias.have_value = false;
                  }
                if (fieldGeneratorTeamOneID.have_value)
                  {
                    result.setTeamOneID(fieldGeneratorTeamOneID.value);
                    fieldGeneratorTeamOneID.have_value = false;
                  }
                if (fieldGeneratorTeamTwoID.have_value)
                  {
                    result.setTeamTwoID(fieldGeneratorTeamTwoID.value);
                    fieldGeneratorTeamTwoID.have_value = false;
                  }
                if (fieldGeneratorLeague.have_value)
                  {
                    result.setLeague(fieldGeneratorLeague.value);
                    fieldGeneratorLeague.have_value = false;
                  }
                if (fieldGeneratorPlayoff_Type.have_value)
                  {
                    result.setPlayoff_Type(fieldGeneratorPlayoff_Type.value);
                    fieldGeneratorPlayoff_Type.have_value = false;
                  }
                if (fieldGeneratorYear.have_value)
                  {
                    result.setYear(fieldGeneratorYear.value);
                    fieldGeneratorYear.have_value = false;
                  }
                if (fieldGeneratorOutcomeCount.have_value)
                  {
                    result.setOutcomeCount(fieldGeneratorOutcomeCount.value);
                    fieldGeneratorOutcomeCount.have_value = false;
                  }
                if (fieldGeneratorSportsResultsScore.have_value)
                  {
                    result.setSportsResultsScore(fieldGeneratorSportsResultsScore.value);
                    fieldGeneratorSportsResultsScore.have_value = false;
                  }
                if (fieldGeneratorSportsTeam.have_value)
                  {
                    result.setSportsTeam(fieldGeneratorSportsTeam.value);
                    fieldGeneratorSportsTeam.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeValueJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'L':
                        if ((String.Compare(field_name, 1, "eague", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorLeague;
                        break;
                    case 'O':
                        if ((String.Compare(field_name, 1, "utcomeCount", 0, 11, false) == 0) && (field_name.Length == 12))
                            return fieldGeneratorOutcomeCount;
                        break;
                    case 'P':
                        if ((String.Compare(field_name, 1, "layoff_Type", 0, 11, false) == 0) && (field_name.Length == 12))
                            return fieldGeneratorPlayoff_Type;
                        break;
                    case 'S':
                        if (String.Compare(field_name, 1, "ports", 0, 5, false) == 0)
                          {
                            switch (field_name[6])
                              {
                                case 'R':
                                    if ((String.Compare(field_name, 7, "esultsScore", 0, 11, false) == 0) && (field_name.Length == 18))
                                        return fieldGeneratorSportsResultsScore;
                                    break;
                                case 'T':
                                    if ((String.Compare(field_name, 7, "eam", 0, 3, false) == 0) && (field_name.Length == 10))
                                        return fieldGeneratorSportsTeam;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'T':
                        if (String.Compare(field_name, 1, "eam", 0, 3, false) == 0)
                          {
                            switch (field_name[4])
                              {
                                case 'O':
                                    if (String.Compare(field_name, 5, "ne", 0, 2, false) == 0)
                                      {
                                        switch (field_name[7])
                                          {
                                            case 'A':
                                                if ((String.Compare(field_name, 8, "lias", 0, 4, false) == 0) && (field_name.Length == 12))
                                                    return fieldGeneratorTeamOneAlias;
                                                break;
                                            case 'I':
                                                if ((String.Compare(field_name, 8, "D", 0, 1, false) == 0) && (field_name.Length == 9))
                                                    return fieldGeneratorTeamOneID;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'T':
                                    if (String.Compare(field_name, 5, "wo", 0, 2, false) == 0)
                                      {
                                        switch (field_name[7])
                                          {
                                            case 'A':
                                                if ((String.Compare(field_name, 8, "lias", 0, 4, false) == 0) && (field_name.Length == 12))
                                                    return fieldGeneratorTeamTwoAlias;
                                                break;
                                            case 'I':
                                                if ((String.Compare(field_name, 8, "D", 0, 1, false) == 0) && (field_name.Length == 9))
                                                    return fieldGeneratorTeamTwoID;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'Y':
                        if ((String.Compare(field_name, 1, "ear", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorYear;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorTeamOneAlias = new JSONHoldingStringGenerator("field \"TeamOneAlias\" of the TypeValue class");
                fieldGeneratorTeamTwoAlias = new JSONHoldingStringGenerator("field \"TeamTwoAlias\" of the TypeValue class");
                fieldGeneratorTeamOneID = new JSONHoldingStringGenerator("field \"TeamOneID\" of the TypeValue class");
                fieldGeneratorTeamTwoID = new JSONHoldingStringGenerator("field \"TeamTwoID\" of the TypeValue class");
                fieldGeneratorLeague = new JSONHoldingStringGenerator("field \"League\" of the TypeValue class");
                fieldGeneratorPlayoff_Type = new JSONHoldingStringGenerator("field \"Playoff_Type\" of the TypeValue class");
                fieldGeneratorYear = new FieldHoldingGeneratorYear("field \"Year\" of the TypeValue class");
                fieldGeneratorOutcomeCount = new FieldHoldingGeneratorOutcomeCount("field \"OutcomeCount\" of the TypeValue class");
                fieldGeneratorSportsResultsScore = new SportsGameSchedulesScoresAPIGameJSON.HoldingGenerator("field \"SportsResultsScore\" of the TypeValue class", ignore_extras);
                fieldGeneratorSportsTeam = new SportsTeamJSON.HoldingGenerator("field \"SportsTeam\" of the TypeValue class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeValue class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorTeamOneAlias = new JSONHoldingStringGenerator("field \"TeamOneAlias\" of the TypeValue class");
                fieldGeneratorTeamTwoAlias = new JSONHoldingStringGenerator("field \"TeamTwoAlias\" of the TypeValue class");
                fieldGeneratorTeamOneID = new JSONHoldingStringGenerator("field \"TeamOneID\" of the TypeValue class");
                fieldGeneratorTeamTwoID = new JSONHoldingStringGenerator("field \"TeamTwoID\" of the TypeValue class");
                fieldGeneratorLeague = new JSONHoldingStringGenerator("field \"League\" of the TypeValue class");
                fieldGeneratorPlayoff_Type = new JSONHoldingStringGenerator("field \"Playoff_Type\" of the TypeValue class");
                fieldGeneratorYear = new FieldHoldingGeneratorYear("field \"Year\" of the TypeValue class");
                fieldGeneratorOutcomeCount = new FieldHoldingGeneratorOutcomeCount("field \"OutcomeCount\" of the TypeValue class");
                fieldGeneratorSportsResultsScore = new SportsGameSchedulesScoresAPIGameJSON.HoldingGenerator("field \"SportsResultsScore\" of the TypeValue class", false);
                fieldGeneratorSportsTeam = new SportsTeamJSON.HoldingGenerator("field \"SportsTeam\" of the TypeValue class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeValue class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorTeamOneAlias.reset();
                fieldGeneratorTeamTwoAlias.reset();
                fieldGeneratorTeamOneID.reset();
                fieldGeneratorTeamTwoID.reset();
                fieldGeneratorLeague.reset();
                fieldGeneratorPlayoff_Type.reset();
                fieldGeneratorYear.reset();
                fieldGeneratorOutcomeCount.reset();
                fieldGeneratorSportsResultsScore.reset();
                fieldGeneratorSportsTeam.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorSportsResultsScore.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorSportsTeam.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorSportsResultsScore.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorSportsTeam.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeValueJSON  result)
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
            public TypeValueJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeValueJSON  result)
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
        protected virtual void handle_result(List<TypeValueJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeValueJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeValueJSON>();
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
        public List<TypeValueJSON> value;
      };
      };
    private bool flagHasValue;
    private List< TypeValueJSON  > storeValue;


    private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Value of SportsPlayoffTriviaAPIJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeValueJSON  > vector_Value1 = new List< TypeValueJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeValueJSON convert_classy = TypeValueJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Value1.Add(convert_classy);
          }
        initValue();
        for (int num1 = 0; num1 < vector_Value1.Count; ++num1)
            appendValue(vector_Value1[num1]);
        for (int num1 = 0; num1 < vector_Value1.Count; ++num1)
          {
          }
      }


    public SportsPlayoffTriviaAPIJSON()
      {
        flagHasValue = false;
        storeValue = new List< TypeValueJSON  >();
      }

    public bool  hasValue()
      {
        return flagHasValue;
      }

    public int  countOfValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue.Count;
      }

    public TypeValueJSON   elementOfValue(int element_num)
      {
        Debug.Assert(flagHasValue);
        return storeValue[element_num];
      }

    public List< TypeValueJSON  >  getValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue;
      }



    public void initValue()
      {
        if (flagHasValue)
          {
            for (int num1 = 0; num1 < storeValue.Count; ++num1)
              {
              }
          }
        flagHasValue = true;
        storeValue.Clear();
      }
    public void appendValue(TypeValueJSON  to_append)
      {
        if (!flagHasValue)
          {
            flagHasValue = true;
            storeValue.Clear();
          }
        Debug.Assert(flagHasValue);
        storeValue.Add(to_append);
      }
    public void unsetValue()
      {
        if (flagHasValue)
          {
            for (int num2 = 0; num2 < storeValue.Count; ++num2)
              {
              }
          }
        flagHasValue = false;
        storeValue.Clear();
      }


    public override void write_as_json(JSONHandler handler)
      {
        handler.start_array();
        for (int num1 = 0; num1 < storeValue.Count; ++num1)
          {
            storeValue[num1].write_as_json(handler);
          }
        handler.finish_array();
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_array();
        for (int num2 = 0; num2 < storeValue.Count; ++num2)
          {
            storeValue[num2].write_partial_as_json(handler);
          }
        handler.finish_array();
      }

    public static SportsPlayoffTriviaAPIJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsPlayoffTriviaAPIJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayoffTriviaAPI", ignore_extras);
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
    public static SportsPlayoffTriviaAPIJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsPlayoffTriviaAPIJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsPlayoffTriviaAPIJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayoffTriviaAPI", ignore_extras);
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
    public static SportsPlayoffTriviaAPIJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsPlayoffTriviaAPIJSON from_text(string text, bool ignore_extras)
      {
        SportsPlayoffTriviaAPIJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayoffTriviaAPI", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsPlayoffTriviaAPIJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsPlayoffTriviaAPIJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsPlayoffTriviaAPIJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayoffTriviaAPI", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : TypeValueJSON.HoldingArrayGenerator
      {
        protected void finish()
          {
            Debug.Assert(have_value);
            SportsPlayoffTriviaAPIJSON result = new SportsPlayoffTriviaAPIJSON();
            result.initValue();
            int count = value.Count;
            for (int num = 0; num < count; ++num)
              {
                result.appendValue(value[num]);
              }
            handle_result(result);
          }
        protected abstract void handle_result(SportsPlayoffTriviaAPIJSON new_result);
        public Generator(bool ignore_extras) : base("Type SportsPlayoffTriviaAPI", ignore_extras)
          {
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsPlayoffTriviaAPIJSON  result)
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
        public SportsPlayoffTriviaAPIJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsPlayoffTriviaAPIJSON  result)
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
    protected virtual void handle_result(List<SportsPlayoffTriviaAPIJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsPlayoffTriviaAPIJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsPlayoffTriviaAPIJSON>();
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
    public List<SportsPlayoffTriviaAPIJSON> value;
  };
  };
