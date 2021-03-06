﻿using Core.Domain;
using Core.Infrastructure.Data;

namespace FubuMvc.Directory.Entries
{
    public class DeleteHandler
    {
        private readonly IRepository<DirectoryEntry> _directoryRepository;

        public DeleteHandler(IRepository<DirectoryEntry> directoryRepository)
        {
            _directoryRepository = directoryRepository;
        }

        public void Execute_id(EntryModel request)
        {
            _directoryRepository.Delete(x => x.Id == request.id);
        }
    }
}