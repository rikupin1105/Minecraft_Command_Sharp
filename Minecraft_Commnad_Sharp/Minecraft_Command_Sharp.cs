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

            IPAddress ipAddress = IPAddress.Parse("IPアドレスを入力");
            ushort port = ポート番号を入力;
            var password = "パスワードを入力";
            var command = "コマンドを入力";
            var connection = new CoreRCON.RCON(ipAddress, port, password);
            await connection.SendCommandAsync(command);

        }
    }
}
