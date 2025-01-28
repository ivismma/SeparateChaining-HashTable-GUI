using System;
using System.Windows.Forms;

namespace HashTableGUI {
    public partial class Application : Form {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label0;
            this.input1 = new System.Windows.Forms.GroupBox();
            this.insert = new System.Windows.Forms.Button();
            this.toInsert = new System.Windows.Forms.TextBox();
            this.HashMenuText = new System.Windows.Forms.Label();
            this.hashFunctionType = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.input2 = new System.Windows.Forms.GroupBox();
            this.remove = new System.Windows.Forms.Button();
            this.toRemove = new System.Windows.Forms.TextBox();
            this.hashTableGroup = new System.Windows.Forms.GroupBox();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.index7 = new System.Windows.Forms.TextBox();
            this.index6 = new System.Windows.Forms.TextBox();
            this.index5 = new System.Windows.Forms.TextBox();
            this.index4 = new System.Windows.Forms.TextBox();
            this.index3 = new System.Windows.Forms.TextBox();
            this.index2 = new System.Windows.Forms.TextBox();
            this.index1 = new System.Windows.Forms.TextBox();
            this.index0 = new System.Windows.Forms.TextBox();
            this.dataLabel = new System.Windows.Forms.Label();
            this.indexLabel = new System.Windows.Forms.Label();
            this.eventLog = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.rules = new System.Windows.Forms.GroupBox();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label0 = new System.Windows.Forms.Label();
            this.input1.SuspendLayout();
            this.input2.SuspendLayout();
            this.hashTableGroup.SuspendLayout();
            this.table.SuspendLayout();
            this.rules.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.SystemColors.ControlText;
            label7.Location = new System.Drawing.Point(8, 358);
            label7.Margin = new System.Windows.Forms.Padding(8, 8, 3, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(30, 33);
            label7.TabIndex = 23;
            label7.Text = "7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.SystemColors.ControlText;
            label6.Location = new System.Drawing.Point(8, 308);
            label6.Margin = new System.Windows.Forms.Padding(8, 8, 3, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(30, 33);
            label6.TabIndex = 22;
            label6.Text = "6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.SystemColors.ControlText;
            label5.Location = new System.Drawing.Point(8, 258);
            label5.Margin = new System.Windows.Forms.Padding(8, 8, 3, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(30, 33);
            label5.TabIndex = 21;
            label5.Text = "5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.SystemColors.ControlText;
            label4.Location = new System.Drawing.Point(8, 208);
            label4.Margin = new System.Windows.Forms.Padding(8, 8, 3, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(30, 33);
            label4.TabIndex = 20;
            label4.Text = "4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.ControlText;
            label3.Location = new System.Drawing.Point(8, 158);
            label3.Margin = new System.Windows.Forms.Padding(8, 8, 3, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(30, 33);
            label3.TabIndex = 19;
            label3.Text = "3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.ControlText;
            label2.Location = new System.Drawing.Point(8, 108);
            label2.Margin = new System.Windows.Forms.Padding(8, 8, 3, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(30, 33);
            label2.TabIndex = 18;
            label2.Text = "2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ControlText;
            label1.Location = new System.Drawing.Point(8, 58);
            label1.Margin = new System.Windows.Forms.Padding(8, 8, 3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(30, 33);
            label1.TabIndex = 17;
            label1.Text = "1";
            // 
            // label0
            // 
            label0.AutoSize = true;
            label0.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label0.ForeColor = System.Drawing.SystemColors.ControlText;
            label0.Location = new System.Drawing.Point(8, 8);
            label0.Margin = new System.Windows.Forms.Padding(8, 8, 3, 0);
            label0.Name = "label0";
            label0.Size = new System.Drawing.Size(30, 33);
            label0.TabIndex = 16;
            label0.Text = "0";
            // 
            // input1
            // 
            this.input1.Controls.Add(this.insert);
            this.input1.Controls.Add(this.toInsert);
            this.input1.Location = new System.Drawing.Point(12, 12);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(187, 76);
            this.input1.TabIndex = 1;
            this.input1.TabStop = false;
            this.input1.Text = "Inserção";
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(101, 27);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 1;
            this.insert.Text = "Inserir";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.toInsert_Click);
            // 
            // toInsert
            // 
            this.toInsert.Location = new System.Drawing.Point(6, 29);
            this.toInsert.Name = "toInsert";
            this.toInsert.Size = new System.Drawing.Size(89, 20);
            this.toInsert.TabIndex = 0;
            this.toInsert.TextChanged += new System.EventHandler(this.toInsert_TextChanged);
            this.toInsert.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toInsert_KeyDown);
            // 
            // HashMenuText
            // 
            this.HashMenuText.AutoSize = true;
            this.HashMenuText.Location = new System.Drawing.Point(4, 46);
            this.HashMenuText.Name = "HashMenuText";
            this.HashMenuText.Size = new System.Drawing.Size(72, 13);
            this.HashMenuText.TabIndex = 4;
            this.HashMenuText.Text = "Função hash:";
            // 
            // hashFunctionType
            // 
            this.hashFunctionType.Items.AddRange(new object[] {
            "Método da divisão (mod 8)",
            "Método da multiplicação"});
            this.hashFunctionType.Location = new System.Drawing.Point(6, 64);
            this.hashFunctionType.Name = "hashFunctionType";
            this.hashFunctionType.Size = new System.Drawing.Size(170, 21);
            this.hashFunctionType.TabIndex = 3;
            this.hashFunctionType.SelectedIndexChanged += new System.EventHandler(this.hashFunctionType_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Inserção ordenada";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.InOrder_CheckedChanged);
            // 
            // input2
            // 
            this.input2.Controls.Add(this.remove);
            this.input2.Controls.Add(this.toRemove);
            this.input2.Location = new System.Drawing.Point(12, 112);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(187, 71);
            this.input2.TabIndex = 2;
            this.input2.TabStop = false;
            this.input2.Text = "Remoção";
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(101, 27);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(75, 23);
            this.remove.TabIndex = 4;
            this.remove.Text = "Remover";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.toRemove_Click);
            // 
            // toRemove
            // 
            this.toRemove.Location = new System.Drawing.Point(6, 29);
            this.toRemove.Name = "toRemove";
            this.toRemove.Size = new System.Drawing.Size(89, 20);
            this.toRemove.TabIndex = 3;
            this.toRemove.TextChanged += new System.EventHandler(this.toRemove_TextChanged);
            this.toRemove.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toRemove_KeyDown);
            // 
            // hashTableGroup
            // 
            this.hashTableGroup.Controls.Add(this.table);
            this.hashTableGroup.Controls.Add(this.dataLabel);
            this.hashTableGroup.Controls.Add(this.indexLabel);
            this.hashTableGroup.Location = new System.Drawing.Point(205, 12);
            this.hashTableGroup.Name = "hashTableGroup";
            this.hashTableGroup.Size = new System.Drawing.Size(1044, 466);
            this.hashTableGroup.TabIndex = 2;
            this.hashTableGroup.TabStop = false;
            this.hashTableGroup.Text = "Tabela de Dispersão -  Encadeamento Externo (8 Encadeamentos)";
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.table.ColumnCount = 2;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1002F));
            this.table.Controls.Add(this.index7, 1, 7);
            this.table.Controls.Add(this.index6, 1, 6);
            this.table.Controls.Add(this.index5, 1, 5);
            this.table.Controls.Add(this.index4, 1, 4);
            this.table.Controls.Add(this.index3, 1, 3);
            this.table.Controls.Add(this.index2, 1, 2);
            this.table.Controls.Add(this.index1, 1, 1);
            this.table.Controls.Add(label5, 0, 5);
            this.table.Controls.Add(label4, 0, 4);
            this.table.Controls.Add(label3, 0, 3);
            this.table.Controls.Add(label2, 0, 2);
            this.table.Controls.Add(label1, 0, 1);
            this.table.Controls.Add(label0, 0, 0);
            this.table.Controls.Add(label7, 0, 7);
            this.table.Controls.Add(label6, 0, 6);
            this.table.Controls.Add(this.index0, 1, 0);
            this.table.ForeColor = System.Drawing.SystemColors.ControlText;
            this.table.Location = new System.Drawing.Point(15, 55);
            this.table.Name = "table";
            this.table.RowCount = 8;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.table.Size = new System.Drawing.Size(1023, 405);
            this.table.TabIndex = 22;
            // 
            // index7
            // 
            this.index7.AccessibleName = "";
            this.index7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.index7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.index7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.index7.CausesValidation = false;
            this.index7.Enabled = false;
            this.index7.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.index7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.index7.Location = new System.Drawing.Point(53, 362);
            this.index7.Margin = new System.Windows.Forms.Padding(2, 3, 16, 3);
            this.index7.Name = "index7";
            this.index7.ReadOnly = true;
            this.index7.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.index7.Size = new System.Drawing.Size(963, 31);
            this.index7.TabIndex = 31;
            this.index7.Tag = "";
            // 
            // index6
            // 
            this.index6.AccessibleName = "";
            this.index6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.index6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.index6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.index6.CausesValidation = false;
            this.index6.Enabled = false;
            this.index6.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.index6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.index6.Location = new System.Drawing.Point(53, 309);
            this.index6.Margin = new System.Windows.Forms.Padding(2, 3, 16, 3);
            this.index6.Name = "index6";
            this.index6.ReadOnly = true;
            this.index6.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.index6.Size = new System.Drawing.Size(963, 31);
            this.index6.TabIndex = 30;
            this.index6.Tag = "";
            // 
            // index5
            // 
            this.index5.AccessibleName = "";
            this.index5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.index5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.index5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.index5.CausesValidation = false;
            this.index5.Enabled = false;
            this.index5.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.index5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.index5.Location = new System.Drawing.Point(53, 259);
            this.index5.Margin = new System.Windows.Forms.Padding(2, 3, 16, 3);
            this.index5.Name = "index5";
            this.index5.ReadOnly = true;
            this.index5.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.index5.Size = new System.Drawing.Size(963, 31);
            this.index5.TabIndex = 29;
            this.index5.Tag = "";
            // 
            // index4
            // 
            this.index4.AccessibleName = "";
            this.index4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.index4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.index4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.index4.CausesValidation = false;
            this.index4.Enabled = false;
            this.index4.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.index4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.index4.Location = new System.Drawing.Point(53, 209);
            this.index4.Margin = new System.Windows.Forms.Padding(2, 3, 16, 3);
            this.index4.Name = "index4";
            this.index4.ReadOnly = true;
            this.index4.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.index4.Size = new System.Drawing.Size(963, 31);
            this.index4.TabIndex = 28;
            this.index4.Tag = "";
            // 
            // index3
            // 
            this.index3.AccessibleName = "";
            this.index3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.index3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.index3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.index3.CausesValidation = false;
            this.index3.Enabled = false;
            this.index3.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.index3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.index3.Location = new System.Drawing.Point(53, 159);
            this.index3.Margin = new System.Windows.Forms.Padding(2, 3, 16, 3);
            this.index3.Name = "index3";
            this.index3.ReadOnly = true;
            this.index3.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.index3.Size = new System.Drawing.Size(963, 31);
            this.index3.TabIndex = 27;
            this.index3.Tag = "";
            // 
            // index2
            // 
            this.index2.AccessibleName = "";
            this.index2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.index2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.index2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.index2.CausesValidation = false;
            this.index2.Enabled = false;
            this.index2.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.index2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.index2.Location = new System.Drawing.Point(53, 109);
            this.index2.Margin = new System.Windows.Forms.Padding(2, 3, 16, 3);
            this.index2.Name = "index2";
            this.index2.ReadOnly = true;
            this.index2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.index2.Size = new System.Drawing.Size(963, 31);
            this.index2.TabIndex = 26;
            this.index2.Tag = "";
            // 
            // index1
            // 
            this.index1.AccessibleName = "";
            this.index1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.index1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.index1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.index1.CausesValidation = false;
            this.index1.Enabled = false;
            this.index1.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.index1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.index1.Location = new System.Drawing.Point(53, 59);
            this.index1.Margin = new System.Windows.Forms.Padding(2, 3, 16, 3);
            this.index1.Name = "index1";
            this.index1.ReadOnly = true;
            this.index1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.index1.Size = new System.Drawing.Size(963, 31);
            this.index1.TabIndex = 25;
            this.index1.Tag = "";
            // 
            // index0
            // 
            this.index0.AccessibleName = "";
            this.index0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.index0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.index0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.index0.CausesValidation = false;
            this.index0.Enabled = false;
            this.index0.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.index0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.index0.Location = new System.Drawing.Point(53, 9);
            this.index0.Margin = new System.Windows.Forms.Padding(2, 3, 16, 3);
            this.index0.MaxLength = 15;
            this.index0.Name = "index0";
            this.index0.ReadOnly = true;
            this.index0.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.index0.Size = new System.Drawing.Size(963, 31);
            this.index0.TabIndex = 24;
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLabel.Location = new System.Drawing.Point(512, 30);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(54, 21);
            this.dataLabel.TabIndex = 21;
            this.dataLabel.Text = "Dados";
            // 
            // indexLabel
            // 
            this.indexLabel.AutoSize = true;
            this.indexLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexLabel.Location = new System.Drawing.Point(12, 30);
            this.indexLabel.Name = "indexLabel";
            this.indexLabel.Size = new System.Drawing.Size(51, 21);
            this.indexLabel.TabIndex = 20;
            this.indexLabel.Text = "Índice";
            // 
            // eventLog
            // 
            this.eventLog.AllowDrop = true;
            this.eventLog.BackColor = System.Drawing.SystemColors.GrayText;
            this.eventLog.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventLog.ForeColor = System.Drawing.Color.White;
            this.eventLog.Location = new System.Drawing.Point(12, 484);
            this.eventLog.Multiline = true;
            this.eventLog.Name = "eventLog";
            this.eventLog.ReadOnly = true;
            this.eventLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.eventLog.Size = new System.Drawing.Size(1237, 177);
            this.eventLog.TabIndex = 3;
            this.eventLog.TabStop = false;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(18, 449);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(181, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Reinicializar Tabela Hash";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clear_Click);
            // 
            // rules
            // 
            this.rules.Controls.Add(this.HashMenuText);
            this.rules.Controls.Add(this.checkBox1);
            this.rules.Controls.Add(this.hashFunctionType);
            this.rules.Location = new System.Drawing.Point(12, 212);
            this.rules.Name = "rules";
            this.rules.Size = new System.Drawing.Size(187, 96);
            this.rules.TabIndex = 6;
            this.rules.TabStop = false;
            this.rules.Text = "Regras";
            // 
            // Application
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 673);
            this.Controls.Add(this.rules);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.eventLog);
            this.Controls.Add(this.hashTableGroup);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Application";
            this.Text = "Tabela Hash <Int32> - v1.0";
            this.Load += new System.EventHandler(this.App_Load);
            this.input1.ResumeLayout(false);
            this.input1.PerformLayout();
            this.input2.ResumeLayout(false);
            this.input2.PerformLayout();
            this.hashTableGroup.ResumeLayout(false);
            this.hashTableGroup.PerformLayout();
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.rules.ResumeLayout(false);
            this.rules.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox input1;
        private GroupBox input2;
        private TextBox toInsert;
        private Button insert;
        private TextBox toRemove;
        private Button remove;
        private GroupBox hashTableGroup;
        private TextBox eventLog;
        public TextBox EventLog {
            get { return eventLog; }
        }
        private Label indexLabel;
        private Label dataLabel;
        private TableLayoutPanel table;
        private CheckBox checkBox1;
        public CheckBox getCheckBox1(Object obj) {
            if (obj is HashTable)
                return checkBox1;
            else
                throw new UnauthorizedAccessException();
        }
        public TextBox index7;
        public TextBox index6;
        public TextBox index5;
        public TextBox index4;
        public TextBox index3;
        public TextBox index2;
        public TextBox index1;
        public TextBox index0;
        private Button clearButton;
        private ComboBox hashFunctionType;
        public ComboBox getHashFunctionType(object obj) {
            if (obj is HashTable)
                return hashFunctionType;
            else
                throw new UnauthorizedAccessException();
        }

        private Label HashMenuText;
        private GroupBox rules;
    }
}

