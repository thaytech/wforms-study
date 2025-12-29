namespace LOGIN
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            textSenha = new TextBox();
            label2 = new Label();
            textUsuario = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textSenha);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textUsuario);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(428, 248);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Formulário de Login";
            // 
            // button2
            // 
            button2.Location = new Point(326, 207);
            button2.Name = "button2";
            button2.Size = new Size(84, 23);
            button2.TabIndex = 5;
            button2.Text = "Entrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(208, 207);
            button1.Name = "button1";
            button1.Size = new Size(98, 23);
            button1.TabIndex = 4;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textSenha
            // 
            textSenha.Location = new Point(15, 133);
            textSenha.Name = "textSenha";
            textSenha.Size = new Size(385, 23);
            textSenha.TabIndex = 3;
            textSenha.UseSystemPasswordChar = true;
            textSenha.TextChanged += txtSenha_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 102);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Senha:";
            // 
            // textUsuario
            // 
            textUsuario.CharacterCasing = CharacterCasing.Lower;
            textUsuario.Location = new Point(15, 57);
            textUsuario.MaxLength = 50;
            textUsuario.Name = "textUsuario";
            textUsuario.PlaceholderText = "Digite seu usuário,apenas com letras e números.";
            textUsuario.Size = new Size(385, 23);
            textUsuario.TabIndex = 1;
            textUsuario.TextChanged += textUsuario_Leave;
            textUsuario.KeyPress += textUsuario_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 29);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuário:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 275);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SISGEN - Sistema de Gestão";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textSenha;
        private Label label2;
        private TextBox textUsuario;
        private Label label1;
        private Button button2;
        private Button button1;
    }
}
