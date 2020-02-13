/* file "SportsOlympicsEventSchedulesAndResultsQueryStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsOlympicsEventSchedulesAndResultsQueryStateJSON : JSONBase
  {
    private bool flagHasArgumentSets;
    private List< List< SportsOlympicsEventSchedulesAndResultsArgumentJSON  > > storeArgumentSets;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONArgumentSets(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ArgumentSets of SportsOlympicsEventSchedulesAndResultsQueryStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field ArgumentSets of SportsOlympicsEventSchedulesAndResultsQueryStateJSON has too few elements.");
        List< List< SportsOlympicsEventSchedulesAndResultsArgumentJSON  > > vector_ArgumentSets1 = new List< List< SportsOlympicsEventSchedulesAndResultsArgumentJSON  > >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONArrayValue json_array2 = json_array1.component(num1).array_value();
            if (json_array2 == null)
                throw new Exception("The value for an element of field ArgumentSets of SportsOlympicsEventSchedulesAndResultsQueryStateJSON is not an array.");
            int count2 = json_array2.componentCount();
            if (count2 < 1)
                throw new Exception("The value for an element of field ArgumentSets of SportsOlympicsEventSchedulesAndResultsQueryStateJSON has too few elements.");
            List< SportsOlympicsEventSchedulesAndResultsArgumentJSON  > vector_ArgumentSets2 = new List< SportsOlympicsEventSchedulesAndResultsArgumentJSON  >(count2);
            for (int num2 = 0; num2 < count2; ++num2)
              {
                SportsOlympicsEventSchedulesAndResultsArgumentJSON convert_classy = SportsOlympicsEventSchedulesAndResultsArgumentJSON.from_json(json_array2.component(num2), ignore_extras, true);
                vector_ArgumentSets2.Add(convert_classy);
              }
            vector_ArgumentSets1.Add(vector_ArgumentSets2);
          }
        Debug.Assert(vector_ArgumentSets1.Count >= 1);
        initArgumentSets();
        for (int num1 = 0; num1 < vector_ArgumentSets1.Count; ++num1)
            appendArgumentSets(vector_ArgumentSets1[num1]);
        for (int num1 = 0; num1 < vector_ArgumentSets1.Count; ++num1)
          {
            for (int num2 = 0; num2 < vector_ArgumentSets1[num1].Count; ++num2)
              {
              }
          }
      }


    public SportsOlympicsEventSchedulesAndResultsQueryStateJSON()
      {
        flagHasArgumentSets = false;
        storeArgumentSets = new List< List< SportsOlympicsEventSchedulesAndResultsArgumentJSON  > >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasArgumentSets()
      {
        return flagHasArgumentSets;
      }

    public int  countOfArgumentSets()
      {
        Debug.Assert(flagHasArgumentSets);
        return storeArgumentSets.Count;
      }

    public List< SportsOlympicsEventSchedulesAndResultsArgumentJSON  >  elementOfArgumentSets(int element_num)
      {
        Debug.Assert(flagHasArgumentSets);
        return storeArgumentSets[element_num];
      }

    public List< List< SportsOlympicsEventSchedulesAndResultsArgumentJSON  > >  getArgumentSets()
      {
        Debug.Assert(flagHasArgumentSets);
        return storeArgumentSets;
      }


    public virtual int extraSportsOlympicsEventSchedulesAndResultsQueryStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsOlympicsEventSchedulesAndResultsQueryStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsOlympicsEventSchedulesAndResultsQueryStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsOlympicsEventSchedulesAndResultsQueryStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initArgumentSets()
      {
        if (flagHasArgumentSets)
          {
            for (int num1 = 0; num1 < storeArgumentSets.Count; ++num1)
              {
                for (int num2 = 0; num2 < storeArgumentSets[num1].Count; ++num2)
                  {
                  }
              }
          }
        flagHasArgumentSets = true;
        storeArgumentSets.Clear();
      }
    public void appendArgumentSets(List< SportsOlympicsEventSchedulesAndResultsArgumentJSON  > to_append)
      {
        if (!flagHasArgumentSets)
          {
            flagHasArgumentSets = true;
            storeArgumentSets.Clear();
          }
        Debug.Assert(flagHasArgumentSets);
        for (int num1 = 0; num1 < to_append.Count; ++num1)
          {
          }
        storeArgumentSets.Add(to_append);
      }
    public void unsetArgumentSets()
      {
        if (flagHasArgumentSets)
          {
            for (int num3 = 0; num3 < storeArgumentSets.Count; ++num3)
              {
                for (int num4 = 0; num4 < storeArgumentSets[num3].Count; ++num4)
                  {
                  }
              }
          }
        flagHasArgumentSets = false;
        storeArgumentSets.Clear();
      }

    public virtual void extraSportsOlympicsEventSchedulesAndResultsQueryStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsOlympicsEventSchedulesAndResultsQueryStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsOlympicsEventSchedulesAndResultsQueryStateLookup(key);
        if (old_field == null)
          {
            extraSportsOlympicsEventSchedulesAndResultsQueryStateAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasArgumentSets);
        if (flagHasArgumentSets)
          {
            handler.start_pair("ArgumentSets");
            Debug.Assert(storeArgumentSets.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeArgumentSets.Count; ++num1)
              {
                Debug.Assert(storeArgumentSets[num1].Count >= 1);
                handler.start_array();
                for (int num2 = 0; num2 < storeArgumentSets[num1].Count; ++num2)
                  {
                    if (partial_allowed)
                        storeArgumentSets[num1][num2].write_partial_as_json(handler);
                    else
                        storeArgumentSets[num1][num2].write_as_json(handler);
                  }
                handler.finish_array();
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
        if (!(hasArgumentSets()))
          {
            return "When parsing the object for %what%, the \"ArgumentSets\" field was missing.";
          }
        return null;
      }

    public static SportsOlympicsEventSchedulesAndResultsQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsEventSchedulesAndResultsQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsQueryState", ignore_extras);
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
    public static SportsOlympicsEventSchedulesAndResultsQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsEventSchedulesAndResultsQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsEventSchedulesAndResultsQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsQueryState", ignore_extras);
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
    public static SportsOlympicsEventSchedulesAndResultsQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsEventSchedulesAndResultsQueryStateJSON from_text(string text, bool ignore_extras)
      {
        SportsOlympicsEventSchedulesAndResultsQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsQueryState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsOlympicsEventSchedulesAndResultsQueryStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsOlympicsEventSchedulesAndResultsQueryStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsOlympicsEventSchedulesAndResultsQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsQueryState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingArrayGeneratorArgumentSets : JSONArrayGenerator
  {
    protected class ElementHandler : SportsOlympicsEventSchedulesAndResultsArgumentJSON.HoldingArrayGenerator
      {
        private FieldHoldingArrayGeneratorArgumentSets top;

        protected override void handle_result(List< SportsOlympicsEventSchedulesAndResultsArgumentJSON  > result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorArgumentSets init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<List< SportsOlympicsEventSchedulesAndResultsArgumentJSON  >> result)
      {
      }

    public FieldHoldingArrayGeneratorArgumentSets(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<List< SportsOlympicsEventSchedulesAndResultsArgumentJSON  >>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorArgumentSets(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<List< SportsOlympicsEventSchedulesAndResultsArgumentJSON  >>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<List< SportsOlympicsEventSchedulesAndResultsArgumentJSON  >> value;
  };
        private FieldHoldingArrayGeneratorArgumentSets fieldGeneratorArgumentSets;
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
            SportsOlympicsEventSchedulesAndResultsQueryStateJSON result = new SportsOlympicsEventSchedulesAndResultsQueryStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsOlympicsEventSchedulesAndResultsQueryStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsOlympicsEventSchedulesAndResultsQueryStateJSON result)
          {
            if (fieldGeneratorArgumentSets.have_value)
              {
                result.initArgumentSets();
                int count = fieldGeneratorArgumentSets.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    List< SportsOlympicsEventSchedulesAndResultsArgumentJSON  > unwrapped0 = new List< SportsOlympicsEventSchedulesAndResultsArgumentJSON  >();
                    for (int num0 = 0; num0 < fieldGeneratorArgumentSets.value[num].Count; ++num0)
                      {
                        unwrapped0.Add(fieldGeneratorArgumentSets.value[num][num0]);
                      }
                    result.appendArgumentSets(unwrapped0);
                  }
                fieldGeneratorArgumentSets.value.Clear();
                fieldGeneratorArgumentSets.have_value = false;
              }
            else if ((!(result.hasArgumentSets())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ArgumentSets\" field was missing.");
              }
          }
        protected abstract void handle_result(SportsOlympicsEventSchedulesAndResultsQueryStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "ArgumentSets", 0, 12, false) == 0) && (field_name.Length == 12))
                return fieldGeneratorArgumentSets;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorArgumentSets = new FieldHoldingArrayGeneratorArgumentSets("field \"ArgumentSets\" of the SportsOlympicsEventSchedulesAndResultsQueryState class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsOlympicsEventSchedulesAndResultsQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorArgumentSets = new FieldHoldingArrayGeneratorArgumentSets("field \"ArgumentSets\" of the SportsOlympicsEventSchedulesAndResultsQueryState class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsOlympicsEventSchedulesAndResultsQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorArgumentSets.reset();
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
        protected override void handle_result(SportsOlympicsEventSchedulesAndResultsQueryStateJSON  result)
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
        public SportsOlympicsEventSchedulesAndResultsQueryStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsOlympicsEventSchedulesAndResultsQueryStateJSON  result)
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
    protected virtual void handle_result(List<SportsOlympicsEventSchedulesAndResultsQueryStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsOlympicsEventSchedulesAndResultsQueryStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsOlympicsEventSchedulesAndResultsQueryStateJSON>();
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
    public List<SportsOlympicsEventSchedulesAndResultsQueryStateJSON> value;
  };
  };
