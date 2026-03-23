namespace FactoryMethod.Models
{
    public class AlunoRegular : Aluno
    {
        public override string Tipo()
        {
            return "Regular";
        }
    }
}