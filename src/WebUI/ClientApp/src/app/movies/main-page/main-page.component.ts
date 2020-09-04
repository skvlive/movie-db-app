import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import { MoviesVm, MovieBannerDto, MoviesClient } from '../../movie_db_app-api';

@Component({
  selector: 'app-main-page',
  templateUrl: './main-page.component.html',
  styleUrls: ['./main-page.component.scss'],
})
export class MainPageComponent {
  vm: MoviesVm;
  movieBanners: MovieBannerDto[];

  constructor(private client: MoviesClient) {
    client.getMovies().subscribe(result => {
      this.vm = result;
      if (this.vm.list.totalItems) {
        this.movieBanners = this.vm.list.items;
      }
    }, error => console.error(error));
  }
}
