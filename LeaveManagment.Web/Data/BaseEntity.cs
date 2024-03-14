﻿using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagment.Web.Data
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}