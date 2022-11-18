
namespace DownloadAssincrono
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.btnLer = new System.Windows.Forms.Button();
            this.btnContar = new System.Windows.Forms.Button();
            this.lstStatus = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Palavra :";
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(122, 27);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(518, 27);
            this.txtURL.TabIndex = 2;
            // 
            // txtPalavra
            // 
            this.txtPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalavra.Location = new System.Drawing.Point(122, 78);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(518, 27);
            this.txtPalavra.TabIndex = 3;
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(655, 27);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(106, 27);
            this.btnLer.TabIndex = 4;
            this.btnLer.Text = "LER";
            this.btnLer.UseVisualStyleBackColor = true;
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(655, 74);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(106, 27);
            this.btnContar.TabIndex = 5;
            this.btnContar.Text = "CONTAR";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // lstStatus
            // 
            this.lstStatus.HideSelection = false;
            this.lstStatus.Location = new System.Drawing.Point(28, 120);
            this.lstStatus.Name = "lstStatus";
            this.lstStatus.Size = new System.Drawing.Size(612, 302);
            this.lstStatus.TabIndex = 6;
            this.lstStatus.UseCompatibleStateImageBehavior = false;
            this.lstStatus.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstStatus);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.btnLer);
            this.Controls.Add(this.txtPalavra);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.ListView lstStatus;
    }
}

