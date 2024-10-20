﻿using Project_SWP391.Model;

namespace Project_SWP391.Dtos.Tours
{
    public class CreateTourDto
    {
        public string TourName { get; set; } 
        public float Price { get; set; }
        public string StartTime { get; set; }
        public string FinishTime { get; set; }
        public string NumberOfParticipate { get; set; }

    }
}
