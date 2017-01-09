namespace GinoGiantApp.Services {
    export class SongService {
        public res = "/api/songs";
        constructor(private $http: ng.IHttpService) {

        }
        public getAllSongs() {
            return this.$http.get(this.res);
        }
    }
    angular.module("GinoGiantApp").service("SongService", SongService);
}
    
