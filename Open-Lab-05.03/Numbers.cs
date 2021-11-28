using System;
using System.Globalization;

namespace Open_Lab_05._03
{
    public class Numbers
    {
        public string FormatNum(int num)
        {

            return (String.Format("{0:#,#}", num));

        }
    }
}
