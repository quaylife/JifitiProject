using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Professional.Services.Assignment

{
	public class AddCandidateController : Controller
	{
		[HttpPost]
		public IActionResult Index([FromBody] Candidate candidate)
		{
			try
			{
				SaveCandidate(candidate);
				return Ok();
			}
			catch (Exception ex)
			{
				return StatusCode(500, ex);
			}
		}

		private void SaveCandidate(Candidate candidate)
		{
			var firstName = candidate.Name.First.Trim();
			var lastName = candidate.Name.Last.Trim();
			var age = candidate.Age;
			var height = candidate.Height;
			var weight = candidate.Weight;
			var hairColour = candidate.HairColour.Trim();
			var maritalStatus = candidate.MaritalStatus.Trim();
			var isEmployed = candidate.IsEmployed;
			var city = candidate.Address.City.Trim();
			var street = candidate.Address.Street.Trim();
			var house = candidate.Address.House.Trim(); 37.
		}
	}




	public class Candidate
	{
		public Name Name { get; set; }
		public int Age { get; set; }
		public int Height { get; set; }
		public int Weight { get; set; }
		public string HairColour { get; set; }
		public Address Address { get; set; }
		public string MaritalStatus { get; set; }
		public bool IsEmployed { get; set; }
	}

	public class Name
	{
		public string First { get; set; }
		public string Last { get; set; }
	}

    public record Address(
        string City, string Street, string House);
}

