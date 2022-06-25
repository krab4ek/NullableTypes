Console.WriteLine("****** Fun with Nullable data*****");
#region 1 code
DataBaseReader reader = new DataBaseReader();
//reader.numericValue = 90;
int? i = reader.GetIntFromDataBase();
if (i.HasValue)
{
    Console.WriteLine($"Value of 'i' is: {i.Value}");
}
else
{
    Console.WriteLine("Value of 'i' is undefined.");
}
bool? b = reader.GetBoolFromDataBase();
if (b != null)
{
    Console.WriteLine($"Value of 'b' is: {b.Value}");
}
else
{
    Console.WriteLine("Value of 'b' is undefined.");
}
#endregion 1

#region 2 code
DataBaseReader dr = new DataBaseReader();
//Если значение, возвращемое из GetIntFromDatabase(), равно null,
//то присвоить локальной перменной значение 100
var myData = dr.GetIntFromDataBase() ?? 100;
//int? myData = dr.GetIntFromDataBase();
//if (!myData.HasValue)
//    myData = 0;
Console.WriteLine($"Value of myData: {myData}");



#endregion

Console.ReadLine();

static void TesterMethodOld(string[] args)
{
    //Перед доступом к данным массива мы должны проверить его на равенство null
    if (args == null)
    {
        Console.WriteLine($"You sent me {args.Length} arguments");
    }
}

static void TesterMethodNew(string[] args)
{
    //Условный оператор не применяется, если args окажется null,
    //тогда обращение к свойству Lenght не приведет к ошибке во время выполнения.
    //?? задает значение по умолчанию, в данном случае 0
    Console.WriteLine($"You sent me {args?.Length ?? 0} arguments");
}
class DataBaseReader
{
    public int? numericValue = null;
    public bool? boolValue = true;
    public int? GetIntFromDataBase() => numericValue;
    public bool? GetBoolFromDataBase() => boolValue;
}

//static void LocalNullableVariablesUsingNullable()
//{
//    Nullable<int> nullableInt = 10;
//    Nullable<double> nullableDouble = 3.14;
//    Nullable<bool> nullableBoolean = null;
//    Nullable<char> nullableChar = 'a';
//    Nullable<int>[] arrayOfNullableInts = new int?[10];

//}

//static void LocalNullableVariables()
//{
//    //Определить несколько локальных переменных, допускающих null
//    int? nullableInt = 10;
//    double? nullableDouble = 3.14;
//    bool? nullableBoolean = null;
//    char? nullableChar = 'a';
//    int?[] arrayOfNullableInts = new int?[10];

//}
