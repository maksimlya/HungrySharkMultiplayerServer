﻿using System.IO;
namespace ServerApp
{
    
        public class DataLogger : LogBase
        {
            private string filePath = "/home/maks/log/data.txt";

            public override void Log(string message)
            {
                using (StreamWriter streamWriter = new StreamWriter(filePath, true))
                {
                    streamWriter.WriteLine(message);
                    streamWriter.Close();
                }
            }
        }
    
}