namespace TodaysSnack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("�g������z����͂��悤!");
            }
            else
            {
                int pocket = Convert.ToInt32(textBox1.Text);
                string caption = "�ǂ������I�ڂ�!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result1;
                DialogResult result2;

                string message1 = "�Â��̂ɂ���?";
                string message2 = "�J�����[�͋C�ɂȂ�?";

                if (pocket < 300)
                {
                    label2.Text = "�u�J���J���V���[�N���[���v�����!";
                }
                else
                {
                    result1 = MessageBox.Show(message1, caption, buttons);
                    result2 = MessageBox.Show(message2, caption, buttons);

                    if (result1 == DialogResult.Yes & result2 == DialogResult.Yes)
                    {
                        label2.Text = "�u�Ղ�Ղ�R�[�q�[�[���[�v�ɂ��܂��傤�I";
                    }
                    else if (result1 == DialogResult.Yes & result2 == DialogResult.No)
                    {
                        label2.Text = "�u�Z���L���������`�[�Y�^���g�v�ɂ��܂��傤!";
                    }
                    else if (result1 == DialogResult.Yes & result2 == DialogResult.No)
                        {
                            label2.Text = "�u�Z���L���������`�[�Y�^���g�v�ɂ��܂��傤!";
                        }
                    else if (result1 == DialogResult.No & result2 == DialogResult.Yes)
                        {
                            label2.Text = "�u�v���e�C���[���[�v����!";
                        }
                    else
                        {
                            label2.Text = "�u�r�^�[�J�J�I�G�N���A�v�ɂ��܂��傤!";
                        }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "�����̂����?";
        }
    }
}
