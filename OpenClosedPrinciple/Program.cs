
using OpenClosedPrinciple;

PersonManager personManager = new(PersonsDB.GetPeople());

personManager.Print();