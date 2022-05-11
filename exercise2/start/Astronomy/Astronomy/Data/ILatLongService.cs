using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astronomy
{
    public interface ILatLongService
    {
        Task<(double Latitude, double Longitude)> GetLatLong();
    }
}
