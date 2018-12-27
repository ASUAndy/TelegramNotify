interface INotifier
{
    // Send notify
    void Send(object msg);

    // Send notify async
    void SendAsync(object msg);
}
