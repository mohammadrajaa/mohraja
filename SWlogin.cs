using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace SW
{
    #region SWlogin
    public class SWlogin
    {
        #region Member Variables
        protected string _Username;
        protected string _Password;
        protected unknown _Status;
        #endregion
        #region Constructors
        public SWlogin() { }
        public SWlogin(string Password, unknown Status)
        {
            this._Password=Password;
            this._Status=Status;
        }
        #endregion
        #region Public Properties
        public virtual string Username
        {
            get {return _Username;}
            set {_Username=value;}
        }
        public virtual string Password
        {
            get {return _Password;}
            set {_Password=value;}
        }
        public virtual unknown Status
        {
            get {return _Status;}
            set {_Status=value;}
        }
        #endregion
    }
    #endregion
}