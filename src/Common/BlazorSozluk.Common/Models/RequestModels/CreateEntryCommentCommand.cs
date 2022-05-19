using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSozluk.Common.Models.RequestModels
{
    public class CreateEntryCommentCommand:IRequest<Guid>
    {
        public Guid? EntryId { get; set; }
        public string Comment { get; set; }
        public Guid? CreateById { get; set; }

        public CreateEntryCommentCommand()
        {
        }

        public CreateEntryCommentCommand(Guid entryId, string comment, Guid createById)
        {
            EntryId = entryId;
            Comment = comment;
            CreateById = createById;
        }
    }
}
