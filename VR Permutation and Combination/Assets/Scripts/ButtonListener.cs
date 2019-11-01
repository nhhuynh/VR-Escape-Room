namespace VRTK.Examples
{
	using UnityEngine;

	public class ButtonListener : MonoBehaviour
	{
		public GameObject button;


		private void Start()
		{
			if (GetComponent<VRTK_ControllerEvents> () == null) {
				VRTK_Logger.Error (VRTK_Logger.GetCommonMessage (VRTK_Logger.CommonMessageKeys.REQUIRED_COMPONENT_MISSING_FROM_GAMEOBJECT, "VRTK_ControllerEvents_ListenerExample", "VRTK_ControllerEvents", "the same"));
				return;
			}
			GetComponent<VRTK_ControllerEvents> ().ButtonOnePressed += new ControllerInteractionEventHandler (DoButtonOnePressed);
		}

		private void DoButtonOnePressed(object sender, ControllerInteractionEventArgs e)
		{
			Debug.Log ("Pressed");
			button.GetComponent<TempButton> ().check ();
		}

	}
}