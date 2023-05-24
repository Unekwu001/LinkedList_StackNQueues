namespace Week2
{
    public class LinkedListMethods<T>
    {
        internal TheoNode<T>? head;
        internal TheoNode<T>? previous;
        internal TheoNode<T>? current;
		internal TheoNode<T>? tail;

		public LinkedListMethods()
        {
            head = null;
            previous = null;
            current = null;
			tail = null;	
        }
        //-----------------------------------------------------------------------------------------------
        public void Add(T mydata)
        {
            var newNode = new TheoNode<T>(mydata);

            if (head is null)
            {
                head = newNode; // assign newNode to head because it means the linkedlist is empty.
            }
            else
            {
                current = head;
                while (current.Next != null)
                {

                    current = current.Next;
                }
				current.Next = newNode;
                Console.WriteLine(current.Data);
                
            }
        }
        //-----------------------------------------------------------------------------------------------
        public bool Remove(T item)
        {

            while (current != null)
            {
                if (current.Data!.Equals(item))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                    }
                    else
                    {
                        head = current.Next;
                    }
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }
		//------------------------------------------------------------------------------------------------------

		public bool Check(T item)
		{
			 
			while (current != null)
			{
				if (current.Data!.Equals(item))
				{
					return true;
				}
				current = current.Next;
			}
			return false;
		}
		//-----------------------------------------------------------------------------------------------------

		public int Index(T item)
		{
			 
			int index = 0;

			while (current != null)
			{
				if (current.Data!.Equals(item))
				{
					return index;
				}
				index++;
				current = current.Next;
			}
			return -1;
		}
		//------------------------------------------------------------------------------------------------------

		public T RemoveandPop()
		{
			if (head == null)
			{
				return default!;
			}

			if (head == tail)
			{
				T value = head.Data;
				head = null!;
				tail = null!;
				return value;
			}

			TheoNode<T> current = head;

			while (current.Next != tail)
			{
				current = current.Next;
			}

			T last_value = tail.Data;

			tail = current;

			tail.Next = null!;

			return last_value;
		}

		//-------------------------------------------------------------------------------------------

		public T LastItem()
		{
			if (tail == null)
			{
				return default!;
			}
			else
			{
				return tail.Data;
			}
		}
		//---------------------------------------------------------------------------------------------

		public int ListSize()
		{
			TheoNode<T> current = head;
			int count = 0;

			while (current != null)
			{
				count++;
				current = current.Next;
			}

			return count;
		}
		//----------------------------------------------------------------------------------------------
		




	}
		
}