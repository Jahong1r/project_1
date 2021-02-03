
namespace Ёкубджонов_КP
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label код_товараLabel;
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label описание_товараLabel;
            System.Windows.Forms.Label старана_производителяLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ёкубджонов_КРDataSet3 = new Ёкубджонов_КP.Ёкубджонов_КРDataSet3();
            this.товарыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарыTableAdapter = new Ёкубджонов_КP.Ёкубджонов_КРDataSet3TableAdapters.ТоварыTableAdapter();
            this.tableAdapterManager = new Ёкубджонов_КP.Ёкубджонов_КРDataSet3TableAdapters.TableAdapterManager();
            this.товарыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.товарыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_товараTextBox = new System.Windows.Forms.TextBox();
            this.названиеTextBox = new System.Windows.Forms.TextBox();
            this.описание_товараTextBox = new System.Windows.Forms.TextBox();
            this.старана_производителяTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            код_товараLabel = new System.Windows.Forms.Label();
            названиеLabel = new System.Windows.Forms.Label();
            описание_товараLabel = new System.Windows.Forms.Label();
            старана_производителяLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ёкубджонов_КРDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingNavigator)).BeginInit();
            this.товарыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // код_товараLabel
            // 
            код_товараLabel.AutoSize = true;
            код_товараLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            код_товараLabel.Location = new System.Drawing.Point(94, 114);
            код_товараLabel.Name = "код_товараLabel";
            код_товараLabel.Size = new System.Drawing.Size(88, 18);
            код_товараLabel.TabIndex = 18;
            код_товараLabel.Text = "Код товара:";
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            названиеLabel.Location = new System.Drawing.Point(106, 140);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(76, 18);
            названиеLabel.TabIndex = 19;
            названиеLabel.Text = "Название:";
            // 
            // описание_товараLabel
            // 
            описание_товараLabel.AutoSize = true;
            описание_товараLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            описание_товараLabel.Location = new System.Drawing.Point(53, 166);
            описание_товараLabel.Name = "описание_товараLabel";
            описание_товараLabel.Size = new System.Drawing.Size(129, 18);
            описание_товараLabel.TabIndex = 20;
            описание_товараLabel.Text = "Описание товара:";
            // 
            // старана_производителяLabel
            // 
            старана_производителяLabel.AutoSize = true;
            старана_производителяLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            старана_производителяLabel.Location = new System.Drawing.Point(8, 192);
            старана_производителяLabel.Name = "старана_производителяLabel";
            старана_производителяLabel.Size = new System.Drawing.Size(174, 18);
            старана_производителяLabel.TabIndex = 21;
            старана_производителяLabel.Text = "Старана производителя:";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(287, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 31);
            this.button3.TabIndex = 17;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Navy;
            this.button2.Location = new System.Drawing.Point(188, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 31);
            this.button2.TabIndex = 16;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(85, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 31);
            this.button1.TabIndex = 15;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(70, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "Добавление нового товара";
            // 
            // ёкубджонов_КРDataSet3
            // 
            this.ёкубджонов_КРDataSet3.DataSetName = "Ёкубджонов_КРDataSet3";
            this.ёкубджонов_КРDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // товарыBindingSource
            // 
            this.товарыBindingSource.DataMember = "Товары";
            this.товарыBindingSource.DataSource = this.ёкубджонов_КРDataSet3;
            // 
            // товарыTableAdapter
            // 
            this.товарыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Ёкубджонов_КP.Ёкубджонов_КРDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Наличие_товараTableAdapter = null;
            this.tableAdapterManager.ТоварыTableAdapter = this.товарыTableAdapter;
            this.tableAdapterManager.Тюнинг_ательеTableAdapter = null;
            // 
            // товарыBindingNavigator
            // 
            this.товарыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.товарыBindingNavigator.BindingSource = this.товарыBindingSource;
            this.товарыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.товарыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.товарыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.товарыBindingNavigatorSaveItem});
            this.товарыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.товарыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.товарыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.товарыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.товарыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.товарыBindingNavigator.Name = "товарыBindingNavigator";
            this.товарыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.товарыBindingNavigator.Size = new System.Drawing.Size(396, 25);
            this.товарыBindingNavigator.TabIndex = 18;
            this.товарыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // товарыBindingNavigatorSaveItem
            // 
            this.товарыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.товарыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("товарыBindingNavigatorSaveItem.Image")));
            this.товарыBindingNavigatorSaveItem.Name = "товарыBindingNavigatorSaveItem";
            this.товарыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.товарыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.товарыBindingNavigatorSaveItem.Click += new System.EventHandler(this.товарыBindingNavigatorSaveItem_Click);
            // 
            // код_товараTextBox
            // 
            this.код_товараTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарыBindingSource, "Код товара", true));
            this.код_товараTextBox.Location = new System.Drawing.Point(188, 112);
            this.код_товараTextBox.Name = "код_товараTextBox";
            this.код_товараTextBox.Size = new System.Drawing.Size(93, 20);
            this.код_товараTextBox.TabIndex = 19;
            // 
            // названиеTextBox
            // 
            this.названиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарыBindingSource, "Название", true));
            this.названиеTextBox.Location = new System.Drawing.Point(188, 138);
            this.названиеTextBox.Name = "названиеTextBox";
            this.названиеTextBox.Size = new System.Drawing.Size(130, 20);
            this.названиеTextBox.TabIndex = 20;
            // 
            // описание_товараTextBox
            // 
            this.описание_товараTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарыBindingSource, "Описание товара", true));
            this.описание_товараTextBox.Location = new System.Drawing.Point(188, 164);
            this.описание_товараTextBox.Name = "описание_товараTextBox";
            this.описание_товараTextBox.Size = new System.Drawing.Size(193, 20);
            this.описание_товараTextBox.TabIndex = 21;
            // 
            // старана_производителяTextBox
            // 
            this.старана_производителяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарыBindingSource, "Старана производителя", true));
            this.старана_производителяTextBox.Location = new System.Drawing.Point(188, 190);
            this.старана_производителяTextBox.Name = "старана_производителяTextBox";
            this.старана_производителяTextBox.Size = new System.Drawing.Size(130, 20);
            this.старана_производителяTextBox.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(188, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 223);
            this.Controls.Add(старана_производителяLabel);
            this.Controls.Add(this.старана_производителяTextBox);
            this.Controls.Add(описание_товараLabel);
            this.Controls.Add(this.описание_товараTextBox);
            this.Controls.Add(названиеLabel);
            this.Controls.Add(this.названиеTextBox);
            this.Controls.Add(код_товараLabel);
            this.Controls.Add(this.код_товараTextBox);
            this.Controls.Add(this.товарыBindingNavigator);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.Text = "Добавление нового товара";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ёкубджонов_КРDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingNavigator)).EndInit();
            this.товарыBindingNavigator.ResumeLayout(false);
            this.товарыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private Ёкубджонов_КРDataSet3 ёкубджонов_КРDataSet3;
        private System.Windows.Forms.BindingSource товарыBindingSource;
        private Ёкубджонов_КРDataSet3TableAdapters.ТоварыTableAdapter товарыTableAdapter;
        private Ёкубджонов_КРDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator товарыBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton товарыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_товараTextBox;
        private System.Windows.Forms.TextBox названиеTextBox;
        private System.Windows.Forms.TextBox описание_товараTextBox;
        private System.Windows.Forms.TextBox старана_производителяTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}