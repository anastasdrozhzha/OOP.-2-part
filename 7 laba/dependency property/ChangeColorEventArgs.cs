using System.Windows;

namespace dependency_property
{
    public class ChangeColorEventArgs : RoutedEventArgs
    {
        private readonly System.Windows.Media.Color _color;

        public System.Windows.Media.Color Color
        {
            get { return _color; }
        }

        public ChangeColorEventArgs(RoutedEvent routedEvent, System.Windows.Media.Color color) : base(routedEvent)
        {
            this._color = color;
        }
    }
}
