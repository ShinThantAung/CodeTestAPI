namespace Am.Infrastructure.Consts
{
    public static class MessageReturn
    {

        public static Dictionary<string, string> _messagecode = new Dictionary<string, string>
      {
        {"000", "Success"},
        {"010", "Field Required / Field Length is too long"},
        {"020", "Bank Account No is Invalid"},
        {"030", "Wallet User ID is Invalid"},
        {"040", "The amount is less than the minimum transfer"},
        {"050", "The amount is greater than the maximum transfer"},
        {"060", "Maximum amount of transaction per day for payer reached"},
        {"070", "Maximum amount of transaction per month for payer reached"},
        {"080", "Invalid T2P_Transaction_ID"},
        {"090", "Duplicate T2P_Transaction_ID"},
        {"100", "Invalid Partner Account"},
        {"110", "Invalid InquiryID"},
        {"120", "Expired InquiryID"},
        {"130", "Transaction Fail"},
        {"140", "nvalid Security"},
        {"500", "System Error"}
      };

        public static string GetMessage(string word)
        {
            // Get the result from the static Dictionary.
            string result;
            if (_messagecode.TryGetValue(word.Trim(), out result))
            {
                return result;
            }
            else
            {
                return "";
            }
        }



    }
}
