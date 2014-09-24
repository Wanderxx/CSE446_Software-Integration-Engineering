﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CoursesDb")]
public partial class CoursesClassesDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertInstructors(Instructors instance);
  partial void UpdateInstructors(Instructors instance);
  partial void DeleteInstructors(Instructors instance);
  partial void InsertmyCourse(myCourse instance);
  partial void UpdatemyCourse(myCourse instance);
  partial void DeletemyCourse(myCourse instance);
  #endregion
	
	public CoursesClassesDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["CoursesDbConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public CoursesClassesDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public CoursesClassesDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public CoursesClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public CoursesClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Instructors> Instructors
	{
		get
		{
			return this.GetTable<Instructors>();
		}
	}
	
	public System.Data.Linq.Table<myCourse> myCourses
	{
		get
		{
			return this.GetTable<myCourse>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Instructors")]
public partial class Instructors : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _FirstName;
	
	private string _LastName;
	
	private string _OfficeNum;
	
	private string _Courses;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnOfficeNumChanging(string value);
    partial void OnOfficeNumChanged();
    partial void OnCoursesChanging(string value);
    partial void OnCoursesChanged();
    #endregion
	
	public Instructors()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NChar(20)")]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NChar(20)")]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OfficeNum", DbType="NChar(10)")]
	public string OfficeNum
	{
		get
		{
			return this._OfficeNum;
		}
		set
		{
			if ((this._OfficeNum != value))
			{
				this.OnOfficeNumChanging(value);
				this.SendPropertyChanging();
				this._OfficeNum = value;
				this.SendPropertyChanged("OfficeNum");
				this.OnOfficeNumChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Courses", DbType="NChar(50)")]
	public string Courses
	{
		get
		{
			return this._Courses;
		}
		set
		{
			if ((this._Courses != value))
			{
				this.OnCoursesChanging(value);
				this.SendPropertyChanging();
				this._Courses = value;
				this.SendPropertyChanged("Courses");
				this.OnCoursesChanged();
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.myCourse")]
public partial class myCourse : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _CourseId;
	
	private string _CourseCode;
	
	private string _Title;
	
	private string _Instructor;
	
	private string _Cap;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCourseIdChanging(int value);
    partial void OnCourseIdChanged();
    partial void OnCourseCodeChanging(string value);
    partial void OnCourseCodeChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnInstructorChanging(string value);
    partial void OnInstructorChanged();
    partial void OnCapChanging(string value);
    partial void OnCapChanged();
    #endregion
	
	public myCourse()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int CourseId
	{
		get
		{
			return this._CourseId;
		}
		set
		{
			if ((this._CourseId != value))
			{
				this.OnCourseIdChanging(value);
				this.SendPropertyChanging();
				this._CourseId = value;
				this.SendPropertyChanged("CourseId");
				this.OnCourseIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseCode", DbType="NChar(10)")]
	public string CourseCode
	{
		get
		{
			return this._CourseCode;
		}
		set
		{
			if ((this._CourseCode != value))
			{
				this.OnCourseCodeChanging(value);
				this.SendPropertyChanging();
				this._CourseCode = value;
				this.SendPropertyChanged("CourseCode");
				this.OnCourseCodeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NChar(50)")]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Instructor", DbType="NChar(20)")]
	public string Instructor
	{
		get
		{
			return this._Instructor;
		}
		set
		{
			if ((this._Instructor != value))
			{
				this.OnInstructorChanging(value);
				this.SendPropertyChanging();
				this._Instructor = value;
				this.SendPropertyChanged("Instructor");
				this.OnInstructorChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cap", DbType="NChar(10)")]
	public string Cap
	{
		get
		{
			return this._Cap;
		}
		set
		{
			if ((this._Cap != value))
			{
				this.OnCapChanging(value);
				this.SendPropertyChanging();
				this._Cap = value;
				this.SendPropertyChanged("Cap");
				this.OnCapChanged();
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
#pragma warning restore 1591