using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuModel
{
    /// <summary>
    /// Methods, properties for a cell in the sudoku.
    /// </summary>
    interface ISudokuCellable
    {
        /// <summary>
        /// Represents the number that can be found in the cell. It must be between 1...9 (a one digit non-zero positive integer, below ten).
        /// </summary>
        int Value { get; set; }
    }
}
