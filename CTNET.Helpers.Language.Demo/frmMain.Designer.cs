namespace CTNET.Helpers.Language.Test
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtText = new System.Windows.Forms.TextBox();
            this.cboLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.butTranslate = new System.Windows.Forms.Button();
            this.txtTranslation = new System.Windows.Forms.TextBox();
            this.lblTranslation = new System.Windows.Forms.Label();
            this.lvDictionary = new System.Windows.Forms.ListView();
            this.colText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTranslation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDictionary = new System.Windows.Forms.Label();
            this.lblNewText = new System.Windows.Forms.Label();
            this.txtNewText = new System.Windows.Forms.TextBox();
            this.txtNewTranslation = new System.Windows.Forms.TextBox();
            this.butAdd = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butRefresh = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.butTranslateUI = new System.Windows.Forms.Button();
            this.butShowForm = new System.Windows.Forms.Button();
            this.lblNewTranslation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtText.Location = new System.Drawing.Point(15, 463);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(252, 20);
            this.txtText.TabIndex = 0;
            // 
            // cboLanguage
            // 
            this.cboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLanguage.FormattingEnabled = true;
            this.cboLanguage.Location = new System.Drawing.Point(15, 37);
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.Size = new System.Drawing.Size(144, 21);
            this.cboLanguage.TabIndex = 1;
            this.cboLanguage.SelectedValueChanged += new System.EventHandler(this.cboLanguage_SelectedValueChanged);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(12, 21);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(55, 13);
            this.lblLanguage.TabIndex = 2;
            this.lblLanguage.Text = "Language";
            // 
            // lblText
            // 
            this.lblText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(12, 447);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(83, 13);
            this.lblText.TabIndex = 3;
            this.lblText.Text = "Text to translate";
            // 
            // butTranslate
            // 
            this.butTranslate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butTranslate.Location = new System.Drawing.Point(532, 460);
            this.butTranslate.Name = "butTranslate";
            this.butTranslate.Size = new System.Drawing.Size(75, 23);
            this.butTranslate.TabIndex = 4;
            this.butTranslate.Text = "Translate";
            this.butTranslate.UseVisualStyleBackColor = true;
            this.butTranslate.Click += new System.EventHandler(this.butTranslate_Click);
            // 
            // txtTranslation
            // 
            this.txtTranslation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTranslation.Location = new System.Drawing.Point(273, 463);
            this.txtTranslation.Name = "txtTranslation";
            this.txtTranslation.Size = new System.Drawing.Size(252, 20);
            this.txtTranslation.TabIndex = 5;
            // 
            // lblTranslation
            // 
            this.lblTranslation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTranslation.AutoSize = true;
            this.lblTranslation.Location = new System.Drawing.Point(270, 447);
            this.lblTranslation.Name = "lblTranslation";
            this.lblTranslation.Size = new System.Drawing.Size(59, 13);
            this.lblTranslation.TabIndex = 6;
            this.lblTranslation.Text = "Translation";
            // 
            // lvDictionary
            // 
            this.lvDictionary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDictionary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colText,
            this.colTranslation});
            this.lvDictionary.GridLines = true;
            this.lvDictionary.HideSelection = false;
            this.lvDictionary.Location = new System.Drawing.Point(12, 143);
            this.lvDictionary.Name = "lvDictionary";
            this.lvDictionary.Size = new System.Drawing.Size(594, 237);
            this.lvDictionary.TabIndex = 7;
            this.lvDictionary.UseCompatibleStateImageBehavior = false;
            this.lvDictionary.View = System.Windows.Forms.View.Details;
            this.lvDictionary.SelectedIndexChanged += new System.EventHandler(this.lvDictionary_SelectedIndexChanged);
            // 
            // colText
            // 
            this.colText.Text = "Text";
            this.colText.Width = 108;
            // 
            // colTranslation
            // 
            this.colTranslation.Text = "Translation";
            this.colTranslation.Width = 142;
            // 
            // lblDictionary
            // 
            this.lblDictionary.AutoSize = true;
            this.lblDictionary.Location = new System.Drawing.Point(12, 127);
            this.lblDictionary.Name = "lblDictionary";
            this.lblDictionary.Size = new System.Drawing.Size(54, 13);
            this.lblDictionary.TabIndex = 8;
            this.lblDictionary.Text = "Dictionary";
            // 
            // lblNewText
            // 
            this.lblNewText.AutoSize = true;
            this.lblNewText.Location = new System.Drawing.Point(12, 72);
            this.lblNewText.Name = "lblNewText";
            this.lblNewText.Size = new System.Drawing.Size(46, 13);
            this.lblNewText.TabIndex = 9;
            this.lblNewText.Text = "Add text";
            // 
            // txtNewText
            // 
            this.txtNewText.Location = new System.Drawing.Point(15, 88);
            this.txtNewText.Name = "txtNewText";
            this.txtNewText.Size = new System.Drawing.Size(178, 20);
            this.txtNewText.TabIndex = 10;
            // 
            // txtNewTranslation
            // 
            this.txtNewTranslation.Location = new System.Drawing.Point(199, 88);
            this.txtNewTranslation.Name = "txtNewTranslation";
            this.txtNewTranslation.Size = new System.Drawing.Size(252, 20);
            this.txtNewTranslation.TabIndex = 11;
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(458, 86);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 23);
            this.butAdd.TabIndex = 12;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butDelete
            // 
            this.butDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butDelete.Location = new System.Drawing.Point(12, 386);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 23);
            this.butDelete.TabIndex = 13;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butRefresh
            // 
            this.butRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butRefresh.Location = new System.Drawing.Point(93, 386);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.Size = new System.Drawing.Size(75, 23);
            this.butRefresh.TabIndex = 14;
            this.butRefresh.Text = "Refresh";
            this.butRefresh.UseVisualStyleBackColor = true;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // butSave
            // 
            this.butSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butSave.Location = new System.Drawing.Point(531, 386);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(75, 23);
            this.butSave.TabIndex = 15;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butTranslateUI
            // 
            this.butTranslateUI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butTranslateUI.Location = new System.Drawing.Point(531, 11);
            this.butTranslateUI.Name = "butTranslateUI";
            this.butTranslateUI.Size = new System.Drawing.Size(75, 23);
            this.butTranslateUI.TabIndex = 16;
            this.butTranslateUI.Text = "Translate UI";
            this.butTranslateUI.UseVisualStyleBackColor = true;
            this.butTranslateUI.Click += new System.EventHandler(this.butTranslateUI_Click);
            // 
            // butShowForm
            // 
            this.butShowForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butShowForm.Location = new System.Drawing.Point(423, 11);
            this.butShowForm.Name = "butShowForm";
            this.butShowForm.Size = new System.Drawing.Size(102, 23);
            this.butShowForm.TabIndex = 17;
            this.butShowForm.Text = "Form Sample";
            this.butShowForm.UseVisualStyleBackColor = true;
            this.butShowForm.Click += new System.EventHandler(this.butShowForm_Click);
            // 
            // lblNewTranslation
            // 
            this.lblNewTranslation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNewTranslation.AutoSize = true;
            this.lblNewTranslation.Location = new System.Drawing.Point(199, 72);
            this.lblNewTranslation.Name = "lblNewTranslation";
            this.lblNewTranslation.Size = new System.Drawing.Size(59, 13);
            this.lblNewTranslation.TabIndex = 18;
            this.lblNewTranslation.Text = "Translation";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 497);
            this.Controls.Add(this.lblNewTranslation);
            this.Controls.Add(this.butShowForm);
            this.Controls.Add(this.butTranslateUI);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.butRefresh);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.txtNewTranslation);
            this.Controls.Add(this.txtNewText);
            this.Controls.Add(this.lblNewText);
            this.Controls.Add(this.lblDictionary);
            this.Controls.Add(this.lvDictionary);
            this.Controls.Add(this.lblTranslation);
            this.Controls.Add(this.txtTranslation);
            this.Controls.Add(this.butTranslate);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.cboLanguage);
            this.Controls.Add(this.txtText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Language Helper Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.ComboBox cboLanguage;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button butTranslate;
        private System.Windows.Forms.TextBox txtTranslation;
        private System.Windows.Forms.Label lblTranslation;
        private System.Windows.Forms.ListView lvDictionary;
        private System.Windows.Forms.Label lblDictionary;
        private System.Windows.Forms.Label lblNewText;
        private System.Windows.Forms.TextBox txtNewText;
        private System.Windows.Forms.TextBox txtNewTranslation;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butRefresh;
        private System.Windows.Forms.ColumnHeader colText;
        private System.Windows.Forms.ColumnHeader colTranslation;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butTranslateUI;
        private System.Windows.Forms.Button butShowForm;
        private System.Windows.Forms.Label lblNewTranslation;
    }
}

