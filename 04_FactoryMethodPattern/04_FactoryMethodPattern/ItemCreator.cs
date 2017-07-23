using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework
{ 
    public abstract class ItemCreator
    {
        public Item create()
        {

            Item item;

            requestItemsInfo();
            item = createItem();
            createItemLog();

            return item;
        }


        //아이템을 생성하기 전에 아이템 정ㅇ보를 요청
        abstract protected void requestItemsInfo();
        //로그
        abstract protected void createItemLog();

        //아이템을 생성하는 알고리즘
        abstract protected Item createItem();


    }
}
