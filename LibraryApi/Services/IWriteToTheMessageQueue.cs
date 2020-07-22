using LibraryApi.Domain;
using System.Threading.Tasks;

namespace LibraryApi.Services
{
    public interface IWriteToTheMessageQueue
    {
        Task Write(Reservations reservation);
    }
}