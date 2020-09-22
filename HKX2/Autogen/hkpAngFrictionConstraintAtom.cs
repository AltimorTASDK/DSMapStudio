using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hkpAngFrictionConstraintAtom : hkpConstraintAtom
    {
        public byte m_isEnabled;
        public byte m_firstFrictionAxis;
        public byte m_numFrictionAxes;
        public float m_maxFrictionTorque;
    }
}
