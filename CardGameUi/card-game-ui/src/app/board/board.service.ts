import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Board } from './board.model';
import { Deck } from './deck/deck.model';

@Injectable()
export class BoardService {

  readonly cardGameUrl = '/api/boards';

  constructor(private httpClient: HttpClient) { }

  public startNewGame(): Observable<Board> {
    return this.httpClient.post<Board>(this.cardGameUrl, null);
  }

  public getDeck(id: number): Observable<Deck> {
    return this.httpClient.get<Deck>(`${this.cardGameUrl}/deck/${id}`);
  }
}
