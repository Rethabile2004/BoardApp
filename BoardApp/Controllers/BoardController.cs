// Student nr      : 222052986
// Programmer name : RE Siase
// Assignment nr   : Practical Assessment 1
// Purpose         : Controller class that handles all requests to list, view, add,
//                   change and delete Board objects.

using BoardApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BoardApp.Controllers
{
    public class BoardController : Controller
    {
        public ViewResult Index()
        {
            //
            // Name             : ViewResult Index()
            // Purpose          : Returns the Index view with all the boards in the repository
            // Re-use           : None
            // Method Parameters: None
            // Output Type      : ViewResult
            //                    - the Index view with the collection of boards
            //
            return View(Repository.Boards);
        } // end method Index

        public ViewResult Details(string id)
        {
            //
            // Name             : ViewResult Details(string id)
            // Purpose          : Returns the Details view for the board with the given board code
            // Re-use           : GetByBoardCode()
            // Method Parameters: string id
            //                    - the board code of the board to be displayed
            // Output Type      : ViewResult
            //                    - the Details view with the selected board
            //
            return View(Repository.GetByBoardCode(id));
        } // end method Details

        [HttpGet]
        public ViewResult Create()
        {
            //
            // Name             : ViewResult Create()
            // Purpose          : Returns the empty Create view so that a new board can be captured
            // Re-use           : None
            // Method Parameters: None
            // Output Type      : ViewResult
            //                    - the Create view
            //
            return View();
        } // end method Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ViewResult Create(Board board)
        {
            //
            // Name             : ViewResult Create(Board board)
            // Purpose          : Adds the captured board to the repository when it passes validation
            // Re-use           : AddBoard()
            // Method Parameters: Board board
            //                    - the board captured on the form
            // Output Type      : ViewResult
            //                    - the Create view with the captured board
            //
            if (ModelState.IsValid)
            {
                Repository.AddBoard(board);
                ViewBag.SuccessMessage = $"Board {board.BoardCode} was added.";
            } // end if
            return View(board);
        } // end method Create

        [HttpGet]
        public ViewResult Edit(string id)
        {
            //
            // Name             : ViewResult Edit(string id)
            // Purpose          : Returns the Edit view for the board with the given board code
            // Re-use           : GetByBoardCode()
            // Method Parameters: string id
            //                    - the board code of the board to be changed
            // Output Type      : ViewResult
            //                    - the Edit view with the selected board
            //
            return View(Repository.GetByBoardCode(id));
        } // end method Edit

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ViewResult Edit(Board board)
        {
            //
            // Name             : ViewResult Edit(Board board)
            // Purpose          : Updates the board in the repository when it passes validation
            // Re-use           : UpdateBoard()
            // Method Parameters: Board board
            //                    - the board carrying the changed values
            // Output Type      : ViewResult
            //                    - the Edit view with the changed board
            //
            if (ModelState.IsValid)
            {
                Repository.UpdateBoard(board);
                ViewBag.SuccessMessage = $"Board {board.BoardCode} was updated.";
            } // end if
            return View(board);
        } // end method Edit

        [HttpGet]
        public ViewResult Delete(string id)
        {
            //
            // Name             : ViewResult Delete(string id)
            // Purpose          : Returns the Delete view for the board with the given board code
            // Re-use           : GetByBoardCode()
            // Method Parameters: string id
            //                    - the board code of the board to be deleted
            // Output Type      : ViewResult
            //                    - the Delete view with the selected board
            //
            return View(Repository.GetByBoardCode(id));
        } // end method Delete

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ViewResult Delete(Board board)
        {
            //
            // Name             : ViewResult Delete(Board board)
            // Purpose          : Removes the board from the repository
            // Re-use           : RemoveBoard()
            // Method Parameters: Board board
            //                    - the board carrying the board code of the board to be deleted
            // Output Type      : ViewResult
            //                    - the Delete view with the deleted board
            //
            Repository.RemoveBoard(board.BoardCode);
            ViewBag.SuccessMessage = $"Board {board.BoardCode} was deleted.";
            return View(board);
        } // end method Delete
    } // end class BoardController
} // end namespace BoardApp.Controllers
