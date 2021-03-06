using System;
using Microsoft.AspNetCore.Mvc;
using DavidBerry.Framework.ApiUtil.Results;

namespace DavidBerry.Framework.ApiUtil.Controllers
{


    /// <summary>
    /// Class containing controller extension methods, mostly helpers for returning difference status code results
    /// </summary>
    public static class ControllerExtensions
    {

        /// <summary>
        /// Returns a forbidden (HTTP 403) result with no additional data
        /// </summary>
        /// <param name="controller">A Controller object this method is being called against</param>
        /// <returns>A ForbiddenResult object representing an HTTP 403 response</returns>
        public static ActionResult Forbidden(this ControllerBase controller)
        {
            return new ForbiddenResult();
        }

        /// <summary>
        /// Returns a forbidden (HTTP 403) result with the specified value object included in the response
        /// </summary>
        /// <param name="controller">A Controller object this method is being called against</param>
        /// <param name="value">A FobiddenObjectResult object representing an HTTP 403 response with a payload describing
        /// why the request was rejected</param>
        /// <returns></returns>
        public static ActionResult Forbidden(this ControllerBase controller, object value)
        {
            return new ForbiddenObjectResult(value);
        }


        public static ActionResult InternalServerError(this ControllerBase controller)
        {
            return new InternalServerErrorResult();
        }

        public static ActionResult InternalServerError(this ControllerBase controller, object value)
        {
            return new InternalServerErrorObjectResult(value);
        }


    }
}
