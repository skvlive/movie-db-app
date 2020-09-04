import { Component, Input, ViewChild, ViewEncapsulation } from '@angular/core';
import { MatMenu } from '@angular/material/menu';

@Component({
  selector: 'app-filter-menu',
  templateUrl: './filter-menu.component.html',
  styleUrls: ['./filter-menu.component.scss'],
  exportAs: 'filterMenu',
  encapsulation: ViewEncapsulation.None
})

export class FilterMenuComponent {
    @ViewChild(MatMenu, {static: true}) menu: MatMenu;
}
