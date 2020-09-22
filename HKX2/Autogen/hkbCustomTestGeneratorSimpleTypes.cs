using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hkbCustomTestGeneratorSimpleTypes : hkbCustomTestGeneratorHiddenTypes
    {
        public long m_simpleTypeHkInt64;
        public ulong m_simpleTypeHkUint64;
        public bool m_simpleHiddenTypeCopyStart;
        public bool m_simpleTypeBool;
        public bool m_simpleTypeHkBool;
        public string m_simpleTypeCString;
        public string m_simpleTypeHkStringPtr;
        public char m_simpleTypeHkInt8;
        public short m_simpleTypeHkInt16;
        public int m_simpleTypeHkInt32;
        public byte m_simpleTypeHkUint8;
        public ushort m_simpleTypeHkUint16;
        public uint m_simpleTypeHkUint32;
        public float m_simpleTypeHkReal;
        public char m_simpleTypeHkInt8Default;
        public short m_simpleTypeHkInt16Default;
        public int m_simpleTypeHkInt32Default;
        public byte m_simpleTypeHkUint8Default;
        public ushort m_simpleTypeHkUint16Default;
        public uint m_simpleTypeHkUint32Default;
        public float m_simpleTypeHkRealDefault;
        public char m_simpleTypeHkInt8Clamp;
        public short m_simpleTypeHkInt16Clamp;
        public int m_simpleTypeHkInt32Clamp;
        public byte m_simpleTypeHkUint8Clamp;
        public ushort m_simpleTypeHkUint16Clamp;
        public uint m_simpleTypeHkUint32Clamp;
        public float m_simpleTypeHkRealClamp;
        public bool m_simpleHiddenTypeCopyEnd;
    }
}
