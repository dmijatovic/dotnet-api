using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace baseApi.Controllers{
  [Route("/")]
  // decorate class to be api controller
  [ApiController]
  public class Root:ControllerBase{
    [HttpGet] // decorate methods as http get method
    public ActionResult<IEnumerable<string>> getString(){
      return new string[] {"This is returned from commands. Does it watch"};
    }
  }
}
