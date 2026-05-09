using System;
using System.Drawing;
using System.Windows.Forms;

namespace Torm_OOP_KT1_CSharp
{
    public class KT_Form1 : Form
    {
        TextBox KT_txtNimi, KT_txtArv1, KT_txtArv2;
        Label KT_lblTervitus, KT_lblTulemus;
        RadioButton KT_rdbPunane, KT_rdbSinine;
        CheckBox KT_chkLiida;

        public KT_Form1()
        {
            Text = "Kristo Torm OOP KT1 - C#";
            Name = "KT_Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(620, 420);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            GroupBox KT_grpTervitus = new GroupBox { Name = "KT_grpTervitus", Text = "Tervitus", Location = new Point(20, 20), Size = new Size(270, 150) };
            Label KT_lblNimi = new Label { Name = "KT_lblNimi", Text = "Sisesta nimi:", Location = new Point(15, 30), AutoSize = true };
            KT_txtNimi = new TextBox { Name = "KT_txtNimi", Location = new Point(105, 27), Size = new Size(140, 23) };
            Button KT_btnTervitus = new Button { Name = "KT_btnTervitus", Text = "Tervitus", Location = new Point(18, 65), Size = new Size(90, 30) };
            Button KT_btnValju = new Button { Name = "KT_btnValju", Text = "Välju", Location = new Point(155, 65), Size = new Size(90, 30) };
            KT_lblTervitus = new Label { Name = "KT_lblTervitus", Text = "Tervitus ilmub siia", Location = new Point(18, 110), Size = new Size(230, 25), BorderStyle = BorderStyle.FixedSingle, TextAlign = ContentAlignment.MiddleCenter };
            KT_btnTervitus.Click += KT_btnTervitus_Click;
            KT_btnValju.Click += (s, e) => Close();
            KT_grpTervitus.Controls.AddRange(new Control[] { KT_lblNimi, KT_txtNimi, KT_btnTervitus, KT_btnValju, KT_lblTervitus });

            GroupBox KT_grpVarv = new GroupBox { Name = "KT_grpVarv", Text = "Värvi valimine", Location = new Point(315, 20), Size = new Size(270, 150) };
            KT_rdbPunane = new RadioButton { Name = "KT_rdbPunane", Text = "Punane", Location = new Point(20, 30), AutoSize = true };
            KT_rdbSinine = new RadioButton { Name = "KT_rdbSinine", Text = "Sinine", Location = new Point(20, 60), AutoSize = true };
            Button KT_btnVarvida = new Button { Name = "KT_btnVarvida", Text = "Värvida", Location = new Point(150, 30), Size = new Size(90, 30) };
            Button KT_btnTyhjista = new Button { Name = "KT_btnTyhjista", Text = "Tühista", Location = new Point(150, 75), Size = new Size(90, 30) };
            KT_btnVarvida.Click += KT_btnVarvida_Click;
            KT_btnTyhjista.Click += KT_btnTyhjista_Click;
            KT_grpVarv.Controls.AddRange(new Control[] { KT_rdbPunane, KT_rdbSinine, KT_btnVarvida, KT_btnTyhjista });

            GroupBox KT_grpMatemaatika = new GroupBox { Name = "KT_grpMatemaatika", Text = "Lihtne matemaatika", Location = new Point(20, 195), Size = new Size(565, 160) };
            Label KT_lblArv1 = new Label { Name = "KT_lblArv1", Text = "Esimene arv:", Location = new Point(20, 35), AutoSize = true };
            KT_txtArv1 = new TextBox { Name = "KT_txtArv1", Location = new Point(115, 32), Size = new Size(100, 23) };
            Label KT_lblArv2 = new Label { Name = "KT_lblArv2", Text = "Teine arv:", Location = new Point(20, 72), AutoSize = true };
            KT_txtArv2 = new TextBox { Name = "KT_txtArv2", Location = new Point(115, 69), Size = new Size(100, 23) };
            KT_chkLiida = new CheckBox { Name = "KT_chkLiida", Text = "Liida arvud", Location = new Point(250, 34), AutoSize = true };
            Button KT_btnArvesta = new Button { Name = "KT_btnArvesta", Text = "Arvesta", Location = new Point(250, 70), Size = new Size(95, 30) };
            Label KT_lblTulemusTekst = new Label { Name = "KT_lblTulemusTekst", Text = "Tulemus:", Location = new Point(385, 38), AutoSize = true };
            KT_lblTulemus = new Label { Name = "KT_lblTulemus", Location = new Point(385, 68), Size = new Size(140, 30), BorderStyle = BorderStyle.FixedSingle, TextAlign = ContentAlignment.MiddleCenter };
            KT_btnArvesta.Click += KT_btnArvesta_Click;
            KT_grpMatemaatika.Controls.AddRange(new Control[] { KT_lblArv1, KT_txtArv1, KT_lblArv2, KT_txtArv2, KT_chkLiida, KT_btnArvesta, KT_lblTulemusTekst, KT_lblTulemus });

            Controls.AddRange(new Control[] { KT_grpTervitus, KT_grpVarv, KT_grpMatemaatika });
        }

        void KT_btnTervitus_Click(object sender, EventArgs e)
        {
            string KT_nimi = KT_txtNimi.Text.Trim();
            KT_lblTervitus.Text = KT_nimi == "" ? "Palun sisesta nimi!" : "Tere, " + KT_nimi + "!";
        }

        void KT_btnVarvida_Click(object sender, EventArgs e)
        {
            if (KT_rdbPunane.Checked) BackColor = Color.LightCoral;
            else if (KT_rdbSinine.Checked) BackColor = Color.LightBlue;
            else MessageBox.Show("Vali enne värv!", "Teade");
        }

        void KT_btnTyhjista_Click(object sender, EventArgs e)
        {
            BackColor = SystemColors.Control;
            KT_rdbPunane.Checked = false;
            KT_rdbSinine.Checked = false;
            KT_txtNimi.Clear();
            KT_txtArv1.Clear();
            KT_txtArv2.Clear();
            KT_chkLiida.Checked = false;
            KT_lblTervitus.Text = "Tervitus ilmub siia";
            KT_lblTulemus.Text = "";
        }

        void KT_btnArvesta_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(KT_txtArv1.Text, out double KT_arv1) || !double.TryParse(KT_txtArv2.Text, out double KT_arv2))
            {
                MessageBox.Show("Sisesta mõlemasse kasti arv!", "Viga");
                return;
            }
            KT_lblTulemus.Text = KT_chkLiida.Checked ? (KT_arv1 + KT_arv2).ToString() : "Märgi Liida";
        }
    }
}
