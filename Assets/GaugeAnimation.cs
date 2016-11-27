using DG.Tweening;
using UnityEngine.UI;

public class GaugeAnimation
{
    private Tweener _tweener;
    private Image _gauge;

    public float Amount { get { return _gauge.fillAmount; } }

    public GaugeAnimation(Image gauge)
    {
        _gauge = gauge;
        _gauge.fillAmount = 0;
    }

    public void Progress(float value)
    {
        if (_tweener != null) _tweener.Complete();

        const float duration = 0.6f;

        var now = _gauge.fillAmount;
        var to = now + value;
        _tweener = DOTween.To(
                () => _gauge.fillAmount,
                v => _gauge.fillAmount = v >= 1 ? v - (int) v : v,
                to,
                duration)
            .SetEase(Ease.OutSine);
    }
}
