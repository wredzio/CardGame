import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Deck } from './deck.model';

@Component({
  selector: 'app-deck',
  templateUrl: './deck.component.html'
})
export class DeckComponent implements OnInit {
  deck: Deck;

  constructor(private route: ActivatedRoute) {}

  ngOnInit() {
    this.route.snapshot.data.subscribe((data) => this.deck = data['deck']);
  }

}
