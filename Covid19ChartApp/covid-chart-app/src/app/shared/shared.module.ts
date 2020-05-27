import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CountryPickerComponent } from './component/country-picker/country-picker.component';
import { MatSelectModule } from '@angular/material/select';



@NgModule({
  declarations: [CountryPickerComponent],
  imports: [
    CommonModule,
    MatSelectModule
  ],
  exports: [CountryPickerComponent]
})
export class SharedModule { }
