

    public class Cliente
    {

        public string Nombre { get; private set; }
        public int DNI { get; private set; }
        public int TipoEntrada { get; set; }

        public int TotalAbonado { get; set; }

        public DateTime FechaInscripcion { get; set; }
        public string Apellido { get; private set; }

        public Cliente()
        {
         Nombre ="";
         Apellido = "";
         DNI=0;
         TipoEntrada=0;
         FechaInscripcion=new DateTime();
        }
        public Cliente(string nom, string ape, int dni, int tipoE,int totalA, DateTime inscripcion)
        {
            Nombre = nom;
            DNI = dni;
            TipoEntrada = tipoE;
            FechaInscripcion = inscripcion;
            Apellido = ape;
            TotalAbonado = totalA;
        }


        
    }

