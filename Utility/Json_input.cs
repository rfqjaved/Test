using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Converters;
using Microsoft.ProjectServer.Client;

namespace Lens_Demo.Utility
{
    public class Json_input
    { 
   
        public string Browser { get; set; }
        public Stage Stage { get; set; }

    }
    public class Stage
    {
        public Devlopment HCL_QA { get; set; }
        public Local QA { get; set; }
        public Production Staging { get; set; }
    }

    public class Devlopment
    {
        public string RunTest { get; set; }
        public string URL { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class Local
    {
        public string RunTest { get; set; }
        public string URL { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }
    public class Production
    {
        public string RunTest { get; set; }
        public string URL { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
