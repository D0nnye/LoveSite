
namespace PrimeiraAppp
{
    partial class frmCalcula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalcula));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblN1 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.lblRespostaSoma = new System.Windows.Forms.Label();
            this.lblResultadoSoma = new System.Windows.Forms.Label();
            this.btnSubtração = new System.Windows.Forms.Button();
            this.btnMultiplicação = new System.Windows.Forms.Button();
            this.btnDivisão = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.lblResultadoSub = new System.Windows.Forms.Label();
            this.lblRespostaSub = new System.Windows.Forms.Label();
            this.lblResultadoDiv = new System.Windows.Forms.Label();
            this.lblRespostaDiv = new System.Windows.Forms.Label();
            this.lblResultadoMult = new System.Windows.Forms.Label();
            this.lblRespostaMult = new System.Windows.Forms.Label();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(93, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(152, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calcula valores";
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Location = new System.Drawing.Point(19, 67);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(53, 13);
            this.lblN1.TabIndex = 1;
            this.lblN1.Text = "Número 1";
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Location = new System.Drawing.Point(19, 102);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(53, 13);
            this.lblN2.TabIndex = 2;
            this.lblN2.Text = "Número 2";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(90, 60);
            this.txtN1.MaxLength = 20;
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(201, 20);
            this.txtN1.TabIndex = 0;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(90, 102);
            this.txtN2.MaxLength = 20;
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(201, 20);
            this.txtN2.TabIndex = 1;
            // 
            // lblRespostaSoma
            // 
            this.lblRespostaSoma.AutoSize = true;
            this.lblRespostaSoma.Location = new System.Drawing.Point(104, 173);
            this.lblRespostaSoma.Name = "lblRespostaSoma";
            this.lblRespostaSoma.Size = new System.Drawing.Size(55, 13);
            this.lblRespostaSoma.TabIndex = 7;
            this.lblRespostaSoma.Text = "Resposta:";
            // 
            // lblResultadoSoma
            // 
            this.lblResultadoSoma.AutoSize = true;
            this.lblResultadoSoma.Location = new System.Drawing.Point(172, 173);
            this.lblResultadoSoma.Name = "lblResultadoSoma";
            this.lblResultadoSoma.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoSoma.TabIndex = 8;
            // 
            // btnSubtração
            // 
            this.btnSubtração.Location = new System.Drawing.Point(22, 198);
            this.btnSubtração.Name = "btnSubtração";
            this.btnSubtração.Size = new System.Drawing.Size(75, 23);
            this.btnSubtração.TabIndex = 9;
            this.btnSubtração.Text = "Subtração";
            this.btnSubtração.UseVisualStyleBackColor = true;
            this.btnSubtração.Click += new System.EventHandler(this.btnSubtração_Click);
            // 
            // btnMultiplicação
            // 
            this.btnMultiplicação.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicação.Location = new System.Drawing.Point(22, 256);
            this.btnMultiplicação.Name = "btnMultiplicação";
            this.btnMultiplicação.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplicação.TabIndex = 10;
            this.btnMultiplicação.Text = "Multiplicação";
            this.btnMultiplicação.UseVisualStyleBackColor = true;
            this.btnMultiplicação.Click += new System.EventHandler(this.btnMultiplicação_Click);
            // 
            // btnDivisão
            // 
            this.btnDivisão.Location = new System.Drawing.Point(22, 227);
            this.btnDivisão.Name = "btnDivisão";
            this.btnDivisão.Size = new System.Drawing.Size(75, 23);
            this.btnDivisão.TabIndex = 11;
            this.btnDivisão.Text = "Divisão";
            this.btnDivisão.UseVisualStyleBackColor = true;
            this.btnDivisão.Click += new System.EventHandler(this.btnDivisão_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(22, 168);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(75, 23);
            this.btnSoma.TabIndex = 12;
            this.btnSoma.Text = "Soma";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // lblResultadoSub
            // 
            this.lblResultadoSub.AutoSize = true;
            this.lblResultadoSub.Location = new System.Drawing.Point(172, 203);
            this.lblResultadoSub.Name = "lblResultadoSub";
            this.lblResultadoSub.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoSub.TabIndex = 14;
            // 
            // lblRespostaSub
            // 
            this.lblRespostaSub.AutoSize = true;
            this.lblRespostaSub.Location = new System.Drawing.Point(104, 203);
            this.lblRespostaSub.Name = "lblRespostaSub";
            this.lblRespostaSub.Size = new System.Drawing.Size(55, 13);
            this.lblRespostaSub.TabIndex = 13;
            this.lblRespostaSub.Text = "Resposta:";
            // 
            // lblResultadoDiv
            // 
            this.lblResultadoDiv.AutoSize = true;
            this.lblResultadoDiv.Location = new System.Drawing.Point(172, 232);
            this.lblResultadoDiv.Name = "lblResultadoDiv";
            this.lblResultadoDiv.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoDiv.TabIndex = 16;
            // 
            // lblRespostaDiv
            // 
            this.lblRespostaDiv.AutoSize = true;
            this.lblRespostaDiv.Location = new System.Drawing.Point(104, 232);
            this.lblRespostaDiv.Name = "lblRespostaDiv";
            this.lblRespostaDiv.Size = new System.Drawing.Size(55, 13);
            this.lblRespostaDiv.TabIndex = 15;
            this.lblRespostaDiv.Text = "Resposta:";
            // 
            // lblResultadoMult
            // 
            this.lblResultadoMult.AutoSize = true;
            this.lblResultadoMult.Location = new System.Drawing.Point(172, 260);
            this.lblResultadoMult.Name = "lblResultadoMult";
            this.lblResultadoMult.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoMult.TabIndex = 18;
            // 
            // lblRespostaMult
            // 
            this.lblRespostaMult.AutoSize = true;
            this.lblRespostaMult.Location = new System.Drawing.Point(104, 260);
            this.lblRespostaMult.Name = "lblRespostaMult";
            this.lblRespostaMult.Size = new System.Drawing.Size(55, 13);
            this.lblRespostaMult.TabIndex = 17;
            this.lblRespostaMult.Text = "Resposta:";
            // 
            // bntLimpar
            // 
            this.bntLimpar.Location = new System.Drawing.Point(216, 168);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(75, 23);
            this.bntLimpar.TabIndex = 19;
            this.bntLimpar.Text = "Limpar";
            this.bntLimpar.UseVisualStyleBackColor = true;
            this.bntLimpar.Click += new System.EventHandler(this.bntLimpar_Click);
            // 
            // frmCalcula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(334, 301);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.lblResultadoMult);
            this.Controls.Add(this.lblRespostaMult);
            this.Controls.Add(this.lblResultadoDiv);
            this.Controls.Add(this.lblRespostaDiv);
            this.Controls.Add(this.lblResultadoSub);
            this.Controls.Add(this.lblRespostaSub);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btnDivisão);
            this.Controls.Add(this.btnMultiplicação);
            this.Controls.Add(this.btnSubtração);
            this.Controls.Add(this.lblResultadoSoma);
            this.Controls.Add(this.lblRespostaSoma);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.lblN1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCalcula";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label lblRespostaSoma;
        private System.Windows.Forms.Label lblResultadoSoma;
        private System.Windows.Forms.Button btnSubtração;
        private System.Windows.Forms.Button btnMultiplicação;
        private System.Windows.Forms.Button btnDivisão;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Label lblResultadoSub;
        private System.Windows.Forms.Label lblRespostaSub;
        private System.Windows.Forms.Label lblResultadoDiv;
        private System.Windows.Forms.Label lblRespostaDiv;
        private System.Windows.Forms.Label lblResultadoMult;
        private System.Windows.Forms.Label lblRespostaMult;
        private System.Windows.Forms.Button bntLimpar;
    }
}