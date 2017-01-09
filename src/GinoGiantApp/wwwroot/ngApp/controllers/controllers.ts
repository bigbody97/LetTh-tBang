namespace GinoGiantApp.Controllers {

    export class HomeController {
        public message = 'Hello from the home page!';
    }

    export class SongController {
        public songs;

        constructor(public SongService:GinoGiantApp.Services.SongService, public $http: ng.IHttpService) {
            this.getAll();
        }
        public getAll() {
            this.SongService.getAllSongs().then((resp) => {
                this.songs = resp.data;
            })
        }
    }






    export class SecretController {
        public secrets;

        constructor($http: ng.IHttpService) {
            $http.get('/api/secrets').then((results) => {
                this.secrets = results.data;
            });
        }
    }


    export class AboutController {
        public message = 'Hello from the about page!';
    }

}
