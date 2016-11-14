Public Class Principal

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RibbonBar1_ItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonBar1.ItemClick

    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        Recibo.Show()
        Me.Hide()


    End Sub

    Private Sub btnfactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfactura.Click
        factura.Show()
        Me.Hide()


    End Sub

    Private Sub ButtonItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem15.Click
        CXP.Show()

    End Sub
End Class