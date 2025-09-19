Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text.Trim() = "" Then
            MessageBox.Show("Customer's name.")
            Exit Sub
        End If

        If ComboBox1.SelectedIndex = -1 Then
            MessageBox.Show(" Beverage.")
            Exit Sub
        End If
        If Not IsNumeric(txt.Text) OrElse CInt(txt.Text) <= 0 Then
            MessageBox.Show(" Quantity.")
            Exit Sub
        End If


        Dim price As Decimal = 0
        Select Case ComboBox1.SelectedItem.ToString()
            Case "Espresso" : price = 120
            Case "Latte" : price = 150
            Case "Cappuccino" : price = 160
            Case "Americano" : price = 130
            Case "Mocha" : price = 170
        End Select

        Dim qty As Integer = CInt(txt.Text)
        Dim subtotal As Decimal = price * qty
        Dim discount As Decimal = 0
        If CheckBox1.Checked Then
            discount = subtotal * 0.1D
        End If
        Dim finalTotal As Decimal = subtotal - discount


        Label7.Text = "Subtotal: " & subtotal.ToString("C") & vbCrLf &
                      "Discount: " & discount.ToString("C") & vbCrLf &
                      "Final Total: " & finalTotal.ToString("C")


        MessageBox.Show("Order " & TextBox1.Text & " has been placed." & vbCrLf &
                        "Final Total:" & finalTotal.ToString("C"))
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
