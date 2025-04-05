﻿Imports MySql.Data.MySqlClient
Module dbConnection

    Public con As New MySqlConnection("server=localhost;user id=lms;password=Magnaye2143@#;database=lms")
    ' Public con As New MySqlConnection ("server=localhost;user id=root;password= ;database=lms")
    ' Public con As New MySqlConnection("server=192.168.1.26;user id=lcpmpc123;password=lcpmpc123;database=lms")
    Dim da As New MySqlDataAdapter
    Public dr As MySqlDataReader




    Public Sub reload(ByVal sql As String, ByVal datagrid As DataGridView)
        Try
            ' Clear the DataTable before loading new data
            Dim dt As New DataTable

            ' Close and open connection
            con.Close()
            con.Open()

            Using loadSql As New MySqlCommand(sql, con)
                Using da As New MySqlDataAdapter(loadSql)
                    da.Fill(dt)
                    datagrid.DataSource = dt
                End Using
            End Using

        Catch ex As Exception
            show_error("Unable to load data: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub


    Public Sub cmb_display(query As String, cmb As ComboBox)
        Try

            con.Close()
            con.Open()

            Using cmd As New MySqlCommand(query, con)
                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    cmb.Items.Clear()


                    While reader.Read()
                        cmb.Items.Add(reader.GetString(0))
                    End While


                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Module
