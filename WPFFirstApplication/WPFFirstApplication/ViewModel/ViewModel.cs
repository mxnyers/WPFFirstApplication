using System.Collections.ObjectModel;
using WPFFirstApplication.Models;

namespace WPFFirstApplication.ViewModel
{
    class ViewModel
    {
        public ObservableCollection<ContactAddressOption> Contacts { get; set; }
        private ContactAddressOption _SelectedContact;
        public ContactAddressOption SelectedContact
        {
            get { return _SelectedContact; }
            set { _SelectedContact = value; }
        }

        public ViewModel()
        {
            Contacts = new ObservableCollection<ContactAddressOption>()
            {
                new ContactAddressOption(){ID=1, EmailAddress="testemail1@gmail.com"},
                new ContactAddressOption(){ID=2, EmailAddress="emailtester@yahoo.com"},
                new ContactAddressOption(){ID=3, EmailAddress="mtitest@mti.com"}
            };
        }
    }
}
