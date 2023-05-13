using ProFormaLibraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFormaUI
{
    public interface ICustomerItemSelection
    {
        void SelectedCustomer(CustomerModel customer);
        void ItemSelection(ItemModel SelectedItem);
    }
}
