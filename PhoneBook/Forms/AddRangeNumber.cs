using PhoneBook.Properties;
using PhoneBook.Types;
using Syncfusion.Data;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Interactivity;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PhoneBook.Forms
{
    public partial class AddRangeNumber : Syncfusion.Windows.Forms.MetroForm
    {
        Regex regex = new Regex(@"[^0-9]");
        public string Address { get; set; }
        public string Mask { get; set; }
        public int AddressId { get; set; }
        public List<NumberPhone> NumberPhones { get; set; }
        public AddRangeNumber(string mask)
        {
            InitializeComponent();
            Mask = mask;
            uC_GridNumberPhones.SelectionModeGrid = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Single;
            //uC_GridNumberPhones.SelectionUnitGrid = Syncfusion.WinForms.DataGrid.Enums.SelectionUnit.Row;
            uC_GridNumberPhones.DataGrid.AllowEditing = true;
            uC_GridNumberPhones.DataGrid.EditMode = Syncfusion.WinForms.DataGrid.Enums.EditMode.DoubleClick;
            uC_GridNumberPhones.DataGrid.EditorSelectionBehavior = Syncfusion.WinForms.DataGrid.Enums.EditorSelectionBehavior.Default;
            uC_GridNumberPhones.DataGrid.ShowRowHeader = true;
            uC_GridNumberPhones.DataGrid.AddNewRowPosition = Syncfusion.WinForms.DataGrid.Enums.RowPosition.Bottom;

            uC_GridNumberPhones.DataGrid.AutoGeneratingColumn += DataGrid_AutoGeneratingColumn;
            uC_GridNumberPhones.DataGrid.AddNewRowInitiating += DataGrid_AddNewRowInitiating;
            uC_GridNumberPhones.DataGrid.DrawCell += DataGrid_DrawCell;
            uC_GridNumberPhones.DataGrid.CellClick += DataGrid_CellClick;
            uC_GridNumberPhones.DataGrid.CurrentCellValidating += DataGrid_CurrentCellValidating;
        }

        private void DataGrid_CurrentCellValidating(object sender, Syncfusion.WinForms.DataGrid.Events.CurrentCellValidatingEventArgs e)
        {
            if (e.Column == uC_GridNumberPhones.DataGrid.Columns["Apartment"])
            {
                e.NewValue = e.NewValue?.ToString().Trim().ToUpper() ?? "";
                if (string.IsNullOrEmpty(e.NewValue.ToString()))
                {
                    e.IsValid = false;
                    e.ErrorMessage = "Введите номер квартиры. Для отмены нажмите на клавиатуре Esc.";
                }
            }

            if (e.Column == uC_GridNumberPhones.DataGrid.Columns["Number"])
            {
                if (regex.Replace(e.NewValue?.ToString() ?? "", "").Length != 0 && regex.Replace(e.NewValue?.ToString() ?? "", "").Length != Mask.Replace("-","").Length)
                {
                    e.IsValid = false;
                    e.ErrorMessage = $"В номере должно быть {Mask.Replace("-", "").Length} цифр. Для отмены нажмите на клавиатуре Esc.";
                }
            }
        }

        private void DataGrid_CellClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            if (!uC_GridNumberPhones.Validate()) return;
            if (e.DataColumn.ColumnIndex == 0 && e.DataRow.RowIndex != uC_GridNumberPhones.DataGrid.RowCount - 1)
            {
                int deletingRowIndex = uC_GridNumberPhones.DataGrid.TableControl.ResolveToRecordIndex(e.DataRow.RowIndex);
                var dataSource = uC_GridNumberPhones.DataGrid.DataSource as List<NumberPhone>;

                dataSource.RemoveAt(deletingRowIndex);
                uC_GridNumberPhones.DataGrid.DataSource = null;
                e.Cancel = true;
                if (dataSource.Count == 0)
                {
                    UpdateData(new List<NumberPhone>() { new NumberPhone() { AddressId = AddressId } });
                }
                else
                {
                    UpdateData(dataSource);
                }
                uC_GridNumberPhones.DataGrid.SelectedItem = uC_GridNumberPhones.DataGrid.View.Records[0];
            } 
        }

        private void DataGrid_DrawCell(object sender, Syncfusion.WinForms.DataGrid.Events.DrawCellEventArgs e)
        {
            if (uC_GridNumberPhones.DataGrid.ShowRowHeader && e.RowIndex != 0 && e.RowIndex != uC_GridNumberPhones.DataGrid.RowCount - 1)
            {
                if (e.ColumnIndex == 0)
                {
                    e.Handled = true;
                    Rectangle rect = new Rectangle(e.Bounds.X + 7, e.Bounds.Y + 7, e.Bounds.Width - 14, e.Bounds.Height - 12);
                    e.Graphics.FillRectangle(new SolidBrush(uC_GridNumberPhones.DataGrid.Style.RowHeaderStyle.BackColor),
                        new Rectangle(e.Bounds.X + 1, e.Bounds.Y + 1, e.Bounds.Width - 2, e.Bounds.Height - 2));
                    e.Graphics.DrawImage(new Bitmap(Resources.remove), rect);
                }
            }
        }

        private void DataGrid_AddNewRowInitiating(object sender, Syncfusion.WinForms.DataGrid.Events.AddNewRowInitiatingEventArgs e)
        {
            var data = e.NewObject as NumberPhone;
            data.AddressId = AddressId;
        }

        private void DataGrid_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
            if (e.Column.MappingName == "Number" && !string.IsNullOrEmpty(Mask))
            {
                e.Column = new GridMaskColumn() { MappingName = "Number", HeaderText = "Номер телефона", Mask = Mask };
            }
        }
        /// <summary>
        /// Загрузка и обновление данных
        /// </summary>
        /// <param name="numberPhones"></param>
        private void UpdateData(List<NumberPhone> numberPhones)
        {
            uC_GridNumberPhones.DataGrid.DataSource = numberPhones;
            uC_GridNumberPhones.DataGrid.Columns["Id"].Visible = false;
            uC_GridNumberPhones.DataGrid.Columns["Apartment"].Width = 120;
            uC_GridNumberPhones.DataGrid.Columns["Apartment"].ValidationMode = Syncfusion.WinForms.DataGrid.Enums.GridValidationMode.InView;
            uC_GridNumberPhones.DataGrid.Columns["AddressId"].Visible = false;
            uC_GridNumberPhones.DataGrid.Columns["Number"].Width = 180;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AddRangeNumber_Load(object sender, System.EventArgs e)
        {
            labelAddress.Text = $"{Address}";
            uC_GridNumberPhones.DataGrid.ClipboardController = new CustomClipboardController(uC_GridNumberPhones.DataGrid, AddressId);
            UpdateData(new List<NumberPhone>() { new NumberPhone() { AddressId = AddressId } });
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            var result = new List<NumberPhone>();
            foreach (var number in uC_GridNumberPhones.DataGrid.DataSource as List<NumberPhone>)
            {
                if (number.AddressId == 0)
                    number.AddressId = AddressId;
                number.Number = regex.Replace(number.Number ?? "", "");
                if (!string.IsNullOrEmpty(number.Apartment))
                    result.Add(number);
                NumberPhones = result;
            }
            DialogResult = DialogResult.OK;
        }
    }

    public class CustomClipboardController : DataGridClipboardController
    {
        SfDataGrid dataGrid;
        int addressId;
        public CustomClipboardController(SfDataGrid dataGrid, int addressId) : base(dataGrid)
        {
            this.dataGrid = dataGrid;
            this.addressId = addressId;
        }
        protected override void PasteToRows(object clipboardRows)
        {
            var copiedRecord = (string[])clipboardRows;
            int copiedRecordsCount = copiedRecord.Count();
            //Based on the clipboard count added the new record to be pasted.
            if (copiedRecordsCount > 0)
            {
                for (int i = 0; i < copiedRecordsCount; i++)
                {
                    if (!string.IsNullOrEmpty(copiedRecord[i]))
                    {
                        var selectedRecord = this.dataGrid.SelectedItems;
                        var firsrRow = selectedRecord[0] as NumberPhone;
                        if (i==0 && selectedRecord.Count == 1 && string.IsNullOrEmpty(firsrRow.Apartment ?? "") && string.IsNullOrEmpty(firsrRow.Number ?? ""))
                        {
                            base.PasteToRow(copiedRecord[i].Trim().ToUpper(), selectedRecord[0]);
                            base.PasteToCell(selectedRecord[0], this.dataGrid.Columns["AddressId"], addressId);
                            continue;
                        }
                        else
                        {
                            // Creates new record.
                            this.dataGrid.View.AddNew();
                        }
                        
                        var k = 0;
                        for (int j = 0; j < this.dataGrid.Columns.Count; j++)
                        {
                            var record = copiedRecord[i];
                            string[] splitRecord = Regex.Split(record, @"\t");
                            //Adds the new record by using the PasteToCell method, by passing       the created data, particular column, and clipboard value.
                            if (this.dataGrid.Columns[j].Visible == true && k < splitRecord.Length)
                            {
                                this.PasteToCell(this.dataGrid.View.CurrentAddItem, this.dataGrid.Columns[j], splitRecord[k].Trim().ToUpper());
                                ++k;
                            }
                            
                            if (j == 3)
                                PasteToCell(this.dataGrid.View.CurrentAddItem, this.dataGrid.Columns[j], addressId);
                        }
                        // Commits the pasted record.
                        this.dataGrid.View.CommitNew();
                    }
                }
            }
        }
    }
}
