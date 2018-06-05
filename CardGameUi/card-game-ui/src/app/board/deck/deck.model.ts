import { Card } from '../shared/model/card.model';

export interface Deck {
    id: number;
    cards: Array<Card>;
}
