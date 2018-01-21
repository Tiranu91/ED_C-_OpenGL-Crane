using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoOpenGLBasicsCS
{
    public partial class GUI : Form, Observer

    {
        TView oglView;

        public GUI()
        {
            InitializeComponent();
            oglView = new TView();

            oglView.Dock = DockStyle.Fill;
            panel.Controls.Add(oglView);

            oglView.register(this);

            panel.Focus();
        }

        //drehen
        private void trb_drehen_Scroll(object sender, EventArgs e)
        {
            oglView.changeVal(1, trb_drehen.Value);
        }

        //auslegen
        private void trb_auslegen_Scroll(object sender, EventArgs e)
        {
            oglView.changeVal(2, trb_auslegen.Value);
        }

        //heben/senken
        private void trb_heben_Scroll(object sender, EventArgs e)
        {
            oglView.changeVal(3, trb_heben.Value);
        }

        public void update()
        {
            //Instanz von TKran aufrufen
            TKran kran_config = TKran.getInstance();
            
            //Anzeige der Krankonfiguration aktualisieren
            lbl_drehung.Text = kran_config.TargetAngle.ToString();
            lbl_ausleger.Text = kran_config.TargetArmLength.ToString();
            lbl_seil.Text = kran_config.TargetRopeLength.ToString();

            //Anzeige der Abrissbirnenposition aktualisieren
            lbl_x.Text = kran_config.PositionX.ToString();
            lbl_y.Text = kran_config.PositionY.ToString();
            lbl_z.Text = kran_config.PositionZ.ToString();

            //tb_x.Text = kran_config.PositionX.ToString();
            //tb_y.Text = kran_config.PositionY.ToString();
            //tb_z.Text = kran_config.PositionZ.ToString();
        }

        private void btn_bewegen_Click(object sender, EventArgs e)
        {
            TKran kran_config = TKran.getInstance();

            double[] bla = { kran_config.PositionX, kran_config.PositionY, kran_config.PositionZ };


            //kran_config.PositionX = Double.Parse(tb_x.Text);
            //MessageBox.Show(kran_config.PositionX.ToString());
            //kran_config.PositionY = Double.Parse(tb_y.Text);
            //MessageBox.Show(kran_config.PositionY.ToString());
            //kran_config.PositionZ = Double.Parse(tb_z.Text);
            //MessageBox.Show(kran_config.PositionZ.ToString());

            //double[] blub = { kran_config.PositionX, kran_config.PositionY, kran_config.PositionZ };
            double[] blub = { Double.Parse(tb_x.Text), Double.Parse(tb_y.Text), Double.Parse(tb_z.Text) };

            if (bla[0] == blub[0] && bla[1] == blub[1] && bla[2] == blub[2])
            {
                return;
            }

            if (blub[0] < 0 || blub[0] > 1.9 || blub[1] < 0 || blub[1] > 1.9 || blub[2] < 0.3 || blub[2] > 2.8) //Check value range
                return;

            //Heben
            trb_heben.Value = Convert.ToInt32((3 - blub[2]) * 10);


            trb_auslegen.Value = Convert.ToInt32(TMatrix.VektorLaenge(new double[] { blub[0], blub[1] }) * 10);

            double angle = TMatrix.VectorWinkel(bla, blub);

            if (TMatrix.Quadrant(bla) == 1 && TMatrix.Quadrant(blub) == 4)
            {
                angle -= TMatrix.VectorWinkel(bla, new double[] { 5, 0, 0 });
                trb_drehen.Value = 360 - Convert.ToInt32(angle);
            }
            else if (TMatrix.Quadrant(bla) == 4 && TMatrix.Quadrant(blub) == 1)
            {
                angle -= TMatrix.VectorWinkel(bla, new double[] { 5, 0, 0 });
                trb_drehen.Value = Convert.ToInt32(angle);
            }
            else
            {
                if (TMatrix.RotationDirection(blub, bla) == 1)
                {
                    trb_drehen.Value += Convert.ToInt32(angle);
                }
                else if (TMatrix.RotationDirection(blub, bla) == -1)
                {
                    trb_drehen.Value -= Convert.ToInt32(angle);
                }
            }

            /*
            if (trb_drehen.Value > 360 || trb_drehen.Value < 0)
            {
                MessageBox.Show("Ungültige Werte!");
                return;
            }
            if (trb_auslegen.Value > 19 || trb_auslegen.Value < 2)
            {
                MessageBox.Show("Ungültige Werte!");
                return;
            }
            if (trb_heben.Value > 27 || trb_heben.Value < 2)
            {
                MessageBox.Show("Ungültige Werte!");
                return;
            }
            */

            oglView.changeVal(1, trb_drehen.Value);
            oglView.changeVal(2, trb_auslegen.Value);
            oglView.changeVal(3, trb_heben.Value);


            //kran_config.PositionX = blub[0];
            //kran_config.PositionY = blub[1];
            //kran_config.PositionZ = blub[2];
        }
    }
}
