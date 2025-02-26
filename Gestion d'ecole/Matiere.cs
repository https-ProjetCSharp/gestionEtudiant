using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_d_ecole
{
    internal class Matiere
    {
        public int Id { get; set; }
        public string NomMatiere { get; set; }
        public List<CoursMatiere> CoursMatieres { get; set; }
        public List<ProfesseurMatiere> ProfesseursMatieres { get; set; }
    }
}
