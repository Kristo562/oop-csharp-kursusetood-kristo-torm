using System;
using System.Drawing;
using System.Windows.Forms;

namespace Torm_OOP_Kursusprojekt_CSharp
{
    public class KT_Form1 : Form
    {
        string KT_mangija = "X";
        bool KT_mangLabi = false;
        int KT_xPunktid = 0, KT_oPunktid = 0, KT_viigid = 0;
        Button[] KT_nupud = new Button[9];
        Label KT_lblKord, KT_lblTulemus, KT_lblXPunktid, KT_lblOPunktid, KT_lblViigid;

        public KT_Form1()
        {
            Name = "KT_Form1";
            Text = "Kristo Torm - Trips-Traps-Trull C#";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(560, 590);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            BackColor = Color.FromArgb(245, 247, 250);
            Font = new Font("Segoe UI", 10F);

            Label KT_lblPealkiri = new Label { Name = "KT_lblPealkiri", Text = "Trips-Traps-Trull", Location = new Point(0, 15), Size = new Size(560, 42), TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 22F, FontStyle.Bold), ForeColor = Color.FromArgb(35, 35, 35) };
            KT_lblKord = new Label { Name = "KT_lblKord", Location = new Point(55, 70), Size = new Size(450, 30), TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 13F, FontStyle.Bold) };
            KT_lblTulemus = new Label { Name = "KT_lblTulemus", Location = new Point(55, 105), Size = new Size(450, 34), TextAlign = ContentAlignment.MiddleCenter, BorderStyle = BorderStyle.FixedSingle, BackColor = Color.White, Font = new Font("Segoe UI", 11F, FontStyle.Bold) };

            int KT_algusX = 145, KT_algusY = 160, KT_suurus = 82, KT_vahe = 10;
            for (int KT_i = 0; KT_i < 9; KT_i++)
            {
                Button KT_btn = new Button();
                KT_btn.Name = "KT_btnRuut" + (KT_i + 1);
                KT_btn.Size = new Size(KT_suurus, KT_suurus);
                KT_btn.Location = new Point(KT_algusX + (KT_i % 3) * (KT_suurus + KT_vahe), KT_algusY + (KT_i / 3) * (KT_suurus + KT_vahe));
                KT_btn.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
                KT_btn.BackColor = Color.White;
                KT_btn.FlatStyle = FlatStyle.Flat;
                KT_btn.FlatAppearance.BorderSize = 2;
                KT_btn.Tag = KT_i;
                KT_btn.Click += KT_Ruut_Click;
                KT_nupud[KT_i] = KT_btn;
                Controls.Add(KT_btn);
            }

