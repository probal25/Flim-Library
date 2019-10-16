namespace Flim_Library
{
    partial class Profile
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanelOverview = new MetroFramework.Controls.MetroPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOverView_2 = new System.Windows.Forms.Label();
            this.labelOverView = new System.Windows.Forms.Label();
            this.metroPanelOverview.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanelOverview
            // 
            this.metroPanelOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanelOverview.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroPanelOverview.Controls.Add(this.label1);
            this.metroPanelOverview.Controls.Add(this.labelOverView_2);
            this.metroPanelOverview.Controls.Add(this.labelOverView);
            this.metroPanelOverview.HorizontalScrollbarBarColor = true;
            this.metroPanelOverview.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelOverview.HorizontalScrollbarSize = 10;
            this.metroPanelOverview.Location = new System.Drawing.Point(0, 22);
            this.metroPanelOverview.Name = "metroPanelOverview";
            this.metroPanelOverview.Size = new System.Drawing.Size(916, 82);
            this.metroPanelOverview.TabIndex = 2;
            this.metroPanelOverview.UseCustomBackColor = true;
            this.metroPanelOverview.UseCustomForeColor = true;
            this.metroPanelOverview.UseStyleColors = true;
            this.metroPanelOverview.VerticalScrollbar = true;
            this.metroPanelOverview.VerticalScrollbarBarColor = true;
            this.metroPanelOverview.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelOverview.VerticalScrollbarSize = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Prestige Elite Std", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(744, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Profile";
            // 
            // labelOverView_2
            // 
            this.labelOverView_2.AutoSize = true;
            this.labelOverView_2.Font = new System.Drawing.Font("Tekton Pro Ext", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOverView_2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelOverView_2.Location = new System.Drawing.Point(24, 60);
            this.labelOverView_2.Name = "labelOverView_2";
            this.labelOverView_2.Size = new System.Drawing.Size(300, 18);
            this.labelOverView_2.TabIndex = 3;
            this.labelOverView_2.Text = "YOUR PERSONAL MOVIE DATABASE";
            // 
            // labelOverView
            // 
            this.labelOverView.AutoSize = true;
            this.labelOverView.Font = new System.Drawing.Font("SketchFlow Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOverView.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelOverView.Location = new System.Drawing.Point(21, 12);
            this.labelOverView.Name = "labelOverView";
            this.labelOverView.Size = new System.Drawing.Size(197, 34);
            this.labelOverView.TabIndex = 2;
            this.labelOverView.Text = "MOTION DB";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 566);
            this.Controls.Add(this.metroPanelOverview);
            this.Name = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.metroPanelOverview.ResumeLayout(false);
            this.metroPanelOverview.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelOverview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOverView_2;
        private System.Windows.Forms.Label labelOverView;
    }
}