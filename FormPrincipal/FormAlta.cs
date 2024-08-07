using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MisClases;

namespace FormExamen
{
    public partial class FormAlta : Form
    {
        private Computadora miComputadora;
        public Computadora MiComputadora { get => miComputadora; }

        public FormAlta()
        {
            InitializeComponent();
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
            cb_procesador.DataSource = Computadora.ListadoDeProcesadores();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string procesador = this.cb_procesador.Text;
            int memoriaRam = (int)this.num_memoria.Value;
            int capacidadDisco = (int)this.num_disco.Value;
            string sistemaOperativo = string.Empty;


            foreach (RadioButton rdb in gb_sistema.Controls)
            {
                if (rdb.Checked)
                {
                    sistemaOperativo = rdb.Text;
                    break;
                }
            }

            miComputadora = new Computadora(memoriaRam, capacidadDisco, procesador, sistemaOperativo);

            foreach (CheckBox ck in gb_programas.Controls)
            {
                if (ck.Checked == true)
                {
                    miComputadora.setPrograma = ck.Text;
                }
            }

            DialogResult = DialogResult.OK;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        
    }
}
