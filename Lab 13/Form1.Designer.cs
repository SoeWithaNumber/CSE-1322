namespace Lab_13;

partial class Form1
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
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(400, 300);
        this.Text = "MegaCalc";

        TextBox input1 = new TextBox();
        input1.Location = new Point(50, 100);
        TextBox input2 = new TextBox();
        input2.Location = new Point(250, 100);
        Button add = new Button();
        add.Location = new Point(190,100);
        add.Text = "+";
        add.Size = new Size(25,25);
        TextBlock output = new TextBlock();
        output.Location = new Point(190, 200);
        output.text = "test";
        this.Controls.Add(output);
        this.Controls.Add(input1);
        this.Controls.Add(input2);
        this.Controls.Add(add);
    }

    #endregion
}
