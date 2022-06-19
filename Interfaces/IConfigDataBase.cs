using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13Database.Interfaces
{
    public interface IConfigDataBase
    {
        string GetFullPath(string databaseFileName);
    }
}
