import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CabecalhoComponent } from './componentes/cabecalho/cabecalho.component';
import { RodapeComponent } from './componentes/rodape/rodape.component';
import { CalculateCdbComponent } from './componentes/calculations/calculate-cdb/calculate-cdb.component';
import { CalculationResultComponent } from './componentes/calculation-result/calculation-result.component';
import { ResultCdbComponent } from './componentes/calculations/result-cdb/result-cdb.component';

@NgModule({
  declarations: [
    AppComponent,
    CabecalhoComponent,
    RodapeComponent,
    CalculateCdbComponent,
    CalculationResultComponent,
    ResultCdbComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
