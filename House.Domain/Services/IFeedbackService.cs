using House.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace House.Domain.Services
{
    public interface IFeedbackService
    {
        Task<IEnumerable<Feedback>> GetAll();
        Task<Feedback> GetById(int id);
        Task Add(Feedback feedback);
        Task<IEnumerable<Feedback>> Update(Feedback newFeedback);
        Task Delete(int id);
    }
}
