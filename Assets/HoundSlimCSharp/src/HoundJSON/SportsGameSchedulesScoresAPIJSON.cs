/* file "SportsGameSchedulesScoresAPIJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsGameSchedulesScoresAPIJSON : JSONBase
  {
    public struct TypeValue
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public SportsResultScoreCricketJSON  choice0;
            [FieldOffset(0)]
            public SportsGameSchedulesScoresAPIGameJSON  choice1;
          };
        public Utype u;
      };
    private bool flagHasValue;
    private List< TypeValue > storeValue;


    private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Value of SportsGameSchedulesScoresAPIJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeValue > vector_Value1 = new List< TypeValue >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeValue or_result = new TypeValue();
            bool or_done = false;
            if (!or_done)
              {
                try
                  {
                    SportsResultScoreCricketJSON convert_classy = SportsResultScoreCricketJSON.from_json(json_array1.component(num1), ignore_extras, true);
                    or_result.u.choice0 = convert_classy;
                    or_result.key = 0;
                    or_done = true;
                  }
                catch (Exception )
                  {
                  }
              }
            if (!or_done)
              {
                try
                  {
                    SportsGameSchedulesScoresAPIGameJSON convert_classy = SportsGameSchedulesScoresAPIGameJSON.from_json(json_array1.component(num1), ignore_extras, true);
                    or_result.u.choice1 = convert_classy;
                    or_result.key = 1;
                    or_done = true;
                  }
                catch (Exception )
                  {
                  }
              }
            if (!or_done)
                throw new Exception("The value for an element of field Value of SportsGameSchedulesScoresAPIJSON is not one of the allowed values.");
            vector_Value1.Add(or_result);
          }
        initValue();
        for (int num1 = 0; num1 < vector_Value1.Count; ++num1)
            appendValue(vector_Value1[num1]);
        for (int num1 = 0; num1 < vector_Value1.Count; ++num1)
          {
            switch (vector_Value1[num1].key)
              {
                case 0:
                    break;
                case 1:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
      }


    public SportsGameSchedulesScoresAPIJSON()
      {
        flagHasValue = false;
        storeValue = new List< TypeValue >();
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

    public TypeValue  elementOfValue(int element_num)
      {
        Debug.Assert(flagHasValue);
        return storeValue[element_num];
      }

    public List< TypeValue >  getValue()
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
                switch (storeValue[num1].key)
                  {
                    case 0:
                        break;
                    case 1:
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
          }
        flagHasValue = true;
        storeValue.Clear();
      }
    public void appendValue(TypeValue to_append)
      {
        if (!flagHasValue)
          {
            flagHasValue = true;
            storeValue.Clear();
          }
        Debug.Assert(flagHasValue);
        switch (to_append.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeValue.Add(to_append);
      }
    public void unsetValue()
      {
        if (flagHasValue)
          {
            for (int num2 = 0; num2 < storeValue.Count; ++num2)
              {
                switch (storeValue[num2].key)
                  {
                    case 0:
                        break;
                    case 1:
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
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
            switch (storeValue[num1].key)
              {
                case 0:
                    storeValue[num1].u.choice0.write_as_json(handler);
                    break;
                case 1:
                    storeValue[num1].u.choice1.write_as_json(handler);
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        handler.finish_array();
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_array();
        for (int num2 = 0; num2 < storeValue.Count; ++num2)
          {
            switch (storeValue[num2].key)
              {
                case 0:
                    storeValue[num2].u.choice0.write_partial_as_json(handler);
                    break;
                case 1:
                    storeValue[num2].u.choice1.write_partial_as_json(handler);
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        handler.finish_array();
      }

    public static SportsGameSchedulesScoresAPIJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsGameSchedulesScoresAPIJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsGameSchedulesScoresAPI", ignore_extras);
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
    public static SportsGameSchedulesScoresAPIJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsGameSchedulesScoresAPIJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsGameSchedulesScoresAPIJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsGameSchedulesScoresAPI", ignore_extras);
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
    public static SportsGameSchedulesScoresAPIJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsGameSchedulesScoresAPIJSON from_text(string text, bool ignore_extras)
      {
        SportsGameSchedulesScoresAPIJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsGameSchedulesScoresAPI", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsGameSchedulesScoresAPIJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsGameSchedulesScoresAPIJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsGameSchedulesScoresAPIJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsGameSchedulesScoresAPI", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class FieldGeneratorValue : JSONParallelGenerator
      {
        private SportsResultScoreCricketJSON.HoldingGenerator field0;
        private SportsGameSchedulesScoresAPIGameJSON.HoldingGenerator field1;
        private JSONHandler [] all_handlers = new JSONHandler [2];
        protected override JSONHandler[] start()
          {
            return all_handlers;
          }
        protected override void finish(int winning_index)
          {
            TypeValue result = new TypeValue();
            result.key = winning_index;
            switch (winning_index)
              {
                case 0:
                  {
                    Debug.Assert(field0.have_value);
                    result.u.choice0 = field0.value;
                    break;
                  }
                case 1:
                  {
                    Debug.Assert(field1.have_value);
                    result.u.choice1 = field1.value;
                    break;
                  }
                default:
                  {
                    Debug.Assert(false);
                    break;
                  }
              }
            handle_result(result);
          }
        protected abstract void handle_result(TypeValue result);
        public FieldGeneratorValue(bool ignore_extras)
          {
                field0 = new SportsResultScoreCricketJSON.HoldingGenerator("option 0 of field \"Value\"", ignore_extras);
                field1 = new SportsGameSchedulesScoresAPIGameJSON.HoldingGenerator("option 1 of field \"Value\"", ignore_extras);
            all_handlers[0] = field0;
            all_handlers[1] = field1;
          }
        public FieldGeneratorValue(string what, bool ignore_extras)
          {
                field0 = new SportsResultScoreCricketJSON.HoldingGenerator("option 0 of field \"Value\"", ignore_extras);
                field1 = new SportsGameSchedulesScoresAPIGameJSON.HoldingGenerator("option 1 of field \"Value\"", ignore_extras);
            all_handlers[0] = field0;
            all_handlers[1] = field1;
          }

        public override void reset()
          {
            field0.reset();
            field1.reset();
            base.reset();
          }
      };
    public class HolderValue
      {
        private bool have_data;
        private TypeValue data;
        public HolderValue()  { have_data = false; }
        public HolderValue(TypeValue init_data)
          {
            have_data = true;
            data = init_data;
            if (have_data)
              {
              }
          }
        public HolderValue(HolderValue other)
          {
            have_data = other.haveData();
            data = other.referenced();
            if (have_data)
              {
              }
          }

        public bool haveData()
          {
            return have_data;
          }
        public TypeValue referenced()
          {
            return data;
          }
      };
    public class FieldHoldingGeneratorValue : FieldGeneratorValue
      {
        protected override void handle_result(TypeValue result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = new HolderValue(result);
          }

        public FieldHoldingGeneratorValue(String what, bool ignore_extras) : base(ignore_extras)
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
        public HolderValue value;
      };
    public class FieldHoldingArrayGeneratorValue : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorValue
      {
        private FieldHoldingArrayGeneratorValue top;

        protected override void handle_result(TypeValue result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorValue init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeValue> result)
      {
      }

    public FieldHoldingArrayGeneratorValue(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeValue>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorValue(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeValue>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeValue> value;
  };
    public abstract class Generator : FieldHoldingArrayGeneratorValue
      {
        protected void finish()
          {
            Debug.Assert(have_value);
            SportsGameSchedulesScoresAPIJSON result = new SportsGameSchedulesScoresAPIJSON();
            result.initValue();
            int count = value.Count;
            for (int num = 0; num < count; ++num)
              {
                result.appendValue(value[num]);
              }
            handle_result(result);
          }
        protected abstract void handle_result(SportsGameSchedulesScoresAPIJSON new_result);
        public Generator(bool ignore_extras) : base("Type SportsGameSchedulesScoresAPI", ignore_extras)
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
        protected override void handle_result(SportsGameSchedulesScoresAPIJSON  result)
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
        public SportsGameSchedulesScoresAPIJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsGameSchedulesScoresAPIJSON  result)
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
    protected virtual void handle_result(List<SportsGameSchedulesScoresAPIJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsGameSchedulesScoresAPIJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsGameSchedulesScoresAPIJSON>();
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
    public List<SportsGameSchedulesScoresAPIJSON> value;
  };
  };
