using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Text;

namespace PS4Payload
{
    class Link
    {
        public string Nombre, Tipo, Sistema, Peso, Version, Region, TitleID, Idioma, Firmware, Url;

        public WebClient wc; // para descargar varios a la vez es necesario un webclient por cada link
        public int Porcentaje = 0;
        public bool Empezado = false, Acabado = false, Cancelado = false;

        // EDIT: Lo mismo para cada columna y valor
        public Link(string _nombre, string _tipo, string _sistema, string _peso, string _version,
            string _region, string _titleid, string _idioma, string _firmare, string _url)
        {
            this.Nombre = _nombre;
            this.Tipo = _tipo;
            this.Sistema = _sistema;
            this.Peso = _peso;
            this.Version = _version;
            this.Region = _region;
            this.TitleID = _titleid;
            this.Idioma = _idioma;
            this.Firmware = _firmare;
            this.Url = _url;

            wc = new WebClient();
            wc.DownloadProgressChanged += wc_descargando;
            wc.DownloadFileCompleted += wc_acabado;
        }

        // EDIT: lo hacemos con todos los datos
        public Link(string[] datos) :
            this(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], datos[6], datos[7], datos[8], datos[9])
        { }

        // para mostrarlos en un dgv
        public string[] convertirAFila()
        {
            // EDIT: devolver en orden de las columnas
            return new[]
            {
                this.Nombre,
                this.Tipo,
                this.Sistema,
                this.Peso,
                this.Version,
                this.Region,
                this.TitleID,
                this.Idioma,
                this.Firmware,
                this.Url
            };
        }

        public object[] FilaDescargando()
        {
            List<object> r = new List<object>();
            // EDIT: añadimos el porcentaje y la fila se queda igual
            // no hay que hacer nada si se quiere poner una columna más o algo así
            r.Add(this.Porcentaje);
            r.AddRange(convertirAFila());

            return r.ToArray();
        }

        // método para descargar
        public void Descargar()
        {
            this.Empezado = true;
            wc.DownloadFileAsync(new Uri(this.Url), this.Nombre);
        }

        private void wc_descargando(object s, DownloadProgressChangedEventArgs e)
        {
            this.Porcentaje = e.ProgressPercentage;
        }

        private void wc_acabado(object s, AsyncCompletedEventArgs e)
        {
            this.Cancelado = e.Cancelled;
            this.Empezado = false;

            if (!this.Cancelado)
            {
                this.Acabado = true;
            }
        }
    }
}
