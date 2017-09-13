' Name:         Bakery Project
' Purpose:      Calculate the total number of items sold and total sales
' Prgrammer:    Matt Mabbitt on 9/12/2017

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' prepare scren for the next sale
        txtDonuts.Text = String.Empty
        TxtMuffins.Text = String.Empty
        lblTotalItems.Text = String.Empty
        lblTotalSales.Text = String.Empty

        ' send the focus to the donuts box
        txtDonuts.Focus()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate number of items sold and total sales

        lblTotalItems.Text = Val(txtDonuts.Text) + Val(TxtMuffins.Text)
        lblTotalSales.Text = Val(lblTotalItems.Text) * 0.5
        lblTotalSales.Text = Format(lblTotalSales.Text, "currency")
    End Sub
End Class