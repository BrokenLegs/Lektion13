using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lektion13.Domain.Entities;

namespace Lektion13.Domain.Repositories
{
    public class FakeProductRepository : FakeRepository<Post>, IProductRepository
    {
        public FakeProductRepository(params Post[] products)
        {
            context = products.ToList();
        }

        public IQueryable<Post> FindProductsByCategoryID(int id)
        {
            return new List<Post>().AsQueryable();
        }
    }
}