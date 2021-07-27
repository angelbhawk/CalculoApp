
namespace CalculoAplicación
{
    partial class Form
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.pnlGrf = new System.Windows.Forms.Panel();
            this.pnlOpt = new System.Windows.Forms.Panel();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxRadio = new System.Windows.Forms.TextBox();
            this.tbxCapa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxRes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlOpt.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGrf
            // 
            this.pnlGrf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGrf.BackColor = System.Drawing.Color.Black;
            this.pnlGrf.Location = new System.Drawing.Point(12, 12);
            this.pnlGrf.Name = "pnlGrf";
            this.pnlGrf.Size = new System.Drawing.Size(589, 537);
            this.pnlGrf.TabIndex = 0;
            // 
            // pnlOpt
            // 
            this.pnlOpt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOpt.BackColor = System.Drawing.Color.White;
            this.pnlOpt.Controls.Add(this.label4);
            this.pnlOpt.Controls.Add(this.tbxRes);
            this.pnlOpt.Controls.Add(this.label3);
            this.pnlOpt.Controls.Add(this.label2);
            this.pnlOpt.Controls.Add(this.tbxCapa);
            this.pnlOpt.Controls.Add(this.tbxRadio);
            this.pnlOpt.Controls.Add(this.btnCalcular);
            this.pnlOpt.Controls.Add(this.label1);
            this.pnlOpt.Location = new System.Drawing.Point(613, 12);
            this.pnlOpt.Name = "pnlOpt";
            this.pnlOpt.Size = new System.Drawing.Size(327, 537);
            this.pnlOpt.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.btnCalcular.Location = new System.Drawing.Point(34, 281);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(261, 30);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Al calcular la velocidad de vaciado\r\npara este tanque cilindrico ingrese los\r\nsig" +
    "uientes valores";
            // 
            // tbxRadio
            // 
            this.tbxRadio.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.tbxRadio.Location = new System.Drawing.Point(34, 142);
            this.tbxRadio.Name = "tbxRadio";
            this.tbxRadio.Size = new System.Drawing.Size(261, 26);
            this.tbxRadio.TabIndex = 3;
            // 
            // tbxCapa
            // 
            this.tbxCapa.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.tbxCapa.Location = new System.Drawing.Point(34, 228);
            this.tbxCapa.Name = "tbxCapa";
            this.tbxCapa.Size = new System.Drawing.Size(261, 26);
            this.tbxCapa.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Radio del tanque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Capacidad del tanque";
            // 
            // tbxRes
            // 
            this.tbxRes.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.tbxRes.Location = new System.Drawing.Point(34, 471);
            this.tbxRes.Name = "tbxRes";
            this.tbxRes.Size = new System.Drawing.Size(261, 26);
            this.tbxRes.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Disminución en metros por segundo";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 561);
            this.Controls.Add(this.pnlOpt);
            this.Controls.Add(this.pnlGrf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(967, 600);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicación del cálculo";
            this.pnlOpt.ResumeLayout(false);
            this.pnlOpt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrf;
        private System.Windows.Forms.Panel pnlOpt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCapa;
        private System.Windows.Forms.TextBox tbxRadio;
        private System.Windows.Forms.TextBox tbxRes;
        private System.Windows.Forms.Label label4;
    }
}

