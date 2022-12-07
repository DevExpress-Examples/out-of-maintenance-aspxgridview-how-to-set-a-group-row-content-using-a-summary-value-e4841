Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Web

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		ASPxGridView1.DataSource = Enumerable.Range(0, 10).Select(Function(i) New With {Key .ID = i, Key .Text = If(i Mod 2 = 0, "Group 1", "Group 2")})
		If (Not IsPostBack) Then
			ASPxGridView1.DataBind()
		End If
		ASPxGridView1.ExpandAll()
	End Sub

	Public Function GetSummaryValue(ByVal c As GridViewGroupRowTemplateContainer) As String
		Dim grid = c.Grid
		Dim summary = grid.GroupSummary("ID")
		Dim sumValue = grid.GetGroupSummaryValue(c.VisibleIndex, summary)
		Return sumValue.ToString()
	End Function
End Class