/* file "SportsTeamAndRankJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SportsTeamAndRankJSON : JSONBase
  {
    private bool flagHasTeam;
    private SportsTeamNewJSON  storeTeam;
    private bool flagHasOutcomeCount;
    private BigInteger storeOutcomeCount;
    private bool flagHasRank;
    private BigInteger storeRank;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONTeam(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsTeamNewJSON convert_classy = SportsTeamNewJSON.from_json(json_value, ignore_extras, true);
        setTeam(convert_classy);
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
                throw new Exception("The value for field OutcomeCount of SportsTeamAndRankJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field OutcomeCount of SportsTeamAndRankJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setOutcomeCount(extracted_integer);
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
                throw new Exception("The value for field Rank of SportsTeamAndRankJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Rank of SportsTeamAndRankJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setRank(extracted_integer);
      }


    public SportsTeamAndRankJSON()
      {
        flagHasTeam = false;
        flagHasOutcomeCount = false;
        flagHasRank = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
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

    public bool  hasOutcomeCount()
      {
        return flagHasOutcomeCount;
      }

    public BigInteger  getOutcomeCount()
      {
        Debug.Assert(flagHasOutcomeCount);
        return storeOutcomeCount;
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


    public virtual int extraSportsTeamAndRankComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsTeamAndRankComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsTeamAndRankComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsTeamAndRankLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
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
    public void setOutcomeCount(BigInteger new_value)
      {
        flagHasOutcomeCount = true;
        if (new_value < -1)
            throw new Exception("The value for field OutcomeCount of SportsTeamAndRankJSON is less than the lower bound (-1) for that field.");
        storeOutcomeCount = new_value;
      }
    public void unsetOutcomeCount()
      {
        flagHasOutcomeCount = false;
      }
    public void setRank(BigInteger new_value)
      {
        flagHasRank = true;
        if (new_value < -1)
            throw new Exception("The value for field Rank of SportsTeamAndRankJSON is less than the lower bound (-1) for that field.");
        storeRank = new_value;
      }
    public void unsetRank()
      {
        flagHasRank = false;
      }

    public virtual void extraSportsTeamAndRankAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsTeamAndRankSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsTeamAndRankLookup(key);
        if (old_field == null)
          {
            extraSportsTeamAndRankAppendPair(key, new_component);
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
        if (flagHasTeam)
          {
            handler.start_pair("Team");
            if (partial_allowed)
                storeTeam.write_partial_as_json(handler);
            else
                storeTeam.write_as_json(handler);
          }
        if (flagHasOutcomeCount)
          {
            handler.start_pair("OutcomeCount");
            handler.number_value(storeOutcomeCount);
          }
        if (flagHasRank)
          {
            handler.start_pair("Rank");
            handler.number_value(storeRank);
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

    public static SportsTeamAndRankJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsTeamAndRankJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsTeamAndRank", ignore_extras);
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
    public static SportsTeamAndRankJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsTeamAndRankJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsTeamAndRankJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsTeamAndRank", ignore_extras);
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
    public static SportsTeamAndRankJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsTeamAndRankJSON from_text(string text, bool ignore_extras)
      {
        SportsTeamAndRankJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsTeamAndRank", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsTeamAndRankJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsTeamAndRankJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsTeamAndRankJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsTeamAndRank", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private SportsTeamNewJSON.HoldingGenerator fieldGeneratorTeam;
    private class FieldHoldingGeneratorOutcomeCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorOutcomeCount(String what) : base(what, (BigInteger)(-1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorOutcomeCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorOutcomeCount(String what) : base(what, (BigInteger)(-1))
              {
              }
          };
        private FieldHoldingGeneratorOutcomeCount fieldGeneratorOutcomeCount;
    private class FieldHoldingGeneratorRank : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorRank(String what) : base(what, (BigInteger)(-1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorRank : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorRank(String what) : base(what, (BigInteger)(-1))
              {
              }
          };
        private FieldHoldingGeneratorRank fieldGeneratorRank;
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
            SportsTeamAndRankJSON result = new SportsTeamAndRankJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsTeamAndRankAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsTeamAndRankJSON result)
          {
            if (fieldGeneratorTeam.have_value)
              {
                result.setTeam(fieldGeneratorTeam.value);
                fieldGeneratorTeam.have_value = false;
              }
            if (fieldGeneratorOutcomeCount.have_value)
              {
                result.setOutcomeCount(fieldGeneratorOutcomeCount.value);
                fieldGeneratorOutcomeCount.have_value = false;
              }
            if (fieldGeneratorRank.have_value)
              {
                result.setRank(fieldGeneratorRank.value);
                fieldGeneratorRank.have_value = false;
              }
          }
        protected abstract void handle_result(SportsTeamAndRankJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'O':
                    if ((String.Compare(field_name, 1, "utcomeCount", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorOutcomeCount;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "ank", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorRank;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "eam", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorTeam;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorTeam = new SportsTeamNewJSON.HoldingGenerator("field \"Team\" of the SportsTeamAndRank class", ignore_extras);
            fieldGeneratorOutcomeCount = new FieldHoldingGeneratorOutcomeCount("field \"OutcomeCount\" of the SportsTeamAndRank class");
            fieldGeneratorRank = new FieldHoldingGeneratorRank("field \"Rank\" of the SportsTeamAndRank class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsTeamAndRank class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorTeam = new SportsTeamNewJSON.HoldingGenerator("field \"Team\" of the SportsTeamAndRank class", false);
            fieldGeneratorOutcomeCount = new FieldHoldingGeneratorOutcomeCount("field \"OutcomeCount\" of the SportsTeamAndRank class");
            fieldGeneratorRank = new FieldHoldingGeneratorRank("field \"Rank\" of the SportsTeamAndRank class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsTeamAndRank class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorTeam.reset();
            fieldGeneratorOutcomeCount.reset();
            fieldGeneratorRank.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorTeam.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorTeam.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsTeamAndRankJSON  result)
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
        public SportsTeamAndRankJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsTeamAndRankJSON  result)
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
    protected virtual void handle_result(List<SportsTeamAndRankJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsTeamAndRankJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsTeamAndRankJSON>();
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
    public List<SportsTeamAndRankJSON> value;
  };
  };
