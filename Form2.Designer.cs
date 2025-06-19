namespace Fermiyon_Lab
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
            this.flpBoson = new System.Windows.Forms.FlowLayoutPanel();
            this.flpKuarklar = new System.Windows.Forms.FlowLayoutPanel();
            this.bottom = new System.Windows.Forms.Button();
            this.strange = new System.Windows.Forms.Button();
            this.top = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Button();
            this.charm = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flpLeptonlar = new System.Windows.Forms.FlowLayoutPanel();
            this.elektron = new System.Windows.Forms.Button();
            this.muon_n = new System.Windows.Forms.Button();
            this.tau = new System.Windows.Forms.Button();
            this.elektron_n = new System.Windows.Forms.Button();
            this.muon = new System.Windows.Forms.Button();
            this.tau_n = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.flpBozonlar = new System.Windows.Forms.FlowLayoutPanel();
            this.gluon = new System.Windows.Forms.Button();
            this.photon = new System.Windows.Forms.Button();
            this.z_bozon = new System.Windows.Forms.Button();
            this.w_bozon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.flpFermiyonlar = new System.Windows.Forms.FlowLayoutPanel();
            this.boson = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flpFermiyonlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpBoson
            // 
            this.flpBoson.AllowDrop = true;
            this.flpBoson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.flpBoson.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpBoson.Location = new System.Drawing.Point(339, 25);
            this.flpBoson.Name = "flpBoson";
            this.flpBoson.Size = new System.Drawing.Size(75, 86);
            this.flpBoson.TabIndex = 15;
            this.flpBoson.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel4_DragEnter);
            // 
            // flpKuarklar
            // 
            this.flpKuarklar.AllowDrop = true;
            this.flpKuarklar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.flpKuarklar.Location = new System.Drawing.Point(12, 25);
            this.flpKuarklar.Name = "flpKuarklar";
            this.flpKuarklar.Size = new System.Drawing.Size(220, 173);
            this.flpKuarklar.TabIndex = 1;
            this.flpKuarklar.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpFermiyonlar_DragDrop);
            this.flpKuarklar.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpFermiyonlar_DragEnter);
            // 
            // bottom
            // 
            this.bottom.Image = global::Fermiyon_Lab.Properties.Resources.Ekran_görüntüsü_2025_06_19_182525;
            this.bottom.Location = new System.Drawing.Point(3, 3);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(89, 78);
            this.bottom.TabIndex = 5;
            this.bottom.Tag = "bottom";
            this.bottom.UseVisualStyleBackColor = true;
            this.bottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bottom_MouseDown);
            // 
            // strange
            // 
            this.strange.Image = global::Fermiyon_Lab.Properties.Resources.Ekran_görüntüsü_2025_06_19_1825231;
            this.strange.Location = new System.Drawing.Point(3, 255);
            this.strange.Name = "strange";
            this.strange.Size = new System.Drawing.Size(89, 78);
            this.strange.TabIndex = 3;
            this.strange.Tag = "strange";
            this.strange.UseVisualStyleBackColor = true;
            this.strange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnStrange_MouseDown);
            // 
            // top
            // 
            this.top.Image = global::Fermiyon_Lab.Properties.Resources.Ekran_görüntüsü_2025_06_19_182514;
            this.top.Location = new System.Drawing.Point(193, 3);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(89, 78);
            this.top.TabIndex = 4;
            this.top.Tag = "top";
            this.top.UseVisualStyleBackColor = true;
            this.top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTop_MouseDown);
            // 
            // up
            // 
            this.up.Image = global::Fermiyon_Lab.Properties.Resources.Ekran_görüntüsü_2025_06_19_1822341;
            this.up.Location = new System.Drawing.Point(98, 3);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(89, 78);
            this.up.TabIndex = 0;
            this.up.Tag = "up";
            this.up.UseVisualStyleBackColor = true;
            this.up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnUp_MouseDown);
            // 
            // charm
            // 
            this.charm.Image = global::Fermiyon_Lab.Properties.Resources.Ekran_görüntüsü_2025_06_19_182509;
            this.charm.Location = new System.Drawing.Point(193, 87);
            this.charm.Name = "charm";
            this.charm.Size = new System.Drawing.Size(89, 78);
            this.charm.TabIndex = 2;
            this.charm.Tag = "charm";
            this.charm.UseVisualStyleBackColor = true;
            this.charm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCharm_MouseDown);
            // 
            // down
            // 
            this.down.Image = global::Fermiyon_Lab.Properties.Resources.Ekran_görüntüsü_2025_06_19_182519;
            this.down.Location = new System.Drawing.Point(193, 171);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(89, 78);
            this.down.TabIndex = 1;
            this.down.Tag = "down";
            this.down.UseVisualStyleBackColor = true;
            this.down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDown_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "KUARKLAR";
            // 
            // flpLeptonlar
            // 
            this.flpLeptonlar.AllowDrop = true;
            this.flpLeptonlar.BackColor = System.Drawing.Color.Green;
            this.flpLeptonlar.Location = new System.Drawing.Point(11, 245);
            this.flpLeptonlar.Name = "flpLeptonlar";
            this.flpLeptonlar.Size = new System.Drawing.Size(221, 170);
            this.flpLeptonlar.TabIndex = 12;
            this.flpLeptonlar.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel1_DragEnter);
            // 
            // elektron
            // 
            this.elektron.Image = global::Fermiyon_Lab.Properties.Resources.Ekran_görüntüsü_2025_06_19_182736;
            this.elektron.Location = new System.Drawing.Point(98, 171);
            this.elektron.Name = "elektron";
            this.elektron.Size = new System.Drawing.Size(89, 78);
            this.elektron.TabIndex = 6;
            this.elektron.Tag = "elektron";
            this.elektron.UseVisualStyleBackColor = true;
            this.elektron.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnElektron_MouseDown);
            // 
            // muon_n
            // 
            this.muon_n.Image = global::Fermiyon_Lab.Properties.Resources.Ekran_görüntüsü_2025_06_19_182745;
            this.muon_n.Location = new System.Drawing.Point(98, 255);
            this.muon_n.Name = "muon_n";
            this.muon_n.Size = new System.Drawing.Size(89, 78);
            this.muon_n.TabIndex = 9;
            this.muon_n.Tag = "muon_n";
            this.muon_n.UseVisualStyleBackColor = true;
            this.muon_n.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMuonNotrino_MouseDown);
            // 
            // tau
            // 
            this.tau.Image = global::Fermiyon_Lab.Properties.Resources.Ekran_görüntüsü_2025_06_19_182747;
            this.tau.Location = new System.Drawing.Point(3, 339);
            this.tau.Name = "tau";
            this.tau.Size = new System.Drawing.Size(89, 78);
            this.tau.TabIndex = 11;
            this.tau.Tag = "tau";
            this.tau.UseVisualStyleBackColor = true;
            this.tau.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTau_MouseDown);
            // 
            // elektron_n
            // 
            this.elektron_n.Image = global::Fermiyon_Lab.Properties.Resources.Ekran_görüntüsü_2025_06_19_182739;
            this.elektron_n.Location = new System.Drawing.Point(193, 255);
            this.elektron_n.Name = "elektron_n";
            this.elektron_n.Size = new System.Drawing.Size(89, 78);
            this.elektron_n.TabIndex = 7;
            this.elektron_n.Tag = "elektron_n";
            this.elektron_n.UseVisualStyleBackColor = true;
            this.elektron_n.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnElektronNotrino_MouseDown);
            // 
            // muon
            // 
            this.muon.Image = global::Fermiyon_Lab.Properties.Resources.Ekran_görüntüsü_2025_06_19_182742;
            this.muon.Location = new System.Drawing.Point(3, 171);
            this.muon.Name = "muon";
            this.muon.Size = new System.Drawing.Size(89, 78);
            this.muon.TabIndex = 8;
            this.muon.Tag = "muon";
            this.muon.UseVisualStyleBackColor = true;
            this.muon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMuon_MouseDown);
            // 
            // tau_n
            // 
            this.tau_n.Image = global::Fermiyon_Lab.Properties.Resources.Ekran_görüntüsü_2025_06_19_182750;
            this.tau_n.Location = new System.Drawing.Point(288, 255);
            this.tau_n.Name = "tau_n";
            this.tau_n.Size = new System.Drawing.Size(89, 78);
            this.tau_n.TabIndex = 10;
            this.tau_n.Tag = "tau_n";
            this.tau_n.UseVisualStyleBackColor = true;
            this.tau_n.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTauNotrinosu_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "LEPTONLAR";
            // 
            // flpBozonlar
            // 
            this.flpBozonlar.AllowDrop = true;
            this.flpBozonlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.flpBozonlar.Location = new System.Drawing.Point(244, 25);
            this.flpBozonlar.Name = "flpBozonlar";
            this.flpBozonlar.Size = new System.Drawing.Size(75, 344);
            this.flpBozonlar.TabIndex = 14;
            this.flpBozonlar.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel2_DragEnter);
            this.flpBozonlar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flpBozonlar_MouseDown);
            // 
            // gluon
            // 
            this.gluon.Image = global::Fermiyon_Lab.Properties.Resources.Ekran_görüntüsü_2025_06_19_183041;
            this.gluon.Location = new System.Drawing.Point(288, 171);
            this.gluon.Name = "gluon";
            this.gluon.Size = new System.Drawing.Size(89, 78);
            this.gluon.TabIndex = 1;
            this.gluon.Tag = "gluon";
            this.gluon.UseVisualStyleBackColor = true;
            this.gluon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gluon_MouseDown);
            // 
            // photon
            // 
            this.photon.Image = global::Fermiyon_Lab.Properties.Resources.Ekran_görüntüsü_2025_06_19_183043;
            this.photon.Location = new System.Drawing.Point(98, 87);
            this.photon.Name = "photon";
            this.photon.Size = new System.Drawing.Size(89, 78);
            this.photon.TabIndex = 2;
            this.photon.Tag = "photon";
            this.photon.UseVisualStyleBackColor = true;
            this.photon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.photon_MouseDown);
            // 
            // z_bozon
            // 
            this.z_bozon.AllowDrop = true;
            this.z_bozon.Image = global::Fermiyon_Lab.Properties.Resources.Ekran_görüntüsü_2025_06_19_183046;
            this.z_bozon.Location = new System.Drawing.Point(288, 3);
            this.z_bozon.Name = "z_bozon";
            this.z_bozon.Size = new System.Drawing.Size(89, 78);
            this.z_bozon.TabIndex = 3;
            this.z_bozon.Tag = "z_bozon";
            this.z_bozon.UseVisualStyleBackColor = true;
            this.z_bozon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ZBozon_MouseDown);
            // 
            // w_bozon
            // 
            this.w_bozon.Image = global::Fermiyon_Lab.Properties.Resources.Ekran_görüntüsü_2025_06_19_183050;
            this.w_bozon.Location = new System.Drawing.Point(3, 87);
            this.w_bozon.Name = "w_bozon";
            this.w_bozon.Size = new System.Drawing.Size(89, 78);
            this.w_bozon.TabIndex = 4;
            this.w_bozon.Tag = "w_bozon";
            this.w_bozon.UseVisualStyleBackColor = true;
            this.w_bozon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WBozon_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(241, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "BOZONLAR";
            // 
            // flpFermiyonlar
            // 
            this.flpFermiyonlar.AllowDrop = true;
            this.flpFermiyonlar.Controls.Add(this.bottom);
            this.flpFermiyonlar.Controls.Add(this.up);
            this.flpFermiyonlar.Controls.Add(this.top);
            this.flpFermiyonlar.Controls.Add(this.z_bozon);
            this.flpFermiyonlar.Controls.Add(this.w_bozon);
            this.flpFermiyonlar.Controls.Add(this.photon);
            this.flpFermiyonlar.Controls.Add(this.charm);
            this.flpFermiyonlar.Controls.Add(this.boson);
            this.flpFermiyonlar.Controls.Add(this.muon);
            this.flpFermiyonlar.Controls.Add(this.elektron);
            this.flpFermiyonlar.Controls.Add(this.down);
            this.flpFermiyonlar.Controls.Add(this.gluon);
            this.flpFermiyonlar.Controls.Add(this.strange);
            this.flpFermiyonlar.Controls.Add(this.muon_n);
            this.flpFermiyonlar.Controls.Add(this.elektron_n);
            this.flpFermiyonlar.Controls.Add(this.tau_n);
            this.flpFermiyonlar.Controls.Add(this.tau);
            this.flpFermiyonlar.Location = new System.Drawing.Point(498, 22);
            this.flpFermiyonlar.Name = "flpFermiyonlar";
            this.flpFermiyonlar.Size = new System.Drawing.Size(382, 418);
            this.flpFermiyonlar.TabIndex = 16;
            this.flpFermiyonlar.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel3_DragEnter);
            // 
            // boson
            // 
            this.boson.Image = global::Fermiyon_Lab.Properties.Resources.Ekran_görüntüsü_2025_06_19_183158;
            this.boson.Location = new System.Drawing.Point(288, 87);
            this.boson.Name = "boson";
            this.boson.Size = new System.Drawing.Size(89, 78);
            this.boson.TabIndex = 5;
            this.boson.Tag = "higgs";
            this.boson.UseVisualStyleBackColor = true;
            this.boson.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boson_MouseDown);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl.Location = new System.Drawing.Point(336, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(49, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "??????";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(498, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "FERMİYONLAR";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(898, 452);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flpBoson);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.flpFermiyonlar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flpBozonlar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flpLeptonlar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpKuarklar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.flpFermiyonlar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpKuarklar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button charm;
        private System.Windows.Forms.Button strange;
        private System.Windows.Forms.Button top;
        private System.Windows.Forms.Button bottom;
        private System.Windows.Forms.Button elektron;
        private System.Windows.Forms.Button elektron_n;
        private System.Windows.Forms.Button muon;
        private System.Windows.Forms.Button muon_n;
        private System.Windows.Forms.Button tau_n;
        private System.Windows.Forms.Button tau;
        private System.Windows.Forms.FlowLayoutPanel flpLeptonlar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flpBozonlar;
        private System.Windows.Forms.Button gluon;
        private System.Windows.Forms.Button photon;
        private System.Windows.Forms.Button z_bozon;
        private System.Windows.Forms.Button w_bozon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flpFermiyonlar;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button boson;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flpBoson;
    }
}