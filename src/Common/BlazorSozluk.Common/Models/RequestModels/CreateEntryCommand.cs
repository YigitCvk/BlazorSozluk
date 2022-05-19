using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSozluk.Common.Models.RequestModels
{
    public class CreateEntryCommand:IRequest<Guid>
    {
        public string Subject { get; set; }
        public string Content { get; set; }
        public Guid? CreateById { get; set; }

        public CreateEntryCommand()
        {

        }
        public CreateEntryCommand(string subject, string content, Guid? createById)
        {
            Subject = subject;
            Content = content;
            CreateById = createById;
        }
    }
}
