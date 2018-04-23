Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid

Namespace WindowsApplication28
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim listDataSource As List(Of Record) = New List(Of Record)()
			listDataSource.Add(New Record(1, "Jane", 19, Nothing,listDataSource))
			listDataSource.Add(New Record(2, "Joe", 30, Nothing, Nothing))
			listDataSource.Add(New Record(3, "Bill", 15, Nothing, Nothing))
			listDataSource.Add(New Record(4, "Michael", 42, listDataSource, Nothing))
			gridView1.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckAllDetails
			gridControl1.DataSource = listDataSource
			gridControl1.MainView.PopulateColumns()
			For i As Integer = 0 To gridView1.DataRowCount - 1
				gridView1.ExpandMasterRow(i)
			Next i
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			filterIsActive = True
			gridView1.RefreshData()
		End Sub
		Private filterIsActive As Boolean = False
		Private Sub gridView1_CustomRowFilter(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowFilterEventArgs) Handles gridView1.CustomRowFilter
			If filterIsActive Then
				Dim view As GridView = CType(sender, GridView)
				Dim rowHandle As Integer = view.GetRowHandle(e.ListSourceRow)
				e.Visible = Not view.IsMasterRowEmptyEx(rowHandle, view.GetRelationIndex(rowHandle, "Detail"))
				e.Handled = True
			End If
		End Sub
	End Class
End Namespace