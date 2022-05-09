using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcDynamoAWS.Models
{
    [DynamoDBTable("coches2")]
    public class Coche
    {
        [DynamoDBHashKey]
        [DynamoDBProperty("idcoche")]
        public int IdCoche { get; set; }
        [DynamoDBProperty("marca")]
        public string Marca { get; set; }
        [DynamoDBProperty("modelo")]
        public string Modelo { get; set; }
        [DynamoDBProperty("velocidad")]
        public int Velocidad { get; set; }

        [DynamoDBProperty("motor")]
        public Motor Motor { get; set; }
    }
}
