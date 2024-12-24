namespace _019_Record
{
    // 불변 데이터를 정의하는데 사용
    // 값 기반으로 비교(참조 기반 X)
    // 컴파일러가 생성자, 속성, Equals(), ToString(), GetHashCode() 메소드 등을 자동으로 생성해줌
    public record Person(string firstName, string secondName);

    public record PersonalInfo(Person name, string[] phoneNum);

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Shinei", "Nouzen");
            Console.WriteLine(person);

            string[] PhoneNum = new string[2];
            PersonalInfo personInfo = new PersonalInfo(person, PhoneNum);
            PersonalInfo personInfo1 = new PersonalInfo(person, PhoneNum);

            Console.WriteLine(personInfo == personInfo1);

            // 내부 데이터를 변경 시 기존 객체의 데이터가 변경되는 것이 아니라
            // 새로운 객체를 생성하고 해당 객체를 참조하게 됨
            personInfo1.phoneNum[0] = "823-2938";
            Console.WriteLine(personInfo == personInfo1);
            Console.WriteLine(ReferenceEquals(personInfo, personInfo1));

            // with 키워드를 통해 변경할 수 없는 객체를 복사
            Person person2 = person with { firstName = "Shourei" };
            Console.WriteLine(person2);
        }
    }
}
