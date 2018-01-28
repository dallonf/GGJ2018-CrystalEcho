using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "TutorialMessageSequence", menuName = "GGJ2018-CrystalEcho/TutorialMessageSequence", order = 0)]
public class TutorialMessageSequence : MessageSequence
{
  public string[] Paragraphs;
  public override IEnumerable<MessageSystem.Message> GetMessages()
  {
    return Paragraphs.Select(p => new MessageSystem.Message()
    {
      Color = Color.white,
        Content = p,
    });
  }
}