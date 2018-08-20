Imports System.Net.Mail

Module correo

    Public Sub CorreoNuevoCandidato(emailTo As String)
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("rrhhcahuita@gmail.com", "cahuita123")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"
            e_mail = New MailMessage()
            e_mail.From = New MailAddress("rrhhcahuita@gmail.com")
            e_mail.To.Add(emailTo)
            e_mail.Subject = "Nuevo Candidato"
            e_mail.IsBodyHtml = False
            e_mail.Body = "Usted ha sido creado como candidato en Cahuita, este atento a este medio para mas notificaciones"
            Smtp_Server.Send(e_mail)
            MsgBox("Correo enviado")
        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try
    End Sub

    Public Sub CorreoNuevoEmpleado(emailTo As String)
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("rrhhcahuita@gmail.com", "cahuita123")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"
            e_mail = New MailMessage()
            e_mail.From = New MailAddress("rrhhcahuita@gmail.com")
            e_mail.To.Add(emailTo)
            e_mail.Subject = "Nuevo Empleado"
            e_mail.IsBodyHtml = False
            e_mail.Body = "Felicidades! Usted ha sido contratado en Cahuita. Por favor proceda a la aplicacion y registrese como usuario"

            Smtp_Server.Send(e_mail)
            MsgBox("Correo enviado")
        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try
    End Sub
End Module
