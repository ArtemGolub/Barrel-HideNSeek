# Barrel-HideNSeek
## Overview
    This is a project for demonstation of Programming skills. The posibility to write extendable code that provides possibility to design and extend game mechanics.
    Also demonstate possibility to understand and implement Design Patterns such as 
        - StateMachine
        - Singleton
        - Strategy
        - Fabric.

### Player
    Player components - this is script was made to simplify access to nesesary Player components.
    PlayerAnimationControll - controlls player animations and animation events
    Player_SM -  this is a StateMachine that controlls Player states.
        The states included is: 
        - Hide - is state where Player cant be detected by Enemies
        - Move - is state where Player movement is controlled
        - Gotcha - is state where Player was caught by Enemy



### Barrel
    Barrel Controller - controller for Barrel include logic for Equip and Removal of Barrel
    PlayerAnimationControll - controlls Barrel animations and animation events

### Enemy
    Enemy components - this is script was made to simplify access to nesesary enemy components.
    Enemy animation controll - controlls Enemy animations and animation events
    Enemy_SM - this is a StateMachine that controlls Enemy states.
        Included states:
            - Patrol - This State reference Enemy type of patrooling and createing PatrolBehaviour by using EnemyType.
                For now implemented 2 types of patrooling:
                    1) Stationary - patrols that dont move such a Snipers etc.
                    2) Patrol - patrols that moves using NavMesh and list of Points
            - Catch - State for Enemy that catch Player

### Weapon
    Weapon - this scripts release Weapon behaviour
    Weapon Behaviour - its a Behaviour of detecting Player and shooting.
        There is 2 types of Player detection:
            1) Pistol - Search a Player in a cone zone might be from 0 to 360 degree. Include obstacles but not the Height of target
            2) Sniper - Search a Player in a range zone. Dont include obstacles but includes height of target

### Popups
    PopupController - is a realisation of MVC pattern that include View for enabling popups and Model for implement additional logic such as scale or else.

### EventManager
    Simple realisation for Win or Lose conditions