import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Board } from './board.model';
import { Deck } from './deck/deck.model';

@Injectable()
export class BoardService {

  readonly boardUrl = '/api/boards';
  readonly deckUrl = '/api/decks';

  constructor(private httpClient: HttpClient) { }

  public startNewGame(): Observable<Board> {
    return this.httpClient.post<Board>(this.boardUrl, null);
  }

  public getDeck(id: number): Observable<Deck> {
    return this.httpClient.get<Deck>(`${this.boardUrl}/deck/${id}`);
  }

  public addNewDeck(): Observable<Deck> {
    return this.httpClient.post<Deck>(this.deckUrl, null);
  }
}
