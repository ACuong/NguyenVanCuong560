using System;
using System.Text.RegularExpressions;

namespace NguyenVanCuong560.Models
{
    public class StringProcessNVC560
    {
        public string LowerToUpper(string strInput)
        {
            string strOutput = Regex.Replace(strInput, @"\D+").Value;

            return strOutput;
        }
    }
}
