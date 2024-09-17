using Microsoft.Identity.Client;
using StageManagmentTwo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManagmentTwo.Service
{
    public class ServicePerformance
    {
        private readonly DbContextStageManagmentTwo _context;

        public ServicePerformance(DbContextStageManagmentTwo context)
        {
            _context = context;
        }

        public List<Performance> GetAllPerformances()
        {
            return _context.Performances.ToList();
        }

        public void AddPerformance(Performance performance)
        {
            _context.Performances.Add(performance);
            _context.SaveChanges();
        }

        public void UpdatePerformance(Performance performanceToUpdate)
        {
            var performance = FindPerformanceById(performanceToUpdate.PerfomanceId);

            if (performance is not null)
            {
                performance.PerfomanceId = performanceToUpdate.PerfomanceId;
                performance.Name = performanceToUpdate.Name;
                performance.SartPerformance = performanceToUpdate.SartPerformance;
                performance.EndPerformance = performanceToUpdate.EndPerformance;
                performance.ProgramStageId = performanceToUpdate.ProgramStageId;

                _context.SaveChanges();
            }
        }

        public void RemovePerformanceById(int id)
        {
            _context.Performances.Remove(FindPerformanceById(id));
            _context.SaveChanges();
        }

        public Performance FindPerformanceById(int id)
        {
            return _context.Performances.Find(id);
        }

        public bool CkeckForDuplicatePerformance(Performance performance)
        {
            return _context.Performances.Any(p => p.Name == performance.Name && p.SartPerformance == performance.SartPerformance && p.EndPerformance == performance.EndPerformance && p.ProgramStageId == performance.ProgramStageId);
        }
    }
}
