using System.Collections.Generic;

namespace projekt_PassManager
{
    public class AccountManager
    {
        public List<Account> Accounts { get; set; } = new List<Account>();

        public bool IsUsernameUnique(string username)
        {
            return Accounts.Find(a => a.Username == username) == null;
        }

        public void AddAccount(Account account)
        {
            Accounts.Add(account);
        }
    }
}
