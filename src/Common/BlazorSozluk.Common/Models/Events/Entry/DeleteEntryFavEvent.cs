﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSozluk.Common.Models.Events.Entry
{
    public class DeleteEntryFavEvent
    {
        public Guid EntryId { get; set; }

        public Guid CreatedBy { get; set; }
    }
}
