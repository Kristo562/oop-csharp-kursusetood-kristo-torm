using System;
using System.Drawing;
using System.Windows.Forms;

namespace Torm_OOP_KT3_CSharp
{
    public class KT_Form1 : Form
    {
        readonly Random KT_random = new Random();
        int KT_jukuPunktid, KT_peeterPunktid;
        Label KT_lblJukuPunktid, KT_lblPeeterPunktid, KT_lblJukuTaring1, KT_lblJukuTaring2, KT_lblPeeterTaring1, KT_lblPeeterTaring2, KT_lblTulemus;
        Button KT_btnJuku, KT_btnPeeter, KT_btnAlusta;

        public KT_Form1()
        {
            Text = "Täring - C#";
            Name = "KT_Form1";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(620, 330);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            BackColor = Color.WhiteSmoke;
            Font = new Font("Segoe UI", 9F);

            Label KT_lblJukuPealkiri = new Label { Text = "Esimene mängija", Location = new Point(35, 20), AutoSize = true, ForeColor = Color.DarkRed, Font = new Font("Segoe UI", 9F, FontStyle.Bold) };
            Label KT_lblJukuNimi = new Label { Text = "Juku", Location = new Point(75, 43), AutoSize = true, ForeColor = Color.DarkRed, Font = new Font("Segoe UI", 9F, FontStyle.Bold) };
            Label KT_lblJukuPunktidTekst = new Label { Text = "Punktid", Location = new Point(65, 66), AutoSize = true, ForeColor = Color.Green, Font = new Font("Segoe UI", 9F, FontStyle.Bold) };
            KT_lblJukuPunktid = new Label { Name = "KT_lblJukuPunktid", Location = new Point(35, 95), Size = new Size(95, 25), BorderStyle = BorderStyle.FixedSingle, BackColor = Color.White, TextAlign = ContentAlignment.MiddleCenter, ForeColor = Color.Green };
            KT_lblJukuTaring1 = new Label { Name = "KT_lblJukuTaring1", Location = new Point(45, 135), Size = new Size(35, 35), BorderStyle = BorderStyle.FixedSingle, BackColor = Color.White, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 10F, FontStyle.Bold), ForeColor = Color.DarkRed };
            KT_lblJukuTaring2 = new Label { Name = "KT_lblJukuTaring2", Location = new Point(90, 135), Size = new Size(35, 35), BorderStyle = BorderStyle.FixedSingle, BackColor = Color.White, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 10F, FontStyle.Bold), ForeColor = Color.DarkRed };
            KT_btnJuku = new Button { Name = "KT_btnJuku", Text = "Mängib Juku", Location = new Point(40, 190), Size = new Size(105, 30), BackColor = Color.SteelBlue, ForeColor = Color.White };
            KT_btnJuku.Click += KT_btnJuku_Click;

