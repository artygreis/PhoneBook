using PhoneBook.Types;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PhoneBook.Forms
{
    public partial class AddSingleNumber : Syncfusion.Windows.Forms.MetroForm
    {
        Regex regex = new Regex(@"[^0-9]");
        public string Address { get; set; }
        public NumberPhone NumberPhone { get; set; }
        public string Mask { get; set; }
        public AddSingleNumber()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AddOneApartment_Load(object sender, System.EventArgs e)
        {
            labelAddress.Text = $"{Address}";
            if (!string.IsNullOrEmpty(Mask))
            {
                maskedEditNumber.Mask = Mask;
            }
            if (NumberPhone != null)
            {
                textBoxApartment.Text = NumberPhone.Apartment;
                maskedEditNumber.Text = NumberPhone.Number;
            }
            else
            {
                NumberPhone = new NumberPhone();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxApartment.Text))
            {
                errorValidating.SetError(textBoxApartment, "Введите номер квартиры.");
                errorValidating.SetIconPadding(textBoxApartment, 8);
                return;
            }
            errorValidating.Clear();
            if (regex.Replace(maskedEditNumber.Text, "").Length != 0 && regex.Replace(maskedEditNumber.Text, "").Length != Mask.Replace("-", "").Length)
            {
                errorValidating.SetError(maskedEditNumber, $"В номере должно быть {Mask.Replace("-", "").Length} цифр");
                errorValidating.SetIconPadding(maskedEditNumber, 8);
                return;
            }
            errorValidating.Clear();
            NumberPhone.Apartment = textBoxApartment.Text.Trim();
            NumberPhone.Number = regex.Replace(maskedEditNumber.Text.Trim(), "");
            DialogResult = DialogResult.OK;
            
        }
    }
}
