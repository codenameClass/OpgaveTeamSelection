using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveTeamSelection
{
    class FileProcessor
    {
        //bestandlezen
        //per team playerfactory

        public string source { get; set; }

        public static void ReadFile()
        {
            bool result = false;
            try
            {
                // een bestand inlezen. 
                using (StreamReader sr = new StreamReader(this.fileName))
                {
                    // Lees tot het einde van het bestand
                    this.text = sr.ReadToEnd();
                    this.melding = String.Format("bestandlezen: ", this.source);
                    result = true;
                }
            }
            catch (Exception e)
            {
                // foutieve melding             
                this.melding = $"Kan het bestand {this.source} niet inlezen.\nFoutmelding {e.Message}.";
            }
            return result;
        }

    }
}