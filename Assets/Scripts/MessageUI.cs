using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class MessageUI : MonoBehaviour
{
  public MessageSystem MessageSystem;
  public GameObject TextPrefab;
  public ScrollRect ScrollRect;
  public RectTransform ContentGroup;
  public float CharTime = 0.1f;
  public float MessageTime = 1;

  private int messagesShown = 0;

  void Start()
  {
    StartCoroutine(ManageMessageUI());
  }

  IEnumerator ManageMessageUI()
  {
    while (true)
    {
      if (messagesShown < MessageSystem.Messages.Count)
      {
        var newMessage = MessageSystem.Messages[messagesShown];
        var newText = GameObject.Instantiate(TextPrefab).GetComponent<Text>();
        var newTransform = newText.GetComponent<RectTransform>();
        newTransform.SetParent(ContentGroup, false);
        newText.color = newMessage.Color;

        for (int i = 1; i < newMessage.Content.Length + 1; i++)
        {
          newText.text = newMessage.Content.Substring(0, i);
          yield return null;
          // Scroll to bottom
          ScrollRect.StopMovement();
          ScrollRect.verticalNormalizedPosition = 0;
        }
        messagesShown += 1;
        yield return new WaitForSeconds(MessageTime);
      }
      yield return null;
    }
  }
}