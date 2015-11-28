﻿namespace JustGestures.WizardItems
{
    partial class UC_W_wheelBtn
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_mouseWheel = new System.Windows.Forms.Label();
            this.lbl_and = new System.Windows.Forms.Label();
            this.cb_trigger = new System.Windows.Forms.ComboBox();
            this.lbl_triggerBtn = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gB_description.SuspendLayout();
            this.gB_activation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_animation)).BeginInit();
            this.gB_gesture.SuspendLayout();
            this.gB_preview.SuspendLayout();
            this.SuspendLayout();
            // 
            // gB_activation
            // 
            this.gB_activation.Controls.Add(this.lbl_mouseWheel);
            this.gB_activation.Controls.Add(this.lbl_and);
            this.gB_activation.Controls.Add(this.cb_trigger);
            this.gB_activation.Controls.Add(this.lbl_triggerBtn);
            // 
            // rTB_instructions
            // 
            this.rTB_instructions.Location = new System.Drawing.Point(19, 68);
            this.rTB_instructions.Size = new System.Drawing.Size(563, 31);
            // 
            // lbl_instructions
            // 
            this.lbl_instructions.Location = new System.Drawing.Point(16, 52);
            // 
            // cB_gesture
            // 
            this.cB_gesture.Size = new System.Drawing.Size(176, 17);
            this.cB_gesture.Text = "Wheel Button Combination";
            // 
            // lbl_mouseWheel
            // 
            this.lbl_mouseWheel.AutoSize = true;
            this.lbl_mouseWheel.Location = new System.Drawing.Point(250, 22);
            this.lbl_mouseWheel.Name = "lbl_mouseWheel";
            this.lbl_mouseWheel.Size = new System.Drawing.Size(73, 13);
            this.lbl_mouseWheel.TabIndex = 13;
            this.lbl_mouseWheel.Text = "Mouse Wheel";
            // 
            // lbl_and
            // 
            this.lbl_and.AutoSize = true;
            this.lbl_and.Location = new System.Drawing.Point(187, 22);
            this.lbl_and.Name = "lbl_and";
            this.lbl_and.Size = new System.Drawing.Size(25, 13);
            this.lbl_and.TabIndex = 12;
            this.lbl_and.Text = "and";
            // 
            // cb_trigger
            // 
            this.cb_trigger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_trigger.Enabled = false;
            this.cb_trigger.FormattingEnabled = true;
            this.cb_trigger.Items.AddRange(new object[] {
            "XButton1"});
            this.cb_trigger.Location = new System.Drawing.Point(33, 38);
            this.cb_trigger.Name = "cb_trigger";
            this.cb_trigger.Size = new System.Drawing.Size(130, 21);
            this.cb_trigger.TabIndex = 11;
            // 
            // lbl_triggerBtn
            // 
            this.lbl_triggerBtn.AutoSize = true;
            this.lbl_triggerBtn.Location = new System.Drawing.Point(30, 22);
            this.lbl_triggerBtn.Name = "lbl_triggerBtn";
            this.lbl_triggerBtn.Size = new System.Drawing.Size(74, 13);
            this.lbl_triggerBtn.TabIndex = 10;
            this.lbl_triggerBtn.Text = "Trigger Button";
            // 
            // UC_W_wheelBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UC_W_wheelBtn";
            this.panel1.ResumeLayout(false);
            this.gB_description.ResumeLayout(false);
            this.gB_activation.ResumeLayout(false);
            this.gB_activation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_animation)).EndInit();
            this.gB_gesture.ResumeLayout(false);
            this.gB_gesture.PerformLayout();
            this.gB_preview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_mouseWheel;
        private System.Windows.Forms.Label lbl_and;
        private System.Windows.Forms.ComboBox cb_trigger;
        private System.Windows.Forms.Label lbl_triggerBtn;
    }
}
