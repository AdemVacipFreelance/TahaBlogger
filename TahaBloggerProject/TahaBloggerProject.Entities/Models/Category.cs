using System;
using System.Collections.Generic;
using System.Text;
using TahaBloggerProject.Core.Entities;

namespace TahaBloggerProject.Entities.Models
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
