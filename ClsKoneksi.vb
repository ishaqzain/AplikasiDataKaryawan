﻿Imports Microsoft.VisualBasic
Imports System.Data.Sql

Public Class ClsKoneksi
    Protected TblKaryawan = New DataTable
    Protected SQL As String
    Protected Cn As OleDb.OleDbConnection
    Protected Cmd As OleDb.OleDbCommand
    Protected Da As OleDb.OleDbDataAdapter
    Protected Ds As DataSet
    Protected Dt As DataTable

    Public Function OpenConn() As Boolean
        Cn = New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;User ID=ishaq;Password=123ishaq;Initial Catalog=DbKaryawan;Data Source=DESKTOP-J1PER27\SQLEXPRESS")
        Cn.Open()
        If Cn.State <> ConnectionState.Open Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub CloseConn()
        If Not IsNothing(Cn) Then
            Cn.Close()
            Cn = Nothing
        End If
    End Sub

    Public Function ExecuteQuery(ByVal Query As String) As DataTable
        If Not OpenConn() Then
            MsgBox("Koneksi Ke Database Gagal...!!!", MsgBoxStyle.Critical, "Access Failed")
            Return Nothing
            Exit Function
        End If

        Cmd = New OleDb.OleDbCommand(Query, Cn)
        Da = New OleDb.OleDbDataAdapter
        Da.SelectCommand = Cmd
        Ds = New Data.DataSet
        Da.Fill(Ds)
        Dt = Ds.Tables(0)
        Return Dt

        Dt = Nothing
        Ds = Nothing
        Da = Nothing
        Cmd = Nothing
        CloseConn()
    End Function

    Public Sub ExecuteNonQuery(ByVal Query As String)
        If Not OpenConn() Then
            MsgBox("Koneksi Ke Database Gagal...!!!", MsgBoxStyle.Critical, "Access Failed")
            Exit Sub
        End If

        Cmd = New OleDb.OleDbCommand
        Cmd.Connection = Cn
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = Query
        Cmd.ExecuteNonQuery()
        Cmd = Nothing
        CloseConn()
    End Sub

End Class