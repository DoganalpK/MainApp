using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Presentation.CustomControllerBase
{
    public class CustomControllerBase
    {
        public IActionResult CreateActionResult<T>(CustomResponseDto<T> response)
        {
            return new ObjectResult(response.StatusCode == 204 ? null : response)
            {
                StatusCode = response.StatusCode
            };
        }
    }
}
