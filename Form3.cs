using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fairplay
{
    public partial class Form3 : Form
    {
        fairplayEntities context = new fairplayEntities();
        public Form3()
        {
            InitializeComponent();
            cmbclasse.DataSource = context.departement.ToList();
            //cmbclasse.DataSource = context.Classe.ToList();
            cmbclasse.DisplayMember = "libelleDep";
            cmbclasse.ValueMember = "idDep";
            dGV1.DataSource = context.Employee.ToList();
        }

      

        private void btnvalider_Click(object sender, EventArgs e)
        {
            Employee etudiants = new Employee();
            etudiants.prenomemp = txtprenom.Text;
            etudiants.nomemp = txtnom.Text;
            etudiants.fonction = txtfonction.Text;
            etudiants.salaire = int.Parse(txtsalaire.Text);
            etudiants.idDepartment = Convert.ToInt32(cmbclasse.SelectedValue);
            context.Employee.Add(etudiants);
            context.SaveChanges();

            MessageBox.Show("Ajout reussi...");
            dGV1.DataSource = context.Employee.ToList();
            effacer();
        }

        private void dGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dGV1.Rows[e.RowIndex];
                txtid.Text = row.Cells[0].Value.ToString();
                txtprenom.Text = row.Cells[1].Value.ToString();
                txtnom.Text = row.Cells[2].Value.ToString();
                txtfonction.Text = row.Cells[3].Value.ToString();
                txtsalaire.Text = row.Cells[4].Value.ToString();
                cmbclasse.Text = row.Cells[5].Value.ToString();

            }
        }

        void effacer()
        {
            txtprenom.Text = "";
            txtnom.Text = "";
            txtfonction.Text = "";
            txtsalaire.Text = "";
            cmbclasse.Text = "";
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            var context = new fairplayEntities();
            if (int.TryParse(txtid.Text.Trim(), out int entityId))
            {
                Employee personneToUpdate = context.Employee.Find(entityId);

                if (personneToUpdate != null)
                {
                    personneToUpdate.prenomemp = txtprenom.Text;
                    personneToUpdate.nomemp = txtnom.Text;
                    personneToUpdate.fonction =txtfonction.Text;
                    personneToUpdate.salaire = int.Parse(txtsalaire.Text);
                    personneToUpdate.idDepartment = Convert.ToInt32(cmbclasse.SelectedValue);
                    context.SaveChanges();
                    MessageBox.Show("Modification réussie...");
                    dGV1.DataSource = context.Employee.ToList();
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

        private void btnsuprimer_Click(object sender, EventArgs e)
        {
            var context = new fairplayEntities();
            if (int.TryParse(txtid.Text.Trim(), out int entityId))
            {
                Employee etudiantToDelete = context.Employee.Find(entityId);

                if (etudiantToDelete != null)
                {
                    context.Employee.Remove(etudiantToDelete);
                    context.SaveChanges();
                    MessageBox.Show("Suppression réussie...");
                    dGV1.DataSource = context.Employee.ToList();
                    effacer();
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

        private void btnrechercher_Click(object sender, EventArgs e)
        {
            string searchText = txtrechercher.Text.Trim();
            var selectedDepartment = (departement)cmbclasse.SelectedItem;

            var etudiants = context.Employee.AsQueryable();

            if (!string.IsNullOrEmpty(searchText))
            {
                etudiants = etudiants.Where(etudiant => etudiant.fonction.StartsWith(searchText));
            }

            if (selectedDepartment != null)
            {
                etudiants = etudiants.Where(etudiant => etudiant.idDepartment == selectedDepartment.idDep);
            }

            dGV1.DataSource = etudiants.ToList();
        }
    }
}
