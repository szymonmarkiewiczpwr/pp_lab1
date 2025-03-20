namespace pp_lab1_forms
{
    partial class MainForm
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
            itemsAmountInput = new TextBox();
            overrideItemsAmount = new CheckBox();
            rngStateInput = new TextBox();
            performSolveButton = new Button();
            generatedItemsList = new ListBox();
            resultsItemList = new ListBox();
            backpackCapacityInput = new TextBox();
            SuspendLayout();
            // 
            // itemsAmountInput
            // 
            itemsAmountInput.Enabled = false;
            itemsAmountInput.Location = new Point(12, 41);
            itemsAmountInput.Name = "itemsAmountInput";
            itemsAmountInput.PlaceholderText = "Items Amount";
            itemsAmountInput.Size = new Size(235, 23);
            itemsAmountInput.TabIndex = 0;
            itemsAmountInput.Validating += itemsAmountInput_Validating;
            // 
            // overrideItemsAmount
            // 
            overrideItemsAmount.AutoSize = true;
            overrideItemsAmount.Location = new Point(253, 45);
            overrideItemsAmount.Name = "overrideItemsAmount";
            overrideItemsAmount.Size = new Size(150, 19);
            overrideItemsAmount.TabIndex = 1;
            overrideItemsAmount.Text = "Override Items Amount";
            overrideItemsAmount.UseVisualStyleBackColor = true;
            overrideItemsAmount.CheckedChanged += overrideItemsAmount_CheckedChanged;
            // 
            // rngStateInput
            // 
            rngStateInput.Location = new Point(12, 12);
            rngStateInput.Name = "rngStateInput";
            rngStateInput.PlaceholderText = "RNG State";
            rngStateInput.Size = new Size(390, 23);
            rngStateInput.TabIndex = 2;
            rngStateInput.TextChanged += rngStateInput_TextChanged;
            rngStateInput.Validating += rngStateInput_Validating;
            // 
            // performSolveButton
            // 
            performSolveButton.Location = new Point(327, 126);
            performSolveButton.Name = "performSolveButton";
            performSolveButton.Size = new Size(75, 23);
            performSolveButton.TabIndex = 3;
            performSolveButton.Text = "Solve";
            performSolveButton.UseVisualStyleBackColor = true;
            performSolveButton.Click += performSolveButton_Click;
            // 
            // generatedItemsList
            // 
            generatedItemsList.FormattingEnabled = true;
            generatedItemsList.ItemHeight = 15;
            generatedItemsList.Location = new Point(12, 155);
            generatedItemsList.Name = "generatedItemsList";
            generatedItemsList.Size = new Size(170, 289);
            generatedItemsList.TabIndex = 4;
            // 
            // resultsItemList
            // 
            resultsItemList.FormattingEnabled = true;
            resultsItemList.ItemHeight = 15;
            resultsItemList.Location = new Point(232, 155);
            resultsItemList.Name = "resultsItemList";
            resultsItemList.Size = new Size(170, 289);
            resultsItemList.TabIndex = 5;
            resultsItemList.SelectedIndexChanged += resultsItemList_SelectedIndexChanged;
            // 
            // backpackCapacityInput
            // 
            backpackCapacityInput.Location = new Point(12, 70);
            backpackCapacityInput.Name = "backpackCapacityInput";
            backpackCapacityInput.PlaceholderText = "Backpack Capacity";
            backpackCapacityInput.Size = new Size(390, 23);
            backpackCapacityInput.TabIndex = 6;
            backpackCapacityInput.Validating += backpackCapacityInput_Validating;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 450);
            Controls.Add(backpackCapacityInput);
            Controls.Add(resultsItemList);
            Controls.Add(generatedItemsList);
            Controls.Add(performSolveButton);
            Controls.Add(rngStateInput);
            Controls.Add(overrideItemsAmount);
            Controls.Add(itemsAmountInput);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox itemsAmountInput;
        private CheckBox overrideItemsAmount;
        private TextBox rngStateInput;
        private Button performSolveButton;
        private ListBox generatedItemsList;
        private ListBox resultsItemList;
        private TextBox backpackCapacityInput;
    }
}
