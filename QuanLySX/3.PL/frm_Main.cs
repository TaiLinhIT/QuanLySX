using System.Windows.Forms;

namespace QuanLySX
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
            LoadDefaultDisplay();
            
        }
        private void LoadDefaultDisplay()
        {

            //Cột mặc định
            List<string> NameColumn = new List<string>() { "Line","Product Name","Plane","Target","Result","Achieve","Progress"};
            tblPnlDisplay.Controls.Clear();
            for (int i = 0; i < NameColumn.Count; i++)
            {
                Label lbl = new Label();
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Font = new Font(Font.FontFamily, 12,FontStyle.Bold);
                lbl.Text = NameColumn[i];
                tblPnlDisplay.Controls.Add(lbl , i, 0);

            }
            


            Label label = new Label() { Text = "Tổng" };
            tblPnlDisplay.Controls.Add(label, 0, 12);  // Thêm vào hàng 1, cột 0
            label.Dock = DockStyle.Fill;  // Đảm bảo Label chiếm toàn bộ không gian
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Font = new Font(label.Font.FontFamily, 15);
            tblPnlDisplay.SetColumnSpan(label, 2); // Gộp cột 1 và 2 cho Label
        }


    }
}
