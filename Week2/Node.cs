namespace Week2
{
    public class TheoNode<T>
    {
        public T Data;
        public TheoNode<T>? Next;

        public TheoNode(T data)
        {
            Data = data;
            Next = null;
        }
    }
}