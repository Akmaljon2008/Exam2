 int a = 5;
 double b = Convert.ToDouble(a);
 double e = Convert.ToDouble(d);

 float c = a;
 int d = 3;


var m = new Math();
System.Console.WriteLine(m.Absd(b));
System.Console.WriteLine(m.Absf(c));
System.Console.WriteLine(m.Absi(a));
System.Console.WriteLine(m.Pow(b,e));
System.Console.WriteLine(m.Sqrt(a));
System.Console.WriteLine(m.Max(a,d));
System.Console.WriteLine(m.Min(a,d));
public class Math{
const double PI = 3.14;
const double E = 2.71;



public double Absd(double value){
    if (value < 0){
        return value * -1;
    }
    else return value;
}
public float Absf(float value){
    if (value < 0){
        return value * -1;
    }
    else return value;
}

public int Absi(int value){
    if (value < 0){
        return value * -1;
    }
    else return value;
}
public double Pow(double x, double y){
    double pow = 0;
    for (int i = 0; i < y; i++)
    {
        pow += x*x;
    }
    return pow;
}
// public double Sqrt(double d){
//     return System.Math.Pow(d);
// }
public int Max(int val1, int val2){
    int max = 0;
    if(val1 > val2)max = val1;
    else max = val2;
    return max;

}
public int Min(int val1, int val2){
    int min = 0;
    if(val1 < val2)min = val1;
    else min = val2;
    return min;
}

}