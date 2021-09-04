using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Template.Preferences
{
    [ApiController]
    [ApiVersion("1.0", Deprecated = true)]
    [Route("v{version:apiVersion}/preferences/{userId}")]
    public class PreferencesController : Controller
    {
        /// <summary>
        /// </summary>
        /// <param name="userId">Can be whitespace. YOLO.</param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<Destinations> Get(string userId)
        {
            var prefs = new Destinations
            {
                Id = userId,
                PhoneNumbers = new List<PhoneNumber>
                {
                    new PhoneNumber
                    {
                        E164 = "+1415555267",
                        Label = "Mobile",
                        IsPrimary = true,
                        SmsEnabled = true,
                    },
                    new PhoneNumber
                    {
                        E164 = "+1415555268",
                        Label = "Office",
                    },
                },
                EmailAddresses = new List<EmailAddress>
                {
                    new EmailAddress
                    {
                        Label = "Work",
                        Value = $"{userId}@example.org",
                    },
                }
            };
            return Ok(prefs);
        }

        [HttpPut]
        public ActionResult Set(
            string userId,
            [FromBody] Destinations destinations)
        {
            // Do the thing...
            
            // Return the persisted value
            return Ok("Goodbye");
        }
    }
}