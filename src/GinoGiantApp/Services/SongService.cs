using GinoGiantApp.Models;
using GinoGiantApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GinoGiantApp.Services
{
    public class SongService: ISongService
    {
        public IGenericRepository _repo;

        public SongService(IGenericRepository repo)
        {
            _repo = repo;
        }

        public List<Song> GetAllSongs()
        {
            var songs = _repo.Query<Song>().ToList();
            return songs;
        }
    }
}
