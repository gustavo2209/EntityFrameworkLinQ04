using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkLinQ04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new ModelFrases())
            {
                var query = from a in db.autores select a;

                string msg = "";

                foreach(var a in query)
                {
                    msg += a.autor + "\r\n";

                    foreach(var f in a.frases)
                    {
                        msg += "\t" + f.frase + "\r\n";
                    }

                    msg += "\r\n";
                }

                textBox1.Text = msg;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var db = new ModelFrases())
            {
                var autor = new autores { autor = "Nuevo Autor 2" };
                db.autores.Add(autor);
                db.SaveChanges();

                // segunda parte (adicional)

                var frase1 = new frases { idautor = autor.idautor, frase = "Frase 1 de " + autor.autor };
                var frase2 = new frases { idautor = autor.idautor, frase = "Frase 2 de " + autor.autor };

                db.frases.Add(frase1);
                db.frases.Add(frase2);
                db.SaveChanges();

                textBox1.Text = "Inserciones exitosas";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
