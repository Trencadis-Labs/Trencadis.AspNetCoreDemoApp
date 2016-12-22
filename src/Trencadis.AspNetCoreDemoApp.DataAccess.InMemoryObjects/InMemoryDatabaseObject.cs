using System;
using System.Collections.Generic;
using System.Linq;
using Trencadis.AspNetCoreDemoApp.Core.POCO;

namespace Trencadis.AspNetCoreDemoApp.DataAccess.InMemoryObjects
{
  public class InMemoryDatabaseObject
  {
    public InMemoryDatabaseObject()
    {
      this.Seed();
    }

    public List<ContactListEntry> ContactList { get; } = new List<ContactListEntry>();

    public int GeneratePK<TModel>()
    {
      Type modelType = typeof(TModel);
      if (modelType == typeof(ContactListEntry))
      {
        return this.ContactList.Max(c => c.Id) + 1;
      }

      throw new NotSupportedException(string.Format("Unable to generate key for type '{0}'", modelType));
    }

    private void Seed()
    {
      for (int i = 0; i < 100; i++)
      {
        this.ContactList.Add(new ContactListEntry
        {
          Id = i + 1,
          EntryName = $"Test item {i}",
          PhoneNumber = string.Format("0770-000.{0}", i.ToString().PadLeft(3, '0')),
          Email = $"test_{i}@yahoo.com"
        });
      }
    }
  }
}
