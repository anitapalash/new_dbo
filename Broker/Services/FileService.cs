using Newtonsoft.Json;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Broker.Identity.Client;

namespace Broker.Services.FileService
{
    class FileService
    {
        public void WriteToFile(Client client)
        {
            string jsonClient = JsonConvert.SerializeObject(client);
            string path = @"..\Data.JSON";
            File.WriteAllText(path, jsonClient);

        }


        }
    }

