using System.Windows.Forms;
using BLL;

namespace Front.Forms.Users.Deposito.Acciones
{
    public partial class RecepcionDePedidos : Form
    {
        DepositoBLL a = new DepositoBLL();
        int id_Produc;
        decimal cantidadUpdated;
        public RecepcionDePedidos()
        {
            
            InitializeComponent();
            comboBox1.ValueMember = "ID_PROD";
            comboBox1.DisplayMember ="DESCRIPCION";
            comboBox1.DataSource = a.ListarTodosLosProdutos();

        




            
        }

        private void ComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            
        }

        private void NumericUpDown1_ValueChanged(object sender, System.EventArgs e)
        {

        }

        private void BotonRecepcionarPedido_Click(object sender, System.EventArgs e)
        {


            id_Produc = comboBox1.SelectedIndex + 1;
            cantidadUpdated = numericUpDown1.Value;
            string [] result;
            string aux = cantidadUpdated.ToString();
            result = aux.Split(',');

            MessageBox.Show($"{result[0]} Separador. {result.Length}");





            if (result.Length == 1)
            {

                if (a.UpdateStockBLL(id_Produc, cantidadUpdated) != 0)
                {
                    MessageBox.Show("Stock actualizado");
                    numericUpDown1.ResetText();
                }
                else
                {
                    MessageBox.Show("Error Al actualizar.");

                    numericUpDown1.ResetText();

                }

            }
            else
            {
                numericUpDown1.ResetText();

                MessageBox.Show("Solo se permiten numeros enteros");

            }












        }
    }
}
