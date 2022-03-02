ArithProgression arith = new ArithProgression();
Console.WriteLine("Арифметическая прогрессия");
arith.setStart(10);
arith.setStep(10);
Console.WriteLine(arith.getNext());
Console.WriteLine(arith.getNext());
Console.WriteLine(arith.getNext());
Console.WriteLine(arith.getNext());
arith.reset();
Console.WriteLine(arith.getNext());
Console.WriteLine(arith.getNext());
Console.WriteLine("Геометрическая прогрессия");
GeomProgression geom = new GeomProgression();
geom.setStart(5);
geom.setStep(2);
Console.WriteLine(geom.getNext());
Console.WriteLine(geom.getNext());
Console.WriteLine(geom.getNext());
Console.WriteLine(geom.getNext());
geom.reset();
Console.WriteLine(geom.getNext());
Console.WriteLine(geom.getNext());
interface ISeries
{
    void setStart(int x);//устанавливает начальное значение
    int getNext();//возвращает следующее число ряда
    void reset();//выполняет сброс к начальному значению
   
}
class ArithProgression : ISeries
{
    int step;
    int startValue;
    int currentValue;
    public int getNext()
    {
        currentValue+=step;
        return currentValue; 

    }

    public void reset()
    {
        currentValue = startValue;
    }

    public void setStart(int x)
    {
        startValue = x;
        currentValue = startValue;
    }
    public void setStep(int s)
    {
        step = s;
    }
}
class GeomProgression : ISeries
{
    int step;
    int startValue;
    int currentValue;
    public int getNext()
    {
        currentValue *= step;
        return currentValue;
    }

    public void reset()
    {
        currentValue = startValue;
    }

    public void setStart(int x)
    {
        startValue = x;
        currentValue = startValue;
    }
    public void setStep(int s)
    {
        step = s;
    }
}