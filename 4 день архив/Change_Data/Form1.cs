using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Change_Data
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lbl�����_����������;
		private System.Windows.Forms.Label lbl���_����������;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label lbl���������;
		private System.Windows.Forms.Label lbl�������;
		private System.Windows.Forms.TextBox txtProvider;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Label lblRecordsPosition;
		private System.Windows.Forms.Button btnFirst;
		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.Button btnLast;
		CurrencyManager cmRecords;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private Change_Data.dsProviders dsProviders1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnSave;
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

			oleDbDataAdapter1.Fill(dsProviders1);
			cmRecords = (CurrencyManager)BindingContext[dsProviders1, "����������"];
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
			this.lbl�����_���������� = new System.Windows.Forms.Label();
			this.lbl���_���������� = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.dsProviders1 = new Change_Data.dsProviders();
			this.txtID = new System.Windows.Forms.TextBox();
			this.lbl��������� = new System.Windows.Forms.Label();
			this.lbl������� = new System.Windows.Forms.Label();
			this.txtProvider = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.btnNext = new System.Windows.Forms.Button();
			this.lblRecordsPosition = new System.Windows.Forms.Label();
			this.btnFirst = new System.Windows.Forms.Button();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.btnLast = new System.Windows.Forms.Button();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dsProviders1)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl�����_����������
			// 
			this.lbl�����_����������.Location = new System.Drawing.Point(24, 16);
			this.lbl�����_����������.Name = "lbl�����_����������";
			this.lbl�����_����������.Size = new System.Drawing.Size(100, 32);
			this.lbl�����_����������.TabIndex = 19;
			this.lbl�����_����������.Text = "����� ����������";
			// 
			// lbl���_����������
			// 
			this.lbl���_����������.Location = new System.Drawing.Point(24, 56);
			this.lbl���_����������.Name = "lbl���_����������";
			this.lbl���_����������.TabIndex = 20;
			this.lbl���_����������.Text = "��� ����������";
			// 
			// txtAddress
			// 
			this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProviders1, "����������.����� ����������"));
			this.txtAddress.Location = new System.Drawing.Point(136, 24);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(184, 20);
			this.txtAddress.TabIndex = 21;
			this.txtAddress.Text = "";
			// 
			// dsProviders1
			// 
			this.dsProviders1.DataSetName = "dsProviders";
			this.dsProviders1.Locale = new System.Globalization.CultureInfo("ru-RU");
			// 
			// txtID
			// 
			this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProviders1, "����������.��� ����������"));
			this.txtID.Location = new System.Drawing.Point(136, 56);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(184, 20);
			this.txtID.TabIndex = 22;
			this.txtID.Text = "";
			// 
			// lbl���������
			// 
			this.lbl���������.Location = new System.Drawing.Point(24, 88);
			this.lbl���������.Name = "lbl���������";
			this.lbl���������.TabIndex = 23;
			this.lbl���������.Text = "���������";
			// 
			// lbl�������
			// 
			this.lbl�������.Location = new System.Drawing.Point(24, 120);
			this.lbl�������.Name = "lbl�������";
			this.lbl�������.TabIndex = 24;
			this.lbl�������.Text = "�������";
			// 
			// txtProvider
			// 
			this.txtProvider.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProviders1, "����������.���������"));
			this.txtProvider.Location = new System.Drawing.Point(136, 88);
			this.txtProvider.Name = "txtProvider";
			this.txtProvider.Size = new System.Drawing.Size(184, 20);
			this.txtProvider.TabIndex = 25;
			this.txtProvider.Text = "";
			// 
			// txtPhone
			// 
			this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsProviders1, "����������.�������"));
			this.txtPhone.Location = new System.Drawing.Point(136, 120);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(184, 20);
			this.txtPhone.TabIndex = 26;
			this.txtPhone.Text = "";
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(232, 152);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(32, 23);
			this.btnNext.TabIndex = 30;
			this.btnNext.Text = ">";
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// lblRecordsPosition
			// 
			this.lblRecordsPosition.Location = new System.Drawing.Point(144, 152);
			this.lblRecordsPosition.Name = "lblRecordsPosition";
			this.lblRecordsPosition.TabIndex = 31;
			this.lblRecordsPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnFirst
			// 
			this.btnFirst.Location = new System.Drawing.Point(80, 152);
			this.btnFirst.Name = "btnFirst";
			this.btnFirst.Size = new System.Drawing.Size(32, 23);
			this.btnFirst.TabIndex = 29;
			this.btnFirst.Text = "|<";
			this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
			// 
			// btnPrevious
			// 
			this.btnPrevious.Location = new System.Drawing.Point(112, 152);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(32, 23);
			this.btnPrevious.TabIndex = 27;
			this.btnPrevious.Text = "<";
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// btnLast
			// 
			this.btnLast.Location = new System.Drawing.Point(264, 152);
			this.btnLast.Name = "btnLast";
			this.btnLast.Size = new System.Drawing.Size(32, 23);
			this.btnLast.TabIndex = 28;
			this.btnLast.Text = ">|";
			this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "����������", new System.Data.Common.DataColumnMapping[] {
																																																					  new System.Data.Common.DataColumnMapping("����� ����������", "����� ����������"),
																																																					  new System.Data.Common.DataColumnMapping("��� ����������", "��� ����������"),
																																																					  new System.Data.Common.DataColumnMapping("���������", "���������"),
																																																					  new System.Data.Common.DataColumnMapping("�������", "�������")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM ���������� WHERE ([��� ����������] = ?) AND ([����� ����������] = ? O" +
				"R ? IS NULL AND [����� ����������] IS NULL) AND (��������� = ? OR ? IS NULL AND " +
				"��������� IS NULL) AND (������� = ? OR ? IS NULL AND ������� IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_���_����������", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��� ����������", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_�����_����������", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����� ����������", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_�����_����������1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����� ����������", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_���������", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���������", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_���������1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���������", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_�������", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�������", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_�������1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�������", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""D:\Uchebnik\Code\Glava4\RBProduct.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO ����������([����� ����������], ���������, �������) VALUES (?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("�����_����������", System.Data.OleDb.OleDbType.VarWChar, 50, "����� ����������"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("���������", System.Data.OleDb.OleDbType.VarWChar, 50, "���������"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("�������", System.Data.OleDb.OleDbType.VarWChar, 50, "�������"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT [����� ����������], [��� ����������], ���������, ������� FROM ����������";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = @"UPDATE ���������� SET [����� ����������] = ?, ��������� = ?, ������� = ? WHERE ([��� ����������] = ?) AND ([����� ����������] = ? OR ? IS NULL AND [����� ����������] IS NULL) AND (��������� = ? OR ? IS NULL AND ��������� IS NULL) AND (������� = ? OR ? IS NULL AND ������� IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("�����_����������", System.Data.OleDb.OleDbType.VarWChar, 50, "����� ����������"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("���������", System.Data.OleDb.OleDbType.VarWChar, 50, "���������"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("�������", System.Data.OleDb.OleDbType.VarWChar, 50, "�������"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_���_����������", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��� ����������", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_�����_����������", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����� ����������", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_�����_����������1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����� ����������", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_���������", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���������", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_���������1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���������", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_�������", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�������", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_�������1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�������", System.Data.DataRowVersion.Original, null));
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(48, 192);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.TabIndex = 33;
			this.btnAdd.Text = "��������";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(256, 192);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.TabIndex = 32;
			this.btnRemove.Text = "�������";
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(152, 232);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.TabIndex = 34;
			this.btnUpdate.Text = "��������";
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(152, 192);
			this.btnSave.Name = "btnSave";
			this.btnSave.TabIndex = 35;
			this.btnSave.Text = "���������";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(376, 266);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.lblRecordsPosition);
			this.Controls.Add(this.btnFirst);
			this.Controls.Add(this.btnPrevious);
			this.Controls.Add(this.btnLast);
			this.Controls.Add(this.lbl�����_����������);
			this.Controls.Add(this.lbl���_����������);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.lbl���������);
			this.Controls.Add(this.lbl�������);
			this.Controls.Add(this.txtProvider);
			this.Controls.Add(this.txtPhone);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dsProviders1)).EndInit();
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
			lblRecordsPosition.Text = "������" + (cmRecords.Position + 1) + "��" + cmRecords.Count;
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

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			cmRecords.AddNew();
			btnFirst.Enabled = false;
			btnLast.Enabled = false;
			btnNext.Enabled = false;
			btnPrevious.Enabled = false;
			btnRemove.Enabled = false;
			btnUpdate.Enabled = false;
		
		}

		private void btnRemove_Click(object sender, System.EventArgs e)
		{
			if(cmRecords.Count>0)cmRecords.RemoveAt(cmRecords.Position);
			else MessageBox.Show("��� ������ ��� ��������!", "�������� ������", MessageBoxButtons.OK, MessageBoxIcon.Error);

		}

		private void btnUpdate_Click(object sender, System.EventArgs e)
		{
			if (dsProviders1.HasChanges())
				try
				{
					DataSet changes = dsProviders1.GetChanges();
					oleDbDataAdapter1.Update(changes);
					dsProviders1.AcceptChanges();
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message, "��������� ����������", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			else				
				MessageBox.Show("��� ������� ��� ���������", "��������� �������", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
		cmRecords.Position = 0;
			btnFirst.Enabled = true;
			btnLast.Enabled = true;
			btnNext.Enabled = true;
			btnPrevious.Enabled = true;
			btnRemove.Enabled = true;
			btnUpdate.Enabled = true;
		}
	}
}