            Button KT_btnUusMang = new Button { Name = "KT_btnUusMang", Text = "Uus mäng", Location = new Point(125, 445), Size = new Size(140, 34), BackColor = Color.FromArgb(40, 150, 90), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
            KT_btnUusMang.Click += (s, e) => KT_UusMang();

            Button KT_btnNulliPunktid = new Button { Name = "KT_btnNulliPunktid", Text = "Nulli punktid", Location = new Point(295, 445), Size = new Size(140, 34), BackColor = Color.FromArgb(180, 60, 60), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
            KT_btnNulliPunktid.Click += KT_btnNulliPunktid_Click;

            KT_lblXPunktid = new Label { Name = "KT_lblXPunktid", Location = new Point(35, 505), Size = new Size(145, 34), TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 10F, FontStyle.Bold), ForeColor = Color.FromArgb(25, 95, 170), BackColor = Color.White, BorderStyle = BorderStyle.FixedSingle };
            KT_lblOPunktid = new Label { Name = "KT_lblOPunktid", Location = new Point(207, 505), Size = new Size(145, 34), TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 10F, FontStyle.Bold), ForeColor = Color.FromArgb(200, 80, 60), BackColor = Color.White, BorderStyle = BorderStyle.FixedSingle };
            KT_lblViigid = new Label { Name = "KT_lblViigid", Location = new Point(380, 505), Size = new Size(145, 34), TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 10F, FontStyle.Bold), ForeColor = Color.FromArgb(60, 120, 60), BackColor = Color.White, BorderStyle = BorderStyle.FixedSingle };

            Controls.AddRange(new Control[] { KT_lblPealkiri, KT_lblKord, KT_lblTulemus, KT_btnUusMang, KT_btnNulliPunktid, KT_lblXPunktid, KT_lblOPunktid, KT_lblViigid });
            KT_UusMang();
        }

        void KT_MuudaKaiguVarv()
        {
            KT_lblKord.ForeColor = KT_mangija == "X" ? Color.FromArgb(25, 95, 170) : Color.FromArgb(200, 80, 60);
        }

        void KT_Ruut_Click(object sender, EventArgs e)
        {
            if (KT_mangLabi) return;
            Button KT_btn = (Button)sender;

            if (KT_btn.Text != "")
            {
                MessageBox.Show("See ruut on juba valitud!", "Teade");
                return;
            }

            KT_btn.Text = KT_mangija;
            KT_lblTulemus.Text = "";
            KT_btn.ForeColor = KT_mangija == "X" ? Color.FromArgb(25, 95, 170) : Color.FromArgb(200, 80, 60);

            if (KT_KontrolliVoitu())
            {
                KT_mangLabi = true;
                KT_lblTulemus.Text = "Võitis mängija " + KT_mangija + "!";
                if (KT_mangija == "X") KT_xPunktid++;
                else KT_oPunktid++;
                KT_UuendaPunktid();
                KT_LukustaRuudud();
                return;
            }

            if (KT_KontrolliViiki())
            {
                KT_mangLabi = true;
                KT_viigid++;
                KT_lblTulemus.Text = "Mäng jäi viiki!";
                KT_UuendaPunktid();
                return;
            }

            KT_mangija = KT_mangija == "X" ? "O" : "X";
            KT_lblKord.Text = "Käik on mängija " + KT_mangija + " käes";
            KT_MuudaKaiguVarv();
        }

        bool KT_KontrolliVoitu()
        {
            int[,] KT_read = {
                {0,1,2}, {3,4,5}, {6,7,8},
                {0,3,6}, {1,4,7}, {2,5,8},
                {0,4,8}, {2,4,6}
            };

            for (int KT_i = 0; KT_i < 8; KT_i++)
            {
                int KT_a = KT_read[KT_i, 0];
                int KT_b = KT_read[KT_i, 1];
                int KT_c = KT_read[KT_i, 2];

                if (KT_nupud[KT_a].Text != "" &&
                    KT_nupud[KT_a].Text == KT_nupud[KT_b].Text &&
                    KT_nupud[KT_b].Text == KT_nupud[KT_c].Text)
                {
                    KT_nupud[KT_a].BackColor = Color.LightGreen;
                    KT_nupud[KT_b].BackColor = Color.LightGreen;
                    KT_nupud[KT_c].BackColor = Color.LightGreen;
                    return true;
                }
            }
            return false;
        }

        bool KT_KontrolliViiki()
        {
            foreach (Button KT_btn in KT_nupud)
                if (KT_btn.Text == "") return false;
            return true;
        }

        void KT_LukustaRuudud()
        {
            foreach (Button KT_btn in KT_nupud)
                KT_btn.Enabled = false;
        }

        void KT_UusMang()
        {
            KT_mangija = "X";
            KT_mangLabi = false;

            foreach (Button KT_btn in KT_nupud)
            {
                KT_btn.Text = "";
                KT_btn.Enabled = true;
                KT_btn.BackColor = Color.White;
                KT_btn.ForeColor = Color.Black;
                KT_btn.FlatAppearance.BorderColor = Color.Black;
            }

            KT_lblKord.Text = "Käik on mängija X käes";
            KT_MuudaKaiguVarv();
            KT_lblTulemus.Text = "Alusta mängu ruudule vajutamisega.";
            KT_UuendaPunktid();
        }

        void KT_UuendaPunktid()
        {
            KT_lblXPunktid.Text = "X punktid: " + KT_xPunktid;
            KT_lblOPunktid.Text = "O punktid: " + KT_oPunktid;
            KT_lblViigid.Text = "Viigid: " + KT_viigid;
        }

        void KT_btnNulliPunktid_Click(object sender, EventArgs e)
        {
            KT_xPunktid = 0;
            KT_oPunktid = 0;
            KT_viigid = 0;
            KT_UusMang();
        }
    }
}
