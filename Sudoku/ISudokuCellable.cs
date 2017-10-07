using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    /// <summary>
    /// Methods, properties for a cell in the sudoku.
    /// </summary>
    interface ISudokuCellable
    {
        /// <summary>
        /// Represents the number that can be found in the cell.
        /// </summary>
        int Value { get; set; }
    }
}
