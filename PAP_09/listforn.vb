﻿Public Class listforn

    Private Sub FornecedorBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FornecedorBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FornecedorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_papDataSet)

    End Sub

    Private Sub listforn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_papDataSet.Fornecedor' table. You can move, or remove it, as needed.
        Me.FornecedorTableAdapter.Fill(Me.Db_papDataSet.Fornecedor)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            Me.FornecedorTableAdapter.FillByidforn(Me.Db_papDataSet.Fornecedor, TextBox1.Text)
        ElseIf RadioButton2.Checked = True Then
            Me.FornecedorTableAdapter.FillBysearchforn(Me.Db_papDataSet.Fornecedor, TextBox1.Text)
        ElseIf RadioButton3.Checked = True Then
            Me.FornecedorTableAdapter.FillBynif(Me.Db_papDataSet.Fornecedor, TextBox1.Text)

        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If RadioButton1.Checked = True Or RadioButton3.Checked = True Then
            If Asc(e.KeyChar) <> 8 Then
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged
        TextBox1.Clear()

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TextBox1.Clear()
    End Sub
End Class