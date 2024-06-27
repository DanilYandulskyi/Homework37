using TMPro;

public class UITextHealth : HealthUI
{
    private TextMeshProUGUI _text;

    private void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    protected override void UpdateUI()
    {
        _text.text = $"{Health.CurrentValue} / {Health.MaxValue}";
    }
}
