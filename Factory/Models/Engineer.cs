using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    public string EngineerName { get; set; }
    public string HireDate { get; set; }
    public string EngineerLicense { get; set; }
    public List<EngineerMachines> JoinEntities { get; }
  }
}