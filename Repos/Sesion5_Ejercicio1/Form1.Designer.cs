namespace Sesion5_Ejercicio1
{
   partial class Form1
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
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.tbNumber1 = new System.Windows.Forms.TextBox();
         this.tbNumber2 = new System.Windows.Forms.TextBox();
         this.btnGreater = new System.Windows.Forms.Button();
         this.lblAnswer = new System.Windows.Forms.Label();
         this.btnLess = new System.Windows.Forms.Button();
         this.button1 = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.btnShowDay = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(36, 33);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(50, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Numero1\r\n";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(36, 69);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(50, 13);
         this.label2.TabIndex = 1;
         this.label2.Text = "Numero2";
         // 
         // tbNumber1
         // 
         this.tbNumber1.Location = new System.Drawing.Point(92, 30);
         this.tbNumber1.Name = "tbNumber1";
         this.tbNumber1.Size = new System.Drawing.Size(100, 20);
         this.tbNumber1.TabIndex = 2;
         this.tbNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         this.tbNumber1.TextChanged += new System.EventHandler(this.tbNumber1_TextChanged);
         // 
         // tbNumber2
         // 
         this.tbNumber2.Location = new System.Drawing.Point(93, 69);
         this.tbNumber2.Name = "tbNumber2";
         this.tbNumber2.Size = new System.Drawing.Size(100, 20);
         this.tbNumber2.TabIndex = 3;
         this.tbNumber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // btnGreater
         // 
         this.btnGreater.Location = new System.Drawing.Point(93, 109);
         this.btnGreater.Name = "btnGreater";
         this.btnGreater.Size = new System.Drawing.Size(100, 23);
         this.btnGreater.TabIndex = 4;
         this.btnGreater.Text = "Evaluate Greater";
         this.btnGreater.UseVisualStyleBackColor = true;
         this.btnGreater.Click += new System.EventHandler(this.btnGreater_Click);
         // 
         // lblAnswer
         // 
         this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.lblAnswer.Location = new System.Drawing.Point(39, 181);
         this.lblAnswer.Name = "lblAnswer";
         this.lblAnswer.Size = new System.Drawing.Size(132, 23);
         this.lblAnswer.TabIndex = 5;
         // 
         // btnLess
         // 
         this.btnLess.Location = new System.Drawing.Point(93, 138);
         this.btnLess.Name = "btnLess";
         this.btnLess.Size = new System.Drawing.Size(100, 23);
         this.btnLess.TabIndex = 6;
         this.btnLess.Text = "Evaluate Less";
         this.btnLess.UseVisualStyleBackColor = true;
         this.btnLess.Click += new System.EventHandler(this.btnLess_Click);
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(199, 138);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(100, 23);
         this.button1.TabIndex = 8;
         this.button1.Text = "Evaluate Less";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(199, 109);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(100, 23);
         this.button2.TabIndex = 7;
         this.button2.Text = "Evaluate Greater";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // btnShowDay
         // 
         this.btnShowDay.Location = new System.Drawing.Point(334, 33);
         this.btnShowDay.Name = "btnShowDay";
         this.btnShowDay.Size = new System.Drawing.Size(100, 23);
         this.btnShowDay.TabIndex = 9;
         this.btnShowDay.Text = "Evaluar Dia";
         this.btnShowDay.UseVisualStyleBackColor = true;
         this.btnShowDay.Click += new System.EventHandler(this.btnShowDay_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(458, 265);
         this.Controls.Add(this.btnShowDay);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.btnLess);
         this.Controls.Add(this.lblAnswer);
         this.Controls.Add(this.btnGreater);
         this.Controls.Add(this.tbNumber2);
         this.Controls.Add(this.tbNumber1);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Name = "Form1";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Sesión 5";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox tbNumber1;
      private System.Windows.Forms.TextBox tbNumber2;
      private System.Windows.Forms.Button btnGreater;
      private System.Windows.Forms.Label lblAnswer;
      private System.Windows.Forms.Button btnLess;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Button btnShowDay;
   }
}

