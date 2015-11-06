<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.gbMensaje = New System.Windows.Forms.GroupBox()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.sbtslblVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslblVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sbtslblApagar = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslblApagar = New System.Windows.Forms.ToolStripStatusLabel()
        Me.gbSoftware = New System.Windows.Forms.GroupBox()
        Me.txtPumpdemo = New System.Windows.Forms.TextBox()
        Me.lblPumpdemo = New System.Windows.Forms.Label()
        Me.txtEnbConfig = New System.Windows.Forms.TextBox()
        Me.lblEnbConfig = New System.Windows.Forms.Label()
        Me.txtPsrvr = New System.Windows.Forms.TextBox()
        Me.lblPsrvr = New System.Windows.Forms.Label()
        Me.niSegundoPlano = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.gbMensaje.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.gbSoftware.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbMensaje
        '
        Me.gbMensaje.Controls.Add(Me.txtMensaje)
        Me.gbMensaje.Location = New System.Drawing.Point(12, 116)
        Me.gbMensaje.Name = "gbMensaje"
        Me.gbMensaje.Size = New System.Drawing.Size(365, 76)
        Me.gbMensaje.TabIndex = 6
        Me.gbMensaje.TabStop = False
        Me.gbMensaje.Text = "[Mensaje:]"
        '
        'txtMensaje
        '
        Me.txtMensaje.Location = New System.Drawing.Point(22, 19)
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.ReadOnly = True
        Me.txtMensaje.Size = New System.Drawing.Size(330, 51)
        Me.txtMensaje.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sbtslblVersion, Me.tslblVersion, Me.sbtslblApagar, Me.tslblApagar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 195)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(391, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "ssEstado"
        '
        'sbtslblVersion
        '
        Me.sbtslblVersion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sbtslblVersion.Name = "sbtslblVersion"
        Me.sbtslblVersion.Size = New System.Drawing.Size(126, 17)
        Me.sbtslblVersion.Text = "Versión del Producto:"
        Me.sbtslblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tslblVersion
        '
        Me.tslblVersion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tslblVersion.Name = "tslblVersion"
        Me.tslblVersion.Size = New System.Drawing.Size(16, 17)
        Me.tslblVersion.Text = "..."
        Me.tslblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sbtslblApagar
        '
        Me.sbtslblApagar.AutoSize = False
        Me.sbtslblApagar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sbtslblApagar.Name = "sbtslblApagar"
        Me.sbtslblApagar.Size = New System.Drawing.Size(80, 17)
        Me.sbtslblApagar.Text = "Apagar:"
        Me.sbtslblApagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tslblApagar
        '
        Me.tslblApagar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslblApagar.ForeColor = System.Drawing.Color.Red
        Me.tslblApagar.Name = "tslblApagar"
        Me.tslblApagar.Size = New System.Drawing.Size(16, 17)
        Me.tslblApagar.Text = "..."
        '
        'gbSoftware
        '
        Me.gbSoftware.Controls.Add(Me.txtPumpdemo)
        Me.gbSoftware.Controls.Add(Me.lblPumpdemo)
        Me.gbSoftware.Controls.Add(Me.txtEnbConfig)
        Me.gbSoftware.Controls.Add(Me.lblEnbConfig)
        Me.gbSoftware.Controls.Add(Me.txtPsrvr)
        Me.gbSoftware.Controls.Add(Me.lblPsrvr)
        Me.gbSoftware.Location = New System.Drawing.Point(12, 4)
        Me.gbSoftware.Name = "gbSoftware"
        Me.gbSoftware.Size = New System.Drawing.Size(365, 106)
        Me.gbSoftware.TabIndex = 8
        Me.gbSoftware.TabStop = False
        Me.gbSoftware.Text = "[Software: Integration Technologies Limited]"
        '
        'txtPumpdemo
        '
        Me.txtPumpdemo.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPumpdemo.ForeColor = System.Drawing.Color.Blue
        Me.txtPumpdemo.Location = New System.Drawing.Point(102, 72)
        Me.txtPumpdemo.Name = "txtPumpdemo"
        Me.txtPumpdemo.ReadOnly = True
        Me.txtPumpdemo.Size = New System.Drawing.Size(250, 23)
        Me.txtPumpdemo.TabIndex = 11
        '
        'lblPumpdemo
        '
        Me.lblPumpdemo.AutoSize = True
        Me.lblPumpdemo.Location = New System.Drawing.Point(19, 75)
        Me.lblPumpdemo.Name = "lblPumpdemo"
        Me.lblPumpdemo.Size = New System.Drawing.Size(83, 13)
        Me.lblPumpdemo.TabIndex = 10
        Me.lblPumpdemo.Text = "Pumpdemo.exe:"
        '
        'txtEnbConfig
        '
        Me.txtEnbConfig.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnbConfig.ForeColor = System.Drawing.Color.Blue
        Me.txtEnbConfig.Location = New System.Drawing.Point(102, 46)
        Me.txtEnbConfig.Name = "txtEnbConfig"
        Me.txtEnbConfig.ReadOnly = True
        Me.txtEnbConfig.Size = New System.Drawing.Size(250, 23)
        Me.txtEnbConfig.TabIndex = 9
        '
        'lblEnbConfig
        '
        Me.lblEnbConfig.AutoSize = True
        Me.lblEnbConfig.Location = New System.Drawing.Point(19, 49)
        Me.lblEnbConfig.Name = "lblEnbConfig"
        Me.lblEnbConfig.Size = New System.Drawing.Size(79, 13)
        Me.lblEnbConfig.TabIndex = 8
        Me.lblEnbConfig.Text = "EnbConfig.exe:"
        '
        'txtPsrvr
        '
        Me.txtPsrvr.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPsrvr.ForeColor = System.Drawing.Color.Blue
        Me.txtPsrvr.Location = New System.Drawing.Point(102, 20)
        Me.txtPsrvr.Name = "txtPsrvr"
        Me.txtPsrvr.ReadOnly = True
        Me.txtPsrvr.Size = New System.Drawing.Size(250, 23)
        Me.txtPsrvr.TabIndex = 7
        '
        'lblPsrvr
        '
        Me.lblPsrvr.AutoSize = True
        Me.lblPsrvr.Location = New System.Drawing.Point(19, 23)
        Me.lblPsrvr.Name = "lblPsrvr"
        Me.lblPsrvr.Size = New System.Drawing.Size(54, 13)
        Me.lblPsrvr.TabIndex = 6
        Me.lblPsrvr.Text = "Psrvr.exe:"
        '
        'niSegundoPlano
        '
        Me.niSegundoPlano.Icon = CType(resources.GetObject("niSegundoPlano.Icon"), System.Drawing.Icon)
        Me.niSegundoPlano.Text = "WatchDog MD5"
        Me.niSegundoPlano.Visible = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 217)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbSoftware)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.gbMensaje)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrincipal"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "WatchDog: Checksum MD5"
        Me.TopMost = True
        Me.gbMensaje.ResumeLayout(False)
        Me.gbMensaje.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.gbSoftware.ResumeLayout(False)
        Me.gbSoftware.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbMensaje As GroupBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents sbtslblVersion As ToolStripStatusLabel
    Friend WithEvents tslblVersion As ToolStripStatusLabel
    Friend WithEvents gbSoftware As GroupBox
    Friend WithEvents txtPumpdemo As TextBox
    Friend WithEvents lblPumpdemo As Label
    Friend WithEvents txtEnbConfig As TextBox
    Friend WithEvents lblEnbConfig As Label
    Friend WithEvents txtPsrvr As TextBox
    Friend WithEvents lblPsrvr As Label
    Friend WithEvents niSegundoPlano As NotifyIcon
    Friend WithEvents txtMensaje As TextBox
    Friend WithEvents sbtslblApagar As ToolStripStatusLabel
    Friend WithEvents tslblApagar As ToolStripStatusLabel
End Class
