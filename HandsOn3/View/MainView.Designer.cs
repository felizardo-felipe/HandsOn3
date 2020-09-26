namespace View
{
    partial class MainView
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageSetor = new System.Windows.Forms.TabPage();
            this.lbSetorId = new System.Windows.Forms.Label();
            this.tbSetorId = new System.Windows.Forms.TextBox();
            this.lbErro = new System.Windows.Forms.Label();
            this.lbSetor = new System.Windows.Forms.Label();
            this.lbNomeSetor = new System.Windows.Forms.Label();
            this.tbSetor = new System.Windows.Forms.TextBox();
            this.btnExcluirSetor = new System.Windows.Forms.Button();
            this.btnEditarSetor = new System.Windows.Forms.Button();
            this.btnCriarSetor = new System.Windows.Forms.Button();
            this.dgvSetores = new System.Windows.Forms.DataGridView();
            this.lbSetores = new System.Windows.Forms.Label();
            this.tabPageFuncionario = new System.Windows.Forms.TabPage();
            this.cbSetor = new System.Windows.Forms.ComboBox();
            this.lbSetorFunc = new System.Windows.Forms.Label();
            this.lbNomeFunc = new System.Windows.Forms.Label();
            this.tbFunc = new System.Windows.Forms.TextBox();
            this.btnExcluirFunc = new System.Windows.Forms.Button();
            this.btnEditarFunc = new System.Windows.Forms.Button();
            this.btnSalvarFunc = new System.Windows.Forms.Button();
            this.dgvFunc = new System.Windows.Forms.DataGridView();
            this.lbFuncId = new System.Windows.Forms.Label();
            this.tbFuncId = new System.Windows.Forms.TextBox();
            this.lbCadFuncionario = new System.Windows.Forms.Label();
            this.lbFuncionario = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPageSetor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSetores)).BeginInit();
            this.tabPageFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageSetor);
            this.tabControlMain.Controls.Add(this.tabPageFuncionario);
            this.tabControlMain.Location = new System.Drawing.Point(1, -1);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(350, 353);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageSetor
            // 
            this.tabPageSetor.Controls.Add(this.lbSetorId);
            this.tabPageSetor.Controls.Add(this.tbSetorId);
            this.tabPageSetor.Controls.Add(this.lbErro);
            this.tabPageSetor.Controls.Add(this.lbSetor);
            this.tabPageSetor.Controls.Add(this.lbNomeSetor);
            this.tabPageSetor.Controls.Add(this.tbSetor);
            this.tabPageSetor.Controls.Add(this.btnExcluirSetor);
            this.tabPageSetor.Controls.Add(this.btnEditarSetor);
            this.tabPageSetor.Controls.Add(this.btnCriarSetor);
            this.tabPageSetor.Controls.Add(this.dgvSetores);
            this.tabPageSetor.Controls.Add(this.lbSetores);
            this.tabPageSetor.Location = new System.Drawing.Point(4, 22);
            this.tabPageSetor.Name = "tabPageSetor";
            this.tabPageSetor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSetor.Size = new System.Drawing.Size(342, 327);
            this.tabPageSetor.TabIndex = 0;
            this.tabPageSetor.Text = "Setores";
            this.tabPageSetor.UseVisualStyleBackColor = true;
            // 
            // lbSetorId
            // 
            this.lbSetorId.AutoSize = true;
            this.lbSetorId.Location = new System.Drawing.Point(15, 49);
            this.lbSetorId.Name = "lbSetorId";
            this.lbSetorId.Size = new System.Drawing.Size(19, 13);
            this.lbSetorId.TabIndex = 13;
            this.lbSetorId.Text = "Id:";
            // 
            // tbSetorId
            // 
            this.tbSetorId.Enabled = false;
            this.tbSetorId.Location = new System.Drawing.Point(59, 47);
            this.tbSetorId.Name = "tbSetorId";
            this.tbSetorId.Size = new System.Drawing.Size(52, 20);
            this.tbSetorId.TabIndex = 12;
            // 
            // lbErro
            // 
            this.lbErro.AutoSize = true;
            this.lbErro.Location = new System.Drawing.Point(233, 299);
            this.lbErro.Name = "lbErro";
            this.lbErro.Size = new System.Drawing.Size(0, 13);
            this.lbErro.TabIndex = 6;
            // 
            // lbSetor
            // 
            this.lbSetor.AutoSize = true;
            this.lbSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSetor.Location = new System.Drawing.Point(127, 3);
            this.lbSetor.Name = "lbSetor";
            this.lbSetor.Size = new System.Drawing.Size(80, 25);
            this.lbSetor.TabIndex = 11;
            this.lbSetor.Text = "Setores";
            // 
            // lbNomeSetor
            // 
            this.lbNomeSetor.AutoSize = true;
            this.lbNomeSetor.Location = new System.Drawing.Point(15, 81);
            this.lbNomeSetor.Name = "lbNomeSetor";
            this.lbNomeSetor.Size = new System.Drawing.Size(38, 13);
            this.lbNomeSetor.TabIndex = 10;
            this.lbNomeSetor.Text = "Nome:";
            // 
            // tbSetor
            // 
            this.tbSetor.Location = new System.Drawing.Point(59, 78);
            this.tbSetor.Name = "tbSetor";
            this.tbSetor.Size = new System.Drawing.Size(165, 20);
            this.tbSetor.TabIndex = 9;
            // 
            // btnExcluirSetor
            // 
            this.btnExcluirSetor.Location = new System.Drawing.Point(184, 289);
            this.btnExcluirSetor.Name = "btnExcluirSetor";
            this.btnExcluirSetor.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirSetor.TabIndex = 7;
            this.btnExcluirSetor.Text = "Excluir";
            this.btnExcluirSetor.UseVisualStyleBackColor = true;
            this.btnExcluirSetor.Click += new System.EventHandler(this.btnExcluirSetor_Click);
            // 
            // btnEditarSetor
            // 
            this.btnEditarSetor.Location = new System.Drawing.Point(81, 289);
            this.btnEditarSetor.Name = "btnEditarSetor";
            this.btnEditarSetor.Size = new System.Drawing.Size(75, 23);
            this.btnEditarSetor.TabIndex = 6;
            this.btnEditarSetor.Text = "Editar";
            this.btnEditarSetor.UseVisualStyleBackColor = true;
            this.btnEditarSetor.Click += new System.EventHandler(this.btnEditarSetor_Click);
            // 
            // btnCriarSetor
            // 
            this.btnCriarSetor.Location = new System.Drawing.Point(250, 75);
            this.btnCriarSetor.Name = "btnCriarSetor";
            this.btnCriarSetor.Size = new System.Drawing.Size(75, 23);
            this.btnCriarSetor.TabIndex = 5;
            this.btnCriarSetor.Text = "Salvar";
            this.btnCriarSetor.UseVisualStyleBackColor = true;
            this.btnCriarSetor.Click += new System.EventHandler(this.btnCriarSetor_Click);
            // 
            // dgvSetores
            // 
            this.dgvSetores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSetores.Location = new System.Drawing.Point(17, 112);
            this.dgvSetores.Name = "dgvSetores";
            this.dgvSetores.Size = new System.Drawing.Size(308, 162);
            this.dgvSetores.TabIndex = 4;
            this.dgvSetores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSetores_CellContentClick);
            // 
            // lbSetores
            // 
            this.lbSetores.AutoSize = true;
            this.lbSetores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSetores.Location = new System.Drawing.Point(222, 69);
            this.lbSetores.Name = "lbSetores";
            this.lbSetores.Size = new System.Drawing.Size(0, 25);
            this.lbSetores.TabIndex = 3;
            // 
            // tabPageFuncionario
            // 
            this.tabPageFuncionario.Controls.Add(this.cbSetor);
            this.tabPageFuncionario.Controls.Add(this.lbSetorFunc);
            this.tabPageFuncionario.Controls.Add(this.lbNomeFunc);
            this.tabPageFuncionario.Controls.Add(this.tbFunc);
            this.tabPageFuncionario.Controls.Add(this.btnExcluirFunc);
            this.tabPageFuncionario.Controls.Add(this.btnEditarFunc);
            this.tabPageFuncionario.Controls.Add(this.btnSalvarFunc);
            this.tabPageFuncionario.Controls.Add(this.dgvFunc);
            this.tabPageFuncionario.Controls.Add(this.lbFuncId);
            this.tabPageFuncionario.Controls.Add(this.tbFuncId);
            this.tabPageFuncionario.Controls.Add(this.lbCadFuncionario);
            this.tabPageFuncionario.Controls.Add(this.lbFuncionario);
            this.tabPageFuncionario.Location = new System.Drawing.Point(4, 22);
            this.tabPageFuncionario.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageFuncionario.Name = "tabPageFuncionario";
            this.tabPageFuncionario.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFuncionario.Size = new System.Drawing.Size(342, 327);
            this.tabPageFuncionario.TabIndex = 1;
            this.tabPageFuncionario.Text = "Funcionários";
            this.tabPageFuncionario.UseVisualStyleBackColor = true;
            // 
            // cbSetor
            // 
            this.cbSetor.FormattingEnabled = true;
            this.cbSetor.Location = new System.Drawing.Point(58, 105);
            this.cbSetor.Name = "cbSetor";
            this.cbSetor.Size = new System.Drawing.Size(183, 21);
            this.cbSetor.TabIndex = 23;
            // 
            // lbSetorFunc
            // 
            this.lbSetorFunc.AutoSize = true;
            this.lbSetorFunc.Location = new System.Drawing.Point(14, 108);
            this.lbSetorFunc.Name = "lbSetorFunc";
            this.lbSetorFunc.Size = new System.Drawing.Size(35, 13);
            this.lbSetorFunc.TabIndex = 22;
            this.lbSetorFunc.Text = "Setor:";
            // 
            // lbNomeFunc
            // 
            this.lbNomeFunc.AutoSize = true;
            this.lbNomeFunc.Location = new System.Drawing.Point(14, 77);
            this.lbNomeFunc.Name = "lbNomeFunc";
            this.lbNomeFunc.Size = new System.Drawing.Size(38, 13);
            this.lbNomeFunc.TabIndex = 21;
            this.lbNomeFunc.Text = "Nome:";
            // 
            // tbFunc
            // 
            this.tbFunc.Location = new System.Drawing.Point(58, 74);
            this.tbFunc.Name = "tbFunc";
            this.tbFunc.Size = new System.Drawing.Size(165, 20);
            this.tbFunc.TabIndex = 20;
            // 
            // btnExcluirFunc
            // 
            this.btnExcluirFunc.Location = new System.Drawing.Point(188, 290);
            this.btnExcluirFunc.Name = "btnExcluirFunc";
            this.btnExcluirFunc.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirFunc.TabIndex = 19;
            this.btnExcluirFunc.Text = "Excluir";
            this.btnExcluirFunc.UseVisualStyleBackColor = true;
            this.btnExcluirFunc.Click += new System.EventHandler(this.btnExcluirFunc_Click);
            // 
            // btnEditarFunc
            // 
            this.btnEditarFunc.Location = new System.Drawing.Point(80, 290);
            this.btnEditarFunc.Name = "btnEditarFunc";
            this.btnEditarFunc.Size = new System.Drawing.Size(75, 23);
            this.btnEditarFunc.TabIndex = 18;
            this.btnEditarFunc.Text = "Editar";
            this.btnEditarFunc.UseVisualStyleBackColor = true;
            this.btnEditarFunc.Click += new System.EventHandler(this.btnEditarFunc_Click);
            // 
            // btnSalvarFunc
            // 
            this.btnSalvarFunc.Location = new System.Drawing.Point(249, 104);
            this.btnSalvarFunc.Name = "btnSalvarFunc";
            this.btnSalvarFunc.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarFunc.TabIndex = 17;
            this.btnSalvarFunc.Text = "Salvar";
            this.btnSalvarFunc.UseVisualStyleBackColor = true;
            this.btnSalvarFunc.Click += new System.EventHandler(this.btnSalvarFunc_Click);
            // 
            // dgvFunc
            // 
            this.dgvFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunc.Location = new System.Drawing.Point(16, 142);
            this.dgvFunc.Name = "dgvFunc";
            this.dgvFunc.Size = new System.Drawing.Size(308, 135);
            this.dgvFunc.TabIndex = 16;
            this.dgvFunc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFunc_CellContentClick);
            // 
            // lbFuncId
            // 
            this.lbFuncId.AutoSize = true;
            this.lbFuncId.Location = new System.Drawing.Point(13, 45);
            this.lbFuncId.Name = "lbFuncId";
            this.lbFuncId.Size = new System.Drawing.Size(19, 13);
            this.lbFuncId.TabIndex = 15;
            this.lbFuncId.Text = "Id:";
            // 
            // tbFuncId
            // 
            this.tbFuncId.Enabled = false;
            this.tbFuncId.Location = new System.Drawing.Point(57, 43);
            this.tbFuncId.Name = "tbFuncId";
            this.tbFuncId.Size = new System.Drawing.Size(52, 20);
            this.tbFuncId.TabIndex = 14;
            // 
            // lbCadFuncionario
            // 
            this.lbCadFuncionario.AutoSize = true;
            this.lbCadFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadFuncionario.Location = new System.Drawing.Point(152, 135);
            this.lbCadFuncionario.Name = "lbCadFuncionario";
            this.lbCadFuncionario.Size = new System.Drawing.Size(0, 25);
            this.lbCadFuncionario.TabIndex = 6;
            this.lbCadFuncionario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbFuncionario
            // 
            this.lbFuncionario.AutoSize = true;
            this.lbFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFuncionario.Location = new System.Drawing.Point(106, 3);
            this.lbFuncionario.Name = "lbFuncionario";
            this.lbFuncionario.Size = new System.Drawing.Size(124, 25);
            this.lbFuncionario.TabIndex = 4;
            this.lbFuncionario.Text = "Funcionários";
            this.lbFuncionario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 355);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainView";
            this.Text = "Hands On 3";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageSetor.ResumeLayout(false);
            this.tabPageSetor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSetores)).EndInit();
            this.tabPageFuncionario.ResumeLayout(false);
            this.tabPageFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageSetor;
        private System.Windows.Forms.TabPage tabPageFuncionario;
        private System.Windows.Forms.Label lbSetores;
        private System.Windows.Forms.Label lbCadFuncionario;
        private System.Windows.Forms.Label lbFuncionario;
        private System.Windows.Forms.Label lbErro;
        private System.Windows.Forms.Button btnCriarSetor;
        private System.Windows.Forms.DataGridView dgvSetores;
        private System.Windows.Forms.Label lbNomeSetor;
        private System.Windows.Forms.TextBox tbSetor;
        private System.Windows.Forms.Button btnExcluirSetor;
        private System.Windows.Forms.Button btnEditarSetor;
        private System.Windows.Forms.Label lbSetor;
        private System.Windows.Forms.Label lbSetorId;
        private System.Windows.Forms.TextBox tbSetorId;
        private System.Windows.Forms.ComboBox cbSetor;
        private System.Windows.Forms.Label lbSetorFunc;
        private System.Windows.Forms.Label lbNomeFunc;
        private System.Windows.Forms.TextBox tbFunc;
        private System.Windows.Forms.Button btnExcluirFunc;
        private System.Windows.Forms.Button btnEditarFunc;
        private System.Windows.Forms.Button btnSalvarFunc;
        private System.Windows.Forms.DataGridView dgvFunc;
        private System.Windows.Forms.Label lbFuncId;
        private System.Windows.Forms.TextBox tbFuncId;
    }
}

