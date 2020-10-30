using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using log4net;

namespace CompraloTo
{
    public interface ILogService
    {
        void LogError(string errorMessage);
    }


    public sealed class LogService : ILogService
    {

        public LogService()
        {
            log4net.Config.XmlConfigurator.Configure();
        }


        public void LogError(string errorMessage)
        {
            ILog ilog = LogManager.GetLogger(GetType());

            ilog.Error(string.Format("Request.URL:{0}", OffendingUrl));
            ilog.Error(errorMessage);
        }

        private string OffendingUrl
        {
            get
            {
                return HttpContext.Current.Request.Url.AbsolutePath;
            }
        }

    }
}