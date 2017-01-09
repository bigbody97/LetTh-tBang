using System.Collections.Generic;
using GinoGiantApp.Models;

namespace GinoGiantApp.Services
{
    public interface ISongService
    {
        List<Song> GetAllSongs();
    }
}