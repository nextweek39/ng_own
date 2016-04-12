using System.Linq;
using Microsoft.AspNet.Builder;
using Microsoft.Extensions.DependencyInjection;

using ngown_2.Models;

namespace ngown_2.Migrations
{
    public static class SampleDataInitializer
    {
 
        public static void EnsureSeedData(this ApplicationDbContext context)
        {
          
                if (!context.Person.Any())
                {


                context.Person.AddRange(
                    new Person { Name = "Mark Trinidad", Address = "Cebu" },
                    new Person { Name = "Mark Trinidad", Address = "Manila" }
                    );
                       

                    context.SaveChanges();
                }

            
        }
    }
}
