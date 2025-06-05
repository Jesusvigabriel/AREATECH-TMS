using System;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hermes;

[StandardModule]
internal sealed class Mod_Enviar_mails
{
	public static void enviar_mail()
	{
		SmtpClient smtpClient = new SmtpClient();
		MailMessage mailMessage = new MailMessage();
		try
		{
			string text = "facumillan@gmail.com";
			string password = "facu@40768959";
			string text2 = "Mensaje prueba ";
			string text3 = "desde Visual Basic .NET ";
			string text4 = "Mensaje enviado desde HERMES";
			string addresses = "operaciones@area54sa.com.ar";
			smtpClient.Port = 587;
			smtpClient.Host = "smtp.gmail.com";
			smtpClient.EnableSsl = true;
			smtpClient.Credentials = new NetworkCredential(text, password);
			mailMessage = new MailMessage();
			mailMessage.From = new MailAddress(text);
			mailMessage.To.Add(addresses);
			mailMessage.Subject = "Prueba Mail HERMES";
			mailMessage.Body = text2 + text3 + text4;
			mailMessage.IsBodyHtml = true;
			smtpClient.Send(mailMessage);
			Interaction.MsgBox("Correo enviado");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public static bool OpenEmail(string EmailAddress, string Subject = "", string Body = "")
	{
		bool result = true;
		string text = EmailAddress;
		if (Operators.CompareString(Strings.LCase(Strings.Left(text, 7)), "mailto:", TextCompare: true) != 0)
		{
			text = "mailto:" + text;
		}
		if (Operators.CompareString(Subject, "", TextCompare: true) != 0)
		{
			text = text + "?subject=" + Subject;
		}
		if (Operators.CompareString(Body, "", TextCompare: true) != 0)
		{
			text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Operators.CompareString(Subject, "", TextCompare: true) == 0, "?", "&")));
			text = text + "body=" + Body;
		}
		try
		{
			Process.Start(text);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
