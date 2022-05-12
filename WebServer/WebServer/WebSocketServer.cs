using System.Net;
using System.Net.Sockets;
using System.Net.WebSockets;

namespace WebServer;

public class WebSocketServer
{
    private WebSocket _webSocket;
    private WebSocketReceiveResult 

    public WebSocketServer(string address, int port)
    {
        var ipHost = Dns.GetHostEntry(address);
        var ipAddr = ipHost.AddressList[0];
        var ipEndPoint = new IPEndPoint(ipAddr, port);
        var socket = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        socket.Bind(ipEndPoint);
        socket.Accept();
        var s = new NetworkStream(socket, true);
        _webSocket = WebSocket.CreateFromStream(s, new WebSocketCreationOptions {IsServer = true});
    }

    public async Task Start()
    {
        if (_webSocket.SendAsync())
    }
}