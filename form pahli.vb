Public Class calculator
    Friend Hasil As Single = 0
    Dim operasi As String = ""
    Dim operasiHitung As Boolean = False

    Private Sub cmbbutton0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbutton0.Click
        txtlayar.Text = txtlayar.Text & "0"
    End Sub

    Private Sub cmbbutton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbutton1.Click
        If operasiHitung = True Or txtlayar.Text = "0" Then
            txtlayar.Text = "1"
            operasiHitung = False
        Else
            txtlayar.Text = txtlayar.Text + "1"
        End If
    End Sub

    Private Sub cmbbutton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbutton2.Click
        If operasiHitung = True Or txtlayar.Text = "0" Then
            txtlayar.Text = "2"
            operasiHitung = False
        Else
            txtlayar.Text = txtlayar.Text + "2"
        End If
    End Sub

    Private Sub cmbbutton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbutton3.Click
        If operasiHitung = True Or txtlayar.Text = "0" Then
            txtlayar.Text = "3"
            operasiHitung = False
        Else
            txtlayar.Text = txtlayar.Text + "3"
        End If
    End Sub

    Private Sub cmbbutton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbutton4.Click
        If operasiHitung = True Or txtlayar.Text = "0" Then
            txtlayar.Text = "4"
            operasiHitung = False
        Else
            txtlayar.Text = txtlayar.Text + "4"
        End If
    End Sub

    Private Sub cmbbutton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbutton5.Click
        If operasiHitung = True Or txtlayar.Text = "0" Then
            txtlayar.Text = "5"
            operasiHitung = False
        Else
            txtlayar.Text = txtlayar.Text + "5"
        End If
    End Sub

    Private Sub cmbbutton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbutton6.Click
        If operasiHitung = True Or txtlayar.Text = "0" Then
            txtlayar.Text = "6"
            operasiHitung = False
        Else
            txtlayar.Text = txtlayar.Text + "6"
        End If
    End Sub

    Private Sub cmbbutton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbutton7.Click
        If operasiHitung = True Or txtlayar.Text = "0" Then
            txtlayar.Text = "7"
            operasiHitung = False
        Else
            txtlayar.Text = txtlayar.Text + "7"
        End If
    End Sub

    Private Sub cmbbutton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbutton8.Click
        If operasiHitung = True Or txtlayar.Text = "0" Then
            txtlayar.Text = "8"
            operasiHitung = False
        Else
            txtlayar.Text = txtlayar.Text + "8"
        End If
    End Sub

    Private Sub cmbbutton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbutton9.Click
        If operasiHitung = True Or txtlayar.Text = "0" Then
            txtlayar.Text = "9"
            operasiHitung = False
        Else
            txtlayar.Text = txtlayar.Text + "9"
        End If
    End Sub

    Private Sub cmbhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbhapus.Click
        txtlayar.Text = ""
        operasi = ""

    End Sub

    Private Sub cmbtambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtambah.Click
        operasi = "tambah"
        Hasil = Val(txtlayar.Text)
        operasiHitung = True
    End Sub

    Private Sub cmbsamadengan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsamadengan.Click
        Select Case operasi
            Case "tambah"
                Hasil = Hasil + Val(txtlayar .Text)
            Case "kurang"
                Hasil = Hasil - Val(txtlayar.Text)
            Case "kali"
                Hasil = Hasil * Val(txtlayar.Text)
            Case "pangkat"
                Hasil = Hasil ^ 2
            Case "bagi"
                Hasil = Hasil / Val(txtlayar.Text)
        End Select
        txtlayar.Text = Hasil
        operasiHitung = True
    End Sub

    Private Sub cmbkurang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbkurang.Click
        operasi = "kurang"
        Hasil = Val(txtlayar.Text)
        operasiHitung = True
    End Sub

    Private Sub calculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub txtlayar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlayar.TextChanged

    End Sub

    Private Sub cmbkali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbkali.Click
        operasi = "kali"
        Hasil = Val(txtlayar.Text)
        operasiHitung = True
    End Sub

    Private Sub cmbpangkat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpangkat.Click
        operasi = "pangkat"
        Hasil = Val(txtlayar.Text)
        operasiHitung = True
    End Sub

    Private Sub cmbbagi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbagi.Click
        operasi = "bagi"
        Hasil = Val(txtlayar.Text)
        operasiHitung = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub
End Class






