using System.Data;

namespace formsimthe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Class2 kn=new Class2();
        private void Form1_Load(object sender, EventArgs e)
        {
            getData();
        }
        public void getData()
        {
            string query = "select * from sim order by sim.NgayKichHoat ASC";
            DataSet ds = kn.LayDuLieu(query);
            Bangsim.DataSource = ds.Tables[0];
        }
    }
}
