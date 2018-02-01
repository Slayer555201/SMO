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
using System.Threading;


public interface IEquatable<T>
{
}
namespace SMO
{

    public partial class SMO : Form
    {
        public SMO()
        {
            InitializeComponent();
        }
        public enum TypeOfPool { PCRD = 1, ICRD = 2, TAX = 3, PAID = 4 }


        public class Request : IEquatable<Request>
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public TypeOfPool Typ { get; set; }
            public string Dat { get; set; }
            public string Status { get; set; }

            public Request(int v1, TypeOfPool v2, string v3)
            {
                ID = v1;
                Name = "Заявка № " + v1;
                Typ = v2;
                Dat = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                Status = v3;
            }
            public override string ToString()
            {
                //return string.Format("{0}  {1}", ID, Name);
                return string.Format("{0}", ID);
            }
        }
        int Z = 0;
        static List<Request> req = new List<Request>();
        List<Request> req1 = new List<Request>();
        List<Request> req2 = new List<Request>();
        List<Request> req3 = new List<Request>();
        List<Request> req4 = new List<Request>();

        private void button1_Click(object sender, EventArgs e)
        {
            int N = 2;

            Random ran = new Random();


            for (int i = 1; i <= N; i++)
            {
   
                //Console.WriteLine(N);
                Z += 1;

                var t2 = ran.Next(1, 5).ToString();
                TypeOfPool t1 = (TypeOfPool)Enum.Parse(typeof(TypeOfPool), t2);
                req.Add(new Request(Z, t1, "new")); //{ ID = i, Dat = DateTime.Today, Name = "Заявка № " + i, Typ = "CRED" });
                //this.dataGridView1.Rows.Insert( i, DateTime.Today,  "Заявка № " + i, "CRED" );
                // req.Remove(new Request(i,t1));
                if (t2 == "1")
                    req1.Add(new Request(Z, t1, "new"));
                if (t2 == "2")
                    req2.Add(new Request(Z, t1, "new"));
                if (t2 == "3")
                    req3.Add(new Request(Z, t1, "new"));
                if (t2 == "4")
                    req4.Add(new Request(Z, t1, "new"));
                //if (Z == 20)
                //{
                //    MessageBox.Show("Очередь заявок заполнена");
                //    timer1.Stop();
                //    break;
                //}
            }
            //dataGridView1.DataSource = req;
            //Console.WriteLine();
            dataGridView1.Rows.Clear();
            //req.Sort();

            //Console.WriteLine(req.Count()); 
            foreach (var j in req)
            {
                dataGridView1.Rows.Add(j.ID, j.Dat, j.Name, j.Typ, j.Status);
            }
            dataGridView2.Rows.Clear();
            foreach (var j in req1)
            {
                dataGridView2.Rows.Add(j.ID, j.Dat, j.Name, j.Typ);
            }
            dataGridView4.Rows.Clear();
            foreach (var j in req2)
            {
                dataGridView4.Rows.Add(j.ID, j.Dat, j.Name, j.Typ);
            }
            dataGridView5.Rows.Clear();
            foreach (var j in req3)
            {
                dataGridView5.Rows.Add(j.ID, j.Dat, j.Name, j.Typ);
            }
            dataGridView6.Rows.Clear();
            foreach (var j in req4)
            {
                dataGridView6.Rows.Add(j.ID, j.Dat, j.Name, j.Typ);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var column1 = new DataGridViewColumn();
            column1.HeaderText = "ID";
            column1.Width = 35;
            column1.ReadOnly = true;
            column1.Name = "ID";
            column1.Frozen = true;
            column1.CellTemplate = new DataGridViewTextBoxCell();

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Дата";
            column2.Width = 110;
            column2.ReadOnly = true;
            column2.Name = "Dat";
            column2.Frozen = true;
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "№ заявки";
            column3.Width = 80;
            column3.ReadOnly = true;
            column3.Name = "Name";
            column3.Frozen = true;
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Тип заявки";
            column4.Width = 50;
            column4.ReadOnly = true;
            column4.Name = "Typ";
            column4.Frozen = true;
            column4.CellTemplate = new DataGridViewTextBoxCell();


            var column4_2 = new DataGridViewColumn();
            column4_2.HeaderText = "Статус";
            column4_2.Width = 50;
            column4_2.ReadOnly = true;
            column4_2.Name = "Status";
            column4_2.Frozen = true;
            column4_2.CellTemplate = new DataGridViewTextBoxCell();

            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            dataGridView1.Columns.Add(column3);
            dataGridView1.Columns.Add(column4);
            dataGridView1.Columns.Add(column4_2);

            var column5 = new DataGridViewColumn();
            column5.HeaderText = "ID";
            column5.Width = 35;
            column5.ReadOnly = true;
            column5.Name = "ID";
            column5.Frozen = true;
            column5.CellTemplate = new DataGridViewTextBoxCell();


            var column6 = new DataGridViewColumn();
            column6.HeaderText = "Дата";
            column6.Width = 110;
            column6.ReadOnly = true;
            column6.Name = "Dat";
            column6.Frozen = true;
            column6.CellTemplate = new DataGridViewTextBoxCell();


            var column7 = new DataGridViewColumn();
            column7.HeaderText = "№ заявки";
            column7.Width = 80;
            column7.ReadOnly = true;
            column7.Name = "Name";
            column7.Frozen = true;
            column7.CellTemplate = new DataGridViewTextBoxCell();

            var column8 = new DataGridViewColumn();
            column8.HeaderText = "Тип заявки";
            column8.Width = 50;
            column8.ReadOnly = true;
            column8.Name = "Typ";
            column8.Frozen = true;
            column8.CellTemplate = new DataGridViewTextBoxCell();

            dataGridView2.Columns.Add(column5);
            dataGridView2.Columns.Add(column6);
            dataGridView2.Columns.Add(column7);
            dataGridView2.Columns.Add(column8);
            dataGridView2.Columns["ID"].Visible = false;

            var column9 = new DataGridViewColumn();//DataGridView4
            column9.HeaderText = "ID";
            column9.Width = 35;
            column9.ReadOnly = true;
            column9.Name = "ID";
            column9.Frozen = true;
            column9.CellTemplate = new DataGridViewTextBoxCell();


            var column10 = new DataGridViewColumn();
            column10.HeaderText = "Дата";
            column10.Width = 110;
            column10.ReadOnly = true;
            column10.Name = "Dat";
            column10.Frozen = true;
            column10.CellTemplate = new DataGridViewTextBoxCell();


            var column11 = new DataGridViewColumn();
            column11.HeaderText = "№ заявки";
            column11.Width = 80;
            column11.ReadOnly = true;
            column11.Name = "Name";
            column11.Frozen = true;
            column11.CellTemplate = new DataGridViewTextBoxCell();

            var column12 = new DataGridViewColumn();
            column12.HeaderText = "Тип заявки";
            column12.Width = 50;
            column12.ReadOnly = true;
            column12.Name = "Typ";
            column12.Frozen = true;
            column12.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView4.Columns.Add(column9);
            dataGridView4.Columns.Add(column10);
            dataGridView4.Columns.Add(column11);
            dataGridView4.Columns.Add(column12);
            dataGridView4.Columns["ID"].Visible = false;



            var column13 = new DataGridViewColumn();//DataGridView5
            column13.HeaderText = "ID";
            column13.Width = 35;
            column13.ReadOnly = true;
            column13.Name = "ID";
            column13.Frozen = true;
            column13.CellTemplate = new DataGridViewTextBoxCell();


            var column14 = new DataGridViewColumn();
            column14.HeaderText = "Дата";
            column14.Width = 110;
            column14.ReadOnly = true;
            column14.Name = "Dat";
            column14.Frozen = true;
            column14.CellTemplate = new DataGridViewTextBoxCell();


            var column15 = new DataGridViewColumn();
            column15.HeaderText = "№ заявки";
            column15.Width = 80;
            column15.ReadOnly = true;
            column15.Name = "Name";
            column15.Frozen = true;
            column15.CellTemplate = new DataGridViewTextBoxCell();

            var column16 = new DataGridViewColumn();
            column16.HeaderText = "Тип заявки";
            column16.Width = 50;
            column16.ReadOnly = true;
            column16.Name = "Typ";
            column16.Frozen = true;
            column16.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView5.Columns.Add(column13);
            dataGridView5.Columns.Add(column14);
            dataGridView5.Columns.Add(column15);
            dataGridView5.Columns.Add(column16);
            dataGridView5.Columns["ID"].Visible = false;

            var column17 = new DataGridViewColumn();//DataGridView6
            column17.HeaderText = "ID";
            column17.Width = 35;
            column17.ReadOnly = true;
            column17.Name = "ID";
            column17.Frozen = true;
            column17.CellTemplate = new DataGridViewTextBoxCell();


            var column18 = new DataGridViewColumn();
            column18.HeaderText = "Дата";
            column18.Width = 110;
            column18.ReadOnly = true;
            column18.Name = "Dat";
            column18.Frozen = true;
            column18.CellTemplate = new DataGridViewTextBoxCell();


            var column19 = new DataGridViewColumn();
            column19.HeaderText = "№ заявки";
            column19.Width = 80;
            column19.ReadOnly = true;
            column19.Name = "Name";
            column19.Frozen = true;
            column19.CellTemplate = new DataGridViewTextBoxCell();

            var column20 = new DataGridViewColumn();
            column20.HeaderText = "Тип заявки";
            column20.Width = 50;
            column20.ReadOnly = true;
            column20.Name = "Typ";
            column20.Frozen = true;
            column20.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView6.Columns.Add(column17);
            dataGridView6.Columns.Add(column18);
            dataGridView6.Columns.Add(column19);
            dataGridView6.Columns.Add(column20);
            dataGridView6.Columns["ID"].Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer1.Tick += new System.EventHandler(this.button1_Click);

            button1_Click(button1, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        public int w;
        public void remove_req1()
        {
            if (tm1.Enabled)
                tm1.Stop();
            label1.BackColor = Color.Red;
            wait(1500);
            w -= 1;
            req.RemoveAt(w);
            var t2 = "1";
            TypeOfPool t1 = (TypeOfPool)Enum.Parse(typeof(TypeOfPool), t2);
            req.Insert(w, new Request(w + 1, t1, "OK"));
            label1.BackColor = Color.Green;
            label1.Text = "";
            tm1.Start();
        }

        public void remove_req2()
        {
            if (tm2.Enabled)
                tm2.Stop();
            label2.BackColor = Color.Red;
            wait(1000);
            w -= 1;
            req.RemoveAt(w);
            var t2 = "2";
            TypeOfPool t1 = (TypeOfPool)Enum.Parse(typeof(TypeOfPool), t2);
            req.Insert(w, new Request(w + 1, t1, "OK"));
            label2.BackColor = Color.Green;
            label2.Text = "";
            tm2.Start();
        }

        public void remove_req3()
        {
            if (tm3.Enabled)
                tm3.Stop();
            label3.BackColor = Color.Red;
            wait(1000);
            w -= 1;
            req.RemoveAt(w);
            var t2 = "3";
            TypeOfPool t1 = (TypeOfPool)Enum.Parse(typeof(TypeOfPool), t2);
            req.Insert(w, new Request(w + 1, t1, "OK"));
            label3.BackColor = Color.Green;
            label3.Text = "";
            tm3.Start();
        }
        public void remove_req4()
        {
            if (tm4.Enabled)
                tm4.Stop();
            label4.BackColor = Color.Red;
            wait(1000);
            w -= 1;
            req.RemoveAt(w);
            var t2 = "3";
            TypeOfPool t1 = (TypeOfPool)Enum.Parse(typeof(TypeOfPool), t2);
            req.Insert(w, new Request(w + 1, t1, "OK"));
            label4.BackColor = Color.Green;
            label4.Text = "";
            tm4.Start();
        }

        private void tm1_Tick_1(object sender, EventArgs e)
        {
            if (req1.Count() > 0)
            {

                string fmt = "000000.##";
                //int a = Int32.Parse(req1.First().ToString());
                w = Int32.Parse(req1[0].ToString());
                //MessageBox.Show(w.ToString());
                label1.BackColor = Color.Green;
                label1.Text = w.ToString(fmt);
                wait(500);
                req1.RemoveAt(0);
                dataGridView2.Rows.RemoveAt(0);
                dataGridView2.Refresh();
                remove_req1();
   
            }


        }

        public void wait(int q)
        {
            var t = Task.Run(async delegate
            {
                await Task.Delay(q);
                return 42;
            });
            t.Wait();
        }

        private void tm2_Tick(object sender, EventArgs e)
        {
            if (req2.Count() > 0)
            {
                string fmt = "000000.##";
                w = Int32.Parse(req2[0].ToString());
                label2.BackColor = Color.Green;
                label2.Text = w.ToString(fmt);
                wait(1000);
                req2.RemoveAt(0);
                dataGridView4.Rows.RemoveAt(0);
                dataGridView4.Refresh();
                remove_req2();
            }
        }

        private void tm3_Tick(object sender, EventArgs e)
        {
            if (req3.Count() > 0)
            {
                string fmt = "000000.##";
                w = Int32.Parse(req3[0].ToString());
                label3.BackColor = Color.Green;
                label3.Text = w.ToString(fmt);
                wait(1000);
                req3.RemoveAt(0);
                dataGridView5.Rows.RemoveAt(0);
                dataGridView5.Refresh();
                remove_req3();
            }
        }

        private void tm4_Tick(object sender, EventArgs e)
        {
            if (req4.Count() > 0)
            {
                string fmt = "000000.##";
                w = Int32.Parse(req4[0].ToString());
                label4.BackColor = Color.Green;
                label4.Text = w.ToString(fmt);
                wait(1000);
                req4.RemoveAt(0);
                dataGridView6.Rows.RemoveAt(0);
                dataGridView6.Refresh();
                remove_req4();
            }
        }
    }
}
