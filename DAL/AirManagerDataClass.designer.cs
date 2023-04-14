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

namespace DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="AIRMANAGER")]
	public partial class AirportsDataClassDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertRoute(Route instance);
    partial void UpdateRoute(Route instance);
    partial void DeleteRoute(Route instance);
    partial void InsertReservation(Reservation instance);
    partial void UpdateReservation(Reservation instance);
    partial void DeleteReservation(Reservation instance);
    partial void InsertPassenger(Passenger instance);
    partial void UpdatePassenger(Passenger instance);
    partial void DeletePassenger(Passenger instance);
    partial void InsertFlight(Flight instance);
    partial void UpdateFlight(Flight instance);
    partial void DeleteFlight(Flight instance);
    partial void InsertCountry(Country instance);
    partial void UpdateCountry(Country instance);
    partial void DeleteCountry(Country instance);
    partial void InsertBookingStatus(BookingStatus instance);
    partial void UpdateBookingStatus(BookingStatus instance);
    partial void DeleteBookingStatus(BookingStatus instance);
    partial void InsertAirport(Airport instance);
    partial void UpdateAirport(Airport instance);
    partial void DeleteAirport(Airport instance);
    partial void InsertAdmin(Admin instance);
    partial void UpdateAdmin(Admin instance);
    partial void DeleteAdmin(Admin instance);
    partial void InsertAirline(Airline instance);
    partial void UpdateAirline(Airline instance);
    partial void DeleteAirline(Airline instance);
    #endregion
		
		public AirportsDataClassDataContext() : 
				base(global::DAL.Properties.Settings.Default.AIRMANAGERConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public AirportsDataClassDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AirportsDataClassDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AirportsDataClassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AirportsDataClassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
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
		
		public System.Data.Linq.Table<Reservation> Reservations
		{
			get
			{
				return this.GetTable<Reservation>();
			}
		}
		
		public System.Data.Linq.Table<Passenger> Passengers
		{
			get
			{
				return this.GetTable<Passenger>();
			}
		}
		
		public System.Data.Linq.Table<Flight> Flights
		{
			get
			{
				return this.GetTable<Flight>();
			}
		}
		
		public System.Data.Linq.Table<Country> Countries
		{
			get
			{
				return this.GetTable<Country>();
			}
		}
		
		public System.Data.Linq.Table<BookingStatus> BookingStatus
		{
			get
			{
				return this.GetTable<BookingStatus>();
			}
		}
		
		public System.Data.Linq.Table<Airport> Airports
		{
			get
			{
				return this.GetTable<Airport>();
			}
		}
		
		public System.Data.Linq.Table<Admin> Admins
		{
			get
			{
				return this.GetTable<Admin>();
			}
		}
		
		public System.Data.Linq.Table<Airline> Airlines
		{
			get
			{
				return this.GetTable<Airline>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Routes")]
	public partial class Route : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RouteID;
		
		private int _OriginAirportID;
		
		private int _DestinationAirportID;
		
		private System.Nullable<int> _Duration;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRouteIDChanging(int value);
    partial void OnRouteIDChanged();
    partial void OnOriginAirportIDChanging(int value);
    partial void OnOriginAirportIDChanged();
    partial void OnDestinationAirportIDChanging(int value);
    partial void OnDestinationAirportIDChanged();
    partial void OnDurationChanging(System.Nullable<int> value);
    partial void OnDurationChanged();
    #endregion
		
		public Route()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RouteID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int RouteID
		{
			get
			{
				return this._RouteID;
			}
			set
			{
				if ((this._RouteID != value))
				{
					this.OnRouteIDChanging(value);
					this.SendPropertyChanging();
					this._RouteID = value;
					this.SendPropertyChanged("RouteID");
					this.OnRouteIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OriginAirportID", DbType="Int NOT NULL")]
		public int OriginAirportID
		{
			get
			{
				return this._OriginAirportID;
			}
			set
			{
				if ((this._OriginAirportID != value))
				{
					this.OnOriginAirportIDChanging(value);
					this.SendPropertyChanging();
					this._OriginAirportID = value;
					this.SendPropertyChanged("OriginAirportID");
					this.OnOriginAirportIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DestinationAirportID", DbType="Int NOT NULL")]
		public int DestinationAirportID
		{
			get
			{
				return this._DestinationAirportID;
			}
			set
			{
				if ((this._DestinationAirportID != value))
				{
					this.OnDestinationAirportIDChanging(value);
					this.SendPropertyChanging();
					this._DestinationAirportID = value;
					this.SendPropertyChanged("DestinationAirportID");
					this.OnDestinationAirportIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Duration", DbType="Int")]
		public System.Nullable<int> Duration
		{
			get
			{
				return this._Duration;
			}
			set
			{
				if ((this._Duration != value))
				{
					this.OnDurationChanging(value);
					this.SendPropertyChanging();
					this._Duration = value;
					this.SendPropertyChanged("Duration");
					this.OnDurationChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Reservations")]
	public partial class Reservation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ReservationID;
		
		private int _FlightID;
		
		private int _PassengerID;
		
		private int _SeatNumber;
		
		private double _Price;
		
		private int _BookingStatus;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnReservationIDChanging(int value);
    partial void OnReservationIDChanged();
    partial void OnFlightIDChanging(int value);
    partial void OnFlightIDChanged();
    partial void OnPassengerIDChanging(int value);
    partial void OnPassengerIDChanged();
    partial void OnSeatNumberChanging(int value);
    partial void OnSeatNumberChanged();
    partial void OnPriceChanging(double value);
    partial void OnPriceChanged();
    partial void OnBookingStatusChanging(int value);
    partial void OnBookingStatusChanged();
    #endregion
		
		public Reservation()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReservationID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ReservationID
		{
			get
			{
				return this._ReservationID;
			}
			set
			{
				if ((this._ReservationID != value))
				{
					this.OnReservationIDChanging(value);
					this.SendPropertyChanging();
					this._ReservationID = value;
					this.SendPropertyChanged("ReservationID");
					this.OnReservationIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FlightID", DbType="Int NOT NULL")]
		public int FlightID
		{
			get
			{
				return this._FlightID;
			}
			set
			{
				if ((this._FlightID != value))
				{
					this.OnFlightIDChanging(value);
					this.SendPropertyChanging();
					this._FlightID = value;
					this.SendPropertyChanged("FlightID");
					this.OnFlightIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PassengerID", DbType="Int NOT NULL")]
		public int PassengerID
		{
			get
			{
				return this._PassengerID;
			}
			set
			{
				if ((this._PassengerID != value))
				{
					this.OnPassengerIDChanging(value);
					this.SendPropertyChanging();
					this._PassengerID = value;
					this.SendPropertyChanged("PassengerID");
					this.OnPassengerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SeatNumber", DbType="Int NOT NULL")]
		public int SeatNumber
		{
			get
			{
				return this._SeatNumber;
			}
			set
			{
				if ((this._SeatNumber != value))
				{
					this.OnSeatNumberChanging(value);
					this.SendPropertyChanging();
					this._SeatNumber = value;
					this.SendPropertyChanged("SeatNumber");
					this.OnSeatNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Float NOT NULL")]
		public double Price
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookingStatus", DbType="Int NOT NULL")]
		public int BookingStatus
		{
			get
			{
				return this._BookingStatus;
			}
			set
			{
				if ((this._BookingStatus != value))
				{
					this.OnBookingStatusChanging(value);
					this.SendPropertyChanging();
					this._BookingStatus = value;
					this.SendPropertyChanged("BookingStatus");
					this.OnBookingStatusChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Passengers")]
	public partial class Passenger : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PassengerID;
		
		private string _FirstName;
		
		private string _LastName;
		
		private System.DateTime _DateOfBirth;
		
		private string _Email;
		
		private string _PhoneNumber;
		
		private string _Username;
		
		private string _Password;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPassengerIDChanging(int value);
    partial void OnPassengerIDChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnDateOfBirthChanging(System.DateTime value);
    partial void OnDateOfBirthChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPhoneNumberChanging(string value);
    partial void OnPhoneNumberChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public Passenger()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PassengerID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PassengerID
		{
			get
			{
				return this._PassengerID;
			}
			set
			{
				if ((this._PassengerID != value))
				{
					this.OnPassengerIDChanging(value);
					this.SendPropertyChanging();
					this._PassengerID = value;
					this.SendPropertyChanged("PassengerID");
					this.OnPassengerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateOfBirth", DbType="Date NOT NULL")]
		public System.DateTime DateOfBirth
		{
			get
			{
				return this._DateOfBirth;
			}
			set
			{
				if ((this._DateOfBirth != value))
				{
					this.OnDateOfBirthChanging(value);
					this.SendPropertyChanging();
					this._DateOfBirth = value;
					this.SendPropertyChanged("DateOfBirth");
					this.OnDateOfBirthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this.OnPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._PhoneNumber = value;
					this.SendPropertyChanged("PhoneNumber");
					this.OnPhoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(50)")]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Flights")]
	public partial class Flight : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _FlightID;
		
		private int _RouteID;
		
		private System.Nullable<System.DateTime> _DepartureTime;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFlightIDChanging(int value);
    partial void OnFlightIDChanged();
    partial void OnRouteIDChanging(int value);
    partial void OnRouteIDChanged();
    partial void OnDepartureTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnDepartureTimeChanged();
    #endregion
		
		public Flight()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FlightID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int FlightID
		{
			get
			{
				return this._FlightID;
			}
			set
			{
				if ((this._FlightID != value))
				{
					this.OnFlightIDChanging(value);
					this.SendPropertyChanging();
					this._FlightID = value;
					this.SendPropertyChanged("FlightID");
					this.OnFlightIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RouteID", DbType="Int NOT NULL")]
		public int RouteID
		{
			get
			{
				return this._RouteID;
			}
			set
			{
				if ((this._RouteID != value))
				{
					this.OnRouteIDChanging(value);
					this.SendPropertyChanging();
					this._RouteID = value;
					this.SendPropertyChanged("RouteID");
					this.OnRouteIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartureTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> DepartureTime
		{
			get
			{
				return this._DepartureTime;
			}
			set
			{
				if ((this._DepartureTime != value))
				{
					this.OnDepartureTimeChanging(value);
					this.SendPropertyChanging();
					this._DepartureTime = value;
					this.SendPropertyChanged("DepartureTime");
					this.OnDepartureTimeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Countrys")]
	public partial class Country : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CountryID;
		
		private string _Name;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCountryIDChanging(string value);
    partial void OnCountryIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Country()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CountryID", DbType="VarChar(2) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CountryID
		{
			get
			{
				return this._CountryID;
			}
			set
			{
				if ((this._CountryID != value))
				{
					this.OnCountryIDChanging(value);
					this.SendPropertyChanging();
					this._CountryID = value;
					this.SendPropertyChanged("CountryID");
					this.OnCountryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BookingStatus")]
	public partial class BookingStatus : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _BookingStatusID;
		
		private string _Status;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBookingStatusIDChanging(int value);
    partial void OnBookingStatusIDChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    #endregion
		
		public BookingStatus()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookingStatusID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int BookingStatusID
		{
			get
			{
				return this._BookingStatusID;
			}
			set
			{
				if ((this._BookingStatusID != value))
				{
					this.OnBookingStatusIDChanging(value);
					this.SendPropertyChanging();
					this._BookingStatusID = value;
					this.SendPropertyChanged("BookingStatusID");
					this.OnBookingStatusIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Airports")]
	public partial class Airport : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AirportID;
		
		private string _Name;
		
		private string _IATA;
		
		private string _ICAO;
		
		private string _City;
		
		private string _CountryID;
		
		private double _Latitude;
		
		private double _Longitude;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAirportIDChanging(int value);
    partial void OnAirportIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnIATAChanging(string value);
    partial void OnIATAChanged();
    partial void OnICAOChanging(string value);
    partial void OnICAOChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnCountryIDChanging(string value);
    partial void OnCountryIDChanged();
    partial void OnLatitudeChanging(double value);
    partial void OnLatitudeChanged();
    partial void OnLongitudeChanging(double value);
    partial void OnLongitudeChanged();
    #endregion
		
		public Airport()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AirportID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int AirportID
		{
			get
			{
				return this._AirportID;
			}
			set
			{
				if ((this._AirportID != value))
				{
					this.OnAirportIDChanging(value);
					this.SendPropertyChanging();
					this._AirportID = value;
					this.SendPropertyChanged("AirportID");
					this.OnAirportIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IATA", DbType="VarChar(3) NOT NULL", CanBeNull=false)]
		public string IATA
		{
			get
			{
				return this._IATA;
			}
			set
			{
				if ((this._IATA != value))
				{
					this.OnIATAChanging(value);
					this.SendPropertyChanging();
					this._IATA = value;
					this.SendPropertyChanged("IATA");
					this.OnIATAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ICAO", DbType="VarChar(4) NOT NULL", CanBeNull=false)]
		public string ICAO
		{
			get
			{
				return this._ICAO;
			}
			set
			{
				if ((this._ICAO != value))
				{
					this.OnICAOChanging(value);
					this.SendPropertyChanging();
					this._ICAO = value;
					this.SendPropertyChanged("ICAO");
					this.OnICAOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CountryID", DbType="VarChar(2) NOT NULL", CanBeNull=false)]
		public string CountryID
		{
			get
			{
				return this._CountryID;
			}
			set
			{
				if ((this._CountryID != value))
				{
					this.OnCountryIDChanging(value);
					this.SendPropertyChanging();
					this._CountryID = value;
					this.SendPropertyChanged("CountryID");
					this.OnCountryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Latitude", DbType="Float NOT NULL")]
		public double Latitude
		{
			get
			{
				return this._Latitude;
			}
			set
			{
				if ((this._Latitude != value))
				{
					this.OnLatitudeChanging(value);
					this.SendPropertyChanging();
					this._Latitude = value;
					this.SendPropertyChanged("Latitude");
					this.OnLatitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Longitude", DbType="Float NOT NULL")]
		public double Longitude
		{
			get
			{
				return this._Longitude;
			}
			set
			{
				if ((this._Longitude != value))
				{
					this.OnLongitudeChanging(value);
					this.SendPropertyChanging();
					this._Longitude = value;
					this.SendPropertyChanged("Longitude");
					this.OnLongitudeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Admins")]
	public partial class Admin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AdminID;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _Email;
		
		private string _Username;
		
		private string _Password;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAdminIDChanging(int value);
    partial void OnAdminIDChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public Admin()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdminID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int AdminID
		{
			get
			{
				return this._AdminID;
			}
			set
			{
				if ((this._AdminID != value))
				{
					this.OnAdminIDChanging(value);
					this.SendPropertyChanging();
					this._AdminID = value;
					this.SendPropertyChanged("AdminID");
					this.OnAdminIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Airlines")]
	public partial class Airline : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AirlineID;
		
		private string _Name;
		
		private string _IATA;
		
		private string _ICAO;
		
		private string _CountryID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAirlineIDChanging(int value);
    partial void OnAirlineIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnIATAChanging(string value);
    partial void OnIATAChanged();
    partial void OnICAOChanging(string value);
    partial void OnICAOChanged();
    partial void OnCountryIDChanging(string value);
    partial void OnCountryIDChanged();
    #endregion
		
		public Airline()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AirlineID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int AirlineID
		{
			get
			{
				return this._AirlineID;
			}
			set
			{
				if ((this._AirlineID != value))
				{
					this.OnAirlineIDChanging(value);
					this.SendPropertyChanging();
					this._AirlineID = value;
					this.SendPropertyChanged("AirlineID");
					this.OnAirlineIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IATA", DbType="VarChar(2) NOT NULL", CanBeNull=false)]
		public string IATA
		{
			get
			{
				return this._IATA;
			}
			set
			{
				if ((this._IATA != value))
				{
					this.OnIATAChanging(value);
					this.SendPropertyChanging();
					this._IATA = value;
					this.SendPropertyChanged("IATA");
					this.OnIATAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ICAO", DbType="VarChar(3) NOT NULL", CanBeNull=false)]
		public string ICAO
		{
			get
			{
				return this._ICAO;
			}
			set
			{
				if ((this._ICAO != value))
				{
					this.OnICAOChanging(value);
					this.SendPropertyChanging();
					this._ICAO = value;
					this.SendPropertyChanged("ICAO");
					this.OnICAOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CountryID", DbType="VarChar(2) NOT NULL", CanBeNull=false)]
		public string CountryID
		{
			get
			{
				return this._CountryID;
			}
			set
			{
				if ((this._CountryID != value))
				{
					this.OnCountryIDChanging(value);
					this.SendPropertyChanging();
					this._CountryID = value;
					this.SendPropertyChanged("CountryID");
					this.OnCountryIDChanged();
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