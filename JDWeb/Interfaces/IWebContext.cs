

namespace JDWeb.Interfaces
{
    public interface IWebContext
    {
        void ClearSession();
        bool ContainsInSession(string key);
        void RemoveFromSession(string key);
    }
}
