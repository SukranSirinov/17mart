using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    internal class Group
    {
        private string _no;
        private int _studentlimit;
        public string No
        {
            get
            {
                return this._no; 
            }
            set
            {
                if(value.Length > 0 && value.Length<5)
                    this._no = value;
            }
        }
        public int Studentlimit
        {
            get
            {
                return this._studentlimit;
            }
            set
            {
                if(value>0)
                    this._studentlimit = value;
            }
        }
        static bool CheckNo(string str)
        {
            bool hasUpper= false;
            for (int i = 0; i < str.Length; i++)
            {
                if(char.IsUpper(str[0]) && char.IsUpper(str[1]))
                    hasUpper = true;    

            }
            return hasUpper;
        }
    }
}
