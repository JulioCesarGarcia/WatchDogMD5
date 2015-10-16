Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Security.Cryptography

Public Class frmPrincipal
    Private hiloVentana As Thread
    Private Delegate Sub DelUbicarVentana()

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        tslblVersion.Text = My.Application.Info.Version.ToString
        hiloVentana = New Thread(New ThreadStart(AddressOf UbicarVentanaSeguro))
        hiloVentana.Priority = ThreadPriority.Lowest
        hiloVentana.Name = "UbicacionVentana"
        hiloVentana.Start()
    End Sub

    Private Sub ManejodeVersiones()

    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPsrvr.Text = Md5_Sum("C:\Enabler\psrvr.exe")
        txtEnbConfig.Text = Md5_Sum("C:\Enabler\EnbConfig.exe")
        txtPumpdemo.Text = Md5_Sum("C:\Enabler\pumpdemo.exe")
    End Sub

    Private Sub frmPrincipal_Click(sender As Object, e As EventArgs) Handles MyBase.Click,
        txtPsrvr.Click, txtPumpdemo.Click, txtEnbConfig.Click, txtMensaje.Click,
        lblEnbConfig.Click, lblPsrvr.Click, lblPumpdemo.Click, gbMensaje.Click,
        gbSoftware.Click, tslblVersion.Click, sbtslblVersion.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Private Sub UbicarVentanaSeguro()
        While True

            If Me.InvokeRequired Then
                Dim d As New DelUbicarVentana(AddressOf UbicarVentana)
                Me.Invoke(d)
            Else
                Location = New Point(Screen.PrimaryScreen.WorkingArea.Size.Width - Width,
                                 Screen.PrimaryScreen.WorkingArea.Size.Height - Height)
            End If

            Thread.Sleep(1000)
        End While
    End Sub

    Private Sub UbicarVentana()
        Location = New Point(Screen.PrimaryScreen.WorkingArea.Size.Width - Width,
                                 Screen.PrimaryScreen.WorkingArea.Size.Height - Height)
    End Sub

    ''' <summary>
    ''' Funcion que me devuelve la verificacion de la integridad de un archivo
    ''' en este caso, la integridad de la aplicacion: Ubicada en C:\Enabler\psrvr.exe
    ''' La verificacion de la instalación da como resultado a comparacion:
    ''' E5B5337FF9AEF32AA19A84AA51CA497C
    ''' </summary>
    ''' <param name="dirExe">Direccion del archivo a verificar</param>
    ''' <returns>Checksum MD5, del servicio de comunicacion: psrvr.exe</returns>
    ''' <remarks>En caso de no existir el archivo a verificar regresa un: nothing</remarks>
    Private Function Md5_Sum(ByVal dirExe As String) As String
        If File.Exists(dirExe) Then
            Dim md5code As String
            Dim md5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider


            Dim f As FileStream = New FileStream(dirExe, FileMode.Open, FileAccess.Read, FileShare.Read, 4096)
            'f = New FileStream(dirExe, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
            md5.ComputeHash(f)

            Dim ObjFSO As Object = CreateObject("Scripting.FileSystemObject")
            Dim objFile = ObjFSO.GetFile(dirExe)

            Dim hash As Byte() = md5.Hash
            Dim buff As StringBuilder = New StringBuilder
            Dim hashByte As Byte
            For Each hashByte In hash
                buff.Append(String.Format("{0:X2}", hashByte))
            Next
            md5code = buff.ToString()
            Return md5code.Trim
        Else
            Return Nothing
        End If
    End Function

    Private Sub frmPrincipal_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged
        MsgBox(Me.Location.X.ToString & " - " & Me.Location.Y.ToString)
    End Sub
End Class
