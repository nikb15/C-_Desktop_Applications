using System;
using System.ComponentModel;
using EmployeeManager.Common.DataProvider;
using EmployeeManager.Common.Model;
using EmployeeManager.ViewModel.Command;

namespace EmployeeManager.ViewModel
{
    public class EmployeeViewModel : ViewBase
    {
        private readonly Employee _employee;
        private readonly IEmployeeDataProvider _employeeDataProvider;


        //Creating the contoller
        public EmployeeViewModel(Employee employee , IEmployeeDataProvider employeeDataProvider)
        {
            _employee = employee;
            _employeeDataProvider = employeeDataProvider;
            SaveCommand = new DelegateCommand(Save,()=>CanSave);
        }
        public DelegateCommand SaveCommand { get; }


        public string FirstName
        {
            get => _employee.FirstName;
            set
            {
                if (_employee.FirstName != value)
                {
                    _employee.FirstName = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(CanSave));
                    SaveCommand.RaiseCanExecuteChanged();
                    //This property will be triggered when we need to save the data
                }
            }
        }

        public DateTimeOffset EntryDate
        {
            get => _employee.EntryDate;
            set
            {
                if (_employee.EntryDate != value)
                {
                    _employee.EntryDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        public DateTime EntryDateTime
        {
            get => _employee.EntryDate.DateTime;
            set
            {
                if (_employee.EntryDate != value)
                {
                    _employee.EntryDate = value;
                    RaisePropertyChanged();
                }
            }
        }


        public int JobRoleId
        {
            get => _employee.JobRoleId;
            set
            {
                if (_employee.JobRoleId != value)
                {
                    _employee.JobRoleId = value;
                    RaisePropertyChanged();
                }
            }
        }

        public bool IsCoffeeDrinker
        {
            get => _employee.IsCoffeeDrinker;
            set
            {
                if (_employee.IsCoffeeDrinker != value)
                {
                    _employee.IsCoffeeDrinker = value;
                    RaisePropertyChanged();
                }
            }
        }

        public bool CanSave => !string.IsNullOrEmpty(FirstName);

        //NOW we will write the save method that will be triggered when button is created
        public void Save() 
        {
            _employeeDataProvider.SaveEmployee(_employee);
        }
    }
}
