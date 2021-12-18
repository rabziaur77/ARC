using ARC.Models;

namespace ARC.Repository
{
    public interface IRepo
    {
        public string SendEMail(EmailModel emailModel);
    }
}
