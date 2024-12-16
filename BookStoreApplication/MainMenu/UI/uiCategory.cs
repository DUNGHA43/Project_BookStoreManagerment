using BLL;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UI
{
    public partial class uiCategory : UserControl
    {
        private readonly CategoryBLL _cate;
        public uiCategory()
        {
            InitializeComponent();
            _cate = new CategoryBLL();
            txtNameCategory.Enabled = false;
            LoadAllCate();
        }

        private async void LoadAllCate()
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = await _cate.GetAllCategoriesAsync();

            gcCategory.DataSource = binding;
            gvCategory.PopulateColumns();
        }
    }
}
