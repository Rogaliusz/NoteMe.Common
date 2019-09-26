using Bogus;

namespace NoteMe.Common.Generators.Users
{
    public class UsersGenerator
    {
        public UsersGenerator()
        {
        }

        public string GetEmail()
        { 
            var faker = new Faker();
            return faker.Person.Email;
        }

        public string GetPassword()
            => "password123";
    }
}