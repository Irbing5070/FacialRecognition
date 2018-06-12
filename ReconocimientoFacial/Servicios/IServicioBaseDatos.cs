using System.Threading.Tasks;
using ReconocimientoFacial.Modelos;

namespace ReconocimientoFacial.Servicios
{
    public interface IServicioBaseDatos
    {
        Task<Usuario> ObtenerUsuario(string key);
        Task<bool> RegistrarUsuario(Usuario dato);
        Task<bool> ActualizarUsuario(Usuario dato);
    }
}