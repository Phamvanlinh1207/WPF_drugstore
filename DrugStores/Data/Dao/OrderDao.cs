using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Dao
{
    public interface OrderDao
    {
        public void insert(Order order);
        public void update(Order order);
        public List<Order> findAll();
        public int count();
        public Order findById(int id);
        public void deleteById(int id);
    }
}
