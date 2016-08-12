using AnalyticsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalysticsLibrary.Helpers
{

    public static class ErrorHandler
    {
        /// <summary>
        /// Extension for handling Error Messages at one place
        /// </summary>
        /// <param name="err">Extended error object</param>
        /// <param name="errorMessage">String from Exception or other string that contains a Error-StatusCode.</param>
        /// <returns>A filled error object</returns>
        public static Error SetError(this Error err, string errorMessage)
        {

            err.Code = "000 - Unhandled Error Request";
            err.Message = errorMessage;

            if (errorMessage.Contains("401"))
            {
                err.Code = "401 - Not Authorized";
                err.Message = "You have no permissions for this ressource, please login.";
            }

            else if (errorMessage.Contains("404"))
            {
                err.Code = "404 - Not Found";
                err.Message = "Sorry, there is no content.";
            }

            else if (errorMessage.Contains("400"))
            {
                err.Code = "400 - Bad Request";
                err.Message = "The request had bad syntax or was inherently impossible to be satisfied.";
            }

            else if (errorMessage.Contains("500"))
            {
                err.Code = "500 - Internal Server Error";
                err.Message = "The server encountered an unexpected condition which prevented it from fulfilling the request.";
            }

            else if (errorMessage.Contains("9999"))
            {
                err.Code = "999 - Wrong Login";
                err.Message = "Wrong Login, try again.";
            }

            return err;
        } 
    }
}
