using kolokwium2b.Models;
using kolokwium2b.Models.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2b.Services
{
    public class DbService : IDbService
    {
        private readonly MainDbContext _dbContext;

        public DbService(MainDbContext mainDbContext)
        {
            _dbContext = mainDbContext;
        }

        public async Task<bool> deleteMusician(int id)
        {
            var musician = await _dbContext.Musicans.Select(e => e).Where(e => e.IdMusician == id).FirstOrDefaultAsync();

            if (musician == null) {
                return false;
            }
            
            var tracks = await _dbContext.Musican_Tracks.Select(e => e).Where(e => e.IdMusician == id).ToListAsync();
            //var tracksInAlbums = _dbContext.Tracks.Join(tracks, t1 => t1.IdTrack, t2 => tracks.Select(e => e.IdTrack), (t1, t2) => new { t1, t2 }).Select(e => e.t1).Where(e => e.t1.IdAlbum == null).ToListAsync();

            return true;

        }

        public async Task<SomeSortOfMusician> getMusician(int id)
        {
            return await _dbContext.Musicans.
                Select(e => e)
                .Where(e => e.IdMusician == id)
                .Select(e => new SomeSortOfMusician {
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    Nickname = e.Nickname,
                    Tracks = e.Musician_Tracks.Select(e => new SomeSortOfTrack { TrackName = e.Track.TrackName, Duration = e.Track.Duration })
                }).OrderBy(e => e.Tracks.Select(e => e.Duration)).FirstOrDefaultAsync();
        }
    }
}
