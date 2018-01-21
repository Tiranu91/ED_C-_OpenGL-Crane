using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsGL.OpenGL;
using System.Windows.Forms;

namespace DemoOpenGLBasicsCS
{
    class TKran
    {
        private static TKran newkran = new TKran(); //Neues statischen Kranobjekt

        //private System.Drawing.Color color = System.Drawing.Color.Grey;

        private int targetAngle = 0;    //Ausgangpunkt drehung
        private double targetArmLength = 1.5;   //Ausgangsounkt Ausleger
        private double targetRopeLength = 1.5;  //Ausgangsounkt Leillänge
        //private double targetBowlDiameter = 0.1;

        //Array für Position (Matrix) der Abrissbirne
        private double[] position = new double[] { 1.5, 0, 1.5 };
        //X,Y,Z

        public int TargetAngle
        {
            get { return targetAngle; }
            set {
                    position = TMatrix.Rotieren(position, value - targetAngle); //Rotationsmethode aufrufen und neue Positionwerte im Array ablegen, differenz zwischen aktuellem und zielwert uebergeben
                    targetAngle = value;
            }
        }

        public double TargetArmLength
        {
            get { return targetArmLength; }
            set {
                double val = 0.0;
                if (value > targetArmLength)
                    val = value / targetArmLength;
                else
                    val = 1 - value / targetArmLength;
                double[] positionausleger = { position[0], position[1] };    //Neues Array mit X und Y Koordinate
                positionausleger = TMatrix.Verkuerzen(positionausleger, val);   //Verkuerzungsmethode aufrufen, neue werte in Ausleherarry ablegen, differenz zwischen aktuellem und Zielwert uebergeben
                position[0] = positionausleger[0];  //Veraenderte Werte in Positionsarray ablegen
                position[1] = positionausleger[1];
                targetArmLength = value;

            }
        }

        public double TargetRopeLength
        {
            get { return targetRopeLength; }
            set { targetRopeLength = value; position[2] = 3 - value; }
        }

        //Wert der X Koordinate bereitstellen
        public double PositionX
        {
            get { return position[0]; }
            set { position[0] = value; }
        }
        //Wert der Y Koordinate bereitstellen
        public double PositionY
        {
            get { return position[1]; }
            set { position[1] = value; }
        }
        //Wert der Z Koordinate bereitstellen
        public double PositionZ
        {
            get { return position[2]; }
            set { position[2] = value; }
        }

        /*
        public double TargetBowlDiamete
        {
            get { return targetBowlDiameter; }
            set { targetBowlDiameter = value; }
        }
        */

        private TKran()
        {

        }

        public static TKran getInstance()
        {
            return newkran;

        }
        
        public void turm()
        {
            //Perspektive 90° auf die X-Achse
           GL.glRotated(90, 1, 0, 0);

            //Turm Zeichnen
            //lässt den Zylinder rotieren 
            GL.glRotated(targetAngle, 0, 1, 0);

            GL.glTranslated(0.0, 0.0, 0.0); 
            GL.glRotated(90, 1, 0, 0);      //Rotation des Objektes (Winkel, X, Y, Z)
            GL.glColor3f(0.0f, 0.0f, 1.0f); //Farbe des Objektes (R,G,B)
            // Zylinderobjekt erzeugen
            GLUquadric zylinder = GL.gluNewQuadric();
            GLU.gluCylinder(zylinder, 0.1, 0.1, 3, 20, 10);
        }

        public void gelenk()
        {
            //Gelenk zeichnen
            GL.glTranslated(0.0, 0.0, 0.0);
            GL.glRotated(0, 0, 1, 0);
            GL.glColor3f(1.0f, 1.0f, 1.0f);
            GLUT.glutWireSphere(0.1, 100, 150);
        }

        public void ausleger()
        {
            //Ausleger zeichnen
            GL.glTranslated(0.0, 0.0, 0.0);
            GL.glRotated(90, 0, 1, 0);
            GL.glColor3f(1.0f, 0.0f, 0.0f);
            GLUquadric ausleger = GL.gluNewQuadric();
            GLU.gluCylinder(ausleger, 0.1, 0.1, 2, 20, 10);
        }

        public void schieber()
        {
            //Schieber zeichnen
            GL.glTranslated(0.0, 0.0, targetArmLength);
            GL.glRotated(0, 0, 0, 0);
            GL.glColor3f(1.0f, 1.0f, 0.0f);
            GLUquadric schieber = GL.gluNewQuadric();
            GLU.gluCylinder(schieber, 0.15, 0.15, 0.1, 20, 10);
        }

        public void seil()
        {
            //Seil zeichnen
            //GL.glTranslated(0.0, 0.0, targetArmLength);
            GL.glTranslated(-0.15, 0.0, 0.05);
            GL.glRotated(-90, 0, 1, 0);
            GL.glColor3f(0.0f, 1.0f, 0.0f);
            GLUquadric seil = GL.gluNewQuadric();
            GLU.gluCylinder(seil, 0.01, 0.01, targetRopeLength, 20, 10);
        }

        public void abrissbirne()
        {
            //Abrissbirne zeichnen
            GL.glTranslated(0.0, 0.0, targetRopeLength);
            GL.glRotated(0, 0, 0, 0);
            GL.glColor3f(0.0f, 0.0f, 0.0f);
            GLUT.glutWireSphere(0.1, 100, 150);
            //GLUT.glutWireSphere(targetBowlDiameter, 100, 150);
        }
    }
}
