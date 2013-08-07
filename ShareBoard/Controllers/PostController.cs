using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using NHibernate;
using ShareBoard.Entities;
using ShareBoard.Models;

namespace ShareBoard.Controllers
{
    public class PostController : ApiController
    {
        readonly ISession _session = DbSessionFactory.GetCurrentFactory().OpenSession();

        // GET api/values
        public IEnumerable<PostItem> Get()
        {
            PostItem[] postItems = _session.CreateQuery("from PostItem").List<PostItem>().ToArray();
            return postItems;
        }

        // POST api/values
        public void Post(PostRequest request)
        {
            var postItem = new PostItem
            {
                Content = request.Content,
                Type = request.Type,
                Time = DateTime.Now
            };

            using (var transaction = _session.BeginTransaction())
            {
                _session.SaveOrUpdate(postItem);
                transaction.Commit();
            }
        }
    }
}