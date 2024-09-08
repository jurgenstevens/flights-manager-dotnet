using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcFlight.Models;

namespace MvcFlight.Data
{
    public class MvcFlightContext : DbContext
    {
        public MvcFlightContext(DbContextOptions<MvcFlightContext> options)
            : base(options)
        {
        }


        public DbSet<Ticket> Tickets { get; set; } = default!;
        public DbSet<Flight> Flights { get; set; } = default!;

    }
}
