namespace BuilderPattern
{
    /// <summary>
    /// This is a best practice for maintaining immunitibility
    /// </summary>
    public class User : IUser
    {
        private int id;
        private string name;
        private string address;
        private int age;
        public int Id { get { return id; } }

        public string Name { get { return name; } }

        public string Address { get { return address; } }

        public int Age { get { return age; } }

        //Private Constructor will not alllow to create anew class out side this.
        private User() { }


        public class UserBuilder
        {
            private readonly User user;
            public UserBuilder()
            {
                user = new User();
            }
            public UserBuilder SetName(string name) {
                user.name = name;
                return this;
            }
            public UserBuilder SetAddress(string address)
            {
                user.address = address;
                return this;
            }
            public UserBuilder SetAge(int age)
            {
                user.age = age;
                return this;
            }

            public User Build() { 
            return user;
            }
        }

    }
}
