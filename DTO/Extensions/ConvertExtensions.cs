using DTO.Entities;
using DTO.Models;

namespace DTO.Extensions
{
    public static class ConvertExtensions
    {
        public static UserModelResponse ToUserModelResponse(this UserEntity user) =>
            new UserModelResponse()
            {
                Id = user.Id,
                Login = user.Login
            };

        public static List<HomeModel> ToHomesModel(this IEnumerable<HomeEntity> homes)
        {
            var result = new List<HomeModel>();

            foreach (var home in homes)
                result.Add(home.ToHomeModel());

            return result;
        }

        public static HomeModel ToHomeModel(this HomeEntity home) =>
            new HomeModel()
            {
                Id = home.Id,
                City = home.City,
                District = home.District,
                Price = home.Price,
                Reservations = home.Reservations.ToReservationsModel(),
            };

        public static List<ReservationModel> ToReservationsModel(this IEnumerable<ReservationEntity> reserservations)
        {
            var result = new List<ReservationModel>();

            foreach (var reserservation in reserservations)
                result.Add(reserservation.ToReservationModel());

            return result;
        }

        public static ReservationModel ToReservationModel(this ReservationEntity reservation) =>
            new ReservationModel()
            {
                StartDate = reservation.StartDate.ToString(),
                EndDate = reservation.EndDate.ToString()
            };

        public static HomeEntity ToHomeEntity(this HomeModel home) =>
            new HomeEntity()
            {
                Id = home.Id,
                City = home.City,
                District = home.District,
                Price = home.Price,
                Reservations = home.Reservations.ToReservationsEntities(),
            };

        public static List<ReservationEntity> ToReservationsEntities(this IEnumerable<ReservationModel> reservations)
        {
            var result = new List<ReservationEntity>();

            foreach (var reserservation in reservations)
                result.Add(reserservation.ToReservationEntity());

            return result;
        }

        public static ReservationEntity ToReservationEntity(this ReservationModel reservation) =>
            new ReservationEntity()
            {
                StartDate = DateTime.Parse(reservation.StartDate),
                EndDate = DateTime.Parse(reservation.EndDate)
            };
    }
}
