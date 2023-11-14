#version 450

struct sceneParams
{
	mat4 projection;
	mat4 view;
	vec4 eye;
	vec4 lightDirection;
	uint envmap;
};

layout(set = 0, binding = 0) uniform SceneParamBuffer
{
    sceneParams sceneparam;
};

struct instanceData
{
	mat4 world;
	// 0: material id
	// 1: bone base
	// 3: entity id
	uvec4 materialID;
};

layout(set = 1, binding = 0, std140) buffer WorldBuffer
{
    readonly instanceData idata[];
};

layout(set = 7, binding = 0, std140) buffer BoneBuffer
{
    readonly mat4 bones[];
};

layout (constant_id = 50) const bool c_normalWBoneTransform = false;

layout(location = 0) in vec3 position;
layout(location = 1) in ivec2 uv;
layout(location = 2) in ivec4 normal;
layout(location = 3) in ivec4 binormal;
layout(location = 4) in ivec4 bitangent;
layout(location = 5) in uvec4 color;
#if defined(MATERIAL_BLEND) || defined(LIGHTMAP)
	layout(location = 6) in ivec2 uv2;
#if defined(MATERIAL_BLEND) && defined(LIGHTMAP)
	layout(location = 7) in ivec2 uv3;
#endif
#endif

layout(location = 0) out vec2 fsin_texcoord;
layout(location = 1) out vec3 fsin_view;
layout(location = 2) out mat3 fsin_worldToTangent;
layout(location = 5) out vec3 fsin_normal;
layout(location = 6) out vec4 fsin_bitangent;
layout(location = 7) out vec4 fsin_color;
layout(location = 8) out uint fsin_mat;
layout(location = 9) out uint fsin_entityid;
#if defined(MATERIAL_BLEND) || defined(LIGHTMAP)
	layout(location = 10) out vec2 fsin_texcoord2;
#if defined(MATERIAL_BLEND) && defined(LIGHTMAP)
        layout(location = 11) out vec2 fsin_texcoord3;
#endif
#endif

void main()
{
	mat4 w = idata[gl_InstanceIndex].world;
	fsin_texcoord = vec2(uv) / 2048.0;
#if defined(MATERIAL_BLEND) || defined(LIGHTMAP)
	fsin_texcoord2 = vec2(uv2) / 2048.0;
#if defined(MATERIAL_BLEND) && defined(LIGHTMAP)
	fsin_texcoord3 = vec2(uv3) / 2048.0;
#endif
#endif
	fsin_normal = normalize(mat3(w) * vec3(normal));
	fsin_bitangent = bitangent;
        fsin_color = color;
	fsin_view = normalize(sceneparam.eye.xyz - (w * vec4(position, 1)).xyz);
	fsin_mat = idata[gl_InstanceIndex].materialID.x;
	fsin_entityid = idata[gl_InstanceIndex].materialID.w;

	vec3 T = normalize(mat3(w) * vec3(bitangent));
	vec3 B = normalize(mat3(w) * vec3(binormal));
	vec3 N = normalize(mat3(w) * vec3(normal));
	fsin_worldToTangent = mat3(T, B, N);

	if (c_normalWBoneTransform)
	{
		gl_Position = sceneparam.projection * sceneparam.view * w *
			(bones[idata[gl_InstanceIndex].materialID.y + normal.w] * vec4(position, 1));
	}
	else
	{
		gl_Position = sceneparam.projection * sceneparam.view * w * vec4(position, 1);
	}
}