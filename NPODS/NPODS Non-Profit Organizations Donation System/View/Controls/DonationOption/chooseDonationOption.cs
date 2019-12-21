﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPODS_Non_Profit_Organizations_Donation_System.View.Controls.DonationOption;
using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using NPODS_Non_Profit_Organizations_Donation_System.Accounts.Donation;
using NPODS_Non_Profit_Organizations_Donation_System.OrganizationUtil;

namespace NPODS_Non_Profit_Organizations_Donation_System
{
    public partial class chooseDonationOption : UserControl
    {
        public chooseDonationOption()
        {
            InitializeComponent();
            organization =
                    new Organization(
                        "Instagram@hydra.com",
                        "123",
                        "Iceland",
                        "ignore the name. there's no ice here",
                        "",
                        true,
                        new MiscDonation[] { new MiscDonation("Ramesy.com") },
                        new SubDonation(true, new DonationTier[] { new DonationTier("plz", "send help", 50.2f) }),
                        new SingleDonation(true, new DonationTier[] { new DonationTier("plz", "send help", 50.2f) }),
                        new DonationGoal(true, 500f, 841258f),
                        new OrganizationStatistics()
                        );

            pnl_displayOptions.Controls.AddRange(organization.SingleDonation.getOptions().ToArray());
        }


        private void btn_singlePayment_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            btn_subscription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(216)))), ((int)(((byte)(238)))));
            btn_miscellaneous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(216)))), ((int)(((byte)(238)))));
            pnl_displayOptions.Controls.Clear();
            pnl_displayOptions.Controls.AddRange(organization.SingleDonation.getOptions().ToArray());
        }

        private void btn_subscription_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            btn_singlePayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(216)))), ((int)(((byte)(238)))));
            btn_miscellaneous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(216)))), ((int)(((byte)(238)))));
            pnl_displayOptions.Controls.Clear();
            pnl_displayOptions.Controls.AddRange(organization.SubDonation.getOptions().ToArray());
        }

        private void btn_miscellaneous_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            btn_singlePayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(216)))), ((int)(((byte)(238)))));
            btn_subscription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(216)))), ((int)(((byte)(238)))));
            pnl_displayOptions.Controls.Clear();
            pnl_displayOptions.Controls.AddRange(organization.getMiscOptions().ToArray());
        }

        
    }
}
