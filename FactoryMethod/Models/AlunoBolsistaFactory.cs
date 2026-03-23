namespace FactoryMethod.Models
{
    public class AlunoBolsistaFactory : AlunoFactory
    {
        public override Aluno CriarAluno()
        {
            return new AlunoBolsista();
        }
    }
}