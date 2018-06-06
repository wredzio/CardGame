import { Component, OnInit } from '@angular/core';
import { BoardService } from './board.service';
import { Board } from './board.model';

@Component({
  selector: 'app-board',
  templateUrl: './board.component.html'
})
export class BoardComponent implements OnInit {
  board: Board;

  constructor(private boardService: BoardService) { }

  ngOnInit(): void {
    this.boardService.getBoard().subscribe(board => {
      if (board) {
        this.board = board;
      } else {
        this.startNewGame();
      }
    },  err => {
      this.startNewGame();
    });
  }

  public addNewDeck() {
    this.boardService.addNewDeck().subscribe(deck => {
      this.board.decks.push(deck);
    });
  }

  public startNewGame() {
    this.boardService.startNewGame().subscribe(board => {
      this.board = board;
    });
  }

  public restart() {
    this.startNewGame();
  }

  public sort() {
    this.boardService.sort(this.board.id).subscribe(board => {
      this.board = board;
    });
  }
}
