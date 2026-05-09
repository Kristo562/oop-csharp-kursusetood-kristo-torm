using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Torm_OOP_KT2_CSharp
{
    public class KT_Form1 : Form
    {
        readonly Random KT_rnd = new Random();
        int KT_katseteArv = 0;
        int KT_raha = 0;
        Label KT_lblRand, KT_lblKatse, KT_lblKirjeldus;
        Button KT_btnOk, KT_btnStart;
        PictureBox KT_picPilt, KT_pic1, KT_pic2, KT_pic3;

        public KT_Form1()
        {
            Text = "Kristo Torm OOP KT2 - C#";
            Name = "KT_Form1";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(640, 350);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            BackColor = Color.Gainsboro;
            Font = new Font("Segoe UI", 9F);

            Label KT_lblJuhis = new Label { Name = "KT_lblJuhis", Text = "Uuri, mitu korda teeme klõps ja saame 0 või 10.\nIga klõps = 1 EURO", Location = new Point(175, 15), Size = new Size(300, 45), BackColor = Color.LightYellow, BorderStyle = BorderStyle.FixedSingle, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 9F, FontStyle.Bold) };
            Label KT_lblRandTekst = new Label { Text = "Juhuslik arv", Location = new Point(145, 70), AutoSize = true };
            KT_lblRand = new Label { Name = "KT_lblRand", Location = new Point(140, 95), Size = new Size(90, 40), BorderStyle = BorderStyle.FixedSingle, BackColor = Color.White, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 14F, FontStyle.Bold) };
            KT_btnOk = new Button { Name = "KT_btnOk", Text = "OK", Location = new Point(250, 96), Size = new Size(60, 40) };
            Label KT_lblKatseTekst = new Label { Text = "Katse", Location = new Point(350, 70), AutoSize = true, ForeColor = Color.RoyalBlue };
            KT_lblKatse = new Label { Name = "KT_lblKatse", Location = new Point(340, 95), Size = new Size(80, 40), BorderStyle = BorderStyle.FixedSingle, BackColor = Color.White, ForeColor = Color.Red, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 12F, FontStyle.Bold) };
            KT_btnStart = new Button { Name = "KT_btnStart", Text = "ALUSTA MÄNG", Location = new Point(220, 150), Size = new Size(150, 35), Font = new Font("Segoe UI", 9F, FontStyle.Bold) };

            KT_pic1 = new PictureBox { Name = "KT_picPilt1", Location = new Point(95, 210), Size = new Size(52, 52), SizeMode = PictureBoxSizeMode.StretchImage, BorderStyle = BorderStyle.FixedSingle, Image = KT_LooKurbNagu() };
            KT_pic2 = new PictureBox { Name = "KT_picPilt2", Location = new Point(155, 210), Size = new Size(52, 52), SizeMode = PictureBoxSizeMode.StretchImage, BorderStyle = BorderStyle.FixedSingle, Image = KT_LooNaerunagu() };
            KT_pic3 = new PictureBox { Name = "KT_picPilt3", Location = new Point(215, 210), Size = new Size(52, 52), SizeMode = PictureBoxSizeMode.StretchImage, BorderStyle = BorderStyle.FixedSingle, Image = KT_LooTyhiPilt() };
            KT_picPilt = new PictureBox { Name = "KT_picPilt", Location = new Point(380, 145), Size = new Size(120, 85), SizeMode = PictureBoxSizeMode.StretchImage, BorderStyle = BorderStyle.FixedSingle };
            KT_lblKirjeldus = new Label { Name = "KT_lblKirjeldus", Location = new Point(360, 260), Size = new Size(220, 45), BackColor = Color.Green, ForeColor = Color.White, BorderStyle = BorderStyle.FixedSingle, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 9F, FontStyle.Bold) };

            KT_btnOk.Click += KT_btnOk_Click;
            KT_btnStart.Click += KT_btnStart_Click;
            Controls.AddRange(new Control[] { KT_lblJuhis, KT_lblRandTekst, KT_lblRand, KT_btnOk, KT_lblKatseTekst, KT_lblKatse, KT_btnStart, KT_picPilt, KT_pic1, KT_pic2, KT_pic3, KT_lblKirjeldus });
            KT_AlustaAlgseis();
        }

        void KT_AlustaAlgseis()
        {
            KT_katseteArv = 0;
            KT_raha = 0;
            KT_lblRand.Text = "";
            KT_lblKatse.Text = "0";
            KT_lblKirjeldus.Text = "";
            KT_picPilt.Image = KT_pic3.Image;
            KT_btnOk.Enabled = false;
            KT_btnStart.Enabled = true;
        }

        void KT_btnStart_Click(object sender, EventArgs e)
        {
            KT_katseteArv = 0;
            KT_raha = 0;
            KT_lblRand.Text = "";
            KT_lblKatse.Text = "0";
            KT_lblKirjeldus.Text = "";
            KT_picPilt.Image = KT_pic3.Image;
            KT_btnOk.Enabled = true;
            KT_btnStart.Enabled = false;
        }

        void KT_btnOk_Click(object sender, EventArgs e)
        {
            int KT_arv = KT_rnd.Next(0, 11);
            KT_lblRand.Text = KT_arv.ToString();
            KT_katseteArv++;
            KT_raha++;
            KT_lblKatse.Text = KT_katseteArv.ToString();

            if (KT_arv == 0 || KT_arv == 10)
            {
                KT_btnOk.Enabled = false;
                KT_btnStart.Enabled = true;

                if (KT_katseteArv < 10)
                {
                    KT_picPilt.Image = KT_pic2.Image;
                    KT_lblKirjeldus.Text = "Katse VÄHEM kui kümme.\nMaksa " + KT_raha + " eurot.";
                }
                else if (KT_katseteArv > 10)
                {
                    KT_picPilt.Image = KT_pic1.Image;
                    KT_lblKirjeldus.Text = "Katse ROHKEM kui kümme.\nMaksa " + KT_raha + " eurot.";
                }
                else
                {
                    KT_picPilt.Image = KT_pic2.Image;
                    KT_lblKirjeldus.Text = "Katse VÕRDNE kümme.\nMaksa " + KT_raha + " eurot.";
                }
            }
        }

        Bitmap KT_LooNaerunagu()
        {
            Bitmap KT_bmp = new Bitmap(100, 100);
            using (Graphics KT_g = Graphics.FromImage(KT_bmp))
            using (Pen KT_p = new Pen(Color.Black, 3))
            {
                KT_g.SmoothingMode = SmoothingMode.AntiAlias;
                KT_g.Clear(Color.White);
                KT_g.FillEllipse(Brushes.Yellow, 8, 8, 84, 84);
                KT_g.DrawEllipse(KT_p, 8, 8, 84, 84);
                KT_g.FillEllipse(Brushes.Black, 28, 32, 10, 10);
                KT_g.FillEllipse(Brushes.Black, 62, 32, 10, 10);
                KT_g.DrawArc(KT_p, 28, 42, 42, 28, 20, 140);
            }
            return KT_bmp;
        }

        Bitmap KT_LooKurbNagu()
        {
            Bitmap KT_bmp = new Bitmap(100, 100);
            using (Graphics KT_g = Graphics.FromImage(KT_bmp))
            using (Pen KT_p = new Pen(Color.Black, 3))
            {
                KT_g.SmoothingMode = SmoothingMode.AntiAlias;
                KT_g.Clear(Color.White);
                KT_g.FillEllipse(Brushes.Yellow, 8, 8, 84, 84);
                KT_g.DrawEllipse(KT_p, 8, 8, 84, 84);
                KT_g.FillEllipse(Brushes.Black, 28, 32, 10, 10);
                KT_g.FillEllipse(Brushes.Black, 62, 32, 10, 10);
                KT_g.DrawArc(KT_p, 28, 58, 42, 20, 200, 140);
            }
            return KT_bmp;
        }

        Bitmap KT_LooTyhiPilt()
        {
            Bitmap KT_bmp = new Bitmap(120, 85);
            using (Graphics KT_g = Graphics.FromImage(KT_bmp))
            {
                KT_g.Clear(Color.WhiteSmoke);
                KT_g.DrawRectangle(Pens.Gray, 1, 1, 116, 81);
            }
            return KT_bmp;
        }
    }
}
