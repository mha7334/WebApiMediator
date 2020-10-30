using MediatR;
using WebApiBoostrapper.Notification;

namespace WebApiBoostrapper.Services
{
    public class NotifierMediatorService: INotifierMediatorService
    {
        private readonly IMediator _mediator;
        public NotifierMediatorService(IMediator mediator)
        {
            _mediator = mediator;
        }
        public void Notify(string notifyText)
        {
            _mediator.Publish(new NotificationMessage() {NotifyText = notifyText});
        }
    }
}