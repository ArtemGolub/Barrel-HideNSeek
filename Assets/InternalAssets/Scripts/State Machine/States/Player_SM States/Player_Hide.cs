using StateManager;

public class Player_Hide: State
{
    private PlayerComponents _playerComponents;
    private PlayerAnimationControll _animationControll;
    public Player_Hide(PlayerComponents components)
    {
        _playerComponents = components;
        _animationControll = _playerComponents.AnimationControll;
    }
    public override void Enter()
    {
        _animationControll.MoveAnimation(false);
    }
}