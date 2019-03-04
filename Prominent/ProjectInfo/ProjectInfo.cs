using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Prominent.ProjectInfo
{
    class ProjectInfo
    {
        private Stream jsonStream;
        private List<Project> projects;

        public ProjectInfo(MemoryStream stream)
        {
            jsonStream = stream;
            DeserializeJSON();
        }

        public ProjectInfo(string jsonfile)
        {
            try
            {
                jsonStream = new FileStream(jsonfile, FileMode.Open);
                DeserializeJSON();
            }
            catch (FileNotFoundException err)
            {
                throw err;
            }          
        }
        /// <summary>
        /// Returns list of all projects
        /// </summary>
        /// <returns>List<Project></returns>
        public List<Project> GetProjects()
        {
            return projects;
        }

        //Converts JSON to C# Objects
        private void DeserializeJSON()
        {
            projects = JsonConvert.DeserializeObject<List<Project>>(GetJSONString(jsonStream));
        }

        //Convert a Json stream to a string
        private string GetJSONString(Stream stream)
        {
            StreamReader streamReader = new StreamReader(stream);
            string line = "";
            line += streamReader.ReadToEnd();

            return line;
        }
    }
}
