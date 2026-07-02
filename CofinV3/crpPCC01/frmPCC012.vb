Public Class frmPCC012

    Private anteriorForm As frmPCC01

    Public Sub New(anterior As frmPCC01)
        InitializeComponent()
        anteriorForm = anterior
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Me.Hide()
        Dim PCC013Frm As New frmPCC013(anteriorForm)
        PCC013Frm.ShowDialog()

        If Not anteriorForm.FormularioCompleto Then
            Me.Show()
        End If
    End Sub

    Private Sub chbxPropiedad1_CheckedChanged(sender As Object, e As EventArgs) Handles chbxPropiedad1.CheckedChanged
        If chbxPropiedad1.Checked Then
            chbxPropiedad2.Checked = False
        End If
    End Sub

    Private Sub chbxPropiedad2_CheckedChanged(sender As Object, e As EventArgs) Handles chbxPropiedad2.CheckedChanged
        If chbxPropiedad2.Checked Then
            chbxPropiedad1.Checked = False
        End If
    End Sub

    Private Sub chbxPersona1_CheckedChanged(sender As Object, e As EventArgs) Handles chbxPersona1.CheckedChanged
        If chbxPersona1.Checked Then
            chbxPersona2.Checked = False
        End If
    End Sub

    Private Sub chbxPersona2_CheckedChanged(sender As Object, e As EventArgs) Handles chbxPersona2.CheckedChanged
        If chbxPersona2.Checked Then
            chbxPersona1.Checked = False
        End If
    End Sub

    Private Sub chbxOperacion1_CheckedChanged(sender As Object, e As EventArgs) Handles chbxOperacion1.CheckedChanged
        If chbxOperacion1.Checked Then
            chbxOperacion2.Checked = False
            chbxOperacion3.Checked = False
            chbxOperacion4.Checked = False
            chbxOperacion5.Checked = False
        End If
    End Sub

    Private Sub chbxOperacion2_CheckedChanged(sender As Object, e As EventArgs) Handles chbxOperacion2.CheckedChanged
        If chbxOperacion2.Checked Then
            chbxOperacion1.Checked = False
            chbxOperacion3.Checked = False
            chbxOperacion4.Checked = False
            chbxOperacion5.Checked = False
        End If
    End Sub

    Private Sub chbxOperacion3_CheckedChanged(sender As Object, e As EventArgs) Handles chbxOperacion3.CheckedChanged
        If chbxOperacion3.Checked Then
            chbxOperacion1.Checked = False
            chbxOperacion2.Checked = False
            chbxOperacion4.Checked = False
            chbxOperacion5.Checked = False
        End If
    End Sub

    Private Sub chbxOperacion4_CheckedChanged(sender As Object, e As EventArgs) Handles chbxOperacion4.CheckedChanged
        If chbxOperacion4.Checked Then
            chbxOperacion2.Checked = False
            chbxOperacion3.Checked = False
            chbxOperacion1.Checked = False
            chbxOperacion5.Checked = False
        End If
    End Sub

    Private Sub chbxOperacion5_CheckedChanged(sender As Object, e As EventArgs) Handles chbxOperacion5.CheckedChanged
        If chbxOperacion5.Checked Then
            chbxOperacion2.Checked = False
            chbxOperacion3.Checked = False
            chbxOperacion4.Checked = False
            chbxOperacion1.Checked = False
        End If
    End Sub

    Private Sub chbxMoneda1_CheckedChanged(sender As Object, e As EventArgs) Handles chbxMoneda1.CheckedChanged
        If chbxMoneda1.Checked Then
            chbxMoneda2.Checked = False
        End If
    End Sub

    Private Sub chbxMoneda2_CheckedChanged(sender As Object, e As EventArgs) Handles chbxMoneda2.CheckedChanged
        If chbxMoneda2.Checked Then
            chbxMoneda1.Checked = False
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        anteriorForm.Show()
        Me.Close()
    End Sub
End Class