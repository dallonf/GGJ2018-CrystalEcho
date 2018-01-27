using UnityEngine;

[CreateAssetMenu(fileName = "LightPopConfig", menuName = "GGJ2018-CrystalEcho/LightPopConfig", order = 0)]
public class LightPopConfig : ScriptableObject
{
  public float Radius;
  public float DecayTime;
  public AnimationCurve DecayCurve;
}