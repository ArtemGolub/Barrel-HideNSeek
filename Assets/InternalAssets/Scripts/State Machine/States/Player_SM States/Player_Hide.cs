using StateManager;

public class Player_Hide: State
{
    private PlayerComponents _playerComponents;

    private PlayerAnimationControll _playerAnimationControll;
    private BarrelAnimationControll _barrelAnimationControll;
    public Player_Hide(PlayerComponents components)
    {
        _playerComponents = components;
        _barrelAnimationControll = _playerComponents.Barrel.GetComponent<BarrelAnimationControll>();
    }
    public override void Enter()
    {
        if(_playerComponents.AnimationControll==null) return;
        _playerComponents.AnimationControll.MoveAnimation(false);
        _barrelAnimationControll.IsMove(false);
    }
}