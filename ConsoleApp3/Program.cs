

namespace Sistema_Universitario
{   // la clase padre
    public class Persona
    {
        //atributos
        protected string _nombre;
        protected string _apellido;
        protected int _edad;
        protected string _dni;
        //creamos el constructor con parametros y los set para validar
        public Persona(string Nombre,string Apellido, int Edad, string Dni)
        {
            SetNombre (Nombre);
            SetApellido(Apellido);
            SetEdad(Edad);
            SetDni(Dni);
        }

        //METODO VIRTUAL MOSTRAR INFORMACIO CON RETORNO STRING
        public virtual string MostrarInformacion()
        {
            return $"Nombre:{_nombre},Apellido;{_apellido},Edad:{_edad},DNI:{_dni}";
        }
        //get y set de los atributos y validaciones

        //-------------NOMBRE----------------
        public void SetNombre(string Nombre)
        {
            if (string.IsNullOrEmpty(Nombre))
            {
                Console.WriteLine("ERROR. Complete su nombre");
            }
            else
            {
                _nombre = Nombre;
            }
        }
        public string GetNombre()
        {
            return _nombre;
        }
        //-----------APELLIDO--------------
        public void SetApellido(string Apellido)
        {
            if (string.IsNullOrEmpty(Apellido))
            
            {
                Console.WriteLine("ERROR. Complete su apellido");

            }
            else
            {
                _apellido = Apellido;
            }
        }   
        public string GetApellido()
        {
            return _apellido;
        }
        //----------EDAD--------------
        public void SetEdad(int Edad)
        {
            if (Edad <= 0)
            {
                Console.WriteLine("ERROR. La edad debe ser mayor a 0");
            }
            else
            {
                _edad = Edad;
            }

        }
        public int GetEdad()
        {
            return _edad;
        }
       //-----------------DNI-------------------
        public void SetDni(string Dni)
        {
            if (Dni != null && Dni.Length == 8)
            {
                _dni = Dni;
            }
            else
            {
                Console.WriteLine("ERROR. EL CAMPO DEBE TENER 8 CARACTERES");
            }
        }
        public string GetDni()
        {
            return _dni;
        }
    }
    //CREANMOS LA CLASE HIJA PROFESOR
    public class Profesor : Persona
    {   //ATRIBUTOS PROPIOS DE CLASE PROFESOR
        private string _legajodocente;
        private string _materiadictada;
        private int _horassemanales;
        //CREAMOS EL CONSTRUCTOR  CON PARAMETROS DE LA CLASE PERSONA + PROFESOR
        public Profesor(string Nombre, string Apellido,int Edad, string Dni, string LegajoDocente, string MateriaAsignada, int HorasSemanales) :
            base(Nombre, Apellido, Edad, Dni)
        {
            SetLegajoDocente(LegajoDocente);
            SetMateriaDictada(MateriaAsignada);
            SetHorasSemanales(HorasSemanales);
        }

       //REALIZAMOS SET, GET Y VALIDAMOS
        //-------------EDAD---------------
        public void SetEdad(int Edad)
        {
            if (Edad >= 22 && Edad <= 65)
            {
                _edad = Edad;
            }
            else
            {
                Console.WriteLine("ERROR. La edad esta fuera del rango aceptado");

            }

        }
        public int GetEdad()
        {
            return _edad;
        }
        //----MATERIA DICTADA------------
        public void SetMateriaDictada( string MateriaDictada)
        {
            if (string.IsNullOrEmpty(MateriaDictada))
            {
                Console.WriteLine("Error. Debe llenar el campo asignado");

            }
            else
            {
                _materiadictada = MateriaDictada;
            }
        }
        public string GetMateriaDictada()
        {
            return _materiadictada;
        }
        //-----------HORAS SEMANALES---------
        public void SetHorasSemanales(int HorasSemanales)
        {
            if (HorasSemanales >= 4 && HorasSemanales <= 48)
            {
                _horassemanales = HorasSemanales;
            }
            else
            {
                Console.WriteLine("ERROR. las horas semanales estan fuera del rango permitido");
            }
            
        }
        public int GetHorasSemanales()
        {
            return _horassemanales;
        }
        //----------LEGAJO DOCENTE-------------
        public void SetLegajoDocente(string LegajoDocente)
        {
            if(LegajoDocente != null && LegajoDocente.StartsWith("P"))
            {
                _legajodocente = LegajoDocente;
            }
            else
            {
                Console.WriteLine("ERROR. El legajo debe ingresar con la letra P(ej:P01234)");
            }
        }
        //---------MOSTRAR INFORMACION ------------
        public override string MostrarInformacion()
        {
        
            return $"{base.MostrarInformacion()},Legajo Docente:{_legajodocente}, Materia Dictada:{_materiadictada},Horas Semanales:{_horassemanales}";
        }
        
    } 
    //CREAMOS LA CLASE ESTUDIANTE
    public class Estudiante:Persona
    {
        //ATRIBUTOS
        private string _matricula;
        private double _promedio;
        private string _carrera;

