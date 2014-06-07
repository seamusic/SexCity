using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lennon.Core;
using Lennon.SexCity.Models;

namespace Lennon.SexCity.Business
{
    public class NovelBusiness : BaseBusiness
    {
        public IList<Novel> GetNovel(int page)
        {
            return null;
        }

        public IPagedList<Novel> GetNovels(int pageIndex, int pageSize, out int total, PropertySortCondition[] sortConditions)
        {
            //return null;
            total = 0;
            return null;
        }
    }
}
