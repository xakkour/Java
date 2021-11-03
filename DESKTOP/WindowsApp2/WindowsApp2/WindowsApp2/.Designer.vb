<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Synoptique = New System.Windows.Forms.Button()
        Me.Historique = New System.Windows.Forms.Button()
        Me.Courbe = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Synoptique
        '
        Me.Synoptique.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Synoptique.Location = New System.Drawing.Point(237, 69)
        Me.Synoptique.Name = "Synoptique"
        Me.Synoptique.Size = New System.Drawing.Size(179, 25)
        Me.Synoptique.TabIndex = 0
        Me.Synoptique.Text = "Synoptique"
        Me.Synoptique.UseVisualStyleBackColor = True
        '
        'Historique
        '
        Me.Historique.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Historique.Location = New System.Drawing.Point(237, 164)
        Me.Historique.Name = "Historique"
        Me.Historique.Size = New System.Drawing.Size(179, 30)
        Me.Historique.TabIndex = 1
        Me.Historique.Text = "Historique"
        Me.Historique.UseVisualStyleBackColor = True
        '
        'Courbe
        '
        Me.Courbe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Courbe.Location = New System.Drawing.Point(237, 270)
        Me.Courbe.Name = "Courbe"
        Me.Courbe.Size = New System.Drawing.Size(179, 23)
        Me.Courbe.TabIndex = 2
        Me.Courbe.Text = "Courbe"
        Me.Courbe.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(659, 385)
        Me.Controls.Add(Me.Courbe)
        Me.Controls.Add(Me.Historique)
        Me.Controls.Add(Me.Synoptique)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "page d'aceuil"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Synoptique As Button
    Friend WithEvents Historique As Button
    Friend WithEvents Courbe As Button
End Class
