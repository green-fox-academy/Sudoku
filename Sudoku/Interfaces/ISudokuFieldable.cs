using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuModel
{
    /// <summary>
    /// Methods for the cells and groups of cells in the sudoku.
    /// </summary>
    interface ISudokuFieldable : ICollection<ISudokuCellable>
    {
        /// <summary>
        /// Returns true if cell(s) contain(s) the given number.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        bool Contains(int number);

        /// <summary>
        /// Returns an IEnumerable<int> of the available numbers.
        /// </summary>
        /// <returns></returns>
        IEnumerable<int> AvailableNumbers();

        /// <summary>
        /// Returns true if given number can be placed in the cell(s).
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        bool NumberIsPlaceable(int number);
    }
}
