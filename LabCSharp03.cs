using System;

class Contrato
{
    private int plazoTiempo;
    private float cuotasMensuales;

   
    public void setPlazoTiempo(int plazo)
    {
       
        plazoTiempo= plazo;
        
    }

    public int getPlazoTiempo()
    {
        return plazoTiempo;
    }

    public void setCuotasMensuales(float cuotas)
    {
        if (cuotas >0)
        {
            cuotasMensuales = cuotas;
        }
        else
        {
           Console.WriteLine("Debe ingresar una cuota mensual valida."); 
        }
    }

    public float getCuotasMensuales()
    {
        return cuotasMensuales;
    }

     public void aquirimos()
    {
        if (getPlazoTiempo() > 0 )
        {
            Console.WriteLine("\nUsted esta aquiriendo un prestamo por {0} meses, pagando una cuota mensual de {1}.", getPlazoTiempo(),getCuotasMensuales());
        }
    }    

    public void devolver()
    {
        if (getPlazoTiempo().Equals(0))
        {
            Console.WriteLine("Usted ha cumplido con lo acordado para devolver el prestamo.");
        }
    }

}

class ContratoTester
{
     static void Main()
     {
         Console.Clear();
         Contrato contrato1 = new Contrato();
        int valorPlazoTiempo;
        float valorCuotasMensuales;

        Console.WriteLine("Datos para el contrato: \n");
        Console.WriteLine("\nPlazo de Tiempo: ");
        valorPlazoTiempo = int.Parse(Console.ReadLine());
        Console.WriteLine("\nCuotas Mensuales: ");
        valorCuotasMensuales = float.Parse(Console.ReadLine());

        contrato1.setPlazoTiempo(valorPlazoTiempo);
        contrato1.setCuotasMensuales(valorCuotasMensuales);
        contrato1.aquirimos();
        contrato1.devolver();

        

     }
}