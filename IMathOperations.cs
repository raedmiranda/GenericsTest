//Task 1: using generic type T
//Task 2: segregating many different interfaces

// public interface IMathOperations_old
// {
// 	int Sum(int a, int b);
// 	int Sum2(int a, int b, int c);
// 	int Sum3(int a, int b, int c, int d);
// 	int Subtract(int a, int b);
// 	double Subtract(double a, double b);
// 	decimal Subtract(decimal a, decimal b);
// 	int Divide(int a, int b);
// 	double Multiply(double a, double b);
// }

using System;
using System.Collections.Generic;
using System.Linq;

public interface ISum<T>
{
    T Sum(params T[] numbers);
    //or
    int Sum(params int[] numbers);

    // int Sum(int a, int b);
    // int Sum2(int a, int b, int c);
    // int Sum3(int a, int b, int c, int d);
}

public interface ISubstract<T>
{
    T Subtract(T a, T b);
    //int Subtract(int a, int b);
    //double Subtract(double a, double b);
    //decimal Subtract(decimal a, decimal b);
}

public interface IMultiply<T>
{
    T Multiply(T a, T b);
}

public interface IDivide<Y, T>
{
    Y Divide(T a, T b);
}

//Task 3: implicit and explicit interface-implementation
public class Calculator : ISum<int>, ISubstract<int>, IMultiply<int>, IDivide<decimal, int>
{
    //implicit implementation
    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Sum(params int[] numbers)
    {
        return new List<int>(numbers).Sum();
    }

    //explicit implementation
    decimal IDivide<decimal, int>.Divide(int a, int b)
    {
        decimal result = a / b;
        return Math.Round(result);
    }

    int ISubstract<int>.Subtract(int a, int b)
    {
        return a - b;
    }
}