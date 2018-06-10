﻿namespace ShoppingBasket
{
    partial class ShoppingForm
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
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.latestPriceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.offerText = new System.Windows.Forms.RichTextBox();
            this.offerLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityInput = new System.Windows.Forms.NumericUpDown();
            this.basketLabel = new System.Windows.Forms.Label();
            this.noItemsLabel = new System.Windows.Forms.Label();
            this.noItemsText = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalText = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.basketList = new System.Windows.Forms.ListView();
            this.product_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.offer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.discount_cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total_cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.offer_help = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quantityInput)).BeginInit();
            this.SuspendLayout();
            // 
            // productComboBox
            // 
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(32, 39);
            this.productComboBox.MaxDropDownItems = 20;
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(146, 21);
            this.productComboBox.TabIndex = 0;
            this.productComboBox.SelectedIndexChanged += new System.EventHandler(this.productComboBox_SelectedIndexChanged);
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(29, 23);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(78, 13);
            this.productNameLabel.TabIndex = 1;
            this.productNameLabel.Text = "Product Name:";
            // 
            // latestPriceLabel
            // 
            this.latestPriceLabel.AutoSize = true;
            this.latestPriceLabel.Location = new System.Drawing.Point(195, 23);
            this.latestPriceLabel.Name = "latestPriceLabel";
            this.latestPriceLabel.Size = new System.Drawing.Size(66, 13);
            this.latestPriceLabel.TabIndex = 2;
            this.latestPriceLabel.Text = "Latest Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(198, 39);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 3;
            // 
            // offerText
            // 
            this.offerText.Location = new System.Drawing.Point(314, 39);
            this.offerText.Name = "offerText";
            this.offerText.ReadOnly = true;
            this.offerText.Size = new System.Drawing.Size(189, 72);
            this.offerText.TabIndex = 4;
            this.offerText.Text = "";
            // 
            // offerLabel
            // 
            this.offerLabel.AutoSize = true;
            this.offerLabel.Location = new System.Drawing.Point(314, 22);
            this.offerLabel.Name = "offerLabel";
            this.offerLabel.Size = new System.Drawing.Size(33, 13);
            this.offerLabel.TabIndex = 5;
            this.offerLabel.Text = "Offer:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(513, 22);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(49, 13);
            this.quantityLabel.TabIndex = 6;
            this.quantityLabel.Text = "Quantity:";
            // 
            // quantityInput
            // 
            this.quantityInput.Location = new System.Drawing.Point(516, 39);
            this.quantityInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityInput.Name = "quantityInput";
            this.quantityInput.Size = new System.Drawing.Size(74, 20);
            this.quantityInput.TabIndex = 7;
            this.quantityInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // basketLabel
            // 
            this.basketLabel.AutoSize = true;
            this.basketLabel.Location = new System.Drawing.Point(32, 117);
            this.basketLabel.Name = "basketLabel";
            this.basketLabel.Size = new System.Drawing.Size(43, 13);
            this.basketLabel.TabIndex = 9;
            this.basketLabel.Text = "Basket:";
            // 
            // noItemsLabel
            // 
            this.noItemsLabel.AutoSize = true;
            this.noItemsLabel.Location = new System.Drawing.Point(32, 338);
            this.noItemsLabel.Name = "noItemsLabel";
            this.noItemsLabel.Size = new System.Drawing.Size(51, 13);
            this.noItemsLabel.TabIndex = 10;
            this.noItemsLabel.Text = "No items:";
            // 
            // noItemsText
            // 
            this.noItemsText.Location = new System.Drawing.Point(89, 338);
            this.noItemsText.Name = "noItemsText";
            this.noItemsText.ReadOnly = true;
            this.noItemsText.Size = new System.Drawing.Size(100, 20);
            this.noItemsText.TabIndex = 11;
            this.noItemsText.Text = "0";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(225, 338);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 13);
            this.totalLabel.TabIndex = 12;
            this.totalLabel.Text = "Total:";
            // 
            // totalText
            // 
            this.totalText.Location = new System.Drawing.Point(266, 338);
            this.totalText.Name = "totalText";
            this.totalText.ReadOnly = true;
            this.totalText.Size = new System.Drawing.Size(100, 20);
            this.totalText.TabIndex = 13;
            this.totalText.Text = "£0";
            this.totalText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(1096, 36);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(1096, 133);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 15;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1096, 338);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // basketList
            // 
            this.basketList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.basketList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.basketList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.product_name,
            this.quantity,
            this.offer,
            this.cost,
            this.discount_cost,
            this.total_cost,
            this.offer_help});
            this.basketList.FullRowSelect = true;
            this.basketList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.basketList.HideSelection = false;
            this.basketList.Location = new System.Drawing.Point(32, 133);
            this.basketList.MultiSelect = false;
            this.basketList.Name = "basketList";
            this.basketList.ShowGroups = false;
            this.basketList.Size = new System.Drawing.Size(1058, 180);
            this.basketList.TabIndex = 17;
            this.basketList.UseCompatibleStateImageBehavior = false;
            this.basketList.View = System.Windows.Forms.View.Details;
            // 
            // product_name
            // 
            this.product_name.Text = "Product Name";
            this.product_name.Width = 200;
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            // 
            // offer
            // 
            this.offer.Text = "Offer";
            this.offer.Width = 300;
            // 
            // cost
            // 
            this.cost.Text = "Price";
            this.cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // discount_cost
            // 
            this.discount_cost.Text = "Discounted Price";
            this.discount_cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.discount_cost.Width = 100;
            // 
            // total_cost
            // 
            this.total_cost.Text = "Total Price";
            this.total_cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.total_cost.Width = 80;
            // 
            // offer_help
            // 
            this.offer_help.Text = "Applied Offer";
            this.offer_help.Width = 250;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(1096, 290);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "Clear basket";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // ShoppingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 373);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.basketList);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.totalText);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.noItemsText);
            this.Controls.Add(this.noItemsLabel);
            this.Controls.Add(this.basketLabel);
            this.Controls.Add(this.quantityInput);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.offerLabel);
            this.Controls.Add(this.offerText);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.latestPriceLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.productComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ShoppingForm";
            this.Text = "Shopping Basket";
            ((System.ComponentModel.ISupportInitialize)(this.quantityInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label latestPriceLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.RichTextBox offerText;
        private System.Windows.Forms.Label offerLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.NumericUpDown quantityInput;
        private System.Windows.Forms.Label basketLabel;
        private System.Windows.Forms.Label noItemsLabel;
        private System.Windows.Forms.TextBox noItemsText;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalText;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListView basketList;
        private System.Windows.Forms.ColumnHeader product_name;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader offer;
        private System.Windows.Forms.ColumnHeader cost;
        private System.Windows.Forms.ColumnHeader discount_cost;
        private System.Windows.Forms.ColumnHeader total_cost;
        private System.Windows.Forms.ColumnHeader offer_help;
        private System.Windows.Forms.Button clearButton;
    }
}

