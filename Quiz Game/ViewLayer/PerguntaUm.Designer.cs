namespace Quiz_Game.ViewLayer
{
    partial class PerguntaUm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerguntaUm));
            this.lblPergunta1 = new System.Windows.Forms.Label();
            this.btnRespostaD = new System.Windows.Forms.Button();
            this.btnRespostaA = new System.Windows.Forms.Button();
            this.btnRespostaC = new System.Windows.Forms.Button();
            this.btnRespostaB = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSLVidas = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPergunta1
            // 
            this.lblPergunta1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPergunta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta1.Location = new System.Drawing.Point(0, 0);
            this.lblPergunta1.Name = "lblPergunta1";
            this.lblPergunta1.Size = new System.Drawing.Size(484, 76);
            this.lblPergunta1.TabIndex = 2;
            this.lblPergunta1.Text = "1) Em um ninho de mafagafos haviam 7 mafagafinhos, 2 mafagafinhos \r\nmorreram. Qua" +
    "ntos mafagafinhos restaram ?";
            this.lblPergunta1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRespostaD
            // 
            this.btnRespostaD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespostaD.Location = new System.Drawing.Point(173, 259);
            this.btnRespostaD.Name = "btnRespostaD";
            this.btnRespostaD.Size = new System.Drawing.Size(132, 36);
            this.btnRespostaD.TabIndex = 6;
            this.btnRespostaD.Text = "5 Mafagafinhos";
            this.btnRespostaD.UseVisualStyleBackColor = true;
            // 
            // btnRespostaA
            // 
            this.btnRespostaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespostaA.Location = new System.Drawing.Point(173, 133);
            this.btnRespostaA.Name = "btnRespostaA";
            this.btnRespostaA.Size = new System.Drawing.Size(132, 36);
            this.btnRespostaA.TabIndex = 3;
            this.btnRespostaA.Text = "2 Mafagafinhos";
            this.btnRespostaA.UseVisualStyleBackColor = true;
            // 
            // btnRespostaC
            // 
            this.btnRespostaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespostaC.Location = new System.Drawing.Point(173, 217);
            this.btnRespostaC.Name = "btnRespostaC";
            this.btnRespostaC.Size = new System.Drawing.Size(132, 36);
            this.btnRespostaC.TabIndex = 5;
            this.btnRespostaC.Text = "4 Mafagafinhos";
            this.btnRespostaC.UseVisualStyleBackColor = true;
            // 
            // btnRespostaB
            // 
            this.btnRespostaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespostaB.Location = new System.Drawing.Point(173, 175);
            this.btnRespostaB.Name = "btnRespostaB";
            this.btnRespostaB.Size = new System.Drawing.Size(132, 36);
            this.btnRespostaB.TabIndex = 4;
            this.btnRespostaB.Text = "3 Mafagafinhos";
            this.btnRespostaB.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.TSSLVidas});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(484, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(234, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Version: 0.1.3.5.8.9.3.11.33333";
            // 
            // TSSLVidas
            // 
            this.TSSLVidas.Name = "TSSLVidas";
            this.TSSLVidas.Size = new System.Drawing.Size(234, 17);
            this.TSSLVidas.Spring = true;
            this.TSSLVidas.Text = "Vidas: 0";
            // 
            // PerguntaUm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblPergunta1);
            this.Controls.Add(this.btnRespostaD);
            this.Controls.Add(this.btnRespostaA);
            this.Controls.Add(this.btnRespostaB);
            this.Controls.Add(this.btnRespostaC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PerguntaUm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta 1";
            this.Load += new System.EventHandler(this.PerguntaUm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPergunta1;
        private System.Windows.Forms.Button btnRespostaD;
        private System.Windows.Forms.Button btnRespostaA;
        private System.Windows.Forms.Button btnRespostaC;
        private System.Windows.Forms.Button btnRespostaB;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel TSSLVidas;
    }
}