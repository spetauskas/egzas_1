namespace egzas_1.InitialData
{
    public class UsersInitialDataSeed
    {
        public static List<User> Users => new()
        {
            new User
            {
                Id = Guid.NewGuid(),
                UserName = "John",
                UserSurName = "Doe",
                UserCountry = "USA",
                UserIdentityNumber = 12345,
                UserEmail = "john.doe@example.com",
                UserResidenceCity = "New York",
                UserResidenceStreet = "Broadway",
                UserResidenceHouseNumber = "123",
               
            },
            new User
            {
                Id = Guid.NewGuid(),
                UserName = "Jane",
                UserSurName = "Smith",
                UserCountry = "Canada",
                UserIdentityNumber = 54321,
                UserEmail = "jane.smith@example.com",
                UserResidenceCity = "Toronto",
                UserResidenceStreet = "Queen Street",
                UserResidenceHouseNumber = "456",
                
            },
            new User
            {
                Id = Guid.NewGuid(),
                UserName = "Alice",
                UserSurName = "Johnson",
                UserCountry = "Australia",
                UserIdentityNumber = 98765,
                UserEmail = "alice.johnson@example.com",
                UserResidenceCity = "Sydney",
                UserResidenceStreet = "George Street",
                UserResidenceHouseNumber = "789",
                
            },
            //new User
            //{
            //    Id = Guid.NewGuid(),
            //    UserName = "Bob",
            //    UserSurName = "Brown",
            //    UserCountry = "UK",
            //    UserIdentityNumber = 67890,
            //    UserEmail = "bob.brown@example.com",
            //    UserResidenceCity = "London",
            //    UserResidenceStreet = "Baker Street",
            //    UserResidenceHouseNumber = "221B",
                
            //},
            //new User
            //{
            //    Id = Guid.NewGuid(),
            //    UserName = "Emily",
            //    UserSurName = "Davis",
            //    UserCountry = "New Zealand",
            //    UserIdentityNumber = 12321,
            //    UserEmail = "emily.davis@example.com",
            //    UserResidenceCity = "Auckland",
            //    UserResidenceStreet = "Victoria Street",
            //    UserResidenceHouseNumber = "102",

            //}

        };
    }
}
