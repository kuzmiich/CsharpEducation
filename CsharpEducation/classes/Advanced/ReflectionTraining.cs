using static ClassLibrary.EmployedEducationalClases.DataAnalyzer;
using Education.interfaces;
using System;
using System.Reflection;

namespace Education.classes.Advanced
{
    class ReflectionTraining : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine("---- Изучение класса System.Reflection ----\n" +
                "1.Assembly: класс, представляющий сборку и позволяющий манипулировать этой сборкой\n" +
                "AssemblyName: класс, хранящий информацию о сборке\n" +
                "MemberInfo: базовый абстрактный класс, определяющий общий функционал для классов EventInfo, FieldInfo, MethodInfo и PropertyInfo\n" +
                "EventInfo: класс, хранящий информацию о событии\n" +
                "FieldInfo: хранит информацию об определенном поле типа\n" +
                "MethodInfo: хранит информацию об определенном методе\n" +
                "PropertyInfo: хранит информацию о свойстве\n" +
                "ConstructorInfo: класс, представляющий конструктор\n" + 
                "Module: класс, позволяющий получить доступ к определенному модулю внутри сборки\n" +
                "ParameterInfo: класс, хранящий информацию о параметре метода\n" +
                "2.Получение членов типа System.Type:\n" +
                "Метод FindMembers() возвращает массив объектов MemberInfo данного типа" +
                "Метод GetConstructors() возвращает все конструкторы данного типа в виде набора объектов ConstructorInfo\n" +
                "Метод GetEvents() возвращает все события данного типа в виде массива объектов EventInfo\n" +
                "Метод GetFields() возвращает все поля данного типа в виде массива объектов FieldInfo\n" +
                "Метод GetInterfaces() получает все реализуемые данным типом интерфейсы в виде массива объектов Type\n" +
                "Метод GetMembers() - возвращает все члены типа в виде массива объектов MemberInfo\n" +
                "Метод GetMethods() - получает все методы типа в виде массива объектов MethodInfo\n" +
                "Метод GetProperties() - получает все свойства в виде массива объектов PropertyInfo\n" +
                "Свойство Name - возвращает имя типа\n" +
                "Свойство Assembly - возвращает название сборки, где определен тип\n" +
                "Свойство Namespace - возвращает название пространства имен, где определен тип\n" +
                "Свойство IsClass - возвращает true, если тип представляет класс\n" +
                "Свойство IsEnum - возвращает true, если тип является перечислением\n" +
                "Свойство IsInterface - возвращает true, если тип представляет интерфейс\n");

            // 1
            string filePath = @"./ClassLibrary.dll";
            Assembly assembly = Assembly.LoadFrom(filePath);
            Type asmType = assembly.GetType();
            Console.WriteLine("Основная информация об экземпляре assembly");
            Console.WriteLine("-------Свойства:");
            Console.WriteLine($"Полное имя - {assembly.FullName}");
            Console.WriteLine($"Расположение - {assembly.Location}");
            Console.WriteLine($"Версия среды выполнения изображения - {assembly.ImageRuntimeVersion}");
            Console.WriteLine($"Модули - {assembly.Modules}");
            Console.WriteLine($"Информация о хосте - {assembly.HostContext}");
            Console.WriteLine("-------Методы:");
            Console.WriteLine($"Получить имя - {assembly.GetName()}");
            Console.WriteLine($"Получить массив типов - {assembly.GetTypes()}");
            Console.WriteLine($"Получить дефолтные атрибуты - {assembly.GetCustomAttributes()}");
            Console.WriteLine($"Находит тип в этой сборке и создает его экземпляр, используя абстрактный метод - {assembly.CreateInstance("Phone")}");
            Console.WriteLine($"Возвращает объект FileStream для указанного файла из таблицы файлов манифеста данной сборки - {assembly.GetFile(filePath)}\n");
            //GetTypeInfo(asmType);

            // 2
            Type type = Type.GetType("ClassLibrary.EmployedEducationalClases.DataAnalyzer, ClassLibrary", false, true);
            Console.WriteLine("Информация о классе DataAnalyzer из ClassLibrary");
            GetTypeInfo(type);
        }
        private static void GetTypeInfo(Type type)
        {

            Console.WriteLine("Участники типа:");
            foreach (MemberInfo memberInfo in type.GetMembers())
            {
                Console.WriteLine($"{memberInfo.MemberType} {memberInfo.Name}");
            }

            Console.WriteLine("Методы:");
            MethodInfo[] methods = type.GetMethods(BindingFlags.DeclaredOnly |
                BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            foreach (MethodInfo method in methods)
            {
                Console.Write($"{method.ReturnType.Name} {method.Name} (");

                ParameterInfo[] parameters = method.GetParameters();
                GetParameterInfo(parameters);
            }

            Console.WriteLine("Конструкторы:");
            foreach (ConstructorInfo ctor in type.GetConstructors())
            {
                ParameterInfo[] parameters = ctor.GetParameters();
                GetParameterInfo(parameters);
            }

            Console.WriteLine("Поля:");
            foreach (FieldInfo field in type.GetFields())
            {
                Console.WriteLine($"{field.DeclaringType} {field.FieldType} {field.Name}");
            }

            Console.WriteLine("Свойства:");
            foreach (PropertyInfo prop in type.GetProperties())
            {
                Console.WriteLine($"{prop.DeclaringType} {prop.PropertyType} {prop.Name}");
            }
        }
        private static void GetParameterInfo(ParameterInfo[] parameters)
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                Console.Write($"{parameters[i].ParameterType.Name} {parameters[i].Name}");

                if (i < parameters.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine(")");
        }
    }
}
