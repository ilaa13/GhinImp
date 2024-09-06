namespace GhinImp;

// Класс для описания навыков персонажей
public class Skill
{
    public string SkillName;
    public int Damage;
    
    public Skill(string skill, int damage)
    {
        this.SkillName = skill;
        this.Damage = damage;
    }

    // Метод для расчета урона навыка
    public int CalculateSkillDamage()
    {
        return Damage * 2;
    }
}