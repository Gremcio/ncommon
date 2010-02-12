﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NCommon.LinqToSql.Tests
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
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="DevelopmentDB")]
	public partial class TestDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    partial void InsertCustomOrderItem(CustomOrderItem instance);
    partial void UpdateCustomOrderItem(CustomOrderItem instance);
    partial void DeleteCustomOrderItem(CustomOrderItem instance);
    partial void InsertCustomOrder(CustomOrder instance);
    partial void UpdateCustomOrder(CustomOrder instance);
    partial void DeleteCustomOrder(CustomOrder instance);
    partial void InsertMonthlySalesSummary(MonthlySalesSummary instance);
    partial void UpdateMonthlySalesSummary(MonthlySalesSummary instance);
    partial void DeleteMonthlySalesSummary(MonthlySalesSummary instance);
    partial void InsertOrderItem(OrderItem instance);
    partial void UpdateOrderItem(OrderItem instance);
    partial void DeleteOrderItem(OrderItem instance);
    partial void InsertOrder(Order instance);
    partial void UpdateOrder(Order instance);
    partial void DeleteOrder(Order instance);
    #endregion
		
		public TestDataDataContext() : 
				base(global::NCommon.LinqToSql.Tests.Properties.Settings.Default.DevelopmentDBConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public TestDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TestDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TestDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TestDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
		
		public System.Data.Linq.Table<CustomOrderItem> CustomOrderItems
		{
			get
			{
				return this.GetTable<CustomOrderItem>();
			}
		}
		
		public System.Data.Linq.Table<CustomOrder> CustomOrders
		{
			get
			{
				return this.GetTable<CustomOrder>();
			}
		}
		
		public System.Data.Linq.Table<MonthlySalesSummary> MonthlySalesSummaries
		{
			get
			{
				return this.GetTable<MonthlySalesSummary>();
			}
		}
		
		public System.Data.Linq.Table<OrderItem> OrderItems
		{
			get
			{
				return this.GetTable<OrderItem>();
			}
		}
		
		public System.Data.Linq.Table<Order> Orders
		{
			get
			{
				return this.GetTable<Order>();
			}
		}
	}
	
	[Table(Name="dbo.Customers")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CustomerID;
		
		private string _StreetAddress1;
		
		private string _StreetAddress2;
		
		private string _City;
		
		private string _State;
		
		private string _ZipCode;
		
		private string _FirstName;
		
		private string _LastName;
		
		private EntitySet<Order> _Orders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomerIDChanging(int value);
    partial void OnCustomerIDChanged();
    partial void OnStreetAddress1Changing(string value);
    partial void OnStreetAddress1Changed();
    partial void OnStreetAddress2Changing(string value);
    partial void OnStreetAddress2Changed();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnStateChanging(string value);
    partial void OnStateChanged();
    partial void OnZipCodeChanging(string value);
    partial void OnZipCodeChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    #endregion
		
		public Customer()
		{
			this._Orders = new EntitySet<Order>(new Action<Order>(this.attach_Orders), new Action<Order>(this.detach_Orders));
			OnCreated();
		}
		
		[Column(Storage="_CustomerID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					this.OnCustomerIDChanging(value);
					this.SendPropertyChanging();
					this._CustomerID = value;
					this.SendPropertyChanged("CustomerID");
					this.OnCustomerIDChanged();
				}
			}
		}
		
		[Column(Storage="_StreetAddress1", DbType="NVarChar(255)")]
		public string StreetAddress1
		{
			get
			{
				return this._StreetAddress1;
			}
			set
			{
				if ((this._StreetAddress1 != value))
				{
					this.OnStreetAddress1Changing(value);
					this.SendPropertyChanging();
					this._StreetAddress1 = value;
					this.SendPropertyChanged("StreetAddress1");
					this.OnStreetAddress1Changed();
				}
			}
		}
		
		[Column(Storage="_StreetAddress2", DbType="NVarChar(255)")]
		public string StreetAddress2
		{
			get
			{
				return this._StreetAddress2;
			}
			set
			{
				if ((this._StreetAddress2 != value))
				{
					this.OnStreetAddress2Changing(value);
					this.SendPropertyChanging();
					this._StreetAddress2 = value;
					this.SendPropertyChanged("StreetAddress2");
					this.OnStreetAddress2Changed();
				}
			}
		}
		
		[Column(Storage="_City", DbType="NVarChar(255)")]
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
		
		[Column(Storage="_State", DbType="NVarChar(255)")]
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
		
		[Column(Storage="_ZipCode", DbType="NVarChar(255)")]
		public string ZipCode
		{
			get
			{
				return this._ZipCode;
			}
			set
			{
				if ((this._ZipCode != value))
				{
					this.OnZipCodeChanging(value);
					this.SendPropertyChanging();
					this._ZipCode = value;
					this.SendPropertyChanged("ZipCode");
					this.OnZipCodeChanged();
				}
			}
		}
		
		[Column(Storage="_FirstName", DbType="NVarChar(255)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[Column(Storage="_LastName", DbType="NVarChar(255)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[Association(Name="Customer_Order", Storage="_Orders", ThisKey="CustomerID", OtherKey="CustomerId")]
		public EntitySet<Order> Orders
		{
			get
			{
				return this._Orders;
			}
			set
			{
				this._Orders.Assign(value);
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
		
		private void attach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.Customer = this;
		}
		
		private void detach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.Customer = null;
		}
	}
	
	[Table(Name="dbo.Products")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProductID;
		
		private string _Name;
		
		private string _Description;
		
		private EntitySet<OrderItem> _OrderItems;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductIDChanging(int value);
    partial void OnProductIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public Product()
		{
			this._OrderItems = new EntitySet<OrderItem>(new Action<OrderItem>(this.attach_OrderItems), new Action<OrderItem>(this.detach_OrderItems));
			OnCreated();
		}
		
		[Column(Storage="_ProductID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProductID
		{
			get
			{
				return this._ProductID;
			}
			set
			{
				if ((this._ProductID != value))
				{
					this.OnProductIDChanging(value);
					this.SendPropertyChanging();
					this._ProductID = value;
					this.SendPropertyChanged("ProductID");
					this.OnProductIDChanged();
				}
			}
		}
		
		[Column(Storage="_Name", DbType="NVarChar(255)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_Description", DbType="NVarChar(255)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Association(Name="Product_OrderItem", Storage="_OrderItems", ThisKey="ProductID", OtherKey="ProductId")]
		public EntitySet<OrderItem> OrderItems
		{
			get
			{
				return this._OrderItems;
			}
			set
			{
				this._OrderItems.Assign(value);
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
		
		private void attach_OrderItems(OrderItem entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_OrderItems(OrderItem entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
	}
	
	[Table(Name="dbo.CustomOrderItem")]
	public partial class CustomOrderItem : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Store;
		
		private System.Nullable<int> _CustomOrderId;
		
		private EntityRef<CustomOrder> _CustomOrder;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnStoreChanging(string value);
    partial void OnStoreChanged();
    partial void OnCustomOrderIdChanging(System.Nullable<int> value);
    partial void OnCustomOrderIdChanged();
    #endregion
		
		public CustomOrderItem()
		{
			this._CustomOrder = default(EntityRef<CustomOrder>);
			OnCreated();
		}
		
		[Column(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[Column(Storage="_Name", DbType="NVarChar(255)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_Store", DbType="NVarChar(255)")]
		public string Store
		{
			get
			{
				return this._Store;
			}
			set
			{
				if ((this._Store != value))
				{
					this.OnStoreChanging(value);
					this.SendPropertyChanging();
					this._Store = value;
					this.SendPropertyChanged("Store");
					this.OnStoreChanged();
				}
			}
		}
		
		[Column(Storage="_CustomOrderId", DbType="Int")]
		public System.Nullable<int> CustomOrderId
		{
			get
			{
				return this._CustomOrderId;
			}
			set
			{
				if ((this._CustomOrderId != value))
				{
					if (this._CustomOrder.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCustomOrderIdChanging(value);
					this.SendPropertyChanging();
					this._CustomOrderId = value;
					this.SendPropertyChanged("CustomOrderId");
					this.OnCustomOrderIdChanged();
				}
			}
		}
		
		[Association(Name="CustomOrder_CustomOrderItem", Storage="_CustomOrder", ThisKey="CustomOrderId", OtherKey="Id", IsForeignKey=true)]
		public CustomOrder CustomOrder
		{
			get
			{
				return this._CustomOrder.Entity;
			}
			set
			{
				CustomOrder previousValue = this._CustomOrder.Entity;
				if (((previousValue != value) 
							|| (this._CustomOrder.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._CustomOrder.Entity = null;
						previousValue.CustomOrderItems.Remove(this);
					}
					this._CustomOrder.Entity = value;
					if ((value != null))
					{
						value.CustomOrderItems.Add(this);
						this._CustomOrderId = value.Id;
					}
					else
					{
						this._CustomOrderId = default(Nullable<int>);
					}
					this.SendPropertyChanged("CustomOrder");
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
	
	[Table(Name="dbo.CustomOrders")]
	public partial class CustomOrder : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<System.DateTime> _OrderDate;
		
		private EntitySet<CustomOrderItem> _CustomOrderItems;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnOrderDateChanging(System.Nullable<System.DateTime> value);
    partial void OnOrderDateChanged();
    #endregion
		
		public CustomOrder()
		{
			this._CustomOrderItems = new EntitySet<CustomOrderItem>(new Action<CustomOrderItem>(this.attach_CustomOrderItems), new Action<CustomOrderItem>(this.detach_CustomOrderItems));
			OnCreated();
		}
		
		[Column(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[Column(Storage="_OrderDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> OrderDate
		{
			get
			{
				return this._OrderDate;
			}
			set
			{
				if ((this._OrderDate != value))
				{
					this.OnOrderDateChanging(value);
					this.SendPropertyChanging();
					this._OrderDate = value;
					this.SendPropertyChanged("OrderDate");
					this.OnOrderDateChanged();
				}
			}
		}
		
		[Association(Name="CustomOrder_CustomOrderItem", Storage="_CustomOrderItems", ThisKey="Id", OtherKey="CustomOrderId")]
		public EntitySet<CustomOrderItem> CustomOrderItems
		{
			get
			{
				return this._CustomOrderItems;
			}
			set
			{
				this._CustomOrderItems.Assign(value);
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
		
		private void attach_CustomOrderItems(CustomOrderItem entity)
		{
			this.SendPropertyChanging();
			entity.CustomOrder = this;
		}
		
		private void detach_CustomOrderItems(CustomOrderItem entity)
		{
			this.SendPropertyChanging();
			entity.CustomOrder = null;
		}
	}
	
	[Table(Name="dbo.MonthlySalesSummary")]
	public partial class MonthlySalesSummary : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Year;
		
		private int _Month;
		
		private int _SalesPersonId;
		
		private System.Nullable<decimal> _Amount;
		
		private string _Currency;
		
		private string _SalesPersonFirstName;
		
		private string _SalesPersonLastName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnYearChanging(int value);
    partial void OnYearChanged();
    partial void OnMonthChanging(int value);
    partial void OnMonthChanged();
    partial void OnSalesPersonIdChanging(int value);
    partial void OnSalesPersonIdChanged();
    partial void OnAmountChanging(System.Nullable<decimal> value);
    partial void OnAmountChanged();
    partial void OnCurrencyChanging(string value);
    partial void OnCurrencyChanged();
    partial void OnSalesPersonFirstNameChanging(string value);
    partial void OnSalesPersonFirstNameChanged();
    partial void OnSalesPersonLastNameChanging(string value);
    partial void OnSalesPersonLastNameChanged();
    #endregion
		
		public MonthlySalesSummary()
		{
			OnCreated();
		}
		
		[Column(Storage="_Year", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this.OnYearChanging(value);
					this.SendPropertyChanging();
					this._Year = value;
					this.SendPropertyChanged("Year");
					this.OnYearChanged();
				}
			}
		}
		
		[Column(Storage="_Month", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Month
		{
			get
			{
				return this._Month;
			}
			set
			{
				if ((this._Month != value))
				{
					this.OnMonthChanging(value);
					this.SendPropertyChanging();
					this._Month = value;
					this.SendPropertyChanged("Month");
					this.OnMonthChanged();
				}
			}
		}
		
		[Column(Storage="_SalesPersonId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int SalesPersonId
		{
			get
			{
				return this._SalesPersonId;
			}
			set
			{
				if ((this._SalesPersonId != value))
				{
					this.OnSalesPersonIdChanging(value);
					this.SendPropertyChanging();
					this._SalesPersonId = value;
					this.SendPropertyChanged("SalesPersonId");
					this.OnSalesPersonIdChanged();
				}
			}
		}
		
		[Column(Storage="_Amount", DbType="Decimal(19,5)")]
		public System.Nullable<decimal> Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[Column(Storage="_Currency", DbType="NVarChar(255)")]
		public string Currency
		{
			get
			{
				return this._Currency;
			}
			set
			{
				if ((this._Currency != value))
				{
					this.OnCurrencyChanging(value);
					this.SendPropertyChanging();
					this._Currency = value;
					this.SendPropertyChanged("Currency");
					this.OnCurrencyChanged();
				}
			}
		}
		
		[Column(Storage="_SalesPersonFirstName", DbType="NVarChar(255)")]
		public string SalesPersonFirstName
		{
			get
			{
				return this._SalesPersonFirstName;
			}
			set
			{
				if ((this._SalesPersonFirstName != value))
				{
					this.OnSalesPersonFirstNameChanging(value);
					this.SendPropertyChanging();
					this._SalesPersonFirstName = value;
					this.SendPropertyChanged("SalesPersonFirstName");
					this.OnSalesPersonFirstNameChanged();
				}
			}
		}
		
		[Column(Storage="_SalesPersonLastName", DbType="NVarChar(255)")]
		public string SalesPersonLastName
		{
			get
			{
				return this._SalesPersonLastName;
			}
			set
			{
				if ((this._SalesPersonLastName != value))
				{
					this.OnSalesPersonLastNameChanging(value);
					this.SendPropertyChanging();
					this._SalesPersonLastName = value;
					this.SendPropertyChanged("SalesPersonLastName");
					this.OnSalesPersonLastNameChanged();
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
	
	[Table(Name="dbo.OrderItems")]
	public partial class OrderItem : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OrderItemID;
		
		private System.Nullable<decimal> _Price;
		
		private System.Nullable<int> _Quantity;
		
		private System.Nullable<int> _ProductId;
		
		private System.Nullable<int> _OrderId;
		
		private string _Store;
		
		private EntityRef<Product> _Product;
		
		private EntityRef<Order> _Order;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderItemIDChanging(int value);
    partial void OnOrderItemIDChanged();
    partial void OnPriceChanging(System.Nullable<decimal> value);
    partial void OnPriceChanged();
    partial void OnQuantityChanging(System.Nullable<int> value);
    partial void OnQuantityChanged();
    partial void OnProductIdChanging(System.Nullable<int> value);
    partial void OnProductIdChanged();
    partial void OnOrderIdChanging(System.Nullable<int> value);
    partial void OnOrderIdChanged();
    partial void OnStoreChanging(string value);
    partial void OnStoreChanged();
    #endregion
		
		public OrderItem()
		{
			this._Product = default(EntityRef<Product>);
			this._Order = default(EntityRef<Order>);
			OnCreated();
		}
		
		[Column(Storage="_OrderItemID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int OrderItemID
		{
			get
			{
				return this._OrderItemID;
			}
			set
			{
				if ((this._OrderItemID != value))
				{
					this.OnOrderItemIDChanging(value);
					this.SendPropertyChanging();
					this._OrderItemID = value;
					this.SendPropertyChanged("OrderItemID");
					this.OnOrderItemIDChanged();
				}
			}
		}
		
		[Column(Storage="_Price", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[Column(Storage="_Quantity", DbType="Int")]
		public System.Nullable<int> Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[Column(Storage="_ProductId", DbType="Int")]
		public System.Nullable<int> ProductId
		{
			get
			{
				return this._ProductId;
			}
			set
			{
				if ((this._ProductId != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductIdChanging(value);
					this.SendPropertyChanging();
					this._ProductId = value;
					this.SendPropertyChanged("ProductId");
					this.OnProductIdChanged();
				}
			}
		}
		
		[Column(Storage="_OrderId", DbType="Int")]
		public System.Nullable<int> OrderId
		{
			get
			{
				return this._OrderId;
			}
			set
			{
				if ((this._OrderId != value))
				{
					if (this._Order.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnOrderIdChanging(value);
					this.SendPropertyChanging();
					this._OrderId = value;
					this.SendPropertyChanged("OrderId");
					this.OnOrderIdChanged();
				}
			}
		}
		
		[Column(Storage="_Store", DbType="NVarChar(255)")]
		public string Store
		{
			get
			{
				return this._Store;
			}
			set
			{
				if ((this._Store != value))
				{
					this.OnStoreChanging(value);
					this.SendPropertyChanging();
					this._Store = value;
					this.SendPropertyChanged("Store");
					this.OnStoreChanged();
				}
			}
		}
		
		[Association(Name="Product_OrderItem", Storage="_Product", ThisKey="ProductId", OtherKey="ProductID", IsForeignKey=true)]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.OrderItems.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.OrderItems.Add(this);
						this._ProductId = value.ProductID;
					}
					else
					{
						this._ProductId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Product");
				}
			}
		}
		
		[Association(Name="Order_OrderItem", Storage="_Order", ThisKey="OrderId", OtherKey="OrderID", IsForeignKey=true)]
		public Order Order
		{
			get
			{
				return this._Order.Entity;
			}
			set
			{
				Order previousValue = this._Order.Entity;
				if (((previousValue != value) 
							|| (this._Order.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Order.Entity = null;
						previousValue.OrderItems.Remove(this);
					}
					this._Order.Entity = value;
					if ((value != null))
					{
						value.OrderItems.Add(this);
						this._OrderId = value.OrderID;
					}
					else
					{
						this._OrderId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Order");
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
	
	[Table(Name="dbo.Orders")]
	public partial class Order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OrderID;
		
		private System.Nullable<System.DateTime> _OrderDate;
		
		private System.Nullable<System.DateTime> _ShipDate;
		
		private System.Nullable<int> _CustomerId;
		
		private EntitySet<OrderItem> _OrderItems;
		
		private EntityRef<Customer> _Customer;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderIDChanging(int value);
    partial void OnOrderIDChanged();
    partial void OnOrderDateChanging(System.Nullable<System.DateTime> value);
    partial void OnOrderDateChanged();
    partial void OnShipDateChanging(System.Nullable<System.DateTime> value);
    partial void OnShipDateChanged();
    partial void OnCustomerIdChanging(System.Nullable<int> value);
    partial void OnCustomerIdChanged();
    #endregion
		
		public Order()
		{
			this._OrderItems = new EntitySet<OrderItem>(new Action<OrderItem>(this.attach_OrderItems), new Action<OrderItem>(this.detach_OrderItems));
			this._Customer = default(EntityRef<Customer>);
			OnCreated();
		}
		
		[Column(Storage="_OrderID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int OrderID
		{
			get
			{
				return this._OrderID;
			}
			set
			{
				if ((this._OrderID != value))
				{
					this.OnOrderIDChanging(value);
					this.SendPropertyChanging();
					this._OrderID = value;
					this.SendPropertyChanged("OrderID");
					this.OnOrderIDChanged();
				}
			}
		}
		
		[Column(Storage="_OrderDate", DbType="DateTime", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<System.DateTime> OrderDate
		{
			get
			{
				return this._OrderDate;
			}
			set
			{
				if ((this._OrderDate != value))
				{
					this.OnOrderDateChanging(value);
					this.SendPropertyChanging();
					this._OrderDate = value;
					this.SendPropertyChanged("OrderDate");
					this.OnOrderDateChanged();
				}
			}
		}
		
		[Column(Storage="_ShipDate", DbType="DateTime", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<System.DateTime> ShipDate
		{
			get
			{
				return this._ShipDate;
			}
			set
			{
				if ((this._ShipDate != value))
				{
					this.OnShipDateChanging(value);
					this.SendPropertyChanging();
					this._ShipDate = value;
					this.SendPropertyChanged("ShipDate");
					this.OnShipDateChanged();
				}
			}
		}
		
		[Column(Storage="_CustomerId", DbType="Int")]
		public System.Nullable<int> CustomerId
		{
			get
			{
				return this._CustomerId;
			}
			set
			{
				if ((this._CustomerId != value))
				{
					if (this._Customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCustomerIdChanging(value);
					this.SendPropertyChanging();
					this._CustomerId = value;
					this.SendPropertyChanged("CustomerId");
					this.OnCustomerIdChanged();
				}
			}
		}
		
		[Association(Name="Order_OrderItem", Storage="_OrderItems", ThisKey="OrderID", OtherKey="OrderId")]
		public EntitySet<OrderItem> OrderItems
		{
			get
			{
				return this._OrderItems;
			}
			set
			{
				this._OrderItems.Assign(value);
			}
		}
		
		[Association(Name="Customer_Order", Storage="_Customer", ThisKey="CustomerId", OtherKey="CustomerID", IsForeignKey=true)]
		public Customer Customer
		{
			get
			{
				return this._Customer.Entity;
			}
			set
			{
				Customer previousValue = this._Customer.Entity;
				if (((previousValue != value) 
							|| (this._Customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Customer.Entity = null;
						previousValue.Orders.Remove(this);
					}
					this._Customer.Entity = value;
					if ((value != null))
					{
						value.Orders.Add(this);
						this._CustomerId = value.CustomerID;
					}
					else
					{
						this._CustomerId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Customer");
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
		
		private void attach_OrderItems(OrderItem entity)
		{
			this.SendPropertyChanging();
			entity.Order = this;
		}
		
		private void detach_OrderItems(OrderItem entity)
		{
			this.SendPropertyChanging();
			entity.Order = null;
		}
	}
}
#pragma warning restore 1591
