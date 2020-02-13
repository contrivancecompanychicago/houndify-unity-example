/* file "MortgageCalculatorInputDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class MortgageCalculatorInputDataJSON : JSONBase
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

    public enum TypeFutureCalculationTypeKnownValues
      {
        FutureCalculationType_TotalInterest,
        FutureCalculationType_TotalPaid,
        FutureCalculationType_PrincipalPaid,
        FutureCalculationType_PrincipalOwing,
        FutureCalculationType__none
      };
    public struct TypeFutureCalculationType
      {
        public bool in_known_list;
        public string string_value;
        public TypeFutureCalculationTypeKnownValues list_value;
      };

    public static TypeFutureCalculationTypeKnownValues  stringToFutureCalculationType(string chars)
      {
        switch (chars[0])
          {
            case 'P':
                if (String.Compare(chars, 1, "rincipal", 0, 8, false) == 0)
                  {
                    switch (chars[9])
                      {
                        case 'O':
                            if ((String.Compare(chars, 10, "wing", 0, 4, false) == 0) && (chars.Length == 14))
                                return TypeFutureCalculationTypeKnownValues.FutureCalculationType_PrincipalOwing;
                            break;
                        case 'P':
                            if ((String.Compare(chars, 10, "aid", 0, 3, false) == 0) && (chars.Length == 13))
                                return TypeFutureCalculationTypeKnownValues.FutureCalculationType_PrincipalPaid;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'T':
                if (String.Compare(chars, 1, "otal", 0, 4, false) == 0)
                  {
                    switch (chars[5])
                      {
                        case 'I':
                            if ((String.Compare(chars, 6, "nterest", 0, 7, false) == 0) && (chars.Length == 13))
                                return TypeFutureCalculationTypeKnownValues.FutureCalculationType_TotalInterest;
                            break;
                        case 'P':
                            if ((String.Compare(chars, 6, "aid", 0, 3, false) == 0) && (chars.Length == 9))
                                return TypeFutureCalculationTypeKnownValues.FutureCalculationType_TotalPaid;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return TypeFutureCalculationTypeKnownValues.FutureCalculationType__none;
      }

    public static string  stringFromFutureCalculationType(TypeFutureCalculationTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeFutureCalculationTypeKnownValues.FutureCalculationType_TotalInterest:
                return "TotalInterest";
            case TypeFutureCalculationTypeKnownValues.FutureCalculationType_TotalPaid:
                return "TotalPaid";
            case TypeFutureCalculationTypeKnownValues.FutureCalculationType_PrincipalPaid:
                return "PrincipalPaid";
            case TypeFutureCalculationTypeKnownValues.FutureCalculationType_PrincipalOwing:
                return "PrincipalOwing";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeRequestTypeKnownValues
      {
        RequestType_Unknown,
        RequestType_AskPrincipal,
        RequestType_AskInterestRate,
        RequestType_AskAmortization,
        RequestType_AskHomeValue,
        RequestType_AskDownPayment,
        RequestType_AskMonthlyPayment,
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
        RequestType_AskYearRange,
        RequestType_AskYearOwing,
        RequestType_AskPrincipalOrHomeValue,
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
            case 'U':
                if ((String.Compare(chars, 1, "nknown", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeRequestTypeKnownValues.RequestType_Unknown;
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
            case TypeRequestTypeKnownValues.RequestType_Unknown:
                return "Unknown";
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
            case TypeRequestTypeKnownValues.RequestType_AskYearRange:
                return "AskYearRange";
            case TypeRequestTypeKnownValues.RequestType_AskYearOwing:
                return "AskYearOwing";
            case TypeRequestTypeKnownValues.RequestType_AskPrincipalOrHomeValue:
                return "AskPrincipalOrHomeValue";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeLastRequestKnownValues
      {
        LastRequest_Unknown,
        LastRequest_AskPrincipal,
        LastRequest_AskInterestRate,
        LastRequest_AskAmortization,
        LastRequest_AskHomeValue,
        LastRequest_AskDownPayment,
        LastRequest_AskMonthlyPayment,
        LastRequest_ShowPayment,
        LastRequest_ShowTotalInterest,
        LastRequest_ShowTotalPaid,
        LastRequest_ShowDownPayment,
        LastRequest_ShowInterestRate,
        LastRequest_ShowAmortization,
        LastRequest_ShowPrincipalPaid,
        LastRequest_ShowPrincipal,
        LastRequest_ShowPrincipalOwing,
        LastRequest_ShowHomeValue,
        LastRequest_AskYearRange,
        LastRequest_AskYearOwing,
        LastRequest_AskPrincipalOrHomeValue,
        LastRequest__none
      };
    public struct TypeLastRequest
      {
        public bool in_known_list;
        public string string_value;
        public TypeLastRequestKnownValues list_value;
      };

    public static TypeLastRequestKnownValues  stringToLastRequest(string chars)
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
                                return TypeLastRequestKnownValues.LastRequest_AskAmortization;
                            break;
                        case 'D':
                            if ((String.Compare(chars, 4, "ownPayment", 0, 10, false) == 0) && (chars.Length == 14))
                                return TypeLastRequestKnownValues.LastRequest_AskDownPayment;
                            break;
                        case 'H':
                            if ((String.Compare(chars, 4, "omeValue", 0, 8, false) == 0) && (chars.Length == 12))
                                return TypeLastRequestKnownValues.LastRequest_AskHomeValue;
                            break;
                        case 'I':
                            if ((String.Compare(chars, 4, "nterestRate", 0, 11, false) == 0) && (chars.Length == 15))
                                return TypeLastRequestKnownValues.LastRequest_AskInterestRate;
                            break;
                        case 'M':
                            if ((String.Compare(chars, 4, "onthlyPayment", 0, 13, false) == 0) && (chars.Length == 17))
                                return TypeLastRequestKnownValues.LastRequest_AskMonthlyPayment;
                            break;
                        case 'P':
                            if (String.Compare(chars, 4, "rincipal", 0, 8, false) == 0)
                              {
                                if (chars.Length == 12)
                                  {
                                    return TypeLastRequestKnownValues.LastRequest_AskPrincipal;
                                  }
                                switch (chars[12])
                                  {
                                    case 'O':
                                        if ((String.Compare(chars, 13, "rHomeValue", 0, 10, false) == 0) && (chars.Length == 23))
                                            return TypeLastRequestKnownValues.LastRequest_AskPrincipalOrHomeValue;
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
                                            return TypeLastRequestKnownValues.LastRequest_AskYearOwing;
                                        break;
                                    case 'R':
                                        if ((String.Compare(chars, 8, "ange", 0, 4, false) == 0) && (chars.Length == 12))
                                            return TypeLastRequestKnownValues.LastRequest_AskYearRange;
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
                                return TypeLastRequestKnownValues.LastRequest_ShowAmortization;
                            break;
                        case 'D':
                            if ((String.Compare(chars, 5, "ownPayment", 0, 10, false) == 0) && (chars.Length == 15))
                                return TypeLastRequestKnownValues.LastRequest_ShowDownPayment;
                            break;
                        case 'H':
                            if ((String.Compare(chars, 5, "omeValue", 0, 8, false) == 0) && (chars.Length == 13))
                                return TypeLastRequestKnownValues.LastRequest_ShowHomeValue;
                            break;
                        case 'I':
                            if ((String.Compare(chars, 5, "nterestRate", 0, 11, false) == 0) && (chars.Length == 16))
                                return TypeLastRequestKnownValues.LastRequest_ShowInterestRate;
                            break;
                        case 'P':
                            switch (chars[5])
                              {
                                case 'a':
                                    if ((String.Compare(chars, 6, "yment", 0, 5, false) == 0) && (chars.Length == 11))
                                        return TypeLastRequestKnownValues.LastRequest_ShowPayment;
                                    break;
                                case 'r':
                                    if (String.Compare(chars, 6, "incipal", 0, 7, false) == 0)
                                      {
                                        if (chars.Length == 13)
                                          {
                                            return TypeLastRequestKnownValues.LastRequest_ShowPrincipal;
                                          }
                                        switch (chars[13])
                                          {
                                            case 'O':
                                                if ((String.Compare(chars, 14, "wing", 0, 4, false) == 0) && (chars.Length == 18))
                                                    return TypeLastRequestKnownValues.LastRequest_ShowPrincipalOwing;
                                                break;
                                            case 'P':
                                                if ((String.Compare(chars, 14, "aid", 0, 3, false) == 0) && (chars.Length == 17))
                                                    return TypeLastRequestKnownValues.LastRequest_ShowPrincipalPaid;
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
                                            return TypeLastRequestKnownValues.LastRequest_ShowTotalInterest;
                                        break;
                                    case 'P':
                                        if ((String.Compare(chars, 10, "aid", 0, 3, false) == 0) && (chars.Length == 13))
                                            return TypeLastRequestKnownValues.LastRequest_ShowTotalPaid;
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
            case 'U':
                if ((String.Compare(chars, 1, "nknown", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeLastRequestKnownValues.LastRequest_Unknown;
                break;
            default:
                break;
          }
        return TypeLastRequestKnownValues.LastRequest__none;
      }

    public static string  stringFromLastRequest(TypeLastRequestKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeLastRequestKnownValues.LastRequest_Unknown:
                return "Unknown";
            case TypeLastRequestKnownValues.LastRequest_AskPrincipal:
                return "AskPrincipal";
            case TypeLastRequestKnownValues.LastRequest_AskInterestRate:
                return "AskInterestRate";
            case TypeLastRequestKnownValues.LastRequest_AskAmortization:
                return "AskAmortization";
            case TypeLastRequestKnownValues.LastRequest_AskHomeValue:
                return "AskHomeValue";
            case TypeLastRequestKnownValues.LastRequest_AskDownPayment:
                return "AskDownPayment";
            case TypeLastRequestKnownValues.LastRequest_AskMonthlyPayment:
                return "AskMonthlyPayment";
            case TypeLastRequestKnownValues.LastRequest_ShowPayment:
                return "ShowPayment";
            case TypeLastRequestKnownValues.LastRequest_ShowTotalInterest:
                return "ShowTotalInterest";
            case TypeLastRequestKnownValues.LastRequest_ShowTotalPaid:
                return "ShowTotalPaid";
            case TypeLastRequestKnownValues.LastRequest_ShowDownPayment:
                return "ShowDownPayment";
            case TypeLastRequestKnownValues.LastRequest_ShowInterestRate:
                return "ShowInterestRate";
            case TypeLastRequestKnownValues.LastRequest_ShowAmortization:
                return "ShowAmortization";
            case TypeLastRequestKnownValues.LastRequest_ShowPrincipalPaid:
                return "ShowPrincipalPaid";
            case TypeLastRequestKnownValues.LastRequest_ShowPrincipal:
                return "ShowPrincipal";
            case TypeLastRequestKnownValues.LastRequest_ShowPrincipalOwing:
                return "ShowPrincipalOwing";
            case TypeLastRequestKnownValues.LastRequest_ShowHomeValue:
                return "ShowHomeValue";
            case TypeLastRequestKnownValues.LastRequest_AskYearRange:
                return "AskYearRange";
            case TypeLastRequestKnownValues.LastRequest_AskYearOwing:
                return "AskYearOwing";
            case TypeLastRequestKnownValues.LastRequest_AskPrincipalOrHomeValue:
                return "AskPrincipalOrHomeValue";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypePaymentFrequencyKnownValues
      {
        PaymentFrequency_monthly,
        PaymentFrequency_biweekly,
        PaymentFrequency_weekly,
        PaymentFrequency__none
      };
    public struct TypePaymentFrequency
      {
        public bool in_known_list;
        public string string_value;
        public TypePaymentFrequencyKnownValues list_value;
      };

    public static TypePaymentFrequencyKnownValues  stringToPaymentFrequency(string chars)
      {
        switch (chars[0])
          {
            case 'b':
                if ((String.Compare(chars, 1, "iweekly", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypePaymentFrequencyKnownValues.PaymentFrequency_biweekly;
                break;
            case 'm':
                if ((String.Compare(chars, 1, "onthly", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypePaymentFrequencyKnownValues.PaymentFrequency_monthly;
                break;
            case 'w':
                if ((String.Compare(chars, 1, "eekly", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypePaymentFrequencyKnownValues.PaymentFrequency_weekly;
                break;
            default:
                break;
          }
        return TypePaymentFrequencyKnownValues.PaymentFrequency__none;
      }

    public static string  stringFromPaymentFrequency(TypePaymentFrequencyKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypePaymentFrequencyKnownValues.PaymentFrequency_monthly:
                return "monthly";
            case TypePaymentFrequencyKnownValues.PaymentFrequency_biweekly:
                return "biweekly";
            case TypePaymentFrequencyKnownValues.PaymentFrequency_weekly:
                return "weekly";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasCalculationType;
    private TypeCalculationType storeCalculationType;
    private bool flagHasCalculationTypeIsNew;
    private bool storeCalculationTypeIsNew;
    private bool flagHasFutureCalculationType;
    private TypeFutureCalculationType storeFutureCalculationType;
    private bool flagHasRequestType;
    private TypeRequestType storeRequestType;
    private bool flagHasLastRequest;
    private TypeLastRequest storeLastRequest;
    private bool flagHasInterestRate;
    private double storeInterestRate;
    private string textStoreInterestRate;
    private bool flagHasInterestRateIsNew;
    private bool storeInterestRateIsNew;
    private bool flagHasMortgagePrincipal;
    private MoneyJSON  storeMortgagePrincipal;
    private bool flagHasMortgagePrincipalIsNew;
    private bool storeMortgagePrincipalIsNew;
    private bool flagHasPrincipalHomeValueAmbiguous;
    private bool storePrincipalHomeValueAmbiguous;
    private bool flagHasPrincipalHomeValueAmbiguousConfirmed;
    private bool storePrincipalHomeValueAmbiguousConfirmed;
    private bool flagHasNumMonths;
    private BigInteger storeNumMonths;
    private bool flagHasNumMonthsIsNew;
    private bool storeNumMonthsIsNew;
    private bool flagHasYearStart;
    private BigInteger storeYearStart;
    private bool flagHasYearEnd;
    private BigInteger storeYearEnd;
    private bool flagHasYearStartEndIsNew;
    private bool storeYearStartEndIsNew;
    private bool flagHasYearEndOwing;
    private BigInteger storeYearEndOwing;
    private bool flagHasYearEndOwingIsNew;
    private bool storeYearEndOwingIsNew;
    private bool flagHasDownPaymentPercent;
    private double storeDownPaymentPercent;
    private string textStoreDownPaymentPercent;
    private bool flagHasDownPaymentPercentIsNew;
    private bool storeDownPaymentPercentIsNew;
    private bool flagHasDownPayment;
    private MoneyJSON  storeDownPayment;
    private bool flagHasDownPaymentIsNew;
    private bool storeDownPaymentIsNew;
    private bool flagHasHomeValue;
    private MoneyJSON  storeHomeValue;
    private bool flagHasHomeValueIsNew;
    private bool storeHomeValueIsNew;
    private bool flagHasMaxPaymentAmount;
    private MoneyJSON  storeMaxPaymentAmount;
    private bool flagHasMaxPaymentAmountIsNew;
    private bool storeMaxPaymentAmountIsNew;
    private bool flagHasDoNotKnow;
    private bool storeDoNotKnow;
    private bool flagHasWantToKnow;
    private bool storeWantToKnow;
    private bool flagHasMortgageCalculatorStart;
    private bool storeMortgageCalculatorStart;
    private bool flagHasDefaultCurrency;
    private MoneyJSON  storeDefaultCurrency;
    private bool flagHasUserConfused;
    private bool storeUserConfused;
    private bool flagHasPaymentFrequency;
    private TypePaymentFrequency storePaymentFrequency;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONCalculationType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CalculationType of MortgageCalculatorInputDataJSON is not a string.");
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


    private void  fromJSONCalculationTypeIsNew(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field CalculationTypeIsNew of MortgageCalculatorInputDataJSON is not true for false.");
              }
          }
        setCalculationTypeIsNew(the_bool);
      }


    private void  fromJSONFutureCalculationType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FutureCalculationType of MortgageCalculatorInputDataJSON is not a string.");
        TypeFutureCalculationType the_open_enum = new TypeFutureCalculationType();
        switch (json_string.getData()[0])
          {
            case 'P':
                if (String.Compare(json_string.getData(), 1, "rincipal", 0, 8, false) == 0)
                  {
                    switch (json_string.getData()[9])
                      {
                        case 'O':
                            if ((String.Compare(json_string.getData(), 10, "wing", 0, 4, false) == 0) && (json_string.getData().Length == 14))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeFutureCalculationTypeKnownValues.FutureCalculationType_PrincipalOwing;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'P':
                            if ((String.Compare(json_string.getData(), 10, "aid", 0, 3, false) == 0) && (json_string.getData().Length == 13))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeFutureCalculationTypeKnownValues.FutureCalculationType_PrincipalPaid;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
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
                                    the_open_enum.list_value = TypeFutureCalculationTypeKnownValues.FutureCalculationType_TotalInterest;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'P':
                            if ((String.Compare(json_string.getData(), 6, "aid", 0, 3, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeFutureCalculationTypeKnownValues.FutureCalculationType_TotalPaid;
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
        setFutureCalculationType(the_open_enum);
      }


    private void  fromJSONRequestType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field RequestType of MortgageCalculatorInputDataJSON is not a string.");
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
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeRequestTypeKnownValues.RequestType_Unknown;
                        goto open_enum_is_done;
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


    private void  fromJSONLastRequest(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LastRequest of MortgageCalculatorInputDataJSON is not a string.");
        TypeLastRequest the_open_enum = new TypeLastRequest();
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
                                    the_open_enum.list_value = TypeLastRequestKnownValues.LastRequest_AskAmortization;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'D':
                            if ((String.Compare(json_string.getData(), 4, "ownPayment", 0, 10, false) == 0) && (json_string.getData().Length == 14))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeLastRequestKnownValues.LastRequest_AskDownPayment;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'H':
                            if ((String.Compare(json_string.getData(), 4, "omeValue", 0, 8, false) == 0) && (json_string.getData().Length == 12))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeLastRequestKnownValues.LastRequest_AskHomeValue;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'I':
                            if ((String.Compare(json_string.getData(), 4, "nterestRate", 0, 11, false) == 0) && (json_string.getData().Length == 15))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeLastRequestKnownValues.LastRequest_AskInterestRate;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'M':
                            if ((String.Compare(json_string.getData(), 4, "onthlyPayment", 0, 13, false) == 0) && (json_string.getData().Length == 17))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeLastRequestKnownValues.LastRequest_AskMonthlyPayment;
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
                                        the_open_enum.list_value = TypeLastRequestKnownValues.LastRequest_AskPrincipal;
                                        goto open_enum_is_done;
                                      }
                                  }
                                switch (json_string.getData()[12])
                                  {
                                    case 'O':
                                        if ((String.Compare(json_string.getData(), 13, "rHomeValue", 0, 10, false) == 0) && (json_string.getData().Length == 23))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeLastRequestKnownValues.LastRequest_AskPrincipalOrHomeValue;
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
                                                the_open_enum.list_value = TypeLastRequestKnownValues.LastRequest_AskYearOwing;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'R':
                                        if ((String.Compare(json_string.getData(), 8, "ange", 0, 4, false) == 0) && (json_string.getData().Length == 12))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeLastRequestKnownValues.LastRequest_AskYearRange;
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
                                    the_open_enum.list_value = TypeLastRequestKnownValues.LastRequest_ShowAmortization;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'D':
                            if ((String.Compare(json_string.getData(), 5, "ownPayment", 0, 10, false) == 0) && (json_string.getData().Length == 15))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeLastRequestKnownValues.LastRequest_ShowDownPayment;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'H':
                            if ((String.Compare(json_string.getData(), 5, "omeValue", 0, 8, false) == 0) && (json_string.getData().Length == 13))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeLastRequestKnownValues.LastRequest_ShowHomeValue;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'I':
                            if ((String.Compare(json_string.getData(), 5, "nterestRate", 0, 11, false) == 0) && (json_string.getData().Length == 16))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeLastRequestKnownValues.LastRequest_ShowInterestRate;
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
                                            the_open_enum.list_value = TypeLastRequestKnownValues.LastRequest_ShowPayment;
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
                                                the_open_enum.list_value = TypeLastRequestKnownValues.LastRequest_ShowPrincipal;
                                                goto open_enum_is_done;
                                              }
                                          }
                                        switch (json_string.getData()[13])
                                          {
                                            case 'O':
                                                if ((String.Compare(json_string.getData(), 14, "wing", 0, 4, false) == 0) && (json_string.getData().Length == 18))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeLastRequestKnownValues.LastRequest_ShowPrincipalOwing;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'P':
                                                if ((String.Compare(json_string.getData(), 14, "aid", 0, 3, false) == 0) && (json_string.getData().Length == 17))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeLastRequestKnownValues.LastRequest_ShowPrincipalPaid;
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
                                                the_open_enum.list_value = TypeLastRequestKnownValues.LastRequest_ShowTotalInterest;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'P':
                                        if ((String.Compare(json_string.getData(), 10, "aid", 0, 3, false) == 0) && (json_string.getData().Length == 13))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeLastRequestKnownValues.LastRequest_ShowTotalPaid;
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
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeLastRequestKnownValues.LastRequest_Unknown;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setLastRequest(the_open_enum);
      }


    private void  fromJSONInterestRate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field InterestRate of MortgageCalculatorInputDataJSON is not a number.");
              }
          }
        setInterestRateText(the_rational_text);
      }


    private void  fromJSONInterestRateIsNew(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field InterestRateIsNew of MortgageCalculatorInputDataJSON is not true for false.");
              }
          }
        setInterestRateIsNew(the_bool);
      }


    private void  fromJSONMortgagePrincipal(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
        setMortgagePrincipal(convert_classy);
      }


    private void  fromJSONMortgagePrincipalIsNew(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field MortgagePrincipalIsNew of MortgageCalculatorInputDataJSON is not true for false.");
              }
          }
        setMortgagePrincipalIsNew(the_bool);
      }


    private void  fromJSONPrincipalHomeValueAmbiguous(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field PrincipalHomeValueAmbiguous of MortgageCalculatorInputDataJSON is not true for false.");
              }
          }
        setPrincipalHomeValueAmbiguous(the_bool);
      }


    private void  fromJSONPrincipalHomeValueAmbiguousConfirmed(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field PrincipalHomeValueAmbiguousConfirmed of MortgageCalculatorInputDataJSON is not true for false.");
              }
          }
        setPrincipalHomeValueAmbiguousConfirmed(the_bool);
      }


    private void  fromJSONNumMonths(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field NumMonths of MortgageCalculatorInputDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field NumMonths of MortgageCalculatorInputDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setNumMonths(extracted_integer);
      }


    private void  fromJSONNumMonthsIsNew(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field NumMonthsIsNew of MortgageCalculatorInputDataJSON is not true for false.");
              }
          }
        setNumMonthsIsNew(the_bool);
      }


    private void  fromJSONYearStart(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field YearStart of MortgageCalculatorInputDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field YearStart of MortgageCalculatorInputDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setYearStart(extracted_integer);
      }


    private void  fromJSONYearEnd(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field YearEnd of MortgageCalculatorInputDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field YearEnd of MortgageCalculatorInputDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setYearEnd(extracted_integer);
      }


    private void  fromJSONYearStartEndIsNew(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field YearStartEndIsNew of MortgageCalculatorInputDataJSON is not true for false.");
              }
          }
        setYearStartEndIsNew(the_bool);
      }


    private void  fromJSONYearEndOwing(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field YearEndOwing of MortgageCalculatorInputDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field YearEndOwing of MortgageCalculatorInputDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setYearEndOwing(extracted_integer);
      }


    private void  fromJSONYearEndOwingIsNew(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field YearEndOwingIsNew of MortgageCalculatorInputDataJSON is not true for false.");
              }
          }
        setYearEndOwingIsNew(the_bool);
      }


    private void  fromJSONDownPaymentPercent(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field DownPaymentPercent of MortgageCalculatorInputDataJSON is not a number.");
              }
          }
        setDownPaymentPercentText(the_rational_text);
      }


    private void  fromJSONDownPaymentPercentIsNew(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DownPaymentPercentIsNew of MortgageCalculatorInputDataJSON is not true for false.");
              }
          }
        setDownPaymentPercentIsNew(the_bool);
      }


    private void  fromJSONDownPayment(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
        setDownPayment(convert_classy);
      }


    private void  fromJSONDownPaymentIsNew(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DownPaymentIsNew of MortgageCalculatorInputDataJSON is not true for false.");
              }
          }
        setDownPaymentIsNew(the_bool);
      }


    private void  fromJSONHomeValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
        setHomeValue(convert_classy);
      }


    private void  fromJSONHomeValueIsNew(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field HomeValueIsNew of MortgageCalculatorInputDataJSON is not true for false.");
              }
          }
        setHomeValueIsNew(the_bool);
      }


    private void  fromJSONMaxPaymentAmount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
        setMaxPaymentAmount(convert_classy);
      }


    private void  fromJSONMaxPaymentAmountIsNew(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field MaxPaymentAmountIsNew of MortgageCalculatorInputDataJSON is not true for false.");
              }
          }
        setMaxPaymentAmountIsNew(the_bool);
      }


    private void  fromJSONDoNotKnow(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DoNotKnow of MortgageCalculatorInputDataJSON is not true for false.");
              }
          }
        setDoNotKnow(the_bool);
      }


    private void  fromJSONWantToKnow(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field WantToKnow of MortgageCalculatorInputDataJSON is not true for false.");
              }
          }
        setWantToKnow(the_bool);
      }


    private void  fromJSONMortgageCalculatorStart(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field MortgageCalculatorStart of MortgageCalculatorInputDataJSON is not true for false.");
              }
          }
        setMortgageCalculatorStart(the_bool);
      }


    private void  fromJSONDefaultCurrency(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
        setDefaultCurrency(convert_classy);
      }


    private void  fromJSONUserConfused(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field UserConfused of MortgageCalculatorInputDataJSON is not true for false.");
              }
          }
        setUserConfused(the_bool);
      }


    private void  fromJSONPaymentFrequency(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PaymentFrequency of MortgageCalculatorInputDataJSON is not a string.");
        TypePaymentFrequency the_open_enum = new TypePaymentFrequency();
        switch (json_string.getData()[0])
          {
            case 'b':
                if ((String.Compare(json_string.getData(), 1, "iweekly", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypePaymentFrequencyKnownValues.PaymentFrequency_biweekly;
                        goto open_enum_is_done;
                      }
                break;
            case 'm':
                if ((String.Compare(json_string.getData(), 1, "onthly", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypePaymentFrequencyKnownValues.PaymentFrequency_monthly;
                        goto open_enum_is_done;
                      }
                break;
            case 'w':
                if ((String.Compare(json_string.getData(), 1, "eekly", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypePaymentFrequencyKnownValues.PaymentFrequency_weekly;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setPaymentFrequency(the_open_enum);
      }


    public MortgageCalculatorInputDataJSON()
      {
        flagHasCalculationType = false;
        flagHasCalculationTypeIsNew = false;
        flagHasFutureCalculationType = false;
        flagHasRequestType = false;
        flagHasLastRequest = false;
        flagHasInterestRate = false;
        flagHasInterestRateIsNew = false;
        flagHasMortgagePrincipal = false;
        flagHasMortgagePrincipalIsNew = false;
        flagHasPrincipalHomeValueAmbiguous = false;
        flagHasPrincipalHomeValueAmbiguousConfirmed = false;
        flagHasNumMonths = false;
        flagHasNumMonthsIsNew = false;
        flagHasYearStart = false;
        flagHasYearEnd = false;
        flagHasYearStartEndIsNew = false;
        flagHasYearEndOwing = false;
        flagHasYearEndOwingIsNew = false;
        flagHasDownPaymentPercent = false;
        flagHasDownPaymentPercentIsNew = false;
        flagHasDownPayment = false;
        flagHasDownPaymentIsNew = false;
        flagHasHomeValue = false;
        flagHasHomeValueIsNew = false;
        flagHasMaxPaymentAmount = false;
        flagHasMaxPaymentAmountIsNew = false;
        flagHasDoNotKnow = false;
        flagHasWantToKnow = false;
        flagHasMortgageCalculatorStart = false;
        flagHasDefaultCurrency = false;
        flagHasUserConfused = false;
        flagHasPaymentFrequency = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
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

    public bool  hasCalculationTypeIsNew()
      {
        return flagHasCalculationTypeIsNew;
      }

    public bool  getCalculationTypeIsNew()
      {
        Debug.Assert(flagHasCalculationTypeIsNew);
        return storeCalculationTypeIsNew;
      }

    public bool  hasFutureCalculationType()
      {
        return flagHasFutureCalculationType;
      }

    public TypeFutureCalculationType  getFutureCalculationType()
      {
        Debug.Assert(flagHasFutureCalculationType);
        return storeFutureCalculationType;
      }

    public string  getFutureCalculationTypeAsString()
      {
        TypeFutureCalculationType result = getFutureCalculationType();
        if (result.in_known_list)
            return stringFromFutureCalculationType(result.list_value);
        else
            return result.string_value;
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

    public bool  hasLastRequest()
      {
        return flagHasLastRequest;
      }

    public TypeLastRequest  getLastRequest()
      {
        Debug.Assert(flagHasLastRequest);
        return storeLastRequest;
      }

    public string  getLastRequestAsString()
      {
        TypeLastRequest result = getLastRequest();
        if (result.in_known_list)
            return stringFromLastRequest(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasInterestRate()
      {
        return flagHasInterestRate;
      }

    public double  getInterestRate()
      {
        Debug.Assert(flagHasInterestRate);
        if (textStoreInterestRate != "")
          {
            return Double.Parse(textStoreInterestRate);
          }
        return storeInterestRate;
      }

    public string  getInterestRateAsText()
      {
        Debug.Assert(flagHasInterestRate);
        if (textStoreInterestRate == "")
          {
            return Convert.ToString(storeInterestRate);
          }
        else
          {
            return (textStoreInterestRate);
          }
      }

    public bool  hasInterestRateIsNew()
      {
        return flagHasInterestRateIsNew;
      }

    public bool  getInterestRateIsNew()
      {
        Debug.Assert(flagHasInterestRateIsNew);
        return storeInterestRateIsNew;
      }

    public bool  hasMortgagePrincipal()
      {
        return flagHasMortgagePrincipal;
      }

    public MoneyJSON   getMortgagePrincipal()
      {
        Debug.Assert(flagHasMortgagePrincipal);
        return storeMortgagePrincipal;
      }

    public bool  hasMortgagePrincipalIsNew()
      {
        return flagHasMortgagePrincipalIsNew;
      }

    public bool  getMortgagePrincipalIsNew()
      {
        Debug.Assert(flagHasMortgagePrincipalIsNew);
        return storeMortgagePrincipalIsNew;
      }

    public bool  hasPrincipalHomeValueAmbiguous()
      {
        return flagHasPrincipalHomeValueAmbiguous;
      }

    public bool  getPrincipalHomeValueAmbiguous()
      {
        Debug.Assert(flagHasPrincipalHomeValueAmbiguous);
        return storePrincipalHomeValueAmbiguous;
      }

    public bool  hasPrincipalHomeValueAmbiguousConfirmed()
      {
        return flagHasPrincipalHomeValueAmbiguousConfirmed;
      }

    public bool  getPrincipalHomeValueAmbiguousConfirmed()
      {
        Debug.Assert(flagHasPrincipalHomeValueAmbiguousConfirmed);
        return storePrincipalHomeValueAmbiguousConfirmed;
      }

    public bool  hasNumMonths()
      {
        return flagHasNumMonths;
      }

    public BigInteger  getNumMonths()
      {
        Debug.Assert(flagHasNumMonths);
        return storeNumMonths;
      }

    public bool  hasNumMonthsIsNew()
      {
        return flagHasNumMonthsIsNew;
      }

    public bool  getNumMonthsIsNew()
      {
        Debug.Assert(flagHasNumMonthsIsNew);
        return storeNumMonthsIsNew;
      }

    public bool  hasYearStart()
      {
        return flagHasYearStart;
      }

    public BigInteger  getYearStart()
      {
        Debug.Assert(flagHasYearStart);
        return storeYearStart;
      }

    public bool  hasYearEnd()
      {
        return flagHasYearEnd;
      }

    public BigInteger  getYearEnd()
      {
        Debug.Assert(flagHasYearEnd);
        return storeYearEnd;
      }

    public bool  hasYearStartEndIsNew()
      {
        return flagHasYearStartEndIsNew;
      }

    public bool  getYearStartEndIsNew()
      {
        Debug.Assert(flagHasYearStartEndIsNew);
        return storeYearStartEndIsNew;
      }

    public bool  hasYearEndOwing()
      {
        return flagHasYearEndOwing;
      }

    public BigInteger  getYearEndOwing()
      {
        Debug.Assert(flagHasYearEndOwing);
        return storeYearEndOwing;
      }

    public bool  hasYearEndOwingIsNew()
      {
        return flagHasYearEndOwingIsNew;
      }

    public bool  getYearEndOwingIsNew()
      {
        Debug.Assert(flagHasYearEndOwingIsNew);
        return storeYearEndOwingIsNew;
      }

    public bool  hasDownPaymentPercent()
      {
        return flagHasDownPaymentPercent;
      }

    public double  getDownPaymentPercent()
      {
        Debug.Assert(flagHasDownPaymentPercent);
        if (textStoreDownPaymentPercent != "")
          {
            return Double.Parse(textStoreDownPaymentPercent);
          }
        return storeDownPaymentPercent;
      }

    public string  getDownPaymentPercentAsText()
      {
        Debug.Assert(flagHasDownPaymentPercent);
        if (textStoreDownPaymentPercent == "")
          {
            return Convert.ToString(storeDownPaymentPercent);
          }
        else
          {
            return (textStoreDownPaymentPercent);
          }
      }

    public bool  hasDownPaymentPercentIsNew()
      {
        return flagHasDownPaymentPercentIsNew;
      }

    public bool  getDownPaymentPercentIsNew()
      {
        Debug.Assert(flagHasDownPaymentPercentIsNew);
        return storeDownPaymentPercentIsNew;
      }

    public bool  hasDownPayment()
      {
        return flagHasDownPayment;
      }

    public MoneyJSON   getDownPayment()
      {
        Debug.Assert(flagHasDownPayment);
        return storeDownPayment;
      }

    public bool  hasDownPaymentIsNew()
      {
        return flagHasDownPaymentIsNew;
      }

    public bool  getDownPaymentIsNew()
      {
        Debug.Assert(flagHasDownPaymentIsNew);
        return storeDownPaymentIsNew;
      }

    public bool  hasHomeValue()
      {
        return flagHasHomeValue;
      }

    public MoneyJSON   getHomeValue()
      {
        Debug.Assert(flagHasHomeValue);
        return storeHomeValue;
      }

    public bool  hasHomeValueIsNew()
      {
        return flagHasHomeValueIsNew;
      }

    public bool  getHomeValueIsNew()
      {
        Debug.Assert(flagHasHomeValueIsNew);
        return storeHomeValueIsNew;
      }

    public bool  hasMaxPaymentAmount()
      {
        return flagHasMaxPaymentAmount;
      }

    public MoneyJSON   getMaxPaymentAmount()
      {
        Debug.Assert(flagHasMaxPaymentAmount);
        return storeMaxPaymentAmount;
      }

    public bool  hasMaxPaymentAmountIsNew()
      {
        return flagHasMaxPaymentAmountIsNew;
      }

    public bool  getMaxPaymentAmountIsNew()
      {
        Debug.Assert(flagHasMaxPaymentAmountIsNew);
        return storeMaxPaymentAmountIsNew;
      }

    public bool  hasDoNotKnow()
      {
        return flagHasDoNotKnow;
      }

    public bool  getDoNotKnow()
      {
        Debug.Assert(flagHasDoNotKnow);
        return storeDoNotKnow;
      }

    public bool  hasWantToKnow()
      {
        return flagHasWantToKnow;
      }

    public bool  getWantToKnow()
      {
        Debug.Assert(flagHasWantToKnow);
        return storeWantToKnow;
      }

    public bool  hasMortgageCalculatorStart()
      {
        return flagHasMortgageCalculatorStart;
      }

    public bool  getMortgageCalculatorStart()
      {
        Debug.Assert(flagHasMortgageCalculatorStart);
        return storeMortgageCalculatorStart;
      }

    public bool  hasDefaultCurrency()
      {
        return flagHasDefaultCurrency;
      }

    public MoneyJSON   getDefaultCurrency()
      {
        Debug.Assert(flagHasDefaultCurrency);
        return storeDefaultCurrency;
      }

    public bool  hasUserConfused()
      {
        return flagHasUserConfused;
      }

    public bool  getUserConfused()
      {
        Debug.Assert(flagHasUserConfused);
        return storeUserConfused;
      }

    public bool  hasPaymentFrequency()
      {
        return flagHasPaymentFrequency;
      }

    public TypePaymentFrequency  getPaymentFrequency()
      {
        Debug.Assert(flagHasPaymentFrequency);
        return storePaymentFrequency;
      }

    public string  getPaymentFrequencyAsString()
      {
        TypePaymentFrequency result = getPaymentFrequency();
        if (result.in_known_list)
            return stringFromPaymentFrequency(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraMortgageCalculatorInputDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMortgageCalculatorInputDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMortgageCalculatorInputDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMortgageCalculatorInputDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
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
    public void setCalculationTypeIsNew(bool new_value)
      {
        flagHasCalculationTypeIsNew = true;
        storeCalculationTypeIsNew = new_value;
      }
    public void unsetCalculationTypeIsNew()
      {
        flagHasCalculationTypeIsNew = false;
      }
    public void setFutureCalculationType(TypeFutureCalculationType new_value)
      {
        flagHasFutureCalculationType = true;
        storeFutureCalculationType = new_value;
      }
    public void setFutureCalculationType(string chars)
      {
        TypeFutureCalculationTypeKnownValues known = stringToFutureCalculationType(chars);
        TypeFutureCalculationType new_value = new TypeFutureCalculationType();
        if (known == TypeFutureCalculationTypeKnownValues.FutureCalculationType__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setFutureCalculationType(new_value);
      }
    public void setFutureCalculationType(TypeFutureCalculationTypeKnownValues new_value)
      {
        TypeFutureCalculationType new_full_value = new TypeFutureCalculationType();
        Debug.Assert(new_value != TypeFutureCalculationTypeKnownValues.FutureCalculationType__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setFutureCalculationType(new_full_value);
      }
    public void unsetFutureCalculationType()
      {
        flagHasFutureCalculationType = false;
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
    public void setLastRequest(TypeLastRequest new_value)
      {
        flagHasLastRequest = true;
        storeLastRequest = new_value;
      }
    public void setLastRequest(string chars)
      {
        TypeLastRequestKnownValues known = stringToLastRequest(chars);
        TypeLastRequest new_value = new TypeLastRequest();
        if (known == TypeLastRequestKnownValues.LastRequest__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setLastRequest(new_value);
      }
    public void setLastRequest(TypeLastRequestKnownValues new_value)
      {
        TypeLastRequest new_full_value = new TypeLastRequest();
        Debug.Assert(new_value != TypeLastRequestKnownValues.LastRequest__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setLastRequest(new_full_value);
      }
    public void unsetLastRequest()
      {
        flagHasLastRequest = false;
      }
    public void setInterestRate(double new_value)
      {
        flagHasInterestRate = true;
        if (new_value < 0)
            throw new Exception("The value for field InterestRate of MortgageCalculatorInputDataJSON is less than the lower bound (0) for that field.");
        storeInterestRate = new_value;
        textStoreInterestRate = "";
      }
    public void setInterestRateText(string new_value)
      {
        flagHasInterestRate = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field InterestRate of MortgageCalculatorInputDataJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field InterestRate of MortgageCalculatorInputDataJSON is less than the lower bound (0) for that field.");
        textStoreInterestRate = new_value;
      }
    public void unsetInterestRate()
      {
        flagHasInterestRate = false;
      }
    public void setInterestRateIsNew(bool new_value)
      {
        flagHasInterestRateIsNew = true;
        storeInterestRateIsNew = new_value;
      }
    public void unsetInterestRateIsNew()
      {
        flagHasInterestRateIsNew = false;
      }
    public void setMortgagePrincipal(MoneyJSON  new_value)
      {
        if (flagHasMortgagePrincipal)
          {
          }
        flagHasMortgagePrincipal = true;
        storeMortgagePrincipal = new_value;
      }
    public void unsetMortgagePrincipal()
      {
        if (flagHasMortgagePrincipal)
          {
          }
        flagHasMortgagePrincipal = false;
      }
    public void setMortgagePrincipalIsNew(bool new_value)
      {
        flagHasMortgagePrincipalIsNew = true;
        storeMortgagePrincipalIsNew = new_value;
      }
    public void unsetMortgagePrincipalIsNew()
      {
        flagHasMortgagePrincipalIsNew = false;
      }
    public void setPrincipalHomeValueAmbiguous(bool new_value)
      {
        flagHasPrincipalHomeValueAmbiguous = true;
        storePrincipalHomeValueAmbiguous = new_value;
      }
    public void unsetPrincipalHomeValueAmbiguous()
      {
        flagHasPrincipalHomeValueAmbiguous = false;
      }
    public void setPrincipalHomeValueAmbiguousConfirmed(bool new_value)
      {
        flagHasPrincipalHomeValueAmbiguousConfirmed = true;
        storePrincipalHomeValueAmbiguousConfirmed = new_value;
      }
    public void unsetPrincipalHomeValueAmbiguousConfirmed()
      {
        flagHasPrincipalHomeValueAmbiguousConfirmed = false;
      }
    public void setNumMonths(BigInteger new_value)
      {
        flagHasNumMonths = true;
        if (new_value < 0)
            throw new Exception("The value for field NumMonths of MortgageCalculatorInputDataJSON is less than the lower bound (0) for that field.");
        storeNumMonths = new_value;
      }
    public void unsetNumMonths()
      {
        flagHasNumMonths = false;
      }
    public void setNumMonthsIsNew(bool new_value)
      {
        flagHasNumMonthsIsNew = true;
        storeNumMonthsIsNew = new_value;
      }
    public void unsetNumMonthsIsNew()
      {
        flagHasNumMonthsIsNew = false;
      }
    public void setYearStart(BigInteger new_value)
      {
        flagHasYearStart = true;
        if (new_value < 0)
            throw new Exception("The value for field YearStart of MortgageCalculatorInputDataJSON is less than the lower bound (0) for that field.");
        storeYearStart = new_value;
      }
    public void unsetYearStart()
      {
        flagHasYearStart = false;
      }
    public void setYearEnd(BigInteger new_value)
      {
        flagHasYearEnd = true;
        storeYearEnd = new_value;
      }
    public void unsetYearEnd()
      {
        flagHasYearEnd = false;
      }
    public void setYearStartEndIsNew(bool new_value)
      {
        flagHasYearStartEndIsNew = true;
        storeYearStartEndIsNew = new_value;
      }
    public void unsetYearStartEndIsNew()
      {
        flagHasYearStartEndIsNew = false;
      }
    public void setYearEndOwing(BigInteger new_value)
      {
        flagHasYearEndOwing = true;
        if (new_value < 0)
            throw new Exception("The value for field YearEndOwing of MortgageCalculatorInputDataJSON is less than the lower bound (0) for that field.");
        storeYearEndOwing = new_value;
      }
    public void unsetYearEndOwing()
      {
        flagHasYearEndOwing = false;
      }
    public void setYearEndOwingIsNew(bool new_value)
      {
        flagHasYearEndOwingIsNew = true;
        storeYearEndOwingIsNew = new_value;
      }
    public void unsetYearEndOwingIsNew()
      {
        flagHasYearEndOwingIsNew = false;
      }
    public void setDownPaymentPercent(double new_value)
      {
        flagHasDownPaymentPercent = true;
        if (new_value < 0)
            throw new Exception("The value for field DownPaymentPercent of MortgageCalculatorInputDataJSON is less than the lower bound (0) for that field.");
        storeDownPaymentPercent = new_value;
        textStoreDownPaymentPercent = "";
      }
    public void setDownPaymentPercentText(string new_value)
      {
        flagHasDownPaymentPercent = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field DownPaymentPercent of MortgageCalculatorInputDataJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field DownPaymentPercent of MortgageCalculatorInputDataJSON is less than the lower bound (0) for that field.");
        textStoreDownPaymentPercent = new_value;
      }
    public void unsetDownPaymentPercent()
      {
        flagHasDownPaymentPercent = false;
      }
    public void setDownPaymentPercentIsNew(bool new_value)
      {
        flagHasDownPaymentPercentIsNew = true;
        storeDownPaymentPercentIsNew = new_value;
      }
    public void unsetDownPaymentPercentIsNew()
      {
        flagHasDownPaymentPercentIsNew = false;
      }
    public void setDownPayment(MoneyJSON  new_value)
      {
        if (flagHasDownPayment)
          {
          }
        flagHasDownPayment = true;
        storeDownPayment = new_value;
      }
    public void unsetDownPayment()
      {
        if (flagHasDownPayment)
          {
          }
        flagHasDownPayment = false;
      }
    public void setDownPaymentIsNew(bool new_value)
      {
        flagHasDownPaymentIsNew = true;
        storeDownPaymentIsNew = new_value;
      }
    public void unsetDownPaymentIsNew()
      {
        flagHasDownPaymentIsNew = false;
      }
    public void setHomeValue(MoneyJSON  new_value)
      {
        if (flagHasHomeValue)
          {
          }
        flagHasHomeValue = true;
        storeHomeValue = new_value;
      }
    public void unsetHomeValue()
      {
        if (flagHasHomeValue)
          {
          }
        flagHasHomeValue = false;
      }
    public void setHomeValueIsNew(bool new_value)
      {
        flagHasHomeValueIsNew = true;
        storeHomeValueIsNew = new_value;
      }
    public void unsetHomeValueIsNew()
      {
        flagHasHomeValueIsNew = false;
      }
    public void setMaxPaymentAmount(MoneyJSON  new_value)
      {
        if (flagHasMaxPaymentAmount)
          {
          }
        flagHasMaxPaymentAmount = true;
        storeMaxPaymentAmount = new_value;
      }
    public void unsetMaxPaymentAmount()
      {
        if (flagHasMaxPaymentAmount)
          {
          }
        flagHasMaxPaymentAmount = false;
      }
    public void setMaxPaymentAmountIsNew(bool new_value)
      {
        flagHasMaxPaymentAmountIsNew = true;
        storeMaxPaymentAmountIsNew = new_value;
      }
    public void unsetMaxPaymentAmountIsNew()
      {
        flagHasMaxPaymentAmountIsNew = false;
      }
    public void setDoNotKnow(bool new_value)
      {
        flagHasDoNotKnow = true;
        storeDoNotKnow = new_value;
      }
    public void unsetDoNotKnow()
      {
        flagHasDoNotKnow = false;
      }
    public void setWantToKnow(bool new_value)
      {
        flagHasWantToKnow = true;
        storeWantToKnow = new_value;
      }
    public void unsetWantToKnow()
      {
        flagHasWantToKnow = false;
      }
    public void setMortgageCalculatorStart(bool new_value)
      {
        flagHasMortgageCalculatorStart = true;
        storeMortgageCalculatorStart = new_value;
      }
    public void unsetMortgageCalculatorStart()
      {
        flagHasMortgageCalculatorStart = false;
      }
    public void setDefaultCurrency(MoneyJSON  new_value)
      {
        if (flagHasDefaultCurrency)
          {
          }
        flagHasDefaultCurrency = true;
        storeDefaultCurrency = new_value;
      }
    public void unsetDefaultCurrency()
      {
        if (flagHasDefaultCurrency)
          {
          }
        flagHasDefaultCurrency = false;
      }
    public void setUserConfused(bool new_value)
      {
        flagHasUserConfused = true;
        storeUserConfused = new_value;
      }
    public void unsetUserConfused()
      {
        flagHasUserConfused = false;
      }
    public void setPaymentFrequency(TypePaymentFrequency new_value)
      {
        flagHasPaymentFrequency = true;
        storePaymentFrequency = new_value;
      }
    public void setPaymentFrequency(string chars)
      {
        TypePaymentFrequencyKnownValues known = stringToPaymentFrequency(chars);
        TypePaymentFrequency new_value = new TypePaymentFrequency();
        if (known == TypePaymentFrequencyKnownValues.PaymentFrequency__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setPaymentFrequency(new_value);
      }
    public void setPaymentFrequency(TypePaymentFrequencyKnownValues new_value)
      {
        TypePaymentFrequency new_full_value = new TypePaymentFrequency();
        Debug.Assert(new_value != TypePaymentFrequencyKnownValues.PaymentFrequency__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setPaymentFrequency(new_full_value);
      }
    public void unsetPaymentFrequency()
      {
        flagHasPaymentFrequency = false;
      }

    public virtual void extraMortgageCalculatorInputDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMortgageCalculatorInputDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMortgageCalculatorInputDataLookup(key);
        if (old_field == null)
          {
            extraMortgageCalculatorInputDataAppendPair(key, new_component);
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
        if (flagHasCalculationTypeIsNew)
          {
            handler.start_pair("CalculationTypeIsNew");
            handler.boolean_value(storeCalculationTypeIsNew);
          }
        if (flagHasFutureCalculationType)
          {
            handler.start_pair("FutureCalculationType");
            if (storeFutureCalculationType.in_known_list)
              {
                switch (storeFutureCalculationType.list_value)
                  {
                    case TypeFutureCalculationTypeKnownValues.FutureCalculationType_TotalInterest:
                        handler.string_value("TotalInterest");
                        break;
                    case TypeFutureCalculationTypeKnownValues.FutureCalculationType_TotalPaid:
                        handler.string_value("TotalPaid");
                        break;
                    case TypeFutureCalculationTypeKnownValues.FutureCalculationType_PrincipalPaid:
                        handler.string_value("PrincipalPaid");
                        break;
                    case TypeFutureCalculationTypeKnownValues.FutureCalculationType_PrincipalOwing:
                        handler.string_value("PrincipalOwing");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeFutureCalculationType.string_value);
              }
          }
        Debug.Assert(partial_allowed || flagHasRequestType);
        if (flagHasRequestType)
          {
            handler.start_pair("RequestType");
            if (storeRequestType.in_known_list)
              {
                switch (storeRequestType.list_value)
                  {
                    case TypeRequestTypeKnownValues.RequestType_Unknown:
                        handler.string_value("Unknown");
                        break;
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
                    case TypeRequestTypeKnownValues.RequestType_AskYearRange:
                        handler.string_value("AskYearRange");
                        break;
                    case TypeRequestTypeKnownValues.RequestType_AskYearOwing:
                        handler.string_value("AskYearOwing");
                        break;
                    case TypeRequestTypeKnownValues.RequestType_AskPrincipalOrHomeValue:
                        handler.string_value("AskPrincipalOrHomeValue");
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
        if (flagHasLastRequest)
          {
            handler.start_pair("LastRequest");
            if (storeLastRequest.in_known_list)
              {
                switch (storeLastRequest.list_value)
                  {
                    case TypeLastRequestKnownValues.LastRequest_Unknown:
                        handler.string_value("Unknown");
                        break;
                    case TypeLastRequestKnownValues.LastRequest_AskPrincipal:
                        handler.string_value("AskPrincipal");
                        break;
                    case TypeLastRequestKnownValues.LastRequest_AskInterestRate:
                        handler.string_value("AskInterestRate");
                        break;
                    case TypeLastRequestKnownValues.LastRequest_AskAmortization:
                        handler.string_value("AskAmortization");
                        break;
                    case TypeLastRequestKnownValues.LastRequest_AskHomeValue:
                        handler.string_value("AskHomeValue");
                        break;
                    case TypeLastRequestKnownValues.LastRequest_AskDownPayment:
                        handler.string_value("AskDownPayment");
                        break;
                    case TypeLastRequestKnownValues.LastRequest_AskMonthlyPayment:
                        handler.string_value("AskMonthlyPayment");
                        break;
                    case TypeLastRequestKnownValues.LastRequest_ShowPayment:
                        handler.string_value("ShowPayment");
                        break;
                    case TypeLastRequestKnownValues.LastRequest_ShowTotalInterest:
                        handler.string_value("ShowTotalInterest");
                        break;
                    case TypeLastRequestKnownValues.LastRequest_ShowTotalPaid:
                        handler.string_value("ShowTotalPaid");
                        break;
                    case TypeLastRequestKnownValues.LastRequest_ShowDownPayment:
                        handler.string_value("ShowDownPayment");
                        break;
                    case TypeLastRequestKnownValues.LastRequest_ShowInterestRate:
                        handler.string_value("ShowInterestRate");
                        break;
                    case TypeLastRequestKnownValues.LastRequest_ShowAmortization:
                        handler.string_value("ShowAmortization");
                        break;
                    case TypeLastRequestKnownValues.LastRequest_ShowPrincipalPaid:
                        handler.string_value("ShowPrincipalPaid");
                        break;
                    case TypeLastRequestKnownValues.LastRequest_ShowPrincipal:
                        handler.string_value("ShowPrincipal");
                        break;
                    case TypeLastRequestKnownValues.LastRequest_ShowPrincipalOwing:
                        handler.string_value("ShowPrincipalOwing");
                        break;
                    case TypeLastRequestKnownValues.LastRequest_ShowHomeValue:
                        handler.string_value("ShowHomeValue");
                        break;
                    case TypeLastRequestKnownValues.LastRequest_AskYearRange:
                        handler.string_value("AskYearRange");
                        break;
                    case TypeLastRequestKnownValues.LastRequest_AskYearOwing:
                        handler.string_value("AskYearOwing");
                        break;
                    case TypeLastRequestKnownValues.LastRequest_AskPrincipalOrHomeValue:
                        handler.string_value("AskPrincipalOrHomeValue");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeLastRequest.string_value);
              }
          }
        if (flagHasInterestRate)
          {
            handler.start_pair("InterestRate");
            if (textStoreInterestRate != "")
                handler.number_value(textStoreInterestRate);
            else if (((double)(long)storeInterestRate) == storeInterestRate)
                handler.number_value((long)storeInterestRate);
            else
                handler.number_value(storeInterestRate);
          }
        if (flagHasInterestRateIsNew)
          {
            handler.start_pair("InterestRateIsNew");
            handler.boolean_value(storeInterestRateIsNew);
          }
        if (flagHasMortgagePrincipal)
          {
            handler.start_pair("MortgagePrincipal");
            if (partial_allowed)
                storeMortgagePrincipal.write_partial_as_json(handler);
            else
                storeMortgagePrincipal.write_as_json(handler);
          }
        if (flagHasMortgagePrincipalIsNew)
          {
            handler.start_pair("MortgagePrincipalIsNew");
            handler.boolean_value(storeMortgagePrincipalIsNew);
          }
        if (flagHasPrincipalHomeValueAmbiguous)
          {
            handler.start_pair("PrincipalHomeValueAmbiguous");
            handler.boolean_value(storePrincipalHomeValueAmbiguous);
          }
        if (flagHasPrincipalHomeValueAmbiguousConfirmed)
          {
            handler.start_pair("PrincipalHomeValueAmbiguousConfirmed");
            handler.boolean_value(storePrincipalHomeValueAmbiguousConfirmed);
          }
        if (flagHasNumMonths)
          {
            handler.start_pair("NumMonths");
            handler.number_value(storeNumMonths);
          }
        if (flagHasNumMonthsIsNew)
          {
            handler.start_pair("NumMonthsIsNew");
            handler.boolean_value(storeNumMonthsIsNew);
          }
        if (flagHasYearStart)
          {
            handler.start_pair("YearStart");
            handler.number_value(storeYearStart);
          }
        if (flagHasYearEnd)
          {
            handler.start_pair("YearEnd");
            handler.number_value(storeYearEnd);
          }
        if (flagHasYearStartEndIsNew)
          {
            handler.start_pair("YearStartEndIsNew");
            handler.boolean_value(storeYearStartEndIsNew);
          }
        if (flagHasYearEndOwing)
          {
            handler.start_pair("YearEndOwing");
            handler.number_value(storeYearEndOwing);
          }
        if (flagHasYearEndOwingIsNew)
          {
            handler.start_pair("YearEndOwingIsNew");
            handler.boolean_value(storeYearEndOwingIsNew);
          }
        if (flagHasDownPaymentPercent)
          {
            handler.start_pair("DownPaymentPercent");
            if (textStoreDownPaymentPercent != "")
                handler.number_value(textStoreDownPaymentPercent);
            else if (((double)(long)storeDownPaymentPercent) == storeDownPaymentPercent)
                handler.number_value((long)storeDownPaymentPercent);
            else
                handler.number_value(storeDownPaymentPercent);
          }
        if (flagHasDownPaymentPercentIsNew)
          {
            handler.start_pair("DownPaymentPercentIsNew");
            handler.boolean_value(storeDownPaymentPercentIsNew);
          }
        if (flagHasDownPayment)
          {
            handler.start_pair("DownPayment");
            if (partial_allowed)
                storeDownPayment.write_partial_as_json(handler);
            else
                storeDownPayment.write_as_json(handler);
          }
        if (flagHasDownPaymentIsNew)
          {
            handler.start_pair("DownPaymentIsNew");
            handler.boolean_value(storeDownPaymentIsNew);
          }
        if (flagHasHomeValue)
          {
            handler.start_pair("HomeValue");
            if (partial_allowed)
                storeHomeValue.write_partial_as_json(handler);
            else
                storeHomeValue.write_as_json(handler);
          }
        if (flagHasHomeValueIsNew)
          {
            handler.start_pair("HomeValueIsNew");
            handler.boolean_value(storeHomeValueIsNew);
          }
        if (flagHasMaxPaymentAmount)
          {
            handler.start_pair("MaxPaymentAmount");
            if (partial_allowed)
                storeMaxPaymentAmount.write_partial_as_json(handler);
            else
                storeMaxPaymentAmount.write_as_json(handler);
          }
        if (flagHasMaxPaymentAmountIsNew)
          {
            handler.start_pair("MaxPaymentAmountIsNew");
            handler.boolean_value(storeMaxPaymentAmountIsNew);
          }
        if (flagHasDoNotKnow)
          {
            handler.start_pair("DoNotKnow");
            handler.boolean_value(storeDoNotKnow);
          }
        if (flagHasWantToKnow)
          {
            handler.start_pair("WantToKnow");
            handler.boolean_value(storeWantToKnow);
          }
        if (flagHasMortgageCalculatorStart)
          {
            handler.start_pair("MortgageCalculatorStart");
            handler.boolean_value(storeMortgageCalculatorStart);
          }
        if (flagHasDefaultCurrency)
          {
            handler.start_pair("DefaultCurrency");
            if (partial_allowed)
                storeDefaultCurrency.write_partial_as_json(handler);
            else
                storeDefaultCurrency.write_as_json(handler);
          }
        if (flagHasUserConfused)
          {
            handler.start_pair("UserConfused");
            handler.boolean_value(storeUserConfused);
          }
        if (flagHasPaymentFrequency)
          {
            handler.start_pair("PaymentFrequency");
            if (storePaymentFrequency.in_known_list)
              {
                switch (storePaymentFrequency.list_value)
                  {
                    case TypePaymentFrequencyKnownValues.PaymentFrequency_monthly:
                        handler.string_value("monthly");
                        break;
                    case TypePaymentFrequencyKnownValues.PaymentFrequency_biweekly:
                        handler.string_value("biweekly");
                        break;
                    case TypePaymentFrequencyKnownValues.PaymentFrequency_weekly:
                        handler.string_value("weekly");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storePaymentFrequency.string_value);
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
        if (!(hasCalculationType()))
          {
            return "When parsing the object for %what%, the \"CalculationType\" field was missing.";
          }
        if (!(hasRequestType()))
          {
            return "When parsing the object for %what%, the \"RequestType\" field was missing.";
          }
        return null;
      }

    public static MortgageCalculatorInputDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MortgageCalculatorInputDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputData", ignore_extras);
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
    public static MortgageCalculatorInputDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MortgageCalculatorInputDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MortgageCalculatorInputDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputData", ignore_extras);
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
    public static MortgageCalculatorInputDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MortgageCalculatorInputDataJSON from_text(string text, bool ignore_extras)
      {
        MortgageCalculatorInputDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MortgageCalculatorInputDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MortgageCalculatorInputDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MortgageCalculatorInputDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
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
        private JSONHoldingBooleanGenerator fieldGeneratorCalculationTypeIsNew;
    private abstract class FieldGeneratorFutureCalculationType : JSONStringGenerator
          {
            protected FieldGeneratorFutureCalculationType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorFutureCalculationType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeFutureCalculationTypeKnownValues known = stringToFutureCalculationType(result);
                TypeFutureCalculationType new_value = new TypeFutureCalculationType();
                if (known == TypeFutureCalculationTypeKnownValues.FutureCalculationType__none)
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
            protected abstract void handle_result(TypeFutureCalculationType result);
          };
    private class FieldHoldingGeneratorFutureCalculationType : FieldGeneratorFutureCalculationType
  {
    protected override void handle_result(TypeFutureCalculationType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorFutureCalculationType(String what)
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
    public TypeFutureCalculationType value;
  };
    private class FieldHoldingArrayGeneratorFutureCalculationType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorFutureCalculationType
      {
        private FieldHoldingArrayGeneratorFutureCalculationType top;

        protected override void handle_result(TypeFutureCalculationType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorFutureCalculationType init_top)
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
    protected virtual void handle_result(List<TypeFutureCalculationType> result)
      {
      }

    public FieldHoldingArrayGeneratorFutureCalculationType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFutureCalculationType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorFutureCalculationType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFutureCalculationType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeFutureCalculationType> value;
  };
        private FieldHoldingGeneratorFutureCalculationType fieldGeneratorFutureCalculationType;
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
    private abstract class FieldGeneratorLastRequest : JSONStringGenerator
          {
            protected FieldGeneratorLastRequest(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorLastRequest()
              {
              }
            protected override void handle_result(string result)
              {
                TypeLastRequestKnownValues known = stringToLastRequest(result);
                TypeLastRequest new_value = new TypeLastRequest();
                if (known == TypeLastRequestKnownValues.LastRequest__none)
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
            protected abstract void handle_result(TypeLastRequest result);
          };
    private class FieldHoldingGeneratorLastRequest : FieldGeneratorLastRequest
  {
    protected override void handle_result(TypeLastRequest result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorLastRequest(String what)
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
    public TypeLastRequest value;
  };
    private class FieldHoldingArrayGeneratorLastRequest : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorLastRequest
      {
        private FieldHoldingArrayGeneratorLastRequest top;

        protected override void handle_result(TypeLastRequest result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorLastRequest init_top)
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
    protected virtual void handle_result(List<TypeLastRequest> result)
      {
      }

    public FieldHoldingArrayGeneratorLastRequest(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeLastRequest>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorLastRequest()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeLastRequest>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeLastRequest> value;
  };
        private FieldHoldingGeneratorLastRequest fieldGeneratorLastRequest;
        private JSONHoldingNumberTextGenerator fieldGeneratorInterestRate;
        private JSONHoldingBooleanGenerator fieldGeneratorInterestRateIsNew;
        private MoneyJSON.HoldingGenerator fieldGeneratorMortgagePrincipal;
        private JSONHoldingBooleanGenerator fieldGeneratorMortgagePrincipalIsNew;
        private JSONHoldingBooleanGenerator fieldGeneratorPrincipalHomeValueAmbiguous;
        private JSONHoldingBooleanGenerator fieldGeneratorPrincipalHomeValueAmbiguousConfirmed;
    private class FieldHoldingGeneratorNumMonths : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorNumMonths(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorNumMonths : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorNumMonths(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorNumMonths fieldGeneratorNumMonths;
        private JSONHoldingBooleanGenerator fieldGeneratorNumMonthsIsNew;
    private class FieldHoldingGeneratorYearStart : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorYearStart(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorYearStart : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorYearStart(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorYearStart fieldGeneratorYearStart;
    private class FieldHoldingGeneratorYearEnd : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorYearEnd(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorYearEnd : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorYearEnd(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorYearEnd fieldGeneratorYearEnd;
        private JSONHoldingBooleanGenerator fieldGeneratorYearStartEndIsNew;
    private class FieldHoldingGeneratorYearEndOwing : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorYearEndOwing(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorYearEndOwing : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorYearEndOwing(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorYearEndOwing fieldGeneratorYearEndOwing;
        private JSONHoldingBooleanGenerator fieldGeneratorYearEndOwingIsNew;
        private JSONHoldingNumberTextGenerator fieldGeneratorDownPaymentPercent;
        private JSONHoldingBooleanGenerator fieldGeneratorDownPaymentPercentIsNew;
        private MoneyJSON.HoldingGenerator fieldGeneratorDownPayment;
        private JSONHoldingBooleanGenerator fieldGeneratorDownPaymentIsNew;
        private MoneyJSON.HoldingGenerator fieldGeneratorHomeValue;
        private JSONHoldingBooleanGenerator fieldGeneratorHomeValueIsNew;
        private MoneyJSON.HoldingGenerator fieldGeneratorMaxPaymentAmount;
        private JSONHoldingBooleanGenerator fieldGeneratorMaxPaymentAmountIsNew;
        private JSONHoldingBooleanGenerator fieldGeneratorDoNotKnow;
        private JSONHoldingBooleanGenerator fieldGeneratorWantToKnow;
        private JSONHoldingBooleanGenerator fieldGeneratorMortgageCalculatorStart;
        private MoneyJSON.HoldingGenerator fieldGeneratorDefaultCurrency;
        private JSONHoldingBooleanGenerator fieldGeneratorUserConfused;
    private abstract class FieldGeneratorPaymentFrequency : JSONStringGenerator
          {
            protected FieldGeneratorPaymentFrequency(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorPaymentFrequency()
              {
              }
            protected override void handle_result(string result)
              {
                TypePaymentFrequencyKnownValues known = stringToPaymentFrequency(result);
                TypePaymentFrequency new_value = new TypePaymentFrequency();
                if (known == TypePaymentFrequencyKnownValues.PaymentFrequency__none)
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
            protected abstract void handle_result(TypePaymentFrequency result);
          };
    private class FieldHoldingGeneratorPaymentFrequency : FieldGeneratorPaymentFrequency
  {
    protected override void handle_result(TypePaymentFrequency result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorPaymentFrequency(String what)
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
    public TypePaymentFrequency value;
  };
    private class FieldHoldingArrayGeneratorPaymentFrequency : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorPaymentFrequency
      {
        private FieldHoldingArrayGeneratorPaymentFrequency top;

        protected override void handle_result(TypePaymentFrequency result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorPaymentFrequency init_top)
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
    protected virtual void handle_result(List<TypePaymentFrequency> result)
      {
      }

    public FieldHoldingArrayGeneratorPaymentFrequency(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypePaymentFrequency>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorPaymentFrequency()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypePaymentFrequency>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypePaymentFrequency> value;
  };
        private FieldHoldingGeneratorPaymentFrequency fieldGeneratorPaymentFrequency;
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
            MortgageCalculatorInputDataJSON result = new MortgageCalculatorInputDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMortgageCalculatorInputDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(MortgageCalculatorInputDataJSON result)
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
            if (fieldGeneratorCalculationTypeIsNew.have_value)
              {
                result.setCalculationTypeIsNew(fieldGeneratorCalculationTypeIsNew.value);
                fieldGeneratorCalculationTypeIsNew.have_value = false;
              }
            if (fieldGeneratorFutureCalculationType.have_value)
              {
                result.setFutureCalculationType(fieldGeneratorFutureCalculationType.value);
                fieldGeneratorFutureCalculationType.have_value = false;
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
            if (fieldGeneratorLastRequest.have_value)
              {
                result.setLastRequest(fieldGeneratorLastRequest.value);
                fieldGeneratorLastRequest.have_value = false;
              }
            if (fieldGeneratorInterestRate.have_value)
              {
                result.setInterestRateText(fieldGeneratorInterestRate.value);
                fieldGeneratorInterestRate.have_value = false;
              }
            if (fieldGeneratorInterestRateIsNew.have_value)
              {
                result.setInterestRateIsNew(fieldGeneratorInterestRateIsNew.value);
                fieldGeneratorInterestRateIsNew.have_value = false;
              }
            if (fieldGeneratorMortgagePrincipal.have_value)
              {
                result.setMortgagePrincipal(fieldGeneratorMortgagePrincipal.value);
                fieldGeneratorMortgagePrincipal.have_value = false;
              }
            if (fieldGeneratorMortgagePrincipalIsNew.have_value)
              {
                result.setMortgagePrincipalIsNew(fieldGeneratorMortgagePrincipalIsNew.value);
                fieldGeneratorMortgagePrincipalIsNew.have_value = false;
              }
            if (fieldGeneratorPrincipalHomeValueAmbiguous.have_value)
              {
                result.setPrincipalHomeValueAmbiguous(fieldGeneratorPrincipalHomeValueAmbiguous.value);
                fieldGeneratorPrincipalHomeValueAmbiguous.have_value = false;
              }
            if (fieldGeneratorPrincipalHomeValueAmbiguousConfirmed.have_value)
              {
                result.setPrincipalHomeValueAmbiguousConfirmed(fieldGeneratorPrincipalHomeValueAmbiguousConfirmed.value);
                fieldGeneratorPrincipalHomeValueAmbiguousConfirmed.have_value = false;
              }
            if (fieldGeneratorNumMonths.have_value)
              {
                result.setNumMonths(fieldGeneratorNumMonths.value);
                fieldGeneratorNumMonths.have_value = false;
              }
            if (fieldGeneratorNumMonthsIsNew.have_value)
              {
                result.setNumMonthsIsNew(fieldGeneratorNumMonthsIsNew.value);
                fieldGeneratorNumMonthsIsNew.have_value = false;
              }
            if (fieldGeneratorYearStart.have_value)
              {
                result.setYearStart(fieldGeneratorYearStart.value);
                fieldGeneratorYearStart.have_value = false;
              }
            if (fieldGeneratorYearEnd.have_value)
              {
                result.setYearEnd(fieldGeneratorYearEnd.value);
                fieldGeneratorYearEnd.have_value = false;
              }
            if (fieldGeneratorYearStartEndIsNew.have_value)
              {
                result.setYearStartEndIsNew(fieldGeneratorYearStartEndIsNew.value);
                fieldGeneratorYearStartEndIsNew.have_value = false;
              }
            if (fieldGeneratorYearEndOwing.have_value)
              {
                result.setYearEndOwing(fieldGeneratorYearEndOwing.value);
                fieldGeneratorYearEndOwing.have_value = false;
              }
            if (fieldGeneratorYearEndOwingIsNew.have_value)
              {
                result.setYearEndOwingIsNew(fieldGeneratorYearEndOwingIsNew.value);
                fieldGeneratorYearEndOwingIsNew.have_value = false;
              }
            if (fieldGeneratorDownPaymentPercent.have_value)
              {
                result.setDownPaymentPercentText(fieldGeneratorDownPaymentPercent.value);
                fieldGeneratorDownPaymentPercent.have_value = false;
              }
            if (fieldGeneratorDownPaymentPercentIsNew.have_value)
              {
                result.setDownPaymentPercentIsNew(fieldGeneratorDownPaymentPercentIsNew.value);
                fieldGeneratorDownPaymentPercentIsNew.have_value = false;
              }
            if (fieldGeneratorDownPayment.have_value)
              {
                result.setDownPayment(fieldGeneratorDownPayment.value);
                fieldGeneratorDownPayment.have_value = false;
              }
            if (fieldGeneratorDownPaymentIsNew.have_value)
              {
                result.setDownPaymentIsNew(fieldGeneratorDownPaymentIsNew.value);
                fieldGeneratorDownPaymentIsNew.have_value = false;
              }
            if (fieldGeneratorHomeValue.have_value)
              {
                result.setHomeValue(fieldGeneratorHomeValue.value);
                fieldGeneratorHomeValue.have_value = false;
              }
            if (fieldGeneratorHomeValueIsNew.have_value)
              {
                result.setHomeValueIsNew(fieldGeneratorHomeValueIsNew.value);
                fieldGeneratorHomeValueIsNew.have_value = false;
              }
            if (fieldGeneratorMaxPaymentAmount.have_value)
              {
                result.setMaxPaymentAmount(fieldGeneratorMaxPaymentAmount.value);
                fieldGeneratorMaxPaymentAmount.have_value = false;
              }
            if (fieldGeneratorMaxPaymentAmountIsNew.have_value)
              {
                result.setMaxPaymentAmountIsNew(fieldGeneratorMaxPaymentAmountIsNew.value);
                fieldGeneratorMaxPaymentAmountIsNew.have_value = false;
              }
            if (fieldGeneratorDoNotKnow.have_value)
              {
                result.setDoNotKnow(fieldGeneratorDoNotKnow.value);
                fieldGeneratorDoNotKnow.have_value = false;
              }
            if (fieldGeneratorWantToKnow.have_value)
              {
                result.setWantToKnow(fieldGeneratorWantToKnow.value);
                fieldGeneratorWantToKnow.have_value = false;
              }
            if (fieldGeneratorMortgageCalculatorStart.have_value)
              {
                result.setMortgageCalculatorStart(fieldGeneratorMortgageCalculatorStart.value);
                fieldGeneratorMortgageCalculatorStart.have_value = false;
              }
            if (fieldGeneratorDefaultCurrency.have_value)
              {
                result.setDefaultCurrency(fieldGeneratorDefaultCurrency.value);
                fieldGeneratorDefaultCurrency.have_value = false;
              }
            if (fieldGeneratorUserConfused.have_value)
              {
                result.setUserConfused(fieldGeneratorUserConfused.value);
                fieldGeneratorUserConfused.have_value = false;
              }
            if (fieldGeneratorPaymentFrequency.have_value)
              {
                result.setPaymentFrequency(fieldGeneratorPaymentFrequency.value);
                fieldGeneratorPaymentFrequency.have_value = false;
              }
          }
        protected abstract void handle_result(MortgageCalculatorInputDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if (String.Compare(field_name, 1, "alculationType", 0, 14, false) == 0)
                      {
                        if (field_name.Length == 15)
                          {
                            return fieldGeneratorCalculationType;
                          }
                        switch (field_name[15])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 16, "sNew", 0, 4, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorCalculationTypeIsNew;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'D':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "faultCurrency", 0, 13, false) == 0) && (field_name.Length == 15))
                                return fieldGeneratorDefaultCurrency;
                            break;
                        case 'o':
                            switch (field_name[2])
                              {
                                case 'N':
                                    if ((String.Compare(field_name, 3, "otKnow", 0, 6, false) == 0) && (field_name.Length == 9))
                                        return fieldGeneratorDoNotKnow;
                                    break;
                                case 'w':
                                    if (String.Compare(field_name, 3, "nPayment", 0, 8, false) == 0)
                                      {
                                        if (field_name.Length == 11)
                                          {
                                            return fieldGeneratorDownPayment;
                                          }
                                        switch (field_name[11])
                                          {
                                            case 'I':
                                                if ((String.Compare(field_name, 12, "sNew", 0, 4, false) == 0) && (field_name.Length == 16))
                                                    return fieldGeneratorDownPaymentIsNew;
                                                break;
                                            case 'P':
                                                if (String.Compare(field_name, 12, "ercent", 0, 6, false) == 0)
                                                  {
                                                    if (field_name.Length == 18)
                                                      {
                                                        return fieldGeneratorDownPaymentPercent;
                                                      }
                                                    switch (field_name[18])
                                                      {
                                                        case 'I':
                                                            if ((String.Compare(field_name, 19, "sNew", 0, 4, false) == 0) && (field_name.Length == 23))
                                                                return fieldGeneratorDownPaymentPercentIsNew;
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
                            break;
                        default:
                            break;
                      }
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "utureCalculationType", 0, 20, false) == 0) && (field_name.Length == 21))
                        return fieldGeneratorFutureCalculationType;
                    break;
                case 'H':
                    if (String.Compare(field_name, 1, "omeValue", 0, 8, false) == 0)
                      {
                        if (field_name.Length == 9)
                          {
                            return fieldGeneratorHomeValue;
                          }
                        switch (field_name[9])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 10, "sNew", 0, 4, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorHomeValueIsNew;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'I':
                    if (String.Compare(field_name, 1, "nterestRate", 0, 11, false) == 0)
                      {
                        if (field_name.Length == 12)
                          {
                            return fieldGeneratorInterestRate;
                          }
                        switch (field_name[12])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 13, "sNew", 0, 4, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorInterestRateIsNew;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "astRequest", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorLastRequest;
                    break;
                case 'M':
                    switch (field_name[1])
                      {
                        case 'a':
                            if (String.Compare(field_name, 2, "xPaymentAmount", 0, 14, false) == 0)
                              {
                                if (field_name.Length == 16)
                                  {
                                    return fieldGeneratorMaxPaymentAmount;
                                  }
                                switch (field_name[16])
                                  {
                                    case 'I':
                                        if ((String.Compare(field_name, 17, "sNew", 0, 4, false) == 0) && (field_name.Length == 21))
                                            return fieldGeneratorMaxPaymentAmountIsNew;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'o':
                            if (String.Compare(field_name, 2, "rtgage", 0, 6, false) == 0)
                              {
                                switch (field_name[8])
                                  {
                                    case 'C':
                                        if ((String.Compare(field_name, 9, "alculatorStart", 0, 14, false) == 0) && (field_name.Length == 23))
                                            return fieldGeneratorMortgageCalculatorStart;
                                        break;
                                    case 'P':
                                        if (String.Compare(field_name, 9, "rincipal", 0, 8, false) == 0)
                                          {
                                            if (field_name.Length == 17)
                                              {
                                                return fieldGeneratorMortgagePrincipal;
                                              }
                                            switch (field_name[17])
                                              {
                                                case 'I':
                                                    if ((String.Compare(field_name, 18, "sNew", 0, 4, false) == 0) && (field_name.Length == 22))
                                                        return fieldGeneratorMortgagePrincipalIsNew;
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
                    break;
                case 'N':
                    if (String.Compare(field_name, 1, "umMonths", 0, 8, false) == 0)
                      {
                        if (field_name.Length == 9)
                          {
                            return fieldGeneratorNumMonths;
                          }
                        switch (field_name[9])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 10, "sNew", 0, 4, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorNumMonthsIsNew;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'P':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "ymentFrequency", 0, 14, false) == 0) && (field_name.Length == 16))
                                return fieldGeneratorPaymentFrequency;
                            break;
                        case 'r':
                            if (String.Compare(field_name, 2, "incipalHomeValueAmbiguous", 0, 25, false) == 0)
                              {
                                if (field_name.Length == 27)
                                  {
                                    return fieldGeneratorPrincipalHomeValueAmbiguous;
                                  }
                                switch (field_name[27])
                                  {
                                    case 'C':
                                        if ((String.Compare(field_name, 28, "onfirmed", 0, 8, false) == 0) && (field_name.Length == 36))
                                            return fieldGeneratorPrincipalHomeValueAmbiguousConfirmed;
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
                case 'R':
                    if ((String.Compare(field_name, 1, "equestType", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorRequestType;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "serConfused", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorUserConfused;
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "antToKnow", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorWantToKnow;
                    break;
                case 'Y':
                    if (String.Compare(field_name, 1, "ear", 0, 3, false) == 0)
                      {
                        switch (field_name[4])
                          {
                            case 'E':
                                if (String.Compare(field_name, 5, "nd", 0, 2, false) == 0)
                                  {
                                    if (field_name.Length == 7)
                                      {
                                        return fieldGeneratorYearEnd;
                                      }
                                    switch (field_name[7])
                                      {
                                        case 'O':
                                            if (String.Compare(field_name, 8, "wing", 0, 4, false) == 0)
                                              {
                                                if (field_name.Length == 12)
                                                  {
                                                    return fieldGeneratorYearEndOwing;
                                                  }
                                                switch (field_name[12])
                                                  {
                                                    case 'I':
                                                        if ((String.Compare(field_name, 13, "sNew", 0, 4, false) == 0) && (field_name.Length == 17))
                                                            return fieldGeneratorYearEndOwingIsNew;
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
                                if (String.Compare(field_name, 5, "tart", 0, 4, false) == 0)
                                  {
                                    if (field_name.Length == 9)
                                      {
                                        return fieldGeneratorYearStart;
                                      }
                                    switch (field_name[9])
                                      {
                                        case 'E':
                                            if ((String.Compare(field_name, 10, "ndIsNew", 0, 7, false) == 0) && (field_name.Length == 17))
                                                return fieldGeneratorYearStartEndIsNew;
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
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorCalculationType = new FieldHoldingGeneratorCalculationType("field \"CalculationType\" of the MortgageCalculatorInputData class");
            fieldGeneratorCalculationTypeIsNew = new JSONHoldingBooleanGenerator("field \"CalculationTypeIsNew\" of the MortgageCalculatorInputData class");
            fieldGeneratorFutureCalculationType = new FieldHoldingGeneratorFutureCalculationType("field \"FutureCalculationType\" of the MortgageCalculatorInputData class");
            fieldGeneratorRequestType = new FieldHoldingGeneratorRequestType("field \"RequestType\" of the MortgageCalculatorInputData class");
            fieldGeneratorLastRequest = new FieldHoldingGeneratorLastRequest("field \"LastRequest\" of the MortgageCalculatorInputData class");
            fieldGeneratorInterestRate = new JSONHoldingNumberTextGenerator("field \"InterestRate\" of the MortgageCalculatorInputData class");
            fieldGeneratorInterestRateIsNew = new JSONHoldingBooleanGenerator("field \"InterestRateIsNew\" of the MortgageCalculatorInputData class");
            fieldGeneratorMortgagePrincipal = new MoneyJSON.HoldingGenerator("field \"MortgagePrincipal\" of the MortgageCalculatorInputData class", ignore_extras);
            fieldGeneratorMortgagePrincipalIsNew = new JSONHoldingBooleanGenerator("field \"MortgagePrincipalIsNew\" of the MortgageCalculatorInputData class");
            fieldGeneratorPrincipalHomeValueAmbiguous = new JSONHoldingBooleanGenerator("field \"PrincipalHomeValueAmbiguous\" of the MortgageCalculatorInputData class");
            fieldGeneratorPrincipalHomeValueAmbiguousConfirmed = new JSONHoldingBooleanGenerator("field \"PrincipalHomeValueAmbiguousConfirmed\" of the MortgageCalculatorInputData class");
            fieldGeneratorNumMonths = new FieldHoldingGeneratorNumMonths("field \"NumMonths\" of the MortgageCalculatorInputData class");
            fieldGeneratorNumMonthsIsNew = new JSONHoldingBooleanGenerator("field \"NumMonthsIsNew\" of the MortgageCalculatorInputData class");
            fieldGeneratorYearStart = new FieldHoldingGeneratorYearStart("field \"YearStart\" of the MortgageCalculatorInputData class");
            fieldGeneratorYearEnd = new FieldHoldingGeneratorYearEnd("field \"YearEnd\" of the MortgageCalculatorInputData class");
            fieldGeneratorYearStartEndIsNew = new JSONHoldingBooleanGenerator("field \"YearStartEndIsNew\" of the MortgageCalculatorInputData class");
            fieldGeneratorYearEndOwing = new FieldHoldingGeneratorYearEndOwing("field \"YearEndOwing\" of the MortgageCalculatorInputData class");
            fieldGeneratorYearEndOwingIsNew = new JSONHoldingBooleanGenerator("field \"YearEndOwingIsNew\" of the MortgageCalculatorInputData class");
            fieldGeneratorDownPaymentPercent = new JSONHoldingNumberTextGenerator("field \"DownPaymentPercent\" of the MortgageCalculatorInputData class");
            fieldGeneratorDownPaymentPercentIsNew = new JSONHoldingBooleanGenerator("field \"DownPaymentPercentIsNew\" of the MortgageCalculatorInputData class");
            fieldGeneratorDownPayment = new MoneyJSON.HoldingGenerator("field \"DownPayment\" of the MortgageCalculatorInputData class", ignore_extras);
            fieldGeneratorDownPaymentIsNew = new JSONHoldingBooleanGenerator("field \"DownPaymentIsNew\" of the MortgageCalculatorInputData class");
            fieldGeneratorHomeValue = new MoneyJSON.HoldingGenerator("field \"HomeValue\" of the MortgageCalculatorInputData class", ignore_extras);
            fieldGeneratorHomeValueIsNew = new JSONHoldingBooleanGenerator("field \"HomeValueIsNew\" of the MortgageCalculatorInputData class");
            fieldGeneratorMaxPaymentAmount = new MoneyJSON.HoldingGenerator("field \"MaxPaymentAmount\" of the MortgageCalculatorInputData class", ignore_extras);
            fieldGeneratorMaxPaymentAmountIsNew = new JSONHoldingBooleanGenerator("field \"MaxPaymentAmountIsNew\" of the MortgageCalculatorInputData class");
            fieldGeneratorDoNotKnow = new JSONHoldingBooleanGenerator("field \"DoNotKnow\" of the MortgageCalculatorInputData class");
            fieldGeneratorWantToKnow = new JSONHoldingBooleanGenerator("field \"WantToKnow\" of the MortgageCalculatorInputData class");
            fieldGeneratorMortgageCalculatorStart = new JSONHoldingBooleanGenerator("field \"MortgageCalculatorStart\" of the MortgageCalculatorInputData class");
            fieldGeneratorDefaultCurrency = new MoneyJSON.HoldingGenerator("field \"DefaultCurrency\" of the MortgageCalculatorInputData class", ignore_extras);
            fieldGeneratorUserConfused = new JSONHoldingBooleanGenerator("field \"UserConfused\" of the MortgageCalculatorInputData class");
            fieldGeneratorPaymentFrequency = new FieldHoldingGeneratorPaymentFrequency("field \"PaymentFrequency\" of the MortgageCalculatorInputData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MortgageCalculatorInputData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorCalculationType = new FieldHoldingGeneratorCalculationType("field \"CalculationType\" of the MortgageCalculatorInputData class");
            fieldGeneratorCalculationTypeIsNew = new JSONHoldingBooleanGenerator("field \"CalculationTypeIsNew\" of the MortgageCalculatorInputData class");
            fieldGeneratorFutureCalculationType = new FieldHoldingGeneratorFutureCalculationType("field \"FutureCalculationType\" of the MortgageCalculatorInputData class");
            fieldGeneratorRequestType = new FieldHoldingGeneratorRequestType("field \"RequestType\" of the MortgageCalculatorInputData class");
            fieldGeneratorLastRequest = new FieldHoldingGeneratorLastRequest("field \"LastRequest\" of the MortgageCalculatorInputData class");
            fieldGeneratorInterestRate = new JSONHoldingNumberTextGenerator("field \"InterestRate\" of the MortgageCalculatorInputData class");
            fieldGeneratorInterestRateIsNew = new JSONHoldingBooleanGenerator("field \"InterestRateIsNew\" of the MortgageCalculatorInputData class");
            fieldGeneratorMortgagePrincipal = new MoneyJSON.HoldingGenerator("field \"MortgagePrincipal\" of the MortgageCalculatorInputData class", false);
            fieldGeneratorMortgagePrincipalIsNew = new JSONHoldingBooleanGenerator("field \"MortgagePrincipalIsNew\" of the MortgageCalculatorInputData class");
            fieldGeneratorPrincipalHomeValueAmbiguous = new JSONHoldingBooleanGenerator("field \"PrincipalHomeValueAmbiguous\" of the MortgageCalculatorInputData class");
            fieldGeneratorPrincipalHomeValueAmbiguousConfirmed = new JSONHoldingBooleanGenerator("field \"PrincipalHomeValueAmbiguousConfirmed\" of the MortgageCalculatorInputData class");
            fieldGeneratorNumMonths = new FieldHoldingGeneratorNumMonths("field \"NumMonths\" of the MortgageCalculatorInputData class");
            fieldGeneratorNumMonthsIsNew = new JSONHoldingBooleanGenerator("field \"NumMonthsIsNew\" of the MortgageCalculatorInputData class");
            fieldGeneratorYearStart = new FieldHoldingGeneratorYearStart("field \"YearStart\" of the MortgageCalculatorInputData class");
            fieldGeneratorYearEnd = new FieldHoldingGeneratorYearEnd("field \"YearEnd\" of the MortgageCalculatorInputData class");
            fieldGeneratorYearStartEndIsNew = new JSONHoldingBooleanGenerator("field \"YearStartEndIsNew\" of the MortgageCalculatorInputData class");
            fieldGeneratorYearEndOwing = new FieldHoldingGeneratorYearEndOwing("field \"YearEndOwing\" of the MortgageCalculatorInputData class");
            fieldGeneratorYearEndOwingIsNew = new JSONHoldingBooleanGenerator("field \"YearEndOwingIsNew\" of the MortgageCalculatorInputData class");
            fieldGeneratorDownPaymentPercent = new JSONHoldingNumberTextGenerator("field \"DownPaymentPercent\" of the MortgageCalculatorInputData class");
            fieldGeneratorDownPaymentPercentIsNew = new JSONHoldingBooleanGenerator("field \"DownPaymentPercentIsNew\" of the MortgageCalculatorInputData class");
            fieldGeneratorDownPayment = new MoneyJSON.HoldingGenerator("field \"DownPayment\" of the MortgageCalculatorInputData class", false);
            fieldGeneratorDownPaymentIsNew = new JSONHoldingBooleanGenerator("field \"DownPaymentIsNew\" of the MortgageCalculatorInputData class");
            fieldGeneratorHomeValue = new MoneyJSON.HoldingGenerator("field \"HomeValue\" of the MortgageCalculatorInputData class", false);
            fieldGeneratorHomeValueIsNew = new JSONHoldingBooleanGenerator("field \"HomeValueIsNew\" of the MortgageCalculatorInputData class");
            fieldGeneratorMaxPaymentAmount = new MoneyJSON.HoldingGenerator("field \"MaxPaymentAmount\" of the MortgageCalculatorInputData class", false);
            fieldGeneratorMaxPaymentAmountIsNew = new JSONHoldingBooleanGenerator("field \"MaxPaymentAmountIsNew\" of the MortgageCalculatorInputData class");
            fieldGeneratorDoNotKnow = new JSONHoldingBooleanGenerator("field \"DoNotKnow\" of the MortgageCalculatorInputData class");
            fieldGeneratorWantToKnow = new JSONHoldingBooleanGenerator("field \"WantToKnow\" of the MortgageCalculatorInputData class");
            fieldGeneratorMortgageCalculatorStart = new JSONHoldingBooleanGenerator("field \"MortgageCalculatorStart\" of the MortgageCalculatorInputData class");
            fieldGeneratorDefaultCurrency = new MoneyJSON.HoldingGenerator("field \"DefaultCurrency\" of the MortgageCalculatorInputData class", false);
            fieldGeneratorUserConfused = new JSONHoldingBooleanGenerator("field \"UserConfused\" of the MortgageCalculatorInputData class");
            fieldGeneratorPaymentFrequency = new FieldHoldingGeneratorPaymentFrequency("field \"PaymentFrequency\" of the MortgageCalculatorInputData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MortgageCalculatorInputData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorCalculationType.reset();
            fieldGeneratorCalculationTypeIsNew.reset();
            fieldGeneratorFutureCalculationType.reset();
            fieldGeneratorRequestType.reset();
            fieldGeneratorLastRequest.reset();
            fieldGeneratorInterestRate.reset();
            fieldGeneratorInterestRateIsNew.reset();
            fieldGeneratorMortgagePrincipal.reset();
            fieldGeneratorMortgagePrincipalIsNew.reset();
            fieldGeneratorPrincipalHomeValueAmbiguous.reset();
            fieldGeneratorPrincipalHomeValueAmbiguousConfirmed.reset();
            fieldGeneratorNumMonths.reset();
            fieldGeneratorNumMonthsIsNew.reset();
            fieldGeneratorYearStart.reset();
            fieldGeneratorYearEnd.reset();
            fieldGeneratorYearStartEndIsNew.reset();
            fieldGeneratorYearEndOwing.reset();
            fieldGeneratorYearEndOwingIsNew.reset();
            fieldGeneratorDownPaymentPercent.reset();
            fieldGeneratorDownPaymentPercentIsNew.reset();
            fieldGeneratorDownPayment.reset();
            fieldGeneratorDownPaymentIsNew.reset();
            fieldGeneratorHomeValue.reset();
            fieldGeneratorHomeValueIsNew.reset();
            fieldGeneratorMaxPaymentAmount.reset();
            fieldGeneratorMaxPaymentAmountIsNew.reset();
            fieldGeneratorDoNotKnow.reset();
            fieldGeneratorWantToKnow.reset();
            fieldGeneratorMortgageCalculatorStart.reset();
            fieldGeneratorDefaultCurrency.reset();
            fieldGeneratorUserConfused.reset();
            fieldGeneratorPaymentFrequency.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorMortgagePrincipal.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDownPayment.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorHomeValue.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMaxPaymentAmount.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDefaultCurrency.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorMortgagePrincipal.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDownPayment.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorHomeValue.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMaxPaymentAmount.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDefaultCurrency.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MortgageCalculatorInputDataJSON  result)
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
        public MortgageCalculatorInputDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MortgageCalculatorInputDataJSON  result)
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
    protected virtual void handle_result(List<MortgageCalculatorInputDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MortgageCalculatorInputDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MortgageCalculatorInputDataJSON>();
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
    public List<MortgageCalculatorInputDataJSON> value;
  };
  };
