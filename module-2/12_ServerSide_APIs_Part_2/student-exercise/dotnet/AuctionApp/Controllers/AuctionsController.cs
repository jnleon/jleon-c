using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AuctionApp.Models;
using AuctionApp.DAO;

namespace AuctionApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuctionsController : ControllerBase
    {
        private readonly IAuctionDao dao;

        public AuctionsController(IAuctionDao auctionDao)
        {
            dao = auctionDao;
        }

        [HttpGet]
        public List<Auction> List(string title_like = "", double currentBid_lte = 0)
        {
            if (title_like != "")
            {
                return dao.SearchByTitle(title_like);
            }
            if (currentBid_lte > 0)
            {
                return dao.SearchByPrice(currentBid_lte);
            }

            return dao.List();
        }

        [HttpGet("{id}")]
        public ActionResult<Auction> Get(int id)
        {
            Auction auction = dao.Get(id);
            if (auction != null)
            {
                return Ok(auction);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<Auction> Create(Auction auction)
        {
            Auction created = dao.Create(auction);
            return Created($"/auctions/{created.Id}", created);
        }

        [HttpPut("{id}")]
        public ActionResult<Auction> Update(Auction auction, int id)
        {
            Auction existing = dao.Get(id);
            if (existing == null) 
            {
                return NotFound("Auction not found");
            }
            Auction result = dao.Update(id, auction);
            return Ok(result);
        }
        
         [HttpDelete("{id}")]
        public ActionResult<Auction> Delete(int id)
        {
            Auction existing = dao.Get(id);
            if (existing == null)
            {
                return NotFound("Auction not found");
            }
            return dao.Delete(id) ? NoContent() : StatusCode(500);
        }
    }
}

