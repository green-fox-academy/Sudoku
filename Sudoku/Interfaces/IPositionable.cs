namespace SudokuModel
{
    /// <summary>
    /// Interface for holding the position with X and Y coordinates.
    /// </summary>
    public interface IPositionable
    {
        /// <summary>
        /// The X coordinate of the position.
        /// </summary>
        int X { get; set; }

        /// <summary>
        /// The X coordinate of the position.
        /// </summary>
        int Y { get; set; }
    }
}