﻿' Developer Express Code Central Example:
' Binding Master and Detail focused rows to ViewModel objects
' 
' This example demonstrates how to use ViewModel properties to track and control
' focused row changes both for Master and Detail grids. This capability is
' achieved by creating attached behavior that handles all necessary events
' (especially for the focused view and row changing, both in the detail and master
' grids). The logic of focusing rows can be changed inside this behavior depending
' on your requirements. For example, you may want not to focus the first detail
' row when a master row is expanded. If so, change the MasterRowExpanded event
' handler as follows:
' 
' void MasterGridMasterRowExpanded(object sender,
' RowEventArgs e)
' {  (MasterGrid.GetDetail(MasterView.FocusedRowHandle) as
' GridControl).View.FocusedRow = null;
' }
' 
' 
' 
' 
' So, the main idea of the example is
' to show how the row focusing logic can be defined in the GridControl that
' operates in Master-Detail mode.
' 
' Important note:the approach shown in the
' example will work only with the DataControlDetailDescriptor, as other
' descriptors use custom templates to display detail content that is not
' synchronized with the master grid.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4402

' Developer Express Code Central Example:
' How to create a master-detail grid
' 
' In the 12.1 version we implemented a Master-Detail feature, and now we provide
' it out of the box. We have added a new solution, which shows how to use our new
' approach.
' 
' With later versions of our controls you can use the previous
' workaround:
' To accomplish this, it is necessary to use one GridControl as a
' template for a data row of another GridControl.
' Limitations of the previous
' approach:
' Vertical scrolling is performed per master row. For an example on how
' to implement vertical scrolling of details, please see 'Persistent Row State' in
' the DXGrid's demo.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E1000

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.3053
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace My


    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")> _
    Friend NotInheritable Partial Class Settings
        Inherits System.Configuration.ApplicationSettingsBase

        Private Shared defaultInstance As Settings = (CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()), Settings))

        Public Shared ReadOnly Property [Default]() As Settings
            Get
                Return defaultInstance
            End Get
        End Property
    End Class
End Namespace
