using Education.interfaces;
using System;
using x = System.Reflection.BindingFlags;
using y = System.Reflection.FieldAttributes;

namespace Education.classes
{
    class ObjectTraining : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine("Изучение тепа object, его полей и методов");
            object obj = new object();
            object obj1 = new object();
            object obj2 = new object();
            // Методы
            obj.ToString();
            obj.GetType();
            obj.Equals(obj1);
            obj.GetHashCode();
            object.Equals(obj1, obj2);
            object.ReferenceEquals(obj1, obj2);
            // скрытые поля

            /*var arrBindings = new List<x>//21
            {
                
            }; */
            /*Console.WriteLine(obj.GetType().GetFields(
                y.PrivateScope |
                y.Private |
                y.FamANDAssem |
                y.Assembly |
                y.Family |
                y.FamORAssem |
                y.Public |
                y.FieldAccessMask |
                y.Static |
                y.InitOnly | 
                y.Literal | 
                y.NotSerialized |
                y.HasFieldRVA |
                y.SpecialName |
                y.RTSpecialName |
                y.HasFieldMarshal |
                y.PinvokeImpl |
                y.HasDefault).Length);*/
            Console.WriteLine(obj.GetType().GetFields().Length);
            Console.WriteLine(obj.GetType().GetMembers().Length);
            var a = obj.GetType().GetProperties(
                x.Default |
                x.IgnoreCase |
                x.DeclaredOnly |
                x.Instance |
                x.Static |
                x.Public |
                x.NonPublic |
                x.FlattenHierarchy |
                x.InvokeMethod |
                x.CreateInstance |
                x.GetField |
                x.SetField |
                x.GetProperty |
                x.SetProperty |
                x.PutDispProperty |
                x.PutRefDispProperty |
                x.ExactBinding |
                x.SuppressChangeType |
                x.OptionalParamBinding |
                x.IgnoreReturn |
                x.DoNotWrapExceptions);
            Console.WriteLine(a.Length);
            foreach (var el in a)
            {
                Console.WriteLine(el);
            }
            
            var length = obj.GetType().GetFields(x.Public).Length;
            foreach (var field in obj.GetType().GetFields())
            {
                Console.WriteLine(field.Name); // 1
                Console.WriteLine(field.IsStatic); // 2
                Console.WriteLine(field.IsPublic); // 3
                Console.WriteLine(field.IsFamily); // 4
                Console.WriteLine(field.IsPrivate); // 5
                Console.WriteLine(field.IsAssembly); // 6
                Console.WriteLine(field.IsLiteral); // 7
                Console.WriteLine(field.IsInitOnly); // 8
                Console.WriteLine(field.FieldType); // 9
                Console.WriteLine(field.Attributes); // 10
                Console.WriteLine(field.CustomAttributes); // 11
                Console.WriteLine(field.DeclaringType); // 12 
                Console.WriteLine(field.IsCollectible); // 13
                Console.WriteLine(field.IsPinvokeImpl); // 14
                Console.WriteLine(field.IsSecurityCritical); // 15
                Console.WriteLine(field.IsSecuritySafeCritical); // 16
                Console.WriteLine(field.IsSpecialName); // 17
                Console.WriteLine(field.IsSecurityTransparent); // 18
                Console.WriteLine(field.IsFamilyAndAssembly); // 19
                Console.WriteLine(field.IsFamilyOrAssembly); // 20
                Console.WriteLine(field.FieldHandle); // 21
                Console.WriteLine(field.IsNotSerialized); // 22
                Console.WriteLine(field.MetadataToken); // 23
                Console.WriteLine(field.Module); // 24
                Console.WriteLine(field.MemberType); // 25
                Console.WriteLine(field.ReflectedType); // 26
            }
        }
    }
}
