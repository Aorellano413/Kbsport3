using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vista.Logins
{
    public partial class FormCargando : Form
    {
        private Timer timer;
        private int progreso;

        public FormCargando()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            LblMensaje.Text = "Estamos validando la información, espere un momento";
            LblMensaje.ForeColor = Color.Blue;
            LblMensaje.Font = new Font("Arial", 16, FontStyle.Bold);

            CARGANDOBARRA.Style = ProgressBarStyle.Continuous;
            CARGANDOBARRA.Maximum = 100;
            CARGANDOBARRA.Value = 0;

            labelCarga.Text = "0% carga";
            labelCarga.ForeColor = Color.Blue; 
            labelCarga.Font = new Font("Arial", 12, FontStyle.Bold);

            timer = new Timer();
            timer.Interval = 55; 
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progreso < 100)
            {
                progreso += 1;
                CARGANDOBARRA.Value = progreso;
                labelCarga.Text = progreso + "% ";
            }
        }

        private void CARGANDOBARRA_Click(object sender, EventArgs e)
        {
        }
    }
}
