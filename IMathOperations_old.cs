//TODO: Task 1: Use Generics to rewrite below interface
//TODO: Task 2: Rewrite the Interface using Interface Segregation
//TODO: Task 3: Using implicit and explicit interface-implementation to create a new class that implements the segregated interfaces.
public interface IMathOperations_old
{
	int Sum(int a, int b);
	int Sum2(int a, int b, int c);
	int Sum3(int a, int b, int c, int d);
	int Subtract(int a, int b);
	double Subtract(double a, double b);
	decimal Subtract(decimal a, decimal b);
	int Divide(int a, int b);
	double Multiply(double a, double b);
}
