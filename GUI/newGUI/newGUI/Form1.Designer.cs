namespace newGUI
{
    partial class newGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newGUI));
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.bttnRemove = new System.Windows.Forms.Button();
            this.bttnPower = new System.Windows.Forms.Button();
            this.bttnMinimize = new System.Windows.Forms.Button();
            this.txtGrid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(62)))), ((int)(((byte)(209)))));
            this.label1.Location = new System.Drawing.Point(163, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE PRODUTOS";
            // 
            // txtName
            // 
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.txtName.ForeColor = System.Drawing.Color.Gray;
            this.txtName.Location = new System.Drawing.Point(34, 149);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(137, 27);
            this.txtName.TabIndex = 1;
            // 
            // txtValue
            // 
            this.txtValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValue.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.txtValue.ForeColor = System.Drawing.Color.Gray;
            this.txtValue.Location = new System.Drawing.Point(177, 149);
            this.txtValue.Multiline = true;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(133, 28);
            this.txtValue.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.Gray;
            this.txtDescription.Location = new System.Drawing.Point(316, 149);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(133, 28);
            this.txtDescription.TabIndex = 3;
            // 
            // txtBrand
            // 
            this.txtBrand.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBrand.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.txtBrand.ForeColor = System.Drawing.Color.Gray;
            this.txtBrand.Location = new System.Drawing.Point(458, 149);
            this.txtBrand.Multiline = true;
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(133, 28);
            this.txtBrand.TabIndex = 4;
            // 
            // bttnAdd
            // 
            this.bttnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(62)))), ((int)(((byte)(209)))));
            this.bttnAdd.FlatAppearance.BorderSize = 0;
            this.bttnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.bttnAdd.ForeColor = System.Drawing.Color.Cornsilk;
            this.bttnAdd.Location = new System.Drawing.Point(597, 148);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(162, 28);
            this.bttnAdd.TabIndex = 5;
            this.bttnAdd.Text = "Adicionar";
            this.bttnAdd.UseVisualStyleBackColor = false;
            this.bttnAdd.Click += new System.EventHandler(this.BttnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(62)))), ((int)(((byte)(209)))));
            this.label2.Location = new System.Drawing.Point(30, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(62)))), ((int)(((byte)(209)))));
            this.label3.Location = new System.Drawing.Point(454, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(62)))), ((int)(((byte)(209)))));
            this.label4.Location = new System.Drawing.Point(314, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descrição:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 14F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(62)))), ((int)(((byte)(209)))));
            this.label5.Location = new System.Drawing.Point(174, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 14.5F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(34, 508);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(305, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Digite o ID para excluir o registro:";
            // 
            // txtID
            // 
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtID.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.txtID.ForeColor = System.Drawing.Color.Gray;
            this.txtID.Location = new System.Drawing.Point(347, 508);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(168, 36);
            this.txtID.TabIndex = 12;
            // 
            // bttnRemove
            // 
            this.bttnRemove.BackColor = System.Drawing.Color.Transparent;
            this.bttnRemove.FlatAppearance.BorderSize = 2;
            this.bttnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnRemove.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.bttnRemove.ForeColor = System.Drawing.Color.Cornsilk;
            this.bttnRemove.Location = new System.Drawing.Point(521, 508);
            this.bttnRemove.Name = "bttnRemove";
            this.bttnRemove.Size = new System.Drawing.Size(238, 36);
            this.bttnRemove.TabIndex = 13;
            this.bttnRemove.Text = "Excluir";
            this.bttnRemove.UseVisualStyleBackColor = false;
            this.bttnRemove.Click += new System.EventHandler(this.BttnRemove_Click);
            // 
            // bttnPower
            // 
            this.bttnPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bttnPower.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnPower.BackgroundImage")));
            this.bttnPower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttnPower.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bttnPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnPower.ForeColor = System.Drawing.Color.Transparent;
            this.bttnPower.Location = new System.Drawing.Point(740, 19);
            this.bttnPower.Name = "bttnPower";
            this.bttnPower.Size = new System.Drawing.Size(48, 32);
            this.bttnPower.TabIndex = 14;
            this.bttnPower.UseVisualStyleBackColor = false;
            this.bttnPower.Click += new System.EventHandler(this.BttnPower_Click);
            // 
            // bttnMinimize
            // 
            this.bttnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bttnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnMinimize.BackgroundImage")));
            this.bttnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bttnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.bttnMinimize.Location = new System.Drawing.Point(686, 19);
            this.bttnMinimize.Name = "bttnMinimize";
            this.bttnMinimize.Size = new System.Drawing.Size(48, 32);
            this.bttnMinimize.TabIndex = 15;
            this.bttnMinimize.UseVisualStyleBackColor = false;
            this.bttnMinimize.Click += new System.EventHandler(this.BttnMinimize_Click);
            // 
            // txtGrid
            // 
            this.txtGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGrid.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrid.ForeColor = System.Drawing.Color.Black;
            this.txtGrid.Location = new System.Drawing.Point(34, 196);
            this.txtGrid.Multiline = true;
            this.txtGrid.Name = "txtGrid";
            this.txtGrid.Size = new System.Drawing.Size(725, 293);
            this.txtGrid.TabIndex = 16;
            this.txtGrid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.txtGrid);
            this.Controls.Add(this.bttnMinimize);
            this.Controls.Add(this.bttnPower);
            this.Controls.Add(this.bttnRemove);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "newGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button bttnRemove;
        private System.Windows.Forms.Button bttnPower;
        private System.Windows.Forms.Button bttnMinimize;
        private System.Windows.Forms.TextBox txtGrid;
    }
}

