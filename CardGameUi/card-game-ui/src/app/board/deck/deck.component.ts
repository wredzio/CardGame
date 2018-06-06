import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Deck } from './deck.model';
import { DeckService } from './deck.service';

@Component({
  selector: 'app-deck',
  templateUrl: './deck.component.html'
})
export class DeckComponent implements OnInit {
  deck: Deck;

  constructor(private route: ActivatedRoute, private deckService: DeckService) {}

  ngOnInit() {
    this.deck = this.route.snapshot.data['deck'];
  }

  public drawNext() {
    this.deckService.drawNext(this.deck.id).subscribe(deck => this.deck = deck);
  }

  public shuffle() {
    this.deckService.shuffle(this.deck.id).subscribe(deck => this.deck = deck);
  }
}
