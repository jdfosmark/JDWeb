

namespace JDWeb.Interfaces
{
    public interface IEmail
    {
        void SendEmail(string from, string subject, string message);
        void SendEmail(string to, string cc, string bcc, string subject, string message);
        void SendEmail(string[] to, string[] cc, string[] bcc, string subject, string message);
        void SendIndividualEmailsPerRecipient(string[] to, string subject, string message);
    }
}
