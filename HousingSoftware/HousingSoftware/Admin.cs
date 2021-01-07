﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingSoftware
{
    public class Admin
    {
        private string username;
        private string firstName;
        private string lastName;
        private string password;
        private List<Tenant> tenants = new List<Tenant>();
        private List<Grocery> allGroceries = new List<Grocery>();
        private List<string> complaints = new List<string>();
        private List<Agreements> agreements = new List<Agreements>();
        private List<Announcements> announcements = new List<Announcements>();
        private List<HouseRules> houseRules = new List<HouseRules>();

        public Admin(string username, string password, string firstName, string lastName)
        {
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
        }



        //  USERNAME
        public void SetUsername(string inputedUsername)
        {
            username = inputedUsername;
        }

        public string GetUsername()
        {
            return username;
        }

        // First name
        public string FirstName
        {
            set { this.firstName = value; }
            get { return this.firstName; }
        }

        // Last name
        public string LastName
        {
            set { this.lastName = value; }
            get { return this.lastName; }
        }


        //  PASSWORD
        public void SetPassword(string inputedPassword)
        {
            password = inputedPassword;
        }

        public string GetPassword()
        {
            return password;
        }

        //  MANAGE TENANTS
        public void AddTenant(Tenant inputedTenant)
        {
            tenants.Add(inputedTenant);
        }

        public void RemoveTenant(Tenant inputedTenant)
        {
            tenants.Remove(inputedTenant);
        }

        public void RemoveTenantAt(int index)
        {
            tenants.RemoveAt(index);
        }

        public void SetTenants(List<Tenant> inputedTenants)
        {
            tenants = inputedTenants;
        }

        public List<Tenant> GetTenants()
        {
            return tenants;
        }

        //  MANAGE GROCERIES
        public void SetAllGroceries(List<Grocery> groceries)
        {
            allGroceries = groceries;
        }

        public List<Grocery> GetAllGroceries()
        {
            return allGroceries;
        }

        public void AddGrocery(Grocery grocery)
        {
            allGroceries.Add(grocery);
        }

        public void RemoveGrocery(Grocery grocery)
        {
            allGroceries.Remove(grocery);
        }

        public void RemoveGroceryAt(int index)
        {
            allGroceries.RemoveAt(index);
        }

        public void RemoveAllGroceries()
        {
            allGroceries.Clear();
        }

        //  COMPLAINTS
        public void AddComplaint(string newComplaint)
        {
            complaints.Add(newComplaint);
        }

        public void RemoveComplaint(string selectedComplaint)
        {
            complaints.Remove(selectedComplaint);
        }

        public List<string> GetComplaints()
        {
            return complaints;
        }

        // AGREEMENTS
        public void AddAgreement(Agreements newAgreements)
        {
            agreements.Add(newAgreements);
        }

        public List<Agreements> GetAgreements()
        {
            return agreements;
        }

        // ANNOUNCEMENTS
        public void AddAnnouncement(Announcements announcement)
        {
            announcements.Add(announcement);
        }
        public List<Announcements> Announcements
        {
            get { return this.announcements; }
        }
        
        // House Rules
        public void AddHouseRule(HouseRules HouseRule)
        {
            houseRules.Add(HouseRule);
        }

        public List<HouseRules> HouseRules
        {
            get {return this.houseRules; }
        }

    }
}
