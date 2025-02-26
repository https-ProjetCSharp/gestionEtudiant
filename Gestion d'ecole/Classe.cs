using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_d_ecole
{
    internal class Classe
    {
        public int Id { get; set; }
        public string NomClasse { get; set; }
        public List<Etudiant> Etudiants { get; set; }
        public List<ClasseCours> ClassesCours { get; set; }
        public List<ProfesseurClasse> ProfesseursClasses { get; set; }
    }
}
