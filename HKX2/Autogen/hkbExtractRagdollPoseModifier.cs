using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hkbExtractRagdollPoseModifier : hkbModifier
    {
        public short m_poseMatchingBone0;
        public short m_poseMatchingBone1;
        public short m_poseMatchingBone2;
        public bool m_enableComputeWorldFromModel;
    }
}
