using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fermiyon_Lab
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Load += Form2_Load;
        }
        private bool KuarkMi(string ad)
        {
            return ad == "up" || ad == "down" || ad == "strange" ||
                   ad == "charm" || ad == "bottom" || ad == "top";
        }
        private bool LeptonMu(string ad)
        {
            return ad == "elektron" || ad == "muon" || ad == "tau" ||
                   ad == "elektron_n" || ad == "muon_n" || ad == "tau_n";
        }
        private bool BozonMu(string ad)
        {
            return ad == "gluon" || ad == "photon" ||
                   ad == "w_bozon" || ad == "z_bozon";
        }
        private bool BosonMu(string ad)
        {
            return ad == "higgs";

        }
        private string FermiyonGorunumu(string ad)
        {
            switch (ad)
            {
                case "elektron": return "Elektron (e⁻)";
                case "muon": return "Müon (μ⁻)";
                case "tau": return "Tau (τ⁻)";
                case "elektron_n": return "Elektron nötrinosu (νₑ)";
                case "muon_n": return "Müon nötrinosu (ν_μ)";
                case "tau_n": return "Tau nötrinosu (ν_τ)";
                case "up": return "Up (u)";
                case "down": return "Down (d)";
                case "strange": return "Strange (s)";
                case "charm": return "Charm (c)";
                case "bottom": return "Bottom (b)";
                case "top": return "Top (t)";
                case "gluon": return "gluon (g)";
                case "photon": return "photon (γ)";
                case "w_bozon": return "W-Bozon (W)";
                case "z_bozon": return "Z-Bozon (Z)";
                case "higgs": return "Higgs Bozon (H)";
                default: return ad;
            }
        }
        private void ShowFermiyonInfo(string ad)
        {
            string bilgi = "";
            switch (ad)
            {
                // KUARKLAR
                case "up":
                    bilgi = "Up Kuark (u)\nKütle: 2.4 MeV/c²\nYük: +2/3\nNesil: 1. nesil kuark\nÖzellik: Proton ve nötronların yapı taşıdır.";
                    break;
                case "down":
                    bilgi = "Down Kuark (d)\nKütle: 4.8 MeV/c²\nYük: -1/3\nNesil: 1. nesil kuark\nÖzellik: Proton ve nötronların yapı taşıdır.";
                    break;
                case "charm":
                    bilgi = "Charm Kuark (c)\nKütle: 1.27 GeV/c²\nYük: +2/3\nNesil: 2. nesil kuark\nÖzellik: J/ψ mezonunun bileşenidir.";
                    break;
                case "strange":
                    bilgi = "Strange Kuark (s)\nKütle: 95 MeV/c²\nYük: -1/3\nNesil: 2. nesil kuark\nÖzellik: Kaon parçacıklarının bileşenidir.";
                    break;
                case "top":
                    bilgi = "Top Kuark (t)\nKütle: 171.2 GeV/c²\nYük: +2/3\nNesil: 3. nesil kuark\nÖzellik: En ağır temel parçacıktır.";
                    break;
                case "bottom":
                    bilgi = "Bottom Kuark (b)\nKütle: 4.18 GeV/c²\nYük: -1/3\nNesil: 3. nesil kuark\nÖzellik: B mezonlarının bileşenidir.";
                    break;

                // LEPTONLAR
                case "elektron":
                    bilgi = "Elektron (e⁻)\nKütle: 0.511 MeV/c²\nYük: -1\nNesil: 1. nesil lepton\nÖzellik: Atomların elektronik yapısını oluşturur.";
                    break;
                case "muon":
                    bilgi = "Müon (μ⁻)\nKütle: 105.7 MeV/c²\nYük: -1\nNesil: 2. nesil lepton\nÖzellik: Kozmik ışınlarda bulunur.";
                    break;
                case "tau":
                    bilgi = "Tau (τ⁻)\nKütle: 1777 MeV/c²\nYük: -1\nNesil: 3. nesil lepton\nÖzellik: En ağır leptondur.";
                    break;
                case "elektron_n":
                    bilgi = "Elektron Nötrinosu (νₑ)\nKütle: ~0\nYük: 0\nNesil: 1. nesil lepton\nÖzellik: Beta bozunumunda ortaya çıkar.";
                    break;
                case "muon_n":
                    bilgi = "Müon Nötrinosu (ν_μ)\nKütle: ~0\nYük: 0\nNesil: 2. nesil lepton\nÖzellik: Pion bozunumunda ortaya çıkar.";
                    break;
                case "tau_n":
                    bilgi = "Tau Nötrinosu (ν_τ)\nKütle: ~0\nYük: 0\nNesil: 3. nesil lepton\nÖzellik: Tau bozunumunda ortaya çıkar.";
                    break;

                // BOZONLAR
                case "gluon":
                    bilgi = "Gluon (g)\nKütle: 0\nYük: 0\nKuvvet: Güçlü nükleer kuvvet\nÖzellik: Kuarkları bir arada tutar.";
                    break;
                case "photon":
                    bilgi = "Foton (γ)\nKütle: 0\nYük: 0\nKuvvet: Elektromanyetik kuvvet\nÖzellik: Işığın yapı taşıdır.";
                    break;
                case "w_bozon":
                    bilgi = "W Bozonu (W)\nKütle: 80.4 GeV/c²\nYük: ±1\nKuvvet: Zayıf nükleer kuvvet\nÖzellik: Beta bozunumunu sağlar.";
                    break;
                case "z_bozon":
                    bilgi = "Z Bozonu (Z)\nKütle: 91.2 GeV/c²\nYük: 0\nKuvvet: Zayıf nükleer kuvvet\nÖzellik: Nötrino etkileşimlerinde rol oynar.";
                    break;
                case "higgs":
                    bilgi = "Higgs Bozonu (H)\nKütle: 125.3 GeV/c²\nYük: 0\nÖzellik: Parçacıklara kütle kazandırır.\nKeşif: 2012 yılında CERN'de keşfedildi.";
                    break;
            }
            MessageBox.Show(bilgi, "Parçacık Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void KaldirOrijinalButon(string ad)
        {
            foreach (Control ctrl in flpFermiyonlar.Controls)
            {
                if (ctrl is Button && ctrl.Tag != null && ctrl.Tag.ToString() == ad)
                {
                    ctrl.Visible = false;
                    break;
                }
            }
        }
        private void flpFermiyonlar_DragDrop(object sender, DragEventArgs e)
        {
            var panel = sender as FlowLayoutPanel;
            string ad = (string)e.Data.GetData(typeof(string));

            if (panel == flpKuarklar && KuarkMi(ad))
            {
                Button yeniBtn = new Button();
                yeniBtn.Text = FermiyonGorunumu(ad);
                yeniBtn.Enabled = false;
                panel.Controls.Add(yeniBtn);
                ShowFermiyonInfo(ad);
                KaldirOrijinalButon(ad);
            }
            else if (panel == flpBozonlar && BozonMu(ad))
            {
                Button yeniBtn = new Button();
                yeniBtn.Text = FermiyonGorunumu(ad);
                yeniBtn.Enabled = false;
                panel.Controls.Add(yeniBtn);
                ShowFermiyonInfo(ad);
                KaldirOrijinalButon(ad);
            }
            else if (panel == flpLeptonlar && LeptonMu(ad))
            {
                Button yeniBtn = new Button();
                yeniBtn.Text = FermiyonGorunumu(ad);
                yeniBtn.Enabled = false;
                panel.Controls.Add(yeniBtn);
                ShowFermiyonInfo(ad);
                KaldirOrijinalButon(ad);
            }
            else if (panel == flpBoson && BosonMu(ad))
            {
                Button yeniBtn = new Button();
                yeniBtn.Text = FermiyonGorunumu(ad);
                yeniBtn.Enabled = false;
                panel.Controls.Add(yeniBtn);
                ShowFermiyonInfo(ad);
                KaldirOrijinalButon(ad);
            }
            else
            {
                MessageBox.Show("Yanlış kutu! Lütfen doğru kategoriye bırakın.");
            }
        }

        private void flowLayoutPanel3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void gluon_MouseDown(object sender, MouseEventArgs e)
        {
            var btn = sender as Button;
            if (btn != null && btn.Tag != null)
                btn.DoDragDrop(btn.Tag.ToString(), DragDropEffects.Move);
        }

        private void photon_MouseDown(object sender, MouseEventArgs e)
        {
            var btn = sender as Button;
            if (btn != null && btn.Tag != null)
                btn.DoDragDrop(btn.Tag.ToString(), DragDropEffects.Move);
        }

        private void ZBozon_MouseDown(object sender, MouseEventArgs e)
        {
            var btn = sender as Button;
            if (btn != null && btn.Tag != null)
                btn.DoDragDrop(btn.Tag.ToString(), DragDropEffects.Move);
        }

        private void WBozon_MouseDown(object sender, MouseEventArgs e)
        {
            var btn = sender as Button;
            if (btn != null && btn.Tag != null)
                btn.DoDragDrop(btn.Tag.ToString(), DragDropEffects.Move);
        }

        private void btnTop_MouseDown(object sender, MouseEventArgs e)
        {
            var btn = sender as Button;
            if (btn != null && btn.Tag != null)
                btn.DoDragDrop(btn.Tag.ToString(), DragDropEffects.Move);
        }

        private void btnStrange_MouseDown(object sender, MouseEventArgs e)
        {
            var btn = sender as Button;
            if (btn != null && btn.Tag != null)
                btn.DoDragDrop(btn.Tag.ToString(), DragDropEffects.Move);
        }

        private void btnUp_MouseDown(object sender, MouseEventArgs e)
        {
            var btn = sender as Button;
            if (btn != null && btn.Tag != null)
                btn.DoDragDrop(btn.Tag.ToString(), DragDropEffects.Move);
        }

        private void btnCharm_MouseDown(object sender, MouseEventArgs e)
        {
            var btn = sender as Button;
            if (btn != null && btn.Tag != null)
                btn.DoDragDrop(btn.Tag.ToString(), DragDropEffects.Move);
        }

        private void btnDown_MouseDown(object sender, MouseEventArgs e)
        {
            var btn = sender as Button;
            if (btn != null && btn.Tag != null)
                btn.DoDragDrop(btn.Tag.ToString(), DragDropEffects.Move);
        }

        private void btnElektron_MouseDown(object sender, MouseEventArgs e)
        {
            var btn = sender as Button;
            if (btn != null && btn.Tag != null)
                btn.DoDragDrop(btn.Tag.ToString(), DragDropEffects.Move);
        }
        private void btnMuonNotrino_MouseDown(object sender, MouseEventArgs e)
        {
            var btn = sender as Button;
            if (btn != null && btn.Tag != null)
                btn.DoDragDrop(btn.Tag.ToString(), DragDropEffects.Move);
        }

        private void btnTau_MouseDown(object sender, MouseEventArgs e)
        {
            var btn = sender as Button;
            if (btn != null && btn.Tag != null)
                btn.DoDragDrop(btn.Tag.ToString(), DragDropEffects.Move);
        }

        private void btnElektronNotrino_MouseDown(object sender, MouseEventArgs e)
        {
            var btn = sender as Button;
            if (btn != null && btn.Tag != null)
                btn.DoDragDrop(btn.Tag.ToString(), DragDropEffects.Move);
        }

        private void btnMuon_MouseDown(object sender, MouseEventArgs e)
        {
            var btn = sender as Button;
            if (btn != null && btn.Tag != null)
                btn.DoDragDrop(btn.Tag.ToString(), DragDropEffects.Move);
        }

        private void btnTauNotrinosu_MouseDown(object sender, MouseEventArgs e)
        {
            var btn = sender as Button;
            if (btn != null && btn.Tag != null)
                btn.DoDragDrop(btn.Tag.ToString(), DragDropEffects.Move);
        }

        private void flpFermiyonlar_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void flowLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void flowLayoutPanel2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void flowLayoutPanel4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void flpBozonlar_MouseDown(object sender, MouseEventArgs e)
        {
            var btn = sender as Button;
            if (btn != null && btn.Tag != null)
                btn.DoDragDrop(btn.Tag.ToString(), DragDropEffects.Move);
        }
        private void bottom_MouseDown(object sender, MouseEventArgs e)
        {
            var btn = sender as Button;
            if (btn != null && btn.Tag != null)
                btn.DoDragDrop(btn.Tag.ToString(), DragDropEffects.Move);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // FlowLayoutPanel ayarları
            flpKuarklar.FlowDirection = FlowDirection.LeftToRight;
            flpKuarklar.WrapContents = true;
            flpLeptonlar.FlowDirection = FlowDirection.LeftToRight;
            flpLeptonlar.WrapContents = true;
            flpBozonlar.FlowDirection = FlowDirection.LeftToRight;
            flpBozonlar.WrapContents = true;
            flpBoson.FlowDirection = FlowDirection.LeftToRight;
            flpBoson.WrapContents = true;

            // Kuarklar için sıralı kutucuklar
            string[] kuarklar = { "up", "charm", "top", "down", "strange", "bottom" };
            flpKuarklar.Controls.Clear();
            foreach (var k in kuarklar)
            {
                Panel pnl = new Panel();
                pnl.Tag = k;
                pnl.Width = 67;
                pnl.Height = 80;
                pnl.BorderStyle = BorderStyle.FixedSingle;
                pnl.AllowDrop = true;
                pnl.DragEnter += Kutucuk_DragEnter;
                pnl.DragDrop += Kutucuk_DragDrop;
                flpKuarklar.Controls.Add(pnl);
            }
            // Leptonlar için sıralı kutucuklar
            string[] leptonlar = { "elektron", "muon", "tau", "elektron_n", "muon_n", "tau_n" };
            flpLeptonlar.Controls.Clear();
            foreach (var l in leptonlar)
            {
                Panel pnl = new Panel();
                pnl.Tag = l;
                pnl.Width = 67;
                pnl.Height = 80;
                pnl.BorderStyle = BorderStyle.FixedSingle;
                pnl.AllowDrop = true;
                pnl.DragEnter += Kutucuk_DragEnter;
                pnl.DragDrop += Kutucuk_DragDrop;
                flpLeptonlar.Controls.Add(pnl);
            }
            // Bozonlar için sıralı kutucuklar
            string[] bozonlar = { "gluon", "photon", "z_bozon", "w_bozon" };
            flpBozonlar.Controls.Clear();
            foreach (var b in bozonlar)
            {
                Panel pnl = new Panel();
                pnl.Tag = b;
                pnl.Width = 67;
                pnl.Height = 80;
                pnl.BorderStyle = BorderStyle.FixedSingle;
                pnl.AllowDrop = true;
                pnl.DragEnter += Kutucuk_DragEnter;
                pnl.DragDrop += Kutucuk_DragDrop;
                flpBozonlar.Controls.Add(pnl);
            }
            // Higgs için ayrı kutucuk (isteğe bağlı)
            flpBoson.Controls.Clear();
            Panel pnlHiggs = new Panel();
            pnlHiggs.Tag = "higgs";
            pnlHiggs.Width = 67;
            pnlHiggs.Height = 80;
            pnlHiggs.BorderStyle = BorderStyle.FixedSingle;
            pnlHiggs.AllowDrop = true;
            pnlHiggs.DragEnter += Kutucuk_DragEnter;
            pnlHiggs.DragDrop += Kutucuk_DragDrop;
            flpBoson.Controls.Add(pnlHiggs);
        }

        private void boson_MouseDown(object sender, MouseEventArgs e)
        {
            var btn = sender as Button;
            if (btn != null && btn.Tag != null)
                btn.DoDragDrop(btn.Tag.ToString(), DragDropEffects.Move);
        }

        // --- KUTUCUK DRAG & DROP ---
        private void Kutucuk_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Kutucuk_DragDrop(object sender, DragEventArgs e)
        {
            var kutucuk = sender as Panel;
            string suruklenenTag = (string)e.Data.GetData(typeof(string));
            string dogruTag = kutucuk.Tag.ToString();

            if (suruklenenTag == dogruTag)
            {
                kutucuk.BackColor = Color.LightGreen;
                kutucuk.Controls.Clear();
                Label lbl = new Label();
                lbl.Text = FermiyonGorunumu(suruklenenTag);
                lbl.Dock = DockStyle.Fill;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                kutucuk.Controls.Add(lbl);
                ShowFermiyonInfo(suruklenenTag);
                KaldirOrijinalButon(suruklenenTag);
            }
            else
            {
                MessageBox.Show("Sırası yanlış! Lütfen doğru kutuya bırakın.");
            }
        }
    }
}
