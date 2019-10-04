using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DndSpellbook.Models
{
    public class DndSpellbookContext : IdentityDbContext
    {
        public DndSpellbookContext (DbContextOptions<DndSpellbookContext> options)
            : base(options)
        {
        }

    }
}
