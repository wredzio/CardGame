import { Component, OnInit, Input, ChangeDetectionStrategy } from '@angular/core';
import { Deck } from '../../deck/deck.model';

@Component({
  selector: 'app-deck-list',
  templateUrl: './deck-list.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class DeckListComponent {

  @Input() decks: Array<Deck>;

  constructor() { }
}
