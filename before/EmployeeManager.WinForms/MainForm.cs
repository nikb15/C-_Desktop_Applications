﻿using EmployeeManager.DataAccess;
using EmployeeManager.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManager.WinForms
{
    public partial class MainForm : Form
    {
        private  MainViewModel _viewModel;

        public MainForm()
        {
            InitializeComponent();
            _viewModel = new MainViewModel(new EmployeeDataProvider());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            _viewModel.Load();
            employeeBindingSource.DataSource = _viewModel.Employees;
            lsbEmployees.DataSource = employeeBindingSource;
            lsbEmployees.DisplayMember = "FirstName";

            cboJobRole.DataSource = _viewModel.JobRoles;
            cboJobRole.DisplayMember = "RoleName";
            cboJobRole.ValueMember = "Id";
            var areDataBindingInit = cboJobRole.DataBindings.Count > 0;
            if (areDataBindingInit)
            {
                employeeBindingSource.ResetBindings(true);
            }
            else
            {
                cboJobRole.DataBindings.Add("SelectedValue",
                    employeeBindingSource, "JobRoleId");


                txtFirstName.DataBindings.Add(
                    "Text",
                    employeeBindingSource,
                    "FirstName",
                    false,
                    DataSourceUpdateMode.OnPropertyChanged
                    );

                dtpEntryDate.DataBindings.Add("Value", employeeBindingSource, "EntryDateTime");
                chkIsCoffeeDrinker.DataBindings.Add("Checked", employeeBindingSource, "IsCoffeeDrinker");


                btnSave.DataBindings.Add("Enabled", employeeBindingSource, "CanSave");

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(employeeBindingSource.Current is EmployeeViewModel employeeViewModel
                && employeeViewModel.CanSave)
            {
                employeeViewModel.Save();
            }
        }
    }
}
