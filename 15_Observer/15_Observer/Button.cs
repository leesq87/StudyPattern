using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Observer
{
    public class Button
    {


        public void onClick()
        {
            Console.WriteLine("asdf");
            //이벤트 처리
            if(onClickListener != null) 
                onClickListener.onClick(this);

        }

        public interface OnClickListener
        {
            void onClick(Button button);
        }

        private OnClickListener onClickListener;

        public void SetOnclickListener(OnClickListener onClickListener)
        {
            this.onClickListener = onClickListener;
        }

    }
}
