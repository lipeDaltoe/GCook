using System.Net.Mail;

namespace GCook.Helpers;

public static class Helpers
{
    public static bool IsValidEmail(string email)
    {
        try
        {
            MailAddress m = new(email);
            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }
}