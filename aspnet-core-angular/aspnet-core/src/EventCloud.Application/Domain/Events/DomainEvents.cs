﻿
using Abp.Events.Bus;

namespace EGhana.Domain.Events
{
    public static class DomainEvents
    {
        public static IEventBus EventBus { get; set; }

        static DomainEvents()
        {
            EventBus = Abp.Events.Bus.EventBus.Default;
        }
    }
}
