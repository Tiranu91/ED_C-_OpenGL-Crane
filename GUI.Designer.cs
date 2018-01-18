namespace DemoOpenGLBasicsCS
{
   partial class GUI
   {
      /// <summary>
      /// Erforderliche Designervariable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Verwendete Ressourcen bereinigen.
      /// </summary>
      /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Vom Windows Form-Designer generierter Code

      /// <summary>
      /// Erforderliche Methode für die Designerunterstützung.
      /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
      /// </summary>
      private void InitializeComponent()
      {
            this.panel = new System.Windows.Forms.Panel();
            this.trb_drehen = new System.Windows.Forms.TrackBar();
            this.trb_auslegen = new System.Windows.Forms.TrackBar();
            this.trb_heben = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_y = new System.Windows.Forms.Label();
            this.lbl_z = new System.Windows.Forms.Label();
            this.lbl_x = new System.Windows.Forms.Label();
            this.lbl_ausleger = new System.Windows.Forms.Label();
            this.lbl_seil = new System.Windows.Forms.Label();
            this.lbl_drehung = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_x = new System.Windows.Forms.TextBox();
            this.tb_z = new System.Windows.Forms.TextBox();
            this.tb_y = new System.Windows.Forms.TextBox();
            this.btn_bewegen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trb_drehen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_auslegen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_heben)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(16, 15);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(988, 591);
            this.panel.TabIndex = 0;
            // 
            // trb_drehen
            // 
            this.trb_drehen.Location = new System.Drawing.Point(1060, 70);
            this.trb_drehen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trb_drehen.Maximum = 360;
            this.trb_drehen.Name = "trb_drehen";
            this.trb_drehen.Size = new System.Drawing.Size(553, 56);
            this.trb_drehen.TabIndex = 1;
            this.trb_drehen.Scroll += new System.EventHandler(this.trb_drehen_Scroll);
            // 
            // trb_auslegen
            // 
            this.trb_auslegen.Location = new System.Drawing.Point(1060, 143);
            this.trb_auslegen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trb_auslegen.Maximum = 19;
            this.trb_auslegen.Minimum = 2;
            this.trb_auslegen.Name = "trb_auslegen";
            this.trb_auslegen.Size = new System.Drawing.Size(553, 56);
            this.trb_auslegen.TabIndex = 2;
            this.trb_auslegen.Value = 15;
            this.trb_auslegen.Scroll += new System.EventHandler(this.trb_auslegen_Scroll);
            // 
            // trb_heben
            // 
            this.trb_heben.Location = new System.Drawing.Point(1060, 219);
            this.trb_heben.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trb_heben.Maximum = 27;
            this.trb_heben.Minimum = 2;
            this.trb_heben.Name = "trb_heben";
            this.trb_heben.Size = new System.Drawing.Size(553, 56);
            this.trb_heben.TabIndex = 3;
            this.trb_heben.Value = 15;
            this.trb_heben.Scroll += new System.EventHandler(this.trb_heben_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1067, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Drehen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1067, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Auslegen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1067, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Heben:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1411, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Position Abrissbirne:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1425, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "X:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1425, 485);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Y:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1425, 521);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Z:";
            // 
            // lbl_y
            // 
            this.lbl_y.AutoSize = true;
            this.lbl_y.Location = new System.Drawing.Point(1452, 485);
            this.lbl_y.Name = "lbl_y";
            this.lbl_y.Size = new System.Drawing.Size(21, 17);
            this.lbl_y.TabIndex = 13;
            this.lbl_y.Text = "Y:";
            // 
            // lbl_z
            // 
            this.lbl_z.AutoSize = true;
            this.lbl_z.Location = new System.Drawing.Point(1452, 521);
            this.lbl_z.Name = "lbl_z";
            this.lbl_z.Size = new System.Drawing.Size(21, 17);
            this.lbl_z.TabIndex = 12;
            this.lbl_z.Text = "Z:";
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.Location = new System.Drawing.Point(1452, 443);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(21, 17);
            this.lbl_x.TabIndex = 11;
            this.lbl_x.Text = "X:";
            // 
            // lbl_ausleger
            // 
            this.lbl_ausleger.AutoSize = true;
            this.lbl_ausleger.Location = new System.Drawing.Point(1160, 485);
            this.lbl_ausleger.Name = "lbl_ausleger";
            this.lbl_ausleger.Size = new System.Drawing.Size(16, 17);
            this.lbl_ausleger.TabIndex = 20;
            this.lbl_ausleger.Text = "0";
            // 
            // lbl_seil
            // 
            this.lbl_seil.AutoSize = true;
            this.lbl_seil.Location = new System.Drawing.Point(1160, 521);
            this.lbl_seil.Name = "lbl_seil";
            this.lbl_seil.Size = new System.Drawing.Size(16, 17);
            this.lbl_seil.TabIndex = 19;
            this.lbl_seil.Text = "0";
            // 
            // lbl_drehung
            // 
            this.lbl_drehung.AutoSize = true;
            this.lbl_drehung.Location = new System.Drawing.Point(1160, 443);
            this.lbl_drehung.Name = "lbl_drehung";
            this.lbl_drehung.Size = new System.Drawing.Size(16, 17);
            this.lbl_drehung.TabIndex = 18;
            this.lbl_drehung.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1069, 521);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "Seillaenge:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1069, 485);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "Auslerger:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1069, 443);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "Drehung (°):";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1055, 378);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 25);
            this.label14.TabIndex = 14;
            this.label14.Text = "Konfiguration:";
            // 
            // tb_x
            // 
            this.tb_x.Location = new System.Drawing.Point(1513, 443);
            this.tb_x.Name = "tb_x";
            this.tb_x.Size = new System.Drawing.Size(100, 22);
            this.tb_x.TabIndex = 21;
            // 
            // tb_z
            // 
            this.tb_z.Location = new System.Drawing.Point(1513, 521);
            this.tb_z.Name = "tb_z";
            this.tb_z.Size = new System.Drawing.Size(100, 22);
            this.tb_z.TabIndex = 22;
            // 
            // tb_y
            // 
            this.tb_y.Location = new System.Drawing.Point(1513, 485);
            this.tb_y.Name = "tb_y";
            this.tb_y.Size = new System.Drawing.Size(100, 22);
            this.tb_y.TabIndex = 23;
            // 
            // btn_bewegen
            // 
            this.btn_bewegen.Location = new System.Drawing.Point(1266, 561);
            this.btn_bewegen.Name = "btn_bewegen";
            this.btn_bewegen.Size = new System.Drawing.Size(159, 35);
            this.btn_bewegen.TabIndex = 24;
            this.btn_bewegen.Text = "Bewegen";
            this.btn_bewegen.UseVisualStyleBackColor = true;
            this.btn_bewegen.Click += new System.EventHandler(this.btn_bewegen_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1647, 620);
            this.Controls.Add(this.btn_bewegen);
            this.Controls.Add(this.tb_y);
            this.Controls.Add(this.tb_z);
            this.Controls.Add(this.tb_x);
            this.Controls.Add(this.lbl_ausleger);
            this.Controls.Add(this.lbl_seil);
            this.Controls.Add(this.lbl_drehung);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbl_y);
            this.Controls.Add(this.lbl_z);
            this.Controls.Add(this.lbl_x);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trb_heben);
            this.Controls.Add(this.trb_auslegen);
            this.Controls.Add(this.trb_drehen);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUI";
            this.Text = "OpenGL Demo";
            ((System.ComponentModel.ISupportInitialize)(this.trb_drehen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_auslegen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_heben)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TrackBar trb_drehen;
        private System.Windows.Forms.TrackBar trb_auslegen;
        private System.Windows.Forms.TrackBar trb_heben;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_y;
        private System.Windows.Forms.Label lbl_z;
        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.Label lbl_ausleger;
        private System.Windows.Forms.Label lbl_seil;
        private System.Windows.Forms.Label lbl_drehung;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_x;
        private System.Windows.Forms.TextBox tb_z;
        private System.Windows.Forms.TextBox tb_y;
        private System.Windows.Forms.Button btn_bewegen;
    }
}

