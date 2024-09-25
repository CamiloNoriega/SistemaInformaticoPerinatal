﻿using Entidades;


namespace Negocio
{
    public interface IServicioMaestro
    {
        List<Etnia> ObtenerEtnia();
        List<EstadoCivil> ObtenerEstadoCivil();
        List<NivelEstudios> ObtenerNivleEstudios();
        List<UsoAnticonceptivos> ObtenerUsoAnticonseptivos();
    }
}
