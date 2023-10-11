namespace Calculator
{
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
            sifir = new Button();
            noqte = new Button();
            bir = new Button();
            iki = new Button();
            uc = new Button();
            dord = new Button();
            bes = new Button();
            alti = new Button();
            yeddi = new Button();
            sekkiz = new Button();
            doqquz = new Button();
            beraber = new Button();
            toplama = new Button();
            cixma = new Button();
            vurma = new Button();
            bolme = new Button();
            faiz = new Button();
            clear = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // sifir
            // 
            sifir.BackColor = SystemColors.ActiveBorder;
            sifir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            sifir.ForeColor = SystemColors.ControlText;
            sifir.Location = new Point(50, 435);
            sifir.Name = "sifir";
            sifir.Size = new Size(237, 69);
            sifir.TabIndex = 0;
            sifir.Text = "0";
            sifir.UseVisualStyleBackColor = false;
            sifir.Click += sifir_Click;
            // 
            // noqte
            // 
            noqte.BackColor = SystemColors.ActiveBorder;
            noqte.Location = new Point(308, 429);
            noqte.Name = "noqte";
            noqte.Size = new Size(120, 75);
            noqte.TabIndex = 1;
            noqte.Text = ".";
            noqte.UseVisualStyleBackColor = false;
            noqte.Click += noqte_Click;
            // 
            // bir
            // 
            bir.BackColor = SystemColors.ActiveBorder;
            bir.Location = new Point(50, 376);
            bir.Name = "bir";
            bir.Size = new Size(118, 52);
            bir.TabIndex = 2;
            bir.Text = "1";
            bir.UseVisualStyleBackColor = false;
            bir.Click += bir_Click;
            // 
            // iki
            // 
            iki.BackColor = SystemColors.ActiveBorder;
            iki.Location = new Point(176, 376);
            iki.Name = "iki";
            iki.Size = new Size(111, 52);
            iki.TabIndex = 3;
            iki.Text = "2";
            iki.UseVisualStyleBackColor = false;
            iki.Click += iki_Click;
            // 
            // uc
            // 
            uc.BackColor = SystemColors.ActiveBorder;
            uc.Location = new Point(308, 376);
            uc.Name = "uc";
            uc.Size = new Size(120, 46);
            uc.TabIndex = 4;
            uc.Text = "3";
            uc.UseVisualStyleBackColor = false;
            uc.Click += uc_Click;
            // 
            // dord
            // 
            dord.BackColor = SystemColors.ActiveBorder;
            dord.Location = new Point(50, 320);
            dord.Name = "dord";
            dord.Size = new Size(118, 49);
            dord.TabIndex = 5;
            dord.Text = "4";
            dord.UseVisualStyleBackColor = false;
            dord.Click += dord_Click;
            // 
            // bes
            // 
            bes.BackColor = SystemColors.ActiveBorder;
            bes.Location = new Point(176, 320);
            bes.Name = "bes";
            bes.Size = new Size(111, 49);
            bes.TabIndex = 6;
            bes.Text = "5";
            bes.UseVisualStyleBackColor = false;
            bes.Click += bes_Click;
            // 
            // alti
            // 
            alti.BackColor = SystemColors.ActiveBorder;
            alti.Location = new Point(308, 320);
            alti.Name = "alti";
            alti.Size = new Size(120, 49);
            alti.TabIndex = 7;
            alti.Text = "6";
            alti.UseVisualStyleBackColor = false;
            alti.Click += alti_Click;
            // 
            // yeddi
            // 
            yeddi.BackColor = SystemColors.ActiveBorder;
            yeddi.Location = new Point(50, 260);
            yeddi.Name = "yeddi";
            yeddi.RightToLeft = RightToLeft.No;
            yeddi.Size = new Size(118, 53);
            yeddi.TabIndex = 8;
            yeddi.Text = "7";
            yeddi.UseVisualStyleBackColor = false;
            yeddi.Click += yeddi_Click;
            // 
            // sekkiz
            // 
            sekkiz.BackColor = SystemColors.ActiveBorder;
            sekkiz.Location = new Point(176, 260);
            sekkiz.Name = "sekkiz";
            sekkiz.Size = new Size(111, 53);
            sekkiz.TabIndex = 9;
            sekkiz.Text = "8";
            sekkiz.UseVisualStyleBackColor = false;
            sekkiz.Click += sekkiz_Click;
            // 
            // doqquz
            // 
            doqquz.BackColor = SystemColors.ActiveBorder;
            doqquz.Location = new Point(308, 260);
            doqquz.Name = "doqquz";
            doqquz.Size = new Size(120, 53);
            doqquz.TabIndex = 10;
            doqquz.Text = "9";
            doqquz.UseVisualStyleBackColor = false;
            doqquz.Click += doqquz_Click;
            // 
            // beraber
            // 
            beraber.BackColor = Color.Yellow;
            beraber.Location = new Point(470, 435);
            beraber.Name = "beraber";
            beraber.Size = new Size(118, 67);
            beraber.TabIndex = 11;
            beraber.Text = "=";
            beraber.UseVisualStyleBackColor = false;
            beraber.Click += beraber_Click;
            // 
            // toplama
            // 
            toplama.BackColor = Color.Yellow;
            toplama.Location = new Point(470, 376);
            toplama.Name = "toplama";
            toplama.Size = new Size(118, 52);
            toplama.TabIndex = 12;
            toplama.Text = "+";
            toplama.UseVisualStyleBackColor = false;
            toplama.Click += toplama_Click;
            // 
            // cixma
            // 
            cixma.BackColor = Color.Yellow;
            cixma.Location = new Point(470, 320);
            cixma.Name = "cixma";
            cixma.Size = new Size(118, 49);
            cixma.TabIndex = 13;
            cixma.Text = "-";
            cixma.UseVisualStyleBackColor = false;
            cixma.Click += cixma_Click;
            // 
            // vurma
            // 
            vurma.BackColor = Color.Yellow;
            vurma.Location = new Point(470, 260);
            vurma.Name = "vurma";
            vurma.Size = new Size(118, 53);
            vurma.TabIndex = 14;
            vurma.Text = "x";
            vurma.UseVisualStyleBackColor = false;
            vurma.Click += vurma_Click;
            // 
            // bolme
            // 
            bolme.BackColor = Color.Yellow;
            bolme.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bolme.Location = new Point(468, 197);
            bolme.Name = "bolme";
            bolme.Size = new Size(120, 56);
            bolme.TabIndex = 15;
            bolme.Text = "/";
            bolme.UseVisualStyleBackColor = false;
            bolme.Click += bolme_Click;
            // 
            // faiz
            // 
            faiz.BackColor = Color.FromArgb(192, 255, 192);
            faiz.Location = new Point(308, 197);
            faiz.Name = "faiz";
            faiz.Size = new Size(120, 56);
            faiz.TabIndex = 16;
            faiz.Text = "%";
            faiz.UseVisualStyleBackColor = false;
            faiz.Click += faiz_Click;
            // 
            // clear
            // 
            clear.BackColor = Color.FromArgb(192, 255, 192);
            clear.Location = new Point(50, 197);
            clear.Name = "clear";
            clear.Size = new Size(237, 56);
            clear.TabIndex = 17;
            clear.Text = "CLEAR";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(313, 68);
            label1.Name = "label1";
            label1.Size = new Size(0, 81);
            label1.TabIndex = 18;
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 523);
            Controls.Add(label1);
            Controls.Add(clear);
            Controls.Add(faiz);
            Controls.Add(bolme);
            Controls.Add(vurma);
            Controls.Add(cixma);
            Controls.Add(toplama);
            Controls.Add(beraber);
            Controls.Add(doqquz);
            Controls.Add(sekkiz);
            Controls.Add(yeddi);
            Controls.Add(alti);
            Controls.Add(bes);
            Controls.Add(dord);
            Controls.Add(uc);
            Controls.Add(iki);
            Controls.Add(bir);
            Controls.Add(noqte);
            Controls.Add(sifir);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sifir;
        private Button noqte;
        private Button bir;
        private Button iki;
        private Button uc;
        private Button dord;
        private Button bes;
        private Button alti;
        private Button yeddi;
        private Button sekkiz;
        private Button doqquz;
        private Button beraber;
        private Button toplama;
        private Button cixma;
        private Button vurma;
        private Button bolme;
        private Button faiz;
        private Button clear;
        private Label label1;
    }
}