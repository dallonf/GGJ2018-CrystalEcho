using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "ConversationMessageSequence", menuName = "GGJ2018-CrystalEcho/ConversationMessageSequence", order = 0)]
public class ConversationMessageSequence : MessageSequence
{
  [System.Serializable]
  public struct ConversationMessage
  {
    public CharacterInfo Character;
    public string Message;
    public bool ShouldOverrideColor;
    public Color OverrideColor;
  }

  public ConversationMessage[] Messages;

  public override IEnumerable<MessageSystem.Message> GetMessages()
  {
    return Messages.Select(m => new MessageSystem.Message()
    {
      Color = m.ShouldOverrideColor ? m.OverrideColor : m.Character.Color,
        Content = System.String.Format("<{0}> {1}", m.Character.name, m.Message)
    });
  }
}