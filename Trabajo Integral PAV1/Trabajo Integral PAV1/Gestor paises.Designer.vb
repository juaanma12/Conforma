﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestor_paises
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.tabla_paises = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.cmd_modificar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_hora = New System.Windows.Forms.Label()
        CType(Me.tabla_paises, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(131, 28)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(199, 25)
        Me.Label22.TabIndex = 36
        Me.Label22.Text = "Gestor de Paises"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.Location = New System.Drawing.Point(15, 109)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(76, 20)
        Me.lbl_nombre.TabIndex = 37
        Me.lbl_nombre.Text = "Nombre:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(97, 111)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(121, 20)
        Me.txt_nombre.TabIndex = 0
        '
        'tabla_paises
        '
        Me.tabla_paises.AllowUserToAddRows = False
        Me.tabla_paises.AllowUserToDeleteRows = False
        Me.tabla_paises.AllowUserToResizeColumns = False
        Me.tabla_paises.AllowUserToResizeRows = False
        Me.tabla_paises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla_paises.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nombre})
        Me.tabla_paises.Location = New System.Drawing.Point(21, 160)
        Me.tabla_paises.Name = "tabla_paises"
        Me.tabla_paises.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabla_paises.Size = New System.Drawing.Size(434, 150)
        Me.tabla_paises.TabIndex = 39
        '
        'id
        '
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.Width = 390
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmd_eliminar.Enabled = False
        Me.cmd_eliminar.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources._61848_deltton
        Me.cmd_eliminar.Location = New System.Drawing.Point(221, 338)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(80, 80)
        Me.cmd_eliminar.TabIndex = 43
        Me.cmd_eliminar.UseVisualStyleBackColor = False
        '
        'cmd_modificar
        '
        Me.cmd_modificar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmd_modificar.Enabled = False
        Me.cmd_modificar.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources.f02a629827a6_4542
        Me.cmd_modificar.Location = New System.Drawing.Point(120, 338)
        Me.cmd_modificar.Name = "cmd_modificar"
        Me.cmd_modificar.Size = New System.Drawing.Size(80, 80)
        Me.cmd_modificar.TabIndex = 42
        Me.cmd_modificar.UseVisualStyleBackColor = False
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.BackColor = System.Drawing.Color.Gainsboro
        Me.cmd_nuevo.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources._554545
        Me.cmd_nuevo.Location = New System.Drawing.Point(19, 338)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(80, 80)
        Me.cmd_nuevo.TabIndex = 40
        Me.cmd_nuevo.UseVisualStyleBackColor = False
        '
        'cmd_salir
        '
        Me.cmd_salir.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmd_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_salir.Location = New System.Drawing.Point(371, 363)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(84, 55)
        Me.cmd_salir.TabIndex = 44
        Me.cmd_salir.Text = "Salir"
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lbl_hora
        '
        Me.lbl_hora.Location = New System.Drawing.Point(340, 9)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(124, 14)
        Me.lbl_hora.TabIndex = 45
        Me.lbl_hora.Text = "Label22"
        '
        'gestor_paises
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 456)
        Me.Controls.Add(Me.lbl_hora)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.cmd_modificar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.tabla_paises)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.Label22)
        Me.Name = "gestor_paises"
        Me.Text = "Gestor_paises"
        CType(Me.tabla_paises, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents tabla_paises As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_modificar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_hora As System.Windows.Forms.Label
End Class
