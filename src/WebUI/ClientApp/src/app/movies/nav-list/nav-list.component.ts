import { Component } from '@angular/core';

export interface Country {
  code: string;
  name: string;
}

@Component({
  selector: 'app-nav-list',
  templateUrl: './nav-list.component.html',
  styleUrls: ['./nav-list.component.scss']
})

export class NavListComponent {
  categories: string[] = ["Entertainment", "General"];
  countries: Country[] = [{ code: "au", name: "Australia" }, { code: "in", name: "India" },
  { code: "us", name: "USA" }, { code: "gb", name: "UK" }];
}
