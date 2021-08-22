using System;
using System.ComponentModel.DataAnnotations;

namespace Template.Preferences
{
    public class EmailAddress :
        IEquatable<EmailAddress>
    {
        [EmailAddress]
        public string Value { get; set; }
        
        [Required]
        public string Label { get; set; }
        
        public bool IsPrimary { get; set; }

        public bool Equals(EmailAddress other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(Value, other.Value, StringComparison.OrdinalIgnoreCase)
                && string.Equals(Label, other.Label, StringComparison.OrdinalIgnoreCase)
                && IsPrimary == other.IsPrimary;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((EmailAddress) obj);
        }

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            hashCode.Add(Value, StringComparer.OrdinalIgnoreCase);
            hashCode.Add(Label, StringComparer.OrdinalIgnoreCase);
            hashCode.Add(IsPrimary);
            return hashCode.ToHashCode();
        }
    }
}