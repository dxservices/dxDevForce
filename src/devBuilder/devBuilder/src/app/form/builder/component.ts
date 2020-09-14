import {Component, OnInit} from '@angular/core';

@Component({
  selector: 'app-form-builder',
  templateUrl: 'component.html'
})

export class FormBuilderComponent implements OnInit {
  form: any = {}
  constructor() {
  }

  ngOnInit() {
  }
}
