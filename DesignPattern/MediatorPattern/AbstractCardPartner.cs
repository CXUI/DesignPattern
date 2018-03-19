using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{

    // 抽象牌友类
  abstract class AbstractCardPartner
    {
      public int MoneyCount { get; set; }

      public AbstractCardPartner()
      {
          MoneyCount = 0;

      }

      public abstract void ChangeCount(int count, AbstractMediator mediator);
    }
}
