public class ThemeService
{
    public bool IsDarkMode { get; private set; } = false;

    // Este evento avisará a los componentes que el tema cambió
    public event Action? OnThemeChanged;

    public void ToggleTheme()
    {
        IsDarkMode = !IsDarkMode;
        OnThemeChanged?.Invoke();
    }
    public string GetThemeClass() => IsDarkMode ? "theme-dark" : "theme-light";
}