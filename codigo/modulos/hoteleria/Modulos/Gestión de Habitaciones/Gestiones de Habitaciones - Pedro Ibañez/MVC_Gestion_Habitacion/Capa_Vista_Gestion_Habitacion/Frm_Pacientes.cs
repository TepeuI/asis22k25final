using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Gestion_Habitacion
{
    public partial class Frm_Pacientes : Form
    {
        public Frm_Pacientes()
        {
            InitializeComponent();
            //parametros para navegador
            Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView config = new Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView
            {
                Ancho = 1100,
                Alto = 200,
                PosX = 10,
                PosY = 300,
                ColorFondo = Color.AliceBlue,
                TipoScrollBars = ScrollBars.Both,
                Nombre = "dgv_empleados"
            };

            string[] columnas = {
                        "tbl_paciente",
                        "pk_idPaciente",
                        "nombrePaciente",
                        "apellidoPaciente",
                        "fechaNacimientoPaciente",
                        "sexoPaciente",
                        "direccionPaciente",
                        "telefonoPaciente",
                        "estadoPaciente"

                    };

            string[] sEtiquetas = {
                        "ID Paciente",
                        "Nombre",
                        "Apellido",
                        "Fecha de Nacimiento",
                        "Sexo",
                        "Direccion Paciente",
                        "Telefono",
                        "Estado del Paciente"
                    };


            int id_aplicacion = 2858;
            int id_Modulo = 6;
            navegador1.IPkId_Aplicacion = id_aplicacion;
            navegador1.IPkId_Modulo = id_Modulo;
            navegador1.configurarDataGridView(config);
            navegador1.SNombreTabla = columnas[0];
            navegador1.SAlias = columnas;
            navegador1.SEtiquetas = sEtiquetas;
            navegador1.mostrarDatos();
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Paciente rpt_pac = new Frm_Reporte_Paciente();
            rpt_pac.ShowDialog();
        }
    }
}
