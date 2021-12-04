using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace DataGrid2Table
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		string commandText = "SELECT [Адрес поставщика], [Код поставщика], Поставщик, Телефон FROM Поставщики";
		string connectionString = @"Provider=""Microsoft.Jet.OLEDB.4.0"";Data Source=""D:\Uchebnik\Code\Glava4\RBProduct.mdb"";User ID=Admin;Jet OLEDB:Encrypt Database=False";
		string commandText2 = "SELECT [Код поставщика], [Код продукта], Наименование, [Цена, $] FROM Товары";
			
			
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
			OleDbConnection conn = new OleDbConnection(connectionString);
			conn.Open();
			OleDbCommand myCommand = new OleDbCommand();
			myCommand.Connection = conn;
			myCommand.CommandText = commandText;
			OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
			dataAdapter.SelectCommand = myCommand;
			DataSet ds = new DataSet();
			dataAdapter.TableMappings.Add("Table", "Поставщики");
			dataAdapter.Fill(ds);
			dataGrid1.DataSource = ds.Tables["Поставщики"].DefaultView;
			OleDbCommand myCommand2 = new OleDbCommand();
			myCommand2.Connection = conn;
			myCommand2.CommandText = commandText2;
			OleDbDataAdapter dataAdapter2 = new OleDbDataAdapter();
			dataAdapter2.SelectCommand = myCommand2;
			dataAdapter2.TableMappings.Add("Table", "Товары");
			dataAdapter2.Fill(ds);
			DataRelation dataRelation;
			DataColumn dataColumn1;
			DataColumn dataColumn2;
			dataColumn1 = ds.Tables["Поставщики"].Columns["Код поставщика"];
			dataColumn2 = ds.Tables["Товары"].Columns["Код поставщика"];
			dataRelation = new DataRelation("Товары этого поставщика", dataColumn1, dataColumn2);
			ds.Relations.Add(dataRelation);
			DataViewManager dsview = ds.DefaultViewManager;
			dataGrid1.DataSource = dsview;
			dataGrid1.DataMember = "Поставщики";
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

		

		
	}
}
