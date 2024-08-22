// See https://aka.ms/new-console-template for more information
using AbstractFactory.Classes.Factory;
using AbstractFactory.Classes.Provider;
using AbstractFactory.Interfaces;
using Adapter;
using Bridge;
using Bridge.BridgeImplementation;
using Bridge.UsingOfBridge;
using BuilderPattern;
using CompositDesignPatter;
using FactoryDesignPattern.Enum;
using FactoryDesignPattern.Factory;
using FactoryDesignPattern.Interface;
using PrototypeDesignPattern;
using PrototypeDesignPattern.Excel;
using SingletonDesignPattern;
using static BuilderPattern.User;

#region Creational Design Pattern
#region Abstract Factory
//Country country = Country.ENDGLAND;
//ILanguage lang = InternationalProvider.CreateLanguage(country);

//ICapitalCity capital = InternationalProvider.CreateCapitalCity(country);

//lang.Greeting();

//Console.WriteLine($"total population {capital.GetPopulation()}");
#endregion

#region Builder
//User user = 
//    new UserBuilder()
//    .SetName("yeswanth")
//    .SetAge(33)
//    .SetAddress("Ramky one")
//    .Build();
//Console.WriteLine($"Name: {user.Name} \r\n Address: {user.Address}, \r\n Age:{user.Age}");
#endregion

#region Factory
//IPayements paymentMethod = PaymentFactory.Create(PaymentMethod.Gpay);
//paymentMethod.Payment(20000);
#endregion

#region Prototype
//Teacher teacher = new Teacher("Yeswanth","C# Basics to Advance");
//Teacher teacherClone = (Teacher)teacher.Clone();

//Console.WriteLine($"Teacher Cloned {teacherClone.Name} who teached {teacherClone.Cource}");

//Student student = new Student("Sai", teacherClone);

//Student studentClone = (Student)student.Clone();

//Console.WriteLine($"student name : {studentClone.Name} Teacher Cloned {studentClone.Teacher.Name} who teached {studentClone.Teacher.Cource}");

//teacherClone.Name = "sam";
//Console.WriteLine($"student name : {studentClone.Name} Teacher Cloned {studentClone.Teacher.Name} who teached {studentClone.Teacher.Cource}");


//IBlock block = BlockFactory.Create("02/08/1991");
//Console.WriteLine(block.render);
//Type blocktype = block.GetType();
//if(typeof(DatetimeBlock) == blocktype)
//{
//    DatetimeBlock cloneblock =  (DatetimeBlock)block.clone();
//    cloneblock.Format = "MM/dd/yyy";
//    Console.WriteLine(cloneblock.render);
//}

#endregion

#region Singletone
//Singletone basesingletone1 = ThreadSafeSingletoneLogger.GetInstance();
//Singletone basesingletone2 = ThreadSafeSingletoneLogger.GetInstance();
//if(basesingletone1 == basesingletone2)
//{
//    basesingletone1.Log(new Exception("Thread safe.."));
//}
#endregion

#endregion
#region Structoral Design Pattern
#region Adaptor
//var xml = @"<note>
//                       <to>Tove</to>
//                       <from>Jani</from>
//                       <heading>Reminder</heading>
//                       <body>Don't forget me this weekend!</body>
//                    </note>";

//IJsonParser<Note> parser = new XmlToJsonAdaptor<Note>();

//// Parse XML to Note object
//Note note = parser.Parse(xml);
//Console.WriteLine(note);

//// Convert Note object back to XML
//string xmlOutput = parser.ConvertToJson(note);
//Console.WriteLine(xmlOutput);
#endregion
#region Bridge
//CarInsurance carInsurance = new ThirdParty(2009,"Discover","Land Rover",new NoClaimsDiscount());
//CarInsurance carInsurance2 = new ThirdParty(2019, "Discover", "Land Rover", new AutoOwnerDiscount());

//Console.WriteLine(carInsurance.CalculatePremium());
//Console.WriteLine(carInsurance2.CalculatePremium());
#endregion

#region Composite Design Pattern
GitComponent maincomponent=new Branch("main");
GitComponent commit1 = new Commit("123456");
GitComponent commit2 = new Commit("123458");
GitComponent commit3 = new Commit("123410");
GitComponent commitignore = new Commit("123410_ignore");
maincomponent.Add(commit1);
maincomponent.Add(commit2);
maincomponent.Add(commit3);
maincomponent.Remove(commitignore);

GitComponent smallcomponent = new Branch("small");
GitComponent smallcommit1 = new Commit("123456_small");
smallcomponent.Add(smallcommit1);

GitComponent Bigcomponent = new Branch("big");
GitComponent Bigcommit1 = new Commit("123456_Big");
GitComponent Bigcommit2 = new Commit("123446_Big");
GitComponent Bigcommit3 = new Commit("123436_Big");
GitComponent Bigcommit4 = new Commit("123426_Big");
Bigcomponent.Add(Bigcommit1);
Bigcomponent.Add(Bigcommit2);
Bigcomponent.Add(Bigcommit3);
Bigcomponent.Add(Bigcommit4);

maincomponent.Add(smallcomponent);
maincomponent.Add(Bigcomponent);


maincomponent.ShowDetails();
#endregion
#endregion