namespace FactoryMethod.Models
{
    public class AlunoBolsista : Aluno
    {
        public override string Tipo()
        {
            return "Bolsista";
        }
    }
}