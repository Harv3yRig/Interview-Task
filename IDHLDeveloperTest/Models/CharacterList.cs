namespace IDHLDeveloperTest.Models
{
    public class CharacterList
    {
        public ResponseInfo Info { get; set; } = new ResponseInfo();

        public List<Character> Data { get; set; } = new List<Character>();
    }

    public class SingleCharacter
    {
        public ResponseInfo Info { get; set; } = new ResponseInfo();

        public Character Data { get; set; } = new Character();

    }
}
