Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Collections

Namespace WindowsApplication28
	Public Class Record
		Private id_Renamed, age_Renamed As Integer
		Private name_Renamed As String
		Private detail_Renamed As List(Of Record)
		Private _coWorkers As List(Of Record)
		Public Sub New(ByVal id As Integer, ByVal name As String, ByVal age As Integer, ByVal detail As List(Of Record), ByVal coWorkers As List(Of Record))
			Me.id_Renamed = id
			Me.name_Renamed = name
			Me.age_Renamed = age
			Me.detail_Renamed = detail
			_coWorkers = coWorkers
		End Sub
		Public ReadOnly Property ID() As Integer
			Get
				Return id_Renamed
			End Get
		End Property
		Public Property Name() As String
			Get
				Return name_Renamed
			End Get
			Set(ByVal value As String)
				name_Renamed = value
			End Set
		End Property
		Public Property Age() As Integer
			Get
				Return age_Renamed
			End Get
			Set(ByVal value As Integer)
				age_Renamed = value
			End Set
		End Property
		Public ReadOnly Property CoWorkers() As List(Of Record)
			Get
				Return _coWorkers
			End Get
			'set { detail = value; }
		End Property
		Public ReadOnly Property Detail() As List(Of Record)
			Get
				Return detail_Renamed
			End Get
			'set { detail = value; }
		End Property
	End Class
End Namespace
