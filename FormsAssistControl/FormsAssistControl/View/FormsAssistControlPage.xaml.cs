using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FormsAssistControl
{
    public partial class FormsAssistControlPage : ContentPage
    {
        public FormsAssistControlPage()
        {
            InitializeComponent();
            this.BindingContext = new StudentDirectoryVM();
            lvStudents.ItemSelected += LvStudents_ItemSelected;
        }

        void LvStudents_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Student selectedStudent = (Student)e.SelectedItem;
            if (selectedStudent == null)
                return;
            Navigation.PushAsync(new StudentDetailPage(selectedStudent));
            lvStudents.SelectedItem = null;
        }
    }
}
