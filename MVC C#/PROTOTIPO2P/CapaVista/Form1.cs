using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using CapaControlador;

namespace CapaVista
{
    public partial class Form1 : Form
    {
        clsControlador logi = new clsControlador();
        public Form1()
        {
            InitializeComponent();
        }

        public void mostrar_consulta()
        {
            OdbcDataReader mostrar = logi.consultar("bodegas"); //envia el nombre de la tabla pa mostrar contenido
            try
            {


                while (mostrar.Read())
                    dataGridView1.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2)); //anade fila con estos datos

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }
        public void mostrar_consulta1()
        {
            OdbcDataReader mostrar = logi.consultar("lineas"); //envia el nombre de la tabla pa mostrar contenido
            try
            {


                while (mostrar.Read())
                    dataGridView1.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2)); //anade fila con estos datos

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }

        public void mostrar_consulta2()
        {
            OdbcDataReader mostrar = logi.consultar("marcas"); //envia el nombre de la tabla pa mostrar contenido
            try
            {


                while (mostrar.Read())
                    dataGridView1.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2)); //anade fila con estos datos

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }

        public void mostrar_consulta3()
        {
            OdbcDataReader mostrar = logi.consultar("productos"); //envia el nombre de la tabla pa mostrar contenido
            try
            {


                while (mostrar.Read())
                    dataGridView1.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4), mostrar.GetString(5)); //anade fila con estos datos

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }

        public void mostrar_consulta4()
        {
            OdbcDataReader mostrar = logi.consultar("existencias"); //envia el nombre de la tabla pa mostrar contenido
            try
            {


                while (mostrar.Read())
                    dataGridView1.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2)); //anade fila con estos datos

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }

        public void mostrar_consulta5()
        {
            OdbcDataReader mostrar = logi.consultar("vendedores"); //envia el nombre de la tabla pa mostrar contenido
            try
            {


                while (mostrar.Read())
                    dataGridView1.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4), mostrar.GetString(5)); //anade fila con estos datos

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }

        public void mostrar_consulta6()
        {
            OdbcDataReader mostrar = logi.consultar("clientes"); //envia el nombre de la tabla pa mostrar contenido
            try
            {


                while (mostrar.Read())
                    dataGridView1.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4), mostrar.GetString(5)); //anade fila con estos datos

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }

        public void mostrar_consulta7()
        {
            OdbcDataReader mostrar = logi.consultar("proveedores"); //envia el nombre de la tabla pa mostrar contenido
            try
            {


                while (mostrar.Read())
                    dataGridView1.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4), mostrar.GetString(5)); //anade fila con estos datos

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }

        public void mostrar_consulta8()
        {
            OdbcDataReader mostrar = logi.consultar("compras_encabezado"); //envia el nombre de la tabla pa mostrar contenido
            try
            {


                while (mostrar.Read())
                    dataGridView1.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4)); //anade fila con estos datos

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }

        public void mostrar_consulta9()
        {
            OdbcDataReader mostrar = logi.consultar("compras_detalle"); //envia el nombre de la tabla pa mostrar contenido
            try
            {


                while (mostrar.Read())
                    dataGridView1.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4)); //anade fila con estos datos

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }


        public void mostrar_consulta10()
        {
            OdbcDataReader mostrar = logi.consultar("ventas_encabezado"); //envia el nombre de la tabla pa mostrar contenido
            try
            {


                while (mostrar.Read())
                    dataGridView1.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4)); //anade fila con estos datos

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }

        public void mostrar_consulta11()
        {
            OdbcDataReader mostrar = logi.consultar("ventas_detalle"); //envia el nombre de la tabla pa mostrar contenido
            try
            {


                while (mostrar.Read())
                    dataGridView1.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4), mostrar.GetString(5)); //anade fila con estos datos

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string[] valoresE = { textBox1.Text, textBox2.Text, textBox3.Text };
            MessageBox.Show("Datos agregados a la base de datos", "Ingreso de datos");
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            if (logi.insertar_bodegas(valoresE) == null)
            {
                MessageBox.Show("Error al guardar");
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.Rows.Clear();
                mostrar_consulta();
                string[] valores = { textBox1.Text, textBox2.Text, textBox3.Text };

                if (logi.insertar_bodegas(valores) == null)
                {
                    MessageBox.Show("Error al guardar");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] valores = { textBox1.Text, textBox2.Text, textBox3.Text }; //valores a ingresar
            if (logi.modificar_bodegas(valores) == null)
            {
                MessageBox.Show("Error al modificar");
            }
            else
            {
                //MessageBox.Show("Modificacion exitosa");
                MessageBox.Show("Datos modificados a la base de datos", "Modificacion de datos");
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] valoresE = { textBox6.Text, textBox5.Text, textBox4.Text };
            MessageBox.Show("Datos agregados a la base de datos", "Ingreso de datos");
            textBox6.Enabled = false;
            textBox5.Enabled = false;
            textBox4.Enabled = false;
            textBox6.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";

            if (logi.insertar_lineas(valoresE) == null)
            {
                MessageBox.Show("Error al guardar");
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.Rows.Clear();
                mostrar_consulta1();
                string[] valores = { textBox6.Text, textBox5.Text, textBox4.Text };

                if (logi.insertar_lineas(valores) == null)
                {
                    MessageBox.Show("Error al guardar");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] valores = { textBox6.Text, textBox5.Text, textBox4.Text }; //valores a ingresar
            if (logi.modificar_lineas(valores) == null)
            {
                MessageBox.Show("Error al modificar");
            }
            else
            {
                //MessageBox.Show("Modificacion exitosa");
                MessageBox.Show("Datos modificados a la base de datos", "Modificacion de datos");
                textBox6.Enabled = false;
                textBox5.Enabled = false;
                textBox4.Enabled = false;
                textBox6.Text = "";
                textBox5.Text = "";
                textBox4.Text = "";

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string[] valoresE = { textBox9.Text, textBox8.Text, textBox7.Text };
            MessageBox.Show("Datos agregados a la base de datos", "Ingreso de datos");
            textBox9.Enabled = false;
            textBox8.Enabled = false;
            textBox7.Enabled = false;
            textBox9.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";

            if (logi.insertar_marcas(valoresE) == null)
            {
                MessageBox.Show("Error al guardar");
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.Rows.Clear();
                mostrar_consulta2();
                string[] valores = { textBox9.Text, textBox8.Text, textBox7.Text };

                if (logi.insertar_marcas(valores) == null)
                {
                    MessageBox.Show("Error al guardar");
                }
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string[] valores = { textBox9.Text, textBox8.Text, textBox7.Text }; //valores a ingresar
            if (logi.modificar_marcas(valores) == null)
            {
                MessageBox.Show("Error al modificar");
            }
            else
            {
                //MessageBox.Show("Modificacion exitosa");
                MessageBox.Show("Datos modificados a la base de datos", "Modificacion de datos");
                textBox9.Enabled = false;
                textBox8.Enabled = false;
                textBox7.Enabled = false;
                textBox9.Text = "";
                textBox8.Text = "";
                textBox7.Text = "";

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string[] valoresE = { textBox15.Text, textBox14.Text, textBox13.Text, textBox12.Text, textBox11.Text, textBox10.Text };
            MessageBox.Show("Datos agregados a la base de datos", "Ingreso de datos");
            textBox15.Enabled = false;
            textBox14.Enabled = false;
            textBox13.Enabled = false;
            textBox12.Enabled = false;
            textBox11.Enabled = false;
            textBox10.Enabled = false;
            textBox15.Text = "";
            textBox14.Text = "";
            textBox13.Text = "";
            textBox12.Text = "";
            textBox11.Text = "";
            textBox10.Text = "";

            if (logi.insertar_productos(valoresE) == null)
            {
                MessageBox.Show("Error al guardar");
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.Rows.Clear();
                mostrar_consulta3();
                string[] valores = { textBox15.Text, textBox14.Text, textBox13.Text, textBox12.Text, textBox11.Text, textBox10.Text };

                if (logi.insertar_productos(valores) == null)
                {
                    MessageBox.Show("Error al guardar");
                }
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string[] valores = { textBox15.Text, textBox14.Text, textBox13.Text, textBox12.Text, textBox11.Text, textBox10.Text }; //valores a ingresar
            if (logi.modificar_productos(valores) == null)
            {
                MessageBox.Show("Error al modificar");
            }
            else
            {
                //MessageBox.Show("Modificacion exitosa");
                MessageBox.Show("Datos modificados a la base de datos", "Modificacion de datos");
                textBox15.Enabled = false;
                textBox14.Enabled = false;
                textBox13.Enabled = false;
                textBox12.Enabled = false;
                textBox11.Enabled = false;
                textBox10.Enabled = false;
                textBox15.Text = "";
                textBox14.Text = "";
                textBox13.Text = "";
                textBox12.Text = "";
                textBox11.Text = "";
                textBox10.Text = "";

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string[] valoresE = { textBox18.Text, textBox17.Text, textBox16.Text };
            MessageBox.Show("Datos agregados a la base de datos", "Ingreso de datos");
            textBox18.Enabled = false;
            textBox17.Enabled = false;
            textBox16.Enabled = false;
            textBox18.Text = "";
            textBox17.Text = "";
            textBox16.Text = "";

            if (logi.insertar_existencias(valoresE) == null)
            {
                MessageBox.Show("Error al guardar");
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.Rows.Clear();
                mostrar_consulta4();
                string[] valores = { textBox18.Text, textBox17.Text, textBox16.Text };

                if (logi.insertar_existencias(valores) == null)
                {
                    MessageBox.Show("Error al guardar");
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string[] valores = { textBox18.Text, textBox17.Text, textBox16.Text }; //valores a ingresar
            if (logi.modificar_existencias(valores) == null)
            {
                MessageBox.Show("Error al modificar");
            }
            else
            {
                //MessageBox.Show("Modificacion exitosa");
                MessageBox.Show("Datos modificados a la base de datos", "Modificacion de datos");
                textBox18.Enabled = false;
                textBox17.Enabled = false;
                textBox16.Enabled = false;
                textBox18.Text = "";
                textBox17.Text = "";
                textBox16.Text = "";

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string[] valoresE = { textBox24.Text, textBox23.Text, textBox22.Text, textBox21.Text, textBox20.Text, textBox19.Text };
            MessageBox.Show("Datos agregados a la base de datos", "Ingreso de datos");
            textBox24.Enabled = false;
            textBox23.Enabled = false;
            textBox22.Enabled = false;
            textBox21.Enabled = false;
            textBox20.Enabled = false;
            textBox19.Enabled = false;
            textBox24.Text = "";
            textBox23.Text = "";
            textBox22.Text = "";
            textBox21.Text = "";
            textBox20.Text = "";
            textBox19.Text = "";

            if (logi.insertar_vendedores(valoresE) == null)
            {
                MessageBox.Show("Error al guardar");
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.Rows.Clear();
                mostrar_consulta5();
                string[] valores = { textBox24.Text, textBox23.Text, textBox22.Text, textBox21.Text, textBox20.Text, textBox19.Text };

                if (logi.insertar_vendedores(valores) == null)
                {
                    MessageBox.Show("Error al guardar");
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string[] valores = { textBox24.Text, textBox23.Text, textBox22.Text, textBox21.Text, textBox20.Text, textBox19.Text }; //valores a ingresar
            if (logi.modificar_vendedores(valores) == null)
            {
                MessageBox.Show("Error al modificar");
            }
            else
            {
                //MessageBox.Show("Modificacion exitosa");
                MessageBox.Show("Datos modificados a la base de datos", "Modificacion de datos");
                textBox24.Enabled = false;
                textBox23.Enabled = false;
                textBox22.Enabled = false;
                textBox21.Enabled = false;
                textBox20.Enabled = false;
                textBox19.Enabled = false;
                textBox24.Text = "";
                textBox23.Text = "";
                textBox22.Text = "";
                textBox21.Text = "";
                textBox20.Text = "";
                textBox19.Text = "";

            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string[] valoresE = { textBox31.Text, textBox30.Text, textBox29.Text, textBox28.Text, textBox27.Text, textBox26.Text, textBox25.Text };
            MessageBox.Show("Datos agregados a la base de datos", "Ingreso de datos");
            textBox31.Enabled = false;
            textBox30.Enabled = false;
            textBox29.Enabled = false;
            textBox28.Enabled = false;
            textBox27.Enabled = false;
            textBox26.Enabled = false;
            textBox25.Enabled = false;
            textBox31.Text = "";
            textBox30.Text = "";
            textBox29.Text = "";
            textBox28.Text = "";
            textBox27.Text = "";
            textBox26.Text = "";
            textBox25.Text = "";

            if (logi.insertar_clientes(valoresE) == null)
            {
                MessageBox.Show("Error al guardar");
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.Rows.Clear();
                mostrar_consulta6();
                string[] valores = { textBox31.Text, textBox30.Text, textBox29.Text, textBox28.Text, textBox27.Text, textBox26.Text, textBox25.Text };

                if (logi.insertar_clientes(valores) == null)
                {
                    MessageBox.Show("Error al guardar");
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string[] valores = { textBox31.Text, textBox30.Text, textBox29.Text, textBox28.Text, textBox27.Text, textBox26.Text, textBox25.Text }; //valores a ingresar
            if (logi.modificar_clientes(valores) == null)
            {
                MessageBox.Show("Error al modificar");
            }
            else
            {
                //MessageBox.Show("Modificacion exitosa");
                MessageBox.Show("Datos modificados a la base de datos", "Modificacion de datos");
                textBox31.Enabled = false;
                textBox30.Enabled = false;
                textBox29.Enabled = false;
                textBox28.Enabled = false;
                textBox27.Enabled = false;
                textBox26.Enabled = false;
                textBox25.Enabled = false;
                textBox31.Text = "";
                textBox30.Text = "";
                textBox29.Text = "";
                textBox28.Text = "";
                textBox27.Text = "";
                textBox26.Text = "";
                textBox25.Text = "";

            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string[] valoresE = { textBox37.Text, textBox36.Text, textBox35.Text, textBox34.Text, textBox33.Text, textBox32.Text };
            MessageBox.Show("Datos agregados a la base de datos", "Ingreso de datos");
            textBox37.Enabled = false;
            textBox36.Enabled = false;
            textBox35.Enabled = false;
            textBox34.Enabled = false;
            textBox33.Enabled = false;
            textBox32.Enabled = false;
            textBox37.Text = "";
            textBox36.Text = "";
            textBox35.Text = "";
            textBox34.Text = "";
            textBox33.Text = "";
            textBox32.Text = "";

            if (logi.insertar_proveedores(valoresE) == null)
            {
                MessageBox.Show("Error al guardar");
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.Rows.Clear();
                mostrar_consulta7();
                string[] valores = { textBox37.Text, textBox36.Text, textBox35.Text, textBox34.Text, textBox33.Text, textBox32.Text };

                if (logi.insertar_proveedores(valores) == null)
                {
                    MessageBox.Show("Error al guardar");
                }
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string[] valores = { textBox37.Text, textBox36.Text, textBox35.Text, textBox34.Text, textBox33.Text, textBox32.Text }; //valores a ingresar
            if (logi.modificar_proveedores(valores) == null)
            {
                MessageBox.Show("Error al modificar");
            }
            else
            {
                //MessageBox.Show("Modificacion exitosa");
                MessageBox.Show("Datos modificados a la base de datos", "Modificacion de datos");
                textBox37.Enabled = false;
                textBox36.Enabled = false;
                textBox35.Enabled = false;
                textBox34.Enabled = false;
                textBox33.Enabled = false;
                textBox32.Enabled = false;
                textBox37.Text = "";
                textBox36.Text = "";
                textBox35.Text = "";
                textBox34.Text = "";
                textBox33.Text = "";
                textBox32.Text = "";

            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            string[] valoresE = { textBox42.Text, textBox41.Text, textBox40.Text, textBox39.Text, textBox38.Text };
            MessageBox.Show("Datos agregados a la base de datos", "Ingreso de datos");
            textBox42.Enabled = false;
            textBox41.Enabled = false;
            textBox40.Enabled = false;
            textBox39.Enabled = false;
            textBox38.Enabled = false;

            textBox42.Text = "";
            textBox41.Text = "";
            textBox40.Text = "";
            textBox39.Text = "";
            textBox38.Text = "";




            if (logi.insertar_compras_encabezado(valoresE) == null)
            {
                MessageBox.Show("Error al guardar");
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.Rows.Clear();
                mostrar_consulta8();
                string[] valores = { textBox42.Text, textBox41.Text, textBox40.Text, textBox39.Text, textBox38.Text };

                if (logi.insertar_compras_encabezado(valores) == null)
                {
                    MessageBox.Show("Error al guardar");
                }
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            string[] valores = { textBox42.Text, textBox41.Text, textBox40.Text, textBox39.Text, textBox38.Text }; //valores a ingresar
            if (logi.modificar_compras_encabezado(valores) == null)
            {
                MessageBox.Show("Error al modificar");
            }
            else
            {
                //MessageBox.Show("Modificacion exitosa");
                MessageBox.Show("Datos modificados a la base de datos", "Modificacion de datos");
                textBox42.Enabled = false;
                textBox41.Enabled = false;
                textBox40.Enabled = false;
                textBox39.Enabled = false;
                textBox38.Enabled = false;

                textBox42.Text = "";
                textBox41.Text = "";
                textBox40.Text = "";
                textBox39.Text = "";
                textBox38.Text = "";


            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            string[] valoresE = { textBox47.Text, textBox46.Text, textBox45.Text, textBox44.Text, textBox43.Text };
            MessageBox.Show("Datos agregados a la base de datos", "Ingreso de datos");
            textBox47.Enabled = false;
            textBox46.Enabled = false;
            textBox45.Enabled = false;
            textBox44.Enabled = false;
            textBox43.Enabled = false;

            textBox47.Text = "";
            textBox46.Text = "";
            textBox45.Text = "";
            textBox44.Text = "";
            textBox43.Text = "";


            if (logi.insertar_compras_detalle(valoresE) == null)
            {
                MessageBox.Show("Error al guardar");
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.Rows.Clear();
                mostrar_consulta9();
                string[] valores = { textBox47.Text, textBox46.Text, textBox45.Text, textBox44.Text, textBox43.Text };

                if (logi.insertar_compras_detalle(valores) == null)
                {
                    MessageBox.Show("Error al guardar");
                }
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            string[] valores = { textBox47.Text, textBox46.Text, textBox45.Text, textBox44.Text, textBox43.Text }; //valores a ingresar
            if (logi.modificar_compras_detalle(valores) == null)
            {
                MessageBox.Show("Error al modificar");
            }
            else
            {
                //MessageBox.Show("Modificacion exitosa");
                MessageBox.Show("Datos modificados a la base de datos", "Modificacion de datos");
                textBox47.Enabled = false;
                textBox46.Enabled = false;
                textBox45.Enabled = false;
                textBox44.Enabled = false;
                textBox43.Enabled = false;

                textBox47.Text = "";
                textBox46.Text = "";
                textBox45.Text = "";
                textBox44.Text = "";
                textBox43.Text = "";


            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            string[] valoresE = { textBox52.Text, textBox51.Text, textBox50.Text, textBox49.Text, textBox48.Text };
            MessageBox.Show("Datos agregados a la base de datos", "Ingreso de datos");
            textBox52.Enabled = false;
            textBox51.Enabled = false;
            textBox50.Enabled = false;
            textBox49.Enabled = false;
            textBox48.Enabled = false;

            textBox52.Text = "";
            textBox51.Text = "";
            textBox50.Text = "";
            textBox49.Text = "";
            textBox48.Text = "";




            if (logi.insertar_ventas_encabezado(valoresE) == null)
            {
                MessageBox.Show("Error al guardar");
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.Rows.Clear();
                mostrar_consulta10();
                string[] valores = { textBox52.Text, textBox51.Text, textBox50.Text, textBox49.Text, textBox48.Text };

                if (logi.insertar_ventas_encabezado(valores) == null)
                {
                    MessageBox.Show("Error al guardar");
                }
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            string[] valores = { textBox52.Text, textBox51.Text, textBox50.Text, textBox49.Text, textBox48.Text }; //valores a ingresar
            if (logi.modificar_ventas_encabezado(valores) == null)
            {
                MessageBox.Show("Error al modificar");
            }
            else
            {
                //MessageBox.Show("Modificacion exitosa");
                MessageBox.Show("Datos modificados a la base de datos", "Modificacion de datos");
                textBox52.Enabled = false;
                textBox51.Enabled = false;
                textBox50.Enabled = false;
                textBox49.Enabled = false;
                textBox48.Enabled = false;

                textBox52.Text = "";
                textBox51.Text = "";
                textBox50.Text = "";
                textBox49.Text = "";
                textBox48.Text = "";


            }
        }

        private void tabPage12_Click(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {
            string[] valoresE = { textBox58.Text, textBox57.Text, textBox56.Text, textBox55.Text, textBox54.Text, textBox53.Text };
            MessageBox.Show("Datos agregados a la base de datos", "Ingreso de datos");
            textBox58.Enabled = false;
            textBox57.Enabled = false;
            textBox56.Enabled = false;
            textBox55.Enabled = false;
            textBox54.Enabled = false;
            textBox53.Enabled = false;
            textBox58.Text = "";
            textBox57.Text = "";
            textBox56.Text = "";
            textBox55.Text = "";
            textBox54.Text = "";
            textBox53.Text = "";

            if (logi.insertar_ventas_detalle(valoresE) == null)
            {
                MessageBox.Show("Error al guardar");
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.Rows.Clear();
                mostrar_consulta11();
                string[] valores = { textBox58.Text, textBox57.Text, textBox56.Text, textBox55.Text, textBox54.Text, textBox53.Text };

                if (logi.insertar_ventas_detalle(valores) == null)
                {
                    MessageBox.Show("Error al guardar");
                }
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            string[] valores = { textBox58.Text, textBox57.Text, textBox56.Text, textBox55.Text, textBox54.Text, textBox53.Text }; //valores a ingresar
            if (logi.modificar_ventas_detalle(valores) == null)
            {
                MessageBox.Show("Error al modificar");
            }
            else
            {
                //MessageBox.Show("Modificacion exitosa");
                MessageBox.Show("Datos modificados a la base de datos", "Modificacion de datos");
                textBox58.Enabled = false;
                textBox57.Enabled = false;
                textBox56.Enabled = false;
                textBox55.Enabled = false;
                textBox54.Enabled = false;
                textBox53.Enabled = false;
                textBox58.Text = "";
                textBox57.Text = "";
                textBox56.Text = "";
                textBox55.Text = "";
                textBox54.Text = "";
                textBox53.Text = "";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mostrar_consulta();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mostrar_consulta1();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mostrar_consulta2();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            mostrar_consulta3();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            mostrar_consulta4();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            mostrar_consulta5();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            mostrar_consulta6();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            mostrar_consulta7();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            mostrar_consulta8();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            mostrar_consulta9();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            mostrar_consulta10();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            mostrar_consulta11();
        }
    }
}
