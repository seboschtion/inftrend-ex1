using GoogleARCore;
using GoogleARCore.Examples.HelloAR;
using UnityEngine;

public class InstantiateObjectOnTouch : MonoBehaviour {
	/// <summary>
	/// The first-person camera being used to render the passthrough camera.
	/// </summary>
	public Camera FirstPersonCamera;

	/// <summary>
	/// The gameobject to place when tapping the screen.
	/// </summary>
	public GameObject objectToPlace;

	//private const float k_ModelRotation = 180.0f;

	private bool placed = false;

	// Update is called once per frame
	void Update () {
		// If the player has not touched the screen, we are done with this update.
		Touch touch;
		if (Input.touchCount < 1 || (touch = Input.GetTouch (0)).phase != TouchPhase.Began || placed == true) {
			return;
		}

		// Raycast against the location the player touched to search for planes.
		TrackableHit hit;
		TrackableHitFlags raycastFilter = TrackableHitFlags.PlaneWithinPolygon |
			TrackableHitFlags.FeaturePointWithSurfaceNormal;

		if (Frame.Raycast (touch.position.x, touch.position.y, raycastFilter, out hit)) {
			// Use hit pose and camera pose to check if hittest is from the
			// back of the plane, if it is, no need to create the anchor.
			if ((hit.Trackable is DetectedPlane) &&
				Vector3.Dot (FirstPersonCamera.transform.position - hit.Pose.position,
					hit.Pose.rotation * Vector3.up) < 0) {
				Debug.Log ("Hit at back of the current DetectedPlane");
			} else {

				// Compensate for the hitPose rotation facing away from the raycast (i.e. camera).
				//objectToPlace.transform.Rotate (0, k_ModelRotation, 0, Space.Self);

				// Create an anchor to allow ARCore to track the hitpoint as understanding of the physical
				// world evolves.
				var anchor = hit.Trackable.CreateAnchor (hit.Pose);

				// Make model a child of the anchor.
				objectToPlace.transform.parent = anchor.transform;
				objectToPlace.SetActive(true);
				placed = true;
			}
		}
	}
}