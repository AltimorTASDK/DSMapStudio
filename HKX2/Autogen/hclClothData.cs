using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public enum Platform
    {
        HCL_PLATFORM_INVALID = 0,
        HCL_PLATFORM_WIN32 = 1,
        HCL_PLATFORM_X64 = 2,
        HCL_PLATFORM_MACPPC = 4,
        HCL_PLATFORM_IOS = 8,
        HCL_PLATFORM_MAC386 = 16,
        HCL_PLATFORM_PS3 = 32,
        HCL_PLATFORM_XBOX360 = 64,
        HCL_PLATFORM_WII = 128,
        HCL_PLATFORM_LRB = 256,
        HCL_PLATFORM_LINUX = 512,
        HCL_PLATFORM_PSVITA = 1024,
        HCL_PLATFORM_ANDROID = 2048,
        HCL_PLATFORM_CTR = 4096,
        HCL_PLATFORM_WIIU = 8192,
        HCL_PLATFORM_PS4 = 16384,
        HCL_PLATFORM_XBOXONE = 32768,
    }
    
    public class hclClothData : hkReferencedObject
    {
        public string m_name;
        public List<hclSimClothData> m_simClothDatas;
        public List<hclBufferDefinition> m_bufferDefinitions;
        public List<hclTransformSetDefinition> m_transformSetDefinitions;
        public List<hclOperator> m_operators;
        public List<hclClothState> m_clothStateDatas;
        public List<hclAction> m_actions;
        public Platform m_targetPlatform;
    }
}
