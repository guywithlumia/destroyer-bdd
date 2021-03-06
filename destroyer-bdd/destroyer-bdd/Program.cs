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

        public void ClearFiles() { files.Clear(); }

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

        public void DeleteFiles()
        {
            for (int i = files.Count - 1; i >= 0; i--)
            {
                File.Delete(files[i]);
                files.RemoveAt(i);
            }
        }

        public void TrashFile()
        {
            if (files.Count > 0)
            {
                var sr = new StreamReader(files[0]);
                var length = sr.ToString().Length;
                sr.Close();
                var sw = new StreamWriter(files[0]);
                var rnd = new Random();
                var chars = new char[length];

                for (int i = 0; i < length; i++) {
                    chars[i] = (char)rnd.Next('0', 'z');
                }
                sw.Write(chars);
                sw.Close();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var dest = new Destroyer();
            dest.AddFile("d:\test6.txt");
            dest.TrashFile();
        }
    }
}
