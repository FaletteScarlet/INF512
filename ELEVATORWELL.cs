//ELEVATORWELL.cs

using System;

class Elevatorwell
{
    private int numeroPiso;
    private int numeroPisoSolicitado;
    private bool encendidoApagado;
    private int hora;

    public Elevatorwell(int hora)
    {
        setHora(hora);
        setEncendidoApagado();
        
        if (getEncendidoApagado())
        {
            int numeroPiso = 0;
            setNumeroPiso(numeroPiso);
            bool valorPuerta = true;
            Console.WriteLine("\nElevador llego: {0} piso.", getNumeroPiso());
            puerta(valorPuerta);
            Console.WriteLine("\nBienvenido a ELEVATORWELL. Pongase comodo y seleccione un piso hacia donde quiere ir.");

            
        }
        else
        {
            Console.WriteLine("\nELEVATORWELL esta cerrado, por favor vuelva despues de las 730.");
        }
       
        
       
    }

    public void setNumeroPiso(int numeroPiso)
    {
        if (numeroPiso >= 0 && numeroPiso <=10)
        {
            this.numeroPiso = numeroPiso;
        }
        else
        {
            this.numeroPiso = 0;
            Console.WriteLine("\nEl numero de piso digitado no existe.");
        }
    }

    public int getNumeroPiso()
    {
        return this.numeroPiso;
    }

    public void setNumeroPisoSolicitado( int numeroPisoSolicitado)
    {
        if (numeroPisoSolicitado >= 0 && numeroPisoSolicitado <=10 && numeroPisoSolicitado < getNumeroPiso() || numeroPisoSolicitado > getNumeroPiso() )
        {
            this.numeroPisoSolicitado = numeroPisoSolicitado;
        }
        else
        {
            this.numeroPisoSolicitado = 0;
            Console.WriteLine("\nEl numero de piso digitado no existe.");
        }
    }

    public int getNumeroPisoSolicitado()
    {
        return this.numeroPisoSolicitado;
    }

    public void setHora (int hora)
    {
        
        if (hora >= 0000 && hora <= 2359)
        {
            this.hora = hora;
        }
        else 
        {
            this.hora = 0000;
            Console.WriteLine("\nLa hora esta incorrecta, por favor inserte en formato 2400");
        }
    }

    public int getHora ()
    {
        return this.hora;
    }

    public void setEncendidoApagado()
    {
        if (this.hora >= 730 && this.hora <= 1930)
        {
            encendidoApagado = true;
        }
        else
        {
            encendidoApagado = false;
        }
    }

    public bool getEncendidoApagado()
    {
        return encendidoApagado;
    }

    public void puerta(bool valorPuerta)
    {
        if (valorPuerta)
        {
            Console.WriteLine("\nPuerta Abierta.");
        }
        else
        {
            Console.WriteLine("\nPuerta Cerrada.");
        }
    }

