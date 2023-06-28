using Flights.Dtos;
using Microsoft.AspNetCore.Mvc;


namespace Flights.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class PassengerController : ControllerBase
	{
		//to store
		static private IList<NewPassengerDto> Passengers = new List<NewPassengerDto>();

		[HttpPost]
		[ProducesResponseType(201)]
		[ProducesResponseType(400)]
		[ProducesResponseType(500)]
		public IActionResult Register(NewPassengerDto dto)
		{
			//reciving the register call
			Passengers.Add(dto);
			System.Diagnostics.Debug.WriteLine(Passengers.Count);
			return Ok();
		}


	}
}
