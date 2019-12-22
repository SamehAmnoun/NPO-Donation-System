﻿using NPODS_Non_Profit_Organizations_Donation_System.View.CustomControls.UserControls.DonationOption;
using System.Collections.Generic;

namespace NPODS_Non_Profit_Organizations_Donation_System.Accounts.Donations
{
    class NullDonation : Donation
    {
        private static readonly NullDonation instance = new NullDonation();
        private NullDonation() : base(new  List<DonationTier>() { new DonationTier("null", "null", 0) })
        {
        }

        public static Donation getInstance()
        {
            return instance;
        }
        public override List<DonationButton> getOptions()
        {
            return new List<DonationButton>();
        }
        public override bool isNull()
        {
            return true;
        }
    }
}
