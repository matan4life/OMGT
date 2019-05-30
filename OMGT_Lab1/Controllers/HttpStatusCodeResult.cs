﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OMGT_Lab1.Controllers
{
    internal class HttpStatusCodeResult : IActionResult
    {
        private object badRequest;

        public HttpStatusCodeResult(object badRequest)
        {
            this.badRequest = badRequest;
        }

        public Task ExecuteResultAsync(ActionContext context)
        {
            throw new System.NotImplementedException();
        }
    }
}