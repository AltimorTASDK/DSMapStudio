using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hknpVehicleDefaultVelocityDamper : hknpVehicleVelocityDamper
    {
        public float m_normalSpinDamping;
        public float m_collisionSpinDamping;
        public float m_collisionThreshold;
    }
}
