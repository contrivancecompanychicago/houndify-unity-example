/* file "SportsTournamentJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsTournamentJSON : JSONBase
  {
    public enum TypeTournamentNameKnownValues
      {
        TournamentName_NCAAMBTournament,
        TournamentName_NCAAMBCIT,
        TournamentName_NCAAMBCBI,
        TournamentName_NCAAMBNIT,
        TournamentName_SoccerInternationalMensWorldCup,
        TournamentName__none
      };
    public struct TypeTournamentName
      {
        public bool in_known_list;
        public string string_value;
        public TypeTournamentNameKnownValues list_value;
      };

    public static TypeTournamentNameKnownValues  stringToTournamentName(string chars)
      {
        switch (chars[0])
          {
            case 'N':
                if (String.Compare(chars, 1, "CAAMB", 0, 5, false) == 0)
                  {
                    switch (chars[6])
                      {
                        case 'C':
                            switch (chars[7])
                              {
                                case 'B':
                                    if ((String.Compare(chars, 8, "I", 0, 1, false) == 0) && (chars.Length == 9))
                                        return TypeTournamentNameKnownValues.TournamentName_NCAAMBCBI;
                                    break;
                                case 'I':
                                    if ((String.Compare(chars, 8, "T", 0, 1, false) == 0) && (chars.Length == 9))
                                        return TypeTournamentNameKnownValues.TournamentName_NCAAMBCIT;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'N':
                            if ((String.Compare(chars, 7, "IT", 0, 2, false) == 0) && (chars.Length == 9))
                                return TypeTournamentNameKnownValues.TournamentName_NCAAMBNIT;
                            break;
                        case 'T':
                            if ((String.Compare(chars, 7, "ournament", 0, 9, false) == 0) && (chars.Length == 16))
                                return TypeTournamentNameKnownValues.TournamentName_NCAAMBTournament;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if ((String.Compare(chars, 1, "occerInternationalMensWorldCup", 0, 30, false) == 0) && (chars.Length == 31))
                    return TypeTournamentNameKnownValues.TournamentName_SoccerInternationalMensWorldCup;
                break;
            default:
                break;
          }
        return TypeTournamentNameKnownValues.TournamentName__none;
      }

    public static string  stringFromTournamentName(TypeTournamentNameKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeTournamentNameKnownValues.TournamentName_NCAAMBTournament:
                return "NCAAMBTournament";
            case TypeTournamentNameKnownValues.TournamentName_NCAAMBCIT:
                return "NCAAMBCIT";
            case TypeTournamentNameKnownValues.TournamentName_NCAAMBCBI:
                return "NCAAMBCBI";
            case TypeTournamentNameKnownValues.TournamentName_NCAAMBNIT:
                return "NCAAMBNIT";
            case TypeTournamentNameKnownValues.TournamentName_SoccerInternationalMensWorldCup:
                return "SoccerInternationalMensWorldCup";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasTournamentName;
    private TypeTournamentName storeTournamentName;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONTournamentName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TournamentName of SportsTournamentJSON is not a string.");
        TypeTournamentName the_open_enum = new TypeTournamentName();
        switch (json_string.getData()[0])
          {
            case 'N':
                if (String.Compare(json_string.getData(), 1, "CAAMB", 0, 5, false) == 0)
                  {
                    switch (json_string.getData()[6])
                      {
                        case 'C':
                            switch (json_string.getData()[7])
                              {
                                case 'B':
                                    if ((String.Compare(json_string.getData(), 8, "I", 0, 1, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeTournamentNameKnownValues.TournamentName_NCAAMBCBI;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'I':
                                    if ((String.Compare(json_string.getData(), 8, "T", 0, 1, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeTournamentNameKnownValues.TournamentName_NCAAMBCIT;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'N':
                            if ((String.Compare(json_string.getData(), 7, "IT", 0, 2, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeTournamentNameKnownValues.TournamentName_NCAAMBNIT;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'T':
                            if ((String.Compare(json_string.getData(), 7, "ournament", 0, 9, false) == 0) && (json_string.getData().Length == 16))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeTournamentNameKnownValues.TournamentName_NCAAMBTournament;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "occerInternationalMensWorldCup", 0, 30, false) == 0) && (json_string.getData().Length == 31))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTournamentNameKnownValues.TournamentName_SoccerInternationalMensWorldCup;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setTournamentName(the_open_enum);
      }


    public SportsTournamentJSON()
      {
        flagHasTournamentName = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasTournamentName()
      {
        return flagHasTournamentName;
      }

    public TypeTournamentName  getTournamentName()
      {
        Debug.Assert(flagHasTournamentName);
        return storeTournamentName;
      }

    public string  getTournamentNameAsString()
      {
        TypeTournamentName result = getTournamentName();
        if (result.in_known_list)
            return stringFromTournamentName(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraSportsTournamentComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsTournamentComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsTournamentComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsTournamentLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setTournamentName(TypeTournamentName new_value)
      {
        flagHasTournamentName = true;
        storeTournamentName = new_value;
      }
    public void setTournamentName(string chars)
      {
        TypeTournamentNameKnownValues known = stringToTournamentName(chars);
        TypeTournamentName new_value = new TypeTournamentName();
        if (known == TypeTournamentNameKnownValues.TournamentName__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setTournamentName(new_value);
      }
    public void setTournamentName(TypeTournamentNameKnownValues new_value)
      {
        TypeTournamentName new_full_value = new TypeTournamentName();
        Debug.Assert(new_value != TypeTournamentNameKnownValues.TournamentName__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setTournamentName(new_full_value);
      }
    public void unsetTournamentName()
      {
        flagHasTournamentName = false;
      }

    public virtual void extraSportsTournamentAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsTournamentSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsTournamentLookup(key);
        if (old_field == null)
          {
            extraSportsTournamentAppendPair(key, new_component);
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
        if (flagHasTournamentName)
          {
            handler.start_pair("TournamentName");
            if (storeTournamentName.in_known_list)
              {
                switch (storeTournamentName.list_value)
                  {
                    case TypeTournamentNameKnownValues.TournamentName_NCAAMBTournament:
                        handler.string_value("NCAAMBTournament");
                        break;
                    case TypeTournamentNameKnownValues.TournamentName_NCAAMBCIT:
                        handler.string_value("NCAAMBCIT");
                        break;
                    case TypeTournamentNameKnownValues.TournamentName_NCAAMBCBI:
                        handler.string_value("NCAAMBCBI");
                        break;
                    case TypeTournamentNameKnownValues.TournamentName_NCAAMBNIT:
                        handler.string_value("NCAAMBNIT");
                        break;
                    case TypeTournamentNameKnownValues.TournamentName_SoccerInternationalMensWorldCup:
                        handler.string_value("SoccerInternationalMensWorldCup");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeTournamentName.string_value);
              }
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

    public static SportsTournamentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsTournamentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsTournament", ignore_extras);
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
    public static SportsTournamentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsTournamentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsTournamentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsTournament", ignore_extras);
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
    public static SportsTournamentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsTournamentJSON from_text(string text, bool ignore_extras)
      {
        SportsTournamentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsTournament", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsTournamentJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsTournamentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsTournamentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsTournament", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorTournamentName : JSONStringGenerator
          {
            protected FieldGeneratorTournamentName(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorTournamentName()
              {
              }
            protected override void handle_result(string result)
              {
                TypeTournamentNameKnownValues known = stringToTournamentName(result);
                TypeTournamentName new_value = new TypeTournamentName();
                if (known == TypeTournamentNameKnownValues.TournamentName__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = result;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                handle_result(new_value);
              }
            protected abstract void handle_result(TypeTournamentName result);
          };
    private class FieldHoldingGeneratorTournamentName : FieldGeneratorTournamentName
  {
    protected override void handle_result(TypeTournamentName result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorTournamentName(String what)
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
    public TypeTournamentName value;
  };
    private class FieldHoldingArrayGeneratorTournamentName : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorTournamentName
      {
        private FieldHoldingArrayGeneratorTournamentName top;

        protected override void handle_result(TypeTournamentName result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorTournamentName init_top)
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
    protected virtual void handle_result(List<TypeTournamentName> result)
      {
      }

    public FieldHoldingArrayGeneratorTournamentName(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeTournamentName>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorTournamentName()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeTournamentName>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeTournamentName> value;
  };
        private FieldHoldingGeneratorTournamentName fieldGeneratorTournamentName;
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
            SportsTournamentJSON result = new SportsTournamentJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsTournamentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsTournamentJSON result)
          {
            if (fieldGeneratorTournamentName.have_value)
              {
                result.setTournamentName(fieldGeneratorTournamentName.value);
                fieldGeneratorTournamentName.have_value = false;
              }
          }
        protected abstract void handle_result(SportsTournamentJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "TournamentName", 0, 14, false) == 0) && (field_name.Length == 14))
                return fieldGeneratorTournamentName;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorTournamentName = new FieldHoldingGeneratorTournamentName("field \"TournamentName\" of the SportsTournament class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsTournament class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorTournamentName = new FieldHoldingGeneratorTournamentName("field \"TournamentName\" of the SportsTournament class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsTournament class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorTournamentName.reset();
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
        protected override void handle_result(SportsTournamentJSON  result)
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
        public SportsTournamentJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsTournamentJSON  result)
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
    protected virtual void handle_result(List<SportsTournamentJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsTournamentJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsTournamentJSON>();
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
    public List<SportsTournamentJSON> value;
  };
  };
