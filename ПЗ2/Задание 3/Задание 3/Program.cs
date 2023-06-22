using System.Runtime.CompilerServices;
using Задание_3;

Class_cycle cycle = new Class_cycle();
Class_counter counter = new Class_counter();
Class_counter counter2 = new Class_counter();

Class_counter.OnIncrement += () => cycle.new_iteration(() => Console.WriteLine($"Произошла итерация: {cycle.iter}"));

counter.increment();
counter2.increment();
counter2.increment();
counter.increment();
counter.increment();
counter.increment();