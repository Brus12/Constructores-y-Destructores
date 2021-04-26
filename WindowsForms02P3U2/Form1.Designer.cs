
namespace WindowsForms02P3U2
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
            this.btnEjec = new System.Windows.Forms.Button();
            this.cboSeleccionar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEjec
            // 
            this.btnEjec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjec.Location = new System.Drawing.Point(24, 90);
            this.btnEjec.Name = "btnEjec";
            this.btnEjec.Size = new System.Drawing.Size(330, 39);
            this.btnEjec.TabIndex = 5;
            this.btnEjec.Text = "Ejecutar";
            this.btnEjec.UseVisualStyleBackColor = true;
            this.btnEjec.Click += new System.EventHandler(this.btnEjec_Click);
            // 
            // cboSeleccionar
            // 
            this.cboSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSeleccionar.FormattingEnabled = true;
            this.cboSeleccionar.Items.AddRange(new object[] {
            "Prueba con X",
            "Numeros Aleatorios",
            "Numero Primo"});
            this.cboSeleccionar.Location = new System.Drawing.Point(196, 34);
            this.cboSeleccionar.Name = "cboSeleccionar";
            this.cboSeleccionar.Size = new System.Drawing.Size(121, 24);
            this.cboSeleccionar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione un programa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Creador: Bruno Uriel Flores Hernández";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 162);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEjec);
            this.Controls.Add(this.cboSeleccionar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEjec;
        private System.Windows.Forms.ComboBox cboSeleccionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

