using System;

namespace ClassLibrary
{
    
    public class clsReceiptUser
    {
        private int mUserID;
        private string mUserName;
        private string mPassword;
        private string mDepartment;

        public int UserID {  get { return mUserID; } set { mUserID = value; } }
        public string UserName { get {  return mUserName; } set { mUserName = value; } }
        public string Password {  get { return mPassword; } set { mPassword = value; } }
        public string Department { get {  return mDepartment; } set { mDepartment = value; } }

        public bool FindUser(string userName, string password)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserName", userName);
            DB.AddParameter("@Password", password);
            DB.Execute("sproc_UserTable_FindUserNamePW");
            if(DB.Count == 1)
            {
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}