using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace fairplay
{
    public partial class Form2 : Form
    {
        fairplayEntities context = new fairplayEntities();
        public Form2()
        {
            InitializeComponent();
            dataGridView1.DataSource = context.departement.ToList();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            departement departement = new departement();
            departement.libelleDep = txtlibelle.Text;
            context.departement.Add(departement);
            context.SaveChanges();
            effacer();
            MessageBox.Show("Ajout reussi...");
            dataGridView1.DataSource = context.departement.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var context = new fairplayEntities();
            if (int.TryParse(txtid.Text.Trim(), out int entityId))
            {
                departement personneToUpdate = context.departement.Find(entityId);

                if (personneToUpdate != null)
                {
                    personneToUpdate.libelleDep = txtlibelle.Text;
                    context.SaveChanges();
                    MessageBox.Show("Modification réussie...");
                    dataGridView1.DataSource = context.departement.ToList();
                    effacer();
                }
                else
                {
                    MessageBox.Show("Entité à mettre à jour non trouvée.");
                }
            }
            else
            {
                MessageBox.Show("ID invalide.");
            }
        }
        private void effacer()
        {
            txtlibelle.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtid.Text = row.Cells[0].Value.ToString();
                txtlibelle.Text = row.Cells[1].Value.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var context = new fairplayEntities();
            if (int.TryParse(txtid.Text.Trim(), out int entityId))
            {
                departement classeToDelete = context.departement.Find(entityId);

                if (classeToDelete != null)
                {
                    context.departement.Remove(classeToDelete);
                    context.SaveChanges();
                    MessageBox.Show("Suppression réussie...");
                    dataGridView1.DataSource = context.departement.ToList();
                }
                else
                {
                    MessageBox.Show("Entité à supprimer non trouvée.");
                }
            }
            else
            {
                MessageBox.Show("ID invalide.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var context = new fairplayEntities();
            string searchTerm = txtrechercher.Text.Trim();
            var result = context.departement
                                .Where(c => c.libelleDep.Contains(searchTerm))
                                .ToList();
            dataGridView1.DataSource = result;
        }
    }
}
