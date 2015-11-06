Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Security.Cryptography
Imports System.Diagnostics

Public Class frmPrincipal
    Private Const PSRVR As String = "C:\Enabler\psrvr.exe"
    Private Const ENBCONFIG As String = "C:\Enabler\EnbConfig.exe"
    Private Const PUMPDEMO As String = "C:\Enabler\pumpdemo.exe"
    Private Const MD5_PSRVR As String = "E5B5337FF9AEF32AA19A84AA51CA497C" '"B0D858A03E6E58888FC29833CAB40268"
    Private Const MD5_ENBCONFIG As String = "874261BDA5FEA111EC3BF83BE07A282C"
    Private Const MD5_PUMPDEMO As String = "6F1705C8303FA8B59F9BAD4DA133A289"
    Private Const SEGUNDOS As Integer = 60
    Private contadorSegundos As Integer = SEGUNDOS
    Private Const CMD As Char = "S" '[S = Apagar, R = Apaga y Reinicia el Equipo]

    Private hiloVentana As Thread
    Private Delegate Sub DelUbicarVentana()
    Private Delegate Sub DelMensajeSeguro(ByRef obj As Object, ByVal txt As String)
    Private ventanaEstado As Boolean = True

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        Call UbicarVentana()
        ' Add any initialization after the InitializeComponent() call.
        tslblVersion.Text = My.Application.Info.Version.ToString
        hiloVentana = New Thread(New ThreadStart(AddressOf UbicarVentanaSeguro))
        hiloVentana.Priority = ThreadPriority.Lowest
        hiloVentana.Name = "UbicacionVentana"
        hiloVentana.Start()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        niSegundoPlano.Visible = True
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

            Call VerificarMD5()

        End While
    End Sub

    Private Sub MensajeSeguro(ByRef obj As Object, ByVal txt As String)
        If obj.InvokeRequired Then
            Dim d As New DelMensajeSeguro(AddressOf MensajeSeguro)
            obj.Invoke(d)
        Else
            obj.Text = txt
        End If
    End Sub

    ''' <summary>
    ''' Segmento que verifica que el Checksum MD5, coincida con lo calculado
    ''' y documentado en las pruebas de Hermeticidad, para el software 
    ''' legalmente relevante, en caso de no concordar, el programa apaga el
    ''' sistema de comunicación cada "X", segundos declarados en la seccion
    ''' de Variables al principio del Programa.
    ''' </summary>
    Private Sub VerificarMD5()
1:      Dim del As New DelMensajeSeguro(AddressOf MensajeSeguro)
2:      Dim banderaPsrvr As Boolean = False
3:      Dim banderaEnbconfig As Boolean = False
4:      Dim banderaPumpdemo As Boolean = False
5:      Dim mensajeCorrecto As Boolean = True

6:      txtPsrvr.Invoke(New DelMensajeSeguro(AddressOf MensajeSeguro),
                                  New Object() {txtPsrvr, Md5_Sum(PSRVR)})
7:      txtEnbConfig.Invoke(New DelMensajeSeguro(AddressOf MensajeSeguro),
                                  New Object() {txtEnbConfig, Md5_Sum(ENBCONFIG)})
8:      txtPumpdemo.Invoke(New DelMensajeSeguro(AddressOf MensajeSeguro),
                                  New Object() {txtPumpdemo, Md5_Sum(PUMPDEMO)})

9:      If MD5_PSRVR = Md5_Sum(PSRVR) Then banderaPsrvr = True
10:     If MD5_ENBCONFIG = Md5_Sum(ENBCONFIG) Then banderaEnbconfig = True
11:     If MD5_PUMPDEMO = Md5_Sum(PUMPDEMO) Then banderaPumpdemo = True

12:     If banderaPsrvr = False Or banderaEnbconfig = False Or banderaPumpdemo = False Then
            'En caso de que el textbox donde se colocan los mensajes, cuente con el mismo
            'mensaje que se va a pasar como parámetro. Esta condición brinca la asignación
            'así no escribirá el mismo mensaje mas de dos veces
13:         If txtMensaje.Text <> "Las APLICACIONES fueron CORROMPIDAS!!!" & vbCrLf &
                                  "PSRVR : " & IIf(banderaPsrvr = False, "CORRUPTO", "NORMAL") &
                                  ", ENBCONFIG : " & IIf(banderaEnbconfig = False, "CORRUPTO", "NORMAL") &
                                  ", PUMPDEMO : " & IIf(banderaPumpdemo = False, "CORRUPTO", "NORMAL") &
                                  ": EL SISTEMA SE APAGARA EN UN INSTANTE" Then
14:             txtMensaje.Invoke(del, New Object() {txtMensaje,
                              "Las APLICACIONES fueron CORROMPIDAS!!!" & vbCrLf &
                              "PSRVR : " & IIf(banderaPsrvr = False, "CORRUPTO", "NORMAL") &
                              ", ENBCONFIG : " & IIf(banderaEnbconfig = False, "CORRUPTO", "NORMAL") &
                              ", PUMPDEMO : " & IIf(banderaPumpdemo = False, "CORRUPTO", "NORMAL") &
                              ": EL SISTEMA SE APAGARA EN UN INSTANTE"})
15:         End If

16:         tslblApagar.Text = contadorSegundos
17:         If contadorSegundos > 0 Then
18:             contadorSegundos -= 1
19:         Else
20:             Process.Start("shutdown.exe", " -" & CMD & " -t " & contadorSegundos & " -f")
21:         End If
22:         mensajeCorrecto = False
23:     End If

24:     If mensajeCorrecto Then
25:         txtMensaje.Invoke(del,
                                  New Object() {txtMensaje,
                                  "TODAS LAS APLICACIONES DE COMUNICACION " &
                                  "FUNCIONAN CORRECTAMENTE!!!"})
26:         contadorSegundos = SEGUNDOS
27:         tslblApagar.Text = "..."
28:     End If
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
        Try
1:          If File.Exists(dirExe) Then
2:              Dim md5code As String
3:              Dim md5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider
4:              Dim f As FileStream = New FileStream(dirExe, FileMode.Open, FileAccess.Read, FileShare.Read, 4096)
5:              md5.ComputeHash(f)
6:              Dim ObjFSO As Object = CreateObject("Scripting.FileSystemObject")
7:              Dim objFile = ObjFSO.GetFile(dirExe)
8:              Dim hash As Byte() = md5.Hash
9:              Dim buff As StringBuilder = New StringBuilder
10:             Dim hashByte As Byte
11:             For Each hashByte In hash
12:                 buff.Append(String.Format("{0:X2}", hashByte))
13:             Next
14:             md5code = buff.ToString()
                f.Dispose()
15:             Return md5code.Trim
16:         Else
17:             Return "NO EXISTE LA APLICACION"
18:         End If
        Catch ex As Exception
            'Call manejoErrores(Err.Number, Erl, "MD5_Sum: " & ex.Message.ToString)
            Return "ERROR"
        End Try
    End Function

    Private Sub niSegundoPlano_Click(sender As Object, e As EventArgs) Handles niSegundoPlano.Click
        If ventanaEstado Then
            ventanaEstado = False
            Me.Hide()
        Else
            Me.Show()
            ventanaEstado = True
        End If
    End Sub

    Private Sub frmPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        hiloVentana.Abort()
    End Sub

    Private Sub frmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        'niSegundoPlano.Visible = False
        'niSegundoPlano.Icon.Dispose()
        'niSegundoPlano.Dispose()
    End Sub
End Class
