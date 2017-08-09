using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _15_Observer;

namespace _15_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Button button = new Button();
            button.SetOnclickListener(new ButtonClick());



            button.onClick();

        }
    }
}


class ButtonClick : _15_Observer.Button.OnClickListener
{
    public void onClick(Button button)
    {
        Console.WriteLine(button + " is clicked");
    }
}
