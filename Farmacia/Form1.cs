using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public struct Medicamento
    {
        public string p_codigo;
        public string p_nombre;
        public int p_cantidad;
        public double p_precioUnitario;
        public double p_montoInvertido;

        public Medicamento(string codigo, string nombre, int cantidad, double precioUnitario)
        {
            this.p_codigo = codigo;
            this.p_nombre = nombre;
            this.p_cantidad = cantidad;
            this.p_precioUnitario = precioUnitario;
            this.p_montoInvertido = (double)cantidad * precioUnitario;
        }
    }

    public partial class Form1 : Form
    {
        // Se crea una lista
        List<Medicamento> ListaMedicamentos = new List<Medicamento>();

        public Form1()
        {
            InitializeComponent();
        }

        // Mensaje de confirmacion
        public void MensajeConfirmacion(string mensaje)
        {
            MessageBox.Show(mensaje, "Farmacia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Mensaje de error
        public void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Farmacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void datalista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void i_btn_agregar_Click(object sender, EventArgs e)
        {
            // Se comprueba que todos los textField estén llenos
            if (p_txt_codigo.Text == string.Empty ||
                p_txt_nombre.Text == string.Empty ||
                p_txt_cantidad.Text == string.Empty ||
                p_txt_precio.Text == string.Empty)
            {
                MensajeError("Debe llenar todos los campos.");
                return;
            }

            // Se Comprueba que el textField de cantidad y precio solo contenga números
            bool contieneLetra1 = p_txt_cantidad.Text.Any(c => Char.IsLetter(c));
            bool contieneLetra2 = p_txt_precio.Text.Any(c => Char.IsLetter(c));

            if (contieneLetra1 || contieneLetra2)
            {
                MensajeError("No puede ingresar letras en los campos de cantidad y precio.");
                return;
            }

            // Se crea el struct del nuevo medicamento
            int cantidad = int.Parse(p_txt_cantidad.Text);
            double precio = double.Parse(p_txt_precio.Text);

            Medicamento nuevo_medicamento = new Medicamento(p_txt_codigo.Text, p_txt_nombre.Text, cantidad, precio);

            // Se comprueba que el código del medicamento no exista en la lista
            Medicamento[] Lista_Medicamentos = ListaMedicamentos.ToArray();

            // Buscador en serie
            for (int i = 0; i < Lista_Medicamentos.Length; i++)
            {
                if (nuevo_medicamento.p_codigo == Lista_Medicamentos[i].p_codigo)
                {
                    MensajeError("El código del medicamento ingresado ya existe.");
                    return;
                }
            }

            // Se ordena alfabéticamente la lista de medicamentos
            ListaMedicamentos.Add(nuevo_medicamento);
            Medicamento[] Lista_Medicamentos1 = ListaMedicamentos.ToArray();

            // Método burbuja
            for (int i = 0; i < Lista_Medicamentos1.Length - 1; i++)
            {
                for (int j = 0; j < Lista_Medicamentos1.Length - i - 1; j++)
                {
                    if (Lista_Medicamentos1[j].p_nombre.CompareTo(Lista_Medicamentos1[j + 1].p_nombre) > 0)
                    {
                        Medicamento temp = Lista_Medicamentos1[j];
                        Lista_Medicamentos1[j] = Lista_Medicamentos1[j + 1];
                        Lista_Medicamentos1[j + 1] = temp;
                    }
                }
            }

            // Se imprime todo en la tabla
            i_listaMedicamentos.Rows.Clear();

            for (int i = 0; i < Lista_Medicamentos1.Length; i++)
            {
                int n = i_listaMedicamentos.Rows.Add();

                i_listaMedicamentos.Rows[n].Cells[0].Value = Lista_Medicamentos1[i].p_codigo;
                i_listaMedicamentos.Rows[n].Cells[1].Value = Lista_Medicamentos1[i].p_nombre;
                i_listaMedicamentos.Rows[n].Cells[2].Value = Lista_Medicamentos1[i].p_cantidad;
                i_listaMedicamentos.Rows[n].Cells[3].Value = Lista_Medicamentos1[i].p_precioUnitario;
                i_listaMedicamentos.Rows[n].Cells[4].Value = Lista_Medicamentos1[i].p_montoInvertido;
            }

            // Se borran los textField
            p_txt_codigo.Clear();
            p_txt_nombre.Clear();
            p_txt_cantidad.Clear();
            p_txt_precio.Clear();

            // Mensaje de confirmación
            MensajeConfirmacion("El medicamento se agregó correctamente.");
        }

        private void i_btn_cancelar1_Click(object sender, EventArgs e)
        {
            // Se borran los textField
            p_txt_codigo.Clear();
            p_txt_nombre.Clear();
            p_txt_cantidad.Clear();
            p_txt_precio.Clear();
        }

        private void i_eliminar_Click(object sender, EventArgs e)
        {
            // Se comprueba que el textField no esté vacío
            string medicamento = p_txt_codigoEliminar.Text;

            if (medicamento == string.Empty)
            {
                MensajeError("Debe ingresar un código");
                return;
            }

            // Se busca el medicamento por código en la lista
            Medicamento[] Lista_Medicamentos = ListaMedicamentos.ToArray();

            for (int i = 0; i < Lista_Medicamentos.Length; i++)
            {
                // Si se encontró el medicamento, se procede a borrarlo
                if (Lista_Medicamentos[i].p_codigo == medicamento)
                {
                    DialogResult resultado = MessageBox.Show("¿Está seguro que desea borrar el medicamento '" + medicamento + "'?", "Confirmar borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        ListaMedicamentos.Remove(Lista_Medicamentos[i]);
                        Medicamento[] Nueva_Lista_Medicamentos = ListaMedicamentos.ToArray();

                        i_listaMedicamentos.Rows.Clear();

                        for (int j = 0; j < Nueva_Lista_Medicamentos.Length; j++)
                        {
                            int n = i_listaMedicamentos.Rows.Add();

                            i_listaMedicamentos.Rows[n].Cells[0].Value = Nueva_Lista_Medicamentos[j].p_codigo;
                            i_listaMedicamentos.Rows[n].Cells[1].Value = Nueva_Lista_Medicamentos[j].p_nombre;
                            i_listaMedicamentos.Rows[n].Cells[2].Value = Nueva_Lista_Medicamentos[j].p_cantidad;
                            i_listaMedicamentos.Rows[n].Cells[3].Value = Nueva_Lista_Medicamentos[j].p_precioUnitario;
                            i_listaMedicamentos.Rows[n].Cells[4].Value = Nueva_Lista_Medicamentos[j].p_montoInvertido;
                        }

                        p_txt_codigoEliminar.Clear();
                        MensajeConfirmacion("Se eliminó con éxito.");
                    }
                    else
                    {
                        p_txt_codigoEliminar.Clear();
                    }
                    return;
                }
            }

            // Si no se encontró el medicamento, se muestra un mensaje de error
            MensajeError("El código no existe.");
        }

        private void i_btn_cancelar2_Click(object sender, EventArgs e)
        {
            // Se borra el textField de Código a eliminar
            p_txt_codigoEliminar.Clear();
        }

        private void I_Buscar_Click(object sender, EventArgs e)
        {
            // Se comprueba que el textField no esté vacío
            string medicamento = p_txt_buscar.Text;

            if (medicamento == string.Empty)
            {
                MensajeError("Debe ingresar un código");
                return;
            }

            // Se busca el medicamento por nombre dentro de la lista
            Medicamento[] Lista_Medicamentos = ListaMedicamentos.ToArray();

            for (int i = 0; i < Lista_Medicamentos.Length; i++)
            {
                if (Lista_Medicamentos[i].p_nombre == medicamento)
                {
                    MensajeConfirmacion("Se encontró el medicamento.");
                    return;
                }
            }

            // Si no se encontró el medicamento, se muestra un mensaje de error
            MensajeError("No se encontró el medicamento.");
        }

        private void i_txt_buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void i_btn_buscarCancelar_Click(object sender, EventArgs e)
        {
            // Se borra el textField del nombre a buscar
            p_txt_buscar.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void i_listaMedicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}