using System.Collections.Generic;
using UnityEngine;

public abstract class MessageSequence : ScriptableObject
{

  public abstract IEnumerable<MessageSystem.Message> GetMessages();

}