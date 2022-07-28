using System.ComponentModel.DataAnnotations;

namespace backend333.RequestModels;

public class Store
{
    [Key] public int Id { get; set; }
    public string Heading { get; set; }
    public string MainText { get; set; }
}