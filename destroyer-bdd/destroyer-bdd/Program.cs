﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace destroyer_bdd
{
    public class Destroyer
    {
        List<string> files = new List<string>();

        public void AddFile(string path)
        {
            if (File.Exists(path))
            {
                files.Add(path);
            }
        }

        public int FileCount()
        {
            return files.Count;
        }

        public void DeleteFirstFile()
        {
            if (files.Count > 0)
            {
                File.Delete(files[0]);
                files.RemoveAt(0);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
