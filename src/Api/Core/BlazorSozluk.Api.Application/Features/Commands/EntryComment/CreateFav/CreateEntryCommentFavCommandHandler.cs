using BlazorSozluk.Common;
using BlazorSozluk.Common.Infrastructure;
using BlazorSozluk.Common.Models.Events.EntryComment;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSozluk.Api.Application.Features.Commands.EntryComment.CreateFav
{
    internal class CreateEntryCommentFavCommandHandler : IRequestHandler<CreateEntryCommentFavCommand, bool>
    {
        public async Task<bool> Handle(CreateEntryCommentFavCommand request, CancellationToken cancellationToken)
        {
            QueueFactory.SendMessageToExchange(exchangeName:SozlukConstants.FavExchangeName,
                exchangeType:SozlukConstants.DefaultExchangeType,
                queueName:SozlukConstants.CreateEntryCommentFavQueueName,
                obj:new CreateEntryCommentFavEvent()
                {
                    EntryCommentId=request.EntryCommentId,
                    CreatedBy=request.UserId
                });
            return await Task.FromResult(true);
        }
    }
}
