Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Datasoft_PIMS
	' Token: 0x0200002F RID: 47
	Friend NotInheritable Module FileAttachments
		' Token: 0x06000B78 RID: 2936 RVA: 0x0006C0B8 File Offset: 0x0006A2B8
		Public Function CreateFileTable() As DataTable
			Return New DataTable() With { .Columns = { { "FileID", Type.[GetType]("System.Int32") }, { "FileName", Type.[GetType]("System.String") }, { "FileExtension", Type.[GetType]("System.String") }, { "FileData", Type.[GetType]("System.Byte[]") } } }
		End Function

		' Token: 0x06000B79 RID: 2937 RVA: 0x0006C140 File Offset: 0x0006A340
		Public Sub SetFileDatagridview(dt As DataTable, dgv As DataGridView)
			dgv.Rows.Clear()
			Dim num As Integer = dt.Rows.Count - 1
			For i As Integer = 0 To num
				dgv.Rows.Add()
				dgv.Rows(dgv.Rows.Count - 1).Cells("FileID").Value = RuntimeHelpers.GetObjectValue(dt.Rows(i)("FileID"))
				dgv.Rows(dgv.Rows.Count - 1).Cells("FileName").Value = RuntimeHelpers.GetObjectValue(dt.Rows(i)("FileName"))
			Next
		End Sub

		' Token: 0x06000B7A RID: 2938 RVA: 0x0006C218 File Offset: 0x0006A418
		Public Function FillFileAttachments(sTrn As String, sID As String) As DataTable
			Dim dataTable As DataTable = New DataTable()
			Try
				Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(sTrn)
				Dim text As String
				If num <= 2214128454UI Then
					If num <= 1222334419UI Then
						If num <> 1029369297UI Then
							If num <> 1222334419UI Then
								GoTo IL_0193
							End If
							If Operators.CompareString(sTrn, "PO Approval", False) <> 0 Then
								GoTo IL_0193
							End If
							GoTo IL_0181
						Else
							If Operators.CompareString(sTrn, "PO Printing", False) <> 0 Then
								GoTo IL_0193
							End If
							GoTo IL_0181
						End If
					ElseIf num <> 1500191736UI Then
						If num <> 2070787099UI Then
							If num <> 2214128454UI Then
								GoTo IL_0193
							End If
							If Operators.CompareString(sTrn, "PO Generation", False) <> 0 Then
								GoTo IL_0193
							End If
							GoTo IL_0181
						ElseIf Operators.CompareString(sTrn, "GRN Entry - Against PO", False) <> 0 Then
							GoTo IL_0193
						End If
					ElseIf Operators.CompareString(sTrn, "GRN Modify", False) <> 0 Then
						GoTo IL_0193
					End If
				ElseIf num <= 2577931921UI Then
					If num <> 2444516107UI Then
						If num <> 2577931921UI Then
							GoTo IL_0193
						End If
						If Operators.CompareString(sTrn, "QC Entry", False) <> 0 Then
							GoTo IL_0193
						End If
						text = "QC Entry"
						GoTo IL_0198
					Else
						If Operators.CompareString(sTrn, "PO Amendment", False) <> 0 Then
							GoTo IL_0193
						End If
						GoTo IL_0181
					End If
				ElseIf num <> 2924031041UI Then
					If num <> 3529496940UI Then
						If num <> 3618005290UI Then
							GoTo IL_0193
						End If
						If Operators.CompareString(sTrn, "GRN Entry", False) <> 0 Then
							GoTo IL_0193
						End If
					Else
						If Operators.CompareString(sTrn, "PO Modification", False) <> 0 Then
							GoTo IL_0193
						End If
						GoTo IL_0181
					End If
				ElseIf Operators.CompareString(sTrn, "GRN Approval", False) <> 0 Then
					GoTo IL_0193
				End If
				text = "GRN Entry"
				GoTo IL_0198
				IL_0181:
				text = "PO Generation"
				GoTo IL_0198
				IL_0193:
				text = sTrn
				IL_0198:
				Dim text2 As String = " SELECT ROW_NUMBER() OVER(ORDER BY FileID) AS FileID, FileName, FileExtension, FileData "
				text2 += " FROM FileAttachment "
				text2 = String.Concat(New String() { text2, " WHERE FileTransaction = '", text, "' AND TransactionID = '", sID, "'" })
				dataTable = MainModule.GetData(text2)
				Return dataTable
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Return dataTable
		End Function

		' Token: 0x06000B7B RID: 2939 RVA: 0x0006C45C File Offset: 0x0006A65C
		Public Function AttachmentFile(sFileID As String, dt As DataTable) As DataTable
			Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
			Try
				Dim flag As Boolean = openFileDialog.ShowDialog() = DialogResult.OK
				If flag Then
					Dim fileName As String = openFileDialog.FileName
					Dim fileInfo As FileInfo = New FileInfo(fileName)
					Dim array As Byte() = File.ReadAllBytes(fileName)
					Dim flag2 As Boolean = Operators.ConditionalCompareObjectEqual(FileAttachments.ValidateFileExtension(fileInfo.Extension), False, False)
					If Not flag2 Then
						Dim flag3 As Boolean = Conversions.ToDouble(sFileID) = -1.0
						If flag3 Then
							dt.Rows.Add(New Object(-1) {})
							sFileID = Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dt.Compute("MAX(FileID)", "1=1"))), 0, RuntimeHelpers.GetObjectValue(dt.Compute("MAX(FileID)", "1=1"))))) + 1.0)
						End If
						dt.Rows(dt.Rows.Count - 1)("FileID") = sFileID
						dt.Rows(dt.Rows.Count - 1)("FileName") = fileInfo.Name
						dt.Rows(dt.Rows.Count - 1)("FileExtension") = fileInfo.Extension
						dt.Rows(dt.Rows.Count - 1)("FileData") = array
					End If
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Return dt
		End Function

		' Token: 0x06000B7C RID: 2940 RVA: 0x0006C630 File Offset: 0x0006A830
		Private Function ValidateFileExtension(sExt As String) As Object
			Return True
		End Function

		' Token: 0x06000B7D RID: 2941 RVA: 0x0006C648 File Offset: 0x0006A848
		Public Sub DownloadFile(dr As DataRow)
			Try
				Dim folderBrowserDialog As FolderBrowserDialog = New FolderBrowserDialog()
				Dim flag As Boolean = folderBrowserDialog.ShowDialog() = DialogResult.OK
				If flag Then
					Dim text As String = Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(folderBrowserDialog.SelectedPath + "\", dr("FileName"))), "\\", "\", 1, -1, CompareMethod.Binary)
					Dim array As Byte() = CType(dr("FileData"), Byte())
					File.WriteAllBytes(text, array)
					CustomMsgBox.Show("File Download Complete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000B7E RID: 2942 RVA: 0x0006C6F4 File Offset: 0x0006A8F4
		Public Sub InsertFiles(sTrn As String, sID As String, dt As DataTable)
			Dim flag As Boolean = Operators.CompareString(sID, "", False) <> 0
			If flag Then
				Dim sqlConnection As SqlConnection = New SqlConnection(GlobalVariables.gsConStr)
				sqlConnection.Open()
				Dim sqlTransaction As SqlTransaction = sqlConnection.BeginTransaction(IsolationLevel.Serializable)
				Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(sTrn)
				If num <= 2070787099UI Then
					If num <= 1222334419UI Then
						If num <> 1029369297UI Then
							If num <> 1222334419UI Then
								GoTo IL_0192
							End If
							If Operators.CompareString(sTrn, "PO Approval", False) <> 0 Then
								GoTo IL_0192
							End If
							GoTo IL_0189
						Else
							If Operators.CompareString(sTrn, "PO Printing", False) <> 0 Then
								GoTo IL_0192
							End If
							GoTo IL_0189
						End If
					ElseIf num <> 1500191736UI Then
						If num <> 2070787099UI Then
							GoTo IL_0192
						End If
						If Operators.CompareString(sTrn, "GRN Entry - Against PO", False) <> 0 Then
							GoTo IL_0192
						End If
					ElseIf Operators.CompareString(sTrn, "GRN Modify", False) <> 0 Then
						GoTo IL_0192
					End If
				ElseIf num <= 2444516107UI Then
					If num <> 2214128454UI Then
						If num <> 2444516107UI Then
							GoTo IL_0192
						End If
						If Operators.CompareString(sTrn, "PO Amendment", False) <> 0 Then
							GoTo IL_0192
						End If
						GoTo IL_0189
					Else
						If Operators.CompareString(sTrn, "PO Generation", False) <> 0 Then
							GoTo IL_0192
						End If
						GoTo IL_0189
					End If
				ElseIf num <> 2924031041UI Then
					If num <> 3529496940UI Then
						If num <> 3618005290UI Then
							GoTo IL_0192
						End If
						If Operators.CompareString(sTrn, "GRN Entry", False) <> 0 Then
							GoTo IL_0192
						End If
					Else
						If Operators.CompareString(sTrn, "PO Modification", False) <> 0 Then
							GoTo IL_0192
						End If
						GoTo IL_0189
					End If
				ElseIf Operators.CompareString(sTrn, "GRN Approval", False) <> 0 Then
					GoTo IL_0192
				End If
				Dim text As String = "GRN Entry"
				GoTo IL_0197
				IL_0189:
				text = "PO Generation"
				GoTo IL_0197
				IL_0192:
				text = sTrn
				IL_0197:
				Try
					Dim text2 As String = String.Concat(New String() { "DELETE FROM FileAttachment WHERE FileTransaction = '", text, "' AND TransactionID = '", sID, "'" })
					Dim flag2 As Boolean = MainModule.ExecuteSQL(text2, sqlConnection, sqlTransaction) = 1
					If flag2 Then
						Dim dataTable As DataTable = dt.Copy()
						dataTable.Columns.Remove("FileID")
						Dim dataColumn As DataColumn = New DataColumn("FileTransaction", GetType(String))
						dataColumn.DefaultValue = text
						Dim dataColumn2 As DataColumn = New DataColumn("TransactionID", GetType(String))
						dataColumn2.DefaultValue = sID
						Dim dataColumn3 As DataColumn = New DataColumn("CreatedBy", GetType(String))
						dataColumn3.DefaultValue = GlobalVariables.gsUserID
						dataTable.Columns.Add(dataColumn)
						dataTable.Columns.Add(dataColumn2)
						dataTable.Columns.Add(dataColumn3)
						MainModule.BulkInsertTemp(dataTable, "FileAttachment", sqlConnection, sqlTransaction)
						sqlTransaction.Commit()
						sqlConnection.Close()
					Else
						sqlTransaction.Rollback()
						sqlConnection.Close()
					End If
				Catch ex As Exception
					sqlTransaction.Rollback()
					sqlConnection.Close()
					CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				End Try
			End If
		End Sub
	End Module
End Namespace
