using System.ComponentModel.DataAnnotations;

namespace StoreBackend.Api.Models.Requests;

public class UpdateProductRequestModel
{
    [Required]
    [MaxLength(50)]
    public string? Name { get; set; }
}
