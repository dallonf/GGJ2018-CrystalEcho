using System.Collections;
using UnityEngine;

public class TestSendingMessages : MonoBehaviour
{
  public MessageSystem MessageSystem;
  public Color[] Colors;
  public string[] Senders;
  public string[] Messages;

  public float Delay = 1;

  private void Start()
  {
    StartCoroutine(SendMessages());
  }

  private IEnumerator SendMessages()
  {
    while (true)
    {
      var color = Colors[Random.Range(0, Colors.Length)];
      var sender = Senders[Random.Range(0, Senders.Length)];
      var messageText = Messages[Random.Range(0, Messages.Length)];
      var message = new MessageSystem.Message()
      {
        Color = color,
        Content = sender + ": " + messageText,
      };
      MessageSystem.AddMessage(message);
      yield return new WaitForSeconds(Delay);
    }
  }
}