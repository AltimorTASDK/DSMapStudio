using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hkbRaiseEventCommand : hkReferencedObject
    {
        public ulong m_characterId;
        public bool m_global;
        public int m_externalId;
    }
}
