import { Component, OnInit, Output, EventEmitter, Input } from '@angular/core';

@Component({
  selector: 'app-country-picker',
  templateUrl: './country-picker.component.html',
  styleUrls: ['./country-picker.component.css']
})
export class CountryPickerComponent implements OnInit {
  @Output() onCountryChanged = new EventEmitter<string>();
  @Input() countryList: Array<string>;

  selected: string = "Poland";

  constructor() {}

  ngOnInit(): void {}

  countryHasChanged($event) {
    this.onCountryChanged.emit(this.selected);
  }
}
