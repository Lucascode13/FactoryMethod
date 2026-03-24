using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using FactoryMethod.Commands;
using FactoryMethod.Models;

namespace FactoryMethod.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Aluno> Alunos { get; set; }

        private string nome;
        public string Nome
        {
            get => nome;
            set { nome = value; OnPropertyChanged(); }
        }

        private int idade;
        public int Idade
        {
            get => idade;
            set { idade = value; OnPropertyChanged(); }
        }

        private string tipoSelecionado;
        public string TipoSelecionado
        {
            get => tipoSelecionado;
            set { tipoSelecionado = value; OnPropertyChanged(); }
        }

        public ICommand CadastrarCommand { get; set; }

        public MainViewModel()
        {
            Alunos = new ObservableCollection<Aluno>();
            CadastrarCommand = new RelayCommand(Cadastrar);
        }

        private void Cadastrar()
        {
            AlunoFactory factory;

            if (TipoSelecionado == "Regular")
                factory = new AlunoRegularFactory();
            else
                factory = new AlunoBolsistaFactory();

            var aluno = factory.CriarAluno();
            aluno.Nome = Nome;
            aluno.Idade = Idade;

            Alunos.Add(aluno);

            // limpar campos
            Nome = "";
            Idade = 0;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string nome = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nome));
        }
    }
}