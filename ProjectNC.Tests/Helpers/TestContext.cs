using Microsoft.EntityFrameworkCore;
using ProjectNC.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNC.Tests.Helpers
{
    public class TestContext
    {
        public AppDbContext GetTestContext(string testDb)
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(testDb)
                .Options;

            var dbcontext = new AppDbContext(options);

            return dbcontext;
        }

    }
}
