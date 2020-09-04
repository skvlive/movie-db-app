import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { ActivatedRoute } from '@angular/router';
import { switchMap } from 'rxjs/operators';
import { MovieVm, MovieDto, MoviesClient } from '../../movie_db_app-api';

@Component({
  selector: 'app-details-page',
  templateUrl: './details-page.component.html',
  styleUrls: ['./details-page.component.scss'],
})
export class DetailsPageComponent {
  vm: MovieVm;
  movie: MovieDto;

  constructor(private route: ActivatedRoute, private client: MoviesClient)
  {
    const id = this.route.snapshot.paramMap.get('id');
    client.getMovie(parseInt(id)).subscribe(result => {
      this.vm = result;
      this.movie = this.vm.details;
    }, error => console.error(error));
  }
}
