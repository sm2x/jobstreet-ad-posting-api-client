﻿
namespace JobStreet.AdPostingApi.Client.Models.JobStreet
{
    public class LocationModel
    {
        public LocationModel()
        {
        }

        public LocationModel(LocationModel model)
        {
            this.Id = model.Id;
            this.Area = model.Area;
        }

        public int?[] Id { get; set; }

        public string Area { get; set; }
    }
}
