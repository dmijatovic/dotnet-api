using System.Collections.Generic;
using Commmander.Models;

namespace Commmander.Data{
  // Use Ctrl + . to implement interface automatically
  public class MockCommandRepo : ICommandRepo
  {
    public IEnumerable<Command> GetAppCommands()
    {
      var commands = new List<Command>{
        new Command{id=2, howto="Boil an egg", line="Boil", platform="kettle"},
        new Command{id=3, howto="Boil an egg", line="Boil", platform="kettle"},
        new Command{id=4, howto="Boil an egg", line="Boil", platform="kettle"},
      };
    }

    public Command GetCommandById(int id)
    {
      return new Command{id=0, howto="Boil an egg", line="Boil", platform="kettle"};
    }
  }
}