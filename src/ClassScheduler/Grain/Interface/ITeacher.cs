﻿using System.Threading.Tasks;

namespace Orleans.Samples.ClassScheduler.Gain.Interface
{
    public interface ITeacher : IGrainWithGuidKey
    {
        Task SetName(string firstName, string lastName);
        Task<string> GetFullName();
        Task<string> GetFirstName();
        Task<string> GetLastName();
    }
}
