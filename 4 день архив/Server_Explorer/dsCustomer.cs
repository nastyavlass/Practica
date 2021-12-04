﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.573
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace Server_Explorer {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class dsCustomer : DataSet {
        
        private CustomerDataTable tableCustomer;
        
        public dsCustomer() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected dsCustomer(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["Customer"] != null)) {
                    this.Tables.Add(new CustomerDataTable(ds.Tables["Customer"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.InitClass();
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public CustomerDataTable Customer {
            get {
                return this.tableCustomer;
            }
        }
        
        public override DataSet Clone() {
            dsCustomer cln = ((dsCustomer)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        protected override void ReadXmlSerializable(XmlReader reader) {
            this.Reset();
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            if ((ds.Tables["Customer"] != null)) {
                this.Tables.Add(new CustomerDataTable(ds.Tables["Customer"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
        }
        
        internal void InitVars() {
            this.tableCustomer = ((CustomerDataTable)(this.Tables["Customer"]));
            if ((this.tableCustomer != null)) {
                this.tableCustomer.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "dsCustomer";
            this.Prefix = "";
            this.Namespace = "http://www.tempuri.org/dsCustomer.xsd";
            this.Locale = new System.Globalization.CultureInfo("ru-RU");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableCustomer = new CustomerDataTable();
            this.Tables.Add(this.tableCustomer);
        }
        
        private bool ShouldSerializeCustomer() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void CustomerRowChangeEventHandler(object sender, CustomerRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class CustomerDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnAddress1;
            
            private DataColumn columnAddress2;
            
            private DataColumn columnCity;
            
            private DataColumn columnContact_First_Name;
            
            private DataColumn columnContact_Last_Name;
            
            private DataColumn columnContact_Position;
            
            private DataColumn columnContact_Title;
            
            private DataColumn columnCountry;
            
            private DataColumn columnCustomer_Credit_ID;
            
            private DataColumn columnCustomer_ID;
            
            private DataColumn columnCustomer_Name;
            
            private DataColumn column_E_mail;
            
            private DataColumn columnFax;
            
            private DataColumn column_Last_Year_s_Sales;
            
            private DataColumn columnPhone;
            
            private DataColumn columnPostal_Code;
            
            private DataColumn columnRegion;
            
            private DataColumn columnWeb_Site;
            
            internal CustomerDataTable() : 
                    base("Customer") {
                this.InitClass();
            }
            
            internal CustomerDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn Address1Column {
                get {
                    return this.columnAddress1;
                }
            }
            
            internal DataColumn Address2Column {
                get {
                    return this.columnAddress2;
                }
            }
            
            internal DataColumn CityColumn {
                get {
                    return this.columnCity;
                }
            }
            
            internal DataColumn Contact_First_NameColumn {
                get {
                    return this.columnContact_First_Name;
                }
            }
            
            internal DataColumn Contact_Last_NameColumn {
                get {
                    return this.columnContact_Last_Name;
                }
            }
            
            internal DataColumn Contact_PositionColumn {
                get {
                    return this.columnContact_Position;
                }
            }
            
            internal DataColumn Contact_TitleColumn {
                get {
                    return this.columnContact_Title;
                }
            }
            
            internal DataColumn CountryColumn {
                get {
                    return this.columnCountry;
                }
            }
            
            internal DataColumn Customer_Credit_IDColumn {
                get {
                    return this.columnCustomer_Credit_ID;
                }
            }
            
            internal DataColumn Customer_IDColumn {
                get {
                    return this.columnCustomer_ID;
                }
            }
            
            internal DataColumn Customer_NameColumn {
                get {
                    return this.columnCustomer_Name;
                }
            }
            
            internal DataColumn _E_mailColumn {
                get {
                    return this.column_E_mail;
                }
            }
            
            internal DataColumn FaxColumn {
                get {
                    return this.columnFax;
                }
            }
            
            internal DataColumn _Last_Year_s_SalesColumn {
                get {
                    return this.column_Last_Year_s_Sales;
                }
            }
            
            internal DataColumn PhoneColumn {
                get {
                    return this.columnPhone;
                }
            }
            
            internal DataColumn Postal_CodeColumn {
                get {
                    return this.columnPostal_Code;
                }
            }
            
            internal DataColumn RegionColumn {
                get {
                    return this.columnRegion;
                }
            }
            
            internal DataColumn Web_SiteColumn {
                get {
                    return this.columnWeb_Site;
                }
            }
            
            public CustomerRow this[int index] {
                get {
                    return ((CustomerRow)(this.Rows[index]));
                }
            }
            
            public event CustomerRowChangeEventHandler CustomerRowChanged;
            
            public event CustomerRowChangeEventHandler CustomerRowChanging;
            
            public event CustomerRowChangeEventHandler CustomerRowDeleted;
            
            public event CustomerRowChangeEventHandler CustomerRowDeleting;
            
            public void AddCustomerRow(CustomerRow row) {
                this.Rows.Add(row);
            }
            
            public CustomerRow AddCustomerRow(
                        string Address1, 
                        string Address2, 
                        string City, 
                        string Contact_First_Name, 
                        string Contact_Last_Name, 
                        string Contact_Position, 
                        string Contact_Title, 
                        string Country, 
                        int Customer_Credit_ID, 
                        int Customer_ID, 
                        string Customer_Name, 
                        string _E_mail, 
                        string Fax, 
                        System.Decimal _Last_Year_s_Sales, 
                        string Phone, 
                        string Postal_Code, 
                        string Region, 
                        string Web_Site) {
                CustomerRow rowCustomerRow = ((CustomerRow)(this.NewRow()));
                rowCustomerRow.ItemArray = new object[] {
                        Address1,
                        Address2,
                        City,
                        Contact_First_Name,
                        Contact_Last_Name,
                        Contact_Position,
                        Contact_Title,
                        Country,
                        Customer_Credit_ID,
                        Customer_ID,
                        Customer_Name,
                        _E_mail,
                        Fax,
                        _Last_Year_s_Sales,
                        Phone,
                        Postal_Code,
                        Region,
                        Web_Site};
                this.Rows.Add(rowCustomerRow);
                return rowCustomerRow;
            }
            
            public CustomerRow FindByCustomer_ID(int Customer_ID) {
                return ((CustomerRow)(this.Rows.Find(new object[] {
                            Customer_ID})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                CustomerDataTable cln = ((CustomerDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new CustomerDataTable();
            }
            
            internal void InitVars() {
                this.columnAddress1 = this.Columns["Address1"];
                this.columnAddress2 = this.Columns["Address2"];
                this.columnCity = this.Columns["City"];
                this.columnContact_First_Name = this.Columns["Contact First Name"];
                this.columnContact_Last_Name = this.Columns["Contact Last Name"];
                this.columnContact_Position = this.Columns["Contact Position"];
                this.columnContact_Title = this.Columns["Contact Title"];
                this.columnCountry = this.Columns["Country"];
                this.columnCustomer_Credit_ID = this.Columns["Customer Credit ID"];
                this.columnCustomer_ID = this.Columns["Customer ID"];
                this.columnCustomer_Name = this.Columns["Customer Name"];
                this.column_E_mail = this.Columns["E-mail"];
                this.columnFax = this.Columns["Fax"];
                this.column_Last_Year_s_Sales = this.Columns["Last Year\'s Sales"];
                this.columnPhone = this.Columns["Phone"];
                this.columnPostal_Code = this.Columns["Postal Code"];
                this.columnRegion = this.Columns["Region"];
                this.columnWeb_Site = this.Columns["Web Site"];
            }
            
            private void InitClass() {
                this.columnAddress1 = new DataColumn("Address1", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAddress1);
                this.columnAddress2 = new DataColumn("Address2", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAddress2);
                this.columnCity = new DataColumn("City", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCity);
                this.columnContact_First_Name = new DataColumn("Contact First Name", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnContact_First_Name);
                this.columnContact_Last_Name = new DataColumn("Contact Last Name", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnContact_Last_Name);
                this.columnContact_Position = new DataColumn("Contact Position", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnContact_Position);
                this.columnContact_Title = new DataColumn("Contact Title", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnContact_Title);
                this.columnCountry = new DataColumn("Country", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCountry);
                this.columnCustomer_Credit_ID = new DataColumn("Customer Credit ID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCustomer_Credit_ID);
                this.columnCustomer_ID = new DataColumn("Customer ID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCustomer_ID);
                this.columnCustomer_Name = new DataColumn("Customer Name", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCustomer_Name);
                this.column_E_mail = new DataColumn("E-mail", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.column_E_mail);
                this.columnFax = new DataColumn("Fax", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFax);
                this.column_Last_Year_s_Sales = new DataColumn("Last Year\'s Sales", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.column_Last_Year_s_Sales);
                this.columnPhone = new DataColumn("Phone", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnPhone);
                this.columnPostal_Code = new DataColumn("Postal Code", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnPostal_Code);
                this.columnRegion = new DataColumn("Region", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRegion);
                this.columnWeb_Site = new DataColumn("Web Site", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnWeb_Site);
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
                                this.columnCustomer_ID}, true));
                this.columnCustomer_ID.AllowDBNull = false;
                this.columnCustomer_ID.Unique = true;
            }
            
            public CustomerRow NewCustomerRow() {
                return ((CustomerRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new CustomerRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(CustomerRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.CustomerRowChanged != null)) {
                    this.CustomerRowChanged(this, new CustomerRowChangeEvent(((CustomerRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.CustomerRowChanging != null)) {
                    this.CustomerRowChanging(this, new CustomerRowChangeEvent(((CustomerRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.CustomerRowDeleted != null)) {
                    this.CustomerRowDeleted(this, new CustomerRowChangeEvent(((CustomerRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.CustomerRowDeleting != null)) {
                    this.CustomerRowDeleting(this, new CustomerRowChangeEvent(((CustomerRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveCustomerRow(CustomerRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class CustomerRow : DataRow {
            
            private CustomerDataTable tableCustomer;
            
            internal CustomerRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableCustomer = ((CustomerDataTable)(this.Table));
            }
            
            public string Address1 {
                get {
                    try {
                        return ((string)(this[this.tableCustomer.Address1Column]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomer.Address1Column] = value;
                }
            }
            
            public string Address2 {
                get {
                    try {
                        return ((string)(this[this.tableCustomer.Address2Column]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomer.Address2Column] = value;
                }
            }
            
            public string City {
                get {
                    try {
                        return ((string)(this[this.tableCustomer.CityColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomer.CityColumn] = value;
                }
            }
            
            public string Contact_First_Name {
                get {
                    try {
                        return ((string)(this[this.tableCustomer.Contact_First_NameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomer.Contact_First_NameColumn] = value;
                }
            }
            
            public string Contact_Last_Name {
                get {
                    try {
                        return ((string)(this[this.tableCustomer.Contact_Last_NameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomer.Contact_Last_NameColumn] = value;
                }
            }
            
            public string Contact_Position {
                get {
                    try {
                        return ((string)(this[this.tableCustomer.Contact_PositionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomer.Contact_PositionColumn] = value;
                }
            }
            
            public string Contact_Title {
                get {
                    try {
                        return ((string)(this[this.tableCustomer.Contact_TitleColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomer.Contact_TitleColumn] = value;
                }
            }
            
            public string Country {
                get {
                    try {
                        return ((string)(this[this.tableCustomer.CountryColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomer.CountryColumn] = value;
                }
            }
            
            public int Customer_Credit_ID {
                get {
                    try {
                        return ((int)(this[this.tableCustomer.Customer_Credit_IDColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomer.Customer_Credit_IDColumn] = value;
                }
            }
            
            public int Customer_ID {
                get {
                    return ((int)(this[this.tableCustomer.Customer_IDColumn]));
                }
                set {
                    this[this.tableCustomer.Customer_IDColumn] = value;
                }
            }
            
            public string Customer_Name {
                get {
                    try {
                        return ((string)(this[this.tableCustomer.Customer_NameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomer.Customer_NameColumn] = value;
                }
            }
            
            public string _E_mail {
                get {
                    try {
                        return ((string)(this[this.tableCustomer._E_mailColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomer._E_mailColumn] = value;
                }
            }
            
            public string Fax {
                get {
                    try {
                        return ((string)(this[this.tableCustomer.FaxColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomer.FaxColumn] = value;
                }
            }
            
            public System.Decimal _Last_Year_s_Sales {
                get {
                    try {
                        return ((System.Decimal)(this[this.tableCustomer._Last_Year_s_SalesColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomer._Last_Year_s_SalesColumn] = value;
                }
            }
            
            public string Phone {
                get {
                    try {
                        return ((string)(this[this.tableCustomer.PhoneColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomer.PhoneColumn] = value;
                }
            }
            
            public string Postal_Code {
                get {
                    try {
                        return ((string)(this[this.tableCustomer.Postal_CodeColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomer.Postal_CodeColumn] = value;
                }
            }
            
            public string Region {
                get {
                    try {
                        return ((string)(this[this.tableCustomer.RegionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomer.RegionColumn] = value;
                }
            }
            
            public string Web_Site {
                get {
                    try {
                        return ((string)(this[this.tableCustomer.Web_SiteColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableCustomer.Web_SiteColumn] = value;
                }
            }
            
            public bool IsAddress1Null() {
                return this.IsNull(this.tableCustomer.Address1Column);
            }
            
            public void SetAddress1Null() {
                this[this.tableCustomer.Address1Column] = System.Convert.DBNull;
            }
            
            public bool IsAddress2Null() {
                return this.IsNull(this.tableCustomer.Address2Column);
            }
            
            public void SetAddress2Null() {
                this[this.tableCustomer.Address2Column] = System.Convert.DBNull;
            }
            
            public bool IsCityNull() {
                return this.IsNull(this.tableCustomer.CityColumn);
            }
            
            public void SetCityNull() {
                this[this.tableCustomer.CityColumn] = System.Convert.DBNull;
            }
            
            public bool IsContact_First_NameNull() {
                return this.IsNull(this.tableCustomer.Contact_First_NameColumn);
            }
            
            public void SetContact_First_NameNull() {
                this[this.tableCustomer.Contact_First_NameColumn] = System.Convert.DBNull;
            }
            
            public bool IsContact_Last_NameNull() {
                return this.IsNull(this.tableCustomer.Contact_Last_NameColumn);
            }
            
            public void SetContact_Last_NameNull() {
                this[this.tableCustomer.Contact_Last_NameColumn] = System.Convert.DBNull;
            }
            
            public bool IsContact_PositionNull() {
                return this.IsNull(this.tableCustomer.Contact_PositionColumn);
            }
            
            public void SetContact_PositionNull() {
                this[this.tableCustomer.Contact_PositionColumn] = System.Convert.DBNull;
            }
            
            public bool IsContact_TitleNull() {
                return this.IsNull(this.tableCustomer.Contact_TitleColumn);
            }
            
            public void SetContact_TitleNull() {
                this[this.tableCustomer.Contact_TitleColumn] = System.Convert.DBNull;
            }
            
            public bool IsCountryNull() {
                return this.IsNull(this.tableCustomer.CountryColumn);
            }
            
            public void SetCountryNull() {
                this[this.tableCustomer.CountryColumn] = System.Convert.DBNull;
            }
            
            public bool IsCustomer_Credit_IDNull() {
                return this.IsNull(this.tableCustomer.Customer_Credit_IDColumn);
            }
            
            public void SetCustomer_Credit_IDNull() {
                this[this.tableCustomer.Customer_Credit_IDColumn] = System.Convert.DBNull;
            }
            
            public bool IsCustomer_NameNull() {
                return this.IsNull(this.tableCustomer.Customer_NameColumn);
            }
            
            public void SetCustomer_NameNull() {
                this[this.tableCustomer.Customer_NameColumn] = System.Convert.DBNull;
            }
            
            public bool Is_E_mailNull() {
                return this.IsNull(this.tableCustomer._E_mailColumn);
            }
            
            public void Set_E_mailNull() {
                this[this.tableCustomer._E_mailColumn] = System.Convert.DBNull;
            }
            
            public bool IsFaxNull() {
                return this.IsNull(this.tableCustomer.FaxColumn);
            }
            
            public void SetFaxNull() {
                this[this.tableCustomer.FaxColumn] = System.Convert.DBNull;
            }
            
            public bool Is_Last_Year_s_SalesNull() {
                return this.IsNull(this.tableCustomer._Last_Year_s_SalesColumn);
            }
            
            public void Set_Last_Year_s_SalesNull() {
                this[this.tableCustomer._Last_Year_s_SalesColumn] = System.Convert.DBNull;
            }
            
            public bool IsPhoneNull() {
                return this.IsNull(this.tableCustomer.PhoneColumn);
            }
            
            public void SetPhoneNull() {
                this[this.tableCustomer.PhoneColumn] = System.Convert.DBNull;
            }
            
            public bool IsPostal_CodeNull() {
                return this.IsNull(this.tableCustomer.Postal_CodeColumn);
            }
            
            public void SetPostal_CodeNull() {
                this[this.tableCustomer.Postal_CodeColumn] = System.Convert.DBNull;
            }
            
            public bool IsRegionNull() {
                return this.IsNull(this.tableCustomer.RegionColumn);
            }
            
            public void SetRegionNull() {
                this[this.tableCustomer.RegionColumn] = System.Convert.DBNull;
            }
            
            public bool IsWeb_SiteNull() {
                return this.IsNull(this.tableCustomer.Web_SiteColumn);
            }
            
            public void SetWeb_SiteNull() {
                this[this.tableCustomer.Web_SiteColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class CustomerRowChangeEvent : EventArgs {
            
            private CustomerRow eventRow;
            
            private DataRowAction eventAction;
            
            public CustomerRowChangeEvent(CustomerRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public CustomerRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}
