<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPop
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbBrand = New System.Windows.Forms.GroupBox()
        Me.radCoke = New System.Windows.Forms.RadioButton()
        Me.radPepsi = New System.Windows.Forms.RadioButton()
        Me.radGeneric = New System.Windows.Forms.RadioButton()
        Me.gbPopSize = New System.Windows.Forms.GroupBox()
        Me.rad3Liter = New System.Windows.Forms.RadioButton()
        Me.rad2Liter = New System.Windows.Forms.RadioButton()
        Me.rad1Liter = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPopCost = New System.Windows.Forms.Label()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.gbBrand.SuspendLayout()
        Me.gbPopSize.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbBrand
        '
        Me.gbBrand.Controls.Add(Me.radCoke)
        Me.gbBrand.Controls.Add(Me.radPepsi)
        Me.gbBrand.Controls.Add(Me.radGeneric)
        Me.gbBrand.Location = New System.Drawing.Point(65, 81)
        Me.gbBrand.Name = "gbBrand"
        Me.gbBrand.Size = New System.Drawing.Size(188, 253)
        Me.gbBrand.TabIndex = 0
        Me.gbBrand.TabStop = False
        Me.gbBrand.Text = "Pop Brand"
        '
        'radCoke
        '
        Me.radCoke.AutoSize = True
        Me.radCoke.Location = New System.Drawing.Point(26, 180)
        Me.radCoke.Name = "radCoke"
        Me.radCoke.Size = New System.Drawing.Size(50, 17)
        Me.radCoke.TabIndex = 2
        Me.radCoke.Text = "Coke"
        Me.radCoke.UseVisualStyleBackColor = True
        '
        'radPepsi
        '
        Me.radPepsi.AutoSize = True
        Me.radPepsi.Location = New System.Drawing.Point(26, 113)
        Me.radPepsi.Name = "radPepsi"
        Me.radPepsi.Size = New System.Drawing.Size(51, 17)
        Me.radPepsi.TabIndex = 1
        Me.radPepsi.Text = "Pepsi"
        Me.radPepsi.UseVisualStyleBackColor = True
        '
        'radGeneric
        '
        Me.radGeneric.AutoSize = True
        Me.radGeneric.Location = New System.Drawing.Point(26, 53)
        Me.radGeneric.Name = "radGeneric"
        Me.radGeneric.Size = New System.Drawing.Size(62, 17)
        Me.radGeneric.TabIndex = 0
        Me.radGeneric.Text = "Generic"
        Me.radGeneric.UseVisualStyleBackColor = True
        '
        'gbPopSize
        '
        Me.gbPopSize.Controls.Add(Me.rad3Liter)
        Me.gbPopSize.Controls.Add(Me.rad2Liter)
        Me.gbPopSize.Controls.Add(Me.rad1Liter)
        Me.gbPopSize.Location = New System.Drawing.Point(336, 81)
        Me.gbPopSize.Name = "gbPopSize"
        Me.gbPopSize.Size = New System.Drawing.Size(188, 253)
        Me.gbPopSize.TabIndex = 1
        Me.gbPopSize.TabStop = False
        Me.gbPopSize.Text = "Size"
        '
        'rad3Liter
        '
        Me.rad3Liter.AutoSize = True
        Me.rad3Liter.Location = New System.Drawing.Point(31, 180)
        Me.rad3Liter.Name = "rad3Liter"
        Me.rad3Liter.Size = New System.Drawing.Size(54, 17)
        Me.rad3Liter.TabIndex = 2
        Me.rad3Liter.Text = "3 Liter"
        Me.rad3Liter.UseVisualStyleBackColor = True
        '
        'rad2Liter
        '
        Me.rad2Liter.AutoSize = True
        Me.rad2Liter.Location = New System.Drawing.Point(31, 113)
        Me.rad2Liter.Name = "rad2Liter"
        Me.rad2Liter.Size = New System.Drawing.Size(54, 17)
        Me.rad2Liter.TabIndex = 1
        Me.rad2Liter.Text = "2 Liter"
        Me.rad2Liter.UseVisualStyleBackColor = True
        '
        'rad1Liter
        '
        Me.rad1Liter.AutoSize = True
        Me.rad1Liter.Location = New System.Drawing.Point(31, 53)
        Me.rad1Liter.Name = "rad1Liter"
        Me.rad1Liter.Size = New System.Drawing.Size(54, 17)
        Me.rad1Liter.TabIndex = 0
        Me.rad1Liter.Text = "1 Liter"
        Me.rad1Liter.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 361)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pop Price"
        '
        'lblPopCost
        '
        Me.lblPopCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPopCost.Location = New System.Drawing.Point(75, 386)
        Me.lblPopCost.Name = "lblPopCost"
        Me.lblPopCost.Size = New System.Drawing.Size(77, 23)
        Me.lblPopCost.TabIndex = 3
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(407, 377)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(99, 33)
        Me.btnDone.TabIndex = 4
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'FrmPop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 442)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.lblPopCost)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbPopSize)
        Me.Controls.Add(Me.gbBrand)
        Me.Name = "FrmPop"
        Me.Text = "FormPop"
        Me.gbBrand.ResumeLayout(False)
        Me.gbBrand.PerformLayout()
        Me.gbPopSize.ResumeLayout(False)
        Me.gbPopSize.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbBrand As GroupBox
    Friend WithEvents gbPopSize As GroupBox
    Friend WithEvents radCoke As RadioButton
    Friend WithEvents radPepsi As RadioButton
    Friend WithEvents radGeneric As RadioButton
    Friend WithEvents rad3Liter As RadioButton
    Friend WithEvents rad2Liter As RadioButton
    Friend WithEvents rad1Liter As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPopCost As Label
    Friend WithEvents btnDone As Button
End Class
