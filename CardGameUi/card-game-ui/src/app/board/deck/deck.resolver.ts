import { Injectable } from '@angular/core';
import { Resolve, ActivatedRouteSnapshot } from '@angular/router';
import { Observable } from 'rxjs';
import { Deck } from './deck.model';
import { BoardService } from '../board.service';

@Injectable()
export class DeckResolver implements Resolve<Observable<Deck>> {
  constructor(private boardService: BoardService) {}

  resolve(route: ActivatedRouteSnapshot) {
      return this.boardService.getDeck(Number(route.paramMap.get('id')));
  }
}
