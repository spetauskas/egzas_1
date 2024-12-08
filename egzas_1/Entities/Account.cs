using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Account
{
 
    public Guid AccountId { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 3)] // Add length constraints
    public string AccountName { get; set; } = string.Empty;

    [Required]
    public byte[] AccountPasswordHash { get; set; } = null!;

    [Required]
    public byte[] AccountPasswordSalt { get; set; } = null!;

    [Required]
    [StringLength(20)] // Limit role name length
    public string AccountRole { get; set; } = "user";

    // Add navigation property
    public User? User { get; set; }
}