namespace PRODIGY_SD_02
{
    partial class form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            contentPanel = new Panel();
            successResultLabel = new Label();
            revealTargetLabel = new Label();
            resultLabel = new Label();
            resultProgressBar = new ProgressBar();
            inputTextBox = new TextBox();
            guessButton = new Button();
            noteLabel = new Label();
            newGameButton = new Button();
            titleLabel = new Label();
            contentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // contentPanel
            // 
            contentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contentPanel.BackColor = SystemColors.ControlDark;
            contentPanel.Controls.Add(successResultLabel);
            contentPanel.Controls.Add(revealTargetLabel);
            contentPanel.Controls.Add(resultLabel);
            contentPanel.Controls.Add(resultProgressBar);
            contentPanel.Controls.Add(inputTextBox);
            contentPanel.Controls.Add(guessButton);
            contentPanel.Controls.Add(noteLabel);
            contentPanel.Controls.Add(newGameButton);
            contentPanel.Controls.Add(titleLabel);
            contentPanel.Location = new Point(12, 12);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(5);
            contentPanel.Size = new Size(660, 337);
            contentPanel.TabIndex = 0;
            // 
            // successResultLabel
            // 
            successResultLabel.Anchor = AnchorStyles.None;
            successResultLabel.AutoEllipsis = true;
            successResultLabel.AutoSize = true;
            successResultLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            successResultLabel.Location = new Point(102, 183);
            successResultLabel.Name = "successResultLabel";
            successResultLabel.Size = new Size(32, 20);
            successResultLabel.TabIndex = 8;
            successResultLabel.Text = "Hi..";
            successResultLabel.Visible = false;
            // 
            // revealTargetLabel
            // 
            revealTargetLabel.Anchor = AnchorStyles.None;
            revealTargetLabel.AutoSize = true;
            revealTargetLabel.BackColor = SystemColors.WindowText;
            revealTargetLabel.FlatStyle = FlatStyle.Popup;
            revealTargetLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            revealTargetLabel.ForeColor = Color.White;
            revealTargetLabel.Location = new Point(146, 74);
            revealTargetLabel.Margin = new Padding(3);
            revealTargetLabel.MaximumSize = new Size(65, 80);
            revealTargetLabel.Name = "revealTargetLabel";
            revealTargetLabel.Size = new Size(58, 60);
            revealTargetLabel.TabIndex = 7;
            revealTargetLabel.Text = "Click here to reveal the number";
            revealTargetLabel.TextAlign = ContentAlignment.MiddleCenter;
            revealTargetLabel.Click += revealTargetLabel_Click;
            // 
            // resultLabel
            // 
            resultLabel.Anchor = AnchorStyles.None;
            resultLabel.AutoEllipsis = true;
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultLabel.Location = new Point(228, 183);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(29, 20);
            resultLabel.TabIndex = 6;
            resultLabel.Text = "Hi!";
            resultLabel.Visible = false;
            // 
            // resultProgressBar
            // 
            resultProgressBar.Anchor = AnchorStyles.None;
            resultProgressBar.Location = new Point(199, 231);
            resultProgressBar.MaximumSize = new Size(350, 25);
            resultProgressBar.MinimumSize = new Size(250, 20);
            resultProgressBar.Name = "resultProgressBar";
            resultProgressBar.Size = new Size(286, 23);
            resultProgressBar.TabIndex = 5;
            // 
            // inputTextBox
            // 
            inputTextBox.Anchor = AnchorStyles.None;
            inputTextBox.Location = new Point(245, 131);
            inputTextBox.MaximumSize = new Size(150, 50);
            inputTextBox.MinimumSize = new Size(75, 15);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(100, 23);
            inputTextBox.TabIndex = 4;
            // 
            // guessButton
            // 
            guessButton.Anchor = AnchorStyles.None;
            guessButton.Location = new Point(351, 126);
            guessButton.MaximumSize = new Size(100, 30);
            guessButton.Name = "guessButton";
            guessButton.Size = new Size(75, 30);
            guessButton.TabIndex = 3;
            guessButton.Text = "Guess";
            guessButton.UseVisualStyleBackColor = true;
            guessButton.Click += guessButton_Click;
            // 
            // noteLabel
            // 
            noteLabel.Anchor = AnchorStyles.None;
            noteLabel.AutoSize = true;
            noteLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            noteLabel.Location = new Point(228, 74);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new Size(224, 17);
            noteLabel.TabIndex = 2;
            noteLabel.Text = "Guess a number between 0 and 100";
            // 
            // newGameButton
            // 
            newGameButton.Anchor = AnchorStyles.None;
            newGameButton.BackColor = SystemColors.ActiveCaption;
            newGameButton.FlatAppearance.BorderSize = 0;
            newGameButton.FlatStyle = FlatStyle.Flat;
            newGameButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newGameButton.ForeColor = SystemColors.HighlightText;
            newGameButton.Location = new Point(264, 283);
            newGameButton.Name = "newGameButton";
            newGameButton.Size = new Size(150, 30);
            newGameButton.TabIndex = 1;
            newGameButton.Text = "play a new game";
            newGameButton.UseVisualStyleBackColor = false;
            newGameButton.Click += newGameButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.None;
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(199, 23);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(286, 32);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Number Guessing Game!";
            // 
            // form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(684, 361);
            Controls.Add(contentPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(500, 400);
            Name = "form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guessing Quiz";
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel contentPanel;
        private Label titleLabel;
        private Button newGameButton;
        private Label noteLabel;
        private Button guessButton;
        private Label resultLabel;
        private ProgressBar resultProgressBar;
        private TextBox inputTextBox;
        private Label revealTargetLabel;
        private Label successResultLabel;
    }
}
