using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hkbJigglerGroup : hkbBindable
    {
        public hkbBoneIndexArray m_boneIndices;
        public float m_mass;
        public float m_stiffness;
        public float m_damping;
        public float m_maxElongation;
        public float m_maxCompression;
        public bool m_propagateToChildren;
        public bool m_affectSiblings;
        public bool m_rotateBonesForSkinning;
    }
}
