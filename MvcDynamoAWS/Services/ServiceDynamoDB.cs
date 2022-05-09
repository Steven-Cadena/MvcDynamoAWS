using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using MvcDynamoAWS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcDynamoAWS.Services
{
    public class ServiceDynamoDB
    {
        private DynamoDBContext context;
        public ServiceDynamoDB() 
        {
            //A PARTIR DE UN CLIENTE DYNAMODB SE CREA UN CONTEXT
            AmazonDynamoDBClient client = new AmazonDynamoDBClient();
            this.context = new DynamoDBContext(client);
        }
        //metodo asincrono
        public async Task CreateCocheAsync(Coche car) 
        {
            await this.context.SaveAsync<Coche>(car);
        }

        public async Task DeleteCocheAsync(int idCoche) 
        {
            await this.context.DeleteAsync<Coche>(idCoche);
        }

        public async Task<Coche> FindCocheAsync(int idCoche) 
        {
            //SI ESTAMOS BUSCANDO POR SU PARTITION KEY(PRIMARY KEY)
            //TENEMOS UN METODO PARA CARGAR SU BUSQUEDA 
            return await this.context.LoadAsync<Coche>(idCoche);
        }


    }
}
