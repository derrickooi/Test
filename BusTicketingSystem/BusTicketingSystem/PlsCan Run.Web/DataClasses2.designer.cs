﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlsCan_Run
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BTSDB")]
	public partial class DataClasses2DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertRoute(Route instance);
    partial void UpdateRoute(Route instance);
    partial void DeleteRoute(Route instance);
    #endregion
		
		public DataClasses2DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["BTSDBConn"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Route> Routes
		{
			get
			{
				return this.GetTable<Route>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Route")]
	public partial class Route : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _routeID;
		
		private string _routeFrom;
		
		private string _routeTo;
		
		private string _price;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnrouteIDChanging(string value);
    partial void OnrouteIDChanged();
    partial void OnrouteFromChanging(string value);
    partial void OnrouteFromChanged();
    partial void OnrouteToChanging(string value);
    partial void OnrouteToChanged();
    partial void OnpriceChanging(string value);
    partial void OnpriceChanged();
    #endregion
		
		public Route()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_routeID", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string routeID
		{
			get
			{
				return this._routeID;
			}
			set
			{
				if ((this._routeID != value))
				{
					this.OnrouteIDChanging(value);
					this.SendPropertyChanging();
					this._routeID = value;
					this.SendPropertyChanged("routeID");
					this.OnrouteIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_routeFrom", DbType="NVarChar(50)")]
		public string routeFrom
		{
			get
			{
				return this._routeFrom;
			}
			set
			{
				if ((this._routeFrom != value))
				{
					this.OnrouteFromChanging(value);
					this.SendPropertyChanging();
					this._routeFrom = value;
					this.SendPropertyChanged("routeFrom");
					this.OnrouteFromChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_routeTo", DbType="NVarChar(50)")]
		public string routeTo
		{
			get
			{
				return this._routeTo;
			}
			set
			{
				if ((this._routeTo != value))
				{
					this.OnrouteToChanging(value);
					this.SendPropertyChanging();
					this._routeTo = value;
					this.SendPropertyChanged("routeTo");
					this.OnrouteToChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="NVarChar(50)")]
		public string price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
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
