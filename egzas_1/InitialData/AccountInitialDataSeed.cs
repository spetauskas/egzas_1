using System.Security.Cryptography;
using System.Text;

namespace egzas_1.InitialData
{
    public static class AccountInitialDataSeed
    {
        public static List<Account> Accounts => new()
        {
            user1(),
            user2(),
            user3(),
            //user4(),
            //user5(),
        };

        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using var hmac = new HMACSHA256();
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        }
        private static Account user1()
        {
            CreatePasswordHash("user1", out var passwordHash, out var passwordSalt);
            return new Account
            {
                AccountId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                AccountName = "user1",
                AccountPasswordHash = passwordHash,
                AccountPasswordSalt = passwordSalt,
                AccountRole = "admin",
            };
        }
        private static Account user2()
        {
            CreatePasswordHash("user2", out var passwordHash, out var passwordSalt);
            return new Account
            {
                AccountId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                AccountName = "user2",
                AccountPasswordHash = passwordHash,
                AccountPasswordSalt = passwordSalt,
                AccountRole = "admin",
            };
        }
        private static Account user3()
        {
            CreatePasswordHash("user3Password", out var passwordHash, out var passwordSalt);
            return new Account
            {
                AccountId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                AccountName = "user3",
                AccountPasswordHash = passwordHash,
                AccountPasswordSalt = passwordSalt,
                AccountRole = "admin",
            };
        }

        //private static Account user4()
        //{
        //    CreatePasswordHash("secureUser4", out var passwordHash, out var passwordSalt);
        //    return new Account
        //    {
        //        AccountId = Guid.NewGuid(),
        //        AccountName = "user4",
        //        AccountPasswordHash = passwordHash,
        //        AccountPasswordSalt = passwordSalt,
        //        AccountRole = "admin",
        //    };
        //}

        //private static Account user5()
        //{
        //    CreatePasswordHash("user5Secret", out var passwordHash, out var passwordSalt);
        //    return new Account
        //    {
        //        AccountId = Guid.NewGuid(),
        //        AccountName = "user5",
        //        AccountPasswordHash = passwordHash,
        //        AccountPasswordSalt = passwordSalt,
        //        AccountRole = "admin",
        //    };
        //}

    }
}
