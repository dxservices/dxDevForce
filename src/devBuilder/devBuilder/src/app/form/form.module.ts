import {NgModule} from '@angular/core';
import {FormioModule} from "angular-formio";

import {FormBuilderComponent} from "./builder/component";


@NgModule({
  imports: [FormioModule],
  exports: [],
  declarations: [FormBuilderComponent],
  providers: [],
})
export class AppFormModule {
}
