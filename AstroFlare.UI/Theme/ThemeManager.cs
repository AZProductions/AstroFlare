namespace AstroFlare.UI.Theme
{
    using AstroFlare.UI;
    using System.Drawing;
    public class ThemeManager
    {

        private static ThemeKind currentTheme;
        public static ThemeManager? Instance { get; private set; }
        public static ThemeKind CurrentTheme { get => currentTheme; set => currentTheme = value; }

        public ThemeManager(ThemeKind kind)
        {
            currentTheme = kind;
            Instance = this;
        }

        // Reloads the current theme.
        // public void LoadTheme(ThemeKind kind)
        // {
        //     CurrentTheme = new Theme(kind);
        // }

        public Color GetResource(Colors.ColorKind kind)
        {
            switch(kind)
            {
                case Colors.ColorKind.BackgroundColor:
                    if(currentTheme == ThemeKind.Dark)
                    {
                        return ThemeBrushConverter.HexStringToColor(Colors.Dark.BackgroundColor);
                    }
                    else if (currentTheme == ThemeKind.Violet)
                    {
                        return ThemeBrushConverter.HexStringToColor(Colors.Violet.BackgroundColor);
                    }
                    else
                    {
                        return ThemeBrushConverter.HexStringToColor(Colors.Light.BackgroundColor);
                    }
                default:
                    return Color.White; // The default color.
            }
        }

        internal void GetKind()
        {
            // switch (currentKind)
            // {
            //     case ThemeKind.Dark:
            //         return Colors.ColorsDark.GetColor(kind);
            //     case ThemeKind.Light:
            //         return Colors.ColorsLight.GetColor(kind);
            //     default:
            //         return Colors.ColorsLight.GetColor(kind);
            // }
        }
    }
}