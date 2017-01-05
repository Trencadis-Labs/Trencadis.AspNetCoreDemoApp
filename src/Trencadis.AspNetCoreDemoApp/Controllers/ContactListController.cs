using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trencadis.AspNetCoreDemoApp.DataAccess.Repository;

namespace Trencadis.AspNetCoreDemoApp.Controllers
{
  public class ContactListController : Controller
  {
    private readonly IContactListRepository contactListRepository;

    public ContactListController(IContactListRepository contactListRepository)
    {
      if (contactListRepository == null)
      {
        throw new ArgumentNullException(nameof(contactListRepository));
      }

      this.contactListRepository = contactListRepository;
    }

    // GET: /<controller>/
    public IActionResult Index()
    {
      var contactListEntries = this.contactListRepository.GetContactList();

      return View(contactListEntries);
    }
  }
}
