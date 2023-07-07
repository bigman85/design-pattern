namespace DesignPattern.BehaviorPattern.Iterator
{
    internal class Users 
    {
        public Users() { }
        public List<User> UserList { get; set; } = new List<User>();
        public void Add(User user)
        {
            this.UserList.Add(user);
        }

        public UserIterator GetIterator()
        {
            return new UserIterator(this);
        }

        public int Length { get { return this.UserList.Count; } }

        public User this[int index]
        {
            get { return UserList[index]; }
        }
    }
}
