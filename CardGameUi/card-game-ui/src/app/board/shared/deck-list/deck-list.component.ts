import { Component, OnInit, Input, ChangeDetectionStrategy } from '@angular/core';
import { Deck } from '../../deck/deck.model';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-deck-list',
  templateUrl: './deck-list.component.html'
})
export class DeckListComponent {

  @Input() decks: Array<Deck>;

  constructor(private router: Router, private route: ActivatedRoute) { }

  public preview(id: number) {
    this.router.navigate(['./', 'deck', id], {relativeTo: this.route});
  }
}
