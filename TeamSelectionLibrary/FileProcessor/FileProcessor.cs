﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TeamSelectionLibrary
{
    public class FileProcessor
    {

        public static List<string> ReadFile(string path)
        {
            List<string> lijnen = new List<string>();
            using (StreamReader sr = File.OpenText(path))
            {
                string input = null;
                while ((input = sr.ReadLine()) != null)
                {
                    lijnen.Add(input);
                }
            }
            return lijnen;
        }

    }
}
            //try
            //{
            //    // een bestand inlezen. 
            //    using (StreamReader sr = new StreamReader(this.fileName))
            //    {
            //        // Lees tot het einde van het bestand
            //        this.text = sr.ReadToEnd();
            //        this.melding = String.Format("bestandlezen: ", this.source);
            //        result = true;
            //    }
            //}
            //catch (Exception e)
            //{
            //    // foutieve melding             
            //    this.melding = $"Kan het bestand {this.source} niet inlezen.\nFoutmelding {e.Message}.";
            //}