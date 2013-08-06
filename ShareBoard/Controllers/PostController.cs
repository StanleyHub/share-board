using System;
using System.Collections.Generic;
using System.Web.Http;
using NHibernate;
using ShareBoard.Entities;
using ShareBoard.Models;

namespace ShareBoard.Controllers
{
    public class PostController : ApiController
    {
        static readonly ISessionFactory SessionFactory = DbSessionFactory.GetCurrentFactory();

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
                Type = request.Type,
                Time = DateTime.Now
            };

            //TODO save into the database
            using (var session = SessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(postItem);
                    transaction.Commit();
                }
            }
        }
    }
}