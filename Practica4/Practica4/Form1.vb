Public Class Form1
    Dim formato As Boolean = True
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Crear una variable, le asigna un valor, el valor es la fecha del dia de hoy convertida a string'
        ' en el formato de "dd 'de' MMM 'del' yyyy" [dd- numero de dia, MMMM- el mes en texto, yyyy- para el año]
        Dim Date_o = DateTime.Now.ToString("dd 'de' MMM 'del' yyyy")
        Dim Day_o = DateTime.Now.ToString("dddd")
        Dim Time_o As String = ""

        ' Este es el formato de 24 h
        If formato = True Then
            ' "08:08:56:12"
            Time_o = DateTime.Now.ToString("HH:mm:ss")
        ElseIf formato = False Then
            Time_o = DateTime.Now.ToString("hh:mm:ss")
        End If

        Dim Time_mod = Time_o.Split(":")
        ' Time_mod(0) = "08"
        ' Time_mod(1) = "08"
        ' Time_mod(2) = "56"
        ' Time_mod(3) = "12"
        Horas.Text = Time_mod(0)
        Minutos.Text = Time_mod(1)
        Segundos.Text = Time_mod(2)
        Dias.Text = Day_o
        Fecha.Text = Date_o
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label1.Text = ":" Then
            Label1.Text = ""
        ElseIf Label1.Text = "" Then
            Label1.Text = ":"
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Panel1.Visible = False Then
            Panel1.Visible = True
        ElseIf Panel1.Visible = True Then
            Panel1.Visible = False

        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim color_texto As String = ComboBox2.SelectedItem.ToString
        If color_texto = "Blanco" Then
            Horas.ForeColor = Color.White
            Minutos.ForeColor = Color.White
            Label1.ForeColor = Color.White
            Fecha.ForeColor = Color.White
            Dias.ForeColor = Color.White
            Segundos.ForeColor = Color.White
        ElseIf color_texto = "Rojo" Then
            Horas.ForeColor = Color.Red
            Minutos.ForeColor = Color.Red
            Label1.ForeColor = Color.Red
            Fecha.ForeColor = Color.Red
            Dias.ForeColor = Color.Red
            Segundos.ForeColor = Color.Red
        ElseIf color_texto = "Azul" Then
            Horas.ForeColor = Color.Blue
            Minutos.ForeColor = Color.Blue
            Label1.ForeColor = Color.Blue
            Fecha.ForeColor = Color.Blue
            Dias.ForeColor = Color.Blue
            Segundos.ForeColor = Color.Blue
        ElseIf color_texto = "Amarillo" Then
            Horas.ForeColor = Color.Yellow
            Minutos.ForeColor = Color.Yellow
            Label1.ForeColor = Color.Yellow
            Fecha.ForeColor = Color.Yellow
            Dias.ForeColor = Color.Yellow
            Segundos.ForeColor = Color.Yellow
        ElseIf color_texto = "Verde" Then
            Horas.ForeColor = Color.Green
            Minutos.ForeColor = Color.Green
            Label1.ForeColor = Color.Green
            Fecha.ForeColor = Color.Green
            Dias.ForeColor = Color.Green
            Segundos.ForeColor = Color.Green
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If formato = True Then
            Button1.Text = "12h"
            formato = False
        ElseIf formato = False Then
            Button1.Text = "24"
            formato = True

        End If
    End Sub
End Class
