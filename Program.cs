// Application that previews keys

using Microsoft.Toolkit.Uwp.Notifications;

class commandPreview
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Provide key to display");
        }

        else
        {
            new ToastContentBuilder()
                .AddText($"{args[0]}")
                .Show();
        }

    }
}

