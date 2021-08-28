using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RESET_Click(object sender, EventArgs e)
        {
           Tekst1.Text = "0000";
            textBox2bx.Text = "0000";
            textBox3cx.Text = "0000";
            textBox4dx.Text = "0000";
            blad.Text = "";
        }

        private void vij_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox2bx.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(characterA))
                {
                    textBox2bx.Text = "0000";
                    blad.Text = "Wymagany system szestnastkowy(Błąd)";
                    proper = false;
                }
                else if (proper == true)
                {
                   Tekst1.Text = textBox2bx.Text;
                    blad.Text = "";
                }
            }
        }

        private void wij_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox3cx.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(characterA))
                {
                    textBox3cx.Text = "0000";
                    blad.Text = "Wymagany system szestnastkowy(Błąd)";
                    proper = false;
                }
                else if (proper == true)
                {
                   Tekst1.Text = textBox3cx.Text;
                    blad.Text = "";
                }
            }
        }

        private void 
         req_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox4dx.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(characterA))
                {
                    textBox4dx.Text = "0000";
                    blad.Text = "Wymagany system szestnastkowy(Błąd)";
                    proper = false;
                }
                else if (proper == true)
                {
                   Tekst1.Text = textBox4dx.Text;
                    blad.Text = "";
                }
            }
        }

        private void 
            iko_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in Tekst1.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(characterA))
                {
                   Tekst1.Text = "0000";
                    blad.Text = "Wymagany system szestnastkowy(Błąd)";
                    proper = false;
                }
                else if (proper == true)
                {
                    textBox2bx.Text =Tekst1.Text;
                    blad.Text = "";
                }
            }
        }

        private void mbxcx_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox3cx.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(characterA))
                {
                    textBox3cx.Text = "0000";
                    blad.Text = "Wymagany system szestnastkowy(Błąd)";
                    proper = false;
                }
                else if (proper == true)
                {
                    textBox2bx.Text = textBox3cx.Text;
                    blad.Text = "";
                }
            }
        }

        private void mbxdx_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox4dx.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(characterA))
                {
                    textBox4dx.Text = "0000";
                    blad.Text = "Wymagany system szestnastkowy(Błąd)";
                    proper = false;
                }
                else if (proper == true)
                {
                    textBox2bx.Text = textBox4dx.Text;
                    blad.Text = "";
                }
            }
        }

        private void mcxax_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in Tekst1.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(characterA))
                {
                   Tekst1.Text = "0000";
                    blad.Text = "Wymagany system szestnastkowy(Błąd)";
                    proper = false;
                }
                else if (proper == true)
                {
                    textBox3cx.Text =Tekst1.Text;
                    blad.Text = "";
                }
            }
        }

        private void mcxbx_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox2bx.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(characterA))
                {
                    textBox2bx.Text = "0000";
                    blad.Text = "Wymagany system szestnastkowy(Błąd)";
                    proper = false;
                }
                else if (proper == true)
                {
                    textBox3cx.Text = textBox2bx.Text;
                    blad.Text = "";
                }
            }
        }

        private void mcxdx_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox4dx.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(characterA))
                {
                    textBox4dx.Text = "0000";
                    blad.Text = "Wymagany system szestnastkowy(Błąd)";
                    proper = false;
                }
                else if (proper == true)
                {
                    textBox3cx.Text = textBox4dx.Text;
                    blad.Text = "";
                }
            }
        }

        private void mdxax_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in Tekst1.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(characterA))
                {
                   Tekst1.Text = "0000";
                    blad.Text = "Wymagany system szestnastkowy(Błąd)";
                    proper = false;
                }
                else if (proper == true)
                {
                    textBox4dx.Text =Tekst1.Text;
                    blad.Text = "";
                }
            }
        }

        private void mdxbx_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox2bx.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(characterA))
                {
                    textBox2bx.Text = "0000";
                    blad.Text = "Wymagany system szestnastkowy(Błąd)";
                    proper = false;
                }
                else if (proper == true)
                {
                    textBox4dx.Text = textBox2bx.Text;
                    blad.Text = "";
                }
            }
        }

        private void mdxcx_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox3cx.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(characterA))
                {
                    textBox3cx.Text = "0000";
                    blad.Text = "Wymagany system szestnastkowy(Błąd)";
                    proper = false;
                }
                else if (proper == true)
                {
                    textBox4dx.Text = textBox3cx.Text;
                    blad.Text = "";
                }
            }
        }

        private void 
            vax_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in Tekst1.Text.ToUpper().ToArray())
                foreach (char characterB in textBox2bx.Text.ToUpper().ToArray())
                {
                    if (!allowedChars.Contains(characterA))
                    {
                       Tekst1.Text = "0000";
                        blad.Text = "Wymagany system szestnastkowy(Błąd)";
                        proper = false;

                    }
                    else if (!allowedChars.Contains(characterB))
                    {
                        proper = false;
                        textBox2bx.Text = "0000";
                        blad.Text = "Wymagany system szestnastkowy(Błąd)";

                    }
                }
            if (proper == true)
            {
                string WartoscAX;
                WartoscAX =Tekst1.Text;
               Tekst1.Text = textBox2bx.Text;
                textBox2bx.Text = WartoscAX;
            }
        }

        private void xaxcx_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in Tekst1.Text.ToUpper().ToArray())
                foreach (char characterB in textBox3cx.Text.ToUpper().ToArray())
                {
                    if (!allowedChars.Contains(characterA))
                    {
                       Tekst1.Text = "0000";
                        blad.Text = "Wymagany system szestnastkowy(Błąd)";
                        proper = false;

                    }
                    else if (!allowedChars.Contains(characterB))
                    {
                        proper = false;
                        textBox3cx.Text = "0000";
                        blad.Text = "Wymagany system szestnastkowy(Błąd)";

                    }
                }
            if (proper == true)
            {
                string WartoscAX;
                WartoscAX =Tekst1.Text;
               Tekst1.Text = textBox3cx.Text;
                textBox3cx.Text = WartoscAX;
            }
        }

        private void xaxdx_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in Tekst1.Text.ToUpper().ToArray())
                foreach (char characterB in textBox4dx.Text.ToUpper().ToArray())
                {
                    if (!allowedChars.Contains(characterA))
                    {
                       Tekst1.Text = "0000";
                        blad.Text = "Wymagany system szestnastkowy(Błąd)";
                        proper = false;

                    }
                    else if (!allowedChars.Contains(characterB))
                    {
                        proper = false;
                        textBox4dx.Text = "0000";
                        blad.Text = "Wymagany system szestnastkowy(Błąd)";

                    }
                }
            if (proper == true)
            {
                string WartoscAX;
                WartoscAX =Tekst1.Text;
               Tekst1.Text = textBox4dx.Text;
                textBox4dx.Text = WartoscAX;
            }
        }

        private void xbxax_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox2bx.Text.ToUpper().ToArray())
                foreach (char characterB in Tekst1.Text.ToUpper().ToArray())
                {
                    if (!allowedChars.Contains(characterA))
                    {
                        textBox2bx.Text = "0000";
                        blad.Text = "Wymagany system szestnastkowy(Błąd)";
                        proper = false;

                    }
                    else if (!allowedChars.Contains(characterB))
                    {
                        proper = false;
                       Tekst1.Text = "0000";
                        blad.Text = "Wymagany system szestnastkowy(Błąd)";

                    }
                }
            if (proper == true)
            {
                string WartoscBX;
                WartoscBX = textBox2bx.Text;
                textBox2bx.Text =Tekst1.Text;
               Tekst1.Text = WartoscBX;
            }
        }

        private void xbxcx_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox2bx.Text.ToUpper().ToArray())
                foreach (char characterB in textBox3cx.Text.ToUpper().ToArray())
                {
                    if (!allowedChars.Contains(characterA))
                    {
                        textBox2bx.Text = "0000";
                        blad.Text = "Wymagany system szestnastkowy(Błąd)";
                        proper = false;

                    }
                    else if (!allowedChars.Contains(characterB))
                    {
                        proper = false;
                        textBox3cx.Text = "0000";
                        blad.Text = "Wymagany system szestnastkowy(Błąd)";

                    }
                }
            if (proper == true)
            {
                string WartoscBX;
                WartoscBX = textBox2bx.Text;
                textBox2bx.Text = textBox3cx.Text;
                textBox3cx.Text = WartoscBX;
            }
        }

        private void xbxdx_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox2bx.Text.ToUpper().ToArray())
                foreach (char characterB in textBox4dx.Text.ToUpper().ToArray())
                {
                    if (!allowedChars.Contains(characterA))
                    {
                        textBox2bx.Text = "0000";
                        blad.Text = "Wymagany system szestnastkowy(Błąd)";
                        proper = false;

                    }
                    else if (!allowedChars.Contains(characterB))
                    {
                        proper = false;
                        textBox4dx.Text = "0000";
                        blad.Text = "Wymagany system szestnastkowy(Błąd)";

                    }
                }
            if (proper == true)
            {
                string WartoscBX;
                WartoscBX = textBox2bx.Text;
                textBox2bx.Text = textBox4dx.Text;
                textBox4dx.Text = WartoscBX;
            }
        }

        private void xcxax_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox3cx.Text.ToUpper().ToArray())
                foreach (char characterB in Tekst1.Text.ToUpper().ToArray())
                {
                    if (!allowedChars.Contains(characterA))
                    {
                        textBox3cx.Text = "0000";
                        blad.Text = "Wymagany system szestnastkowy(Błąd)";
                        proper = false;

                    }
                    else if (!allowedChars.Contains(characterB))
                    {
                        proper = false;
                       Tekst1.Text = "0000";
                        blad.Text = "Wymagany system szestnastkowy(Błąd)"; ;

                    }
                }
            if (proper == true)
            {
                string WartoscCX;
                WartoscCX = textBox3cx.Text;
                textBox3cx.Text =Tekst1.Text;
               Tekst1.Text = WartoscCX;
            }
        }

        private void xcxbx_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox3cx.Text.ToUpper().ToArray())
                foreach (char characterB in textBox2bx.Text.ToUpper().ToArray())
                {
                    if (!allowedChars.Contains(characterA))
                    {
                        textBox3cx.Text = "0000";
                        blad.Text = "Wymagany system szestnastkowy(Błąd)";
                        proper = false;

                    }
                    else if (!allowedChars.Contains(characterB))
                    {
                        proper = false;
                        textBox2bx.Text = "0000";
                        blad.Text = "Wymagany system szestnastkowy(Błąd)";

                    }
                }
            if (proper == true)
            {
                string WartoscCX;
                WartoscCX = textBox3cx.Text;
                textBox3cx.Text = textBox2bx.Text;
                textBox2bx.Text = WartoscCX;
            }
        }

        private void xcxdx_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox3cx.Text.ToUpper().ToArray())
                foreach (char characterB in textBox4dx.Text.ToUpper().ToArray())
                {
                    if (!allowedChars.Contains(characterA))
                    {
                        textBox3cx.Text = "0000";
                        blad.Text = "Wymagany system szestnastkowy(Błąd)";
                        proper = false;

                    }
                    else if (!allowedChars.Contains(characterB))
                    {
                        proper = false;
                        textBox4dx.Text = "0000";
                        blad.Text = "Wymagany system szestnastkowy(Błąd)";

                    }
                }
            if (proper == true)
            {
                string WartoscCX;
                WartoscCX = textBox3cx.Text;
                textBox3cx.Text = textBox4dx.Text;
                textBox4dx.Text = WartoscCX;
            }
        }

        private void xdxax_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox4dx.Text.ToUpper().ToArray())
                foreach (char characterB in Tekst1.Text.ToUpper().ToArray())
                {
                    if (!allowedChars.Contains(characterA))
                    {
                        textBox4dx.Text = "0000";
                        blad.Text = "Wymagany system szestnastkowy(Błąd)";
                        proper = false;

                    }
                    else if (!allowedChars.Contains(characterB))
                    {
                        proper = false;
                       Tekst1.Text = "0000";
                        blad.Text = "Wymagany system szestnastkowy(Błąd)";

                    }
                }
            if (proper == true)
            {
                string WartoscDX;
                WartoscDX = textBox4dx.Text;
                textBox4dx.Text =Tekst1.Text;
               Tekst1.Text = WartoscDX;
            }
        }

        private void xdxbx_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox4dx.Text.ToUpper().ToArray())
                foreach (char characterB in textBox2bx.Text.ToUpper().ToArray())
                {
                    if (!allowedChars.Contains(characterA))
                    {
                        textBox4dx.Text = "0000";
                        blad.Text = "Wymagany system szestnastkowy(Błąd)";
                        proper = false;

                    }
                    else if (!allowedChars.Contains(characterB))
                    {
                        proper = false;
                        textBox2bx.Text = "0000";
                        blad.Text = "Wymagany system szestnastkowy(Błąd)";

                    }
                }
            if (proper == true)
            {
                string WartoscDX;
                WartoscDX = textBox4dx.Text;
                textBox4dx.Text = textBox2bx.Text;
                textBox2bx.Text = WartoscDX;
            }
        }

        private void xdxcx_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox4dx.Text.ToUpper().ToArray())
                foreach (char characterB in textBox3cx.Text.ToUpper().ToArray())
                {
                    if (!allowedChars.Contains(characterA))
                    {
                        textBox4dx.Text = "0000";
                        blad.Text = "Wymagany system szestnastkowy(Błąd)";
                        proper = false;

                    }
                    else if (!allowedChars.Contains(characterB))
                    {
                        proper = false;
                        textBox3cx.Text = "0000";
                        blad.Text = "Wymagany system szestnastkowy(Błąd)";

                    }
                }
            if (proper == true)
            {
                string WartoscDX;
                WartoscDX = textBox4dx.Text;
                textBox4dx.Text = textBox3cx.Text;
                textBox3cx.Text = WartoscDX;
            }
        }

        private void blad_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(  "TEXT"); 
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
