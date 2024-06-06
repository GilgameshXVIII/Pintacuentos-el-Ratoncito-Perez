using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class GalleryManager : MonoBehaviour
{
    public string screenshotFileName = "screenshot.png";
    public RawImage displayImage; // Reference to the UI RawImage to display the screenshot

    void Start()
    {
        // Construct the path within StreamingAssets
        string path = Path.Combine(Application.streamingAssetsPath, screenshotFileName);

        // Load and display the screenshot if it exists
        if (File.Exists(path))
        {
            StartCoroutine(LoadAndDisplayScreenshot(path));
        }
        else
        {
            Debug.LogWarning("Screenshot not found at path: " + path);
        }
    }

    private IEnumerator LoadAndDisplayScreenshot(string path)
    {
        // Load the image file
        byte[] imageBytes = File.ReadAllBytes(path);
        Texture2D texture = new Texture2D(2, 2);
        texture.LoadImage(imageBytes);

        // Assign the texture to the RawImage
        displayImage.texture = texture;
        displayImage.SetNativeSize(); // Optional: Adjust the size of the RawImage to match the screenshot

        yield return null;
    }
}
