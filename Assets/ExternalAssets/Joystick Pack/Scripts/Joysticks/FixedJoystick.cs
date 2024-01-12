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
            Destroy(gameObject);
        }
    }
}