using FrameWork;
using FrameWork.Logger;
using System;
using System.Collections.Generic;
using System.Timers;

namespace LobbyServer
{
    /// <summary>
    /// Start Lobby Server
    /// </summary>
    class Program
    {
        //Initialize variables
        public static World.Listener WorldListener;                             //Create a new World.Listener called WorldListener
        public static List<byte> Worlds = new List<byte>();                     //Create a new list called worlds
        public static List<LobbyClient> Clients = new List<LobbyClient>();      //Create a new list called clients

        [STAThread]
        private static void Main(string[] args)
        {
            Log.Info("LobbyServer", "Starting...");

            if (!EasyServer.InitLog("Lobby", "Configs/Logs.conf") ||
                !EasyServer.InitConfig("Configs/Lobby.xml", "Lobby") ||
                !EasyServer.InitConfig("Configs/Database.xml", "Database") ||
                !EasyServer.Listen<TcpServer>(EasyServer.GetConfValue<int>("Lobby", "LoginServer", "Port"), "LoginServer"))
            {
                return;
            }

            WorldListener = new World.Listener(EasyServer.GetConfValue<string>("Lobby", "WorldListener", "IP"), EasyServer.GetConfValue<int>("Lobby", "WorldListener", "Port"));

            Databases.InitDB();

            Databases.Load(true);

            try
            {
                HttpServer.MapHandlers();
                HttpServer server = new HttpServer();
                server.Start();
            }
            catch
            {
                Log.Error("HTTP", "If you want to use HTTP stuff, start this server with Admin rights");
            }

            Log.Succes("LobbyServer", "Server initialisation complete!");
            Clients.Clear();
            Worlds.Clear();
            Timer aTimer = new Timer(1000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;

            Log.Enter();
            Console.WriteLine("For available console commands, type /commands");
            Log.Enter();

            bool done = false;
            while (!done)
            {
                var command = Console.ReadLine();
                ProccessCommand(command);
            }
            EasyServer.StartConsole();
        }

        /// <summary>
        /// Process commands inputed
        /// </summary>
        /// <param name="command"></param>
        public static void ProccessCommand(string command)
        {
            switch (command)
            {
                //List all commands available
                case "/commands":
                    Log.Enter();
                    Console.WriteLine("Available commands:");
                    Console.WriteLine("/commands - shows this list of commands");
                    Console.WriteLine("/shutdown - shuts down server");
                    Console.WriteLine("/clients - total clients connected");
                    Console.WriteLine("/worlds - total world servers connected");
                    Console.WriteLine("/clear console - clear console from logs");
                    break;
                //Shutdown the server
                case "/shutdown":
                    Console.WriteLine("Login server shutting down in 3 seconds...");
                    System.Threading.Thread.Sleep(3000);
                    Environment.Exit(2);
                    break;
                //List all clients
                case "/clients":
                    int count = 0;
                    foreach (LobbyClient client in Clients)
                    {
                        count++;
                        Console.WriteLine("Name: " + client.Account.Username);
                        Console.WriteLine("ID: " + count);
                        Console.WriteLine("isGM: " + client.Account.IsAdmin);
                    }
                    Log.Enter();
                    Console.WriteLine("Total clients connected to login server: " + count);
                    count = 0;
                    break;
                //Show all worlds connected to the server
                case "/worlds":
                    Console.WriteLine("Total worlds connected to login server: " + Worlds.Count);
                    break;
                //Clear the console
                case "/clear":
                    Console.Clear();
                    break;
                //Everything else
                default:
                    Console.WriteLine("ERROR: Unknown command: " + command + "");
                    break;

            }
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Databases.Load(false);
        }
    }
}
