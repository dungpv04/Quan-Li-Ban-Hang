using Database.Models;
using Shared.IFactory;
using Shared.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Factory
{
    public class ViewModelAbstractFactory : IAbstractFactory
    {
        public ProductTypeViewModel createProductTypeViewModel(LoaiHang entity)
        {
            return new ProductTypeViewModel
            {
                MaLoai = entity.MaLoai,
                TenLoai = entity.TenLoai,
                MoTa = entity.MoTa
            };
        }
    }
}
