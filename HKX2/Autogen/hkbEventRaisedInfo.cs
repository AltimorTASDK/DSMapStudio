using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hkbEventRaisedInfo : hkReferencedObject
    {
        public ulong m_characterId;
        public string m_eventName;
        public bool m_raisedBySdk;
        public int m_senderId;
        public int m_padding;
    }
}
