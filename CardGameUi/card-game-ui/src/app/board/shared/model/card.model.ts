import { Rank } from './rank.enum';
import { Color } from './color.enum';

export interface Card {
    rank: Rank;
    color: Color;
}
