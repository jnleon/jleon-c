﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp
{
    public class APIService
    {
        static readonly string API_URL = "http://localhost:3000/";
        static readonly RestClient client = new RestClient();

        public List<Auction> GetAllAuctions()
        {
            RestRequest request = new RestRequest(API_URL + "auctions");
            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);
            return response.Data;
        }

        public Auction GetDetailsForAuction(int auctionId)
        {
            RestRequest request = new RestRequest(API_URL + "auctions/" +auctionId);
            IRestResponse<Auction> response = client.Get<Auction>(request);
            return response.Data;
        }

        public List<Auction> GetAuctionsSearchTitle(string searchTitle)
        {
            RestRequest request = new RestRequest(API_URL + "auctions?title_like="+ searchTitle);
            IRestResponse <List<Auction>> response = client.Get<List<Auction>>(request);
            return response.Data;
        }

        public List<Auction> GetAuctionsSearchPrice(double searchPrice)
        {
            RestRequest request = new RestRequest(API_URL + "auctions?currentBid_lte=" + searchPrice);
            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);
            return response.Data;
        }
    }
}
