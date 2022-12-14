using UnityEngine;

namespace CodeBase.Hero
{
    [RequireComponent(typeof(HeroHealth), typeof(HeroMove), typeof(HeroAnimator))]
    public class HeroDeath : MonoBehaviour
    {
        [Header("Components")]
        [SerializeField] private HeroHealth _health;

        [SerializeField] private HeroMove _move;
        [SerializeField] private HeroAttack _attack;
        [SerializeField] private HeroAnimator _animator;

        [Header("VFX")] 
        [SerializeField] private GameObject _deathFxPrefab;

        private void Start()
        {
            _health.HealthChanged += OnHealthChanged;
        }

        private void OnDestroy()
        {
            _health.HealthChanged -= OnHealthChanged;
        }

        private void OnHealthChanged()
        {
            if (_health.Current > 0)
                return;

            Die();
        }

        private void Die()
        {
            _health.enabled = false;
            _move.enabled = false;
            _attack.enabled = false;
            _animator.PlayDeath();
            PlayDeathFx();
        }

        private void PlayDeathFx() => 
            Instantiate(_deathFxPrefab, transform.position, Quaternion.identity);
    }
}