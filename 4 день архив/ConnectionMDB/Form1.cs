using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace ConnectionMDB
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		string ConnectionString = @"Provider=""Microsoft.Jet.OLEDB.4.0""; Data Source=""E:\Program Files\Microsoft Visual Studio .NET 2003\Crystal Reports\Samples\Database\xtreme.mdb"";User ID=Admin;Jet OLEDB:Encrypt Database=False";
		string commandText = @"SELECT Address1, Address2, City, [Contact First Name], [Contact Last Name], [Contact Position], [Contact Title], Country, [Customer Credit ID], [Customer ID], [Customer Name], [E-mail], Fax, [Last Year's Sales], Phone, [Postal Code], Region, [Web Site] FROM Customer";


		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			OleDbConnection  conn = new OleDbConnection(ConnectionString);
 //			OleDbConnection  conn = new OleDbConnection(); 
//			conn.ConnectionString = ConnectionString;
			conn.Open();
			OleDbCommand myCommand = new OleDbCommand();
			myCommand.Connection = conn;
			myCommand.CommandText = commandText;
			//OleDbCommand myCommand = conn.CreateCommand();
			myCommand.CommandText = commandText;
			OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
			dataAdapter.SelectCommand = myCommand;
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds, "Customers");
			dataGrid1.DataSource = ds.Tables["Customers"].DefaultView;
			conn.Close();



			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 0);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(292, 266);
			this.dataGrid1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.dataGrid1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
		
		}
	}
}
