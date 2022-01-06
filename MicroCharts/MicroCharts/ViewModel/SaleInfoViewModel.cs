using MicroCharts.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroCharts.ViewModel
{
    class SaleInfoViewModel
    {

        public List<SaleInfo> SalesDatas { get; set; }


        public SaleInfoViewModel()
        {
            SalesDatas = new List<SaleInfo>();


            SalesDatas.Add(new SaleInfo { Year = 2021, Target = 500, Sale = 342 });
            SalesDatas.Add(new SaleInfo { Year = 2022, Target = 520, Sale = 320 });
            SalesDatas.Add(new SaleInfo { Year = 2023, Target = 260, Sale = 360 });
            SalesDatas.Add(new SaleInfo { Year = 2024, Target = 600, Sale = 430 });
            SalesDatas.Add(new SaleInfo { Year = 2025, Target = 200, Sale = 560 });
        }
    }
}
