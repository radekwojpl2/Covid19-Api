import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CountriesAggregatedChartComponent } from './countries-aggregated-chart.component';

describe('CountriesAggregatedChartComponent', () => {
  let component: CountriesAggregatedChartComponent;
  let fixture: ComponentFixture<CountriesAggregatedChartComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CountriesAggregatedChartComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CountriesAggregatedChartComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
