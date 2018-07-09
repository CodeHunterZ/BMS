using System;
using System.Windows.Forms;
using BMS.BLL;
using BMS.Entity;
using BMS.Tools;
using CCWin;

namespace BMS.BillForm
{
    public partial class EditBill : CCSkinMain
    {
        public EditBill()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.Add(new ListItem(0, "现金"));
            bindingSource.Add(new ListItem(1, "银行卡"));
            bindingSource.Add(new ListItem(2, "微信"));
            bindingSource.Add(new ListItem(3, "支付宝"));
            bindingSource.Add(new ListItem(4, "支票"));
            bindingSource.Add(new ListItem(5, "其他"));
            this.lbPayType.DataSource = bindingSource;
            this.lbPayType.DisplayMember = "Text";
            this.lbPayType.ValueMember = "Value";
        }

        private void EditBill_Load(object sender, System.EventArgs e)
        {
            
        }

        private void skinButton1_Click(object sender, System.EventArgs e)
        {
            Bill bill = new Bill();
            bill.Balance = decimal.Parse(this.txtBalance.Text);
            bill.CompanyName = this.txtCompany.Text;
            bill.Deadline = int.Parse(this.txtDeadline.Text);
            bill.EveryMonthPayment = decimal.Parse(this.txtEveryMonthPayment.Text);
            bill.Note = this.txtNote.Text;
            bill.PayType = int.Parse(this.lbPayType.ValueMember);
            bill.Phone = this.txtPhone.Text;
            bill.RealPayment = decimal.Parse(this.txtRealPayment.Text);
            bill.RecordTime = System.DateTime.Now;
            bill.StarTime = DateTime.Parse(this.ctlStartTime.text);
            bill.Status = 0;
            if (BillBll.GetInstance().addBill(bill) == 1)
            {
                MessageBox.Show("保存成功！");
            }
            else
            {
                MessageBox.Show("保存失败！");
            }

        }

        private void skinButton2_Click(object sender, System.EventArgs e)
        {

        }
    }
}
