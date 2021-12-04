using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace DataWizardMDB
{
	/// <summary>
	/// Summary description for DataFormMDB.
	/// </summary>
	public class DataFormMDB : System.Windows.Forms.Form
	{
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private DataWizardMDB.dsProviders objdsProviders;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnCancelAll;
		private System.Windows.Forms.Label lbl�����_����������;
		private System.Windows.Forms.Label lbl���_����������;
		private System.Windows.Forms.TextBox edit�����_����������;
		private System.Windows.Forms.TextBox edit���_����������;
		private System.Windows.Forms.Label lbl���������;
		private System.Windows.Forms.Label lbl�������;
		private System.Windows.Forms.TextBox edit���������;
		private System.Windows.Forms.TextBox edit�������;
		private System.Windows.Forms.Button btnNavFirst;
		private System.Windows.Forms.Button btnNavPrev;
		private System.Windows.Forms.Label lblNavLocation;
		private System.Windows.Forms.Button btnNavNext;
		private System.Windows.Forms.Button btnLast;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.DataGrid grd������;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public DataFormMDB()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

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
				if(components != null)
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
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
			this.objdsProviders = new DataWizardMDB.dsProviders();
			this.btnLoad = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnCancelAll = new System.Windows.Forms.Button();
			this.lbl�����_���������� = new System.Windows.Forms.Label();
			this.lbl���_���������� = new System.Windows.Forms.Label();
			this.edit�����_���������� = new System.Windows.Forms.TextBox();
			this.edit���_���������� = new System.Windows.Forms.TextBox();
			this.lbl��������� = new System.Windows.Forms.Label();
			this.lbl������� = new System.Windows.Forms.Label();
			this.edit��������� = new System.Windows.Forms.TextBox();
			this.edit������� = new System.Windows.Forms.TextBox();
			this.btnNavFirst = new System.Windows.Forms.Button();
			this.btnNavPrev = new System.Windows.Forms.Button();
			this.lblNavLocation = new System.Windows.Forms.Label();
			this.btnNavNext = new System.Windows.Forms.Button();
			this.btnLast = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.grd������ = new System.Windows.Forms.DataGrid();
			((System.ComponentModel.ISupportInitialize)(this.objdsProviders)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grd������)).BeginInit();
			this.SuspendLayout();
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT [����� ����������], [��� ����������], ���������, ������� FROM ����������";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
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
			// oleDbSelectCommand2
			// 
			this.oleDbSelectCommand2.CommandText = "SELECT [��� ����������], [��� ��������], ������������, [����, $] FROM ������";
			this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
			// 
			// oleDbInsertCommand2
			// 
			this.oleDbInsertCommand2.CommandText = "INSERT INTO ������([��� ����������], ������������, [����, $]) VALUES (?, ?, ?)";
			this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("���_����������", System.Data.OleDb.OleDbType.Integer, 0, "��� ����������"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("������������", System.Data.OleDb.OleDbType.VarWChar, 50, "������������"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("����___", System.Data.OleDb.OleDbType.VarWChar, 50, "����, $"));
			// 
			// oleDbUpdateCommand2
			// 
			this.oleDbUpdateCommand2.CommandText = @"UPDATE ������ SET [��� ����������] = ?, ������������ = ?, [����, $] = ? WHERE ([��� ��������] = ?) AND ([��� ����������] = ? OR ? IS NULL AND [��� ����������] IS NULL) AND (������������ = ? OR ? IS NULL AND ������������ IS NULL) AND ([����, $] = ? OR ? IS NULL AND [����, $] IS NULL)";
			this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("���_����������", System.Data.OleDb.OleDbType.Integer, 0, "��� ����������"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("������������", System.Data.OleDb.OleDbType.VarWChar, 50, "������������"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("����___", System.Data.OleDb.OleDbType.VarWChar, 50, "����, $"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_���_��������", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��� ��������", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_���_����������", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��� ����������", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_���_����������1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��� ����������", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_������������", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "������������", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_������������1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "������������", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_����___", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����, $", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_����___1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����, $", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDeleteCommand2
			// 
			this.oleDbDeleteCommand2.CommandText = "DELETE FROM ������ WHERE ([��� ��������] = ?) AND ([��� ����������] = ? OR ? IS N" +
				"ULL AND [��� ����������] IS NULL) AND (������������ = ? OR ? IS NULL AND �������" +
				"����� IS NULL) AND ([����, $] = ? OR ? IS NULL AND [����, $] IS NULL)";
			this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_���_��������", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��� ��������", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_���_����������", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��� ����������", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_���_����������1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��� ����������", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_������������", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "������������", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_������������1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "������������", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_����___", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����, $", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_����___1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����, $", System.Data.DataRowVersion.Original, null));
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
			// oleDbDataAdapter2
			// 
			this.oleDbDataAdapter2.DeleteCommand = this.oleDbDeleteCommand2;
			this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand2;
			this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
			this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "������", new System.Data.Common.DataColumnMapping[] {
																																																				  new System.Data.Common.DataColumnMapping("��� ����������", "��� ����������"),
																																																				  new System.Data.Common.DataColumnMapping("��� ��������", "��� ��������"),
																																																				  new System.Data.Common.DataColumnMapping("������������", "������������"),
																																																				  new System.Data.Common.DataColumnMapping("����, $", "����, $")})});
			this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand2;
			// 
			// objdsProviders
			// 
			this.objdsProviders.DataSetName = "dsProviders";
			this.objdsProviders.Locale = new System.Globalization.CultureInfo("ru-RU");
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(10, 10);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.TabIndex = 0;
			this.btnLoad.Text = "&Load";
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(365, 10);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.TabIndex = 1;
			this.btnUpdate.Text = "&Update";
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnCancelAll
			// 
			this.btnCancelAll.Location = new System.Drawing.Point(365, 43);
			this.btnCancelAll.Name = "btnCancelAll";
			this.btnCancelAll.TabIndex = 2;
			this.btnCancelAll.Text = "Ca&ncel All";
			this.btnCancelAll.Click += new System.EventHandler(this.btnCancelAll_Click);
			// 
			// lbl�����_����������
			// 
			this.lbl�����_����������.Location = new System.Drawing.Point(10, 72);
			this.lbl�����_����������.Name = "lbl�����_����������";
			this.lbl�����_����������.Size = new System.Drawing.Size(100, 32);
			this.lbl�����_����������.TabIndex = 3;
			this.lbl�����_����������.Text = "����� ����������";
			// 
			// lbl���_����������
			// 
			this.lbl���_����������.Location = new System.Drawing.Point(10, 109);
			this.lbl���_����������.Name = "lbl���_����������";
			this.lbl���_����������.TabIndex = 4;
			this.lbl���_����������.Text = "��� ����������";
			// 
			// edit�����_����������
			// 
			this.edit�����_����������.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objdsProviders, "����������.����� ����������"));
			this.edit�����_����������.Location = new System.Drawing.Point(120, 76);
			this.edit�����_����������.Name = "edit�����_����������";
			this.edit�����_����������.TabIndex = 5;
			this.edit�����_����������.Text = "";
			// 
			// edit���_����������
			// 
			this.edit���_����������.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objdsProviders, "����������.��� ����������"));
			this.edit���_����������.Location = new System.Drawing.Point(120, 109);
			this.edit���_����������.Name = "edit���_����������";
			this.edit���_����������.TabIndex = 6;
			this.edit���_����������.Text = "";
			// 
			// lbl���������
			// 
			this.lbl���������.Location = new System.Drawing.Point(230, 76);
			this.lbl���������.Name = "lbl���������";
			this.lbl���������.TabIndex = 7;
			this.lbl���������.Text = "���������";
			// 
			// lbl�������
			// 
			this.lbl�������.Location = new System.Drawing.Point(230, 109);
			this.lbl�������.Name = "lbl�������";
			this.lbl�������.TabIndex = 8;
			this.lbl�������.Text = "�������";
			// 
			// edit���������
			// 
			this.edit���������.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objdsProviders, "����������.���������"));
			this.edit���������.Location = new System.Drawing.Point(340, 76);
			this.edit���������.Name = "edit���������";
			this.edit���������.Size = new System.Drawing.Size(124, 20);
			this.edit���������.TabIndex = 9;
			this.edit���������.Text = "";
			// 
			// edit�������
			// 
			this.edit�������.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objdsProviders, "����������.�������"));
			this.edit�������.Location = new System.Drawing.Point(340, 109);
			this.edit�������.Name = "edit�������";
			this.edit�������.Size = new System.Drawing.Size(124, 20);
			this.edit�������.TabIndex = 10;
			this.edit�������.Text = "";
			// 
			// btnNavFirst
			// 
			this.btnNavFirst.Location = new System.Drawing.Point(195, 142);
			this.btnNavFirst.Name = "btnNavFirst";
			this.btnNavFirst.Size = new System.Drawing.Size(40, 23);
			this.btnNavFirst.TabIndex = 11;
			this.btnNavFirst.Text = "<<";
			this.btnNavFirst.Click += new System.EventHandler(this.btnNavFirst_Click);
			// 
			// btnNavPrev
			// 
			this.btnNavPrev.Location = new System.Drawing.Point(235, 142);
			this.btnNavPrev.Name = "btnNavPrev";
			this.btnNavPrev.Size = new System.Drawing.Size(35, 23);
			this.btnNavPrev.TabIndex = 12;
			this.btnNavPrev.Text = "<";
			this.btnNavPrev.Click += new System.EventHandler(this.btnNavPrev_Click);
			// 
			// lblNavLocation
			// 
			this.lblNavLocation.BackColor = System.Drawing.Color.White;
			this.lblNavLocation.Location = new System.Drawing.Point(270, 142);
			this.lblNavLocation.Name = "lblNavLocation";
			this.lblNavLocation.Size = new System.Drawing.Size(95, 23);
			this.lblNavLocation.TabIndex = 13;
			this.lblNavLocation.Text = "No Records";
			this.lblNavLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnNavNext
			// 
			this.btnNavNext.Location = new System.Drawing.Point(365, 142);
			this.btnNavNext.Name = "btnNavNext";
			this.btnNavNext.Size = new System.Drawing.Size(35, 23);
			this.btnNavNext.TabIndex = 14;
			this.btnNavNext.Text = ">";
			this.btnNavNext.Click += new System.EventHandler(this.btnNavNext_Click);
			// 
			// btnLast
			// 
			this.btnLast.Location = new System.Drawing.Point(400, 142);
			this.btnLast.Name = "btnLast";
			this.btnLast.Size = new System.Drawing.Size(40, 23);
			this.btnLast.TabIndex = 15;
			this.btnLast.Text = ">>";
			this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(195, 175);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.TabIndex = 16;
			this.btnAdd.Text = "&Add";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(280, 175);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.TabIndex = 17;
			this.btnDelete.Text = "&Delete";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(365, 175);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 18;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// grd������
			// 
			this.grd������.AllowNavigation = false;
			this.grd������.DataMember = "����������.ProvidersProducts";
			this.grd������.DataSource = this.objdsProviders;
			this.grd������.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.grd������.Location = new System.Drawing.Point(10, 208);
			this.grd������.Name = "grd������";
			this.grd������.Size = new System.Drawing.Size(430, 292);
			this.grd������.TabIndex = 19;
			// 
			// DataFormMDB
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(488, 476);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnCancelAll);
			this.Controls.Add(this.lbl�����_����������);
			this.Controls.Add(this.lbl���_����������);
			this.Controls.Add(this.edit�����_����������);
			this.Controls.Add(this.edit���_����������);
			this.Controls.Add(this.lbl���������);
			this.Controls.Add(this.lbl�������);
			this.Controls.Add(this.edit���������);
			this.Controls.Add(this.edit�������);
			this.Controls.Add(this.btnNavFirst);
			this.Controls.Add(this.btnNavPrev);
			this.Controls.Add(this.lblNavLocation);
			this.Controls.Add(this.btnNavNext);
			this.Controls.Add(this.btnLast);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.grd������);
			this.Name = "DataFormMDB";
			this.Text = "DataFormMDB";
			this.Load += new System.EventHandler(this.DataFormMDB_Load);
			((System.ComponentModel.ISupportInitialize)(this.objdsProviders)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grd������)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		[STAThread]
		static void Main() 
		{
			Application.Run(new DataFormMDB());
		}

		public void FillDataSet(DataWizardMDB.dsProviders dataSet)
		{
			// Turn off constraint checking before the dataset is filled.
			// This allows the adapters to fill the dataset without concern
			// for dependencies between the tables.
			dataSet.EnforceConstraints = false;
			try 
			{
				// Open the connection.
				this.oleDbConnection1.Open();
				// Attempt to fill the dataset through the OleDbDataAdapter1.
				this.oleDbDataAdapter1.Fill(dataSet);
				this.oleDbDataAdapter2.Fill(dataSet);
			}
			catch (System.Exception fillException) 
			{
				// Add your error handling code here.
				throw fillException;
			}
			finally 
			{
				// Turn constraint checking back on.
				dataSet.EnforceConstraints = true;
				// Close the connection whether or not the exception was thrown.
				this.oleDbConnection1.Close();
			}

		}

		public void UpdateDataSource(DataWizardMDB.dsProviders ChangedRows)
		{
			try 
			{
				// The data source only needs to be updated if there are changes pending.
				if ((ChangedRows != null)) 
				{
					// Open the connection.
					this.oleDbConnection1.Open();
					// Attempt to update the data source.
					oleDbDataAdapter1.Update(ChangedRows);
					oleDbDataAdapter2.Update(ChangedRows);
				}
			}
			catch (System.Exception updateException) 
			{
				// Add your error handling code here.
				throw updateException;
			}
			finally 
			{
				// Close the connection whether or not the exception was thrown.
				this.oleDbConnection1.Close();
			}

		}

		public void LoadDataSet()
		{
			// Create a new dataset to hold the records returned from the call to FillDataSet.
			// A temporary dataset is used because filling the existing dataset would
			// require the databindings to be rebound.
			DataWizardMDB.dsProviders objDataSetTemp;
			objDataSetTemp = new DataWizardMDB.dsProviders();
			try 
			{
				// Attempt to fill the temporary dataset.
				this.FillDataSet(objDataSetTemp);
			}
			catch (System.Exception eFillDataSet) 
			{
				// Add your error handling code here.
				throw eFillDataSet;
			}
			try 
			{
				grd������.DataSource = null;
				// Empty the old records from the dataset.
				objdsProviders.Clear();
				// Merge the records into the main dataset.
				objdsProviders.Merge(objDataSetTemp);
				grd������.SetDataBinding(objdsProviders, "����������.ProvidersProducts");
			}
			catch (System.Exception eLoadMerge) 
			{
				// Add your error handling code here.
				throw eLoadMerge;
			}

		}

		public void UpdateDataSet()
		{
			// Create a new dataset to hold the changes that have been made to the main dataset.
			DataWizardMDB.dsProviders objDataSetChanges = new DataWizardMDB.dsProviders();
			// Stop any current edits.
			this.BindingContext[objdsProviders,"����������"].EndCurrentEdit();
			this.BindingContext[objdsProviders,"������"].EndCurrentEdit();
			// Get the changes that have been made to the main dataset.
			objDataSetChanges = ((DataWizardMDB.dsProviders)(objdsProviders.GetChanges()));
			// Check to see if any changes have been made.
			if ((objDataSetChanges != null)) 
			{
				try 
				{
					// There are changes that need to be made, so attempt to update the datasource by
					// calling the update method and passing the dataset and any parameters.
					this.UpdateDataSource(objDataSetChanges);
					objdsProviders.Merge(objDataSetChanges);
					objdsProviders.AcceptChanges();
				}
				catch (System.Exception eUpdate) 
				{
					// Add your error handling code here.
					throw eUpdate;
				}
				// Add your code to check the returned dataset for any errors that may have been
				// pushed into the row object's error.
			}

		}

		private void btnCancelAll_Click(object sender, System.EventArgs e)
		{
			this.objdsProviders.RejectChanges();

		}

		private void objdsProviders_PositionChanged()
		{
			this.lblNavLocation.Text = ((((this.BindingContext[objdsProviders,"����������"].Position + 1)).ToString() + " of  ") 
				+ this.BindingContext[objdsProviders,"����������"].Count.ToString());

		}

		private void btnNavNext_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[objdsProviders,"����������"].Position = (this.BindingContext[objdsProviders,"����������"].Position + 1);
			this.objdsProviders_PositionChanged();

		}

		private void btnNavPrev_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[objdsProviders,"����������"].Position = (this.BindingContext[objdsProviders,"����������"].Position - 1);
			this.objdsProviders_PositionChanged();

		}

		private void btnLast_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[objdsProviders,"����������"].Position = (this.objdsProviders.Tables["����������"].Rows.Count - 1);
			this.objdsProviders_PositionChanged();

		}

		private void btnNavFirst_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[objdsProviders,"����������"].Position = 0;
			this.objdsProviders_PositionChanged();

		}

		private void btnLoad_Click(object sender, System.EventArgs e)
		{
			try 
			{
				// Attempt to load the dataset.
				this.LoadDataSet();
			}
			catch (System.Exception eLoad) 
			{
				// Add your error handling code here.
				// Display error message, if any.
				System.Windows.Forms.MessageBox.Show(eLoad.Message);
			}
			this.objdsProviders_PositionChanged();

		}

		private void btnUpdate_Click(object sender, System.EventArgs e)
		{
			try 
			{
				// Attempt to update the datasource.
				this.UpdateDataSet();
			}
			catch (System.Exception eUpdate) 
			{
				// Add your error handling code here.
				// Display error message, if any.
				System.Windows.Forms.MessageBox.Show(eUpdate.Message);
			}
			this.objdsProviders_PositionChanged();

		}

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			try 
			{
				// Clear out the current edits
				this.BindingContext[objdsProviders,"����������"].EndCurrentEdit();
				this.BindingContext[objdsProviders,"����������"].AddNew();
			}
			catch (System.Exception eEndEdit) 
			{
				System.Windows.Forms.MessageBox.Show(eEndEdit.Message);
			}
			this.objdsProviders_PositionChanged();

		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			if ((this.BindingContext[objdsProviders,"����������"].Count > 0)) 
			{
				this.BindingContext[objdsProviders,"����������"].RemoveAt(this.BindingContext[objdsProviders,"����������"].Position);
				this.objdsProviders_PositionChanged();
			}

		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[objdsProviders,"����������"].CancelCurrentEdit();
			this.objdsProviders_PositionChanged();

		}

		private void DataFormMDB_Load(object sender, System.EventArgs e)
		{
		
		}
	}
}
