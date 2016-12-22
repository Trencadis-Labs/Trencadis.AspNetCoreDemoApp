using System.Collections.Generic;
using Trencadis.AspNetCoreDemoApp.Core.POCO;

namespace Trencadis.AspNetCoreDemoApp.DataAccess.Repository
{
  public interface IContactListRepository
  {
    IEnumerable<ContactListEntry> GetContactList();
  }
}
