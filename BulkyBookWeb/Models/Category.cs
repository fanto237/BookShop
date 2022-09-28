using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models;

public class Category
{
    [Key] public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public int DisplayOrder { get; set; }
    public DateTime CreateDateTime { get; set; } = DateTime.Now;
}