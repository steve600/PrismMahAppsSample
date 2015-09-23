using NLog;
using Prism.Logging;

namespace PrismMahAppsSample.Shell.Logging
{
    public class NLogLogger : ILoggerFacade
    {
        #region Members and Constants

        private Logger logger = LogManager.GetCurrentClassLogger();

        #endregion Members and Constants 
        
        #region ILoggerFacade Members

        /// <summary>
        /// Write a new log entry with the specified category and priority.
        /// </summary>
        /// <param name="message">Message body to log.</param>
        /// <param name="category">Category of the entry.</param>
        /// <param name="priority">The priority of the entry (not used by NLog so we pass Priority.None)</param>
        public void Log(string message, Category category, Priority priority)
        {
            switch (category)
            {
                case Category.Debug:
                    logger.Debug(message);
                    break;
                case Category.Exception:
                    logger.Error(message);
                    break;
                case Category.Info:
                    logger.Info(message);
                    break;
                case Category.Warn:
                    logger.Warn(message);
                    break;
                default:
                    logger.Info(message);
                    break;
            }
        }

        #endregion ILoggerFacade Members
    }
}