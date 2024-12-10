using APITutorial.Model;
using Microsoft.AspNetCore.Mvc;

// this is a basic controller to link to the API
// the controller uses the methods in a DAO to access data
// the controller does not actually access the data


namespace APITutorial.Controllers
{
    // this method will handle a GET Request with nothing ...
    [Route("api")]
    // [Route() specifies the main URL path this Controller will handle
    // This controller will handle the path: /api/ (http://servermame:nnnn/api = www.websitename.com)
    // unless its overriden by [HttpGet], [HttpPost], [HttpPut], or [HttpDelete]

    [ApiController]     // Identifies the class as containing ApiControllers
    public class BasicController : ControllerBase
    {
        // Any data used by multiple methods is defined outside any methods
        // Define an instance of the DAO
        GamblerDAO theData = new GamblerDAO();


        // Step 2
        // Create controller methods
        [HttpGet("/")]

        // IACTIONRESULT is a propper HTTP response object
        public IActionResult ControllerActionResult()
        {
            return Ok("Text here appears on the server");
            // OK is a response that sends a status code 200 
            // also sends the data inside the parentheses
        }

        // Method to return all of the data in the data source
        [HttpGet("/gambler")]                       // path to get all Gamblers - must be different than any other path
        public IActionResult getGamblerData()       // method name doesnt matter
        {
            return Ok(theData.getGamblers());       // Call the DAO method and return whatever it gives us
        }

        // method to return a specific gambler based on their ID
        // There must be a method in the DAO to do this for us
        // We need to get the ID to find from the URL as a parameter
        [HttpGet("/gambler/{id}")]    // Handle /gambler/id
        public IActionResult GetAGambler(int id)          // will recieve the ID parameter from the URL
        {
            // Use the DAO method to find a specific Gambler
            return Ok(theData.getSpecificGambler(id));
        }

        // Method to find a Gambler by name or partial name
        // We will use a query parameter
        // We will use a DAO method to find the data
        [HttpGet("/findgambler")]     // /gambler/?name=
        public IActionResult getGamblerByName(string GamblerName)
        {
            return Ok(theData.getGamblerDataByName(GamblerName));
        }

        // Add a gambler to the data source
        // the HTTP Post will send us the new data in the body of the response (JSON)
        // the server will automatically instantiate the gambler object from the JSON
                // there must be a DAO to add the Gambler
        [HttpPost("/gambler")]
        public IActionResult AddAGambler(Gambler newGambler)
        {
            return Ok(theData.AddAGambler(newGambler));
        }
    }
}