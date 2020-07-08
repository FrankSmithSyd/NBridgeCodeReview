namespace ClassLibrary1
{
    public class RecentlyUsedList
    {
        private readonly List<string> items;
        public RecentlyUsedList()
        {
            items = new List<string>();
        }

        public void Add(string newItem)
        {
            if (items.Contains(newItem))
            {
                int position = items.IndexOf(newItem);

                string existingItem = items[position];
                items.RemoveAt(position);
                items.Insert(0, existingItem);
            }

            else
            {
                items.Insert(0, newItem);
            }
        }

        public int Count
        {
            get
            {
                int size = items.Count;
                return size;
            }
        }

        public string this[int index]
        {
            get
            {
                int position = 0;
                foreach (string item in items)
                {
                    if (position == index)
                        return item;
                    ++position;
                }

                throw new ArgumentOutOfRangeException();
            }
        }
    }
}