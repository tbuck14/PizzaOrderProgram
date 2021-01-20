<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grbdelivery = New System.Windows.Forms.GroupBox()
        Me.lblhouseaddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.radDelivery = New System.Windows.Forms.RadioButton()
        Me.radpickup = New System.Windows.Forms.RadioButton()
        Me.lblDelivery = New System.Windows.Forms.Label()
        Me.grbToppings = New System.Windows.Forms.GroupBox()
        Me.cbPeppers = New System.Windows.Forms.CheckBox()
        Me.cbBacon = New System.Windows.Forms.CheckBox()
        Me.lblToppingCost = New System.Windows.Forms.Label()
        Me.cbMushrooms = New System.Windows.Forms.CheckBox()
        Me.cbSausage = New System.Windows.Forms.CheckBox()
        Me.cbPepperoni = New System.Windows.Forms.CheckBox()
        Me.cbCheese = New System.Windows.Forms.CheckBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.grbPizzaSize = New System.Windows.Forms.GroupBox()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.radSmall = New System.Windows.Forms.RadioButton()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.btnPop = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CouponToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintRecieptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbCalculate = New System.Windows.Forms.ToolStripButton()
        Me.tsbPrintPreview = New System.Windows.Forms.ToolStripButton()
        Me.tsbPop = New System.Windows.Forms.ToolStripButton()
        Me.tsbCoupon = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PreviewOrder = New System.Windows.Forms.PrintPreviewDialog()
        Me.grbdelivery.SuspendLayout()
        Me.grbToppings.SuspendLayout()
        Me.grbPizzaSize.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(33, 78)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(82, 13)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "Customer Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(25, 108)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(157, 20)
        Me.txtName.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(615, 518)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(74, 26)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Exit")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grbdelivery
        '
        Me.grbdelivery.Controls.Add(Me.lblhouseaddress)
        Me.grbdelivery.Controls.Add(Me.txtAddress)
        Me.grbdelivery.Controls.Add(Me.radDelivery)
        Me.grbdelivery.Controls.Add(Me.radpickup)
        Me.grbdelivery.Location = New System.Drawing.Point(416, 78)
        Me.grbdelivery.Name = "grbdelivery"
        Me.grbdelivery.Size = New System.Drawing.Size(144, 154)
        Me.grbdelivery.TabIndex = 3
        Me.grbdelivery.TabStop = False
        '
        'lblhouseaddress
        '
        Me.lblhouseaddress.AutoSize = True
        Me.lblhouseaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhouseaddress.Location = New System.Drawing.Point(15, 93)
        Me.lblhouseaddress.Name = "lblhouseaddress"
        Me.lblhouseaddress.Size = New System.Drawing.Size(100, 13)
        Me.lblhouseaddress.TabIndex = 3
        Me.lblhouseaddress.Text = "House Address :"
        Me.lblhouseaddress.Visible = False
        '
        'txtAddress
        '
        Me.txtAddress.Enabled = False
        Me.txtAddress.Location = New System.Drawing.Point(5, 109)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(130, 39)
        Me.txtAddress.TabIndex = 2
        '
        'radDelivery
        '
        Me.radDelivery.AutoSize = True
        Me.radDelivery.Location = New System.Drawing.Point(15, 56)
        Me.radDelivery.Name = "radDelivery"
        Me.radDelivery.Size = New System.Drawing.Size(63, 17)
        Me.radDelivery.TabIndex = 1
        Me.radDelivery.Text = "Delivery"
        Me.ToolTip1.SetToolTip(Me.radDelivery, "Delivery")
        Me.radDelivery.UseVisualStyleBackColor = True
        '
        'radpickup
        '
        Me.radpickup.AutoSize = True
        Me.radpickup.Checked = True
        Me.radpickup.Location = New System.Drawing.Point(15, 33)
        Me.radpickup.Name = "radpickup"
        Me.radpickup.Size = New System.Drawing.Size(63, 17)
        Me.radpickup.TabIndex = 0
        Me.radpickup.TabStop = True
        Me.radpickup.Text = "Pick Up"
        Me.ToolTip1.SetToolTip(Me.radpickup, "Pick Up ")
        Me.radpickup.UseVisualStyleBackColor = True
        '
        'lblDelivery
        '
        Me.lblDelivery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDelivery.Location = New System.Drawing.Point(367, 462)
        Me.lblDelivery.Name = "lblDelivery"
        Me.lblDelivery.Size = New System.Drawing.Size(70, 20)
        Me.lblDelivery.TabIndex = 4
        '
        'grbToppings
        '
        Me.grbToppings.Controls.Add(Me.cbPeppers)
        Me.grbToppings.Controls.Add(Me.cbBacon)
        Me.grbToppings.Controls.Add(Me.lblToppingCost)
        Me.grbToppings.Controls.Add(Me.cbMushrooms)
        Me.grbToppings.Controls.Add(Me.cbSausage)
        Me.grbToppings.Controls.Add(Me.cbPepperoni)
        Me.grbToppings.Controls.Add(Me.cbCheese)
        Me.grbToppings.Location = New System.Drawing.Point(416, 238)
        Me.grbToppings.Name = "grbToppings"
        Me.grbToppings.Size = New System.Drawing.Size(184, 193)
        Me.grbToppings.TabIndex = 5
        Me.grbToppings.TabStop = False
        Me.grbToppings.Text = "Toppings                      Cost"
        '
        'cbPeppers
        '
        Me.cbPeppers.AutoSize = True
        Me.cbPeppers.Location = New System.Drawing.Point(11, 147)
        Me.cbPeppers.Name = "cbPeppers"
        Me.cbPeppers.Size = New System.Drawing.Size(65, 17)
        Me.cbPeppers.TabIndex = 6
        Me.cbPeppers.Text = "Peppers"
        Me.cbPeppers.UseVisualStyleBackColor = True
        '
        'cbBacon
        '
        Me.cbBacon.AutoSize = True
        Me.cbBacon.Location = New System.Drawing.Point(11, 124)
        Me.cbBacon.Name = "cbBacon"
        Me.cbBacon.Size = New System.Drawing.Size(57, 17)
        Me.cbBacon.TabIndex = 5
        Me.cbBacon.Text = "Bacon"
        Me.cbBacon.UseVisualStyleBackColor = True
        '
        'lblToppingCost
        '
        Me.lblToppingCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblToppingCost.Location = New System.Drawing.Point(112, 43)
        Me.lblToppingCost.Name = "lblToppingCost"
        Me.lblToppingCost.Size = New System.Drawing.Size(56, 17)
        Me.lblToppingCost.TabIndex = 4
        '
        'cbMushrooms
        '
        Me.cbMushrooms.AutoSize = True
        Me.cbMushrooms.Location = New System.Drawing.Point(11, 101)
        Me.cbMushrooms.Name = "cbMushrooms"
        Me.cbMushrooms.Size = New System.Drawing.Size(80, 17)
        Me.cbMushrooms.TabIndex = 3
        Me.cbMushrooms.Text = "Mushrooms"
        Me.ToolTip1.SetToolTip(Me.cbMushrooms, "Mushrooms")
        Me.cbMushrooms.UseVisualStyleBackColor = True
        '
        'cbSausage
        '
        Me.cbSausage.AutoSize = True
        Me.cbSausage.Location = New System.Drawing.Point(11, 78)
        Me.cbSausage.Name = "cbSausage"
        Me.cbSausage.Size = New System.Drawing.Size(68, 17)
        Me.cbSausage.TabIndex = 2
        Me.cbSausage.Text = "Sausage"
        Me.ToolTip1.SetToolTip(Me.cbSausage, "Sausage")
        Me.cbSausage.UseVisualStyleBackColor = True
        '
        'cbPepperoni
        '
        Me.cbPepperoni.AutoSize = True
        Me.cbPepperoni.Location = New System.Drawing.Point(11, 55)
        Me.cbPepperoni.Name = "cbPepperoni"
        Me.cbPepperoni.Size = New System.Drawing.Size(74, 17)
        Me.cbPepperoni.TabIndex = 1
        Me.cbPepperoni.Text = "Pepperoni"
        Me.ToolTip1.SetToolTip(Me.cbPepperoni, "Pepperoni")
        Me.cbPepperoni.UseVisualStyleBackColor = True
        '
        'cbCheese
        '
        Me.cbCheese.AutoSize = True
        Me.cbCheese.Checked = True
        Me.cbCheese.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCheese.Location = New System.Drawing.Point(11, 19)
        Me.cbCheese.Name = "cbCheese"
        Me.cbCheese.Size = New System.Drawing.Size(62, 17)
        Me.cbCheese.TabIndex = 0
        Me.cbCheese.Text = "Cheese"
        Me.ToolTip1.SetToolTip(Me.cbCheese, "Chese")
        Me.cbCheese.UseVisualStyleBackColor = True
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(364, 434)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(45, 13)
        Me.lbl2.TabIndex = 6
        Me.lbl2.Text = "Delivery"
        '
        'grbPizzaSize
        '
        Me.grbPizzaSize.Controls.Add(Me.radLarge)
        Me.grbPizzaSize.Controls.Add(Me.radMedium)
        Me.grbPizzaSize.Controls.Add(Me.radSmall)
        Me.grbPizzaSize.Location = New System.Drawing.Point(147, 238)
        Me.grbPizzaSize.Name = "grbPizzaSize"
        Me.grbPizzaSize.Size = New System.Drawing.Size(175, 137)
        Me.grbPizzaSize.TabIndex = 7
        Me.grbPizzaSize.TabStop = False
        Me.grbPizzaSize.Text = "Pizza Size"
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.Location = New System.Drawing.Point(15, 101)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(112, 17)
        Me.radLarge.TabIndex = 2
        Me.radLarge.Text = "Large         $15.00"
        Me.ToolTip1.SetToolTip(Me.radLarge, "Large pizza")
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.Location = New System.Drawing.Point(15, 68)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(113, 17)
        Me.radMedium.TabIndex = 1
        Me.radMedium.Text = "Medium      $10.00"
        Me.ToolTip1.SetToolTip(Me.radMedium, "Medium pizza")
        Me.radMedium.UseVisualStyleBackColor = True
        '
        'radSmall
        '
        Me.radSmall.AutoSize = True
        Me.radSmall.Checked = True
        Me.radSmall.Location = New System.Drawing.Point(15, 32)
        Me.radSmall.Name = "radSmall"
        Me.radSmall.Size = New System.Drawing.Size(107, 17)
        Me.radSmall.TabIndex = 0
        Me.radSmall.TabStop = True
        Me.radSmall.Text = "Small          $6.00"
        Me.ToolTip1.SetToolTip(Me.radSmall, "small pizza")
        Me.radSmall.UseVisualStyleBackColor = True
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTax.Location = New System.Drawing.Point(252, 462)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(70, 20)
        Me.lblTax.TabIndex = 8
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(249, 434)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(25, 13)
        Me.lbl3.TabIndex = 9
        Me.lbl3.Text = "Tax"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubtotal.Location = New System.Drawing.Point(124, 462)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(70, 20)
        Me.lblSubtotal.TabIndex = 10
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(121, 434)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(46, 13)
        Me.lbl4.TabIndex = 11
        Me.lbl4.Text = "Subtotal"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(481, 462)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(70, 22)
        Me.lblTotal.TabIndex = 12
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Location = New System.Drawing.Point(478, 434)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(31, 13)
        Me.lbl5.TabIndex = 13
        Me.lbl5.Text = "Total"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(510, 518)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(74, 26)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "&New Order"
        Me.ToolTip1.SetToolTip(Me.btnClear, "New order")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(288, 499)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(121, 26)
        Me.btnCalculate.TabIndex = 15
        Me.btnCalculate.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.btnCalculate, "Calculate")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(12, 520)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(119, 27)
        Me.btnPrint.TabIndex = 16
        Me.btnPrint.Text = "Order / Print Reciept"
        Me.ToolTip1.SetToolTip(Me.btnPrint, "Print order")
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'btnPop
        '
        Me.btnPop.Location = New System.Drawing.Point(25, 178)
        Me.btnPop.Name = "btnPop"
        Me.btnPop.Size = New System.Drawing.Size(90, 25)
        Me.btnPop.TabIndex = 17
        Me.btnPop.Text = "POP"
        Me.btnPop.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Add pop to your order"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(712, 24)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CouponToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.PrintRecieptToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CouponToolStripMenuItem
        '
        Me.CouponToolStripMenuItem.Name = "CouponToolStripMenuItem"
        Me.CouponToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CouponToolStripMenuItem.Text = "Coupon"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Preview"
        '
        'PrintRecieptToolStripMenuItem
        '
        Me.PrintRecieptToolStripMenuItem.Name = "PrintRecieptToolStripMenuItem"
        Me.PrintRecieptToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PrintRecieptToolStripMenuItem.Text = "Order/Print"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbCalculate, Me.tsbPrintPreview, Me.tsbPop, Me.tsbCoupon})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(712, 25)
        Me.ToolStrip1.TabIndex = 20
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbCalculate
        '
        Me.tsbCalculate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCalculate.Image = CType(resources.GetObject("tsbCalculate.Image"), System.Drawing.Image)
        Me.tsbCalculate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCalculate.Name = "tsbCalculate"
        Me.tsbCalculate.Size = New System.Drawing.Size(23, 22)
        Me.tsbCalculate.Text = "Calculate"
        '
        'tsbPrintPreview
        '
        Me.tsbPrintPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbPrintPreview.Image = CType(resources.GetObject("tsbPrintPreview.Image"), System.Drawing.Image)
        Me.tsbPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPrintPreview.Name = "tsbPrintPreview"
        Me.tsbPrintPreview.Size = New System.Drawing.Size(23, 22)
        Me.tsbPrintPreview.Text = "PrintPreview"
        '
        'tsbPop
        '
        Me.tsbPop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbPop.Image = Global.Pizza_order.My.Resources.Resources.can__1_
        Me.tsbPop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPop.Name = "tsbPop"
        Me.tsbPop.Size = New System.Drawing.Size(23, 22)
        Me.tsbPop.Text = "Pop"
        '
        'tsbCoupon
        '
        Me.tsbCoupon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCoupon.Image = CType(resources.GetObject("tsbCoupon.Image"), System.Drawing.Image)
        Me.tsbCoupon.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCoupon.Name = "tsbCoupon"
        Me.tsbCoupon.Size = New System.Drawing.Size(23, 22)
        Me.tsbCoupon.Text = "Coupon"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssName, Me.tssDate, Me.tssTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 555)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(712, 22)
        Me.StatusStrip1.TabIndex = 21
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssName
        '
        Me.tssName.Name = "tssName"
        Me.tssName.Size = New System.Drawing.Size(76, 17)
        Me.tssName.Text = "Trevor J Buck"
        '
        'tssDate
        '
        Me.tssDate.Name = "tssDate"
        Me.tssDate.Size = New System.Drawing.Size(31, 17)
        Me.tssDate.Text = "Date"
        '
        'tssTime
        '
        Me.tssTime.Name = "tssTime"
        Me.tssTime.Size = New System.Drawing.Size(34, 17)
        Me.tssTime.Text = "Time"
        '
        'Timer1
        '
        '
        'PreviewOrder
        '
        Me.PreviewOrder.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PreviewOrder.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PreviewOrder.ClientSize = New System.Drawing.Size(400, 300)
        Me.PreviewOrder.Enabled = True
        Me.PreviewOrder.Icon = CType(resources.GetObject("PreviewOrder.Icon"), System.Drawing.Icon)
        Me.PreviewOrder.Name = "PreviewOrder"
        Me.PreviewOrder.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 577)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPop)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.grbPizzaSize)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.grbToppings)
        Me.Controls.Add(Me.lblDelivery)
        Me.Controls.Add(Me.grbdelivery)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.grbdelivery.ResumeLayout(False)
        Me.grbdelivery.PerformLayout()
        Me.grbToppings.ResumeLayout(False)
        Me.grbToppings.PerformLayout()
        Me.grbPizzaSize.ResumeLayout(False)
        Me.grbPizzaSize.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents grbdelivery As GroupBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents radDelivery As RadioButton
    Friend WithEvents radpickup As RadioButton
    Friend WithEvents lblDelivery As Label
    Friend WithEvents grbToppings As GroupBox
    Friend WithEvents cbMushrooms As CheckBox
    Friend WithEvents cbSausage As CheckBox
    Friend WithEvents cbPepperoni As CheckBox
    Friend WithEvents cbCheese As CheckBox
    Friend WithEvents lblToppingCost As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents grbPizzaSize As GroupBox
    Friend WithEvents radLarge As RadioButton
    Friend WithEvents radMedium As RadioButton
    Friend WithEvents radSmall As RadioButton
    Friend WithEvents lblTax As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents lblhouseaddress As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents cbBacon As CheckBox
    Friend WithEvents cbPeppers As CheckBox
    Friend WithEvents btnPop As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CouponToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintRecieptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbPrintPreview As ToolStripButton
    Friend WithEvents tsbPop As ToolStripButton
    Friend WithEvents tsbCoupon As ToolStripButton
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tssName As ToolStripStatusLabel
    Friend WithEvents tssDate As ToolStripStatusLabel
    Friend WithEvents tssTime As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents tsbCalculate As ToolStripButton
    Friend WithEvents PreviewOrder As PrintPreviewDialog
End Class
