using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    [Required(ErrorMessage = "You must add the Machines Name")]
    public string MachineName { get; set; }
    [Required(ErrorMessage = "You must add the install date")]
    public string InstallDate { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}