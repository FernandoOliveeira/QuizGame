namespace Quiz_Game.ViewLayer
{
    partial class FimDeJogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FimDeJogo));
            this.lblPergunta2 = new System.Windows.Forms.Label();
            this.btnRespostaA = new System.Windows.Forms.Button();
            this.btnRespostaB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPergunta2
            // 
            this.lblPergunta2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPergunta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta2.Location = new System.Drawing.Point(0, 0);
            this.lblPergunta2.Name = "lblPergunta2";
            this.lblPergunta2.Size = new System.Drawing.Size(484, 355);
            this.lblPergunta2.TabIndex = 20;
            this.lblPergunta2.Text = resources.GetString("lblPergunta2.Text");
            this.lblPergunta2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRespostaA
            // 
            this.btnRespostaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespostaA.Location = new System.Drawing.Point(12, 394);
            this.btnRespostaA.Name = "btnRespostaA";
            this.btnRespostaA.Size = new System.Drawing.Size(132, 36);
            this.btnRespostaA.TabIndex = 21;
            this.btnRespostaA.Text = "Pílula Azul";
            this.btnRespostaA.UseVisualStyleBackColor = true;
            this.btnRespostaA.Click += new System.EventHandler(this.VoltarMenuPrincipal_Click);
            // 
            // btnRespostaB
            // 
            this.btnRespostaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespostaB.Location = new System.Drawing.Point(323, 394);
            this.btnRespostaB.Name = "btnRespostaB";
            this.btnRespostaB.Size = new System.Drawing.Size(149, 36);
            this.btnRespostaB.TabIndex = 22;
            this.btnRespostaB.Text = "Pílula Vermelha";
            this.btnRespostaB.UseVisualStyleBackColor = true;
            this.btnRespostaB.Click += new System.EventHandler(this.VoltarMenuPrincipal_Click);
            // 
            // FimDeJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.lblPergunta2);
            this.Controls.Add(this.btnRespostaA);
            this.Controls.Add(this.btnRespostaB);
            this.MaximizeBox = false;
            this.Name = "FimDeJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FimDeJogo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPergunta2;
        private System.Windows.Forms.Button btnRespostaA;
        private System.Windows.Forms.Button btnRespostaB;
    }
}