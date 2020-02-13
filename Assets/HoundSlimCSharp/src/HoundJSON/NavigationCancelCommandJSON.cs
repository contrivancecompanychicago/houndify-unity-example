/* file "NavigationCancelCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class NavigationCancelCommandJSON : NavigationCommandJSON
  {

    public NavigationCancelCommandJSON()
      {
      }

    public override string  getNavigationCommandKind()
      {
        return "NavigationCancelCommand";
      }


    public override int extraNavigationCommandComponentCount()
      {
        int result = 0;
        return result;
      }
    public override string extraNavigationCommandComponentKey(int component_num)
      {
        Debug.Assert(false);
        return null;
      }
    public override JSONValue extraNavigationCommandComponentValue(int component_num)
      {
        Debug.Assert(false);
        return null;
      }
    public override JSONValue extraNavigationCommandLookup(string field_name)
      {
        return null;
      }


    public override void extraNavigationCommandAppendPair(string key, JSONValue new_component)
      {
      }
    public override void extraNavigationCommandSetField(string key, JSONValue new_component)
      {
      }

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public override string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static new NavigationCancelCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        NavigationCancelCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NavigationCancelCommand", ignore_extras);
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
    public static new NavigationCancelCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new NavigationCancelCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        NavigationCancelCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NavigationCancelCommand", ignore_extras);
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
    public static new NavigationCancelCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new NavigationCancelCommandJSON from_text(string text, bool ignore_extras)
      {
        NavigationCancelCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NavigationCancelCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for NavigationCancelCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new NavigationCancelCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        NavigationCancelCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NavigationCancelCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : NavigationCommandJSON.Generator
      {

        protected override void start()
          {
          }
        protected override JSONHandler start_field(string field_name)
          {
            JSONHandler result = start_known_field(field_name);
            if (result != null)
                return result;
            string message = "";
            message = message + "Field \"" + field_name + "\" found for a type that doesn't allow extra fields.";
            throw new Exception(message);
          }
        protected override void finish_field(string field_name, JSONHandler field_handler)
          {
          }
        protected override void finish()
          {
            if (!(getNavigationCommandJSONKey().Equals("NavigationCancelCommand")))
                throw new Exception("The key field has a value other than `NavigationCancelCommand'.");
            NavigationCancelCommandJSON result = new NavigationCancelCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected override void handle_result(NavigationCommandJSON new_result)
          {
            handle_result((NavigationCancelCommandJSON )new_result);
          }
        protected void finish(NavigationCancelCommandJSON result)
          {
            base.finish(result);
          }
        protected abstract void handle_result(NavigationCancelCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            set_what("the NavigationCancelCommand class");
          }
        public Generator() : base(false)
          {
            set_what("the NavigationCancelCommand class");
          }

        public override void reset()
          {
            base.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(NavigationCancelCommandJSON  result)
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
        public NavigationCancelCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(NavigationCancelCommandJSON  result)
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
    protected virtual void handle_result(List<NavigationCancelCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<NavigationCancelCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<NavigationCancelCommandJSON>();
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
    public List<NavigationCancelCommandJSON> value;
  };
  };
