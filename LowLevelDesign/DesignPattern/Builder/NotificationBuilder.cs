using LowLevelDesign.DesignPattern.Builder;

public class NotificationBuilder
{
    private string _message;
    private string _recipient;
    private string _channel;
    private string _priority;

    public NotificationBuilder SetMessage(string message)
    {
        //add validation
        _message = message;
        return this;
    }

    public NotificationBuilder SetRecipient(string recipient)
    {
        //add validation
        _recipient = recipient;
        return this;
    }

    public NotificationBuilder SetChannel(string channel)
    {
        //add validation
        _channel = channel;
        return this;
    }

    public NotificationBuilder SetPriority(string priority)
    {
        //add validation
        _priority = priority;
        return this;
    }

    public NotificationRequest Build()
    {
        if (string.IsNullOrEmpty(_message) || string.IsNullOrEmpty(_recipient))
            throw new Exception("Invalid object");

        return new NotificationRequest(_message, _recipient, _channel, _priority);
    }
}