import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Board } from './board.model';
import { Deck } from './deck/deck.model';

@Injectable()
export class BoardService {
  private readonly boardUrl = '/api/boards';
  private readonly deckUrl = '/api/decks';

  constructor(private httpClient: HttpClient) { }

  public startNewGame(): Observable<Board> {
    return this.httpClient.post<Board>(this.boardUrl, null);
  }

  public getBoard(): Observable<Board> {
    return this.httpClient.get<Board>(this.boardUrl);
  }

  public addNewDeck(): Observable<Deck> {
    return this.httpClient.post<Deck>(this.deckUrl, null);
  }

  public sort(boardId: number): Observable<Board> {
    return this.httpClient.post<Board>(`${this.boardUrl}/${boardId}/sort`, null);
  }
}
