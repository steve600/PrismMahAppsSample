using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismMahAppsSample.Infrastructure.Events
{
    public class StatusBarMessageUpdateEvent : PubSubEvent<string>
    {
    }
}
