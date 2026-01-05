namespace SmartHomeDashboard2;

public partial class MainPage : ContentPage
{
    private enum SegmentOption { Compact, Smart, Premium }
    private SegmentOption _selectedOption = SegmentOption.Compact;

    public MainPage()
    {
        InitializeComponent();
    }

    private void UpdateSegmentControl(SegmentOption selected)
    {
        _selectedOption = selected;

        // Hide all frames and show all labels
        CompactFrame.IsVisible = false;
        SmartFrame.IsVisible = false;
        PremiumFrame.IsVisible = false;

        CompactLabel.IsVisible = true;
        SmartLabel.IsVisible = true;
        PremiumLabel.IsVisible = true;

        // Set active state - show frame and hide label
        switch (selected)
        {
            case SegmentOption.Compact:
                CompactFrame.IsVisible = true;
                CompactLabel.IsVisible = false;
                break;
            case SegmentOption.Smart:
                SmartFrame.IsVisible = true;
                SmartLabel.IsVisible = false;
                break;
            case SegmentOption.Premium:
                PremiumFrame.IsVisible = true;
                PremiumLabel.IsVisible = false;
                break;
        }
    }

    private void OnSmartTapped(object sender, EventArgs e)
    {
        UpdateSegmentControl(SegmentOption.Smart);
    }

    private void OnPremiumTapped(object sender, EventArgs e)
    {
        UpdateSegmentControl(SegmentOption.Premium);
    }

    private void OnCompactTapped(object sender, EventArgs e)
    {
        UpdateSegmentControl(SegmentOption.Compact);
    }
}
