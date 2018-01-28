using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterMessageSequence", menuName = "GGJ2018-CrystalEcho/CharacterMessageSequence", order = 0)]
public class CharacterMessageSequence : MessageSequence
{
  public CharacterInfo Character;
  public string[] Paragraphs;
  public override IEnumerable<MessageSystem.Message> GetMessages()
  {
    return Paragraphs.Select(p => new MessageSystem.Message()
    {
      Color = Character.Color,
        Content = Character.Name + ": " + p
    });
  }
}