/* file "MortgageCalculatorQueryStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MortgageCalculatorQueryStateJSON : JSONBase
  {
    public enum TypeRequestTypeKnownValues
      {
        RequestType_AskPrincipal,
        RequestType_AskInterestRate,
        RequestType_AskAmortization,
        RequestType_AskHomeValue,
        RequestType_AskDownPayment,
        RequestType_AskMonthlyPayment,
        RequestType_AskYearRange,
        RequestType_AskYearOwing,
        RequestType_AskPrincipalOrHomeValue,
        RequestType_ShowPayment,
        RequestType_ShowTotalInterest,
        RequestType_ShowTotalPaid,
        RequestType_ShowDownPayment,
        RequestType_ShowInterestRate,
        RequestType_ShowAmortization,
        RequestType_ShowPrincipalPaid,
        RequestType_ShowPrincipal,
        RequestType_ShowPrincipalOwing,
        RequestType_ShowHomeValue,
        RequestType__none
      };
    public struct TypeRequestType
      {
        public bool in_known_list;
        public string string_value;
        public TypeRequestTypeKnownValues list_value;
      };

    public static TypeRequestTypeKnownValues  stringToRequestType(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if (String.Compare(chars, 1, "sk", 0, 2, false) == 0)
                  {
                    switch (chars[3])
                      {
                        case 'A':
                            if ((String.Compare(chars, 4, "mortization", 0, 11, false) == 0) && (chars.Length == 15))
                                return TypeRequestTypeKnownValues.RequestType_AskAmortization;
                            break;
                        case 'D':
                            if ((String.Compare(chars, 4, "ownPayment", 0, 10, false) == 0) && (chars.Length == 14))
                                return TypeRequestTypeKnownValues.RequestType_AskDownPayment;
                            break;
                        case 'H':
                            if ((String.Compare(chars, 4, "omeValue", 0, 8, false) == 0) && (chars.Length == 12))
                                return TypeRequestTypeKnownValues.RequestType_AskHomeValue;
                            break;
                        case 'I':
                            if ((String.Compare(chars, 4, "nterestRate", 0, 11, false) == 0) && (chars.Length == 15))
                                return TypeRequestTypeKnownValues.RequestType_AskInterestRate;
                            break;
                        case 'M':
                            if ((String.Compare(chars, 4, "onthlyPayment", 0, 13, false) == 0) && (chars.Length == 17))
                                return TypeRequestTypeKnownValues.RequestType_AskMonthlyPayment;
                            break;
                        case 'P':
                            if (String.Compare(chars, 4, "rincipal", 0, 8, false) == 0)
                              {
                                if (chars.Length == 12)
                                  {
                                    return TypeRequestTypeKnownValues.RequestType_AskPrincipal;
                                  }
                                switch (chars[12])
                                  {
                                    case 'O':
                                        if ((String.Compare(chars, 13, "rHomeValue", 0, 10, false) == 0) && (chars.Length == 23))
                                            return TypeRequestTypeKnownValues.RequestType_AskPrincipalOrHomeValue;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'Y':
                            if (String.Compare(chars, 4, "ear", 0, 3, false) == 0)
                              {
                                switch (chars[7])
                                  {
                                    case 'O':
                                        if ((String.Compare(chars, 8, "wing", 0, 4, false) == 0) && (chars.Length == 12))
                                            return TypeRequestTypeKnownValues.RequestType_AskYearOwing;
                                        break;
                                    case 'R':
                                        if ((String.Compare(chars, 8, "ange", 0, 4, false) == 0) && (chars.Length == 12))
                                            return TypeRequestTypeKnownValues.RequestType_AskYearRange;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if (String.Compare(chars, 1, "how", 0, 3, false) == 0)
                  {
                    switch (chars[4])
                      {
                        case 'A':
                            if ((String.Compare(chars, 5, "mortization", 0, 11, false) == 0) && (chars.Length == 16))
                                return TypeRequestTypeKnownValues.RequestType_ShowAmortization;
                            break;
                        case 'D':
                            if ((String.Compare(chars, 5, "ownPayment", 0, 10, false) == 0) && (chars.Length == 15))
                                return TypeRequestTypeKnownValues.RequestType_ShowDownPayment;
                            break;
                        case 'H':
                            if ((String.Compare(chars, 5, "omeValue", 0, 8, false) == 0) && (chars.Length == 13))
                                return TypeRequestTypeKnownValues.RequestType_ShowHomeValue;
                            break;
                        case 'I':
                            if ((String.Compare(chars, 5, "nterestRate", 0, 11, false) == 0) && (chars.Length == 16))
                                return TypeRequestTypeKnownValues.RequestType_ShowInterestRate;
                            break;
                        case 'P':
                            switch (chars[5])
                              {
                                case 'a':
                                    if ((String.Compare(chars, 6, "yment", 0, 5, false) == 0) && (chars.Length == 11))
                                        return TypeRequestTypeKnownValues.RequestType_ShowPayment;
                                    break;
                                case 'r':
                                    if (String.Compare(chars, 6, "incipal", 0, 7, false) == 0)
                                      {
                                        if (chars.Length == 13)
                                          {
                                            return TypeRequestTypeKnownValues.RequestType_ShowPrincipal;
                                          }
                                        switch (chars[13])
                                          {
                                            case 'O':
                                                if ((String.Compare(chars, 14, "wing", 0, 4, false) == 0) && (chars.Length == 18))
                                                    return TypeRequestTypeKnownValues.RequestType_ShowPrincipalOwing;
                                                break;
                                            case 'P':
                                                if ((String.Compare(chars, 14, "aid", 0, 3, false) == 0) && (chars.Length == 17))
                                                    return TypeRequestTypeKnownValues.RequestType_ShowPrincipalPaid;
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
                            if (String.Compare(chars, 5, "otal", 0, 4, false) == 0)
                              {
                                switch (chars[9])
                                  {
                                    case 'I':
                                        if ((String.Compare(chars, 10, "nterest", 0, 7, false) == 0) && (chars.Length == 17))
                                            return TypeRequestTypeKnownValues.RequestType_ShowTotalInterest;
                                        break;
                                    case 'P':
                                        if ((String.Compare(chars, 10, "aid", 0, 3, false) == 0) && (chars.Length == 13))
                                            return TypeRequestTypeKnownValues.RequestType_ShowTotalPaid;
                                        break;
                                    default:
                                        break;
                                  }
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
        return TypeRequestTypeKnownValues.RequestType__none;
      }

    public static string  stringFromRequestType(TypeRequestTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeRequestTypeKnownValues.RequestType_AskPrincipal:
                return "AskPrincipal";
            case TypeRequestTypeKnownValues.RequestType_AskInterestRate:
                return "AskInterestRate";
            case TypeRequestTypeKnownValues.RequestType_AskAmortization:
                return "AskAmortization";
            case TypeRequestTypeKnownValues.RequestType_AskHomeValue:
                return "AskHomeValue";
            case TypeRequestTypeKnownValues.RequestType_AskDownPayment:
                return "AskDownPayment";
            case TypeRequestTypeKnownValues.RequestType_AskMonthlyPayment:
                return "AskMonthlyPayment";
            case TypeRequestTypeKnownValues.RequestType_AskYearRange:
                return "AskYearRange";
            case TypeRequestTypeKnownValues.RequestType_AskYearOwing:
                return "AskYearOwing";
            case TypeRequestTypeKnownValues.RequestType_AskPrincipalOrHomeValue:
                return "AskPrincipalOrHomeValue";
            case TypeRequestTypeKnownValues.RequestType_ShowPayment:
                return "ShowPayment";
            case TypeRequestTypeKnownValues.RequestType_ShowTotalInterest:
                return "ShowTotalInterest";
            case TypeRequestTypeKnownValues.RequestType_ShowTotalPaid:
                return "ShowTotalPaid";
            case TypeRequestTypeKnownValues.RequestType_ShowDownPayment:
                return "ShowDownPayment";
            case TypeRequestTypeKnownValues.RequestType_ShowInterestRate:
                return "ShowInterestRate";
            case TypeRequestTypeKnownValues.RequestType_ShowAmortization:
                return "ShowAmortization";
            case TypeRequestTypeKnownValues.RequestType_ShowPrincipalPaid:
                return "ShowPrincipalPaid";
            case TypeRequestTypeKnownValues.RequestType_ShowPrincipal:
                return "ShowPrincipal";
            case TypeRequestTypeKnownValues.RequestType_ShowPrincipalOwing:
                return "ShowPrincipalOwing";
            case TypeRequestTypeKnownValues.RequestType_ShowHomeValue:
                return "ShowHomeValue";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasInputVariableSets;
    private List< List< MortgageCalculatorInputVariableJSON  > > storeInputVariableSets;
    private bool flagHasRequestType;
    private TypeRequestType storeRequestType;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONInputVariableSets(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field InputVariableSets of MortgageCalculatorQueryStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< List< MortgageCalculatorInputVariableJSON  > > vector_InputVariableSets1 = new List< List< MortgageCalculatorInputVariableJSON  > >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONArrayValue json_array2 = json_array1.component(num1).array_value();
            if (json_array2 == null)
                throw new Exception("The value for an element of field InputVariableSets of MortgageCalculatorQueryStateJSON is not an array.");
            int count2 = json_array2.componentCount();
            List< MortgageCalculatorInputVariableJSON  > vector_InputVariableSets2 = new List< MortgageCalculatorInputVariableJSON  >(count2);
            for (int num2 = 0; num2 < count2; ++num2)
              {
                MortgageCalculatorInputVariableJSON convert_classy = MortgageCalculatorInputVariableJSON.from_json(json_array2.component(num2), ignore_extras, true);
                vector_InputVariableSets2.Add(convert_classy);
              }
            vector_InputVariableSets1.Add(vector_InputVariableSets2);
          }
        initInputVariableSets();
        for (int num1 = 0; num1 < vector_InputVariableSets1.Count; ++num1)
            appendInputVariableSets(vector_InputVariableSets1[num1]);
        for (int num1 = 0; num1 < vector_InputVariableSets1.Count; ++num1)
          {
            for (int num2 = 0; num2 < vector_InputVariableSets1[num1].Count; ++num2)
              {
              }
          }
      }


    private void  fromJSONRequestType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field RequestType of MortgageCalculatorQueryStateJSON is not a string.");
        TypeRequestType the_open_enum = new TypeRequestType();
        switch (json_string.getData()[0])
          {
            case 'A':
                if (String.Compare(json_string.getData(), 1, "sk", 0, 2, false) == 0)
                  {
                    switch (json_string.getData()[3])
                      {
                        case 'A':
                            if ((String.Compare(json_string.getData(), 4, "mortization", 0, 11, false) == 0) && (json_string.getData().Length == 15))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeRequestTypeKnownValues.RequestType_AskAmortization;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'D':
                            if ((String.Compare(json_string.getData(), 4, "ownPayment", 0, 10, false) == 0) && (json_string.getData().Length == 14))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeRequestTypeKnownValues.RequestType_AskDownPayment;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'H':
                            if ((String.Compare(json_string.getData(), 4, "omeValue", 0, 8, false) == 0) && (json_string.getData().Length == 12))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeRequestTypeKnownValues.RequestType_AskHomeValue;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'I':
                            if ((String.Compare(json_string.getData(), 4, "nterestRate", 0, 11, false) == 0) && (json_string.getData().Length == 15))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeRequestTypeKnownValues.RequestType_AskInterestRate;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'M':
                            if ((String.Compare(json_string.getData(), 4, "onthlyPayment", 0, 13, false) == 0) && (json_string.getData().Length == 17))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeRequestTypeKnownValues.RequestType_AskMonthlyPayment;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'P':
                            if (String.Compare(json_string.getData(), 4, "rincipal", 0, 8, false) == 0)
                              {
                                if (json_string.getData().Length == 12)
                                  {
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeRequestTypeKnownValues.RequestType_AskPrincipal;
                                        goto open_enum_is_done;
                                      }
                                  }
                                switch (json_string.getData()[12])
                                  {
                                    case 'O':
                                        if ((String.Compare(json_string.getData(), 13, "rHomeValue", 0, 10, false) == 0) && (json_string.getData().Length == 23))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeRequestTypeKnownValues.RequestType_AskPrincipalOrHomeValue;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'Y':
                            if (String.Compare(json_string.getData(), 4, "ear", 0, 3, false) == 0)
                              {
                                switch (json_string.getData()[7])
                                  {
                                    case 'O':
                                        if ((String.Compare(json_string.getData(), 8, "wing", 0, 4, false) == 0) && (json_string.getData().Length == 12))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeRequestTypeKnownValues.RequestType_AskYearOwing;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'R':
                                        if ((String.Compare(json_string.getData(), 8, "ange", 0, 4, false) == 0) && (json_string.getData().Length == 12))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeRequestTypeKnownValues.RequestType_AskYearRange;
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
                  }
                break;
            case 'S':
                if (String.Compare(json_string.getData(), 1, "how", 0, 3, false) == 0)
                  {
                    switch (json_string.getData()[4])
                      {
                        case 'A':
                            if ((String.Compare(json_string.getData(), 5, "mortization", 0, 11, false) == 0) && (json_string.getData().Length == 16))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeRequestTypeKnownValues.RequestType_ShowAmortization;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'D':
                            if ((String.Compare(json_string.getData(), 5, "ownPayment", 0, 10, false) == 0) && (json_string.getData().Length == 15))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeRequestTypeKnownValues.RequestType_ShowDownPayment;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'H':
                            if ((String.Compare(json_string.getData(), 5, "omeValue", 0, 8, false) == 0) && (json_string.getData().Length == 13))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeRequestTypeKnownValues.RequestType_ShowHomeValue;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'I':
                            if ((String.Compare(json_string.getData(), 5, "nterestRate", 0, 11, false) == 0) && (json_string.getData().Length == 16))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeRequestTypeKnownValues.RequestType_ShowInterestRate;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'P':
                            switch (json_string.getData()[5])
                              {
                                case 'a':
                                    if ((String.Compare(json_string.getData(), 6, "yment", 0, 5, false) == 0) && (json_string.getData().Length == 11))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeRequestTypeKnownValues.RequestType_ShowPayment;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'r':
                                    if (String.Compare(json_string.getData(), 6, "incipal", 0, 7, false) == 0)
                                      {
                                        if (json_string.getData().Length == 13)
                                          {
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeRequestTypeKnownValues.RequestType_ShowPrincipal;
                                                goto open_enum_is_done;
                                              }
                                          }
                                        switch (json_string.getData()[13])
                                          {
                                            case 'O':
                                                if ((String.Compare(json_string.getData(), 14, "wing", 0, 4, false) == 0) && (json_string.getData().Length == 18))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeRequestTypeKnownValues.RequestType_ShowPrincipalOwing;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'P':
                                                if ((String.Compare(json_string.getData(), 14, "aid", 0, 3, false) == 0) && (json_string.getData().Length == 17))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeRequestTypeKnownValues.RequestType_ShowPrincipalPaid;
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
                            if (String.Compare(json_string.getData(), 5, "otal", 0, 4, false) == 0)
                              {
                                switch (json_string.getData()[9])
                                  {
                                    case 'I':
                                        if ((String.Compare(json_string.getData(), 10, "nterest", 0, 7, false) == 0) && (json_string.getData().Length == 17))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeRequestTypeKnownValues.RequestType_ShowTotalInterest;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'P':
                                        if ((String.Compare(json_string.getData(), 10, "aid", 0, 3, false) == 0) && (json_string.getData().Length == 13))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeRequestTypeKnownValues.RequestType_ShowTotalPaid;
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
                  }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setRequestType(the_open_enum);
      }


    public MortgageCalculatorQueryStateJSON()
      {
        flagHasInputVariableSets = false;
        flagHasRequestType = false;
        storeInputVariableSets = new List< List< MortgageCalculatorInputVariableJSON  > >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasInputVariableSets()
      {
        return flagHasInputVariableSets;
      }

    public int  countOfInputVariableSets()
      {
        Debug.Assert(flagHasInputVariableSets);
        return storeInputVariableSets.Count;
      }

    public List< MortgageCalculatorInputVariableJSON  >  elementOfInputVariableSets(int element_num)
      {
        Debug.Assert(flagHasInputVariableSets);
        return storeInputVariableSets[element_num];
      }

    public List< List< MortgageCalculatorInputVariableJSON  > >  getInputVariableSets()
      {
        Debug.Assert(flagHasInputVariableSets);
        return storeInputVariableSets;
      }

    public bool  hasRequestType()
      {
        return flagHasRequestType;
      }

    public TypeRequestType  getRequestType()
      {
        Debug.Assert(flagHasRequestType);
        return storeRequestType;
      }

    public string  getRequestTypeAsString()
      {
        TypeRequestType result = getRequestType();
        if (result.in_known_list)
            return stringFromRequestType(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraMortgageCalculatorQueryStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMortgageCalculatorQueryStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMortgageCalculatorQueryStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMortgageCalculatorQueryStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initInputVariableSets()
      {
        if (flagHasInputVariableSets)
          {
            for (int num1 = 0; num1 < storeInputVariableSets.Count; ++num1)
              {
                for (int num2 = 0; num2 < storeInputVariableSets[num1].Count; ++num2)
                  {
                  }
              }
          }
        flagHasInputVariableSets = true;
        storeInputVariableSets.Clear();
      }
    public void appendInputVariableSets(List< MortgageCalculatorInputVariableJSON  > to_append)
      {
        if (!flagHasInputVariableSets)
          {
            flagHasInputVariableSets = true;
            storeInputVariableSets.Clear();
          }
        Debug.Assert(flagHasInputVariableSets);
        for (int num1 = 0; num1 < to_append.Count; ++num1)
          {
          }
        storeInputVariableSets.Add(to_append);
      }
    public void unsetInputVariableSets()
      {
        if (flagHasInputVariableSets)
          {
            for (int num3 = 0; num3 < storeInputVariableSets.Count; ++num3)
              {
                for (int num4 = 0; num4 < storeInputVariableSets[num3].Count; ++num4)
                  {
                  }
              }
          }
        flagHasInputVariableSets = false;
        storeInputVariableSets.Clear();
      }
    public void setRequestType(TypeRequestType new_value)
      {
        flagHasRequestType = true;
        storeRequestType = new_value;
      }
    public void setRequestType(string chars)
      {
        TypeRequestTypeKnownValues known = stringToRequestType(chars);
        TypeRequestType new_value = new TypeRequestType();
        if (known == TypeRequestTypeKnownValues.RequestType__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setRequestType(new_value);
      }
    public void setRequestType(TypeRequestTypeKnownValues new_value)
      {
        TypeRequestType new_full_value = new TypeRequestType();
        Debug.Assert(new_value != TypeRequestTypeKnownValues.RequestType__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setRequestType(new_full_value);
      }
    public void unsetRequestType()
      {
        flagHasRequestType = false;
      }

    public virtual void extraMortgageCalculatorQueryStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMortgageCalculatorQueryStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMortgageCalculatorQueryStateLookup(key);
        if (old_field == null)
          {
            extraMortgageCalculatorQueryStateAppendPair(key, new_component);
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
        if (flagHasInputVariableSets)
          {
            handler.start_pair("InputVariableSets");
            handler.start_array();
            for (int num1 = 0; num1 < storeInputVariableSets.Count; ++num1)
              {
                handler.start_array();
                for (int num2 = 0; num2 < storeInputVariableSets[num1].Count; ++num2)
                  {
                    if (partial_allowed)
                        storeInputVariableSets[num1][num2].write_partial_as_json(handler);
                    else
                        storeInputVariableSets[num1][num2].write_as_json(handler);
                  }
                handler.finish_array();
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasRequestType);
        if (flagHasRequestType)
          {
            handler.start_pair("RequestType");
            if (storeRequestType.in_known_list)
              {
                switch (storeRequestType.list_value)
                  {
                    case TypeRequestTypeKnownValues.RequestType_AskPrincipal:
                        handler.string_value("AskPrincipal");
                        break;
                    case TypeRequestTypeKnownValues.RequestType_AskInterestRate:
                        handler.string_value("AskInterestRate");
                        break;
                    case TypeRequestTypeKnownValues.RequestType_AskAmortization:
                        handler.string_value("AskAmortization");
                        break;
                    case TypeRequestTypeKnownValues.RequestType_AskHomeValue:
                        handler.string_value("AskHomeValue");
                        break;
                    case TypeRequestTypeKnownValues.RequestType_AskDownPayment:
                        handler.string_value("AskDownPayment");
                        break;
                    case TypeRequestTypeKnownValues.RequestType_AskMonthlyPayment:
                        handler.string_value("AskMonthlyPayment");
                        break;
                    case TypeRequestTypeKnownValues.RequestType_AskYearRange:
                        handler.string_value("AskYearRange");
                        break;
                    case TypeRequestTypeKnownValues.RequestType_AskYearOwing:
                        handler.string_value("AskYearOwing");
                        break;
                    case TypeRequestTypeKnownValues.RequestType_AskPrincipalOrHomeValue:
                        handler.string_value("AskPrincipalOrHomeValue");
                        break;
                    case TypeRequestTypeKnownValues.RequestType_ShowPayment:
                        handler.string_value("ShowPayment");
                        break;
                    case TypeRequestTypeKnownValues.RequestType_ShowTotalInterest:
                        handler.string_value("ShowTotalInterest");
                        break;
                    case TypeRequestTypeKnownValues.RequestType_ShowTotalPaid:
                        handler.string_value("ShowTotalPaid");
                        break;
                    case TypeRequestTypeKnownValues.RequestType_ShowDownPayment:
                        handler.string_value("ShowDownPayment");
                        break;
                    case TypeRequestTypeKnownValues.RequestType_ShowInterestRate:
                        handler.string_value("ShowInterestRate");
                        break;
                    case TypeRequestTypeKnownValues.RequestType_ShowAmortization:
                        handler.string_value("ShowAmortization");
                        break;
                    case TypeRequestTypeKnownValues.RequestType_ShowPrincipalPaid:
                        handler.string_value("ShowPrincipalPaid");
                        break;
                    case TypeRequestTypeKnownValues.RequestType_ShowPrincipal:
                        handler.string_value("ShowPrincipal");
                        break;
                    case TypeRequestTypeKnownValues.RequestType_ShowPrincipalOwing:
                        handler.string_value("ShowPrincipalOwing");
                        break;
                    case TypeRequestTypeKnownValues.RequestType_ShowHomeValue:
                        handler.string_value("ShowHomeValue");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeRequestType.string_value);
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
        if (!(hasRequestType()))
          {
            return "When parsing the object for %what%, the \"RequestType\" field was missing.";
          }
        return null;
      }

    public static MortgageCalculatorQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MortgageCalculatorQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorQueryState", ignore_extras);
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
    public static MortgageCalculatorQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MortgageCalculatorQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MortgageCalculatorQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorQueryState", ignore_extras);
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
    public static MortgageCalculatorQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MortgageCalculatorQueryStateJSON from_text(string text, bool ignore_extras)
      {
        MortgageCalculatorQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorQueryState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MortgageCalculatorQueryStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MortgageCalculatorQueryStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MortgageCalculatorQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorQueryState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingArrayGeneratorInputVariableSets : JSONArrayGenerator
  {
    protected class ElementHandler : MortgageCalculatorInputVariableJSON.HoldingArrayGenerator
      {
        private FieldHoldingArrayGeneratorInputVariableSets top;

        protected override void handle_result(List< MortgageCalculatorInputVariableJSON  > result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorInputVariableSets init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<List< MortgageCalculatorInputVariableJSON  >> result)
      {
      }

    public FieldHoldingArrayGeneratorInputVariableSets(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<List< MortgageCalculatorInputVariableJSON  >>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorInputVariableSets(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<List< MortgageCalculatorInputVariableJSON  >>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<List< MortgageCalculatorInputVariableJSON  >> value;
  };
        private FieldHoldingArrayGeneratorInputVariableSets fieldGeneratorInputVariableSets;
    private abstract class FieldGeneratorRequestType : JSONStringGenerator
          {
            protected FieldGeneratorRequestType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorRequestType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeRequestTypeKnownValues known = stringToRequestType(result);
                TypeRequestType new_value = new TypeRequestType();
                if (known == TypeRequestTypeKnownValues.RequestType__none)
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
            protected abstract void handle_result(TypeRequestType result);
          };
    private class FieldHoldingGeneratorRequestType : FieldGeneratorRequestType
  {
    protected override void handle_result(TypeRequestType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorRequestType(String what)
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
    public TypeRequestType value;
  };
    private class FieldHoldingArrayGeneratorRequestType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorRequestType
      {
        private FieldHoldingArrayGeneratorRequestType top;

        protected override void handle_result(TypeRequestType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorRequestType init_top)
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
    protected virtual void handle_result(List<TypeRequestType> result)
      {
      }

    public FieldHoldingArrayGeneratorRequestType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeRequestType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorRequestType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeRequestType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeRequestType> value;
  };
        private FieldHoldingGeneratorRequestType fieldGeneratorRequestType;
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
            MortgageCalculatorQueryStateJSON result = new MortgageCalculatorQueryStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMortgageCalculatorQueryStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(MortgageCalculatorQueryStateJSON result)
          {
            if (fieldGeneratorInputVariableSets.have_value)
              {
                result.initInputVariableSets();
                int count = fieldGeneratorInputVariableSets.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    List< MortgageCalculatorInputVariableJSON  > unwrapped0 = new List< MortgageCalculatorInputVariableJSON  >();
                    for (int num0 = 0; num0 < fieldGeneratorInputVariableSets.value[num].Count; ++num0)
                      {
                        unwrapped0.Add(fieldGeneratorInputVariableSets.value[num][num0]);
                      }
                    result.appendInputVariableSets(unwrapped0);
                  }
                fieldGeneratorInputVariableSets.value.Clear();
                fieldGeneratorInputVariableSets.have_value = false;
              }
            if (fieldGeneratorRequestType.have_value)
              {
                result.setRequestType(fieldGeneratorRequestType.value);
                fieldGeneratorRequestType.have_value = false;
              }
            else if ((!(result.hasRequestType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RequestType\" field was missing.");
              }
          }
        protected abstract void handle_result(MortgageCalculatorQueryStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'I':
                    if ((String.Compare(field_name, 1, "nputVariableSets", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorInputVariableSets;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "equestType", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorRequestType;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorInputVariableSets = new FieldHoldingArrayGeneratorInputVariableSets("field \"InputVariableSets\" of the MortgageCalculatorQueryState class", ignore_extras);
            fieldGeneratorRequestType = new FieldHoldingGeneratorRequestType("field \"RequestType\" of the MortgageCalculatorQueryState class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MortgageCalculatorQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorInputVariableSets = new FieldHoldingArrayGeneratorInputVariableSets("field \"InputVariableSets\" of the MortgageCalculatorQueryState class", false);
            fieldGeneratorRequestType = new FieldHoldingGeneratorRequestType("field \"RequestType\" of the MortgageCalculatorQueryState class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MortgageCalculatorQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorInputVariableSets.reset();
            fieldGeneratorRequestType.reset();
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
        protected override void handle_result(MortgageCalculatorQueryStateJSON  result)
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
        public MortgageCalculatorQueryStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MortgageCalculatorQueryStateJSON  result)
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
    protected virtual void handle_result(List<MortgageCalculatorQueryStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MortgageCalculatorQueryStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MortgageCalculatorQueryStateJSON>();
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
    public List<MortgageCalculatorQueryStateJSON> value;
  };
  };
