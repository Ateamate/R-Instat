﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgOneWayANOVA
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
        Me.lblYVariate = New System.Windows.Forms.Label()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.lblFittedModel = New System.Windows.Forms.Label()
        Me.txtFittedModel = New System.Windows.Forms.TextBox()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.ucrAddRemoveDataFrame = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrYVariate = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrFactor = New instat.ucrReceiverSingle()
        Me.SuspendLayout()
        '
        'lblYVariate
        '
        Me.lblYVariate.AutoSize = True
        Me.lblYVariate.Location = New System.Drawing.Point(271, 98)
        Me.lblYVariate.Name = "lblYVariate"
        Me.lblYVariate.Size = New System.Drawing.Size(49, 13)
        Me.lblYVariate.TabIndex = 5
        Me.lblYVariate.Tag = "Y variate"
        Me.lblYVariate.Text = "Y-variate"
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(272, 148)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(37, 13)
        Me.lblFactor.TabIndex = 6
        Me.lblFactor.Tag = "Factor"
        Me.lblFactor.Text = "Factor"
        '
        'lblFittedModel
        '
        Me.lblFittedModel.AutoSize = True
        Me.lblFittedModel.Location = New System.Drawing.Point(1, 221)
        Me.lblFittedModel.Name = "lblFittedModel"
        Me.lblFittedModel.Size = New System.Drawing.Size(64, 13)
        Me.lblFittedModel.TabIndex = 9
        Me.lblFittedModel.Tag = "Fitted_model"
        Me.lblFittedModel.Text = "Fitted model"
        '
        'txtFittedModel
        '
        Me.txtFittedModel.Location = New System.Drawing.Point(84, 221)
        Me.txtFittedModel.Name = "txtFittedModel"
        Me.txtFittedModel.Size = New System.Drawing.Size(236, 20)
        Me.txtFittedModel.TabIndex = 10
        Me.txtFittedModel.Tag = "Last_ANOVA"
        Me.txtFittedModel.Text = "Last ANOVA"
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(4, 259)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(75, 23)
        Me.cmdOptions.TabIndex = 11
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrAddRemoveDataFrame
        '
        Me.ucrAddRemoveDataFrame.Location = New System.Drawing.Point(4, 20)
        Me.ucrAddRemoveDataFrame.Name = "ucrAddRemoveDataFrame"
        Me.ucrAddRemoveDataFrame.Size = New System.Drawing.Size(242, 179)
        Me.ucrAddRemoveDataFrame.TabIndex = 8
        '
        'ucrYVariate
        '
        Me.ucrYVariate.Location = New System.Drawing.Point(265, 112)
        Me.ucrYVariate.Name = "ucrYVariate"
        Me.ucrYVariate.Size = New System.Drawing.Size(106, 26)
        Me.ucrYVariate.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(4, 295)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 57)
        Me.ucrBase.TabIndex = 0
        '
        'ucrFactor
        '
        Me.ucrFactor.Location = New System.Drawing.Point(265, 160)
        Me.ucrFactor.Name = "ucrFactor"
        Me.ucrFactor.Size = New System.Drawing.Size(106, 26)
        Me.ucrFactor.TabIndex = 4
        '
        'dlgOneWayANOVA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 346)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.txtFittedModel)
        Me.Controls.Add(Me.lblFittedModel)
        Me.Controls.Add(Me.ucrAddRemoveDataFrame)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.lblYVariate)
        Me.Controls.Add(Me.ucrFactor)
        Me.Controls.Add(Me.ucrYVariate)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgOneWayANOVA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "One_Way_ANOVAN"
        Me.Text = "One Way ANOVA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrYVariate As ucrReceiverSingle
    Friend WithEvents lblYVariate As Label
    Friend WithEvents lblFactor As Label
    Friend WithEvents ucrAddRemoveDataFrame As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblFittedModel As Label
    Friend WithEvents txtFittedModel As TextBox
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrFactor As ucrReceiverSingle
End Class
