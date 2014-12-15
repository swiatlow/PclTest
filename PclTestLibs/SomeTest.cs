using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PclTestLibs
{
    public class SomeTest
    {
        public string Test()
        {
            var json = JsonConvert.SerializeObject("test string");
            return json;
        }
    }
}
