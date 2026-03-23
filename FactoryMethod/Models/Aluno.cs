namespace FactoryMethod.Models
{
    public abstract class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public abstract string Tipo();

        public override string ToString()
        {
            return $"{Nome} - {Idade} anos ({Tipo()})";
        }
    }
}