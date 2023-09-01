//Un vendedor recibe un sueldo base más un 10% extra por comisión de sus ventas, el vendedor desea
//saber cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el
//mes y el total que recibirá en el mes tomando en cuenta su sueldo base y comisiones.
//DONE


// 1 clase y motodo

public class Comision
{
    static void Main(string[] Args)
    {
        //2 declaracion de variables

        double sueldoBase, venta1, venta2, venta3, sueldoTotal, comisionTotal;

        // 3 recolectar los datos

        Console.Write("Escriba su sueldo base: ");
        sueldoBase = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Cual fue su primera venta: ");
        venta1 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Cual fue su segunda venta: ");
        venta2 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Cual fue su tercera venta: ");
        venta3 = Convert.ToDouble(Console.ReadLine());

        // 4 realizar los calculos}

        comisionTotal = ((venta1 + venta2 + venta3) * 0.1);
        sueldoTotal = comisionTotal + sueldoBase;

        // Mostar resultados en pantalla

        Console.WriteLine("el concepto por comision es: " + comisionTotal);
        Console.WriteLine("Neto a pagar por este mes es: " + sueldoTotal);

    }
}