using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspNetTest.Models
{
    public class QuestionContext : DbContext
    {
        public DbSet<QuestionModel> Questions { get; set; }
    }
}