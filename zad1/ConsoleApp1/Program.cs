Point point1 = new Point();
Point point2 = new Point();
point1.x = 1;
point1.y = 2;
point2 = point1; // point2.y=2,point1.x=1
point1.x = 3;
point1.y = 3;
Console.WriteLine(point1.x);
Console.WriteLine(point1.y);
Console.WriteLine(point2.y);
Console.WriteLine(point2.x);
//так как структура это значимый тип то он храниться в стеке и когда мы копируем одну структуру в другую то копируются и её поля
PointClass pointClass1 = new PointClass();
PointClass pointClass2 = new PointClass();
pointClass2.x = 3;
pointClass2.y = 4;
pointClass1=pointClass2;// 1.x=3 1.y =4
pointClass2.x = 1;
pointClass2.y = 2;
Console.WriteLine(pointClass1.x);
Console.WriteLine(pointClass1.y);
Console.WriteLine(pointClass2.x);
Console.WriteLine(pointClass2.y);
// так как класс ссылочный тип и его ссылка храниться в стеке а само значение получаем через ссылку в куче
// то из-за того что pointclass1 и pointсlass2 ссылаются на одну область памяти в куче то при копировании значения из второго класса в первый и потом изменения значений у второго, значения поменяются и у первого класса
// это будет происходить даже в том случае если ссылочный тип является переменной в значимом типе, то есть если класс будет внутри структуры, всё равно в стеке при создании структуры будет ссылка на кучу


struct Point
{
    public int x;
    public int y;
}

class PointClass
{
    public int x;
    public int y;
}
