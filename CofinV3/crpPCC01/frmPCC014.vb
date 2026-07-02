Public Class frmPCC014
    Private anteriorForm As frmPCC01

    Public Sub New(anterior As frmPCC01)
        InitializeComponent()
        anteriorForm = anterior
    End Sub

    Private Sub chbxMonedaOrigen1_CheckedChanged(sender As Object, e As EventArgs) Handles chbxMonedaOrigen1.CheckedChanged
        If chbxMonedaOrigen1.Checked Then
            chbxMonedaOrigen2.Checked = False
            txtMonedaOrigen3.Enabled = False
        Else
            txtMonedaOrigen3.Enabled = True
        End If
    End Sub

    Private Sub chbxMonedaOrigen2_CheckedChanged(sender As Object, e As EventArgs) Handles chbxMonedaOrigen2.CheckedChanged
        If chbxMonedaOrigen2.Checked Then
            chbxMonedaOrigen1.Checked = False
            txtMonedaOrigen3.Enabled = False
        Else
            txtMonedaOrigen3.Enabled = True
        End If
    End Sub

    Private Sub chbxMonedaDestino1_CheckedChanged(sender As Object, e As EventArgs) Handles chbxMonedaDestino1.CheckedChanged
        If chbxMonedaDestino1.Checked Then
            chbxMonedaDestino2.Checked = False
            txtMonedaDestino3.Enabled = False
        Else
            txtMonedaDestino3.Enabled = True
        End If
    End Sub

    Private Sub chbxMonedaDestino2_CheckedChanged(sender As Object, e As EventArgs) Handles chbxMonedaDestino2.CheckedChanged
        If chbxMonedaDestino2.Checked Then
            chbxMonedaDestino1.Checked = False
            txtMonedaDestino3.Enabled = False
        Else
            txtMonedaDestino3.Enabled = True
        End If
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        MessageBox.Show("Formulario Completo")

        anteriorForm.FormularioCompleto = True
        Me.Close()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        anteriorForm.Show()
        Me.Close()
    End Sub
End Class