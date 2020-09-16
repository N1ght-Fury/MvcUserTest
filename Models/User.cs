namespace MVCTestFormApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Birthdate { get; set; }
        public bool Gender { get; set; }
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public int City { get; set; }
        public int TurkishGrammar { get; set; }
        public int EnglishGrammar { get; set; }
        public int RussianGrammar { get; set; }
    }
}