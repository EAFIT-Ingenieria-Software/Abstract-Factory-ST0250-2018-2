public class Client
{
    private Sedan _productA;
    private Campero _productB;
 /*El constructor del cliente recibe una fabrica abstracta como parametro
 para instanciar los productos abstractos o las familias 
 El parametro factory decidira si la familia sera de vehiculo personal o publico*/
    public Client(Vehiculo factory)
    {
        _productA = factory.CrearProductoA();
        _productB = factory.CrearProductoB();
    }
}
 
 /*En la fabrica abstracta vehiculo se llaman a los metodos de crearProductos
 para crear los productos concretos 
 En este caso por cada familia(VehiculoPublico o VehiculoPersonal) habra un sedan y un campero
 es decir, un productoA y un producto B*/
public abstract class Vehiculo
{
    public abstract Sedan CrearProductoA();
 
    public abstract Campero CrearProductoB();
}
 
 /*Esta es la primera fabrica concreta
   que hereda de vehiculos: VehiculoPersonal
   la cual instancia un vehiculoPersonal sedan y otro campero
   Estos vehiculos instanciados son los productos concretos
  */
public class VehiculoPersonal : Vehiculo
{
    public override Sedan CrearProductoA()
    {
        return new FordSedan();
    }
 
    public override Campero CrearProductoB()
    {
        return new MazdaCampero();
    }
}
 

 /*Esta es la segunda fabrica concreta
   que hereda de vehiculos: VehiculoPublico
   la cual instancia un vehiculoPersonal sedan y otro campero
   Estos vehiculos instanciados son los productos concretos
  */
public class VehiculoPublico : Vehiculo
{
    public override Sedan CrearProductoA()
    {
        return new ChevroletSedan();
    }
 
    public override Campero CrearProductoB()
    {
        return new JeepCampero();
    }
}
 
 /*Clase del producto abstracto Sedan */
public abstract class Sedan { }
 /*Clases de los productos concretos que heredan de Sedan */
public class FordSedan : Sedan { }
 
public class ChevroletSedan : Sedan { }

  /*Clase del producto abstracto CamperocLi */
public abstract class Campero { }
  /*Clases de los productos concretos que heredan de Campero */
public class MazdaCampero : Campero { }
 
public class JeepCampero : Campero { }