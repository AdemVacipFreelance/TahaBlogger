﻿using System;
using System.Collections.Generic;
using System.Text;
using TahaBloggerProject.Core.DataAccess;
using TahaBloggerProject.Entities.Models;

namespace TahaBloggerProject.DataAccess.Abstract
{
   public interface ICommentDal:IEntityRepository<Comment>
    {
    }
}