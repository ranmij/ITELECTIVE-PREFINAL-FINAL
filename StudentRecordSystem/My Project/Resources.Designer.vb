﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("StudentRecordSystem.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Add Student.
        '''</summary>
        Friend ReadOnly Property addStudentBtnLabel() As String
            Get
                Return ResourceManager.GetString("addStudentBtnLabel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to STUDENTS RECORD SYSTEM.
        '''</summary>
        Friend ReadOnly Property appName() As String
            Get
                Return ResourceManager.GetString("appName", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to C:\.
        '''</summary>
        Friend ReadOnly Property baseCDirectory() As String
            Get
                Return ResourceManager.GetString("baseCDirectory", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to D:\.
        '''</summary>
        Friend ReadOnly Property baseDDirectory() As String
            Get
                Return ResourceManager.GetString("baseDDirectory", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to D:\StudentsProfile\.
        '''</summary>
        Friend ReadOnly Property basePath() As String
            Get
                Return ResourceManager.GetString("basePath", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property close() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("close", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to CONTACT:.
        '''</summary>
        Friend ReadOnly Property contactLabel() As String
            Get
                Return ResourceManager.GetString("contactLabel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property copy() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("copy", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Error when copying the image please try again..
        '''</summary>
        Friend ReadOnly Property copyErrorText() As String
            Get
                Return ResourceManager.GetString("copyErrorText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to COURSE:.
        '''</summary>
        Friend ReadOnly Property courseLabel() As String
            Get
                Return ResourceManager.GetString("courseLabel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to id.
        '''</summary>
        Friend ReadOnly Property departmentIdColumn() As String
            Get
                Return ResourceManager.GetString("departmentIdColumn", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to DEPARTMENT:.
        '''</summary>
        Friend ReadOnly Property departmentLabel() As String
            Get
                Return ResourceManager.GetString("departmentLabel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to department_name.
        '''</summary>
        Friend ReadOnly Property departmentNameColumn() As String
            Get
                Return ResourceManager.GetString("departmentNameColumn", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please fill the empty fields.
        '''</summary>
        Friend ReadOnly Property emptyFieldsErrorText() As String
            Get
                Return ResourceManager.GetString("emptyFieldsErrorText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Error!.
        '''</summary>
        Friend ReadOnly Property errorCaption() As String
            Get
                Return ResourceManager.GetString("errorCaption", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to F.
        '''</summary>
        Friend ReadOnly Property femaleInitial() As String
            Get
                Return ResourceManager.GetString("femaleInitial", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Female.
        '''</summary>
        Friend ReadOnly Property femaleText() As String
            Get
                Return ResourceManager.GetString("femaleText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Add Image.
        '''</summary>
        Friend ReadOnly Property fileDialogTitle() As String
            Get
                Return ResourceManager.GetString("fileDialogTitle", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to *.png|*.jpg.
        '''</summary>
        Friend ReadOnly Property fileTypeFilter() As String
            Get
                Return ResourceManager.GetString("fileTypeFilter", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to GENDER:.
        '''</summary>
        Friend ReadOnly Property genderLabel() As String
            Get
                Return ResourceManager.GetString("genderLabel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to D:\StudentsProfile.
        '''</summary>
        Friend ReadOnly Property homeDirectory() As String
            Get
                Return ResourceManager.GetString("homeDirectory", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Invalid!.
        '''</summary>
        Friend ReadOnly Property invalidCaption() As String
            Get
                Return ResourceManager.GetString("invalidCaption", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to .jpg.
        '''</summary>
        Friend ReadOnly Property jpgType() As String
            Get
                Return ResourceManager.GetString("jpgType", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to M.
        '''</summary>
        Friend ReadOnly Property maleInitial() As String
            Get
                Return ResourceManager.GetString("maleInitial", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Male.
        '''</summary>
        Friend ReadOnly Property maleText() As String
            Get
                Return ResourceManager.GetString("maleText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property maximize() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("maximize", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property minus() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("minus", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to STUDENT INFORMATION.
        '''</summary>
        Friend ReadOnly Property modalWindowLabel() As String
            Get
                Return ResourceManager.GetString("modalWindowLabel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to NAME:.
        '''</summary>
        Friend ReadOnly Property nameLabel() As String
            Get
                Return ResourceManager.GetString("nameLabel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to NULL.
        '''</summary>
        Friend ReadOnly Property nullLabel() As String
            Get
                Return ResourceManager.GetString("nullLabel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to OK.
        '''</summary>
        Friend ReadOnly Property okButtonLabel() As String
            Get
                Return ResourceManager.GetString("okButtonLabel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to .png.
        '''</summary>
        Friend ReadOnly Property pngType() As String
            Get
                Return ResourceManager.GetString("pngType", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Profile is missing!.
        '''</summary>
        Friend ReadOnly Property profileCaption() As String
            Get
                Return ResourceManager.GetString("profileCaption", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to id.
        '''</summary>
        Friend ReadOnly Property profileIdColumn() As String
            Get
                Return ResourceManager.GetString("profileIdColumn", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to image_path.
        '''</summary>
        Friend ReadOnly Property profileImagePathColumn() As String
            Get
                Return ResourceManager.GetString("profileImagePathColumn", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please provide a profile picture..
        '''</summary>
        Friend ReadOnly Property provideProfileErrorText() As String
            Get
                Return ResourceManager.GetString("provideProfileErrorText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to An error occured when saving the image.
        '''</summary>
        Friend ReadOnly Property savingImageErrorText() As String
            Get
                Return ResourceManager.GetString("savingImageErrorText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property search() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("search", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Search.
        '''</summary>
        Friend ReadOnly Property searchHint() As String
            Get
                Return ResourceManager.GetString("searchHint", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to STUDENT NO:.
        '''</summary>
        Friend ReadOnly Property studentNoLabel() As String
            Get
                Return ResourceManager.GetString("studentNoLabel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to STUDENTS RECORDS.
        '''</summary>
        Friend ReadOnly Property studentRecordWindowLabel() As String
            Get
                Return ResourceManager.GetString("studentRecordWindowLabel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Success!.
        '''</summary>
        Friend ReadOnly Property successCaption() As String
            Get
                Return ResourceManager.GetString("successCaption", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Student has been updated!.
        '''</summary>
        Friend ReadOnly Property successStudentText() As String
            Get
                Return ResourceManager.GetString("successStudentText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to An error occured please try again..
        '''</summary>
        Friend ReadOnly Property unknownErrrorText() As String
            Get
                Return ResourceManager.GetString("unknownErrrorText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property upload() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("upload", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property wave() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("wave", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
