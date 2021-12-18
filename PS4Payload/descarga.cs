using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS4Payload
{
    public partial class descarga : Form
    {
        WebClient wc = new WebClient();
        bool cancelado = false;
        public int indice = 0; // este es el índice del link (IMPORTANTE)
        public descarga()
        {
            InitializeComponent();

            this.FormClosing += (s, e) =>
            {
                // impedimos que se cierre si no se ha cancelado la descarga
                if (!cancelado)
                {
                    // pedimos si cancelar la descarga
                    cancelar();
                    if (!cancelado) e.Cancel = true;
                }
            };

            // Mientras se descarga
            wc.DownloadProgressChanged += (s, e) =>
            {
                progreso.Value = e.ProgressPercentage; // mostramos el porcentaje
            };

            // cuando acabe
            wc.DownloadFileCompleted += (s, e) =>
            {
                if (!e.Cancelled)
                {
                    // si no se ha cancelado ya se habrá descargado
                    MessageBox.Show("Archivo descargado");
                    cancelado = true; // permitimos que se cierre el form
                    this.Close();
                }
            };
        }

        // para cancelar la descarga
        void cancelar()
        {
            var d = MessageBox.Show("Seguro que quieres cancelar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (d == DialogResult.Yes)
            {
                wc.CancelAsync();
                cancelado = true;
                this.Close();
            }
        }

        public void descargar()
        {
            string[] linea = File.ReadAllLines(hbdownloader.archivo)[indice].Split(';'); // solo cogemos la línea que hemos seleccionado

            lbnombre.Text = "Nombre: " + linea[0];
            lbpeso.Text = "Peso: " + linea[1];
            lbtipo.Text = "Tipo: " + linea[2];
            lblink.Text = "Link: " + linea[3];

            wc.DownloadFileAsync(new Uri(linea[3]), linea[0]); // aquí lo guardo por su nombre en la carpeta del programa, haz lo que quieras
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            cancelar(); // pedimos cancelación
        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {

        }
    }   
}
