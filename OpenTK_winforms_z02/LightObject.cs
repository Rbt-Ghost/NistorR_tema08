using System;

using System.Drawing;
using System.IO;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;

public class LightObject
{
    private LightName lightName;
    private float[] position;
    private float[] ambient;
    private float[] diffuse;
    private float[] specular;
    public bool IsActive { get; set; }

    public LightObject(LightName name, float[] pos)
    {
        lightName = name;
        position = pos;
        // Valori implicite (galben pentru a se distinge de sursa 0)
        ambient = new float[] { 0.1f, 0.1f, 0.0f, 1.0f };
        diffuse = new float[] { 1.0f, 1.0f, 0.0f, 1.0f };
        specular = new float[] { 1.0f, 1.0f, 1.0f, 1.0f };
        IsActive = false;
    }

    public void Toggle()
    {
        IsActive = !IsActive;
    }

    public void Move(float x, float y, float z)
    {
        position[0] += x;
        position[1] += y;
        position[2] += z;
    }

    public void SetPosition(float x, float y)
    {
        // Setare absolută pentru mouse (mapare pe planul ecranului)
        position[0] = x;
        position[1] = y;
    }

    public void ApplyLight()
    {
        if (IsActive)
        {
            GL.Enable((EnableCap)lightName);
            GL.Light(lightName, LightParameter.Ambient, ambient);
            GL.Light(lightName, LightParameter.Diffuse, diffuse);
            GL.Light(lightName, LightParameter.Specular, specular);
            GL.Light(lightName, LightParameter.Position, position);
        }
        else
        {
            GL.Disable((EnableCap)lightName);
        }
    }
}