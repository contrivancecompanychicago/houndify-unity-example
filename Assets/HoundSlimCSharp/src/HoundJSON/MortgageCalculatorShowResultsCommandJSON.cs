/* file "MortgageCalculatorShowResultsCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class MortgageCalculatorShowResultsCommandJSON : MortgageCalculatorCommandJSON
  {
    public class TypeNativeDataJSON : JSONBase
      {
        public enum TypeResultErrorKnownValues
          {
            ResultError_AmortizationInfinite,
            ResultError_DownPaymentNegative,
            ResultError_DownPaymentExceedsHomeValue,
            ResultError_Precision,
            ResultError__none
          };
        public struct TypeResultError
          {
            public bool in_known_list;
            public string string_value;
            public TypeResultErrorKnownValues list_value;
          };

        public static TypeResultErrorKnownValues  stringToResultError(string chars)
          {
            switch (chars[0])
              {
                case 'A':
                    if ((String.Compare(chars, 1, "mortizationInfinite", 0, 19, false) == 0) && (chars.Length == 20))
                        return TypeResultErrorKnownValues.ResultError_AmortizationInfinite;
                    break;
                case 'D':
                    if (String.Compare(chars, 1, "ownPayment", 0, 10, false) == 0)
                      {
                        switch (chars[11])
                          {
                            case 'E':
                                if ((String.Compare(chars, 12, "xceedsHomeValue", 0, 15, false) == 0) && (chars.Length == 27))
                                    return TypeResultErrorKnownValues.ResultError_DownPaymentExceedsHomeValue;
                                break;
                            case 'N':
                                if ((String.Compare(chars, 12, "egative", 0, 7, false) == 0) && (chars.Length == 19))
                                    return TypeResultErrorKnownValues.ResultError_DownPaymentNegative;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'P':
                    if ((String.Compare(chars, 1, "recision", 0, 8, false) == 0) && (chars.Length == 9))
                        return TypeResultErrorKnownValues.ResultError_Precision;
                    break;
                default:
                    break;
              }
            return TypeResultErrorKnownValues.ResultError__none;
          }

        public static string  stringFromResultError(TypeResultErrorKnownValues the_enum)
          {
            switch (the_enum)
              {
                case TypeResultErrorKnownValues.ResultError_AmortizationInfinite:
                    return "AmortizationInfinite";
                case TypeResultErrorKnownValues.ResultError_DownPaymentNegative:
                    return "DownPaymentNegative";
                case TypeResultErrorKnownValues.ResultError_DownPaymentExceedsHomeValue:
                    return "DownPaymentExceedsHomeValue";
                case TypeResultErrorKnownValues.ResultError_Precision:
                    return "Precision";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        private bool flagHasPaymentAmount;
        private MoneyJSON  storePaymentAmount;
        private bool flagHasTotalInterest;
        private MoneyJSON  storeTotalInterest;
        private bool flagHasTotalPaidResult;
        private MoneyJSON  storeTotalPaidResult;
        private bool flagHasDownPaymentResult;
        private MoneyJSON  storeDownPaymentResult;
        private bool flagHasDownPaymentPercentResult;
        private double storeDownPaymentPercentResult;
        private string textStoreDownPaymentPercentResult;
        private bool flagHasNumMonthsResult;
        private BigInteger storeNumMonthsResult;
        private bool flagHasPrincipalPaidResult;
        private MoneyJSON  storePrincipalPaidResult;
        private bool flagHasPrincipalResult;
        private MoneyJSON  storePrincipalResult;
        private bool flagHasPrincipalOwingResult;
        private MoneyJSON  storePrincipalOwingResult;
        private bool flagHasHomeValueResult;
        private MoneyJSON  storeHomeValueResult;
        private bool flagHasInterestRateResult;
        private double storeInterestRateResult;
        private string textStoreInterestRateResult;
        private bool flagHasMortgageInputData;
        private MortgageCalculatorInputDataJSON  storeMortgageInputData;
        private bool flagHasNotUnderstood;
        private bool storeNotUnderstood;
        private bool flagHasResultError;
        private TypeResultError storeResultError;
        private bool flagHasAuxPaymentPerYear;
        private MoneyJSON  storeAuxPaymentPerYear;
        private bool flagHasAuxTotalPayment;
        private MoneyJSON  storeAuxTotalPayment;
        private bool flagHasAuxInterestFirstYear;
        private MoneyJSON  storeAuxInterestFirstYear;
        private bool flagHasAuxInterestLastYear;
        private MoneyJSON  storeAuxInterestLastYear;
        private bool flagHasAuxInterestTotal;
        private MoneyJSON  storeAuxInterestTotal;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONPaymentAmount(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
            setPaymentAmount(convert_classy);
          }


        private void  fromJSONTotalInterest(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
            setTotalInterest(convert_classy);
          }


        private void  fromJSONTotalPaidResult(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
            setTotalPaidResult(convert_classy);
          }


        private void  fromJSONDownPaymentResult(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
            setDownPaymentResult(convert_classy);
          }


        private void  fromJSONDownPaymentPercentResult(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field DownPaymentPercentResult of TypeNativeDataJSON is not a number.");
                  }
              }
            setDownPaymentPercentResultText(the_rational_text);
          }


        private void  fromJSONNumMonthsResult(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field NumMonthsResult of TypeNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field NumMonthsResult of TypeNativeDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setNumMonthsResult(extracted_integer);
          }


        private void  fromJSONPrincipalPaidResult(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
            setPrincipalPaidResult(convert_classy);
          }


        private void  fromJSONPrincipalResult(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
            setPrincipalResult(convert_classy);
          }


        private void  fromJSONPrincipalOwingResult(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
            setPrincipalOwingResult(convert_classy);
          }


        private void  fromJSONHomeValueResult(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
            setHomeValueResult(convert_classy);
          }


        private void  fromJSONInterestRateResult(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field InterestRateResult of TypeNativeDataJSON is not a number.");
                  }
              }
            setInterestRateResultText(the_rational_text);
          }


        private void  fromJSONMortgageInputData(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            MortgageCalculatorInputDataJSON convert_classy = MortgageCalculatorInputDataJSON.from_json(json_value, ignore_extras, true);
            setMortgageInputData(convert_classy);
          }


        private void  fromJSONNotUnderstood(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field NotUnderstood of TypeNativeDataJSON is not true for false.");
                  }
              }
            setNotUnderstood(the_bool);
          }


        private void  fromJSONResultError(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field ResultError of TypeNativeDataJSON is not a string.");
            TypeResultError the_open_enum = new TypeResultError();
            switch (json_string.getData()[0])
              {
                case 'A':
                    if ((String.Compare(json_string.getData(), 1, "mortizationInfinite", 0, 19, false) == 0) && (json_string.getData().Length == 20))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeResultErrorKnownValues.ResultError_AmortizationInfinite;
                            goto open_enum_is_done;
                          }
                    break;
                case 'D':
                    if (String.Compare(json_string.getData(), 1, "ownPayment", 0, 10, false) == 0)
                      {
                        switch (json_string.getData()[11])
                          {
                            case 'E':
                                if ((String.Compare(json_string.getData(), 12, "xceedsHomeValue", 0, 15, false) == 0) && (json_string.getData().Length == 27))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeResultErrorKnownValues.ResultError_DownPaymentExceedsHomeValue;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'N':
                                if ((String.Compare(json_string.getData(), 12, "egative", 0, 7, false) == 0) && (json_string.getData().Length == 19))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeResultErrorKnownValues.ResultError_DownPaymentNegative;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'P':
                    if ((String.Compare(json_string.getData(), 1, "recision", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeResultErrorKnownValues.ResultError_Precision;
                            goto open_enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            setResultError(the_open_enum);
          }


        private void  fromJSONAuxPaymentPerYear(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
            setAuxPaymentPerYear(convert_classy);
          }


        private void  fromJSONAuxTotalPayment(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
            setAuxTotalPayment(convert_classy);
          }


        private void  fromJSONAuxInterestFirstYear(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
            setAuxInterestFirstYear(convert_classy);
          }


        private void  fromJSONAuxInterestLastYear(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
            setAuxInterestLastYear(convert_classy);
          }


        private void  fromJSONAuxInterestTotal(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
            setAuxInterestTotal(convert_classy);
          }


        public TypeNativeDataJSON()
          {
            flagHasPaymentAmount = false;
            flagHasTotalInterest = false;
            flagHasTotalPaidResult = false;
            flagHasDownPaymentResult = false;
            flagHasDownPaymentPercentResult = false;
            flagHasNumMonthsResult = false;
            flagHasPrincipalPaidResult = false;
            flagHasPrincipalResult = false;
            flagHasPrincipalOwingResult = false;
            flagHasHomeValueResult = false;
            flagHasInterestRateResult = false;
            flagHasMortgageInputData = false;
            flagHasNotUnderstood = false;
            flagHasResultError = false;
            flagHasAuxPaymentPerYear = false;
            flagHasAuxTotalPayment = false;
            flagHasAuxInterestFirstYear = false;
            flagHasAuxInterestLastYear = false;
            flagHasAuxInterestTotal = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasPaymentAmount()
          {
            return flagHasPaymentAmount;
          }

        public MoneyJSON   getPaymentAmount()
          {
            Debug.Assert(flagHasPaymentAmount);
            return storePaymentAmount;
          }

        public bool  hasTotalInterest()
          {
            return flagHasTotalInterest;
          }

        public MoneyJSON   getTotalInterest()
          {
            Debug.Assert(flagHasTotalInterest);
            return storeTotalInterest;
          }

        public bool  hasTotalPaidResult()
          {
            return flagHasTotalPaidResult;
          }

        public MoneyJSON   getTotalPaidResult()
          {
            Debug.Assert(flagHasTotalPaidResult);
            return storeTotalPaidResult;
          }

        public bool  hasDownPaymentResult()
          {
            return flagHasDownPaymentResult;
          }

        public MoneyJSON   getDownPaymentResult()
          {
            Debug.Assert(flagHasDownPaymentResult);
            return storeDownPaymentResult;
          }

        public bool  hasDownPaymentPercentResult()
          {
            return flagHasDownPaymentPercentResult;
          }

        public double  getDownPaymentPercentResult()
          {
            Debug.Assert(flagHasDownPaymentPercentResult);
            if (textStoreDownPaymentPercentResult != "")
              {
                return Double.Parse(textStoreDownPaymentPercentResult);
              }
            return storeDownPaymentPercentResult;
          }

        public string  getDownPaymentPercentResultAsText()
          {
            Debug.Assert(flagHasDownPaymentPercentResult);
            if (textStoreDownPaymentPercentResult == "")
              {
                return Convert.ToString(storeDownPaymentPercentResult);
              }
            else
              {
                return (textStoreDownPaymentPercentResult);
              }
          }

        public bool  hasNumMonthsResult()
          {
            return flagHasNumMonthsResult;
          }

        public BigInteger  getNumMonthsResult()
          {
            Debug.Assert(flagHasNumMonthsResult);
            return storeNumMonthsResult;
          }

        public bool  hasPrincipalPaidResult()
          {
            return flagHasPrincipalPaidResult;
          }

        public MoneyJSON   getPrincipalPaidResult()
          {
            Debug.Assert(flagHasPrincipalPaidResult);
            return storePrincipalPaidResult;
          }

        public bool  hasPrincipalResult()
          {
            return flagHasPrincipalResult;
          }

        public MoneyJSON   getPrincipalResult()
          {
            Debug.Assert(flagHasPrincipalResult);
            return storePrincipalResult;
          }

        public bool  hasPrincipalOwingResult()
          {
            return flagHasPrincipalOwingResult;
          }

        public MoneyJSON   getPrincipalOwingResult()
          {
            Debug.Assert(flagHasPrincipalOwingResult);
            return storePrincipalOwingResult;
          }

        public bool  hasHomeValueResult()
          {
            return flagHasHomeValueResult;
          }

        public MoneyJSON   getHomeValueResult()
          {
            Debug.Assert(flagHasHomeValueResult);
            return storeHomeValueResult;
          }

        public bool  hasInterestRateResult()
          {
            return flagHasInterestRateResult;
          }

        public double  getInterestRateResult()
          {
            Debug.Assert(flagHasInterestRateResult);
            if (textStoreInterestRateResult != "")
              {
                return Double.Parse(textStoreInterestRateResult);
              }
            return storeInterestRateResult;
          }

        public string  getInterestRateResultAsText()
          {
            Debug.Assert(flagHasInterestRateResult);
            if (textStoreInterestRateResult == "")
              {
                return Convert.ToString(storeInterestRateResult);
              }
            else
              {
                return (textStoreInterestRateResult);
              }
          }

        public bool  hasMortgageInputData()
          {
            return flagHasMortgageInputData;
          }

        public MortgageCalculatorInputDataJSON   getMortgageInputData()
          {
            Debug.Assert(flagHasMortgageInputData);
            return storeMortgageInputData;
          }

        public bool  hasNotUnderstood()
          {
            return flagHasNotUnderstood;
          }

        public bool  getNotUnderstood()
          {
            Debug.Assert(flagHasNotUnderstood);
            return storeNotUnderstood;
          }

        public bool  hasResultError()
          {
            return flagHasResultError;
          }

        public TypeResultError  getResultError()
          {
            Debug.Assert(flagHasResultError);
            return storeResultError;
          }

        public string  getResultErrorAsString()
          {
            TypeResultError result = getResultError();
            if (result.in_known_list)
                return stringFromResultError(result.list_value);
            else
                return result.string_value;
          }

        public bool  hasAuxPaymentPerYear()
          {
            return flagHasAuxPaymentPerYear;
          }

        public MoneyJSON   getAuxPaymentPerYear()
          {
            Debug.Assert(flagHasAuxPaymentPerYear);
            return storeAuxPaymentPerYear;
          }

        public bool  hasAuxTotalPayment()
          {
            return flagHasAuxTotalPayment;
          }

        public MoneyJSON   getAuxTotalPayment()
          {
            Debug.Assert(flagHasAuxTotalPayment);
            return storeAuxTotalPayment;
          }

        public bool  hasAuxInterestFirstYear()
          {
            return flagHasAuxInterestFirstYear;
          }

        public MoneyJSON   getAuxInterestFirstYear()
          {
            Debug.Assert(flagHasAuxInterestFirstYear);
            return storeAuxInterestFirstYear;
          }

        public bool  hasAuxInterestLastYear()
          {
            return flagHasAuxInterestLastYear;
          }

        public MoneyJSON   getAuxInterestLastYear()
          {
            Debug.Assert(flagHasAuxInterestLastYear);
            return storeAuxInterestLastYear;
          }

        public bool  hasAuxInterestTotal()
          {
            return flagHasAuxInterestTotal;
          }

        public MoneyJSON   getAuxInterestTotal()
          {
            Debug.Assert(flagHasAuxInterestTotal);
            return storeAuxInterestTotal;
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

        public void setPaymentAmount(MoneyJSON  new_value)
          {
            if (flagHasPaymentAmount)
              {
              }
            flagHasPaymentAmount = true;
            storePaymentAmount = new_value;
          }
        public void unsetPaymentAmount()
          {
            if (flagHasPaymentAmount)
              {
              }
            flagHasPaymentAmount = false;
          }
        public void setTotalInterest(MoneyJSON  new_value)
          {
            if (flagHasTotalInterest)
              {
              }
            flagHasTotalInterest = true;
            storeTotalInterest = new_value;
          }
        public void unsetTotalInterest()
          {
            if (flagHasTotalInterest)
              {
              }
            flagHasTotalInterest = false;
          }
        public void setTotalPaidResult(MoneyJSON  new_value)
          {
            if (flagHasTotalPaidResult)
              {
              }
            flagHasTotalPaidResult = true;
            storeTotalPaidResult = new_value;
          }
        public void unsetTotalPaidResult()
          {
            if (flagHasTotalPaidResult)
              {
              }
            flagHasTotalPaidResult = false;
          }
        public void setDownPaymentResult(MoneyJSON  new_value)
          {
            if (flagHasDownPaymentResult)
              {
              }
            flagHasDownPaymentResult = true;
            storeDownPaymentResult = new_value;
          }
        public void unsetDownPaymentResult()
          {
            if (flagHasDownPaymentResult)
              {
              }
            flagHasDownPaymentResult = false;
          }
        public void setDownPaymentPercentResult(double new_value)
          {
            flagHasDownPaymentPercentResult = true;
            if (new_value < 0)
                throw new Exception("The value for field DownPaymentPercentResult of TypeNativeDataJSON is less than the lower bound (0) for that field.");
            storeDownPaymentPercentResult = new_value;
            textStoreDownPaymentPercentResult = "";
          }
        public void setDownPaymentPercentResultText(string new_value)
          {
            flagHasDownPaymentPercentResult = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field DownPaymentPercentResult of TypeNativeDataJSON is not a valid number.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
                throw new Exception("The value for field DownPaymentPercentResult of TypeNativeDataJSON is less than the lower bound (0) for that field.");
            textStoreDownPaymentPercentResult = new_value;
          }
        public void unsetDownPaymentPercentResult()
          {
            flagHasDownPaymentPercentResult = false;
          }
        public void setNumMonthsResult(BigInteger new_value)
          {
            flagHasNumMonthsResult = true;
            if (new_value < 0)
                throw new Exception("The value for field NumMonthsResult of TypeNativeDataJSON is less than the lower bound (0) for that field.");
            storeNumMonthsResult = new_value;
          }
        public void unsetNumMonthsResult()
          {
            flagHasNumMonthsResult = false;
          }
        public void setPrincipalPaidResult(MoneyJSON  new_value)
          {
            if (flagHasPrincipalPaidResult)
              {
              }
            flagHasPrincipalPaidResult = true;
            storePrincipalPaidResult = new_value;
          }
        public void unsetPrincipalPaidResult()
          {
            if (flagHasPrincipalPaidResult)
              {
              }
            flagHasPrincipalPaidResult = false;
          }
        public void setPrincipalResult(MoneyJSON  new_value)
          {
            if (flagHasPrincipalResult)
              {
              }
            flagHasPrincipalResult = true;
            storePrincipalResult = new_value;
          }
        public void unsetPrincipalResult()
          {
            if (flagHasPrincipalResult)
              {
              }
            flagHasPrincipalResult = false;
          }
        public void setPrincipalOwingResult(MoneyJSON  new_value)
          {
            if (flagHasPrincipalOwingResult)
              {
              }
            flagHasPrincipalOwingResult = true;
            storePrincipalOwingResult = new_value;
          }
        public void unsetPrincipalOwingResult()
          {
            if (flagHasPrincipalOwingResult)
              {
              }
            flagHasPrincipalOwingResult = false;
          }
        public void setHomeValueResult(MoneyJSON  new_value)
          {
            if (flagHasHomeValueResult)
              {
              }
            flagHasHomeValueResult = true;
            storeHomeValueResult = new_value;
          }
        public void unsetHomeValueResult()
          {
            if (flagHasHomeValueResult)
              {
              }
            flagHasHomeValueResult = false;
          }
        public void setInterestRateResult(double new_value)
          {
            flagHasInterestRateResult = true;
            if (new_value < 0)
                throw new Exception("The value for field InterestRateResult of TypeNativeDataJSON is less than the lower bound (0) for that field.");
            storeInterestRateResult = new_value;
            textStoreInterestRateResult = "";
          }
        public void setInterestRateResultText(string new_value)
          {
            flagHasInterestRateResult = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field InterestRateResult of TypeNativeDataJSON is not a valid number.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
                throw new Exception("The value for field InterestRateResult of TypeNativeDataJSON is less than the lower bound (0) for that field.");
            textStoreInterestRateResult = new_value;
          }
        public void unsetInterestRateResult()
          {
            flagHasInterestRateResult = false;
          }
        public void setMortgageInputData(MortgageCalculatorInputDataJSON  new_value)
          {
            if (flagHasMortgageInputData)
              {
              }
            flagHasMortgageInputData = true;
            storeMortgageInputData = new_value;
          }
        public void unsetMortgageInputData()
          {
            if (flagHasMortgageInputData)
              {
              }
            flagHasMortgageInputData = false;
          }
        public void setNotUnderstood(bool new_value)
          {
            flagHasNotUnderstood = true;
            storeNotUnderstood = new_value;
          }
        public void unsetNotUnderstood()
          {
            flagHasNotUnderstood = false;
          }
        public void setResultError(TypeResultError new_value)
          {
            flagHasResultError = true;
            storeResultError = new_value;
          }
        public void setResultError(string chars)
          {
            TypeResultErrorKnownValues known = stringToResultError(chars);
            TypeResultError new_value = new TypeResultError();
            if (known == TypeResultErrorKnownValues.ResultError__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setResultError(new_value);
          }
        public void setResultError(TypeResultErrorKnownValues new_value)
          {
            TypeResultError new_full_value = new TypeResultError();
            Debug.Assert(new_value != TypeResultErrorKnownValues.ResultError__none);
            new_full_value.in_known_list = true;
            new_full_value.list_value = new_value;
            setResultError(new_full_value);
          }
        public void unsetResultError()
          {
            flagHasResultError = false;
          }
        public void setAuxPaymentPerYear(MoneyJSON  new_value)
          {
            if (flagHasAuxPaymentPerYear)
              {
              }
            flagHasAuxPaymentPerYear = true;
            storeAuxPaymentPerYear = new_value;
          }
        public void unsetAuxPaymentPerYear()
          {
            if (flagHasAuxPaymentPerYear)
              {
              }
            flagHasAuxPaymentPerYear = false;
          }
        public void setAuxTotalPayment(MoneyJSON  new_value)
          {
            if (flagHasAuxTotalPayment)
              {
              }
            flagHasAuxTotalPayment = true;
            storeAuxTotalPayment = new_value;
          }
        public void unsetAuxTotalPayment()
          {
            if (flagHasAuxTotalPayment)
              {
              }
            flagHasAuxTotalPayment = false;
          }
        public void setAuxInterestFirstYear(MoneyJSON  new_value)
          {
            if (flagHasAuxInterestFirstYear)
              {
              }
            flagHasAuxInterestFirstYear = true;
            storeAuxInterestFirstYear = new_value;
          }
        public void unsetAuxInterestFirstYear()
          {
            if (flagHasAuxInterestFirstYear)
              {
              }
            flagHasAuxInterestFirstYear = false;
          }
        public void setAuxInterestLastYear(MoneyJSON  new_value)
          {
            if (flagHasAuxInterestLastYear)
              {
              }
            flagHasAuxInterestLastYear = true;
            storeAuxInterestLastYear = new_value;
          }
        public void unsetAuxInterestLastYear()
          {
            if (flagHasAuxInterestLastYear)
              {
              }
            flagHasAuxInterestLastYear = false;
          }
        public void setAuxInterestTotal(MoneyJSON  new_value)
          {
            if (flagHasAuxInterestTotal)
              {
              }
            flagHasAuxInterestTotal = true;
            storeAuxInterestTotal = new_value;
          }
        public void unsetAuxInterestTotal()
          {
            if (flagHasAuxInterestTotal)
              {
              }
            flagHasAuxInterestTotal = false;
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
            if (flagHasPaymentAmount)
              {
                handler.start_pair("PaymentAmount");
                if (partial_allowed)
                    storePaymentAmount.write_partial_as_json(handler);
                else
                    storePaymentAmount.write_as_json(handler);
              }
            if (flagHasTotalInterest)
              {
                handler.start_pair("TotalInterest");
                if (partial_allowed)
                    storeTotalInterest.write_partial_as_json(handler);
                else
                    storeTotalInterest.write_as_json(handler);
              }
            if (flagHasTotalPaidResult)
              {
                handler.start_pair("TotalPaidResult");
                if (partial_allowed)
                    storeTotalPaidResult.write_partial_as_json(handler);
                else
                    storeTotalPaidResult.write_as_json(handler);
              }
            if (flagHasDownPaymentResult)
              {
                handler.start_pair("DownPaymentResult");
                if (partial_allowed)
                    storeDownPaymentResult.write_partial_as_json(handler);
                else
                    storeDownPaymentResult.write_as_json(handler);
              }
            if (flagHasDownPaymentPercentResult)
              {
                handler.start_pair("DownPaymentPercentResult");
                if (textStoreDownPaymentPercentResult != "")
                    handler.number_value(textStoreDownPaymentPercentResult);
                else if (((double)(long)storeDownPaymentPercentResult) == storeDownPaymentPercentResult)
                    handler.number_value((long)storeDownPaymentPercentResult);
                else
                    handler.number_value(storeDownPaymentPercentResult);
              }
            if (flagHasNumMonthsResult)
              {
                handler.start_pair("NumMonthsResult");
                handler.number_value(storeNumMonthsResult);
              }
            if (flagHasPrincipalPaidResult)
              {
                handler.start_pair("PrincipalPaidResult");
                if (partial_allowed)
                    storePrincipalPaidResult.write_partial_as_json(handler);
                else
                    storePrincipalPaidResult.write_as_json(handler);
              }
            if (flagHasPrincipalResult)
              {
                handler.start_pair("PrincipalResult");
                if (partial_allowed)
                    storePrincipalResult.write_partial_as_json(handler);
                else
                    storePrincipalResult.write_as_json(handler);
              }
            if (flagHasPrincipalOwingResult)
              {
                handler.start_pair("PrincipalOwingResult");
                if (partial_allowed)
                    storePrincipalOwingResult.write_partial_as_json(handler);
                else
                    storePrincipalOwingResult.write_as_json(handler);
              }
            if (flagHasHomeValueResult)
              {
                handler.start_pair("HomeValueResult");
                if (partial_allowed)
                    storeHomeValueResult.write_partial_as_json(handler);
                else
                    storeHomeValueResult.write_as_json(handler);
              }
            if (flagHasInterestRateResult)
              {
                handler.start_pair("InterestRateResult");
                if (textStoreInterestRateResult != "")
                    handler.number_value(textStoreInterestRateResult);
                else if (((double)(long)storeInterestRateResult) == storeInterestRateResult)
                    handler.number_value((long)storeInterestRateResult);
                else
                    handler.number_value(storeInterestRateResult);
              }
            Debug.Assert(partial_allowed || flagHasMortgageInputData);
            if (flagHasMortgageInputData)
              {
                handler.start_pair("MortgageInputData");
                if (partial_allowed)
                    storeMortgageInputData.write_partial_as_json(handler);
                else
                    storeMortgageInputData.write_as_json(handler);
              }
            if (flagHasNotUnderstood)
              {
                handler.start_pair("NotUnderstood");
                handler.boolean_value(storeNotUnderstood);
              }
            if (flagHasResultError)
              {
                handler.start_pair("ResultError");
                if (storeResultError.in_known_list)
                  {
                    switch (storeResultError.list_value)
                      {
                        case TypeResultErrorKnownValues.ResultError_AmortizationInfinite:
                            handler.string_value("AmortizationInfinite");
                            break;
                        case TypeResultErrorKnownValues.ResultError_DownPaymentNegative:
                            handler.string_value("DownPaymentNegative");
                            break;
                        case TypeResultErrorKnownValues.ResultError_DownPaymentExceedsHomeValue:
                            handler.string_value("DownPaymentExceedsHomeValue");
                            break;
                        case TypeResultErrorKnownValues.ResultError_Precision:
                            handler.string_value("Precision");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeResultError.string_value);
                  }
              }
            if (flagHasAuxPaymentPerYear)
              {
                handler.start_pair("AuxPaymentPerYear");
                if (partial_allowed)
                    storeAuxPaymentPerYear.write_partial_as_json(handler);
                else
                    storeAuxPaymentPerYear.write_as_json(handler);
              }
            if (flagHasAuxTotalPayment)
              {
                handler.start_pair("AuxTotalPayment");
                if (partial_allowed)
                    storeAuxTotalPayment.write_partial_as_json(handler);
                else
                    storeAuxTotalPayment.write_as_json(handler);
              }
            if (flagHasAuxInterestFirstYear)
              {
                handler.start_pair("AuxInterestFirstYear");
                if (partial_allowed)
                    storeAuxInterestFirstYear.write_partial_as_json(handler);
                else
                    storeAuxInterestFirstYear.write_as_json(handler);
              }
            if (flagHasAuxInterestLastYear)
              {
                handler.start_pair("AuxInterestLastYear");
                if (partial_allowed)
                    storeAuxInterestLastYear.write_partial_as_json(handler);
                else
                    storeAuxInterestLastYear.write_as_json(handler);
              }
            if (flagHasAuxInterestTotal)
              {
                handler.start_pair("AuxInterestTotal");
                if (partial_allowed)
                    storeAuxInterestTotal.write_partial_as_json(handler);
                else
                    storeAuxInterestTotal.write_as_json(handler);
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
            if (!(hasMortgageInputData()))
              {
                return "When parsing the object for %what%, the \"MortgageInputData\" field was missing.";
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
            private MoneyJSON.HoldingGenerator fieldGeneratorPaymentAmount;
            private MoneyJSON.HoldingGenerator fieldGeneratorTotalInterest;
            private MoneyJSON.HoldingGenerator fieldGeneratorTotalPaidResult;
            private MoneyJSON.HoldingGenerator fieldGeneratorDownPaymentResult;
            private JSONHoldingNumberTextGenerator fieldGeneratorDownPaymentPercentResult;
        private class FieldHoldingGeneratorNumMonthsResult : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorNumMonthsResult(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorNumMonthsResult : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorNumMonthsResult(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorNumMonthsResult fieldGeneratorNumMonthsResult;
            private MoneyJSON.HoldingGenerator fieldGeneratorPrincipalPaidResult;
            private MoneyJSON.HoldingGenerator fieldGeneratorPrincipalResult;
            private MoneyJSON.HoldingGenerator fieldGeneratorPrincipalOwingResult;
            private MoneyJSON.HoldingGenerator fieldGeneratorHomeValueResult;
            private JSONHoldingNumberTextGenerator fieldGeneratorInterestRateResult;
            private MortgageCalculatorInputDataJSON.HoldingGenerator fieldGeneratorMortgageInputData;
            private JSONHoldingBooleanGenerator fieldGeneratorNotUnderstood;
        private abstract class FieldGeneratorResultError : JSONStringGenerator
              {
                protected FieldGeneratorResultError(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorResultError()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    TypeResultErrorKnownValues known = stringToResultError(result);
                    TypeResultError new_value = new TypeResultError();
                    if (known == TypeResultErrorKnownValues.ResultError__none)
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
                protected abstract void handle_result(TypeResultError result);
              };
        private class FieldHoldingGeneratorResultError : FieldGeneratorResultError
      {
        protected override void handle_result(TypeResultError result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorResultError(String what)
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
        public TypeResultError value;
      };
        private class FieldHoldingArrayGeneratorResultError : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorResultError
          {
            private FieldHoldingArrayGeneratorResultError top;

            protected override void handle_result(TypeResultError result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorResultError init_top)
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
        protected virtual void handle_result(List<TypeResultError> result)
          {
          }

        public FieldHoldingArrayGeneratorResultError(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeResultError>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorResultError()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeResultError>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeResultError> value;
      };
            private FieldHoldingGeneratorResultError fieldGeneratorResultError;
            private MoneyJSON.HoldingGenerator fieldGeneratorAuxPaymentPerYear;
            private MoneyJSON.HoldingGenerator fieldGeneratorAuxTotalPayment;
            private MoneyJSON.HoldingGenerator fieldGeneratorAuxInterestFirstYear;
            private MoneyJSON.HoldingGenerator fieldGeneratorAuxInterestLastYear;
            private MoneyJSON.HoldingGenerator fieldGeneratorAuxInterestTotal;
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
                if (fieldGeneratorPaymentAmount.have_value)
                  {
                    result.setPaymentAmount(fieldGeneratorPaymentAmount.value);
                    fieldGeneratorPaymentAmount.have_value = false;
                  }
                if (fieldGeneratorTotalInterest.have_value)
                  {
                    result.setTotalInterest(fieldGeneratorTotalInterest.value);
                    fieldGeneratorTotalInterest.have_value = false;
                  }
                if (fieldGeneratorTotalPaidResult.have_value)
                  {
                    result.setTotalPaidResult(fieldGeneratorTotalPaidResult.value);
                    fieldGeneratorTotalPaidResult.have_value = false;
                  }
                if (fieldGeneratorDownPaymentResult.have_value)
                  {
                    result.setDownPaymentResult(fieldGeneratorDownPaymentResult.value);
                    fieldGeneratorDownPaymentResult.have_value = false;
                  }
                if (fieldGeneratorDownPaymentPercentResult.have_value)
                  {
                    result.setDownPaymentPercentResultText(fieldGeneratorDownPaymentPercentResult.value);
                    fieldGeneratorDownPaymentPercentResult.have_value = false;
                  }
                if (fieldGeneratorNumMonthsResult.have_value)
                  {
                    result.setNumMonthsResult(fieldGeneratorNumMonthsResult.value);
                    fieldGeneratorNumMonthsResult.have_value = false;
                  }
                if (fieldGeneratorPrincipalPaidResult.have_value)
                  {
                    result.setPrincipalPaidResult(fieldGeneratorPrincipalPaidResult.value);
                    fieldGeneratorPrincipalPaidResult.have_value = false;
                  }
                if (fieldGeneratorPrincipalResult.have_value)
                  {
                    result.setPrincipalResult(fieldGeneratorPrincipalResult.value);
                    fieldGeneratorPrincipalResult.have_value = false;
                  }
                if (fieldGeneratorPrincipalOwingResult.have_value)
                  {
                    result.setPrincipalOwingResult(fieldGeneratorPrincipalOwingResult.value);
                    fieldGeneratorPrincipalOwingResult.have_value = false;
                  }
                if (fieldGeneratorHomeValueResult.have_value)
                  {
                    result.setHomeValueResult(fieldGeneratorHomeValueResult.value);
                    fieldGeneratorHomeValueResult.have_value = false;
                  }
                if (fieldGeneratorInterestRateResult.have_value)
                  {
                    result.setInterestRateResultText(fieldGeneratorInterestRateResult.value);
                    fieldGeneratorInterestRateResult.have_value = false;
                  }
                if (fieldGeneratorMortgageInputData.have_value)
                  {
                    result.setMortgageInputData(fieldGeneratorMortgageInputData.value);
                    fieldGeneratorMortgageInputData.have_value = false;
                  }
                else if ((!(result.hasMortgageInputData())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"MortgageInputData\" field was missing.");
                  }
                if (fieldGeneratorNotUnderstood.have_value)
                  {
                    result.setNotUnderstood(fieldGeneratorNotUnderstood.value);
                    fieldGeneratorNotUnderstood.have_value = false;
                  }
                if (fieldGeneratorResultError.have_value)
                  {
                    result.setResultError(fieldGeneratorResultError.value);
                    fieldGeneratorResultError.have_value = false;
                  }
                if (fieldGeneratorAuxPaymentPerYear.have_value)
                  {
                    result.setAuxPaymentPerYear(fieldGeneratorAuxPaymentPerYear.value);
                    fieldGeneratorAuxPaymentPerYear.have_value = false;
                  }
                if (fieldGeneratorAuxTotalPayment.have_value)
                  {
                    result.setAuxTotalPayment(fieldGeneratorAuxTotalPayment.value);
                    fieldGeneratorAuxTotalPayment.have_value = false;
                  }
                if (fieldGeneratorAuxInterestFirstYear.have_value)
                  {
                    result.setAuxInterestFirstYear(fieldGeneratorAuxInterestFirstYear.value);
                    fieldGeneratorAuxInterestFirstYear.have_value = false;
                  }
                if (fieldGeneratorAuxInterestLastYear.have_value)
                  {
                    result.setAuxInterestLastYear(fieldGeneratorAuxInterestLastYear.value);
                    fieldGeneratorAuxInterestLastYear.have_value = false;
                  }
                if (fieldGeneratorAuxInterestTotal.have_value)
                  {
                    result.setAuxInterestTotal(fieldGeneratorAuxInterestTotal.value);
                    fieldGeneratorAuxInterestTotal.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeNativeDataJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'A':
                        if (String.Compare(field_name, 1, "ux", 0, 2, false) == 0)
                          {
                            switch (field_name[3])
                              {
                                case 'I':
                                    if (String.Compare(field_name, 4, "nterest", 0, 7, false) == 0)
                                      {
                                        switch (field_name[11])
                                          {
                                            case 'F':
                                                if ((String.Compare(field_name, 12, "irstYear", 0, 8, false) == 0) && (field_name.Length == 20))
                                                    return fieldGeneratorAuxInterestFirstYear;
                                                break;
                                            case 'L':
                                                if ((String.Compare(field_name, 12, "astYear", 0, 7, false) == 0) && (field_name.Length == 19))
                                                    return fieldGeneratorAuxInterestLastYear;
                                                break;
                                            case 'T':
                                                if ((String.Compare(field_name, 12, "otal", 0, 4, false) == 0) && (field_name.Length == 16))
                                                    return fieldGeneratorAuxInterestTotal;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'P':
                                    if ((String.Compare(field_name, 4, "aymentPerYear", 0, 13, false) == 0) && (field_name.Length == 17))
                                        return fieldGeneratorAuxPaymentPerYear;
                                    break;
                                case 'T':
                                    if ((String.Compare(field_name, 4, "otalPayment", 0, 11, false) == 0) && (field_name.Length == 15))
                                        return fieldGeneratorAuxTotalPayment;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'D':
                        if (String.Compare(field_name, 1, "ownPayment", 0, 10, false) == 0)
                          {
                            switch (field_name[11])
                              {
                                case 'P':
                                    if ((String.Compare(field_name, 12, "ercentResult", 0, 12, false) == 0) && (field_name.Length == 24))
                                        return fieldGeneratorDownPaymentPercentResult;
                                    break;
                                case 'R':
                                    if ((String.Compare(field_name, 12, "esult", 0, 5, false) == 0) && (field_name.Length == 17))
                                        return fieldGeneratorDownPaymentResult;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'H':
                        if ((String.Compare(field_name, 1, "omeValueResult", 0, 14, false) == 0) && (field_name.Length == 15))
                            return fieldGeneratorHomeValueResult;
                        break;
                    case 'I':
                        if ((String.Compare(field_name, 1, "nterestRateResult", 0, 17, false) == 0) && (field_name.Length == 18))
                            return fieldGeneratorInterestRateResult;
                        break;
                    case 'M':
                        if ((String.Compare(field_name, 1, "ortgageInputData", 0, 16, false) == 0) && (field_name.Length == 17))
                            return fieldGeneratorMortgageInputData;
                        break;
                    case 'N':
                        switch (field_name[1])
                          {
                            case 'o':
                                if ((String.Compare(field_name, 2, "tUnderstood", 0, 11, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorNotUnderstood;
                                break;
                            case 'u':
                                if ((String.Compare(field_name, 2, "mMonthsResult", 0, 13, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorNumMonthsResult;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'P':
                        switch (field_name[1])
                          {
                            case 'a':
                                if ((String.Compare(field_name, 2, "ymentAmount", 0, 11, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorPaymentAmount;
                                break;
                            case 'r':
                                if (String.Compare(field_name, 2, "incipal", 0, 7, false) == 0)
                                  {
                                    switch (field_name[9])
                                      {
                                        case 'O':
                                            if ((String.Compare(field_name, 10, "wingResult", 0, 10, false) == 0) && (field_name.Length == 20))
                                                return fieldGeneratorPrincipalOwingResult;
                                            break;
                                        case 'P':
                                            if ((String.Compare(field_name, 10, "aidResult", 0, 9, false) == 0) && (field_name.Length == 19))
                                                return fieldGeneratorPrincipalPaidResult;
                                            break;
                                        case 'R':
                                            if ((String.Compare(field_name, 10, "esult", 0, 5, false) == 0) && (field_name.Length == 15))
                                                return fieldGeneratorPrincipalResult;
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
                        if ((String.Compare(field_name, 1, "esultError", 0, 10, false) == 0) && (field_name.Length == 11))
                            return fieldGeneratorResultError;
                        break;
                    case 'T':
                        if (String.Compare(field_name, 1, "otal", 0, 4, false) == 0)
                          {
                            switch (field_name[5])
                              {
                                case 'I':
                                    if ((String.Compare(field_name, 6, "nterest", 0, 7, false) == 0) && (field_name.Length == 13))
                                        return fieldGeneratorTotalInterest;
                                    break;
                                case 'P':
                                    if ((String.Compare(field_name, 6, "aidResult", 0, 9, false) == 0) && (field_name.Length == 15))
                                        return fieldGeneratorTotalPaidResult;
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
                fieldGeneratorPaymentAmount = new MoneyJSON.HoldingGenerator("field \"PaymentAmount\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorTotalInterest = new MoneyJSON.HoldingGenerator("field \"TotalInterest\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorTotalPaidResult = new MoneyJSON.HoldingGenerator("field \"TotalPaidResult\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorDownPaymentResult = new MoneyJSON.HoldingGenerator("field \"DownPaymentResult\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorDownPaymentPercentResult = new JSONHoldingNumberTextGenerator("field \"DownPaymentPercentResult\" of the TypeNativeData class");
                fieldGeneratorNumMonthsResult = new FieldHoldingGeneratorNumMonthsResult("field \"NumMonthsResult\" of the TypeNativeData class");
                fieldGeneratorPrincipalPaidResult = new MoneyJSON.HoldingGenerator("field \"PrincipalPaidResult\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorPrincipalResult = new MoneyJSON.HoldingGenerator("field \"PrincipalResult\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorPrincipalOwingResult = new MoneyJSON.HoldingGenerator("field \"PrincipalOwingResult\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorHomeValueResult = new MoneyJSON.HoldingGenerator("field \"HomeValueResult\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorInterestRateResult = new JSONHoldingNumberTextGenerator("field \"InterestRateResult\" of the TypeNativeData class");
                fieldGeneratorMortgageInputData = new MortgageCalculatorInputDataJSON.HoldingGenerator("field \"MortgageInputData\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorNotUnderstood = new JSONHoldingBooleanGenerator("field \"NotUnderstood\" of the TypeNativeData class");
                fieldGeneratorResultError = new FieldHoldingGeneratorResultError("field \"ResultError\" of the TypeNativeData class");
                fieldGeneratorAuxPaymentPerYear = new MoneyJSON.HoldingGenerator("field \"AuxPaymentPerYear\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorAuxTotalPayment = new MoneyJSON.HoldingGenerator("field \"AuxTotalPayment\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorAuxInterestFirstYear = new MoneyJSON.HoldingGenerator("field \"AuxInterestFirstYear\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorAuxInterestLastYear = new MoneyJSON.HoldingGenerator("field \"AuxInterestLastYear\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorAuxInterestTotal = new MoneyJSON.HoldingGenerator("field \"AuxInterestTotal\" of the TypeNativeData class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorPaymentAmount = new MoneyJSON.HoldingGenerator("field \"PaymentAmount\" of the TypeNativeData class", false);
                fieldGeneratorTotalInterest = new MoneyJSON.HoldingGenerator("field \"TotalInterest\" of the TypeNativeData class", false);
                fieldGeneratorTotalPaidResult = new MoneyJSON.HoldingGenerator("field \"TotalPaidResult\" of the TypeNativeData class", false);
                fieldGeneratorDownPaymentResult = new MoneyJSON.HoldingGenerator("field \"DownPaymentResult\" of the TypeNativeData class", false);
                fieldGeneratorDownPaymentPercentResult = new JSONHoldingNumberTextGenerator("field \"DownPaymentPercentResult\" of the TypeNativeData class");
                fieldGeneratorNumMonthsResult = new FieldHoldingGeneratorNumMonthsResult("field \"NumMonthsResult\" of the TypeNativeData class");
                fieldGeneratorPrincipalPaidResult = new MoneyJSON.HoldingGenerator("field \"PrincipalPaidResult\" of the TypeNativeData class", false);
                fieldGeneratorPrincipalResult = new MoneyJSON.HoldingGenerator("field \"PrincipalResult\" of the TypeNativeData class", false);
                fieldGeneratorPrincipalOwingResult = new MoneyJSON.HoldingGenerator("field \"PrincipalOwingResult\" of the TypeNativeData class", false);
                fieldGeneratorHomeValueResult = new MoneyJSON.HoldingGenerator("field \"HomeValueResult\" of the TypeNativeData class", false);
                fieldGeneratorInterestRateResult = new JSONHoldingNumberTextGenerator("field \"InterestRateResult\" of the TypeNativeData class");
                fieldGeneratorMortgageInputData = new MortgageCalculatorInputDataJSON.HoldingGenerator("field \"MortgageInputData\" of the TypeNativeData class", false);
                fieldGeneratorNotUnderstood = new JSONHoldingBooleanGenerator("field \"NotUnderstood\" of the TypeNativeData class");
                fieldGeneratorResultError = new FieldHoldingGeneratorResultError("field \"ResultError\" of the TypeNativeData class");
                fieldGeneratorAuxPaymentPerYear = new MoneyJSON.HoldingGenerator("field \"AuxPaymentPerYear\" of the TypeNativeData class", false);
                fieldGeneratorAuxTotalPayment = new MoneyJSON.HoldingGenerator("field \"AuxTotalPayment\" of the TypeNativeData class", false);
                fieldGeneratorAuxInterestFirstYear = new MoneyJSON.HoldingGenerator("field \"AuxInterestFirstYear\" of the TypeNativeData class", false);
                fieldGeneratorAuxInterestLastYear = new MoneyJSON.HoldingGenerator("field \"AuxInterestLastYear\" of the TypeNativeData class", false);
                fieldGeneratorAuxInterestTotal = new MoneyJSON.HoldingGenerator("field \"AuxInterestTotal\" of the TypeNativeData class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorPaymentAmount.reset();
                fieldGeneratorTotalInterest.reset();
                fieldGeneratorTotalPaidResult.reset();
                fieldGeneratorDownPaymentResult.reset();
                fieldGeneratorDownPaymentPercentResult.reset();
                fieldGeneratorNumMonthsResult.reset();
                fieldGeneratorPrincipalPaidResult.reset();
                fieldGeneratorPrincipalResult.reset();
                fieldGeneratorPrincipalOwingResult.reset();
                fieldGeneratorHomeValueResult.reset();
                fieldGeneratorInterestRateResult.reset();
                fieldGeneratorMortgageInputData.reset();
                fieldGeneratorNotUnderstood.reset();
                fieldGeneratorResultError.reset();
                fieldGeneratorAuxPaymentPerYear.reset();
                fieldGeneratorAuxTotalPayment.reset();
                fieldGeneratorAuxInterestFirstYear.reset();
                fieldGeneratorAuxInterestLastYear.reset();
                fieldGeneratorAuxInterestTotal.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorPaymentAmount.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorTotalInterest.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorTotalPaidResult.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorDownPaymentResult.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorPrincipalPaidResult.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorPrincipalResult.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorPrincipalOwingResult.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorHomeValueResult.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorMortgageInputData.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorAuxPaymentPerYear.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorAuxTotalPayment.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorAuxInterestFirstYear.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorAuxInterestLastYear.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorAuxInterestTotal.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorPaymentAmount.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorTotalInterest.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorTotalPaidResult.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorDownPaymentResult.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorPrincipalPaidResult.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorPrincipalResult.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorPrincipalOwingResult.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorHomeValueResult.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorMortgageInputData.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorAuxPaymentPerYear.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorAuxTotalPayment.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorAuxInterestFirstYear.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorAuxInterestLastYear.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorAuxInterestTotal.set_allow_unpolished(new_allow_unpolished);
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
    private TypeNativeDataJSON  storeNativeData;


    private JSONValue  extraNativeDataToJSON()
      {
        JSONValueHandler handler_NativeData = new JSONValueHandler();
        storeNativeData.write_as_json(handler_NativeData);
        return handler_NativeData.result;
      }


    private void  fromJSONNativeData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeNativeDataJSON convert_classy = TypeNativeDataJSON.from_json(json_value, ignore_extras, true);
        setNativeData(convert_classy);
      }


    public MortgageCalculatorShowResultsCommandJSON()
      {
        flagHasNativeData = false;
      }

    public override string  getMortgageCalculatorCommandKind()
      {
        return "MortgageCalculatorShowResultsCommand";
      }

    public bool  hasNativeData()
      {
        return flagHasNativeData;
      }

    public TypeNativeDataJSON   getNativeData()
      {
        Debug.Assert(flagHasNativeData);
        return storeNativeData;
      }


    public override int extraMortgageCalculatorCommandComponentCount()
      {
        int result = 0;
        if (flagHasNativeData)
            ++result;
        return result;
      }
    public override string extraMortgageCalculatorCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return "NativeData";
            --remainder;
          }
        Debug.Assert(false);
        return null;
      }
    public override JSONValue extraMortgageCalculatorCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return extraNativeDataToJSON();
            --remainder;
          }
        Debug.Assert(false);
        return null;
      }
    public override JSONValue extraMortgageCalculatorCommandLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "NativeData", 0, 10, false) == 0) && (field_name.Length == 10))
            return (flagHasNativeData ? extraNativeDataToJSON() : null);
        return null;
      }

    public void setNativeData(TypeNativeDataJSON  new_value)
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = true;
        storeNativeData = new_value;
      }
    public void unsetNativeData()
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = false;
      }

    public override void extraMortgageCalculatorCommandAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "NativeData", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONNativeData(new_component, false);
            return;
            }
      }
    public override void extraMortgageCalculatorCommandSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "NativeData", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONNativeData(new_component, false);
            return;
            }
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
        if (flagHasNativeData)
          {
            handler.start_pair("NativeData");
            if (partial_allowed)
                storeNativeData.write_partial_as_json(handler);
            else
                storeNativeData.write_as_json(handler);
          }
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

    public static new MortgageCalculatorShowResultsCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MortgageCalculatorShowResultsCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorShowResultsCommand", ignore_extras);
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
    public static new MortgageCalculatorShowResultsCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MortgageCalculatorShowResultsCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MortgageCalculatorShowResultsCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorShowResultsCommand", ignore_extras);
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
    public static new MortgageCalculatorShowResultsCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MortgageCalculatorShowResultsCommandJSON from_text(string text, bool ignore_extras)
      {
        MortgageCalculatorShowResultsCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorShowResultsCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MortgageCalculatorShowResultsCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MortgageCalculatorShowResultsCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MortgageCalculatorShowResultsCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorShowResultsCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : MortgageCalculatorCommandJSON.Generator
      {
        private TypeNativeDataJSON.HoldingGenerator fieldGeneratorNativeData;

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
            if (!(getMortgageCalculatorCommandJSONKey().Equals("MortgageCalculatorShowResultsCommand")))
                throw new Exception("The key field has a value other than `MortgageCalculatorShowResultsCommand'.");
            MortgageCalculatorShowResultsCommandJSON result = new MortgageCalculatorShowResultsCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected override void handle_result(MortgageCalculatorCommandJSON new_result)
          {
            handle_result((MortgageCalculatorShowResultsCommandJSON )new_result);
          }
        protected void finish(MortgageCalculatorShowResultsCommandJSON result)
          {
            if (fieldGeneratorNativeData.have_value)
              {
                result.setNativeData(fieldGeneratorNativeData.value);
                fieldGeneratorNativeData.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(MortgageCalculatorShowResultsCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "NativeData", 0, 10, false) == 0) && (field_name.Length == 10))
                return fieldGeneratorNativeData;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the MortgageCalculatorShowResultsCommand class", ignore_extras);
            set_what("the MortgageCalculatorShowResultsCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the MortgageCalculatorShowResultsCommand class", false);
            set_what("the MortgageCalculatorShowResultsCommand class");
          }

        public override void reset()
          {
            fieldGeneratorNativeData.reset();
            base.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MortgageCalculatorShowResultsCommandJSON  result)
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
        public MortgageCalculatorShowResultsCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MortgageCalculatorShowResultsCommandJSON  result)
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
    protected virtual void handle_result(List<MortgageCalculatorShowResultsCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MortgageCalculatorShowResultsCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MortgageCalculatorShowResultsCommandJSON>();
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
    public List<MortgageCalculatorShowResultsCommandJSON> value;
  };
  };
