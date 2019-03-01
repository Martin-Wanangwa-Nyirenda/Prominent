using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Prominent
{
    class DataProvider
    {
        private Stream jsonStream;

        public DataProvider(MemoryStream stream)
        {
            jsonStream = stream;
        }

        public DataProvider(string jsonfile)
        {
            try
            {
                jsonStream = new FileStream(jsonfile, FileMode.Open);
            }
            catch (FileNotFoundException err)
            {
                throw err;
            }          
        }

        private void DeserializeJSON()
        {

        }
    }
}
