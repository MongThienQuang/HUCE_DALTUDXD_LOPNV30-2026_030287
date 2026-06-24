using DALTUDTXD_ThietKeVaTinhToanMongBang_0302867_67TH3.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DALTUDTXD_ThietKeVaTinhToanMongBang_0302867_67TH3
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected void ApplicationStart(object sender, StartupEventArgs e)
        {
            var loginView = new LoginView();
            loginView.Show();
        }
    }
}
