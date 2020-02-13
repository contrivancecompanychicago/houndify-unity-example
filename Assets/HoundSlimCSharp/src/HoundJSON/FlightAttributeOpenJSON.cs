/* file "FlightAttributeOpenJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class FlightAttributeOpenJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_Status,
        Value_DepartureInformation,
        Value_DepartureTime,
        Value_HasDeparted,
        Value_DepartureLocation,
        Value_DepartureAirport,
        Value_DepartureTerminal,
        Value_DepartureGate,
        Value_ArrivalInformation,
        Value_ArrivalTime,
        Value_HasArrived,
        Value_ArrivalLocation,
        Value_ArrivalAirport,
        Value_ArrivalTerminal,
        Value_ArrivalGate,
        Value_FlightDuration,
        Value_BoardingTime,
        Value__none
      };
    public struct TypeValue
      {
        public bool in_known_list;
        public string string_value;
        public TypeValueKnownValues list_value;
      };

    public static TypeValueKnownValues  stringToValue(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if (String.Compare(chars, 1, "rrival", 0, 6, false) == 0)
                  {
                    switch (chars[7])
                      {
                        case 'A':
                            if ((String.Compare(chars, 8, "irport", 0, 6, false) == 0) && (chars.Length == 14))
                                return TypeValueKnownValues.Value_ArrivalAirport;
                            break;
                        case 'G':
                            if ((String.Compare(chars, 8, "ate", 0, 3, false) == 0) && (chars.Length == 11))
                                return TypeValueKnownValues.Value_ArrivalGate;
                            break;
                        case 'I':
                            if ((String.Compare(chars, 8, "nformation", 0, 10, false) == 0) && (chars.Length == 18))
                                return TypeValueKnownValues.Value_ArrivalInformation;
                            break;
                        case 'L':
                            if ((String.Compare(chars, 8, "ocation", 0, 7, false) == 0) && (chars.Length == 15))
                                return TypeValueKnownValues.Value_ArrivalLocation;
                            break;
                        case 'T':
                            switch (chars[8])
                              {
                                case 'e':
                                    if ((String.Compare(chars, 9, "rminal", 0, 6, false) == 0) && (chars.Length == 15))
                                        return TypeValueKnownValues.Value_ArrivalTerminal;
                                    break;
                                case 'i':
                                    if ((String.Compare(chars, 9, "me", 0, 2, false) == 0) && (chars.Length == 11))
                                        return TypeValueKnownValues.Value_ArrivalTime;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'B':
                if ((String.Compare(chars, 1, "oardingTime", 0, 11, false) == 0) && (chars.Length == 12))
                    return TypeValueKnownValues.Value_BoardingTime;
                break;
            case 'D':
                if (String.Compare(chars, 1, "eparture", 0, 8, false) == 0)
                  {
                    switch (chars[9])
                      {
                        case 'A':
                            if ((String.Compare(chars, 10, "irport", 0, 6, false) == 0) && (chars.Length == 16))
                                return TypeValueKnownValues.Value_DepartureAirport;
                            break;
                        case 'G':
                            if ((String.Compare(chars, 10, "ate", 0, 3, false) == 0) && (chars.Length == 13))
                                return TypeValueKnownValues.Value_DepartureGate;
                            break;
                        case 'I':
                            if ((String.Compare(chars, 10, "nformation", 0, 10, false) == 0) && (chars.Length == 20))
                                return TypeValueKnownValues.Value_DepartureInformation;
                            break;
                        case 'L':
                            if ((String.Compare(chars, 10, "ocation", 0, 7, false) == 0) && (chars.Length == 17))
                                return TypeValueKnownValues.Value_DepartureLocation;
                            break;
                        case 'T':
                            switch (chars[10])
                              {
                                case 'e':
                                    if ((String.Compare(chars, 11, "rminal", 0, 6, false) == 0) && (chars.Length == 17))
                                        return TypeValueKnownValues.Value_DepartureTerminal;
                                    break;
                                case 'i':
                                    if ((String.Compare(chars, 11, "me", 0, 2, false) == 0) && (chars.Length == 13))
                                        return TypeValueKnownValues.Value_DepartureTime;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'F':
                if ((String.Compare(chars, 1, "lightDuration", 0, 13, false) == 0) && (chars.Length == 14))
                    return TypeValueKnownValues.Value_FlightDuration;
                break;
            case 'H':
                if (String.Compare(chars, 1, "as", 0, 2, false) == 0)
                  {
                    switch (chars[3])
                      {
                        case 'A':
                            if ((String.Compare(chars, 4, "rrived", 0, 6, false) == 0) && (chars.Length == 10))
                                return TypeValueKnownValues.Value_HasArrived;
                            break;
                        case 'D':
                            if ((String.Compare(chars, 4, "eparted", 0, 7, false) == 0) && (chars.Length == 11))
                                return TypeValueKnownValues.Value_HasDeparted;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if ((String.Compare(chars, 1, "tatus", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeValueKnownValues.Value_Status;
                break;
            default:
                break;
          }
        return TypeValueKnownValues.Value__none;
      }

    public static string  stringFromValue(TypeValueKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeValueKnownValues.Value_Status:
                return "Status";
            case TypeValueKnownValues.Value_DepartureInformation:
                return "DepartureInformation";
            case TypeValueKnownValues.Value_DepartureTime:
                return "DepartureTime";
            case TypeValueKnownValues.Value_HasDeparted:
                return "HasDeparted";
            case TypeValueKnownValues.Value_DepartureLocation:
                return "DepartureLocation";
            case TypeValueKnownValues.Value_DepartureAirport:
                return "DepartureAirport";
            case TypeValueKnownValues.Value_DepartureTerminal:
                return "DepartureTerminal";
            case TypeValueKnownValues.Value_DepartureGate:
                return "DepartureGate";
            case TypeValueKnownValues.Value_ArrivalInformation:
                return "ArrivalInformation";
            case TypeValueKnownValues.Value_ArrivalTime:
                return "ArrivalTime";
            case TypeValueKnownValues.Value_HasArrived:
                return "HasArrived";
            case TypeValueKnownValues.Value_ArrivalLocation:
                return "ArrivalLocation";
            case TypeValueKnownValues.Value_ArrivalAirport:
                return "ArrivalAirport";
            case TypeValueKnownValues.Value_ArrivalTerminal:
                return "ArrivalTerminal";
            case TypeValueKnownValues.Value_ArrivalGate:
                return "ArrivalGate";
            case TypeValueKnownValues.Value_FlightDuration:
                return "FlightDuration";
            case TypeValueKnownValues.Value_BoardingTime:
                return "BoardingTime";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasValue;
    private TypeValue storeValue;


    private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Value of FlightAttributeOpenJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case 'A':
                if (String.Compare(json_string.getData(), 1, "rrival", 0, 6, false) == 0)
                  {
                    switch (json_string.getData()[7])
                      {
                        case 'A':
                            if ((String.Compare(json_string.getData(), 8, "irport", 0, 6, false) == 0) && (json_string.getData().Length == 14))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_ArrivalAirport;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'G':
                            if ((String.Compare(json_string.getData(), 8, "ate", 0, 3, false) == 0) && (json_string.getData().Length == 11))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_ArrivalGate;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'I':
                            if ((String.Compare(json_string.getData(), 8, "nformation", 0, 10, false) == 0) && (json_string.getData().Length == 18))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_ArrivalInformation;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'L':
                            if ((String.Compare(json_string.getData(), 8, "ocation", 0, 7, false) == 0) && (json_string.getData().Length == 15))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_ArrivalLocation;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'T':
                            switch (json_string.getData()[8])
                              {
                                case 'e':
                                    if ((String.Compare(json_string.getData(), 9, "rminal", 0, 6, false) == 0) && (json_string.getData().Length == 15))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_ArrivalTerminal;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'i':
                                    if ((String.Compare(json_string.getData(), 9, "me", 0, 2, false) == 0) && (json_string.getData().Length == 11))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_ArrivalTime;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'B':
                if ((String.Compare(json_string.getData(), 1, "oardingTime", 0, 11, false) == 0) && (json_string.getData().Length == 12))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_BoardingTime;
                        goto open_enum_is_done;
                      }
                break;
            case 'D':
                if (String.Compare(json_string.getData(), 1, "eparture", 0, 8, false) == 0)
                  {
                    switch (json_string.getData()[9])
                      {
                        case 'A':
                            if ((String.Compare(json_string.getData(), 10, "irport", 0, 6, false) == 0) && (json_string.getData().Length == 16))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_DepartureAirport;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'G':
                            if ((String.Compare(json_string.getData(), 10, "ate", 0, 3, false) == 0) && (json_string.getData().Length == 13))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_DepartureGate;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'I':
                            if ((String.Compare(json_string.getData(), 10, "nformation", 0, 10, false) == 0) && (json_string.getData().Length == 20))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_DepartureInformation;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'L':
                            if ((String.Compare(json_string.getData(), 10, "ocation", 0, 7, false) == 0) && (json_string.getData().Length == 17))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_DepartureLocation;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'T':
                            switch (json_string.getData()[10])
                              {
                                case 'e':
                                    if ((String.Compare(json_string.getData(), 11, "rminal", 0, 6, false) == 0) && (json_string.getData().Length == 17))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_DepartureTerminal;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'i':
                                    if ((String.Compare(json_string.getData(), 11, "me", 0, 2, false) == 0) && (json_string.getData().Length == 13))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_DepartureTime;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "lightDuration", 0, 13, false) == 0) && (json_string.getData().Length == 14))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_FlightDuration;
                        goto open_enum_is_done;
                      }
                break;
            case 'H':
                if (String.Compare(json_string.getData(), 1, "as", 0, 2, false) == 0)
                  {
                    switch (json_string.getData()[3])
                      {
                        case 'A':
                            if ((String.Compare(json_string.getData(), 4, "rrived", 0, 6, false) == 0) && (json_string.getData().Length == 10))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_HasArrived;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'D':
                            if ((String.Compare(json_string.getData(), 4, "eparted", 0, 7, false) == 0) && (json_string.getData().Length == 11))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_HasDeparted;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "tatus", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Status;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setValue(the_open_enum);
      }


    public FlightAttributeOpenJSON()
      {
        flagHasValue = false;
      }

    public FlightAttributeOpenJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public FlightAttributeOpenJSON(string init_value)
      {
        flagHasValue = true;
        TypeValueKnownValues known = stringToValue(init_value);
        if (known == TypeValueKnownValues.Value__none)
          {
            storeValue.in_known_list = false;
            storeValue.string_value = init_value;
          }
        else
          {
            storeValue.in_known_list = true;
            storeValue.list_value = known;
          }
      }

    public FlightAttributeOpenJSON(TypeValueKnownValues init_value)
      {
        flagHasValue = true;
        Debug.Assert(init_value != TypeValueKnownValues.Value__none);
        storeValue.in_known_list = true;
        storeValue.list_value = init_value;
      }

    public bool  hasValue()
      {
        return flagHasValue;
      }

    public TypeValue  getValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue;
      }

    public string  getValueAsString()
      {
        TypeValue result = getValue();
        if (result.in_known_list)
            return stringFromValue(result.list_value);
        else
            return result.string_value;
      }



    public void setValue(TypeValue new_value)
      {
        flagHasValue = true;
        storeValue = new_value;
      }
    public void setValue(string chars)
      {
        TypeValueKnownValues known = stringToValue(chars);
        TypeValue new_value = new TypeValue();
        if (known == TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setValue(new_value);
      }
    public void setValue(TypeValueKnownValues new_value)
      {
        TypeValue new_full_value = new TypeValue();
        Debug.Assert(new_value != TypeValueKnownValues.Value__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setValue(new_full_value);
      }
    public void unsetValue()
      {
        flagHasValue = false;
      }


    public override void write_as_json(JSONHandler handler)
      {
        if (storeValue.in_known_list)
          {
            switch (storeValue.list_value)
              {
                case TypeValueKnownValues.Value_Status:
                    handler.string_value("Status");
                    break;
                case TypeValueKnownValues.Value_DepartureInformation:
                    handler.string_value("DepartureInformation");
                    break;
                case TypeValueKnownValues.Value_DepartureTime:
                    handler.string_value("DepartureTime");
                    break;
                case TypeValueKnownValues.Value_HasDeparted:
                    handler.string_value("HasDeparted");
                    break;
                case TypeValueKnownValues.Value_DepartureLocation:
                    handler.string_value("DepartureLocation");
                    break;
                case TypeValueKnownValues.Value_DepartureAirport:
                    handler.string_value("DepartureAirport");
                    break;
                case TypeValueKnownValues.Value_DepartureTerminal:
                    handler.string_value("DepartureTerminal");
                    break;
                case TypeValueKnownValues.Value_DepartureGate:
                    handler.string_value("DepartureGate");
                    break;
                case TypeValueKnownValues.Value_ArrivalInformation:
                    handler.string_value("ArrivalInformation");
                    break;
                case TypeValueKnownValues.Value_ArrivalTime:
                    handler.string_value("ArrivalTime");
                    break;
                case TypeValueKnownValues.Value_HasArrived:
                    handler.string_value("HasArrived");
                    break;
                case TypeValueKnownValues.Value_ArrivalLocation:
                    handler.string_value("ArrivalLocation");
                    break;
                case TypeValueKnownValues.Value_ArrivalAirport:
                    handler.string_value("ArrivalAirport");
                    break;
                case TypeValueKnownValues.Value_ArrivalTerminal:
                    handler.string_value("ArrivalTerminal");
                    break;
                case TypeValueKnownValues.Value_ArrivalGate:
                    handler.string_value("ArrivalGate");
                    break;
                case TypeValueKnownValues.Value_FlightDuration:
                    handler.string_value("FlightDuration");
                    break;
                case TypeValueKnownValues.Value_BoardingTime:
                    handler.string_value("BoardingTime");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        else
          {
                    handler.string_value(storeValue.string_value);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        if (storeValue.in_known_list)
          {
            switch (storeValue.list_value)
              {
                case TypeValueKnownValues.Value_Status:
                    handler.string_value("Status");
                    break;
                case TypeValueKnownValues.Value_DepartureInformation:
                    handler.string_value("DepartureInformation");
                    break;
                case TypeValueKnownValues.Value_DepartureTime:
                    handler.string_value("DepartureTime");
                    break;
                case TypeValueKnownValues.Value_HasDeparted:
                    handler.string_value("HasDeparted");
                    break;
                case TypeValueKnownValues.Value_DepartureLocation:
                    handler.string_value("DepartureLocation");
                    break;
                case TypeValueKnownValues.Value_DepartureAirport:
                    handler.string_value("DepartureAirport");
                    break;
                case TypeValueKnownValues.Value_DepartureTerminal:
                    handler.string_value("DepartureTerminal");
                    break;
                case TypeValueKnownValues.Value_DepartureGate:
                    handler.string_value("DepartureGate");
                    break;
                case TypeValueKnownValues.Value_ArrivalInformation:
                    handler.string_value("ArrivalInformation");
                    break;
                case TypeValueKnownValues.Value_ArrivalTime:
                    handler.string_value("ArrivalTime");
                    break;
                case TypeValueKnownValues.Value_HasArrived:
                    handler.string_value("HasArrived");
                    break;
                case TypeValueKnownValues.Value_ArrivalLocation:
                    handler.string_value("ArrivalLocation");
                    break;
                case TypeValueKnownValues.Value_ArrivalAirport:
                    handler.string_value("ArrivalAirport");
                    break;
                case TypeValueKnownValues.Value_ArrivalTerminal:
                    handler.string_value("ArrivalTerminal");
                    break;
                case TypeValueKnownValues.Value_ArrivalGate:
                    handler.string_value("ArrivalGate");
                    break;
                case TypeValueKnownValues.Value_FlightDuration:
                    handler.string_value("FlightDuration");
                    break;
                case TypeValueKnownValues.Value_BoardingTime:
                    handler.string_value("BoardingTime");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        else
          {
                    handler.string_value(storeValue.string_value);
          }
      }

    public static FlightAttributeOpenJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightAttributeOpenJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightAttributeOpen", ignore_extras);
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
    public static FlightAttributeOpenJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightAttributeOpenJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightAttributeOpenJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightAttributeOpen", ignore_extras);
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
    public static FlightAttributeOpenJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightAttributeOpenJSON from_text(string text, bool ignore_extras)
      {
        FlightAttributeOpenJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightAttributeOpen", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightAttributeOpenJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FlightAttributeOpenJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightAttributeOpenJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightAttributeOpen", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class FieldGeneratorValue : JSONStringGenerator
      {
        protected FieldGeneratorValue(string what)
          {
            set_what(what);
          }
        protected FieldGeneratorValue()
          {
          }
        protected override void handle_result(string result)
          {
            TypeValueKnownValues known = stringToValue(result);
            TypeValue new_value = new TypeValue();
            if (known == TypeValueKnownValues.Value__none)
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
        protected abstract void handle_result(TypeValue result);
      };
    public class FieldHoldingGeneratorValue : FieldGeneratorValue
  {
    protected override void handle_result(TypeValue result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorValue(String what)
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
    public TypeValue value;
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

        public ElementHandler(FieldHoldingArrayGeneratorValue init_top)
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

    public FieldHoldingArrayGeneratorValue(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeValue>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorValue()
      {
        element_handler = new ElementHandler(this);
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
    public abstract class Generator : FieldGeneratorValue
      {
        protected override void handle_result(TypeValue new_value)
          {
            FlightAttributeOpenJSON result = new FlightAttributeOpenJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(FlightAttributeOpenJSON new_result);
        public Generator(bool ignore_extras) : base("Type FlightAttributeOpen")
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
        protected override void handle_result(FlightAttributeOpenJSON  result)
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
        public FlightAttributeOpenJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightAttributeOpenJSON  result)
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
    protected virtual void handle_result(List<FlightAttributeOpenJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightAttributeOpenJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightAttributeOpenJSON>();
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
    public List<FlightAttributeOpenJSON> value;
  };
  };
