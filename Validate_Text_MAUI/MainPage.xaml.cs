using System.Text.RegularExpressions;

namespace Validate_Text_MAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            // Biểu thức chính quy để chỉ cho phép chữ cái và số
            //var regex = new Regex("^[a-zA-Z0-9 ]*$");
            //Biểu thức chính quy để chỉ cho phép chữ cái, không được phép nhập số, ký tự đặc biệt và dấu cách
            var regex = new Regex("^[a-zA-Z]*$");
            // Biểu thức chính quy để chỉ cho phép chữ cái và dấu cách (không cho phép số)
            //var regex = new Regex("^[a-zA-Z ]*$");
            // Nếu văn bản chứa ký tự đặc biệt, giữ lại giá trị cũ
            if (!regex.IsMatch(e.NewTextValue))
            {
                ((Entry)sender).Text = e.OldTextValue;
            }
        }
    }

}
