// =============================
// Email: kkdubey1989@gmail.com
// https://github.com/kkdubey
// =============================

using System;

namespace DAL.Models.Interfaces
{
    public interface IAuditableEntity
    {
        string CreatedBy { get; set; }
        string UpdatedBy { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime UpdatedDate { get; set; }
    }
}
