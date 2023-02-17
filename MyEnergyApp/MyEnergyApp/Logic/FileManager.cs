using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEnergyApp.Logic
{
    internal class FileManager
    {
        private static readonly string path = "../../../Files/";

        internal static List<string> SplitFileToStringList(string fileName)
        {
            List<string> list = new();
            string[] splitlist = File.ReadAllText(path + fileName).Split('|');
            foreach (var item in splitlist)
            {
                list.Add(item);
            }
            return list;
        }

        internal static async Task<List<string>> SplitFileToStringListAsync(string fileName)
        {
            List<string> list = new();
            string text = await File.ReadAllTextAsync(path + fileName);
            string[] splitText = text.Split("|");

            foreach (var item in splitText)
            {
                list.Add(item);
            }
            return list;
        }
    }
}
