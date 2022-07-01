using System;
using System.Collections.Generic;
using System.Text;
using YCProduction.IRepository.IRepository.Base;
using YCProduction.IService.IService.Base;
using YCProduction.Model.Entitys.Base;
using YCProduction.Service.BaseService;

namespace YCProduction.Service.Service.Base
{
    public class BaseDepartmentService : BaseService<BaseDepartment>, IBaseDepartmentService
    {
        public BaseDepartmentService(IBaseDepartmentRepository baseDepartmentRepository)
        {
            BaseDepartmentRepository = baseDepartmentRepository;
            base.BaseRepository = baseDepartmentRepository;
        }

        public IBaseDepartmentRepository BaseDepartmentRepository { get; }
    }
}
