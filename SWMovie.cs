using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace SW
{
    #region SWMovie
    public class SWMovie
    {
        #region Member Variables
        protected string _Title;
        protected string _Actor;
        protected string _Genre;
        protected string _Date;
        protected string _Duration;
        #endregion
        #region Constructors
        public SWMovie() { }
        public SWMovie(string Title, string Actor, string Genre, string Date, string Duration)
        {
            this._Title=Title;
            this._Actor=Actor;
            this._Genre=Genre;
            this._Date=Date;
            this._Duration=Duration;
        }
        #endregion
        #region Public Properties
        public virtual string Title
        {
            get {return _Title;}
            set {_Title=value;}
        }
        public virtual string Actor
        {
            get {return _Actor;}
            set {_Actor=value;}
        }
        public virtual string Genre
        {
            get {return _Genre;}
            set {_Genre=value;}
        }
        public virtual string Date
        {
            get {return _Date;}
            set {_Date=value;}
        }
        public virtual string Duration
        {
            get {return _Duration;}
            set {_Duration=value;}
        }
        #endregion
    }
    #endregion
}