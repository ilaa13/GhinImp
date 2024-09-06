namespace GhinImp;

// Класс для управления группой персонажей
public class CharacterGroup 
{
    private List<Character> _characters;
    public CharacterGroup()
    {
        
        _characters = new List<Character>();
    }

    // Метод для добавления персонажей
    public void AddCharacter(string name, string element, int attackPower, params Skill[] skills)
    {
        var character = new Character(name, element, attackPower, skills.ToList());
        _characters.Add(character);
    }

    // Метод для фильтрации персонажей по критерию
    public IEnumerable<Character> FilterCharacters(Func<Character, bool> criteria)
    {
        return _characters.Where(x => criteria(x));
    }

    // Метод для сортировки персонажей по имени
    public IEnumerable<Character> SortCharactersByName()
    {
        return _characters.OrderByDescending(c => c.Name);
    }

    // Метод для подсчета количества персонажей определенного элемента
    public int CountCharactersByElement(string element)
    {
        return _characters.Count(c => c.Element == element);
    }

    // Метод для получения персонажа с наибольшей атакой
    public Character GetStrongestCharacter()
    {
        return _characters.MaxBy(c => c.AttackPower);
    }

    // Метод для поиска персонажа по имени
    public Character FindCharacterByName(string name)
    {
        return _characters.FirstOrDefault(c => c.Name == name);
    }
}