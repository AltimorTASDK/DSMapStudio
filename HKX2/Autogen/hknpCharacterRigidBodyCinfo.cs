using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hknpCharacterRigidBodyCinfo : hkReferencedObject
    {
        public uint m_collisionFilterInfo;
        public hknpShape m_shape;
        public Vector4 m_position;
        public Quaternion m_orientation;
        public float m_mass;
        public float m_dynamicFriction;
        public float m_staticFriction;
        public float m_weldingTolerance;
        public uint m_reservedBodyId;
        public byte m_additionMode;
        public byte m_additionFlags;
        public Vector4 m_up;
        public float m_maxSlope;
        public float m_maxForce;
        public float m_maxSpeedForSimplexSolver;
        public float m_supportDistance;
        public float m_hardSupportDistance;
    }
}
