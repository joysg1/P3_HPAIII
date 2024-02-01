Public Class Form1
    Dim numRegistro As Integer
    Dim tipoNave As String
    Dim precioPeaje As Double
    Dim totalPeaje As Double
    Dim comision As Double
    Dim vecTipoNave(10) As String
    Dim vecPrecioPeaje(10) As Double
    Dim c As Integer
    Dim d As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbRegistro.Enabled = False
        c = -1
        d = -1
        totalPeaje = 0
    End Sub

    Sub Verificar()
        If (cbTipoNave.SelectedIndex = -1) Then
            MsgBox("Favor seleccionar tipo de Nave")
        Else
            Registro()
        End If
    End Sub

    Sub Registro()
        numRegistro = Val(lbData.Text)
        numRegistro = numRegistro - 1
        lbData.Text = numRegistro


        tipoNave = cbTipoNave.SelectedItem
        c = c + 1
        vecTipoNave(c) = tipoNave


        d = d + 1
        If (cbTipoNave.SelectedIndex = 0) Then
            precioPeaje = 30000

        ElseIf (cbTipoNave.SelectedIndex = 1) Then
            precioPeaje = 100000
        Else
            precioPeaje = 800000
        End If

        vecPrecioPeaje(d) = precioPeaje
        lbPrecio.Text = "PRECIO DE PEAJE " + Str(precioPeaje)

        If (lbData.Text = 0) Then
            MsgBox("REGISTRO DIARIO LLENO")
            gbDatos.Enabled = False
            Calcular()
            Imprimir()

        End If



    End Sub

    Sub Calcular()
        For i = 0 To 9

            totalPeaje = totalPeaje + vecPrecioPeaje(i)

        Next

        lbTotalDiario.Text = "TOTAL PEAJE DIARIO " + Str(totalPeaje)

        If (totalPeaje > 500000) Then
            comision = totalPeaje * 0.15
            lbComision.Text = "COMISION OBTENIDA: " + Str(comision)
        Else
            lbComision.Text = "COMISION NO ALCANZADA"
        End If


    End Sub

    Sub Imprimir()
        gbRegistro.Enabled = True
        For r = 0 To 9


            lboxPrecioNave.Items.Add(Str(vecPrecioPeaje(r)))
            lboxTipoNave.Items.Add(vecTipoNave(r))


        Next
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Verificar()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
