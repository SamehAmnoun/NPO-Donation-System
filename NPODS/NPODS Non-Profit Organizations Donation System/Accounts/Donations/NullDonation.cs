﻿using NPODS_Non_Profit_Organizations_Donation_System.View.Controls.DonationOption;
using System.Collections.Generic;

namespace NPODS_Non_Profit_Organizations_Donation_System.Accounts.Donations
{
    class NullDonation : Donation
    {
        private static readonly NullDonation instance = new NullDonation();
        private NullDonation() : base(new DonationTier[] { new DonationTier("null", "null", 0) })
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

    }
}
