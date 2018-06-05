import { Component, OnInit } from '@angular/core';
import { BoardService } from './board.service';

@Component({
  selector: 'app-board',
  templateUrl: './board.component.html'
})
export class BoardComponent {
  board$ = this.boardService.startNewGame();

  constructor(private boardService: BoardService) { }

}
