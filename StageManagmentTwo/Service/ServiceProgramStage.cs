using StageManagmentTwo.Entities;

namespace StageManagmentTwo.Service
{
    public class ServiceProgramStage
    {
        private readonly DbContextStageManagmentTwo _context;

        public ServiceProgramStage(DbContextStageManagmentTwo context)
        {
            _context = context;
        }

        /// <summary>
        /// Get all Programs
        /// </summary>
        /// <returns>a list of Programs</returns>
        public List<ProgramStage> GetAllProgramStages()
        {
            return _context.ProgramStages.ToList();
        }

        /// <summary>
        /// Add a Program
        /// </summary>
        /// <param name="programStage"></param>
        public void AddProgrammStage(ProgramStage programStage)
        {
            _context.ProgramStages.Add(programStage);
            _context.SaveChanges();
        }

        /// <summary>
        /// Update a Program
        /// </summary>
        /// <param name="programStageToUpdate"></param>
        public void UpdateProgramStage(ProgramStage programStageToUpdate)
        {
            var programStage = FindProgramStageById(programStageToUpdate.ProgramStageId);

            if (programStage is not null)
            {
                programStage.ProgramStageId = programStageToUpdate.ProgramStageId;
                programStage.Name = programStageToUpdate.Name;
                programStage.PriceEuro = programStageToUpdate.PriceEuro;
                programStage.StartPaidEuro = programStageToUpdate.StartPaidEuro;
                programStage.EndPaidEuro = programStageToUpdate?.EndPaidEuro;
                programStage.Duration = programStageToUpdate.Duration;
                programStage.IsPaid = programStageToUpdate.IsPaid;
                programStage.ArtistId = programStageToUpdate.ArtistId;

                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Delete a Program
        /// </summary>
        /// <param name="id"></param>
        public void DeleteProgramStage(int id)
        {
            var programstage = FindProgramStageById(id);

            if (programstage is not null)
            {
                _context.ProgramStages.Remove(programstage);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Find Program by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Program</returns>
        public ProgramStage FindProgramStageById(int id)
        {
            return _context.ProgramStages.Find(id);
        }

        public bool CheckOfDuplicateProgramStage(ProgramStage programStage)
        {
            return _context.ProgramStages.Any(p => p.Name == programStage.Name && p.ArtistId == programStage.ArtistId && p.Duration == programStage.Duration);
        }
    }
}
