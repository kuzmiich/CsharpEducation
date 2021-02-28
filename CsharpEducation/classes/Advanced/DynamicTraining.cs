using Education.interfaces;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Education.classes.Advanced
{
    class DynamicTraining : ITask
    {
        public static void OutTask()
        {
            Console.WriteLine("Изучение DLR - Dynamic Language Runtime\n" +
                "1.Использование dynamic переменных\n" +
                "2.ExpandoObject и DynamicObject\n" +
                "ExpandoObject - объект, который можно использовать как в js\n" +
                "DynamicObject - объект, п\n");

            // 1
            dynamic variable = 3;
            Console.WriteLine(variable);

            variable = "Привет мир"; // x - строка
            Console.WriteLine(variable);

            variable = (Name: "Evgene", Age: 19); // x - объект Person
            OutInfo(variable);

            // 2
            dynamic viewbag = new ExpandoObject();
            viewbag.Name = "Tom";
            viewbag.Age = 46;
            viewbag.Languages = new List<string> { "english", "german", "french" };
            viewbag.OutInfo = new Action(() =>
            {
                Console.WriteLine($"{viewbag.Name} - {viewbag.Age}");
                foreach (var lang in viewbag.Languages)
                    Console.WriteLine(lang);
            });

            dynamic person = new DynamicPerson();
            person.Name = "Tom";
            person.Age = 23;
            Func<int, int> Increment = delegate (int x) { person.Age += x; return person.Age; };
            person.IncrementAge = Increment;
            Console.WriteLine($"{person.Name} - {person.Age}"); // Tom - 23
            person.IncrementAge(4);
            Console.WriteLine($"{person.Name} - {person.Age}"); // Tom - 27

            // 3
            ScriptEngine engine = Python.CreateEngine();
            ScriptScope scope = engine.CreateScope();
            string pythonFilePath = @"C:\Users\ivank\source\repos\CsharpEducation\CsharpEducation\classes\Advanced\python\hello.py";
            engine.Execute("print 'hello, world'");

            engine.ExecuteFile(pythonFilePath, scope);
            dynamic function = scope.GetVariable("hello");
            function();

        }

        private static void OutInfo(dynamic variable)
        {
            Console.WriteLine(variable);
        }
    }
    class DynamicPerson : DynamicObject
    {
        public DynamicPerson(Dictionary<string, object> members)
        {
            this._members = members;
        }

        public DynamicPerson()
        {
        }
        
        private Dictionary<string, object> _members = new Dictionary<string, object>();

        // установка свойства
        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            _members[binder.Name] = value;
            return true;
        }
        // получение свойства
        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            result = null;
            if (_members.ContainsKey(binder.Name))
            {
                result = _members[binder.Name];
                return true;
            }
            return false;
        }
        // вызов метода
        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            dynamic method = _members[binder.Name];
            result = method((int)args[0]);
            return result != null;
        }
    }
}
