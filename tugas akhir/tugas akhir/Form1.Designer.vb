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
        Label1 = New Label()
        lstProducts = New ListBox()
        btnAddToCart = New Button()
        btnCheckout = New Button()
        txtTotal = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.LightCyan
        Label1.Location = New Point(321, 321)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 25)
        Label1.TabIndex = 0
        Label1.Text = "Total Belanja"
        ' 
        ' lstProducts
        ' 
        lstProducts.BackColor = Color.DarkCyan
        lstProducts.ForeColor = Color.Bisque
        lstProducts.FormattingEnabled = True
        lstProducts.ItemHeight = 25
        lstProducts.Location = New Point(201, 12)
        lstProducts.Name = "lstProducts"
        lstProducts.Size = New Size(336, 129)
        lstProducts.TabIndex = 1
        ' 
        ' btnAddToCart
        ' 
        btnAddToCart.BackColor = SystemColors.ActiveCaption
        btnAddToCart.Location = New Point(3, 275)
        btnAddToCart.Name = "btnAddToCart"
        btnAddToCart.Size = New Size(257, 58)
        btnAddToCart.TabIndex = 2
        btnAddToCart.Text = "Tambah Ke Keranjang"
        btnAddToCart.UseVisualStyleBackColor = False
        ' 
        ' btnCheckout
        ' 
        btnCheckout.BackColor = SystemColors.ActiveCaption
        btnCheckout.Location = New Point(509, 275)
        btnCheckout.Name = "btnCheckout"
        btnCheckout.Size = New Size(264, 58)
        btnCheckout.TabIndex = 3
        btnCheckout.Text = "Seleseikan Pembelian"
        btnCheckout.UseVisualStyleBackColor = False
        ' 
        ' txtTotal
        ' 
        txtTotal.BackColor = Color.DarkRed
        txtTotal.Location = New Point(201, 359)
        txtTotal.Name = "txtTotal"
        txtTotal.ReadOnly = True
        txtTotal.Size = New Size(336, 31)
        txtTotal.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._14
        ClientSize = New Size(800, 450)
        Controls.Add(txtTotal)
        Controls.Add(btnCheckout)
        Controls.Add(btnAddToCart)
        Controls.Add(lstProducts)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Keranjang belanja"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstProducts As ListBox
    Friend WithEvents btnAddToCart As Button
    Friend WithEvents btnCheckout As Button
    Friend WithEvents txtTotal As TextBox

End Class
