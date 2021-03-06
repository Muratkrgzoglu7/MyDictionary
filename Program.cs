using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
	class Program
	{
		
		static void Main(string[] args)
		{
			
			MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
			myDictionary.Add( "Neo",10);
			myDictionary.Add( "Trainman",11);
			myDictionary.Add( "Architect", 12);
			myDictionary.Listele();

		}
		public class MyDictionary<T, K>
		{
			K[] _Value;
			T[] _Key;
			public MyDictionary()
			{
				_Value = new K[0];
				_Key = new T[0];
			}
			public void Add(T item, K itemK)
			{
				K[] tempArrayK = _Value;
				T[] tempArray = _Key;
				_Key = new T[_Key.Length + 1];
				_Value = new K[_Value.Length + 1];
				for (int i = 0; i < tempArray.Length; i++)
				{
					_Value[i] = tempArrayK[i];
					_Key[i] = tempArray[i];
				}
				_Value[_Value.Length - 1] = itemK;
				_Key[_Key.Length - 1] = item;
			}
			public void Listele()
			{
				for (int i = 0; i < _Value.Length; i++)
				{
					Console.WriteLine(_Key[i] + " " + _Value[i]);
				}

			}

		}
	}
}
