using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrnaRupa
{
    public partial class CrnaRupa : Form
    {
        private Random random = new Random();
        private int[] locX, locY;
        private int i;
        private int vrijemeStvaranjaKuglica;
        private Control[] kuglica = new PictureBox[100];
        int promenljivaBrzina;
        int br = 0;
        int brPropustnihKuglica = 0;
        int brSvihKuglica = 0;
        public CrnaRupa( int vrijemeStvaranjaKuglica)
        {
            InitializeComponent();
            Restart();

            this.vrijemeStvaranjaKuglica = vrijemeStvaranjaKuglica;
        }
        private void Restart()
        {
            panIgra.Location = new Point(10, 45);
            this.Height = panIgra.Location.Y + panIgra.Height + 39 + 10;
            this.Width = panIgra.Location.X * 2 + panIgra.Width + 18;

            btnStart.ForeColor = Color.Red;
            btnStart.Enabled = true;
            btnPause.Enabled = false;
            btnStop.Enabled = false;

            brPropustnihKuglica = 0;
            lblBrojPropustenihKuglica.Text = brPropustnihKuglica.ToString();

            foreach(Control x in panIgra.Controls)
            {
                if((string)x.Tag == "kuglice")
                {
                    panIgra.Controls.Remove(x);
                }
            }

            CrtanjeRupe();
        }
        private void CrtanjeRupe()
        {
            pbRupa.Location = new Point(panIgra.Width/2 - pbRupa.Width/2, panIgra.Height / 2 - pbRupa.Height / 2);

            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pbRupa.Width, pbRupa.Height);
            Region rg = new Region(gp);
            pbRupa.Region = rg;

            pbSkrivenaRupa.Width = 70;
            pbSkrivenaRupa.Height = 70;
            pbSkrivenaRupa.Location = new Point(panIgra.Width / 2 - pbSkrivenaRupa.Width / 2, panIgra.Height / 2 - pbSkrivenaRupa.Height / 2);

            panIgra.Controls.Add(pbSkrivenaRupa);
        }
        private void CrtanjeKuglice()
        {
            kuglica[i] = new PictureBox
            {
                Name = "Kuglica" + i,
                Tag = "kuglice",
                Width = 25,
                Height = 25,
                BackColor = Color.DarkCyan
            };
            kuglica[i].Click += new EventHandler(Kuglica_Click);
            locX = new int[] { 0, panIgra.Width - kuglica[i].Width };
            locY = new int[] { 0, panIgra.Height - kuglica[i].Height };
            kuglica[i].Location = new Point(locX[random.Next(locX.Length)], locY[random.Next(locY.Length)]);

            panIgra.Controls.Add(kuglica[i]);
            
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, kuglica[i].Width, kuglica[i].Height);
            Region rg = new Region(gp);
            kuglica[i].Region = rg;

            i++;
        }
        private void Kuglica_Click(object sender, EventArgs e)
        {
            foreach (Control x in panIgra.Controls)
            {
                if (x.Capture == true)
                {
                    panIgra.Controls.Remove(x);
                }
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnPause.ForeColor = Color.Red;
            btnStop.ForeColor = Color.Red;
            btnStart.Enabled = false;
            btnPause.Enabled = true;
            btnStop.Enabled = true;
            
            TimerIgra.Start();
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            btnStart.ForeColor = Color.Red;
            btnStop.ForeColor = Color.Red;
            btnStart.Enabled = true;
            btnPause.Enabled = false;
            btnStop.Enabled = true;

            TimerIgra.Stop();
            panIgra.Enabled = false;
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.ForeColor = Color.Red;
            btnStart.Enabled = true;
            btnPause.Enabled = false;
            btnStop.Enabled = false;

            TimerIgra.Stop();
            MessageBox.Show("Procentualno je uhvaćeno: " + Math.Round((float)(brSvihKuglica - brPropustnihKuglica) / brSvihKuglica * 100) + " % kuglica!");
            this.Close();
            Restart();
        }
        private void TimerIgra_Tick(object sender, EventArgs e)
        {
            br++;
            if(br == 25 * vrijemeStvaranjaKuglica)
            {
                br = 0;
                CrtanjeKuglice();
                brSvihKuglica++;
            }
            foreach (Control x in panIgra.Controls)
            {
                if ((string)x.Tag == "kuglice")
                {
                    promenljivaBrzina = random.Next(3,10);
                    if(x.Location.X < pbSkrivenaRupa.Location.X + pbSkrivenaRupa.Width / 2)
                    {
                        x.Left += promenljivaBrzina;
                    }
                    else
                    {
                        x.Left -= promenljivaBrzina;
                    }
                    if (x.Location.Y < pbSkrivenaRupa.Location.Y + pbSkrivenaRupa.Height / 2)
                    {
                        x.Top += promenljivaBrzina;
                    }
                    else
                    {
                        x.Top -= promenljivaBrzina;
                    }
                    if (x.Bounds.IntersectsWith(pbSkrivenaRupa.Bounds) && x.Visible == true)
                    {
                        panIgra.Controls.Remove(x);
                        lblBrojPropustenihKuglica.Text = (++brPropustnihKuglica).ToString();
                    }
                }
            }
        }
    }
}
