using System;
using System.Collections.Generic;
using System.Text;

namespace July13Examples
{
    public class AccessorService
    {
        public AccessorService()
        {

        }

        public List<string> ShowGreeting()
        {
            var result = new List<string>();
            var epheral = PrependHiToString("Shari", "Sid");
            result.Add(epheral);
            var fugazi = PrependHiToString("Shari");
            result.Add(fugazi);
            return result;
        }

        public string SomeProperty { get; set; }

        private string PrependHiToString(string value)
        {
            return $"Hi {value}";
        } 

        //You can have the same method name as above if you use method overload
        private string PrependHiToString(string value, string valueTwo)
        {
            return $"Hi {value} {valueTwo}";
        }
    }
}
