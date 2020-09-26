using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace View
{
    public partial class MainView : Form
    {
        private SetorBLL _setorBLL;
        private FuncionarioBLL _funcionarioBLL;
        private List<Setor> _setores;

        public MainView()
        {
            InitializeComponent();
            _setorBLL = new SetorBLL();
            _funcionarioBLL = new FuncionarioBLL();
            _setores = new List<Setor>();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            Recarregar();
        }

        private void LimpaCampos()
        {
            tbSetor.Text = "";
            tbFunc.Text = "";
            lbErro.Text = "";
        }

        private void Recarregar()
        {
            LimpaCampos();

            dgvSetores.DataSource = _setorBLL.GetAllTabela();

            cbSetor.Items.Clear();
            _setores = _setorBLL.GetAll().ToList();

            foreach (var setor in _setores)
                cbSetor.Items.Add(setor.Nome);

            dgvFunc.DataSource = _funcionarioBLL.GetAllTabela();
        }

        private void dgvSetores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSetores.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvSetores.CurrentRow.Selected = true;
                tbSetor.Text = dgvSetores.Rows[e.RowIndex].Cells["Nome"].FormattedValue.ToString();
                tbSetorId.Text = dgvSetores.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
            }
        }

        private void btnCriarSetor_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSetor.Text))
            {
                _setorBLL.Create(tbSetor.Text);
                Recarregar();
            }
            else
            {
                lbErro.Text = "O Campo NOME DO SETOR é obrigatório";
                lbErro.ForeColor = Color.Red;
            }
        }

        private void btnEditarSetor_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSetorId.Text))
            {
                _setorBLL.Update(int.Parse(tbSetorId.Text), tbSetor.Text);
                Recarregar();
            }
        }

        private void btnExcluirSetor_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSetorId.Text))
            {
                _setorBLL.Delete(int.Parse(tbSetorId.Text));
                Recarregar();
            }
        }

        private void dgvFunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFunc.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvFunc.CurrentRow.Selected = true;
                tbFunc.Text = dgvFunc.Rows[e.RowIndex].Cells["Nome"].FormattedValue.ToString();
                tbFuncId.Text = dgvFunc.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                cbSetor.SelectedItem = _setores.Where(x => x.Id == int.Parse(dgvFunc.Rows[e.RowIndex].Cells["Setor_id"].FormattedValue.ToString())).FirstOrDefault().Nome;
            }
        }

        private void btnSalvarFunc_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbFunc.Text))
            {
                _funcionarioBLL.Create(tbFunc.Text, (string)cbSetor.SelectedItem);
                Recarregar();
            }
            else
            {
                lbErro.Text = "O Campo NOME DO FUNCIONÁRIO é obrigatório";
                lbErro.ForeColor = Color.Red;
            }
        }

        private void btnEditarFunc_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbFunc.Text))
            {
                _funcionarioBLL.Update(int.Parse(tbFuncId.Text), tbFunc.Text, (string)cbSetor.SelectedItem);
                Recarregar();
            }
        }

        private void btnExcluirFunc_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbFuncId.Text))
            {
                _funcionarioBLL.Delete(int.Parse(tbFuncId.Text));
                LimpaCampos();
                Recarregar();
            }
        }
    }
}
