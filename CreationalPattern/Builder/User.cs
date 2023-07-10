namespace DesignPattern.CreationalPattern.Builder
{
    public class User
    {
        private string name;
        private string password;
        private string nickName;
        private int? age;

        private User(string name, string password, string nickName, int? age)
        {
            this.name = name;
            this.password = password;
            this.nickName = nickName;
            this.age = age;
        }

        public void Display()
        {
            Console.WriteLine($"Name:{name},Password:{password},NickName:{nickName},Age:{age}");
        }

        public static UserBuilder Builder()
        {
            return new UserBuilder();
        }

        public class UserBuilder
        {

            private string name;
            private string password;
            private string nickName;
            private int? age;

            public UserBuilder() { 
                this.name = "NO-NAME";
                this.password = "NO-PASSWORD";
                this.nickName = "NO-NICKNAME";
                this.age = null;
            }

            public UserBuilder Name(string name){
                this.name = name;
                return this;
            }
            public UserBuilder Password(string password){
                this.password = password;
                return this;
            }
            public UserBuilder NickName(string nickName){
                this.nickName = nickName;
                return this;
            }
            public UserBuilder Age(int age){
                this.age = age;
                return this;
            }

            public User Build(){
                return new User(name,password,nickName,age);
            }
        }
    }
}