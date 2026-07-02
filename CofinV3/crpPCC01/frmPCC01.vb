Public Class frmPCC01

    Public Property FormularioCompleto As Boolean = False

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Me.Hide()
        Dim PCC012fmr As New frmPCC012(Me)
        PCC012fmr.ShowDialog()

        If Not FormularioCompleto Then
            Me.Show()
        End If
    End Sub

    Public Sub MarcarCompleto()
        FormularioCompleto = True
    End Sub

    Private Sub chbxOperacion1_CheckedChanged(sender As Object, e As EventArgs) Handles chbxOperacion1.CheckedChanged
        If chbxOperacion1.Checked Then
            chbxOperacion2.Checked = False
        End If
    End Sub

    Private Sub chbxOperacion2_CheckedChanged(sender As Object, e As EventArgs) Handles chbxOperacion2.CheckedChanged
        If chbxOperacion2.Checked Then
            chbxOperacion1.Checked = False
        End If
    End Sub

    Private Sub chbxDocID1_CheckedChanged(sender As Object, e As EventArgs) Handles chbxDocID1.CheckedChanged
        If chbxDocID1.Checked Then
            chbxDocID2.Checked = False
            chbxDocID3.Checked = False
        End If
    End Sub

    Private Sub chbxDocID2_CheckedChanged(sender As Object, e As EventArgs) Handles chbxDocID2.CheckedChanged
        If chbxDocID2.Checked Then
            chbxDocID1.Checked = False
            chbxDocID3.Checked = False
        End If
    End Sub

    Private Sub chbxDocID3_CheckedChanged(sender As Object, e As EventArgs) Handles chbxDocID3.CheckedChanged
        If chbxDocID3.Checked Then
            chbxDocID1.Checked = False
            chbxDocID2.Checked = False
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class