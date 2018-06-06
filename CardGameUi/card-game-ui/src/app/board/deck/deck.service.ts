import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Deck } from './deck.model';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class DeckService {
  private readonly deckUrl = '/api/decks';

  constructor(private httpClient: HttpClient) { }

  public getDeck(id: number): Observable<Deck> {
    return this.httpClient.get<Deck>(`${this.deckUrl}/${id}`);
  }

  public drawNext(id: number): Observable<Deck> {
    return this.httpClient.post<Deck>(`${this.deckUrl}/${id}/draw`, null);
  }

  public shuffle(id: number): Observable<Deck> {
    return this.httpClient.post<Deck>(`${this.deckUrl}/${id}/shuffle`, null);
  }
}
