using System.Collections.Generic;

namespace Template.Preferences
{
    public class Destinations
    {
        public string Id { get; set; }
        public List<PhoneNumber> PhoneNumbers { get; set; }
        public List<EmailAddress> EmailAddresses { get; set; }
    }
}