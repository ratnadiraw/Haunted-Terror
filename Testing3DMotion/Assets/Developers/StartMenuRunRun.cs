using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Loads Sample Scenes
public class StartMenuRunRun : MonoBehaviour
{   
    public OVROverlay overlay;
    public OVROverlay text;
    public OVRCameraRig vrRig;

    void Start()
    {
        DebugUIBuilder.instance.AddLabel("Do you wanna go?");
        DebugUIBuilder.instance.AddButton("Yes", LoadGame);
        DebugUIBuilder.instance.AddButton("No", LoadGame);
        DebugUIBuilder.instance.AddButton("Leaderboard first", LoadLeader);
        DebugUIBuilder.instance.AddButton("Change cube first", LoadCube);
        //DebugUIBuilder.instance.AddButton("Distance Grab", LoadDistanceGrab);
        //DebugUIBuilder.instance.AddButton("Guardian Boundary System", LoadGuardianBoundarySystem);
        //DebugUIBuilder.instance.AddButton("Locomotion", LoadLocomotion);
        //DebugUIBuilder.instance.AddButton("Mixed Reality Capture", LoadMixedRealityCapture);
        //DebugUIBuilder.instance.AddButton("OVR Overlay", LoadOVROverlay);
        DebugUIBuilder.instance.Show();
    }

    // Can't guarantee build order won't change, so use strings for loading
    void LoadScene(string sceneName)
    {
        DebugUIBuilder.instance.Hide();
        StartCoroutine(ShowOverlayAndLoad(sceneName));
    }

    IEnumerator ShowOverlayAndLoad(string sceneName)
    {
        text.transform.position = vrRig.centerEyeAnchor.position + Vector3.ProjectOnPlane(vrRig.centerEyeAnchor.forward, Vector3.up).normalized * 3f;
        overlay.enabled = true;
        text.enabled = true;
        // Waiting to prevent "pop" to new scene
        yield return new WaitForSeconds(1f);
        // Load Scene and wait til complete
        AsyncOperation asyncLoad = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName);
        while(!asyncLoad.isDone)
        {
            yield return null;
        }
        yield return null;
    }

    #region Scene Load Callbacks
    void LoadAvatarGrab()
    {
        LoadScene("AvatarGrab");
    }
    void LoadCustomControllers()
    {
        LoadScene("CustomControllers");
    }
    void LoadCustomHands()
    {
        LoadScene("CustomHands");
    }
    void LoadDebugUI()
    {
        LoadScene("DebugUI");
    }
    void LoadDistanceGrab()
    {
        LoadScene("DistanceGrab");
    }
    void LoadGame()
    {
        LoadScene("DistanceGrab-Development");
    }
    void LoadLeader()
    {
        LoadScene("Leaderboard");
    }
    void LoadCube()
    {
        LoadScene("SkinCube");
    }
    void LoadGuardianBoundarySystem()
    {
        LoadScene("GuardianBoundarySystem");
    }
    void LoadLocomotion()
    {
        LoadScene("Locomotion");
    }
    void LoadMixedRealityCapture()
    {
        LoadScene("MixedRealityCapture");
    }
    void LoadOVROverlay()
    {
        LoadScene("OVROverlay");
    }
    #endregion
}
