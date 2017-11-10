using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Microsoft_Graph_REST_ASPNET_Connect.Models
{
    public class UserInfo
    {
        public string Name { get; set; }
        public string Address { get; set; }

    }

    public class UserInfoRequest
    {
        public string index { get; set; }
        public string[][] values { get; set; }
    }
}

