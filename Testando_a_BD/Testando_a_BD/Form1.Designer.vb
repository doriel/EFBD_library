<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.UtilizadoresDataSet = New Testando_a_BD.utilizadoresDataSet()
        Me.UtilizadorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UtilizadorTableAdapter = New Testando_a_BD.utilizadoresDataSetTableAdapters.utilizadorTableAdapter()
        Me.TableAdapterManager = New Testando_a_BD.utilizadoresDataSetTableAdapters.TableAdapterManager()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.UtilizadoresDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtilizadorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UtilizadoresDataSet
        '
        Me.UtilizadoresDataSet.DataSetName = "utilizadoresDataSet"
        Me.UtilizadoresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UtilizadorBindingSource
        '
        Me.UtilizadorBindingSource.DataMember = "utilizador"
        Me.UtilizadorBindingSource.DataSource = Me.UtilizadoresDataSet
        '
        'UtilizadorTableAdapter
        '
        Me.UtilizadorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Testando_a_BD.utilizadoresDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.utilizadorTableAdapter = Me.UtilizadorTableAdapter
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(257, 169)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(272, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(257, 207)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(272, 20)
        Me.TextBox2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(257, 272)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(272, 37)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 435)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.UtilizadoresDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtilizadorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UtilizadoresDataSet As Testando_a_BD.utilizadoresDataSet
    Friend WithEvents UtilizadorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UtilizadorTableAdapter As Testando_a_BD.utilizadoresDataSetTableAdapters.utilizadorTableAdapter
    Friend WithEvents TableAdapterManager As Testando_a_BD.utilizadoresDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
