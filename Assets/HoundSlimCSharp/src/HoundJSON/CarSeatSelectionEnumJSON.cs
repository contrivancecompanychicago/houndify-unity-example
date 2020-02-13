/* file "CarSeatSelectionEnumJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CarSeatSelectionEnumJSON : JSONBase
  {
    public enum TypeValue
      {
        Value_FrontLeft,
        Value_FrontRight,
        Value_FrontDriver,
        Value_FrontPassenger,
        Value_FrontCentre,
        Value_FrontBoth,
        Value_RearLeft,
        Value_RearRight,
        Value_RearDriver,
        Value_RearPassenger,
        Value_RearCentre,
        Value_RearBoth,
        Value_MiddleLeft,
        Value_MiddleRight,
        Value_MiddleDriver,
        Value_MiddlePassenger,
        Value_MiddleCentre,
        Value_MiddleBoth,
        Value_LeftAll,
        Value_RightAll,
        Value_DriverAll,
        Value_PassengerAll,
        Value_CentreAll,
        Value_All
      };

    public static TypeValue  stringToValue(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "ll", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeValue.Value_All;
                break;
            case 'C':
                if ((String.Compare(chars, 1, "entreAll", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeValue.Value_CentreAll;
                break;
            case 'D':
                if ((String.Compare(chars, 1, "riverAll", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeValue.Value_DriverAll;
                break;
            case 'F':
                if (String.Compare(chars, 1, "ront", 0, 4, false) == 0)
                  {
                    switch (chars[5])
                      {
                        case 'B':
                            if ((String.Compare(chars, 6, "oth", 0, 3, false) == 0) && (chars.Length == 9))
                                return TypeValue.Value_FrontBoth;
                            break;
                        case 'C':
                            if ((String.Compare(chars, 6, "entre", 0, 5, false) == 0) && (chars.Length == 11))
                                return TypeValue.Value_FrontCentre;
                            break;
                        case 'D':
                            if ((String.Compare(chars, 6, "river", 0, 5, false) == 0) && (chars.Length == 11))
                                return TypeValue.Value_FrontDriver;
                            break;
                        case 'L':
                            if ((String.Compare(chars, 6, "eft", 0, 3, false) == 0) && (chars.Length == 9))
                                return TypeValue.Value_FrontLeft;
                            break;
                        case 'P':
                            if ((String.Compare(chars, 6, "assenger", 0, 8, false) == 0) && (chars.Length == 14))
                                return TypeValue.Value_FrontPassenger;
                            break;
                        case 'R':
                            if ((String.Compare(chars, 6, "ight", 0, 4, false) == 0) && (chars.Length == 10))
                                return TypeValue.Value_FrontRight;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'L':
                if ((String.Compare(chars, 1, "eftAll", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeValue.Value_LeftAll;
                break;
            case 'M':
                if (String.Compare(chars, 1, "iddle", 0, 5, false) == 0)
                  {
                    switch (chars[6])
                      {
                        case 'B':
                            if ((String.Compare(chars, 7, "oth", 0, 3, false) == 0) && (chars.Length == 10))
                                return TypeValue.Value_MiddleBoth;
                            break;
                        case 'C':
                            if ((String.Compare(chars, 7, "entre", 0, 5, false) == 0) && (chars.Length == 12))
                                return TypeValue.Value_MiddleCentre;
                            break;
                        case 'D':
                            if ((String.Compare(chars, 7, "river", 0, 5, false) == 0) && (chars.Length == 12))
                                return TypeValue.Value_MiddleDriver;
                            break;
                        case 'L':
                            if ((String.Compare(chars, 7, "eft", 0, 3, false) == 0) && (chars.Length == 10))
                                return TypeValue.Value_MiddleLeft;
                            break;
                        case 'P':
                            if ((String.Compare(chars, 7, "assenger", 0, 8, false) == 0) && (chars.Length == 15))
                                return TypeValue.Value_MiddlePassenger;
                            break;
                        case 'R':
                            if ((String.Compare(chars, 7, "ight", 0, 4, false) == 0) && (chars.Length == 11))
                                return TypeValue.Value_MiddleRight;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'P':
                if ((String.Compare(chars, 1, "assengerAll", 0, 11, false) == 0) && (chars.Length == 12))
                    return TypeValue.Value_PassengerAll;
                break;
            case 'R':
                switch (chars[1])
                  {
                    case 'e':
                        if (String.Compare(chars, 2, "ar", 0, 2, false) == 0)
                          {
                            switch (chars[4])
                              {
                                case 'B':
                                    if ((String.Compare(chars, 5, "oth", 0, 3, false) == 0) && (chars.Length == 8))
                                        return TypeValue.Value_RearBoth;
                                    break;
                                case 'C':
                                    if ((String.Compare(chars, 5, "entre", 0, 5, false) == 0) && (chars.Length == 10))
                                        return TypeValue.Value_RearCentre;
                                    break;
                                case 'D':
                                    if ((String.Compare(chars, 5, "river", 0, 5, false) == 0) && (chars.Length == 10))
                                        return TypeValue.Value_RearDriver;
                                    break;
                                case 'L':
                                    if ((String.Compare(chars, 5, "eft", 0, 3, false) == 0) && (chars.Length == 8))
                                        return TypeValue.Value_RearLeft;
                                    break;
                                case 'P':
                                    if ((String.Compare(chars, 5, "assenger", 0, 8, false) == 0) && (chars.Length == 13))
                                        return TypeValue.Value_RearPassenger;
                                    break;
                                case 'R':
                                    if ((String.Compare(chars, 5, "ight", 0, 4, false) == 0) && (chars.Length == 9))
                                        return TypeValue.Value_RearRight;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'i':
                        if ((String.Compare(chars, 2, "ghtAll", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeValue.Value_RightAll;
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        throw new Exception("The value for field `Value' is not one of the legal values.");
      }

    public static string  stringFromValue(TypeValue the_enum)
      {
        switch (the_enum)
          {
            case TypeValue.Value_FrontLeft:
                return "FrontLeft";
            case TypeValue.Value_FrontRight:
                return "FrontRight";
            case TypeValue.Value_FrontDriver:
                return "FrontDriver";
            case TypeValue.Value_FrontPassenger:
                return "FrontPassenger";
            case TypeValue.Value_FrontCentre:
                return "FrontCentre";
            case TypeValue.Value_FrontBoth:
                return "FrontBoth";
            case TypeValue.Value_RearLeft:
                return "RearLeft";
            case TypeValue.Value_RearRight:
                return "RearRight";
            case TypeValue.Value_RearDriver:
                return "RearDriver";
            case TypeValue.Value_RearPassenger:
                return "RearPassenger";
            case TypeValue.Value_RearCentre:
                return "RearCentre";
            case TypeValue.Value_RearBoth:
                return "RearBoth";
            case TypeValue.Value_MiddleLeft:
                return "MiddleLeft";
            case TypeValue.Value_MiddleRight:
                return "MiddleRight";
            case TypeValue.Value_MiddleDriver:
                return "MiddleDriver";
            case TypeValue.Value_MiddlePassenger:
                return "MiddlePassenger";
            case TypeValue.Value_MiddleCentre:
                return "MiddleCentre";
            case TypeValue.Value_MiddleBoth:
                return "MiddleBoth";
            case TypeValue.Value_LeftAll:
                return "LeftAll";
            case TypeValue.Value_RightAll:
                return "RightAll";
            case TypeValue.Value_DriverAll:
                return "DriverAll";
            case TypeValue.Value_PassengerAll:
                return "PassengerAll";
            case TypeValue.Value_CentreAll:
                return "CentreAll";
            case TypeValue.Value_All:
                return "All";
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
            throw new Exception("The value for field Value of CarSeatSelectionEnumJSON is not a string.");
        TypeValue the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "ll", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_enum = TypeValue.Value_All;
                        goto enum_is_done;
                      }
                break;
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "entreAll", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_enum = TypeValue.Value_CentreAll;
                        goto enum_is_done;
                      }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "riverAll", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_enum = TypeValue.Value_DriverAll;
                        goto enum_is_done;
                      }
                break;
            case 'F':
                if (String.Compare(json_string.getData(), 1, "ront", 0, 4, false) == 0)
                  {
                    switch (json_string.getData()[5])
                      {
                        case 'B':
                            if ((String.Compare(json_string.getData(), 6, "oth", 0, 3, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_enum = TypeValue.Value_FrontBoth;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'C':
                            if ((String.Compare(json_string.getData(), 6, "entre", 0, 5, false) == 0) && (json_string.getData().Length == 11))
                                  {
                                    the_enum = TypeValue.Value_FrontCentre;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'D':
                            if ((String.Compare(json_string.getData(), 6, "river", 0, 5, false) == 0) && (json_string.getData().Length == 11))
                                  {
                                    the_enum = TypeValue.Value_FrontDriver;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'L':
                            if ((String.Compare(json_string.getData(), 6, "eft", 0, 3, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_enum = TypeValue.Value_FrontLeft;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'P':
                            if ((String.Compare(json_string.getData(), 6, "assenger", 0, 8, false) == 0) && (json_string.getData().Length == 14))
                                  {
                                    the_enum = TypeValue.Value_FrontPassenger;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'R':
                            if ((String.Compare(json_string.getData(), 6, "ight", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                  {
                                    the_enum = TypeValue.Value_FrontRight;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "eftAll", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeValue.Value_LeftAll;
                        goto enum_is_done;
                      }
                break;
            case 'M':
                if (String.Compare(json_string.getData(), 1, "iddle", 0, 5, false) == 0)
                  {
                    switch (json_string.getData()[6])
                      {
                        case 'B':
                            if ((String.Compare(json_string.getData(), 7, "oth", 0, 3, false) == 0) && (json_string.getData().Length == 10))
                                  {
                                    the_enum = TypeValue.Value_MiddleBoth;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'C':
                            if ((String.Compare(json_string.getData(), 7, "entre", 0, 5, false) == 0) && (json_string.getData().Length == 12))
                                  {
                                    the_enum = TypeValue.Value_MiddleCentre;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'D':
                            if ((String.Compare(json_string.getData(), 7, "river", 0, 5, false) == 0) && (json_string.getData().Length == 12))
                                  {
                                    the_enum = TypeValue.Value_MiddleDriver;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'L':
                            if ((String.Compare(json_string.getData(), 7, "eft", 0, 3, false) == 0) && (json_string.getData().Length == 10))
                                  {
                                    the_enum = TypeValue.Value_MiddleLeft;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'P':
                            if ((String.Compare(json_string.getData(), 7, "assenger", 0, 8, false) == 0) && (json_string.getData().Length == 15))
                                  {
                                    the_enum = TypeValue.Value_MiddlePassenger;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'R':
                            if ((String.Compare(json_string.getData(), 7, "ight", 0, 4, false) == 0) && (json_string.getData().Length == 11))
                                  {
                                    the_enum = TypeValue.Value_MiddleRight;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'P':
                if ((String.Compare(json_string.getData(), 1, "assengerAll", 0, 11, false) == 0) && (json_string.getData().Length == 12))
                      {
                        the_enum = TypeValue.Value_PassengerAll;
                        goto enum_is_done;
                      }
                break;
            case 'R':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if (String.Compare(json_string.getData(), 2, "ar", 0, 2, false) == 0)
                          {
                            switch (json_string.getData()[4])
                              {
                                case 'B':
                                    if ((String.Compare(json_string.getData(), 5, "oth", 0, 3, false) == 0) && (json_string.getData().Length == 8))
                                          {
                                            the_enum = TypeValue.Value_RearBoth;
                                            goto enum_is_done;
                                          }
                                    break;
                                case 'C':
                                    if ((String.Compare(json_string.getData(), 5, "entre", 0, 5, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_enum = TypeValue.Value_RearCentre;
                                            goto enum_is_done;
                                          }
                                    break;
                                case 'D':
                                    if ((String.Compare(json_string.getData(), 5, "river", 0, 5, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_enum = TypeValue.Value_RearDriver;
                                            goto enum_is_done;
                                          }
                                    break;
                                case 'L':
                                    if ((String.Compare(json_string.getData(), 5, "eft", 0, 3, false) == 0) && (json_string.getData().Length == 8))
                                          {
                                            the_enum = TypeValue.Value_RearLeft;
                                            goto enum_is_done;
                                          }
                                    break;
                                case 'P':
                                    if ((String.Compare(json_string.getData(), 5, "assenger", 0, 8, false) == 0) && (json_string.getData().Length == 13))
                                          {
                                            the_enum = TypeValue.Value_RearPassenger;
                                            goto enum_is_done;
                                          }
                                    break;
                                case 'R':
                                    if ((String.Compare(json_string.getData(), 5, "ight", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_enum = TypeValue.Value_RearRight;
                                            goto enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "ghtAll", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_enum = TypeValue.Value_RightAll;
                                goto enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        throw new Exception("The value for field Value of CarSeatSelectionEnumJSON is not one of the legal strings.");
      enum_is_done:;
        setValue(the_enum);
      }


    public CarSeatSelectionEnumJSON()
      {
        flagHasValue = false;
      }

    public CarSeatSelectionEnumJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public CarSeatSelectionEnumJSON(string init_value)
      {
        flagHasValue = true;
        storeValue = stringToValue(init_value);
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
        return stringFromValue(getValue());
      }



    public void setValue(TypeValue new_value)
      {
        flagHasValue = true;
        storeValue = new_value;
      }
    public void setValue(string chars)
      {
        setValue(stringToValue(chars));
      }
    public void unsetValue()
      {
        flagHasValue = false;
      }


    public override void write_as_json(JSONHandler handler)
      {
        switch (storeValue)
          {
            case TypeValue.Value_FrontLeft:
                handler.string_value("FrontLeft");
                break;
            case TypeValue.Value_FrontRight:
                handler.string_value("FrontRight");
                break;
            case TypeValue.Value_FrontDriver:
                handler.string_value("FrontDriver");
                break;
            case TypeValue.Value_FrontPassenger:
                handler.string_value("FrontPassenger");
                break;
            case TypeValue.Value_FrontCentre:
                handler.string_value("FrontCentre");
                break;
            case TypeValue.Value_FrontBoth:
                handler.string_value("FrontBoth");
                break;
            case TypeValue.Value_RearLeft:
                handler.string_value("RearLeft");
                break;
            case TypeValue.Value_RearRight:
                handler.string_value("RearRight");
                break;
            case TypeValue.Value_RearDriver:
                handler.string_value("RearDriver");
                break;
            case TypeValue.Value_RearPassenger:
                handler.string_value("RearPassenger");
                break;
            case TypeValue.Value_RearCentre:
                handler.string_value("RearCentre");
                break;
            case TypeValue.Value_RearBoth:
                handler.string_value("RearBoth");
                break;
            case TypeValue.Value_MiddleLeft:
                handler.string_value("MiddleLeft");
                break;
            case TypeValue.Value_MiddleRight:
                handler.string_value("MiddleRight");
                break;
            case TypeValue.Value_MiddleDriver:
                handler.string_value("MiddleDriver");
                break;
            case TypeValue.Value_MiddlePassenger:
                handler.string_value("MiddlePassenger");
                break;
            case TypeValue.Value_MiddleCentre:
                handler.string_value("MiddleCentre");
                break;
            case TypeValue.Value_MiddleBoth:
                handler.string_value("MiddleBoth");
                break;
            case TypeValue.Value_LeftAll:
                handler.string_value("LeftAll");
                break;
            case TypeValue.Value_RightAll:
                handler.string_value("RightAll");
                break;
            case TypeValue.Value_DriverAll:
                handler.string_value("DriverAll");
                break;
            case TypeValue.Value_PassengerAll:
                handler.string_value("PassengerAll");
                break;
            case TypeValue.Value_CentreAll:
                handler.string_value("CentreAll");
                break;
            case TypeValue.Value_All:
                handler.string_value("All");
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        switch (storeValue)
          {
            case TypeValue.Value_FrontLeft:
                handler.string_value("FrontLeft");
                break;
            case TypeValue.Value_FrontRight:
                handler.string_value("FrontRight");
                break;
            case TypeValue.Value_FrontDriver:
                handler.string_value("FrontDriver");
                break;
            case TypeValue.Value_FrontPassenger:
                handler.string_value("FrontPassenger");
                break;
            case TypeValue.Value_FrontCentre:
                handler.string_value("FrontCentre");
                break;
            case TypeValue.Value_FrontBoth:
                handler.string_value("FrontBoth");
                break;
            case TypeValue.Value_RearLeft:
                handler.string_value("RearLeft");
                break;
            case TypeValue.Value_RearRight:
                handler.string_value("RearRight");
                break;
            case TypeValue.Value_RearDriver:
                handler.string_value("RearDriver");
                break;
            case TypeValue.Value_RearPassenger:
                handler.string_value("RearPassenger");
                break;
            case TypeValue.Value_RearCentre:
                handler.string_value("RearCentre");
                break;
            case TypeValue.Value_RearBoth:
                handler.string_value("RearBoth");
                break;
            case TypeValue.Value_MiddleLeft:
                handler.string_value("MiddleLeft");
                break;
            case TypeValue.Value_MiddleRight:
                handler.string_value("MiddleRight");
                break;
            case TypeValue.Value_MiddleDriver:
                handler.string_value("MiddleDriver");
                break;
            case TypeValue.Value_MiddlePassenger:
                handler.string_value("MiddlePassenger");
                break;
            case TypeValue.Value_MiddleCentre:
                handler.string_value("MiddleCentre");
                break;
            case TypeValue.Value_MiddleBoth:
                handler.string_value("MiddleBoth");
                break;
            case TypeValue.Value_LeftAll:
                handler.string_value("LeftAll");
                break;
            case TypeValue.Value_RightAll:
                handler.string_value("RightAll");
                break;
            case TypeValue.Value_DriverAll:
                handler.string_value("DriverAll");
                break;
            case TypeValue.Value_PassengerAll:
                handler.string_value("PassengerAll");
                break;
            case TypeValue.Value_CentreAll:
                handler.string_value("CentreAll");
                break;
            case TypeValue.Value_All:
                handler.string_value("All");
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }

    public static CarSeatSelectionEnumJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarSeatSelectionEnumJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarSeatSelectionEnum", ignore_extras);
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
    public static CarSeatSelectionEnumJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CarSeatSelectionEnumJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarSeatSelectionEnumJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarSeatSelectionEnum", ignore_extras);
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
    public static CarSeatSelectionEnumJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CarSeatSelectionEnumJSON from_text(string text, bool ignore_extras)
      {
        CarSeatSelectionEnumJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarSeatSelectionEnum", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CarSeatSelectionEnumJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CarSeatSelectionEnumJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CarSeatSelectionEnumJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarSeatSelectionEnum", ignore_extras);
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
            handle_result(stringToValue(result));
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
            CarSeatSelectionEnumJSON result = new CarSeatSelectionEnumJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(CarSeatSelectionEnumJSON new_result);
        public Generator(bool ignore_extras) : base("Type CarSeatSelectionEnum")
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
        protected override void handle_result(CarSeatSelectionEnumJSON  result)
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
        public CarSeatSelectionEnumJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CarSeatSelectionEnumJSON  result)
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
    protected virtual void handle_result(List<CarSeatSelectionEnumJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CarSeatSelectionEnumJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CarSeatSelectionEnumJSON>();
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
    public List<CarSeatSelectionEnumJSON> value;
  };
  };
