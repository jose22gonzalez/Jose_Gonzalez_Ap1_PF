using System.Linq.Expressions;
using  Microsoft.EntityFrameworkCore;
using Jose_Gonzalez_Ap1_PF.DAL;
using Jose_Gonzalez_Ap1_PF.Entidades;

namespace Jose_Gonzalez_Ap1_PF.BBL
{
    public class InscripcionesBBL
    {
        private Contexto _contexto;

        public InscripcionesBBL(Contexto contexto)
        {
            _contexto = contexto;
        }

        private bool Existe(int InscripcionId)
        {
            bool paso = false;

            try
            {
                paso = _contexto.Inscripciones.Any(p => p.InscripcionId == InscripcionId);
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

     

        private bool Insertar(Inscripciones inscripciones)
        {
            bool paso = false;
            try
            {
                _contexto.Inscripciones.Add(inscripciones);
                paso = _contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        private bool Modificar(Inscripciones inscripciones)
        {
            bool paso = false;
            try
            {          
                _contexto.Database.ExecuteSqlRaw($"DELETE FROM InscripcionesDetalles WHERE InscripcionId={inscripciones.InscripcionId}");

                foreach (var Anterior in inscripciones.InscripcionesDetalles)
                {
                    _contexto.Entry(Anterior).State = EntityState.Added;
                }
                _contexto.Entry(inscripciones).State = EntityState.Modified;
                paso = _contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }


        public bool Guardar(Inscripciones inscripciones)
        {
            if (Existe(inscripciones.InscripcionId))
                return Modificar(inscripciones);
            else
                return Insertar(inscripciones);
        }

        public Inscripciones? Buscar(int inscripcionesId)
        {
            Inscripciones? productos = new Inscripciones();

            try
            {
                productos = _contexto.Inscripciones.Include(z => z.InscripcionesDetalles)
                                                .Where(x => x.InscripcionId == inscripcionesId)
                                                .SingleOrDefault();
            }
            catch (Exception)
            {
                throw;
            }

            return productos;
        }
       

        public bool Eliminar(int inscripcionesId)
        {
            bool paso = false;

            try
            {
                var producto = _contexto.Inscripciones.Find(inscripcionesId);
                if (producto != null)
                {
                    _contexto.Inscripciones.Remove(producto);
                    paso = _contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public List<Inscripciones> GetList(Expression<Func<Inscripciones, bool>> criterio)
        {
            List<Inscripciones> lista = new List<Inscripciones>();
            try
            {
                lista = _contexto.Inscripciones.Include(x => x.InscripcionesDetalles)
                                            .Where(criterio)
                                            .AsNoTracking()
                                            .ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return lista;
        }
    }
}