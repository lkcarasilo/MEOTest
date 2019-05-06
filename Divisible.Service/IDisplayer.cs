namespace Divisible.Service
{
    /// <summary>
    /// Interface representing a displayer
    /// </summary>
    public interface IDisplayer
    {
        /// <summary>
        /// Show a result in the screen
        /// </summary>
        /// <param name="text">Text to show</param>
        void Show(string text);
    }
}
