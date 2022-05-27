
namespace ExeDataGridandNavBinding
{
    partial class Form2
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
            this.adventureWorksDataSet1 = new ExeDataGridandNavBinding.AdventureWorksDataSet();
            this.buttonNavigation = new System.Windows.Forms.Button();
            this.buttonDataGridView = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAIN MENU";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // adventureWorksDataSet1
            // 
            this.adventureWorksDataSet1.DataSetName = "AdventureWorksDataSet";
            this.adventureWorksDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonNavigation
            // 
            this.buttonNavigation.BackgroundImage = global::ExeDataGridandNavBinding.Properties.Resources.WhatsApp_Image_2022_05_27_at_08_41_26;
            this.buttonNavigation.Location = new System.Drawing.Point(209, 107);
            this.buttonNavigation.Name = "buttonNavigation";
            this.buttonNavigation.Size = new System.Drawing.Size(73, 58);
            this.buttonNavigation.TabIndex = 2;
            this.buttonNavigation.UseVisualStyleBackColor = true;
            this.buttonNavigation.Click += new System.EventHandler(this.buttonNavigation_Click);
            // 
            // buttonDataGridView
            // 
            this.buttonDataGridView.BackgroundImage = global::ExeDataGridandNavBinding.Properties.Resources.datagridview;
            this.buttonDataGridView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDataGridView.Location = new System.Drawing.Point(71, 107);
            this.buttonDataGridView.Name = "buttonDataGridView";
            this.buttonDataGridView.Size = new System.Drawing.Size(78, 58);
            this.buttonDataGridView.TabIndex = 1;
            this.buttonDataGridView.UseVisualStyleBackColor = true;
            this.buttonDataGridView.Click += new System.EventHandler(this.buttonDataGridView_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DataGridView";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Binding Navigation";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 263);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonNavigation);
            this.Controls.Add(this.buttonDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDataGridView;
        private AdventureWorksDataSet adventureWorksDataSet1;
        private System.Windows.Forms.Button buttonNavigation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}