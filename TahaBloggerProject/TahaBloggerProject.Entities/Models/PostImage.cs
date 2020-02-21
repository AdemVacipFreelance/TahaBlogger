using System;
using System.Collections.Generic;
using System.Text;
using TahaBloggerProject.Core.Entities;

namespace TahaBloggerProject.Entities.Models
{
  public  class PostImage:IEntity
    {
        public int PostImageId { get; set; }
        public string ImageRootName { get; set; }
        public int PostId { get; set; }

    }
}
