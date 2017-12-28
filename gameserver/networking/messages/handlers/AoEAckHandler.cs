﻿#region

using gameserver.networking.incoming;

#endregion

namespace gameserver.networking.handlers
{
    internal class AOEAckHandler : MessageHandlers<AOEACK>
    {
        public override MessageID ID => MessageID.AOEACK;

        protected override void HandleMessage(Client client, AOEACK message) => NotImplementedMessageHandler();
    }
}