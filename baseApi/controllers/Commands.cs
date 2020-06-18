using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace baseApi.Controllers{
  [Route("[controller]")]
  // decorate class to be api controller
  [ApiController]
  public class Commands:ControllerBase{
    [HttpGet] // decorate methods as http get method
    public ActionResult<IEnumerable<string>> getString(){
      return new string[] {"This is returned from commands"};
    }
  }

  [Route("[controller]")]
  // Decorate class to be api controller
  [ApiController]
  public class Names:ControllerBase{
    [HttpGet] // decorate methods as http get method
    public ActionResult<IEnumerable<string>> getString(){
      return new string[] {"Returned from names controller"};
    }
  }

}
