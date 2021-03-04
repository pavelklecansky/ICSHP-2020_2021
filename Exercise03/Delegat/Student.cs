namespace Delegat
{
    public class Student
    {
        public string Jmeno { get; }
        public int Cislo { get; }
        public Fakulta Fakulta { get; }

        public Student(string jmeno, int cislo, Fakulta fakulta)
        {
            Jmeno = jmeno;
            Cislo = cislo;
            Fakulta = fakulta;
        }

        public override string ToString()
        {
            return "Student: Jméno:" + Jmeno + " | Číslo: " + Cislo + " | Fakulta: " + Fakulta;
        }
    }
}