using UnityEngine;
using UnityEngine.UI;

namespace CodeBase.UI.Elements
{
    public class HealthBarView : MonoBehaviour
    {
        [SerializeField] private Image _currentHp;

        public void SetValue(float current, float max)
        {
            _currentHp.fillAmount = current / max;
        }
    }
}