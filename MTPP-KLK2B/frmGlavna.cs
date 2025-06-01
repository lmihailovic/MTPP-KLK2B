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
            AzurirajComboBoxPitanja();
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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške prilikom brisanja provere znanja: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void dgvPitanja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPitanja.SelectedRows.Count == 0)
            {
                return;
            }

            int selectedRowIndex = dgvPitanja.SelectedCells[0].RowIndex;

            txtIdPitanja.Text = dgvPitanja.Rows[selectedRowIndex].Cells[0].Value.ToString();
            txtTekstPitanja.Text = dgvPitanja.Rows[selectedRowIndex].Cells[1].Value.ToString();
            cmbIdProvereZnanja.SelectedValue = dgvPitanja.Rows[selectedRowIndex].Cells[2].Value;
        }

        private void btnPonistiDodavanjePitanja_Click(object sender, EventArgs e)
        {
            txtIdPitanja.Text = string.Empty;
            txtTekstPitanja.Text = string.Empty;
            cmbIdProvereZnanja.SelectedIndex = 0;
        }
        private void btnDodajPitanje_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTekstPitanja.Text) || cmbIdProvereZnanja.SelectedIndex < 0)
            {
                MessageBox.Show("Molimo unesite tekst pitanja i odaberite proveru znanja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var context = new ProveraZnanjaDB())
            {
                if (string.IsNullOrEmpty(txtIdPitanja.Text))
                {
                    var novoPitanje = new Pitanje
                    {
                        TekstPitanja = txtTekstPitanja.Text,
                        IdProvereZnanja = Convert.ToInt16(cmbIdProvereZnanja.SelectedValue)
                    };
                    context.Pitanjas.Add(novoPitanje);
                    context.SaveChanges();
                    dgvPitanja.DataSource = context.Pitanjas.ToList();
                }
                else
                {
                    int idPitanja = int.Parse(txtIdPitanja.Text);
                    var pitanje = context.Pitanjas.Find(idPitanja);
                    if (pitanje != null)
                    {
                        pitanje.TekstPitanja = txtTekstPitanja.Text;
                        pitanje.IdProvereZnanja = Convert.ToInt16(cmbIdProvereZnanja.SelectedValue);
                        context.SaveChanges();
                        dgvPitanja.DataSource = context.Pitanjas.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Pitanje sa datim ID-jem ne postoji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            AzurirajComboBoxPitanja();

        }

        private void btnObrisiPitanje_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ProveraZnanjaDB())
                {
                    int idPitanja = Convert.ToInt16(dgvPitanja.SelectedRows[0].Cells[0].Value);

                    if (MessageBox.Show("Da li ste sigurni da želite da obrišete ovo pitanje?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var pitanje = context.Pitanjas.Find(idPitanja);
                        if (pitanje != null)
                        {
                            context.Pitanjas.Remove(pitanje);
                            context.SaveChanges();
                            dgvPitanja.DataSource = context.Pitanjas.ToList();
                        }
                        else
                        {
                            MessageBox.Show("Pitanje sa datim ID-jem ne postoji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                AzurirajComboBoxPitanja();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške prilikom brisanja pitanja: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AzurirajComboBoxPitanja()
        {
            using (var context = new ProveraZnanjaDB())
            {
                cmbIdPitanja.DataSource = context.Pitanjas.ToList();
                cmbIdPitanja.DisplayMember = "IdPitanja";
                cmbIdPitanja.ValueMember = "IdPitanja";
            }
        }

        private void dgvOdgovori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOdgovori.SelectedRows.Count == 0)
            {
                return;
            }

            int selectedRowIndex = dgvOdgovori.SelectedCells[0].RowIndex;

            txtIdOdgovora.Text = dgvOdgovori.Rows[selectedRowIndex].Cells[0].Value.ToString();
            txtTekstOdgovora.Text = dgvOdgovori.Rows[selectedRowIndex].Cells[1].Value.ToString();
            cmbIdPitanja.SelectedValue = dgvOdgovori.Rows[selectedRowIndex].Cells[2].Value;
        }

        private void btnDodajOdgovor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTekstOdgovora.Text) || cmbIdPitanja.SelectedIndex < 0)
            {
                MessageBox.Show("Molimo unesite tekst odgovora i odaberite pitanje.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var context = new ProveraZnanjaDB())
            {
                if (string.IsNullOrEmpty(txtIdOdgovora.Text))
                {
                    var noviOdgovor = new Odgovor
                    {
                        TekstOdgovora = txtTekstOdgovora.Text,
                        IdPitanja = Convert.ToInt16(cmbIdPitanja.SelectedValue)
                    };
                    context.Odgovori.Add(noviOdgovor);
                    context.SaveChanges();
                    dgvOdgovori.DataSource = context.Odgovori.ToList();
                }
                else
                {
                    int idOdgovora = int.Parse(txtIdOdgovora.Text);
                    var odgovor = context.Odgovori.Find(idOdgovora);
                    if (odgovor != null)
                    {
                        odgovor.TekstOdgovora = txtTekstOdgovora.Text;
                        odgovor.IdPitanja = Convert.ToInt16(cmbIdPitanja.SelectedValue);
                        context.SaveChanges();
                        dgvOdgovori.DataSource = context.Odgovori.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Odgovor sa datim ID-jem ne postoji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void btnPonistiDodavanjeOdgovora_Click(object sender, EventArgs e)
        {
            txtIdOdgovora.Text = string.Empty;
            txtTekstOdgovora.Text = string.Empty;
            cmbIdPitanja.SelectedIndex = 0;
        }

        private void btnObrisiOdgovor_Click(object sender, EventArgs e)
        {
            try
            {

                using (var context = new ProveraZnanjaDB())
                {
                    int idOdgovora = Convert.ToInt16(dgvOdgovori.SelectedRows[0].Cells[0].Value);

                    if (MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj odgovor?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var odgovor = context.Odgovori.Find(idOdgovora);
                        if (odgovor != null)
                        {
                            context.Odgovori.Remove(odgovor);
                            context.SaveChanges();
                            dgvOdgovori.DataSource = context.Odgovori.ToList();
                        }
                        else
                        {
                            MessageBox.Show("Odgovor sa datim ID-jem ne postoji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške prilikom brisanja odgovora: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
