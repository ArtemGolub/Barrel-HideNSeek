using UnityEngine;

public class FixedJoystick : Joystick
{
    public static FixedJoystick current;
    private void Awake()
    {
        if (current == null)
        {
            current = this;
        }
        else if (current != this)
        {
            Debug.LogError("Only one Joysctick Enable");
            Destroy(gameObject);
        }
    }
}