using Microsoft.EntityFrameworkCore;
using TestCRM.Data;

namespace TestCRM.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TestCRMContext(
                serviceProvider.GetRequiredService<DbContextOptions<TestCRMContext>>()))
            {
                if(context.UserModel.Any())
                {
                    return;
                }

                context.UserModel.AddRange(
                    new UserModel
                    {
                        Name = "Roman",
                        SurName = "Developer"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
