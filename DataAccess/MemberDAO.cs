using System;
using System.Collections.Generic;
using System.Linq;
using BusinessObject;

namespace DataAccess
{
    public class MemberDAO
    {
        //initialize the member List
        private static List<MemberObject> _memberList = new List<MemberObject>()
        {
            new MemberObject{MemberId = 1, MemberName = "Dang Xuan Dat", Password = "123456", Email = "dangxuandat0@gmail.com", City = "Thu Duc", Country = "Viet Nam"},
            new MemberObject{MemberId = 2, MemberName = "Le Quang Ky", Password = "123456", Email = "lequangky@gmail.com", City = "Thu duc", Country = "Viet Nam"}
        };

        public List<MemberObject> GetMemberList => _memberList;

        //Using Singleton Pattern
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();

        private MemberDAO()
        {

        }

        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock) //ensure 1 thread running at the time
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }

                    return instance;
                }
            }
        }

        public MemberObject GetMemberByEmailAndPassword(string email, string password)
        {
            MemberObject member =
                GetMemberList.SingleOrDefault(member => member.Email == email && member.Password == password);
            return member;
        }

        public MemberObject GetMemberById(int MemberId)
        {
            MemberObject member = GetMemberList.SingleOrDefault(member => member.MemberId == MemberId);
            return member;
        }

        public MemberObject GetMemberByIdAndName(int MemberId, string MemberName)
        {
            MemberObject foundMember = GetMemberList.SingleOrDefault(member =>
                MemberId == member.MemberId && member.MemberName.ToUpper().Contains(MemberName.ToUpper()));
            //return member or a default Tsource => return null 
            return foundMember;
        }

        public void AddNewMember(MemberObject NewMember)
        {
            MemberObject checkDuplicated = GetMemberById(NewMember.MemberId);
            if (checkDuplicated != null)
            {
                throw new Exception("Member is already existed");
            }
            else
            {
                GetMemberList.Add(NewMember);
            }
        }

        public List<MemberObject> ListFilterByCityAndCountry(string city, string country)
        {
            List<MemberObject> filteredList =
                GetMemberList.FindAll(member => member.City == city && member.Country == country);
            return filteredList;
        }

        public List<MemberObject> SortMemberListDescendingByName()
        {
            var sortedList = from member in GetMemberList orderby member.MemberName select member;
            return sortedList.ToList();
        }

        public void DeleteMemberById(int MemberId)
        {
            var member = GetMemberById(MemberId);
            if (member == null)
            {
                throw new Exception("Member does not exist");
            }
            else
            {
                GetMemberList.Remove(member);
            }
        }

        public bool CheckduplicatedEmail(string email)
        {
            foreach (var memberObject in GetMemberList)
            {
                if (memberObject.Email.Equals(email)) return true;
            }

            return false;
        }

        public void UpdateMemberInfo(MemberObject UpdateMember)
        {
            var member = GetMemberById(UpdateMember.MemberId);
            if (member == null)
            {
                throw new Exception("Member does not exist!!");
            }

            if (CheckduplicatedEmail(UpdateMember.Email))
            {
                throw new Exception("Email is already existed!!");
            }
            member.MemberName = UpdateMember.MemberName ??= member.MemberName; // set new Name if input is not null, otherwise get old name to set
            member.Email = UpdateMember.Email ??= member.Email;
            member.Password = UpdateMember.Password ??= member.Password;
            member.City = UpdateMember.City ??= member.City;
            member.Country = UpdateMember.Country ??= member.Country;
        }

    }
}
