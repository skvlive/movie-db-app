import { Component, Input } from '@angular/core';
import { MovieDto } from '../../movie_db_app-api';

@Component({
  selector: 'app-movie-details',
  templateUrl: './movie-details.component.html',
  styleUrls: ['./movie-details.component.scss'],
})
export class MovieDetailsComponent{
  @Input() movie: MovieDto;

  constructor() { }
}