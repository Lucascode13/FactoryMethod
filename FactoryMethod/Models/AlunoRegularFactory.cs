namespace FactoryMethod.Models
{
    public class AlunoRegularFactory : AlunoFactory
    {
        public override Aluno CriarAluno()
        {
            return new AlunoRegular();
        }
    }
}