        //CONSTRUCTOR CON HERENCIA DE PERSONA
        public Estudiante(string Nombre, string Apellido, int Edad, string Dni, string Matricula, double Promedio, string Carrera) 
            : base(Nombre,Apellido,Edad,Dni)
        {
            SetMatricula(Matricula);
            SetPromedio(Promedio);
            SetCarrera(Carrera);

        }

        //SET Y GET CON VALIDACIONES
        //-----------EDAD-----------
        public void SetEdad( int Edad)
        {
            if (Edad >= 17)
            {
                _edad = Edad;
            }
            else
            {
                Console.WriteLine("ERROR. La edad minima es de 17 años");
            }
        }
        public int GetEdad()
        {
            return _edad;
        }

        //-------------MATRICULA------------------------
        public void SetMatricula(string Matricula)
        {
            if(Matricula != null && Matricula.Length == 6)
            {
                _matricula = Matricula;
            }
            else
            {
                Console.WriteLine("ERROR. Matricula incorrecta");
            }
        }
        public string GetMatricula()
        {
            return _matricula;
        }
        // -------------PROMEDIO---------------
        public void SetPromedio(double Promedio)
        {
            if(Promedio >=1.0 &&Promedio <= 10.0)
            {
                _promedio = Promedio;
            }
            else
            {
                Console.WriteLine("ERROR. El promedio debe estar dentro de este rango (1.0 hasta10.0)");
            }
        }
        public double GetPromedio()
        {
            return _promedio;
        }
        //-------------CARRERA-----------
        public void SetCarrera(string Carrera)
        {
            if(Carrera != null&& Carrera.Length<=50)
            {
                _carrera = Carrera;
            }
            else
            {
                Console.WriteLine("ERROR. El campo asignado debe estar completo y no superar los 50 caracteres");
            }
        }
        public string GetCarrera()
        {
            return _carrera;
        }
        //MOSTRAR INFORMACION 
        public override string MostrarInformacion()
        {
        
            return  $"{base.MostrarInformacion()},Matricula: {_matricula},Promedio:{_promedio},Carrera{_carrera}";
        }
        //ESTADOSACADEMICOS
        public string EstadoAcademico(double Promedio)
        {

            if (Promedio >= 4.0)
            {
                return $"Regular";
            }
            else
            {
                return $"En Riesgo";
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //CREAMOS LA LISTA
            List<Persona> listaPersonas = new List<Persona>();
            //AGREGAMOS UN  PROFESOR A LA LISTA
            Profesor miProfesor = new Profesor("Carlos", "Gomez", 40, "12345678", "P2025", "Programacion",20);
            listaPersonas.Add(miProfesor);
            //AGREGAMOS UN ESTUDIANTE A LA LISTA
            Estudiante Estudiante1 = new Estudiante("Marcos", "Aguirre", 25, "87654321", "E2526", 5.5, "Programacion");
            listaPersonas.Add(Estudiante1);
            //BUCLE PARA RECORRER LA LISTA
            foreach(Persona p in listaPersonas)
            {
                Console.WriteLine(p.MostrarInformacion());
            }
            //PROBAMOS DATOS INVALIDOS
            Console.WriteLine("----------------Testeando validacion con datos erroneos----------------");
            Estudiante Estudiante2 = new Estudiante("Matias", "Molina", 37, "1234", "E123456789", 12.5, "PP1");
        }
    }
}
