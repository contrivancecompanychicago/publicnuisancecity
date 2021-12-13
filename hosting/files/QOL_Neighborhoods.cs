using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace __publicnuisancecitygame
{
    #region QOLNeighborhoods
    public class QOLNeighborhoods
    {
        #region Member Variables
        protected string _COL;
        protected string _COL;
        protected string _COL;
        protected string _COL;
        protected string _COL;
        protected string _COL;
        #endregion
        #region Constructors
        public QOLNeighborhoods() { }
        public QOLNeighborhoods(string COL, string COL, string COL, string COL, string COL, string COL)
        {
            this._COL=COL;
            this._COL=COL;
            this._COL=COL;
            this._COL=COL;
            this._COL=COL;
            this._COL=COL;
        }
        #endregion
        #region Public Properties
        public virtual string COL
        {
            get {return _COL;}
            set {_COL=value;}
        }
        public virtual string COL
        {
            get {return _COL;}
            set {_COL=value;}
        }
        public virtual string COL
        {
            get {return _COL;}
            set {_COL=value;}
        }
        public virtual string COL
        {
            get {return _COL;}
            set {_COL=value;}
        }
        public virtual string COL
        {
            get {return _COL;}
            set {_COL=value;}
        }
        public virtual string COL
        {
            get {return _COL;}
            set {_COL=value;}
        }
        #endregion
    }
    #endregion
}