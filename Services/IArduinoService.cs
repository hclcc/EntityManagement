using Arduino.Models;

namespace Arduino.Services
{
    public interface IArduinoService
    {
        string SendSeveral(List<Ardcommand> ardcommands);
        string Send(Ardcommand ardcommand);
        string OnThenOff(Ardcommand ardcommand);
    }
}
