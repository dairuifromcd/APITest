using APITest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace APITest.Verifiers
{
    public class FestivalsVerifier
    {
        private const int Festivals_Max = 100;

        private const int Bands_Max = 100;

        public void Verify(Festival[] festivals)
        {
            Assert.NotNull(festivals);
            // Max check optional
            Assert.True(festivals.Length > 0 && festivals.Length <= Festivals_Max);

            // optional
            CheckDuplicateFestivals(festivals);

            festivals.ToList().ForEach(festival => FestivalVerifier(festival));
        }

        private void CheckDuplicateFestivals(Festival[] festivals)
        {
            var uniqueFestivalCount = festivals.GroupBy(festival => festival.Name).ToList().Count;

            Assert.Equal(uniqueFestivalCount, festivals.Length);
        }

        private void FestivalVerifier(Festival festival)
        {
            Assert.True(!string.IsNullOrEmpty(festival.Name));

            Assert.NotNull(festival.Bands);
            // Max check optional
            Assert.True(festival.Bands.Length > 0 && festival.Bands.Length <= Bands_Max);

            // optional
            CheckDuplicateBands(festival.Bands);

            festival.Bands.ToList().ForEach(band => BandVerifier(band));
        }

        private void CheckDuplicateBands(Band[] bands)
        {
            var uniqueBandCount = bands.GroupBy(band => band.Name).ToList().Count;

            Assert.Equal(uniqueBandCount, bands.Length);
        }

        private void BandVerifier(Band band)
        {
            Assert.True(!string.IsNullOrEmpty(band.Name));
            Assert.True(!string.IsNullOrEmpty(band.RecordLabel));
        }
    }
}
