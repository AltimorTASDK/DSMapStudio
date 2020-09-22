using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hknpVehicleDefaultTransmission : hknpVehicleTransmission
    {
        public float m_downshiftRPM;
        public float m_upshiftRPM;
        public float m_primaryTransmissionRatio;
        public float m_clutchDelayTime;
        public float m_reverseGearRatio;
        public List<float> m_gearsRatio;
        public List<float> m_wheelsTorqueRatio;
    }
}
