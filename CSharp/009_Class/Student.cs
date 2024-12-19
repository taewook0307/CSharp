using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    // [접근 제한자 : default = internal] class [클래스 이름]
    internal class Student
    {
        // 인스턴스 변수
        // 클래스를 이용해 생성된 인스턴스에서 사용하는 속성값(변수)
        // [접근 제한자 : default = private] 자료형 [변수명]
        private string name;
        private int age;
        private char className;

        // 생성자 : 인스턴스가 생성될 때 실행되는 메서드
        // [접근제한자] [클래스 이름]([매개변수])
        // {
        //
        // }
        internal Student(string _name, int _age, char _className)
        {
            name = _name;
            age = _age;
            className = _className;
        }
        // 정적 생성자 : static이 붙여진 생성자 => static 멤버 변수를 초기화할 때 사용
        // 매개변수 X, 접근제한자 X, 자주 사용 X
        // static [클래스 이름]()
        // {
        //
        // }
        // 해당 클래스와 관련된 요소를 처음 사용할 때 한 번만 실행됨

        // 소멸자 : 인스턴스가 소멸될 때 실행되는 메서드
        // ~[클래스 이름]()
        // {
        //
        // }
        ~Student()
        {

        }

        // 메서드
        // 클래스를 이용해 생성된 인스턴스에서 사용되는 행위(= 함수)
        // [접근 제한자 : default = private] [반환형] [메서드 이름] ([매개변수])
        // {
        //      [메서드 코드]
        // }
        public void PrintStudentInfo()
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("age : " + age);
            Console.WriteLine("className : " + className);
        }

        public string GetName()
        {
            return name;
        }
    }

    internal class StudentManager
    {
        // 클래스 변수
        // 인스턴스를 생성하지 않고 클래스 명을 이용해 사용할 수 있는 변수
        // [접근 제한자 : default = private] static 자료형 [변수명]
        private static StudentManager studentManager = null;
        private StudentManager() { }

        // 클래스 메서드
        // 인스턴스를 생성하지 않고 클래스 명을 이용해 사용할 수 있는 메서드
        // [접근 제한자 : default = private] static [반환형] [메서드 이름] ([매개변수])
        // {
        //      [메서드 코드]
        // }
        public static StudentManager GetManager()
        {
            if (studentManager == null)
            {
                studentManager = new StudentManager();
            }

            return studentManager;
        }

        public void RegistStudent(string _name, int _age, char _className)
        {
            Student newStudent = new Student(_name, _age, _className);

            allStudent.Add(newStudent);
        }
        public void RegistStudent(Student _student)
        {
            allStudent.Add(_student);
        }

        public Student FindStudent(string _name)
        {
            foreach(Student curStudent in allStudent)
            {
                if(curStudent.GetName() == _name)
                {
                    return curStudent;
                }
            }

            return null;
        }

        private List<Student> allStudent = new List<Student>();
    }
}
