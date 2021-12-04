using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace DataBindings
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblАдрес_поставщика;
		private System.Windows.Forms.Label lblКод_поставщика;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label lblПоставщик;
		private System.Windows.Forms.Label lblТелефон;
		private System.Windows.Forms.TextBox txtProvider;
		private System.Windows.Forms.TextBox txtPhone;
		string commandText = "SELECT [Адрес поставщика], [Код поставщика], Поставщик, Телефон FROM Поставщики";
		string connectionString = @"Provider=""Microsoft.Jet.OLEDB.4.0"";Data Source=""D:\Uchebnik\Code\Glava4\RBProduct.mdb"";User ID=Admin;Jet OLEDB:Encrypt Database=False";
		CurrencyManager cmRecords;
		private System.Windows.Forms.Label lblRecordsPosition;
		private System.Windows.Forms.Button btnFirst;
		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnLast;
		
		
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
			txtAddress.DataBindings.Add("Text", ds, "Поставщики.Адрес поставщика");
			txtID.DataBindings.Add("Text", ds, "Поставщики.Код поставщика");
			txtPhone.DataBindings.Add("Text", ds, "Поставщики.Поставщик");
			txtProvider.DataBindings.Add("Text", ds, "Поставщики.Телефон");
			conn.Close();
			cmRecords = (CurrencyManager)BindingContext[ds, "Поставщики"];
			cmRecords.ItemChanged+=new ItemChangedEventHandler(cmRecords_ItemChanged);
			cmRecords.PositionChanged+=new EventHandler(cmRecords_PositionChanged);
			DisplayRecordsPosition();
			

			

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
			this.lblАдрес_поставщика = new System.Windows.Forms.Label();
			this.lblКод_поставщика = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.lblПоставщик = new System.Windows.Forms.Label();
			this.lblТелефон = new System.Windows.Forms.Label();
			this.txtProvider = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.btnFirst = new System.Windows.Forms.Button();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnLast = new System.Windows.Forms.Button();
			this.lblRecordsPosition = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblАдрес_поставщика
			// 
			this.lblАдрес_поставщика.Location = new System.Drawing.Point(8, 8);
			this.lblАдрес_поставщика.Name = "lblАдрес_поставщика";
			this.lblАдрес_поставщика.Size = new System.Drawing.Size(100, 32);
			this.lblАдрес_поставщика.TabIndex = 11;
			this.lblАдрес_поставщика.Text = "Адрес поставщика";
			// 
			// lblКод_поставщика
			// 
			this.lblКод_поставщика.Location = new System.Drawing.Point(8, 48);
			this.lblКод_поставщика.Name = "lblКод_поставщика";
			this.lblКод_поставщика.TabIndex = 12;
			this.lblКод_поставщика.Text = "Код поставщика";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(120, 16);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(184, 20);
			this.txtAddress.TabIndex = 13;
			this.txtAddress.Text = "";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(120, 48);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(184, 20);
			this.txtID.TabIndex = 14;
			this.txtID.Text = "";
			// 
			// lblПоставщик
			// 
			this.lblПоставщик.Location = new System.Drawing.Point(8, 80);
			this.lblПоставщик.Name = "lblПоставщик";
			this.lblПоставщик.TabIndex = 15;
			this.lblПоставщик.Text = "Поставщик";
			// 
			// lblТелефон
			// 
			this.lblТелефон.Location = new System.Drawing.Point(8, 112);
			this.lblТелефон.Name = "lblТелефон";
			this.lblТелефон.TabIndex = 16;
			this.lblТелефон.Text = "Телефон";
			// 
			// txtProvider
			// 
			this.txtProvider.Location = new System.Drawing.Point(120, 80);
			this.txtProvider.Name = "txtProvider";
			this.txtProvider.Size = new System.Drawing.Size(184, 20);
			this.txtProvider.TabIndex = 17;
			this.txtProvider.Text = "";
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(120, 112);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(184, 20);
			this.txtPhone.TabIndex = 18;
			this.txtPhone.Text = "";
			// 
			// btnFirst
			// 
			this.btnFirst.Location = new System.Drawing.Point(72, 152);
			this.btnFirst.Name = "btnFirst";
			this.btnFirst.Size = new System.Drawing.Size(32, 23);
			this.btnFirst.TabIndex = 24;
			this.btnFirst.Text = "|<";
			this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
			// 
			// btnPrevious
			// 
			this.btnPrevious.Location = new System.Drawing.Point(104, 152);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(32, 23);
			this.btnPrevious.TabIndex = 24;
			this.btnPrevious.Text = "<";
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(224, 152);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(32, 23);
			this.btnNext.TabIndex = 24;
			this.btnNext.Text = ">";
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnLast
			// 
			this.btnLast.Location = new System.Drawing.Point(256, 152);
			this.btnLast.Name = "btnLast";
			this.btnLast.Size = new System.Drawing.Size(32, 23);
			this.btnLast.TabIndex = 24;
			this.btnLast.Text = ">|";
			this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
			// 
			// lblRecordsPosition
			// 
			this.lblRecordsPosition.Location = new System.Drawing.Point(136, 152);
			this.lblRecordsPosition.Name = "lblRecordsPosition";
			this.lblRecordsPosition.TabIndex = 25;
			this.lblRecordsPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(328, 190);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.lblRecordsPosition);
			this.Controls.Add(this.btnFirst);
			this.Controls.Add(this.lblАдрес_поставщика);
			this.Controls.Add(this.lblКод_поставщика);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.lblПоставщик);
			this.Controls.Add(this.lblТелефон);
			this.Controls.Add(this.txtProvider);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.btnPrevious);
			this.Controls.Add(this.btnLast);
			this.Name = "Form1";
			this.Text = "Form1";
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

		
		private void DisplayRecordsPosition()
		{
			lblRecordsPosition.Text = "Запись" + (cmRecords.Position + 1) + "из" + cmRecords.Count;
		}
		private void cmRecords_ItemChanged( object sender, ItemChangedEventArgs e)
		{
			DisplayRecordsPosition();
		}
		private void cmRecords_PositionChanged( object sender, System.EventArgs e)
		{
			DisplayRecordsPosition();
		}


		private void btnFirst_Click(object sender, System.EventArgs e)
		{
			cmRecords.Position = 0;
		}

		private void btnPrevious_Click(object sender, System.EventArgs e)
		{
			cmRecords.Position--;
		}

		private void btnNext_Click(object sender, System.EventArgs e)
		{
			cmRecords.Position++;
		}

		private void btnLast_Click(object sender, System.EventArgs e)
		{
			cmRecords.Position = cmRecords.Count - 1;
		}

		

		

		
	

	}
}
