using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscoveredObjectMessageSender : MonoBehaviour
{
	public MessageSystem MessageSystem;

	public void SendMessageForDiscoveredObject(KnowableObject obj)
	{
		MessageSystem.AddMessage(new MessageSystem.Message()
		{
			Color = Color.white,
				Content = "You have discovered " + obj.name + "!"
		});
	}
}