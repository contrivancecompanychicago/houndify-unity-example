/* file "BuildInfoJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class BuildInfoJSON : JSONBase
  {
    private bool flagHasUser;
    private string storeUser;
    private bool flagHasDate;
    private string storeDate;
    private bool flagHasMachine;
    private string storeMachine;
    private bool flagHasSVNRevision;
    private string storeSVNRevision;
    private bool flagHasSVNBranch;
    private string storeSVNBranch;
    private bool flagHasBuildNumber;
    private string storeBuildNumber;
    private bool flagHasKind;
    private string storeKind;
    private bool flagHasVariant;
    private string storeVariant;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONUser(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field User of BuildInfoJSON is not a string.");
        setUser(json_string.getData());
      }


    private void  fromJSONDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Date of BuildInfoJSON is not a string.");
        setDate(json_string.getData());
      }


    private void  fromJSONMachine(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Machine of BuildInfoJSON is not a string.");
        setMachine(json_string.getData());
      }


    private void  fromJSONSVNRevision(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SVNRevision of BuildInfoJSON is not a string.");
        setSVNRevision(json_string.getData());
      }


    private void  fromJSONSVNBranch(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SVNBranch of BuildInfoJSON is not a string.");
        setSVNBranch(json_string.getData());
      }


    private void  fromJSONBuildNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field BuildNumber of BuildInfoJSON is not a string.");
        setBuildNumber(json_string.getData());
      }


    private void  fromJSONKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Kind of BuildInfoJSON is not a string.");
        setKind(json_string.getData());
      }


    private void  fromJSONVariant(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Variant of BuildInfoJSON is not a string.");
        setVariant(json_string.getData());
      }


    public BuildInfoJSON()
      {
        flagHasUser = false;
        flagHasDate = false;
        flagHasMachine = false;
        flagHasSVNRevision = false;
        flagHasSVNBranch = false;
        flagHasBuildNumber = false;
        flagHasKind = false;
        flagHasVariant = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasUser()
      {
        return flagHasUser;
      }

    public string  getUser()
      {
        Debug.Assert(flagHasUser);
        return storeUser;
      }

    public bool  hasDate()
      {
        return flagHasDate;
      }

    public string  getDate()
      {
        Debug.Assert(flagHasDate);
        return storeDate;
      }

    public bool  hasMachine()
      {
        return flagHasMachine;
      }

    public string  getMachine()
      {
        Debug.Assert(flagHasMachine);
        return storeMachine;
      }

    public bool  hasSVNRevision()
      {
        return flagHasSVNRevision;
      }

    public string  getSVNRevision()
      {
        Debug.Assert(flagHasSVNRevision);
        return storeSVNRevision;
      }

    public bool  hasSVNBranch()
      {
        return flagHasSVNBranch;
      }

    public string  getSVNBranch()
      {
        Debug.Assert(flagHasSVNBranch);
        return storeSVNBranch;
      }

    public bool  hasBuildNumber()
      {
        return flagHasBuildNumber;
      }

    public string  getBuildNumber()
      {
        Debug.Assert(flagHasBuildNumber);
        return storeBuildNumber;
      }

    public bool  hasKind()
      {
        return flagHasKind;
      }

    public string  getKind()
      {
        Debug.Assert(flagHasKind);
        return storeKind;
      }

    public bool  hasVariant()
      {
        return flagHasVariant;
      }

    public string  getVariant()
      {
        Debug.Assert(flagHasVariant);
        return storeVariant;
      }


    public virtual int extraBuildInfoComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraBuildInfoComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraBuildInfoComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraBuildInfoLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setUser(string new_value)
      {
        flagHasUser = true;
        storeUser = new_value;
      }
    public void unsetUser()
      {
        flagHasUser = false;
      }
    public void setDate(string new_value)
      {
        flagHasDate = true;
        storeDate = new_value;
      }
    public void unsetDate()
      {
        flagHasDate = false;
      }
    public void setMachine(string new_value)
      {
        flagHasMachine = true;
        storeMachine = new_value;
      }
    public void unsetMachine()
      {
        flagHasMachine = false;
      }
    public void setSVNRevision(string new_value)
      {
        flagHasSVNRevision = true;
        storeSVNRevision = new_value;
      }
    public void unsetSVNRevision()
      {
        flagHasSVNRevision = false;
      }
    public void setSVNBranch(string new_value)
      {
        flagHasSVNBranch = true;
        storeSVNBranch = new_value;
      }
    public void unsetSVNBranch()
      {
        flagHasSVNBranch = false;
      }
    public void setBuildNumber(string new_value)
      {
        flagHasBuildNumber = true;
        storeBuildNumber = new_value;
      }
    public void unsetBuildNumber()
      {
        flagHasBuildNumber = false;
      }
    public void setKind(string new_value)
      {
        flagHasKind = true;
        storeKind = new_value;
      }
    public void unsetKind()
      {
        flagHasKind = false;
      }
    public void setVariant(string new_value)
      {
        flagHasVariant = true;
        storeVariant = new_value;
      }
    public void unsetVariant()
      {
        flagHasVariant = false;
      }

    public virtual void extraBuildInfoAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraBuildInfoSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraBuildInfoLookup(key);
        if (old_field == null)
          {
            extraBuildInfoAppendPair(key, new_component);
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
        if (flagHasUser)
          {
            handler.start_pair("User");
            handler.string_value(storeUser);
          }
        if (flagHasDate)
          {
            handler.start_pair("Date");
            handler.string_value(storeDate);
          }
        if (flagHasMachine)
          {
            handler.start_pair("Machine");
            handler.string_value(storeMachine);
          }
        if (flagHasSVNRevision)
          {
            handler.start_pair("SVNRevision");
            handler.string_value(storeSVNRevision);
          }
        if (flagHasSVNBranch)
          {
            handler.start_pair("SVNBranch");
            handler.string_value(storeSVNBranch);
          }
        if (flagHasBuildNumber)
          {
            handler.start_pair("BuildNumber");
            handler.string_value(storeBuildNumber);
          }
        if (flagHasKind)
          {
            handler.start_pair("Kind");
            handler.string_value(storeKind);
          }
        if (flagHasVariant)
          {
            handler.start_pair("Variant");
            handler.string_value(storeVariant);
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

    public static BuildInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BuildInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BuildInfo", ignore_extras);
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
    public static BuildInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BuildInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BuildInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BuildInfo", ignore_extras);
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
    public static BuildInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BuildInfoJSON from_text(string text, bool ignore_extras)
      {
        BuildInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BuildInfo", ignore_extras);
            JSONParse.parse_json_value(text, "Text for BuildInfoJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static BuildInfoJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        BuildInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BuildInfo", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorUser;
        private JSONHoldingStringGenerator fieldGeneratorDate;
        private JSONHoldingStringGenerator fieldGeneratorMachine;
        private JSONHoldingStringGenerator fieldGeneratorSVNRevision;
        private JSONHoldingStringGenerator fieldGeneratorSVNBranch;
        private JSONHoldingStringGenerator fieldGeneratorBuildNumber;
        private JSONHoldingStringGenerator fieldGeneratorKind;
        private JSONHoldingStringGenerator fieldGeneratorVariant;
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
            BuildInfoJSON result = new BuildInfoJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraBuildInfoAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(BuildInfoJSON result)
          {
            if (fieldGeneratorUser.have_value)
              {
                result.setUser(fieldGeneratorUser.value);
                fieldGeneratorUser.have_value = false;
              }
            if (fieldGeneratorDate.have_value)
              {
                result.setDate(fieldGeneratorDate.value);
                fieldGeneratorDate.have_value = false;
              }
            if (fieldGeneratorMachine.have_value)
              {
                result.setMachine(fieldGeneratorMachine.value);
                fieldGeneratorMachine.have_value = false;
              }
            if (fieldGeneratorSVNRevision.have_value)
              {
                result.setSVNRevision(fieldGeneratorSVNRevision.value);
                fieldGeneratorSVNRevision.have_value = false;
              }
            if (fieldGeneratorSVNBranch.have_value)
              {
                result.setSVNBranch(fieldGeneratorSVNBranch.value);
                fieldGeneratorSVNBranch.have_value = false;
              }
            if (fieldGeneratorBuildNumber.have_value)
              {
                result.setBuildNumber(fieldGeneratorBuildNumber.value);
                fieldGeneratorBuildNumber.have_value = false;
              }
            if (fieldGeneratorKind.have_value)
              {
                result.setKind(fieldGeneratorKind.value);
                fieldGeneratorKind.have_value = false;
              }
            if (fieldGeneratorVariant.have_value)
              {
                result.setVariant(fieldGeneratorVariant.value);
                fieldGeneratorVariant.have_value = false;
              }
          }
        protected abstract void handle_result(BuildInfoJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    if ((String.Compare(field_name, 1, "uildNumber", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorBuildNumber;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "ate", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorDate;
                    break;
                case 'K':
                    if ((String.Compare(field_name, 1, "ind", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorKind;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "achine", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorMachine;
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "VN", 0, 2, false) == 0)
                      {
                        switch (field_name[3])
                          {
                            case 'B':
                                if ((String.Compare(field_name, 4, "ranch", 0, 5, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorSVNBranch;
                                break;
                            case 'R':
                                if ((String.Compare(field_name, 4, "evision", 0, 7, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorSVNRevision;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "ser", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorUser;
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "ariant", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorVariant;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorUser = new JSONHoldingStringGenerator("field \"User\" of the BuildInfo class");
            fieldGeneratorDate = new JSONHoldingStringGenerator("field \"Date\" of the BuildInfo class");
            fieldGeneratorMachine = new JSONHoldingStringGenerator("field \"Machine\" of the BuildInfo class");
            fieldGeneratorSVNRevision = new JSONHoldingStringGenerator("field \"SVNRevision\" of the BuildInfo class");
            fieldGeneratorSVNBranch = new JSONHoldingStringGenerator("field \"SVNBranch\" of the BuildInfo class");
            fieldGeneratorBuildNumber = new JSONHoldingStringGenerator("field \"BuildNumber\" of the BuildInfo class");
            fieldGeneratorKind = new JSONHoldingStringGenerator("field \"Kind\" of the BuildInfo class");
            fieldGeneratorVariant = new JSONHoldingStringGenerator("field \"Variant\" of the BuildInfo class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the BuildInfo class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorUser = new JSONHoldingStringGenerator("field \"User\" of the BuildInfo class");
            fieldGeneratorDate = new JSONHoldingStringGenerator("field \"Date\" of the BuildInfo class");
            fieldGeneratorMachine = new JSONHoldingStringGenerator("field \"Machine\" of the BuildInfo class");
            fieldGeneratorSVNRevision = new JSONHoldingStringGenerator("field \"SVNRevision\" of the BuildInfo class");
            fieldGeneratorSVNBranch = new JSONHoldingStringGenerator("field \"SVNBranch\" of the BuildInfo class");
            fieldGeneratorBuildNumber = new JSONHoldingStringGenerator("field \"BuildNumber\" of the BuildInfo class");
            fieldGeneratorKind = new JSONHoldingStringGenerator("field \"Kind\" of the BuildInfo class");
            fieldGeneratorVariant = new JSONHoldingStringGenerator("field \"Variant\" of the BuildInfo class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the BuildInfo class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorUser.reset();
            fieldGeneratorDate.reset();
            fieldGeneratorMachine.reset();
            fieldGeneratorSVNRevision.reset();
            fieldGeneratorSVNBranch.reset();
            fieldGeneratorBuildNumber.reset();
            fieldGeneratorKind.reset();
            fieldGeneratorVariant.reset();
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
        protected override void handle_result(BuildInfoJSON  result)
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
        public BuildInfoJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(BuildInfoJSON  result)
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
    protected virtual void handle_result(List<BuildInfoJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<BuildInfoJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<BuildInfoJSON>();
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
    public List<BuildInfoJSON> value;
  };
  };
