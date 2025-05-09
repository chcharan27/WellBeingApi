﻿using WellBeing.Services.AuthApi.Data;
using WellBeing.Services.AuthApi.models.Dto;
using Microsoft.EntityFrameworkCore;

namespace WellBeing.Services.AuthApi.Service
{
    public class ConsumerService : IConsumerService

    {

        private readonly AppDbContext _context;



        public ConsumerService(AppDbContext context)

        {

            _context = context;

        }



        public async Task<List<ConsumerDto>> GetUsersByRole(string role)

        {

            var users = await _context.Roles

              .Where(u => u.Name == role) // Filtering by role

              .ToListAsync();



            var consumerDtos = users.Select(u => new ConsumerDto

            {



                Name = u.Name,



            }).ToList();



            return consumerDtos;

        }

    }
}
