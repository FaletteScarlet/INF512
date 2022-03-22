using System;
//Clase de implementación y encapsulación
public class Mouse
{
    private string marca;
    private string modelo;
    private string tipo;   //tipos: Normal o Ergonomico.
    private string color; //Colores permitidos: Rojo, Verde, Azul.
    private bool ergonomico;
    private float precio;

    public bool seleccionar(string bloqueTexto)
    {
        return true;
    }

    public bool clickDerecho()
    {
        Console.WriteLine("El usuario ha hecho un click derecho");
        return true;
    }

    public bool clickIzquierdo()
    {
        Console.WriteLine("El usuario ha hecho un click izquierdo");
        return true;
    }

    public string arrastrar(string bloqueTexto)
    {
        return "";
    }

    public void setMarca(string marca)
    {
        marca = marca.ToUpper();
        if (marca.Equals("DELL") || marca.Equals("GENIUS") || marca.Equals("LOGITEC"))
        {
            this.marca = marca;
        }
        else
        {
            this.marca = "GENERIC DEVICE";
        }
    }

    public string getMarca()
    {
        return this.marca;
    }

    public void setModelo(string modelo)
    {
        modelo = modelo.ToUpper();
        if (!modelo.Equals(""))
        {
            modelo = modelo.ToUpper();
            this.modelo = modelo;
        }
        else
        {
            Console.WriteLine("Error 4. Modelo Invalido.");
            this.modelo = null;
        }
    }

    public string getModelo()
    {
        return this.modelo;
    }

    public void setTipo(string tipo)
    {
        tipo = tipo.ToUpper();
        if (tipo.Equals("NORMAL") || tipo.Equals("ERGONOMICO"))
        {
            this.tipo = tipo;
        }
        else
        {
           Console.WriteLine("Error 3. Tipo Invalido.");
            Console.WriteLine("Tipos permitidos: Normal o Ergonomico"); 
            this.tipo = null;
        }
    }

    public string getTipo()
    {
        return this.tipo;
    }


    public void setPrecio(float precio)
    {
        if (precio >= 0.0 && precio <=50.0)
        {
            this.precio = precio;
        }
         else 
        {
            this.precio = 0.0f;
            Console.WriteLine("Error 1. Precio Invalido.");
        }
    }


    public float getPrecio()
    {
        return this.precio;
    }

    public string getColor()
    {
        return this.color;
    }

    public void setColor(string color)
    {
        color = color.ToUpper();
        if (color.Equals("ROJO") || color.Equals("VERDE") || color.Equals("AZUL"))
        {
            this.color = color;
        } 
        else 
        {
            Console.WriteLine("Error 2. Color Invalido.");
            Console.WriteLine("Colores permitidos: ROJO, VERDE, AZUL.");
            Console.WriteLine("Debe corregir color: " + color);
            this.color = null;
        }
    }

    public void setErgonomico()
    {
        if (this.tipo.Equals("ERGONOMICO"))
        {
            ergonomico=true;
        }
        else
        {
            ergonomico = false;
            
        }
    }

    public bool getErgonomico()
    {
        return this.ergonomico;
    }

    public void desplegarInformacion()
    {
        Console.WriteLine("\nDatos Registrados\n");
        Console.WriteLine("Marca: " + getMarca());
        Console.WriteLine("\nModelo: " + getModelo());
        Console.WriteLine("\nTipo: " + getTipo());
        Console.WriteLine("\nColor: " + getColor());
        if (getErgonomico())
        {
            Console.WriteLine("\nErgonomico: Si");
        }
        else
        {
            Console.WriteLine("\nErgonomico: No");
        }
        Console.WriteLine("\nPrecio: " + getPrecio());

    }
}

public class MouseTest
{
    static void Main()
    {
        
        Console.Clear();
        string valorMarca, valorModelo, valorColor, valorTipo;
        float valorPrecio;
        Mouse objeto1 = new Mouse();

        Console.WriteLine("Registrar datos del Mouse:\n");
        Console.WriteLine("Registar Marca: ");
        valorMarca = Console.ReadLine();
        Console.WriteLine("Registrar Modelo: ");
        valorModelo = Console.ReadLine();
        Console.WriteLine("Registrar Tipo Normal/Ergonomico: ");
        valorTipo = Console.ReadLine();
        Console.WriteLine("Registrar Color Azul/Verde/Rojo: ");
        valorColor = Console.ReadLine();
        Console.WriteLine("Registrar Precio: ");
        valorPrecio = float.Parse(Console.ReadLine());

        objeto1.setMarca(valorMarca);
        objeto1.setModelo(valorModelo);
        objeto1.setTipo(valorTipo);
        objeto1.setColor(valorColor);
        objeto1.setErgonomico();
        objeto1.setPrecio(valorPrecio);

        objeto1.desplegarInformacion();
    }
}