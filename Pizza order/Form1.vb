Option Strict On
Imports System.IO
Public Class Form1
    'Trevor J Buck
    'CIS 125-01
    'Fall 2018
    'Professor Hinz
    Dim basetoppingcost As Double
    Dim deliverycost As Double
    Dim basepizzacost As Double
    Public PopCost As Double
    Public PrintTopString As String
    Dim coupon As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'code for the status strip
        tssDate.Text = Now.ToShortDateString
        tssTime.Text = Now.ToShortTimeString
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'ends program
        End
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        'where costomer enters their name

    End Sub

    Private Sub radDelivery_CheckedChanged(sender As Object, e As EventArgs) Handles radDelivery.CheckedChanged
        'adds on cost for delivery
        If radDelivery.Checked = True Then
            txtAddress.Enabled = True
            lblhouseaddress.Visible = True
        ElseIf radDelivery.Checked = False Then
            txtAddress.Enabled = False
            lblhouseaddress.Visible = False
        End If
        deliverycost = 2
    End Sub

    Private Sub lblDelivery_Click(sender As Object, e As EventArgs) Handles lblDelivery.Click
        'shows delivery price
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles cbPepperoni.CheckedChanged
        'adds pepperoni to the pizza 
    End Sub

    Private Sub radSmall_CheckedChanged(sender As Object, e As EventArgs) Handles radSmall.CheckedChanged
        'option for small pizza
        lblToppingCost.Text = "$1.00"
        basepizzacost = 6
        basetoppingcost = 1

    End Sub

    Private Sub radMedium_CheckedChanged(sender As Object, e As EventArgs) Handles radMedium.CheckedChanged
        'option for medium pizza
        lblToppingCost.Text = "$1.50"
        basepizzacost = 10
        basetoppingcost = 1.5
    End Sub

    Private Sub radLarge_CheckedChanged(sender As Object, e As EventArgs) Handles radLarge.CheckedChanged
        'option for Large pizza
        lblToppingCost.Text = "$2.00"
        basepizzacost = 15
        basetoppingcost = 2
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'calculates the subtotal, tax, and total depending on what the user enters
        If txtName.Text = "" Then
            MsgBox(" ERROR :      PLEASE ENTER THE CUSTOMER'S NAME")
            txtName.Focus()
        Else
            If radDelivery.Checked = True Then
                lblDelivery.Text = "$2.00"
            ElseIf radDelivery.Checked = False Then
                lblDelivery.Text = ""
            End If
            Dim subtotal As Double
            Dim toppingcount As Double
            Dim tax As Double
            Dim deliverycost As Double
            Dim total As Double


            If cbPepperoni.Checked = True Then
                toppingcount += 1
            End If
            If cbSausage.Checked = True Then
                toppingcount += 1
            End If
            If cbMushrooms.Checked = True Then
                toppingcount += 1
            End If
            If cbBacon.Checked = True Then
                toppingcount += 1
            End If
            If cbPeppers.Checked = True Then
                toppingcount += 1
            End If

            If radDelivery.Checked = True Then
                deliverycost = 2
            End If

            subtotal = basepizzacost + (basetoppingcost * toppingcount) + PopCost
            lblSubtotal.Text = subtotal.ToString("c")
            tax = (subtotal * 0.0825)
            lblTax.Text = tax.ToString("c")
            total = (subtotal + tax + deliverycost) - coupon
            lblTotal.Text = total.ToString("c")
        End If
    End Sub

    Private Sub lblSubtotal_Click(sender As Object, e As EventArgs) Handles lblSubtotal.Click
        'displays subtotal
    End Sub

    Private Sub cbSausage_CheckedChanged(sender As Object, e As EventArgs) Handles cbSausage.CheckedChanged
        'adds sausage to the pizza
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'resets all options to default
        txtName.Text = ""
        txtAddress.Text = ""
        radpickup.Checked = True
        cbCheese.Checked = True
        radSmall.Checked = True
        cbPepperoni.Checked = False
        cbSausage.Checked = False
        cbMushrooms.Checked = False
        cbBacon.Checked = False
        cbPeppers.Checked = False
        txtName.Focus()
        coupon = 0
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'Prints out name and Address/ saves the customers order
        PrintDocument1.Print()
        Dim name As String
        Dim address As String
        Dim popprice As String
        Dim couponamount As String
        Dim subsubtotal As String
        Dim tax As String
        Dim delivery As String
        Dim total As String
        Dim Pizza As New StreamWriter("Pizzaorder.hdf", True)
        name = txtName.Text
        address = txtAddress.Text
        popprice = PopCost.ToString("c")
        couponamount = coupon.ToString("c")
        subsubtotal = lblSubtotal.Text
        tax = lblTax.Text
        delivery = lblDelivery.Text
        total = lblTotal.Text


        Pizza.WriteLine("Name: " & name)
        Pizza.WriteLine("Address: " & address)
        If radSmall.Checked = True Then
            Pizza.WriteLine("Pizza Size: Small")
        End If
        If radMedium.Checked = True Then
            Pizza.WriteLine("Pizza Size: Medium")
        End If
        If radLarge.Checked = True Then
            Pizza.WriteLine("Pizza Size: Large")
        End If
        Pizza.WriteLine("Pop Cost: " & popprice)
        If FrmPop.radGeneric.Checked = True Then
            Pizza.WriteLine("Pop Brand: Generic")
        End If
        Pizza.WriteLine("Toppings: " & PrintTopString)
        If FrmPop.radPepsi.Checked = True Then
            Pizza.WriteLine("Pop Brand: Pepsi")
        End If
        If FrmPop.radCoke.Checked = True Then
            Pizza.WriteLine("Pop Brand: Coke")
        End If
        If FrmPop.rad1Liter.Checked = True Then
            Pizza.WriteLine("Pop Size: 1 Liter")
        End If
        If FrmPop.rad2Liter.Checked = True Then
            Pizza.WriteLine("Pop Size: 2 Liter")
        End If
        If FrmPop.rad3Liter.Checked = True Then
            Pizza.WriteLine("Pop Size: 3 Liter")
        End If
        Pizza.WriteLine("Coupon: " & couponamount)
        Pizza.WriteLine("Subtotal: " & subsubtotal)
        Pizza.WriteLine("Tax: " & tax)
        Pizza.WriteLine("Delivery fee: " & delivery)
        Pizza.WriteLine("Total: " & total)
        Pizza.WriteLine("                            ")
        Pizza.WriteLine("                            ")
        Pizza.Close()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'code to make hardcopy
        Dim x As Single
        Dim y As Single
        PrintTopString = ""

        x = e.MarginBounds.Left
        y = e.MarginBounds.Top

        If cbBacon.Checked = True Then

            PrintTopString += "  Bacon,"
        End If
        If cbCheese.Checked = True Then
            PrintTopString += "  Cheese,"
        End If
        If cbMushrooms.Checked = True Then
            PrintTopString += "  Mushrooms,"
        End If
        If cbPeppers.Checked = True Then
            PrintTopString += "  Peppers,"
        End If
        If cbPepperoni.Checked = True Then
            PrintTopString += "  Pepperoni,"
        End If
        If cbSausage.Checked = True Then
            PrintTopString += "  Sausage,"
        End If
        e.Graphics.DrawString("Customer Name: " & txtName.Text, New Font("Arial", 18), Brushes.Black, x, y)
        y = y + 35
        If radDelivery.Checked = True Then
            e.Graphics.DrawString("Address: " & txtAddress.Text, New Font("Arial", 18), Brushes.Black, x, y)
            y = y + 35
        End If

        If radSmall.Checked = True Then
            e.Graphics.DrawString("Pizza Size: Small", New Font("Arial", 18), Brushes.Black, x, y)
        ElseIf radMedium.Checked = True Then
            e.Graphics.DrawString("Pizza Size: Medium", New Font("Arial", 18), Brushes.Black, x, y)
        ElseIf radLarge.Checked = True Then
            e.Graphics.DrawString("Pizza Size: Large", New Font("Arial", 18), Brushes.Black, x, y)
        End If
        y = y + 35

        If PrintTopString <> "" Then
            e.Graphics.DrawString("Toppings: " & PrintTopString, New Font("Arial", 18), Brushes.Black, x, y)
            y = y + 35
        End If

        e.Graphics.DrawString("Pop Cost: " & PopCost.ToString("c"), New Font("Arial", 18), Brushes.Black, x, y)
        y = y + 35
        If FrmPop.radGeneric.Checked = True Then
            e.Graphics.DrawString("Pop Brand: Generic", New Font("Arial", 18), Brushes.Black, x, y)
            y = y + 35
        End If
        If FrmPop.radCoke.Checked = True Then
            e.Graphics.DrawString("Pop Brand: Coke", New Font("Arial", 18), Brushes.Black, x, y)
            y = y + 35
        End If
      
        If FrmPop.radPepsi.Checked = True Then
            e.Graphics.DrawString("Pop brand: Pepsi", New Font("Arial", 18), Brushes.Black, x, y)
            y = y + 35
        End If
        If FrmPop.rad1Liter.Checked = True Then
            e.Graphics.DrawString("Pop Size: 1 Liter", New Font("Arial", 18), Brushes.Black, x, y)
            y = y + 35
        End If
        If FrmPop.rad2Liter.Checked = True Then
            e.Graphics.DrawString("Pop Size: 2 Liter", New Font("Arial", 18), Brushes.Black, x, y)
            y = y + 35
        End If
        If FrmPop.rad3Liter.Checked = True Then
            e.Graphics.DrawString("Pop Size: 3 Liter", New Font("Arial", 18), Brushes.Black, x, y)
            y = y + 35
        End If
        e.Graphics.DrawString("Coupon: " & coupon.ToString("c"), New Font("Arial", 18), Brushes.Black, x, y)
        y = y + 35
        e.Graphics.DrawString("Subtotal: " & lblSubtotal.Text, New Font("Arial", 18), Brushes.Black, x, y)
        y = y + 35
        e.Graphics.DrawString("Delivery: " & lblDelivery.Text, New Font("Arial", 18), Brushes.Black, x, y)
        y = y + 35
        e.Graphics.DrawString("Tax: " & lblTax.Text, New Font("Arial", 18), Brushes.Black, x, y)
        y = y + 35
        e.Graphics.DrawString("Bill Total : " & lblTotal.Text, New Font("Arial", 18), Brushes.Black, x, y)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnPop.Click
        'Displays the Pop form 
        FrmPop.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'timer for the status strip
        tssTime.Text = Now.ToShortTimeString
    End Sub

    Private Sub tsbCalculate_Click(sender As Object, e As EventArgs) Handles tsbCalculate.Click
        'calculates order
        btnCalculate_Click(sender, e)
    End Sub

    Private Sub tsbPrintPreview_Click(sender As Object, e As EventArgs) Handles tsbPrintPreview.Click
        'previews order
        PreviewOrder.Document = PrintDocument1
        PreviewOrder.ShowDialog()
    End Sub

    Private Sub tsbPop_Click(sender As Object, e As EventArgs) Handles tsbPop.Click
        'opens pop form 
        Button1_Click_1(sender, e)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Ends program
        Button1_Click(sender, e)
    End Sub

    Private Sub PrintRecieptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintRecieptToolStripMenuItem.Click
        'prints order
        btnPrint_Click(sender, e)
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        'previews order
        tsbPrintPreview_Click(sender, e)
    End Sub

    Private Sub tsbCoupon_Click(sender As Object, e As EventArgs) Handles tsbCoupon.Click
        'opens coupon input box
        coupon = CDbl(InputBox("Enter Coupon Amount:"))


    End Sub

    Private Sub CouponToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CouponToolStripMenuItem.Click
        'same as coupon button
        tsbCoupon_Click(sender, e)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'Displays the about form
        AboutBox1.Show()
    End Sub
End Class
