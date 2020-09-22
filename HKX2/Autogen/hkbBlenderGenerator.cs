using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public enum BlenderFlags
    {
        FLAG_SYNC = 1,
        FLAG_SMOOTH_GENERATOR_WEIGHTS = 4,
        FLAG_DONT_DEACTIVATE_CHILDREN_WITH_ZERO_WEIGHTS = 8,
        FLAG_PARAMETRIC_BLEND = 16,
        FLAG_IS_PARAMETRIC_BLEND_CYCLIC = 32,
        FLAG_FORCE_DENSE_POSE = 64,
        FLAG_BLEND_MOTION_OF_ADDITIVE_ANIMATIONS = 128,
        FLAG_USE_VELOCITY_SYNCHRONIZATION = 256,
    }
    
    public class hkbBlenderGenerator : hkbGenerator
    {
        public float m_referencePoseWeightThreshold;
        public float m_blendParameter;
        public float m_minCyclicBlendParameter;
        public float m_maxCyclicBlendParameter;
        public short m_indexOfSyncMasterChild;
        public short m_flags;
        public bool m_subtractLastChild;
        public List<hkbBlenderGeneratorChild> m_children;
    }
}
