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

        public AuctionsController(IAuctionDao auctionDao = null)
        {
            if (auctionDao == null)
            {
                dao = new AuctionDao();
            }
            else
            {
                dao = auctionDao;
            }
        }
        [HttpGet]
        public List<Auction> ListAuctions(string title_like = "", double currentBid_lte = 0)
        {

            if (title_like == "" && currentBid_lte == 0)
            {
                return dao.List();
            }
            else if (title_like != "" && currentBid_lte != 0)
            {
                //return dao.SearchByTitle(title_like);
                return dao.SearchByTitleAndPrice(title_like, currentBid_lte);
            }
            else if (title_like == "" && currentBid_lte != 0)
            {
                return dao.SearchByPrice(currentBid_lte);
            }
            return dao.SearchByTitle(title_like);
        }

        [HttpGet("/auctions/{id}")]
        public Auction GetAuctionById(int id)
        {
            Auction auction = dao.Get(id);

            if (auction != null)
            {
                return auction;
            }
            return null;
        }

        [HttpPost("/auctions")]
        public Auction CreateAuction(Auction auctionSpecific)
        {
            Auction auction = dao.Create(auctionSpecific);

            if (auction != null)
            {
                return auction;
            }
            return null;
        }
       

        }
    }


    
