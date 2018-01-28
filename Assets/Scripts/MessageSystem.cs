using System.Collections.Generic;
using UnityEngine;

public class MessageSystem : MonoBehaviour
{
  [System.Serializable]
  public struct Message
  {
    public Color Color;
    public string Content;
  }

  public List<Message> Messages;

  public void AddMessage(Message newMessage) 
  {
    Messages.Add(newMessage);
  }
}