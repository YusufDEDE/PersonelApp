using PersonelApp.DAL;
using PersonelApp.DAL.Repositories.Abstractions;
using PersonelApp.Domains;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelApp_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<join> jn = new List<join>();
            UnitOfWork unitOfWork = new UnitOfWork(new PersonelContext());
            List<Department> departments = new List<Department>();
            departments = unitOfWork.DepartmentRepository.GetDepartmentsWithPersonels().ToList();
            foreach (Department department in departments)
            {

                foreach (Personel personel in department.Personels)
                {
                    join jns = new join()
                    {
                        per_id = personel.Id,
                        dept_id = department.Id,
                        Dept_name = department.Dept_Name,
                        Personel_name = personel.Name

                    };
                    jn.Add(jns);
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = jn;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            UnitOfWork unitOfWork = new UnitOfWork(new PersonelContext());
            unitOfWork.PersonelRepository.Add(new Personel()
            {

                Name = txtName.Text,
                LastName = txtLastName.Text,
                DepatmentID = 0,
                
            });
            unitOfWork.Complate();
        }

        private void btnDeptPer_Click(object sender, EventArgs e)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new PersonelContext());

            unitOfWork.DepartmentRepository.Add(new Department()
            {
                Dept_Name = textBox1.Text,
                IsActive = true
                
            });

            unitOfWork.Complate();
        }

        private void btnPerList_Click(object sender, EventArgs e)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new PersonelContext());

           List<Department> list = new List<Department>();

            foreach (Department item in unitOfWork.DepartmentRepository.GetAll())
            {
                list.Add(item);
            }

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = list;

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Department model = new Department();
            UnitOfWork unitOfWork = new UnitOfWork(new PersonelContext());

            model = unitOfWork.DepartmentRepository.GetById(7);
            model.Dept_Name = "Muhasebe";
            model.IsActive = true;
            model.UpdateTime = DateTime.Now;

            unitOfWork.Complate();
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Personel dp = new Personel();
            UnitOfWork unitOfWork = new UnitOfWork(new PersonelContext());

            dp = unitOfWork.PersonelRepository.GetById(2);

            unitOfWork.PersonelRepository.Remove(dp);
            
            
              
        }
    }
}
