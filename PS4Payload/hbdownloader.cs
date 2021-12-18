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
    public partial class hbdownloader : Form
    {
        public const string archivo = "db"; // ruta al archivo
        List<Link> links = new List<Link>();
        List<Link> descargas = new List<Link>();
        public hbdownloader()
        {
            InitializeComponent();
            cbtipo.SelectedIndex = 0; // seleccionamos "todos los archivos"


            // EDIT: Me da pereza cambiar las columnas del dgv manualmente, lo hago aquí
            dgv.Columns.Clear();
            dgvdescargas.Columns.Clear();

            var pgcol = new DataGridViewProgressColumn();
            pgcol.HeaderText = "Progreso";
            dgvdescargas.Columns.Add(pgcol);

            string[] cols = new[] { "Nombre", "Tipo", "Info", "Peso", "Versión", "Region", "TitleID", "Idioma", "Firmware", "Link" };
            foreach (string c in cols)
            {
                dgv.Columns.Add(c, c);
                dgvdescargas.Columns.Add(c, c);
            }


            // cargamos el archivo
            if (!File.Exists(archivo)) File.WriteAllText(archivo, ""); // si no existe lo creamos
            else rtb.Text = File.ReadAllText(archivo); // cargamos el archivo1

            cargarArchivo(); // cargamos la lista
            render(links); // cargamos el dgv

            // este timer es para actualizar las descargas en el dgv
            timer1.Tick += (s, e) =>
            {
                for (int i = 0; i < descargas.Count; i++)
                {
                    // cambiamos el valor del progressbar en la columna 0 (en este caso es la barra de progreso)
                    dgvdescargas.Rows[i].Cells[0].Value = descargas[i].Porcentaje;
                }
            };
        }

        void cargarArchivo()
        {
            // actualizamos la lista de links
            links.Clear();
            foreach (string l in File.ReadLines(archivo))
            {
                string[] datos = l.Split(';');
                links.Add(new Link(datos));
            }
        }

        // método para mostrar los datos en el datagridview
        void render(List<Link> urls)
        {
            dgv.Rows.Clear(); // quitamos las filas que haya

            foreach (Link l in urls)
            {
                string[] celdas = l.convertirAFila();
                dgv.Rows.Add(celdas); // agregamos la fila al dgv
            }
        }

        void renderDescargas(List<Link> urls)
        {
            dgvdescargas.Rows.Clear();
            foreach (Link l in urls)
            {
                object[] celdas = l.FilaDescargando();
                dgvdescargas.Rows.Add(celdas);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            List<int> indices_seleccionados = new List<int>();
            foreach (DataGridViewCell celda in dgv.SelectedCells)
            {
                int indice = celda.RowIndex;
                if (indices_seleccionados.Contains(indice)) continue; // evita poner la misma descarga más veces

                indices_seleccionados.Add(indice);
                DataGridViewRow fila = dgv.Rows[indice];

                // EDIT: Ponemos todas las columnas
                List<string> datos = new List<string>();
                foreach (DataGridViewCell c in fila.Cells) datos.Add(c.Value.ToString());

                Link l = new Link(datos.ToArray()); // convertimos la fila en un link
                if (descargas.Contains(l)) break; // evita descargar el mismo archivo dos veces

                descargas.Insert(0, l); // insertamos la descarga al principio          
                descargas[0].Descargar();
            }
            if (descargas.Count > 0) timer1.Start();
            renderDescargas(descargas);
        }      

        private void btnguardar_Click(object sender, EventArgs e)
        {
            // guardamos el archivo
            File.WriteAllText(archivo, rtb.Text);

            // actualizamos el dgv
            cargarArchivo();
            render(links);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (descargas.Count == 0) return; // si no hay descargas no hay nada por cancelar

            var d = MessageBox.Show("Seguro que quieres cancelar las descargas seleccionadas?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (d == DialogResult.Yes)
            {
                List<int> indice = new List<int>();
                foreach (DataGridViewCell celda in dgvdescargas.SelectedCells)
                {
                    int ind = celda.RowIndex;
                    if (indice.Contains(ind)) continue; // evitar que se ponga la misma celda más de una vez

                    indice.Add(ind);
                    DataGridViewRow fila = dgvdescargas.Rows[ind];

                    // EDIT: Lo pongo en lista asi puede haber las cols que quieras
                    List<string> datos = new List<string>();
                    for (int i = 1; i < fila.Cells.Count; i++) datos.Add(fila.Cells[i].Value.ToString());

                    Link l = new Link(datos.ToArray()); // convertimos la fila en un link
                    int ind_descarga = descargas.FindIndex(x => x.Url == l.Url); // índice de la descarga para cancelar

                    if (ind_descarga >= 0)
                    {
                        descargas[ind_descarga].wc.CancelAsync();
                        descargas.RemoveAt(ind_descarga); // la quitamos de la lista
                    }
                }

                renderDescargas(descargas);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (descargas.Count == 0) return; // si no hay descargas no hay nada por cancelar

            var d = MessageBox.Show("Seguro que quieres cancelar todas las descargas?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (d == DialogResult.Yes)
            {
                foreach (Link l in descargas) l.wc.CancelAsync();
                descargas = new List<Link>();
                timer1.Stop();

                renderDescargas(descargas);
            }
        }      

        private void cbtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbtipo.SelectedIndex == 0) render(links); // mostramos todos
            else
            {
                // filtramos los links por los que coincidan con el tipo
                List<Link> busqueda = links.Where(x => x.Tipo == cbtipo.SelectedItem.ToString()).ToList();
                render(busqueda);
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            // filtramos los links por los que contengan parte de ese nombre
            //List<Link> busqueda = links.Where(x => x.Nombre.Contains(txtbuscar.Text)).ToList();

            // este de abajo no distingue mayús/minús, el de arriba sí
             List<Link> busqueda = links.Where(x => x.Nombre.ToLower().Contains(txtbuscar.Text.ToLower())).ToList();

            render(busqueda);
        }

        private void hbdownloader_Load(object sender, EventArgs e)
        {
            //nada aun!
        }      
    }
}
