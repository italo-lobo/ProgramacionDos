namespace messageQueue
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.messageQueue1 = new System.Messaging.MessageQueue();
            this.txtMensajeEnvio = new System.Windows.Forms.TextBox();
            this.cmdEnviar = new System.Windows.Forms.Button();
            this.cmdRecibir = new System.Windows.Forms.Button();
            this.rtbMensajesRecibidos = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // messageQueue1
            // 
            this.messageQueue1.DefaultPropertiesToSend.HashAlgorithm = System.Messaging.HashAlgorithm.Sha512;
            this.messageQueue1.MessageReadPropertyFilter.LookupId = true;
            this.messageQueue1.SynchronizingObject = this;
            // 
            // txtMensajeEnvio
            // 
            this.txtMensajeEnvio.Location = new System.Drawing.Point(35, 59);
            this.txtMensajeEnvio.Name = "txtMensajeEnvio";
            this.txtMensajeEnvio.Size = new System.Drawing.Size(100, 20);
            this.txtMensajeEnvio.TabIndex = 0;
            // 
            // cmdEnviar
            // 
            this.cmdEnviar.Location = new System.Drawing.Point(168, 58);
            this.cmdEnviar.Name = "cmdEnviar";
            this.cmdEnviar.Size = new System.Drawing.Size(75, 23);
            this.cmdEnviar.TabIndex = 1;
            this.cmdEnviar.Text = "ENVIAR";
            this.cmdEnviar.UseVisualStyleBackColor = true;
            this.cmdEnviar.Click += new System.EventHandler(this.cmdEnviar_Click);
            // 
            // cmdRecibir
            // 
            this.cmdRecibir.Location = new System.Drawing.Point(276, 58);
            this.cmdRecibir.Name = "cmdRecibir";
            this.cmdRecibir.Size = new System.Drawing.Size(75, 23);
            this.cmdRecibir.TabIndex = 2;
            this.cmdRecibir.Text = "Recibir";
            this.cmdRecibir.UseVisualStyleBackColor = true;
            this.cmdRecibir.Click += new System.EventHandler(this.cmdRecibir_Click);
            // 
            // rtbMensajesRecibidos
            // 
            this.rtbMensajesRecibidos.Location = new System.Drawing.Point(35, 115);
            this.rtbMensajesRecibidos.Name = "rtbMensajesRecibidos";
            this.rtbMensajesRecibidos.Size = new System.Drawing.Size(316, 133);
            this.rtbMensajesRecibidos.TabIndex = 3;
            this.rtbMensajesRecibidos.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 270);
            this.Controls.Add(this.rtbMensajesRecibidos);
            this.Controls.Add(this.cmdRecibir);
            this.Controls.Add(this.cmdEnviar);
            this.Controls.Add(this.txtMensajeEnvio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "msmq ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Messaging.MessageQueue messageQueue1;
        private System.Windows.Forms.RichTextBox rtbMensajesRecibidos;
        private System.Windows.Forms.Button cmdRecibir;
        private System.Windows.Forms.Button cmdEnviar;
        private System.Windows.Forms.TextBox txtMensajeEnvio;
    }
}

