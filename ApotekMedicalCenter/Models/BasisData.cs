using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotekMedicalCenter.Models
{
    public class BasisData : DbContext
    {
        public DbSet<AkunModel> Akun { set; get; }
    }
}
