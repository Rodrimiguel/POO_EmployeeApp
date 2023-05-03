// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Elabore una aplicación con una clase empleado (Nombre, apellido, cargo, CUIL, cantidad de hijos a 
cargo y años de antigüedad).
Un método LiquidarSueldo que mostrará en pantalla la liquidación, que contendrá: el nombre completo,
 el CUIL y el sueldo a percibir.
Se sabe que en la empresa hay cinco cargos que perciben un sueldo básico diferente: Asistente 
($ 100000), Operador ($ 150000), Ejecutivo de cuenta ($200000), Gerente ($500000) y Director ejecutivo 
($900000)
Se sabe asimismo que los empleados tienen derecho a percibir un importe de $10000 como asignación
 familiar por hijo a cargo,
y el 7% más de su sueldo básico por año de antigüedad.
Ingrese varios empleados y calcule su sueldo.

*/
var empleado1 = new Empleado("David", "Ronalson");
// empleado1.Apellido = "Ronalson";
// empleado1.Nombre = "David";
empleado1.Cuil = "34-1078967-00";
empleado1.Hijos = 2;
empleado1.Antigüedad = 5;
empleado1.Cargo = Empleado.TipoCargo.Director;
empleado1.LiquidarSueldo(); // void, no me devuelve nada, no tengo que pasar ningún parametro


var empleado2 = new Empleado("Brain", "Thompson");
// empleado2.Apellido = "Ronalson";
// empleado2.Nombre = "David";
empleado2.Cuil = "34-2078967-00";
empleado2.Hijos = 2;
empleado2.Antigüedad = 10;
empleado2.Cargo = Empleado.TipoCargo.Ejecutivo;
empleado2.LiquidarSueldo(); // void, no me devuelve nada, no tengo que pasar ningún parametro


var empleado3 = new Empleado("Marina", "Brierson");
// empleado2.Apellido = "Ronalson";
// empleado2.Nombre = "David";
// empleado3.Cuil = "34-2078967-00";
// empleado3.Hijos = 1;
// empleado3.Antigüedad = 15;
// empleado3.Cargo = Empleado.TipoCargo.Operador;
empleado3.LiquidarSueldo(); // void, no me devuelve nada, no tengo que pasar ningún parametro

public class Empleado
{

    public Empleado()
    {

    }

    public Empleado(string nombre, string apellido)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
    }

    public string Nombre { get; set; }

    public string Apellido { get; set; }

    public string Cuil { get; set; }

    public int Hijos { get; set; }

    public int Antigüedad { get; set; }


    public TipoCargo Cargo { get; set; } // a la propiedad Cargo le asignamos el tipo cargo.
    public enum TipoCargo
    { // enumeración con los tipos posibles (definion de cargos : 5)

        Asistente = 100000,
        Operador = 150000,
        Ejecutivo = 200000,
        Gerente = 500000,
        Director = 900000,

    }

    public void LiquidarSueldo()
    {
        double sueldobasico = (double)this.Cargo;
        /*
        switch(this.Cargo){
            case TipoCargo.Asistente:
            sueldobasico=100000;
            break;
            case TipoCargo.Operador:
            sueldobasico=150000;
            break;
            case TipoCargo.Ejecutivo:
            sueldobasico=200000;
            break;
            case TipoCargo.Gerente: 
            sueldobasico=500000;
            break;
            case TipoCargo.Director: 
            sueldobasico=900000;
            break;
            
        }
        */
        //  var sueldo=SueldoBasico + (Hijos * 100) + (Antiguedad * 50) ; example
        sueldobasico += (10000 * this.Hijos) + ((sueldobasico * 0.07) * this.Antigüedad);
        // sueldobasico = sueldobasico + (10000 * this.Hijos);
        // sueldobasico+= 1.07 * this.Antigüedad;

        Console.WriteLine($"Name: {this.Nombre} LastName: {this.Apellido} Cuil:{this.Cuil} Sueldo:{sueldobasico}");
        // this hace referencia a la misma clase desde donde lo estoy llamando.


    }

}





