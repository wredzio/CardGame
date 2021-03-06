import { Injectable } from '@angular/core';
import { Resolve, ActivatedRouteSnapshot } from '@angular/router';
import { Observable } from 'rxjs';
import { Deck } from './deck.model';
import { BoardService } from '../board.service';
import { DeckService } from './deck.service';

@Injectable()
export class DeckResolver implements Resolve<Observable<Deck>> {
  constructor(private deckService: DeckService) {}

  resolve(route: ActivatedRouteSnapshot) {
      return this.deckService.getDeck(Number(route.paramMap.get('id')));
  }
}
