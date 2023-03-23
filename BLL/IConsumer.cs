using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace BLL
{
    public interface IConsumer
    {
        List<Consumer> getAllConsumer();

        Consumer validateConsumer(String RationId, String password);

        Consumer showDetailsByID(String user);
    }
}
