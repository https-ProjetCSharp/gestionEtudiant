namespace Gestion_d_ecole
{
    partial class FormMatiere
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
            this.txtNomMatiere = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewMatiere = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatiere)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom matière";
            // 
            // txtNomMatiere
            // 
            this.txtNomMatiere.Location = new System.Drawing.Point(31, 84);
            this.txtNomMatiere.Multiline = true;
            this.txtNomMatiere.Name = "txtNomMatiere";
            this.txtNomMatiere.Size = new System.Drawing.Size(213, 45);
            this.txtNomMatiere.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewMatiere
            // 
            this.dataGridViewMatiere.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMatiere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatiere.Location = new System.Drawing.Point(357, 37);
            this.dataGridViewMatiere.Name = "dataGridViewMatiere";
            this.dataGridViewMatiere.RowHeadersWidth = 62;
            this.dataGridViewMatiere.RowTemplate.Height = 28;
            this.dataGridViewMatiere.Size = new System.Drawing.Size(567, 332);
            this.dataGridViewMatiere.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 49);
            this.button2.TabIndex = 4;
            this.button2.Text = "Associer matiere à un cours";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormMatiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 483);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViewMatiere);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNomMatiere);
            this.Controls.Add(this.label1);
            this.Name = "FormMatiere";
            this.Text = "Page Matiere";
            this.Load += new System.EventHandler(this.FormMatiere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatiere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomMatiere;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewMatiere;
        private System.Windows.Forms.Button button2;
    }
}