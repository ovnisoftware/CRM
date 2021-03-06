﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRM2
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Contacts")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMisc(Misc instance);
    partial void UpdateMisc(Misc instance);
    partial void DeleteMisc(Misc instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::CRM2.Properties.Settings.Default.ContactsConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Misc> Miscs
		{
			get
			{
				return this.GetTable<Misc>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Misc")]
	public partial class Misc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Lead_Category;
		
		private string _Status;
		
		private System.Nullable<System.DateTime> _Last_Contact;
		
		private System.Nullable<System.DateTime> _Next_Contact;
		
		private string _Company;
		
		private string _Company_Title;
		
		private string _Website;
		
		private string _Title;
		
		private string _First_Name;
		
		private string _Last_Name;
		
		private string _Address;
		
		private string _City;
		
		private string _State;
		
		private System.Nullable<int> _Zip;
		
		private string _Email;
		
		private string _Mobile;
		
		private string _Phone2;
		
		private string _Phone3;
		
		private string _Picture;
		
		private string _Notes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnLead_CategoryChanging(string value);
    partial void OnLead_CategoryChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    partial void OnLast_ContactChanging(System.Nullable<System.DateTime> value);
    partial void OnLast_ContactChanged();
    partial void OnNext_ContactChanging(System.Nullable<System.DateTime> value);
    partial void OnNext_ContactChanged();
    partial void OnCompanyChanging(string value);
    partial void OnCompanyChanged();
    partial void OnCompany_TitleChanging(string value);
    partial void OnCompany_TitleChanged();
    partial void OnWebsiteChanging(string value);
    partial void OnWebsiteChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnFirst_NameChanging(string value);
    partial void OnFirst_NameChanged();
    partial void OnLast_NameChanging(string value);
    partial void OnLast_NameChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnStateChanging(string value);
    partial void OnStateChanged();
    partial void OnZipChanging(System.Nullable<int> value);
    partial void OnZipChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnMobileChanging(string value);
    partial void OnMobileChanged();
    partial void OnPhone2Changing(string value);
    partial void OnPhone2Changed();
    partial void OnPhone3Changing(string value);
    partial void OnPhone3Changed();
    partial void OnPictureChanging(string value);
    partial void OnPictureChanged();
    partial void OnNotesChanging(string value);
    partial void OnNotesChanged();
    #endregion
		
		public Misc()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Lead_Category", DbType="NVarChar(50)")]
		public string Lead_Category
		{
			get
			{
				return this._Lead_Category;
			}
			set
			{
				if ((this._Lead_Category != value))
				{
					this.OnLead_CategoryChanging(value);
					this.SendPropertyChanging();
					this._Lead_Category = value;
					this.SendPropertyChanged("Lead_Category");
					this.OnLead_CategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="NVarChar(50)")]
		public string Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Last_Contact", DbType="DateTime")]
		public System.Nullable<System.DateTime> Last_Contact
		{
			get
			{
				return this._Last_Contact;
			}
			set
			{
				if ((this._Last_Contact != value))
				{
					this.OnLast_ContactChanging(value);
					this.SendPropertyChanging();
					this._Last_Contact = value;
					this.SendPropertyChanged("Last_Contact");
					this.OnLast_ContactChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Next_Contact", DbType="DateTime")]
		public System.Nullable<System.DateTime> Next_Contact
		{
			get
			{
				return this._Next_Contact;
			}
			set
			{
				if ((this._Next_Contact != value))
				{
					this.OnNext_ContactChanging(value);
					this.SendPropertyChanging();
					this._Next_Contact = value;
					this.SendPropertyChanged("Next_Contact");
					this.OnNext_ContactChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Company", DbType="NVarChar(500)")]
		public string Company
		{
			get
			{
				return this._Company;
			}
			set
			{
				if ((this._Company != value))
				{
					this.OnCompanyChanging(value);
					this.SendPropertyChanging();
					this._Company = value;
					this.SendPropertyChanged("Company");
					this.OnCompanyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Company_Title", DbType="NVarChar(150)")]
		public string Company_Title
		{
			get
			{
				return this._Company_Title;
			}
			set
			{
				if ((this._Company_Title != value))
				{
					this.OnCompany_TitleChanging(value);
					this.SendPropertyChanging();
					this._Company_Title = value;
					this.SendPropertyChanged("Company_Title");
					this.OnCompany_TitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Website", DbType="NVarChar(1000)")]
		public string Website
		{
			get
			{
				return this._Website;
			}
			set
			{
				if ((this._Website != value))
				{
					this.OnWebsiteChanging(value);
					this.SendPropertyChanging();
					this._Website = value;
					this.SendPropertyChanged("Website");
					this.OnWebsiteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(50)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_First_Name", DbType="NVarChar(500)")]
		public string First_Name
		{
			get
			{
				return this._First_Name;
			}
			set
			{
				if ((this._First_Name != value))
				{
					this.OnFirst_NameChanging(value);
					this.SendPropertyChanging();
					this._First_Name = value;
					this.SendPropertyChanged("First_Name");
					this.OnFirst_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Last_Name", DbType="NVarChar(500)")]
		public string Last_Name
		{
			get
			{
				return this._Last_Name;
			}
			set
			{
				if ((this._Last_Name != value))
				{
					this.OnLast_NameChanging(value);
					this.SendPropertyChanging();
					this._Last_Name = value;
					this.SendPropertyChanged("Last_Name");
					this.OnLast_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(1000)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(1000)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="NVarChar(200)")]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this.OnStateChanging(value);
					this.SendPropertyChanging();
					this._State = value;
					this.SendPropertyChanged("State");
					this.OnStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Zip", DbType="Int")]
		public System.Nullable<int> Zip
		{
			get
			{
				return this._Zip;
			}
			set
			{
				if ((this._Zip != value))
				{
					this.OnZipChanging(value);
					this.SendPropertyChanging();
					this._Zip = value;
					this.SendPropertyChanged("Zip");
					this.OnZipChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(1000)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mobile", DbType="NVarChar(50)")]
		public string Mobile
		{
			get
			{
				return this._Mobile;
			}
			set
			{
				if ((this._Mobile != value))
				{
					this.OnMobileChanging(value);
					this.SendPropertyChanging();
					this._Mobile = value;
					this.SendPropertyChanged("Mobile");
					this.OnMobileChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone2", DbType="NVarChar(50)")]
		public string Phone2
		{
			get
			{
				return this._Phone2;
			}
			set
			{
				if ((this._Phone2 != value))
				{
					this.OnPhone2Changing(value);
					this.SendPropertyChanging();
					this._Phone2 = value;
					this.SendPropertyChanged("Phone2");
					this.OnPhone2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone3", DbType="NVarChar(50)")]
		public string Phone3
		{
			get
			{
				return this._Phone3;
			}
			set
			{
				if ((this._Phone3 != value))
				{
					this.OnPhone3Changing(value);
					this.SendPropertyChanging();
					this._Phone3 = value;
					this.SendPropertyChanged("Phone3");
					this.OnPhone3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Picture", DbType="NVarChar(1000)")]
		public string Picture
		{
			get
			{
				return this._Picture;
			}
			set
			{
				if ((this._Picture != value))
				{
					this.OnPictureChanging(value);
					this.SendPropertyChanging();
					this._Picture = value;
					this.SendPropertyChanged("Picture");
					this.OnPictureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Notes", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Notes
		{
			get
			{
				return this._Notes;
			}
			set
			{
				if ((this._Notes != value))
				{
					this.OnNotesChanging(value);
					this.SendPropertyChanging();
					this._Notes = value;
					this.SendPropertyChanged("Notes");
					this.OnNotesChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
