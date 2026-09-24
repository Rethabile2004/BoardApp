// Student nr      : 222052986  
// Programmer name : RE Siase
// Assignment nr   : Practical Assessment 1
// Purpose         : In-memory storage class for Board objects. Provides the add, find,
//                   update and remove operations used by the controllers.

namespace BoardApp.Models
{
    public static class Repository
    {
        private static List<Board> boards = new List<Board>();

        public static IEnumerable<Board> Boards
        {
            //
            // Name             : property IEnumerable<Board> Boards
            // Purpose          : Read-only property giving access to the boards in the repository
            // Re-use           : None
            // Input Parameter  : IEnumerable<Board> value
            //                    - read-only property; no value is assigned
            // Output Type      : IEnumerable<Board>
            //                    - the boards currently held in the repository
            //
            get { return boards; } // end get
        } // end property Boards

        public static void AddBoard(Board board)
        {
            //
            // Name             : void AddBoard(Board board)
            // Purpose          : Adds a new board to the repository
            // Re-use           : None
            // Method Parameters: Board board
            //                    - the board to be added to the repository
            // Output Type      : None
            //
            boards.Add(board);
        } // end method AddBoard

        public static Board? GetByBoardCode(string boardCode)
        {
            //
            // Name             : Board? GetByBoardCode(string boardCode)
            // Purpose          : Finds the board that matches the given board code
            // Re-use           : None
            // Method Parameters: string boardCode
            //                    - the board code to search for
            // Output Type      : Board?
            //                    - the matching board, or null when no board has that board code
            //
            return boards.FirstOrDefault(b => b.BoardCode == boardCode);
        } // end method GetByBoardCode

        public static void RemoveBoard(string boardCode)
        {
            //
            // Name             : void RemoveBoard(string boardCode)
            // Purpose          : Removes the board that matches the given board code
            // Re-use           : GetByBoardCode()
            // Method Parameters: string boardCode
            //                    - the board code of the board to be removed
            // Output Type      : None
            //
            Board? board = GetByBoardCode(boardCode);
            if (board != null)
            {
                boards.Remove(board);
            } // end if
        } // end method RemoveBoard

        public static void UpdateBoard(Board updatedBoard)
        {
            //
            // Name             : void UpdateBoard(Board updatedBoard)
            // Purpose          : Updates the make, model, flash size and price of an existing board
            // Re-use           : GetByBoardCode()
            // Method Parameters: Board updatedBoard
            //                    - a board carrying the updated values
            // Output Type      : None
            //
            Board? existingBoard = GetByBoardCode(updatedBoard.BoardCode);
            if (existingBoard != null)
            {
                existingBoard.Make = updatedBoard.Make;
                existingBoard.Model = updatedBoard.Model;
                existingBoard.FlashKb = updatedBoard.FlashKb;
                existingBoard.Price = updatedBoard.Price;
            } // end if
        } // end method UpdateBoard

        static Repository()
        {
            //
            // Name             : Repository()
            // Purpose          : Static constructor that seeds the repository with the initial ten boards
            // Re-use           : None
            // Method Parameters: None
            // Output Type      : None
            //
            boards = new List<Board>()
            {
                new Board("1001", "Espressif", "ESP32-WROOM-32", 4096, 129.00m),
                new Board("1002", "Espressif", "ESP32-C3-MINI-1", 4096, 99.00m),
                new Board("1003", "STMicroelectronics", "STM32F103C8T6", 64, 75.00m),
                new Board("1004", "STMicroelectronics", "STM32F411CEU6", 512, 145.00m),
                new Board("1005", "Microchip", "ATmega328P", 32, 89.00m),
                new Board("1006", "Microchip", "ATmega2560", 256, 199.00m),
                new Board("1007", "WCH", "CH32V003F4P6", 16, 29.00m),
                new Board("1008", "Raspberry Pi", "Pico", 2048, 89.00m),
                new Board("1009", "Espressif", "ESP-01S", 1024, 65.00m),
                new Board("1010", "CUTfree", "CV32-BFN-01", 128, 49.00m)
            };
        } // end method Repository
    } // end class Repository
} // end namespace BoardApp.Models
