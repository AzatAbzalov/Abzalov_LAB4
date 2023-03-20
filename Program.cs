DArray a = new();
Console.WriteLine(a);
Console.WriteLine("Выделенная память = " + a.Capacity);
Console.WriteLine("Размер массива = " + a.Size);

DArray b = new(5);
Console.WriteLine(b);
Console.WriteLine("Выделенная память = " + b.Capacity);
Console.WriteLine("Размер массива = " + b.Size);

DArray c = new(new double[] { 8, -4, 2.12, -6.7, -20 });
Console.WriteLine("Массив: " + c);
Console.WriteLine("Выделенная память = " + c.Capacity);
Console.WriteLine("Размер массива = " + c.Size);

int ind = 1;
Console.WriteLine($"Элемент массива C с индексом {ind} = " + c.ReadElem(1));
c.WriteElem(ind,100.3);
Console.WriteLine($"Массив С с измененным элементом по индексу {ind}: " + c);

double elem = 0;
c.AddElemEnd(elem);
Console.WriteLine("Массив: " + c);
Console.WriteLine("Выделенная память = " + c.Capacity);
Console.WriteLine("Размер массива = " + c.Size);

c.RemoveElemEnd();
Console.WriteLine("Массив: " + c);
Console.WriteLine("Выделенная память = " + c.Capacity);
Console.WriteLine("Размер массива = " + c.Size);

c.RemoveElemEnd();
Console.WriteLine("Массив: " + c);
Console.WriteLine("Выделенная память = " + c.Capacity);
Console.WriteLine("Размер массива = " + c.Size);

c.AddInd(20, 2);
Console.WriteLine("Массив: " + c);
Console.WriteLine("Выделенная память = " + c.Capacity);
Console.WriteLine("Размер массива = " + c.Size);

c.RemoveInd(2);
Console.WriteLine("Массив: " + c);
Console.WriteLine("Выделенная память = " + c.Capacity);
Console.WriteLine("Размер массива = " + c.Size);

Console.WriteLine("Индекс макс элемента = " + c.MaxInd());