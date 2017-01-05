using System;
using System.Collections.Generic;
using Trencadis.AspNetCoreDemoApp.Core.POCO;
using Trencadis.AspNetCoreDemoApp.DataAccess.Repository;

namespace Trencadis.AspNetCoreDemoApp.DataAccess.InMemoryObjects.Repository
{
  public class ContactListRepository : IContactListRepository
  {
    private readonly InMemoryDatabaseObject database;

    public ContactListRepository(InMemoryDatabaseObject db)
    {
      if (db == null)
      {
        throw new ArgumentNullException(nameof(db));
      }

      this.database = db;
    }

    public IEnumerable<ContactListEntry> GetContactList()
    {
      return database.ContactList;
    }
  }
}
