using UnityEngine;

namespace PlatformerMVC
{
  public class Main : MonoBehaviour
  {
      [SerializeField] private SpriteAnimatorController _playerAnimator;
      [SerializeField] private LevelObjectView _playerView;
      [SerializeField] private AnimationCfg _playerConfig;
      [SerializeField] private int _animationSpeed = 10;
      
      void Awake()
      {
          _playerConfig = Resources.Load<AnimationCfg>("PlayerAnimCtg");
          _playerAnimator = new SpriteAnimatorController(_playerConfig);
          _playerAnimator.StartAnimation(_playerView._spriteRenderer, AnimState.Run, true, _animationSpeed);
      }
      
      void Update()
      {
          _playerAnimator.Update();
      }
  }  
}

