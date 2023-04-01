using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsUI
{
    internal class PerformanceTests
    {
        Dictionary<int, Library> map = new Dictionary<int, Library>();
        Library[] libraries = new Library[100000];
        Random random = new Random();

        public void CreateArray()
        {
            for (int i = 0; i < 100000; i++)
            {
                libraries[i] = new Library();
            }
        }

        public void CreateDictionary()
        {
            for (int i = 0; i < 100000; i++)
            {
                map.Add(i, new Library());
            }
        }

        public void TakeFromArrayInOrder()
        {
            for (int i = 0; i < 100000; i++)
            {
                Library lib = map[i];
            }
        }

        public void TakeFromDictionaryInOrder()
        {
            for (int i = 0; i < 100000; i++)
            {
                Library lib = map[i];
            }
        }

        public void TakeFromArrayInRandom()
        {
            for (int i = 0; i < 100000; i++)
            {
                Library lib = libraries[random.Next(0, 100000)];
            }
        }

        public void TakeFromDictionaryInRandom()
        {
            for (int i = 0; i < 100000; i++)
            {
                Library lib = map[random.Next(0, 100000)];
            }
        }
    }
}
