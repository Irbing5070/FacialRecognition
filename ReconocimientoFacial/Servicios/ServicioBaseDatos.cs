using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReconocimientoFacial.Datos;
using ReconocimientoFacial.Helpers;
using ReconocimientoFacial.Modelos;

namespace ReconocimientoFacial.Servicios
{
    public class ServicioBaseDatos : IServicioBaseDatos
    {
        private readonly BaseDatos bd;

        public ServicioBaseDatos()
        {
            bd = new BaseDatos(Constantes.NombreBD);
        }

        //public async Task<Usuario> ObtenerUsuario(string id)
        //{
        //    try
        //    {
        //        return await bd.Usuarios.FindAsync(id);
        //    }
        //    catch(Exception e)
        //    {
        //        return null;
        //    }
        //}

        public async Task<Usuario> ObtenerUsuario(string key)
        {
            try
            {
                return await bd.Usuarios.FirstOrDefaultAsync(x => x.Key == key);
            }
            catch (Exception )
            {
                return null;
            }
        }

        public async Task<bool> RegistrarUsuario(Usuario dato)
        {
            try
            {
                await bd.Usuarios.AddAsync(dato);
                await bd.SaveChangesAsync();
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }

        public async Task<bool> ActualizarUsuario(Usuario dato)
        {
            try
            {
                bd.Usuarios.Update(dato);
                await bd.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                var msg = e.Message;
                return false;
            }
        }
    }
}