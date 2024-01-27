﻿using Clothings_Store.Data;
using Clothings_Store.Models.Database;

namespace Clothings_Store.Repositories;
public class OrderDetailRepository : GenericRepository<OrderDetail,string>
{
    public OrderDetailRepository(StoreContext context) : base(context)
    {
    }
}
