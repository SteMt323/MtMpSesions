namespace Sesion5_Ejercicio1
{
   partial class FrmDia
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
         this.cmbDay = new System.Windows.Forms.ComboBox();
         this.buttonDay = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 19);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(116, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Selecciona un número:\r\n";
         this.label1.Click += new System.EventHandler(this.label1_Click);
         // 
         // cmbDay
         // 
         this.cmbDay.FormattingEnabled = true;
         this.cmbDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
         this.cmbDay.Location = new System.Drawing.Point(134, 16);
         this.cmbDay.Name = "cmbDay";
         this.cmbDay.Size = new System.Drawing.Size(58, 21);
         this.cmbDay.TabIndex = 1;
         // 
         // buttonDay
         // 
         this.buttonDay.Location = new System.Drawing.Point(198, 8);
         this.buttonDay.Name = "buttonDay";
         this.buttonDay.Size = new System.Drawing.Size(100, 35);
         this.buttonDay.TabIndex = 9;
         this.buttonDay.Text = "Show Day";
         this.buttonDay.UseVisualStyleBackColor = true;
         this.buttonDay.Click += new System.EventHandler(this.buttonDay_Click);
         // 
         // FrmDia
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(395, 224);
         this.Controls.Add(this.buttonDay);
         this.Controls.Add(this.cmbDay);
         this.Controls.Add(this.label1);
         this.Name = "FrmDia";
         this.Text = "FrmDia";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.ComboBox cmbDay;
      private System.Windows.Forms.Button buttonDay;
   }
}