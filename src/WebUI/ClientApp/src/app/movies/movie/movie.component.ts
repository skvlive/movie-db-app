import { Component, Input } from '@angular/core';
import { environment } from 'src/environments/environment';
import { formatDate } from '@angular/common'
import { MovieBannerDto } from '../../movie_db_app-api';

@Component({
  selector: 'app-movie',
  templateUrl: './movie.component.html',
  styleUrls: ['./movie.component.scss'],
})
export class MovieComponent {
  @Input() movieBanner: MovieBannerDto;
  @Input() index: number;

  constructor() { }
}
