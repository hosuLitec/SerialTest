namespace SerialTest
{
  partial class Form1
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.lblComPort = new System.Windows.Forms.Label();
      this.cboComPort = new System.Windows.Forms.ComboBox();
      this.lblComInfo = new System.Windows.Forms.Label();
      this.lblNumber = new System.Windows.Forms.Label();
      this.numNumber = new System.Windows.Forms.NumericUpDown();
      this.lblData = new System.Windows.Forms.Label();
      this.cmdOpenPort = new System.Windows.Forms.Button();
      this.cmdClosePort = new System.Windows.Forms.Button();
      this.cmdSend = new System.Windows.Forms.Button();
      this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.numNumber)).BeginInit();
      this.SuspendLayout();
      // 
      // lblComPort
      // 
      this.lblComPort.AutoSize = true;
      this.lblComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblComPort.Location = new System.Drawing.Point(68, 62);
      this.lblComPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblComPort.Name = "lblComPort";
      this.lblComPort.Size = new System.Drawing.Size(96, 25);
      this.lblComPort.TabIndex = 0;
      this.lblComPort.Text = "Com-Port";
      // 
      // cboComPort
      // 
      this.cboComPort.FormattingEnabled = true;
      this.cboComPort.Location = new System.Drawing.Point(73, 101);
      this.cboComPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.cboComPort.Name = "cboComPort";
      this.cboComPort.Size = new System.Drawing.Size(258, 33);
      this.cboComPort.TabIndex = 1;
      // 
      // lblComInfo
      // 
      this.lblComInfo.AutoSize = true;
      this.lblComInfo.Location = new System.Drawing.Point(78, 185);
      this.lblComInfo.Name = "lblComInfo";
      this.lblComInfo.Size = new System.Drawing.Size(47, 25);
      this.lblComInfo.TabIndex = 2;
      this.lblComInfo.Text = "-----";
      // 
      // lblNumber
      // 
      this.lblNumber.AutoSize = true;
      this.lblNumber.Location = new System.Drawing.Point(82, 249);
      this.lblNumber.Name = "lblNumber";
      this.lblNumber.Size = new System.Drawing.Size(50, 25);
      this.lblNumber.TabIndex = 3;
      this.lblNumber.Text = "Zahl";
      // 
      // numNumber
      // 
      this.numNumber.Location = new System.Drawing.Point(172, 244);
      this.numNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.numNumber.Name = "numNumber";
      this.numNumber.Size = new System.Drawing.Size(120, 30);
      this.numNumber.TabIndex = 4;
      // 
      // lblData
      // 
      this.lblData.AutoSize = true;
      this.lblData.Location = new System.Drawing.Point(78, 313);
      this.lblData.Name = "lblData";
      this.lblData.Size = new System.Drawing.Size(47, 25);
      this.lblData.TabIndex = 5;
      this.lblData.Text = "-----";
      // 
      // cmdOpenPort
      // 
      this.cmdOpenPort.Location = new System.Drawing.Point(403, 86);
      this.cmdOpenPort.Name = "cmdOpenPort";
      this.cmdOpenPort.Size = new System.Drawing.Size(131, 59);
      this.cmdOpenPort.TabIndex = 6;
      this.cmdOpenPort.Text = "Port öffnen";
      this.cmdOpenPort.UseVisualStyleBackColor = true;
      this.cmdOpenPort.Click += new System.EventHandler(this.cmdOpenPort_Click);
      // 
      // cmdClosePort
      // 
      this.cmdClosePort.Location = new System.Drawing.Point(572, 87);
      this.cmdClosePort.Name = "cmdClosePort";
      this.cmdClosePort.Size = new System.Drawing.Size(131, 59);
      this.cmdClosePort.TabIndex = 7;
      this.cmdClosePort.Text = "Port schließen";
      this.cmdClosePort.UseVisualStyleBackColor = true;
      this.cmdClosePort.Click += new System.EventHandler(this.cmdClosePort_Click);
      // 
      // cmdSend
      // 
      this.cmdSend.Location = new System.Drawing.Point(403, 232);
      this.cmdSend.Name = "cmdSend";
      this.cmdSend.Size = new System.Drawing.Size(131, 59);
      this.cmdSend.TabIndex = 8;
      this.cmdSend.Text = "Zahl senden";
      this.cmdSend.UseVisualStyleBackColor = true;
      this.cmdSend.Click += new System.EventHandler(this.cmdSend_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1018, 544);
      this.Controls.Add(this.cmdSend);
      this.Controls.Add(this.cmdClosePort);
      this.Controls.Add(this.cmdOpenPort);
      this.Controls.Add(this.lblData);
      this.Controls.Add(this.numNumber);
      this.Controls.Add(this.lblNumber);
      this.Controls.Add(this.lblComInfo);
      this.Controls.Add(this.cboComPort);
      this.Controls.Add(this.lblComPort);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "Form1";
      this.Text = "Mikrocontroller-Kommunikation";
      ((System.ComponentModel.ISupportInitialize)(this.numNumber)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblComPort;
    private System.Windows.Forms.ComboBox cboComPort;
    private System.Windows.Forms.Label lblComInfo;
    private System.Windows.Forms.Label lblNumber;
    private System.Windows.Forms.NumericUpDown numNumber;
    private System.Windows.Forms.Label lblData;
    private System.Windows.Forms.Button cmdOpenPort;
    private System.Windows.Forms.Button cmdClosePort;
    private System.Windows.Forms.Button cmdSend;
    private System.IO.Ports.SerialPort serialPort1;
  }
}

