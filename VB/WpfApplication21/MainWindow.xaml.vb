﻿' Developer Express Code Central Example:
' GridControl - How to bind Master and Detail focused rows to ViewModel objects to follow the MVVM pattern in your application
' 
' This example demonstrates how to use ViewModel properties to track and control
' focused row changes both for Master and Detail grids. This capability is
' achieved by creating attached behavior that handles all necessary events
' (especially for the focused view and row changing, both in the detail and master
' grids). The logic of focusing rows can be changed inside this behavior depending
' on your requirements. For example, you may want not to focus the first detail
' row when a master row is expanded. If so, change the MasterRowExpanded event
' handler as follows:
' void MasterGridMasterRowExpanded(object sender,
' RowEventArgs e)
' {  (MasterGrid.GetDetail(MasterView.FocusedRowHandle) as
' GridControl).View.FocusedRow = null;
' }
' So, the main idea of the example is to
' show how the row focusing logic can be defined in the GridControl that operates
' in Master-Detail mode.
' Note that the approach shown in the example will work
' only with the DataControlDetailDescriptor, as other descriptors use custom
' templates to display detail content that is not synchronized with the master
' grid.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4402


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows

Namespace E4402
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			DataContext = New ViewModel()
		End Sub
	End Class
End Namespace
