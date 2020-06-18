using System.Collections.Generic;
// this is my model
using Commmander.Models;

namespace Commmander.Data{
  public interface ICommandRepo
  {
      IEnumerable<Command> GetAppCommands();
      Command GetCommandById(int id);
  }
  public interface ICommand
  {
      
  }
}