using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
	internal class TheoStack<T>
	{
		public readonly LinkedListMethods<T> mylist;

		public TheoStack()
		{
			mylist = new LinkedListMethods<T>();
		}

		//--------------------------------------------------------------------------------------- 

		public bool IsEmpty()
		{
			if (mylist.head == null)
			{
				return true;
			}
			return false;
		}
		//----------------------------------------------------------------------------------------

		public void Push(T item)
		{
			mylist.Add(item);
		}

		//---------------------------------------------------------------------------------------

		public T Pop()
		{
			if (mylist.head == null)
			{
				Console.WriteLine("The stack is empty");
			}
			T value = mylist.RemoveandPop();

			return value;
		}

		//------------------------------------------------------------------------------------------

		public T Peek()
		{
			if (mylist.head == null)
			{
				Console.WriteLine("The stack is empty");
			}
			return mylist.LastItem();
		}

		//------------------------------------------------------------------------------------------


		//-----------------------------------------------------------------------------------------------
	}
}

