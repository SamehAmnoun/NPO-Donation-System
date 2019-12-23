﻿using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using NPODS_Non_Profit_Organizations_Donation_System.controller.Login;
using System.Collections.Generic;

namespace NPODS_Non_Profit_Organizations_Donation_System.controller.DatabaseAccess
{
    public abstract class DatabaseAccess
    {
        private static readonly DatabaseAccess instance = FileDatabaseAccess.getInstance();

        protected DatabaseAccess() { }

        public static DatabaseAccess getInstance()
        {
            return instance;
        }

        public abstract List<LoginInfo> LoadLoginInfos();
        public abstract List<Organization> loadOrganizations();
        public abstract void SaveOrganizations(List<Organization> organizations);
        internal abstract List<Donor> loadDonors();
        internal abstract void SaveDonors(List<Donor> donors);
        internal abstract void addLogin(string email, string password, AccountType accountType);
    }
}
