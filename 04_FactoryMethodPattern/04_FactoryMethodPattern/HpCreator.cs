using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework
{
    public class HpCreator : ItemCreator
    {
        protected override Item createItem()
        {
            return new HpPotion();
        }


        protected override void createItemLog()
        {
            Console.WriteLine("회복물약을 새로 생성한다." + System.DateTime.Now);
        }

        protected override void requestItemsInfo()
        {
            Console.WriteLine("데이터베이스에서 회복물약의 정보를 갖고온다.");
        }

    }
}
