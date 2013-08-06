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
        static readonly ISessionFactory SessionFactory = DbSessionFactory.GetCurrentFactory();
        readonly ISession _session = SessionFactory.OpenSession();

        // GET api/values
        public IEnumerable<PostItem> Get()
        {
            IQuery query = _session.CreateQuery("from PostItem");
            PostItem[] postItems = query.List<PostItem>().ToArray();
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