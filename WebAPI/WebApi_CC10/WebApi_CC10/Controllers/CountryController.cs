using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_CC10.Models;

namespace WebApi_CC10.Controllers
{
   
        [RoutePrefix("api/Country")]
        public class CountryController : ApiController
        {
            
            List<Country> countryList = new List<Country>()
        {
            new Country {id = 1, CountryName = "India", Capital = "Delhi"},
            new Country {id = 2, CountryName = "Germany", Capital = "Berlin"},
            new Country {id = 3, CountryName = "France", Capital = "Paris"},
        };

            // GET all the list of country
            [HttpGet]
            [Route("All")]
            public IEnumerable<Country> GetAllCountries()
            {
                return countryList;
            }


            // GET: api/Country/ById?pId=3
            [HttpGet]
            [Route("ById")]
            public IHttpActionResult GetCountryById(int pId)
            {
                string countryName = countryList.Where(c => c.id == pId).SingleOrDefault()?.CountryName;
                if (countryName == null)
                {
                    return NotFound();
                }
                return Ok(countryName);
            }

            // POST: api/Country/AllPost
            [HttpPost]
            [Route("AllPost")]
            public List<Country> PostNewCountry([FromBody] Country country)
            {
                countryList.Add(country);
                return countryList;
            }

        // PUT: api/Country?pid=1
        [HttpPut]
        [Route("updateCountry")]
        public IEnumerable<Country> UpdateCountry(int pid, [FromUri] Country updatedCountry)
        {
            var existingCountry = countryList.FirstOrDefault(c => c.id == pid);
            if (existingCountry != null)
            {
                existingCountry.CountryName = updatedCountry.CountryName;
                existingCountry.Capital = updatedCountry.Capital;
            }
            return countryList;
        }

        // DELETE: api/Country/delcountry?pid=1
        [HttpDelete]
            [Route("delcountry")]
            public IEnumerable<Country> DeleteCountry(int pid)
            {
                var country = countryList.FirstOrDefault(c => c.id == pid);
                if (country != null)
                {
                    countryList.Remove(country);
                }
                return countryList;
            }
        }
    }