    public void subirBajar(int pisoElevador)
    {
        bool valorPuerta;
       
        if (getEncendidoApagado())
        {
            if (pisoElevador>getNumeroPiso())
            {
                valorPuerta = false;
                puerta(valorPuerta);

                for (int x=pisoElevador; x>=getNumeroPiso();x--)
                {
                    Console.WriteLine("\nElevador bajando: {0} piso.", x);
                }
                valorPuerta = true;
                puerta(valorPuerta);
                Console.WriteLine("\nElevador llego: {0} piso.", getNumeroPiso());
                valorPuerta = false;
                puerta(valorPuerta);
                if (getNumeroPiso() > getNumeroPisoSolicitado())
                {
                    for (int x=getNumeroPiso(); x>=getNumeroPisoSolicitado();x--)
                    {
                        Console.WriteLine("\nElevador bajando: {0} piso.", x);
                    }
                    valorPuerta = true;
                    puerta(valorPuerta);
                    Console.WriteLine("\nElevador llego: {0} piso.", getNumeroPisoSolicitado());
                }
                else if (getNumeroPiso() < getNumeroPisoSolicitado())
                {
                    for (int x=getNumeroPiso(); x<=getNumeroPisoSolicitado();x++)
                    {
                        Console.WriteLine("\nElevador subiendo: {0} piso.", x);
                    }
                    valorPuerta = true;
                    puerta(valorPuerta);
                    Console.WriteLine("\nElevador llego: {0} piso.", getNumeroPisoSolicitado());
                }
                
            }
            else if (pisoElevador<getNumeroPiso())
            {
                valorPuerta = false;
                puerta(valorPuerta);

                for (int x=pisoElevador; x<=getNumeroPiso();x++)
                {
                    Console.WriteLine("\nElevador subiendo: {0} piso.", x);
                }
                valorPuerta = true;
                puerta(valorPuerta);
                Console.WriteLine("\nElevador llego: {0} piso.", getNumeroPiso());
                valorPuerta = false;
                puerta(valorPuerta);
                if (getNumeroPiso() > getNumeroPisoSolicitado())
                {
                    for (int x=getNumeroPiso(); x>=getNumeroPisoSolicitado();x--)
                    {
                        Console.WriteLine("\nElevador bajando: {0} piso.", x);
                    }
                    valorPuerta = true;
                    puerta(valorPuerta);
                    Console.WriteLine("\nElevador llego: {0} piso.", getNumeroPisoSolicitado());
                }
                else if(getNumeroPiso() < getNumeroPisoSolicitado())
                {
                    for (int x=getNumeroPiso(); x<=getNumeroPisoSolicitado();x++)
                    {
                        Console.WriteLine("\nElevador subiendo: {0} piso.", x);
                    }
                    valorPuerta = true;
                    puerta(valorPuerta);
                    Console.WriteLine("\nElevador llego: {0} piso.", getNumeroPisoSolicitado());
                }
                
            }
            else
            {
                Console.WriteLine("\nElevador llego: {0} piso.", getNumeroPiso());
                valorPuerta = false;
                puerta(valorPuerta);
                if (getNumeroPiso() > getNumeroPisoSolicitado())
                {
                    for (int x=getNumeroPiso(); x>=getNumeroPisoSolicitado();x--)
                    {
                        Console.WriteLine("\nElevador bajando: {0} piso.", x);
                    }
                    valorPuerta = true;
                    puerta(valorPuerta);
                    Console.WriteLine("\nElevador llego: {0} piso.", getNumeroPisoSolicitado());
                }
                else if(getNumeroPiso() < getNumeroPisoSolicitado())
                {
                    for (int x=getNumeroPiso(); x<=getNumeroPisoSolicitado();x++)
                    {
                        Console.WriteLine("\nElevador subiendo: {0} piso.", x);
                    }
                    valorPuerta = true;
                    puerta(valorPuerta);
                    Console.WriteLine("\nElevador llego: {0} piso.", getNumeroPisoSolicitado());
                }
            }
            
        }
        else
        {
            Console.WriteLine("\nELEVATORWELL esta cerrado, por favor vuelva despues de las 730.");
        }
        
    }

}

class TesterElevatorwell
{
    static void Main()
    {
        Console.Clear();
        int hora, pisoElevador = 0;

        Console.WriteLine("\nDigite la hora en formato 2400: ");
        hora= int.Parse(Console.ReadLine());

        Elevatorwell miElevatorwell = new Elevatorwell(hora);

        miElevatorwell.setHora(hora);
        miElevatorwell.setEncendidoApagado();
        if (miElevatorwell.getEncendidoApagado())
        {
            do
            {
                int numeroPiso, numeroPisoSolicitado;
                Console.WriteLine("\nDigite el piso que se encuentra: ");
                numeroPiso = int.Parse(Console.ReadLine());
                miElevatorwell.setNumeroPiso(numeroPiso);

                Console.WriteLine("\nDigite el piso Solicitado: ");
                numeroPisoSolicitado = int.Parse(Console.ReadLine());
                miElevatorwell.setNumeroPisoSolicitado(numeroPisoSolicitado);

                miElevatorwell.subirBajar(pisoElevador);

                Console.WriteLine("\nDigite la hora en formato 2400: ");
                hora= int.Parse(Console.ReadLine());
                miElevatorwell.setHora(hora);
                miElevatorwell.setEncendidoApagado();
                pisoElevador = numeroPisoSolicitado;

        } while (miElevatorwell.getEncendidoApagado());
        Console.WriteLine("\nELEVATORWELL esta cerrado, por favor vuelva despues de las 730.");
        }
        else
        {
            Console.WriteLine("\nELEVATORWELL esta cerrado, por favor vuelva despues de las 730.");
        }
       
        
       
    }
}