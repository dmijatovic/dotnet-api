using Microsoft.EntityFrameworkCore;

namespace baseApi.Models{
  public class Command{

    public int id{get;set;}
    public string howto {get;set;}
    public string platform {get;set;}
    public string comandline {get;set;}
  }

  public class CommandContext:DbContext{
    public CommandContext(DbContextOptions<CommandContext> options):base(options){

    }
    public DbSet<Command>CommandItems {get; set;}
  }
}
