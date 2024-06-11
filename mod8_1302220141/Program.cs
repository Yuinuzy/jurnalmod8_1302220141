namespace program;
using mod8_1302220141.UIconfig;
using Newtonsoft.Json;
using mod8_1302220141.BankTransferConfig;
class Program
{
    static void Main()
    {
        /* String path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName ;
         String jsonString = File.ReadAllText(path + "//bank_transfer_config.json");
         BankTransferConfig config = JsonConvert.DeserializeObject<BankTransferConfig>(jsonString);
         Console.WriteLine("Language: " + config.lang);

         jsonString = JsonConvert.SerializeObject(config);
         File.WriteAllText(path + "//bank_transfer_config.json", jsonString);*/

        UIConfig uiConfig = new UIConfig();
        uiConfig.addConfig();
    }
}