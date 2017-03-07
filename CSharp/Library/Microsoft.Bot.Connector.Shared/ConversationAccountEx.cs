﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Bot.Connector
{
    public partial class ConversationAccount : IEquatable<ConversationAccount>
    {
        public bool Equals(ConversationAccount other)
        {
            return other != null
                && this.Id == other.Id
                && this.Name == other.Name
                && this.IsGroup == other.IsGroup;


        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as ConversationAccount);
        }

        public override int GetHashCode()
        {
            var code
                = this.Id.GetHashCode()
                ^ this.Name.GetHashCode()
                ^ this.IsGroup.GetHashCode();
            return code;
        }
    }
}