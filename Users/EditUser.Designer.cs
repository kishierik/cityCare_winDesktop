namespace Proyecto_Final.Users
{
    partial class EditUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.usersEditDataGrid = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.newPasswordGrp = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.newpasswordTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.negativepointsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.positivepointsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersEditDataGrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.newPasswordGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.usersEditDataGrid);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(630, 527);
            this.panel2.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(316, 498);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Actualizar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(302, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Gestión de usuarios: Editar usuario";
            // 
            // usersEditDataGrid
            // 
            this.usersEditDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersEditDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.email,
            this.pass,
            this.id});
            this.usersEditDataGrid.Location = new System.Drawing.Point(3, 56);
            this.usersEditDataGrid.Name = "usersEditDataGrid";
            this.usersEditDataGrid.Size = new System.Drawing.Size(622, 436);
            this.usersEditDataGrid.TabIndex = 0;
            this.usersEditDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.getUserDataFromRow);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.newPasswordGrp);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.negativepointsTextBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.positivepointsTextBox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lastnameTextBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.nameTextBox);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.passwordTextBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.emailTextBox);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(630, 527);
            this.panel3.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(7, 284);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(177, 23);
            this.button6.TabIndex = 22;
            this.button6.Text = "Cancelar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // newPasswordGrp
            // 
            this.newPasswordGrp.Controls.Add(this.button4);
            this.newPasswordGrp.Controls.Add(this.button2);
            this.newPasswordGrp.Controls.Add(this.newpasswordTextBox);
            this.newPasswordGrp.Controls.Add(this.label9);
            this.newPasswordGrp.Location = new System.Drawing.Point(6, 11);
            this.newPasswordGrp.Name = "newPasswordGrp";
            this.newPasswordGrp.Size = new System.Drawing.Size(410, 307);
            this.newPasswordGrp.TabIndex = 22;
            this.newPasswordGrp.TabStop = false;
            this.newPasswordGrp.Text = "Editar contraseña";
            this.newPasswordGrp.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 256);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // newpasswordTextBox
            // 
            this.newpasswordTextBox.Location = new System.Drawing.Point(111, 24);
            this.newpasswordTextBox.Name = "newpasswordTextBox";
            this.newpasswordTextBox.Size = new System.Drawing.Size(212, 20);
            this.newpasswordTextBox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nueva contraseña:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 20);
            this.button1.TabIndex = 21;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Puntos negativos:";
            // 
            // negativepointsTextBox
            // 
            this.negativepointsTextBox.Location = new System.Drawing.Point(125, 241);
            this.negativepointsTextBox.Name = "negativepointsTextBox";
            this.negativepointsTextBox.Size = new System.Drawing.Size(275, 20);
            this.negativepointsTextBox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Puntos positivos:";
            // 
            // positivepointsTextBox
            // 
            this.positivepointsTextBox.Location = new System.Drawing.Point(125, 205);
            this.positivepointsTextBox.Name = "positivepointsTextBox";
            this.positivepointsTextBox.Size = new System.Drawing.Size(275, 20);
            this.positivepointsTextBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Apellidos del usuario:";
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Location = new System.Drawing.Point(125, 168);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(275, 20);
            this.lastnameTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre del usuario:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(125, 129);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(275, 20);
            this.nameTextBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(302, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Gestión de usuarios: Editar usuario";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(223, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Editar Usuario";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Enabled = false;
            this.passwordTextBox.Location = new System.Drawing.Point(125, 89);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.ReadOnly = true;
            this.passwordTextBox.Size = new System.Drawing.Size(218, 20);
            this.passwordTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Correo del usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Contraseña de usuario:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(125, 51);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(275, 20);
            this.emailTextBox.TabIndex = 9;
            // 
            // emailColumn
            // 
            this.emailColumn.HeaderText = "Correo";
            this.emailColumn.Name = "emailColumn";
            this.emailColumn.ReadOnly = true;
            this.emailColumn.Width = 150;
            // 
            // passColumn
            // 
            this.passColumn.HeaderText = "Contraseña";
            this.passColumn.Name = "passColumn";
            this.passColumn.ReadOnly = true;
            this.passColumn.Width = 150;
            // 
            // email
            // 
            this.email.HeaderText = "Correo";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 190;
            // 
            // pass
            // 
            this.pass.HeaderText = "Contraseña";
            this.pass.Name = "pass";
            this.pass.ReadOnly = true;
            this.pass.Width = 190;
            // 
            // id
            // 
            this.id.HeaderText = "User ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 190;
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 551);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditUser";
            this.Text = "EditarUsuario";
            this.VisibleChanged += new System.EventHandler(this.refreshData);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersEditDataGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.newPasswordGrp.ResumeLayout(false);
            this.newPasswordGrp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView usersEditDataGrid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox negativepointsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox positivepointsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.GroupBox newPasswordGrp;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox newpasswordTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}