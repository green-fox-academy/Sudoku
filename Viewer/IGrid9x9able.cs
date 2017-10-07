using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SudokuModel;

namespace Viewer
{
    interface IGrid9x9able
    {
        void Initialize(int cellSize);

        void DrawGrid();

        void PlaceNumber(IPositionable position, int number);

        void RemoveNumber(IPositionable position);

        void HighlightCell(IPositionable position);


    }
}
