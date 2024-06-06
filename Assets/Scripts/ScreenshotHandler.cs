using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ScreenshotHandler : MonoBehaviour
{
    public string screenshotFileName = "screenshot.png";
    public RawImage displayImage; // Reference to the UI RawImage to display the screenshot

    public void CaptureAndSaveScreenshot()
    {
        StartCoroutine(CaptureScreenshot());
    }

    private IEnumerator CaptureScreenshot()
    {
        yield return new WaitForEndOfFrame();

        // Construct the path within StreamingAssets
        string path = Path.Combine(Application.streamingAssetsPath, screenshotFileName);

        // Ensure the StreamingAssets folder exists (optional)
        if (!Directory.Exists(Application.streamingAssetsPath))
        {
            Directory.CreateDirectory(Application.streamingAssetsPath);
        }

        ScreenCapture.CaptureScreenshot(path);
        Debug.Log("Screenshot saved to: " + path);

        yield return new WaitForSeconds(1); // Wait a bit to ensure the file is saved
    }
}
