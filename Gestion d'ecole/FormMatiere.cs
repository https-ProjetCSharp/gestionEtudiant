using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_d_ecole
{
    public partial class FormMatiere : Form
    {
        public FormMatiere()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var matiere = new Matiere
            {
                NomMatiere = txtNomMatiere.Text
            };

            using (var context = new DB())
            {
                context.Matieres.Add(matiere);
                context.SaveChanges();
                MessageBox.Show("Matière ajouté avec succés");
                loadMatiere();
            }
        }
        public void loadMatiere()
        {
            txtNomMatiere.Text = "";
            DB db = new DB();
            dataGridViewMatiere.DataSource = db.Matieres.Select(c => new { c.Id, c.NomMatiere })
                               .ToList(); ;
        }

        private void FormMatiere_Load(object sender, EventArgs e)
        {
            loadMatiere();
        }
    }
}
