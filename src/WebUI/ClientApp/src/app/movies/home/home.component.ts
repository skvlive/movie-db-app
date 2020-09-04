import { Component } from '@angular/core';
import { MoviesVm, DiscoverMoviesClient, MovieBannerDto } from '../movie_db_app-api';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  vm: MoviesVm;
  movieBanners$: MovieBannerDto[];

  constructor(private client: DiscoverMoviesClient) {
    client.get().subscribe(result => {
      this.vm = result;
      if (this.vm.list.totalItems) {
        this.movieBanners$ = this.vm.list.items;
      }
    }, error => console.error(error));
  }
}
