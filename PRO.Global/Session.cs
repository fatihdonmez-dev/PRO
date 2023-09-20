using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Specialized;

namespace PRO.Global
{
    public sealed class Session
    {

    #region Singletion

        private static readonly Session _instance = new Session();
        public static Session Instance
        {
            get { return _instance; }
        }
        private Session()
        {
            _localizer= new Culture(System.Threading.Thread.CurrentThread.CurrentUICulture);
        }

        #endregion 

        private SessionUsers _user;
        public SessionUsers CurrentUser
        {
            get { return _user;  }
            set {
                    //if (_user == null)
                        _user = value;
                    //else
                    //    throw new Exception("Kullanıcı zaten atanmış !");
                }
        }

        private Culture _localizer;
        public Culture CurrentCulture
        {
            get { return _localizer; }
            set {
                if (_localizer == null)
                    _localizer = value;
                    else
                        throw new Exception("Localizer zaten atanmış !");
                }
        }

        private SessionConnect _Connect;
        public SessionConnect CurrentConnect
        {
            get { return _Connect; }
            set
            {
                _Connect = value;
            }
        }



        public Guid MEMORY_ID = Guid.Empty;

    }




}
