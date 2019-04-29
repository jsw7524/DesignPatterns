using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediator
{

    class ColleagueButton : Button, Colleague
    {
        private Mediator mediator;
        public void SetColleagueEnable(bool b)
        {
            this.Enabled = b;
        }
        public void SetMediator(Mediator m)
        {
            mediator = m;
        }
    }

    class ColleagueCheckBox : CheckBox, Colleague
    {
        private Mediator mediator;
        public void SetColleagueEnable(bool b)
        {
            this.Enabled = b;
        }
        public void SetMediator(Mediator m)
        {
            mediator = m;
        }

        protected override void OnCheckStateChanged(EventArgs e)
        {
            mediator.ColleagueChange();
        }

    }

    class LoginFrame : Mediator
    {
        ColleagueCheckBox rb1 = new ColleagueCheckBox();
        ColleagueCheckBox rb2 = new ColleagueCheckBox();
        ColleagueButton textBox1 = new ColleagueButton();

        public void ColleagueChange()
        {

            textBox1.SetColleagueEnable(rb1.Checked);

            
        }

        public void CreateColleagues(Form f)
        {
            f.SuspendLayout();
            rb1.AutoSize = true;
            rb1.Location = new System.Drawing.Point(209, 106);
            rb1.Name = "checkBox1";
            rb1.Size = new System.Drawing.Size(91, 19);
            rb1.TabIndex = 0;
            rb1.Text = "checkBox1";
            rb1.UseVisualStyleBackColor = true;
            rb1.SetMediator(this);

            rb2.AutoSize = true;
            rb2.Location = new System.Drawing.Point(309, 106);
            rb2.Name = "checkBox2";
            rb2.Size = new System.Drawing.Size(91, 19);
            rb2.TabIndex = 0;
            rb2.Text = "checkBox2";
            rb2.UseVisualStyleBackColor = true;
            rb2.SetMediator(this);

            textBox1.Location = new System.Drawing.Point(194, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(100, 25);
            textBox1.TabIndex = 0;
            textBox1.SetMediator(this);

            f.Controls.Add(rb1);
            f.Controls.Add(rb2);
            f.Controls.Add(textBox1);
            f.ResumeLayout();
            f.PerformLayout();
        }

    }

    interface Colleague
    {
        void SetMediator(Mediator m);
        void SetColleagueEnable(Boolean b);
    }

    interface Mediator
    {
        void CreateColleagues(Form f);
        void ColleagueChange();
    }
}
