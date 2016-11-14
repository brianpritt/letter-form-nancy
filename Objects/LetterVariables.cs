namespace FriendLetter.Objects
{
  public class LetterVariables
  {
    private string _recipient;
    private string _sender;
    private string _destination;
    private string _location;

    public string GetRecipient()
    {
      return _recipient;
    }

    public void SetRecipient(string newRecipient)
    {
      _recipient = newRecipient;
    }

    public string GetSender()
    {
      return _sender;
    }

    public void SetSender(string newSender)
    {
      _sender = newSender;
    }

    public string GetLocation()
    {
      return _location;
    }

    public void SetLocation(string newLocation)
    {
      _location = newLocation;
    }
    public string GetDestination()
    {
      return _destination;
    }

    public void SetDestination(string newDestination)
    {
      _destination = newDestination;
    }

  }
}
