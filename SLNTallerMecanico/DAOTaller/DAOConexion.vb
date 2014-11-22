﻿Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration


Public Class DAOConexion
    Public conex As New SqlConnection
    Private resultado As Boolean = False

    Function AbrirConexion() As Boolean
        Try
            ' conex.ConnectionString = DAOTaller.My.MySettings.Default.Conexion
            conex = New SqlConnection(ConfigurationManager.ConnectionStrings("OracleConnectionString").ConnectionString) ' se crea la conexion a la bd
            conex.Open()
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        Return resultado
    End Function

    Function CerrarConexion() As Boolean
        Try
            If conex.State = ConnectionState.Open Then
                conex.Close()
                resultado = True
            End If
        Catch ex As Exception
            Resultado = False
        End Try
        Return Resultado
    End Function
End Class
