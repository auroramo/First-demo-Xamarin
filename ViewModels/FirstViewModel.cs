using Cirrious.MvvmCross.ViewModels;

namespace FirstDemoPCL.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
        public string _firstName { get; set; }
        public string _lastName { get; set; }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; RaisePropertyChanged(() => FirstName); RaisePropertyChanged(() => FullName); }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; RaisePropertyChanged(() => LastName); RaisePropertyChanged(() => FullName); }
        }

        public string FullName 
        {
            get { return string.Format("{0} {1}", _firstName, _lastName); }
        }
    }
}
