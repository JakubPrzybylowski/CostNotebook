import { Injectable } from '@angular/core';
import { of } from 'rxjs';

export class ExpInlfuDataService {

  constructor() { }

  getExpInfluData() {
    return of({
      "January ": {
        "volumeExpenses": "2453",
        "valueInfluence": "5500"
      },
      "February ": {
        "volumeSales": "3456",
        "valueSales": "5500"
      },
      "March ": {
        "volumeExpenses": "1245",
        "valueInfluence": "5500"
      },
      "April ": {
        "volumeExpenses": "3587",
        "valueInfluence": "5500"
      },
      "May ": {
        "volumeExpenses": "3124",
        "valueInfluence": "5500"
      },
      "June ": {
        "volumeExpenses": "2148",
        "valueInfluence": "5500"
      },
      "July ": {
        "volumeExpenses": "892",
        "valueInfluence": "6500"
      },
      "August ": {
        "volumeExpenses": "2691",
        "valueInfluence": "5500"
      },
      "September ": {
        "volumeExpenses": "1278",
        "valueInfluence": "5500"
      },
      "October ": {
        "volumeExpenses": "2461",
        "valueInfluence": "5500"
      },
      "November ": {
        "volumeExpenses": "1374",
        "valueInfluence": "5500"
      },
      "December ": {
        "volumeExpenses": "3475",
        "valueInfluence": "8500"
      }
    });
  }

}
