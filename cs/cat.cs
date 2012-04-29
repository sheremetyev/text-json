using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;

namespace Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            string input = sr.ReadToEnd();
            sr.Dispose();

            JavaScriptSerializer ser = new JavaScriptSerializer();
            dynamic json = ser.DeserializeObject(input);
            for (int i = 1; i < json.Length; i++)
            {
                dynamic block = json[i];
                string blockType = block[0];
                Dictionary<string, object> blockAttr = block[1];

                for (int j = 2; j < block.Length; j++)
                {
                    dynamic span = block[j];
                    string spanType = span[0];
                    string text = span[1];
                    Console.Write(text);
                }

                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
