namespace UniSystem
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>(); // รายชื่อนักศึกษา
        private List<Advisor> advisors = new List<Advisor>(); // รายชื่ออาจารย์


        public Form1()
        {
            InitializeComponent();
        }

        // เมื่อคลิกปุ่ม Add สำหรับกรอกข้อมูลอาจารย์
        private void btnAddAdvisor_Click(object sender, EventArgs e)
        {
            // รับข้อมูลจาก TextBox สำหรับอาจารย์
            string firstName = tFirstNameA.Text;
            string lastName = tLastNameA.Text;
            string major = tMajorA.Text;

            // สร้างอาจารย์ใหม่
            Advisor advisor = new Advisor(firstName, lastName, major);
            advisors.Add(advisor);

            // เพิ่มชื่ออาจารย์ใน ComboBox สำหรับนักศึกษา
            cmbAdvisor.Items.Add(firstName + " " + lastName); // เพิ่มชื่ออาจารย์ใน ComboBox ของนักศึกษา

            // รีเฟรช ComboBox ของนักศึกษาเพื่อให้ข้อมูลใหม่แสดงขึ้น
            cmbAdvisor.SelectedIndex = cmbAdvisor.Items.Count - 1;

            // แสดงข้อความ "บันทึกข้อมูลแล้ว"
            MessageBox.Show("ข้อมูลอาจารย์ถูกบันทึกแล้ว");

            // เคลียร์ TextBox ของอาจารย์
            btnClearA_Click(sender, e);
        }

        // เมื่อคลิกปุ่ม Add สำหรับกรอกข้อมูลนักศึกษา


        // แสดงรายชื่อนักศึกษาของอาจารย์ที่เลือกใน DataGridView
        private void cmbAdvisor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // เช็คว่ามีการเลือกอาจารย์ใน ComboBox หรือไม่
            if (cmbAdvisor.SelectedItem != null)
            {
                // หาอาจารย์ที่ถูกเลือกจาก ComboBox
                Advisor selectedAdvisor = advisors.FirstOrDefault(a => a.FirstName + " " + a.LastName == cmbAdvisor.SelectedItem.ToString());

                if (selectedAdvisor != null)
                {
                    // ลบข้อมูลเก่าใน DataGridView
                    dgvStudents.Rows.Clear();

                    // แสดงข้อมูลนักศึกษาของอาจารย์ที่เลือก
                    foreach (var student in selectedAdvisor.Students)
                    {
                        // เพิ่มข้อมูลนักศึกษาใน DataGridView
                        dgvStudents.Rows.Add(student.StudentID, student.FirstName, student.LastName);
                    }
                }
                else
                {
                    MessageBox.Show("กรุณาเลือกอาจารย์ที่ปรึกษาก่อน");
                }
            }
        }


        // เคลียร์ข้อมูลใน TextBox ทั้งหมด
        private void btnClear_Click(object sender, EventArgs e)
        {
            tStudentID.Clear();
            tFirstName.Clear();
            tLastName.Clear();
            tMajor.Clear();

            tGrade.Clear();
        }

        // เคลียร์ข้อมูลใน TextBox อาจารย์
        private void btnClearA_Click(object sender, EventArgs e)
        {
            tFirstNameA.Clear();
            tLastNameA.Clear();
            tMajorA.Clear();
        }

        private void btnAddStudent_Click_1(object sender, EventArgs e)
        {
            
            // ตรวจสอบว่าเลือกอาจารย์ที่ปรึกษาหรือไม่
            if (cmbAdvisor.SelectedItem != null)
            {
                // ตรวจสอบว่าอาจารย์ที่เลือกใน ComboBox อยู่ในรายชื่ออาจารย์ที่มีอยู่หรือไม่
                string selectedAdvisorName = cmbAdvisor.SelectedItem.ToString();

                // ใช้การเปรียบเทียบ FirstName และ LastName ของอาจารย์
                Advisor selectedAdvisor = advisors.FirstOrDefault(a => (a.FirstName + " " + a.LastName) == selectedAdvisorName);

                if (selectedAdvisor != null)
                {
                    // สร้างนักศึกษาใหม่
                    Student student = new Student(tStudentID.Text, tFirstName.Text, tLastName.Text,
                                                  tMajor.Text, double.Parse(tGrade.Text), selectedAdvisor);

                    students.Add(student); // เพิ่มนักศึกษาใน List<Student>
                    selectedAdvisor.AddStudent(student);  // เพิ่มนักศึกษาให้กับอาจารย์ที่ปรึกษา

                    // แสดงข้อความ "บันทึกข้อมูลแล้ว"
                    MessageBox.Show("ข้อมูลนักศึกษาถูกบันทึกแล้ว");

                    // เคลียร์ข้อมูลใน TextBox
                    btnClear_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("ไม่พบอาจารย์ที่เลือก");
                }
            }
            else
            {
                MessageBox.Show("กรุณาเลือกอาจารย์ที่ปรึกษาก่อน");
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
