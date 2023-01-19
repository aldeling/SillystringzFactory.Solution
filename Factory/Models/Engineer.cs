using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    // [Required(ErrorMessage = "The Engineers Name can't be blank")]
    public string EngineerName { get; set; }
    // [Required(ErrorMessage = "The hire date must be added")]
    public string HireDate { get; set; }
    // [Required(ErrorMessage = "You must add the Engineer License")]
    public string EngineerLicense { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}