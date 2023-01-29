using House.Data;
using House.Domain.Entities;
using House.Domain.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace House.Services.Services
{
    internal class FeedbackServices : IFeedbackService
    {
        private readonly AppDBContext _context;
        public FeedbackServices(AppDBContext context)
        {
            _context = context;
        }

        public Task Add(Feedback feedback)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Feedback>> GetAll()
        {
            var result = await _context.Feedback.AsNoTracking().ToListAsync();
            return result;
        }

        public Task<Feedback> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Feedback>> Update(Feedback newFeedback)
        {
            var entity = await _context.Feedback.FirstOrDefaultAsync(x => x.ID == newFeedback.ID);
            entity.ID = newFeedback.ID;
            await _context.SaveChangesAsync();
            return (IEnumerable<Feedback>)entity;
        }
    }
}
