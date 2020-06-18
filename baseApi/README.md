# Basic API with dotnet and C\#

This API is build based on you tube training.

## Development

Started with basic web template `dotnet new web baseApi`.

Added MVC dependecies and removed boilerplate code in Startup.cs

### Controllers

The controllers are routes classes. These are in the namespace `Controllers`. They can be in multiple files. One per file seem to me propper. One can use word Controller in the file names and these will be ignored. I am omitting controller word in file and classnames. Each class need to be decorated in order to mark it as route and the http verb.

One can use `[controller]` in the route decorator to indicate that route should have same name as the class.

Created CommandsController.cs that inerits from ControllerBase.

```c#
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace baseApi.Controllers{
  [Route("/")]
  // decorate class to be api controller
  [ApiController]
  public class Root:ControllerBase{
    [HttpGet] // decorate methods as http get method
    public ActionResult<IEnumerable<string>> getString(){
      return new string[] {"This is returned from commands"};
    }
  }
}

```

## Models

There are classes in the model folder. Used namespace is `Models`. To access data from database Entity frameworks is used. To bind routes and controllers to database using C# some work is involved:

- it requires models definitions as defined in model folder
- it requires db connection definitions.

Microsoft users normally use MS SQL server. There is a free Express version. In addition you need dotnet entity framework. To check:

```bash
# check if dotnet entity framework is installed
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
```

Eventially I installed dotnet-ef module. It can only be installed globally?!?

```bash

dotnet tool install --global dotnet-ef

```

### DB connection

It is called in MS words Context. Sometimes this definitions are placed in the separate file. I decided to keep it in the same file. In this case models/Commands.cs.

The connection string itself is placed in appsettings.json
