using EmployeeManager.Common.Model;
using System.Collections.ObjectModel;
using System;
using EmployeeManager.Common.DataProvider;
using EmployeeManager.ViewModel.Command;

namespace EmployeeManager.ViewModel
{
    public class MainViewModel : ViewBase
    {
        private EmployeeViewModel _selectedEmployee;
        private readonly IEmployeeDataProvider _employeeDataProvider;

        

        public MainViewModel(IEmployeeDataProvider employeeDataProvider) 
        {
            _employeeDataProvider = employeeDataProvider;
            LoadCommand = new DelegateCommand(Load);
            //Take tw logic to excute , Not to Execute
        }
        public DelegateCommand LoadCommand { get; }

        public ObservableCollection<EmployeeViewModel> Employees { get; } = new();
        public ObservableCollection<JobRole> JobRoles { get; } = new();

        

        public EmployeeViewModel SelectedEmployee
        {
            get => _selectedEmployee;
            set
            {
                if (_selectedEmployee != value) 
                {
                    _selectedEmployee = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(isEmployeSelected));
                }
            }
        }

        public bool isEmployeSelected => SelectedEmployee != null;

        public void Load() 
        {
            var employees = _employeeDataProvider.LoadEmployees();
            var jobRoles = _employeeDataProvider.LoadJobRoles();

            Employees.Clear();
            foreach(var employee in employees) 
            {
                Employees.Add(new EmployeeViewModel(employee, _employeeDataProvider));
                
            }

            JobRoles.Clear();
            foreach (var jobrole in jobRoles)
            {
                JobRoles.Add(jobrole); 
            }
        }
    }
}
