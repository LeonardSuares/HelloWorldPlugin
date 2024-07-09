using System;

namespace HelloWorldPlugin
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize the plugin
            HelloWorldPlugin plugin = new HelloWorldPlugin();

            //Execute the action
            plugin.RunAction();
        }
    }
}
