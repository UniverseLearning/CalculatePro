namespace CalculatePro
{
    partial class FormIndex
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
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonContract = new System.Windows.Forms.Button();
            this.buttonMateriel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonCalculate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCalculate.Location = new System.Drawing.Point(72, 95);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(177, 51);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "报价计算";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonContract
            // 
            this.buttonContract.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonContract.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonContract.Location = new System.Drawing.Point(72, 184);
            this.buttonContract.Name = "buttonContract";
            this.buttonContract.Size = new System.Drawing.Size(177, 51);
            this.buttonContract.TabIndex = 1;
            this.buttonContract.Text = "合同管理";
            this.buttonContract.UseVisualStyleBackColor = false;
            this.buttonContract.Click += new System.EventHandler(this.buttonContract_Click);
            // 
            // buttonMateriel
            // 
            this.buttonMateriel.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonMateriel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMateriel.Location = new System.Drawing.Point(72, 277);
            this.buttonMateriel.Name = "buttonMateriel";
            this.buttonMateriel.Size = new System.Drawing.Size(177, 51);
            this.buttonMateriel.TabIndex = 2;
            this.buttonMateriel.Text = "部件管理";
            this.buttonMateriel.UseVisualStyleBackColor = false;
            this.buttonMateriel.Click += new System.EventHandler(this.buttonMateriel_Click);
            // 
            // FormIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(327, 459);
            this.Controls.Add(this.buttonMateriel);
            this.Controls.Add(this.buttonContract);
            this.Controls.Add(this.buttonCalculate);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "机械报价计算器";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonContract;
        private System.Windows.Forms.Button buttonMateriel;
    }
}