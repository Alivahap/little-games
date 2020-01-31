using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayıBulma
{
    class Sayıuret

    {
        public void Buttongizle(GroupBox g)
        {
            foreach (TextBox t in g.Controls)
            {
                t.Visible = false;
            }




        }
        public void labelgizle(GroupBox g)
        {

            foreach (Label l in g.Controls)
            {

                l.Visible = false;
            }


        }

        




    }
}
