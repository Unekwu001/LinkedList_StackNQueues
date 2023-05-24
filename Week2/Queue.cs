using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{

	public class TheoQueue<T>
	{

		private LinkedListMethods<T> queue;
		public TheoQueue()
		{
			queue = new LinkedListMethods<T>();
		}

		//-------------------------------------------------------------------------------------------------
		public bool IsEmpty()
		{
			if (queue == null)
			{
				return true;
			}
			return false;
		}

		//--------------------------------------------------------------------------------------------------- 
		public void Enqueue(T item)
		{
			queue.Add(item);
		}

		//--------------------------------------------------------------------------------------------------
		public T Dequeue()
		{
			if (IsEmpty())
			{
				Console.WriteLine(("Queue is empty"));
			}
			T item = queue.head.Data;
			queue.Remove(item);
			return item;
		}

		//--------------------------------------------------------------------------------------------------
		public int Size()
		{
			return queue.ListSize();
		}
	}
}