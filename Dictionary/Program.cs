using System;
using System.Collections.Generic;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary <int,string> MyDictionary = new Dictionary <int, string>();
            MyDictionary.Add(1, "Enes"); 
            MyDictionary.Add(2, "Ekrem");
            MyDictionary.Add(3, "Suat");
            MyDictionary.Add(4, "Necip");
            MyDictionary.Add(5, "Ömer");
            MyDictionary.Add(6, "Can");
            MyDictionary.Add(7, "Kadir");
            Console.WriteLine(MyDictionary.Count);

           

        }
    }
    class MyDictionary<T>
    {
        T[] _TArray;
        T[] _Array;
        public MyDictionary()
        {
            _Array = new T[0];

        }
        public void Add(T item)
        {
            _TArray = _Array;
            _Array = new T[_TArray.Length+1];
            for (int i = 0; i < _TArray.Length; i++)
            {
                _TArray[i] = _Array[i];
            }
            _Array[_Array.Length - 1] = item;

        }
        public int Count {
            get { return _Array.Length; } }

    }

}
