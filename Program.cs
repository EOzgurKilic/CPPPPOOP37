namespace CPPPPOOP37;

class Program
{
    static void Main(string[] args)
    {
        MyRecordStruct MyRecStructObj1 = new MyRecordStruct() {Prop1 = 10 , Prop2 = 20 };
        MyRecordStruct MyRecStructObj2 = new MyRecordStruct() {Prop1 = 10 , Prop2 = 20 };
        if (MyRecStructObj1 == MyRecStructObj2) //It does not show an error for if-equal operator.
        {
            Console.WriteLine("They are equal");
        }
        MyRecStructObj1.Prop1 = 10;
        //Whereas
        MyNormalStruct MyNormalStructObj1 = new MyNormalStruct() {Prop1 = 10, Prop2 = 20 };
        MyNormalStruct MyNormalStructObj2 = new MyNormalStruct() {Prop1 = 10, Prop2 = 20 };
        /*if (MyNormalStructObj1 == MyNormalStructObj2) //It shows an error for if-equal operator.
        {
            Console.WriteLine("They are equal");
        }*/

        if (MyNormalStructObj1.Equals(MyNormalStructObj2))
        {
            Console.WriteLine("They are equal");
        }


        //With Usage
        MyRecordStruct MyRecordStructObj3 = new MyRecordStruct() {Prop1 = 10, Prop2 = 20 };
        MyRecordStruct MyRecordStructObj4 = MyRecordStructObj3 with {Y = 1};
        Console.WriteLine(MyRecordStructObj4.ToString());
        
        
        
        //Another feature being record brings along (This feature is valid for records too) is to convert a whole struct into a string
        Console.WriteLine(MyRecStructObj1.ToString() +" "+ MyRecStructObj2.ToString());
    }


    //Record Structs
    //Their fields, properties, and parameters coming along with the positional aspect are not init in default unlike records. You can qualify them with readonly in order to make them unchangeable.
    //Equals method is available and utilizable as intended for structs unlike classes.
    //In addition to that method, operators of "==" and "!=" are available for record structs whereas normal ones throw an error. 
    record struct MyRecordStruct(int X, int Y) //Record Structs supports with keyword usage like in positional records.
    //Positional structs can't have a constructor as well as positional records can't do.
    {
        public int Prop1 { get; set; }    
        public int Prop2 { get; set; }
    }

    struct MyNormalStruct
    {
        public int Prop1 { get; set; }
        public int Prop2 { get; set; }
    }
}