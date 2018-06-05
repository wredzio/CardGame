import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { BoardRoutingModule } from './board-routing.module';
import { BoardComponent } from './board.component';
import { BoardService } from './board.service';
import { DeckComponent } from './deck/deck.component';
import { BoardSharedModule } from './shared/board-shared.module';
import { DeckResolver } from './deck/deck.resolver';

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
    DeckResolver
  ]
})
export class BoardModule { }
