public class Proyecto
{

    private string nombre;
    private DateTime fechaInicio;

    public Proyecto(string nombre, DateTime fechaInicio)
    {
        this.nombre = nombre;
        this.fechaInicio = fechaInicio;
    }

    //Clase interna para gestionar tareas del proyecto

    private class Tarea
    {

        public string Descripcion { get; set; }
        public int DuracionHoras { get; set; }

        public Tarea(String descripcion, int duracionHoras)
        {
            Descripcion = descripcion;
            DuracionHoras = duracionHoras;
        }

    }

    //Clase interna para gestionar recursos del proyecto

    private class Recurso
    {

        public string Nombre { get; set; }
        public string Rol { get; set; }

        public Recurso(string nombre, string rol)
        {
            Nombre = nombre;
            Rol = rol;
        }
    }

    //Metodo publico para crear una tarea
    public string Agregartarea (string descripcion, int duracionHoras)
    {

        Tarea nuevatarea = new Tarea (descripcion, duracionHoras);
        return $"Tarea creada:  {nuevatarea.Descripcion}," + 
            $"Duración: {nuevatarea.DuracionHoras} horas";

    }

    //Metodo publico para asignar un recurso

    public string AsignarRecurso (string nombre, string rol)
    {

        Recurso nuevorecurso = new Recurso(nombre, rol);
        return $"Recurso asignado: {nuevorecurso.Nombre}, " +
            $"Rol: {nuevorecurso.Rol}";
    }

    //Mostrar detalles del proyecto
    public string MostrarDetalles ()
    {
        return $"Proyecto: {nombre}, " + 
            $"Fecha de inicio: {fechaInicio.ToShortDateString()}";
    }


}
