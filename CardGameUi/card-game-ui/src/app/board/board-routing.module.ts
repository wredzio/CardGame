import { BoardComponent } from './board.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DeckComponent } from './deck/deck.component';
import { DeckResolver } from './deck/deck.resolver';

const routes: Routes = [
  {
    path: '',
    component: BoardComponent
  },
  {
    path: 'deck/:id',
    component: DeckComponent,
    resolve: { deck: DeckResolver }
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class BoardRoutingModule { }
