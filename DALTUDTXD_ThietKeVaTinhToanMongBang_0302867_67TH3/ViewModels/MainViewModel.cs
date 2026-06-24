using DALTUDTXD_ThietKeVaTinhToanMongBang_0302867_67TH3.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DALTUDTXD_ThietKeVaTinhToanMongBang_0302867_67TH3.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private UserAccountModel _currentUserAccount;
        private ViewModelBase _currentChildView;
        private string _caption;

        public UserAccountModel CurrentUserAccount
        {
            get => _currentUserAccount;
            set
            {
                _currentUserAccount = value;
                OnPropertyChanged(nameof(CurrentUserAccount));
            }
        }

        public ViewModelBase CurrentChildView
        {
            get => _currentChildView;
            set
            {
                _currentChildView = value;
                OnPropertyChanged(nameof(CurrentChildView));
            }
        }

        public string Caption
        {
            get => _caption;
            set
            {
                _caption = value;
                OnPropertyChanged(nameof(Caption));
            }
        }

        public ICommand ShowHomeViewCommand { get; }
        public ICommand ShowCal1ViewCommand { get; }
        public ICommand ShowCal2ViewCommand { get; }
        public ICommand ShowCal3ViewCommand { get; }
        public ICommand ShowCal4ViewCommand { get; }
        public ICommand ShowCal5ViewCommand { get; }

        public HomeViewModel HomeViewModel { get; }
        public Page1ViewModel Page1ViewModel { get; }
        public Page2ViewModel Page2ViewModel { get; }
        public Page3ViewModel Page3ViewModel { get; }
        public Page4ViewModel Page4ViewModel { get; }
        public Page5ViewModel Page5ViewModel { get; }

        public MainViewModel()
        {
            HomeViewModel = new HomeViewModel();
            Page1ViewModel = new Page1ViewModel();
            Page2ViewModel = new Page2ViewModel(this);
            Page3ViewModel = new Page3ViewModel(this);
            Page4ViewModel = new Page4ViewModel(this);
            Page5ViewModel = new Page5ViewModel(this);

            ShowHomeViewCommand = new ViewModelCommand(ExecuteShowHomeViewCommand);
            ShowCal1ViewCommand = new ViewModelCommand(ExecuteShowCal1ViewCommand);
            ShowCal2ViewCommand = new ViewModelCommand(ExecuteShowCal2ViewCommand);
            ShowCal3ViewCommand = new ViewModelCommand(ExecuteShowCal3ViewCommand);
            ShowCal4ViewCommand = new ViewModelCommand(ExecuteShowCal4ViewCommand);
            ShowCal5ViewCommand = new ViewModelCommand(ExecuteShowCal5ViewCommand);

            ExecuteShowHomeViewCommand(null);
        }

        public ObservableCollection<ConstructionEntry> ConstructionList { get; set; } = new ObservableCollection<ConstructionEntry>();

        private void ExecuteShowHomeViewCommand(object obj)
        {
            CurrentChildView = HomeViewModel;
            Caption = "Trang chủ";
        }

        private void ExecuteShowCal1ViewCommand(object obj)
        {
            ExecuteShowPage1ViewCommand(null);
        }

        private void ExecuteShowCal2ViewCommand(object obj)
        {
            CurrentChildView = Page2ViewModel;
            Caption = "Thông số móng cơ bản";
        }

        private void ExecuteShowCal3ViewCommand(object obj)
        {
            CurrentChildView = Page4ViewModel;
            Caption = "Tải trọng";
        }

        private void ExecuteShowCal4ViewCommand(object obj)
        {
            CurrentChildView = Page3ViewModel;
            Caption = "Tính toán móng";
        }

        private void ExecuteShowCal5ViewCommand(object obj)
        {
            CurrentChildView = Page5ViewModel;
            Caption = "Báo cáo kết quả";
        }

        private void ExecuteShowPage1ViewCommand(object obj)
        {
            CurrentChildView = Page1ViewModel;
            Caption = "Số liệu nền đất";
        }

        public void ExecuteShowCal5View()
        {
            ExecuteShowCal5ViewCommand(null);
        }
    }
}
