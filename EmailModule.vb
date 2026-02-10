Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Net.Mail
Imports System.Reflection
Imports System.Threading
Imports System.Windows.Forms
Imports Datasoft_PIMS.My
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Datasoft_PIMS
	' Token: 0x0200002D RID: 45
	Friend NotInheritable Module EmailModule
		' Token: 0x06000B4A RID: 2890 RVA: 0x0006911C File Offset: 0x0006731C
		Public Sub SendEmail(sTo As String, sSubject As String, sBody As String, Optional CC As ArrayList = Nothing, Optional Attachments As ArrayList = Nothing)
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
			Dim flag As Boolean = Operators.CompareString(FeaturesVariables.gsEmail_Alert, "Yes", False) = 0
			If flag Then
				Dim mailMessage As MailMessage = New MailMessage()
				Dim smtpClient As SmtpClient = New SmtpClient()
				mailMessage.IsBodyHtml = True
				Dim flag2 As Boolean = Operators.CompareString(MySettingsProperty.Settings.sConfigMailHost, "Client", False) = 0
				Dim text As String
				Dim text2 As String
				If flag2 Then
					text = "notifications@immunoact.com"
					text2 = "hnzmkqxbtmkhhfyy"
					smtpClient.Host = "smtp.office365.com"
					smtpClient.Port = 587
					smtpClient.EnableSsl = True
				Else
					text = "datacode123@gmail.com"
					text2 = "vhfdudlxbqztxqme"
					smtpClient.Host = "smtp.gmail.com"
					smtpClient.Port = 587
					smtpClient.EnableSsl = True
				End If
				mailMessage.From = New MailAddress(text)
				mailMessage.[To].Add(New MailAddress(sTo))
				mailMessage.Subject = sSubject
				mailMessage.Body = sBody
				Dim flag3 As Boolean = CC IsNot Nothing
				If flag3 Then
					Dim num As Integer = CC.Count - 1
					For i As Integer = 0 To num
						Dim flag4 As Boolean = Operators.ConditionalCompareObjectNotEqual(CC(i), "", False)
						If flag4 Then
							mailMessage.CC.Add(New MailAddress(Conversions.ToString(CC(i))))
						End If
					Next
				End If
				Dim flag5 As Boolean = Attachments IsNot Nothing
				If flag5 Then
					Dim num2 As Integer = Attachments.Count - 1
					For j As Integer = 0 To num2
						Dim flag6 As Boolean = EmailModule.FileExists(Conversions.ToString(Attachments(j)))
						If flag6 Then
							Dim attachment As Attachment = New Attachment(Conversions.ToString(Attachments(j)))
							mailMessage.Attachments.Add(attachment)
						End If
					Next
				End If
				smtpClient.Credentials = New NetworkCredential(text, text2)
				smtpClient.Send(mailMessage)
			End If
		End Sub

		' Token: 0x06000B4B RID: 2891 RVA: 0x000692F0 File Offset: 0x000674F0
		Private Function FileExists(FileFullPath As String) As Boolean
			Dim flag As Boolean = Operators.CompareString(Strings.Trim(FileFullPath), "", False) = 0
			Return Not flag AndAlso File.Exists(FileFullPath)
		End Function

		' Token: 0x06000B4C RID: 2892 RVA: 0x00069324 File Offset: 0x00067524
		Private Sub SendEmail(arrTo As ArrayList, sSubject As String, sBody As String, Optional arrCC As ArrayList = Nothing, Optional Attachments As ArrayList = Nothing)
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
			Dim flag As Boolean = Operators.CompareString(FeaturesVariables.gsEmail_Alert, "Yes", False) = 0
			If flag Then
				Dim mailMessage As MailMessage = New MailMessage()
				Dim smtpClient As SmtpClient = New SmtpClient()
				smtpClient.UseDefaultCredentials = False
				Dim flag2 As Boolean = Operators.CompareString(MySettingsProperty.Settings.sConfigMailHost, "Client", False) = 0
				Dim text As String
				Dim text2 As String
				If flag2 Then
					text = "commercial.operations@immunoact.com"
					text2 = "wyqckqwqhzqdyzny"
					smtpClient.Host = "smtp.office365.com"
					smtpClient.Port = 587
					smtpClient.EnableSsl = True
				Else
					text = "datacode123@gmail.com"
					text2 = "vhfdudlxbqztxqme"
					smtpClient.Host = "smtp.gmail.com"
					smtpClient.Port = 587
					smtpClient.EnableSsl = True
				End If
				mailMessage.IsBodyHtml = True
				mailMessage.From = New MailAddress(text)
				mailMessage.Subject = sSubject
				mailMessage.Body = sBody
				Dim flag3 As Boolean = arrTo IsNot Nothing
				If flag3 Then
					Dim num As Integer = arrTo.Count - 1
					For i As Integer = 0 To num
						Dim flag4 As Boolean = Operators.ConditionalCompareObjectNotEqual(arrTo(i), "", False)
						If flag4 Then
							mailMessage.[To].Add(New MailAddress(Conversions.ToString(arrTo(i))))
						End If
					Next
				End If
				Dim flag5 As Boolean = arrCC IsNot Nothing
				If flag5 Then
					Dim num2 As Integer = arrCC.Count - 1
					For j As Integer = 0 To num2
						Dim flag6 As Boolean = Operators.ConditionalCompareObjectNotEqual(arrCC(j), "", False)
						If flag6 Then
							mailMessage.CC.Add(New MailAddress(Conversions.ToString(arrCC(j))))
						End If
					Next
				End If
				Dim flag7 As Boolean = Attachments IsNot Nothing
				If flag7 Then
					Dim num3 As Integer = Attachments.Count - 1
					For k As Integer = 0 To num3
						Dim flag8 As Boolean = EmailModule.FileExists(Conversions.ToString(Attachments(k)))
						If flag8 Then
							Dim attachment As Attachment = New Attachment(Conversions.ToString(Attachments(k)))
							mailMessage.Attachments.Add(attachment)
						End If
					Next
				End If
				smtpClient.Credentials = New NetworkCredential(text, text2)
				Dim flag9 As Boolean = False
				While Not flag9
					Try
						smtpClient.Send(mailMessage)
						flag9 = True
					Catch ex As Exception
						Dim text3 As String = "Check Your Internet Connection." & vbCrLf
						text3 = text3 + "Alert Failed : " + ex.Message + vbCrLf & vbCrLf
						text3 += "Do You Want To Retry..?"
						Thread.Sleep(2000)
						Dim flag10 As Boolean = CustomMsgBox.Show(text3, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = DialogResult.Yes
						flag9 = Not flag10
					End Try
				End While
			End If
		End Sub

		' Token: 0x06000B4D RID: 2893 RVA: 0x000695E8 File Offset: 0x000677E8
		Public Sub ConfigureEmailAlert(sFormat As String, sTrn As String, sSubject As String, sSalutations As String, sHeading As String, sTextLine1 As String, dt As DataTable, Optional sTo As String = "")
			Dim arrayList As ArrayList = New ArrayList()
			Dim arrayList2 As ArrayList = New ArrayList()
			Dim flag As Boolean = dt.Rows.Count = 0
			If Not flag Then
				Dim array As String() = Strings.Split(sTo, ":", -1, CompareMethod.Binary)
				Dim num As Short = CShort((array.Length - 1))
				For num2 As Short = 0S To num
					Dim flag2 As Boolean = Operators.CompareString(array(CInt(num2)).ToString(), "", False) <> 0
					If flag2 Then
						arrayList.Add(array(CInt(num2)).ToString())
					End If
				Next
				Dim text As String = " SELECT Transactions, AutoMailing, AddressType, EmailID  " & vbCrLf
				text += " FROM EmailSettings E LEFT OUTER JOIN EmailSettingsDtls ED ON E.EmailSettingsID = ED.EmailSettingsID  " & vbCrLf
				text = text + " WHERE Transactions = '" + sTrn + "' " & vbCrLf
				Dim data As DataTable = MainModule.GetData(text)
				Dim flag3 As Boolean = data.Rows.Count > 0
				If flag3 Then
					Dim num3 As Integer = data.Rows.Count - 1
					For i As Integer = 0 To num3
						Dim flag4 As Boolean = Operators.CompareString(data.Rows(i)("AddressType").ToString(), "To", False) = 0
						If flag4 Then
							arrayList.Add(data.Rows(i)("EmailID").ToString())
						Else
							Dim flag5 As Boolean = Operators.CompareString(data.Rows(i)("AddressType").ToString(), "CC", False) = 0
							If flag5 Then
								arrayList2.Add(data.Rows(i)("EmailID").ToString())
							End If
						End If
					Next
					Dim flag6 As Boolean = (arrayList.Count = 0) Or Not Conversions.ToBoolean(data.Rows(0)("AutoMailing").ToString())
					If Not flag6 Then
						Dim list As List(Of String) = arrayList.Cast().Distinct().ToList()
						arrayList.Clear()
						arrayList.AddRange(list)
						Dim executingAssembly As Assembly = Assembly.GetExecutingAssembly()
						Dim manifestResourceStream As Stream = executingAssembly.GetManifestResourceStream(sFormat)
						Dim flag7 As Boolean = Not Information.IsNothing(manifestResourceStream)
						If flag7 Then
							Dim text2 As String
							Using streamReader As StreamReader = New StreamReader(manifestResourceStream)
								text2 = streamReader.ReadToEnd()
							End Using
							Dim flag8 As Boolean = Operators.CompareString(sHeading, "", False) <> 0
							If flag8 Then
								text2 = Strings.Replace(text2, "@Heading", sHeading, 1, -1, CompareMethod.Binary)
							End If
							Dim flag9 As Boolean = Operators.CompareString(sSalutations, "", False) <> 0
							If flag9 Then
								text2 = Strings.Replace(text2, "@Salutations", sSalutations, 1, -1, CompareMethod.Binary)
							End If
							Dim flag10 As Boolean = Operators.CompareString(sTextLine1, "", False) <> 0
							If flag10 Then
								text2 = Strings.Replace(text2, "@TextLine1", sTextLine1, 1, -1, CompareMethod.Binary)
							End If
							If Operators.CompareString(sFormat, "Datasoft_PIMS.Standard.html", False) <> 0 Then
								If Operators.CompareString(sFormat, "Datasoft_PIMS.Binning.html", False) <> 0 Then
									If Operators.CompareString(sFormat, "Datasoft_PIMS.PRStatusUpdate.html", False) <> 0 Then
										If Operators.CompareString(sFormat, "Datasoft_PIMS.PRStatus.html", False) = 0 Then
											text2 = EmailModule.SetPRStatusBodyFields(text2, dt)
										End If
									Else
										text2 = EmailModule.SetPRStatusUpdateBodyFields(text2, dt)
									End If
								Else
									text2 = EmailModule.SetBinningBodyFields(text2, dt)
								End If
							Else
								text2 = EmailModule.SetBodyFields(text2, dt)
							End If
							EmailModule.SendEmail(arrayList, sSubject, text2, arrayList2, Nothing)
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x06000B4E RID: 2894 RVA: 0x00069944 File Offset: 0x00067B44
		Private Function SetBodyFields(sBody As String, dt As DataTable) As String
			Dim flag As Boolean = dt.Rows.Count > 0
			If flag Then
				Dim text As String = "<tr><td style=""height:20px;vertical-align:middle""></td><td>@FieldName</td><td></td><td>:</td><td></td><td>@FieldValue</td></tr>"
				Dim text2 As String = text
				Dim num As Integer = Strings.InStr(sBody, text, CompareMethod.Binary)
				Dim text3 As String = vbCrLf
				Dim num2 As Integer = dt.Columns.Count - 1
				For i As Integer = 0 To num2
					Dim text4 As String = Strings.Replace(text2, "@FieldName", dt.Columns(i).ColumnName.ToString(), 1, -1, CompareMethod.Binary)
					text4 = Strings.Replace(text4, "@FieldValue", dt.Rows(0)(i).ToString(), 1, -1, CompareMethod.Binary)
					text3 = text3 + text4 + vbCrLf
				Next
				sBody = Strings.Replace(sBody, text, text3, 1, -1, CompareMethod.Binary)
			End If
			Return sBody
		End Function

		' Token: 0x06000B4F RID: 2895 RVA: 0x00069A14 File Offset: 0x00067C14
		Private Function SetBinningBodyFields(sBody As String, dt As DataTable) As String
			Dim flag As Boolean = dt.Rows.Count > 0
			If flag Then
				Dim text As String = "<tr>" & vbCrLf
				text += "<td style=""border: thin solid #336699; background-color: #FFFFFF; padding-left: 4px;"">@FieldValue1</td>" & vbCrLf
				text += "<td style=""border: thin solid #336699; background-color: #FFFFFF; padding-left: 4px;"">@FieldValue2</td>" & vbCrLf
				text += "<td style=""border: thin solid #336699; background-color: #FFFFFF; padding-left: 4px;"">@FieldValue3</td>" & vbCrLf
				text += "<td style=""border: thin solid #336699; background-color: #FFFFFF; padding-left: 4px;"">@FieldValue4</td>" & vbCrLf
				text += "</tr>" & vbCrLf
				Dim num As Integer = Strings.InStr(sBody, text, CompareMethod.Binary)
				Dim text2 As String = vbCrLf
				Dim text3 As String = ""
				Dim num2 As Integer = dt.Rows.Count - 1
				For i As Integer = 0 To num2
					Dim text4 As String = Conversions.ToString(dt.Rows(i)("CatalogNo"))
					Dim text5 As String = Conversions.ToString(dt.Rows(i)("ProductBarcode"))
					Dim text6 As String = Conversions.ToString(dt.Rows(i)("OldLocationCode"))
					Dim text7 As String = Conversions.ToString(dt.Rows(i)("LocationCode"))
					text3 += "<tr>" & vbCrLf
					text3 = text3 + "<td style=""border: thin solid #336699; background-color: #FFFFFF; padding-left: 4px;"">" + text4 + "</td>" & vbCrLf
					text3 = text3 + "<td style=""border: thin solid #336699; background-color: #FFFFFF; padding-left: 4px;"">" + text5 + "</td>" & vbCrLf
					text3 = text3 + "<td style=""border: thin solid #336699; background-color: #FFFFFF; padding-left: 4px;"">" + text6 + "</td>" & vbCrLf
					text3 = text3 + "<td style=""border: thin solid #336699; background-color: #FFFFFF; padding-left: 4px;"">" + text7 + "</td>" & vbCrLf
					text3 += "</tr>"
					text2 = text2 + text3 + vbCrLf
				Next
				sBody = Strings.Replace(sBody, text, text2, 1, -1, CompareMethod.Binary)
			End If
			Return sBody
		End Function

		' Token: 0x06000B50 RID: 2896 RVA: 0x00069BB8 File Offset: 0x00067DB8
		Private Function SetPRStatusUpdateBodyFields(sBody As String, dt As DataTable) As String
			Dim flag As Boolean = dt.Rows.Count > 0
			If flag Then
				Dim text As String = "<tr>" & vbCrLf
				text += "<td style=""border: thin solid #336699; background-color: #FFFFFF; padding-left: 4px;"">@FieldValue1</td>" & vbCrLf
				text += "<td style=""border: thin solid #336699; background-color: #FFFFFF; padding-left: 4px;"">@FieldValue2</td>" & vbCrLf
				text += "<td style=""border: thin solid #336699; background-color: #FFFFFF; padding-left: 4px;"">@FieldValue3</td>" & vbCrLf
				text += "<td style=""border: thin solid #336699; background-color: #FFFFFF; padding-left: 4px;"">@FieldValue4</td>" & vbCrLf
				text += "</tr>" & vbCrLf
				Dim text2 As String = text
				Dim num As Integer = Strings.InStr(sBody, text, CompareMethod.Binary)
				Dim text3 As String = vbCrLf
				Dim num2 As Integer = dt.Rows.Count - 1
				For i As Integer = 0 To num2
					Dim text4 As String = Conversions.ToString(dt.Rows(i)("PRNo"))
					Dim text5 As String = Conversions.ToString(dt.Rows(i)("RequestedBy"))
					Dim text6 As String = Conversions.ToString(dt.Rows(i)("PONo"))
					Dim text7 As String = Conversions.ToString(dt.Rows(i)("Status"))
					Dim text8 As String = Strings.Replace(text2, "@FieldValue1", text4, 1, -1, CompareMethod.Binary)
					text8 = Strings.Replace(text8, "@FieldValue2", text5, 1, -1, CompareMethod.Binary)
					text8 = Strings.Replace(text8, "@FieldValue3", text6, 1, -1, CompareMethod.Binary)
					text8 = Strings.Replace(text8, "@FieldValue4", text7, 1, -1, CompareMethod.Binary)
					text3 = text3 + text8 + vbCrLf
				Next
				sBody = Strings.Replace(sBody, text, text3, 1, -1, CompareMethod.Binary)
			End If
			Return sBody
		End Function

		' Token: 0x06000B51 RID: 2897 RVA: 0x00069D40 File Offset: 0x00067F40
		Private Function SetPRStatusBodyFields(sBody As String, dt As DataTable) As String
			Dim flag As Boolean = dt.Rows.Count > 0
			If flag Then
				Dim text As String = "<tr>" & vbCrLf
				text += "<td style=""border: thin solid #336699; width: 120px; font-weight: bold; background-color: #336699; color: #FFFFFF; padding-left: 4px;"">@Column1</td>" & vbCrLf
				text += "</tr>" & vbCrLf
				Dim text2 As String = "<tr>" & vbCrLf
				text2 += "<td style=""border: thin solid #336699; background-color: #FFFFFF; padding-left: 4px;"">@FieldValue1</td>" & vbCrLf
				text2 += "</tr>" & vbCrLf
				Dim text3 As String = "<td style=""border: thin solid #336699; width: 120px; font-weight: bold; background-color: #336699; color: #FFFFFF; padding-left: 4px;"">@Column1</td>"
				Dim text4 As String = "<td style=""border: thin solid #336699; background-color: #FFFFFF; padding-left: 4px;"">@FieldValue1</td>"
				Dim text5 As String = "<tr>" & vbCrLf
				Dim num As Integer = dt.Columns.Count - 1
				For i As Integer = 0 To num
					text5 = text5 + Strings.Replace(text3, "@Column1", dt.Columns(i).ColumnName, 1, -1, CompareMethod.Binary) + vbCrLf
				Next
				text5 += "</tr>" & vbCrLf
				Dim text6 As String = ""
				Dim num2 As Integer = dt.Rows.Count - 1
				For j As Integer = 0 To num2
					text6 += "<tr>" & vbCrLf
					Dim num3 As Integer = dt.Columns.Count - 1
					For k As Integer = 0 To num3
						text6 = text6 + Strings.Replace(text4, "@FieldValue1", Conversions.ToString(dt.Rows(j)(k)), 1, -1, CompareMethod.Binary) + vbCrLf
					Next
					text6 += "</tr>" & vbCrLf
				Next
				sBody = Strings.Replace(sBody, text, text5, 1, -1, CompareMethod.Binary)
				sBody = Strings.Replace(sBody, text2, text6, 1, -1, CompareMethod.Binary)
			End If
			Return sBody
		End Function

		' Token: 0x06000B52 RID: 2898 RVA: 0x00069ED8 File Offset: 0x000680D8
		Public Sub SendMail(sTrn As String, sID As String, Optional sAction As String = "", Optional sTo As String = "")
			Try
				Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(sTrn)
				If num <= 2551315143UI Then
					If num <= 1139106643UI Then
						If num <= 435109060UI Then
							If num <= 157425306UI Then
								If num <> 150284158UI Then
									If num = 157425306UI Then
										If Operators.CompareString(sTrn, "GRN Modification", False) = 0 Then
											EmailModule.Send_GRNModification_MailAlert(sID, sTo)
										End If
									End If
								ElseIf Operators.CompareString(sTrn, "QA Release", False) = 0 Then
									EmailModule.Send_QARelease_MailAlert(sAction, sID, sTo)
								End If
							ElseIf num <> 364672065UI Then
								If num = 435109060UI Then
									If Operators.CompareString(sTrn, "PR Creation", False) = 0 Then
										EmailModule.Send_PRCreation_MailAlert(sID, sTo)
									End If
								End If
							ElseIf Operators.CompareString(sTrn, "Material Request", False) = 0 Then
								EmailModule.Send_MaterialRequest_MailAlert(sAction, sID, sTo)
							End If
						ElseIf num <= 903404742UI Then
							If num <> 490341950UI Then
								If num = 903404742UI Then
									If Operators.CompareString(sTrn, "PR Approval", False) = 0 Then
										EmailModule.Send_PRApproval_MailAlert(sAction, sID, sTo)
									End If
								End If
							ElseIf Operators.CompareString(sTrn, "PR Cancellation", False) = 0 Then
								EmailModule.Send_PRCancellation_MailAlert(sID, sTo)
							End If
						ElseIf num <> 1029369297UI Then
							If num = 1139106643UI Then
								If Operators.CompareString(sTrn, "PO Cancellation", False) = 0 Then
									EmailModule.Send_POCancellation_MailAlert(sID, sTo)
								End If
							End If
						ElseIf Operators.CompareString(sTrn, "PO Printing", False) = 0 Then
							EmailModule.Send_POPrinting_MailAlert(sID, sTo)
						End If
					ElseIf num <= 2081285115UI Then
						If num <= 1355220356UI Then
							If num <> 1222334419UI Then
								If num = 1355220356UI Then
									If Operators.CompareString(sTrn, "Vendor Database", False) = 0 Then
										EmailModule.Send_Vendor_MailAlert(sAction, sID)
									End If
								End If
							ElseIf Operators.CompareString(sTrn, "PO Approval", False) = 0 Then
								EmailModule.Send_POApproval_MailAlert(sAction, sID, sTo)
							End If
						ElseIf num <> 1775191613UI Then
							If num = 2081285115UI Then
								If Operators.CompareString(sTrn, "Material Issue", False) = 0 Then
									EmailModule.Send_MaterialIssue_MailAlert(sID, sTo)
								End If
							End If
						ElseIf Operators.CompareString(sTrn, "PR Modification", False) = 0 Then
							EmailModule.Send_PRModification_MailAlert(sID, sTo)
						End If
					ElseIf num <= 2444516107UI Then
						If num <> 2398361191UI Then
							If num = 2444516107UI Then
								If Operators.CompareString(sTrn, "PO Amendment", False) = 0 Then
									EmailModule.Send_POAmendment_MailAlert(sID, sTo)
								End If
							End If
						ElseIf Operators.CompareString(sTrn, "BOM Modification", False) = 0 Then
							EmailModule.Send_BOM_Modification_MailAlert(sID, sTo)
						End If
					ElseIf num <> 2458866757UI Then
						If num = 2551315143UI Then
							If Operators.CompareString(sTrn, "Material Picking", False) = 0 Then
								EmailModule.Send_MaterialPicking_MailAlert(sAction, sID, sTo)
							End If
						End If
					ElseIf Operators.CompareString(sTrn, "GRN Cancelled", False) = 0 Then
						EmailModule.Send_GRNCancelled_MailAlert(sAction, sID, sTo)
					End If
				ElseIf num <= 3611093083UI Then
					If num <= 2924031041UI Then
						If num <= 2577931921UI Then
							If num <> 2556391593UI Then
								If num = 2577931921UI Then
									If Operators.CompareString(sTrn, "QC Entry", False) = 0 Then
										EmailModule.Send_QCEntry_MailAlert(sID, sTo)
									End If
								End If
							ElseIf Operators.CompareString(sTrn, "PO Creation", False) = 0 Then
								EmailModule.Send_POCreation_MailAlert(sID, sTo)
							End If
						ElseIf num <> 2901430534UI Then
							If num = 2924031041UI Then
								If Operators.CompareString(sTrn, "GRN Approval", False) = 0 Then
									EmailModule.Send_GRNApproval_MailAlert(sAction, sID, sTo)
								End If
							End If
						ElseIf Operators.CompareString(sTrn, "Dispose", False) = 0 Then
							EmailModule.Send_ProductDispose_MailAlert(sAction, sID, sTo)
						End If
					ElseIf num <= 3244383850UI Then
						If num <> 3101945593UI Then
							If num = 3244383850UI Then
								If Operators.CompareString(sTrn, "BOM Creation", False) = 0 Then
									EmailModule.Send_BOM_Creation_MailAlert(sID, sTo)
								End If
							End If
						ElseIf Operators.CompareString(sTrn, "Product Database", False) = 0 Then
							EmailModule.Send_Product_MailAlert(sAction, sID)
						End If
					ElseIf num <> 3529496940UI Then
						If num = 3611093083UI Then
							If Operators.CompareString(sTrn, "User Database", False) = 0 Then
								EmailModule.Send_User_MailAlert(sAction, sID)
							End If
						End If
					ElseIf Operators.CompareString(sTrn, "PO Modification", False) = 0 Then
						EmailModule.Send_POModification_MailAlert(sID, sTo)
					End If
				ElseIf num <= 3851013900UI Then
					If num <= 3662844576UI Then
						If num <> 3618005290UI Then
							If num = 3662844576UI Then
								If Operators.CompareString(sTrn, "New User", False) = 0 Then
									EmailModule.Send_NewUser_MailAlert(sID, sTo)
								End If
							End If
						ElseIf Operators.CompareString(sTrn, "GRN Entry", False) = 0 Then
							EmailModule.Send_GRNEntry_MailAlert(sID, sTo)
						End If
					ElseIf num <> 3748351800UI Then
						If num = 3851013900UI Then
							If Operators.CompareString(sTrn, "QC Release", False) = 0 Then
								EmailModule.Send_QCRelease_MailAlert(sAction, sID, sTo)
							End If
						End If
					ElseIf Operators.CompareString(sTrn, "Binning", False) <> 0 Then
					End If
				ElseIf num <= 3965349392UI Then
					If num <> 3950635596UI Then
						If num = 3965349392UI Then
							If Operators.CompareString(sTrn, "BOM Approval", False) = 0 Then
								EmailModule.Send_BOM_Approval_MailAlert(sAction, sID, sTo)
							End If
						End If
					ElseIf Operators.CompareString(sTrn, "PR Status Update", False) <> 0 Then
					End If
				ElseIf num <> 4189533819UI Then
					If num = 4276050529UI Then
						If Operators.CompareString(sTrn, "Picking QA Approval", False) = 0 Then
							EmailModule.Send_PickingApproval_MailAlert(sAction, sID, sTo)
						End If
					End If
				ElseIf Operators.CompareString(sTrn, "PR Cost Approval", False) = 0 Then
					EmailModule.Send_PRCost_Approval_MailAlert(sAction, sID, sTo)
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06000B53 RID: 2899 RVA: 0x0006A5E4 File Offset: 0x000687E4
		Private Sub Send_Product_MailAlert(sAction As String, sID As String)
			Dim flag As Boolean = Operators.CompareString(sID, "", False) <> 0
			If flag Then
				Dim text As String = ""
				Dim text2 As String = ""
				Dim text3 As String = ""
				Dim text4 As String = ""
				Dim text5 As String = "Datasoft_PIMS.Standard.html"
				Dim text6 As String = "Product Database"
				If Operators.CompareString(sAction, "Created", False) <> 0 Then
					If Operators.CompareString(sAction, "Modified", False) <> 0 Then
						If Operators.CompareString(sAction, "QA Approved", False) = 0 Then
							text = "Alert : A Product Entry Is QA Approved"
							text2 = "Dear User"
							text3 = "PRODUCT IS QA APPROVED"
							text4 = "A product entry is QA approved." & vbCrLf
						End If
					Else
						text = "Alert : A Product Entry Is Modified"
						text2 = "Dear User"
						text3 = "PRODUCT MODIFIED"
						text4 = "A product entry is modified." & vbCrLf
					End If
				Else
					text = "Alert : A Product Entry Is Created"
					text2 = "Dear User"
					text3 = "PRODUCT CREATED"
					text4 = "A product entry is created." & vbCrLf
				End If
				Dim text7 As String = String.Concat(New String() { " EXEC usp_MailAlert '", text6, "', '", sAction, "', '", sID, "'" })
				Dim data As DataTable = MainModule.GetData(text7)
				EmailModule.ConfigureEmailAlert(text5, text6, text, text2, text3, text4, data, "")
			End If
		End Sub

		' Token: 0x06000B54 RID: 2900 RVA: 0x0006A718 File Offset: 0x00068918
		Private Sub Send_Vendor_MailAlert(sAction As String, sID As String)
			Dim flag As Boolean = Operators.CompareString(sID, "", False) <> 0
			If flag Then
				Dim text As String = "Datasoft_PIMS.Standard.html"
				Dim text2 As String = "Vendor Database"
				Dim flag2 As Boolean = Operators.CompareString(sAction, "Created", False) = 0
				Dim text3 As String
				Dim text4 As String
				Dim text5 As String
				Dim text6 As String
				If flag2 Then
					text3 = "Alert : A Vendor Entry Is Created"
					text4 = "Dear User"
					text5 = "VENDOR CREATED"
					text6 = "A vendor entry is created." & vbCrLf
				Else
					text3 = "Alert : A Vendor Entry Is Modified"
					text4 = "Dear User"
					text5 = "VENDOR MODIFIED"
					text6 = "A vendor entry is modified." & vbCrLf
				End If
				Dim text7 As String = String.Concat(New String() { " EXEC usp_MailAlert '", text2, "', '", sAction, "', '", sID, "'" })
				Dim data As DataTable = MainModule.GetData(text7)
				EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, data, "")
			End If
		End Sub

		' Token: 0x06000B55 RID: 2901 RVA: 0x0006A7F4 File Offset: 0x000689F4
		Private Sub Send_User_MailAlert(sAction As String, sID As String)
			Dim flag As Boolean = Operators.CompareString(sID, "", False) <> 0
			If flag Then
				Dim text As String = "Datasoft_PIMS.Standard.html"
				Dim text2 As String = "User Database"
				Dim flag2 As Boolean = Operators.CompareString(sAction, "Created", False) = 0
				Dim text3 As String
				Dim text4 As String
				Dim text5 As String
				Dim text6 As String
				If flag2 Then
					text3 = "Alert : A User Entry Is Created"
					text4 = "Dear User"
					text5 = "LOGIN USER CREATED"
					text6 = "A login user is created." & vbCrLf
				Else
					text3 = "Alert : A User Entry Is Modified"
					text4 = "Dear User"
					text5 = "LOGIN USER MODIFIED"
					text6 = "A login user is modified." & vbCrLf
				End If
				Dim text7 As String = String.Concat(New String() { " EXEC usp_MailAlert '", text2, "', '", sAction, "', '", sID, "'" })
				Dim data As DataTable = MainModule.GetData(text7)
				EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, data, "")
			End If
		End Sub

		' Token: 0x06000B56 RID: 2902 RVA: 0x0006A8D0 File Offset: 0x00068AD0
		Private Sub Send_NewUser_MailAlert(sID As String, sTo As String)
			Dim flag As Boolean = Operators.CompareString(sID, "", False) <> 0
			If flag Then
				Dim text As String = "DatasoftBPMS.Standard.html"
				Dim text2 As String = "New User"
				Dim text3 As String = "Alert : A New User Is Created"
				Dim text4 As String = "Dear User"
				Dim text5 As String = "NEW LOGIN USER"
				Dim text6 As String = "A new login user is created for you." & vbCrLf
				text6 += "You must change your password at your first login."
				Dim text7 As String = String.Concat(New String() { " EXEC usp_MailAlert '", text2, "', '', '", sID, "'" })
				Dim data As DataTable = MainModule.GetData(text7)
				data.Rows(0)("Password") = MainModule.DecryptData(Conversions.ToString(data.Rows(0)("Password")), GlobalVariables.gsPwd)
				EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, data, sTo)
			End If
		End Sub

		' Token: 0x06000B57 RID: 2903 RVA: 0x0006A9B4 File Offset: 0x00068BB4
		Private Sub Send_BOM_Creation_MailAlert(sID As String, Optional sTo As String = "")
			Dim text As String = "Datasoft_PIMS.Standard.html"
			Dim text2 As String = "BOM Creation"
			Dim text3 As String = "Alert : A Product BOM Entry Is Created"
			Dim text4 As String = "Dear User"
			Dim text5 As String = "BOM CREATED"
			Dim text6 As String = "A product BOM entry is created." & vbCrLf
			Dim text7 As String = String.Concat(New String() { " EXEC usp_MailAlert '", text2, "', '', '", sID, "'" })
			Dim data As DataTable = MainModule.GetData(text7)
			EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, data, sTo)
		End Sub

		' Token: 0x06000B58 RID: 2904 RVA: 0x0006AA30 File Offset: 0x00068C30
		Private Sub Send_BOM_Modification_MailAlert(sID As String, Optional sTo As String = "")
			Dim text As String = "Datasoft_PIMS.Standard.html"
			Dim text2 As String = "BOM Modification"
			Dim text3 As String = "Alert : A Product BOM Entry Is Modified"
			Dim text4 As String = "Dear User"
			Dim text5 As String = "BOM MODIFIED"
			Dim text6 As String = "A product BOM entry is modified." & vbCrLf
			Dim text7 As String = String.Concat(New String() { " EXEC usp_MailAlert '", text2, "', '', '", sID, "'" })
			Dim data As DataTable = MainModule.GetData(text7)
			EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, data, sTo)
		End Sub

		' Token: 0x06000B59 RID: 2905 RVA: 0x0006AAAC File Offset: 0x00068CAC
		Private Sub Send_BOM_Approval_MailAlert(sAction As String, sID As String, Optional sTo As String = "")
			Dim text As String = "Datasoft_PIMS.Standard.html"
			Dim text2 As String = "BOM Approval"
			Dim text3 As String = "Alert : A Product BOM Entry Is " + sAction
			Dim text4 As String = "Dear User"
			Dim text5 As String = "BOM APPROVAL"
			Dim text6 As String = "A product BOM entry is " + sAction.ToLower() + "." & vbCrLf
			Dim text7 As String = String.Concat(New String() { " EXEC usp_MailAlert '", text2, "', '", sAction, "', '", sID, "'" })
			Dim data As DataTable = MainModule.GetData(text7)
			EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, data, sTo)
		End Sub

		' Token: 0x06000B5A RID: 2906 RVA: 0x0006AB4C File Offset: 0x00068D4C
		Private Sub Send_PRCreation_MailAlert(sID As String, Optional sTo As String = "")
			Dim text As String = "Datasoft_PIMS.Standard.html"
			Dim text2 As String = "PR Creation"
			Dim text3 As String = "Alert : A Purchase Requisition Entry Is Created"
			Dim text4 As String = "Dear User"
			Dim text5 As String = "PR CREATED"
			Dim text6 As String = "A purchase requisition entry is created." & vbCrLf
			Dim text7 As String = String.Concat(New String() { " EXEC usp_MailAlert '", text2, "', '', '", sID, "'" })
			Dim data As DataTable = MainModule.GetData(text7)
			EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, data, sTo)
		End Sub

		' Token: 0x06000B5B RID: 2907 RVA: 0x0006ABC8 File Offset: 0x00068DC8
		Private Sub Send_PRModification_MailAlert(sID As String, Optional sTo As String = "")
			Dim text As String = "Datasoft_PIMS.Standard.html"
			Dim text2 As String = "PR Modification"
			Dim text3 As String = "Alert : A Purchase Requisition Entry Is Modified"
			Dim text4 As String = "Dear User"
			Dim text5 As String = "PR MODIFIED"
			Dim text6 As String = "A purchase requisition entry is modified." & vbCrLf
			Dim text7 As String = String.Concat(New String() { " EXEC usp_MailAlert '", text2, "', '', '", sID, "'" })
			Dim data As DataTable = MainModule.GetData(text7)
			EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, data, sTo)
		End Sub

		' Token: 0x06000B5C RID: 2908 RVA: 0x0006AC44 File Offset: 0x00068E44
		Private Sub Send_PRCancellation_MailAlert(sID As String, Optional sTo As String = "")
			Dim text As String = "Datasoft_PIMS.Standard.html"
			Dim text2 As String = "PR Cancellation"
			Dim text3 As String = "Alert : A Purchase Requisition Is Cancelled"
			Dim text4 As String = "Dear User"
			Dim text5 As String = "PR CANCELLATION"
			Dim text6 As String = "A purchase requisition entry is cancelled." & vbCrLf
			Dim text7 As String = String.Concat(New String() { " EXEC usp_MailAlert '", text2, "', '', '", sID, "'" })
			Dim data As DataTable = MainModule.GetData(text7)
			EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, data, sTo)
		End Sub

		' Token: 0x06000B5D RID: 2909 RVA: 0x0006ACC0 File Offset: 0x00068EC0
		Private Sub Send_PRApproval_MailAlert(sAction As String, sID As String, Optional sTo As String = "")
			Dim text As String = "Datasoft_PIMS.Standard.html"
			Dim text2 As String = "PR Approval"
			Dim text3 As String = "Alert : A Purchase Requisition Entry Is " + sAction
			Dim text4 As String = "Dear User"
			Dim text5 As String = "PR APPROVAL"
			Dim text6 As String = "A purchase requisition entry is " + sAction.ToLower() + "." & vbCrLf
			Dim text7 As String = String.Concat(New String() { " EXEC usp_MailAlert '", text2, "', '", sAction, "', '", sID, "'" })
			Dim data As DataTable = MainModule.GetData(text7)
			EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, data, sTo)
		End Sub

		' Token: 0x06000B5E RID: 2910 RVA: 0x0006AD60 File Offset: 0x00068F60
		Private Sub Send_PRCost_Approval_MailAlert(sAction As String, sID As String, Optional sTo As String = "")
			Dim text As String = "Datasoft_PIMS.Standard.html"
			Dim text2 As String = "PR Cost Approval"
			Dim text3 As String = "Alert : A Purchase Requisition Entry Is " + sAction
			Dim text4 As String = "Dear User"
			Dim text5 As String = "PR COST APPROVAL"
			Dim text6 As String = "A purchase requisition entry is " + sAction.ToLower() + "." & vbCrLf
			Dim text7 As String = String.Concat(New String() { " EXEC usp_MailAlert '", text2, "', '", sAction, "', '", sID, "'" })
			Dim data As DataTable = MainModule.GetData(text7)
			EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, data, sTo)
		End Sub

		' Token: 0x06000B5F RID: 2911 RVA: 0x0006AE00 File Offset: 0x00069000
		Private Sub Send_POCreation_MailAlert(sID As String, Optional sTo As String = "")
			Dim text As String = "Datasoft_PIMS.Standard.html"
			Dim text2 As String = "PO Creation"
			Dim text3 As String = "Alert : A Purchase Order Entry Is Created"
			Dim text4 As String = "Dear User"
			Dim text5 As String = "PO CREATED"
			Dim text6 As String = "A purchase order entry is created." & vbCrLf
			Dim text7 As String = String.Concat(New String() { " EXEC usp_MailAlert '", text2, "', '', '", sID, "'" })
			Dim data As DataTable = MainModule.GetData(text7)
			EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, data, sTo)
		End Sub

		' Token: 0x06000B60 RID: 2912 RVA: 0x0006AE7C File Offset: 0x0006907C
		Private Sub Send_POModification_MailAlert(sID As String, Optional sTo As String = "")
			Dim text As String = "Datasoft_PIMS.Standard.html"
			Dim text2 As String = "PO Modification"
			Dim text3 As String = "Alert : A Purchase Order Entry Is Modified"
			Dim text4 As String = "Dear User"
			Dim text5 As String = "PO MODIFIED"
			Dim text6 As String = "A purchase order entry is modified." & vbCrLf
			Dim text7 As String = String.Concat(New String() { " EXEC usp_MailAlert '", text2, "', '', '", sID, "'" })
			Dim data As DataTable = MainModule.GetData(text7)
			EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, data, sTo)
		End Sub

		' Token: 0x06000B61 RID: 2913 RVA: 0x0006AEF8 File Offset: 0x000690F8
		Private Sub Send_POCancellation_MailAlert(sID As String, Optional sTo As String = "")
			Dim text As String = "Datasoft_PIMS.Standard.html"
			Dim text2 As String = "PO Cancellation"
			Dim text3 As String = "Alert : A Purchase Order Is Cancelled"
			Dim text4 As String = "Dear User"
			Dim text5 As String = "PO CANCELLATION"
			Dim text6 As String = "A purchase order entry is cancelled." & vbCrLf
			Dim text7 As String = String.Concat(New String() { " EXEC usp_MailAlert '", text2, "', '', '", sID, "'" })
			Dim data As DataTable = MainModule.GetData(text7)
			EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, data, sTo)
		End Sub

		' Token: 0x06000B62 RID: 2914 RVA: 0x0006AF74 File Offset: 0x00069174
		Private Sub Send_POApproval_MailAlert(sAction As String, sID As String, Optional sTo As String = "")
			Dim text As String = "Datasoft_PIMS.Standard.html"
			Dim text2 As String = "PO Approval"
			Dim text3 As String = "Alert : A Purchase Order Entry Is " + sAction
			Dim text4 As String = "Dear User"
			Dim text5 As String = "PO APPROVAL"
			Dim text6 As String = "A purchase order entry is " + sAction.ToLower() + "." & vbCrLf
			Dim text7 As String = String.Concat(New String() { " EXEC usp_MailAlert '", text2, "', '", sAction, "', '", sID, "'" })
			Dim data As DataTable = MainModule.GetData(text7)
			EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, data, sTo)
		End Sub

		' Token: 0x06000B63 RID: 2915 RVA: 0x0006B014 File Offset: 0x00069214
		Private Sub Send_POPrinting_MailAlert(sID As String, Optional sTo As String = "")
			Dim text As String = "Datasoft_PIMS.Standard.html"
			Dim text2 As String = "PO Printing"
			Dim text3 As String = "Alert : A Purchase Order Is Printed"
			Dim text4 As String = "Dear User"
			Dim text5 As String = "PO PRINTING"
			Dim text6 As String = "A purchase order is printed." & vbCrLf
			Dim text7 As String = String.Concat(New String() { " EXEC usp_MailAlert '", text2, "', '', '", sID, "'" })
			Dim data As DataTable = MainModule.GetData(text7)
			EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, data, sTo)
		End Sub

		' Token: 0x06000B64 RID: 2916 RVA: 0x0006B090 File Offset: 0x00069290
		Private Sub Send_POAmendment_MailAlert(sID As String, Optional sTo As String = "")
			Dim text As String = "Datasoft_PIMS.Standard.html"
			Dim text2 As String = "PO Amendment"
			Dim text3 As String = "Alert : A Purchase Order Entry Is Amended"
			Dim text4 As String = "Dear User"
			Dim text5 As String = "PO AMENDMENT"
			Dim text6 As String = "A purchase order entry is amended." & vbCrLf
			Dim text7 As String = String.Concat(New String() { " EXEC usp_MailAlert '", text2, "', '', '", sID, "'" })
			Dim data As DataTable = MainModule.GetData(text7)
			EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, data, sTo)
		End Sub

		' Token: 0x06000B65 RID: 2917 RVA: 0x0006B10C File Offset: 0x0006930C
		Private Sub Send_GRNEntry_MailAlert(sID As String, Optional sTo As String = "")
			Dim text As String = "Datasoft_PIMS.Standard.html"
			Dim text2 As String = "GRN Entry"
			Dim text3 As String = "Alert : A GRN Entry Is Created"
			Dim text4 As String = "Dear User"
			Dim text5 As String = "GRN ENTRY"
			Dim text6 As String = "A GRN entry is created." & vbCrLf
			Dim text7 As String = String.Concat(New String() { " EXEC usp_MailAlert '", text2, "', '', '", sID, "'" })
			Dim data As DataTable = MainModule.GetData(text7)
			EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, data, sTo)
		End Sub

		' Token: 0x06000B66 RID: 2918 RVA: 0x0006B188 File Offset: 0x00069388
		Private Sub Send_GRNModification_MailAlert(sID As String, Optional sTo As String = "")
			Dim text As String = "Datasoft_PIMS.Standard.html"
			Dim text2 As String = "GRN Modification"
			Dim text3 As String = "Alert : A GRN Entry Is Modified"
			Dim text4 As String = "Dear User"
			Dim text5 As String = "GRN MODIFICATION"
			Dim text6 As String = "A GRN entry is modified." & vbCrLf
			Dim text7 As String = String.Concat(New String() { " EXEC usp_MailAlert '", text2, "', '', '", sID, "'" })
			Dim data As DataTable = MainModule.GetData(text7)
			EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, data, sTo)
		End Sub

		' Token: 0x06000B67 RID: 2919 RVA: 0x0006B204 File Offset: 0x00069404
		Private Sub Send_GRNApproval_MailAlert(sAction As String, sID As String, Optional sTo As String = "")
			Dim text As String = "Datasoft_PIMS.Standard.html"
			Dim text2 As String = "GRN Approval"
			Dim text3 As String = "Alert : A GRN Entry Is " + sAction
			Dim text4 As String = "Dear User"
			Dim text5 As String = "GRN APPROVAL"
			Dim text6 As String = "A GRN entry is " + sAction.ToLower() + "." & vbCrLf
			Dim text7 As String = String.Concat(New String() { " EXEC usp_MailAlert '", text2, "', '", sAction, "', '", sID, "'" })
			Dim data As DataTable = MainModule.GetData(text7)
			EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, data, sTo)
		End Sub

		' Token: 0x06000B68 RID: 2920 RVA: 0x0006B2A4 File Offset: 0x000694A4
		Private Sub Send_GRNCancelled_MailAlert(sAction As String, sID As String, Optional sTo As String = "")
			Dim text As String = "Datasoft_PIMS.Standard.html"
			Dim text2 As String = "GRN Cancelled"
			Dim text3 As String = "Alert : A GRN Entry Is " + sAction
			Dim text4 As String = "Dear User"
			Dim text5 As String = "GRN CANCELLATION"
			Dim text6 As String = "A GRN entry is " + sAction.ToLower() + "." & vbCrLf
			Dim text7 As String = String.Concat(New String() { " EXEC usp_MailAlert '", text2, "', '", sAction, "', '", sID, "'" })
			Dim data As DataTable = MainModule.GetData(text7)
			EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, data, sTo)
		End Sub

		' Token: 0x06000B69 RID: 2921 RVA: 0x0006B344 File Offset: 0x00069544
		Private Sub Send_QCEntry_MailAlert(sID As String, Optional sTo As String = "")
			Dim text As String = "Datasoft_PIMS.Standard.html"
			Dim text2 As String = "QC Entry"
			Dim text3 As String = "Alert : A QC Entry Is Created"
			Dim text4 As String = "Dear User"
			Dim text5 As String = "QC ENTRY"
			Dim text6 As String = "A QC entry is created." & vbCrLf
			Dim text7 As String = String.Concat(New String() { " EXEC usp_MailAlert '", text2, "', '', '", sID, "'" })
			Dim data As DataTable = MainModule.GetData(text7)
			EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, data, sTo)
		End Sub

		' Token: 0x06000B6A RID: 2922 RVA: 0x0006B3C0 File Offset: 0x000695C0
		Private Sub Send_QCRelease_MailAlert(sAction As String, sID As String, Optional sTo As String = "")
			Dim text As String = "Datasoft_PIMS.Standard.html"
			Dim text2 As String = "QC Release"
			Dim text3 As String = "Alert : A QC Entry Is " + sAction
			Dim text4 As String = "Dear User"
			Dim text5 As String = "QC RELEASE"
			Dim text6 As String = "A QC entry is " + sAction.ToLower() + "." & vbCrLf
			Dim text7 As String = String.Concat(New String() { " EXEC usp_MailAlert '", text2, "', '", sAction, "', '", sID, "'" })
			Dim data As DataTable = MainModule.GetData(text7)
			EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, data, sTo)
		End Sub

		' Token: 0x06000B6B RID: 2923 RVA: 0x0006B460 File Offset: 0x00069660
		Private Sub Send_QARelease_MailAlert(sAction As String, sID As String, Optional sTo As String = "")
			Dim text As String = "Datasoft_PIMS.Standard.html"
			Dim text2 As String = "QA Release"
			Dim text3 As String = "Alert : A QA Entry Is " + sAction
			Dim text4 As String = "Dear User"
			Dim text5 As String = "QA RELEASE"
			Dim text6 As String = "A QA entry is " + sAction.ToLower() + "." & vbCrLf
			Dim text7 As String = String.Concat(New String() { " EXEC usp_MailAlert '", text2, "', '", sAction, "', '", sID, "'" })
			Dim data As DataTable = MainModule.GetData(text7)
			EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, data, sTo)
		End Sub

		' Token: 0x06000B6C RID: 2924 RVA: 0x0006B500 File Offset: 0x00069700
		Private Sub Send_MaterialRequest_MailAlert(sAction As String, sID As String, Optional sTo As String = "")
			Dim flag As Boolean = Operators.CompareString(sID, "", False) <> 0
			If flag Then
				Dim text As String = "Datasoft_PIMS.Standard.html"
				Dim text2 As String = "Material Request"
				Dim flag2 As Boolean = Operators.CompareString(sAction, "Created", False) = 0
				Dim text3 As String
				Dim text4 As String
				Dim text5 As String
				Dim text6 As String
				If flag2 Then
					text3 = "Alert : A Material Request Is Created"
					text4 = "Dear User"
					text5 = "MATERIAL REQUEST CREATED"
					text6 = "A material request is created." & vbCrLf
				Else
					text3 = "Alert : A Material Request Is Modified"
					text4 = "Dear User"
					text5 = "MATERIAL REQUEST MODIFIED"
					text6 = "A material request is modified." & vbCrLf
				End If
				Dim text7 As String = String.Concat(New String() { " EXEC usp_MailAlert '", text2, "', '", sAction, "', '", sID, "'" })
				Dim data As DataTable = MainModule.GetData(text7)
				EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, data, sTo)
			End If
		End Sub

		' Token: 0x06000B6D RID: 2925 RVA: 0x0006B5D8 File Offset: 0x000697D8
		Private Sub Send_MaterialPicking_MailAlert(sAction As String, sID As String, Optional sTo As String = "")
			Dim text As String = "Datasoft_PIMS.Standard.html"
			Dim text2 As String = "Material Picking"
			Dim flag As Boolean = Operators.CompareString(sAction, "Picked", False) = 0
			Dim text3 As String
			Dim text4 As String
			Dim text5 As String
			Dim text6 As String
			If flag Then
				text3 = "Alert : Material Is Picked Against A Request"
				text4 = "Dear User"
				text5 = "MATERIAL PICKING"
				text6 = "Material is picked against a request." & vbCrLf
			Else
				text3 = "Alert : A Material Picked Is Cancelled"
				text4 = "Dear User"
				text5 = "MATERIAL PICKING CANCELLED"
				text6 = "A material picked is cancelled." & vbCrLf
			End If
			Dim text7 As String = String.Concat(New String() { " EXEC usp_MailAlert '", text2, "', '", sAction, "', '", sID, "'" })
			Dim data As DataTable = MainModule.GetData(text7)
			EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, data, sTo)
		End Sub

		' Token: 0x06000B6E RID: 2926 RVA: 0x0006B694 File Offset: 0x00069894
		Private Sub Send_PickingApproval_MailAlert(sAction As String, sID As String, Optional sTo As String = "")
			Dim text As String = "Datasoft_PIMS.Standard.html"
			Dim text2 As String = "Picking QA Approval"
			Dim text3 As String = "Alert : A Picking Entry Is " + sAction
			Dim text4 As String = "Dear User"
			Dim text5 As String = "PICING QA APPROVAL"
			Dim text6 As String = "A picking entry is " + sAction.ToLower() + "." & vbCrLf
			Dim text7 As String = String.Concat(New String() { " EXEC usp_MailAlert '", text2, "', '", sAction, "', '", sID, "'" })
			Dim data As DataTable = MainModule.GetData(text7)
			EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, data, sTo)
		End Sub

		' Token: 0x06000B6F RID: 2927 RVA: 0x0006B734 File Offset: 0x00069934
		Private Sub Send_MaterialIssue_MailAlert(sID As String, Optional sTo As String = "")
			Dim text As String = "Datasoft_PIMS.Standard.html"
			Dim text2 As String = "Material Issue"
			Dim text3 As String = "Alert : A Material Issue Entry Is Executed"
			Dim text4 As String = "Dear User"
			Dim text5 As String = "MATERIAL ISSUE"
			Dim text6 As String = "A material issue entry is executed." & vbCrLf
			Dim text7 As String = String.Concat(New String() { " EXEC usp_MailAlert '", text2, "', '', '", sID, "'" })
			Dim data As DataTable = MainModule.GetData(text7)
			EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, data, sTo)
		End Sub

		' Token: 0x06000B70 RID: 2928 RVA: 0x0006B7B0 File Offset: 0x000699B0
		Private Sub Send_ProductDispose_MailAlert(sAction As String, sID As String, Optional sTo As String = "")
			Dim text As String = "Datasoft_PIMS.Standard.html"
			Dim text2 As String = "Dispose"
			Dim text3 As String = "Alert : Product Barcode(s) Are Disposed"
			Dim text4 As String = "Dear User"
			Dim text5 As String = "PRODUCT DISPOSE"
			Dim text6 As String = "Product barcode(s) are disposed." & vbCrLf
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("Disposed By")
			dataTable.Columns.Add("Disposed Date")
			dataTable.Columns.Add("Disposed Remarks")
			dataTable.Columns.Add("UID List")
			dataTable.Rows.Add(New Object(-1) {})
			dataTable.Rows(0)("Disposed By") = GlobalVariables.gsUserName + "/ " + GlobalVariables.gsLoginID
			dataTable.Rows(0)("Disposed Date") = Strings.Format(MainModule.GetServerDate(), "dd-MMM-yyyy")
			dataTable.Rows(0)("Disposed Remarks") = sAction
			dataTable.Rows(0)("UID List") = sID
			EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, dataTable, sTo)
		End Sub

		' Token: 0x06000B71 RID: 2929 RVA: 0x0006B8E4 File Offset: 0x00069AE4
		Public Sub Send_Binning_MailAlert(dt As DataTable, Optional sTo As String = "")
			Dim text As String = "Datasoft_PIMS.Binning.html"
			Dim text2 As String = "Location Mapping"
			Dim text3 As String = "Alert : Product Location Changed"
			Dim text4 As String = "Dear User"
			Dim text5 As String = "LOCATION CHANGED"
			Dim text6 As String = "There is a change in location of product UID(s)." & vbCrLf
			EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, dt, sTo)
		End Sub

		' Token: 0x06000B72 RID: 2930 RVA: 0x0006B928 File Offset: 0x00069B28
		Public Sub Send_PR_Status_PO_MailAlert(sPOID As String, sType As String, Optional sTo As String = "")
			Dim text As String = "Datasoft_PIMS.PRStatusUpdate.html"
			Dim text2 As String = "PR Status Update"
			Dim text3 As String = "Alert : PR Status Update"
			Dim text4 As String = "Dear User"
			Dim text5 As String = "PR STATUS UPDATE"
			Dim data As DataTable
			Dim text7 As String
			If Operators.CompareString(sType, "PO", False) = 0 Then
				Dim text6 As String = " SELECT P.PRNo, Req.UserName AS RequestedBy, Req.EmailID RequestedByEmailID, PO.PONo, PO.Status " & vbCrLf
				text6 += " FROM PR AS P " & vbCrLf
				text6 += " INNER JOIN POPR ON P.PRID = POPR.PRID " & vbCrLf
				text6 += " INNER JOIN PO ON POPR.POID = PO.POID " & vbCrLf
				text6 += " INNER JOIN [User] AS Req ON P.RequestedBy = Req.UserID " & vbCrLf
				text6 = text6 + " WHERE POPR.POID = '" + sPOID + "' " & vbCrLf
				data = MainModule.GetData(text6)
				Dim flag As Boolean = data.Rows.Count > 0
				If Not flag Then
					Return
				End If
				text7 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("A PO has been ", data.Rows(0)("Status")), " against your PR."), vbCrLf))
			End If
			Dim num As Integer = data.Rows.Count - 1
			For i As Integer = 0 To num
				Dim flag2 As Boolean = Operators.CompareString(sTo, "", False) = 0
				If flag2 Then
					sTo = Conversions.ToString(Operators.AddObject(sTo, data.Rows(i)("RequestedByEmailID")))
				Else
					sTo = Conversions.ToString(Operators.AddObject(sTo, Operators.ConcatenateObject(":", data.Rows(i)("RequestedByEmailID"))))
				End If
			Next
			EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text7, data, sTo)
		End Sub

		' Token: 0x06000B73 RID: 2931 RVA: 0x0006BACC File Offset: 0x00069CCC
		Public Sub Send_PR_Status_MailAlert(sPOID As String, sGRNID As String, sItemID As String, sBatchNo As String, sType As String, Optional sTo As String = "")
			Dim text As String = "Datasoft_PIMS.PRStatus.html"
			Dim text2 As String = "PR Status Update"
			Dim text3 As String = "Alert : PR Status Update"
			Dim text4 As String = "Dear User"
			Dim text5 As String = "PR STATUS UPDATE"
			Dim dataTable As DataTable
			Dim text7 As String
			If Operators.CompareString(sType, "PO", False) <> 0 Then
				If Operators.CompareString(sType, "GRN", False) <> 0 Then
					If Operators.CompareString(sType, "Batch Release", False) = 0 Then
						Dim flag As Boolean = (Operators.CompareString(sGRNID, "", False) <> 0) And (Operators.CompareString(sPOID, "", False) <> 0) And (Operators.CompareString(sItemID, "", False) <> 0)
						If Not flag Then
							Return
						End If
						Dim text6 As String = " SELECT G.GRNNo [GRN No.], PO.PONo [PO No.], PR.PRNo [PR No.], " & vbCrLf
						text6 += " P.ProductCode [Product Code], P.ProductName [Product Name], GI.BatchNo [Batch No.], " & vbCrLf
						text6 += " Req.UserName AS [Requested By], G.Status [GRN Status]," & vbCrLf
						text6 += " Req.EmailID RequestedByEmailID " & vbCrLf
						text6 += " FROM GRN G " & vbCrLf
						text6 += " INNER JOIN GRNItems GI ON G.GRNID = GI.GRNID " & vbCrLf
						text6 += " INNER JOIN Product P ON GI.ProductID = P.ProductID " & vbCrLf
						text6 += " INNER JOIN PO ON G.POID = PO.POID " & vbCrLf
						text6 += " INNER JOIN POPR ON PO.POID = POPR.POID " & vbCrLf
						text6 += " INNER JOIN PR ON PR.PRID = POPR.PRID " & vbCrLf
						text6 += " INNER JOIN PRItems PRI ON PR.PRID = PRI.PRID AND PRI.ProductID = GI.ProductID " & vbCrLf
						text6 += " INNER JOIN [User] AS Req ON PR.RequestedBy = Req.UserID " & vbCrLf
						text6 = String.Concat(New String() { text6, " WHERE GI.Status = 'Batch Released' AND G.POID = '", sPOID, "' AND G.GRNID = '", sGRNID, "' " & vbCrLf })
						text6 = String.Concat(New String() { text6, " AND GI.ProductID = '", sItemID, "' AND GI.BatchNo = '", sBatchNo, "'" & vbCrLf })
						dataTable = MainModule.GetData(text6)
						Dim flag2 As Boolean = dataTable.Rows.Count > 0
						If Not flag2 Then
							Return
						End If
						text7 = "A batch release has been performed against your PR." & vbCrLf
					End If
				Else
					Dim flag3 As Boolean = (Operators.CompareString(sGRNID, "", False) <> 0) And (Operators.CompareString(sPOID, "", False) <> 0)
					If Not flag3 Then
						Return
					End If
					Dim text6 As String = " SELECT G.GRNNo [GRN No.], PO.PONo [PO No.], PR.PRNo [PR No.], " & vbCrLf
					text6 += " P.ProductCode [Product Code], P.ProductName [Product Name], " & vbCrLf
					text6 += " Req.UserName AS [Requested By], G.Status [GRN Status]," & vbCrLf
					text6 += " Req.EmailID RequestedByEmailID " & vbCrLf
					text6 += " FROM GRN G " & vbCrLf
					text6 += " INNER JOIN GRNItems GI ON G.GRNID = GI.GRNID " & vbCrLf
					text6 += " INNER JOIN Product P ON GI.ProductID = P.ProductID " & vbCrLf
					text6 += " INNER JOIN PO ON G.POID = PO.POID " & vbCrLf
					text6 += " INNER JOIN POPR ON PO.POID = POPR.POID " & vbCrLf
					text6 += " INNER JOIN PR ON PR.PRID = POPR.PRID " & vbCrLf
					text6 += " INNER JOIN PRItems PRI ON PR.PRID = PRI.PRID AND PRI.ProductID = GI.ProductID " & vbCrLf
					text6 += " INNER JOIN [User] AS Req ON PR.RequestedBy = Req.UserID " & vbCrLf
					text6 = String.Concat(New String() { text6, " WHERE G.Status = 'GRN Approved' AND G.POID = '", sPOID, "' AND G.GRNID = '", sGRNID, "' " & vbCrLf })
					dataTable = MainModule.GetData(text6)
					Dim flag4 As Boolean = dataTable.Rows.Count > 0
					If Not flag4 Then
						Return
					End If
					text7 = "A GRN has been approved against your PR." & vbCrLf
				End If
			Else
				Dim flag5 As Boolean = Operators.CompareString(sPOID, "", False) <> 0
				If Not flag5 Then
					Return
				End If
				Dim text6 As String = " SELECT P.PRNo [PR No.], Req.UserName AS [Requested By], Req.EmailID RequestedByEmailID, " & vbCrLf
				text6 += " PO.PONo [PO No.], PO.Status [PO Status] " & vbCrLf
				text6 += " FROM PR AS P " & vbCrLf
				text6 += " INNER JOIN POPR ON P.PRID = POPR.PRID " & vbCrLf
				text6 += " INNER JOIN PO ON POPR.POID = PO.POID " & vbCrLf
				text6 += " INNER JOIN [User] AS Req ON P.RequestedBy = Req.UserID " & vbCrLf
				text6 = text6 + " WHERE POPR.POID = '" + sPOID + "' " & vbCrLf
				dataTable = MainModule.GetData(text6)
				Dim flag6 As Boolean = dataTable.Rows.Count > 0
				If Not flag6 Then
					Return
				End If
				text7 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("A PO has been ", dataTable.Rows(0)("PO Status")), " against your PR."), vbCrLf))
			End If
			Dim num As Integer = dataTable.Rows.Count - 1
			For i As Integer = 0 To num
				Dim flag7 As Boolean = Operators.CompareString(sTo, "", False) = 0
				If flag7 Then
					sTo = Conversions.ToString(Operators.AddObject(sTo, dataTable.Rows(i)("RequestedByEmailID")))
				Else
					sTo = Conversions.ToString(Operators.AddObject(sTo, Operators.ConcatenateObject(":", dataTable.Rows(i)("RequestedByEmailID"))))
				End If
			Next
			dataTable.Columns.Remove("RequestedByEmailID")
			EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text7, dataTable, sTo)
		End Sub

		' Token: 0x06000B74 RID: 2932 RVA: 0x0006BF88 File Offset: 0x0006A188
		Public Sub Send_Unregistered_PR_Product_MailAlert(dt As DataTable, Optional sTo As String = "")
			Dim text As String = "Datasoft_PIMS.PRStatus.html"
			Dim text2 As String = "Product Database"
			Dim text3 As String = "Alert : Unregistered Products In PR Request"
			Dim text4 As String = "Dear User"
			Dim text5 As String = "UNREGISTERED PR PRODUCTS"
			Dim text6 As String = "Following products in PR need product registration/ creation." & vbCrLf
			EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, dt, sTo)
		End Sub

		' Token: 0x06000B75 RID: 2933 RVA: 0x0006BFCC File Offset: 0x0006A1CC
		Public Sub Send_Unregistered_PR_Product_Creation_MailAlert(dt As DataTable, Optional sTo As String = "")
			Dim text As String = "Datasoft_PIMS.PRStatus.html"
			Dim text2 As String = "PO Creation"
			Dim text3 As String = "Alert : Unregistered Products I\Creation"
			Dim text4 As String = "Dear User"
			Dim text5 As String = "UNREGISTERED PRODUCTS CREATION"
			Dim text6 As String = "Following unregistered product is created in master." & vbCrLf
			EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, dt, sTo)
		End Sub

		' Token: 0x06000B76 RID: 2934 RVA: 0x0006C010 File Offset: 0x0006A210
		Public Sub Send_ROL_MailAlert(dt As DataTable, Optional sTo As String = "")
			Dim text As String = "Datasoft_PIMS.PRStatus.html"
			Dim text2 As String = "Reorder Level Alert"
			Dim text3 As String = "Alert : Product(s) Reached Reorder Level"
			Dim text4 As String = "Dear User"
			Dim text5 As String = "REORDER LEVEL NOTIFICATION"
			Dim text6 As String = "Reorder Required: Products at Minimum Stock." & vbCrLf
			EmailModule.ConfigureEmailAlert(text, text2, text3, text4, text5, text6, dt, sTo)
		End Sub
	End Module
End Namespace