            Label KT_lblPeeterPealkiri = new Label { Text = "Teine mängija", Location = new Point(385, 20), AutoSize = true, ForeColor = Color.DarkRed, Font = new Font("Segoe UI", 9F, FontStyle.Bold) };
            Label KT_lblPeeterNimi = new Label { Text = "Peeter", Location = new Point(425, 43), AutoSize = true, ForeColor = Color.DarkRed, Font = new Font("Segoe UI", 9F, FontStyle.Bold) };
            Label KT_lblPeeterPunktidTekst = new Label { Text = "Punktid", Location = new Point(415, 66), AutoSize = true, ForeColor = Color.Green, Font = new Font("Segoe UI", 9F, FontStyle.Bold) };
            KT_lblPeeterPunktid = new Label { Name = "KT_lblPeeterPunktid", Location = new Point(385, 95), Size = new Size(95, 25), BorderStyle = BorderStyle.FixedSingle, BackColor = Color.White, TextAlign = ContentAlignment.MiddleCenter, ForeColor = Color.Green };
            KT_lblPeeterTaring1 = new Label { Name = "KT_lblPeeterTaring1", Location = new Point(395, 135), Size = new Size(35, 35), BorderStyle = BorderStyle.FixedSingle, BackColor = Color.White, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 10F, FontStyle.Bold), ForeColor = Color.DarkRed };
            KT_lblPeeterTaring2 = new Label { Name = "KT_lblPeeterTaring2", Location = new Point(440, 135), Size = new Size(35, 35), BorderStyle = BorderStyle.FixedSingle, BackColor = Color.White, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 10F, FontStyle.Bold), ForeColor = Color.DarkRed };
            KT_btnPeeter = new Button { Name = "KT_btnPeeter", Text = "Mängib Peeter", Location = new Point(385, 190), Size = new Size(115, 30), BackColor = Color.SteelBlue, ForeColor = Color.White };
            KT_btnPeeter.Click += KT_btnPeeter_Click;

            KT_btnAlusta = new Button { Name = "KT_btnAlusta", Text = "Alusta uut mängu", Location = new Point(238, 192), Size = new Size(130, 30), BackColor = Color.Green, ForeColor = Color.White };
            KT_btnAlusta.Click += KT_btnAlusta_Click;

            Label KT_lblTulemusTekst = new Label { Text = "Tulemus", Location = new Point(70, 255), AutoSize = true, ForeColor = Color.DarkRed, Font = new Font("Segoe UI", 9F, FontStyle.Bold) };
            KT_lblTulemus = new Label { Name = "KT_lblTulemus", Location = new Point(160, 250), Size = new Size(260, 28), BorderStyle = BorderStyle.FixedSingle, BackColor = Color.White, TextAlign = ContentAlignment.MiddleCenter, ForeColor = Color.DarkRed };

            Controls.AddRange(new Control[] { KT_lblJukuPealkiri, KT_lblJukuNimi, KT_lblJukuPunktidTekst, KT_lblJukuPunktid, KT_lblJukuTaring1, KT_lblJukuTaring2, KT_btnJuku, KT_lblPeeterPealkiri, KT_lblPeeterNimi, KT_lblPeeterPunktidTekst, KT_lblPeeterPunktid, KT_lblPeeterTaring1, KT_lblPeeterTaring2, KT_btnPeeter, KT_btnAlusta, KT_lblTulemusTekst, KT_lblTulemus });
            KT_Algseis();
        }

        void KT_Algseis()
        {
            KT_jukuPunktid = 0;
            KT_peeterPunktid = 0;
            KT_lblJukuPunktid.Text = "";
            KT_lblPeeterPunktid.Text = "";
            KT_lblJukuTaring1.Text = "";
            KT_lblJukuTaring2.Text = "";
            KT_lblPeeterTaring1.Text = "";
            KT_lblPeeterTaring2.Text = "";
            KT_lblTulemus.Text = "";
            KT_btnAlusta.Enabled = true;
            KT_btnJuku.Enabled = false;
            KT_btnPeeter.Enabled = false;
        }

        void KT_btnAlusta_Click(object sender, EventArgs e)
        {
            KT_Algseis();
            KT_btnAlusta.Enabled = false;
            KT_btnJuku.Enabled = true;
        }

        void KT_btnJuku_Click(object sender, EventArgs e)
        {
            int KT_t1 = KT_random.Next(1, 7);
            int KT_t2 = KT_random.Next(1, 7);
            KT_jukuPunktid = KT_t1 + KT_t2;
            KT_lblJukuTaring1.Text = KT_t1.ToString();
            KT_lblJukuTaring2.Text = KT_t2.ToString();
            KT_lblJukuPunktid.Text = KT_jukuPunktid.ToString();
            KT_btnJuku.Enabled = false;
            KT_btnPeeter.Enabled = true;
        }

        void KT_btnPeeter_Click(object sender, EventArgs e)
        {
            int KT_t1 = KT_random.Next(1, 7);
            int KT_t2 = KT_random.Next(1, 7);
            KT_peeterPunktid = KT_t1 + KT_t2;
            KT_lblPeeterTaring1.Text = KT_t1.ToString();
            KT_lblPeeterTaring2.Text = KT_t2.ToString();
            KT_lblPeeterPunktid.Text = KT_peeterPunktid.ToString();

            if (KT_jukuPunktid > KT_peeterPunktid) KT_lblTulemus.Text = "Võitis Juku";
            else if (KT_peeterPunktid > KT_jukuPunktid) KT_lblTulemus.Text = "Võitis Peeter";
            else KT_lblTulemus.Text = "Viik";

            KT_btnPeeter.Enabled = false;
            KT_btnAlusta.Enabled = true;
        }
    }
}
