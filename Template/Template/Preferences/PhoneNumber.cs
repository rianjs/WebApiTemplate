using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Template.Preferences
{
    public class PhoneNumber
    {
        /// <summary>
        /// The E.164-formatted phone number
        /// </summary>
        public string E164 { get; set; }
        public bool SmsEnabled { get; set; }
        public bool IsPrimary { get; set; }
        
        [Required]
        public string Label { get; set; }
        
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"{Label}: {E164}");
            if (SmsEnabled)
            {
                sb.Append(" (SMS)");
            }

            if (IsPrimary)
            {
                sb.Append(" (Primary)");
            }

            return sb.ToString();
        }
    }
}