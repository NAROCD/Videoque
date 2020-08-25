using System.Collections.Generic;
using Videoque.Models;

namespace Videoque.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }


    }
}