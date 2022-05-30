using System;
using System.Drawing;
using System.Windows.Forms;

namespace BridgeSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int x_rear = 0;
        float length, w_front, w_rear, Fw = 0, F_left = 0, F_right = 0, r_Fw;
        int[] loadings = new int[1000];
        int[] shearForces = new int[1000];
        int[] bendingMoments = new int[1000];

        Pen whitePen = new Pen(Brushes.White);
        Pen yellowPen = new Pen(Brushes.Yellow);
        Pen redPen = new Pen(Brushes.Red, 5);
        Font arialFont = new Font("Arial", 12);
        Bitmap result = new Bitmap(1000, 900);

        private void DrawBackground_all()
        {
            Graphics GFX = Graphics.FromImage(result);
            GFX.FillRectangle(Brushes.Black, 0, 0, 1000, 900);
            GFX.DrawLine(whitePen, 0, 150, 1000, 150);
            GFX.DrawLine(whitePen, 0, 450, 1000, 450);
            GFX.DrawLine(yellowPen, 0, 300, 1000, 300);
            GFX.DrawLine(yellowPen, 0, 600, 1000, 600);
            GFX.DrawString("w-x graph", arialFont, Brushes.Yellow, new Point(10, 10));
            GFX.DrawString("V-x graph", arialFont, Brushes.Yellow, new Point(10, 310));
            GFX.DrawString("M-x graph", arialFont, Brushes.Yellow, new Point(10, 610));
            
            pictureBox1.Image = result;
        }

        private void DrawBackground_single(string kind)
        {
            Graphics GFX = Graphics.FromImage(result);
            GFX.FillRectangle(Brushes.Black, 0, 0, 1000, 900);
            GFX.DrawLine(whitePen, 0, 450, 1000, 450);
            GFX.DrawString($"{kind}-x graph", arialFont, Brushes.Yellow, new Point(10, 10));

            pictureBox1.Image = result;
        }

        private void CalculateForce()
        {
            r_Fw = (w_rear * (2 * x_rear + length * 33) + (w_front - w_rear) * (x_rear + 2 * 11 * length)) / (w_rear + w_front);
            F_right = r_Fw * Fw / 1000;
            F_left = Fw - F_right;
        }

        private void SeeAll()
        {
            DrawBackground_all();

            Fw = F_left = F_right = 0;
            loadings = new int[1000];
            shearForces = new int[1000];
            bendingMoments = new int[1000];

            // 1000 pixels for 30 meters
            for (int i = x_rear; i < 33 * length + x_rear; ++i)
            {
                loadings[i] = (int)((w_rear + (i - x_rear) / (length * 33) * (w_front - w_rear)) * 7);

                if (150 - loadings[i] < 300 && 150 - loadings[i] > 0)
                {
                    result.SetPixel(i, 150 - loadings[i], Color.LightPink);
                }

                Fw += loadings[i];
            }

            CalculateForce();
            
            Graphics GFX = Graphics.FromImage(result);
            GFX.DrawLine(redPen, 2, 150, 2, 150 - F_left / 150);
            GFX.DrawLine(redPen, 998, 150, 998, 150 - F_right / 150);
            GFX.DrawLine(redPen, 2, 450, 2, 450 - F_left / 150);
            GFX.DrawLine(redPen, 998, 450, 998, 450 - F_right / 150);
            GFX.DrawLine(redPen, 2, 899, 2, 899 - F_left / 75);
            GFX.DrawLine(redPen, 998, 899, 998, 899 - F_right / 75);

            for (int i = 0; i < 1000; ++i)
            {
                shearForces[i] = (int)F_left;

                // integration
                for (int j = 0; j < i; ++j)
                {
                    shearForces[i] -= loadings[j];
                }

                shearForces[i] /= 150;

                if (450 - shearForces[i] < 600 && 450 - bendingMoments[i] > 300)
                {
                    result.SetPixel(i, 450 - shearForces[i], Color.LightPink);
                }
            }

            for (int i = 0; i < 1000; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    bendingMoments[i] += shearForces[j];
                }
                
                bendingMoments[i] /= 100;

                if (bendingMoments[i] > 0 && bendingMoments[i] < 300)
                {
                    result.SetPixel(i, 899 - bendingMoments[i], Color.LightPink);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_alarm.Text = "Enter the input data first!";
            gb_options.Enabled = false;
            bt_stop.Enabled = false;
            bt_continue.Enabled = false;
            DrawBackground_all();
            timer.Enabled = false;
            timer.Interval = 100;
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            x_rear = 0;
            
            gb_options.Enabled = false;

            try
            {
                length  = float.Parse(tb_length.Text);
                w_front = float.Parse(tb_wf.Text);
                w_rear  = float.Parse(tb_wr.Text);

                if (length < 4 || length > 8 || w_front < 0 || w_front > 20 || w_rear < 0 || w_rear > 20)
                {
                    throw new Exception();
                }

                timer.Enabled      = true;
                bt_stop.Enabled    = true;
                gb_options.Enabled = true;
                rb_all.Checked     = true;
                label_alarm.Text = "Select the graph(s) to be observed!";
            }
            catch
            {
                label_alarm.Text = "Invalid input(s)!";
            }
        }
        
        private void bt_change_Click(object sender, EventArgs e)
        {
            x_rear = 0;
            timer.Enabled       = true;
            bt_stop.Enabled     = true;
            bt_continue.Enabled = false;
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            bt_stop.Enabled     = false;
            timer.Enabled       = false;
            bt_continue.Enabled = true;
        }

        private void bt_continue_Click(object sender, EventArgs e)
        {
            bt_continue.Enabled = false;
            timer.Enabled       = true;
            bt_stop.Enabled     = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (x_rear + 10 + length * 33 >= 999)
            {
                timer.Enabled = false;
                gb_options.Enabled = true;
            }
            else
            {
                x_rear += 10;

                if (rb_all.Checked)
                {
                    SeeAll();
                }
                else if (rb_w.Checked)
                {
                    DrawBackground_single("w");
                    loadings = new int[1000];

                    for (int i = x_rear; i < 33 * length + x_rear; ++i)
                    {
                        loadings[i] = (int)((w_rear + ((i - x_rear) / (length * 33)) * (w_front - w_rear)) * 22);
                        if ((450 - loadings[i] < 900) && (450 - loadings[i] > 0))
                        {
                            result.SetPixel(i, (450 - loadings[i]), Color.LightPink);
                        }
                    }
                }
                else if (rb_V.Checked)
                {
                    DrawBackground_single("V");
                    loadings = new int[1000];
                    shearForces = new int[1000];

                    for (int i = x_rear; i < 33 * length + x_rear; ++i)
                    {
                        loadings[i] = (int)((w_rear + ((i - x_rear) / (length * 33)) * (w_front - w_rear)) * 7);
                    }

                    CalculateForce();
                    Graphics GFX = Graphics.FromImage(result);
                    GFX.DrawLine(redPen, 2, 450, 2, 450 - F_left / 50);
                    GFX.DrawLine(redPen, 998, 450, 998, 450 - F_right / 50);

                    for (int i = 0; i < 1000; ++i)
                    {
                        shearForces[i] = (int)F_left;

                        for (int j = 0; j < i; ++j)
                        {
                            shearForces[i] -= loadings[j];
                        }

                        shearForces[i] /= 50;

                        if (450 - shearForces[i] < 900 && 450 - shearForces[i] > 0)
                        {
                            result.SetPixel(i, 450 - shearForces[i], Color.LightPink);
                        }
                    }
                }
                else if (rb_M.Checked)
                {
                    DrawBackground_single("M");
                    loadings = new int[1000];
                    shearForces = new int[1000];
                    bendingMoments = new int[1000];

                    for (int i = x_rear; i < 33 * length + x_rear; ++i)
                    {
                        loadings[i] = (int)((w_rear + ((i - x_rear) / (length * 33)) * (w_front - w_rear)) * 7);
                    }

                    CalculateForce();
                    Graphics GFX = Graphics.FromImage(result);
                    GFX.DrawLine(redPen, 2, 450, 2, 450 - F_left / 50);
                    GFX.DrawLine(redPen, 998, 450, 998, 450 - F_right / 50);

                    for (int i = 0; i < 1000; ++i)
                    {
                        shearForces[i] = (int)F_left;

                        for (int j = 0; j < i; ++j)
                        {
                            shearForces[i] -= loadings[j];
                        }

                        shearForces[i] /= 150;
                    }

                    for (int i = 0; i < 1000; ++i)
                    {
                        for (int j = 0; j < i; ++j)
                        {
                            bendingMoments[i] += shearForces[j];
                        }

                        bendingMoments[i] /= 66;

                        if (450 - bendingMoments[i] < 900 && 450 - bendingMoments[i] > 0)
                        {
                            result.SetPixel(i, 450 - bendingMoments[i], Color.LightPink);
                        }
                    }
                }
            }
        }
    }
}
