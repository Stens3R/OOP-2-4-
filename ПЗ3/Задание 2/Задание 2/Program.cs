//Абстрактная фабрика
Car tesla = new Car(new TeslaFactory());
tesla.vroom();
tesla.info();
Car vaz = new Car(new VazFactory());
vaz.vroom();
vaz.info();
//abstract product
abstract class Enjine
{
    public abstract void give_power();
}
abstract class Description
{
    public abstract void description();
}
// products
class TeslaEnjine : Enjine
{
    public override void give_power()
    {
        Console.WriteLine("Много");
    }
}
class VazEnjine : Enjine
{
    public override void give_power()
    {
        Console.WriteLine("Чуть меньше чем много");
    }
}
class TeslaDescription : Description
{
    public override void description()
    {
        Console.WriteLine("Куда выбрасывать батареи через 10 лет?");
    }
}
class VazDescription : Description
{
    public override void description()
    {
        Console.WriteLine("Нестареющая классика");
    }
}
//abstract factory
abstract class Factory
{
    public abstract Enjine CreateEnjine();
    public abstract Description CreateDescription();
}
//factories
class TeslaFactory : Factory
{
    public override Enjine CreateEnjine()
    {
        return new TeslaEnjine();
    }
    public override Description CreateDescription()
    {
        return new TeslaDescription();
    }
}
class VazFactory : Factory
{
    public override Enjine CreateEnjine()
    {
        return new VazEnjine();
    }
    public override Description CreateDescription()
    {
        return new VazDescription();
    }
}
//client
class Car
{
    private Enjine? enjine;
    private Description? description;
    public Car(Factory factory)
    {
        enjine = factory.CreateEnjine();
        description = factory.CreateDescription();
    }
    public void vroom()
    {
        enjine?.give_power();
    }
    public void info()
    {
        description?.description();
    }
}