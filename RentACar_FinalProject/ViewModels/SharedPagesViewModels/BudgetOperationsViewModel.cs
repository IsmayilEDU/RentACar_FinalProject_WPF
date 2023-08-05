using RentACar_FinalProject.Models.Classes.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar_FinalProject.ViewModels.SharedPagesViewModels
{
    class BudgetOperationsViewModel
    {
        public User SelectedUser { get; set; }
        public BudgetOperationsViewModel(User selectedUser) 
        {
            SelectedUser= selectedUser;
        }
    }
}
