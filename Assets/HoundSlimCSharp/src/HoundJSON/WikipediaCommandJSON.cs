/* file "WikipediaCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class WikipediaCommandJSON : CommandResultJSON
  {
    public class TypeNativeDataJSON : JSONBase
      {
        private bool flagHasTitle;
        private string storeTitle;
        private bool flagHasRequestedTitle;
        private string storeRequestedTitle;
        private bool flagHasShouldIndicateRedirect;
        private bool storeShouldIndicateRedirect;
        private bool flagHasWrittenSummaryShort;
        private string storeWrittenSummaryShort;
        private bool flagHasWrittenSummaryLong;
        private string storeWrittenSummaryLong;
        private bool flagHasImage;
        private string storeImage;
        private bool flagHasURI;
        private string storeURI;
        private bool flagHasSpokenSummaryShort;
        private string storeSpokenSummaryShort;
        private bool flagHasSpokenSummaryLong;
        private string storeSpokenSummaryLong;
        private bool flagHasOriginalID;
        private BigInteger storeOriginalID;
        private bool flagHasResolvedID;
        private BigInteger storeResolvedID;
        private bool flagHasWebCommandEnabled;
        private bool storeWebCommandEnabled;
        private bool flagHasWikipediaAttribution;
        private string storeWikipediaAttribution;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONTitle(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Title of TypeNativeDataJSON is not a string.");
            setTitle(json_string.getData());
          }


        private void  fromJSONRequestedTitle(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field RequestedTitle of TypeNativeDataJSON is not a string.");
            setRequestedTitle(json_string.getData());
          }


        private void  fromJSONShouldIndicateRedirect(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field ShouldIndicateRedirect of TypeNativeDataJSON is not true for false.");
                  }
              }
            setShouldIndicateRedirect(the_bool);
          }


        private void  fromJSONWrittenSummaryShort(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field WrittenSummaryShort of TypeNativeDataJSON is not a string.");
            setWrittenSummaryShort(json_string.getData());
          }


        private void  fromJSONWrittenSummaryLong(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field WrittenSummaryLong of TypeNativeDataJSON is not a string.");
            setWrittenSummaryLong(json_string.getData());
          }


        private void  fromJSONImage(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Image of TypeNativeDataJSON is not a string.");
            setImage(json_string.getData());
          }


        private void  fromJSONURI(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field URI of TypeNativeDataJSON is not a string.");
            setURI(json_string.getData());
          }


        private void  fromJSONSpokenSummaryShort(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field SpokenSummaryShort of TypeNativeDataJSON is not a string.");
            setSpokenSummaryShort(json_string.getData());
          }


        private void  fromJSONSpokenSummaryLong(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field SpokenSummaryLong of TypeNativeDataJSON is not a string.");
            setSpokenSummaryLong(json_string.getData());
          }


        private void  fromJSONOriginalID(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field OriginalID of TypeNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field OriginalID of TypeNativeDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setOriginalID(extracted_integer);
          }


        private void  fromJSONResolvedID(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field ResolvedID of TypeNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field ResolvedID of TypeNativeDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setResolvedID(extracted_integer);
          }


        private void  fromJSONWebCommandEnabled(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field WebCommandEnabled of TypeNativeDataJSON is not true for false.");
                  }
              }
            setWebCommandEnabled(the_bool);
          }


        private void  fromJSONWikipediaAttribution(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field WikipediaAttribution of TypeNativeDataJSON is not a string.");
            setWikipediaAttribution(json_string.getData());
          }


        public TypeNativeDataJSON()
          {
            flagHasTitle = false;
            flagHasRequestedTitle = false;
            flagHasShouldIndicateRedirect = false;
            flagHasWrittenSummaryShort = false;
            flagHasWrittenSummaryLong = false;
            flagHasImage = false;
            flagHasURI = false;
            flagHasSpokenSummaryShort = false;
            flagHasSpokenSummaryLong = false;
            flagHasOriginalID = false;
            flagHasResolvedID = false;
            flagHasWebCommandEnabled = false;
            flagHasWikipediaAttribution = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasTitle()
          {
            return flagHasTitle;
          }

        public string  getTitle()
          {
            Debug.Assert(flagHasTitle);
            return storeTitle;
          }

        public bool  hasRequestedTitle()
          {
            return flagHasRequestedTitle;
          }

        public string  getRequestedTitle()
          {
            Debug.Assert(flagHasRequestedTitle);
            return storeRequestedTitle;
          }

        public bool  hasShouldIndicateRedirect()
          {
            return flagHasShouldIndicateRedirect;
          }

        public bool  getShouldIndicateRedirect()
          {
            Debug.Assert(flagHasShouldIndicateRedirect);
            return storeShouldIndicateRedirect;
          }

        public bool  hasWrittenSummaryShort()
          {
            return flagHasWrittenSummaryShort;
          }

        public string  getWrittenSummaryShort()
          {
            Debug.Assert(flagHasWrittenSummaryShort);
            return storeWrittenSummaryShort;
          }

        public bool  hasWrittenSummaryLong()
          {
            return flagHasWrittenSummaryLong;
          }

        public string  getWrittenSummaryLong()
          {
            Debug.Assert(flagHasWrittenSummaryLong);
            return storeWrittenSummaryLong;
          }

        public bool  hasImage()
          {
            return flagHasImage;
          }

        public string  getImage()
          {
            Debug.Assert(flagHasImage);
            return storeImage;
          }

        public bool  hasURI()
          {
            return flagHasURI;
          }

        public string  getURI()
          {
            Debug.Assert(flagHasURI);
            return storeURI;
          }

        public bool  hasSpokenSummaryShort()
          {
            return flagHasSpokenSummaryShort;
          }

        public string  getSpokenSummaryShort()
          {
            Debug.Assert(flagHasSpokenSummaryShort);
            return storeSpokenSummaryShort;
          }

        public bool  hasSpokenSummaryLong()
          {
            return flagHasSpokenSummaryLong;
          }

        public string  getSpokenSummaryLong()
          {
            Debug.Assert(flagHasSpokenSummaryLong);
            return storeSpokenSummaryLong;
          }

        public bool  hasOriginalID()
          {
            return flagHasOriginalID;
          }

        public BigInteger  getOriginalID()
          {
            Debug.Assert(flagHasOriginalID);
            return storeOriginalID;
          }

        public bool  hasResolvedID()
          {
            return flagHasResolvedID;
          }

        public BigInteger  getResolvedID()
          {
            Debug.Assert(flagHasResolvedID);
            return storeResolvedID;
          }

        public bool  hasWebCommandEnabled()
          {
            return flagHasWebCommandEnabled;
          }

        public bool  getWebCommandEnabled()
          {
            Debug.Assert(flagHasWebCommandEnabled);
            return storeWebCommandEnabled;
          }

        public bool  hasWikipediaAttribution()
          {
            return flagHasWikipediaAttribution;
          }

        public string  getWikipediaAttribution()
          {
            Debug.Assert(flagHasWikipediaAttribution);
            return storeWikipediaAttribution;
          }


        public virtual int extraTypeNativeDataComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeNativeDataComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeNativeDataComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeNativeDataLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setTitle(string new_value)
          {
            flagHasTitle = true;
            storeTitle = new_value;
          }
        public void unsetTitle()
          {
            flagHasTitle = false;
          }
        public void setRequestedTitle(string new_value)
          {
            flagHasRequestedTitle = true;
            storeRequestedTitle = new_value;
          }
        public void unsetRequestedTitle()
          {
            flagHasRequestedTitle = false;
          }
        public void setShouldIndicateRedirect(bool new_value)
          {
            flagHasShouldIndicateRedirect = true;
            storeShouldIndicateRedirect = new_value;
          }
        public void unsetShouldIndicateRedirect()
          {
            flagHasShouldIndicateRedirect = false;
          }
        public void setWrittenSummaryShort(string new_value)
          {
            flagHasWrittenSummaryShort = true;
            storeWrittenSummaryShort = new_value;
          }
        public void unsetWrittenSummaryShort()
          {
            flagHasWrittenSummaryShort = false;
          }
        public void setWrittenSummaryLong(string new_value)
          {
            flagHasWrittenSummaryLong = true;
            storeWrittenSummaryLong = new_value;
          }
        public void unsetWrittenSummaryLong()
          {
            flagHasWrittenSummaryLong = false;
          }
        public void setImage(string new_value)
          {
            flagHasImage = true;
            storeImage = new_value;
          }
        public void unsetImage()
          {
            flagHasImage = false;
          }
        public void setURI(string new_value)
          {
            flagHasURI = true;
            storeURI = new_value;
          }
        public void unsetURI()
          {
            flagHasURI = false;
          }
        public void setSpokenSummaryShort(string new_value)
          {
            flagHasSpokenSummaryShort = true;
            storeSpokenSummaryShort = new_value;
          }
        public void unsetSpokenSummaryShort()
          {
            flagHasSpokenSummaryShort = false;
          }
        public void setSpokenSummaryLong(string new_value)
          {
            flagHasSpokenSummaryLong = true;
            storeSpokenSummaryLong = new_value;
          }
        public void unsetSpokenSummaryLong()
          {
            flagHasSpokenSummaryLong = false;
          }
        public void setOriginalID(BigInteger new_value)
          {
            flagHasOriginalID = true;
            storeOriginalID = new_value;
          }
        public void unsetOriginalID()
          {
            flagHasOriginalID = false;
          }
        public void setResolvedID(BigInteger new_value)
          {
            flagHasResolvedID = true;
            storeResolvedID = new_value;
          }
        public void unsetResolvedID()
          {
            flagHasResolvedID = false;
          }
        public void setWebCommandEnabled(bool new_value)
          {
            flagHasWebCommandEnabled = true;
            storeWebCommandEnabled = new_value;
          }
        public void unsetWebCommandEnabled()
          {
            flagHasWebCommandEnabled = false;
          }
        public void setWikipediaAttribution(string new_value)
          {
            flagHasWikipediaAttribution = true;
            storeWikipediaAttribution = new_value;
          }
        public void unsetWikipediaAttribution()
          {
            flagHasWikipediaAttribution = false;
          }

        public virtual void extraTypeNativeDataAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeNativeDataSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeNativeDataLookup(key);
            if (old_field == null)
              {
                extraTypeNativeDataAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasTitle);
            if (flagHasTitle)
              {
                handler.start_pair("Title");
                handler.string_value(storeTitle);
              }
            if (flagHasRequestedTitle)
              {
                handler.start_pair("RequestedTitle");
                handler.string_value(storeRequestedTitle);
              }
            if (flagHasShouldIndicateRedirect)
              {
                handler.start_pair("ShouldIndicateRedirect");
                handler.boolean_value(storeShouldIndicateRedirect);
              }
            Debug.Assert(partial_allowed || flagHasWrittenSummaryShort);
            if (flagHasWrittenSummaryShort)
              {
                handler.start_pair("WrittenSummaryShort");
                handler.string_value(storeWrittenSummaryShort);
              }
            Debug.Assert(partial_allowed || flagHasWrittenSummaryLong);
            if (flagHasWrittenSummaryLong)
              {
                handler.start_pair("WrittenSummaryLong");
                handler.string_value(storeWrittenSummaryLong);
              }
            Debug.Assert(partial_allowed || flagHasImage);
            if (flagHasImage)
              {
                handler.start_pair("Image");
                handler.string_value(storeImage);
              }
            Debug.Assert(partial_allowed || flagHasURI);
            if (flagHasURI)
              {
                handler.start_pair("URI");
                handler.string_value(storeURI);
              }
            Debug.Assert(partial_allowed || flagHasSpokenSummaryShort);
            if (flagHasSpokenSummaryShort)
              {
                handler.start_pair("SpokenSummaryShort");
                handler.string_value(storeSpokenSummaryShort);
              }
            Debug.Assert(partial_allowed || flagHasSpokenSummaryLong);
            if (flagHasSpokenSummaryLong)
              {
                handler.start_pair("SpokenSummaryLong");
                handler.string_value(storeSpokenSummaryLong);
              }
            Debug.Assert(partial_allowed || flagHasOriginalID);
            if (flagHasOriginalID)
              {
                handler.start_pair("OriginalID");
                handler.number_value(storeOriginalID);
              }
            Debug.Assert(partial_allowed || flagHasResolvedID);
            if (flagHasResolvedID)
              {
                handler.start_pair("ResolvedID");
                handler.number_value(storeResolvedID);
              }
            if (flagHasWebCommandEnabled)
              {
                handler.start_pair("WebCommandEnabled");
                handler.boolean_value(storeWebCommandEnabled);
              }
            if (flagHasWikipediaAttribution)
              {
                handler.start_pair("WikipediaAttribution");
                handler.string_value(storeWikipediaAttribution);
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
            if (!(hasTitle()))
              {
                return "When parsing the object for %what%, the \"Title\" field was missing.";
              }
            if (!(hasWrittenSummaryShort()))
              {
                return "When parsing the object for %what%, the \"WrittenSummaryShort\" field was missing.";
              }
            if (!(hasWrittenSummaryLong()))
              {
                return "When parsing the object for %what%, the \"WrittenSummaryLong\" field was missing.";
              }
            if (!(hasImage()))
              {
                return "When parsing the object for %what%, the \"Image\" field was missing.";
              }
            if (!(hasURI()))
              {
                return "When parsing the object for %what%, the \"URI\" field was missing.";
              }
            if (!(hasSpokenSummaryShort()))
              {
                return "When parsing the object for %what%, the \"SpokenSummaryShort\" field was missing.";
              }
            if (!(hasSpokenSummaryLong()))
              {
                return "When parsing the object for %what%, the \"SpokenSummaryLong\" field was missing.";
              }
            if (!(hasOriginalID()))
              {
                return "When parsing the object for %what%, the \"OriginalID\" field was missing.";
              }
            if (!(hasResolvedID()))
              {
                return "When parsing the object for %what%, the \"ResolvedID\" field was missing.";
              }
            return null;
          }

        public static TypeNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
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
        public static TypeNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
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
        public static TypeNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNativeDataJSON from_text(string text, bool ignore_extras)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeNativeDataJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeNativeDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorTitle;
            private JSONHoldingStringGenerator fieldGeneratorRequestedTitle;
            private JSONHoldingBooleanGenerator fieldGeneratorShouldIndicateRedirect;
            private JSONHoldingStringGenerator fieldGeneratorWrittenSummaryShort;
            private JSONHoldingStringGenerator fieldGeneratorWrittenSummaryLong;
            private JSONHoldingStringGenerator fieldGeneratorImage;
            private JSONHoldingStringGenerator fieldGeneratorURI;
            private JSONHoldingStringGenerator fieldGeneratorSpokenSummaryShort;
            private JSONHoldingStringGenerator fieldGeneratorSpokenSummaryLong;
        private class FieldHoldingGeneratorOriginalID : JSONHoldingIntegerUnboundRangeGenerator
              {
                public FieldHoldingGeneratorOriginalID(String what) : base(what)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorOriginalID : JSONHoldingIntegerUnboundRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorOriginalID(String what) : base(what)
                  {
                  }
              };
            private FieldHoldingGeneratorOriginalID fieldGeneratorOriginalID;
        private class FieldHoldingGeneratorResolvedID : JSONHoldingIntegerUnboundRangeGenerator
              {
                public FieldHoldingGeneratorResolvedID(String what) : base(what)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorResolvedID : JSONHoldingIntegerUnboundRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorResolvedID(String what) : base(what)
                  {
                  }
              };
            private FieldHoldingGeneratorResolvedID fieldGeneratorResolvedID;
            private JSONHoldingBooleanGenerator fieldGeneratorWebCommandEnabled;
            private JSONHoldingStringGenerator fieldGeneratorWikipediaAttribution;
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
                TypeNativeDataJSON result = new TypeNativeDataJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeNativeDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeNativeDataJSON result)
              {
                if (fieldGeneratorTitle.have_value)
                  {
                    result.setTitle(fieldGeneratorTitle.value);
                    fieldGeneratorTitle.have_value = false;
                  }
                else if ((!(result.hasTitle())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Title\" field was missing.");
                  }
                if (fieldGeneratorRequestedTitle.have_value)
                  {
                    result.setRequestedTitle(fieldGeneratorRequestedTitle.value);
                    fieldGeneratorRequestedTitle.have_value = false;
                  }
                if (fieldGeneratorShouldIndicateRedirect.have_value)
                  {
                    result.setShouldIndicateRedirect(fieldGeneratorShouldIndicateRedirect.value);
                    fieldGeneratorShouldIndicateRedirect.have_value = false;
                  }
                if (fieldGeneratorWrittenSummaryShort.have_value)
                  {
                    result.setWrittenSummaryShort(fieldGeneratorWrittenSummaryShort.value);
                    fieldGeneratorWrittenSummaryShort.have_value = false;
                  }
                else if ((!(result.hasWrittenSummaryShort())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"WrittenSummaryShort\" field was missing.");
                  }
                if (fieldGeneratorWrittenSummaryLong.have_value)
                  {
                    result.setWrittenSummaryLong(fieldGeneratorWrittenSummaryLong.value);
                    fieldGeneratorWrittenSummaryLong.have_value = false;
                  }
                else if ((!(result.hasWrittenSummaryLong())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"WrittenSummaryLong\" field was missing.");
                  }
                if (fieldGeneratorImage.have_value)
                  {
                    result.setImage(fieldGeneratorImage.value);
                    fieldGeneratorImage.have_value = false;
                  }
                else if ((!(result.hasImage())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Image\" field was missing.");
                  }
                if (fieldGeneratorURI.have_value)
                  {
                    result.setURI(fieldGeneratorURI.value);
                    fieldGeneratorURI.have_value = false;
                  }
                else if ((!(result.hasURI())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"URI\" field was missing.");
                  }
                if (fieldGeneratorSpokenSummaryShort.have_value)
                  {
                    result.setSpokenSummaryShort(fieldGeneratorSpokenSummaryShort.value);
                    fieldGeneratorSpokenSummaryShort.have_value = false;
                  }
                else if ((!(result.hasSpokenSummaryShort())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"SpokenSummaryShort\" field was missing.");
                  }
                if (fieldGeneratorSpokenSummaryLong.have_value)
                  {
                    result.setSpokenSummaryLong(fieldGeneratorSpokenSummaryLong.value);
                    fieldGeneratorSpokenSummaryLong.have_value = false;
                  }
                else if ((!(result.hasSpokenSummaryLong())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"SpokenSummaryLong\" field was missing.");
                  }
                if (fieldGeneratorOriginalID.have_value)
                  {
                    result.setOriginalID(fieldGeneratorOriginalID.value);
                    fieldGeneratorOriginalID.have_value = false;
                  }
                else if ((!(result.hasOriginalID())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"OriginalID\" field was missing.");
                  }
                if (fieldGeneratorResolvedID.have_value)
                  {
                    result.setResolvedID(fieldGeneratorResolvedID.value);
                    fieldGeneratorResolvedID.have_value = false;
                  }
                else if ((!(result.hasResolvedID())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"ResolvedID\" field was missing.");
                  }
                if (fieldGeneratorWebCommandEnabled.have_value)
                  {
                    result.setWebCommandEnabled(fieldGeneratorWebCommandEnabled.value);
                    fieldGeneratorWebCommandEnabled.have_value = false;
                  }
                if (fieldGeneratorWikipediaAttribution.have_value)
                  {
                    result.setWikipediaAttribution(fieldGeneratorWikipediaAttribution.value);
                    fieldGeneratorWikipediaAttribution.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeNativeDataJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'I':
                        if ((String.Compare(field_name, 1, "mage", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorImage;
                        break;
                    case 'O':
                        if ((String.Compare(field_name, 1, "riginalID", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorOriginalID;
                        break;
                    case 'R':
                        if (String.Compare(field_name, 1, "e", 0, 1, false) == 0)
                          {
                            switch (field_name[2])
                              {
                                case 'q':
                                    if ((String.Compare(field_name, 3, "uestedTitle", 0, 11, false) == 0) && (field_name.Length == 14))
                                        return fieldGeneratorRequestedTitle;
                                    break;
                                case 's':
                                    if ((String.Compare(field_name, 3, "olvedID", 0, 7, false) == 0) && (field_name.Length == 10))
                                        return fieldGeneratorResolvedID;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'S':
                        switch (field_name[1])
                          {
                            case 'h':
                                if ((String.Compare(field_name, 2, "ouldIndicateRedirect", 0, 20, false) == 0) && (field_name.Length == 22))
                                    return fieldGeneratorShouldIndicateRedirect;
                                break;
                            case 'p':
                                if (String.Compare(field_name, 2, "okenSummary", 0, 11, false) == 0)
                                  {
                                    switch (field_name[13])
                                      {
                                        case 'L':
                                            if ((String.Compare(field_name, 14, "ong", 0, 3, false) == 0) && (field_name.Length == 17))
                                                return fieldGeneratorSpokenSummaryLong;
                                            break;
                                        case 'S':
                                            if ((String.Compare(field_name, 14, "hort", 0, 4, false) == 0) && (field_name.Length == 18))
                                                return fieldGeneratorSpokenSummaryShort;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'T':
                        if ((String.Compare(field_name, 1, "itle", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorTitle;
                        break;
                    case 'U':
                        if ((String.Compare(field_name, 1, "RI", 0, 2, false) == 0) && (field_name.Length == 3))
                            return fieldGeneratorURI;
                        break;
                    case 'W':
                        switch (field_name[1])
                          {
                            case 'e':
                                if ((String.Compare(field_name, 2, "bCommandEnabled", 0, 15, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorWebCommandEnabled;
                                break;
                            case 'i':
                                if ((String.Compare(field_name, 2, "kipediaAttribution", 0, 18, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorWikipediaAttribution;
                                break;
                            case 'r':
                                if (String.Compare(field_name, 2, "ittenSummary", 0, 12, false) == 0)
                                  {
                                    switch (field_name[14])
                                      {
                                        case 'L':
                                            if ((String.Compare(field_name, 15, "ong", 0, 3, false) == 0) && (field_name.Length == 18))
                                                return fieldGeneratorWrittenSummaryLong;
                                            break;
                                        case 'S':
                                            if ((String.Compare(field_name, 15, "hort", 0, 4, false) == 0) && (field_name.Length == 19))
                                                return fieldGeneratorWrittenSummaryShort;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            default:
                                break;
                          }
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the TypeNativeData class");
                fieldGeneratorRequestedTitle = new JSONHoldingStringGenerator("field \"RequestedTitle\" of the TypeNativeData class");
                fieldGeneratorShouldIndicateRedirect = new JSONHoldingBooleanGenerator("field \"ShouldIndicateRedirect\" of the TypeNativeData class");
                fieldGeneratorWrittenSummaryShort = new JSONHoldingStringGenerator("field \"WrittenSummaryShort\" of the TypeNativeData class");
                fieldGeneratorWrittenSummaryLong = new JSONHoldingStringGenerator("field \"WrittenSummaryLong\" of the TypeNativeData class");
                fieldGeneratorImage = new JSONHoldingStringGenerator("field \"Image\" of the TypeNativeData class");
                fieldGeneratorURI = new JSONHoldingStringGenerator("field \"URI\" of the TypeNativeData class");
                fieldGeneratorSpokenSummaryShort = new JSONHoldingStringGenerator("field \"SpokenSummaryShort\" of the TypeNativeData class");
                fieldGeneratorSpokenSummaryLong = new JSONHoldingStringGenerator("field \"SpokenSummaryLong\" of the TypeNativeData class");
                fieldGeneratorOriginalID = new FieldHoldingGeneratorOriginalID("field \"OriginalID\" of the TypeNativeData class");
                fieldGeneratorResolvedID = new FieldHoldingGeneratorResolvedID("field \"ResolvedID\" of the TypeNativeData class");
                fieldGeneratorWebCommandEnabled = new JSONHoldingBooleanGenerator("field \"WebCommandEnabled\" of the TypeNativeData class");
                fieldGeneratorWikipediaAttribution = new JSONHoldingStringGenerator("field \"WikipediaAttribution\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the TypeNativeData class");
                fieldGeneratorRequestedTitle = new JSONHoldingStringGenerator("field \"RequestedTitle\" of the TypeNativeData class");
                fieldGeneratorShouldIndicateRedirect = new JSONHoldingBooleanGenerator("field \"ShouldIndicateRedirect\" of the TypeNativeData class");
                fieldGeneratorWrittenSummaryShort = new JSONHoldingStringGenerator("field \"WrittenSummaryShort\" of the TypeNativeData class");
                fieldGeneratorWrittenSummaryLong = new JSONHoldingStringGenerator("field \"WrittenSummaryLong\" of the TypeNativeData class");
                fieldGeneratorImage = new JSONHoldingStringGenerator("field \"Image\" of the TypeNativeData class");
                fieldGeneratorURI = new JSONHoldingStringGenerator("field \"URI\" of the TypeNativeData class");
                fieldGeneratorSpokenSummaryShort = new JSONHoldingStringGenerator("field \"SpokenSummaryShort\" of the TypeNativeData class");
                fieldGeneratorSpokenSummaryLong = new JSONHoldingStringGenerator("field \"SpokenSummaryLong\" of the TypeNativeData class");
                fieldGeneratorOriginalID = new FieldHoldingGeneratorOriginalID("field \"OriginalID\" of the TypeNativeData class");
                fieldGeneratorResolvedID = new FieldHoldingGeneratorResolvedID("field \"ResolvedID\" of the TypeNativeData class");
                fieldGeneratorWebCommandEnabled = new JSONHoldingBooleanGenerator("field \"WebCommandEnabled\" of the TypeNativeData class");
                fieldGeneratorWikipediaAttribution = new JSONHoldingStringGenerator("field \"WikipediaAttribution\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorTitle.reset();
                fieldGeneratorRequestedTitle.reset();
                fieldGeneratorShouldIndicateRedirect.reset();
                fieldGeneratorWrittenSummaryShort.reset();
                fieldGeneratorWrittenSummaryLong.reset();
                fieldGeneratorImage.reset();
                fieldGeneratorURI.reset();
                fieldGeneratorSpokenSummaryShort.reset();
                fieldGeneratorSpokenSummaryLong.reset();
                fieldGeneratorOriginalID.reset();
                fieldGeneratorResolvedID.reset();
                fieldGeneratorWebCommandEnabled.reset();
                fieldGeneratorWikipediaAttribution.reset();
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
            protected override void handle_result(TypeNativeDataJSON  result)
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
            public TypeNativeDataJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeNativeDataJSON  result)
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
        protected virtual void handle_result(List<TypeNativeDataJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeNativeDataJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeNativeDataJSON>();
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
        public List<TypeNativeDataJSON> value;
      };
      };
    private bool flagHasNativeData;
    private List< TypeNativeDataJSON  > storeNativeData;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraNativeDataToJSON()
      {
        JSONArrayValue generated_array_1_NativeData = new JSONArrayValue();
        for (int num1 = 0; num1 < storeNativeData.Count; ++num1)
          {
            JSONValueHandler handler_NativeData = new JSONValueHandler();
            storeNativeData[num1].write_as_json(handler_NativeData);
            generated_array_1_NativeData.appendComponent(handler_NativeData.result);
          }
        return generated_array_1_NativeData;
      }


    private void  fromJSONNativeData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field NativeData of WikipediaCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field NativeData of WikipediaCommandJSON has too few elements.");
        List< TypeNativeDataJSON  > vector_NativeData1 = new List< TypeNativeDataJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeNativeDataJSON convert_classy = TypeNativeDataJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_NativeData1.Add(convert_classy);
          }
        Debug.Assert(vector_NativeData1.Count >= 1);
        initNativeData();
        for (int num1 = 0; num1 < vector_NativeData1.Count; ++num1)
            appendNativeData(vector_NativeData1[num1]);
        for (int num1 = 0; num1 < vector_NativeData1.Count; ++num1)
          {
          }
      }


    public WikipediaCommandJSON()
      {
        flagHasNativeData = false;
        storeNativeData = new List< TypeNativeDataJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getCommandKind()
      {
        return "WikipediaCommand";
      }

    public bool  hasNativeData()
      {
        return flagHasNativeData;
      }

    public int  countOfNativeData()
      {
        Debug.Assert(flagHasNativeData);
        return storeNativeData.Count;
      }

    public TypeNativeDataJSON   elementOfNativeData(int element_num)
      {
        Debug.Assert(flagHasNativeData);
        return storeNativeData[element_num];
      }

    public List< TypeNativeDataJSON  >  getNativeData()
      {
        Debug.Assert(flagHasNativeData);
        return storeNativeData;
      }


    public virtual int extraWikipediaCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraWikipediaCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraWikipediaCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraWikipediaCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCommandResultComponentCount()
      {
        int result = 0;
        if (flagHasNativeData)
            ++result;
        result += extraWikipediaCommandComponentCount();
        return result;
      }
    public override string extraCommandResultComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return "NativeData";
            --remainder;
          }
        return extraWikipediaCommandComponentKey(remainder);
      }
    public override JSONValue extraCommandResultComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return extraNativeDataToJSON();
            --remainder;
          }
        return extraWikipediaCommandComponentValue(remainder);
      }
    public override JSONValue extraCommandResultLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "NativeData", 0, 10, false) == 0) && (field_name.Length == 10))
            return (flagHasNativeData ? extraNativeDataToJSON() : null);
        return extraWikipediaCommandLookup(field_name);
      }

    public void initNativeData()
      {
        if (flagHasNativeData)
          {
            for (int num1 = 0; num1 < storeNativeData.Count; ++num1)
              {
              }
          }
        flagHasNativeData = true;
        storeNativeData.Clear();
      }
    public void appendNativeData(TypeNativeDataJSON  to_append)
      {
        if (!flagHasNativeData)
          {
            flagHasNativeData = true;
            storeNativeData.Clear();
          }
        Debug.Assert(flagHasNativeData);
        storeNativeData.Add(to_append);
      }
    public void unsetNativeData()
      {
        if (flagHasNativeData)
          {
            for (int num2 = 0; num2 < storeNativeData.Count; ++num2)
              {
              }
          }
        flagHasNativeData = false;
        storeNativeData.Clear();
      }

    public virtual void extraWikipediaCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraWikipediaCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraWikipediaCommandLookup(key);
        if (old_field == null)
          {
            extraWikipediaCommandAppendPair(key, new_component);
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
    public override void extraCommandResultAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "NativeData", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONNativeData(new_component, false);
            return;
            }
        extraWikipediaCommandAppendPair(key, new_component);
      }
    public override void extraCommandResultSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "NativeData", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONNativeData(new_component, false);
            return;
            }
        extraWikipediaCommandSetField(key, new_component);
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

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        Debug.Assert(partial_allowed || flagHasNativeData);
        if (flagHasNativeData)
          {
            handler.start_pair("NativeData");
            Debug.Assert(storeNativeData.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeNativeData.Count; ++num1)
              {
                if (partial_allowed)
                    storeNativeData[num1].write_partial_as_json(handler);
                else
                    storeNativeData[num1].write_as_json(handler);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasNativeData()))
          {
            return "When parsing the object for %what%, the \"NativeData\" field was missing.";
          }
        return null;
      }

    public static new WikipediaCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WikipediaCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikipediaCommand", ignore_extras);
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
    public static new WikipediaCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new WikipediaCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WikipediaCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikipediaCommand", ignore_extras);
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
    public static new WikipediaCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new WikipediaCommandJSON from_text(string text, bool ignore_extras)
      {
        WikipediaCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikipediaCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for WikipediaCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new WikipediaCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        WikipediaCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikipediaCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandResultJSON.Generator
      {
        private TypeNativeDataJSON.HoldingArrayGenerator fieldGeneratorNativeData;
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
            if (!(getCommandResultJSONKey().Equals("WikipediaCommand")))
                throw new Exception("The key field has a value other than `WikipediaCommand'.");
            WikipediaCommandJSON result = new WikipediaCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraWikipediaCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CommandResultJSON new_result)
          {
            handle_result((WikipediaCommandJSON )new_result);
          }
        protected void finish(WikipediaCommandJSON result)
          {
            if (fieldGeneratorNativeData.have_value)
              {
                result.initNativeData();
                int count = fieldGeneratorNativeData.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendNativeData(fieldGeneratorNativeData.value[num]);
                  }
                fieldGeneratorNativeData.value.Clear();
                fieldGeneratorNativeData.have_value = false;
              }
            else if ((!(result.hasNativeData())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NativeData\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(WikipediaCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "NativeData", 0, 10, false) == 0) && (field_name.Length == 10))
                return fieldGeneratorNativeData;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingArrayGenerator("field \"NativeData\" of the WikipediaCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the WikipediaCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingArrayGenerator("field \"NativeData\" of the WikipediaCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the WikipediaCommand class");
          }

        public override void reset()
          {
            fieldGeneratorNativeData.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(WikipediaCommandJSON  result)
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
        public WikipediaCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(WikipediaCommandJSON  result)
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
    protected virtual void handle_result(List<WikipediaCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<WikipediaCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<WikipediaCommandJSON>();
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
    public List<WikipediaCommandJSON> value;
  };
  };
