Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Common
Imports System.IO
Imports System.Drawing



Public Class Implementacion

    Inherits System.Web.UI.Page

    Dim Alerta As New Alertas
    Dim msgtipo(20) As Integer
    Dim msgmensaje(20) As String




    Dim VS1, VS2, VS3, VS4, VS5, VS6, VS7, TS1, TS2, TS3, FTO1, FTO2, FTO3, FTO4, MI1, MI2, MI3, MI4, ELL1, ELL2, ELL3, ELL4 As String

    Protected Sub btSubir_Click99(sender As Object, e As EventArgs) Handles btSubir30.Click
        Dim Plantillas As String = "Plantillas"
        If fuimage39.HasFile Then

            Dim filePath As String = fuimage39.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & Plantillas & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuimage39.PostedFile.SaveAs(estamadre)


                Label179.Text = "File " + fuimage39.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label179.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label179.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click100(sender As Object, e As EventArgs) Handles btSubir31.Click
        Dim Encuesta As String = "Encuesta"
        If fuimage40.HasFile Then

            Dim filePath As String = fuimage40.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & Encuesta & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuimage40.PostedFile.SaveAs(estamadre)


                Label181.Text = "File " + fuimage40.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label181.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label181.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click101(sender As Object, e As EventArgs) Handles btSubir32.Click
        Dim Operativas As String = "Dinamicas Operativas"
        If fuimage41.HasFile Then

            Dim filePath As String = fuimage41.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & Operativas & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuimage41.PostedFile.SaveAs(estamadre)


                Label187.Text = "File " + fuimage41.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label187.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label187.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click102(sender As Object, e As EventArgs) Handles btSubir33.Click
        Dim Mapa As String = "Mapa"
        If fuimage42.HasFile Then

            Dim filePath As String = fuimage42.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & Mapa & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuimage42.PostedFile.SaveAs(estamadre)


                Label189.Text = "File " + fuimage42.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label189.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label189.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click120(sender As Object, e As EventArgs) Handles btSubir34.Click
        Dim perfil As String = "perfil"
        If fuImage43.HasFile Then

            Dim filePath As String = fuImage43.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & perfil & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuImage43.PostedFile.SaveAs(estamadre)


                Label192.Text = "File " + fuImage43.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label192.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label192.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click123(sender As Object, e As EventArgs) Handles btSubir35.Click
        Dim Requisicion As String = "Requisicion"
        If fuImage44.HasFile Then

            Dim filePath As String = fuImage44.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & Requisicion & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuImage44.PostedFile.SaveAs(estamadre)


                Label194.Text = "File " + fuImage44.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label194.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label194.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click104(sender As Object, e As EventArgs) Handles btSubir36.Click
        Dim Politicas As String = "politicas"
        If fuImage45.HasFile Then

            Dim filePath As String = fuImage45.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & Politicas & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuImage45.PostedFile.SaveAs(estamadre)


                Label196.Text = "File " + fuImage45.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label196.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label196.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click500(sender As Object, e As EventArgs) Handles btSubir250.Click
        Dim Tipificacion As String = "Tipificacion"
        If fuImage200.HasFile Then

            Dim filePath As String = fuImage200.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & Tipificacion & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuImage200.PostedFile.SaveAs(estamadre)


                Label198.Text = "File " + fuImage200.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label198.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label198.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click510(sender As Object, e As EventArgs) Handles btSubir251.Click
        Dim Formato As String = "Formato_Caida"
        If fuImage201.HasFile Then

            Dim filePath As String = fuImage201.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & Formato & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuImage201.PostedFile.SaveAs(estamadre)


                Label200.Text = "File " + fuImage201.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label200.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label200.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click520(sender As Object, e As EventArgs) Handles btSubir252.Click
        Dim Pruebas As String = "Pruebas"
        If fuImage202.HasFile Then

            Dim filePath As String = fuImage202.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & Pruebas & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuImage202.PostedFile.SaveAs(estamadre)


                Label202.Text = "File " + fuImage202.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label202.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label202.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click900(sender As Object, e As EventArgs) Handles btSubir300.Click
        Dim Producto As String = "Producto"
        If fuImage67.HasFile Then

            Dim filePath As String = fuImage67.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & Producto & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuImage67.PostedFile.SaveAs(estamadre)


                Label204.Text = "File " + fuImage67.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label204.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label204.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click800(sender As Object, e As EventArgs) Handles btSubir301.Click
        Dim Sistema As String = "Sistema"
        If fuImage78.HasFile Then

            Dim filePath As String = fuImage78.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & Sistema & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuImage78.PostedFile.SaveAs(estamadre)


                Label206.Text = "File " + fuImage78.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label206.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label206.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click700(sender As Object, e As EventArgs) Handles btSubir302.Click
        Dim Logistica As String = "Logistica"
        If fuImage79.HasFile Then

            Dim filePath As String = fuImage79.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & Logistica & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuImage79.PostedFile.SaveAs(estamadre)


                Label208.Text = "File " + fuImage79.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label208.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label208.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click780(sender As Object, e As EventArgs) Handles btSubir560.Click
        Dim Evaluacion As String = "Evaluacion"
        If fuImage170.HasFile Then

            Dim filePath As String = fuImage170.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & Evaluacion & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuImage170.PostedFile.SaveAs(estamadre)


                Label210.Text = "File " + fuImage170.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label210.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label210.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click990(sender As Object, e As EventArgs) Handles btSubir700.Click
        Dim E_S As String = "Evalu_Siste"
        If fuImage177.HasFile Then

            Dim filePath As String = fuImage177.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & E_S & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuImage177.PostedFile.SaveAs(estamadre)


                Label212.Text = "File " + fuImage177.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label212.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label212.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click980(sender As Object, e As EventArgs) Handles btSubir351.Click
        Dim Presentacion As String = "Presentacion"
        If fuImage999.HasFile Then

            Dim filePath As String = fuImage999.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & Presentacion & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuImage999.PostedFile.SaveAs(estamadre)


                Label214.Text = "File " + fuImage999.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label214.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label214.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click970(sender As Object, e As EventArgs) Handles btSubir353.Click
        Dim Carta As String = "Carta"
        If fuImage899.HasFile Then

            Dim filePath As String = fuImage899.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & Carta & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuImage899.PostedFile.SaveAs(estamadre)


                Label216.Text = "File " + fuImage899.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label216.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label216.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click920(sender As Object, e As EventArgs) Handles btSubir354.Click
        Dim Glosario As String = "Glosario"
        If fuimage877.HasFile Then

            Dim filePath As String = fuimage877.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & Glosario & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuimage877.PostedFile.SaveAs(estamadre)


                Label218.Text = "File " + fuimage877.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label218.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label218.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    'Protected Sub btSubir_Click766(sender As Object, e As EventArgs) Handles btSubir666.Click
    '    Dim Reporte1 As String = "Reporte_1"
    '    If fuimage366.HasFile Then

    '        Dim filePath As String = fuimage366.PostedFile.FileName

    '        Dim filename As String = Path.GetFileName(filePath)

    '        Dim ext As String = Path.GetExtension(filename)

    '        Dim nombre As String = (TextBox1.Text & "_" & Reporte1 & ext)



    '        Try

    '            Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
    '            fuimage366.PostedFile.SaveAs(estamadre)


    '            Label172.Text = "File " + fuimage366.PostedFile.FileName + " Tu archivo subido correctamente."

    '        Catch ex As Exception



    '            Label172.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

    '        End Try
    '    Else


    '        Label172.Text = "Por favor selecciona un archivo."
    '    End If
    'End Sub



    Protected Sub btSubir_Click768(sender As Object, e As EventArgs) Handles btSubir667.Click
        Dim Reporte_2 As String = "Reporte_2"
        If fuimage367.HasFile Then

            Dim filePath As String = fuimage367.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & Reporte_2 & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuimage367.PostedFile.SaveAs(estamadre)


                Label173.Text = "File " + fuimage367.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label173.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label173.Text = "Por favor selecciona un archivo."
        End If
    End Sub



    Protected Sub btSubir_Click090(sender As Object, e As EventArgs)
        Dim Script As String = "Script"
        If fuimage38.HasFile Then

            Dim filePath As String = fuimage38.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & Script & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuimage38.PostedFile.SaveAs(estamadre)


                Label176.Text = "File " + fuimage38.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label176.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label176.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click290(sender As Object, e As EventArgs) Handles btSubir668.Click
        Dim Reporte_3 As String = "Reporte_3"
        If fuImage368.HasFile Then

            Dim filePath As String = fuImage368.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & Reporte_3 & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuImage368.PostedFile.SaveAs(estamadre)


                Label182.Text = "File " + fuImage368.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label182.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label182.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click404(sender As Object, e As EventArgs) Handles btSubir544.Click
        Dim Reporte_4 As String = "Reporte_4"
        If fuImage544.HasFile Then

            Dim filePath As String = fuImage544.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & Reporte_4 & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuImage544.PostedFile.SaveAs(estamadre)


                Label183.Text = "File " + fuImage544.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label183.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label183.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click405(sender As Object, e As EventArgs) Handles btSubir587.Click
        Dim Reporte_5 As String = "Reporte_5"
        If fuImage587.HasFile Then

            Dim filePath As String = fuImage587.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & Reporte_5 & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuImage587.PostedFile.SaveAs(estamadre)


                Label184.Text = "File " + fuImage587.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label184.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label184.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click1480(sender As Object, e As EventArgs) Handles btSubir1080.Click
        Dim Reporte1 As String = "Reporte_1"
        If fuimage366.HasFile Then

            Dim filePath As String = fuimage366.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & Reporte1 & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuimage366.PostedFile.SaveAs(estamadre)


                Label172.Text = "File " + fuimage366.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label172.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label172.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click408(sender As Object, e As EventArgs) Handles btSubir589.Click
        Dim Reporte_6 As String = "Reporte_6"
        If fuImage588.HasFile Then

            Dim filePath As String = fuImage588.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & Reporte_6 & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuImage588.PostedFile.SaveAs(estamadre)


                Label185.Text = "File " + fuImage588.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label185.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label185.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click695(sender As Object, e As EventArgs) Handles btSubir695.Click
        Dim carta As String = "Carta_Ins"
        If fuimage695.HasFile Then

            Dim filePath As String = fuimage695.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & carta & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuimage695.PostedFile.SaveAs(estamadre)


                Label224.Text = "File " + fuimage695.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label224.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label224.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click98(sender As Object, e As EventArgs) Handles btSubir29.Click
        Dim Script As String = "Script"
        If fuimage38.HasFile Then

            Dim filePath As String = fuimage38.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & Script & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuimage38.PostedFile.SaveAs(estamadre)


                Label176.Text = "File " + fuimage38.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label176.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label176.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click97(sender As Object, e As EventArgs) Handles btSubir28.Click
        Dim Grantt As String = "Grantt"
        If fuimage37.HasFile Then

            Dim filePath As String = fuimage37.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & Grantt & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuimage37.PostedFile.SaveAs(estamadre)


                Label159.Text = "File " + fuimage37.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label159.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label159.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click96(sender As Object, e As EventArgs) Handles btSubir27.Click
        Dim Minuta_7 As String = "Minuta_7"
        If fuimage36.HasFile Then

            Dim filePath As String = fuimage36.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & Minuta_7 & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuimage36.PostedFile.SaveAs(estamadre)


                Label157.Text = "File " + fuimage36.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label157.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label157.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click95(sender As Object, e As EventArgs) Handles btSubir26.Click
        Dim Minuta_6 As String = "Minuta_6"
        If fuimage35.HasFile Then

            Dim filePath As String = fuimage35.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & Minuta_6 & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuimage35.PostedFile.SaveAs(estamadre)


                Label155.Text = "File " + fuimage35.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label155.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label155.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click94(sender As Object, e As EventArgs) Handles btSubir25.Click
        Dim Minuta_5 As String = "Minuta_5"
        If fuimage34.HasFile Then

            Dim filePath As String = fuimage34.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & Minuta_5 & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuimage34.PostedFile.SaveAs(estamadre)


                Label153.Text = "File " + fuimage34.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label153.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label153.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click93(sender As Object, e As EventArgs) Handles btSubir24.Click
        Dim Minuta_4 As String = "Minuta_4"
        If fuimage33.HasFile Then

            Dim filePath As String = fuimage33.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & Minuta_4 & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuimage33.PostedFile.SaveAs(estamadre)


                Label151.Text = "File " + fuimage33.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label151.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label151.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click92(sender As Object, e As EventArgs) Handles btSubir23.Click
        Dim Minuta_3 As String = "Minuta_3"
        If fuimage32.HasFile Then

            Dim filePath As String = fuimage32.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & Minuta_3 & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuimage32.PostedFile.SaveAs(estamadre)


                Label130.Text = "File " + fuimage32.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label130.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label130.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click91(sender As Object, e As EventArgs) Handles btSubir22.Click
        Dim Minuta_2 As String = "Minuta_2"
        If fuimage31.HasFile Then

            Dim filePath As String = fuimage31.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & Minuta_2 & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuimage31.PostedFile.SaveAs(estamadre)


                Label122.Text = "File " + fuimage31.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label122.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label122.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click90(sender As Object, e As EventArgs) Handles btSubir21.Click
        Dim Minuta_1 As String = "Minuta_1"
        If fuimage30.HasFile Then

            Dim filePath As String = fuimage30.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & Minuta_1 & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuimage30.PostedFile.SaveAs(estamadre)


                Label120.Text = "File " + fuimage30.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label120.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label120.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Private Sub Menu1_MenuItemClick(sender As Object, e As MenuEventArgs) Handles Menu1.MenuItemClick
        MultiView1.ActiveViewIndex = Int32.Parse(e.Item.Value)
    End Sub

    Public Sub InsertFicha()

        Using cnn As New SqlConnection(ConfigurationManager.ConnectionStrings("Imple").ToString())

            Dim cmd As SqlCommand = New SqlCommand("INSERT_Campania", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            cnn.Open()



            '################################################# GENERAL #################################################

            cmd.Parameters.AddWithValue("@general_nombre_comercial_del_cliente", TextBox1.Text)
            cmd.Parameters.AddWithValue("@general_tipo_de_servicio", TextBox2.Text)
            cmd.Parameters.AddWithValue("@general_ubicación", TextBox4.Text)
            cmd.Parameters.AddWithValue("@general_interna", DropDownList1.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@general_fecha_de_implementacion", TextBox3.Text)
            cmd.Parameters.AddWithValue("@general_duracion_implementacion", TextBox5.Text)
            cmd.Parameters.AddWithValue("@general_fecha_de_inicio", TextBox6.Text)
            cmd.Parameters.AddWithValue("@general_duracion_inicio", TextBox7.Text)
            ''Aqui empeiza las variables  para  aguadar los checkbox

            If CheckBox1.Checked = True Then
                VS1 = "1,"
            Else
                VS1 = ""
            End If

            If CheckBox2.Checked = True Then
                VS2 = "2,"
            Else
                VS2 = ""
            End If

            If CheckBox3.Checked = True Then
                VS3 = "3,"
            Else
                VS3 = ""
            End If

            If CheckBox4.Checked = True Then
                VS4 = "4,"
            Else
                VS4 = ""
            End If

            If CheckBox5.Checked = True Then
                VS5 = "5,"
            Else
                VS5 = ""
            End If

            If CheckBox6.Checked = True Then
                VS6 = "6,"
            Else
                VS6 = ""
            End If

            If CheckBox7.Checked = True Then
                VS7 = "7"
            Else
                VS7 = ""
            End If


            cmd.Parameters.AddWithValue("@general_dias_de_servicio", VS1 & VS2 & VS3 & VS4 & VS5 & VS6 & VS7)
            cmd.Parameters.AddWithValue("@general_ventana_de_servicio_1_ini", DropDownList2.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@general_ventana_de_servicio_1_fin", DropDownList4.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@general_ventana_de_servicio_2_ini", DropDownList3.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@general_ventana_de_servicio_2_fin", DropDownList5.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@general_responsable_ccs_imp_nombre", TextBox8.Text)
            cmd.Parameters.AddWithValue("@general_responsable_ccs_imp_puesto", TextBox9.Text)
            cmd.Parameters.AddWithValue("@general_responsable_ccs_imp_telefono", TextBox10.Text)
            cmd.Parameters.AddWithValue("@general_responsable_ccs_imp_mail", TextBox42.Text)
            cmd.Parameters.AddWithValue("@general_responsable_ccs_imp_ext", TextBox1024.Text)
            cmd.Parameters.AddWithValue("@general_responsable_ccs_servicio_nombre", TextBox11.Text)
            cmd.Parameters.AddWithValue("@general_responsable_ccs_servicio_puesto", TextBox12.Text)
            cmd.Parameters.AddWithValue("@general_responsable_ccs_servicio_telefono", TextBox13.Text)
            cmd.Parameters.AddWithValue("@general_responsable_ccs_servicio_mail", TextBox14.Text)
            cmd.Parameters.AddWithValue("@general_responsable_ccs_servicio_ext", TextBox124.Text)


            cmd.Parameters.AddWithValue("@general_contacto_cliente_compañia_1", TextBox15.Text)
            cmd.Parameters.AddWithValue("@general_contacto_cliente_nombre_1", TextBox16.Text)
            cmd.Parameters.AddWithValue("@general_contacto_cliente_puesto_1", TextBox17.Text)
            cmd.Parameters.AddWithValue("@general_contacto_cliente_telefono_1", TextBox18.Text)
            cmd.Parameters.AddWithValue("@general_contacto_cliente_email_1", TextBox19.Text)
            cmd.Parameters.AddWithValue("@general_contacto_cliente_compañia_2", TextBox20.Text)
            cmd.Parameters.AddWithValue("@general_contacto_cliente_nombre_2", TextBox21.Text)
            cmd.Parameters.AddWithValue("@general_contacto_cliente_puesto_2", TextBox22.Text)
            cmd.Parameters.AddWithValue("@general_contacto_cliente_telefono_2", TextBox23.Text)
            cmd.Parameters.AddWithValue("@general_contacto_cliente_email_2", TextBox24.Text)
            cmd.Parameters.AddWithValue("@general_contacto_cliente_compañia_3", TextBox25.Text)
            cmd.Parameters.AddWithValue("@general_contacto_cliente_nombre_3", TextBox26.Text)
            cmd.Parameters.AddWithValue("@general_contacto_cliente_puesto_3", TextBox27.Text)
            cmd.Parameters.AddWithValue("@general_contacto_cliente_telefono_3", TextBox28.Text)
            cmd.Parameters.AddWithValue("@general_contacto_cliente_email_3", TextBox29.Text)
            cmd.Parameters.AddWithValue("@general_contacto_cliente_compañia_4", TextBox30.Text)
            cmd.Parameters.AddWithValue("@general_contacto_cliente_nombre_4", TextBox31.Text)
            cmd.Parameters.AddWithValue("@general_contacto_cliente_puesto_4", TextBox32.Text)
            cmd.Parameters.AddWithValue("@general_contacto_cliente_telefono_4", TextBox33.Text)
            cmd.Parameters.AddWithValue("@general_contacto_cliente_email_4", TextBox34.Text)
            cmd.Parameters.AddWithValue("@general_contacto_cliente_compañia_5", TextBox35.Text)
            cmd.Parameters.AddWithValue("@general_contacto_cliente_nombre_5", TextBox36.Text)
            cmd.Parameters.AddWithValue("@general_contacto_cliente_puesto_5", TextBox37.Text)
            cmd.Parameters.AddWithValue("@general_contacto_cliente_telefono_5", TextBox38.Text)
            cmd.Parameters.AddWithValue("@general_contacto_cliente_email_5", TextBox39.Text)
            cmd.Parameters.AddWithValue("@general_descripcion_servicio_objetivo", TextBox40.Text)
            cmd.Parameters.AddWithValue("@general_descripcion_servicio_resumen", TextBox41.Text)



            '''Segundo bloque de checklist

            If CheckBox8.Checked Then
                TS1 = "1,"
            Else
                TS1 = ""
            End If
            If CheckBox9.Checked Then
                TS2 = "2,"
            Else
                TS2 = ""
            End If
            If CheckBox10.Checked Then
                TS3 = "3"
            Else
                TS3 = ""
            End If

            '###########################################################################################################
            '################################################# CALIDAD #################################################

            cmd.Parameters.AddWithValue("@calidad_tipo_de_servicio", TS1 & TS2 & TS3)
            cmd.Parameters.AddWithValue("@calidad_alcance_del_proyecto", TextBox43.Text)
            cmd.Parameters.AddWithValue("@calidad_responsable_ccs_qa_nombre", TextBox44.Text)
            cmd.Parameters.AddWithValue("@calidad_responsable_ccs_qa_puesto", TextBox45.Text)
            cmd.Parameters.AddWithValue("@calidad_responsable_ccs_qa_telefono", TextBox46.Text)
            cmd.Parameters.AddWithValue("@calidad_responsable_ccs_qa_mail", TextBox47.Text)

            cmd.Parameters.AddWithValue("@calidad_desarrollo_de_script", DropDownList50.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@calidad_fecha_vobo_script", TextBox49.Text)
            cmd.Parameters.AddWithValue("@calidad_desarrollo_de_guia_de_monitoreo", DropDownList51.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@calidad_fecha_vobo_guia_de_monitoreo", TextBox48.Text)
            cmd.Parameters.AddWithValue("@calidad_desarrollo_de_material_de_apoyo", DropDownList52.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@calidad_fecha_vobo_material_de_apoyo", TextBox50.Text)



            cmd.Parameters.AddWithValue("@calidad_especificacion_servicio_de_monitoreo", TextBox51.Text)
            cmd.Parameters.AddWithValue("@calidad_especificacion_servicio_de_validacion", TextBox52.Text)
            cmd.Parameters.AddWithValue("@calidad_especificacion_servicio_de_verificacion", TextBox53.Text)
            cmd.Parameters.AddWithValue("@calidad_condiciones_de_rechazo_del_servicio", TextBox54.Text)

            cmd.Parameters.AddWithValue("@calidad_plantillas", DropDownList53.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@calidad_fecha_vobo_plantillas", TextBox55.Text)
            cmd.Parameters.AddWithValue("@calidad_responsable_entrega_plantillas", TextBox56.Text)
            cmd.Parameters.AddWithValue("@calidad_email_responsable_entrega_plantillas", TextBox57.Text)
            cmd.Parameters.AddWithValue("@calidad_contacto_entrega_plantillas", TextBox58.Text)
            cmd.Parameters.AddWithValue("@calidad_email_entrega_plantillas", TextBox59.Text)

            cmd.Parameters.AddWithValue("@calidad_encuesta_de_satisfaccion", DropDownList55.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@calidad_fecha_vobo_satisfaccion", TextBox65.Text)
            cmd.Parameters.AddWithValue("@calidad_responsable_entrega_satisfaccion", TextBox66.Text)
            cmd.Parameters.AddWithValue("@calidad_email_responsable_satisfaccion", TextBox67.Text)
            cmd.Parameters.AddWithValue("@calidad_contacto_entrega_satisfaccion", TextBox68.Text)
            cmd.Parameters.AddWithValue("@calidad_email_entrega_satisfaccion", TextBox69.Text)

            cmd.Parameters.AddWithValue("@calidad_grabaciones", DropDownList56.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@calidad_periodo_de_entrega_grabaciones", TextBox70.Text)
            cmd.Parameters.AddWithValue("@calidad_porcentaje_grabaciones_clientes", TextBox72.Text)
            cmd.Parameters.AddWithValue("@calidad_forma_de_entrega", TextBox71.Text)
            cmd.Parameters.AddWithValue("@calidad_audioteca", DropDownList57.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@calidad_tiempo_de_resguardo", TextBox74.Text)
            cmd.Parameters.AddWithValue("@calidad_reporteria_adicional", DropDownList58.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@calidad_comentarios_adicionales_del_proyecto", TextBox73.Text)
            cmd.Parameters.AddWithValue("@calidad_existe_riesgo", DropDownList59.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@calidad_periodo_de_entrega", TextBox75.Text)
            cmd.Parameters.AddWithValue("@calidad_activos_a_proteger", TextBox76.Text)

            '###########################################################################################################
            '################################################ OPERACION ################################################

            cmd.Parameters.AddWithValue("@operación_indicador_1", TextBox87.Text)
            cmd.Parameters.AddWithValue("@operación_indicador_1_objetivo", TextBox88.Text)
            cmd.Parameters.AddWithValue("@operación_indicador_2", TextBox77.Text)
            cmd.Parameters.AddWithValue("@operación_indicador_2_objetivo", TextBox78.Text)
            cmd.Parameters.AddWithValue("@operación_indicador_3", TextBox79.Text)
            cmd.Parameters.AddWithValue("@operación_indicador_3_objetivo", TextBox80.Text)
            cmd.Parameters.AddWithValue("@operación_indicador_4", TextBox81.Text)
            cmd.Parameters.AddWithValue("@operación_indicador_4_objetivo", TextBox82.Text)
            cmd.Parameters.AddWithValue("@operación_indicador_5", TextBox83.Text)
            cmd.Parameters.AddWithValue("@operación_indicador_5_objetivo", TextBox84.Text)
            cmd.Parameters.AddWithValue("@operación_indicador_6", TextBox85.Text)
            cmd.Parameters.AddWithValue("@operación_indicador_6_objetivo", TextBox86.Text)
            cmd.Parameters.AddWithValue("@operación_horas_de_servicio", TextBox500.Text)
            cmd.Parameters.AddWithValue("@operación_agentes_entregados", TextBox510.Text)
            cmd.Parameters.AddWithValue("@operación_existe_riesgo", DropDownList300.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@operación_nivel_riesgo", TextBox323.Text)
            cmd.Parameters.AddWithValue("@operación_activos_a_proteger", TextBox950.Text)


            '###########################################################################################################
            '################################################### RRHH ##################################################

            cmd.Parameters.AddWithValue("@rrhh_no_supervisores", DropDownList6.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_analistas", DropDownList7.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_validadores", DropDownList8.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes", TextBox125.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_1", DropDownList9.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_LV_entrada_1", DropDownList10.SelectedItem.Text)


            cmd.Parameters.AddWithValue("@rrhh_no_agentes_LV_salida_1", DropDownList11.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_SD_entrada_1", DropDownList12.SelectedItem.Text)

            cmd.Parameters.AddWithValue("@rrhh_no_agentes_SD_salida_1", DropDownList91.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_2", DropDownList102.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_LV_entrada_2", DropDownList13.SelectedItem.Text)


            cmd.Parameters.AddWithValue("@rrhh_no_agentes_LV_salida_2", DropDownList14.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_SD_entrada_2", DropDownList67.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_SD_salida_2", DropDownList100.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_3", DropDownList15.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_LV_entrada_3", DropDownList16.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_LV_salida_3", DropDownList17.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_SD_entrada_3", DropDownList68.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_SD_salida_3", DropDownList101.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_4", DropDownList18.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_LV_entrada_4", DropDownList19.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_LV_salida_4", DropDownList20.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_SD_entrada_4", DropDownList89.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_SD_salida_4", DropDownList103.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_5", DropDownList21.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_LV_entrada_5", DropDownList22.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_LV_salida_5", DropDownList23.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_SD_entrada_5", DropDownList90.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_SD_salida_5", DropDownList104.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_6", DropDownList24.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_LV_entrada_6", DropDownList25.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_LV_salida_6", DropDownList26.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_SD_entrada_6", DropDownList105.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_SD_salida_6", DropDownList106.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_7", DropDownList27.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_LV_entrada_7", DropDownList28.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_LV_salida_7", DropDownList29.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_SD_entrada_7", DropDownList98.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_SD_salida_7", DropDownList99.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_8", DropDownList30.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_LV_entrada_8", DropDownList31.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_LV_salida_8", DropDownList32.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_SD_entrada_8", DropDownList96.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_SD_salida_8", DropDownList97.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_9", DropDownList33.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_LV_entrada_9", DropDownList34.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_LV_salida_9", DropDownList35.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_SD_entrada_9", DropDownList94.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_SD_salida_9", DropDownList95.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_10", DropDownList36.SelectedItem.Text)

            cmd.Parameters.AddWithValue("@rrhh_no_agentes_LV_entrada_10", DropDownList37.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_LV_salida_10", DropDownList38.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_SD_entrada_10", DropDownList92.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_no_agentes_SD_salida_10", DropDownList93.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_perfiles", TextBox119.Text)
            cmd.Parameters.AddWithValue("@rrhh_dias_descanso", TextBox95.Text)
            cmd.Parameters.AddWithValue("@rrhh_sueldo_bruto", TextBox120.Text)
            cmd.Parameters.AddWithValue("@rrhh_bono_productividad", TextBox121.Text) '
            cmd.Parameters.AddWithValue("@rrhh_bono_prosperidad", TextBox122.Text) '
            cmd.Parameters.AddWithValue("@rrhh_otros", TextBox123.Text) '
            cmd.Parameters.AddWithValue("@rrhh_existe_riesgo", DropDownList60.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@rrhh_periodo_de_entrega", TextBox128.Text)
            cmd.Parameters.AddWithValue("@rrhh_activos_a_proteger", TextBox129.Text)

            '###########################################################################################################
            '#################################################### TI ###################################################

            cmd.Parameters.AddWithValue("@ti_carrier", TextBox130.Text)
            cmd.Parameters.AddWithValue("@ti_enlaces_ccs", TextBox135.Text)
            cmd.Parameters.AddWithValue("@ti_enlaces_cliente_ccs", TextBox137.Text)
            cmd.Parameters.AddWithValue("@ti_no_800_1", TextBox168.Text)
            cmd.Parameters.AddWithValue("@ti_publicado_800_1", TextBox138.Text)
            cmd.Parameters.AddWithValue("@ti_did_800_1", TextBox139.Text)
            cmd.Parameters.AddWithValue("@ti_publicado_did_1", TextBox140.Text)
            cmd.Parameters.AddWithValue("@ti_numero_local_1", TextBox141.Text)
            cmd.Parameters.AddWithValue("@ti_no_800_2", TextBox170.Text)
            cmd.Parameters.AddWithValue("@ti_publicado_800_2", TextBox171.Text)
            cmd.Parameters.AddWithValue("@ti_did_800_2", TextBox143.Text)
            cmd.Parameters.AddWithValue("@ti_publicado_did_2", TextBox144.Text)
            cmd.Parameters.AddWithValue("@ti_numero_local_2", TextBox145.Text)
            cmd.Parameters.AddWithValue("@ti_no_800_3", TextBox172.Text)
            cmd.Parameters.AddWithValue("@ti_publicado_800_3", TextBox173.Text)
            cmd.Parameters.AddWithValue("@ti_did_800_3", TextBox148.Text)
            cmd.Parameters.AddWithValue("@ti_publicado_did_3", TextBox149.Text)
            cmd.Parameters.AddWithValue("@ti_numero_local_3", TextBox150.Text)
            cmd.Parameters.AddWithValue("@ti_no_800_4", TextBox174.Text)
            cmd.Parameters.AddWithValue("@ti_publicado_800_4", TextBox175.Text)
            cmd.Parameters.AddWithValue("@ti_did_800_4", TextBox153.Text)
            cmd.Parameters.AddWithValue("@ti_publicado_did_4", TextBox154.Text)
            cmd.Parameters.AddWithValue("@ti_numero_local_4", TextBox155.Text)
            cmd.Parameters.AddWithValue("@ti_no_800_5", TextBox176.Text)
            cmd.Parameters.AddWithValue("@ti_publicado_800_5", TextBox177.Text)
            cmd.Parameters.AddWithValue("@ti_did_800_5", TextBox158.Text)
            cmd.Parameters.AddWithValue("@ti_publicado_did_5", TextBox159.Text)
            cmd.Parameters.AddWithValue("@ti_numero_local_5", TextBox160.Text)
            cmd.Parameters.AddWithValue("@ti_no_800_6", TextBox178.Text)
            cmd.Parameters.AddWithValue("@ti_publicado_800_6", TextBox179.Text)
            cmd.Parameters.AddWithValue("@ti_did_800_6", TextBox163.Text)
            cmd.Parameters.AddWithValue("@ti_publicado_did_6", TextBox164.Text)
            cmd.Parameters.AddWithValue("@ti_numero_local_6", TextBox165.Text)
            cmd.Parameters.AddWithValue("@ti_desborda_numero_externo", DropDownList61.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@ti_skills", TextBox180.Text)
            cmd.Parameters.AddWithValue("@ti_Url", TextBox502.Text)
            cmd.Parameters.AddWithValue("@ti_requiere_estaciones", DropDownList62.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@ti_no_estaciones", TextBox181.Text)
            cmd.Parameters.AddWithValue("@ti_analistas_por_estacion", TextBox183.Text)
            cmd.Parameters.AddWithValue("@ti_comentarios", TextBox182.Text)
            cmd.Parameters.AddWithValue("@ti_equipos_de_computo", DropDownList63.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@ti_unidades_1", TextBox185.Text)
            cmd.Parameters.AddWithValue("@ti_compra_renta_1", DropDownList164.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@ti_telefonos", DropDownList64.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@ti_unidades_2", TextBox184.Text)
            cmd.Parameters.AddWithValue("@ti_compra_renta_2", DropDownList65.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@ti_sillas", DropDownList66.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@ti_unidades_3", TextBox186.Text)
            cmd.Parameters.AddWithValue("@ti_compra_renta_3", DropDownList69.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@ti_diademas", DropDownList107.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@ti_unidades_4", TextBox105.Text)
            cmd.Parameters.AddWithValue("@ti_compra_renta_4", DropDownList108.SelectedItem.Text)

            cmd.Parameters.AddWithValue("@ti_pantallas", DropDownList44.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@ti_unidades_5", TextBox98.Text)
            cmd.Parameters.AddWithValue("@ti_compra_renta_5", DropDownList77.SelectedItem.Text)

            cmd.Parameters.AddWithValue("@ti_canceleria", DropDownList45.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@ti_unidades_6", TextBox99.Text)
            cmd.Parameters.AddWithValue("@ti_compra_renta_6", DropDownList78.SelectedItem.Text)

            cmd.Parameters.AddWithValue("@ti_mamparas", DropDownList48.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@ti_unidades_7", TextBox101.Text)
            cmd.Parameters.AddWithValue("@ti_compra_renta_7", DropDownList87.SelectedItem.Text)


            cmd.Parameters.AddWithValue("@ti_nodos", DropDownList49.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@ti_unidades_8", TextBox102.Text)
            cmd.Parameters.AddWithValue("@ti_compra_renta_8", DropDownList88.SelectedItem.Text)

            cmd.Parameters.AddWithValue("@ti_escritorio", DropDownList54.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@ti_unidades_9", TextBox187.Text)
            cmd.Parameters.AddWithValue("@ti_compra_renta_9", DropDownList76.SelectedItem.Text)

            cmd.Parameters.AddWithValue("@ti_biometrico", DropDownList47.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@ti_biometrico_especificar", TextBox103.Text)

            cmd.Parameters.AddWithValue("@ti_requerimiento_extra", DropDownList70.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@ti_requerimiento_extra_especificar", TextBox188.Text)
            cmd.Parameters.AddWithValue("@ti_cliente_propociona_recursos", DropDownList71.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@ti_cliente_propociona_recursos_especificar", TextBox189.Text)
            cmd.Parameters.AddWithValue("@ti_otros_requerimientos", TextBox190.Text)



            cmd.Parameters.AddWithValue("@ti_Aplicativo", DropDownList72.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@ti_email", DropDownList74.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@ti_otro_1", DropDownList80.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@ti_otro_1_especificar", TextBox104.Text)

            cmd.Parameters.AddWithValue("@ti_crm", DropDownList73.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@ti_ivr", DropDownList75.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@ti_cti", DropDownList79.SelectedItem.Text)


            cmd.Parameters.AddWithValue("@ti_facebook", DropDownList81.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@ti_twitter", DropDownList82.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@ti_otro_2", DropDownList83.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@whatsapp", DropDownList39.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@ti_espe_3", TextBox503.Text)
            cmd.Parameters.AddWithValue("@ti_celular_in_1", TextBox61.Text)
            cmd.Parameters.AddWithValue("@ti_celular_in_2", TextBox63.Text)
            cmd.Parameters.AddWithValue("@ti_celular_in_3", TextBox89.Text)
            cmd.Parameters.AddWithValue("@ti_celular_in_4", TextBox91.Text)
            cmd.Parameters.AddWithValue("@ti_numero_out_1", TextBox62.Text)
            cmd.Parameters.AddWithValue("@ti_numero_out_2", TextBox64.Text)
            cmd.Parameters.AddWithValue("@ti_numero_out_3", TextBox90.Text)
            cmd.Parameters.AddWithValue("@ti_numero_out_4", TextBox92.Text)


            cmd.Parameters.AddWithValue("@ti_se_supervisor", TextBox194.Text)
            cmd.Parameters.AddWithValue("@ti_se_supervisor_adicional", TextBox195.Text)
            cmd.Parameters.AddWithValue("@ti_se_agentes", TextBox196.Text)
            cmd.Parameters.AddWithValue("@ti_se_agentes_adicional", TextBox197.Text)
            cmd.Parameters.AddWithValue("@ti_se_cliente", TextBox198.Text)
            cmd.Parameters.AddWithValue("@ti_se_cliente_adicional", TextBox199.Text)
            cmd.Parameters.AddWithValue("@ti_he_supervisor", TextBox202.Text)
            cmd.Parameters.AddWithValue("@ti_he_supervisor_adicional", TextBox203.Text)
            cmd.Parameters.AddWithValue("@ti_he_agentes", TextBox204.Text)
            cmd.Parameters.AddWithValue("@ti_he_agentes_adicional", TextBox205.Text)
            cmd.Parameters.AddWithValue("@ti_he_cliente", TextBox206.Text)
            cmd.Parameters.AddWithValue("@ti_he_cliente_adicional", TextBox207.Text)

            If CheckBox85.Checked = True Then
                FTO1 = "XLS,"
            Else
                FTO1 = ""
            End If
            If CheckBox86.Checked = True Then
                FTO2 = "SQL,"
            Else
                FTO2 = ""
            End If
            If CheckBox87.Checked = True Then
                FTO3 = "Access,"
            Else
                FTO3 = ""
            End If
            If CheckBox88.Checked = True Then
                FTO4 = "Otro"
            Else
                FTO4 = ""
            End If

            cmd.Parameters.AddWithValue("@ti_bdd_formato", FTO1 & FTO2 & FTO3 & FTO4)
            If CheckBox89.Checked = True Then
                MI1 = "USB,"
            Else
                MI1 = ""
            End If
            If CheckBox90.Checked = True Then
                MI2 = "FTP,"
            Else
                MI2 = ""
            End If
            If CheckBox91.Checked = True Then
                MI3 = "Correo Cifrado,"
            Else
                MI3 = ""
            End If
            If CheckBox92.Checked = True Then
                MI4 = "Otro"
            Else
                MI4 = ""
            End If
            cmd.Parameters.AddWithValue("@ti_bdd_intercambio", MI1 & MI2 & MI3 & MI4)
            If CheckBox93.Checked = True Then
                ELL1 = "Correo Alterno,"
            Else
                ELL1 = ""
            End If
            If CheckBox94.Checked = True Then
                ELL2 = "SMS,"
            Else
                ELL2 = ""
            End If
            If CheckBox95.Checked = True Then
                ELL3 = "Whatsapp,"
            Else
                ELL3 = ""
            End If
            If CheckBox96.Checked = True Then
                ELL4 = "Llamada"
            Else
                ELL4 = ""
            End If
            cmd.Parameters.AddWithValue("@ti_bdd_llaves", ELL1 & ELL2 & ELL3 & ELL4)
            cmd.Parameters.AddWithValue("@ti_tratamiento", TextBox208.Text)
            cmd.Parameters.AddWithValue("@ti_responsable_bdd", TextBox209.Text)
            cmd.Parameters.AddWithValue("@ti_higienizacion_bdd", DropDownList40.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@ti_criterios_higienizacion", TextBox93.Text)
            cmd.Parameters.AddWithValue("@ti_existe_riesgo", DropDownList84.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@ti_periodo_de_entrega", TextBox210.Text)
            cmd.Parameters.AddWithValue("@ti_activos_a_proteger", TextBox211.Text)

            '###########################################################################################################
            '################################################### CAPA ##################################################

            cmd.Parameters.AddWithValue("@capa_contenido_curso", TextBox212.Text)
            cmd.Parameters.AddWithValue("@capa_impartido_por", TextBox213.Text)
            cmd.Parameters.AddWithValue("@capa_material_necesario", TextBox214.Text)
            cmd.Parameters.AddWithValue("@capa_duracion", TextBox215.Text)
            cmd.Parameters.AddWithValue("@capa_fechas", TextBox216.Text)
            cmd.Parameters.AddWithValue("@capa_intranet", DropDownList41.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@capa_agentes", TextBox94.Text)


            '###########################################################################################################
            '################################################### COMMAND CENTER ##################################################

            cmd.Parameters.AddWithValue("@command_reporte_tipo_solicitud", TextBox512.Text)
            cmd.Parameters.AddWithValue("@command_reporte_cliente", TextBox511.Text)
            cmd.Parameters.AddWithValue("@command_reporte_campaña", TextBox513.Text)
            cmd.Parameters.AddWithValue("@command_reporte_skills", TextBox524.Text)
            cmd.Parameters.AddWithValue("@command_reporte_solicitado", TextBox515.Text)
            cmd.Parameters.AddWithValue("@command_responsable_envio", TextBox60.Text)
            cmd.Parameters.AddWithValue("@command_reporte_lista", TextBox516.Text)



            '###########################################################################################################
            '############################################### FACTURACION ###############################################

            cmd.Parameters.AddWithValue("@facturacion_razon_social", TextBox217.Text)
            cmd.Parameters.AddWithValue("@facturacion_rfc", TextBox218.Text)
            cmd.Parameters.AddWithValue("@facturacion_domicilio_fiscal", TextBox219.Text)
            cmd.Parameters.AddWithValue("@facturacion_unidades_facturables", TextBox220.Text)
            cmd.Parameters.AddWithValue("@facturacion_descripcion_de_unidades", TextBox221.Text)
            cmd.Parameters.AddWithValue("@facturacion_consideraciones_para_el_cobro", TextBox222.Text)
            cmd.Parameters.AddWithValue("@facturacion_entrega_contacto", DropDownList42.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@facturacion_comentarios_1", TextBox96.Text)
            cmd.Parameters.AddWithValue("@facturacion_entrega_NDA", DropDownList43.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@facturacion_comentarios_2", TextBox97.Text)

            cmd.Parameters.AddWithValue("@facturacion_existe_riesgo", DropDownList85.SelectedItem.Text)
            cmd.Parameters.AddWithValue("@facturacion_periodo_de_entrega", TextBox233.Text)
            cmd.Parameters.AddWithValue("@facturacion_activos_a_proteger", TextBox234.Text)

            cmd.ExecuteNonQuery()

            cnn.Close()

        End Using

    End Sub

    Sub ClearControls()

        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
        TextBox3.Text = Nothing
        TextBox4.Text = Nothing
        TextBox5.Text = Nothing
        TextBox6.Text = Nothing
        TextBox7.Text = Nothing
        TextBox8.Text = Nothing
        TextBox9.Text = Nothing
        TextBox10.Text = Nothing
        TextBox11.Text = Nothing
        TextBox12.Text = Nothing
        TextBox13.Text = Nothing
        TextBox14.Text = Nothing
        TextBox15.Text = Nothing
        TextBox16.Text = Nothing
        TextBox17.Text = Nothing
        TextBox18.Text = Nothing
        TextBox19.Text = Nothing
        TextBox20.Text = Nothing
        TextBox21.Text = Nothing
        TextBox22.Text = Nothing
        TextBox23.Text = Nothing
        TextBox24.Text = Nothing
        TextBox25.Text = Nothing
        TextBox26.Text = Nothing
        TextBox27.Text = Nothing
        TextBox28.Text = Nothing
        TextBox29.Text = Nothing
        TextBox30.Text = Nothing
        TextBox31.Text = Nothing
        TextBox32.Text = Nothing
        TextBox33.Text = Nothing
        TextBox34.Text = Nothing
        TextBox35.Text = Nothing
        TextBox36.Text = Nothing
        TextBox37.Text = Nothing
        TextBox38.Text = Nothing
        TextBox39.Text = Nothing
        TextBox40.Text = Nothing
        TextBox41.Text = Nothing
        TextBox42.Text = Nothing
        TextBox43.Text = Nothing
        TextBox44.Text = Nothing
        TextBox45.Text = Nothing
        TextBox46.Text = Nothing
        TextBox47.Text = Nothing
        TextBox48.Text = Nothing
        TextBox49.Text = Nothing
        TextBox50.Text = Nothing
        TextBox51.Text = Nothing
        TextBox52.Text = Nothing
        TextBox53.Text = Nothing
        TextBox54.Text = Nothing
        TextBox55.Text = Nothing
        TextBox56.Text = Nothing
        TextBox57.Text = Nothing
        TextBox58.Text = Nothing
        TextBox59.Text = Nothing
        TextBox60.Text = Nothing
        TextBox61.Text = Nothing
        TextBox62.Text = Nothing
        TextBox63.Text = Nothing
        TextBox64.Text = Nothing
        TextBox65.Text = Nothing
        TextBox66.Text = Nothing
        TextBox67.Text = Nothing
        TextBox68.Text = Nothing
        TextBox69.Text = Nothing
        TextBox70.Text = Nothing
        TextBox71.Text = Nothing
        TextBox72.Text = Nothing
        TextBox73.Text = Nothing
        TextBox74.Text = Nothing
        TextBox75.Text = Nothing
        TextBox76.Text = Nothing
        TextBox77.Text = Nothing
        TextBox78.Text = Nothing
        TextBox79.Text = Nothing
        TextBox80.Text = Nothing
        TextBox81.Text = Nothing
        TextBox82.Text = Nothing
        TextBox83.Text = Nothing
        TextBox84.Text = Nothing
        TextBox85.Text = Nothing
        TextBox86.Text = Nothing
        TextBox87.Text = Nothing
        TextBox88.Text = Nothing
        TextBox89.Text = Nothing
        TextBox90.Text = Nothing
        TextBox91.Text = Nothing
        TextBox92.Text = Nothing
        TextBox93.Text = Nothing
        TextBox94.Text = Nothing
        'TextBox95.Text = Nothing
        'TextBox96.Text = Nothing
        'TextBox97.Text = Nothing
        'TextBox98.Text = Nothing
        'TextBox99.Text = Nothing
        'TextBox100.Text = Nothing
        'TextBox101.Text = Nothing
        'TextBox102.Text = Nothing
        'TextBox103.Text = Nothing
        'TextBox104.Text = Nothing
        'TextBox105.Text = Nothing
        'TextBox106.Text = Nothing
        'TextBox107.Text = Nothing
        'TextBox108.Text = Nothing
        'TextBox109.Text = Nothing
        'TextBox110.Text = Nothing
        'TextBox111.Text = Nothing
        'TextBox112.Text = Nothing
        'TextBox113.Text = Nothing
        'TextBox114.Text = Nothing
        'TextBox115.Text = Nothing
        'TextBox116.Text = Nothing
        'TextBox117.Text = Nothing
        'TextBox118.Text = Nothing
        TextBox119.Text = Nothing
        TextBox120.Text = Nothing
        TextBox121.Text = Nothing
        TextBox122.Text = Nothing
        TextBox123.Text = Nothing
        'TextBox124.Text = Nothing
        ' TextBox125.Text = Nothing
        'TextBox126.Text = Nothing
        'TextBox127.Text = Nothing
        TextBox128.Text = Nothing
        TextBox129.Text = Nothing
        TextBox130.Text = Nothing
        'TextBox131.Text = Nothing
        'TextBox132.Text = Nothing
        'TextBox133.Text = Nothing
        'TextBox134.Text = Nothing
        'TextBox135.Text = Nothing
        'TextBox136.Text = Nothing
        TextBox137.Text = Nothing
        TextBox138.Text = Nothing
        TextBox139.Text = Nothing
        TextBox140.Text = Nothing
        TextBox141.Text = Nothing
        'TextBox142.Text = Nothing
        TextBox143.Text = Nothing
        TextBox144.Text = Nothing
        TextBox145.Text = Nothing
        'TextBox146.Text = Nothing
        'TextBox147.Text = Nothing
        TextBox148.Text = Nothing
        TextBox149.Text = Nothing
        TextBox150.Text = Nothing
        'TextBox151.Text = Nothing
        'TextBox152.Text = Nothing
        TextBox153.Text = Nothing
        TextBox154.Text = Nothing
        TextBox155.Text = Nothing
        'TextBox156.Text = Nothing
        'TextBox157.Text = Nothing
        TextBox158.Text = Nothing
        TextBox159.Text = Nothing
        TextBox160.Text = Nothing
        'TextBox161.Text = Nothing
        'TextBox162.Text = Nothing
        TextBox163.Text = Nothing
        TextBox164.Text = Nothing
        TextBox165.Text = Nothing
        'TextBox166.Text = Nothing
        'TextBox167.Text = Nothing
        TextBox168.Text = Nothing
        'TextBox169.Text = Nothing
        TextBox170.Text = Nothing
        TextBox171.Text = Nothing
        TextBox172.Text = Nothing
        TextBox173.Text = Nothing
        TextBox174.Text = Nothing
        TextBox175.Text = Nothing
        TextBox176.Text = Nothing
        TextBox177.Text = Nothing
        TextBox178.Text = Nothing
        TextBox179.Text = Nothing
        TextBox180.Text = Nothing
        TextBox181.Text = Nothing
        TextBox182.Text = Nothing
        TextBox183.Text = Nothing
        TextBox184.Text = Nothing
        TextBox185.Text = Nothing
        TextBox186.Text = Nothing
        TextBox187.Text = Nothing
        TextBox188.Text = Nothing
        TextBox189.Text = Nothing
        TextBox190.Text = Nothing
        'TextBox191.Text = Nothing
        'TextBox192.Text = Nothing
        'TextBox193.Text = Nothing
        TextBox194.Text = Nothing
        TextBox195.Text = Nothing
        TextBox196.Text = Nothing
        TextBox197.Text = Nothing
        TextBox198.Text = Nothing
        TextBox199.Text = Nothing
        'TextBox200.Text = Nothing
        'TextBox201.Text = Nothing
        TextBox202.Text = Nothing
        TextBox203.Text = Nothing
        TextBox204.Text = Nothing
        TextBox205.Text = Nothing
        TextBox206.Text = Nothing
        TextBox207.Text = Nothing
        TextBox208.Text = Nothing
        TextBox209.Text = Nothing
        TextBox210.Text = Nothing
        TextBox211.Text = Nothing
        TextBox212.Text = Nothing
        TextBox213.Text = Nothing
        TextBox214.Text = Nothing
        TextBox215.Text = Nothing
        TextBox216.Text = Nothing
        TextBox217.Text = Nothing
        TextBox218.Text = Nothing
        TextBox219.Text = Nothing
        TextBox220.Text = Nothing
        TextBox221.Text = Nothing
        TextBox222.Text = Nothing
        'TextBox223.Text = Nothing
        'TextBox224.Text = Nothing
        'TextBox225.Text = Nothing
        'TextBox226.Text = Nothing
        'TextBox227.Text = Nothing
        'TextBox228.Text = Nothing
        'TextBox229.Text = Nothing
        'TextBox230.Text = Nothing
        'TextBox231.Text = Nothing
        ' TextBox232.Text = Nothing
        TextBox233.Text = Nothing
        TextBox234.Text = Nothing
        TextBox500.Text = Nothing
        TextBox502.Text = Nothing
        TextBox503.Text = Nothing
        TextBox510.Text = Nothing
        TextBox511.Text = Nothing
        TextBox512.Text = Nothing
        TextBox513.Text = Nothing
        TextBox524.Text = Nothing
        TextBox515.Text = Nothing
        TextBox516.Text = Nothing
        TextBox323.Text = Nothing
        TextBox950.Text = Nothing

        DropDownList1.SelectedIndex = 0
        DropDownList2.SelectedIndex = 0
        DropDownList3.SelectedIndex = 0
        DropDownList4.SelectedIndex = 0
        DropDownList5.SelectedIndex = 0
        DropDownList6.SelectedIndex = 0
        DropDownList7.SelectedIndex = 0
        DropDownList8.SelectedIndex = 0
        DropDownList9.SelectedIndex = 0
        DropDownList10.SelectedIndex = 0
        DropDownList11.SelectedIndex = 0
        DropDownList12.SelectedIndex = 0
        DropDownList13.SelectedIndex = 0
        DropDownList14.SelectedIndex = 0
        DropDownList15.SelectedIndex = 0
        DropDownList16.SelectedIndex = 0
        DropDownList17.SelectedIndex = 0
        DropDownList18.SelectedIndex = 0
        DropDownList19.SelectedIndex = 0
        DropDownList20.SelectedIndex = 0
        DropDownList22.SelectedIndex = 0
        DropDownList21.SelectedIndex = 0
        DropDownList23.SelectedIndex = 0
        DropDownList24.SelectedIndex = 0
        DropDownList25.SelectedIndex = 0

        DropDownList26.SelectedIndex = 0
        DropDownList27.SelectedIndex = 0
        DropDownList28.SelectedIndex = 0
        DropDownList29.SelectedIndex = 0
        DropDownList30.SelectedIndex = 0
        DropDownList31.SelectedIndex = 0
        DropDownList32.SelectedIndex = 0
        DropDownList33.SelectedIndex = 0
        DropDownList34.SelectedIndex = 0

        DropDownList50.SelectedIndex = 0
        DropDownList51.SelectedIndex = 0
        DropDownList52.SelectedIndex = 0
        DropDownList53.SelectedIndex = 0
        'DropDownList54.SelectedIndex = 0
        DropDownList55.SelectedIndex = 0
        DropDownList56.SelectedIndex = 0
        DropDownList57.SelectedIndex = 0
        DropDownList58.SelectedIndex = 0
        DropDownList59.SelectedIndex = 0
        DropDownList60.SelectedIndex = 0
        DropDownList61.SelectedIndex = 0
        DropDownList62.SelectedIndex = 0
        DropDownList63.SelectedIndex = 0
        DropDownList64.SelectedIndex = 0
        DropDownList164.SelectedIndex = 0
        DropDownList65.SelectedIndex = 0
        DropDownList66.SelectedIndex = 0
        DropDownList67.SelectedIndex = 0
        DropDownList68.SelectedIndex = 0
        DropDownList69.SelectedIndex = 0
        DropDownList70.SelectedIndex = 0
        DropDownList71.SelectedIndex = 0
        DropDownList72.SelectedIndex = 0
        DropDownList73.SelectedIndex = 0
        DropDownList74.SelectedIndex = 0
        DropDownList75.SelectedIndex = 0
        'DropDownList76.SelectedIndex = 0
        'DropDownList77.SelectedIndex = 0
        'DropDownList78.SelectedIndex = 0
        DropDownList79.SelectedIndex = 0
        DropDownList80.SelectedIndex = 0
        DropDownList81.SelectedIndex = 0
        DropDownList82.SelectedIndex = 0
        DropDownList83.SelectedIndex = 0
        DropDownList84.SelectedIndex = 0
        DropDownList85.SelectedIndex = 0
        DropDownList300.SelectedIndex = 0


        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
        CheckBox10.Checked = False
        'CheckBox81.Checked = False
        'CheckBox82.Checked = False
        'CheckBox83.Checked = False
        'CheckBox84.Checked = False
        CheckBox85.Checked = False
        CheckBox86.Checked = False
        CheckBox87.Checked = False
        CheckBox88.Checked = False
        CheckBox89.Checked = False
        CheckBox90.Checked = False
        CheckBox91.Checked = False
        CheckBox92.Checked = False
        CheckBox93.Checked = False
        CheckBox94.Checked = False
        CheckBox95.Checked = False
        CheckBox96.Checked = False









    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Try
            InsertFicha()
            ClearControls()
            msgtipo(0) = 1
            msgmensaje(0) = "¡Ficha Guardada Correctamente!"
            Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
        Catch ex As Exception
            msgtipo(0) = 4
            msgmensaje(0) = "¡Revisa que todos los campos estén llenos y con el formato correcto!"
            Alerta.NewShowAlert(msgtipo, msgmensaje, Me)
        End Try


    End Sub
    Protected Sub btSubir_Click(sender As Object, e As EventArgs) Handles btSubir.Click

        Dim macro As String = "macro"

        If fuImage.HasFile Then
            Dim filePath As String = fuImage.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & macro & ext)

            Try
                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuImage.PostedFile.SaveAs(estamadre)

                Label164.Text = "File " + fuImage.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label164.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label164.Text = "Por favor selecciona un archivo."
        End If
    End Sub


    Protected Sub btSubir_Click1(sender As Object, e As EventArgs) Handles btSubir2.Click
        Dim subp As String = "sub"
        If fuImage2.HasFile Then
            Dim filePath As String = fuImage2.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & subp & ext)


            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuImage2.PostedFile.SaveAs(estamadre)


                Label165.Text = "File " + fuImage2.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label165.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label165.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click2(sender As Object, e As EventArgs) Handles btSubir3.Click
        Dim manual As String = "manual"

        If fuImage3.HasFile Then
            Dim filePath As String = fuImage3.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & manual & ext)

            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuImage3.PostedFile.SaveAs(estamadre)


                Label166.Text = "File " + fuImage3.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label166.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label166.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click3(sender As Object, e As EventArgs) Handles btSubir4.Click
        Dim operativo As String = "operativo"
        If fuImage4.HasFile Then

            Dim filePath As String = fuImage4.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & operativo & ext)

            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)

                fuImage4.PostedFile.SaveAs(estamadre)

                Label167.Text = "File " + fuImage4.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label167.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label167.Text = "Por favor selecciona un archivo."
        End If
    End Sub

    Protected Sub btSubir_Click71(sender As Object, e As EventArgs) Handles Button2.Click
        Dim layout As String = "layout"
        If FileUpload1.HasFile Then


            Dim filePath As String = FileUpload1.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & layout & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                FileUpload1.PostedFile.SaveAs(estamadre)


                Label44.Text = "File " + FileUpload1.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label44.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label44.Text = "Por favor selecciona un archivo."
        End If
    End Sub


    Protected Sub btSubir_Click6(sender As Object, e As EventArgs) Handles btSubir5.Click
        Dim logo As String = "logo"
        If fuImage5.HasFile Then

            Dim filePath As String = fuImage5.PostedFile.FileName

            Dim filename As String = Path.GetFileName(filePath)

            Dim ext As String = Path.GetExtension(filename)

            Dim nombre As String = (TextBox1.Text & "_" & logo & ext)



            Try

                Dim estamadre As String = Server.MapPath("~/temp/" & nombre)
                fuImage5.PostedFile.SaveAs(estamadre)


                Label168.Text = "File " + fuImage5.PostedFile.FileName + " Tu archivo subido correctamente."

            Catch ex As Exception



                Label168.Text = "Ocurrio un problema mientras se cargaba el archivo. Por favor vuelve intentarlo."

            End Try
        Else


            Label168.Text = "Por favor selecciona un archivo."
        End If
    End Sub






End Class