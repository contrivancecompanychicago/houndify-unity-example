/* file "SportsOlympicsGamesResponseStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsOlympicsGamesResponseStateJSON : JSONBase
  {
    private bool flagHasGames;
    private List< SportsOlympicsGamesCodeJSON  > storeGames;
    private bool flagHasGamesNotFound;
    private bool storeGamesNotFound;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONGames(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Games of SportsOlympicsGamesResponseStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Games of SportsOlympicsGamesResponseStateJSON has too few elements.");
        List< SportsOlympicsGamesCodeJSON  > vector_Games1 = new List< SportsOlympicsGamesCodeJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsOlympicsGamesCodeJSON convert_classy = SportsOlympicsGamesCodeJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Games1.Add(convert_classy);
          }
        Debug.Assert(vector_Games1.Count >= 1);
        initGames();
        for (int num1 = 0; num1 < vector_Games1.Count; ++num1)
            appendGames(vector_Games1[num1]);
        for (int num1 = 0; num1 < vector_Games1.Count; ++num1)
          {
          }
      }


    private void  fromJSONGamesNotFound(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field GamesNotFound of SportsOlympicsGamesResponseStateJSON is not true for false.");
              }
          }
        setGamesNotFound(the_bool);
      }


    public SportsOlympicsGamesResponseStateJSON()
      {
        flagHasGames = false;
        flagHasGamesNotFound = false;
        storeGames = new List< SportsOlympicsGamesCodeJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasGames()
      {
        return flagHasGames;
      }

    public int  countOfGames()
      {
        Debug.Assert(flagHasGames);
        return storeGames.Count;
      }

    public SportsOlympicsGamesCodeJSON   elementOfGames(int element_num)
      {
        Debug.Assert(flagHasGames);
        return storeGames[element_num];
      }

    public List< SportsOlympicsGamesCodeJSON  >  getGames()
      {
        Debug.Assert(flagHasGames);
        return storeGames;
      }

    public bool  hasGamesNotFound()
      {
        return flagHasGamesNotFound;
      }

    public bool  getGamesNotFound()
      {
        Debug.Assert(flagHasGamesNotFound);
        return storeGamesNotFound;
      }


    public virtual int extraSportsOlympicsGamesResponseStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsOlympicsGamesResponseStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsOlympicsGamesResponseStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsOlympicsGamesResponseStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initGames()
      {
        if (flagHasGames)
          {
            for (int num1 = 0; num1 < storeGames.Count; ++num1)
              {
              }
          }
        flagHasGames = true;
        storeGames.Clear();
      }
    public void appendGames(SportsOlympicsGamesCodeJSON  to_append)
      {
        if (!flagHasGames)
          {
            flagHasGames = true;
            storeGames.Clear();
          }
        Debug.Assert(flagHasGames);
        storeGames.Add(to_append);
      }
    public void appendGames(SportsOlympicsGamesCodeJSON.TypeValue new_value)
      {
        appendGames(new SportsOlympicsGamesCodeJSON(new_value));
      }
    public void appendGames(string chars)
      {
        SportsOlympicsGamesCodeJSON.TypeValueKnownValues known = SportsOlympicsGamesCodeJSON.stringToValue(chars);
        SportsOlympicsGamesCodeJSON.TypeValue new_value = new SportsOlympicsGamesCodeJSON.TypeValue();
        if (known == SportsOlympicsGamesCodeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendGames(new_value);
      }
    public void unsetGames()
      {
        if (flagHasGames)
          {
            for (int num2 = 0; num2 < storeGames.Count; ++num2)
              {
              }
          }
        flagHasGames = false;
        storeGames.Clear();
      }
    public void setGamesNotFound(bool new_value)
      {
        flagHasGamesNotFound = true;
        storeGamesNotFound = new_value;
      }
    public void unsetGamesNotFound()
      {
        flagHasGamesNotFound = false;
      }

    public virtual void extraSportsOlympicsGamesResponseStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsOlympicsGamesResponseStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsOlympicsGamesResponseStateLookup(key);
        if (old_field == null)
          {
            extraSportsOlympicsGamesResponseStateAppendPair(key, new_component);
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
        if (flagHasGames)
          {
            handler.start_pair("Games");
            Debug.Assert(storeGames.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeGames.Count; ++num1)
              {
                if (partial_allowed)
                    storeGames[num1].write_partial_as_json(handler);
                else
                    storeGames[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasGamesNotFound)
          {
            handler.start_pair("GamesNotFound");
            handler.boolean_value(storeGamesNotFound);
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

    public static SportsOlympicsGamesResponseStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsGamesResponseStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsGamesResponseState", ignore_extras);
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
    public static SportsOlympicsGamesResponseStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsGamesResponseStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsGamesResponseStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsGamesResponseState", ignore_extras);
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
    public static SportsOlympicsGamesResponseStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsGamesResponseStateJSON from_text(string text, bool ignore_extras)
      {
        SportsOlympicsGamesResponseStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsGamesResponseState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsOlympicsGamesResponseStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsOlympicsGamesResponseStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsOlympicsGamesResponseStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsGamesResponseState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private SportsOlympicsGamesCodeJSON.HoldingArrayGenerator fieldGeneratorGames;
        private JSONHoldingBooleanGenerator fieldGeneratorGamesNotFound;
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
            SportsOlympicsGamesResponseStateJSON result = new SportsOlympicsGamesResponseStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsOlympicsGamesResponseStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsOlympicsGamesResponseStateJSON result)
          {
            if (fieldGeneratorGames.have_value)
              {
                result.initGames();
                int count = fieldGeneratorGames.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendGames(fieldGeneratorGames.value[num]);
                  }
                fieldGeneratorGames.value.Clear();
                fieldGeneratorGames.have_value = false;
              }
            if (fieldGeneratorGamesNotFound.have_value)
              {
                result.setGamesNotFound(fieldGeneratorGamesNotFound.value);
                fieldGeneratorGamesNotFound.have_value = false;
              }
          }
        protected abstract void handle_result(SportsOlympicsGamesResponseStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "Games", 0, 5, false) == 0)
              {
                if (field_name.Length == 5)
                  {
                    return fieldGeneratorGames;
                  }
                switch (field_name[5])
                  {
                    case 'N':
                        if ((String.Compare(field_name, 6, "otFound", 0, 7, false) == 0) && (field_name.Length == 13))
                            return fieldGeneratorGamesNotFound;
                        break;
                    default:
                        break;
                  }
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorGames = new SportsOlympicsGamesCodeJSON.HoldingArrayGenerator("field \"Games\" of the SportsOlympicsGamesResponseState class", ignore_extras);
            fieldGeneratorGamesNotFound = new JSONHoldingBooleanGenerator("field \"GamesNotFound\" of the SportsOlympicsGamesResponseState class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsOlympicsGamesResponseState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorGames = new SportsOlympicsGamesCodeJSON.HoldingArrayGenerator("field \"Games\" of the SportsOlympicsGamesResponseState class", false);
            fieldGeneratorGamesNotFound = new JSONHoldingBooleanGenerator("field \"GamesNotFound\" of the SportsOlympicsGamesResponseState class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsOlympicsGamesResponseState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorGames.reset();
            fieldGeneratorGamesNotFound.reset();
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
        protected override void handle_result(SportsOlympicsGamesResponseStateJSON  result)
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
        public SportsOlympicsGamesResponseStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsOlympicsGamesResponseStateJSON  result)
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
    protected virtual void handle_result(List<SportsOlympicsGamesResponseStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsOlympicsGamesResponseStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsOlympicsGamesResponseStateJSON>();
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
    public List<SportsOlympicsGamesResponseStateJSON> value;
  };
  };
