using System;
using System.Net;

namespace Minecraft_Command_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            comAsync();
        }
        static async void comAsync()
        {
            //Minecraftのサーバーフォルダに生成されるserver.propertiesで
            //server-ip = 任意
            //rcon.port = 任意
            //rcon.password= 任意
            //enable-rcon=true

            IPAddress ipAddress = IPAddress.Parse("192.168.0.108");
            ushort port = 25575;
            var password = "password";
            var command = "/time set day";
            var connection = new CoreRCON.RCON(ipAddress, port, password);
            await connection.SendCommandAsync(command);

        }
    }
}
