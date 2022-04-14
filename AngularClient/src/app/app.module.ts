import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { PessoaComponent } from './pessoa/pessoa.component';
import { CidadeComponent } from './cidade/cidade.component';

import { ShowCidadeComponent } from './cidade/show/show.component';
import { EditCidadeComponent } from './cidade/edit/edit.component';

import { ShowPessoaComponent } from './pessoa/show/show.component';
import { EditPessoaComponent } from './pessoa/edit/edit.component';


import { SharedService } from './shared.service';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    AppComponent,
    PessoaComponent,
    CidadeComponent,
    ShowCidadeComponent,
    EditCidadeComponent,
    ShowPessoaComponent,
    EditPessoaComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [SharedService],
  bootstrap: [AppComponent]
})
export class AppModule { }
