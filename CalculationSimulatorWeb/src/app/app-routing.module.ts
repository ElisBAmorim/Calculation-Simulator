import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CalculateCdbComponent } from './componentes/calculations/calculate-cdb/calculate-cdb.component';
import { CalculationResultComponent } from './componentes/calculation-result/calculation-result.component';

const routes: Routes = [
  //{
  //  path: '',
  //  redirectTo: 'simular-calulo-cdb',
  //  pathMatch: 'full'
  //},
  {
    path: 'simular-calulo-cdb',
    component: CalculateCdbComponent
  },
  {
    path: 'resultado-calulo-cdb',
    component: CalculationResultComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
