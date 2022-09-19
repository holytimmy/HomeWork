namespace _10._1
{
    public class MyList<T>
    {
        public T myList { get; set; }

        public int this[int index]
        {
            get { return index; }
            set { index = value; }
        }

        public T Add(T item)
        {
            return item;
        }
    }
}
