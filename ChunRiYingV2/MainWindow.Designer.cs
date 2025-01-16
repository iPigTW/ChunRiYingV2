namespace ChunRiYingV2;

partial class MainWindow
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        searchBox = new System.Windows.Forms.TextBox();
        searchButton = new System.Windows.Forms.Button();
        Result = new System.Windows.Forms.ListBox();
        contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
        複製圖片連結ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        contextMenuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // searchBox
        // 
        searchBox.BackColor = System.Drawing.Color.WhiteSmoke;
        searchBox.Dock = System.Windows.Forms.DockStyle.Fill;
        searchBox.Font = new System.Drawing.Font("Noto Sans TC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        searchBox.Location = new System.Drawing.Point(0, 0);
        searchBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        searchBox.Name = "searchBox";
        searchBox.Size = new System.Drawing.Size(1000, 36);
        searchBox.TabIndex = 0;
        searchBox.Text = "輸入要搜尋的關鍵字";
        searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // searchButton
        // 
        searchButton.AutoSize = true;
        searchButton.Dock = System.Windows.Forms.DockStyle.Bottom;
        searchButton.Font = new System.Drawing.Font("Noto Sans TC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        searchButton.Location = new System.Drawing.Point(0, 513);
        searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        searchButton.Name = "searchButton";
        searchButton.Size = new System.Drawing.Size(1000, 49);
        searchButton.TabIndex = 1;
        searchButton.Text = "搜尋";
        searchButton.UseVisualStyleBackColor = true;
        searchButton.Click += button1_Click;
        // 
        // Result
        // 
        Result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        Result.Font = new System.Drawing.Font("Noto Sans TC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)136));
        Result.FormattingEnabled = true;
        Result.Location = new System.Drawing.Point(290, 121);
        Result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        Result.Name = "Result";
        Result.Size = new System.Drawing.Size(426, 329);
        Result.TabIndex = 2;
        Result.MouseDown += Result_MouseDown;
        // 
        // contextMenuStrip1
        // 
        contextMenuStrip1.Font = new System.Drawing.Font("Noto Sans TC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
        contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { 複製圖片連結ToolStripMenuItem });
        contextMenuStrip1.Name = "contextMenuStrip1";
        contextMenuStrip1.Size = new System.Drawing.Size(187, 34);
        // 
        // 複製圖片連結ToolStripMenuItem
        // 
        複製圖片連結ToolStripMenuItem.Name = "複製圖片連結ToolStripMenuItem";
        複製圖片連結ToolStripMenuItem.Size = new System.Drawing.Size(186, 30);
        複製圖片連結ToolStripMenuItem.Text = "複製圖片連結";
        複製圖片連結ToolStripMenuItem.Click += 複製圖片連結ToolStripMenuItem_Click;
        // 
        // MainWindow
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1000, 562);
        Controls.Add(Result);
        Controls.Add(searchButton);
        Controls.Add(searchBox);
        Font = new System.Drawing.Font("Noto Sans TC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        Text = "MyGo梗圖查詢(powered by miyago9267.com)";
        contextMenuStrip1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem 複製圖片連結ToolStripMenuItem;

    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

    private System.Windows.Forms.ListBox Result;

    private System.Windows.Forms.Button searchButton;

    private System.Windows.Forms.TextBox searchBox;

    #endregion
}