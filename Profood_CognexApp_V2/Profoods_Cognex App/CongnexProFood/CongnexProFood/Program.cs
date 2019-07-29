using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data;

namespace CongnexProFood
{
    public partial class Program : Form
    {
        public Program()
        {
            InitializeComponent();
            
        }

        static SerialPort SP;
        private Panel panel1;
        private TextBox textBox1;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Panel panel4;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private _Cognex_TestDataSet _Cognex_TestDataSet;
        private BindingSource codeMasterBindingSource;
        private System.ComponentModel.IContainer components;
        private _Cognex_TestDataSetTableAdapters.CodeMasterTableAdapter codeMasterTableAdapter;
        private TextBox textBox6;
        private TextBox orderform;
        private TextBox reject;
        private TextBox count;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox textBox13;
        private Label label16;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;




        static void Main(string[] args)
        {
            SqlConnection con;
            string str;
            string bcode;
            string logtime;
            SP = new SerialPort();
            SP.PortName = "COM6";
            SP.BaudRate = 9600;
            SP.DtrEnable = true;
            //SP.WriteLine("+");
            //SP.ReadTimeout = 500;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Program());

            try
            {
                str = @"Data Source=localhost;Initial Catalog=Cognex;Integrated Security=True";
                con = new SqlConnection(str);
                con.Open();
                //  Console.Write("SQL Connection Open; Press any key to continue");
                //  Console.ReadLine();

                // SP.Open();


                while (true)

                {

                    bcode = SP.ReadLine();
                    logtime = DateTime.Now.ToString();
                    Console.WriteLine(logtime + " : " + bcode);
                    string query = "INSERT INTO bcodelog (bcode,logtime) VALUES('" + bcode + "','" + logtime + "')";
                    SqlCommand ins = new SqlCommand(query, con);
                    ins.ExecuteNonQuery();



                }
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }



        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.orderform = new System.Windows.Forms.TextBox();
            this.reject = new System.Windows.Forms.TextBox();
            this.count = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._Cognex_TestDataSet = new CongnexProFood._Cognex_TestDataSet();
            this.codeMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeMasterTableAdapter = new CongnexProFood._Cognex_TestDataSetTableAdapters.CodeMasterTableAdapter();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Cognex_TestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeMasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1421, 242);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.textBox13);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Controls.Add(this.textBox5);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(0, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1418, 187);
            this.panel4.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(147, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 25);
            this.comboBox1.TabIndex = 27;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Location = new System.Drawing.Point(147, 137);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(185, 22);
            this.textBox13.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(7, 135);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 21);
            this.label16.TabIndex = 25;
            this.label16.Text = "Deliver Route";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(147, 107);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(185, 22);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(147, 77);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(185, 22);
            this.textBox5.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(482, 23);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(185, 22);
            this.textBox3.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Deliver Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Customer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(347, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Order Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Barcode ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(147, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Order Number";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.orderform);
            this.panel2.Controls.Add(this.reject);
            this.panel2.Controls.Add(this.count);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(12, 309);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1418, 160);
            this.panel2.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(928, 39);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 13;
            // 
            // orderform
            // 
            this.orderform.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.orderform.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderform.Location = new System.Drawing.Point(232, 89);
            this.orderform.Multiline = true;
            this.orderform.Name = "orderform";
            this.orderform.Size = new System.Drawing.Size(100, 22);
            this.orderform.TabIndex = 6;
            // 
            // reject
            // 
            this.reject.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.reject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reject.Location = new System.Drawing.Point(232, 60);
            this.reject.Multiline = true;
            this.reject.Name = "reject";
            this.reject.Size = new System.Drawing.Size(100, 22);
            this.reject.TabIndex = 5;
            // 
            // count
            // 
            this.count.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.count.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.count.Location = new System.Drawing.Point(232, 29);
            this.count.Multiline = true;
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(100, 22);
            this.count.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "No of Processed OrderForms";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Rejected No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Count";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(12, 513);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1418, 285);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1378, 250);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1067, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1174, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1281, 475);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Order Form Details";
            // 
            // _Cognex_TestDataSet
            // 
            this._Cognex_TestDataSet.DataSetName = "_Cognex_TestDataSet";
            this._Cognex_TestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // codeMasterBindingSource
            // 
            this.codeMasterBindingSource.DataMember = "CodeMaster";
            this.codeMasterBindingSource.DataSource = this._Cognex_TestDataSet;
            // 
            // codeMasterTableAdapter
            // 
            this.codeMasterTableAdapter.ClearBeforeFill = true;
            // 
            // Program
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1432, 810);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Name = "Program";
            this.Load += new System.EventHandler(this.Program_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Cognex_TestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeMasterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Program_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Cognex_TestDataSet.CodeMaster' table. You can move, or remove it, as needed.
            this.codeMasterTableAdapter.Fill(this._Cognex_TestDataSet.CodeMaster);
            SP.Open();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel4.Visible = false;
        }

        
        



         void FillCombo()
          {
              SqlConnection con = new SqlConnection("Data Source = 127.0.0.1; Initial Catalog = Cognex-Test; user = sa; password = ##2980dc;");

              String order = textBox1.Text;

              string quary = "SELECT Bcode1, Bcode2, Bcode3, Bcode4 FROM odrform WHERE orderNumber = " + @order;

              SqlCommand cmd = new SqlCommand(quary, con);

              try
              {
                  con.Open();
                  SqlDataReader sdr = cmd.ExecuteReader();

                  while (sdr.Read())
                  {
                      string order1 = sdr["Bcode1"].ToString();
                      comboBox1.Items.Add(order1);
                      string order2 = sdr["Bcode2"].ToString();
                      comboBox1.Items.Add(order2);
                      string order3 = sdr["Bcode3"].ToString();
                      comboBox1.Items.Add(order3);
                      string order4 = sdr["Bcode4"].ToString();
                      comboBox1.Items.Add(order4);

                    
                  }
              }
              catch(Exception ex )
              {
                  MessageBox.Show(ex.Message);

              }

          }

        private void button1_Click(object sender, EventArgs e)
        {
            String barcode2 = SP.ReadLine();

            SqlConnection con = new SqlConnection("Data Source = 127.0.0.1; Initial Catalog = Cognex-Test; user = sa; password =##2980dc;");
                con.Open();
                string quary = "SELECT barcode,batchNumber,category,mnfDate,expDate,prdOrder  FROM CodeMaster  WHERE barcode =" + @barcode2;
                SqlCommand cmd = new SqlCommand(quary, con);

                try

                {
                    SqlDataAdapter da = new SqlDataAdapter();

                    da.SelectCommand = cmd;

                    DataTable dt = new DataTable();


                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                    con.Close();

                }

                catch (SqlException ex)

                {

                    MessageBox.Show(ex.Message);

                }

            
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            FillCombo();
            String order = textBox1.Text;
            panel1.Visible = true;
            panel4.Visible = true;
            //textBox6.Text = SP.ReadLine();
            SqlConnection con = new SqlConnection("Data Source = 127.0.0.1; Initial Catalog = Cognex-Test; user = sa; password =##2980dc;");


            String quary = "SELECT customer,DDate,DRoute  FROM odrform  WHERE orderNumber =" + @order;
            SqlCommand cmd = new SqlCommand(quary, con);

            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            // cmd.Parameters.AddWithValue("@order", int.Parse(textBox1.Text));
            con.Open();
          

            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
               
                
                textBox5.Text = sdr["customer"].ToString();
                textBox4.Text = sdr["DDate"].ToString();
                textBox13.Text = sdr["DRoute"].ToString();

            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    
    

