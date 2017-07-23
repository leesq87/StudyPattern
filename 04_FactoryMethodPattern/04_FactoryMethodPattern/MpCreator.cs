using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework
{
    public class MpCreator : ItemCreator
    {
        protected override Item createItem()
        {
            return new MpPotion();
        }

        protected override void createItemLog()
        {
            Console.WriteLine("저장" + System.DateTime.Now);
        }

        protected override void requestItemsInfo()
        {
            Console.WriteLine("엠피 회복포션 생성");
        }
    }
}
