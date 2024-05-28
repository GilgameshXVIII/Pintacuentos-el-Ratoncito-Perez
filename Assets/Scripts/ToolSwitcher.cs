using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolSwitcher : MonoBehaviour
{
    public enum PaintingTool { Brush, Bucket }
    public PaintingTool currentTool = PaintingTool.Brush;

    public void SetToolToBrush()
    {
        currentTool = PaintingTool.Brush;
    }

    public void SetToolToBucket()
    {
        currentTool = PaintingTool.Bucket;
    }
}
