using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_d_ecole
{
    internal class OTPCode
    {
        public int Id { get; set; }
        public int IdUtilisateur { get; set; }
        public string Code { get; set; }
        public DateTime DateExpiration { get; set; }
        public Utilisateur Utilisateur { get; set; }
    }
}
