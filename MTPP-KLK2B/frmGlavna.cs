using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTPP_KLK2B
{
    public partial class frmGlavna : Form
    {
        public frmGlavna()
        {
            InitializeComponent();

            using (var context = new ProveraZnanjaDB())
            {
                var provereZnanja = context.ProveraZnanjas.ToList();
                dgvProvereZnanja.DataSource = context.ProveraZnanjas.ToList();

                var pitanja = context.Pitanjas.ToList();
                dgvPitanja.DataSource = pitanja;

                var odgovori = context.Odgovori.ToList();
                dgvOdgovori.DataSource = odgovori;
            }

            AzurirajComboBoxProvereZnanja();
        }

        private void dgvProvereZnanja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProvereZnanja.SelectedRows.Count == 0)
            {
                return;
            }

            int selectedRowIndex = dgvProvereZnanja.SelectedCells[0].RowIndex;

            txtIdProvereZnanja.Text = dgvProvereZnanja.Rows[selectedRowIndex].Cells[0].Value.ToString();
            txtNazivProvere.Text = dgvProvereZnanja.Rows[selectedRowIndex].Cells[1].Value.ToString();
            txtGodinaProvere.Text = Convert.ToDateTime(dgvProvereZnanja.Rows[selectedRowIndex].Cells[2].Value).Year.ToString();

            if (dgvProvereZnanja.Rows[selectedRowIndex].Cells[3].Value == null ||
                dgvProvereZnanja.Rows[selectedRowIndex].Cells[3].Value.ToString() == string.Empty)
            {
                txtTrajanjeProvere.Text = string.Empty;
            }
            else
                txtTrajanjeProvere.Text = dgvProvereZnanja.Rows[selectedRowIndex].Cells[3].Value.ToString();
        }

        private void btnPonistiDodavanjeProvereZnanja_Click(object sender, EventArgs e)
        {
            txtIdProvereZnanja.Text = string.Empty;
            txtNazivProvere.Text = string.Empty;
            txtGodinaProvere.Text = string.Empty;
            txtTrajanjeProvere.Text = string.Empty;
        }

        private void btnDodajProveruZnanja_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNazivProvere.Text) || string.IsNullOrEmpty(txtGodinaProvere.Text))
            {
                MessageBox.Show("Molimo unesite naziv i godinu provere znanja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtIdProvereZnanja.Text))
            {
                using (var context = new ProveraZnanjaDB())
                {
                    var novaProvera = new ProveraZnanja
                    {
                        NazivProvere = txtNazivProvere.Text,
                        GodinaProvere = new DateTime(Convert.ToInt16(txtGodinaProvere.Text), 1, 1),
                        TrajanjeProvere = string.IsNullOrEmpty(txtTrajanjeProvere.Text) ? (int?)null : int.Parse(txtTrajanjeProvere.Text)
                    };
                    context.ProveraZnanjas.Add(novaProvera);
                    context.SaveChanges();
                    dgvProvereZnanja.DataSource = context.ProveraZnanjas.ToList();
                }
            }
            else
            {
                using (var context = new ProveraZnanjaDB())
                {
                    int idProvere = int.Parse(txtIdProvereZnanja.Text);
                    var provera = context.ProveraZnanjas.Find(idProvere);

                    if (provera != null)
                    {
                        provera.NazivProvere = txtNazivProvere.Text;
                        provera.GodinaProvere = DateTime.Parse(txtGodinaProvere.Text);
                        provera.TrajanjeProvere = string.IsNullOrEmpty(txtTrajanjeProvere.Text) ? (int?)null : int.Parse(txtTrajanjeProvere.Text);
                        context.SaveChanges();
                        dgvProvereZnanja.DataSource = context.ProveraZnanjas.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Provera znanja sa datim ID-jem ne postoji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            AzurirajComboBoxProvereZnanja();
        }

        private void btnObrisiProveruZnanja_Click(object sender, EventArgs e)
        {
            using (var context = new ProveraZnanjaDB())
            {
                int idProvere = Convert.ToInt16(dgvProvereZnanja.SelectedRows[0].Cells[0].Value);

                if (MessageBox.Show("Da li ste sigurni da želite da obrišete ovu proveru znanja?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var provera = context.ProveraZnanjas.Find(idProvere);
                    if (provera != null)
                    {
                        context.ProveraZnanjas.Remove(provera);
                        context.SaveChanges();
                        dgvProvereZnanja.DataSource = context.ProveraZnanjas.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Provera znanja sa datim ID-jem ne postoji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            AzurirajComboBoxProvereZnanja();
        }

        private void dgvPitanja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPitanja.SelectedRows.Count == 0)
            {
                return;
            }

            int selectedRowIndex = dgvPitanja.SelectedCells[0].RowIndex;

            txtIdPitanja.Text = dgvPitanja.Rows[selectedRowIndex].Cells[0].Value.ToString();
            txtTekstPitanja.Text = dgvPitanja.Rows[selectedRowIndex].Cells[1].Value.ToString();
            cmbIdProvereZnanja.Text = dgvPitanja.Rows[selectedRowIndex].Cells[2].Value.ToString();

        }

        private void btnPonistiDodavanjePitanja_Click(object sender, EventArgs e)
        {
            txtIdPitanja.Text = string.Empty;
            txtTekstPitanja.Text = string.Empty;
            cmbIdProvereZnanja.SelectedIndex = 0;
        }

        private void btnObrisiPitanje_Click(object sender, EventArgs e)
        {

        }

        private void AzurirajComboBoxProvereZnanja()
        {
            using (var context = new ProveraZnanjaDB())
            {
                cmbIdProvereZnanja.DataSource = context.ProveraZnanjas.ToList();
                cmbIdProvereZnanja.DisplayMember = "NazivProvere";
                cmbIdProvereZnanja.ValueMember = "IdProvereZnanja";
            }
        }
    }
}
