﻿using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcDynamoAWS.Models
{
    public class Motor
    {
        [DynamoDBProperty("tipo")]
        public string Tipo { get; set; }
        [DynamoDBProperty("cilindrada")]
        public int Cilindrada { get; set; }
        [DynamoDBProperty("caballos")]
        public int Caballos { get; set; }
    }
}
