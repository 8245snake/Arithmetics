# Arithmetics
文字列の計算式を計算するライブラリ

## Sample

```c#

 using (Calculator calculator = new Calculator())
 {
     Console.WriteLine(calculator.Calculate("1 + 2 - 1 * (1 + 2)")); // ⇒ 0
     Console.WriteLine(calculator.Calculate("(1+2)/(3+7)"));         // ⇒ 0.3
     Console.WriteLine(calculator.Calculate("pow(2,3)"));            // ⇒ 8
     Console.WriteLine(calculator.Calculate("sin(90)"));             // ⇒ 0.893996663600558
     Console.WriteLine(calculator.Calculate("cos(90)"));             // ⇒ -0.44807361612917
     Console.WriteLine(calculator.Calculate("tan(90)"));             // ⇒ -1.99520041220824
     Console.WriteLine(calculator.Calculate("log(90)"));             // ⇒ 4.49980967033027
     Console.WriteLine(calculator.Calculate("log10(90)"));           // ⇒ 1.95424250943932
     Console.WriteLine(calculator.Calculate("max(1,2)"));            // ⇒ 2
     Console.WriteLine(calculator.Calculate("exp(-1)"));             // ⇒ 0.367879441171442
 }

```

## Note

Powershellのdllを使用
