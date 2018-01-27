using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightingPostProcessEffect : MonoBehaviour
{

	public Material Material;
	public RenderTexture renderTexture;
	public Camera lightingCamera;

	private void Awake()
	{
		if (!renderTexture)
		{
			renderTexture = new RenderTexture(
				Screen.width,
				Screen.height,
				0,
				RenderTextureFormat.RG32,
				RenderTextureReadWrite.Default
			);
			Material.SetTexture("_Lighting", renderTexture);
		}
	}

	private void Start() {
		lightingCamera.enabled = true;
		lightingCamera.targetTexture = renderTexture;
	}

	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
		Graphics.Blit(src, dest, Material);
	}
}