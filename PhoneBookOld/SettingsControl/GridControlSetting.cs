using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.SettingsControl
{
    public class GridControlSetting
    {
        public static void SetGridControlSetting(SfDataGrid grid)
        {
            grid.AllowEditing = false;
            grid.AllowResizingColumns = true;
            grid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.LastColumnFill;
            grid.BackColor = System.Drawing.Color.Silver;
            grid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            grid.HeaderRowHeight = 28;
            grid.RowHeight = 25;
            grid.Style.BorderColor = System.Drawing.Color.Gray;
            grid.Style.CaptionSummaryRowStyle.BackColor = System.Drawing.Color.White;
            grid.Style.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            grid.Style.HeaderStyle.BackColor = System.Drawing.SystemColors.Window;
            grid.Style.HeaderStyle.Font.Bold = true;
            grid.Style.HeaderStyle.Font.Size = 10F;
            grid.Style.HeaderStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
        }
    }
}
