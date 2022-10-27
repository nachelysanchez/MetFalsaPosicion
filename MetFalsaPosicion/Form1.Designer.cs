
namespace MetFalsaPosicion
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xuTXT = new System.Windows.Forms.TextBox();
            this.xlTXT = new System.Windows.Forms.TextBox();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.FalsaPosiciondtg = new System.Windows.Forms.DataGridView();
            this.Iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Et = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.Raiztxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FalsaPosiciondtg)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(563, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(643, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar las raices de la ecuacion por medio del metodo de la falsa posicion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Xu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(658, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Xl";
            // 
            // xuTXT
            // 
            this.xuTXT.Location = new System.Drawing.Point(53, 154);
            this.xuTXT.Name = "xuTXT";
            this.xuTXT.Size = new System.Drawing.Size(572, 22);
            this.xuTXT.TabIndex = 4;
            // 
            // xlTXT
            // 
            this.xlTXT.Location = new System.Drawing.Point(699, 154);
            this.xlTXT.Name = "xlTXT";
            this.xlTXT.Size = new System.Drawing.Size(533, 22);
            this.xlTXT.TabIndex = 5;
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(1238, 149);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(75, 33);
            this.CalcularButton.TabIndex = 6;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // FalsaPosiciondtg
            // 
            this.FalsaPosiciondtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FalsaPosiciondtg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Iteracion,
            this.Xl,
            this.Xu,
            this.fxu,
            this.fxl,
            this.Xr,
            this.fxr,
            this.xar,
            this.Ea,
            this.Et});
            this.FalsaPosiciondtg.Location = new System.Drawing.Point(25, 197);
            this.FalsaPosiciondtg.Name = "FalsaPosiciondtg";
            this.FalsaPosiciondtg.RowHeadersWidth = 51;
            this.FalsaPosiciondtg.RowTemplate.Height = 24;
            this.FalsaPosiciondtg.Size = new System.Drawing.Size(1304, 177);
            this.FalsaPosiciondtg.TabIndex = 7;
            // 
            // Iteracion
            // 
            this.Iteracion.HeaderText = "Iteracion";
            this.Iteracion.MinimumWidth = 6;
            this.Iteracion.Name = "Iteracion";
            this.Iteracion.ReadOnly = true;
            this.Iteracion.Width = 125;
            // 
            // Xl
            // 
            this.Xl.HeaderText = "Xl";
            this.Xl.MinimumWidth = 6;
            this.Xl.Name = "Xl";
            this.Xl.ReadOnly = true;
            this.Xl.Width = 125;
            // 
            // Xu
            // 
            this.Xu.HeaderText = "Xu";
            this.Xu.MinimumWidth = 6;
            this.Xu.Name = "Xu";
            this.Xu.ReadOnly = true;
            this.Xu.Width = 125;
            // 
            // fxu
            // 
            this.fxu.HeaderText = "f(xu)";
            this.fxu.MinimumWidth = 6;
            this.fxu.Name = "fxu";
            this.fxu.ReadOnly = true;
            this.fxu.Width = 125;
            // 
            // fxl
            // 
            this.fxl.HeaderText = "f(Xl)";
            this.fxl.MinimumWidth = 6;
            this.fxl.Name = "fxl";
            this.fxl.ReadOnly = true;
            this.fxl.Width = 125;
            // 
            // Xr
            // 
            this.Xr.HeaderText = "Xr";
            this.Xr.MinimumWidth = 6;
            this.Xr.Name = "Xr";
            this.Xr.ReadOnly = true;
            this.Xr.Width = 125;
            // 
            // fxr
            // 
            this.fxr.HeaderText = "f(Xr)";
            this.fxr.MinimumWidth = 6;
            this.fxr.Name = "fxr";
            this.fxr.ReadOnly = true;
            this.fxr.Width = 125;
            // 
            // xar
            // 
            this.xar.HeaderText = "f(Xl)f(Xr)";
            this.xar.MinimumWidth = 6;
            this.xar.Name = "xar";
            this.xar.ReadOnly = true;
            this.xar.Width = 125;
            // 
            // Ea
            // 
            this.Ea.HeaderText = "Ea";
            this.Ea.MinimumWidth = 6;
            this.Ea.Name = "Ea";
            this.Ea.ReadOnly = true;
            this.Ea.Width = 125;
            // 
            // Et
            // 
            this.Et.HeaderText = "Et";
            this.Et.MinimumWidth = 6;
            this.Et.Name = "Et";
            this.Et.ReadOnly = true;
            this.Et.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "La raiz es : ";
            // 
            // Raiztxt
            // 
            this.Raiztxt.Location = new System.Drawing.Point(110, 399);
            this.Raiztxt.Name = "Raiztxt";
            this.Raiztxt.ReadOnly = true;
            this.Raiztxt.Size = new System.Drawing.Size(100, 22);
            this.Raiztxt.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 450);
            this.Controls.Add(this.Raiztxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FalsaPosiciondtg);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.xlTXT);
            this.Controls.Add(this.xuTXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FalsaPosiciondtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox xuTXT;
        private System.Windows.Forms.TextBox xlTXT;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.DataGridView FalsaPosiciondtg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xu;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxu;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xr;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxr;
        private System.Windows.Forms.DataGridViewTextBoxColumn xar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Et;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Raiztxt;
    }
}

