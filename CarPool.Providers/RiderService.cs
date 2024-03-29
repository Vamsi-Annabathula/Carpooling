﻿using CarPool.IServices;
using Application.CarPool.Concern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CarPool.Domain.Enum;
using CarPool.Persistence;

namespace CarPool.Api
{
    
    public class RiderService
    {
        protected readonly CarPoolDBContext _context;
        public RiderService(CarPoolDBContext context)
        {
            _context = context;
        }
        //public void EndPassengerTrip(string passengerRideId)
        //{
        //        var user = _context.PassengerRides.Where(s => s.Id == passengerRideId).FirstOrDefault();
        //        user.EndTime = DateTime.Now;
        //        user.Status = RideStatusType.Completed;
        //        _context.SaveChanges();
            
        //}

        //public void StartPassengerTrip(string passengerRideId)
        //{
        //        var user = _context.PassengerRides.Where(s => s.Id == passengerRideId).FirstOrDefault();
        //        user.StartTime = DateTime.Now;
        //        user.Status = RideStatusType.OnGoing;
        //        _context.SaveChanges();
            
        //}

        //public string AcceptPassenger(string passengerRideId, string offeredRideId)
        //{
        //        var rider = _context.Rides.Where(s => s.Id == offeredRideId).FirstOrDefault();
        //        var passengerRide = _context.PassengerRides.Where(s => s.Id == passengerRideId).FirstOrDefault();
        //        if (rider.AvailableCapacity < passengerRide.RequestedSeats)
        //        {
        //            _context.RideRequests.Where(s => s.OfferedRideId == offeredRideId).FirstOrDefault().Status = RideRequestStatus.Accepted;
        //            passengerRide.Id = offeredRideId;
        //            passengerRide.BookingStatus = BookingStatus.Booked;
        //            rider.AvailableCapacity -= passengerRide.RequestedSeats;
        //            _context.SaveChanges();
        //            return "Accepted user successfully";
        //        }
        //        else
        //        {
        //            return "Not enough capacity accept this user";
        //        }
        //}

        //public void AddPassenger(string offeredRideId, int requiredSeats)
        //{
        //        _context.Rides.Where(s => s.Id == offeredRideId).FirstOrDefault().AvailableCapacity -= requiredSeats;
        //        _context.SaveChanges();
        //}

        //public decimal AverageRating(string offeredRideId)
        //{
        //        var allStars = _context.Ratings.Where(s => s.RideId == offeredRideId).Select(s => s.Stars);
        //        return Decimal.Round(allStars.Sum() / allStars.Count(), 1);
        //}

        //public void EndPostedRide(string offeredRideId)
        //{
        //        var ride = _context.Rides.Where(s => s.Id == offeredRideId).FirstOrDefault();
        //        var status = ride.Status;
        //        status = RideStatusType.Completed;
        //        _context.SaveChanges();
        //}
    }
}
