
namespace HelloWorldAPI
{
    public interface IHelloWorld
    {
        string WriteLocation { get; set; }

        string getGreeting();

        void writeMessage(string value);

    }
}
