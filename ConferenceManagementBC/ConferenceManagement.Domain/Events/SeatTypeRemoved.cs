﻿using System;
using ENode.Eventing;

namespace ConferenceManagement
{
    [Serializable]
    public class SeatTypeRemoved : DomainEvent<Guid>
    {
        public Guid SeatTypeId { get; private set; }

        public SeatTypeRemoved() { }
        public SeatTypeRemoved(Guid seatTypeId)
        {
            SeatTypeId = seatTypeId;
        }
    }
}
