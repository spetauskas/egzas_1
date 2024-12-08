using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace egzas_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<UserController> _logger;
        //private readonly IAccountRepository _repository;
        //private readonly IJwtService _jwtService;
        //private readonly IAccountMapper _mapper;
        //private readonly IAccountService _service;
        public UserController(ILogger<UserController> logger
            //IAccountRepository repository,
            //IJwtService jwtService,
            //IAccountMapper mapper,
            //IAccountService service
            )
        {
            _logger = logger;
            //_repository = repository;
            //_jwtService = jwtService;
            //_mapper = mapper;
            //_service = service;
        }

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }






        [HttpGet("GetUserByName")]
        [ProducesResponseType(typeof(IEnumerable<User>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetUserByName([FromQuery] string userName)
        {
            // Use EF Core to query the database
            var users = await _context.Users
                .Where(u => u.UserName == userName)
                .ToListAsync();

            if (users == null || !users.Any())
            {
                return NotFound("No users found with the given name.");
            }
            return Ok(users);
        }

        [HttpPost("CreateUser")]
        [ProducesResponseType(typeof(User), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateUser([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest("User data is required.");
            }

            // Validate user input
            if (string.IsNullOrWhiteSpace(user.UserName) ||
                string.IsNullOrWhiteSpace(user.UserEmail))
            {
                return BadRequest("Username and email are required.");
            }

            // Check for existing user with same email
            var existingUser = await _context.Users
                .FirstOrDefaultAsync(u => u.UserEmail == user.UserEmail);

            if (existingUser != null)
            {
                return BadRequest("A user with this email already exists.");
            }

            // Generate account if not provided
            if (user.Account == null)
            {
                user.Account = new Account
                {
                    AccountId = Guid.NewGuid(),
                    AccountName = user.UserName.ToLower(),
                    AccountRole = "user"
                };
            }

            // Hash password if account exists
            if (user.Account != null)
            {
                var (passwordHash, passwordSalt) = HashPassword("defaultPassword");
                user.Account.AccountPasswordHash = passwordHash;
                user.Account.AccountPasswordSalt = passwordSalt;
            }

            // Add user to context and save
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUserByName),
                new { userName = user.UserName }, user);
        }

        // Helper method for password hashing
        private (byte[] PasswordHash, byte[] PasswordSalt) HashPassword(string password)
        {
            using (var hmac = new HMACSHA512())
            {
                var passwordSalt = hmac.Key;
                var passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return (passwordHash, passwordSalt);
            }
        }

        [HttpGet("SeedInitialUsers")]
        public async Task<IActionResult> SeedInitialUsers()
        {
            // Only seed if no users exist
            if (!_context.Users.Any())
            {
                var users = new List<User>
                {
                    
                };

                _context.Users.AddRange(users);
                await _context.SaveChangesAsync();

                return Ok($"{users.Count} users seeded successfully");
            }

            return Ok("Database already contains users");
        }
    }
}