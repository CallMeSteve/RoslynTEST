using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Roslyn.Compilers;
using Roslyn.Scripting.CSharp;
using Roslyn.Scripting;

namespace RoslynTEST
{
    public partial class Roslyn : Form
    {
        ScriptEngine engine = null;
        public Roslyn()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartEngine();

            var session = Session.Create(this);
            session.AddReference("System.Windows.Forms");

            engine.Execute(textBox1.Text, session);
        }

        private void StartEngine()
        {
            if (engine == null)
            {
                engine = new ScriptEngine(new[] { "System", "System.Core", this.GetType().Assembly.Location });
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartEngine();

            var session = Session.Create(this);
            session.AddReference("System.Windows.Forms");
            //Func<decimal, decimal, decimal> ismail = (a, b) => { return a * b; };
            var asdasd = engine.Execute<Func<decimal, decimal, decimal>>(textBox2.Text, session);
            MessageBox.Show(asdasd(numericUpDown1.Value, numericUpDown2.Value).ToString());
        }

        public void Deneme()
        {
            MessageBox.Show("DENEME");
        }

        public static void DenemeStatic()
        {
            MessageBox.Show("DenemeStatic");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StartEngine();

            var session = Session.Create(this);
            session.AddReference("System.Windows.Forms");

            engine.Execute(textBox3.Text, session);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StartEngine();

            var session = Session.Create(this);
            session.AddReference("System.Windows.Forms");

            engine.Execute(textBox4.Text, session);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StartEngine();

            var session = Session.Create(this);
            session.AddReference("System.Windows.Forms");
            session.AddReference("System.Data");
            session.AddReference("System.Data.DataSetExtensions");

            engine.Execute(textBox5.Text, session);
        }



    }
}
