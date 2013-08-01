using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using ShareBoard.Entities;
using ShareBoard.Models;

namespace ShareBoard.Controllers
{
    public class PostController : ApiController
    {
        // GET api/values
        public IEnumerable<PostItem> Get()
        {
            PostItem postItem1 = new PostItem()
                {
                    Content = "C#",
                    Type = PostItemType.Hear,
                    Time = DateTime.Now
                };
            PostItem postItem2 = new PostItem()
            {
                Content = "AngularJS",
                Type = PostItemType.Share,
                Time = DateTime.Now
            };
            return new PostItem[] {postItem1, postItem2};
        }

        // POST api/values
        public void Post(PostRequest request)
        {
            PostItem postItem = new PostItem()
                {
                    Content = request.Content,
                    Type = request.Type
                };

            //TODO save into the database

        }
    }
}