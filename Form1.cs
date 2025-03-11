namespace UniSystem
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>(); // ��ª��͹ѡ�֡��
        private List<Advisor> advisors = new List<Advisor>(); // ��ª����Ҩ����


        public Form1()
        {
            InitializeComponent();
        }

        // ����ͤ�ԡ���� Add ����Ѻ��͡�������Ҩ����
        private void btnAddAdvisor_Click(object sender, EventArgs e)
        {
            // �Ѻ�����Ũҡ TextBox ����Ѻ�Ҩ����
            string firstName = tFirstNameA.Text;
            string lastName = tLastNameA.Text;
            string major = tMajorA.Text;

            // ���ҧ�Ҩ��������
            Advisor advisor = new Advisor(firstName, lastName, major);
            advisors.Add(advisor);

            // ���������Ҩ����� ComboBox ����Ѻ�ѡ�֡��
            cmbAdvisor.Items.Add(firstName + " " + lastName); // ���������Ҩ����� ComboBox �ͧ�ѡ�֡��

            // ���ê ComboBox �ͧ�ѡ�֡�������������������ʴ����
            cmbAdvisor.SelectedIndex = cmbAdvisor.Items.Count - 1;

            // �ʴ���ͤ��� "�ѹ�֡����������"
            MessageBox.Show("�������Ҩ����١�ѹ�֡����");

            // ������ TextBox �ͧ�Ҩ����
            btnClearA_Click(sender, e);
        }

        // ����ͤ�ԡ���� Add ����Ѻ��͡�����Źѡ�֡��


        // �ʴ���ª��͹ѡ�֡�Ңͧ�Ҩ���������͡� DataGridView
        private void cmbAdvisor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ������ա�����͡�Ҩ����� ComboBox �������
            if (cmbAdvisor.SelectedItem != null)
            {
                // ���Ҩ������١���͡�ҡ ComboBox
                Advisor selectedAdvisor = advisors.FirstOrDefault(a => a.FirstName + " " + a.LastName == cmbAdvisor.SelectedItem.ToString());

                if (selectedAdvisor != null)
                {
                    // ź���������� DataGridView
                    dgvStudents.Rows.Clear();

                    // �ʴ������Źѡ�֡�Ңͧ�Ҩ���������͡
                    foreach (var student in selectedAdvisor.Students)
                    {
                        // ���������Źѡ�֡��� DataGridView
                        dgvStudents.Rows.Add(student.StudentID, student.FirstName, student.LastName);
                    }
                }
                else
                {
                    MessageBox.Show("��س����͡�Ҩ�������֡�ҡ�͹");
                }
            }
        }


        // ������������ TextBox ������
        private void btnClear_Click(object sender, EventArgs e)
        {
            tStudentID.Clear();
            tFirstName.Clear();
            tLastName.Clear();
            tMajor.Clear();

            tGrade.Clear();
        }

        // ������������ TextBox �Ҩ����
        private void btnClearA_Click(object sender, EventArgs e)
        {
            tFirstNameA.Clear();
            tLastNameA.Clear();
            tMajorA.Clear();
        }

        private void btnAddStudent_Click_1(object sender, EventArgs e)
        {
            
            // ��Ǩ�ͺ������͡�Ҩ�������֡���������
            if (cmbAdvisor.SelectedItem != null)
            {
                // ��Ǩ�ͺ����Ҩ���������͡� ComboBox �������ª����Ҩ�������������������
                string selectedAdvisorName = cmbAdvisor.SelectedItem.ToString();

                // �������º��º FirstName ��� LastName �ͧ�Ҩ����
                Advisor selectedAdvisor = advisors.FirstOrDefault(a => (a.FirstName + " " + a.LastName) == selectedAdvisorName);

                if (selectedAdvisor != null)
                {
                    // ���ҧ�ѡ�֡������
                    Student student = new Student(tStudentID.Text, tFirstName.Text, tLastName.Text,
                                                  tMajor.Text, double.Parse(tGrade.Text), selectedAdvisor);

                    students.Add(student); // �����ѡ�֡��� List<Student>
                    selectedAdvisor.AddStudent(student);  // �����ѡ�֡�����Ѻ�Ҩ�������֡��

                    // �ʴ���ͤ��� "�ѹ�֡����������"
                    MessageBox.Show("�����Źѡ�֡�Ҷ١�ѹ�֡����");

                    // ������������ TextBox
                    btnClear_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("��辺�Ҩ���������͡");
                }
            }
            else
            {
                MessageBox.Show("��س����͡�Ҩ�������֡�ҡ�͹");
            }
        }

        private void UpdateTopGradeStudent()
        {
            if (students.Count > 0)
            {
                var topStudent = students.OrderByDescending(s => s.Grade).FirstOrDefault();
                label22.Text = "Top Grade Student: " + topStudent?.FirstName + " " + topStudent?.LastName;
            }
        }

    }
}
