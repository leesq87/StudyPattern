using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    학습목표
    팩토리 메소드 패턴에서 템플릿 메서드 패턴의 사용됨을 안다.
    팩토리 메서드 패턴에서의 구조와 구현의 분리를 이해하고 구조와 구현의 분리의 장점을 안다.
    모든 패턴은 기본적으로 구조와 구현의 분리를 장점으로 둔다.

    

    요구사항
    *게임 아이템과 아이템 생성을 구현
     - 아이템을 생성하기 전에 데이터 베이스에서 아이템 정보를요청
     - 아이템을 생성 후 아이템 복제 등의 불법을 방지하기 위해 데이터 베이스에 아이템 생성 정보를 남긴다.
    * 아이템을 생성하는 주체를 itemCreator로 이름짓는다.
    * 아이템은 item이라는 interface로 다룰 수 있도록 한다.
     - item은 use함수를 기본 함수로 갖고 있다.
    * 현재 아이템의 종류는 체력회복물약, 마력회복물약이 있다.

*/

using framework;

namespace _04_FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemCreator creator;
            Item item;

            creator = new HpCreator();
            item = creator.create();
            item.use();

            creator = new MpCreator();
            item = creator.create();
            item.use();

        }
    }
}
