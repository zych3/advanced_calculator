using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private bool[] pkStanAktywnosciStronZakladki =
            { true, true, true };
        

        private Matrix matrixA = null;
        private Matrix matrixB = null;
        private Matrix matrixC;
        private DataGridView dataGridViewA;
        private DataGridView dataGridViewB;

        private ComplexNumber A;
        private ComplexNumber B;
        private ComplexNumber C;
        private ComplexNumber D;
        private ComplexNumber E;
        private ComplexNumber F;
        private ComplexNumber Z;
        private int int_Z;
        
        private TabControl pkZakladki;
        private TabPage pkKokpit;
        private System.Windows.Forms.Label label1;
        private TabPage pkDzialaniaNaMacierzach;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TabPage pkDzialaniaNaLiczbachZespolonych;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;

        public Form1()
        {
            InitializeComponent();
        }

        private void pkZakladki_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if ((e.TabPage == pkZakladki.TabPages[0]) &&
                (pkStanAktywnosciStronZakladki[0]))
            {
                pkStanAktywnosciStronZakladki[1] = true;
                pkStanAktywnosciStronZakladki[2] = true;
                pkZakladki.SelectedTab = pkKokpit;
            }
            else

            if ((e.TabPage == pkZakladki.TabPages[1]) &&
                (pkStanAktywnosciStronZakladki[1]))
            {
                pkStanAktywnosciStronZakladki[2] = false;
                pkZakladki.SelectedIndex = 1;
            }
            else
            if ((e.TabPage == pkZakladki.TabPages[2]) &&
                (pkStanAktywnosciStronZakladki[2]))
            {
                pkStanAktywnosciStronZakladki[1] = false;
                pkZakladki.SelectedIndex = 2;
            }

            else
                e.Cancel = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        
        
        
        
      
        
        private void label7_Click(object sender, EventArgs e)
        {

        }
        
        private void label8_Click(object sender, EventArgs e)
        {

        }
        
        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e) //create DataGrid a
        {
            /*pkDzialaniaNaMacierzach.Controls.Remove(dataGridViewB);
            dataGridViewB = null;*/

            
            int rowsA, columnsA;

            if (int.TryParse(textBox1.Text, out rowsA) && int.TryParse(textBox2.Text, out columnsA)) {
                // Create a new control only if dataGridViewA doesn't exist
                if (dataGridViewA == null)
                {
                    // Tworzenie nowej kontrolki DataGridView dla macierzy A
                    dataGridViewA = new DataGridView();

                    // Konfiguracja wymiarów DataGridView
                    dataGridViewA.Size = new System.Drawing.Size(400, 150);
                    dataGridViewA.ColumnCount = columnsA;
                    dataGridViewA.RowCount = rowsA + 1;

                    // Wyśrodkowanie DataGridView wewnątrz kontenera pkDzialaniaNaMacierzach
                    dataGridViewA.Anchor = AnchorStyles.None;
                    dataGridViewA.Location = new System.Drawing.Point(
                        (pkDzialaniaNaMacierzach.ClientSize.Width - dataGridViewA.Size.Width) / 2,
                        (pkDzialaniaNaMacierzach.ClientSize.Height - dataGridViewA.Size.Height) / 2
                    );
                    dataGridViewA.AllowUserToAddRows = false;
                    // Dodanie DataGridView do kontenera
                    pkDzialaniaNaMacierzach.Controls.Add(dataGridViewA);
                }

                // Wypełnienie komórek danymi losowymi
                Random random = new Random();
                /*for (int i = 0; i < rowsA; i++) {
                    for (int j = 0; j < columnsA; j++) {
                        dataGridViewA[j, i].Value = random.Next(1, 100); // Przykładowe wartości losowe
                    }
                }*/
            } else {
                MessageBox.Show("Wprowadź poprawne liczby dla wymiarów macierzy!");
            }
        }

        private void button12_Click(object sender, EventArgs e) //create dataGrid b
        {
            /*pkDzialaniaNaMacierzach.Controls.Remove(dataGridViewA);
            dataGridViewA = null;*/
            int rowsB, columnsB;

            if (int.TryParse(textBox1.Text, out rowsB) && int.TryParse(textBox2.Text, out columnsB)) {
                // Tworzenie nowej kontrolki DataGridView dla macierzy A
                dataGridViewB = new DataGridView();

                // Konfiguracja wymiarów DataGridView
                dataGridViewB.Size = new System.Drawing.Size(400, 150);
                dataGridViewB.ColumnCount = columnsB;
                dataGridViewB.RowCount = rowsB + 1;

                // Wyśrodkowanie DataGridView wewnątrz kontenera pkDzialaniaNaMacierzach
                dataGridViewB.Anchor = AnchorStyles.None;
                dataGridViewB.Location = new System.Drawing.Point(
                    (pkDzialaniaNaMacierzach.ClientSize.Width - dataGridViewB.Size.Width) / 2 ,
                    (pkDzialaniaNaMacierzach.ClientSize.Height - dataGridViewB.Size.Height) / 2 + 150
                );
                dataGridViewB.AllowUserToAddRows = false;
                // Dodanie DataGridView do kontenera
                pkDzialaniaNaMacierzach.Controls.Add(dataGridViewB);

               
                
            } else {
                MessageBox.Show("Wprowadź poprawne liczby dla wymiarów macierzy!");
            }
        }

        private void button15_Click(object sender, EventArgs e) //reset
        {
            matrixA = null;
            matrixB = null;
            
            pkDzialaniaNaMacierzach.Controls.Remove(dataGridViewA);
            pkDzialaniaNaMacierzach.Controls.Remove(dataGridViewB);

            dataGridViewA = null;
            dataGridViewB = null;


        } 

        private void button11_Click(object sender, EventArgs e) //create matrix a
        {

            try
            {
                int rowsA, columnsA;
                if (int.TryParse(textBox1.Text, out rowsA) && int.TryParse(textBox2.Text, out columnsA))
                {
                    if (dataGridViewA != null && dataGridViewA.RowCount == rowsA && dataGridViewA.ColumnCount == columnsA)
                    {
                        matrixA = new Matrix(rowsA, columnsA);

                        // Loop through dataGridViewA to populate matrixA with its values
                        for (int i = 0; i < rowsA; i++)
                        {
                            for (int j = 0; j < columnsA; j++)
                            {
                                // Assuming matrixA is a two-dimensional array of type int[,]
                                matrixA.MArray[i, j] = Convert.ToInt32(dataGridViewA[j, i].Value);
                            }
                        }

                        MessageBox.Show("Macierz A została wypełniona danymi z DataGridView!");
                    
                        /*pkDzialaniaNaMacierzach.Controls.Remove(dataGridViewA);
                    dataGridViewA = null;*/
                    }
                    else
                    {
                        MessageBox.Show("DataGridView nie zostało utworzone lub ma inne wymiary niż macierz A!");
                    }
                }
                else
                {
                    MessageBox.Show("Wprowadź poprawne liczby dla wymiarów macierzy!");
                }
            
                Matrix.DebugPrint(matrixA);
            }
            catch (Exception exception)
            {
                MessageBox.Show("error catching values");
                //throw;
            }
        }

        private void button14_Click(object sender, EventArgs e) //create matrix b
        {
            try
            {
                int rowsB, columnsB;
                if (int.TryParse(textBox1.Text, out rowsB) && int.TryParse(textBox2.Text, out columnsB))
                {
                    if (dataGridViewB != null && dataGridViewB.RowCount == rowsB && dataGridViewB.ColumnCount == columnsB)
                    {
                        matrixB = new Matrix(rowsB, columnsB);

                        // Loop through dataGridViewA to populate matrixA with its values
                        for (int i = 0; i < rowsB; i++)
                        {
                            for (int j = 0; j < columnsB; j++)
                            {
                                // Assuming matrixA is a two-dimensional array of type int[,]
                                matrixB.MArray[i, j] = Convert.ToInt32(dataGridViewB[j, i].Value);
                            }
                        }

                        MessageBox.Show("Macierz B została wypełniona danymi z DataGridView!");
                    
                        /*pkDzialaniaNaMacierzach.Controls.Remove(dataGridViewB);
                    dataGridViewB = null;*/
                    }
                    else
                    {
                        MessageBox.Show("DataGridView nie zostało utworzone lub ma inne wymiary niż macierz B!");
                    }
                }
                else
                {
                    MessageBox.Show("Wprowadź poprawne liczby dla wymiarów macierzy!");
                }
            
                Matrix.DebugPrint(matrixB);
            }
            catch (Exception exception)
            {
                MessageBox.Show("error capturing values");
                //throw;
            }
        }

        private void button10_Click(object sender, EventArgs e) //populate dataGrid a 
        {
            if (dataGridViewA != null)
            {
                // Wypełnienie komórek danymi losowymi
                Random random = new Random();
                int rowsA = dataGridViewA.RowCount;
                int columnsA = dataGridViewA.ColumnCount;

                for (int i = 0; i < rowsA; i++) {
                    for (int j = 0; j < columnsA; j++) {
                        dataGridViewA[j, i].Value = random.Next(1, 100); // Przykładowe wartości losowe
                    }
                }
            }
            else {
                MessageBox.Show("Najpierw wygeneruj DataGridView za pomocą przycisku wyżej!");
            } 
        }
        private void button13_Click(object sender, EventArgs e) //randomize for grid b
        {
            if (dataGridViewB != null)
            {
                // Wypełnienie komórek danymi losowymi
                Random random = new Random();
                int rowsA = dataGridViewB.RowCount;
                int columnsA = dataGridViewB.ColumnCount;

                for (int i = 0; i < rowsA; i++) {
                    for (int j = 0; j < columnsA; j++) {
                        dataGridViewB[j, i].Value = random.Next(1, 100); // Przykładowe wartości losowe
                    }
                }
            }
            else {
                MessageBox.Show("Najpierw wygeneruj DataGridView za pomocą przycisku wyżej!");
            } 
        }

        private void button1_Click(object sender, EventArgs e) //c = a + b
        {
            matrixC = matrixA + matrixB;
            Matrix.DebugPrint(matrixC);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            matrixC = matrixA - matrixB;
            Matrix.DebugPrint(matrixC);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            matrixC = matrixB - matrixA;
            Matrix.DebugPrint(matrixC);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            matrixC = matrixA * matrixB;
            Matrix.DebugPrint(matrixC);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Matrix.Zero(matrixA);
            }
            catch (Exception exception)
            {
                MessageBox.Show("matrix not created yet!!");
                //throw;
            }
            for(int i = 0; i < dataGridViewA.ColumnCount; i++)
            for (int j = 0; j < dataGridViewA.RowCount; j++)
                dataGridViewA[i, j].Value = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Matrix.Zero(matrixB);
            }
            catch (Exception exception)
            {
                MessageBox.Show("matrix not created yet!!");
                //throw;
            }
            for(int i = 0; i < dataGridViewB.ColumnCount; i++)
            for (int j = 0; j < dataGridViewB.RowCount; j++)
                dataGridViewB[i, j].Value = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {

            try
            {
                MessageBox.Show((matrixA == matrixB).ToString());
            }
            catch (Exception exception)
            {
                MessageBox.Show("one of the matrices not created yet");
                //throw;;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show((matrixA == matrixA).ToString() + "\n"
                            + "It's redundant tho :v");
        }


        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                A = ComplexNumber.FromTextbox(textBox3, textBox10);
                B = ComplexNumber.FromTextbox(textBox4, textBox9);

                C = A + B;
                textBox11.Text = C.ToString();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {

            try
            {
                A = ComplexNumber.FromTextbox(textBox3, textBox10);
                B = ComplexNumber.FromTextbox(textBox4, textBox9);

                C = A - B;
                textBox11.Text = C.ToString();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            

        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                A = ComplexNumber.FromTextbox(textBox3, textBox10);
                B = ComplexNumber.FromTextbox(textBox4, textBox9);

                C = A * B;
                textBox11.Text = C.ToString();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                A = ComplexNumber.FromTextbox(textBox3, textBox10);
                B = ComplexNumber.FromTextbox(textBox4, textBox9);

                C = A / B;
                textBox11.Text = (C.ToString());
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                A = ComplexNumber.FromTextbox(textBox3, textBox10);
                B = ComplexNumber.FromTextbox(textBox4, textBox9);
                E = ComplexNumber.FromTextbox(textBox6, textBox7);

                F = (A + B * E) - (E * A);
                textBox11.Text = (F.ToString());
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                A = ComplexNumber.FromTextbox(textBox3, textBox10);
            
                textBox11.Text = ((!A).ToString());
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                A = ComplexNumber.FromTextbox(textBox3, textBox10);
            
                textBox11.Text = ((-A).ToString());
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                
            }
        }


        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                A = ComplexNumber.FromTextbox(textBox3, textBox10);
                B = ComplexNumber.FromTextbox(textBox4, textBox9);
                textBox11.Text =((A!=B).ToString());
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                A = ComplexNumber.FromTextbox(textBox3, textBox10);
                B = ComplexNumber.FromTextbox(textBox4, textBox9);
                textBox11.Text = ((A==B).ToString());
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                A = ComplexNumber.FromTextbox(textBox3, textBox10);
            
                textBox11.Text = ((A.Re).ToString());
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            foreach (Control c in pkDzialaniaNaLiczbachZespolonych.Controls)
            {
                if (c is TextBox) c.Text = "";
            }
        }
    }
}