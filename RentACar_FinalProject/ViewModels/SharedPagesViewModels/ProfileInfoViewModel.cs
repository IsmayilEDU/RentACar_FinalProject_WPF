using RentACar_FinalProject.Models.Classes.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar_FinalProject.ViewModels.SharedPagesViewModels
{
    class ProfileInfoViewModel
    {
        public User SelectedUser { get; set; }
        public ProfileInfoViewModel(User SelectedUser)
        {
            this.SelectedUser = SelectedUser;
        }
    }
}
