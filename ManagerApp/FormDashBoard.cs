using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerApp
{
    public partial class FormDashBoard : Form
    {
        public FormDashBoard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InitializeComponent()
        {
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormDashBoard));
            tabPageControl = new TabControl();
            tabPageHome = new TabPage();
            tabPage2 = new TabPage();
            groupBoxUser = new GroupBox();
            CboCustomerType = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            Label1 = new Label();
            textBox1 = new TextBox();
            txtCustomer = new TextBox();
            tabPage1 = new TabPage();
            button1 = new Button();
            imageList1 = new ImageList(components);
            People = new Label();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            label14 = new Label();
            button5 = new Button();
            button6 = new Button();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            button7 = new Button();
            tabPageControl.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBoxUser.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageControl
            // 
            tabPageControl.Controls.Add(tabPageHome);
            tabPageControl.Controls.Add(tabPage2);
            tabPageControl.Controls.Add(tabPage1);
            tabPageControl.Dock = DockStyle.Fill;
            tabPageControl.ImageList = imageList1;
            tabPageControl.Location = new Point(0, 0);
            tabPageControl.Name = "tabPageControl";
            tabPageControl.SelectedIndex = 0;
            tabPageControl.Size = new Size(939, 383);
            tabPageControl.TabIndex = 0;
            // 
            // tabPageHome
            // 
            tabPageHome.ImageIndex = 0;
            tabPageHome.Location = new Point(4, 39);
            tabPageHome.Name = "tabPageHome";
            tabPageHome.Padding = new Padding(3);
            tabPageHome.Size = new Size(931, 340);
            tabPageHome.TabIndex = 0;
            tabPageHome.Text = "Home";
            tabPageHome.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBoxUser);
            tabPage2.ImageIndex = 1;
            tabPage2.Location = new Point(4, 39);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(931, 340);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "WaterBIll";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // groupBoxUser
            // 
            groupBoxUser.Controls.Add(groupBox5);
            groupBoxUser.Controls.Add(groupBox4);
            groupBoxUser.Controls.Add(groupBox3);
            groupBoxUser.Controls.Add(button7);
            groupBoxUser.Controls.Add(button6);
            groupBoxUser.Controls.Add(button5);
            groupBoxUser.Controls.Add(People);
            groupBoxUser.Controls.Add(CboCustomerType);
            groupBoxUser.Controls.Add(label14);
            groupBoxUser.Controls.Add(label3);
            groupBoxUser.Controls.Add(label2);
            groupBoxUser.Controls.Add(Label1);
            groupBoxUser.Controls.Add(textBox1);
            groupBoxUser.Controls.Add(textBox9);
            groupBoxUser.Controls.Add(textBox8);
            groupBoxUser.Controls.Add(txtCustomer);
            groupBoxUser.Location = new Point(3, 6);
            groupBoxUser.Name = "groupBoxUser";
            groupBoxUser.Size = new Size(932, 241);
            groupBoxUser.TabIndex = 0;
            groupBoxUser.TabStop = false;
            groupBoxUser.Text = "User's Information";
            // 
            // CboCustomerType
            // 
            CboCustomerType.FormattingEnabled = true;
            CboCustomerType.Items.AddRange(new object[] { "Household", "Administrative", "Production units", "Business" });
            CboCustomerType.Location = new Point(128, 80);
            CboCustomerType.Name = "CboCustomerType";
            CboCustomerType.Size = new Size(353, 23);
            CboCustomerType.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(511, 33);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 2;
            label3.Text = "Water LastMonth";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 79);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 2;
            label2.Text = "Customer Type";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(23, 38);
            Label1.Name = "Label1";
            Label1.Size = new Size(59, 15);
            Label1.TabIndex = 1;
            Label1.Text = "Customer";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(128, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(353, 23);
            textBox1.TabIndex = 0;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(128, 30);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(353, 23);
            txtCustomer.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.ForeColor = Color.Crimson;
            tabPage1.ImageIndex = 2;
            tabPage1.Location = new Point(4, 39);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(828, 340);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "tabExit";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(249, 23);
            button1.Name = "button1";
            button1.Size = new Size(175, 80);
            button1.TabIndex = 0;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "home-icon.png");
            imageList1.Images.SetKeyName(1, "Invoice-Bill-Payment-Billing-Hospital-icon.png");
            imageList1.Images.SetKeyName(2, "Users-Exit-icon.png");
            // 
            // People
            // 
            People.AutoSize = true;
            People.Location = new Point(41, 129);
            People.Name = "People";
            People.Size = new Size(44, 15);
            People.TabIndex = 4;
            People.Text = "label14";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(628, 30);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(353, 23);
            textBox8.TabIndex = 0;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(628, 76);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(353, 23);
            textBox9.TabIndex = 0;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(511, 84);
            label14.Name = "label14";
            label14.Size = new Size(117, 15);
            label14.TabIndex = 2;
            label14.Text = "Water CurrentMonth";
            // 
            // button5
            // 
            button5.Location = new Point(596, 131);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 5;
            button5.Text = "Add +";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(711, 131);
            button6.Name = "button6";
            button6.Size = new Size(106, 23);
            button6.TabIndex = 5;
            button6.Text = "remove item";
            button6.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(6, 241);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(930, 100);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            groupBox4.Location = new Point(12, 237);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(880, 100);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // groupBox5
            // 
            groupBox5.Location = new Point(78, 208);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(808, 100);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Data";
            // 
            // button7
            // 
            button7.Location = new Point(822, 131);
            button7.Name = "button7";
            button7.Size = new Size(106, 23);
            button7.TabIndex = 5;
            button7.Text = "Clear";
            button7.UseVisualStyleBackColor = true;
            // 
            // FormDashBoard
            // 
            ClientSize = new Size(939, 383);
            Controls.Add(tabPageControl);
            Name = "FormDashBoard";
            tabPageControl.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBoxUser.ResumeLayout(false);
            groupBoxUser.PerformLayout();
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TabControl tabPageControl;
        private TabPage tabPageHome;
        private ImageList imageList1;
        private IContainer components;
        private TabPage tabPage1;
        private Button button1;
        private GroupBox groupBoxUser;
        private Label Label1;
        private TextBox txtCustomer;
        private ComboBox CboCustomerType;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label People;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Button button6;
        private Button button5;
        private Label label14;
        private TextBox textBox9;
        private TextBox textBox8;
        private GroupBox groupBox5;
        private Button button7;
        private TabPage tabPage2;

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
