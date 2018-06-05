import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DeckListComponent } from './deck-list/deck-list.component';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [
    DeckListComponent
  ],
  exports: [
    DeckListComponent
  ]
})
export class BoardSharedModule { }
