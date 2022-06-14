<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.txtATCClass = New System.Windows.Forms.TextBox()
        Me.txtMIMSClass = New System.Windows.Forms.TextBox()
        Me.txtMedPacking = New System.Windows.Forms.TextBox()
        Me.txtMedName = New System.Windows.Forms.TextBox()
        Me.cmdSubmit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.t = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Location = New System.Drawing.Point(532, 184)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(155, 20)
        Me.txtID.TabIndex = 19
        '
        'txtRemarks
        '
        Me.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRemarks.Location = New System.Drawing.Point(267, 227)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(205, 20)
        Me.txtRemarks.TabIndex = 18
        '
        'txtATCClass
        '
        Me.txtATCClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtATCClass.Location = New System.Drawing.Point(267, 184)
        Me.txtATCClass.Name = "txtATCClass"
        Me.txtATCClass.Size = New System.Drawing.Size(205, 20)
        Me.txtATCClass.TabIndex = 17
        '
        'txtMIMSClass
        '
        Me.txtMIMSClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMIMSClass.Location = New System.Drawing.Point(267, 137)
        Me.txtMIMSClass.Name = "txtMIMSClass"
        Me.txtMIMSClass.Size = New System.Drawing.Size(205, 20)
        Me.txtMIMSClass.TabIndex = 16
        '
        'txtMedPacking
        '
        Me.txtMedPacking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMedPacking.Location = New System.Drawing.Point(267, 99)
        Me.txtMedPacking.Name = "txtMedPacking"
        Me.txtMedPacking.Size = New System.Drawing.Size(205, 20)
        Me.txtMedPacking.TabIndex = 15
        '
        'txtMedName
        '
        Me.txtMedName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMedName.Location = New System.Drawing.Point(267, 56)
        Me.txtMedName.Name = "txtMedName"
        Me.txtMedName.Size = New System.Drawing.Size(205, 20)
        Me.txtMedName.TabIndex = 14
        '
        'cmdSubmit
        '
        Me.cmdSubmit.Location = New System.Drawing.Point(544, 216)
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.Size = New System.Drawing.Size(113, 38)
        Me.cmdSubmit.TabIndex = 13
        Me.cmdSubmit.Text = "search"
        Me.cmdSubmit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(508, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(175, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Medicine Name:"
        '
        't
        '
        Me.t.AutoSize = True
        Me.t.Location = New System.Drawing.Point(164, 101)
        Me.t.Name = "t"
        Me.t.Size = New System.Drawing.Size(95, 13)
        Me.t.TabIndex = 21
        Me.t.Text = "Medicine Packing:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(193, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "MIMS Class:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(198, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "ATC Class:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(207, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Remarks:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(154, 312)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(0, 20)
        Me.TextBox1.TabIndex = 26
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.t)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtATCClass)
        Me.Controls.Add(Me.txtMIMSClass)
        Me.Controls.Add(Me.txtMedPacking)
        Me.Controls.Add(Me.txtMedName)
        Me.Controls.Add(Me.cmdSubmit)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents txtATCClass As TextBox
    Friend WithEvents txtMIMSClass As TextBox
    Friend WithEvents txtMedPacking As TextBox
    Friend WithEvents txtMedName As TextBox
    Friend WithEvents cmdSubmit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents t As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
