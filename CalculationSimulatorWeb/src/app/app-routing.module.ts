import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CalculateCdbComponent } from './componentes/calculations/calculate-cdb/calculate-cdb.component';
import { ResultCdbComponent } from './componentes/calculations/result-cdb/result-cdb.component';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'simular-calculo-cdb',
    pathMatch: 'full'
  },
  {
    path: 'simular-calculo-cdb',
    component: CalculateCdbComponent
  },
  {
    path: 'resultado-cdb/:grossValue/:netValue',
    component: ResultCdbComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
