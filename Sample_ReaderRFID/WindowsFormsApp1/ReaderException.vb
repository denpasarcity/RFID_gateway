Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace WindowsFormsApp1
	Public Class ReaderException
		Inherits Exception

		''' <summary>
		''' 执行成功
		''' </summary>
		Public Shared ReadOnly ERROR_SUCCESS As Integer = &H0
		''' <summary>
		''' 句柄错误
		''' </summary>
		Public Shared ReadOnly ERROR_HANDLE_ERROR As Integer = -255
		''' <summary>
		''' 打开串口或建立网络连接失败
		''' </summary>
		Public Shared ReadOnly ERROR_OPEN_FAILED As Integer = -254
		''' <summary>
		''' 动态库内部错误
		''' </summary>
		Public Shared ReadOnly ERROR_DLL_INNER_ERROR As Integer = -253
		''' <summary>
		''' 参数值错误或越界，或者模块不支持该参数值
		''' </summary>
		Public Shared ReadOnly ERROR_CMD_PARAM_ERROR As Integer = -252
		''' <summary>
		''' 序列号已存在
		''' </summary>
		Public Shared ReadOnly ERROR_CMD_SERIAL_NUM_EXISTS As Integer = -251
		''' <summary>
		''' 由于模块内部错误导致命令执行失败
		''' </summary>
		Public Shared ReadOnly ERROR_CMD_INTERNAL_ERROR As Integer = -250
		''' <summary>
		''' 没有盘点到标签或盘点已结束
		''' </summary>
		Public Shared ReadOnly ERROR_CMD_NO_TAG As Integer = -249
		''' <summary>
		''' 标签响应超时
		''' </summary>
		Public Shared ReadOnly ERROR_CMD_TAG_RESP_TIMEOUT As Integer = -248
		''' <summary>
		''' 解调标签数据错误
		''' </summary>
		Public Shared ReadOnly ERROR_CMD_TAG_RESP_COLLISION As Integer = -247
		''' <summary>
		''' 标签数据超出最大传输长度
		''' </summary>
		Public Shared ReadOnly ERROR_CMD_CODE_OVERFLOW As Integer = -246
		''' <summary>
		''' 认证失败
		''' </summary>
		Public Shared ReadOnly ERROR_CMD_AUTH_FAILED As Integer = -245
		''' <summary>
		''' 口令错误
		''' </summary>
		Public Shared ReadOnly ERROR_CMD_PWD_ERROR As Integer = -244
		''' <summary>
		''' SAM卡无响应
		''' </summary>
		Public Shared ReadOnly ERROR_CMD_SAM_NO_RESP As Integer = -243
		''' <summary>
		''' PSAM卡命令执行失败
		''' </summary>
		Public Shared ReadOnly ERROR_CMD_SAM_CMD_FAILED As Integer = -242
		''' <summary>
		''' 读写器响应格式错误
		''' </summary>
		Public Shared ReadOnly ERROR_CMD_RESP_FORMAT_ERROR As Integer = -241
		''' <summary>
		''' 命令执行成功，但是还有后续数据未传输完成
		''' </summary>
		Public Shared ReadOnly ERROR_CMD_HAS_MORE_DATA As Integer = -240
		''' <summary>
		''' 传入缓存太小，数据溢出
		''' </summary>
		Public Shared ReadOnly ERROR_CMD_BUF_OVERFLOW As Integer = -239
		''' <summary>
		''' 等待阅读器响应超时
		''' </summary>
		Public Shared ReadOnly ERROR_CMD_COMM_TIMEOUT As Integer = -238
		''' <summary>
		''' 向读写器写数据失败
		''' </summary>
		Public Shared ReadOnly ERROR_CMD_COMM_WRITE_FAILED As Integer = -237
		''' <summary>
		''' 从读写器读数据失败
		''' </summary>
		Public Shared ReadOnly ERROR_CMD_COMM_READ_FAILED As Integer = -236
		''' <summary>
		''' 所有数据已传输完毕
		''' </summary>
		Public Shared ReadOnly ERROR_CMD_NOMORE_DATA As Integer = -235
		''' <summary>
		''' 网络连接尚未建立
		''' </summary>
		Public Shared ReadOnly ERROR_DLL_UNCONNECT As Integer = -234
		''' <summary>
		''' 网络连接已经断开
		''' </summary>
		Public Shared ReadOnly ERROR_DLL_DISCONNECT As Integer = -233
		''' <summary>
		''' 接收响应CRC校验错误
		''' </summary>
		Public Shared ReadOnly ERROR_CMD_RESP_CRC_ERROR As Integer = -232
		''' <summary>
		''' 下载数据校验错误
		''' </summary>
		Public Shared ReadOnly ERROR_CMD_IAP_CRC_ERR As Integer = -231
		''' <summary>
		''' 下载数据错误
		''' </summary>
		Public Shared ReadOnly ERROR_CMD_DOWMLOAD_ERR As Integer = -230
		''' <summary>
		''' 数据未下载成功
		''' </summary>
		Public Shared ReadOnly ERROR_CMD_DOWM_NONE_ERR As Integer = -229




		Private Shared ReadOnly s_arrErrs() As ErrorItem = {
			New ErrorItem(ERROR_SUCCESS, "Command executed successfully"),
			New ErrorItem(ERROR_HANDLE_ERROR, "Incorrect handle or parameter"),
			New ErrorItem(ERROR_OPEN_FAILED, "Failed to open the reader"),
			New ErrorItem(ERROR_DLL_INNER_ERROR, "Internal dynamic library error"),
			New ErrorItem(ERROR_CMD_RESP_FORMAT_ERROR, "The reader responds to a data format error"),
			New ErrorItem(ERROR_CMD_RESP_CRC_ERROR, "The reader responded to a CRC check error"),
			New ErrorItem(ERROR_CMD_BUF_OVERFLOW, "The incoming cache is too small and the data overflows"),
			New ErrorItem(ERROR_CMD_COMM_TIMEOUT, "Waiting for reader response timed out"),
			New ErrorItem(ERROR_CMD_COMM_WRITE_FAILED, "An error occurred writing data to the reader"),
			New ErrorItem(ERROR_CMD_COMM_READ_FAILED, "An error occurred while reading data from the reader"),
			New ErrorItem(ERROR_CMD_HAS_MORE_DATA, "Subsequent data transmission is not complete"),
			New ErrorItem(ERROR_DLL_UNCONNECT, "The network connection has not been established"),
			New ErrorItem(ERROR_DLL_DISCONNECT, "The network connection has been disconnected"),
			New ErrorItem(ERROR_CMD_IAP_CRC_ERR, "Download data verification error"),
			New ErrorItem(ERROR_CMD_DOWMLOAD_ERR, "Data download error, data write error"),
			New ErrorItem(ERROR_CMD_DOWM_NONE_ERR, "Data download failed. Procedure")
		}

		''' <summary>
		''' 错误码
		''' </summary>
		Private m_iErroCode As Integer = 0

		''' <summary>
		''' 错误码
		''' </summary>
		Public ReadOnly Property ErrorCode() As Integer
			Get
				Return m_iErroCode
			End Get
		End Property

		Public Sub New()
			Me.New(ERROR_SUCCESS)
		End Sub

