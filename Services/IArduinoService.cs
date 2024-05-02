using Arduino.Models;

namespace Arduino.Services
{
    public interface IArduinoService
    {
        string SendSeveral(List<Ardcommand> ardcommands, bool useCOM3);
        string Send(Ardcommand ardcommand, bool useCOM3);
        string OnThenOff(Ardcommand ardcommand, bool useCOM3);
    }
}
