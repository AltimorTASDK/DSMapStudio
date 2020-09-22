using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hkbPinBonesGenerator : hkbGenerator
    {
        public hkbGenerator m_referenceFrameGenerator;
        public hkbGenerator m_pinnedGenerator;
        public hkbBoneIndexArray m_boneIndices;
        public float m_fraction;
    }
}
