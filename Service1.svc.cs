using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SortWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string sort(string s)
        {
            string result = "";
            

            // convert the string into an array of integers
            string[] numString = s.Split(',');
            int[] num = new int[numString.Length];
         
            // put into the array
            for (int i = 0; i < numString.Length; i++)
            {
                num[i] = Int32.Parse(numString[i]);
                //Debug.Write(num[i]);
            }

            Array.Sort(num);

            result = string.Join(",", num);

            return result;
        }
    }
}
