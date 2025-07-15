using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Day8CSharp
{
        //1.create a custom Event Arguments
        public class ButtonClickedEventArgs : EventArgs
        {
            public string ClickBy { get; } //readonly property
            public ButtonClickedEventArgs(string ClickBy)
            {
                this.ClickBy = ClickBy;
            }
        }
        //2.create a class with an event
        public class Button
        {
            // create an event
            public event EventHandler<ButtonClickedEventArgs> ButtonClicked;
            //method to stimulate button click
            public void Click(string user)
            {
                Console.WriteLine("Event Raised");
                OnButtonClicked(new ButtonClickedEventArgs(user));
            }
            protected virtual void OnButtonClicked(ButtonClickedEventArgs e)
            {
                ButtonClicked.Invoke(this, e);
            }
        }
    class EvebtargDemo
    {
        //eventhandler
        public static void Button_ButtonClicked(object sender,ButtonClickedEventArgs e)
        {
            Console.WriteLine($"Button was clicked by:{e.ClickBy}");
        }
        public static void Main(string[] args)
        {
            Button button = new Button();
            //subscribe to the event
            button.ButtonClicked += Button_ButtonClicked;
            button.Click("Bob");
            button.Click("Dinesh");
            Console.Read();
        }
    }
}