'INSTANT VB NOTE: The variable errorCode was renamed since Visual Basic does not handle local variables named the same as class members well:
		Public Sub New(ByVal errorCode_Conflict As Integer)
			Me.New(errorCode_Conflict, MessageFromErrorCode(errorCode_Conflict))
		End Sub

'INSTANT VB NOTE: The variable errorCode was renamed since Visual Basic does not handle local variables named the same as class members well:
'INSTANT VB NOTE: The variable message was renamed since Visual Basic does not handle local variables named the same as class members well:
		Public Sub New(ByVal errorCode_Conflict As Integer, ByVal message_Conflict As String)
			MyBase.New(message_Conflict)
			Me.m_iErroCode = errorCode_Conflict
		End Sub

'INSTANT VB NOTE: The variable errorCode was renamed since Visual Basic does not handle local variables named the same as class members well:
		Public Shared Function MessageFromErrorCode(ByVal errorCode_Conflict As Integer) As String
			For i As Integer = 0 To s_arrErrs.Length - 1
				If s_arrErrs(i).ErrorCode = errorCode_Conflict Then
					Return s_arrErrs(i).Message
				End If
			Next i
			Return "Unknown error code：" & errorCode_Conflict
		End Function

		Private Structure ErrorItem
			Public ErrorCode As Integer
			Public Message As String

'INSTANT VB NOTE: The variable errorCode was renamed since Visual Basic does not handle local variables named the same as class members well:
'INSTANT VB NOTE: The variable message was renamed since Visual Basic does not handle local variables named the same as class members well:
			Public Sub New(ByVal errorCode_Conflict As Integer, ByVal message_Conflict As String)
				Me.ErrorCode = errorCode_Conflict
				Me.Message = message_Conflict
			End Sub
		End Structure
	End Class
End Namespace
