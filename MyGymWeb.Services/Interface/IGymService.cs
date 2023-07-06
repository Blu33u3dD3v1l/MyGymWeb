﻿using MyGymWeb.Models.Home;

namespace MyGymWeb.Services.Interface
{
    public interface IGymService
    {
        Task<IEnumerable<GymsViewModel>> GetAllGymsAsync();
        Task<GymsViewModel> GetDescriptionAsync(int id);
        Task<IEnumerable<IndexViewModel>> GetAllGymsForIndexAsync();
        Task<EditGymFormModel> GetEditGymAsync(int id);
        Task EditByIdAsync(int id, EditGymFormModel model);        
        Task AddGymAsync(AddGymFormModel model);
     
       




    }
}
