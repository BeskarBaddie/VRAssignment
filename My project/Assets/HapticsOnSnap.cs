using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SnapHapticFeedback : MonoBehaviour
{
    private XRSocketInteractor socketInteractor;

    private void Start()
    {
        socketInteractor = GetComponent<XRSocketInteractor>();

        // Subscribe to the OnSelectEntered event to trigger haptic feedback.
        socketInteractor.selectEntered.AddListener(OnSelectEntered);
    }

    private void OnSelectEntered(SelectEnterEventArgs args)
    {
        // You can customize the haptic feedback pattern here.
        // For example, vibrate the controller for a short duration.
        args.interactor.GetComponent<XRBaseController>().SendHapticImpulse(0.5f, 0.1f);

        // You can adjust the intensity and duration values as needed.
    }
}
