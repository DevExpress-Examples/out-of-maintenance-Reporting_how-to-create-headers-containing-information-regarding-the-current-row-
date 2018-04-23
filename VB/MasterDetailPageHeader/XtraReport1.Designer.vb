Imports Microsoft.VisualBasic
Imports System
Namespace MasterDetailPageHeader
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
			Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
			Me.nwindDataSet1 = New MasterDetailPageHeader.nwindDataSet()
			Me.categoriesTableAdapter = New MasterDetailPageHeader.nwindDataSetTableAdapters.CategoriesTableAdapter()
			Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
			Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.productsTableAdapter = New MasterDetailPageHeader.nwindDataSetTableAdapters.ProductsTableAdapter()
			Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' PageHeader
			' 
			Me.PageHeader.HeightF = 30F
			Me.PageHeader.Name = "PageHeader"
			Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' PageFooter
			' 
			Me.PageFooter.HeightF = 30F
			Me.PageFooter.Name = "PageFooter"
			Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' categoriesTableAdapter
			' 
			Me.categoriesTableAdapter.ClearBeforeFill = True
			' 
			' DetailReport
			' 
			Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail1, Me.GroupHeader1})
			Me.DetailReport.DataAdapter = Me.productsTableAdapter
			Me.DetailReport.DataMember = "Categories.CategoriesProducts"
			Me.DetailReport.DataSource = Me.nwindDataSet1
			Me.DetailReport.Level = 0
			Me.DetailReport.Name = "DetailReport"
			' 
			' Detail1
			' 
			Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel6, Me.xrLabel5, Me.xrLabel4, Me.xrLabel3})
			Me.Detail1.HeightF = 42F
			Me.Detail1.Name = "Detail1"
			' 
			' xrLabel6
			' 
			Me.xrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.UnitsOnOrder")})
			Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(508F, 0F)
			Me.xrLabel6.Name = "xrLabel6"
			Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel6.SizeF = New System.Drawing.SizeF(133F, 42F)
			Me.xrLabel6.Text = "xrLabel6"
			' 
			' xrLabel5
			' 
			Me.xrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.UnitsInStock")})
			Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(375F, 0F)
			Me.xrLabel5.Name = "xrLabel5"
			Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel5.SizeF = New System.Drawing.SizeF(125F, 42F)
			Me.xrLabel5.Text = "xrLabel5"
			' 
			' xrLabel4
			' 
			Me.xrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.UnitPrice")})
			Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(233F, 0F)
			Me.xrLabel4.Name = "xrLabel4"
			Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel4.SizeF = New System.Drawing.SizeF(133F, 42F)
			Me.xrLabel4.Text = "xrLabel4"
			' 
			' xrLabel3
			' 
			Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.ProductName")})
			Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel3.SizeF = New System.Drawing.SizeF(225F, 42F)
			Me.xrLabel3.Text = "xrLabel3"
			' 
			' GroupHeader1
			' 
			Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox1, Me.xrLabel2, Me.xrLabel1})
			Me.GroupHeader1.Name = "GroupHeader1"
			Me.GroupHeader1.RepeatEveryPage = True
			' 
			' xrPictureBox1
			' 
			Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Picture")})
			Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(450F, 0F)
			Me.xrPictureBox1.Name = "xrPictureBox1"
			Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(200F, 100F)
			Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
			' 
			' xrLabel2
			' 
			Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.Description")})
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(8F, 42F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(333F, 58F)
			Me.xrLabel2.Text = "xrLabel2"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName")})
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(8F, 0F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(333F, 42F)
			Me.xrLabel1.Text = "xrLabel1"
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' topMarginBand1
			' 
			Me.topMarginBand1.Name = "topMarginBand1"
			' 
			' bottomMarginBand1
			' 
			Me.bottomMarginBand1.Name = "bottomMarginBand1"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.PageFooter, Me.DetailReport, Me.topMarginBand1, Me.bottomMarginBand1})
			Me.DataAdapter = Me.categoriesTableAdapter
			Me.DataMember = "Categories"
			Me.DataSource = Me.nwindDataSet1
			Me.Version = "12.2"
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private nwindDataSet1 As nwindDataSet
		Private categoriesTableAdapter As MasterDetailPageHeader.nwindDataSetTableAdapters.CategoriesTableAdapter
		Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand
		Private Detail1 As DevExpress.XtraReports.UI.DetailBand
		Private productsTableAdapter As MasterDetailPageHeader.nwindDataSetTableAdapters.ProductsTableAdapter
		Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private xrLabel6 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
		Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
	End Class
End Namespace
