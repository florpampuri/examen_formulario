using FormExamen;
using MisClases;

namespace FormPrincipal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private List<Computadora> listaComputadoras;

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            listaComputadoras = new List<Computadora>();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FormAlta formAlta = new FormAlta();
            formAlta.ShowDialog();

            if (formAlta.ShowDialog() == DialogResult.OK)
            {
                listaComputadoras.Add(formAlta.MiComputadora);
                dgv_principal.DataSource = null;
                dgv_principal.DataSource = listaComputadoras;
            }

        }


    }
}
