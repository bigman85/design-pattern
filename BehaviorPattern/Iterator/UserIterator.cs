namespace DesignPattern.BehaviorPattern.Iterator
{
    internal class UserIterator : IIterator
    {
        private readonly Users users;
        private int index { get; set; } = 0;
        private User current { get; set; }
        public UserIterator(Users users) 
        {
            this.users = users;
        }
        public bool HasNext()
        {
            return users.UserList.Count > index;
        }

        public object Next()
        {
            if (HasNext())
            {
                this.current = users.UserList[index];
                index++;
                return current;
            }
            throw new InvalidOperationException();

        }
    }
}
