import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { BoardRoutingModule } from './board-routing.module';
import { BoardComponent } from './board.component';
import { BoardService } from './board.service';
import { DeckComponent } from './deck/deck.component';
import { DeckResolver } from './deck/deck.resolver';
import { DeckService } from './deck/deck.service';
import { BoardSharedModule } from './shared/board-shared.module';

@NgModule({
  imports: [
    CommonModule,
    BoardRoutingModule,
    BoardSharedModule
  ],
  declarations: [
    DeckComponent,
    BoardComponent
  ],
  providers: [
    BoardService,
    DeckService,
    DeckResolver
  ]
})
export class BoardModule { }
