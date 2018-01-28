using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class MessageUI : MonoBehaviour
{
  public MessageSystem MessageSystem;
  public GameObject TextPrefab;
  public ScrollRect ScrollRect;
  public RectTransform ContentGroup;

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
        newText.GetComponent<RectTransform>().SetParent(ContentGroup);
        newText.text = newMessage.Content;
        newText.color = newMessage.Color;
        messagesShown += 1;
      }
      yield return null;
    }
  }
}