using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotekMedicalCenter.Models
{
    public class Pengguna
    {
        BasisData db = new BasisData();

        public void Tambah(AkunModel data)
        {
            db.Akun.Add(data);
            db.SaveChanges();
        }

        public bool IsExist(string userName)
        {
            int userExist = 0;
            userExist = (from akun in db.Akun where akun.Username == userName select akun).Count();

            if (userExist == 0)
            {
                return true;
            }

            return false;
        }
    }
}
