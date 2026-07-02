Imports System.Diagnostics.Tracing

Public Class frmPCC013

    Private anteriorForm As frmPCC01

    Public Sub New(anterior As frmPCC01)
        InitializeComponent()
        anteriorForm = anterior
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Me.Hide()
        Dim PCC014Frm As New frmPCC014(anteriorForm)
        PCC014Frm.ShowDialog()

        If Not anteriorForm.FormularioCompleto Then
            Me.Show()
        End If
    End Sub

    Private Sub chbxOperacion_CheckedChanged(sender As Object, e As EventArgs) _
    Handles chbxOperacion1.CheckedChanged, chbxOperacion2.CheckedChanged, chbxOperacion3.CheckedChanged,
            chbxOperacion4.CheckedChanged, chbxOperacion5.CheckedChanged, chbxOperacion6.CheckedChanged,
            chbxOperacion7.CheckedChanged, chbxOperacion8.CheckedChanged, chbxOperacion9.CheckedChanged,
            chbxOperacion10.CheckedChanged, chbxOperacion11.CheckedChanged, chbxOperacion12.CheckedChanged

        Dim chbx As CheckBox = CType(sender, CheckBox)
        Dim numero As Integer = CInt(chbx.Name.Replace("chbxOperacion", ""))
        Dim numero2 As Integer

        ' --- Ajuste especial según el número ---
        If numero = 11 Then
            numero2 = 0
        ElseIf numero = 12 Then
            numero2 = 11
        Else
            numero2 = numero
        End If

        If chbx.Checked Then
            DesmarcarOperacionesOtros(numero)
            InhabilitarOpcionesOtros(numero, numero2)
        Else
            InhabilitarTodo()
        End If
    End Sub


    Private Sub DesmarcarOperacionesOtros(numero As Integer)
        For i As Integer = 1 To 12
            If i <> numero Then
                Dim chbx As CheckBox = CType(Me.Controls("chbxOperacion" & i), CheckBox)
                chbx.Checked = False
            End If
        Next
    End Sub

    Private Sub InhabilitarOpcionesOtros(numero1 As Integer, numero2 As Integer)
        For i As Integer = 1 To 12
            Dim chbx As CheckBox = CType(Me.Controls("chbxDetalleA" & i), CheckBox)
            If i <> numero1 Then
                chbx.Enabled = False
                chbx.Checked = False
            Else
                chbx.Enabled = True
                If i = 1 Then
                    chbxDetalleC1.Enabled = True
                Else
                    chbxDetalleC1.Enabled = False
                    chbxDetalleC1.Checked = False
                End If
                If i = 4 Then txtDetalleC2.Enabled = True Else txtDetalleC2.Enabled = False
                If i = 5 Then
                    chbxDetalleC3.Enabled = True
                Else
                    chbxDetalleC3.Enabled = False
                    chbxDetalleC3.Checked = False
                End If
            End If
        Next


        If numero2 <> 0 Then
            For i As Integer = 1 To 11
                Dim chbx As CheckBox = CType(Me.Controls("chbxDetalleB" & i), CheckBox)
                If i <> numero2 Then
                    chbx.Enabled = False
                    chbx.Checked = False
                Else
                    chbx.Enabled = True
                End If
            Next
        Else
            chbxDetalleB11.Enabled = False
            chbxDetalleB11.Checked = False
        End If
    End Sub

    Private Sub InhabilitarTodo()
        For i As Integer = 1 To 12
            Dim chbx As CheckBox = CType(Me.Controls("chbxDetalleA" & i), CheckBox)
            chbx.Enabled = False
            chbx.Checked = False
        Next
        For i As Integer = 1 To 11
            Dim chbx As CheckBox = CType(Me.Controls("chbxDetalleB" & i), CheckBox)
            chbx.Enabled = False
            chbx.Checked = False
        Next
        chbxDetalleC1.Enabled = False
        chbxDetalleC1.Checked = False
        txtDetalleC2.Enabled = False
        chbxDetalleC3.Enabled = False
        chbxDetalleC3.Checked = False
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        anteriorForm.Show()
        Me.Close()
    End Sub
End Class