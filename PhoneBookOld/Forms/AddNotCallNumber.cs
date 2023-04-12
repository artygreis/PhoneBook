using PhoneBook.Types;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PhoneBook.Forms
{
    public partial class AddNotCallNumber : Syncfusion.Windows.Forms.MetroForm
    {
        Regex regex = new Regex(@"[^0-9]");
        public NotCall NotCall { get; set; }
        public string Mask { get; set; }

        public string NameForm
        {
            get => lblHeader.Text;
            set => lblHeader.Text = value;
        }
        public AddNotCallNumber()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AddOneApartment_Load(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(Mask))
            {
                maskedEditNumber.Mask = Mask;
            }
            if (NotCall != null)
            {
                maskedEditNumber.Text = NotCall.Number;
                rtxtNotes.Text = NotCall.Notes;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationContext())
            {
                var notCallExist = db.NotCall.Where(n => n.Number == regex.Replace(maskedEditNumber.Text, "")).Count();
                if (notCallExist > 0)
                {
                    MessageBox.Show("Данный номер уже внесен в базу.",
                        "Информация",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }
            }

            if (regex.Replace(maskedEditNumber.Text, "").Length != 0 && regex.Replace(maskedEditNumber.Text, "").Length != Mask.Replace("-", "").Length)
            {
                errorValidating.SetError(maskedEditNumber, $"В номере должно быть {Mask.Replace("-", "").Length} цифр");
                errorValidating.SetIconPadding(maskedEditNumber, 8);
                return;
            }
            errorValidating.Clear();
            NotCall.Number = regex.Replace(maskedEditNumber.Text.Trim(), "");
            NotCall.Notes = rtxtNotes.Text;

            DialogResult = DialogResult.OK;
            
        }
    }
}
