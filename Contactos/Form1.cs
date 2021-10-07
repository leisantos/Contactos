using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contactos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgContacto.Columns.Add("contactoId", "ID");
            dgContacto.Columns.Add("nombre", "Nombre");
            dgContacto.Columns.Add("apellido", "Apellido");
            dgContacto.Columns.Add("numeroTelefono", "Telefono");
            dgContacto.Columns.Add("direccion", "Direccion");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Contacto contacto = new Contacto();

            contacto.setcontactoId(Convert.ToInt32(txtcontactoId.Text));
            contacto.setnombre(txtnombre.Text);
            contacto.setapellido(txtapellido.Text);
            contacto.setnumeroTelefono(Convert.ToInt32(txtnumeroTelefono.Text));
            contacto.setdireccion(txtdireccion.Text);

            dgContacto.Rows.Add(contacto.getcontactoId(), contacto.getnombre(), contacto.getapellido(), contacto.getnumeroTelefono(), contacto.getdireccion());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
