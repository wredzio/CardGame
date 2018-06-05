import { Deck } from './deck/deck.model';

export interface Board {
    id: number;
    name: string;
    decks: Array<Deck>;
}
