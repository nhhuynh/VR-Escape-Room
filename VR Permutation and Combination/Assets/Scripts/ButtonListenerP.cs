using System.Collections;
using System.Collections.Generic;
namespace VRTK.Examples
{
    using UnityEngine;

    public class ButtonListenerP : MonoBehaviour
    {

        public GameObject button;
        public GameObject menu;
		public GameObject SoundEffectManager;

        private void Start()
        {
            
            if (GetComponent<VRTK_ControllerEvents>() == null)
            {
                VRTK_Logger.Error(VRTK_Logger.GetCommonMessage(VRTK_Logger.CommonMessageKeys.REQUIRED_COMPONENT_MISSING_FROM_GAMEOBJECT, "VRTK_ControllerEvents_ListenerExample", "VRTK_ControllerEvents", "the same"));
                return;
            }
            GetComponent<VRTK_ControllerEvents>().ButtonTwoPressed += new ControllerInteractionEventHandler(DoButtonTwoPressed);
            GetComponent<VRTK_ControllerEvents>().TriggerPressed += new ControllerInteractionEventHandler(DoButtonTriggerPressed);
        }

        private void DoButtonTwoPressed(object sender, ControllerInteractionEventArgs e)
        {
            Debug.Log("Pressed");
            button.GetComponent<buttonB>().check();
        }
        private void DoButtonTriggerPressed(object sender, ControllerInteractionEventArgs e)
        {
            Debug.Log("Pressed Start");
            if(menu.activeInHierarchy == false)
            {
				SoundEffectManager.GetComponent<SoundEffectManager> ().playMenuSound ();
                menu.SetActive(true);
            }
            else
            {
                menu.SetActive(false);

            }
            
        }
    }
}

