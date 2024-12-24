Public Class Form1
    Dim products() As String = {"Baju", "Jaket", "Sepatu", "Topi", "Celana"}
    Dim prices() As Decimal = {150000, 15000, 25000, 80000, 50000}
    Dim total As Decimal = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Menambahkan produk ke ListBox saat form dimuat
        For i As Integer = 0 To products.Length - 1
            lstProducts.Items.Add(products(i) & " - " & prices(i).ToString("C"))
        Next
    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        ' Menambahkan produk yang dipilih ke total
        If lstProducts.SelectedIndex <> -1 Then
            Dim selectedProduct As String = lstProducts.SelectedItem.ToString()
            Dim price As Decimal = prices(lstProducts.SelectedIndex)
            total += price
            txtTotal.Text = total.ToString("C")
            MessageBox.Show(selectedProduct & " telah ditambahkan ke keranjang.")
        Else
            MessageBox.Show("Silakan pilih produk terlebih dahulu.")
        End If
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        MessageBox.Show("Total belanja Anda adalah: " & txtTotal.Text)
        ' Reset total setelah checkout
        total = 0
        txtTotal.Text = ""
    End Sub
End Class