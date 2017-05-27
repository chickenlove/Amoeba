using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amoeba.Interface
{
    class ChatMessageEditWindowShowEvent : PubSubEvent<ChatMessageEditWindowViewModel> { }
    class OptionsWindowShowEvent : PubSubEvent<OptionsWindowViewModel> { }
    class PublishDirectoryInfoEditWindowShowEvent : PubSubEvent<PublishDirectoryInfoEditWindowViewModel> { }
    class NameEditWindowViewModelShowEvent : PubSubEvent<NameEditWindowViewModel> { }
    class ConfirmWindowViewModelShowEvent : PubSubEvent<ConfirmWindowViewModel> { }

    class Messenger : EventAggregator
    {
        public static Messenger Instance { get; } = new Messenger();
    }
}