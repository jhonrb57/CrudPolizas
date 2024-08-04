using Models;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IPoliza
    {
        List<Poliza> Listar();
        Poliza Obtener(int numeroPoliza);
        bool Registrar(Poliza poliza);
        bool Modificar(Poliza poliza);
        bool Eliminar(int id);
    }
}
