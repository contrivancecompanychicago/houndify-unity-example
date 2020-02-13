/* file "MortgageCalculatorInputVariableCalculationTypeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MortgageCalculatorInputVariableCalculationTypeJSON : MortgageCalculatorInputVariableJSON
  {
    public enum TypeCalculationTypeKnownValues
      {
        CalculationType_Payment,
        CalculationType_TotalInterest,
        CalculationType_TotalPaid,
        CalculationType_InterestRate,
        CalculationType_DownPayment,
        CalculationType_AmortizationPeriod,
        CalculationType_PrincipalPaid,
        CalculationType_Principal,
        CalculationType_PrincipalOwing,
        CalculationType_HomeValue,
        CalculationType__none
      };
    public struct TypeCalculationType
      {
        public bool in_known_list;
        public string string_value;
        public TypeCalculationTypeKnownValues list_value;
      };

    public static TypeCalculationTypeKnownValues  stringToCalculationType(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "mortizationPeriod", 0, 17, false) == 0) && (chars.Length == 18))
                    return TypeCalculationTypeKnownValues.CalculationType_AmortizationPeriod;
                break;
            case 'D':
                if ((String.Compare(chars, 1, "ownPayment", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeCalculationTypeKnownValues.CalculationType_DownPayment;
                break;
            case 'H':
                if ((String.Compare(chars, 1, "omeValue", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeCalculationTypeKnownValues.CalculationType_HomeValue;
                break;
            case 'I':
                if ((String.Compare(chars, 1, "nterestRate", 0, 11, false) == 0) && (chars.Length == 12))
                    return TypeCalculationTypeKnownValues.CalculationType_InterestRate;
                break;
            case 'P':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "yment", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeCalculationTypeKnownValues.CalculationType_Payment;
                        break;
                    case 'r':
                        if (String.Compare(chars, 2, "incipal", 0, 7, false) == 0)
                          {
                            if (chars.Length == 9)
                              {
                                return TypeCalculationTypeKnownValues.CalculationType_Principal;
                              }
                            switch (chars[9])
                              {
                                case 'O':
                                    if ((String.Compare(chars, 10, "wing", 0, 4, false) == 0) && (chars.Length == 14))
                                        return TypeCalculationTypeKnownValues.CalculationType_PrincipalOwing;
                                    break;
                                case 'P':
                                    if ((String.Compare(chars, 10, "aid", 0, 3, false) == 0) && (chars.Length == 13))
                                        return TypeCalculationTypeKnownValues.CalculationType_PrincipalPaid;
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
                if (String.Compare(chars, 1, "otal", 0, 4, false) == 0)
                  {
                    switch (chars[5])
                      {
                        case 'I':
                            if ((String.Compare(chars, 6, "nterest", 0, 7, false) == 0) && (chars.Length == 13))
                                return TypeCalculationTypeKnownValues.CalculationType_TotalInterest;
                            break;
                        case 'P':
                            if ((String.Compare(chars, 6, "aid", 0, 3, false) == 0) && (chars.Length == 9))
                                return TypeCalculationTypeKnownValues.CalculationType_TotalPaid;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return TypeCalculationTypeKnownValues.CalculationType__none;
      }

    public static string  stringFromCalculationType(TypeCalculationTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeCalculationTypeKnownValues.CalculationType_Payment:
                return "Payment";
            case TypeCalculationTypeKnownValues.CalculationType_TotalInterest:
                return "TotalInterest";
            case TypeCalculationTypeKnownValues.CalculationType_TotalPaid:
                return "TotalPaid";
            case TypeCalculationTypeKnownValues.CalculationType_InterestRate:
                return "InterestRate";
            case TypeCalculationTypeKnownValues.CalculationType_DownPayment:
                return "DownPayment";
            case TypeCalculationTypeKnownValues.CalculationType_AmortizationPeriod:
                return "AmortizationPeriod";
            case TypeCalculationTypeKnownValues.CalculationType_PrincipalPaid:
                return "PrincipalPaid";
            case TypeCalculationTypeKnownValues.CalculationType_Principal:
                return "Principal";
            case TypeCalculationTypeKnownValues.CalculationType_PrincipalOwing:
                return "PrincipalOwing";
            case TypeCalculationTypeKnownValues.CalculationType_HomeValue:
                return "HomeValue";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeIntermediateCalculationTypeKnownValues
      {
        IntermediateCalculationType_InterestRate,
        IntermediateCalculationType_DownPayment,
        IntermediateCalculationType_AmortizationPeriod,
        IntermediateCalculationType_Principal,
        IntermediateCalculationType_HomeValue,
        IntermediateCalculationType__none
      };
    public struct TypeIntermediateCalculationType
      {
        public bool in_known_list;
        public string string_value;
        public TypeIntermediateCalculationTypeKnownValues list_value;
      };

    public static TypeIntermediateCalculationTypeKnownValues  stringToIntermediateCalculationType(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "mortizationPeriod", 0, 17, false) == 0) && (chars.Length == 18))
                    return TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_AmortizationPeriod;
                break;
            case 'D':
                if ((String.Compare(chars, 1, "ownPayment", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_DownPayment;
                break;
            case 'H':
                if ((String.Compare(chars, 1, "omeValue", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_HomeValue;
                break;
            case 'I':
                if ((String.Compare(chars, 1, "nterestRate", 0, 11, false) == 0) && (chars.Length == 12))
                    return TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_InterestRate;
                break;
            case 'P':
                if ((String.Compare(chars, 1, "rincipal", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_Principal;
                break;
            default:
                break;
          }
        return TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType__none;
      }

    public static string  stringFromIntermediateCalculationType(TypeIntermediateCalculationTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_InterestRate:
                return "InterestRate";
            case TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_DownPayment:
                return "DownPayment";
            case TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_AmortizationPeriod:
                return "AmortizationPeriod";
            case TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_Principal:
                return "Principal";
            case TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_HomeValue:
                return "HomeValue";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasCalculationType;
    private TypeCalculationType storeCalculationType;
    private bool flagHasIntermediateCalculationType;
    private TypeIntermediateCalculationType storeIntermediateCalculationType;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraCalculationTypeToJSON()
      {
        JSONStringValue generated_string_CalculationType;
        if (!(storeCalculationType.in_known_list))
          {
        generated_string_CalculationType = new JSONStringValue(storeCalculationType.string_value);
          }
        else
          {
        switch (storeCalculationType.list_value)
          {
            case TypeCalculationTypeKnownValues.CalculationType_Payment:
                generated_string_CalculationType = new JSONStringValue("Payment");
                break;
            case TypeCalculationTypeKnownValues.CalculationType_TotalInterest:
                generated_string_CalculationType = new JSONStringValue("TotalInterest");
                break;
            case TypeCalculationTypeKnownValues.CalculationType_TotalPaid:
                generated_string_CalculationType = new JSONStringValue("TotalPaid");
                break;
            case TypeCalculationTypeKnownValues.CalculationType_InterestRate:
                generated_string_CalculationType = new JSONStringValue("InterestRate");
                break;
            case TypeCalculationTypeKnownValues.CalculationType_DownPayment:
                generated_string_CalculationType = new JSONStringValue("DownPayment");
                break;
            case TypeCalculationTypeKnownValues.CalculationType_AmortizationPeriod:
                generated_string_CalculationType = new JSONStringValue("AmortizationPeriod");
                break;
            case TypeCalculationTypeKnownValues.CalculationType_PrincipalPaid:
                generated_string_CalculationType = new JSONStringValue("PrincipalPaid");
                break;
            case TypeCalculationTypeKnownValues.CalculationType_Principal:
                generated_string_CalculationType = new JSONStringValue("Principal");
                break;
            case TypeCalculationTypeKnownValues.CalculationType_PrincipalOwing:
                generated_string_CalculationType = new JSONStringValue("PrincipalOwing");
                break;
            case TypeCalculationTypeKnownValues.CalculationType_HomeValue:
                generated_string_CalculationType = new JSONStringValue("HomeValue");
                break;
            default:
                Debug.Assert(false);
                generated_string_CalculationType = null;
                break;
          }
          }
        return generated_string_CalculationType;
      }

    private JSONValue  extraIntermediateCalculationTypeToJSON()
      {
        JSONStringValue generated_string_IntermediateCalculationType;
        if (!(storeIntermediateCalculationType.in_known_list))
          {
        generated_string_IntermediateCalculationType = new JSONStringValue(storeIntermediateCalculationType.string_value);
          }
        else
          {
        switch (storeIntermediateCalculationType.list_value)
          {
            case TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_InterestRate:
                generated_string_IntermediateCalculationType = new JSONStringValue("InterestRate");
                break;
            case TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_DownPayment:
                generated_string_IntermediateCalculationType = new JSONStringValue("DownPayment");
                break;
            case TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_AmortizationPeriod:
                generated_string_IntermediateCalculationType = new JSONStringValue("AmortizationPeriod");
                break;
            case TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_Principal:
                generated_string_IntermediateCalculationType = new JSONStringValue("Principal");
                break;
            case TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_HomeValue:
                generated_string_IntermediateCalculationType = new JSONStringValue("HomeValue");
                break;
            default:
                Debug.Assert(false);
                generated_string_IntermediateCalculationType = null;
                break;
          }
          }
        return generated_string_IntermediateCalculationType;
      }


    private void  fromJSONCalculationType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CalculationType of MortgageCalculatorInputVariableCalculationTypeJSON is not a string.");
        TypeCalculationType the_open_enum = new TypeCalculationType();
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "mortizationPeriod", 0, 17, false) == 0) && (json_string.getData().Length == 18))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeCalculationTypeKnownValues.CalculationType_AmortizationPeriod;
                        goto open_enum_is_done;
                      }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "ownPayment", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeCalculationTypeKnownValues.CalculationType_DownPayment;
                        goto open_enum_is_done;
                      }
                break;
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "omeValue", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeCalculationTypeKnownValues.CalculationType_HomeValue;
                        goto open_enum_is_done;
                      }
                break;
            case 'I':
                if ((String.Compare(json_string.getData(), 1, "nterestRate", 0, 11, false) == 0) && (json_string.getData().Length == 12))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeCalculationTypeKnownValues.CalculationType_InterestRate;
                        goto open_enum_is_done;
                      }
                break;
            case 'P':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "yment", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeCalculationTypeKnownValues.CalculationType_Payment;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'r':
                        if (String.Compare(json_string.getData(), 2, "incipal", 0, 7, false) == 0)
                          {
                            if (json_string.getData().Length == 9)
                              {
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeCalculationTypeKnownValues.CalculationType_Principal;
                                    goto open_enum_is_done;
                                  }
                              }
                            switch (json_string.getData()[9])
                              {
                                case 'O':
                                    if ((String.Compare(json_string.getData(), 10, "wing", 0, 4, false) == 0) && (json_string.getData().Length == 14))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeCalculationTypeKnownValues.CalculationType_PrincipalOwing;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'P':
                                    if ((String.Compare(json_string.getData(), 10, "aid", 0, 3, false) == 0) && (json_string.getData().Length == 13))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeCalculationTypeKnownValues.CalculationType_PrincipalPaid;
                                            goto open_enum_is_done;
                                          }
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
                if (String.Compare(json_string.getData(), 1, "otal", 0, 4, false) == 0)
                  {
                    switch (json_string.getData()[5])
                      {
                        case 'I':
                            if ((String.Compare(json_string.getData(), 6, "nterest", 0, 7, false) == 0) && (json_string.getData().Length == 13))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeCalculationTypeKnownValues.CalculationType_TotalInterest;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'P':
                            if ((String.Compare(json_string.getData(), 6, "aid", 0, 3, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeCalculationTypeKnownValues.CalculationType_TotalPaid;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setCalculationType(the_open_enum);
      }


    private void  fromJSONIntermediateCalculationType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field IntermediateCalculationType of MortgageCalculatorInputVariableCalculationTypeJSON is not a string.");
        TypeIntermediateCalculationType the_open_enum = new TypeIntermediateCalculationType();
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "mortizationPeriod", 0, 17, false) == 0) && (json_string.getData().Length == 18))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_AmortizationPeriod;
                        goto open_enum_is_done;
                      }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "ownPayment", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_DownPayment;
                        goto open_enum_is_done;
                      }
                break;
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "omeValue", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_HomeValue;
                        goto open_enum_is_done;
                      }
                break;
            case 'I':
                if ((String.Compare(json_string.getData(), 1, "nterestRate", 0, 11, false) == 0) && (json_string.getData().Length == 12))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_InterestRate;
                        goto open_enum_is_done;
                      }
                break;
            case 'P':
                if ((String.Compare(json_string.getData(), 1, "rincipal", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_Principal;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setIntermediateCalculationType(the_open_enum);
      }


    public MortgageCalculatorInputVariableCalculationTypeJSON()
      {
        flagHasCalculationType = false;
        flagHasIntermediateCalculationType = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getInputVariableKind()
      {
        return "CalculationType";
      }

    public bool  hasCalculationType()
      {
        return flagHasCalculationType;
      }

    public TypeCalculationType  getCalculationType()
      {
        Debug.Assert(flagHasCalculationType);
        return storeCalculationType;
      }

    public string  getCalculationTypeAsString()
      {
        TypeCalculationType result = getCalculationType();
        if (result.in_known_list)
            return stringFromCalculationType(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasIntermediateCalculationType()
      {
        return flagHasIntermediateCalculationType;
      }

    public TypeIntermediateCalculationType  getIntermediateCalculationType()
      {
        Debug.Assert(flagHasIntermediateCalculationType);
        return storeIntermediateCalculationType;
      }

    public string  getIntermediateCalculationTypeAsString()
      {
        TypeIntermediateCalculationType result = getIntermediateCalculationType();
        if (result.in_known_list)
            return stringFromIntermediateCalculationType(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraMortgageCalculatorInputVariableCalculationTypeComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMortgageCalculatorInputVariableCalculationTypeComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMortgageCalculatorInputVariableCalculationTypeComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMortgageCalculatorInputVariableCalculationTypeLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraMortgageCalculatorInputVariableComponentCount()
      {
        int result = 0;
        if (flagHasCalculationType)
            ++result;
        if (flagHasIntermediateCalculationType)
            ++result;
        result += extraMortgageCalculatorInputVariableCalculationTypeComponentCount();
        return result;
      }
    public override string extraMortgageCalculatorInputVariableComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasCalculationType)
          {
            if (remainder == 0)
                return "CalculationType";
            --remainder;
          }
        if (flagHasIntermediateCalculationType)
          {
            if (remainder == 0)
                return "IntermediateCalculationType";
            --remainder;
          }
        return extraMortgageCalculatorInputVariableCalculationTypeComponentKey(remainder);
      }
    public override JSONValue extraMortgageCalculatorInputVariableComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasCalculationType)
          {
            if (remainder == 0)
                return extraCalculationTypeToJSON();
            --remainder;
          }
        if (flagHasIntermediateCalculationType)
          {
            if (remainder == 0)
                return extraIntermediateCalculationTypeToJSON();
            --remainder;
          }
        return extraMortgageCalculatorInputVariableCalculationTypeComponentValue(remainder);
      }
    public override JSONValue extraMortgageCalculatorInputVariableLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "alculationType", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasCalculationType ? extraCalculationTypeToJSON() : null);
                break;
            case 'I':
                if ((String.Compare(field_name, 1, "ntermediateCalculationType", 0, 26, false) == 0) && (field_name.Length == 27))
                    return (flagHasIntermediateCalculationType ? extraIntermediateCalculationTypeToJSON() : null);
                break;
            default:
                break;
          }
        return extraMortgageCalculatorInputVariableCalculationTypeLookup(field_name);
      }

    public void setCalculationType(TypeCalculationType new_value)
      {
        flagHasCalculationType = true;
        storeCalculationType = new_value;
      }
    public void setCalculationType(string chars)
      {
        TypeCalculationTypeKnownValues known = stringToCalculationType(chars);
        TypeCalculationType new_value = new TypeCalculationType();
        if (known == TypeCalculationTypeKnownValues.CalculationType__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setCalculationType(new_value);
      }
    public void setCalculationType(TypeCalculationTypeKnownValues new_value)
      {
        TypeCalculationType new_full_value = new TypeCalculationType();
        Debug.Assert(new_value != TypeCalculationTypeKnownValues.CalculationType__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setCalculationType(new_full_value);
      }
    public void unsetCalculationType()
      {
        flagHasCalculationType = false;
      }
    public void setIntermediateCalculationType(TypeIntermediateCalculationType new_value)
      {
        flagHasIntermediateCalculationType = true;
        storeIntermediateCalculationType = new_value;
      }
    public void setIntermediateCalculationType(string chars)
      {
        TypeIntermediateCalculationTypeKnownValues known = stringToIntermediateCalculationType(chars);
        TypeIntermediateCalculationType new_value = new TypeIntermediateCalculationType();
        if (known == TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setIntermediateCalculationType(new_value);
      }
    public void setIntermediateCalculationType(TypeIntermediateCalculationTypeKnownValues new_value)
      {
        TypeIntermediateCalculationType new_full_value = new TypeIntermediateCalculationType();
        Debug.Assert(new_value != TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setIntermediateCalculationType(new_full_value);
      }
    public void unsetIntermediateCalculationType()
      {
        flagHasIntermediateCalculationType = false;
      }

    public virtual void extraMortgageCalculatorInputVariableCalculationTypeAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMortgageCalculatorInputVariableCalculationTypeSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMortgageCalculatorInputVariableCalculationTypeLookup(key);
        if (old_field == null)
          {
            extraMortgageCalculatorInputVariableCalculationTypeAppendPair(key, new_component);
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
    public override void extraMortgageCalculatorInputVariableAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "alculationType", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONCalculationType(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if ((String.Compare(key, 1, "ntermediateCalculationType", 0, 26, false) == 0) && (key.Length == 27))
                    {
                    fromJSONIntermediateCalculationType(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraMortgageCalculatorInputVariableCalculationTypeAppendPair(key, new_component);
      }
    public override void extraMortgageCalculatorInputVariableSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "alculationType", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONCalculationType(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if ((String.Compare(key, 1, "ntermediateCalculationType", 0, 26, false) == 0) && (key.Length == 27))
                    {
                    fromJSONIntermediateCalculationType(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraMortgageCalculatorInputVariableCalculationTypeSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasCalculationType);
        if (flagHasCalculationType)
          {
            handler.start_pair("CalculationType");
            if (storeCalculationType.in_known_list)
              {
                switch (storeCalculationType.list_value)
                  {
                    case TypeCalculationTypeKnownValues.CalculationType_Payment:
                        handler.string_value("Payment");
                        break;
                    case TypeCalculationTypeKnownValues.CalculationType_TotalInterest:
                        handler.string_value("TotalInterest");
                        break;
                    case TypeCalculationTypeKnownValues.CalculationType_TotalPaid:
                        handler.string_value("TotalPaid");
                        break;
                    case TypeCalculationTypeKnownValues.CalculationType_InterestRate:
                        handler.string_value("InterestRate");
                        break;
                    case TypeCalculationTypeKnownValues.CalculationType_DownPayment:
                        handler.string_value("DownPayment");
                        break;
                    case TypeCalculationTypeKnownValues.CalculationType_AmortizationPeriod:
                        handler.string_value("AmortizationPeriod");
                        break;
                    case TypeCalculationTypeKnownValues.CalculationType_PrincipalPaid:
                        handler.string_value("PrincipalPaid");
                        break;
                    case TypeCalculationTypeKnownValues.CalculationType_Principal:
                        handler.string_value("Principal");
                        break;
                    case TypeCalculationTypeKnownValues.CalculationType_PrincipalOwing:
                        handler.string_value("PrincipalOwing");
                        break;
                    case TypeCalculationTypeKnownValues.CalculationType_HomeValue:
                        handler.string_value("HomeValue");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeCalculationType.string_value);
              }
          }
        if (flagHasIntermediateCalculationType)
          {
            handler.start_pair("IntermediateCalculationType");
            if (storeIntermediateCalculationType.in_known_list)
              {
                switch (storeIntermediateCalculationType.list_value)
                  {
                    case TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_InterestRate:
                        handler.string_value("InterestRate");
                        break;
                    case TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_DownPayment:
                        handler.string_value("DownPayment");
                        break;
                    case TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_AmortizationPeriod:
                        handler.string_value("AmortizationPeriod");
                        break;
                    case TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_Principal:
                        handler.string_value("Principal");
                        break;
                    case TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_HomeValue:
                        handler.string_value("HomeValue");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeIntermediateCalculationType.string_value);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasCalculationType()))
          {
            return "When parsing the object for %what%, the \"CalculationType\" field was missing.";
          }
        return null;
      }

    public static new MortgageCalculatorInputVariableCalculationTypeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MortgageCalculatorInputVariableCalculationTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariableCalculationType", ignore_extras);
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
    public static new MortgageCalculatorInputVariableCalculationTypeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MortgageCalculatorInputVariableCalculationTypeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MortgageCalculatorInputVariableCalculationTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariableCalculationType", ignore_extras);
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
    public static new MortgageCalculatorInputVariableCalculationTypeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MortgageCalculatorInputVariableCalculationTypeJSON from_text(string text, bool ignore_extras)
      {
        MortgageCalculatorInputVariableCalculationTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariableCalculationType", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MortgageCalculatorInputVariableCalculationTypeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MortgageCalculatorInputVariableCalculationTypeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MortgageCalculatorInputVariableCalculationTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariableCalculationType", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : MortgageCalculatorInputVariableJSON.Generator
      {
    private abstract class FieldGeneratorCalculationType : JSONStringGenerator
          {
            protected FieldGeneratorCalculationType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorCalculationType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeCalculationTypeKnownValues known = stringToCalculationType(result);
                TypeCalculationType new_value = new TypeCalculationType();
                if (known == TypeCalculationTypeKnownValues.CalculationType__none)
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
            protected abstract void handle_result(TypeCalculationType result);
          };
    private class FieldHoldingGeneratorCalculationType : FieldGeneratorCalculationType
  {
    protected override void handle_result(TypeCalculationType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorCalculationType(String what)
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
    public TypeCalculationType value;
  };
    private class FieldHoldingArrayGeneratorCalculationType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorCalculationType
      {
        private FieldHoldingArrayGeneratorCalculationType top;

        protected override void handle_result(TypeCalculationType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorCalculationType init_top)
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
    protected virtual void handle_result(List<TypeCalculationType> result)
      {
      }

    public FieldHoldingArrayGeneratorCalculationType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCalculationType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorCalculationType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCalculationType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeCalculationType> value;
  };
        private FieldHoldingGeneratorCalculationType fieldGeneratorCalculationType;
    private abstract class FieldGeneratorIntermediateCalculationType : JSONStringGenerator
          {
            protected FieldGeneratorIntermediateCalculationType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorIntermediateCalculationType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeIntermediateCalculationTypeKnownValues known = stringToIntermediateCalculationType(result);
                TypeIntermediateCalculationType new_value = new TypeIntermediateCalculationType();
                if (known == TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType__none)
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
            protected abstract void handle_result(TypeIntermediateCalculationType result);
          };
    private class FieldHoldingGeneratorIntermediateCalculationType : FieldGeneratorIntermediateCalculationType
  {
    protected override void handle_result(TypeIntermediateCalculationType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorIntermediateCalculationType(String what)
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
    public TypeIntermediateCalculationType value;
  };
    private class FieldHoldingArrayGeneratorIntermediateCalculationType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorIntermediateCalculationType
      {
        private FieldHoldingArrayGeneratorIntermediateCalculationType top;

        protected override void handle_result(TypeIntermediateCalculationType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorIntermediateCalculationType init_top)
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
    protected virtual void handle_result(List<TypeIntermediateCalculationType> result)
      {
      }

    public FieldHoldingArrayGeneratorIntermediateCalculationType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeIntermediateCalculationType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorIntermediateCalculationType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeIntermediateCalculationType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeIntermediateCalculationType> value;
  };
        private FieldHoldingGeneratorIntermediateCalculationType fieldGeneratorIntermediateCalculationType;
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
            if (!(getMortgageCalculatorInputVariableJSONKey().Equals("CalculationType")))
                throw new Exception("The key field has a value other than `CalculationType'.");
            MortgageCalculatorInputVariableCalculationTypeJSON result = new MortgageCalculatorInputVariableCalculationTypeJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMortgageCalculatorInputVariableCalculationTypeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(MortgageCalculatorInputVariableJSON new_result)
          {
            handle_result((MortgageCalculatorInputVariableCalculationTypeJSON )new_result);
          }
        protected void finish(MortgageCalculatorInputVariableCalculationTypeJSON result)
          {
            if (fieldGeneratorCalculationType.have_value)
              {
                result.setCalculationType(fieldGeneratorCalculationType.value);
                fieldGeneratorCalculationType.have_value = false;
              }
            else if ((!(result.hasCalculationType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CalculationType\" field was missing.");
              }
            if (fieldGeneratorIntermediateCalculationType.have_value)
              {
                result.setIntermediateCalculationType(fieldGeneratorIntermediateCalculationType.value);
                fieldGeneratorIntermediateCalculationType.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(MortgageCalculatorInputVariableCalculationTypeJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "alculationType", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorCalculationType;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "ntermediateCalculationType", 0, 26, false) == 0) && (field_name.Length == 27))
                        return fieldGeneratorIntermediateCalculationType;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorCalculationType = new FieldHoldingGeneratorCalculationType("field \"CalculationType\" of the MortgageCalculatorInputVariableCalculationType class");
            fieldGeneratorIntermediateCalculationType = new FieldHoldingGeneratorIntermediateCalculationType("field \"IntermediateCalculationType\" of the MortgageCalculatorInputVariableCalculationType class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MortgageCalculatorInputVariableCalculationType class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorCalculationType = new FieldHoldingGeneratorCalculationType("field \"CalculationType\" of the MortgageCalculatorInputVariableCalculationType class");
            fieldGeneratorIntermediateCalculationType = new FieldHoldingGeneratorIntermediateCalculationType("field \"IntermediateCalculationType\" of the MortgageCalculatorInputVariableCalculationType class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MortgageCalculatorInputVariableCalculationType class");
          }

        public override void reset()
          {
            fieldGeneratorCalculationType.reset();
            fieldGeneratorIntermediateCalculationType.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MortgageCalculatorInputVariableCalculationTypeJSON  result)
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
        public MortgageCalculatorInputVariableCalculationTypeJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MortgageCalculatorInputVariableCalculationTypeJSON  result)
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
    protected virtual void handle_result(List<MortgageCalculatorInputVariableCalculationTypeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MortgageCalculatorInputVariableCalculationTypeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MortgageCalculatorInputVariableCalculationTypeJSON>();
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
    public List<MortgageCalculatorInputVariableCalculationTypeJSON> value;
  };
  };
